Imports System.Data.OleDb
Public Class TDashBoard
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim Type As String
    Dim i
    Private currentChildForm As Form
    Dim gotUidTDB
    Dim LID
    Public Sub New(ByVal uID As String)
        ' This call is required by the designer.
        InitializeComponent()
        gotUidTDB = uID
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

        tenantMainPanel.Controls.Add(childForm)
        tenantMainPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    'to open edit profile form
    Private Sub BtnEditProfile_Click(sender As Object, e As EventArgs) Handles BtnEditProfile.Click
        openChildForm(New ProfileeditForm(gotUidTDB))
    End Sub

    'To open specific form in the main panel
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        openChildForm(New Home(gotUidTDB))
    End Sub

    Private Sub btnNotifications_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click
        openChildForm(New TNotification(gotUidTDB))
    End Sub

    Private Sub btnFavorites_Click(sender As Object, e As EventArgs) Handles btnFavorites.Click
        openChildForm(New FavoriteForm(gotUidTDB))
    End Sub

    Private Sub btnUtility_Click(sender As Object, e As EventArgs)
        openChildForm(New utilityForm)
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        openChildForm(New TAccount(gotUidTDB))
    End Sub

    Private Sub lblNotification_Click(sender As Object, e As EventArgs) Handles lblNotification.Click
        openChildForm(New TNotification(gotUidTDB))
    End Sub

    Private Sub lblFavorites_Click(sender As Object, e As EventArgs) Handles lblFavorites.Click
        openChildForm(New FavoriteForm(gotUidTDB))
    End Sub

    Private Sub lblUtility2_Click(sender As Object, e As EventArgs) Handles lblUtility2.Click
        openChildForm(New utilityForm)
    End Sub

    Private Sub lblAccount_Click(sender As Object, e As EventArgs) Handles lblAccount.Click
        openChildForm(New TAccount(gotUidTDB))
    End Sub

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        openChildForm(New Home(gotUidTDB))
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


        btnHome.Region = New Region(rad)
        btnNotifications.Region = New Region(rad)
        btnFavorites.Region = New Region(rad)
        btnUtility.Region = New Region(rad)
        btnAccount.Region = New Region(rad)
    End Sub

    Private Sub TDashBoard_load(sender As Object, e As EventArgs) Handles MyBase.Load
        openChildForm(New Home(gotUidTDB))
        roundcornerPanel(btnHome)
        roundcornerPanel(btnNotifications)
        roundcornerPanel(btnFavorites)
        roundcornerPanel(btnUtility)
        roundcornerPanel(btnAccount)
        'round the picbox
        Dim pic As New Drawing2D.GraphicsPath
        pic.AddEllipse(0, 0, 100, 100)
        PictureBox3.Region = New Region(pic)

        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter

            con.Open()
            sql = "SELECT FirstName, ProfilePicture  FROM UserTable  Where UserID = " & Val(gotUidTDB)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)

            DashName.Text = dt.Rows(0).Item("FirstName")
            DashName.TextAlign = ContentAlignment.MiddleCenter

            Dim arrimg() As Byte = dt.Rows(0).Item("ProfilePicture")
            Dim mstream As New System.IO.MemoryStream(arrimg)
            PictureBox3.Image = Image.FromStream(mstream)


        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub lblHome_MouseHover(sender As Object, e As EventArgs) Handles lblHome.MouseHover
        btnHome.BackColor = Color.FromArgb(75, 255, 255, 255)
        lblHome.ForeColor = Color.Black
    End Sub

    Private Sub lblHome_MouseLeave(sender As Object, e As EventArgs) Handles lblHome.MouseLeave
        btnHome.BackColor = Color.FromArgb(75, 0, 0, 0)
        lblHome.ForeColor = Color.White
    End Sub


    Private Sub lblNotification_MouseHover(sender As Object, e As EventArgs) Handles lblNotification.MouseHover
        btnNotifications.BackColor = Color.FromArgb(75, 255, 255, 255)
        lblNotification.ForeColor = Color.Black
    End Sub

    Private Sub lblNotification_MouseLeave(sender As Object, e As EventArgs) Handles lblNotification.MouseLeave
        btnNotifications.BackColor = Color.FromArgb(75, 0, 0, 0)
        lblNotification.ForeColor = Color.White
    End Sub

    Private Sub lblFavorites_MouseHover(sender As Object, e As EventArgs) Handles lblFavorites.MouseHover
        btnFavorites.BackColor = Color.FromArgb(75, 255, 255, 255)
        lblFavorites.ForeColor = Color.Black
    End Sub

    Private Sub lblFavorites_MouseLeave(sender As Object, e As EventArgs) Handles lblFavorites.MouseLeave
        btnFavorites.BackColor = Color.FromArgb(75, 0, 0, 0)
        lblFavorites.ForeColor = Color.White
    End Sub

    Private Sub lblUtility_MouseHover(sender As Object, e As EventArgs) Handles lblUtility2.MouseHover
        btnUtility.BackColor = Color.FromArgb(75, 255, 255, 255)
        lblUtility2.ForeColor = Color.Black
    End Sub

    Private Sub lblUtility_MouseLeave(sender As Object, e As EventArgs) Handles lblUtility2.MouseLeave
        btnUtility.BackColor = Color.FromArgb(75, 0, 0, 0)
        lblUtility2.ForeColor = Color.White
    End Sub

    Private Sub lblAccount_MouseHover(sender As Object, e As EventArgs) Handles lblAccount.MouseHover
        btnAccount.BackColor = Color.FromArgb(75, 255, 255, 255)
        lblAccount.ForeColor = Color.Black
    End Sub

    Private Sub lblAccount_MouseLeave(sender As Object, e As EventArgs) Handles lblAccount.MouseLeave
        btnAccount.BackColor = Color.FromArgb(75, 0, 0, 0)
        lblAccount.ForeColor = Color.White
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Refresh()
    End Sub
End Class