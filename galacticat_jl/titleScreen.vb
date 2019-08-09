Public Class titleScreen

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PLAY.Click
        Me.Hide()
        MainForm.ShowDialog()

    End Sub
End Class