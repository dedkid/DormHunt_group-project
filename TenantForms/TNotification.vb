Imports System.Data.OleDb
Public Class TNotification
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim i
    Dim gotUidnotif
    Dim gotUidLDN
    Dim userTypeL

    'initialization for Teanant pass variable
    Public Sub New(ByVal gotUidTDB As String)
        ' This call is required by the designer.
        InitializeComponent()
        gotUidnotif = CInt(gotUidTDB)
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    'initialization for landowner pass variable
    Public Sub New(ByVal gotUidLD As String, ByVal utype As String)
        ' This call is required by the designer.
        InitializeComponent()
        gotUidLDN = CInt(gotUidLD)
        userTypeL = utype
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub TNotification_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()

            'condition to which notification will be display tenant/landowner
            If userTypeL = "LandOwner" Then
                'landowner
                sql = "SELECT Title, nTime, Description from NotificationTable Where UserId=" & Val(gotUidLDN)
            Else
                'tenant
                sql = "SELECT Title, nTime, Description from NotificationTable Where UserId=" & Val(gotUidnotif)
            End If

            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            lblnotif11.Text = dt.Rows(0)("Title").ToString
            lblnotif12.Text = dt.Rows(0)("nTime")
            lblnotif13.Text = dt.Rows(0)("Description").ToString

            lblnotif21.Text = dt.Rows(1)("Title").ToString
            lblnotif22.Text = dt.Rows(1)("nTime")
            lblnotif23.Text = dt.Rows(1)("Description").ToString

            lblnotif31.Text = dt.Rows(2)("Title").ToString
            lblnotif32.Text = dt.Rows(2)("nTime")
            lblnotif33.Text = dt.Rows(2)("Description").ToString

            lblnotif41.Text = dt.Rows(3)("Title").ToString
            lblnotif42.Text = dt.Rows(3)("nTime")
            lblnotif43.Text = dt.Rows(3)("Description").ToString

            lblnotif51.Text = dt.Rows(4)("Title").ToString
            lblnotif52.Text = dt.Rows(4)("nTime")
            lblnotif53.Text = dt.Rows(4)("Description").ToString

            lblnotif61.Text = dt.Rows(5)("Title").ToString
            lblnotif62.Text = dt.Rows(5)("nTime")
            lblnotif63.Text = dt.Rows(5)("Description").ToString

            lblnotif71.Text = dt.Rows(6)("Title").ToString
            lblnotif72.Text = dt.Rows(6)("nTime")
            lblnotif73.Text = dt.Rows(6)("Description").ToString

            lblnotif81.Text = dt.Rows(7)("Title").ToString
            lblnotif82.Text = dt.Rows(7)("nTime")
            lblnotif83.Text = dt.Rows(7)("Description").ToString

            lblnotif91.Text = dt.Rows(8)("Title").ToString
            lblnotif92.Text = dt.Rows(8)("nTime")
            lblnotif93.Text = dt.Rows(8)("Description").ToString

            lblnotif01.Text = dt.Rows(9)("Title").ToString
            lblnotif02.Text = dt.Rows(9)("nTime")
            lblnotif03.Text = dt.Rows(9)("Description").ToString

            'to hide useless panel
            If String.IsNullOrEmpty(lblnotif11.Text) Then
                p1.Visible = False
            End If
            If String.IsNullOrEmpty(lblnotif21.Text) Then
                p2.Visible = False
            End If
            If String.IsNullOrEmpty(lblnotif31.Text) Then
                p3.Visible = False
            End If
            If String.IsNullOrEmpty(lblnotif41.Text) Then
                p4.Visible = False
            End If
            If String.IsNullOrEmpty(lblnotif51.Text) Then
                p5.Visible = False
            End If
            If String.IsNullOrEmpty(lblnotif61.Text) Then
                p6.Visible = False
            End If
            If String.IsNullOrEmpty(lblnotif71.Text) Then
                p7.Visible = False
            End If
            If String.IsNullOrEmpty(lblnotif81.Text) Then
                p8.Visible = False
            End If
            If String.IsNullOrEmpty(lblnotif91.Text) Then
                p9.Visible = False
            End If
            If String.IsNullOrEmpty(lblnotif01.Text) Then
                p10.Visible = False
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

End Class