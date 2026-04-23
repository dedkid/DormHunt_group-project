<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp_Location_Form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblQLocation = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbCountry = New System.Windows.Forms.ComboBox()
        Me.cbRegion = New System.Windows.Forms.ComboBox()
        Me.cbProvince = New System.Windows.Forms.ComboBox()
        Me.cbCity = New System.Windows.Forms.ComboBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtBrgy = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblQLocation)
        Me.Panel1.Location = New System.Drawing.Point(37, 110)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 400)
        Me.Panel1.TabIndex = 0
        '
        'lblQLocation
        '
        Me.lblQLocation.AutoSize = True
        Me.lblQLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblQLocation.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblQLocation.ForeColor = System.Drawing.Color.White
        Me.lblQLocation.Location = New System.Drawing.Point(45, 154)
        Me.lblQLocation.Name = "lblQLocation"
        Me.lblQLocation.Size = New System.Drawing.Size(300, 74)
        Me.lblQLocation.TabIndex = 8
        Me.lblQLocation.Text = "What is your current " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "address?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblQLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSize = True
        Me.Panel2.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.mapbg
        Me.Panel2.Controls.Add(Me.cbCountry)
        Me.Panel2.Controls.Add(Me.cbRegion)
        Me.Panel2.Controls.Add(Me.cbProvince)
        Me.Panel2.Controls.Add(Me.cbCity)
        Me.Panel2.Controls.Add(Me.txtZipCode)
        Me.Panel2.Controls.Add(Me.btnNext)
        Me.Panel2.Controls.Add(Me.txtStreet)
        Me.Panel2.Controls.Add(Me.txtBrgy)
        Me.Panel2.Location = New System.Drawing.Point(443, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 400)
        Me.Panel2.TabIndex = 120
        '
        'cbCountry
        '
        Me.cbCountry.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbCountry.ForeColor = System.Drawing.Color.Black
        Me.cbCountry.FormattingEnabled = True
        Me.cbCountry.Items.AddRange(New Object() {"Philippines"})
        Me.cbCountry.Location = New System.Drawing.Point(53, 25)
        Me.cbCountry.Name = "cbCountry"
        Me.cbCountry.Size = New System.Drawing.Size(295, 28)
        Me.cbCountry.TabIndex = 122
        Me.cbCountry.Text = "Country"
        '
        'cbRegion
        '
        Me.cbRegion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbRegion.ForeColor = System.Drawing.Color.Black
        Me.cbRegion.FormattingEnabled = True
        Me.cbRegion.Items.AddRange(New Object() {"Region I – Ilocos Region", "Region II – Cagayan Valley", "Region III – Central Luzon", "Region IV A – CALABARZON", "Region IX – Zamboanga Peninsula", "Region V – Bicol Region", "Region VI – Western Visayas", "Region VII – Central Visayas", "Region VIII – Eastern Visayas", "Region X – Northern Mindanao", "Region XI – Davao Region", "Region XII – SOCCSKSARGEN", "Region XIII – Caraga", "BARMM – Bangsamoro Autonomous Region in Muslim Mindanao", "CAR – Cordillera Administrative Region", "MIMAROPA Region", "NCR – National Capital Region"})
        Me.cbRegion.Location = New System.Drawing.Point(53, 68)
        Me.cbRegion.Name = "cbRegion"
        Me.cbRegion.Size = New System.Drawing.Size(295, 28)
        Me.cbRegion.TabIndex = 121
        Me.cbRegion.Text = "Region I – Ilocos Region"
        '
        'cbProvince
        '
        Me.cbProvince.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbProvince.ForeColor = System.Drawing.Color.Black
        Me.cbProvince.FormattingEnabled = True
        Me.cbProvince.Items.AddRange(New Object() {"Abra", "Agusan del Norte", "Agusan del Sur", "Aklan", "Albay", "Antique", "Apayao", "Aurora", "Basilan", "Bataan", "Batanes", "Batangas", "Benguet", "Biliran", "Bohol", "Bukidnon", "Bulacan", "Cagayan", "Camarines Norte", "Camarines Sur", "Camiguin", "Capiz", "Catanduanes", "Cavite", "Cebu[viii]", "Cotabato", "Davao de Oro", "Davao del Norte", "Davao del Sur", "Davao Occidental", "Davao Oriental", "Dinagat Islands", "Eastern Samar", "Guimaras", "Ifugao", "Ilocos Norte", "Ilocos Sur", "Iloilo", "Isabela", "Kalinga", "La Union", "Laguna", "Lanao del Norte", "Lanao del Sur", "Leyte", "Maguindanao", "Marinduque", "Masbate", "Metro Manila", "Misamis Occidental", "Misamis Oriental", "Mountain Province", "Negros Occidental", "Negros Oriental", "Northern Samar", "Nueva Ecija", "Nueva Vizcaya", "Occidental Mindoro", "Oriental Mindoro", "Palawan", "Pampanga", "Pangasinan", "Quezon", "Quirino", "Rizal", "Romblon", "Samar", "Sarangani", "Siquijor", "Sorsogon", "South Cotabato", "Southern Leyte", "Sultan Kudarat", "Sulu", "Surigao del Norte", "Surigao del Sur", "Tarlac", "Tawi-Tawi", "Zambales", "Zamboanga del Norte", "Zamboanga del Sur", "Zamboanga Sibugay"})
        Me.cbProvince.Location = New System.Drawing.Point(53, 114)
        Me.cbProvince.Name = "cbProvince"
        Me.cbProvince.Size = New System.Drawing.Size(295, 28)
        Me.cbProvince.TabIndex = 120
        Me.cbProvince.Text = "Province"
        '
        'cbCity
        '
        Me.cbCity.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbCity.ForeColor = System.Drawing.Color.Black
        Me.cbCity.FormattingEnabled = True
        Me.cbCity.Items.AddRange(New Object() {"Alaminos", "Angeles City", "Antipolo", "Bacolod", "Bacoor", "Bago", "Baguio", "Bais", "Balanga", "Batac", "Batangas City", "Bayawan", "Baybay", "Bayugan", "Biñan", "Bislig", "Bogo", "Borongan", "Butuan", "Cabadbaran", "Cabanatuan", "Cabuyao", "Cadiz", "Cagayan de Oro", "Calamba", "Calapan", "Calbayog", "Caloocan", "Candon", "Canlaon", "Carcar", "Catbalogan", "Cauayan", "Cavite City", "Cebu City", "Cotabato City", "Dagupan", "Danao", "Dapitan", "Dasmariñas", "Davao City", "Digos", "Dipolog", "Dumaguete", "El Salvador", "Escalante", "Gapan", "General Santos", "General Trias", "Gingoog", "Guihulngan", "Himamaylan", "Ilagan", "Iligan", "Iloilo City", "Imus", "Iriga", "Isabela", "Kabankalan", "Kidapawan", "Koronadal", "La Carlota", "Lamitan", "Laoag", "Lapu-Lapu City", "Las Piñas", "Legazpi", "Ligao", "Lipa", "Lucena", "Maasin", "Mabalacat", "Makati", "Malabon", "Malaybalay", "Malolos", "Mandaluyong", "Mandaue", "Manila", "Marawi", "Marikina", "Masbate City", "Mati", "Meycauayan", "Muñoz", "Muntinlupa", "Naga", "Navotas", "Olongapo", "Ormoc", "Oroquieta", "Ozamiz", "Pagadian", "Palayan", "Panabo", "Parañaque", "Pasay", "Pasig", "Passi", "Puerto Princesa", "Quezon City", "Roxas", "Sagay", "Samal", "San Carlos", "San Fernando", "San Jose", "San Jose del Monte", "San Juan", "San Pablo", "San Pedro", "Santa Rosa", "Santo Tomas", "Santiago", "Silay", "Sipalay", "Sorsogon City", "Surigao City", "Tabaco", "Tabuk", "Tacloban", "Tacurong", "Tagaytay", "Tagbilaran", "Taguig", "Tagum", "Talisay", "Tanauan", "Tandag", "Tangub", "Tanjay", "Tarlac City", "Tayabas", "Toledo", "Trece Martires", "Tuguegarao", "Urdaneta", "Valencia", "Valenzuela", "Victorias", "Vigan", "Zamboanga City"})
        Me.cbCity.Location = New System.Drawing.Point(53, 164)
        Me.cbCity.Name = "cbCity"
        Me.cbCity.Size = New System.Drawing.Size(295, 28)
        Me.cbCity.TabIndex = 119
        Me.cbCity.Text = "City/Town"
        '
        'txtZipCode
        '
        Me.txtZipCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtZipCode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtZipCode.ForeColor = System.Drawing.Color.Black
        Me.txtZipCode.Location = New System.Drawing.Point(53, 298)
        Me.txtZipCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.PlaceholderText = "Zip Code"
        Me.txtZipCode.Size = New System.Drawing.Size(311, 27)
        Me.txtZipCode.TabIndex = 5
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.BackColor = System.Drawing.Color.Red
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNext.Location = New System.Drawing.Point(142, 345)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(129, 35)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'txtStreet
        '
        Me.txtStreet.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStreet.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtStreet.ForeColor = System.Drawing.Color.Black
        Me.txtStreet.Location = New System.Drawing.Point(53, 253)
        Me.txtStreet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.PlaceholderText = "Street"
        Me.txtStreet.Size = New System.Drawing.Size(311, 27)
        Me.txtStreet.TabIndex = 3
        '
        'txtBrgy
        '
        Me.txtBrgy.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBrgy.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBrgy.ForeColor = System.Drawing.Color.Black
        Me.txtBrgy.Location = New System.Drawing.Point(53, 210)
        Me.txtBrgy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBrgy.Name = "txtBrgy"
        Me.txtBrgy.PlaceholderText = "Barangay"
        Me.txtBrgy.Size = New System.Drawing.Size(311, 27)
        Me.txtBrgy.TabIndex = 116
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.FinalProjectOOP.My.Resources.Resource1.dhLogoHorizontal
        Me.PictureBox1.Location = New System.Drawing.Point(229, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(423, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
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
        Me.btnBack.TabIndex = 115
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'SignUp_Location_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.DarkerGradient_Background
        Me.ClientSize = New System.Drawing.Size(895, 548)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(895, 538)
        Me.Name = "SignUp_Location_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up Location"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNext As Button
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents lblQLocation As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents txtBrgy As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbCountry As ComboBox
    Friend WithEvents cbRegion As ComboBox
    Friend WithEvents cbProvince As ComboBox
    Friend WithEvents cbCity As ComboBox
End Class
