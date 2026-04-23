Imports System.Data.OleDb
Public Class Landlord_Edit_Listing_Form
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim i
    Dim Selected2
    Dim gotUidELF
    Public Sub New(ByVal Selected1 As Integer, ByVal gotUidMD As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        Selected2 = CInt(Selected1)
        gotUidELF = CInt(gotUidMD)
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub Landlord_Edit_Listing_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()
            sql = "SELECT Type, Price, Location, Description, MaxPeople, Picture from UnverifiedListingTable where ListingID=" & Val(Selected2)

            cmd.Connection = con
            cmd.CommandText = sql
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            lblType.Text = myreader("Type")
            LTxtPrice.Text = myreader("Price")
            LTxtAddress.Text = myreader("Location")
            txtDescription.Text = myreader("Description")
            LTxtAvailability.Text = myreader("MaxPeople")
            'for picture
            Dim arrimg() As Byte = myreader("Picture")
            Dim mstream As New System.IO.MemoryStream(arrimg)
            LPicDetails.Image = Image.FromStream(mstream)
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            sql = "SELECT MobileNumber, Email from UserTable where UserID=" & Val(gotUidELF)
            cmd.Connection = con
            cmd.CommandText = sql
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            LTxtMobileNumber.Text = myreader("MobileNumber")
            LTxtEmailAdd.Text = myreader("Email")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub


    Private Sub LBtnSave_Click(sender As Object, e As EventArgs) Handles LBtnSave.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            'Image
            Dim mstream As New System.IO.MemoryStream()
            LPicDetails.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            mstream.Close()

            con.Open()
            sql = "UPDATE UnverifiedListingTable SET Price = @Price ,Location = @Location ,MaxPeople = @MaxPeople, Description = @Description, Picture= @img Where ListingID = " & Val(Selected2)
            cmd.Parameters.Add("@Price", SqlDbType.VarChar).Value = LTxtPrice.Text
            cmd.Parameters.Add("@Location", SqlDbType.VarChar).Value = LTxtAddress.Text
            cmd.Parameters.Add("@MaxPeople", SqlDbType.VarChar).Value = LTxtAvailability.Text
            cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = txtDescription.Text
            cmd.Parameters.AddWithValue("@img", arrImage)
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been UPDATED successfully!", vbOKOnly, "Record Updated")
            Else
                MsgBox("No record has been UPDATED!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.Hide()
            con.Close()

        End Try
    End Sub
    Private Sub LBtnChangePhoto_Click(sender As Object, e As EventArgs) Handles LBtnChangePhoto.Click
        Dim ofd As New OpenFileDialog
        ofd.FileName = ""
        ofd.Filter = "Jpg, Jpeg Image|*.jpg;*.jpeg|PNG image|*.png|BMP Image|*.bmp|" & "Allfiles (*.*)|*.*"
        If ofd.ShowDialog() = Global.System.Windows.Forms.DialogResult.OK Then
            LPicDetails.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub
End Class