<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.Mini = New System.Windows.Forms.PictureBox()
        Me.Cerrar = New System.Windows.Forms.PictureBox()
        Me.registrarme = New System.Windows.Forms.Button()
        Me.pagingresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RegistroPassCom = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RegistroCorreo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RegistroAM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RegistroNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RegistroAP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RegistroPass = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitleBar.SuspendLayout()
        CType(Me.Mini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(281, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.TitleBar.Controls.Add(Me.Mini)
        Me.TitleBar.Controls.Add(Me.Cerrar)
        Me.TitleBar.Location = New System.Drawing.Point(649, 1)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(71, 25)
        Me.TitleBar.TabIndex = 4
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
        Me.Cerrar.Location = New System.Drawing.Point(43, 2)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(24, 22)
        Me.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cerrar.TabIndex = 0
        Me.Cerrar.TabStop = False
        '
        'registrarme
        '
        Me.registrarme.BackColor = System.Drawing.Color.Transparent
        Me.registrarme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.registrarme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.registrarme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registrarme.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrarme.Location = New System.Drawing.Point(562, 345)
        Me.registrarme.Name = "registrarme"
        Me.registrarme.Size = New System.Drawing.Size(135, 34)
        Me.registrarme.TabIndex = 14
        Me.registrarme.Text = "Registrarme"
        Me.registrarme.UseVisualStyleBackColor = False
        '
        'pagingresar
        '
        Me.pagingresar.BackColor = System.Drawing.Color.Transparent
        Me.pagingresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.pagingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pagingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pagingresar.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pagingresar.Location = New System.Drawing.Point(12, 345)
        Me.pagingresar.Name = "pagingresar"
        Me.pagingresar.Size = New System.Drawing.Size(135, 34)
        Me.pagingresar.TabIndex = 13
        Me.pagingresar.Text = "Ingresar"
        Me.pagingresar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 34)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "¿Ya tienes cuenta?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(532, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 34)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Registro"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(327, 356)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(201, 19)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "Aceptar terminos y condiciones"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'RegistroPassCom
        '
        Me.RegistroPassCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.RegistroPassCom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegistroPassCom.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroPassCom.ForeColor = System.Drawing.Color.Black
        Me.RegistroPassCom.Location = New System.Drawing.Point(508, 297)
        Me.RegistroPassCom.Name = "RegistroPassCom"
        Me.RegistroPassCom.Size = New System.Drawing.Size(200, 17)
        Me.RegistroPassCom.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(457, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Repetir contraseña:"
        '
        'RegistroCorreo
        '
        Me.RegistroCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.RegistroCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegistroCorreo.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroCorreo.ForeColor = System.Drawing.Color.Black
        Me.RegistroCorreo.Location = New System.Drawing.Point(488, 236)
        Me.RegistroCorreo.Name = "RegistroCorreo"
        Me.RegistroCorreo.Size = New System.Drawing.Size(220, 17)
        Me.RegistroCorreo.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(410, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Correo:"
        '
        'RegistroAM
        '
        Me.RegistroAM.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.RegistroAM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegistroAM.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroAM.ForeColor = System.Drawing.Color.Black
        Me.RegistroAM.Location = New System.Drawing.Point(528, 179)
        Me.RegistroAM.Name = "RegistroAM"
        Me.RegistroAM.Size = New System.Drawing.Size(180, 17)
        Me.RegistroAM.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(496, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 19)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Apellido Materno:"
        '
        'RegistroNombre
        '
        Me.RegistroNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.RegistroNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegistroNombre.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroNombre.ForeColor = System.Drawing.Color.Black
        Me.RegistroNombre.Location = New System.Drawing.Point(488, 105)
        Me.RegistroNombre.Name = "RegistroNombre"
        Me.RegistroNombre.Size = New System.Drawing.Size(220, 17)
        Me.RegistroNombre.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(457, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nombre (s):"
        '
        'RegistroAP
        '
        Me.RegistroAP.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.RegistroAP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegistroAP.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroAP.ForeColor = System.Drawing.Color.Black
        Me.RegistroAP.Location = New System.Drawing.Point(309, 179)
        Me.RegistroAP.Name = "RegistroAP"
        Me.RegistroAP.Size = New System.Drawing.Size(180, 17)
        Me.RegistroAP.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(294, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Apellido Paterno:"
        '
        'RegistroPass
        '
        Me.RegistroPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.RegistroPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegistroPass.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroPass.ForeColor = System.Drawing.Color.Black
        Me.RegistroPass.Location = New System.Drawing.Point(257, 297)
        Me.RegistroPass.Name = "RegistroPass"
        Me.RegistroPass.Size = New System.Drawing.Size(200, 17)
        Me.RegistroPass.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(224, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 19)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Contraseña:"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 400)
        Me.Controls.Add(Me.RegistroPass)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RegistroAP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RegistroAM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RegistroNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RegistroPassCom)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RegistroCorreo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.registrarme)
        Me.Controls.Add(Me.pagingresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TitleBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "c"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitleBar.ResumeLayout(False)
        CType(Me.Mini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TitleBar As Panel
    Friend WithEvents Mini As PictureBox
    Friend WithEvents Cerrar As PictureBox
    Friend WithEvents registrarme As Button
    Friend WithEvents pagingresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RegistroPassCom As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RegistroCorreo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RegistroAM As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RegistroNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RegistroAP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RegistroPass As TextBox
    Friend WithEvents Label8 As Label
End Class
