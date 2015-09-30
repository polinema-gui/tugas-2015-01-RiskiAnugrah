Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MyBase.BackColor = Color.Red Then
            MyBase.BackColor = Color.Blue
        Else
            MyBase.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MyBase.BackColor = Color.White
    End Sub
End Class