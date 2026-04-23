Imports System.Data.OleDb

Public Class TenantViewMoreForm
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim lisID
    Dim gotUidTVM
    Dim UIDofLister
    Private currentChildForm As Form

    Public Sub New(ByVal LID As String, ByVal gotUidH As String)
        ' This call is required by the designer.
        InitializeComponent()
        lisID = CInt(LID)
        gotUidTVM = gotUidH
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub openChildForm(childForm As Form)
        'method for opening other form in Main Panel
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        vmdPanel.Controls.Add(childForm)
        vmdPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        openChildForm(New ReservationForm(gotUidTVM, lisID, UIDofLister))
    End Sub

    Private Sub btnLandlordProfile_Click(sender As Object, e As EventArgs) Handles btnLandlordProfile.Click
        openChildForm(New ListerProfile(UIDofLister))
    End Sub

    Private Sub btnReportRoom_Click(sender As Object, e As EventArgs) Handles btnReportRoom.Click
        openChildForm(New tenantreportform(gotUidTVM, lisID, UIDofLister))
    End Sub

    'load the more data of the listing from listing table
    Private Sub TenantViewMoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Sql As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()

            Sql = "Select * From ListingTable Where ListingID=" & Val(lisID)
            cmd.Connection = con
            cmd.CommandText = Sql
            da.SelectCommand = cmd

            da.Fill(dt)

            Label8.Text = dt.Rows(0)("Type").ToString
            lblPrice.Text = dt.Rows(0)("Price").ToString
            lblAddress.Text = dt.Rows(0)("Location").ToString
            lblAvailability.Text = dt.Rows(0)("MaxPeople").ToString
            UIDofLister = dt.Rows(0)("UserID").ToString

            Dim arrimg() As Byte = dt.Rows(0)("Picture")
            Dim mstream As New System.IO.MemoryStream(arrimg)
            picboxPhoto.Image = Image.FromStream(mstream)

        Catch ex As Exception
            ' MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        'load the contact details of the lister 
        Try
            Dim Sql As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()

            Sql = "Select * From UserTable Where UserID =" & Val(UIDofLister)
            cmd.Connection = con
            cmd.CommandText = Sql
            da.SelectCommand = cmd

            da.Fill(dt)

            lblMobileNumber.Text = dt.Rows(0)("MobileNumber").ToString
            lblEmail.Text = dt.Rows(0)("Email").ToString

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

End Class