Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Form1

    Public Connect

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim trimmed As String = Trim(TextBox1.Text)
        Dim check As String = "SELECT PASSWORD FROM ids where USERNAME = '" & trimmed & "'"
        ExecuteQuery1(check)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub ExecuteQuery1(query As String)
        Dim cmd As New MySqlCommand(query, Connect)
        'One connection can handle only one query.
        'Remember to close the connection once a query is fulfilled 
        'Or before jumping to another query.
        'Error handling required. -> NOT
        Connect.Open()

        cmd.ExecuteNonQuery()
        Dim Reader As MySqlDataReader
        Reader = cmd.ExecuteReader()
        'Reader.Read()

        If Reader.Read() = False Then
            MsgBox("UserName or Password is Incorrect! Please try again.", MsgBoxStyle.Critical, "Error")
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            If Reader("PASSWORD") = TextBox2.Text Then
                Dim adminQ As String = "SELECT * FROM ids where PASSWORD = '" & TextBox2.Text & "'"
                Connect.Close()
                ExecuteQuery(adminQ)
            Else
                MsgBox("Password is Incorrect! Please try again.", MsgBoxStyle.Critical, "Error")
                TextBox2.Text = ""
            End If

        End If
        Connect.Close()
    End Sub

    Private Sub ExecuteQuery(query As String)
        Dim deets(9) As String
        Dim cmd As New MySqlCommand(query, Connect)
        'Error handling required. -> NOT
        Connect.Open()
        cmd.ExecuteNonQuery()
        Dim Reader As MySqlDataReader
        Reader = cmd.ExecuteReader()
        Reader.Read()
        If Reader("DESIGNATION") = "Admin" Then
            Form2.Show()
        ElseIf Reader("DESIGNATION") = "Manager" Then
            Manager.PassBranch(Reader("BRANCH"), Connect)
            Manager.Show()
        ElseIf Reader("DESIGNATION") = "HR" Then
            Manager.Show() ' Is a HR.
        Else
            deets(0) = Reader("ID")
            deets(1) = Reader("NAME")
            deets(2) = Reader("DESIGNATION")
            deets(3) = Convert.ToString(Reader("BRANCH"))
            deets(4) = Reader("USERNAME")
            deets(5) = Convert.ToString(Reader("ADDRESS"))
            deets(6) = Reader("PH.NO")
            deets(7) = Convert.ToString(Reader("FEEDBACK"))
            deets(8) = Reader("SALARY")
            Regular_Employee.DetailsPass(deets)
            Regular_Employee.Show()
        End If
        Me.Hide()
        Connect.Close()

    End Sub
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Pass(instance As Object)
        Connect = instance
    End Sub
End Class
