<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relat_clientes
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
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TbclientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmarioDataSet = New prj_farmario.farmarioDataSet()
        Me.TbloginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbprodutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbvendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbvendasprodutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_clientesTableAdapter = New prj_farmario.farmarioDataSetTableAdapters.tb_clientesTableAdapter()
        Me.Tb_loginTableAdapter = New prj_farmario.farmarioDataSetTableAdapters.tb_loginTableAdapter()
        Me.Tb_produtosTableAdapter = New prj_farmario.farmarioDataSetTableAdapters.tb_produtosTableAdapter()
        Me.Tb_vendasTableAdapter = New prj_farmario.farmarioDataSetTableAdapters.tb_vendasTableAdapter()
        Me.Tb_vendas_produtoTableAdapter = New prj_farmario.farmarioDataSetTableAdapters.tb_vendas_produtoTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.TbclientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbloginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbprodutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbvendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbvendasprodutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbclientesBindingSource
        '
        Me.TbclientesBindingSource.DataMember = "tb_clientes"
        Me.TbclientesBindingSource.DataSource = Me.FarmarioDataSet
        '
        'FarmarioDataSet
        '
        Me.FarmarioDataSet.DataSetName = "farmarioDataSet"
        Me.FarmarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbloginBindingSource
        '
        Me.TbloginBindingSource.DataMember = "tb_login"
        Me.TbloginBindingSource.DataSource = Me.FarmarioDataSet
        '
        'TbprodutosBindingSource
        '
        Me.TbprodutosBindingSource.DataMember = "tb_produtos"
        Me.TbprodutosBindingSource.DataSource = Me.FarmarioDataSet
        '
        'TbvendasBindingSource
        '
        Me.TbvendasBindingSource.DataMember = "tb_vendas"
        Me.TbvendasBindingSource.DataSource = Me.FarmarioDataSet
        '
        'TbvendasprodutoBindingSource
        '
        Me.TbvendasprodutoBindingSource.DataMember = "tb_vendas_produto"
        Me.TbvendasprodutoBindingSource.DataSource = Me.FarmarioDataSet
        '
        'Tb_clientesTableAdapter
        '
        Me.Tb_clientesTableAdapter.ClearBeforeFill = True
        '
        'Tb_loginTableAdapter
        '
        Me.Tb_loginTableAdapter.ClearBeforeFill = True
        '
        'Tb_produtosTableAdapter
        '
        Me.Tb_produtosTableAdapter.ClearBeforeFill = True
        '
        'Tb_vendasTableAdapter
        '
        Me.Tb_vendasTableAdapter.ClearBeforeFill = True
        '
        'Tb_vendas_produtoTableAdapter
        '
        Me.Tb_vendas_produtoTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource6.Name = "ds_clientes"
        ReportDataSource6.Value = Me.TbclientesBindingSource
        ReportDataSource7.Name = "ds_login"
        ReportDataSource7.Value = Me.TbloginBindingSource
        ReportDataSource8.Name = "ds_produtos"
        ReportDataSource8.Value = Me.TbprodutosBindingSource
        ReportDataSource9.Name = "ds_vendas"
        ReportDataSource9.Value = Me.TbvendasBindingSource
        ReportDataSource10.Name = "ds_vendas_produto"
        ReportDataSource10.Value = Me.TbvendasprodutoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "prj_farmario.relat_cliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1192, 854)
        Me.ReportViewer1.TabIndex = 0
        '
        'frm_relat_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 854)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_relat_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Clientes"
        CType(Me.TbclientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbloginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbprodutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbvendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbvendasprodutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FarmarioDataSet As farmarioDataSet
    Friend WithEvents TbclientesBindingSource As BindingSource
    Friend WithEvents Tb_clientesTableAdapter As farmarioDataSetTableAdapters.tb_clientesTableAdapter
    Friend WithEvents TbloginBindingSource As BindingSource
    Friend WithEvents Tb_loginTableAdapter As farmarioDataSetTableAdapters.tb_loginTableAdapter
    Friend WithEvents TbprodutosBindingSource As BindingSource
    Friend WithEvents Tb_produtosTableAdapter As farmarioDataSetTableAdapters.tb_produtosTableAdapter
    Friend WithEvents TbvendasBindingSource As BindingSource
    Friend WithEvents Tb_vendasTableAdapter As farmarioDataSetTableAdapters.tb_vendasTableAdapter
    Friend WithEvents TbvendasprodutoBindingSource As BindingSource
    Friend WithEvents Tb_vendas_produtoTableAdapter As farmarioDataSetTableAdapters.tb_vendas_produtoTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
