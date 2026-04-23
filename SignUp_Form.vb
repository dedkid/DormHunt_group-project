Imports System.Data.OleDb
Public Class SignUp_Form

    ' This finds the folder where your .exe is currently running
    Dim dbPath As String = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "DormHuntDB.accdb")

    ' This uses that dynamic path for the connection
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath)
    Dim i
    Dim uID As String
    Dim Gender As String
    Dim BirthDate As String
    'To set the user type as Tenant
    Dim Utype As String = "Tenant"

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If String.IsNullOrEmpty(txtFName.Text) Or String.IsNullOrEmpty(txtLName.Text) Or String.IsNullOrEmpty(txtContact.Text) Or String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrEmpty(txtPassword.Text) Or String.IsNullOrEmpty(txtConfirmPW.Text) Or rbFemale.Checked = False And rbMale.Checked = False Then
            MsgBox("Fill up required fields!", vbOKOnly + vbExclamation, "Empty Field(s)!")
        Else
            If IsNumeric(txtContact.Text) Then

                'To confirm if the initial password is the same
                Dim initialPassword = txtPassword.Text
                If initialPassword <> txtConfirmPW.Text Then
                    MsgBox("Password does not MATCH", vbOKOnly + vbCritical, "Match Not Found")
                End If

                'Get the gender and birthdate of the user
                If rbMale.Checked = True Then
                    Gender = rbMale.Text
                End If

                If rbFemale.Checked = True Then
                    Gender = rbFemale.Text
                End If

                BirthDate = bday.Text

                'To save the user's data to database
                Try
                    con.Open()
                    Dim sql As String = "Insert Into UserTable(`FirstName`,`MiddleName`, `LastName`,`Gender`,`MobileNumber`, `Email`, `AddressID` , `BirthDate`,`UserPassword`, `UserType`) VALUES (@FirstName, @MiddleName,@LastName,@Gender, @MobileNumber, @Email, 'x' , @BirthDate,@Password, @UserType)"
                    Dim cmd As New OleDb.OleDbCommand(sql, con)

                    cmd.Parameters.AddWithValue("FirstName", txtFName.Text)
                    cmd.Parameters.AddWithValue("MiddleName", txtMname.Text)
                    cmd.Parameters.AddWithValue("LastName", txtLName.Text)
                    cmd.Parameters.AddWithValue("Gender", Gender)
                    cmd.Parameters.AddWithValue("MobileNumber", txtContact.Text)
                    cmd.Parameters.AddWithValue("Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("Birthday", BirthDate)
                    cmd.Parameters.AddWithValue("Password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("UserType", Utype)

                    i = cmd.ExecuteNonQuery

                    If i > 0 Then

                        MsgBox("Record has been SAVED successfully!", vbOKOnly + vbInformation, "SAVE")

                        'To get the User ID of the individual signing up then forward to sign up location form
                        Try
                            Dim sql2 As String = "Select UserID From UserTable Where FirstName='" & txtFName.Text & "' And LastName='" & txtLName.Text & "' And UserPassword='" & txtPassword.Text & "'"
                            Dim cmd2 As New OleDb.OleDbCommand(sql2, con)

                            Dim reader As OleDbDataReader
                            reader = cmd2.ExecuteReader

                            reader.Read()
                            uID = reader("UserID")

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            Dim locationForm = New SignUp_Location_Form(uID)
                            locationForm.Show()
                            Me.Hide()
                            con.Close()
                        End Try

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                txtContact.Focus()
                MsgBox("Enter a valid phone number!", vbOKOnly + vbCritical, "Invalid Entry!")
            End If

        End If
    End Sub
    'back to question form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        SignupQuestionForm.Show()
    End Sub

    Private Sub SignUp_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'round the picbox
        Dim pic As New Drawing2D.GraphicsPath
        pic.AddEllipse(0, 0, 45, 45)
        btnBack.Region = New Region(pic)

        'round the backbutton
        Dim btn As New Drawing2D.GraphicsPath
        btn.AddEllipse(0, 0, 45, 45)
        btnBack.Region = New Region(btn)
    End Sub
End Class