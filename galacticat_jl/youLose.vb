Public Class youLose

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        quit = True
        Hide()
    End Sub

    Private Sub youLose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\sounds\youLostMusic.wav", AudioPlayMode.BackgroundLoop)
    End Sub
End Class