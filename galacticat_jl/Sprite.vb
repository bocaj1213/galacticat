Module Sprite
    Structure Sprite
        Dim Picture As Bitmap
        Dim CellWidth As Integer
        Dim CellHeight As Integer
        Dim CellCount As Integer
        Dim StartPosition As Point
        Dim Position As Point
        Dim Speed As Point
        Dim StartSpeed As Point
        Dim mRectangle As Rectangle
        Dim CellTop As Integer
        Dim FacingRight As Boolean
        Dim OnFloor As Boolean
        Dim radius As Integer
        Dim state As Integer
        Dim timeFlipped As Integer
        Dim powerInvicibility As Boolean
        Dim powerTimeSlower As Boolean
        Dim powerSpeedBoost As Boolean
        Dim changeCostume As Boolean
        Dim jumpCounter As Integer
        Dim DirectionCounter As Integer

    End Structure

    Public Max As Sprite
    Public numBadGuys As Integer = 6
    Public BadGuys(1000) As Sprite
    'hello world 
    Public milk As Sprite
    Public timeSlower As Sprite
    Public invicibility As Sprite
    Public speedBoost As Sprite

    Public Const gravity As Integer = 1
    Public ALIVE As Integer = 0
    Public DEAD As Integer = 1
    Public revive As Integer = 2
    Public flip As Integer = 3
    Public score As Integer
    Public lives As Integer
    Public numBadGuysKilled As Integer
    Public levelNumber As Integer
    Public NumSpawnBadGuys As Integer
    Public TimerCounter As Integer

    Public invicibilityCounter As Integer
    Public timeSlowerCounter As Integer
    Public speedBoostCounter As Integer

    Public invincibilitySpawned As Boolean
    Public quit As Boolean
    Public slowTimeSpawned As Boolean




    Public Sub LoadGuy(ByRef Guy As Sprite, ByVal picname As String, ByVal numCells As Integer, ByVal Xspeed As Integer, ByVal YSpeed As Integer, ByVal Xpos As Integer, ByVal ypos As Integer)
        Guy.Picture = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & picname)
        Guy.CellCount = numCells
        Guy.CellWidth = Guy.Picture.Width
        Guy.CellHeight = Guy.Picture.Height / Guy.CellCount
        Guy.StartPosition.X = Xpos
        Guy.StartPosition.Y = ypos
        Guy.Position.X = Guy.StartPosition.X
        Guy.Position.Y = Guy.StartPosition.Y
        Guy.Speed.X = Xspeed
        Guy.Speed.Y = Yspeed
        Guy.StartSpeed.X = Xspeed
        Guy.StartSpeed.Y = Yspeed
        Guy.mRectangle.Width = Guy.CellWidth
        Guy.mRectangle.Height = Guy.CellHeight
        Guy.mRectangle.X = Guy.Position.X
        Guy.mRectangle.Y = Guy.Position.Y
        Guy.FacingRight = True
        If Guy.CellWidth > Guy.CellHeight Then
            Guy.radius = Guy.CellWidth / 2
        Else
            Guy.radius = Guy.CellHeight / 2
        End If

        Guy.state = ALIVE

    End Sub

    Public Sub MoveSprite(ByRef Guy As Sprite)
        Guy.Speed.Y = GetVerticalSpeed(Guy)
        Guy.Position.Y += Guy.Speed.Y
        Guy.Position.X += Guy.Speed.X

        Guy.mRectangle.X = Guy.Position.X
        Guy.mRectangle.Y = Guy.Position.Y

        If Guy.Position.X > 638 + Guy.CellWidth Then
            Guy.Position.X = 0 - Guy.CellWidth
        ElseIf Guy.Position.X < 0 - Guy.CellWidth Then
            Guy.Position.X = 638 + Guy.CellWidth
        End If

        If Guy.state = ALIVE Then
            If Guy.Position.Y > Floors(1).Bottom And Guy.Position.X < 0 Then
                Guy.Position.Y = 40
                Guy.Position.X = Floors(7).Right + Guy.CellWidth
            ElseIf Guy.Position.Y > Floors(1).Bottom And Guy.Position.X > 638 Then
                Guy.Position.Y = 50
                Guy.Position.X = Floors(6).Left
            End If
        End If
    End Sub

    Public Sub GuyDraw(ByRef Guy As Sprite)
        offG.DrawImage(Guy.Picture, Guy.mRectangle, 0, Guy.CellTop, Guy.CellWidth, Guy.CellHeight, System.Drawing.GraphicsUnit.Pixel)

    End Sub

    Public Sub AnimateMax()
        Max.CellTop += Max.CellHeight

        If Max.state = ALIVE Then
            If Max.Speed.X > 0 And Max.Speed.Y = 0 And Max.OnFloor = True Then
                If Max.CellTop > Max.CellHeight * 2 Then
                    Max.CellTop = 0
                End If
            ElseIf Max.Speed.X < 0 And Max.Speed.Y = 0 And Max.OnFloor = True Then
                If Max.CellTop < Max.CellHeight * 3 Or Max.CellTop > Max.CellHeight * 5 Then
                    Max.CellTop = Max.CellHeight * 3
                End If
            ElseIf Max.Speed.X = 0 And Max.Speed.Y = 0 And Max.OnFloor = True Then
                If Max.FacingRight = True Then
                    Max.CellTop = Max.CellHeight * 6
                Else
                    Max.CellTop = Max.CellHeight * 7
                End If
            ElseIf Max.OnFloor = False Then
                If Max.FacingRight = True Then
                    Max.CellTop = Max.CellHeight * 8
                Else
                    Max.CellTop = Max.CellHeight * 9
                End If
            End If

        ElseIf Max.state = DEAD Then
            If Max.CellTop > Max.CellHeight * 13 Then
                Max.CellTop = Max.CellHeight * 12
            End If
        ElseIf Max.state = revive Then
            Max.CellTop = Max.CellHeight * 14
        End If
    End Sub

    Public Function GetVerticalSpeed(ByRef Guy As Sprite)
        Dim NextVerticalStep As Integer
        NextVerticalStep = Guy.Speed.Y + gravity
        If Guy.state <> DEAD Then
            Dim index As Integer
            Guy.OnFloor = False
            For index = 0 To 7
                If Guy.Position.X + Guy.CellWidth > Floors(index).Left And Guy.Position.X < Floors(index).Right Then
                    If NextVerticalStep > 0 Then
                        If Guy.Position.Y + Guy.CellHeight <= Floors(index).top Then
                            If Guy.Position.Y + Guy.CellHeight + NextVerticalStep > Floors(index).top Then
                                NextVerticalStep = Floors(index).top - (Guy.Position.Y + Guy.CellHeight)
                                Guy.OnFloor = True
                            End If
                        End If
                    End If
                    If NextVerticalStep <= 0 Then
                        If Guy.Position.Y >= Floors(index).Bottom Then
                            If Guy.Position.Y + NextVerticalStep < Floors(index).Bottom Then
                                NextVerticalStep = Floors(index).Bottom - Guy.Position.Y
                            End If
                        End If
                    End If
                End If

            Next index
        End If

        Return NextVerticalStep
    End Function

    Public Sub AnimateBadGuy()

        Dim index As Integer

        For index = 0 To numBadGuys
            BadGuys(index).CellTop += BadGuys(index).CellHeight
            If BadGuys(index).state = ALIVE Then


                If BadGuys(index).Speed.X > 0 Then
                    If BadGuys(index).CellTop > BadGuys(index).CellHeight * 1 Then
                        BadGuys(index).CellTop = 0
                    End If
                ElseIf BadGuys(index).Speed.X < 0 Then
                    If BadGuys(index).CellTop > BadGuys(index).CellHeight * 3 Then
                        BadGuys(index).CellTop = BadGuys(index).CellHeight * 2
                    End If
                End If
            ElseIf BadGuys(index).state = flip Then
                If BadGuys(index).CellTop > BadGuys(index).CellHeight * 9 Then
                    BadGuys(index).CellTop = BadGuys(index).CellHeight * 8
                End If
            ElseIf BadGuys(index).state = DEAD Then
                If BadGuys(index).CellTop > BadGuys(index).CellHeight * 7 Then
                    BadGuys(index).CellTop = BadGuys(index).CellHeight * 4
                End If
            End If
        Next index
    End Sub


    Public Function Collision(ByVal Guy1 As Sprite, ByVal Guy2 As Sprite)
        Dim a As Integer
        Dim b As Integer
        Dim c As Double

        a = Guy1.Position.X - Guy2.Position.X
        b = Guy1.Position.Y - Guy2.Position.Y
        c = Math.Sqrt(a * a + b * b)

        If c < Guy1.radius + Guy2.radius Then
            Return True
        End If

        Return False

    End Function

    Public Sub reviveMax()
        If Max.state = DEAD And Max.Position.Y > backdrop.Height Then
            Max.state = revive
            Max.Position.Y = -50
            Max.Speed.Y = 0
            Max.Position.X = 310

        End If
        If Max.Position.X > 50 And Max.state = revive Then
            Max.Speed.Y = 0
            Max.Position.Y = 10
        End If
    End Sub

    Public Sub checkKillBadGuy()
        Dim index As Integer
        Dim maxCLone As Sprite

        maxCLone = Max
        maxCLone.Position.Y -= 25

        For index = 0 To numBadGuys
            If Collision(maxCLone, BadGuys(index)) And Max.state = ALIVE And BadGuys(index).state = ALIVE And BadGuys(index).OnFloor = True Then
                BadGuys(index).state = flip
                BadGuys(index).Speed.Y -= 10
                BadGuys(index).Speed.X = 0
                BadGuys(index).timeFlipped = 0
            End If
            If BadGuys(index).Position.Y > 600 And BadGuys(index).state = DEAD Then
                BadGuys(index).Speed.X = 0
                BadGuys(index).Speed.Y = 0
                BadGuys(index).Position.X = backdrop.Width / 2
                BadGuys(index).Position.Y = 600
            End If
            If BadGuys(index).state = flip Then
                BadGuys(index).timeFlipped += 1
                If BadGuys(index).timeFlipped = 60 Then
                    BadGuys(index).state = ALIVE
                    BadGuys(index).Speed.X = BadGuys(index).StartSpeed.X
                    BadGuys(index).timeFlipped = 0
                End If
            End If
            If Collision(Max, BadGuys(index)) And BadGuys(index).state = flip And Max.state = ALIVE Then
                BadGuys(index).state = DEAD
                BadGuys(index).Speed.X = Max.Speed.X * 3
                score += 50
                numBadGuysKilled += 1
                MainForm.ScoreText.Text = score.ToString
            End If
        Next
    End Sub

    Public Sub checkKillmax()
        For index = 0 To NumSpawnBadGuys
            Call MoveSprite(BadGuys(index))
            If Collision(Max, BadGuys(index)) And Max.state = ALIVE And BadGuys(index).state = ALIVE And Max.powerInvicibility = False And BadGuys(index).Speed.X = 4 Then
                Max.state = DEAD
                Max.Speed.Y = -20
                Max.Speed.X = 0

                lives -= 2

                MainForm.livesText.Text = lives.ToString
            End If

            If Collision(Max, BadGuys(index)) And Max.state = ALIVE And BadGuys(index).state = ALIVE And Max.powerInvicibility = False And BadGuys(index).Speed.X = -4 Then
                Max.state = DEAD
                Max.Speed.Y = -20
                Max.Speed.X = 0

                lives -= 2

                MainForm.livesText.Text = lives.ToString
            End If

            If Collision(Max, BadGuys(index)) And Max.state = ALIVE And BadGuys(index).state = ALIVE And Max.powerInvicibility = False And BadGuys(index).Speed.X = -6 Then
                Max.state = DEAD
                Max.Speed.Y = -20
                Max.Speed.X = 0

                lives -= 1

                MainForm.livesText.Text = lives.ToString
            End If

            If Collision(Max, BadGuys(index)) And Max.state = ALIVE And BadGuys(index).state = ALIVE And Max.powerInvicibility = False And BadGuys(index).Speed.X = 6 Then
                Max.state = DEAD
                Max.Speed.Y = -20
                Max.Speed.X = 0

                lives -= 1

                MainForm.livesText.Text = lives.ToString
            End If
        Next index
    End Sub

    Public Sub checkMilk()

        Dim index As Integer
        If Collision(milk, Max) And Max.OnFloor = False And milk.state = ALIVE And Max.state = ALIVE And Max.Speed.Y < 0 Then
            Max.Speed.Y = milk.Position.Y + milk.CellWidth - Max.Position.Y
            For index = 0 To NumSpawnBadGuys
                If BadGuys(index).state = ALIVE Then
                    BadGuys(index).state = flip
                    BadGuys(index).Speed.X = 0

                    milk.state = DEAD
                End If
            Next
        End If
    End Sub

    Public Sub checkInvincibility()
        If Collision(Max, invicibility) And invicibility.state = ALIVE And invincibilitySpawned = True Then
            Max.powerInvicibility = True
            invicibility.state = DEAD
            invincibilitySpawned = False
            Max.changeCostume = True
        End If

        If Max.powerInvicibility = True Then
            invicibilityCounter += 1
            If invicibilityCounter = 100 Then
                invicibilityCounter = 0
                Max.powerInvicibility = False
                Max.Picture = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\galacticat.png")
                Max.changeCostume = False
            End If
        End If
    End Sub

    Public Sub visualizeInvincibility()
        If Max.changeCostume = True Then
            'Dim invincibleMax As Sprite
            'invincibleMax = Max
            Max.Picture = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\galacticat2.png")
        End If
    End Sub

    Public Sub checkSlowTime()
        If Collision(Max, timeSlower) Then
            timeSlower.state = DEAD
            Dim index As Integer
            Max.powerTimeSlower = True
            slowTimeSpawned = False

            For index = 0 To NumSpawnBadGuys
                If BadGuys(index).Speed.X > 0 Then
                    BadGuys(index).Speed.X = 1
                ElseIf BadGuys(index).Speed.X < 0 Then
                    BadGuys(index).Speed.X = -1
                End If
            Next index
        End If

        If Max.powerTimeSlower = True Then
            timeSlowerCounter += 1
            If timeSlowerCounter = 100 Then
                Max.powerTimeSlower = False
                timeSlowerCounter = 0
            End If
        End If
    End Sub

    Public Sub checkSpeedBoost()
        If Collision(Max, speedBoost) Then
            speedBoost.state = DEAD
            Max.StartSpeed.X *= 2
            Max.powerSpeedBoost = True
            speedBoostCounter += 1
            If speedBoostCounter = 100 Then
                Max.powerTimeSlower = False
            End If
        End If
    End Sub

    Public Sub BadGuysJump()
        Dim index As Integer

        For index = 0 To NumSpawnBadGuys
            BadGuys(index).jumpCounter += 1
            If BadGuys(index).jumpCounter = 200 And BadGuys(index).Speed.X = 4 Then
                BadGuys(index).Speed.Y = -10
                BadGuys(index).jumpCounter = 0
            End If
            If BadGuys(index).jumpCounter = 200 And BadGuys(index).Speed.X = -4 Then
                BadGuys(index).Speed.Y = -10
                BadGuys(index).jumpCounter = 0
            End If
        Next
    End Sub

    Public Sub BadGuysChangeDirection()
        Dim index As Integer

        For index = 0 To NumSpawnBadGuys
            BadGuys(index).DirectionCounter += 1
            If BadGuys(index).DirectionCounter = 200 And BadGuys(index).Speed.X = 6 Then
                BadGuys(index).Speed.X = -6
                BadGuys(index).DirectionCounter = 0
            ElseIf BadGuys(index).DirectionCounter = 200 And BadGuys(index).Speed.X = -6 Then
                BadGuys(index).Speed.X = 6
                BadGuys(index).DirectionCounter = 0
            End If
        Next
    End Sub
End Module
