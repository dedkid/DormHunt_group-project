Imports System.Data.OleDb
Public Class reservationLForm
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user\Repository\clone999\DataBase\DormHuntDB.accdb")
    Dim selected
    Dim gotuidR
    Dim stat As String = "Completed"
    Dim i
    Public Sub New(ByVal gotUidLD As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        gotuidR = CInt(gotUidLD)
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub LbtnUpcoming_Click(sender As Object, e As EventArgs) Handles LbtnUpcoming.Click
        Try
            Dim Sql As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            Sql = "Select * from ReservationTable Where Status = 'Upcoming' And UserID=" & Val(gotuidR)
            cmd.Connection = con
            cmd.CommandText = Sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub reservationLForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Sql As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            Sql = "Select * from ReservationTable Where Status = 'Upcoming' And UserID=" & Val(gotuidR)
            cmd.Connection = con
            cmd.CommandText = Sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        selected = DataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub LbtnCompleted_Click(sender As Object, e As EventArgs) Handles LbtnCompleted.Click
        Try
            Dim Sql As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            Sql = "Select * from ReservationTable Where Status = 'Completed' And UserID = " & Val(gotuidR)
            cmd.Connection = con
            cmd.CommandText = Sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            Dim Sql As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()

            Sql = "UPDATE ReservationTable Set Status ='" & stat & "' Where ReservationID = " & Val(selected)
            cmd.Connection = con
            cmd.CommandText = Sql
            da.SelectCommand = cmd
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Reservation Confirmed.", vbOKOnly + vbInformation, "COMPLETED")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class