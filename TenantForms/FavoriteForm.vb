Imports System.Data.OleDb
Public Class FavoriteForm
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim i
    Dim gotUidF
    Dim a As Integer = 20

    Public Sub New(ByVal gotUidTDB As String)
        ' This call is required by the designer.
        InitializeComponent()
        gotUidF = CInt(gotUidTDB)
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub btnViewMore_Click(sender As Object, e As EventArgs)
        'Dim tenantv = New TenantViewMoreForm(LID, gotUidH)
        'tenantv.Show()
    End Sub

    Private Sub FavoriteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Sql As String
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            Sql = "SELECT  Type, Price, Location, Picture FROM ListingTable INNER JOIN FavoritesTable On (ListingTable.ListingID = FavoritesTable.ListingID) Where FavoritesTable.UserID = " & Val(gotUidF)
            Dim cmd As New OleDb.OleDbCommand(Sql, con)
            da.SelectCommand = cmd
            da.Fill(dt)


            lbltype1.Text = dt.Rows(0)("Type").ToString
            lblprice1.Text = dt.Rows(0)("Price")
            lblloc1.Text = dt.Rows(0)("Location").ToString

            lbltype2.Text = dt.Rows(1)("Type").ToString
            lblprice2.Text = dt.Rows(1)("Price")
            lblloc2.Text = dt.Rows(1)("Location").ToString

            lbltype3.Text = dt.Rows(2)("Type").ToString
            lblprice3.Text = dt.Rows(2)("Price")
            lblloc3.Text = dt.Rows(2)("Location").ToString

            lbltype4.Text = dt.Rows(3)("Type").ToString
            lblprice4.Text = dt.Rows(3)("Price")
            lblloc4.Text = dt.Rows(3)("Location").ToString

            lbltype5.Text = dt.Rows(4)("Type").ToString
            lblprice5.Text = dt.Rows(4)("Price")
            lblloc5.Text = dt.Rows(4)("Location").ToString

            lbltype6.Text = dt.Rows(5)("Type").ToString
            lblprice6.Text = dt.Rows(5)("Price")
            lblloc6.Text = dt.Rows(5)("Location").ToString

            lbltype7.Text = dt.Rows(6)("Type").ToString
            lblprice7.Text = dt.Rows(6)("Price")
            lblloc7.Text = dt.Rows(6)("Location").ToString

            lbltype8.Text = dt.Rows(7)("Type").ToString
            lblprice8.Text = dt.Rows(7)("Price")
            lblloc8.Text = dt.Rows(7)("Location").ToString

            lbltype9.Text = dt.Rows(8)("Type").ToString
            lblprice9.Text = dt.Rows(8)("Price")
            lblloc9.Text = dt.Rows(8)("Location").ToString

            lbltype10.Text = dt.Rows(9)("Type").ToString
            lblprice10.Text = dt.Rows(9)("Price")
            lblloc10.Text = dt.Rows(9)("Location").ToString

            'to load images
            Dim arrimg() As Byte = dt.Rows(0)("Picture")
            Dim mstream As New System.IO.MemoryStream(arrimg)
            p1.Image = Image.FromStream(mstream)

            Dim arrimg2() As Byte = dt.Rows(1)("Picture")
            Dim mstream2 As New System.IO.MemoryStream(arrimg2)
            p2.Image = Image.FromStream(mstream2)

            Dim arrimg3() As Byte = dt.Rows(3)("Picture")
            Dim mstream3 As New System.IO.MemoryStream(arrimg3)
            p3.Image = Image.FromStream(mstream3)

            Dim arrimg4() As Byte = dt.Rows(3)("Picture")
            Dim mstream4 As New System.IO.MemoryStream(arrimg4)
            p4.Image = Image.FromStream(mstream4)

            Dim arrimg5() As Byte = dt.Rows(4)("Picture")
            Dim mstream5 As New System.IO.MemoryStream(arrimg5)
            p5.Image = Image.FromStream(mstream5)

            Dim arrimg6() As Byte = dt.Rows(5)("Picture")
            Dim mstream6 As New System.IO.MemoryStream(arrimg6)
            p6.Image = Image.FromStream(mstream6)

            Dim arrimg7() As Byte = dt.Rows(6)("Picture")
            Dim mstream7 As New System.IO.MemoryStream(arrimg7)
            p7.Image = Image.FromStream(mstream7)

            Dim arrimg8() As Byte = dt.Rows(7)("Picture")
            Dim mstream8 As New System.IO.MemoryStream(arrimg8)
            p8.Image = Image.FromStream(mstream8)

            Dim arrimg9() As Byte = dt.Rows(8)("Picture")
            Dim mstream9 As New System.IO.MemoryStream(arrimg9)
            p9.Image = Image.FromStream(mstream9)

            Dim arrimg10() As Byte = dt.Rows(9)("Picture")
            Dim mstream10 As New System.IO.MemoryStream(arrimg10)
            p10.Image = Image.FromStream(mstream10)


            'to hide useless panel
            If String.IsNullOrEmpty(lbltype1.Text) Then
                Panel1.Visible = False
            End If
            If String.IsNullOrEmpty(lbltype2.Text) Then
                Panel2.Visible = False
            End If
            If String.IsNullOrEmpty(lbltype3.Text) Then
                Panel3.Visible = False
            End If
            If String.IsNullOrEmpty(lbltype4.Text) Then
                Panel4.Visible = False
            End If
            If String.IsNullOrEmpty(lbltype5.Text) Then
                Panel5.Visible = False
            End If
            If String.IsNullOrEmpty(lbltype6.Text) Then
                Panel6.Visible = False
            End If
            If String.IsNullOrEmpty(lbltype7.Text) Then
                Panel7.Visible = False
            End If
            If String.IsNullOrEmpty(lbltype8.Text) Then
                Panel8.Visible = False
            End If
            If String.IsNullOrEmpty(lbltype9.Text) Then
                Panel9.Visible = False
            End If
            If String.IsNullOrEmpty(lbltype10.Text) Then
                Panel10.Visible = False
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDel1.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            sql = " Delete * from FavoritesTable WHERE UserID=" & Val(gotUidF)
            cmd.Connection = con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then

                MsgBox("Record has been deleted successfully!")
                'lblType.Text = String.Empty
                'lblPrice.Text = String.Empty
                'lblLocation.Text = String.Empty
            Else
                MsgBox("No Record has been deleted!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


End Class