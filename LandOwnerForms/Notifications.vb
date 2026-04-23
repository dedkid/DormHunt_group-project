Public Class LNotifications

    Private Sub roundcornerPanel(pnl As Panel)

        ' Dim rad As New Drawing2D.GraphicsPath
        'rad.StartFigure()

        'rad.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        'rad.AddLine(40, 0, pnl.Width - 40, 0)

        'rad.AddArc(New Rectangle(pnl.Width - 40, 0, 40, 40), -90, 90)
        'rad.AddLine(Lpnl1.Width, 40, pnl.Width, pnl.Height - 40)

        'rad.AddArc(New Rectangle(pnl.Width - 40, pnl.Height - 40, 40, 40), 0, 90)
        'rad.AddLine(pnl.Width - 40, pnl.Height, 40, pnl.Height)

        'rad.AddArc(New Rectangle(0, pnl.Height - 40, 40, 40), 90, 90)


        'Lpnl1.Region = New Region(rad)
        'Lpnl2.Region = New Region(rad)
        'Lpnl3.Region = New Region(rad)
    End Sub

    Private Sub notifications_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'roundcornerPanel(Lpnl1)
        'roundcornerPanel(Lpnl2)
        'roundcornerPanel(Lpnl3)
    End Sub

    Private Sub Lpnl1_Paint(sender As Object, e As PaintEventArgs) Handles Lpnl1.Paint

    End Sub
End Class