Public Class billingForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PaymentForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        InvoiceForm.Show()
    End Sub


End Class