Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New MySqlConnection("server=localhost; user=root; password=;database=biblioteca;port=3306")
        Try
            conexion.Open()
        Catch ex As Exception
            Login.Show()
            conexion.Close()
            MsgBox("Error al conectar base de datos por favor reiniciar el servidor y cargue de nuevo la aplicacion")
            Application.Exit()
        End Try
    End Sub
    Dim porcentaje As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If porcentaje < 100 Then
            ProgressBar1.Value = porcentaje
            porcentaje = porcentaje + 2
            Label1.Text = "Cargando... "
            Label2.Text = ProgressBar1.Value & " %"
        Else
            Timer1.Enabled = False
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 40
        Timer1.Enabled = True
    End Sub

End Class
