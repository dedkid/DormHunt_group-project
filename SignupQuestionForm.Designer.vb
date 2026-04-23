<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignupQuestionForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnLandOwner = New System.Windows.Forms.Button()
        Me.btnTenant = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblQuestion)
        Me.Panel1.Controls.Add(Me.btnLandOwner)
        Me.Panel1.Controls.Add(Me.btnTenant)
        Me.Panel1.Location = New System.Drawing.Point(178, 230)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 292)
        Me.Panel1.TabIndex = 3
        '
        'lblQuestion
        '
        Me.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblQuestion.ForeColor = System.Drawing.Color.White
        Me.lblQuestion.Location = New System.Drawing.Point(51, 48)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(454, 32)
        Me.lblQuestion.TabIndex = 2
        Me.lblQuestion.Text = "Are you a TENANT or LAND OWNER ?"
        '
        'btnLandOwner
        '
        Me.btnLandOwner.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLandOwner.BackColor = System.Drawing.Color.Fuchsia
        Me.btnLandOwner.FlatAppearance.BorderSize = 0
        Me.btnLandOwner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum
        Me.btnLandOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLandOwner.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLandOwner.Location = New System.Drawing.Point(137, 207)
        Me.btnLandOwner.Name = "btnLandOwner"
        Me.btnLandOwner.Size = New System.Drawing.Size(288, 40)
        Me.btnLandOwner.TabIndex = 1
        Me.btnLandOwner.Text = "LAND OWNER"
        Me.btnLandOwner.UseVisualStyleBackColor = False
        '
        'btnTenant
        '
        Me.btnTenant.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTenant.BackColor = System.Drawing.Color.Black
        Me.btnTenant.FlatAppearance.BorderSize = 0
        Me.btnTenant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTenant.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTenant.ForeColor = System.Drawing.Color.White
        Me.btnTenant.Location = New System.Drawing.Point(137, 151)
        Me.btnTenant.Name = "btnTenant"
        Me.btnTenant.Size = New System.Drawing.Size(288, 40)
        Me.btnTenant.TabIndex = 0
        Me.btnTenant.Text = "TENANT"
        Me.btnTenant.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.FinalProjectOOP.My.Resources.Resource1.dhLogoVertical
        Me.PictureBox1.Location = New System.Drawing.Point(268, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(369, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.backBUTTON
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnBack.Location = New System.Drawing.Point(13, 13)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(45, 45)
        Me.btnBack.TabIndex = 116
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'SignupQuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.DarkerGradient_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(894, 546)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(894, 538)
        Me.Name = "SignupQuestionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up Question "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLandOwner As Button
    Friend WithEvents btnTenant As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnBack As Button
End Class
