Imports System.Data.OleDb
Public Class SignUp_Location_Form

    ' This finds the folder where your .exe is currently running
    Dim dbPath As String = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "DormHuntDB.accdb")

    ' This uses that dynamic path for the connection
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath)
    Dim i
    Dim gotUid
    Public Sub New(ByVal uID As String)
        ' This call is required by the designer.
        InitializeComponent()
        gotUid = CInt(uID)
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    'To get the location of the user
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If String.IsNullOrEmpty(txtBrgy.Text) Or String.IsNullOrEmpty(txtStreet.Text) Or String.IsNullOrEmpty(txtZipCode.Text) Or String.IsNullOrEmpty(cbCity.Text) Or String.IsNullOrEmpty(cbCountry.Text) Or String.IsNullOrEmpty(cbProvince.Text) Or String.IsNullOrEmpty(cbRegion.Text) Then

            MsgBox("Fill up required fields!", vbOKOnly + vbCritical, "Empty Field(s)!")
        Else
            If IsNumeric(txtZipCode.Text) Then
                Try
                    con.Open()
                    Dim sql As String = "INSERT INTO AddressTable(AddressID, Country, Region, Province, TownCity, Barangay, Street, ZipCode) VALUES(@AddressID, @Country, @Region, @Province, @TownCity, @Barangay, @Street, @ZipCode)"
                    Dim cmd As New OleDb.OleDbCommand(sql, con)

                    cmd.Parameters.AddWithValue("AddressID", CStr(gotUid))
                    cmd.Parameters.AddWithValue("Country", cbCountry.Text)
                    cmd.Parameters.AddWithValue("Region", cbRegion.Text)
                    cmd.Parameters.AddWithValue("Province", cbProvince.Text)
                    cmd.Parameters.AddWithValue("TownCity", cbCity.Text)
                    cmd.Parameters.AddWithValue("Barangay", txtBrgy.Text)
                    cmd.Parameters.AddWithValue("Street", txtStreet.Text)
                    cmd.Parameters.AddWithValue("ZipCode", txtZipCode.Text)

                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        Try
                            Dim a
                            Dim sql2 As String = "Update UserTable Set AddressID = '" & gotUid.ToString & "' Where UserID = " & Val(gotUid)
                            Dim cmd2 As New OleDb.OleDbCommand(sql2, con)
                            a = cmd2.ExecuteNonQuery
                            If a > 0 Then
                                MsgBox("Record has been SAVED successfully!")
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                        Me.Hide()
                        LoginForm.Show()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            Else
                MsgBox("Please enter a valid zip code.", vbOKOnly + vbCritical, "Invalid Entry!")
            End If
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        SignUp_Form.Show()
    End Sub

    Private Sub SignUp_Location_Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        'round the backbutton
        Dim btn As New Drawing2D.GraphicsPath
        btn.AddEllipse(0, 0, 45, 45)
        btnBack.Region = New Region(btn)

        cbProvince.Enabled = False
    End Sub

    Private Sub cbRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRegion.SelectedIndexChanged
        Select Case (cbRegion.Text)
            Case "Region I – Ilocos Region"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Ilocos Norte", "Ilocos Sur", "La Union", "Pangasinan"})
            Case "Region II – Cagayan Valley"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Batanes", "Cagayan", "Isabela", "Nueva Vizcaya", "Quirino"})
            Case "Region III – Central Luzon"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Aurora", "Bataan", "Bulacan", "Nueva Ecija", "Pampanga", "Tarlac", "Zambales", "Angeles", "Olongapo"})
            Case "Region IV A – CALABARZON"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Cavite", "Laguna", "Batangas", "Rizal", "Quezon"})
            Case "MIMAROPA Region"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Occidental Mindoro", "Oriental Mindoro", "Marinduque", "Romblon", "Palawan"})
            Case "Region V – Bicol Region"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Albay", "Camarines Norte", "Camarines Sur", "Sorsogon", "Catanduanes", "Masbate"})
            Case "CAR – Cordillera Administrative Region"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Abra", "Apayao", "Benguet", "Ifugao", "Kalinga", "Mountain Province"})
            Case "NCR – National Capital Region"
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Enabled = False
            Case "Region VI – Western Visayas"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Aklan", "Antique", "Capiz", "Guimaras", "Iloilo", "Negros Occidental"})
            Case "Region VII – Central Visayas"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Bohol", "Cebu", "Negros Oriental", "Siquijor"})
            Case "Region VIII – Eastern Visayas"
                cbProvince.Enabled = True
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Biliran", "Leyte", "Northern Samar", "Samar", "Eastern Samar", "Southern Leyte"})
            Case "Region IX – Zamboanga Peninsula"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Zamboanga del Norte", "Zamboanga del Sur", "Zamboanga Sibugay"})
            Case "Region X – Northern Mindanao"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Misamis Oriental", "Misamis Occidental", "Bukidnon", "Camiguin", "Lanao del Norte"})
            Case "Region XI – Davao Region"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Compostela Valley", "Davao del Norte", "Davao del Sur", "Davao Oriental", "Davao Occidental"})
            Case "Region XII – SOCCSKSARGEN"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"South Cotabato", "Cotabato", "Sultan Kudarat", "Saragani", "General Santos"})
            Case "BARMM – Bangsamoro Autonomous Region in Muslim Mindanao"
                cbProvince.Enabled = True
                cbProvince.Text = ""
                cbProvince.Items.Clear()
                cbProvince.Items.AddRange(New String() {"Basilan", "Lanao del Sur", "Maguindanao", "Sulu", "Tawi-Tawi"})
            Case Else
                cbProvince.Items.Clear()
                cbCity.Items.Clear()
                cbRegion.Text = ""
                cbProvince.Text = ""
                MessageBox.Show("Invalid Region")
        End Select
    End Sub
End Class