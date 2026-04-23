<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp_Form
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
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.txtConfirmPW = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.bday = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtMname)
        Me.Panel1.Controls.Add(Me.lblSignUp)
        Me.Panel1.Controls.Add(Me.btnSignUp)
        Me.Panel1.Controls.Add(Me.txtConfirmPW)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtLName)
        Me.Panel1.Controls.Add(Me.txtFName)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel1.Location = New System.Drawing.Point(86, 106)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 426)
        Me.Panel1.TabIndex = 0
        '
        'txtMname
        '
        Me.txtMname.ForeColor = System.Drawing.Color.Black
        Me.txtMname.Location = New System.Drawing.Point(33, 101)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.PlaceholderText = "Middle Name"
        Me.txtMname.Size = New System.Drawing.Size(295, 27)
        Me.txtMname.TabIndex = 12
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.BackColor = System.Drawing.Color.Transparent
        Me.lblSignUp.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSignUp.ForeColor = System.Drawing.Color.White
        Me.lblSignUp.Location = New System.Drawing.Point(122, 11)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(119, 37)
        Me.lblSignUp.TabIndex = 11
        Me.lblSignUp.Text = "Sign Up"
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Fuchsia
        Me.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignUp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.Location = New System.Drawing.Point(122, 379)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(118, 33)
        Me.btnSignUp.TabIndex = 6
        Me.btnSignUp.Text = "SIGN UP"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'txtConfirmPW
        '
        Me.txtConfirmPW.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPW.Location = New System.Drawing.Point(33, 329)
        Me.txtConfirmPW.Name = "txtConfirmPW"
        Me.txtConfirmPW.PlaceholderText = "Confirm Password"
        Me.txtConfirmPW.Size = New System.Drawing.Size(295, 27)
        Me.txtConfirmPW.TabIndex = 5
        '
        'txtPassword
        '
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(33, 285)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.Size = New System.Drawing.Size(295, 27)
        Me.txtPassword.TabIndex = 4
        '
        'txtContact
        '
        Me.txtContact.ForeColor = System.Drawing.Color.Black
        Me.txtContact.Location = New System.Drawing.Point(33, 239)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.PlaceholderText = "Contact No."
        Me.txtContact.Size = New System.Drawing.Size(295, 27)
        Me.txtContact.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(33, 193)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderText = "Email Address"
        Me.txtEmail.Size = New System.Drawing.Size(295, 27)
        Me.txtEmail.TabIndex = 2
        '
        'txtLName
        '
        Me.txtLName.ForeColor = System.Drawing.Color.Black
        Me.txtLName.Location = New System.Drawing.Point(33, 145)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.PlaceholderText = "Last Name"
        Me.txtLName.Size = New System.Drawing.Size(295, 27)
        Me.txtLName.TabIndex = 1
        '
        'txtFName
        '
        Me.txtFName.ForeColor = System.Drawing.Color.Black
        Me.txtFName.Location = New System.Drawing.Point(33, 59)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.PlaceholderText = "First Name"
        Me.txtFName.Size = New System.Drawing.Size(295, 27)
        Me.txtFName.TabIndex = 0
        '
        'lblGender
        '
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGender.ForeColor = System.Drawing.Color.White
        Me.lblGender.Location = New System.Drawing.Point(541, 160)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(67, 21)
        Me.lblGender.TabIndex = 1
        Me.lblGender.Text = "Gender"
        '
        'lblBirthdate
        '
        Me.lblBirthdate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.BackColor = System.Drawing.Color.Transparent
        Me.lblBirthdate.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBirthdate.ForeColor = System.Drawing.Color.White
        Me.lblBirthdate.Location = New System.Drawing.Point(541, 268)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(89, 21)
        Me.lblBirthdate.TabIndex = 2
        Me.lblBirthdate.Text = "Birth date"
        '
        'rbMale
        '
        Me.rbMale.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.rbMale.AutoSize = True
        Me.rbMale.BackColor = System.Drawing.Color.Transparent
        Me.rbMale.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbMale.ForeColor = System.Drawing.Color.White
        Me.rbMale.Location = New System.Drawing.Point(548, 191)
        Me.rbMale.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(60, 24)
        Me.rbMale.TabIndex = 3
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = False
        '
        'rbFemale
        '
        Me.rbFemale.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.rbFemale.AutoSize = True
        Me.rbFemale.BackColor = System.Drawing.Color.Transparent
        Me.rbFemale.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbFemale.ForeColor = System.Drawing.Color.White
        Me.rbFemale.Location = New System.Drawing.Point(547, 214)
        Me.rbFemale.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(75, 24)
        Me.rbFemale.TabIndex = 4
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.FinalProjectOOP.My.Resources.Resource1.dhLogoHorizontal
        Me.PictureBox1.Location = New System.Drawing.Point(235, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(423, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
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
        Me.btnBack.Location = New System.Drawing.Point(12, 11)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(45, 45)
        Me.btnBack.TabIndex = 114
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'bday
        '
        Me.bday.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bday.CustomFormat = "yyyy-MM-dd"
        Me.bday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bday.Location = New System.Drawing.Point(547, 299)
        Me.bday.Name = "bday"
        Me.bday.Size = New System.Drawing.Size(200, 23)
        Me.bday.TabIndex = 115
        '
        'SignUp_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.DarkerGradient_Background
        Me.ClientSize = New System.Drawing.Size(894, 544)
        Me.Controls.Add(Me.bday)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.lblBirthdate)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(894, 538)
        Me.Name = "SignUp_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSignUp As Label
    Friend WithEvents txtConfirmPW As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblBirthdate As Label
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents btnSignUp As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents bday As DateTimePicker
    Friend WithEvents txtMname As TextBox
End Class
