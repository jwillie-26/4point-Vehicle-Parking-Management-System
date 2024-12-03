Public Class LoadingForm

    ' Starts the fade-in and progress timers when the form loads
    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0 ' Start with invisible form
        Timer2.Interval = 50 ' Interval for fade-in effect
        Timer2.Start()

        Timer1.Interval = 50 ' Interval for progress bar
        Timer1.Start()
    End Sub

    ' Timer for fade-in effect
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05 ' Increase opacity gradually
        Else
            Timer2.Stop() ' Stop once fully visible
        End If
    End Sub

    ' Timer for updating the progress bar
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment the progress bar
        If progressBarLoading.Value < 100 Then
            progressBarLoading.Value += 1
        Else
            Timer1.Stop() ' Stop the timer when progress reaches 100%
            Me.Hide() ' Hide the loading form after completion
            ParkingForm.Show() ' Show the main form
        End If
    End Sub
End Class
