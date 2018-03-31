Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Regular_Employee

    Dim Array

    Private Sub Regualr_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'View deets.
        Display_Deets.PassConn(Array)
        Display_Deets.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Me.Close()
        Form1.Show()
    End Sub

    Public Sub DetailsPass(Inst() As String)
        Array = Inst
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Update deets.
        'Print current Deets in TBs, and take those TBs as inputs after the user edits them. 
    End Sub
End Class