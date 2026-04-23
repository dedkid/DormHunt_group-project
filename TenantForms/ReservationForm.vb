Imports System.Data.OleDb
Public Class ReservationForm
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim i
    Dim HowMany As String
    Dim DateFrom As String
    Dim DateTo As String
    Dim Sched As String
    Dim lisIDRS
    Dim gotUidRS
    Dim UIDofListerRS
    Dim up As String = "Upcoming"

    Public Sub New(ByVal gotUidTVM As String, lisID As Integer, ByVal UIDofLister As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        gotUidRS = gotUidTVM
        lisIDRS = lisID
        UIDofListerRS = UIDofLister
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    'load the listing data 
    Private Sub ReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim Sql As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()

            Sql = "Select * From ListingTable Where ListingID=" & Val(lisIDRS)
            cmd.Connection = con
            cmd.CommandText = Sql
            da.SelectCommand = cmd

            da.Fill(dt)

            lbltype.Text = dt.Rows(0)("Type").ToString
            lblPrice.Text = dt.Rows(0)("Price").ToString
            lblLocation.Text = dt.Rows(0)("Location").ToString
            lblmax.Text = dt.Rows(0)("MaxPeople").ToString
            lbldescription.Text = dt.Rows(0)("Description").ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'confirm the resrvation
    Private Sub btnConfirmReservation_Click(sender As Object, e As EventArgs) Handles btnConfirmReservation.Click
        DateFrom = DateTimePicker1.Text
        DateTo = DateTimePicker2.Text
        Sched = DateTimePicker3.Text
        HowMany = NumericUpDown1.Text
        If HowMany < 1 Then
            MsgBox("Please enter a valid number of people.", vbOKOnly + vbExclamation, "Invalid Entry")
        Else
            Try
                Dim sql As String
                Dim cmd As New OleDb.OleDbCommand

                con.Open()
                sql = "INSERT into ReservationTable (UserID, ListingID, HowMany, `DateFrom`, `DateTo`, `VisitSchedule`,`Status`) VALUES(" & Val(UIDofListerRS) & "," & Val(lisIDRS) & ",@HowMany, @DateFrom, @DateTo,@Sched,@Status)"
                cmd.Parameters.AddWithValue("HowMany", HowMany)
                cmd.Parameters.AddWithValue("DateFrom", DateFrom)
                cmd.Parameters.AddWithValue("DateTo", DateTo)
                cmd.Parameters.AddWithValue("VisitSchedule", Sched)
                cmd.Parameters.AddWithValue("Status", up)
                cmd.Connection = con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("You Successfuly sent your reservation request.", vbOKOnly, "RESERVE")
                    Me.Hide()
                Else
                    MsgBox("No record has been SAVED!")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If

        'notify the user that reservation request received
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim theDate = DateTime.Today.ToString("'#'yyyy'/'MM'/'dd'#'")
            Dim desN As String = "We received your Reservation regards listing number" & CStr(lisIDRS) & " ."

            con.Open()
            sql = "Insert Into NotificationTable(UserID, nTime, Title, Description) Values(" & Val(gotUidRS) & "," & CStr(theDate) & ",'Resevation Request Sent', '" & CStr(desN) & "')"

            cmd.Connection = con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        'notify the landowner that someone was sent reservation request
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim theDate = DateTime.Today.ToString("'#'yyyy'/'MM'/'dd'#'")
            Dim desN As String = "Someone sent you a reservation request for your Listing " & CStr(lisIDRS) & " ."

            con.Open()
            sql = "Insert Into NotificationTable(UserID, nTime, Title, Description) Values(" & Val(UIDofListerRS) & "," & CStr(theDate) & ",'Resevation Request', '" & CStr(desN) & "')"

            cmd.Connection = con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

End Class