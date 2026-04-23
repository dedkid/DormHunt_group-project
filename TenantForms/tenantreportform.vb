Imports System.Data.OleDb
Public Class tenantreportform
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim i
    Dim lisIDR
    Dim gotUidR
    Dim UIDofListerR

    Public Sub New(ByVal gotUidTVM As String, lisID As Integer, ByVal UIDofLister As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        gotUidR = gotUidTVM
        lisIDR = lisID
        UIDofListerR = UIDofLister
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        If RichTextBox1.Text <> Nothing Then
            Try
                Dim sql As String
                Dim cmd As New OleDb.OleDbCommand
                con.Open()
                sql = "Insert Into ReportTable(UserID,ListingID,Description) Values(" & Val(gotUidR) & "," & Val(lisIDR) & ",'" & RichTextBox1.Text & "')"

                cmd.Connection = con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("We Received your report.", vbOKOnly, "REPORT")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        Else
            MsgBox("The reason of reporting is empty!", vbOKOnly + vbExclamation, "Report")
        End If

        'notify the user that the report has received
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim theDate = DateTime.Today.ToString("'#'yyyy'/'MM'/'dd'#'")
            Dim desN As String = "We received your complaint regards listing number" & CStr(lisIDR) & " . Surely, necessary action will be taken! "

            con.Open()

            sql = "Insert Into NotificationTable(UserID, nTime, Title, Description) Values(" & Val(gotUidR) & "," & CStr(theDate) & ",'Report Submitted', '" & CStr(desN) & "')"

            cmd.Connection = con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        'notify the landowner that his listing is being reported
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim theDate = DateTime.Today.ToString("'#'yyyy'/'MM'/'dd'#'")
            Dim desN As String = "Your posted room for rent with Listing ID " & CStr(lisIDR) & " has been reported to us."

            con.Open()

            sql = "Insert Into NotificationTable(UserID, nTime, Title, Description) Values(" & Val(UIDofListerR) & "," & CStr(theDate) & ",'Listing Reported', '" & CStr(desN) & "')"

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
