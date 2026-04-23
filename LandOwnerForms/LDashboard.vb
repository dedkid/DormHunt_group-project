Imports System.Data.OleDb
Public Class LDashboard
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim Type As String
    Dim i
    Dim gotUidLD
    Dim utype As String = "LandOwner"

    Public Sub New(ByVal uID As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        gotUidLD = uID
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private currentChildForm As Form

    Private Sub openChildForm(childForm As Form)
        'method for opening other form in Main Panel
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        landOwnerMainPanel.Controls.Add(childForm)
        landOwnerMainPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        openChildForm(New ProfileeditForm(gotUidLD, utype))
    End Sub

    Private Sub btnLDashboard_Click(sender As Object, e As EventArgs) Handles btnLDashboard.Click
        openChildForm(New myListingForm(gotUidLD))
    End Sub

    Private Sub btnLReservation_Click(sender As Object, e As EventArgs) Handles btnLReservation.Click
        openChildForm(New reservationLForm(gotUidLD))
    End Sub

    Private Sub btnLNotification_Click(sender As Object, e As EventArgs) Handles btnLNotification.Click
        openChildForm(New TNotification(gotUidLD, utype))
    End Sub

    Private Sub btnUtility_Click(sender As Object, e As EventArgs) Handles btnLUtility.Click
        openChildForm(New utilityForm)
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnLAccount.Click
        openChildForm(New landownerprofile(gotUidLD))
    End Sub

    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        openChildForm(New myListingForm(gotUidLD))
    End Sub

    Private Sub lblReservation_Click(sender As Object, e As EventArgs) Handles lblReservation.Click
        openChildForm(New reservationLForm(gotUidLD))
    End Sub

    Private Sub lblNotification_Click(sender As Object, e As EventArgs) Handles lblNotification.Click
        openChildForm(New TNotification(gotUidLD, utype))
    End Sub

    Private Sub lblUtility_Click(sender As Object, e As EventArgs) Handles lblUtility.Click
        openChildForm(New utilityForm)
    End Sub

    Private Sub lblAccount_Click(sender As Object, e As EventArgs) Handles lblAccount.Click
        openChildForm(New landownerprofile(gotUidLD))
    End Sub

    Private Sub roundcornerPanel(pnl As Panel)

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        'top left corner
        rad.AddArc(New Rectangle(0, 0, 35, 35), 180, 90)
        rad.AddLine(35, 0, pnl.Width - 35, 0)

        'top right corner
        rad.AddArc(New Rectangle(pnl.Width - 35, 0, 35, 35), -90, 90)
        rad.AddLine(pnl.Width, 35, pnl.Width, pnl.Height - 35)

        'bottom right corner
        rad.AddArc(New Rectangle(pnl.Width - 35, pnl.Height - 35, 35, 35), 0, 90)
        rad.AddLine(pnl.Width - 35, pnl.Height, 35, pnl.Height)

        'bottom left corner
        rad.AddArc(New Rectangle(0, pnl.Height - 35, 35, 35), 90, 90)


        btnLDashboard.Region = New Region(rad)
        btnLReservation.Region = New Region(rad)
        btnLNotification.Region = New Region(rad)
        btnLUtility.Region = New Region(rad)
        btnLAccount.Region = New Region(rad)
    End Sub

    Private Sub notifications_load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundcornerPanel(btnLDashboard)
        roundcornerPanel(btnLReservation)
        roundcornerPanel(btnLNotification)
        roundcornerPanel(btnLUtility)
        roundcornerPanel(btnLAccount)

        'round the picbox
        Dim pic As New Drawing2D.GraphicsPath
        pic.AddEllipse(0, 0, 100, 100)
        PictureBox10.Region = New Region(pic)

        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter

            con.Open()
            sql = "SELECT FirstName, ProfilePicture FROM UserTable Where UserID=" & Val(gotUidLD)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)

            DashName.Text = dt.Rows(0).Item("FirstName")
            DashName.TextAlign = ContentAlignment.MiddleCenter

            Dim arrimg() As Byte = dt.Rows(0).Item("ProfilePicture")
            Dim mstream As New System.IO.MemoryStream(arrimg)
            PictureBox10.Image = Image.FromStream(mstream)


        Catch ex As Exception
            ' MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        'initially show the my listing form
        openChildForm(New myListingForm(gotUidLD))
    End Sub

    Private Sub lblDashboard_MouseHover(sender As Object, e As EventArgs) Handles lblDashboard.MouseHover
        btnLDashboard.BackColor = Color.FromArgb(75, 255, 255, 255)
        lblDashboard.ForeColor = Color.Black
    End Sub

    Private Sub lblDashboard_MouseLeave(sender As Object, e As EventArgs) Handles lblDashboard.MouseLeave
        btnLDashboard.BackColor = Color.FromArgb(75, 0, 0, 0)
        lblDashboard.ForeColor = Color.White
    End Sub

    Private Sub lblReservation_MouseHover(sender As Object, e As EventArgs) Handles lblReservation.MouseHover
        btnLReservation.BackColor = Color.FromArgb(75, 255, 255, 255)
        lblReservation.ForeColor = Color.Black
    End Sub

    Private Sub lblReservation_MouseLeave(sender As Object, e As EventArgs) Handles lblReservation.MouseLeave
        btnLReservation.BackColor = Color.FromArgb(75, 0, 0, 0)
        lblReservation.ForeColor = Color.White
    End Sub

    Private Sub lblNotification_MouseHover(sender As Object, e As EventArgs) Handles lblNotification.MouseHover
        btnLNotification.BackColor = Color.FromArgb(75, 255, 255, 255)
        lblNotification.ForeColor = Color.Black
    End Sub

    Private Sub lblNotification_MouseLeave(sender As Object, e As EventArgs) Handles lblNotification.MouseLeave
        btnLNotification.BackColor = Color.FromArgb(75, 0, 0, 0)
        lblNotification.ForeColor = Color.White
    End Sub

    Private Sub lblUtility_MouseHover(sender As Object, e As EventArgs) Handles lblUtility.MouseHover
        btnLUtility.BackColor = Color.FromArgb(75, 255, 255, 255)
        lblUtility.ForeColor = Color.Black
    End Sub

    Private Sub lblUtility_MouseLeave(sender As Object, e As EventArgs) Handles lblUtility.MouseLeave
        btnLUtility.BackColor = Color.FromArgb(75, 0, 0, 0)
        lblUtility.ForeColor = Color.White
    End Sub

    Private Sub lblAccount_MouseHover(sender As Object, e As EventArgs) Handles lblAccount.MouseHover
        btnLAccount.BackColor = Color.FromArgb(75, 255, 255, 255)
        lblAccount.ForeColor = Color.Black
    End Sub

    Private Sub lblAccount_MouseLeave(sender As Object, e As EventArgs) Handles lblAccount.MouseLeave
        btnLAccount.BackColor = Color.FromArgb(75, 0, 0, 0)
        lblAccount.ForeColor = Color.White
    End Sub
End Class

