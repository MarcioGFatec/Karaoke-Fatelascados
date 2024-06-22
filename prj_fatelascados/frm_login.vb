Public Class frm_login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        Me.Show()
        txt_usuario.Focus()

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        log_usuario = txt_usuario.Text
        log_senha = txt_senha.Text


        Try
            SQL = "SELECT * FROM tb_cadastro WHERE login = '" & log_usuario & "'"
            rs = db.Execute(SQL)

            If log_usuario = "" Or log_senha = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                limpar_login()
            ElseIf log_usuario = "ADMIN" AndAlso log_senha = "ADMIN" Then
                Me.Show()
                frm_gerente.Show()
                Me.Hide()

            ElseIf rs.EOF = True Then
                MsgBox("Usuário não cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                limpar_login()
            Else
                Dim bloqueado As Boolean = rs.Fields("bloquear").Value ' Verifica se o usuário está bloqueado
                If bloqueado Then
                    MsgBox("Usuário está bloqueado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    limpar_login()
                Else
                    SQL = "SELECT * FROM tb_cadastro WHERE login = '" & log_usuario & "' AND senha = '" & log_senha & "'"
                    rs = db.Execute(SQL)

                    If rs.EOF = True Then
                        MsgBox("Senha incorreta!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        limpar_login()
                    Else
                        MsgBox("Usuário logado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        limpar_login()
                        Me.Show()
                    frm_atendente.Show()
                    Me.Hide()

                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro ao tentar fazer login: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            limpar_login()
        End Try
    End Sub

    Private Sub txt_usuario_GotFocus(sender As Object, e As EventArgs) Handles txt_usuario.GotFocus
        If txt_usuario.Text = "Usuario" Then
            txt_usuario.Text = ""
            txt_usuario.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txt_usuario_LostFocus(sender As Object, e As EventArgs) Handles txt_usuario.LostFocus
        If txt_usuario.Text = "" Then
            txt_usuario.Text = "Usuario"
            txt_usuario.ForeColor = Color.DarkGray

        End If
    End Sub

    Private Sub txt_senha_GotFocus(sender As Object, e As EventArgs) Handles txt_senha.GotFocus
        If txt_senha.Text = "Senha" Then
            txt_senha.Text = ""
            txt_senha.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_senha_LostFocus(sender As Object, e As EventArgs) Handles txt_senha.LostFocus
        If txt_senha.Text = "" Then
            txt_senha.Text = "Senha"
            txt_senha.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txt_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_usuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_senha.Focus()
        End If

    End Sub

    Private Sub txt_senha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_senha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btn_login.PerformClick()
        End If
    End Sub

    Private Sub chk_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_senha.CheckedChanged
        If txt_senha.PasswordChar = "•" Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "•"
        End If
    End Sub


End Class
