<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditProf
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
        Me.LFirstName = New System.Windows.Forms.Label()
        Me.LProfilePic = New System.Windows.Forms.PictureBox()
        Me.LLabelSecurity = New System.Windows.Forms.Label()
        Me.LLabelBirthday = New System.Windows.Forms.Label()
        Me.LLabelMobileNumber = New System.Windows.Forms.Label()
        Me.LLabelAddress = New System.Windows.Forms.Label()
        Me.LBtnChangeYoutProfile = New System.Windows.Forms.Button()
        Me.LTxtBirthday = New System.Windows.Forms.DateTimePicker()
        Me.LTxtSecurity = New System.Windows.Forms.TextBox()
        Me.LBtnChangePassword = New System.Windows.Forms.Button()
        Me.LTxtAddress = New System.Windows.Forms.TextBox()
        Me.LTxtMobileNumber = New System.Windows.Forms.TextBox()
        Me.LBtnSaveChanges = New System.Windows.Forms.Button()
        Me.LSecondName = New System.Windows.Forms.Label()
        Me.LLastName = New System.Windows.Forms.Label()
        CType(Me.LProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LFirstName
        '
        Me.LFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LFirstName.AutoSize = True
        Me.LFirstName.BackColor = System.Drawing.Color.Transparent
        Me.LFirstName.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LFirstName.Location = New System.Drawing.Point(314, 79)
        Me.LFirstName.Name = "LFirstName"
        Me.LFirstName.Size = New System.Drawing.Size(178, 41)
        Me.LFirstName.TabIndex = 86
        Me.LFirstName.Text = "First Name"
        '
        'LProfilePic
        '
        Me.LProfilePic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LProfilePic.BackColor = System.Drawing.Color.Transparent
        Me.LProfilePic.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.Profile
        Me.LProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LProfilePic.Location = New System.Drawing.Point(122, 84)
        Me.LProfilePic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LProfilePic.Name = "LProfilePic"
        Me.LProfilePic.Size = New System.Drawing.Size(143, 136)
        Me.LProfilePic.TabIndex = 85
        Me.LProfilePic.TabStop = False
        '
        'LLabelSecurity
        '
        Me.LLabelSecurity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LLabelSecurity.AutoSize = True
        Me.LLabelSecurity.BackColor = System.Drawing.Color.Transparent
        Me.LLabelSecurity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LLabelSecurity.Location = New System.Drawing.Point(38, 399)
        Me.LLabelSecurity.Name = "LLabelSecurity"
        Me.LLabelSecurity.Size = New System.Drawing.Size(89, 28)
        Me.LLabelSecurity.TabIndex = 72
        Me.LLabelSecurity.Text = "Security"
        '
        'LLabelBirthday
        '
        Me.LLabelBirthday.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LLabelBirthday.AutoSize = True
        Me.LLabelBirthday.BackColor = System.Drawing.Color.Transparent
        Me.LLabelBirthday.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LLabelBirthday.Location = New System.Drawing.Point(38, 284)
        Me.LLabelBirthday.Name = "LLabelBirthday"
        Me.LLabelBirthday.Size = New System.Drawing.Size(94, 28)
        Me.LLabelBirthday.TabIndex = 73
        Me.LLabelBirthday.Text = "Birthday"
        '
        'LLabelMobileNumber
        '
        Me.LLabelMobileNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LLabelMobileNumber.AutoSize = True
        Me.LLabelMobileNumber.BackColor = System.Drawing.Color.Transparent
        Me.LLabelMobileNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LLabelMobileNumber.Location = New System.Drawing.Point(422, 401)
        Me.LLabelMobileNumber.Name = "LLabelMobileNumber"
        Me.LLabelMobileNumber.Size = New System.Drawing.Size(161, 28)
        Me.LLabelMobileNumber.TabIndex = 74
        Me.LLabelMobileNumber.Text = "Mobile Number"
        '
        'LLabelAddress
        '
        Me.LLabelAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LLabelAddress.AutoSize = True
        Me.LLabelAddress.BackColor = System.Drawing.Color.Transparent
        Me.LLabelAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LLabelAddress.Location = New System.Drawing.Point(422, 285)
        Me.LLabelAddress.Name = "LLabelAddress"
        Me.LLabelAddress.Size = New System.Drawing.Size(87, 28)
        Me.LLabelAddress.TabIndex = 69
        Me.LLabelAddress.Text = "Address"
        '
        'LBtnChangeYoutProfile
        '
        Me.LBtnChangeYoutProfile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LBtnChangeYoutProfile.BackColor = System.Drawing.Color.DeepPink
        Me.LBtnChangeYoutProfile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LBtnChangeYoutProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBtnChangeYoutProfile.Location = New System.Drawing.Point(396, 166)
        Me.LBtnChangeYoutProfile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LBtnChangeYoutProfile.Name = "LBtnChangeYoutProfile"
        Me.LBtnChangeYoutProfile.Size = New System.Drawing.Size(201, 45)
        Me.LBtnChangeYoutProfile.TabIndex = 75
        Me.LBtnChangeYoutProfile.Text = "Change your Profile Picture"
        Me.LBtnChangeYoutProfile.UseVisualStyleBackColor = False
        '
        'LTxtBirthday
        '
        Me.LTxtBirthday.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LTxtBirthday.Location = New System.Drawing.Point(38, 316)
        Me.LTxtBirthday.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LTxtBirthday.Name = "LTxtBirthday"
        Me.LTxtBirthday.Size = New System.Drawing.Size(228, 27)
        Me.LTxtBirthday.TabIndex = 94
        '
        'LTxtSecurity
        '
        Me.LTxtSecurity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LTxtSecurity.Location = New System.Drawing.Point(38, 436)
        Me.LTxtSecurity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LTxtSecurity.Name = "LTxtSecurity"
        Me.LTxtSecurity.Size = New System.Drawing.Size(227, 27)
        Me.LTxtSecurity.TabIndex = 95
        '
        'LBtnChangePassword
        '
        Me.LBtnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LBtnChangePassword.BackColor = System.Drawing.Color.Firebrick
        Me.LBtnChangePassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LBtnChangePassword.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LBtnChangePassword.Location = New System.Drawing.Point(54, 539)
        Me.LBtnChangePassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LBtnChangePassword.Name = "LBtnChangePassword"
        Me.LBtnChangePassword.Size = New System.Drawing.Size(178, 52)
        Me.LBtnChangePassword.TabIndex = 96
        Me.LBtnChangePassword.Text = "Change Password"
        Me.LBtnChangePassword.UseVisualStyleBackColor = False
        '
        'LTxtAddress
        '
        Me.LTxtAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LTxtAddress.Location = New System.Drawing.Point(422, 320)
        Me.LTxtAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LTxtAddress.Multiline = True
        Me.LTxtAddress.Name = "LTxtAddress"
        Me.LTxtAddress.Size = New System.Drawing.Size(303, 77)
        Me.LTxtAddress.TabIndex = 97
        '
        'LTxtMobileNumber
        '
        Me.LTxtMobileNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LTxtMobileNumber.Location = New System.Drawing.Point(422, 437)
        Me.LTxtMobileNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LTxtMobileNumber.Multiline = True
        Me.LTxtMobileNumber.Name = "LTxtMobileNumber"
        Me.LTxtMobileNumber.Size = New System.Drawing.Size(228, 29)
        Me.LTxtMobileNumber.TabIndex = 99
        '
        'LBtnSaveChanges
        '
        Me.LBtnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LBtnSaveChanges.BackColor = System.Drawing.Color.Firebrick
        Me.LBtnSaveChanges.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LBtnSaveChanges.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LBtnSaveChanges.Location = New System.Drawing.Point(507, 539)
        Me.LBtnSaveChanges.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LBtnSaveChanges.Name = "LBtnSaveChanges"
        Me.LBtnSaveChanges.Size = New System.Drawing.Size(178, 52)
        Me.LBtnSaveChanges.TabIndex = 100
        Me.LBtnSaveChanges.Text = "Save Changes"
        Me.LBtnSaveChanges.UseVisualStyleBackColor = False
        '
        'LSecondName
        '
        Me.LSecondName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LSecondName.AutoSize = True
        Me.LSecondName.BackColor = System.Drawing.Color.Transparent
        Me.LSecondName.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LSecondName.Location = New System.Drawing.Point(488, 79)
        Me.LSecondName.Name = "LSecondName"
        Me.LSecondName.Size = New System.Drawing.Size(219, 41)
        Me.LSecondName.TabIndex = 101
        Me.LSecondName.Text = "Second Name"
        '
        'LLastName
        '
        Me.LLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LLastName.AutoSize = True
        Me.LLastName.BackColor = System.Drawing.Color.Transparent
        Me.LLastName.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LLastName.Location = New System.Drawing.Point(415, 121)
        Me.LLastName.Name = "LLastName"
        Me.LLastName.Size = New System.Drawing.Size(173, 41)
        Me.LLastName.TabIndex = 102
        Me.LLastName.Text = "Last Name"
        '
        'EditProf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Plum
        Me.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.DarkerGradient_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(769, 653)
        Me.Controls.Add(Me.LLastName)
        Me.Controls.Add(Me.LSecondName)
        Me.Controls.Add(Me.LBtnSaveChanges)
        Me.Controls.Add(Me.LTxtMobileNumber)
        Me.Controls.Add(Me.LBtnChangePassword)
        Me.Controls.Add(Me.LTxtSecurity)
        Me.Controls.Add(Me.LTxtBirthday)
        Me.Controls.Add(Me.LLabelAddress)
        Me.Controls.Add(Me.LBtnChangeYoutProfile)
        Me.Controls.Add(Me.LLabelMobileNumber)
        Me.Controls.Add(Me.LLabelBirthday)
        Me.Controls.Add(Me.LLabelSecurity)
        Me.Controls.Add(Me.LFirstName)
        Me.Controls.Add(Me.LProfilePic)
        Me.Controls.Add(Me.LTxtAddress)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(769, 653)
        Me.Name = "EditProf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Profile"
        CType(Me.LProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LFirstName As Label
    Friend WithEvents LProfilePic As PictureBox
    Friend WithEvents LLabelSecurity As Label
    Friend WithEvents LLabelBirthday As Label
    Friend WithEvents LLabelMobileNumber As Label
    Friend WithEvents LLabelAddress As Label
    Friend WithEvents LBtnChangeYoutProfile As Button
    Friend WithEvents LTxtBirthday As DateTimePicker
    Friend WithEvents LTxtSecurity As TextBox
    Friend WithEvents LBtnChangePassword As Button
    Friend WithEvents LTxtAddress As TextBox
    Friend WithEvents LTxtMobileNumber As TextBox
    Friend WithEvents LBtnSaveChanges As Button
    Friend WithEvents LSecondName As Label
    Friend WithEvents LLastName As Label
End Class
