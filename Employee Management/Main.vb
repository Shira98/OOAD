Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient



Public Class Main

    Public Connect As New MySqlConnection("server=10.50.0.178;user id=Synche;database=sys; password=Shira_98;integrated security=true;")


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Form1.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LDateTime.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BLogin.Click
        Form1.Pass(Connect)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Emp_Det.Pass1(Connect)
        Emp_Det.Show()
        Me.Hide()

    End Sub



End Class