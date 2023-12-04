Public Class frm_relat_estoque
    Private Sub frm_relat_estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta linha de código carrega dados na tabela 'FarmarioDataSet.tb_vendas_produto'. Você pode movê-la ou removê-la conforme necessário.
            Me.Tb_vendas_produtoTableAdapter.Fill(Me.FarmarioDataSet.tb_vendas_produto)
            'TODO: esta linha de código carrega dados na tabela 'FarmarioDataSet.tb_vendas'. Você pode movê-la ou removê-la conforme necessário.
            Me.Tb_vendasTableAdapter.Fill(Me.FarmarioDataSet.tb_vendas)
            'TODO: esta linha de código carrega dados na tabela 'FarmarioDataSet.tb_login'. Você pode movê-la ou removê-la conforme necessário.
            Me.Tb_loginTableAdapter.Fill(Me.FarmarioDataSet.tb_login)
            'TODO: esta linha de código carrega dados na tabela 'FarmarioDataSet.tb_produtos'. Você pode movê-la ou removê-la conforme necessário.
            Me.Tb_produtosTableAdapter.Fill(Me.FarmarioDataSet.tb_produtos)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("Erro ao gerar os dados para o relatório.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub
End Class