<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class winForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(winForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QUITbutton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(-6, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1041, 117)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "YOU SAVED THE UNIVERSE!"
        '
        'QUITbutton
        '
        Me.QUITbutton.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QUITbutton.Location = New System.Drawing.Point(105, 369)
        Me.QUITbutton.Name = "QUITbutton"
        Me.QUITbutton.Size = New System.Drawing.Size(254, 110)
        Me.QUITbutton.TabIndex = 3
        Me.QUITbutton.Text = "QUIT"
        Me.QUITbutton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(670, 369)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(254, 110)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "NEXT LEVEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'winForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1018, 527)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.QUITbutton)
        Me.Controls.Add(Me.Label2)
        Me.Name = "winForm"
        Me.Text = "winForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents QUITbutton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
