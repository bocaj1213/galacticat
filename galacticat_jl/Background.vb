Module Background
    Structure Floor
        Dim top As Integer
        Dim Bottom As Integer
        Dim Left As Integer
        Dim Right As Integer

    End Structure
    Structure Background
        Dim Picture As Bitmap
        Dim Position As Point
        Dim Width As Integer
        Dim Height As Integer
    End Structure

    Public backdrop As Background
    Public g As Graphics
    Public offG As Graphics
    Public imageOffScreen As Image
    Public numFloors As Integer = 7
    Public Floors(numFloors) As Floor

    Public Sub LoadBackground()
        backdrop.Position.X = 0
        backdrop.Position.Y = 0
        backdrop.Picture = New Bitmap(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\bckgrnd2.bmp")
        backdrop.Width = backdrop.Picture.Width
        backdrop.Height = backdrop.Picture.Height
    End Sub

    Public Sub BackgroundDraw()
        offG.DrawImage(backdrop.Picture, 0, 0)
    End Sub

    Public Sub SetFloors()
        Floors(0).top = 415
        Floors(0).Bottom = 442
        Floors(0).Left = -50
        Floors(0).Right = 688

        Floors(1).top = 315
        Floors(1).Bottom = 335
        Floors(1).Left = -70
        Floors(1).Right = 246

        Floors(2).top = 315
        Floors(2).Bottom = 335
        Floors(2).Left = 406
        Floors(2).Right = 688

        Floors(3).top = 215
        Floors(3).Bottom = 235
        Floors(3).Left = -50
        Floors(3).Right = 100

        Floors(4).top = 215
        Floors(4).Bottom = 235
        Floors(4).Left = 552
        Floors(4).Right = 688

        Floors(5).top = 201
        Floors(5).Bottom = 221
        Floors(5).Left = 167
        Floors(5).Right = 484

        Floors(6).top = 90
        Floors(6).Bottom = 110
        Floors(6).Left = -50
        Floors(6).Right = 271

        Floors(7).top = 90
        Floors(7).Bottom = 110
        Floors(7).Left = 380
        Floors(7).Right = 688
    End Sub

End Module
