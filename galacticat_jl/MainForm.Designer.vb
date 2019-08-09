<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicDrawOnScreen = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScoreText = New System.Windows.Forms.Label()
        Me.LABEL3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.livesText = New System.Windows.Forms.Label()
        Me.level7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.levelText = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDrawOnScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 60
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PicDrawOnScreen
        '
        Me.PicDrawOnScreen.Location = New System.Drawing.Point(8, 8)
        Me.PicDrawOnScreen.Name = "PicDrawOnScreen"
        Me.PicDrawOnScreen.Size = New System.Drawing.Size(100, 50)
        Me.PicDrawOnScreen.TabIndex = 2
        Me.PicDrawOnScreen.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(732, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'ScoreText
        '
        Me.ScoreText.AutoSize = True
        Me.ScoreText.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreText.ForeColor = System.Drawing.Color.White
        Me.ScoreText.Location = New System.Drawing.Point(680, 63)
        Me.ScoreText.Name = "ScoreText"
        Me.ScoreText.Size = New System.Drawing.Size(34, 32)
        Me.ScoreText.TabIndex = 4
        Me.ScoreText.Text = "0"
        '
        'LABEL3
        '
        Me.LABEL3.AutoSize = True
        Me.LABEL3.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABEL3.ForeColor = System.Drawing.Color.White
        Me.LABEL3.Location = New System.Drawing.Point(645, 9)
        Me.LABEL3.Name = "LABEL3"
        Me.LABEL3.Size = New System.Drawing.Size(150, 38)
        Me.LABEL3.TabIndex = 6
        Me.LABEL3.Text = "SCORE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(652, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(656, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 38)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "LIVES:"
        '
        'livesText
        '
        Me.livesText.AutoSize = True
        Me.livesText.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.livesText.ForeColor = System.Drawing.Color.White
        Me.livesText.Location = New System.Drawing.Point(693, 209)
        Me.livesText.Name = "livesText"
        Me.livesText.Size = New System.Drawing.Size(34, 32)
        Me.livesText.TabIndex = 9
        Me.livesText.Text = "3"
        '
        'level7
        '
        Me.level7.AutoSize = True
        Me.level7.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.level7.ForeColor = System.Drawing.Color.White
        Me.level7.Location = New System.Drawing.Point(656, 280)
        Me.level7.Name = "level7"
        Me.level7.Size = New System.Drawing.Size(125, 38)
        Me.level7.TabIndex = 10
        Me.level7.Text = "LEVEL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(696, 349)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Label6"
        '
        'levelText
        '
        Me.levelText.AutoSize = True
        Me.levelText.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.levelText.ForeColor = System.Drawing.Color.White
        Me.levelText.Location = New System.Drawing.Point(693, 349)
        Me.levelText.Name = "levelText"
        Me.levelText.Size = New System.Drawing.Size(34, 32)
        Me.levelText.TabIndex = 12
        Me.levelText.Text = "1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.levelText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.level7)
        Me.Controls.Add(Me.livesText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LABEL3)
        Me.Controls.Add(Me.ScoreText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicDrawOnScreen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainForm"
        Me.Text = "Galacticat - by Jacob "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDrawOnScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PicDrawOnScreen As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ScoreText As System.Windows.Forms.Label
    Friend WithEvents LABEL3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents livesText As System.Windows.Forms.Label
    Friend WithEvents level7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents levelText As System.Windows.Forms.Label

End Class
