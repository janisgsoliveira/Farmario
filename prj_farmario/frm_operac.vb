Public Class frm_operac
    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Try
            frm_cadastro_cliente.Show()
        Catch ex As Exception
            MsgBox("Erro ao abrir o Cadastro de Clientes.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub btn_vendas_Click(sender As Object, e As EventArgs) Handles btn_vendas.Click
        Try
            frm_cadastro_venda.Show()
        Catch ex As Exception
            MsgBox("Erro ao abrir o Caixa.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub frm_operac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_login.Hide()
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