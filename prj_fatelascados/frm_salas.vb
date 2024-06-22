Public Class frm_salas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim sala As String = txt_cadsala.Text
            Dim qtdePessoas As Integer
            Dim valorHr As Decimal

            ' Validação de entrada
            If String.IsNullOrWhiteSpace(sala) Then
                MsgBox("Por favor, insira o nome da sala.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            End If

            If Not Integer.TryParse(cmb_qtdepessoas.Text, qtdePessoas) Then
                MsgBox("Por favor, insira um número válido para a quantidade de pessoas.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            End If

            If Not Decimal.TryParse(txt_valorhr.Text, valorHr) Then
                MsgBox("Por favor, insira um valor horário válido.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            End If

            ' Verificação de duplicidade
            SQL = "SELECT COUNT(*) FROM tb_sala WHERE sala = '" & sala & "'"
            rs = db.Execute(SQL)

            If rs.Fields(0).Value > 0 Then
                MsgBox("A sala já está cadastrada.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            End If


            SQL = "INSERT INTO tb_sala (sala, qtde_pessoas, valor_hora) VALUES ('" & sala & "', " & qtdePessoas & ", " & valorHr & ")"
            rs = db.Execute(SQL)
            MsgBox("Dados cadastrados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            limpar_sala()

        Catch ex As Exception
            MsgBox("Erro ao gravar! " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub frm_salas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub frm_salas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_gerente.Show()
        Me.Hide()
    End Sub
End Class