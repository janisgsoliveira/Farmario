<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_operac
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_operac))
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_vendas = New System.Windows.Forms.Button()
        Me.btn_deslogar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_clientes
        '
        Me.btn_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clientes.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btn_clientes.Location = New System.Drawing.Point(96, 152)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(186, 95)
        Me.btn_clientes.TabIndex = 0
        Me.btn_clientes.Text = "CADASTRO DE CLIENTES"
        Me.btn_clientes.UseVisualStyleBackColor = False
        '
        'btn_vendas
        '
        Me.btn_vendas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_vendas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_vendas.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.btn_vendas.Location = New System.Drawing.Point(96, 282)
        Me.btn_vendas.Name = "btn_vendas"
        Me.btn_vendas.Size = New System.Drawing.Size(186, 95)
        Me.btn_vendas.TabIndex = 1
        Me.btn_vendas.Text = "CADASTRO DE VENDAS"
        Me.btn_vendas.UseVisualStyleBackColor = False
        '
        'btn_deslogar
        '
        Me.btn_deslogar.BackColor = System.Drawing.Color.Transparent
        Me.btn_deslogar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deslogar.FlatAppearance.BorderSize = 0
        Me.btn_deslogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_deslogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_deslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deslogar.Image = CType(resources.GetObject("btn_deslogar.Image"), System.Drawing.Image)
        Me.btn_deslogar.Location = New System.Drawing.Point(0, 372)
        Me.btn_deslogar.Name = "btn_deslogar"
        Me.btn_deslogar.Size = New System.Drawing.Size(69, 68)
        Me.btn_deslogar.TabIndex = 7
        Me.btn_deslogar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(393, 126)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(303, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 126)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'frm_operac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(393, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_deslogar)
        Me.Controls.Add(Me.btn_vendas)
        Me.Controls.Add(Me.btn_clientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_operac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_clientes As Button
    Friend WithEvents btn_vendas As Button
    Friend WithEvents btn_deslogar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
