<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfileeditForm
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
        Me.btnsaveChanges = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.cbCountry = New System.Windows.Forms.ComboBox()
        Me.cbRegion = New System.Windows.Forms.ComboBox()
        Me.cbProvince = New System.Windows.Forms.ComboBox()
        Me.cbCity = New System.Windows.Forms.ComboBox()
        Me.bday = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDeactivate = New System.Windows.Forms.Button()
        Me.txtConfirmNewPass = New System.Windows.Forms.TextBox()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtcurrentPass = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.txtcontactNumber = New System.Windows.Forms.TextBox()
        Me.txtemailAddress = New System.Windows.Forms.TextBox()
        Me.txtlastName = New System.Windows.Forms.TextBox()
        Me.txtmiddleInitial = New System.Windows.Forms.TextBox()
        Me.txtzipCode = New System.Windows.Forms.TextBox()
        Me.txtBarangay = New System.Windows.Forms.TextBox()
        Me.txtfirstName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.btnAddPic = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.btnAddPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsaveChanges
        '
        Me.btnsaveChanges.BackColor = System.Drawing.Color.Black
        Me.btnsaveChanges.FlatAppearance.BorderSize = 0
        Me.btnsaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia
        Me.btnsaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsaveChanges.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnsaveChanges.Location = New System.Drawing.Point(452, 403)
        Me.btnsaveChanges.Name = "btnsaveChanges"
        Me.btnsaveChanges.Size = New System.Drawing.Size(136, 29)
        Me.btnsaveChanges.TabIndex = 23
        Me.btnsaveChanges.Text = "Save Changes"
        Me.btnsaveChanges.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.Profile
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(251, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AutoScrollMargin = New System.Drawing.Size(0, 40)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnChangePass)
        Me.Panel2.Controls.Add(Me.cbCountry)
        Me.Panel2.Controls.Add(Me.cbRegion)
        Me.Panel2.Controls.Add(Me.cbProvince)
        Me.Panel2.Controls.Add(Me.cbCity)
        Me.Panel2.Controls.Add(Me.bday)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtStreet)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnDeactivate)
        Me.Panel2.Controls.Add(Me.txtConfirmNewPass)
        Me.Panel2.Controls.Add(Me.txtNewPass)
        Me.Panel2.Controls.Add(Me.txtcurrentPass)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.rbFemale)
        Me.Panel2.Controls.Add(Me.rbMale)
        Me.Panel2.Controls.Add(Me.txtcontactNumber)
        Me.Panel2.Controls.Add(Me.txtemailAddress)
        Me.Panel2.Controls.Add(Me.txtlastName)
        Me.Panel2.Controls.Add(Me.btnsaveChanges)
        Me.Panel2.Controls.Add(Me.txtmiddleInitial)
        Me.Panel2.Controls.Add(Me.txtzipCode)
        Me.Panel2.Controls.Add(Me.txtBarangay)
        Me.Panel2.Controls.Add(Me.txtfirstName)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblFName)
        Me.Panel2.Location = New System.Drawing.Point(12, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(619, 648)
        Me.Panel2.TabIndex = 23
        '
        'btnChangePass
        '
        Me.btnChangePass.BackColor = System.Drawing.Color.Black
        Me.btnChangePass.FlatAppearance.BorderSize = 0
        Me.btnChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia
        Me.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnChangePass.Location = New System.Drawing.Point(30, 577)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(136, 29)
        Me.btnChangePass.TabIndex = 127
        Me.btnChangePass.Text = "Change Password"
        Me.btnChangePass.UseVisualStyleBackColor = False
        '
        'cbCountry
        '
        Me.cbCountry.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbCountry.ForeColor = System.Drawing.Color.Black
        Me.cbCountry.FormattingEnabled = True
        Me.cbCountry.Items.AddRange(New Object() {"Philippines"})
        Me.cbCountry.Location = New System.Drawing.Point(343, 304)
        Me.cbCountry.Name = "cbCountry"
        Me.cbCountry.Size = New System.Drawing.Size(246, 23)
        Me.cbCountry.TabIndex = 126
        Me.cbCountry.Text = "Country"
        '
        'cbRegion
        '
        Me.cbRegion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbRegion.ForeColor = System.Drawing.Color.Black
        Me.cbRegion.FormattingEnabled = True
        Me.cbRegion.Items.AddRange(New Object() {"Region I – Ilocos Region", "Region II – Cagayan Valley", "Region III – Central Luzon", "Region IV A – CALABARZON", "Region IX – Zamboanga Peninsula", "Region V – Bicol Region", "Region VI – Western Visayas", "Region VII – Central Visayas", "Region VIII – Eastern Visayas", "Region X – Northern Mindanao", "Region XI – Davao Region", "Region XII – SOCCSKSARGEN", "Region XIII – Caraga", "BARMM – Bangsamoro Autonomous Region in Muslim Mindanao", "CAR – Cordillera Administrative Region", "MIMAROPA Region", "NCR – National Capital Region"})
        Me.cbRegion.Location = New System.Drawing.Point(343, 254)
        Me.cbRegion.Name = "cbRegion"
        Me.cbRegion.Size = New System.Drawing.Size(246, 23)
        Me.cbRegion.TabIndex = 125
        Me.cbRegion.Text = "Region I – Ilocos Region"
        '
        'cbProvince
        '
        Me.cbProvince.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbProvince.ForeColor = System.Drawing.Color.Black
        Me.cbProvince.FormattingEnabled = True
        Me.cbProvince.Items.AddRange(New Object() {"Abra", "Agusan del Norte", "Agusan del Sur", "Aklan", "Albay", "Antique", "Apayao", "Aurora", "Basilan", "Bataan", "Batanes", "Batangas", "Benguet", "Biliran", "Bohol", "Bukidnon", "Bulacan", "Cagayan", "Camarines Norte", "Camarines Sur", "Camiguin", "Capiz", "Catanduanes", "Cavite", "Cebu[viii]", "Cotabato", "Davao de Oro", "Davao del Norte", "Davao del Sur", "Davao Occidental", "Davao Oriental", "Dinagat Islands", "Eastern Samar", "Guimaras", "Ifugao", "Ilocos Norte", "Ilocos Sur", "Iloilo", "Isabela", "Kalinga", "La Union", "Laguna", "Lanao del Norte", "Lanao del Sur", "Leyte", "Maguindanao", "Marinduque", "Masbate", "Metro Manila", "Misamis Occidental", "Misamis Oriental", "Mountain Province", "Negros Occidental", "Negros Oriental", "Northern Samar", "Nueva Ecija", "Nueva Vizcaya", "Occidental Mindoro", "Oriental Mindoro", "Palawan", "Pampanga", "Pangasinan", "Quezon", "Quirino", "Rizal", "Romblon", "Samar", "Sarangani", "Siquijor", "Sorsogon", "South Cotabato", "Southern Leyte", "Sultan Kudarat", "Sulu", "Surigao del Norte", "Surigao del Sur", "Tarlac", "Tawi-Tawi", "Zambales", "Zamboanga del Norte", "Zamboanga del Sur", "Zamboanga Sibugay"})
        Me.cbProvince.Location = New System.Drawing.Point(343, 203)
        Me.cbProvince.Name = "cbProvince"
        Me.cbProvince.Size = New System.Drawing.Size(246, 23)
        Me.cbProvince.TabIndex = 124
        Me.cbProvince.Text = "Province"
        '
        'cbCity
        '
        Me.cbCity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbCity.ForeColor = System.Drawing.Color.Black
        Me.cbCity.FormattingEnabled = True
        Me.cbCity.Items.AddRange(New Object() {"Alaminos", "Angeles City", "Antipolo", "Bacolod", "Bacoor", "Bago", "Baguio", "Bais", "Balanga", "Batac", "Batangas City", "Bayawan", "Baybay", "Bayugan", "Biñan", "Bislig", "Bogo", "Borongan", "Butuan", "Cabadbaran", "Cabanatuan", "Cabuyao", "Cadiz", "Cagayan de Oro", "Calamba", "Calapan", "Calbayog", "Caloocan", "Candon", "Canlaon", "Carcar", "Catbalogan", "Cauayan", "Cavite City", "Cebu City", "Cotabato City", "Dagupan", "Danao", "Dapitan", "Dasmariñas", "Davao City", "Digos", "Dipolog", "Dumaguete", "El Salvador", "Escalante", "Gapan", "General Santos", "General Trias", "Gingoog", "Guihulngan", "Himamaylan", "Ilagan", "Iligan", "Iloilo City", "Imus", "Iriga", "Isabela", "Kabankalan", "Kidapawan", "Koronadal", "La Carlota", "Lamitan", "Laoag", "Lapu-Lapu City", "Las Piñas", "Legazpi", "Ligao", "Lipa", "Lucena", "Maasin", "Mabalacat", "Makati", "Malabon", "Malaybalay", "Malolos", "Mandaluyong", "Mandaue", "Manila", "Marawi", "Marikina", "Masbate City", "Mati", "Meycauayan", "Muñoz", "Muntinlupa", "Naga", "Navotas", "Olongapo", "Ormoc", "Oroquieta", "Ozamiz", "Pagadian", "Palayan", "Panabo", "Parañaque", "Pasay", "Pasig", "Passi", "Puerto Princesa", "Quezon City", "Roxas", "Sagay", "Samal", "San Carlos", "San Fernando", "San Jose", "San Jose del Monte", "San Juan", "San Pablo", "San Pedro", "Santa Rosa", "Santo Tomas", "Santiago", "Silay", "Sipalay", "Sorsogon City", "Surigao City", "Tabaco", "Tabuk", "Tacloban", "Tacurong", "Tagaytay", "Tagbilaran", "Taguig", "Tagum", "Talisay", "Tanauan", "Tandag", "Tangub", "Tanjay", "Tarlac City", "Tayabas", "Toledo", "Trece Martires", "Tuguegarao", "Urdaneta", "Valencia", "Valenzuela", "Victorias", "Vigan", "Zamboanga City"})
        Me.cbCity.Location = New System.Drawing.Point(343, 152)
        Me.cbCity.Name = "cbCity"
        Me.cbCity.Size = New System.Drawing.Size(246, 23)
        Me.cbCity.TabIndex = 123
        Me.cbCity.Text = "City/Town"
        '
        'bday
        '
        Me.bday.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bday.CustomFormat = "yyyy-MM-dd"
        Me.bday.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bday.Location = New System.Drawing.Point(31, 316)
        Me.bday.Name = "bday"
        Me.bday.Size = New System.Drawing.Size(222, 23)
        Me.bday.TabIndex = 116
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(343, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 14)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Province"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(343, 287)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 14)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Country"
        '
        'txtStreet
        '
        Me.txtStreet.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtStreet.Location = New System.Drawing.Point(343, 51)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(245, 23)
        Me.txtStreet.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(343, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Street"
        '
        'btnDeactivate
        '
        Me.btnDeactivate.BackColor = System.Drawing.Color.Fuchsia
        Me.btnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeactivate.Location = New System.Drawing.Point(224, 804)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.Size = New System.Drawing.Size(200, 37)
        Me.btnDeactivate.TabIndex = 37
        Me.btnDeactivate.Text = "Deactivate Account"
        Me.btnDeactivate.UseVisualStyleBackColor = False
        '
        'txtConfirmNewPass
        '
        Me.txtConfirmNewPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtConfirmNewPass.Location = New System.Drawing.Point(31, 545)
        Me.txtConfirmNewPass.Name = "txtConfirmNewPass"
        Me.txtConfirmNewPass.Size = New System.Drawing.Size(194, 23)
        Me.txtConfirmNewPass.TabIndex = 32
        '
        'txtNewPass
        '
        Me.txtNewPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNewPass.Location = New System.Drawing.Point(31, 502)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(193, 23)
        Me.txtNewPass.TabIndex = 31
        '
        'txtcurrentPass
        '
        Me.txtcurrentPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtcurrentPass.Location = New System.Drawing.Point(31, 458)
        Me.txtcurrentPass.Name = "txtcurrentPass"
        Me.txtcurrentPass.Size = New System.Drawing.Size(194, 23)
        Me.txtcurrentPass.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(28, 441)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 14)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Current Password"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(27, 484)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 14)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "New Password"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(28, 527)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(162, 14)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Confirm New Password"
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.BackColor = System.Drawing.Color.Transparent
        Me.rbFemale.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbFemale.Location = New System.Drawing.Point(110, 265)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(63, 19)
        Me.rbFemale.TabIndex = 21
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = False
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.BackColor = System.Drawing.Color.Transparent
        Me.rbMale.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbMale.Location = New System.Drawing.Point(28, 265)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(51, 19)
        Me.rbMale.TabIndex = 20
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = False
        '
        'txtcontactNumber
        '
        Me.txtcontactNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtcontactNumber.Location = New System.Drawing.Point(30, 207)
        Me.txtcontactNumber.Name = "txtcontactNumber"
        Me.txtcontactNumber.Size = New System.Drawing.Size(222, 23)
        Me.txtcontactNumber.TabIndex = 19
        '
        'txtemailAddress
        '
        Me.txtemailAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtemailAddress.Location = New System.Drawing.Point(30, 156)
        Me.txtemailAddress.Name = "txtemailAddress"
        Me.txtemailAddress.Size = New System.Drawing.Size(221, 23)
        Me.txtemailAddress.TabIndex = 18
        '
        'txtlastName
        '
        Me.txtlastName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtlastName.Location = New System.Drawing.Point(31, 103)
        Me.txtlastName.Name = "txtlastName"
        Me.txtlastName.Size = New System.Drawing.Size(221, 23)
        Me.txtlastName.TabIndex = 17
        '
        'txtmiddleInitial
        '
        Me.txtmiddleInitial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtmiddleInitial.Location = New System.Drawing.Point(259, 51)
        Me.txtmiddleInitial.Name = "txtmiddleInitial"
        Me.txtmiddleInitial.Size = New System.Drawing.Size(46, 23)
        Me.txtmiddleInitial.TabIndex = 16
        '
        'txtzipCode
        '
        Me.txtzipCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtzipCode.Location = New System.Drawing.Point(343, 356)
        Me.txtzipCode.Name = "txtzipCode"
        Me.txtzipCode.Size = New System.Drawing.Size(106, 23)
        Me.txtzipCode.TabIndex = 15
        '
        'txtBarangay
        '
        Me.txtBarangay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBarangay.Location = New System.Drawing.Point(343, 103)
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.Size = New System.Drawing.Size(245, 23)
        Me.txtBarangay.TabIndex = 12
        '
        'txtfirstName
        '
        Me.txtfirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtfirstName.Location = New System.Drawing.Point(30, 51)
        Me.txtfirstName.Name = "txtfirstName"
        Me.txtfirstName.Size = New System.Drawing.Size(223, 23)
        Me.txtfirstName.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(343, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 14)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Region"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(343, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 14)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Zip Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(343, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 14)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "City / Town"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(343, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Barangay"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(27, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Birth Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(28, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(31, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contact Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(28, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(259, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "M.I."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(31, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last name"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.BackColor = System.Drawing.Color.Transparent
        Me.lblFName.Location = New System.Drawing.Point(31, 30)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(77, 14)
        Me.lblFName.TabIndex = 0
        Me.lblFName.Text = "First name"
        '
        'btnAddPic
        '
        Me.btnAddPic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddPic.BackColor = System.Drawing.Color.Transparent
        Me.btnAddPic.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.cam
        Me.btnAddPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddPic.Location = New System.Drawing.Point(341, 129)
        Me.btnAddPic.Name = "btnAddPic"
        Me.btnAddPic.Size = New System.Drawing.Size(30, 25)
        Me.btnAddPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAddPic.TabIndex = 24
        Me.btnAddPic.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProfileeditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 30)
        Me.BackColor = System.Drawing.Color.Violet
        Me.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.DarkerGradient_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(660, 491)
        Me.Controls.Add(Me.btnAddPic)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximumSize = New System.Drawing.Size(660, 491)
        Me.Name = "ProfileeditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile Edit"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnAddPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnsaveChanges As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents txtcontactNumber As TextBox
    Friend WithEvents txtemailAddress As TextBox
    Friend WithEvents txtlastName As TextBox
    Friend WithEvents txtmiddleInitial As TextBox
    Friend WithEvents txtzipCode As TextBox
    Friend WithEvents txtBarangay As TextBox
    Friend WithEvents txtfirstName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents btnAddPic As PictureBox
    Friend WithEvents btnDeactivate As Button
    Friend WithEvents txtConfirmNewPass As TextBox
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents txtcurrentPass As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents bday As DateTimePicker
    Friend WithEvents cbCountry As ComboBox
    Friend WithEvents cbRegion As ComboBox
    Friend WithEvents cbProvince As ComboBox
    Friend WithEvents cbCity As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnChangePass As Button
End Class
