<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_farm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_farm))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_pesquisar = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_pesquisar = New System.Windows.Forms.ToolStripTextBox()
        Me.dgv_farm = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receita = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_deslogar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_farm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.cmb_pesquisar, Me.ToolStripLabel1, Me.txt_pesquisar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 186)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1198, 40)
        Me.ToolStrip1.TabIndex = 61
        Me.ToolStrip1.TabStop = True
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(294, 35)
        Me.ToolStripLabel2.Text = "Selecione o parâmetro de pesquisa:"
        '
        'cmb_pesquisar
        '
        Me.cmb_pesquisar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_pesquisar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_pesquisar.AutoToolTip = True
        Me.cmb_pesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pesquisar.Items.AddRange(New Object() {"Código", "Nome do Produto"})
        Me.cmb_pesquisar.Name = "cmb_pesquisar"
        Me.cmb_pesquisar.Size = New System.Drawing.Size(199, 40)
        Me.cmb_pesquisar.Sorted = True
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(90, 35)
        Me.ToolStripLabel1.Text = "Pesquisar:"
        '
        'txt_pesquisar
        '
        Me.txt_pesquisar.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txt_pesquisar.Name = "txt_pesquisar"
        Me.txt_pesquisar.Size = New System.Drawing.Size(335, 40)
        '
        'dgv_farm
        '
        Me.dgv_farm.AllowUserToAddRows = False
        Me.dgv_farm.AllowUserToDeleteRows = False
        Me.dgv_farm.AllowUserToResizeColumns = False
        Me.dgv_farm.AllowUserToResizeRows = False
        Me.dgv_farm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_farm.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_farm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nome, Me.quantidade, Me.valor, Me.tipo, Me.receita})
        Me.dgv_farm.Location = New System.Drawing.Point(0, 229)
        Me.dgv_farm.MultiSelect = False
        Me.dgv_farm.Name = "dgv_farm"
        Me.dgv_farm.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_farm.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_farm.RowHeadersVisible = False
        Me.dgv_farm.RowHeadersWidth = 50
        Me.dgv_farm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_farm.RowTemplate.Height = 24
        Me.dgv_farm.Size = New System.Drawing.Size(1198, 665)
        Me.dgv_farm.TabIndex = 63
        '
        'codigo
        '
        Me.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.codigo.DefaultCellStyle = DataGridViewCellStyle5
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 120
        '
        'nome
        '
        Me.nome.HeaderText = "Nome do Produto"
        Me.nome.MinimumWidth = 6
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        '
        'quantidade
        '
        Me.quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.quantidade.HeaderText = "Qtde Disponível"
        Me.quantidade.MinimumWidth = 6
        Me.quantidade.Name = "quantidade"
        Me.quantidade.ReadOnly = True
        Me.quantidade.Width = 68
        '
        'valor
        '
        Me.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.valor.HeaderText = "Valor"
        Me.valor.MinimumWidth = 6
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        Me.valor.Width = 60
        '
        'tipo
        '
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.MinimumWidth = 6
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        '
        'receita
        '
        Me.receita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.receita.HeaderText = "Remédio Controlado"
        Me.receita.MinimumWidth = 6
        Me.receita.Name = "receita"
        Me.receita.ReadOnly = True
        Me.receita.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.receita.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.receita.Width = 150
        '
        'btn_deslogar
        '
        Me.btn_deslogar.BackColor = System.Drawing.Color.Transparent
        Me.btn_deslogar.BackgroundImage = CType(resources.GetObject("btn_deslogar.BackgroundImage"), System.Drawing.Image)
        Me.btn_deslogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_deslogar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deslogar.FlatAppearance.BorderSize = 0
        Me.btn_deslogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_deslogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_deslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deslogar.Image = CType(resources.GetObject("btn_deslogar.Image"), System.Drawing.Image)
        Me.btn_deslogar.Location = New System.Drawing.Point(0, 0)
        Me.btn_deslogar.Name = "btn_deslogar"
        Me.btn_deslogar.Size = New System.Drawing.Size(116, 143)
        Me.btn_deslogar.TabIndex = 2
        Me.btn_deslogar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1198, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1056, 88)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(142, 95)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 95
        Me.PictureBox2.TabStop = False
        '
        'frm_farm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1198, 895)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_deslogar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_farm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_farm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_farm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_pesquisar As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_pesquisar As ToolStripComboBox
    Friend WithEvents dgv_farm As DataGridView
    Friend WithEvents btn_deslogar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents quantidade As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents receita As DataGridViewCheckBoxColumn
    Friend WithEvents PictureBox2 As PictureBox
End Class
