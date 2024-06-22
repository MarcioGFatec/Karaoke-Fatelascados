Imports System.Data.OleDb
Public Class frmMusica
    Private Sub frmMusica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub bntMusica_Click(sender As Object, e As EventArgs) Handles bntMusica.Click
        Try
            If String.IsNullOrEmpty(txtMusica.Text) Or
           String.IsNullOrEmpty(txtCantor.Text) Or
           String.IsNullOrEmpty(txtDuracao.Text) Or
           String.IsNullOrEmpty(txtGenMusical.Text) Then
                MsgBox("Por favor, preencha todos os campos.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Return ' Sai da sub-rotina sem continuar
            End If

            SQL = "SELECT * FROM tb_musicas WHERE musica='" & txtMusica.Text & "'"
            rs = db.Execute(SQL)

            If rs.EOF Then
                Dim novoId As Integer = gerar_id_musica()

                SQL = "INSERT INTO tb_musicas (id, musica, cantor, duracao_musica, genero_musical) VALUES (" &
                    novoId & ", " &
                    "'" & txtMusica.Text & "', " &
                    "'" & txtCantor.Text & "', " &
                    "'" & txtDuracao.Text & "', " &
                    "'" & txtGenMusical.Text & "')"
                db.Execute(SQL)

                MsgBox("Música gravada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                txtId.Text = rs.Fields("id").Value
                txtCantor.Text = rs.Fields("cantor").Value
                txtDuracao.Text = rs.Fields("duracao_musica").Value
                txtGenMusical.Text = rs.Fields("genero_musical").Value
            End If

            limpar_musicas()

        Catch ex As Exception
            MsgBox("Erro ao gravar! " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btnExcluirMusica_Click(sender As Object, e As EventArgs) Handles btnExcluirMusica.Click
        Try
            resp = MsgBox("Deseja realmente excluir a música: " & txtMusica.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")

            If resp = MsgBoxResult.Yes Then
                SQL = "DELETE FROM tb_musicas WHERE musica = '" & txtMusica.Text & "'"
                db.Execute(SQL)

                MsgBox("Música excluída com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                limpar_musicas()
            End If

        Catch ex As Exception
            MsgBox("Erro ao excluir música: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txtMusica_TextChanged(sender As Object, e As EventArgs) Handles txtMusica.TextChanged
        Try
            If String.IsNullOrEmpty(txtMusica.Text) Then
                Return
            End If

            SQL = "SELECT * FROM tb_musicas WHERE musica='" & txtMusica.Text & "'"
            rs = db.Execute(SQL)

            If rs.EOF = False Then
                txtId.Text = rs.Fields("id").Value
                txtCantor.Text = rs.Fields("cantor").Value
                txtDuracao.Text = rs.Fields("duracao_musica").Value
                txtGenMusical.Text = rs.Fields("genero_musical").Value
            Else
                txtId.Text = ""
                txtCantor.Text = ""
                txtDuracao.Text = ""
                txtGenMusical.Text = ""
            End If

        Catch ex As Exception
            MsgBox("Erro ao buscar música: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub frmMusica_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_gerente.Show()
        Me.Hide()
    End Sub

    Private Function gerar_id_musica() As Integer
        Dim sql As String = "SELECT * FROM tb_musicas ORDER BY id DESC"
        rs = db.Execute(sql)
        If rs.BOF Then ' Se a tabela não conter nenhum registro
            Return 1
        Else
            Return rs.Fields("id").Value + 1
        End If
    End Function

    Private Sub limpar_musicas()
        txtMusica.Text = ""
        txtCantor.Text = ""
        txtDuracao.Text = ""
        txtGenMusical.Text = ""
        txtId.Text = ""
    End Sub
End Class
