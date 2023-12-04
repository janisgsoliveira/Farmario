<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relat_venda_produto
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TbvendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmarioDataSet = New prj_farmario.farmarioDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Tb_vendaTableAdapter = New prj_farmario.farmarioDataSetTableAdapters.tb_vendaTableAdapter()
        Me.txt_pesquisa = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_gerar = New System.Windows.Forms.Button()
        CType(Me.TbvendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbvendaBindingSource
        '
        Me.TbvendaBindingSource.DataMember = "tb_venda"
        Me.TbvendaBindingSource.DataSource = Me.FarmarioDataSet
        '
        'FarmarioDataSet
        '
        Me.FarmarioDataSet.DataSetName = "farmarioDataSet"
        Me.FarmarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ds_venda"
        ReportDataSource1.Value = Me.TbvendaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "prj_farmario.relat_venda_produto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 63)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1496, 785)
        Me.ReportViewer1.TabIndex = 0
        '
        'Tb_vendaTableAdapter
        '
        Me.Tb_vendaTableAdapter.ClearBeforeFill = True
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.txt_pesquisa.Location = New System.Drawing.Point(341, 20)
        Me.txt_pesquisa.Mask = "999-99"
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(64, 26)
        Me.txt_pesquisa.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(29, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Defina o código que deseja gerar:"
        '
        'btn_reset
        '
        Me.btn_reset.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.btn_reset.Location = New System.Drawing.Point(576, 15)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(112, 36)
        Me.btn_reset.TabIndex = 7
        Me.btn_reset.Text = "Resetar"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_gerar
        '
        Me.btn_gerar.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.btn_gerar.Location = New System.Drawing.Point(434, 16)
        Me.btn_gerar.Name = "btn_gerar"
        Me.btn_gerar.Size = New System.Drawing.Size(122, 33)
        Me.btn_gerar.TabIndex = 6
        Me.btn_gerar.Text = "Atualizar"
        Me.btn_gerar.UseVisualStyleBackColor = True
        '
        'frm_relat_venda_produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1496, 847)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_gerar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_pesquisa)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_relat_venda_produto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Vendas"
        CType(Me.TbvendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FarmarioDataSet As farmarioDataSet
    Friend WithEvents TbvendaBindingSource As BindingSource
    Friend WithEvents Tb_vendaTableAdapter As farmarioDataSetTableAdapters.tb_vendaTableAdapter
    Friend WithEvents txt_pesquisa As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_gerar As Button
End Class
