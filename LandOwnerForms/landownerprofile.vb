Imports System.Data.OleDb
Public Class landownerprofile
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim i
    Dim gotUidLDP

    Public Sub New(ByVal gotUidLD As String)
        ' This call is required by the designer.
        InitializeComponent()
        gotUidLDP = CInt(gotUidLD)
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub TAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'round the picbox
        Dim pic As New Drawing2D.GraphicsPath
        pic.AddEllipse(0, 0, 120, 120)
        LProfilePic.Region = New Region(pic)

        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            'load the data from user table
            con.Open()
            sql = "SELECT FirstName, LastName, MiddleName, Gender, BirthDate, MobileNumber, Email, ProfilePicture from UserTable Where UserId=" & Val(gotUidLDP)

            cmd.Connection = con
            cmd.CommandText = sql
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            lblFname.Text = myreader("FirstName")
            lblLname.Text = myreader("LastName")
            lblMI.Text = myreader("MiddleName")
            lblGender.Text = myreader("Gender")
            lblBday.Text = myreader("BirthDate")
            lblEmail.Text = myreader("Email")
            lblContact.Text = myreader("MobileNumber")
            'Profile pic
            Dim arrimg() As Byte = myreader("ProfilePicture")
            Dim mstream As New System.IO.MemoryStream(arrimg)
            LProfilePic.Image = Image.FromStream(mstream)


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        'to  load the address 
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()
            sql = "SELECT Street, Barangay, TownCity, Province, Region, Country, ZipCode FROM AddressTable Where AddressID='" & gotUidLDP & "'"

            cmd.Connection = con
            cmd.CommandText = sql
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            lblStreet.Text = myreader("Street")
            lblBarangay.Text = myreader("Barangay")
            lblCityTown.Text = myreader("TownCity")
            lblProvince.Text = myreader("Province")
            lblCountry.Text = myreader("Country")
            lblZipcode.Text = myreader("ZipCode")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class