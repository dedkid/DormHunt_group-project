Imports System.Data.OleDb
Public Class ProfileeditForm
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim i
    Dim Gender As String
    Dim BirthDate As String
    Dim gotUidPEF
    Dim gotUidLDEF
    Dim userTypeL
    Dim currentP
    'for tenant
    Public Sub New(ByVal gotUidTDB As String)
        ' This call is required by the designer.
        InitializeComponent()
        gotUidPEF = CInt(gotUidTDB)
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    'for landowner
    Public Sub New(ByVal gotUidLD As String, ByVal utype As String)
        ' This call is required by the designer.
        InitializeComponent()
        gotUidLDEF = CInt(gotUidLD)
        userTypeL = utype
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    'add image to user profile
    Private Sub btnAddPic_Click(sender As Object, e As EventArgs) Handles btnAddPic.Click
        Dim ofd As New OpenFileDialog
        ofd.FileName = ""
        ofd.Filter = "Jpg, Jpeg Image|*.jpg;*.jpeg|PNG image|*.png|BMP Image|*.bmp|" & "Allfiles (*.*)|*.*"
        If ofd.ShowDialog() = Global.System.Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub btnsaveChanges_Click(sender As Object, e As EventArgs) Handles btnsaveChanges.Click
        If String.IsNullOrEmpty(txtBarangay.Text) Or String.IsNullOrEmpty(txtcontactNumber.Text) Or String.IsNullOrEmpty(txtemailAddress.Text) Or String.IsNullOrEmpty(txtfirstName.Text) Or String.IsNullOrEmpty(txtlastName.Text) Or String.IsNullOrEmpty(txtmiddleInitial.Text) Then
            MsgBox("Fill up required fields!", vbOKOnly + vbCritical, "Empty Field(s)")
        Else
            If IsNumeric(txtcontactNumber.Text) Then
                'To Update user table
                Try
                    Dim sql As String
                    Dim cmd As New OleDb.OleDbCommand

                    'add image neccessary code open
                    Dim mstream As New System.IO.MemoryStream()
                    PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer()
                    mstream.Close()
                    'add image neccessary code close

                    If rbMale.Checked = True Then
                        Gender = "Male"
                    End If
                    If rbFemale.Checked = True Then
                        Gender = "Female"
                    End If
                    BirthDate = bday.Text

                    con.Open()
                    If userTypeL = "LandOwner" Then
                        sql = "UPDATE UserTable Set FirstName='" & txtfirstName.Text & "', MiddleName='" & txtmiddleInitial.Text & "', LastName='" & txtlastName.Text & "', Gender='" & Gender & "', MobileNumber='" & txtcontactNumber.Text & "', Email='" & txtemailAddress.Text & "', BirthDate='" & bday.Text & "', ProfilePicture = @img  Where UserID = " & Val(gotUidLDEF)
                    Else
                        sql = "UPDATE UserTable Set FirstName='" & txtfirstName.Text & "', MiddleName='" & txtmiddleInitial.Text & "', LastName='" & txtlastName.Text & "', Gender='" & Gender & "', MobileNumber='" & txtcontactNumber.Text & "', Email='" & txtemailAddress.Text & "', BirthDate='" & bday.Text & "', ProfilePicture = @img  Where UserID = " & Val(gotUidPEF)
                    End If
                    cmd.Connection = con
                    cmd.CommandText = sql
                    cmd.Parameters.AddWithValue("@img", arrImage)

                    i = cmd.ExecuteNonQuery
                    'If i > 0 Then
                    '    MsgBox("Record has been UPDATED successfully!", vbOKOnly , "UPDATED")
                    'Else
                    '    MsgBox("No Record has been UPDATED!")
                    'End If

                Catch ex As Exception
                    'MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try

                'to update address of the user
                Try
                    Dim sql As String
                    Dim cmd As New OleDb.OleDbCommand
                    con.Open()
                    If userTypeL = "LandOwner" Then
                        sql = "UPDATE AddressTable Set Street='" & txtStreet.Text & "', Barangay='" & txtBarangay.Text & "', TownCity='" & cbCity.Text & "', Province='" & cbProvince.Text & "', Region='" & cbRegion.Text & "', Country='" & cbCountry.Text & "', ZipCode='" & txtzipCode.Text & "' Where AddressID='" & gotUidLDEF & "'"
                    Else
                        sql = "UPDATE AddressTable Set Street='" & txtStreet.Text & "', Barangay='" & txtBarangay.Text & "', TownCity='" & cbCity.Text & "', Province='" & cbProvince.Text & "', Region='" & cbRegion.Text & "', Country='" & cbCountry.Text & "', ZipCode='" & txtzipCode.Text & "' Where AddressID='" & gotUidPEF & "'"
                    End If

                    cmd.Connection = con
                    cmd.CommandText = sql

                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Record has been UPDATED successfully!", vbOKOnly, "UPDATED")
                    Else
                        MsgBox("No record has been UPDATED!")
                    End If
                Catch ex As Exception
                    '  MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            Else
                MsgBox("Please write a valid phone number.", vbOKOnly + vbExclamation, "Invalid Entry!")
            End If
        End If

    End Sub

    'to initially display currently save data of the user from user table
    Private Sub ProfileeditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'round the picbox
        Dim pic As New Drawing2D.GraphicsPath
        pic.AddEllipse(0, 0, 120, 120)
        PictureBox1.Region = New Region(pic)
        'round the picbox
        Dim pic2 As New Drawing2D.GraphicsPath
        pic2.AddEllipse(0, 0, 30, 25)
        btnAddPic.Region = New Region(pic2)

        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()
            If userTypeL = "LandOwner" Then
                sql = "SELECT FirstName, LastName, MiddleName, Gender, MobileNumber, Email, BirthDate, UserPassword, ProfilePicture from UserTable Where UserId=" & Val(gotUidLDEF)
            Else
                sql = "SELECT FirstName, LastName, MiddleName, Gender, MobileNumber, Email, BirthDate, UserPassword, ProfilePicture from UserTable Where UserId=" & Val(gotUidPEF)
            End If
            cmd.Connection = con
            cmd.CommandText = sql
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            txtfirstName.Text = myreader("FirstName")
            txtlastName.Text = myreader("LastName")
            txtmiddleInitial.Text = myreader("MiddleName")
            txtemailAddress.Text = myreader("Email")
            txtcontactNumber.Text = myreader("MobileNumber")
            Gender = myreader("Gender")
            BirthDate = myreader("BirthDate")
            currentP = myreader("UserPassword")
            'to load image 
            Dim arrimg() As Byte = myreader("ProfilePicture")
            Dim mstream As New System.IO.MemoryStream(arrimg)
            PictureBox1.Image = Image.FromStream(mstream)


            If Gender = "Male" Then
                rbMale.Checked = True
            End If
            If Gender = "Female" Then
                rbFemale.Checked = True
            End If

            bday.Text = BirthDate

        Catch ex As Exception
            ' MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        'load the address of the user
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()
            If userTypeL = "LandOwner" Then
                sql = "SELECT Street, Barangay, TownCity, Province, Region, Country, ZipCode from AddressTable Where AddressID='" & gotUidLDEF & "'"
            Else
                sql = "SELECT Street, Barangay, TownCity, Province, Region, Country, ZipCode from AddressTable Where AddressID='" & gotUidPEF & "'"
            End If
            cmd.Connection = con
            cmd.CommandText = sql
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            txtStreet.Text = myreader("Street")
            txtBarangay.Text = myreader("Barangay")
            cbCity.Text = myreader("TownCity")
            cbProvince.Text = myreader("Province")
            cbRegion.Text = myreader("Region")
            cbCountry.Text = myreader("Country")
            txtzipCode.Text = myreader("ZipCode")

        Catch ex As Exception
            ' MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        If String.IsNullOrEmpty(txtcurrentPass.Text) Or String.IsNullOrEmpty(txtNewPass.Text) Or String.IsNullOrEmpty(txtConfirmNewPass.Text) Then
            MsgBox("Please fill up all required fields.")
        Else
            If currentP = txtcurrentPass.Text Then
                Try
                    Dim sql As String
                    Dim cmd As New OleDb.OleDbCommand
                    con.Open()
                    If userTypeL = "LandOwner" Then
                        sql = "UPDATE UserTable Set  UserPassword ='" & txtNewPass.Text & "'  Where UserID = " & Val(gotUidLDEF)
                    Else
                        sql = "UPDATE UserTable Set  UserPassword ='" & txtNewPass.Text & "'  Where UserID = " & Val(gotUidPEF)
                    End If
                    cmd.Connection = con
                    cmd.CommandText = sql

                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Password Updated", vbOKOnly, "Changed Password")
                    Else
                        MsgBox("Can't change password.")
                    End If

                Catch ex As Exception
                    'MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            Else
                MsgBox("Current Password does not match.", vbOKOnly, "ERROR")
            End If
        End If
    End Sub
End Class


