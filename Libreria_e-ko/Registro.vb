Public Class Registro
    Private Sub Mini_Click(sender As Object, e As EventArgs) Handles Mini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Application.Exit()
    End Sub
    Private Sub pagingresar_Click(sender As Object, e As EventArgs) Handles pagingresar.Click
        Me.Hide()
        Login.Show()
    End Sub
    Private Sub pagingresar_Paint(sender As Object, e As PaintEventArgs) Handles pagingresar.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = pagingresar.ClientRectangle
        myRectangle.Inflate(10, 10)
        buttonPath.AddEllipse(myRectangle)
        pagingresar.Region = New Region(buttonPath)
    End Sub

    Private Sub registrarme_Paint(sender As Object, e As PaintEventArgs) Handles registrarme.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = registrarme.ClientRectangle
        myRectangle.Inflate(10, 10)
        buttonPath.AddEllipse(myRectangle)
        registrarme.Region = New Region(buttonPath)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class