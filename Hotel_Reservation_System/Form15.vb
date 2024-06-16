Public Class checkInOutForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckOutForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckInForm.Show()
    End Sub


End Class