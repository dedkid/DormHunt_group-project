Imports System.Data.OleDb
Imports System.IO
Public Class utilityForm
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim i
    Dim dt As New DataTable

    Private Sub utilityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            sql = "SELECT * from UtilityTable"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            lbltitle1.Text = dt.Rows(0)("ServiceTitle").ToString
            lblname1.Text = dt.Rows(0)("ProviderName").ToString
            lbldescription1.Text = dt.Rows(0)("ServiceOffer").ToString
            lblnumber1.Text = dt.Rows(0)("MobileNumber").ToString
            lblEmail1.Text = dt.Rows(0)("Email").ToString
            lbllocation1.Text = dt.Rows(0)("ServiceArea").ToString
            lblschedule1.Text = dt.Rows(0)("Availability").ToString
            Dim arrimg() As Byte = dt.Rows(0)("Picture")
            Dim mstream As New System.IO.MemoryStream(arrimg)
            pic1.Image = Image.FromStream(mstream)

            lbltitle21.Text = dt.Rows(1)("ServiceTitle").ToString
            lblname22.Text = dt.Rows(1)("ProviderName").ToString
            lbldescription23.Text = dt.Rows(1)("ServiceOffer").ToString
            lblnumber24.Text = dt.Rows(1)("MobileNumber").ToString
            lblemail25.Text = dt.Rows(1)("Email").ToString
            lbllocation26.Text = dt.Rows(1)("ServiceArea").ToString
            lblschedule27.Text = dt.Rows(1)("Availability").ToString
            Dim arrimg2() As Byte = dt.Rows(1)("Picture")
            Dim mstream2 As New System.IO.MemoryStream(arrimg2)
            pic2.Image = Image.FromStream(mstream2)

            lbltitle31.Text = dt.Rows(2)("ServiceTitle").ToString
            lblname32.Text = dt.Rows(2)("ProviderName").ToString
            lbldescription33.Text = dt.Rows(2)("ServiceOffer").ToString
            lblnumber34.Text = dt.Rows(2)("MobileNumber").ToString
            lblemail35.Text = dt.Rows(2)("Email").ToString
            lbllocation36.Text = dt.Rows(2)("ServiceArea").ToString
            lblschedule37.Text = dt.Rows(2)("Availability").ToString
            Dim arrimg3() As Byte = dt.Rows(2)("Picture")
            Dim mstream3 As New System.IO.MemoryStream(arrimg3)
            pic3.Image = Image.FromStream(mstream3)

            lbltitle41.Text = dt.Rows(3)("ServiceTitle").ToString
            lblname42.Text = dt.Rows(3)("ProviderName").ToString
            lbldescription43.Text = dt.Rows(3)("ServiceOffer").ToString
            lblnumber44.Text = dt.Rows(3)("MobileNumber").ToString
            lblemail45.Text = dt.Rows(3)("Email").ToString
            lbllocation46.Text = dt.Rows(3)("ServiceArea").ToString
            lblschedule47.Text = dt.Rows(3)("Availability").ToString
            Dim arrimg4() As Byte = dt.Rows(3)("Picture")
            Dim mstream4 As New System.IO.MemoryStream(arrimg4)
            pic4.Image = Image.FromStream(mstream4)

            lbltitle51.Text = dt.Rows(4)("ServiceTitle").ToString
            lblname52.Text = dt.Rows(4)("ProviderName").ToString
            lbldescription53.Text = dt.Rows(4)("ServiceOffer").ToString
            lblnumber54.Text = dt.Rows(4)("MobileNumber").ToString
            lblemail5.Text = dt.Rows(4)("Email").ToString
            lbllocation5.Text = dt.Rows(4)("ServiceArea").ToString
            lblschedule5.Text = dt.Rows(4)("Availability").ToString
            Dim arrimg5() As Byte = dt.Rows(4)("Picture")
            Dim mstream5 As New System.IO.MemoryStream(arrimg5)
            pic5.Image = Image.FromStream(mstream5)

            lbltitle6.Text = dt.Rows(5)("ServiceTitle").ToString
            lblname6.Text = dt.Rows(5)("ProviderName").ToString
            lbldescription6.Text = dt.Rows(5)("ServiceOffer").ToString
            lblnumber6.Text = dt.Rows(5)("MobileNumber").ToString
            lblemail6.Text = dt.Rows(5)("Email").ToString
            lbllocation6.Text = dt.Rows(5)("ServiceArea").ToString
            lblschedule6.Text = dt.Rows(5)("Availability").ToString
            Dim arrimg6() As Byte = dt.Rows(5)("Picture")
            Dim mstream6 As New System.IO.MemoryStream(arrimg6)
            pic6.Image = Image.FromStream(mstream6)

            lbltitle7.Text = dt.Rows(6)("ServiceTitle").ToString
            lblname7.Text = dt.Rows(6)("ProviderName").ToString
            lbldescription7.Text = dt.Rows(6)("ServiceOffer").ToString
            lblnumber7.Text = dt.Rows(6)("MobileNumber").ToString
            lblemail7.Text = dt.Rows(6)("Email").ToString
            lbllocation7.Text = dt.Rows(6)("ServiceArea").ToString
            lblschedule7.Text = dt.Rows(6)("Availability").ToString
            Dim arrimg7() As Byte = dt.Rows(6)("Picture")
            Dim mstream7 As New System.IO.MemoryStream(arrimg7)
            pic7.Image = Image.FromStream(mstream7)

            lbltitle8.Text = dt.Rows(7)("ServiceTitle").ToString
            lblname8.Text = dt.Rows(7)("ProviderName").ToString
            lbldescription8.Text = dt.Rows(7)("ServiceOffer").ToString
            lblnumber8.Text = dt.Rows(7)("MobileNumber").ToString
            lblemail8.Text = dt.Rows(7)("Email").ToString
            lbllocation8.Text = dt.Rows(7)("ServiceArea").ToString
            lblschedule8.Text = dt.Rows(7)("Availability").ToString
            Dim arrimg8() As Byte = dt.Rows(7)("Picture")
            Dim mstream8 As New System.IO.MemoryStream(arrimg8)
            pic8.Image = Image.FromStream(mstream8)

            lbltitle9.Text = dt.Rows(8)("ServiceTitle").ToString
            lblname9.Text = dt.Rows(8)("ProviderName").ToString
            lbldescription9.Text = dt.Rows(8)("ServiceOffer").ToString
            lblnumber9.Text = dt.Rows(8)("MobileNumber").ToString
            lblemail9.Text = dt.Rows(8)("Email").ToString
            lbllocation9.Text = dt.Rows(8)("ServiceArea").ToString
            lblschedule9.Text = dt.Rows(8)("Availability").ToString
            Dim arrimg9() As Byte = dt.Rows(8)("Picture")
            Dim mstream9 As New System.IO.MemoryStream(arrimg9)
            pic9.Image = Image.FromStream(mstream9)

            lbltitle10.Text = dt.Rows(9)("ServiceTitle").ToString
            lblname10.Text = dt.Rows(9)("ProviderName").ToString
            lbldescription10.Text = dt.Rows(9)("ServiceOffer").ToString
            lblnumber10.Text = dt.Rows(9)("MobileNumber").ToString
            lblemail10.Text = dt.Rows(9)("Email").ToString
            lbllocation10.Text = dt.Rows(9)("ServiceArea").ToString
            lblschedule10.Text = dt.Rows(9)("Availability").ToString
            Dim arrimg10() As Byte = dt.Rows(9)("Picture")
            Dim mstream10 As New System.IO.MemoryStream(arrimg10)
            pic10.Image = Image.FromStream(mstream10)

            lbltitle111.Text = dt.Rows(10)("ServiceTitle").ToString
            lblname112.Text = dt.Rows(10)("ProviderName").ToString
            lbldescription113.Text = dt.Rows(10)("ServiceOffer").ToString
            lblnumber114.Text = dt.Rows(10)("MobileNumber").ToString
            lblemail115.Text = dt.Rows(10)("Email").ToString
            lbllocation116.Text = dt.Rows(10)("ServiceArea").ToString
            lblschedule117.Text = dt.Rows(10)("Availability").ToString
            Dim arrimg11() As Byte = dt.Rows(10)("Picture")
            Dim mstream11 As New System.IO.MemoryStream(arrimg11)
            pic11.Image = Image.FromStream(mstream11)

            lbltitle12.Text = dt.Rows(11)("ServiceTitle").ToString
            lblname12.Text = dt.Rows(11)("ProviderName").ToString
            lbldescription12.Text = dt.Rows(11)("ServiceOffer").ToString
            lblnumber12.Text = dt.Rows(11)("MobileNumber").ToString
            lblemail12.Text = dt.Rows(11)("Email").ToString
            lbllocation12.Text = dt.Rows(11)("ServiceArea").ToString
            lblschedule12.Text = dt.Rows(11)("Availability").ToString
            Dim arrimg12() As Byte = dt.Rows(11)("Picture")
            Dim mstream12 As New System.IO.MemoryStream(arrimg12)
            pic12.Image = Image.FromStream(mstream12)

            lbltitle13.Text = dt.Rows(12)("ServiceTitle").ToString
            lblname13.Text = dt.Rows(12)("ProviderName").ToString
            lbldescription13.Text = dt.Rows(12)("ServiceOffer").ToString
            lblnumber13.Text = dt.Rows(12)("MobileNumber").ToString
            lblemail13.Text = dt.Rows(12)("Email").ToString
            lbllocation13.Text = dt.Rows(12)("ServiceArea").ToString
            lblschedule13.Text = dt.Rows(12)("Availability").ToString
            Dim arrimg13() As Byte = dt.Rows(12)("Picture")
            Dim mstream13 As New System.IO.MemoryStream(arrimg13)
            pic13.Image = Image.FromStream(mstream13)

            lbltitle14.Text = dt.Rows(13)("ServiceTitle").ToString
            lblname14.Text = dt.Rows(13)("ProviderName").ToString
            lbldescription14.Text = dt.Rows(13)("ServiceOffer").ToString
            lblnumber14.Text = dt.Rows(13)("MobileNumber").ToString
            lblemail14.Text = dt.Rows(13)("Email").ToString
            lbllocation14.Text = dt.Rows(13)("ServiceArea").ToString
            lblschedule14.Text = dt.Rows(13)("Availability").ToString
            Dim arrimg14() As Byte = dt.Rows(13)("Picture")
            Dim mstream14 As New System.IO.MemoryStream(arrimg14)
            pic14.Image = Image.FromStream(mstream14)

            lbltitle15.Text = dt.Rows(14)("ServiceTitle").ToString
            lblname15.Text = dt.Rows(14)("ProviderName").ToString
            lbldescription15.Text = dt.Rows(14)("ServiceOffer").ToString
            lblnumber15.Text = dt.Rows(14)("MobileNumber").ToString
            lblemail15.Text = dt.Rows(14)("Email").ToString
            lbllocation15.Text = dt.Rows(14)("ServiceArea").ToString
            lblschedule15.Text = dt.Rows(14)("Availability").ToString
            Dim arrimg15() As Byte = dt.Rows(14)("Picture")
            Dim mstream15 As New System.IO.MemoryStream(arrimg15)
            pic15.Image = Image.FromStream(mstream15)

            lbltitle16.Text = dt.Rows(15)("ServiceTitle").ToString
            lblname16.Text = dt.Rows(15)("ProviderName").ToString
            lbldescription16.Text = dt.Rows(15)("ServiceOffer").ToString
            lblnumber16.Text = dt.Rows(15)("MobileNumber").ToString
            lblemail16.Text = dt.Rows(15)("Email").ToString
            lbllocation16.Text = dt.Rows(15)("ServiceArea").ToString
            lblschedule16.Text = dt.Rows(15)("Availability").ToString
            Dim arrimg16() As Byte = dt.Rows(15)("Picture")
            Dim mstream16 As New System.IO.MemoryStream(arrimg16)
            pic16.Image = Image.FromStream(mstream16)

            lbltitle17.Text = dt.Rows(16)("ServiceTitle").ToString
            lblname17.Text = dt.Rows(16)("ProviderName").ToString
            lbldescription17.Text = dt.Rows(16)("ServiceOffer").ToString
            lblnumber17.Text = dt.Rows(16)("MobileNumber").ToString
            lblemail17.Text = dt.Rows(16)("Email").ToString
            lbllocation17.Text = dt.Rows(16)("ServiceArea").ToString
            lblschedule17.Text = dt.Rows(16)("Availability").ToString
            Dim arrimg17() As Byte = dt.Rows(16)("Picture")
            Dim mstream17 As New System.IO.MemoryStream(arrimg17)
            pic17.Image = Image.FromStream(mstream17)

            lbltitle18.Text = dt.Rows(17)("ServiceTitle").ToString
            lblname18.Text = dt.Rows(17)("ProviderName").ToString
            lbldescription18.Text = dt.Rows(17)("ServiceOffer").ToString
            lblnumber18.Text = dt.Rows(17)("MobileNumber").ToString
            lblemail18.Text = dt.Rows(17)("Email").ToString
            lbllocation18.Text = dt.Rows(17)("ServiceArea").ToString
            lblschedule18.Text = dt.Rows(17)("Availability").ToString
            Dim arrimg18() As Byte = dt.Rows(17)("Picture")
            Dim mstream18 As New System.IO.MemoryStream(arrimg18)
            pic18.Image = Image.FromStream(mstream18)

            lbltitle19.Text = dt.Rows(18)("ServiceTitle").ToString
            lblname19.Text = dt.Rows(18)("ProviderName").ToString
            lbldescription19.Text = dt.Rows(18)("ServiceOffer").ToString
            lblnumber19.Text = dt.Rows(18)("MobileNumber").ToString
            lblemail19.Text = dt.Rows(18)("Email").ToString
            lbllocation19.Text = dt.Rows(18)("ServiceArea").ToString
            lblschedule19.Text = dt.Rows(18)("Availability").ToString
            Dim arrimg19() As Byte = dt.Rows(18)("Picture")
            Dim mstream19 As New System.IO.MemoryStream(arrimg19)
            pic19.Image = Image.FromStream(mstream19)

            lbltitle20.Text = dt.Rows(19)("ServiceTitle").ToString
            lblname20.Text = dt.Rows(19)("ProviderName").ToString
            lbldescription20.Text = dt.Rows(19)("ServiceOffer").ToString
            lblnumber20.Text = dt.Rows(19)("MobileNumber").ToString
            lblemail20.Text = dt.Rows(19)("Email").ToString
            lbllocation20.Text = dt.Rows(19)("ServiceArea").ToString
            lblschedule20.Text = dt.Rows(19)("Availability").ToString
            Dim arrimg20() As Byte = dt.Rows(19)("Picture")
            Dim mstream20 As New System.IO.MemoryStream(arrimg20)
            pic20.Image = Image.FromStream(mstream20)

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            sql = "Select * from UtilityTable where ServiceTitle like '%" & TextBox1.Text & "%'"
            cmd.Parameters.AddWithValue("ServiceTitle", TextBox1.Text)
            cmd.Connection = con
            cmd.CommandText = sql

            dt = New DataTable
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(dt)

            lbltitle1.Text = dt.Rows(0)("ServiceTitle").ToString
            lblname1.Text = dt.Rows(0)("ProviderName").ToString
            lbldescription1.Text = dt.Rows(0)("ServiceOffer").ToString
            lblnumber1.Text = dt.Rows(0)("MobileNumber").ToString
            lblEmail1.Text = dt.Rows(0)("Email").ToString
            lbllocation1.Text = dt.Rows(0)("ServiceArea").ToString
            lblschedule1.Text = dt.Rows(0)("Availability").ToString
            Dim arrimg() As Byte = dt.Rows(0)("Picture")
            Dim mstream As New System.IO.MemoryStream(arrimg)
            pic1.Image = Image.FromStream(mstream)

            lbltitle21.Text = dt.Rows(1)("ServiceTitle").ToString
            lblname22.Text = dt.Rows(1)("ProviderName").ToString
            lbldescription23.Text = dt.Rows(1)("ServiceOffer").ToString
            lblnumber24.Text = dt.Rows(1)("MobileNumber").ToString
            lblemail25.Text = dt.Rows(1)("Email").ToString
            lbllocation26.Text = dt.Rows(1)("ServiceArea").ToString
            lblschedule27.Text = dt.Rows(1)("Availability").ToString
            Dim arrimg2() As Byte = dt.Rows(1)("Picture")
            Dim mstream2 As New System.IO.MemoryStream(arrimg2)
            pic2.Image = Image.FromStream(mstream2)

            lbltitle31.Text = dt.Rows(2)("ServiceTitle").ToString
            lblname32.Text = dt.Rows(2)("ProviderName").ToString
            lbldescription33.Text = dt.Rows(2)("ServiceOffer").ToString
            lblnumber34.Text = dt.Rows(2)("MobileNumber").ToString
            lblemail35.Text = dt.Rows(2)("Email").ToString
            lbllocation36.Text = dt.Rows(2)("ServiceArea").ToString
            lblschedule37.Text = dt.Rows(2)("Availability").ToString
            Dim arrimg3() As Byte = dt.Rows(2)("Picture")
            Dim mstream3 As New System.IO.MemoryStream(arrimg3)
            pic3.Image = Image.FromStream(mstream3)

            lbltitle41.Text = dt.Rows(3)("ServiceTitle").ToString
            lblname42.Text = dt.Rows(3)("ProviderName").ToString
            lbldescription43.Text = dt.Rows(3)("ServiceOffer").ToString
            lblnumber44.Text = dt.Rows(3)("MobileNumber").ToString
            lblemail45.Text = dt.Rows(3)("Email").ToString
            lbllocation46.Text = dt.Rows(3)("ServiceArea").ToString
            lblschedule47.Text = dt.Rows(3)("Availability").ToString
            Dim arrimg4() As Byte = dt.Rows(3)("Picture")
            Dim mstream4 As New System.IO.MemoryStream(arrimg4)
            pic4.Image = Image.FromStream(mstream4)

            lbltitle51.Text = dt.Rows(4)("ServiceTitle").ToString
            lblname52.Text = dt.Rows(4)("ProviderName").ToString
            lbldescription53.Text = dt.Rows(4)("ServiceOffer").ToString
            lblnumber54.Text = dt.Rows(4)("MobileNumber").ToString
            lblemail5.Text = dt.Rows(4)("Email").ToString
            lbllocation5.Text = dt.Rows(4)("ServiceArea").ToString
            lblschedule5.Text = dt.Rows(4)("Availability").ToString
            Dim arrimg5() As Byte = dt.Rows(4)("Picture")
            Dim mstream5 As New System.IO.MemoryStream(arrimg5)
            pic5.Image = Image.FromStream(mstream5)

            lbltitle6.Text = dt.Rows(5)("ServiceTitle").ToString
            lblname6.Text = dt.Rows(5)("ProviderName").ToString
            lbldescription6.Text = dt.Rows(5)("ServiceOffer").ToString
            lblnumber6.Text = dt.Rows(5)("MobileNumber").ToString
            lblemail6.Text = dt.Rows(5)("Email").ToString
            lbllocation6.Text = dt.Rows(5)("ServiceArea").ToString
            lblschedule6.Text = dt.Rows(5)("Availability").ToString
            Dim arrimg6() As Byte = dt.Rows(5)("Picture")
            Dim mstream6 As New System.IO.MemoryStream(arrimg6)
            pic6.Image = Image.FromStream(mstream6)

            lbltitle7.Text = dt.Rows(6)("ServiceTitle").ToString
            lblname7.Text = dt.Rows(6)("ProviderName").ToString
            lbldescription7.Text = dt.Rows(6)("ServiceOffer").ToString
            lblnumber7.Text = dt.Rows(6)("MobileNumber").ToString
            lblemail7.Text = dt.Rows(6)("Email").ToString
            lbllocation7.Text = dt.Rows(6)("ServiceArea").ToString
            lblschedule7.Text = dt.Rows(6)("Availability").ToString
            Dim arrimg7() As Byte = dt.Rows(6)("Picture")
            Dim mstream7 As New System.IO.MemoryStream(arrimg7)
            pic7.Image = Image.FromStream(mstream7)

            lbltitle8.Text = dt.Rows(7)("ServiceTitle").ToString
            lblname8.Text = dt.Rows(7)("ProviderName").ToString
            lbldescription8.Text = dt.Rows(7)("ServiceOffer").ToString
            lblnumber8.Text = dt.Rows(7)("MobileNumber").ToString
            lblemail8.Text = dt.Rows(7)("Email").ToString
            lbllocation8.Text = dt.Rows(7)("ServiceArea").ToString
            lblschedule8.Text = dt.Rows(7)("Availability").ToString
            Dim arrimg8() As Byte = dt.Rows(7)("Picture")
            Dim mstream8 As New System.IO.MemoryStream(arrimg8)
            pic8.Image = Image.FromStream(mstream8)

            lbltitle9.Text = dt.Rows(8)("ServiceTitle").ToString
            lblname9.Text = dt.Rows(8)("ProviderName").ToString
            lbldescription9.Text = dt.Rows(8)("ServiceOffer").ToString
            lblnumber9.Text = dt.Rows(8)("MobileNumber").ToString
            lblemail9.Text = dt.Rows(8)("Email").ToString
            lbllocation9.Text = dt.Rows(8)("ServiceArea").ToString
            lblschedule9.Text = dt.Rows(8)("Availability").ToString
            Dim arrimg9() As Byte = dt.Rows(8)("Picture")
            Dim mstream9 As New System.IO.MemoryStream(arrimg9)
            pic9.Image = Image.FromStream(mstream9)

            lbltitle10.Text = dt.Rows(9)("ServiceTitle").ToString
            lblname10.Text = dt.Rows(9)("ProviderName").ToString
            lbldescription10.Text = dt.Rows(9)("ServiceOffer").ToString
            lblnumber10.Text = dt.Rows(9)("MobileNumber").ToString
            lblemail10.Text = dt.Rows(9)("Email").ToString
            lbllocation10.Text = dt.Rows(9)("ServiceArea").ToString
            lblschedule10.Text = dt.Rows(9)("Availability").ToString
            Dim arrimg10() As Byte = dt.Rows(9)("Picture")
            Dim mstream10 As New System.IO.MemoryStream(arrimg10)
            pic10.Image = Image.FromStream(mstream10)

            lbltitle111.Text = dt.Rows(10)("ServiceTitle").ToString
            lblname112.Text = dt.Rows(10)("ProviderName").ToString
            lbldescription113.Text = dt.Rows(10)("ServiceOffer").ToString
            lblnumber114.Text = dt.Rows(10)("MobileNumber").ToString
            lblemail115.Text = dt.Rows(10)("Email").ToString
            lbllocation116.Text = dt.Rows(10)("ServiceArea").ToString
            lblschedule117.Text = dt.Rows(10)("Availability").ToString
            Dim arrimg11() As Byte = dt.Rows(10)("Picture")
            Dim mstream11 As New System.IO.MemoryStream(arrimg11)
            pic11.Image = Image.FromStream(mstream11)

            lbltitle12.Text = dt.Rows(11)("ServiceTitle").ToString
            lblname12.Text = dt.Rows(11)("ProviderName").ToString
            lbldescription12.Text = dt.Rows(11)("ServiceOffer").ToString
            lblnumber12.Text = dt.Rows(11)("MobileNumber").ToString
            lblemail12.Text = dt.Rows(11)("Email").ToString
            lbllocation12.Text = dt.Rows(11)("ServiceArea").ToString
            lblschedule12.Text = dt.Rows(11)("Availability").ToString
            Dim arrimg12() As Byte = dt.Rows(11)("Picture")
            Dim mstream12 As New System.IO.MemoryStream(arrimg12)
            pic12.Image = Image.FromStream(mstream12)

            lbltitle13.Text = dt.Rows(12)("ServiceTitle").ToString
            lblname13.Text = dt.Rows(12)("ProviderName").ToString
            lbldescription13.Text = dt.Rows(12)("ServiceOffer").ToString
            lblnumber13.Text = dt.Rows(12)("MobileNumber").ToString
            lblemail13.Text = dt.Rows(12)("Email").ToString
            lbllocation13.Text = dt.Rows(12)("ServiceArea").ToString
            lblschedule13.Text = dt.Rows(12)("Availability").ToString
            Dim arrimg13() As Byte = dt.Rows(12)("Picture")
            Dim mstream13 As New System.IO.MemoryStream(arrimg13)
            pic13.Image = Image.FromStream(mstream13)

            lbltitle14.Text = dt.Rows(13)("ServiceTitle").ToString
            lblname14.Text = dt.Rows(13)("ProviderName").ToString
            lbldescription14.Text = dt.Rows(13)("ServiceOffer").ToString
            lblnumber14.Text = dt.Rows(13)("MobileNumber").ToString
            lblemail14.Text = dt.Rows(13)("Email").ToString
            lbllocation14.Text = dt.Rows(13)("ServiceArea").ToString
            lblschedule14.Text = dt.Rows(13)("Availability").ToString
            Dim arrimg14() As Byte = dt.Rows(13)("Picture")
            Dim mstream14 As New System.IO.MemoryStream(arrimg14)
            pic14.Image = Image.FromStream(mstream14)

            lbltitle15.Text = dt.Rows(14)("ServiceTitle").ToString
            lblname15.Text = dt.Rows(14)("ProviderName").ToString
            lbldescription15.Text = dt.Rows(14)("ServiceOffer").ToString
            lblnumber15.Text = dt.Rows(14)("MobileNumber").ToString
            lblemail15.Text = dt.Rows(14)("Email").ToString
            lbllocation15.Text = dt.Rows(14)("ServiceArea").ToString
            lblschedule15.Text = dt.Rows(14)("Availability").ToString
            Dim arrimg15() As Byte = dt.Rows(14)("Picture")
            Dim mstream15 As New System.IO.MemoryStream(arrimg15)
            pic15.Image = Image.FromStream(mstream15)

            lbltitle16.Text = dt.Rows(15)("ServiceTitle").ToString
            lblname16.Text = dt.Rows(15)("ProviderName").ToString
            lbldescription16.Text = dt.Rows(15)("ServiceOffer").ToString
            lblnumber16.Text = dt.Rows(15)("MobileNumber").ToString
            lblemail16.Text = dt.Rows(15)("Email").ToString
            lbllocation16.Text = dt.Rows(15)("ServiceArea").ToString
            lblschedule16.Text = dt.Rows(15)("Availability").ToString
            Dim arrimg16() As Byte = dt.Rows(15)("Picture")
            Dim mstream16 As New System.IO.MemoryStream(arrimg16)
            pic16.Image = Image.FromStream(mstream16)

            lbltitle17.Text = dt.Rows(16)("ServiceTitle").ToString
            lblname17.Text = dt.Rows(16)("ProviderName").ToString
            lbldescription17.Text = dt.Rows(16)("ServiceOffer").ToString
            lblnumber17.Text = dt.Rows(16)("MobileNumber").ToString
            lblemail17.Text = dt.Rows(16)("Email").ToString
            lbllocation17.Text = dt.Rows(16)("ServiceArea").ToString
            lblschedule17.Text = dt.Rows(16)("Availability").ToString
            Dim arrimg17() As Byte = dt.Rows(16)("Picture")
            Dim mstream17 As New System.IO.MemoryStream(arrimg17)
            pic17.Image = Image.FromStream(mstream17)

            lbltitle18.Text = dt.Rows(17)("ServiceTitle").ToString
            lblname18.Text = dt.Rows(17)("ProviderName").ToString
            lbldescription18.Text = dt.Rows(17)("ServiceOffer").ToString
            lblnumber18.Text = dt.Rows(17)("MobileNumber").ToString
            lblemail18.Text = dt.Rows(17)("Email").ToString
            lbllocation18.Text = dt.Rows(17)("ServiceArea").ToString
            lblschedule18.Text = dt.Rows(17)("Availability").ToString
            Dim arrimg18() As Byte = dt.Rows(17)("Picture")
            Dim mstream18 As New System.IO.MemoryStream(arrimg18)
            pic18.Image = Image.FromStream(mstream18)

            lbltitle19.Text = dt.Rows(18)("ServiceTitle").ToString
            lblname19.Text = dt.Rows(18)("ProviderName").ToString
            lbldescription19.Text = dt.Rows(18)("ServiceOffer").ToString
            lblnumber19.Text = dt.Rows(18)("MobileNumber").ToString
            lblemail19.Text = dt.Rows(18)("Email").ToString
            lbllocation19.Text = dt.Rows(18)("ServiceArea").ToString
            lblschedule19.Text = dt.Rows(18)("Availability").ToString
            Dim arrimg19() As Byte = dt.Rows(18)("Picture")
            Dim mstream19 As New System.IO.MemoryStream(arrimg19)
            pic19.Image = Image.FromStream(mstream19)

            lbltitle20.Text = dt.Rows(19)("ServiceTitle").ToString
            lblname20.Text = dt.Rows(19)("ProviderName").ToString
            lbldescription20.Text = dt.Rows(19)("ServiceOffer").ToString
            lblnumber20.Text = dt.Rows(19)("MobileNumber").ToString
            lblemail20.Text = dt.Rows(19)("Email").ToString
            lbllocation20.Text = dt.Rows(19)("ServiceArea").ToString
            lblschedule20.Text = dt.Rows(19)("Availability").ToString
            Dim arrimg20() As Byte = dt.Rows(19)("Picture")
            Dim mstream20 As New System.IO.MemoryStream(arrimg20)
            pic20.Image = Image.FromStream(mstream20)


        Catch ex As Exception

        End Try
        con.Close()

    End Sub

    Private Sub filterBtn_Click(sender As Object, e As EventArgs) Handles filterBtn.Click
        pnlFilter.Visible = True
    End Sub

    Private Sub btnsaveChanges_Click(sender As Object, e As EventArgs) Handles btnsaveChanges.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            sql = "Select * from UtilityTable where ServiceArea like '%" & cbCity.Text & "%'"
            cmd.Parameters.AddWithValue("ServiceTitle", TextBox1.Text)
            cmd.Connection = con
            cmd.CommandText = sql

            dt = New DataTable
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(dt)

            lbltitle1.Text = dt.Rows(0)("ServiceTitle").ToString
            lblname1.Text = dt.Rows(0)("ProviderName").ToString
            lbldescription1.Text = dt.Rows(0)("ServiceOffer").ToString
            lblnumber1.Text = dt.Rows(0)("MobileNumber").ToString
            lblEmail1.Text = dt.Rows(0)("Email").ToString
            lbllocation1.Text = dt.Rows(0)("ServiceArea").ToString
            lblschedule1.Text = dt.Rows(0)("Availability").ToString
            Dim arrimg() As Byte = dt.Rows(0)("Picture")
            Dim mstream As New System.IO.MemoryStream(arrimg)
            pic1.Image = Image.FromStream(mstream)

            lbltitle21.Text = dt.Rows(1)("ServiceTitle").ToString
            lblname22.Text = dt.Rows(1)("ProviderName").ToString
            lbldescription23.Text = dt.Rows(1)("ServiceOffer").ToString
            lblnumber24.Text = dt.Rows(1)("MobileNumber").ToString
            lblemail25.Text = dt.Rows(1)("Email").ToString
            lbllocation26.Text = dt.Rows(1)("ServiceArea").ToString
            lblschedule27.Text = dt.Rows(1)("Availability").ToString
            Dim arrimg2() As Byte = dt.Rows(1)("Picture")
            Dim mstream2 As New System.IO.MemoryStream(arrimg2)
            pic2.Image = Image.FromStream(mstream2)

            lbltitle31.Text = dt.Rows(2)("ServiceTitle").ToString
            lblname32.Text = dt.Rows(2)("ProviderName").ToString
            lbldescription33.Text = dt.Rows(2)("ServiceOffer").ToString
            lblnumber34.Text = dt.Rows(2)("MobileNumber").ToString
            lblemail35.Text = dt.Rows(2)("Email").ToString
            lbllocation36.Text = dt.Rows(2)("ServiceArea").ToString
            lblschedule37.Text = dt.Rows(2)("Availability").ToString
            Dim arrimg3() As Byte = dt.Rows(2)("Picture")
            Dim mstream3 As New System.IO.MemoryStream(arrimg3)
            pic3.Image = Image.FromStream(mstream3)

            lbltitle41.Text = dt.Rows(3)("ServiceTitle").ToString
            lblname42.Text = dt.Rows(3)("ProviderName").ToString
            lbldescription43.Text = dt.Rows(3)("ServiceOffer").ToString
            lblnumber44.Text = dt.Rows(3)("MobileNumber").ToString
            lblemail45.Text = dt.Rows(3)("Email").ToString
            lbllocation46.Text = dt.Rows(3)("ServiceArea").ToString
            lblschedule47.Text = dt.Rows(3)("Availability").ToString
            Dim arrimg4() As Byte = dt.Rows(3)("Picture")
            Dim mstream4 As New System.IO.MemoryStream(arrimg4)
            pic4.Image = Image.FromStream(mstream4)

            lbltitle51.Text = dt.Rows(4)("ServiceTitle").ToString
            lblname52.Text = dt.Rows(4)("ProviderName").ToString
            lbldescription53.Text = dt.Rows(4)("ServiceOffer").ToString
            lblnumber54.Text = dt.Rows(4)("MobileNumber").ToString
            lblemail5.Text = dt.Rows(4)("Email").ToString
            lbllocation5.Text = dt.Rows(4)("ServiceArea").ToString
            lblschedule5.Text = dt.Rows(4)("Availability").ToString
            Dim arrimg5() As Byte = dt.Rows(4)("Picture")
            Dim mstream5 As New System.IO.MemoryStream(arrimg5)
            pic5.Image = Image.FromStream(mstream5)

            lbltitle6.Text = dt.Rows(5)("ServiceTitle").ToString
            lblname6.Text = dt.Rows(5)("ProviderName").ToString
            lbldescription6.Text = dt.Rows(5)("ServiceOffer").ToString
            lblnumber6.Text = dt.Rows(5)("MobileNumber").ToString
            lblemail6.Text = dt.Rows(5)("Email").ToString
            lbllocation6.Text = dt.Rows(5)("ServiceArea").ToString
            lblschedule6.Text = dt.Rows(5)("Availability").ToString
            Dim arrimg6() As Byte = dt.Rows(5)("Picture")
            Dim mstream6 As New System.IO.MemoryStream(arrimg6)
            pic6.Image = Image.FromStream(mstream6)

            lbltitle7.Text = dt.Rows(6)("ServiceTitle").ToString
            lblname7.Text = dt.Rows(6)("ProviderName").ToString
            lbldescription7.Text = dt.Rows(6)("ServiceOffer").ToString
            lblnumber7.Text = dt.Rows(6)("MobileNumber").ToString
            lblemail7.Text = dt.Rows(6)("Email").ToString
            lbllocation7.Text = dt.Rows(6)("ServiceArea").ToString
            lblschedule7.Text = dt.Rows(6)("Availability").ToString
            Dim arrimg7() As Byte = dt.Rows(6)("Picture")
            Dim mstream7 As New System.IO.MemoryStream(arrimg7)
            pic7.Image = Image.FromStream(mstream7)

            lbltitle8.Text = dt.Rows(7)("ServiceTitle").ToString
            lblname8.Text = dt.Rows(7)("ProviderName").ToString
            lbldescription8.Text = dt.Rows(7)("ServiceOffer").ToString
            lblnumber8.Text = dt.Rows(7)("MobileNumber").ToString
            lblemail8.Text = dt.Rows(7)("Email").ToString
            lbllocation8.Text = dt.Rows(7)("ServiceArea").ToString
            lblschedule8.Text = dt.Rows(7)("Availability").ToString
            Dim arrimg8() As Byte = dt.Rows(7)("Picture")
            Dim mstream8 As New System.IO.MemoryStream(arrimg8)
            pic8.Image = Image.FromStream(mstream8)

            lbltitle9.Text = dt.Rows(8)("ServiceTitle").ToString
            lblname9.Text = dt.Rows(8)("ProviderName").ToString
            lbldescription9.Text = dt.Rows(8)("ServiceOffer").ToString
            lblnumber9.Text = dt.Rows(8)("MobileNumber").ToString
            lblemail9.Text = dt.Rows(8)("Email").ToString
            lbllocation9.Text = dt.Rows(8)("ServiceArea").ToString
            lblschedule9.Text = dt.Rows(8)("Availability").ToString
            Dim arrimg9() As Byte = dt.Rows(8)("Picture")
            Dim mstream9 As New System.IO.MemoryStream(arrimg9)
            pic9.Image = Image.FromStream(mstream9)

            lbltitle10.Text = dt.Rows(9)("ServiceTitle").ToString
            lblname10.Text = dt.Rows(9)("ProviderName").ToString
            lbldescription10.Text = dt.Rows(9)("ServiceOffer").ToString
            lblnumber10.Text = dt.Rows(9)("MobileNumber").ToString
            lblemail10.Text = dt.Rows(9)("Email").ToString
            lbllocation10.Text = dt.Rows(9)("ServiceArea").ToString
            lblschedule10.Text = dt.Rows(9)("Availability").ToString
            Dim arrimg10() As Byte = dt.Rows(9)("Picture")
            Dim mstream10 As New System.IO.MemoryStream(arrimg10)
            pic10.Image = Image.FromStream(mstream10)

            lbltitle111.Text = dt.Rows(10)("ServiceTitle").ToString
            lblname112.Text = dt.Rows(10)("ProviderName").ToString
            lbldescription113.Text = dt.Rows(10)("ServiceOffer").ToString
            lblnumber114.Text = dt.Rows(10)("MobileNumber").ToString
            lblemail115.Text = dt.Rows(10)("Email").ToString
            lbllocation116.Text = dt.Rows(10)("ServiceArea").ToString
            lblschedule117.Text = dt.Rows(10)("Availability").ToString
            Dim arrimg11() As Byte = dt.Rows(10)("Picture")
            Dim mstream11 As New System.IO.MemoryStream(arrimg11)
            pic11.Image = Image.FromStream(mstream11)

            lbltitle12.Text = dt.Rows(11)("ServiceTitle").ToString
            lblname12.Text = dt.Rows(11)("ProviderName").ToString
            lbldescription12.Text = dt.Rows(11)("ServiceOffer").ToString
            lblnumber12.Text = dt.Rows(11)("MobileNumber").ToString
            lblemail12.Text = dt.Rows(11)("Email").ToString
            lbllocation12.Text = dt.Rows(11)("ServiceArea").ToString
            lblschedule12.Text = dt.Rows(11)("Availability").ToString
            Dim arrimg12() As Byte = dt.Rows(11)("Picture")
            Dim mstream12 As New System.IO.MemoryStream(arrimg12)
            pic12.Image = Image.FromStream(mstream12)

            lbltitle13.Text = dt.Rows(12)("ServiceTitle").ToString
            lblname13.Text = dt.Rows(12)("ProviderName").ToString
            lbldescription13.Text = dt.Rows(12)("ServiceOffer").ToString
            lblnumber13.Text = dt.Rows(12)("MobileNumber").ToString
            lblemail13.Text = dt.Rows(12)("Email").ToString
            lbllocation13.Text = dt.Rows(12)("ServiceArea").ToString
            lblschedule13.Text = dt.Rows(12)("Availability").ToString
            Dim arrimg13() As Byte = dt.Rows(12)("Picture")
            Dim mstream13 As New System.IO.MemoryStream(arrimg13)
            pic13.Image = Image.FromStream(mstream13)

            lbltitle14.Text = dt.Rows(13)("ServiceTitle").ToString
            lblname14.Text = dt.Rows(13)("ProviderName").ToString
            lbldescription14.Text = dt.Rows(13)("ServiceOffer").ToString
            lblnumber14.Text = dt.Rows(13)("MobileNumber").ToString
            lblemail14.Text = dt.Rows(13)("Email").ToString
            lbllocation14.Text = dt.Rows(13)("ServiceArea").ToString
            lblschedule14.Text = dt.Rows(13)("Availability").ToString
            Dim arrimg14() As Byte = dt.Rows(13)("Picture")
            Dim mstream14 As New System.IO.MemoryStream(arrimg14)
            pic14.Image = Image.FromStream(mstream14)

            lbltitle15.Text = dt.Rows(14)("ServiceTitle").ToString
            lblname15.Text = dt.Rows(14)("ProviderName").ToString
            lbldescription15.Text = dt.Rows(14)("ServiceOffer").ToString
            lblnumber15.Text = dt.Rows(14)("MobileNumber").ToString
            lblemail15.Text = dt.Rows(14)("Email").ToString
            lbllocation15.Text = dt.Rows(14)("ServiceArea").ToString
            lblschedule15.Text = dt.Rows(14)("Availability").ToString
            Dim arrimg15() As Byte = dt.Rows(14)("Picture")
            Dim mstream15 As New System.IO.MemoryStream(arrimg15)
            pic15.Image = Image.FromStream(mstream15)

            lbltitle16.Text = dt.Rows(15)("ServiceTitle").ToString
            lblname16.Text = dt.Rows(15)("ProviderName").ToString
            lbldescription16.Text = dt.Rows(15)("ServiceOffer").ToString
            lblnumber16.Text = dt.Rows(15)("MobileNumber").ToString
            lblemail16.Text = dt.Rows(15)("Email").ToString
            lbllocation16.Text = dt.Rows(15)("ServiceArea").ToString
            lblschedule16.Text = dt.Rows(15)("Availability").ToString
            Dim arrimg16() As Byte = dt.Rows(15)("Picture")
            Dim mstream16 As New System.IO.MemoryStream(arrimg16)
            pic16.Image = Image.FromStream(mstream16)

            lbltitle17.Text = dt.Rows(16)("ServiceTitle").ToString
            lblname17.Text = dt.Rows(16)("ProviderName").ToString
            lbldescription17.Text = dt.Rows(16)("ServiceOffer").ToString
            lblnumber17.Text = dt.Rows(16)("MobileNumber").ToString
            lblemail17.Text = dt.Rows(16)("Email").ToString
            lbllocation17.Text = dt.Rows(16)("ServiceArea").ToString
            lblschedule17.Text = dt.Rows(16)("Availability").ToString
            Dim arrimg17() As Byte = dt.Rows(16)("Picture")
            Dim mstream17 As New System.IO.MemoryStream(arrimg17)
            pic17.Image = Image.FromStream(mstream17)

            lbltitle18.Text = dt.Rows(17)("ServiceTitle").ToString
            lblname18.Text = dt.Rows(17)("ProviderName").ToString
            lbldescription18.Text = dt.Rows(17)("ServiceOffer").ToString
            lblnumber18.Text = dt.Rows(17)("MobileNumber").ToString
            lblemail18.Text = dt.Rows(17)("Email").ToString
            lbllocation18.Text = dt.Rows(17)("ServiceArea").ToString
            lblschedule18.Text = dt.Rows(17)("Availability").ToString
            Dim arrimg18() As Byte = dt.Rows(17)("Picture")
            Dim mstream18 As New System.IO.MemoryStream(arrimg18)
            pic18.Image = Image.FromStream(mstream18)

            lbltitle19.Text = dt.Rows(18)("ServiceTitle").ToString
            lblname19.Text = dt.Rows(18)("ProviderName").ToString
            lbldescription19.Text = dt.Rows(18)("ServiceOffer").ToString
            lblnumber19.Text = dt.Rows(18)("MobileNumber").ToString
            lblemail19.Text = dt.Rows(18)("Email").ToString
            lbllocation19.Text = dt.Rows(18)("ServiceArea").ToString
            lblschedule19.Text = dt.Rows(18)("Availability").ToString
            Dim arrimg19() As Byte = dt.Rows(18)("Picture")
            Dim mstream19 As New System.IO.MemoryStream(arrimg19)
            pic19.Image = Image.FromStream(mstream19)

            lbltitle20.Text = dt.Rows(19)("ServiceTitle").ToString
            lblname20.Text = dt.Rows(19)("ProviderName").ToString
            lbldescription20.Text = dt.Rows(19)("ServiceOffer").ToString
            lblnumber20.Text = dt.Rows(19)("MobileNumber").ToString
            lblemail20.Text = dt.Rows(19)("Email").ToString
            lbllocation20.Text = dt.Rows(19)("ServiceArea").ToString
            lblschedule20.Text = dt.Rows(19)("Availability").ToString
            Dim arrimg20() As Byte = dt.Rows(19)("Picture")
            Dim mstream20 As New System.IO.MemoryStream(arrimg20)
            pic20.Image = Image.FromStream(mstream20)

        Catch ex As Exception

        End Try
        pnlFilter.Visible = False
        con.Close()
    End Sub
End Class