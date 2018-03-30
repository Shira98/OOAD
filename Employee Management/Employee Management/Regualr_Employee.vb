Public Class Regualr_Employee
    Private Sub Regualr_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Display_Employee_Detail.Show()
        Me.Hide()
    End Sub
End Class