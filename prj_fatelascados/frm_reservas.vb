Imports System.Data.OleDb

Public Class frm_reservas

    Public caminho_banco As String = Application.StartupPath & "\banco\cadastro.mdb"
    Dim db As OleDbConnection

    Private Sub frm_reservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        CarregarQuantidadePessoas()
        CarregarSalasDisponiveis()

        ' Configuração dos DateTimePickers
        ConfigurarDateTimePickers()
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

    Private Sub ConfigurarDateTimePickers()
        ' Configuração do DateTimePicker de Entrada
        dtpEntrada.Format = DateTimePickerFormat.Custom
        dtpEntrada.CustomFormat = "HH:mm" ' Apenas horário
        dtpEntrada.ShowUpDown = True

        ' Configuração do DateTimePicker de Saída
        dtpSaida.Format = DateTimePickerFormat.Custom
        dtpSaida.CustomFormat = "HH:mm" ' Apenas horário
        dtpSaida.ShowUpDown = True
    End Sub

    Private Sub CarregarQuantidadePessoas()
        ' Limpa itens anteriores da ComboBox cmbQuantidadePessoas
        cmbQuantidadePessoas.Items.Clear()

        Try
            ' Consulta SQL para carregar as opções de quantidade de pessoas
            Dim query As String = "SELECT DISTINCT qtde_pessoas FROM tb_sala ORDER BY qtde_pessoas ASC"
            Using cmd As New OleDbCommand(query, db)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                While reader.Read()
                    cmbQuantidadePessoas.Items.Add(reader("qtde_pessoas").ToString())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar opções de quantidade de pessoas: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregarSalasDisponiveis()
        cmbSalas.Items.Clear() ' Limpar itens anteriores da ComboBox cmbSalas

        Try
            Dim qtdePessoas As Integer = CInt(cmbQuantidadePessoas.SelectedItem)

            ' Consulta SQL para carregar salas disponíveis com a quantidade de pessoas selecionada
            Dim query As String = "SELECT sala FROM tb_sala WHERE qtde_pessoas = @qtdePessoas"
            Using cmd As New OleDbCommand(query, db)
                cmd.Parameters.AddWithValue("@qtdePessoas", qtdePessoas)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                While reader.Read()
                    cmbSalas.Items.Add(reader("sala").ToString())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar salas disponíveis: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
        ' Verificar se todos os campos estão preenchidos
        If String.IsNullOrEmpty(txtNomeCliente.Text.Trim()) OrElse cmbQuantidadePessoas.SelectedItem Is Nothing OrElse
       cmbSalas.SelectedItem Is Nothing OrElse dtpEntrada.Value >= dtpSaida.Value Then
            MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Calcular diferença de tempo em minutos
        Dim diferencaMinutos As Integer = CInt((dtpSaida.Value - dtpEntrada.Value).TotalMinutes)

        ' Verificar se a diferença de tempo é maior ou igual a 59 minutos
        If diferencaMinutos < 59 Then
            MessageBox.Show("Selecione um horário de saída que seja pelo menos 1h maior que o horário de entrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Verificar se já existe uma reserva para o mesmo dia, horário e sala
        If ExisteReservaConflitante(cmbSalas.SelectedItem.ToString(), dtpEntrada.Value, dtpSaida.Value, dtpDataReserva.Value) Then
            MessageBox.Show("Não é possível fazer a reserva pois já existe uma reserva para a mesma sala, dia e horário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Implemente a lógica para reservar a sala
        Dim nomeCliente As String = txtNomeCliente.Text.Trim()
        Dim qtdePessoas As Integer = CInt(cmbQuantidadePessoas.SelectedItem)
        Dim sala As String = cmbSalas.SelectedItem.ToString()
        Dim entrada As DateTime = dtpEntrada.Value
        Dim saida As DateTime = dtpSaida.Value
        Dim dataReserva As DateTime = dtpDataReserva.Value ' Usar a data selecionada no DateTimePicker

        Dim valorHora As Decimal = ObterValorHora(sala) ' Função para obter o valor da hora da sala selecionada

        ' Calcular valor total acumulando o valor de cada hora
        Dim valorTotal As Decimal = 0
        Dim horasUtilizadas As Double = (saida - entrada).TotalHours
        For i As Integer = 1 To CInt(horasUtilizadas)
            valorTotal += valorHora
        Next

        Try
            ' Consulta SQL para inserir a reserva
            Dim query As String = "INSERT INTO tb_reserva (nome_cliente, qtde_pessoas, sala, entrada, saida, data, valor_total) " &
                         "VALUES (@nomeCliente, @qtdePessoas, @sala, @entrada, @saida, @data, @valorTotal)"
            Using cmd As New OleDbCommand(query, db)
                cmd.Parameters.AddWithValue("@nomeCliente", nomeCliente)
                cmd.Parameters.AddWithValue("@qtdePessoas", qtdePessoas)
                cmd.Parameters.AddWithValue("@sala", sala)
                cmd.Parameters.AddWithValue("@entrada", entrada.ToString("HH:mm")) ' Apenas horário de entrada
                cmd.Parameters.AddWithValue("@saida", saida.ToString("HH:mm")) ' Apenas horário de saída
                cmd.Parameters.AddWithValue("@data", dataReserva.ToString("dd/MM/yyyy")) ' Data selecionada no DateTimePicker
                cmd.Parameters.AddWithValue("@valorTotal", valorTotal)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Reserva realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpar os campos após a reserva ser realizada
                LimparCampos()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao realizar reserva: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ExisteReservaConflitante(ByVal sala As String, ByVal entrada As DateTime, ByVal saida As DateTime, ByVal dataReserva As DateTime) As Boolean
        ' Função para verificar se existe uma reserva conflitante para a mesma sala, dia e horário
        Try
            Dim query As String = "SELECT COUNT(*) FROM tb_reserva " &
                              "WHERE sala = @sala " &
                              "AND data = @data " &
                              "AND (@entrada BETWEEN entrada AND saida OR @saida BETWEEN entrada AND saida)"

            Using cmd As New OleDbCommand(query, db)
                cmd.Parameters.AddWithValue("@sala", sala)
                cmd.Parameters.AddWithValue("@data", dataReserva.ToString("dd/MM/yyyy"))
                cmd.Parameters.AddWithValue("@entrada", entrada.ToString("HH:mm"))
                cmd.Parameters.AddWithValue("@saida", saida.ToString("HH:mm"))

                Dim count As Integer = CInt(cmd.ExecuteScalar())
                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao verificar reserva conflitante: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True ' Retorna verdadeiro para prevenir a reserva em caso de erro na consulta
        End Try
    End Function


    Private Function ExisteReservaConflitante(ByVal sala As String, ByVal entrada As DateTime, ByVal saida As DateTime) As Boolean
        ' Função para verificar se existe uma reserva conflitante para a mesma sala, dia e horário
        Try
            Dim query As String = "SELECT COUNT(*) FROM tb_reserva " &
                              "WHERE sala = @sala " &
                              "AND data = @data " &
                              "AND (@entrada BETWEEN entrada AND saida OR @saida BETWEEN entrada AND saida)"

            Using cmd As New OleDbCommand(query, db)
                cmd.Parameters.AddWithValue("@sala", sala)
                cmd.Parameters.AddWithValue("@data", entrada.ToString("dd/MM/yyyy"))
                cmd.Parameters.AddWithValue("@entrada", entrada.ToString("HH:mm"))
                cmd.Parameters.AddWithValue("@saida", saida.ToString("HH:mm"))

                Dim count As Integer = CInt(cmd.ExecuteScalar())
                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao verificar reserva conflitante: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True ' Retorna verdadeiro para prevenir a reserva em caso de erro na consulta
        End Try
    End Function

    Private Sub LimparCampos()
        ' Limpar todos os campos após a reserva ser realizada
        txtNomeCliente.Clear()
        cmbQuantidadePessoas.SelectedIndex = -1
        cmbSalas.Items.Clear()
        dtpEntrada.Value = DateTime.Now
        dtpSaida.Value = DateTime.Now
        dtpDataReserva.Value = DateTime.Now
    End Sub

    Private Function ObterValorHora(ByVal sala As String) As Decimal
        ' Função para obter o valor da hora da sala selecionada
        Dim valorHora As Decimal = 0

        Try
            ' Consulta SQL para obter o valor da hora da sala
            Dim query As String = "SELECT valor_hora FROM tb_sala WHERE sala = @sala"
            Using cmd As New OleDbCommand(query, db)
                cmd.Parameters.AddWithValue("@sala", sala)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    valorHora = Convert.ToDecimal(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao obter valor da hora da sala: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return valorHora
    End Function

    Private Sub cmbQuantidadePessoas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQuantidadePessoas.SelectedIndexChanged
        CarregarSalasDisponiveis()
    End Sub

    Private Sub frm_reservas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_atendente.Show()
        Me.Hide()
    End Sub
End Class
