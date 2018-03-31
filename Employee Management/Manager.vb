Public Class Manager

    Dim Branch, Connect
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Feedbackk.PassDeets(Branch, Connect)
        Feedbackk.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Manager_Employee_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Intra_Transfer.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Add_Intern.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Me.Close()
        Form1.Show()
    End Sub
    Public Sub PassBranch(B As String, C As Object)
        Branch = B
        Connect = C
    End Sub
End Class