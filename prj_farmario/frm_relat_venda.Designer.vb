<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_relat_venda
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TbvendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmarioDataSet = New prj_farmario.farmarioDataSet()
        Me.txt_data = New System.Windows.Forms.MaskedTextBox()
        Me.btn_atualizar = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Tb_vendaTableAdapter = New prj_farmario.farmarioDataSetTableAdapters.tb_vendaTableAdapter()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'txt_data
        '
        Me.txt_data.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.txt_data.Location = New System.Drawing.Point(320, 20)
        Me.txt_data.Mask = "00/00/0000"
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(100, 26)
        Me.txt_data.TabIndex = 0
        Me.txt_data.ValidatingType = GetType(Date)
        '
        'btn_atualizar
        '
        Me.btn_atualizar.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.btn_atualizar.Location = New System.Drawing.Point(447, 15)
        Me.btn_atualizar.Name = "btn_atualizar"
        Me.btn_atualizar.Size = New System.Drawing.Size(122, 33)
        Me.btn_atualizar.TabIndex = 1
        Me.btn_atualizar.Text = "Atualizar"
        Me.btn_atualizar.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ds_venda"
        ReportDataSource1.Value = Me.TbvendaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "prj_farmario.relat_venda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 66)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1214, 789)
        Me.ReportViewer1.TabIndex = 2
        '
        'Tb_vendaTableAdapter
        '
        Me.Tb_vendaTableAdapter.ClearBeforeFill = True
        '
        'btn_reset
        '
        Me.btn_reset.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.btn_reset.Location = New System.Drawing.Point(589, 14)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(112, 36)
        Me.btn_reset.TabIndex = 3
        Me.btn_reset.Text = "Resetar"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(26, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Defina a data que deseja gerar:"
        '
        'frm_relat_venda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 855)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_atualizar)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_relat_venda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Vendas"
        CType(Me.TbvendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_data As MaskedTextBox
    Friend WithEvents btn_atualizar As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FarmarioDataSet As farmarioDataSet
    Friend WithEvents TbvendaBindingSource As BindingSource
    Friend WithEvents Tb_vendaTableAdapter As farmarioDataSetTableAdapters.tb_vendaTableAdapter
    Friend WithEvents btn_reset As Button
    Friend WithEvents Label1 As Label
End Class
