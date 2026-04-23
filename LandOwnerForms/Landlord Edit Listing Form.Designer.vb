<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Landlord_Edit_Listing_Form
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LTxtPrice = New System.Windows.Forms.TextBox()
        Me.LLblPrice = New System.Windows.Forms.Label()
        Me.LTxtAvailability = New System.Windows.Forms.TextBox()
        Me.LTxtEmailAdd = New System.Windows.Forms.TextBox()
        Me.LTxtMobileNumber = New System.Windows.Forms.TextBox()
        Me.LTxtAddress = New System.Windows.Forms.TextBox()
        Me.LBtnChangePhoto = New System.Windows.Forms.Button()
        Me.LBtnSave = New System.Windows.Forms.Button()
        Me.LLblAvailability = New System.Windows.Forms.Label()
        Me.LLblEmailAdd = New System.Windows.Forms.Label()
        Me.LLblMobileNumber = New System.Windows.Forms.Label()
        Me.LLblAddress = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.LPicDetails = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.LPicDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.txtDescription)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.LTxtPrice)
        Me.Panel2.Controls.Add(Me.LLblPrice)
        Me.Panel2.Controls.Add(Me.LTxtAvailability)
        Me.Panel2.Controls.Add(Me.LTxtEmailAdd)
        Me.Panel2.Controls.Add(Me.LTxtMobileNumber)
        Me.Panel2.Controls.Add(Me.LTxtAddress)
        Me.Panel2.Controls.Add(Me.LBtnChangePhoto)
        Me.Panel2.Controls.Add(Me.LBtnSave)
        Me.Panel2.Controls.Add(Me.LLblAvailability)
        Me.Panel2.Controls.Add(Me.LLblEmailAdd)
        Me.Panel2.Controls.Add(Me.LLblMobileNumber)
        Me.Panel2.Controls.Add(Me.LLblAddress)
        Me.Panel2.Controls.Add(Me.lblType)
        Me.Panel2.Controls.Add(Me.LPicDetails)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(673, 491)
        Me.Panel2.TabIndex = 10
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(247, 224)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(384, 46)
        Me.txtDescription.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(247, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Description:"
        '
        'LTxtPrice
        '
        Me.LTxtPrice.Location = New System.Drawing.Point(247, 112)
        Me.LTxtPrice.Name = "LTxtPrice"
        Me.LTxtPrice.Size = New System.Drawing.Size(131, 23)
        Me.LTxtPrice.TabIndex = 20
        '
        'LLblPrice
        '
        Me.LLblPrice.AutoSize = True
        Me.LLblPrice.BackColor = System.Drawing.Color.Transparent
        Me.LLblPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LLblPrice.ForeColor = System.Drawing.Color.White
        Me.LLblPrice.Location = New System.Drawing.Point(247, 88)
        Me.LLblPrice.Name = "LLblPrice"
        Me.LLblPrice.Size = New System.Drawing.Size(50, 21)
        Me.LLblPrice.TabIndex = 19
        Me.LLblPrice.Text = "Price:"
        '
        'LTxtAvailability
        '
        Me.LTxtAvailability.Location = New System.Drawing.Point(247, 401)
        Me.LTxtAvailability.Name = "LTxtAvailability"
        Me.LTxtAvailability.Size = New System.Drawing.Size(110, 23)
        Me.LTxtAvailability.TabIndex = 18
        '
        'LTxtEmailAdd
        '
        Me.LTxtEmailAdd.Location = New System.Drawing.Point(247, 341)
        Me.LTxtEmailAdd.Name = "LTxtEmailAdd"
        Me.LTxtEmailAdd.Size = New System.Drawing.Size(208, 23)
        Me.LTxtEmailAdd.TabIndex = 17
        '
        'LTxtMobileNumber
        '
        Me.LTxtMobileNumber.Location = New System.Drawing.Point(247, 297)
        Me.LTxtMobileNumber.Name = "LTxtMobileNumber"
        Me.LTxtMobileNumber.Size = New System.Drawing.Size(208, 23)
        Me.LTxtMobileNumber.TabIndex = 16
        '
        'LTxtAddress
        '
        Me.LTxtAddress.Location = New System.Drawing.Point(247, 159)
        Me.LTxtAddress.Multiline = True
        Me.LTxtAddress.Name = "LTxtAddress"
        Me.LTxtAddress.Size = New System.Drawing.Size(384, 38)
        Me.LTxtAddress.TabIndex = 15
        '
        'LBtnChangePhoto
        '
        Me.LBtnChangePhoto.BackColor = System.Drawing.Color.Green
        Me.LBtnChangePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LBtnChangePhoto.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LBtnChangePhoto.ForeColor = System.Drawing.Color.White
        Me.LBtnChangePhoto.Location = New System.Drawing.Point(55, 374)
        Me.LBtnChangePhoto.Name = "LBtnChangePhoto"
        Me.LBtnChangePhoto.Size = New System.Drawing.Size(136, 30)
        Me.LBtnChangePhoto.TabIndex = 14
        Me.LBtnChangePhoto.Text = "Change Photo"
        Me.LBtnChangePhoto.UseVisualStyleBackColor = False
        '
        'LBtnSave
        '
        Me.LBtnSave.BackColor = System.Drawing.Color.Green
        Me.LBtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LBtnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LBtnSave.ForeColor = System.Drawing.Color.White
        Me.LBtnSave.Location = New System.Drawing.Point(497, 406)
        Me.LBtnSave.Name = "LBtnSave"
        Me.LBtnSave.Size = New System.Drawing.Size(134, 33)
        Me.LBtnSave.TabIndex = 12
        Me.LBtnSave.Text = "SAVE"
        Me.LBtnSave.UseVisualStyleBackColor = False
        '
        'LLblAvailability
        '
        Me.LLblAvailability.BackColor = System.Drawing.Color.MediumPurple
        Me.LLblAvailability.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LLblAvailability.ForeColor = System.Drawing.Color.White
        Me.LLblAvailability.Location = New System.Drawing.Point(247, 377)
        Me.LLblAvailability.Name = "LLblAvailability"
        Me.LLblAvailability.Size = New System.Drawing.Size(110, 21)
        Me.LLblAvailability.TabIndex = 10
        Me.LLblAvailability.Text = "Availability"
        Me.LLblAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LLblEmailAdd
        '
        Me.LLblEmailAdd.AutoSize = True
        Me.LLblEmailAdd.BackColor = System.Drawing.Color.Transparent
        Me.LLblEmailAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LLblEmailAdd.ForeColor = System.Drawing.Color.White
        Me.LLblEmailAdd.Location = New System.Drawing.Point(247, 317)
        Me.LLblEmailAdd.Name = "LLblEmailAdd"
        Me.LLblEmailAdd.Size = New System.Drawing.Size(116, 21)
        Me.LLblEmailAdd.TabIndex = 8
        Me.LLblEmailAdd.Text = "Email Address:"
        '
        'LLblMobileNumber
        '
        Me.LLblMobileNumber.AutoSize = True
        Me.LLblMobileNumber.BackColor = System.Drawing.Color.Transparent
        Me.LLblMobileNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LLblMobileNumber.ForeColor = System.Drawing.Color.White
        Me.LLblMobileNumber.Location = New System.Drawing.Point(247, 273)
        Me.LLblMobileNumber.Name = "LLblMobileNumber"
        Me.LLblMobileNumber.Size = New System.Drawing.Size(131, 21)
        Me.LLblMobileNumber.TabIndex = 6
        Me.LLblMobileNumber.Text = "Mobile Number:"
        '
        'LLblAddress
        '
        Me.LLblAddress.AutoSize = True
        Me.LLblAddress.BackColor = System.Drawing.Color.Transparent
        Me.LLblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LLblAddress.ForeColor = System.Drawing.Color.White
        Me.LLblAddress.Location = New System.Drawing.Point(247, 135)
        Me.LLblAddress.Name = "LLblAddress"
        Me.LLblAddress.Size = New System.Drawing.Size(74, 21)
        Me.LLblAddress.TabIndex = 4
        Me.LLblAddress.Text = "Address:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblType.ForeColor = System.Drawing.Color.White
        Me.lblType.Location = New System.Drawing.Point(247, 50)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(288, 28)
        Me.lblType.TabIndex = 1
        Me.lblType.Text = "Sta. Mesa hosted by John Doe"
        '
        'LPicDetails
        '
        Me.LPicDetails.BackColor = System.Drawing.Color.White
        Me.LPicDetails.Location = New System.Drawing.Point(24, 73)
        Me.LPicDetails.Name = "LPicDetails"
        Me.LPicDetails.Size = New System.Drawing.Size(198, 291)
        Me.LPicDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LPicDetails.TabIndex = 0
        Me.LPicDetails.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Firebrick
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(639, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(34, 25)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Landlord_Edit_Listing_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Violet
        Me.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.DarkerGradient_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(673, 491)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(673, 491)
        Me.Name = "Landlord_Edit_Listing_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Land Owner Edit Listing"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.LPicDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LBtnChangePhoto As Button
    Friend WithEvents LBtnSave As Button
    Friend WithEvents LLblAvailability As Label
    Friend WithEvents LLblEmailAdd As Label
    Friend WithEvents LLblMobileNumber As Label
    Friend WithEvents LLblAddress As Label
    Friend WithEvents lblType As Label
    Friend WithEvents LPicDetails As PictureBox
    Friend WithEvents LTxtAvailability As TextBox
    Friend WithEvents LTxtEmailAdd As TextBox
    Friend WithEvents LTxtMobileNumber As TextBox
    Friend WithEvents LTxtAddress As TextBox
    Friend WithEvents LTxtPrice As TextBox
    Friend WithEvents LLblPrice As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnExit As Button
End Class
