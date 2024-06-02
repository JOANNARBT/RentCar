Public Class SplashScreen

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Enabled = True
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Timer.Interval = Timer.Interval + 10
        If Timer.Interval > 300 Then
            Timer.Enabled = False
            Me.Hide()
            DashBoard.Show()
        End If
    End Sub
End Class