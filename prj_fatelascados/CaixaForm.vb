Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class CaixaForm
    Private Sub CaixaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim query As String = "SELECT * FROM tb_reserva WHERE nome_cliente = ?"
        Dim rs As Object

        Try
            rs = CreateObject("ADODB.Recordset")

            ' Preparar o comando
            Dim cmd As Object
            cmd = CreateObject("ADODB.Command")
            cmd.ActiveConnection = db
            cmd.CommandText = query
            cmd.Parameters.Append(cmd.CreateParameter("nome_cliente", 200, 1, 255, Me.textBoxNomeCliente.Text)) ' 200=adVarChar, 1=adParamInput

            ' Executar o comando e abrir o Recordset
            rs.Open(cmd, , 1, 2) ' 1=adOpenKeyset, 2=adLockPessimistic

            If Not rs.EOF Then
                ' Preenchendo os TextBox com os dados retornados do banco de dados
                Me.textBoxNomeCliente.Text = rs.Fields("nome_cliente").Value
                Dim entrada As DateTime = DateTime.Parse(rs.Fields("entrada").Value.ToString())
                Dim saida As DateTime = DateTime.Parse(rs.Fields("saida").Value.ToString())
                Dim tempoReserva As TimeSpan = saida - entrada

                ' Formatar o tempo de reserva como horas e minutos
                Me.textBoxTempoReserva.Text = String.Format("{0}h {1}m", tempoReserva.Hours, tempoReserva.Minutes)
                Me.textBoxSalaReservada.Text = rs.Fields("sala").Value.ToString()
                Me.textBoxQtdePessoas.Text = rs.Fields("qtde_pessoas").Value.ToString()

                ' Tratamento do valor total para exibição correta
                Dim valorTotal As String = rs.Fields("valor_total").Value.ToString()
                If Not valorTotal.StartsWith("R$") Then
                    valorTotal = "R$ " & valorTotal
                End If
                Me.textBoxValorPagar.Text = valorTotal
            Else
                MessageBox.Show("Reserva não encontrada!")
            End If

            rs.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao buscar a reserva: " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonConfirmarPagamento_Click(sender As Object, e As EventArgs) Handles ButtonConfirmarPagamento.Click
        Dim nomeCliente As String = Me.textBoxNomeCliente.Text.Trim()

        If String.IsNullOrEmpty(nomeCliente) Then
            MessageBox.Show("Por favor, digite o nome do cliente.")
            Return
        End If

        Dim querySelect As String = "SELECT COUNT(*) FROM tb_reserva WHERE nome_cliente = ?"
        Dim queryDelete As String = "DELETE FROM tb_reserva WHERE nome_cliente = ?"
        Dim cmdSelect As Object = Nothing
        Dim cmdDelete As Object = Nothing

        Try
            ' Verificar se o registro existe
            cmdSelect = CreateObject("ADODB.Command")
            cmdSelect.ActiveConnection = db
            cmdSelect.CommandText = querySelect
            cmdSelect.Parameters.Append(cmdSelect.CreateParameter("nome_cliente", 200, 1, 255, nomeCliente)) ' 200=adVarChar, 1=adParamInput

            Dim count As Integer = CInt(cmdSelect.Execute().Fields(0).Value)

            If count > 0 Then
                ' Registro encontrado, proceder com a deleção
                cmdDelete = CreateObject("ADODB.Command")
                cmdDelete.ActiveConnection = db
                cmdDelete.CommandText = queryDelete
                cmdDelete.Parameters.Append(cmdDelete.CreateParameter("nome_cliente", 200, 1, 255, nomeCliente)) ' 200=adVarChar, 1=adParamInput

                ' Executar o comando DELETE
                cmdDelete.Execute()

                ' Exibir mensagem de sucesso
                MessageBox.Show("Pagamento confirmado e reserva apagada com sucesso!")

                ' Limpar os TextBox após a confirmação do pagamento
                LimparCampos()
            Else
                ' Nenhum registro encontrado com o nome do cliente informado
                MessageBox.Show("Erro ao apagar a reserva ou reserva não encontrada.")
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao confirmar o pagamento: " & ex.Message)

        Finally
            ' Liberar recursos dos objetos Command
            If cmdSelect IsNot Nothing Then
                Marshal.ReleaseComObject(cmdSelect)
                cmdSelect = Nothing
            End If

            If cmdDelete IsNot Nothing Then
                Marshal.ReleaseComObject(cmdDelete)
                cmdDelete = Nothing
            End If
        End Try
    End Sub

    Private Sub LimparCampos()
        ' Limpar os TextBox após a confirmação do pagamento
        Me.textBoxNomeCliente.Clear()
        Me.textBoxTempoReserva.Clear()
        Me.textBoxSalaReservada.Clear()
        Me.textBoxQtdePessoas.Clear()
        Me.textBoxValorPagar.Clear()
    End Sub

    Public Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
    End Sub

    Private Sub CaixaForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_atendente.Show()
        Me.Hide()

    End Sub
End Class