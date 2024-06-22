Public Class frm_gerente
    Private Sub btn_cadastro_funcionario_Click(sender As Object, e As EventArgs) Handles btn_cadastro_funcionario.Click
        Me.Show()
        frm_cadastro_funcionario.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cadsala_Click(sender As Object, e As EventArgs) Handles btn_cadsala.Click
        Me.Show()
        frm_salas.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Show()
        frmMusica.Show()
        Me.Hide()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try

            Dim resp As MsgBoxResult
            resp = MsgBox("Deseja realmente encerrar a sessão?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Encerrar Sessão")

            If resp = MsgBoxResult.Yes Then

                Dim frmLogin As New frm_login()
                Me.Show()
                frmLogin.ShowDialog()
                Me.Hide()
            End If
        Catch ex As Exception

            MsgBox("Erro ao processar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

End Class
