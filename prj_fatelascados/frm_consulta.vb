Imports System.Data.OleDb

Public Class frm_consulta
    ' Conexão com o banco de dados
    Public caminho_banco As String = Application.StartupPath & "\banco\cadastro.mdb"
    Dim db As OleDbConnection

    Private Sub frm_consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub conectar_banco()
        Try
            db = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & caminho_banco)
            db.Open()
            MsgBox("Conexão bem sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btnBuscarReserva_Click(sender As Object, e As EventArgs) Handles btnBuscarReserva.Click
        Try
            ' Verificar se o campo Nome do Cliente está vazio
            If String.IsNullOrEmpty(txtNomeCliente.Text) Then
                MsgBox("Por favor, insira o nome do cliente.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Return
            End If

            ' Consultar o banco de dados pelo Nome do Cliente
            Dim SQL As String = "SELECT * FROM tb_reserva WHERE nome_cliente LIKE '%" & txtNomeCliente.Text & "%'"
            Dim cmd As New OleDbCommand(SQL, db)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            ' Verificar se a reserva foi encontrada
            If reader.HasRows Then
                reader.Read()
                ' Preencher os campos com as informações da reserva
                txtNomeCliente.Text = reader("nome_cliente").ToString()
                txtQtdePessoas.Text = reader("qtde_pessoas").ToString()
                txtSala.Text = reader("sala").ToString()
                txtEntrada.Text = DateTime.Parse(reader("entrada").ToString()).ToString("HH:mm")
                txtSaida.Text = DateTime.Parse(reader("saida").ToString()).ToString("HH:mm")
                txtData.Text = DateTime.Parse(reader("data").ToString()).ToString("dd/MM/yyyy")
                txtValorTotal.Text = "R$ " & Convert.ToDecimal(reader("valor_total")).ToString("N2")
            Else
                MsgBox("Reserva não encontrada.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_campos()
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Erro ao buscar reserva: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btnEditarReserva_Click(sender As Object, e As EventArgs) Handles btnEditarReserva.Click
        Try
            ' Verificar se todos os campos estão preenchidos
            If String.IsNullOrEmpty(txtNomeCliente.Text) OrElse
               String.IsNullOrEmpty(txtQtdePessoas.Text) OrElse
               String.IsNullOrEmpty(txtSala.Text) OrElse
               String.IsNullOrEmpty(txtEntrada.Text) OrElse
               String.IsNullOrEmpty(txtSaida.Text) OrElse
               String.IsNullOrEmpty(txtData.Text) Then
                MsgBox("Por favor, preencha todos os campos.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Return
            End If

            ' Atualizar os dados da reserva no banco de dados
            Dim SQL As String = "UPDATE tb_reserva SET " &
                                "qtde_pessoas = @qtdePessoas, " &
                                "sala = @sala, " &
                                "entrada = @entrada, " &
                                "saida = @saida, " &
                                "data = @data, " &
                                "valor_total = @valorTotal " &
                                "WHERE nome_cliente = @nomeCliente"
            Dim cmd As New OleDbCommand(SQL, db)
            cmd.Parameters.AddWithValue("@qtdePessoas", txtQtdePessoas.Text)
            cmd.Parameters.AddWithValue("@sala", txtSala.Text)
            cmd.Parameters.AddWithValue("@entrada", DateTime.Parse(txtEntrada.Text).ToString("HH:mm"))
            cmd.Parameters.AddWithValue("@saida", DateTime.Parse(txtSaida.Text).ToString("HH:mm"))
            cmd.Parameters.AddWithValue("@data", DateTime.Parse(txtData.Text).ToString("dd/MM/yyyy"))
            cmd.Parameters.AddWithValue("@valorTotal", Convert.ToDecimal(txtValorTotal.Text.Replace("R$", "").Trim()))
            cmd.Parameters.AddWithValue("@nomeCliente", txtNomeCliente.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Reserva atualizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao atualizar reserva: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btnExcluirReserva_Click(sender As Object, e As EventArgs) Handles btnExcluirReserva.Click
        Try
            ' Confirmar exclusão
            Dim resp As MsgBoxResult = MsgBox("Deseja realmente excluir a reserva do cliente: " & txtNomeCliente.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
            If resp = MsgBoxResult.Yes Then
                ' Excluir a reserva do banco de dados
                Dim SQL As String = "DELETE FROM tb_reserva WHERE nome_cliente = @nomeCliente"
                Dim cmd As New OleDbCommand(SQL, db)
                cmd.Parameters.AddWithValue("@nomeCliente", txtNomeCliente.Text)
                cmd.ExecuteNonQuery()

                MsgBox("Reserva excluída com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_campos()
            End If
        Catch ex As Exception
            MsgBox("Erro ao excluir reserva: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub limpar_campos()
        txtNomeCliente.Text = ""
        txtQtdePessoas.Text = ""
        txtSala.Text = ""
        txtEntrada.Text = ""
        txtSaida.Text = ""
        txtData.Text = ""
        txtValorTotal.Text = ""
    End Sub

    Private Sub frm_consulta_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_atendente.Show()
        Me.Hide()
    End Sub
End Class
