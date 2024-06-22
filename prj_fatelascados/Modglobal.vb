Imports System.Data.OleDb
Module Modglobal
    Public diretorio, SQL, aux_cpf, resp As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public caminho_banco = Application.StartupPath & "\banco\cadastro.mdb"
    Public cont As Integer
    Public log_usuario, log_senha, nomeCliente As String
    Public quantidade As Integer


    Sub conectar_banco()
        'String de Conexão ADO Banco de Dados Access
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & caminho_banco)
            MsgBox("Conexão bem sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        Catch ex As Exception
            MsgBox("Erro ao conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_cadastro()
        Try
            With frm_cadastro_funcionario

                .txt_cpf.Clear()
                .txt_nome.Clear()
                .cmb_data_nasc.Value = Now
                .txt_fone.Clear()
                .txt_email.Clear()
                .txt_login.Clear()
                .txt_senha.Clear()
                .img_foto.Load(Application.StartupPath & "\fotos\nova_foto.png")
                .txt_cpf.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar !", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")

        End Try
    End Sub
    Sub carregar_dados()
        Try
            SQL = "select * from tb_cadastro order by nome asc"
            rs = db.Execute(SQL)
            cont = 1
            With frm_cadastro_funcionario.dgv_dados
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
    Sub carregar_tipo()
        Try
            With frm_cadastro_funcionario.cmb_tipo.Items
                .Add("CPF")
                .Add("Nome")
            End With
            frm_cadastro_funcionario.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("erro ao carregar o tipo do campo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO,")
        End Try
    End Sub
    Sub limpar_login()
        With frm_login
            .txt_usuario.Clear()
            .txt_senha.Clear()
            .txt_usuario.Focus()
        End With
    End Sub
    Sub limpar_sala()
        With frm_salas
            .txt_cadsala.Clear()
            .txt_valorhr.Clear()
            .cmb_qtdepessoas.Items.Clear()
            .txt_cadsala.Focus()
        End With
    End Sub

    Sub limpar_musicas()
        With frmMusica
            .txtId.Clear()
            .txtMusica.Clear()
            .txtCantor.Clear()
            .txtDuracao.Clear()
            .txtGenMusical.Clear()
            .txtMusica.Focus()

        End With
    End Sub
End Module