Public Class frm_login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            If String.IsNullOrEmpty(txt_user.Text) Or String.IsNullOrEmpty(txt_senha.Text) Then
                MsgBox("Preencha todos os campos.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                'Checagem de login
                sql = "select * from tb_login where usuario = '" & txt_user.Text & "' and senha = '" & txt_senha.Text & "'"
                rs = db.Execute(UCase(sql))

                'Conta não correspondente
                If rs.EOF = True Then
                    MsgBox("Usuário ou Senha incorretos.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_senha.Clear()
                    txt_user.Clear()
                    txt_user.Focus()

                Else 'Conta existente
                    If rs.Fields(6).Value = 1 Then

                        If rs.Fields(3).Value = "Supervisor" Then
                            Me.Hide() 'esconder o form de login quando logar
                            frm_admin.ShowDialog()
                            Exit Sub
                        ElseIf rs.Fields(3).Value = "Operador de Caixa" Then
                            Me.Hide() 'esconder o form de login quando logar
                            frm_operac.Show()
                        ElseIf rs.Fields(3).Value = "Farmacêutico" Then
                            Me.Hide() 'esconder o form de login quando logar
                            frm_farm.Show()
                        End If

                    Else 'Conta bloqueada
                        MsgBox("Sua conta está bloqueada." & vbCrLf & "Contate seu administrador.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "BLOQUEADO")
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro ao efetuar o login.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub lbl_recuperar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_recuperar.LinkClicked

        'Determina usuario como parametro
        usuario = InputBox("Digite seu nome de usuário:", "Recuperar Senha")

        Try
            sql = "select * from tb_login where usuario = '" & usuario & "'"
            rs = db.Execute(LCase(sql))

            'Se usuario existir, enviar mensagem com código
            If rs.EOF = False Then
                fone = rs.Fields(5).Value
                fone = fone.Replace("(", "").Replace(")", "").Replace("-", "") 'Remove os caracteres especiais do telefone para o envio do código

                'Cria um código de segurança aleatório
                Randomize()
                chave = CInt(10000 * Rnd())

                Process.Start("https://api.callmebot.com/whatsapp.php?phone=55" & fone & "&text='Olá, " & usuario & ". Seu código de recuperação de senha é: " & chave & ".&apikey=4048576")

                'Verificação de código de segurança
                Do While cod <> "" & chave & ""

                    cod = InputBox("Digite seu código de segurança (enviado para seu celular):", "Recuperar Senha")

                    If cod <> "" & chave & "" And cod <> "" Then
                        MsgBox("Código não correspondente. Tente novamente.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Erro")

                    ElseIf cod = "" Then
                        Exit Do
                    End If

                Loop

                If cod = "" Then
                    Exit Sub
                Else 'Código correspondente
                    frm_rec_senha.Show()
                End If

            ElseIf usuario = "" Then
                Exit Sub

            Else
                MsgBox("Conta Inválida.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            End If

        Catch ex As Exception
            MsgBox("Erro ao efetuar a recuperação de senha.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try

    End Sub

    Private Sub cbx_senha_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_senha.CheckedChanged
        Try
            If cbx_senha.Checked = True Then
                txt_senha.PasswordChar = ""
            Else
                txt_senha.PasswordChar = "•"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class