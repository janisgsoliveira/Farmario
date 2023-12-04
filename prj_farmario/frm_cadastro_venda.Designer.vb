<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cadastro_venda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_venda))
        Me.btn_adicionar = New System.Windows.Forms.Button()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.MaskedTextBox()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.txt_produto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_venda = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_farm = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_pesquisar = New System.Windows.Forms.ToolStripTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_valor_unit = New System.Windows.Forms.TextBox()
        Me.txt_valor_final = New System.Windows.Forms.TextBox()
        Me.txt_valor_total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rd_cartao = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_troco = New System.Windows.Forms.Label()
        Me.rd_dinheiro = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_valor_pago = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_desconto = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chk_cpf = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_desconto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_a_pagar = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_estoque = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgv_venda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_farm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_adicionar
        '
        Me.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_adicionar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_adicionar.Location = New System.Drawing.Point(327, 529)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(168, 69)
        Me.btn_adicionar.TabIndex = 4
        Me.btn_adicionar.Text = "Adicionar"
        Me.btn_adicionar.UseVisualStyleBackColor = False
        '
        'btn_finalizar
        '
        Me.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_finalizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_finalizar.Location = New System.Drawing.Point(1191, 866)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(282, 78)
        Me.btn_finalizar.TabIndex = 10
        Me.btn_finalizar.Text = "FINALIZAR"
        Me.btn_finalizar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(60, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(75, 520)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Qtde:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(54, 466)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Produto:"
        '
        'txt_cod
        '
        Me.txt_cod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cod.Location = New System.Drawing.Point(144, 409)
        Me.txt_cod.Mask = "999-99"
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(61, 26)
        Me.txt_cod.TabIndex = 2
        '
        'txt_qtde
        '
        Me.txt_qtde.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_qtde.Location = New System.Drawing.Point(142, 520)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(56, 26)
        Me.txt_qtde.TabIndex = 3
        '
        'txt_produto
        '
        Me.txt_produto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_produto.Enabled = False
        Me.txt_produto.Location = New System.Drawing.Point(142, 462)
        Me.txt_produto.Name = "txt_produto"
        Me.txt_produto.Size = New System.Drawing.Size(322, 26)
        Me.txt_produto.TabIndex = 36
        Me.txt_produto.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(3, 634)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Valor Final:"
        '
        'dgv_venda
        '
        Me.dgv_venda.AllowUserToAddRows = False
        Me.dgv_venda.AllowUserToDeleteRows = False
        Me.dgv_venda.AllowUserToResizeColumns = False
        Me.dgv_venda.AllowUserToResizeRows = False
        Me.dgv_venda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_venda.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_venda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.id, Me.Produto, Me.quant, Me.valor_unit, Me.sub_total})
        Me.dgv_venda.Location = New System.Drawing.Point(734, 205)
        Me.dgv_venda.MultiSelect = False
        Me.dgv_venda.Name = "dgv_venda"
        Me.dgv_venda.ReadOnly = True
        Me.dgv_venda.RowHeadersVisible = False
        Me.dgv_venda.RowHeadersWidth = 50
        Me.dgv_venda.RowTemplate.Height = 24
        Me.dgv_venda.Size = New System.Drawing.Size(740, 446)
        Me.dgv_venda.TabIndex = 48
        Me.dgv_venda.TabStop = False
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.HeaderText = ""
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.Width = 40
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 65
        '
        'Produto
        '
        Me.Produto.FillWeight = 24.09988!
        Me.Produto.HeaderText = "Nome"
        Me.Produto.MinimumWidth = 6
        Me.Produto.Name = "Produto"
        Me.Produto.ReadOnly = True
        '
        'quant
        '
        Me.quant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.quant.FillWeight = 97.56097!
        Me.quant.HeaderText = "Qtde"
        Me.quant.MinimumWidth = 6
        Me.quant.Name = "quant"
        Me.quant.ReadOnly = True
        Me.quant.Width = 40
        '
        'valor_unit
        '
        Me.valor_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.valor_unit.HeaderText = "Valor Unitário"
        Me.valor_unit.MinimumWidth = 6
        Me.valor_unit.Name = "valor_unit"
        Me.valor_unit.ReadOnly = True
        Me.valor_unit.Width = 50
        '
        'sub_total
        '
        Me.sub_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.sub_total.FillWeight = 178.3391!
        Me.sub_total.HeaderText = "Subtotal"
        Me.sub_total.MinimumWidth = 6
        Me.sub_total.Name = "sub_total"
        Me.sub_total.ReadOnly = True
        Me.sub_total.Width = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(42, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 19)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Valor da Compra: R$"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(20, 903)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(102, 43)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.TabStop = False
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(3, 578)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 19)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Valor unit:"
        '
        'dgv_farm
        '
        Me.dgv_farm.AllowUserToAddRows = False
        Me.dgv_farm.AllowUserToDeleteRows = False
        Me.dgv_farm.AllowUserToResizeColumns = False
        Me.dgv_farm.AllowUserToResizeRows = False
        Me.dgv_farm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_farm.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_farm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.codigo, Me.nome, Me.valor})
        Me.dgv_farm.Location = New System.Drawing.Point(8, 46)
        Me.dgv_farm.MultiSelect = False
        Me.dgv_farm.Name = "dgv_farm"
        Me.dgv_farm.ReadOnly = True
        Me.dgv_farm.RowHeadersVisible = False
        Me.dgv_farm.RowHeadersWidth = 50
        Me.dgv_farm.RowTemplate.Height = 24
        Me.dgv_farm.Size = New System.Drawing.Size(650, 326)
        Me.dgv_farm.TabIndex = 64
        Me.dgv_farm.TabStop = False
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.FillWeight = 146.1538!
        Me.Column3.HeaderText = ""
        Me.Column3.Image = CType(resources.GetObject("Column3.Image"), System.Drawing.Image)
        Me.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column3.Width = 40
        '
        'codigo
        '
        Me.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.codigo.Width = 65
        '
        'nome
        '
        Me.nome.HeaderText = "Nome do Produto"
        Me.nome.MinimumWidth = 6
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        Me.nome.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'valor
        '
        Me.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.valor.FillWeight = 53.84616!
        Me.valor.HeaderText = "Valor"
        Me.valor.MinimumWidth = 6
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        Me.valor.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.valor.Width = 50
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_pesquisar})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(327, 375)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(328, 36)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.TabStop = True
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(121, 25)
        Me.ToolStripLabel1.Text = "Pesquisar por Nome:"
        '
        'txt_pesquisar
        '
        Me.txt_pesquisar.AutoSize = False
        Me.txt_pesquisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_pesquisar.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txt_pesquisar.Name = "txt_pesquisar"
        Me.txt_pesquisar.Size = New System.Drawing.Size(200, 36)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1490, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Consolas", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(144, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(418, 42)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "LISTAGEM DE PRODUTOS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Consolas", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(924, 158)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(398, 42)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "CARRINHO DE COMPRAS"
        '
        'txt_valor_unit
        '
        Me.txt_valor_unit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_valor_unit.Enabled = False
        Me.txt_valor_unit.Location = New System.Drawing.Point(142, 574)
        Me.txt_valor_unit.Name = "txt_valor_unit"
        Me.txt_valor_unit.Size = New System.Drawing.Size(56, 26)
        Me.txt_valor_unit.TabIndex = 72
        '
        'txt_valor_final
        '
        Me.txt_valor_final.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_valor_final.Enabled = False
        Me.txt_valor_final.Location = New System.Drawing.Point(142, 629)
        Me.txt_valor_final.Name = "txt_valor_final"
        Me.txt_valor_final.Size = New System.Drawing.Size(56, 26)
        Me.txt_valor_final.TabIndex = 73
        '
        'txt_valor_total
        '
        Me.txt_valor_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_valor_total.Enabled = False
        Me.txt_valor_total.Location = New System.Drawing.Point(230, 14)
        Me.txt_valor_total.Name = "txt_valor_total"
        Me.txt_valor_total.Size = New System.Drawing.Size(56, 26)
        Me.txt_valor_total.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(110, 578)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 19)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "R$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(110, 634)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 19)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "R$"
        '
        'rd_cartao
        '
        Me.rd_cartao.AutoSize = True
        Me.rd_cartao.BackColor = System.Drawing.Color.Transparent
        Me.rd_cartao.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.rd_cartao.ForeColor = System.Drawing.Color.Yellow
        Me.rd_cartao.Location = New System.Drawing.Point(6, 66)
        Me.rd_cartao.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rd_cartao.Name = "rd_cartao"
        Me.rd_cartao.Size = New System.Drawing.Size(101, 27)
        Me.rd_cartao.TabIndex = 9
        Me.rd_cartao.TabStop = True
        Me.rd_cartao.Text = "Cartão"
        Me.rd_cartao.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lbl_troco)
        Me.GroupBox1.Controls.Add(Me.rd_dinheiro)
        Me.GroupBox1.Controls.Add(Me.rd_cartao)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_valor_pago)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(734, 831)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(406, 114)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma de Pgto"
        '
        'lbl_troco
        '
        Me.lbl_troco.AutoSize = True
        Me.lbl_troco.BackColor = System.Drawing.Color.Transparent
        Me.lbl_troco.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_troco.ForeColor = System.Drawing.Color.White
        Me.lbl_troco.Location = New System.Drawing.Point(326, 72)
        Me.lbl_troco.Name = "lbl_troco"
        Me.lbl_troco.Size = New System.Drawing.Size(43, 23)
        Me.lbl_troco.TabIndex = 98
        Me.lbl_troco.Text = "---"
        Me.lbl_troco.Visible = False
        '
        'rd_dinheiro
        '
        Me.rd_dinheiro.AutoSize = True
        Me.rd_dinheiro.BackColor = System.Drawing.Color.Transparent
        Me.rd_dinheiro.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.rd_dinheiro.ForeColor = System.Drawing.Color.Yellow
        Me.rd_dinheiro.Location = New System.Drawing.Point(6, 31)
        Me.rd_dinheiro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rd_dinheiro.Name = "rd_dinheiro"
        Me.rd_dinheiro.Size = New System.Drawing.Size(123, 27)
        Me.rd_dinheiro.TabIndex = 8
        Me.rd_dinheiro.TabStop = True
        Me.rd_dinheiro.Text = "Dinheiro"
        Me.rd_dinheiro.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(237, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 23)
        Me.Label16.TabIndex = 91
        Me.Label16.Text = "Troco: "
        '
        'txt_valor_pago
        '
        Me.txt_valor_pago.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_valor_pago.Enabled = False
        Me.txt_valor_pago.Location = New System.Drawing.Point(332, 26)
        Me.txt_valor_pago.Name = "txt_valor_pago"
        Me.txt_valor_pago.Size = New System.Drawing.Size(61, 30)
        Me.txt_valor_pago.TabIndex = 7
        Me.txt_valor_pago.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(192, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 23)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Valor Pago: R$"
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cpf.Location = New System.Drawing.Point(10, 38)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(169, 30)
        Me.txt_cpf.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lbl_desconto)
        Me.GroupBox2.Controls.Add(Me.lbl_cliente)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.chk_cpf)
        Me.GroupBox2.Controls.Add(Me.txt_cpf)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox2.Location = New System.Drawing.Point(734, 658)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(406, 154)
        Me.GroupBox2.TabIndex = 83
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CPF do Cliente"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(370, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 22)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "%"
        '
        'lbl_desconto
        '
        Me.lbl_desconto.AutoSize = True
        Me.lbl_desconto.BackColor = System.Drawing.Color.Transparent
        Me.lbl_desconto.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_desconto.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_desconto.Location = New System.Drawing.Point(352, 106)
        Me.lbl_desconto.Name = "lbl_desconto"
        Me.lbl_desconto.Size = New System.Drawing.Size(20, 22)
        Me.lbl_desconto.TabIndex = 97
        Me.lbl_desconto.Text = "-"
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cliente.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_cliente.ForeColor = System.Drawing.Color.White
        Me.lbl_cliente.Location = New System.Drawing.Point(99, 106)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(36, 19)
        Me.lbl_cliente.TabIndex = 96
        Me.lbl_cliente.Text = "---"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.Yellow
        Me.Label20.Location = New System.Drawing.Point(8, 106)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 22)
        Me.Label20.TabIndex = 95
        Me.Label20.Text = "Cliente:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(252, 106)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 22)
        Me.Label18.TabIndex = 94
        Me.Label18.Text = "Desconto:"
        '
        'chk_cpf
        '
        Me.chk_cpf.AutoSize = True
        Me.chk_cpf.BackColor = System.Drawing.Color.Transparent
        Me.chk_cpf.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chk_cpf.ForeColor = System.Drawing.Color.Yellow
        Me.chk_cpf.Location = New System.Drawing.Point(247, 41)
        Me.chk_cpf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chk_cpf.Name = "chk_cpf"
        Me.chk_cpf.Size = New System.Drawing.Size(143, 23)
        Me.chk_cpf.TabIndex = 6
        Me.chk_cpf.Text = "Não Informar"
        Me.chk_cpf.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 69)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(384, 23)
        Me.Label19.TabIndex = 94
        Me.Label19.Text = "__________________________________"
        '
        'txt_desconto
        '
        Me.txt_desconto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_desconto.Enabled = False
        Me.txt_desconto.Location = New System.Drawing.Point(230, 58)
        Me.txt_desconto.Name = "txt_desconto"
        Me.txt_desconto.Size = New System.Drawing.Size(56, 26)
        Me.txt_desconto.TabIndex = 87
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(6, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(216, 19)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Descontos Aplicados: R$"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(60, 117)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(162, 19)
        Me.Label17.TabIndex = 93
        Me.Label17.Text = "Valor a pagar: R$"
        '
        'txt_a_pagar
        '
        Me.txt_a_pagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_a_pagar.Enabled = False
        Me.txt_a_pagar.Location = New System.Drawing.Point(230, 111)
        Me.txt_a_pagar.Name = "txt_a_pagar"
        Me.txt_a_pagar.Size = New System.Drawing.Size(56, 26)
        Me.txt_a_pagar.TabIndex = 92
        Me.txt_a_pagar.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1251, 49)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(240, 105)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 94
        Me.PictureBox2.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.Yellow
        Me.Label21.Location = New System.Drawing.Point(472, 466)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(153, 19)
        Me.Label21.TabIndex = 95
        Me.Label21.Text = "Qtde em estoque:"
        '
        'lbl_estoque
        '
        Me.lbl_estoque.AutoSize = True
        Me.lbl_estoque.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_estoque.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_estoque.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_estoque.Location = New System.Drawing.Point(628, 466)
        Me.lbl_estoque.Name = "lbl_estoque"
        Me.lbl_estoque.Size = New System.Drawing.Size(36, 19)
        Me.lbl_estoque.TabIndex = 98
        Me.lbl_estoque.Text = "---"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox3.CausesValidation = False
        Me.GroupBox3.Controls.Add(Me.lbl_estoque)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_valor_final)
        Me.GroupBox3.Controls.Add(Me.txt_valor_unit)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.ToolStrip1)
        Me.GroupBox3.Controls.Add(Me.dgv_farm)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btn_adicionar)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txt_cod)
        Me.GroupBox3.Controls.Add(Me.txt_qtde)
        Me.GroupBox3.Controls.Add(Me.txt_produto)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(9, 158)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(686, 674)
        Me.GroupBox3.TabIndex = 99
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txt_a_pagar)
        Me.GroupBox4.Controls.Add(Me.txt_desconto)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txt_valor_total)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox4.Location = New System.Drawing.Point(1172, 658)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(302, 154)
        Me.GroupBox4.TabIndex = 100
        Me.GroupBox4.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(-4, 77)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(306, 20)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "_________________________________"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Yellow
        Me.Label15.Location = New System.Drawing.Point(1167, 718)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(306, 20)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "_________________________________"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frm_cadastro_venda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1490, 963)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgv_venda)
        Me.Controls.Add(Me.btn_finalizar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btn_cancelar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastro_venda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_venda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_farm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_adicionar As Button
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cod As MaskedTextBox
    Friend WithEvents txt_qtde As TextBox
    Friend WithEvents txt_produto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_venda As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dgv_farm As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_pesquisar As ToolStripTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_valor_unit As TextBox
    Friend WithEvents txt_valor_final As TextBox
    Friend WithEvents txt_valor_total As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents rd_cartao As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rd_dinheiro As RadioButton
    Friend WithEvents chk_cpf As CheckBox
    Friend WithEvents txt_valor_pago As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_desconto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_a_pagar As TextBox
    Friend WithEvents lbl_desconto As Label
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_troco As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label21 As Label
    Friend WithEvents lbl_estoque As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Produto As DataGridViewTextBoxColumn
    Friend WithEvents quant As DataGridViewTextBoxColumn
    Friend WithEvents valor_unit As DataGridViewTextBoxColumn
    Friend WithEvents sub_total As DataGridViewTextBoxColumn
End Class
