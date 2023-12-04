Public Class frm_admin
    Private Sub btn_produtos_Click(sender As Object, e As EventArgs) Handles btn_produtos.Click
        Try
            frm_cadastro_produto.Show()
        Catch ex As Exception
            MsgBox("Erro ao abrir o Cadastro de Produtos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub btn_gerenciar_Click(sender As Object, e As EventArgs) Handles btn_gerenciar.Click
        Try
            frm_gerenciar.Show()
        Catch ex As Exception
            MsgBox("Erro ao abrir o Gerenciar Usuários.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub btn_relats_Click(sender As Object, e As EventArgs) Handles btn_relats.Click
        Try
            frm_relats.Show()
        Catch ex As Exception
            MsgBox("Erro ao abrir o Gerar Relatórios.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub btn_deslogar_Click(sender As Object, e As EventArgs) Handles btn_deslogar.Click
        Try
            limpar_login()
            Me.Close()
            frm_login.Show()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

End Class