Imports System.Data.OleDb
Public Class SignupQuestionForm
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\olive\Documents\Finalproject_Database.accdb")
    Dim i
    Private Sub btnTenant_Click(sender As Object, e As EventArgs) Handles btnTenant.Click
        Me.Hide()
        SignUp_Form.Show()




    End Sub

    Private Sub btnLandOwner_Click(sender As Object, e As EventArgs) Handles btnLandOwner.Click
        Me.Hide()
        SignUpForm_Landowner.Show()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        LoginSignupForm.Show()
    End Sub

    Private Sub SignupQuestionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'round the backbutton
        Dim btn As New Drawing2D.GraphicsPath
        btn.AddEllipse(0, 0, 45, 45)
        btnBack.Region = New Region(btn)
    End Sub

End Class