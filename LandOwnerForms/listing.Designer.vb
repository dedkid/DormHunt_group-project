<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listing
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
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LbtnUpload = New System.Windows.Forms.Button()
        Me.btnPublish = New System.Windows.Forms.Button()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.LtxtDescription = New System.Windows.Forms.TextBox()
        Me.LbtnSubtract = New System.Windows.Forms.Button()
        Me.LbtnAddition = New System.Windows.Forms.Button()
        Me.LtxtMaxTenant = New System.Windows.Forms.TextBox()
        Me.LlblMaxTenant = New System.Windows.Forms.Label()
        Me.LlblPerMonth = New System.Windows.Forms.Label()
        Me.LtxtPrice = New System.Windows.Forms.TextBox()
        Me.LbtnBoardingHouse = New System.Windows.Forms.Button()
        Me.LbtnRoom = New System.Windows.Forms.Button()
        Me.LbtnDorm = New System.Windows.Forms.Button()
        Me.LbtnApartment = New System.Windows.Forms.Button()
        Me.LlblQuestion = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbLogo.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.dhLogoHorizontal
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLogo.Location = New System.Drawing.Point(-336, 31183)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(243, 50)
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(137, 826)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(436, 199)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'LbtnUpload
        '
        Me.LbtnUpload.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LbtnUpload.ForeColor = System.Drawing.Color.Black
        Me.LbtnUpload.Location = New System.Drawing.Point(267, 1039)
        Me.LbtnUpload.Name = "LbtnUpload"
        Me.LbtnUpload.Size = New System.Drawing.Size(205, 41)
        Me.LbtnUpload.TabIndex = 0
        Me.LbtnUpload.Text = "UPLOAD IMAGE"
        Me.LbtnUpload.UseVisualStyleBackColor = True
        '
        'btnPublish
        '
        Me.btnPublish.BackColor = System.Drawing.Color.Black
        Me.btnPublish.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPublish.ForeColor = System.Drawing.Color.White
        Me.btnPublish.Location = New System.Drawing.Point(235, 1186)
        Me.btnPublish.Name = "btnPublish"
        Me.btnPublish.Size = New System.Drawing.Size(267, 41)
        Me.btnPublish.TabIndex = 2
        Me.btnPublish.Text = "Publish Your Listing"
        Me.btnPublish.UseVisualStyleBackColor = False
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLocation.Location = New System.Drawing.Point(154, 410)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(76, 21)
        Me.lblLocation.TabIndex = 20
        Me.lblLocation.Text = "Location"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(236, 407)
        Me.txtLocation.Multiline = True
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(337, 89)
        Me.txtLocation.TabIndex = 19
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.ForeColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(182, 348)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(48, 21)
        Me.lblPrice.TabIndex = 0
        Me.lblPrice.Text = "Price"
        '
        'LtxtDescription
        '
        Me.LtxtDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LtxtDescription.BackColor = System.Drawing.Color.GhostWhite
        Me.LtxtDescription.Location = New System.Drawing.Point(137, 593)
        Me.LtxtDescription.Multiline = True
        Me.LtxtDescription.Name = "LtxtDescription"
        Me.LtxtDescription.PlaceholderText = "Create your description."
        Me.LtxtDescription.Size = New System.Drawing.Size(436, 212)
        Me.LtxtDescription.TabIndex = 13
        '
        'LbtnSubtract
        '
        Me.LbtnSubtract.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LbtnSubtract.Location = New System.Drawing.Point(235, 523)
        Me.LbtnSubtract.Name = "LbtnSubtract"
        Me.LbtnSubtract.Size = New System.Drawing.Size(36, 30)
        Me.LbtnSubtract.TabIndex = 12
        Me.LbtnSubtract.Text = "-"
        Me.LbtnSubtract.UseVisualStyleBackColor = True
        '
        'LbtnAddition
        '
        Me.LbtnAddition.Location = New System.Drawing.Point(423, 523)
        Me.LbtnAddition.Name = "LbtnAddition"
        Me.LbtnAddition.Size = New System.Drawing.Size(36, 30)
        Me.LbtnAddition.TabIndex = 11
        Me.LbtnAddition.Text = "+"
        Me.LbtnAddition.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LbtnAddition.UseVisualStyleBackColor = True
        '
        'LtxtMaxTenant
        '
        Me.LtxtMaxTenant.BackColor = System.Drawing.Color.White
        Me.LtxtMaxTenant.ForeColor = System.Drawing.Color.Black
        Me.LtxtMaxTenant.Location = New System.Drawing.Point(277, 524)
        Me.LtxtMaxTenant.Name = "LtxtMaxTenant"
        Me.LtxtMaxTenant.Size = New System.Drawing.Size(140, 29)
        Me.LtxtMaxTenant.TabIndex = 10
        Me.LtxtMaxTenant.Text = "0"
        Me.LtxtMaxTenant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LlblMaxTenant
        '
        Me.LlblMaxTenant.AutoSize = True
        Me.LlblMaxTenant.BackColor = System.Drawing.Color.Transparent
        Me.LlblMaxTenant.ForeColor = System.Drawing.Color.White
        Me.LlblMaxTenant.Location = New System.Drawing.Point(130, 527)
        Me.LlblMaxTenant.Name = "LlblMaxTenant"
        Me.LlblMaxTenant.Size = New System.Drawing.Size(99, 21)
        Me.LlblMaxTenant.TabIndex = 9
        Me.LlblMaxTenant.Text = "Max Tenant"
        '
        'LlblPerMonth
        '
        Me.LlblPerMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LlblPerMonth.AutoSize = True
        Me.LlblPerMonth.BackColor = System.Drawing.Color.Transparent
        Me.LlblPerMonth.ForeColor = System.Drawing.Color.White
        Me.LlblPerMonth.Location = New System.Drawing.Point(369, 348)
        Me.LlblPerMonth.Name = "LlblPerMonth"
        Me.LlblPerMonth.Size = New System.Drawing.Size(90, 21)
        Me.LlblPerMonth.TabIndex = 8
        Me.LlblPerMonth.Text = "Per Month"
        '
        'LtxtPrice
        '
        Me.LtxtPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LtxtPrice.Location = New System.Drawing.Point(236, 345)
        Me.LtxtPrice.MaximumSize = New System.Drawing.Size(866, 34)
        Me.LtxtPrice.Name = "LtxtPrice"
        Me.LtxtPrice.PlaceholderText = "₱ 00"
        Me.LtxtPrice.Size = New System.Drawing.Size(127, 29)
        Me.LtxtPrice.TabIndex = 7
        Me.LtxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LbtnBoardingHouse
        '
        Me.LbtnBoardingHouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbtnBoardingHouse.BackColor = System.Drawing.Color.Plum
        Me.LbtnBoardingHouse.Location = New System.Drawing.Point(137, 279)
        Me.LbtnBoardingHouse.MaximumSize = New System.Drawing.Size(866, 40)
        Me.LbtnBoardingHouse.Name = "LbtnBoardingHouse"
        Me.LbtnBoardingHouse.Size = New System.Drawing.Size(436, 40)
        Me.LbtnBoardingHouse.TabIndex = 5
        Me.LbtnBoardingHouse.Text = "Boarding House"
        Me.LbtnBoardingHouse.UseVisualStyleBackColor = False
        '
        'LbtnRoom
        '
        Me.LbtnRoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbtnRoom.BackColor = System.Drawing.Color.Plum
        Me.LbtnRoom.Location = New System.Drawing.Point(137, 222)
        Me.LbtnRoom.MaximumSize = New System.Drawing.Size(866, 40)
        Me.LbtnRoom.Name = "LbtnRoom"
        Me.LbtnRoom.Size = New System.Drawing.Size(436, 40)
        Me.LbtnRoom.TabIndex = 4
        Me.LbtnRoom.Text = "Bed Spacer"
        Me.LbtnRoom.UseVisualStyleBackColor = False
        '
        'LbtnDorm
        '
        Me.LbtnDorm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbtnDorm.BackColor = System.Drawing.Color.Plum
        Me.LbtnDorm.Location = New System.Drawing.Point(137, 159)
        Me.LbtnDorm.MaximumSize = New System.Drawing.Size(866, 40)
        Me.LbtnDorm.Name = "LbtnDorm"
        Me.LbtnDorm.Size = New System.Drawing.Size(436, 40)
        Me.LbtnDorm.TabIndex = 3
        Me.LbtnDorm.Text = "Dorm"
        Me.LbtnDorm.UseVisualStyleBackColor = False
        '
        'LbtnApartment
        '
        Me.LbtnApartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbtnApartment.BackColor = System.Drawing.Color.Plum
        Me.LbtnApartment.Location = New System.Drawing.Point(137, 103)
        Me.LbtnApartment.MaximumSize = New System.Drawing.Size(866, 40)
        Me.LbtnApartment.Name = "LbtnApartment"
        Me.LbtnApartment.Size = New System.Drawing.Size(436, 40)
        Me.LbtnApartment.TabIndex = 2
        Me.LbtnApartment.Text = "Apartment"
        Me.LbtnApartment.UseVisualStyleBackColor = False
        '
        'LlblQuestion
        '
        Me.LlblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.LlblQuestion.ForeColor = System.Drawing.Color.White
        Me.LlblQuestion.Location = New System.Drawing.Point(219, 52)
        Me.LlblQuestion.Name = "LlblQuestion"
        Me.LlblQuestion.Size = New System.Drawing.Size(331, 37)
        Me.LlblQuestion.TabIndex = 1
        Me.LlblQuestion.Text = "What kind of home will you host?"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.backBUTTON
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(45, 45)
        Me.btnBack.TabIndex = 2
        Me.btnBack.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblLocation)
        Me.Panel1.Controls.Add(Me.btnPublish)
        Me.Panel1.Controls.Add(Me.LlblQuestion)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LbtnUpload)
        Me.Panel1.Controls.Add(Me.LbtnSubtract)
        Me.Panel1.Controls.Add(Me.txtLocation)
        Me.Panel1.Controls.Add(Me.LbtnAddition)
        Me.Panel1.Controls.Add(Me.LtxtDescription)
        Me.Panel1.Controls.Add(Me.LbtnApartment)
        Me.Panel1.Controls.Add(Me.LtxtMaxTenant)
        Me.Panel1.Controls.Add(Me.lblPrice)
        Me.Panel1.Controls.Add(Me.LlblMaxTenant)
        Me.Panel1.Controls.Add(Me.LbtnDorm)
        Me.Panel1.Controls.Add(Me.LbtnRoom)
        Me.Panel1.Controls.Add(Me.LbtnBoardingHouse)
        Me.Panel1.Controls.Add(Me.LtxtPrice)
        Me.Panel1.Controls.Add(Me.LlblPerMonth)
        Me.Panel1.Location = New System.Drawing.Point(37, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 1266)
        Me.Panel1.TabIndex = 22
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'listing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.BackColor = System.Drawing.Color.Violet
        Me.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.DarkerGradient_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(769, 550)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pbLogo)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(769, 550)
        Me.Name = "listing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Land Owner Listing"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents btnPublish As Button
    Friend WithEvents LbtnUpload As Button
    Friend WithEvents LtxtDescription As TextBox
    Friend WithEvents LbtnSubtract As Button
    Friend WithEvents LbtnAddition As Button
    Friend WithEvents LtxtMaxTenant As TextBox
    Friend WithEvents LlblMaxTenant As Label
    Friend WithEvents LlblPerMonth As Label
    Friend WithEvents LtxtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents LbtnBoardingHouse As Button
    Friend WithEvents LbtnRoom As Button
    Friend WithEvents LbtnDorm As Button
    Friend WithEvents LbtnApartment As Button
    Friend WithEvents LlblQuestion As Label
    Friend WithEvents btnBack As PictureBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
