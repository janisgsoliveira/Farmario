<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relat_estoque
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource11 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource12 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource13 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource14 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource15 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TbprodutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmarioDataSet = New prj_farmario.farmarioDataSet()
        Me.TbloginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmarioDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbprodutosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbvendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbvendasprodutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Tb_produtosTableAdapter = New prj_farmario.farmarioDataSetTableAdapters.tb_produtosTableAdapter()
        Me.tb_produtosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_loginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_loginTableAdapter = New prj_farmario.farmarioDataSetTableAdapters.tb_loginTableAdapter()
        Me.Tb_vendasTableAdapter = New prj_farmario.farmarioDataSetTableAdapters.tb_vendasTableAdapter()
        Me.Tb_vendas_produtoTableAdapter = New prj_farmario.farmarioDataSetTableAdapters.tb_vendas_produtoTableAdapter()
        CType(Me.TbprodutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbloginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmarioDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbprodutosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbvendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbvendasprodutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_produtosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_loginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbprodutosBindingSource
        '
        Me.TbprodutosBindingSource.DataMember = "tb_produtos"
        Me.TbprodutosBindingSource.DataSource = Me.FarmarioDataSet
        '
        'FarmarioDataSet
        '
        Me.FarmarioDataSet.DataSetName = "farmarioDataSet"
        Me.FarmarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbloginBindingSource
        '
        Me.TbloginBindingSource.DataMember = "tb_login"
        Me.TbloginBindingSource.DataSource = Me.FarmarioDataSetBindingSource
        '
        'FarmarioDataSetBindingSource
        '
        Me.FarmarioDataSetBindingSource.DataSource = Me.FarmarioDataSet
        Me.FarmarioDataSetBindingSource.Position = 0
        '
        'TbprodutosBindingSource1
        '
        Me.TbprodutosBindingSource1.DataMember = "tb_produtos"
        Me.TbprodutosBindingSource1.DataSource = Me.FarmarioDataSetBindingSource
        '
        'TbvendasBindingSource
        '
        Me.TbvendasBindingSource.DataMember = "tb_vendas"
        Me.TbvendasBindingSource.DataSource = Me.FarmarioDataSetBindingSource
        '
        'TbvendasprodutoBindingSource
        '
        Me.TbvendasprodutoBindingSource.DataMember = "tb_vendas_produto"
        Me.TbvendasprodutoBindingSource.DataSource = Me.FarmarioDataSetBindingSource
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource11.Name = "ds_produtos"
        ReportDataSource11.Value = Me.TbprodutosBindingSource
        ReportDataSource12.Name = "ds_login"
        ReportDataSource12.Value = Me.TbloginBindingSource
        ReportDataSource13.Name = "ds_clientes"
        ReportDataSource13.Value = Me.TbprodutosBindingSource1
        ReportDataSource14.Name = "ds_vendas"
        ReportDataSource14.Value = Me.TbvendasBindingSource
        ReportDataSource15.Name = "ds_vendas_produto"
        ReportDataSource15.Value = Me.TbvendasprodutoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource11)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource12)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource13)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource14)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource15)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "prj_farmario.relat_estoque.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1103, 940)
        Me.ReportViewer1.TabIndex = 0
        '
        'Tb_produtosTableAdapter
        '
        Me.Tb_produtosTableAdapter.ClearBeforeFill = True
        '
        'tb_produtosBindingSource
        '
        Me.tb_produtosBindingSource.DataMember = "tb_produtos"
        Me.tb_produtosBindingSource.DataSource = Me.FarmarioDataSet
        '
        'tb_loginBindingSource
        '
        Me.tb_loginBindingSource.DataMember = "tb_login"
        Me.tb_loginBindingSource.DataSource = Me.FarmarioDataSet
        '
        'Tb_loginTableAdapter
        '
        Me.Tb_loginTableAdapter.ClearBeforeFill = True
        '
        'Tb_vendasTableAdapter
        '
        Me.Tb_vendasTableAdapter.ClearBeforeFill = True
        '
        'Tb_vendas_produtoTableAdapter
        '
        Me.Tb_vendas_produtoTableAdapter.ClearBeforeFill = True
        '
        'frm_relat_estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 940)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_relat_estoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Estoque"
        CType(Me.TbprodutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbloginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmarioDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbprodutosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbvendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbvendasprodutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_produtosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_loginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FarmarioDataSet As farmarioDataSet
    Friend WithEvents FarmarioDataSetBindingSource As BindingSource
    Friend WithEvents TbprodutosBindingSource As BindingSource
    Friend WithEvents Tb_produtosTableAdapter As farmarioDataSetTableAdapters.tb_produtosTableAdapter
    Friend WithEvents tb_produtosBindingSource As BindingSource
    Friend WithEvents tb_loginBindingSource As BindingSource
    Friend WithEvents TbloginBindingSource As BindingSource
    Friend WithEvents Tb_loginTableAdapter As farmarioDataSetTableAdapters.tb_loginTableAdapter
    Friend WithEvents TbprodutosBindingSource1 As BindingSource
    Friend WithEvents TbvendasBindingSource As BindingSource
    Friend WithEvents Tb_vendasTableAdapter As farmarioDataSetTableAdapters.tb_vendasTableAdapter
    Friend WithEvents TbvendasprodutoBindingSource As BindingSource
    Friend WithEvents Tb_vendas_produtoTableAdapter As farmarioDataSetTableAdapters.tb_vendas_produtoTableAdapter
End Class
