<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cadastro_produto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_produto))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.cbx_receita = New System.Windows.Forms.CheckBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.MaskedTextBox()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.txt_produto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_qtde_estoque = New System.Windows.Forms.Label()
        Me.lbl_qtde = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(70, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 28)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Tipo de Produto:"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Items.AddRange(New Object() {"", "ANTIBIÓTICO", "ANTI-INFLAMATÓRIO", "ANALGÉSICO", "DIGESTIVO", "ANTIALÉRGICO", "ANTIEMÉTICO", "ANTICONVULSIONANTE", "ANTIDEPRESSIVO", "ANTIVIRAL", "EXPECTORANTE", "VERMINOSE"})
        Me.cmb_tipo.Location = New System.Drawing.Point(72, 338)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(202, 31)
        Me.cmb_tipo.TabIndex = 3
        '
        'cbx_receita
        '
        Me.cbx_receita.AutoSize = True
        Me.cbx_receita.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbx_receita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cbx_receita.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbx_receita.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.cbx_receita.ForeColor = System.Drawing.Color.Yellow
        Me.cbx_receita.Location = New System.Drawing.Point(642, 214)
        Me.cbx_receita.Name = "cbx_receita"
        Me.cbx_receita.Size = New System.Drawing.Size(146, 50)
        Me.cbx_receita.TabIndex = 2
        Me.cbx_receita.Text = "Remédio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Controlado"
        Me.cbx_receita.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btn_cancelar.Location = New System.Drawing.Point(76, 545)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(133, 43)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btn_cadastrar.Location = New System.Drawing.Point(609, 509)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(194, 78)
        Me.btn_cadastrar.TabIndex = 6
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(70, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 28)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(70, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 28)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Qtde. a adicionar:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(306, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 28)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Produto:"
        '
        'txt_cod
        '
        Me.txt_cod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cod.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_cod.Location = New System.Drawing.Point(76, 226)
        Me.txt_cod.Mask = "999-99"
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(80, 31)
        Me.txt_cod.TabIndex = 0
        '
        'txt_qtde
        '
        Me.txt_qtde.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_qtde.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_qtde.Location = New System.Drawing.Point(76, 442)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(67, 31)
        Me.txt_qtde.TabIndex = 5
        '
        'txt_produto
        '
        Me.txt_produto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_produto.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_produto.Location = New System.Drawing.Point(312, 226)
        Me.txt_produto.Name = "txt_produto"
        Me.txt_produto.Size = New System.Drawing.Size(322, 31)
        Me.txt_produto.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(356, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 28)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Valor Unitário:"
        '
        'lbl_qtde_estoque
        '
        Me.lbl_qtde_estoque.AutoSize = True
        Me.lbl_qtde_estoque.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_qtde_estoque.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_qtde_estoque.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_qtde_estoque.Location = New System.Drawing.Point(356, 412)
        Me.lbl_qtde_estoque.Name = "lbl_qtde_estoque"
        Me.lbl_qtde_estoque.Size = New System.Drawing.Size(233, 28)
        Me.lbl_qtde_estoque.TabIndex = 49
        Me.lbl_qtde_estoque.Text = "Qtde. no Estoque:"
        '
        'lbl_qtde
        '
        Me.lbl_qtde.AutoSize = True
        Me.lbl_qtde.BackColor = System.Drawing.Color.Transparent
        Me.lbl_qtde.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.lbl_qtde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_qtde.Location = New System.Drawing.Point(357, 451)
        Me.lbl_qtde.Name = "lbl_qtde"
        Me.lbl_qtde.Size = New System.Drawing.Size(43, 23)
        Me.lbl_qtde.TabIndex = 50
        Me.lbl_qtde.Text = "---"
        '
        'txt_valor
        '
        Me.txt_valor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_valor.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_valor.Location = New System.Drawing.Point(357, 338)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(154, 31)
        Me.txt_valor.TabIndex = 4
        Me.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(834, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(366, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 31)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "R$"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_cadastro_produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(834, 612)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.lbl_qtde)
        Me.Controls.Add(Me.lbl_qtde_estoque)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.cbx_receita)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cod)
        Me.Controls.Add(Me.txt_qtde)
        Me.Controls.Add(Me.txt_produto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastro_produto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents cbx_receita As CheckBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cod As MaskedTextBox
    Friend WithEvents txt_qtde As TextBox
    Friend WithEvents txt_produto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_qtde_estoque As Label
    Friend WithEvents lbl_qtde As Label
    Friend WithEvents txt_valor As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
End Class
