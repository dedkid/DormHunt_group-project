<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBoxSSLogo = New System.Windows.Forms.PictureBox()
        Me.lblDormHunt = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBoxSSLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxSSLogo
        '
        Me.PictureBoxSSLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxSSLogo.Image = Global.FinalProjectOOP.My.Resources.Resource1.dhLogoVertical
        Me.PictureBoxSSLogo.Location = New System.Drawing.Point(175, 75)
        Me.PictureBoxSSLogo.Name = "PictureBoxSSLogo"
        Me.PictureBoxSSLogo.Size = New System.Drawing.Size(350, 150)
        Me.PictureBoxSSLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxSSLogo.TabIndex = 0
        Me.PictureBoxSSLogo.TabStop = False
        '
        'lblDormHunt
        '
        Me.lblDormHunt.AutoSize = True
        Me.lblDormHunt.BackColor = System.Drawing.Color.Transparent
        Me.lblDormHunt.Font = New System.Drawing.Font("Segoe UI Black", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDormHunt.ForeColor = System.Drawing.Color.White
        Me.lblDormHunt.Location = New System.Drawing.Point(169, 176)
        Me.lblDormHunt.Name = "lblDormHunt"
        Me.lblDormHunt.Size = New System.Drawing.Size(0, 72)
        Me.lblDormHunt.TabIndex = 1
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.BackColor = System.Drawing.Color.Transparent
        Me.lblPercentage.Location = New System.Drawing.Point(350, 412)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(17, 15)
        Me.lblPercentage.TabIndex = 2
        Me.lblPercentage.Text = "%"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(88, 398)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(525, 11)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Violet
        Me.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.DarkerGradient_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.lblDormHunt)
        Me.Controls.Add(Me.PictureBoxSSLogo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(700, 450)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBoxSSLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxSSLogo As PictureBox
    Friend WithEvents lblDormHunt As Label
    Friend WithEvents lblPercentage As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
