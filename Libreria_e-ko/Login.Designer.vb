<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.ingresar = New System.Windows.Forms.Button()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.Mini = New System.Windows.Forms.PictureBox()
        Me.Cerrar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UsuarioBox = New System.Windows.Forms.TextBox()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.Pass = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.iniciar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pagregistro = New System.Windows.Forms.Button()
        Me.TitleBar.SuspendLayout()
        CType(Me.Mini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ingresar
        '
        Me.ingresar.BackColor = System.Drawing.Color.Transparent
        Me.ingresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ingresar.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingresar.Location = New System.Drawing.Point(493, 281)
        Me.ingresar.Name = "ingresar"
        Me.ingresar.Size = New System.Drawing.Size(135, 34)
        Me.ingresar.TabIndex = 0
        Me.ingresar.Text = "Ingresar"
        Me.ingresar.UseVisualStyleBackColor = False
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.BackColor = System.Drawing.Color.Transparent
        Me.Usuario.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.Location = New System.Drawing.Point(352, 132)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(71, 19)
        Me.Usuario.TabIndex = 1
        Me.Usuario.Text = "Usuario:"
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.TitleBar.Controls.Add(Me.Mini)
        Me.TitleBar.Controls.Add(Me.Cerrar)
        Me.TitleBar.Location = New System.Drawing.Point(649, 1)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(71, 25)
        Me.TitleBar.TabIndex = 2
        '
        'Mini
        '
        Me.Mini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Mini.Image = CType(resources.GetObject("Mini.Image"), System.Drawing.Image)
        Me.Mini.Location = New System.Drawing.Point(7, 2)
        Me.Mini.Name = "Mini"
        Me.Mini.Size = New System.Drawing.Size(24, 22)
        Me.Mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mini.TabIndex = 1
        Me.Mini.TabStop = False
        '
        'Cerrar
        '
        Me.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cerrar.Image = CType(resources.GetObject("Cerrar.Image"), System.Drawing.Image)
        Me.Cerrar.Location = New System.Drawing.Point(45, 2)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(24, 22)
        Me.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cerrar.TabIndex = 0
        Me.Cerrar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(302, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UsuarioBox
        '
        Me.UsuarioBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.UsuarioBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsuarioBox.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioBox.ForeColor = System.Drawing.Color.Black
        Me.UsuarioBox.Location = New System.Drawing.Point(459, 132)
        Me.UsuarioBox.Name = "UsuarioBox"
        Me.UsuarioBox.Size = New System.Drawing.Size(220, 17)
        Me.UsuarioBox.TabIndex = 3
        '
        'PassBox
        '
        Me.PassBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PassBox.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassBox.ForeColor = System.Drawing.Color.Black
        Me.PassBox.Location = New System.Drawing.Point(459, 180)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.Size = New System.Drawing.Size(220, 17)
        Me.PassBox.TabIndex = 5
        '
        'Pass
        '
        Me.Pass.AutoSize = True
        Me.Pass.BackColor = System.Drawing.Color.Transparent
        Me.Pass.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass.Location = New System.Drawing.Point(350, 185)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(97, 19)
        Me.Pass.TabIndex = 4
        Me.Pass.Text = "Contraseña:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(557, 220)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(93, 19)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Recordarme"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkRed
        Me.LinkLabel1.Location = New System.Drawing.Point(383, 224)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(129, 15)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Olvido su contraseña?"
        '
        'iniciar
        '
        Me.iniciar.AutoSize = True
        Me.iniciar.BackColor = System.Drawing.Color.Transparent
        Me.iniciar.Font = New System.Drawing.Font("Cambria", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iniciar.Location = New System.Drawing.Point(453, 57)
        Me.iniciar.Name = "iniciar"
        Me.iniciar.Size = New System.Drawing.Size(213, 37)
        Me.iniciar.TabIndex = 9
        Me.iniciar.Text = "Iniciar Sesion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 34)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "¿No tienes cuenta?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Crea una en libreria e-ko"
        '
        'pagregistro
        '
        Me.pagregistro.BackColor = System.Drawing.Color.Transparent
        Me.pagregistro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.pagregistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.pagregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pagregistro.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pagregistro.Location = New System.Drawing.Point(59, 281)
        Me.pagregistro.Name = "pagregistro"
        Me.pagregistro.Size = New System.Drawing.Size(135, 34)
        Me.pagregistro.TabIndex = 12
        Me.pagregistro.Text = "Registrarme"
        Me.pagregistro.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 360)
        Me.Controls.Add(Me.pagregistro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.iniciar)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.UsuarioBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.ingresar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TitleBar.ResumeLayout(False)
        CType(Me.Mini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ingresar As Button
    Friend WithEvents Usuario As Label
    Friend WithEvents TitleBar As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Mini As PictureBox
    Friend WithEvents Cerrar As PictureBox
    Friend WithEvents UsuarioBox As TextBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents Pass As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents iniciar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pagregistro As Button
End Class
