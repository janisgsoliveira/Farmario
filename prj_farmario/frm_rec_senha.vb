Public Class frm_rec_senha
    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            If txt_novasenha.Text = txt_repetsenha.Text Then 'Alteração de senha
                sql = "update tb_login set senha = '" & txt_novasenha.Text & "' where usuario = '" & usuario & "'"
                rs = db.Execute(sql)
                MsgBox("Senha alterada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")

                Me.Hide()

            Else 'Confirmação de nova senha
                MsgBox("As senhas novas não são iguais. " & vbCrLf & "Confirme novamente sua senha antes de alterá-la.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Erro ao efetuar a recuperação de senha.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub


    Private Sub cbx_senha_CheckStateChanged(sender As Object, e As EventArgs) Handles cbx_senha.CheckStateChanged
        Try
            If cbx_senha.Checked = True Then
                txt_novasenha.PasswordChar = ""
                txt_repetsenha.PasswordChar = ""
            Else
                txt_novasenha.PasswordChar = "•"
                txt_repetsenha.PasswordChar = "•"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class