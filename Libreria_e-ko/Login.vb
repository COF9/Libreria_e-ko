Imports System.Runtime.InteropServices
Public Class Login
    Private Sub Mini_Click(sender As Object, e As EventArgs) Handles Mini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Application.Exit()
    End Sub
#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Pass.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PassBox.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub


#End Region

    Private Sub ingresar_Click(sender As Object, e As EventArgs) Handles ingresar.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub pagregistro_Click(sender As Object, e As EventArgs) Handles pagregistro.Click
        Me.Hide()
        Registro.Show()
    End Sub
#Region "Customize Controls"
    Private Sub CustomizeComponents()
        'UsuarioBox
        UsuarioBox.AutoSize = False
        UsuarioBox.Size = New Size(220, 25)
        'PassBox
        PassBox.AutoSize = False
        PassBox.Size = New Size(220, 25)
        PassBox.UseSystemPasswordChar = True
    End Sub
    Private Sub ingresar_Paint(sender As Object, e As PaintEventArgs) Handles ingresar.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = ingresar.ClientRectangle
        myRectangle.Inflate(10, 10)
        buttonPath.AddEllipse(myRectangle)
        ingresar.Region = New Region(buttonPath)
    End Sub
    Private Sub pagregistro_Paint(sender As Object, e As PaintEventArgs) Handles pagregistro.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = pagregistro.ClientRectangle
        myRectangle.Inflate(10, 10)
        buttonPath.AddEllipse(myRectangle)
        pagregistro.Region = New Region(buttonPath)
    End Sub
#End Region
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CustomizeComponents()
    End Sub
End Class