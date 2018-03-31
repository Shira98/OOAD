Public Class Display_Deets
    Dim array
    Private Sub Display_Deets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = array(0)
        Label5.Text = array(1)
        Label6.Text = array(2)
        Label8.Text = array(3)
        Label10.Text = array(4)
        Label12.Text = array(5)
        Label14.Text = array(6)
        Label16.Text = array(7)
        Label18.Text = array(8)
        'Connect.Close()
    End Sub

    Public Sub PassConn(I() As String)
        array = I
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Regular_Employee.Show()
        Me.Close()
    End Sub
End Class