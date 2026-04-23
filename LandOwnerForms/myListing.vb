Imports System.Data.OleDb

Public Class myListingForm
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim i
    Dim b
    Dim gotUidLDLF
    Dim selectedListing

    Public Sub New(ByVal gotUidLD As String)
        ' This call is required by the designer.
        InitializeComponent()
        gotUidLDLF = CInt(gotUidLD)
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub btnAddListing_Click(sender As Object, e As EventArgs) Handles btnAddListing.Click
        Dim addlisting = New listing(gotUidLDLF)
        addlisting.Show()
    End Sub

    Private Sub btnCheckListing_Click(sender As Object, e As EventArgs) Handles btnCheckListing.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            sql = "Select ListingID, Type,Price,Location,MaxPeople,Description,Status from UnverifiedListingTable Where UserID=" & Val(gotUidLDLF)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        selectedListing = DataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Public Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim more = New Landlord_More_Details(selectedListing, gotUidLDLF)
        more.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            sql = "Delete * from UnverifiedListingTable WHERE UserID = " & Val(gotUidLDLF) & " And ListingID = " & Val(selectedListing)
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been deleted successfully!", vbOKOnly, "DELETED")

                'notify the landowner about deleted listing
                Try
                    Dim sql2 As String
                    Dim cmd2 As New OleDb.OleDbCommand
                    Dim theDate = DateTime.Today.ToString("'#'yyyy'/'MM'/'dd'#'")
                    Dim desN As String = "You've deleted your listing number " & CStr(selectedListing) & " ."

                    sql2 = "Insert Into NotificationTable(UserID, nTime, Title, Description) Values(" & Val(gotUidLDLF) & "," & CStr(theDate) & ",'Listing Deleted', '" & CStr(desN) & "')"

                    cmd2.Connection = con
                    cmd2.CommandText = sql
                    b = cmd2.ExecuteNonQuery
                Catch ex As Exception
                    MsgBox(ex.Message)
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

    'Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
    '    Dim edit = New Landlord_Edit_Listing_Form(gotUidLDLF, selectedListing)
    '    edit.Show()
    'End Sub
End Class