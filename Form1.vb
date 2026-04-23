Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Timer1.Stop()
            Me.Hide()
            LoginSignupForm.Show()
        Else
            ProgressBar1.PerformStep()
            lblPercentage.Text = ProgressBar1.Value & " %"
        End If
    End Sub

End Class
