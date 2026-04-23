Imports System.Data.OleDb
Public Class listing
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim Type As String
    Dim i
    Dim GotUidLF

    Public Sub New(ByVal gotUidLDLF As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        GotUidLF = CInt(gotUidLDLF)
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    'add image to user profile
    Private Sub LbtnUpload_Click(sender As Object, e As EventArgs) Handles LbtnUpload.Click
        Dim ofd As New OpenFileDialog
        ofd.FileName = ""
        ofd.Filter = "Jpg, Jpeg Image|*.jpg;*.jpeg|PNG image|*.png|BMP Image|*.bmp|" & "Allfiles (*.*)|*.*"
        If ofd.ShowDialog() = Global.System.Windows.Forms.DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub LbtnApartment_Click(sender As Object, e As EventArgs) Handles LbtnApartment.Click
        Type = "Apartment"
        MsgBox("Your listing is an aparment", vbOKOnly, "TYPE")
        LbtnApartment.Enabled = False
        LbtnBoardingHouse.Enabled = True
        LbtnDorm.Enabled = True
        LbtnRoom.Enabled = True
        'if the button is clicked the data will be apartment
    End Sub

    Private Sub LbtnDorm_Click(sender As Object, e As EventArgs) Handles LbtnDorm.Click
        Type = "Dorm"
        MsgBox("Your listing is a Dorm", vbOKOnly, "TYPE")
        LbtnApartment.Enabled = True
        LbtnBoardingHouse.Enabled = True
        LbtnDorm.Enabled = False
        LbtnRoom.Enabled = True
        'if the button is clicked the data will be Dorm
    End Sub

    Private Sub LbtnRoom_Click(sender As Object, e As EventArgs) Handles LbtnRoom.Click
        Type = "BedSpacer"
        MsgBox("Your listing is a Bedspace", vbOKOnly, "TYPE")
        LbtnApartment.Enabled = True
        LbtnBoardingHouse.Enabled = True
        LbtnDorm.Enabled = True
        LbtnRoom.Enabled = False
        'if the button is clicked the data will be Room
    End Sub

    Private Sub LbtnBoardingHouse_Click(sender As Object, e As EventArgs) Handles LbtnBoardingHouse.Click
        Type = "Boarding House"
        MsgBox("Your listing is a Boarding House", vbOKOnly, "TYPE")
        LbtnApartment.Enabled = True
        LbtnBoardingHouse.Enabled = False
        LbtnDorm.Enabled = True
        LbtnRoom.Enabled = True
        'if the button is clicked the data will be Boarding House
    End Sub

    Private Sub btnPublish_Click(sender As Object, e As EventArgs) Handles btnPublish.Click
        'Saving the listing in the database
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            'add image neccessary code | open
            Dim mstream As New System.IO.MemoryStream()
            PictureBox2.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            mstream.Close()
            'add image neccessary code | close

            con.Open()

            sql = "INSERT INTO UnverifiedListingTable (`UserID`,`Type`,`Price`,`Location`,`MaxPeople`,`Description`,`Status`,`Picture`) VALUES (@UserID, @Type,@Price,@Location,@MaxPeople, @Description, 'Unverify', @img)"
            cmd.Parameters.AddWithValue("UserID", Val(GotUidLF))
            cmd.Parameters.AddWithValue("Type", Type)
            cmd.Parameters.AddWithValue("Price", LtxtPrice.Text)
            cmd.Parameters.AddWithValue("Location", txtLocation.Text)
            cmd.Parameters.AddWithValue("MaxPeople", LtxtMaxTenant.Text)
            cmd.Parameters.AddWithValue("Description", LtxtDescription.Text)
            cmd.Parameters.AddWithValue("@img", arrImage)

            cmd.Connection = con
            cmd.CommandText = sql


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Listing has been submitted!", vbOKOnly + vbInformation, "SUBMIT")
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            con.Close()
            Me.Hide()
        End Try
    End Sub
    Private Sub LbtnSubtract_Click(sender As Object, e As EventArgs) Handles LbtnSubtract.Click
        Dim mintenant As Integer
        If LtxtMaxTenant.Text > 0 Then
            mintenant = LtxtMaxTenant.Text
            mintenant -= 1
            LtxtMaxTenant.Text = mintenant
        ElseIf LtxtMaxTenant.Text <= 0 Then
            MsgBox("Please enter a valid number of tenants!", vbExclamation + vbOKOnly, "Error")
        Else
            MsgBox("Invalid Entry!", vbOKOnly + vbCritical, "Error")
        End If
    End Sub
    Private Sub LbtnAddition_Click(sender As Object, e As EventArgs) Handles LbtnAddition.Click
        Dim maxtenant As Integer
        maxtenant = LtxtMaxTenant.Text
        maxtenant += 1
        LtxtMaxTenant.Text = maxtenant
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub listing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'round the backbutton
        Dim btn As New Drawing2D.GraphicsPath
        btn.AddEllipse(0, 0, 45, 45)
        btnBack.Region = New Region(btn)
    End Sub
End Class