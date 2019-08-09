Public Class MainForm


    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If Max.state = ALIVE Or Max.state = revive Then

            Max.state = ALIVE

            If e.KeyCode = Keys.Left Then
                Max.Speed.X = -Max.StartSpeed.X
                Max.FacingRight = False
            End If

            If e.KeyCode = Keys.Right Then
                Max.Speed.X = +Max.StartSpeed.X
                Max.FacingRight = True
            End If

            If e.KeyCode = Keys.Up And Max.OnFloor = True Then
                Max.Speed.Y = -Max.StartSpeed.Y
            End If
        End If

    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
            Max.Speed.X = 0
        End If

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        levelNumber = 1
        Call resetLevel()
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        TimerCounter += 1
        NumSpawnBadGuys = TimerCounter / 48

        If NumSpawnBadGuys > numBadGuys Then
            NumSpawnBadGuys = numBadGuys
        End If

        Call ScreenDraw()
        Call AnimateMax()
        Call AnimateBadGuy()
        Call MoveSprite(Max)
        Call reviveMax()
        Call checkKillBadGuy()
        Call checkKillmax()
        Call checkMilk()
        Call checkYouWin()
        Call checkYouLose()
        Call checkInvincibility()
        Call visualizeInvincibility()
        Call checkSlowTime()
        Call checkSpeedBoost()
        Call spawnPowerUps()
        Call BadGuysJump()
        Call BadGuysChangeDirection()

    End Sub

    Public Sub DrawScreenSet()
        imageOffScreen = backdrop.Picture.Clone
        PicDrawOnScreen.Left = backdrop.Position.X
        PicDrawOnScreen.Top = backdrop.Position.Y
        PicDrawOnScreen.Width = backdrop.Width
        PicDrawOnScreen.Height = backdrop.Height

    End Sub

    Public Sub ScreenDraw()
        Dim index As Integer

        g = PicDrawOnScreen.CreateGraphics
        offG = Graphics.FromImage(imageOffScreen)
        Call BackgroundDraw()


        Call GuyDraw(Max)


        If milk.state = ALIVE Then
            Call GuyDraw(milk)
        End If

        If invincibilitySpawned = True Then
            Call GuyDraw(invicibility)
        End If

        For index = 0 To NumSpawnBadGuys
            Call GuyDraw(BadGuys(index))
        Next index

        If slowTimeSpawned = True Then
            Call GuyDraw(timeSlower)
        End If

        If Max.powerSpeedBoost = True Then
            Call GuyDraw(speedBoost)
        End If

        g.DrawImage(imageOffScreen, 0, 0)
        g.Dispose()
        offG.Dispose()



    End Sub

    Public Sub checkYouWin()
        If numBadGuysKilled > numBadGuys Then
            Timer1.Stop()
            winForm.ShowDialog()
            If quit = True Then
                Me.Close()
            End If

            levelNumber += 1

            levelText.Text = levelNumber.ToString

            'numBadGuys += 3
            Call resetLevel()
            Timer1.Start()
        End If
    End Sub

    Public Sub checkYouLose()
        If lives <= 0 Then
            Timer1.Stop()
            youLose.ShowDialog()
            If quit = True Then
                Me.Close()
            End If
            Call resetLevel()
            Timer1.Start()
        End If
    End Sub

    Public Sub resetLevel()
        Dim index As Integer
        Call LoadGuy(Max, "/pics/galacticat.png", 15, 5, 17, 319, 50)

        numBadGuys = BadGuyNumber

        For index = 0 To numBadGuys

            If index Mod 2 = 0 Then
                Call LoadGuy(BadGuys(index), "/pics/fangs.png", 10, 4, 17, 50, 50)
            Else
                Call LoadGuy(BadGuys(index), "/pics/Gatorpede.png", 10, -6, 17, 520, 50)
            End If
        Next index

        Call LoadGuy(milk, "/pics/milk.png", 1, 0, 0, 319, 300)
        Call LoadGuy(invicibility, "/pics/invincibility_power.png", 1, 0, 0, 0, 0)
        Call LoadGuy(timeSlower, "/pics/time_slower.png", 1, 0, 0, 600, 0)
        Call LoadGuy(speedBoost, "/pics/speed_boost.png", 1, 0, 0, 0, 375)


        Call LoadBackground()
        Call DrawScreenSet()
        Call SetFloors()


        Max.Speed.X = 0

        score = 0

        lives = 3

        TimerCounter = 0

        quit = False

        numBadGuysKilled = 0

        Max.powerInvicibility = False

        invicibility.state = ALIVE

        My.Computer.Audio.Play(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\sounds\music-.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Public Sub spawnPowerUps()
        Dim randomNumInvincible As Integer
        Dim randomNumTimeslower As Integer
        Dim randomNumSpeedBoost As Integer

        randomNumInvincible = Int((500 * Rnd()) + 1)

        If randomNumInvincible = 7 Then

            invincibilitySpawned = True
        End If

        randomNumTimeslower = Int((500 * Rnd()) + 1)

        If randomNumTimeslower = 6 Then
            slowTimeSpawned = True
            Max.powerTimeSlower = True
        End If

        randomNumSpeedBoost = Int((500 * Rnd()) + 1)

        If randomNumSpeedBoost = Int((500 * Rnd()) + 1) Then
            Max.powerSpeedBoost = True
        End If
    End Sub

   
End Class
