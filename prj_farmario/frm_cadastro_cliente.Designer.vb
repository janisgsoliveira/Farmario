<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_cliente))
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_datanasc = New System.Windows.Forms.DateTimePicker()
        Me.txt_tel = New System.Windows.Forms.MaskedTextBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_complemento = New System.Windows.Forms.TextBox()
        Me.cbx_local = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_nome.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_nome.Location = New System.Drawing.Point(288, 315)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(382, 31)
        Me.txt_nome.TabIndex = 1
        '
        'txt_endereco
        '
        Me.txt_endereco.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_endereco.Enabled = False
        Me.txt_endereco.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_endereco.Location = New System.Drawing.Point(52, 634)
        Me.txt_endereco.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(332, 31)
        Me.txt_endereco.TabIndex = 6
        '
        'txt_num
        '
        Me.txt_num.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_num.Enabled = False
        Me.txt_num.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_num.Location = New System.Drawing.Point(51, 717)
        Me.txt_num.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(67, 31)
        Me.txt_num.TabIndex = 7
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cpf.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_cpf.Location = New System.Drawing.Point(51, 318)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(169, 31)
        Me.txt_cpf.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(286, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(50, 602)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 28)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Endereço:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(50, 683)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 28)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Número:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(50, 392)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Telefone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(50, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 28)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "CPF:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(736, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(259, 28)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Data de Nascimento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(50, 495)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 28)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "CEP:"
        '
        'txt_cep
        '
        Me.txt_cep.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cep.Enabled = False
        Me.txt_cep.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_cep.Location = New System.Drawing.Point(51, 529)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_cep.Mask = "00000-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(110, 31)
        Me.txt_cep.TabIndex = 5
        '
        'cmb_datanasc
        '
        Me.cmb_datanasc.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.cmb_datanasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_datanasc.Location = New System.Drawing.Point(742, 317)
        Me.cmb_datanasc.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmb_datanasc.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.cmb_datanasc.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.cmb_datanasc.Name = "cmb_datanasc"
        Me.cmb_datanasc.Size = New System.Drawing.Size(144, 31)
        Me.cmb_datanasc.TabIndex = 2
        Me.cmb_datanasc.Value = New Date(1980, 1, 1, 0, 0, 0, 0)
        '
        'txt_tel
        '
        Me.txt_tel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_tel.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_tel.Location = New System.Drawing.Point(51, 426)
        Me.txt_tel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_tel.Mask = "(99) 90000-0000"
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(186, 31)
        Me.txt_tel.TabIndex = 3
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btn_cadastrar.Location = New System.Drawing.Point(786, 711)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(268, 83)
        Me.btn_cadastrar.TabIndex = 9
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btn_cancelar.Location = New System.Drawing.Point(612, 740)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(136, 54)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(426, 600)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 28)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Complemento:"
        '
        'txt_complemento
        '
        Me.txt_complemento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_complemento.Enabled = False
        Me.txt_complemento.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_complemento.Location = New System.Drawing.Point(432, 634)
        Me.txt_complemento.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(332, 31)
        Me.txt_complemento.TabIndex = 8
        '
        'cbx_local
        '
        Me.cbx_local.AutoSize = True
        Me.cbx_local.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbx_local.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbx_local.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbx_local.ForeColor = System.Drawing.Color.Yellow
        Me.cbx_local.Location = New System.Drawing.Point(334, 426)
        Me.cbx_local.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbx_local.Name = "cbx_local"
        Me.cbx_local.Size = New System.Drawing.Size(285, 32)
        Me.cbx_local.TabIndex = 4
        Me.cbx_local.Text = "Cadastrar Endereço?"
        Me.cbx_local.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1071, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'frm_cadastro_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1071, 818)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbx_local)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_complemento)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_datanasc)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_num)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.txt_nome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frm_cadastro_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents txt_num As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents cmb_datanasc As DateTimePicker
    Friend WithEvents txt_tel As MaskedTextBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_complemento As TextBox
    Friend WithEvents cbx_local As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
