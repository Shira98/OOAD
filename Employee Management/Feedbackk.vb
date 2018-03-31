Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Feedbackk

    Dim Branch, Connect

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkID As String = "SELECT * FROM ids where BRANCH = '" & Branch & "' and DESIGNATION = 'RE' and ID = '" & TextBox1.Text & "'"
        ExecuteQuery1(checkID)
        Me.Close()
    End Sub

    Private Sub ExecuteQuery1(query As String)
        Dim cmd As New MySqlCommand(query, Connect)
        Connect.Open()
        cmd.ExecuteNonQuery()
        Dim Reader As MySqlDataReader
        Reader = cmd.ExecuteReader()

        If Reader.Read() = False Then
            MsgBox("Employee doesn't exist under this branch! Please try again.", MsgBoxStyle.Critical, "Error")
            TextBox1.Text = ""
        Else
            If Reader("ID") = TextBox1.Text Then
                Dim fback As String = "UPDATE ids SET FEEDBACK ='" & RichTextBox1.Text & "' where ID = '" & TextBox1.Text & "'"
                Connect.Close()
                ExecuteQuery(fback)
            End If
        End If
        Connect.Close()
    End Sub

    Private Sub ExecuteQuery(query As String)
        Dim cmd As New MySqlCommand(query, Connect)
        Connect.Open()
        cmd.ExecuteNonQuery()
        Connect.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Manager.Show()
        Me.Close()
    End Sub

    Public Sub PassDeets(B As String, C As Object)
        Branch = B
        Connect = C
    End Sub
End Class