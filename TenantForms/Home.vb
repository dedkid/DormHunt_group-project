Imports System.Data.OleDb
Public Class Home
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim i
    Dim LID
    Dim gotUidH

    Public Sub New(ByVal gotUidTDB As String)
        ' This call is required by the designer.
        InitializeComponent()
        gotUidH = gotUidTDB
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    'Loading the data available
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Sql As String
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            Sql = "Select * from ListingTable"
            Dim cmd As New OleDb.OleDbCommand(Sql, con)
            da.SelectCommand = cmd

            da.Fill(dt)


            Label1.Text = dt.Rows(0)("Type").ToString
            Label4.Text = dt.Rows(0)("Price").ToString
            lblLocation.Text = dt.Rows(0)("Location").ToString


            Label5.Text = dt.Rows(1)("Type").ToString
            Label3.Text = dt.Rows(1)("Price").ToString
            Label2.Text = dt.Rows(1)("Location").ToString


            Label8.Text = dt.Rows(2)("Type").ToString
            Label7.Text = dt.Rows(2)("Price").ToString
            Label6.Text = dt.Rows(2)("Location").ToString



            Label11.Text = dt.Rows(3)("Type").ToString
            Label10.Text = dt.Rows(3)("Price").ToString
            Label9.Text = dt.Rows(3)("Location").ToString


            Label14.Text = dt.Rows(4)("Type").ToString
            Label13.Text = dt.Rows(4)("Price").ToString
            Label12.Text = dt.Rows(4)("Location").ToString



            'load the images
            Dim arrimg() As Byte = dt.Rows(0).Item("Picture")
            Dim mstream As New System.IO.MemoryStream(arrimg)
            pic1.Image = Image.FromStream(mstream)

            Dim arrimg2() As Byte = dt.Rows(1).Item("Picture")
            Dim mstream2 As New System.IO.MemoryStream(arrimg2)
            pic2.Image = Image.FromStream(mstream2)

            Dim arrimg3() As Byte = dt.Rows(2).Item("Picture")
            Dim mstream3 As New System.IO.MemoryStream(arrimg3)
            pic3.Image = Image.FromStream(mstream3)

            Dim arrimg4() As Byte = dt.Rows(3).Item("Picture")
            Dim mstream4 As New System.IO.MemoryStream(arrimg4)
            pic4.Image = Image.FromStream(mstream4)

            Dim arrimg5() As Byte = dt.Rows(4).Item("Picture")
            Dim mstream5 As New System.IO.MemoryStream(arrimg5)
            pic5.Image = Image.FromStream(mstream5)

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'LOADING  VIEW MORE DETAILS
    Private Sub btnviewMoreDetails1_Click(sender As Object, e As EventArgs) Handles btnviewMoreDetails1.Click
        LID = 1

        Dim tenantv = New TenantViewMoreForm(LID, gotUidH)
        tenantv.Show()
    End Sub
    Private Sub btnviewMoreDetails2_Click(sender As Object, e As EventArgs) Handles btnviewMoreDetails2.Click
        LID = 2

        Dim tenantv = New TenantViewMoreForm(LID, gotUidH)
        tenantv.Show()
    End Sub

    Private Sub btnviewMoreDetails3_Click(sender As Object, e As EventArgs) Handles btnviewMoreDetails3.Click
        LID = 3

        Dim tenantv = New TenantViewMoreForm(LID, gotUidH)
        tenantv.Show()
    End Sub

    Private Sub btnviewMoreDetails4_Click(sender As Object, e As EventArgs) Handles btnviewMoreDetails4.Click
        LID = 4

        Dim tenantv = New TenantViewMoreForm(LID, gotUidH)
        tenantv.Show()
    End Sub

    Private Sub btnviewMoreDetails5_Click(sender As Object, e As EventArgs) Handles btnviewMoreDetails5.Click
        LID = 5

        Dim tenantv = New TenantViewMoreForm(LID, gotUidH)
        tenantv.Show()
    End Sub

    'SAVING INTO FAVORITES
    Private Sub btnFavorites1_Click(sender As Object, e As EventArgs) Handles btnFavorites1.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            LID = 1
            con.Open()
            sql = "INSERT INTO FavoritesTable (UserID, ListingID) VALUES (" & Val(gotUidH) & "," & Val(LID) & ")"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Listing has been added to FAVORITES!", vbOKOnly + vbInformation, "SAVE Message")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub btnFavorites2_Click(sender As Object, e As EventArgs) Handles btnFavorites2.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            LID = 2
            con.Open()
            sql = "INSERT INTO FavoritesTable (UserID, ListingID) VALUES (" & Val(gotUidH) & "," & Val(LID) & ")"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Listing has been added to FAVORITES!", vbOKOnly + vbInformation, "SAVE Message")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnFavorites3_Click(sender As Object, e As EventArgs) Handles btnFavorites3.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            LID = 3
            con.Open()
            sql = "INSERT INTO FavoritesTable (UserID, ListingID) VALUES (" & Val(gotUidH) & "," & Val(LID) & ")"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Listing has been added to FAVORITES!", vbOKOnly + vbInformation, "SAVE Message")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnFavorites4_Click(sender As Object, e As EventArgs) Handles btnFavorites4.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            LID = 4
            con.Open()
            sql = "INSERT INTO FavoritesTable (UserID, ListingID) VALUES (" & Val(gotUidH) & "," & Val(LID) & ")"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Listing has been added to FAVORITES!", vbOKOnly + vbInformation, "SAVE Message")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnFavorites5_Click(sender As Object, e As EventArgs) Handles btnFavorites5.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            LID = 5
            sql = "INSERT INTO FavoritesTable (UserID, ListingID) VALUES (" & Val(gotUidH) & "," & Val(LID) & ")"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Listing has been added to FAVORITES!", vbOKOnly + vbInformation, "SAVE Message")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class