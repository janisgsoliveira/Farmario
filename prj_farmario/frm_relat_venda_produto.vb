Public Class frm_relat_venda_produto
    Private Sub frm_relat_venda_produto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Tb_vendaTableAdapter.Fill(Me.FarmarioDataSet.tb_venda)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("Erro ao gerar os dados para o relatório.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub btn_gerar_Click_1(sender As Object, e As EventArgs) Handles btn_gerar.Click
        Try
            If txt_pesquisa.Text = "   -" Then
                MsgBox("Insira um parâmetro para gerar o relatório.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Else
                Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("prod", txt_pesquisa.Text))
                Me.ReportViewer1.RefreshReport()

                txt_pesquisa.Clear()
            End If
        Catch ex As Exception
            MsgBox("Erro ao gerar os dados para o relatório.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub btn_reset_Click_1(sender As Object, e As EventArgs) Handles btn_reset.Click
        Try
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("prod", CStr(Nothing)))
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("Erro ao gerar os dados para o relatório.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub
End Class