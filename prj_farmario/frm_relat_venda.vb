Public Class frm_relat_venda
    Private Sub frm_relat_venda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Tb_vendaTableAdapter.Fill(Me.FarmarioDataSet.tb_venda)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("Erro ao gerar os dados para o relatório.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click
        Try
            If txt_data.Text = "  /  /" Then
                MsgBox("Insira um parâmetro para gerar o relatório.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Else
                Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("data", CDate(txt_data.Text)))
                Me.ReportViewer1.RefreshReport()

                txt_data.Clear()
            End If
        Catch ex As Exception
            MsgBox("Erro ao gerar os dados para o relatório.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Try
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("data", CStr(Nothing)))
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("Erro ao gerar os dados para o relatório.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

End Class