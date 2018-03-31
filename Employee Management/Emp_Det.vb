Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Emp_Det
    Dim Connect

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim total As String = "SELECT BRANCH FROM ids"
        ExecuteQuery(total)
    End Sub

    Public Sub Pass1(Inst As Object)
        Connect = Inst
    End Sub

    Private Sub ExecuteQuery(query As String)
        Dim cmd As New MySqlCommand(query, Connect)
        Dim Reader As MySqlDataReader

        Connect.Open()
        cmd.ExecuteNonQuery()
        Dim C = 0, D = 0, Ms = 0, H As Int16
        H = 0
        Reader = cmd.ExecuteReader()

        While Reader.Read()
            Dim null = Convert.ToString(Reader("BRANCH"))
            If null IsNot "" Then
                If null = "Design" Then
                    D = D + 1
                ElseIf null = "MS" Then
                    Ms = Ms + 1
                ElseIf null = "Handover" Then
                    H = H + 1
                ElseIf null = "Conceptualization" Then
                    C = C + 1
                Else
                    Continue While
                End If
            End If
        End While

        'Entering values in table...
        Label7.Text = C
        Label8.Text = D
        Label9.Text = Ms
        Label10.Text = H

        Connect.Close()
    End Sub
End Class