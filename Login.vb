Public Class Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Enter the Username and Password")
        ElseIf TextBox1.Text = "User" And TextBox2.Text = "Password" Then
            Dim Main = New MainForm
            Main.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Username or Password")
        End If
    End Sub
End Class