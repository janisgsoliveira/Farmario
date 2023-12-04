Public Class frm_relats
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            Me.Close()
            frm_admin.Show()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Private Sub btn_gerar_Click_1(sender As Object, e As EventArgs) Handles btn_gerar.Click
        Try
            If cmb_relat.Text = "Estoque" Then
                frm_relat_estoque.ShowDialog()
            ElseIf cmb_relat.Text = "Clientes" Then
                frm_relat_clientes.ShowDialog()
            ElseIf cmb_relat.Text = "Venda (diário)" Then
                frm_relat_venda.ShowDialog()
            ElseIf cmb_relat.Text = "Venda (por produto)" Then
                frm_relat_venda_produto.ShowDialog()
            Else
                MsgBox("Escolha um tipo de relatório a ser gerado.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            End If
        Catch ex As Exception
            MsgBox("Erro ao gerar o relatório.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

End Class