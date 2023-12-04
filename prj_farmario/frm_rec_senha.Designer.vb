<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rec_senha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rec_senha))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_repetsenha = New System.Windows.Forms.MaskedTextBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_novasenha = New System.Windows.Forms.MaskedTextBox()
        Me.cbx_senha = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(66, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Digite novamente sua nova senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(66, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Digite sua nova senha:"
        '
        'txt_repetsenha
        '
        Me.txt_repetsenha.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_repetsenha.Location = New System.Drawing.Point(70, 205)
        Me.txt_repetsenha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_repetsenha.Name = "txt_repetsenha"
        Me.txt_repetsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_repetsenha.Size = New System.Drawing.Size(248, 31)
        Me.txt_repetsenha.TabIndex = 1
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_confirmar.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btn_confirmar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_confirmar.Location = New System.Drawing.Point(317, 286)
        Me.btn_confirmar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(153, 56)
        Me.btn_confirmar.TabIndex = 3
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FloralWhite
        Me.Button1.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(175, 308)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(65, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Confirmação de senha"
        '
        'txt_novasenha
        '
        Me.txt_novasenha.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txt_novasenha.Location = New System.Drawing.Point(70, 119)
        Me.txt_novasenha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_novasenha.Name = "txt_novasenha"
        Me.txt_novasenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_novasenha.Size = New System.Drawing.Size(248, 31)
        Me.txt_novasenha.TabIndex = 0
        '
        'cbx_senha
        '
        Me.cbx_senha.AutoSize = True
        Me.cbx_senha.Image = CType(resources.GetObject("cbx_senha.Image"), System.Drawing.Image)
        Me.cbx_senha.Location = New System.Drawing.Point(338, 118)
        Me.cbx_senha.Name = "cbx_senha"
        Me.cbx_senha.Size = New System.Drawing.Size(54, 32)
        Me.cbx_senha.TabIndex = 2
        Me.cbx_senha.UseVisualStyleBackColor = True
        '
        'frm_rec_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(498, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbx_senha)
        Me.Controls.Add(Me.txt_novasenha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_repetsenha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_rec_senha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_repetsenha As MaskedTextBox
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_novasenha As MaskedTextBox
    Friend WithEvents cbx_senha As CheckBox
End Class
