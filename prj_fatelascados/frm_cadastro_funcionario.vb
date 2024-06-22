Public Class frm_cadastro_funcionario

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog2
                .Title = "SELECIONE UMA FOTO DO FUNCIONÁRIO"
                .InitialDirectory = Application.StartupPath & "\fotos"
                If .ShowDialog() = DialogResult.OK Then
                    diretorio = .FileName
                    img_foto.Load(diretorio)
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar a foto: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados()
        carregar_tipo()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            SQL = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)

            If rs.EOF = True Then 'Se não existir o cpf na tabela tb_cadastro
                SQL = "insert into tb_cadastro values ('" & txt_cpf.Text & "', " &
                                                "'" & txt_nome.Text & "', " &
                                                "'" & cmb_data_nasc.Value.Date & "', " &
                                                "'" & txt_fone.Text & "', " &
                                                "'" & txt_email.Text & "', " &
                                                "'" & diretorio & "', " &
                                                "'" & txt_login.Text & "', " &
                                                "'" & txt_senha.Text & "', " &
                                                "False)"
                rs = db.Execute(SQL)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Else
                SQL = "update tb_cadastro set nome='" & txt_nome.Text & "', " &
                                                    "data_nasc='" & cmb_data_nasc.Value.Date & "', " &
                                                    "fone='" & txt_fone.Text & "', " &
                                                    "email='" & txt_email.Text & "', " &
                                                    "login='" & txt_login.Text & "', " &
                                                    "senha='" & txt_senha.Text & "', " &
                                                    "foto='" & diretorio & "' where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_cadastro()
            carregar_dados()

        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            SQL = "select * from tb_cadastro where " & cmb_tipo.Text & " like '" & txt_buscar.Text & "%' order by nome asc"
            rs = db.Execute(SQL)
            cont = 1
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False 'Enquanto existir registro no banco
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    SQL = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        cmb_data_nasc.Value = rs.Fields(2).Value
                        txt_fone.Text = rs.Fields(3).Value
                        txt_email.Text = rs.Fields(4).Value
                        diretorio = rs.Fields(5).Value
                        txt_login.Text = rs.Fields(6).Value
                        txt_senha.Text = rs.Fields(7).Value
                        img_foto.Load(diretorio)
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("deseja realmente excluir o" + vbNewLine &
                                  "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "delete * from tb_cadastro where cpf='" & aux_cpf & "'"
                        rs = db.Execute(SQL)
                        limpar_cadastro()
                        carregar_dados()
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then ' A mesma coluna é usada para bloquear/desbloquear, assumindo que está na posição 5
                    aux_cpf = .CurrentRow.Cells(1).Value
                    Dim Bloqueado As Boolean = CBool(.CurrentRow.Cells("status").Value) ' Verifica se o usuário está bloqueado

                    If Bloqueado Then
                        resp = MsgBox("Deseja realmente desbloquear o" & vbNewLine &
                                      "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                        If resp = MsgBoxResult.Yes Then
                            SQL = "UPDATE tb_cadastro SET bloquear = False WHERE cpf='" & aux_cpf & "'"
                            db.Execute(SQL)
                            MsgBox("Usuário desbloqueado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")

                            ' Altera visualmente a célula na DataGridView para refletir o desbloqueio alterando o valor do CheckBox para False
                            .CurrentRow.Cells("status").Value = False
                        End If
                    Else
                        resp = MsgBox("Deseja realmente bloquear o" & vbNewLine &
                                      "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                        If resp = MsgBoxResult.Yes Then
                            SQL = "UPDATE tb_cadastro SET bloquear = True WHERE cpf='" & aux_cpf & "'"
                            db.Execute(SQL)
                            MsgBox("Usuário bloqueado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")

                            ' Altera visualmente a célula na DataGridView para refletir o bloqueio alterando o valor do CheckBox para True
                            .CurrentRow.Cells("status").Value = True
                        End If
                    End If
                End If

                Exit Sub
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Private Sub dgv_dados_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_dados.CellFormatting
        ' Verifica se a coluna é a coluna "status"
        If e.ColumnIndex = dgv_dados.Columns("status").Index Then
            ' Verifica se o valor é Booleano
            If TypeOf e.Value Is Boolean Then
                ' Define a célula como um texto descritivo
                If CBool(e.Value) Then
                    e.Value = "Bloqueada"
                    e.CellStyle.ForeColor = Color.Red ' Opcional: alterar a cor do texto para vermelho
                Else
                    e.Value = "Ativa"
                    e.CellStyle.ForeColor = Color.Green ' Opcional: alterar a cor do texto para verde
                End If
                e.FormattingApplied = True
            End If
        End If
    End Sub

    Private Sub frm_cadastro_funcionario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_gerente.Show()
        Me.Hide()
    End Sub
End Class