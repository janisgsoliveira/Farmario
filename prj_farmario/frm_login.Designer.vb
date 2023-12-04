<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_recuperar = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.tt_usuario = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.tt_senha = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cbx_senha = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btn_login.Location = New System.Drawing.Point(158, 244)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(94, 37)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "LOGIN"
        Me.tt_senha.SetToolTip(Me.btn_login, "LOGIN")
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_senha.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_senha.Location = New System.Drawing.Point(130, 170)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(167, 31)
        Me.txt_senha.TabIndex = 1
        Me.tt_senha.SetToolTip(Me.txt_senha, "Senha")
        '
        'lbl_recuperar
        '
        Me.lbl_recuperar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_recuperar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_recuperar.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.lbl_recuperar.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_recuperar.Location = New System.Drawing.Point(126, 204)
        Me.lbl_recuperar.Name = "lbl_recuperar"
        Me.lbl_recuperar.Size = New System.Drawing.Size(180, 25)
        Me.lbl_recuperar.TabIndex = 3
        Me.lbl_recuperar.TabStop = True
        Me.lbl_recuperar.Text = "Esqueceu sua senha?"
        Me.tt_senha.SetToolTip(Me.lbl_recuperar, "Recuperar Senha")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(396, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_user.Location = New System.Drawing.Point(130, 99)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(167, 31)
        Me.txt_user.TabIndex = 0
        Me.tt_usuario.SetToolTip(Me.txt_user, "Usuário")
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(55, 69)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(83, 81)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 69
        Me.PictureBox3.TabStop = False
        Me.tt_usuario.SetToolTip(Me.PictureBox3, "Usuário")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(72, 151)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        Me.tt_senha.SetToolTip(Me.PictureBox2, "Senha")
        '
        'cbx_senha
        '
        Me.cbx_senha.AutoSize = True
        Me.cbx_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbx_senha.Image = CType(resources.GetObject("cbx_senha.Image"), System.Drawing.Image)
        Me.cbx_senha.Location = New System.Drawing.Point(314, 169)
        Me.cbx_senha.Name = "cbx_senha"
        Me.cbx_senha.Size = New System.Drawing.Size(54, 32)
        Me.cbx_senha.TabIndex = 70
        Me.cbx_senha.UseVisualStyleBackColor = False
        '
        'frm_login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(396, 292)
        Me.Controls.Add(Me.cbx_senha)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_recuperar)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_login As Button
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents lbl_recuperar As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents tt_usuario As ToolTip
    Friend WithEvents tt_senha As ToolTip
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cbx_senha As CheckBox
End Class
