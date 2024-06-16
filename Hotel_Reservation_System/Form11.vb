Imports System.Data.SqlClient

Public Class PaymentForm
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim query As String = "INSERT INTO Payments (InvoiceID, AmountPaid, PaymentDate, PaymentMethod) VALUES (@InvoiceID, @AmountPaid, @PaymentDate, @PaymentMethod)"
            Dim connectionString As String = "Data Source=KASTURI\SQLEXPRESS;Initial Catalog=Hotel_Reservation_System;Integrated Security=True;"
            Dim connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)

            ' No need to include PaymentID as it is an identity column
            command.Parameters.AddWithValue("@InvoiceID", txtInvoiceID.Text)
            command.Parameters.AddWithValue("@AmountPaid", txtAmountPaid.Text)
            command.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value)
            command.Parameters.AddWithValue("@PaymentMethod", txtPaymentMethod.Text)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            MessageBox.Show("Payment submitted successfully!")
            Me.Close()
        Catch ex As SqlException
            MessageBox.Show("SQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


