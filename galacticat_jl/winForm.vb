Public Class winForm

    Private Sub QUITbutton_Click(sender As Object, e As EventArgs) Handles QUITbutton.Click
        quit = True
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BadGuyNumber += 6
        Hide()
    End Sub

    Private Sub winForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\sounds\youWonMusic.wav", AudioPlayMode.BackgroundLoop)
    End Sub
End Class