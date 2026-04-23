Imports System.Data.OleDb
Public Class LoginForm

    ' 1. This is just the text path (The Address)
    Dim dbPath As String = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "DormHuntDB.accdb")

    ' 2. This is the Connection String (The Instructions)
    ' Rename this to 'connString' so it doesn't conflict with your object
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & dbPath

    ' 3. This is the ACTUAL Connection Object (The Telephone)
    ' This is the one that has .Open() and .Close()
    Dim con As New OleDb.OleDbConnection(connString)
    Dim uID As Integer

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtEmail.Text = "" Or txtPassword.Text = "" Then ' Changed AND to OR for better validation
            MsgBox("Please fill up all required fields!", vbInformation + vbExclamation, "Error")
            Exit Sub
        End If

        Try
            ' 1. SAFE OPEN: Check state before opening
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Using cmd As New OleDbCommand("SELECT * FROM UserTable WHERE [Email] = @Email AND [UserPassword] = @Password", con)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim)

                Dim usertable As New DataTable
                Using ds As New OleDbDataAdapter(cmd)
                    ds.Fill(usertable)
                End Using

                ' 2. CHECK FOR ROWS: This prevents the "No row at position 0" error
                If usertable.Rows.Count > 0 Then
                    uID = usertable.Rows(0)("UserID")
                    Dim userType As String = usertable.Rows(0)("UserType").ToString()

                    If userType = "LandOwner" Then
                        Dim LandOwnerD = New LDashboard(uID)
                        Me.Hide()
                        LandOwnerD.Show()
                    ElseIf userType = "Tenant" Then
                        Dim TenantD = New TDashBoard(uID)
                        Me.Hide()
                        TenantD.Show()
                    End If
                    txtPassword.Clear()
                Else
                    ' If no records match, we handle it here instead of crashing
                    MsgBox("Please input correct email or password!", vbOKOnly + vbCritical, "Login Failed")
                    txtPassword.Clear()
                End If
            End Using

        Catch ex As Exception
            ' This will now catch actual database errors (like missing files)
            MsgBox("Database Error: " & ex.Message, vbOKOnly + vbExclamation, "System Error")
        Finally
            ' 3. SAFE CLOSE: Ensure the connection is always closed
            con.Close()
        End Try
    End Sub

    Private Sub txtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        If e.KeyChar = Chr(13) Then
            'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            btnLogin_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            btnLogin_Click(Me, EventArgs.Empty)
        End If
    End Sub
    Private Sub pbShowPassword_Click(sender As Object, e As EventArgs) Handles pbShowPassword.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        ElseIf txtPassword.UseSystemPasswordChar = False Then
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Me.Hide()
        SignupQuestionForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class