Public Class frm_atendente
    Private Sub btn_cadastro_funcionario_Click(sender As Object, e As EventArgs) Handles btn_reserva.Click
        Me.Show()
        frm_reservas.Show()
        Me.Hide()
    End Sub

    Private Sub btn_caixa_Click(sender As Object, e As EventArgs) Handles btn_caixa.Click
        Me.Show()
        CaixaForm.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_sair_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_sair.LinkClicked
        Try

            Dim resp As MsgBoxResult
            resp = MsgBox("Deseja realmente encerrar a sessão?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Encerrar Sessão")

            If resp = MsgBoxResult.Yes Then

                Dim frmLogin As New frm_login()
                frmLogin.Show()
                Me.Hide()
            End If
        Catch ex As Exception

            MsgBox("Erro ao processar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_consulta_Click(sender As Object, e As EventArgs) Handles btn_consulta.Click
        Me.Show()
        frm_consulta.Show()
        Me.Hide()
    End Sub
End Class