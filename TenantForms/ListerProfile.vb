Imports System.Data.OleDb
Public Class ListerProfile
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim listerIDLP

    Public Sub New(ByVal UIDofLister As String)
        ' This call is required by the designer.
        InitializeComponent()
        listerIDLP = CInt(UIDofLister)
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub ListerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load the data of the lister from user table
        Try
            Dim Sql As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()

            Sql = "Select * From UserTable Where UserID =" & Val(listerIDLP)
            cmd.Connection = con
            cmd.CommandText = Sql
            da.SelectCommand = cmd

            da.Fill(dt)

            lblFname.Text = dt.Rows(0)("FirstName").ToString
            lblMI.Text = dt.Rows(0)("MiddleName").ToString
            lblLname.Text = dt.Rows(0)("LastName").ToString
            Dim d = dt.Rows(0)("BirthDate").ToString
            lblBday.Text = Format(d, "Long Date")
            lblContact.Text = dt.Rows(0)("MobileNumber").ToString
            lblEmail.Text = dt.Rows(0)("Email").ToString
            'load image of lister
            Dim arrimg() As Byte = dt.Rows(0).Item("Picture")
            Dim mstream As New System.IO.MemoryStream(arrimg)
            LProfilePic.Image = Image.FromStream(mstream)
            ''round the picbox
            'Dim pic As New Drawing2D.GraphicsPath
            'pic.AddEllipse(0, 0, 120, 120)
            'LProfilePic.Region = New Region(pic)

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        'load the address
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()
            sql = "SELECT Street, Barangay, TownCity, Province, Region, Country, ZipCode from AddressTable Where AddressID='" & listerIDLP & "'"

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
            'MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub
End Class