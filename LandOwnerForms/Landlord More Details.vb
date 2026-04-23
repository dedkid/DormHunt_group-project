Imports System.Data.OleDb
Public Class Landlord_More_Details
 Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim i
    Dim gotUidMD
    Dim Selected1
    Public Sub New(ByVal selectedListing As Integer, ByVal gotUidLDLF As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        Selected1 = CInt(selectedListing)
        gotUidMD = CInt(gotUidLDLF)
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim EditListingForm = New Landlord_Edit_Listing_Form(Selected1, gotUidMD)
        EditListingForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnRemoveListing_Click(sender As Object, e As EventArgs) Handles btnRemoveListing.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            sql = " Delete * from UnverifiedListingTable WHERE ListingID=" & Val(Selected1) & " And ListingID = " & Val(Selected1)
            cmd.Connection = con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been deleted successfully!", vbOKOnly, "Delete Listing")

                'notify the landowner about deleted listing
                Try
                    Dim sql2 As String
                    Dim cmd2 As New OleDb.OleDbCommand
                    Dim theDate = DateTime.Today.ToString("'#'yyyy'/'MM'/'dd'#'")
                    Dim desN As String = "You've deleted your listing number " & CStr(Selected1) & " ."

                    sql2 = "Insert Into NotificationTable(UserID, nTime, Title, Description) Values(" & Val(gotUidMD) & "," & CStr(theDate) & ",'Listing Deleted', '" & CStr(desN) & "')"

                    cmd2.Connection = con
                    cmd2.CommandText = sql
                    i = cmd2.ExecuteNonQuery
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try

            Else
                MsgBox("No Record has been deleted!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub Landlord_More_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()
            sql = "SELECT Type, Price, Location,Description, MaxPeople, Picture from UnverifiedListingTable where ListingID=" & Val(Selected1)

            cmd.Connection = con
            cmd.CommandText = sql
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            lblType.Text = myreader("Type")
            lblPrice.Text = myreader("Price")
            lblDescription.Text = myreader("Description")
            lblAddress.Text = myreader("Location")
            lblAvailability.Text = myreader("MaxPeople")
            'for picture
            Dim arrimg() As Byte = myreader("Picture")
            Dim mstream As New System.IO.MemoryStream(arrimg)
            picboxPhoto.Image = Image.FromStream(mstream)
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            sql = "SELECT MobileNumber, Email from UserTable where UserID=" & Val(gotUidMD)
            cmd.Connection = con
            cmd.CommandText = sql
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            lblMobileNumber.Text = myreader("MobileNumber")
            lblEmail.Text = myreader("Email")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class