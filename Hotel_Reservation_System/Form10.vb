Imports System.Data.SqlClient

Public Class InvoiceForm
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim query As String = "INSERT INTO Invoices (BookingID, RoomCharges, AdditionalCharges, TotalAmount, PaymentStatus) VALUES (@BookingID, @RoomCharges, @AdditionalCharges, @TotalAmount, @PaymentStatus)"
        Dim connectionString As String = "Data Source=KASTURI\SQLEXPRESS;Initial Catalog=Hotel_Reservation_System;Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)
        Dim command As New SqlCommand(query, connection)

        ' No need to include InvoiceID as it is an identity column
        command.Parameters.AddWithValue("@BookingID", txtBookingID.Text)
        command.Parameters.AddWithValue("@RoomCharges", txtRoomCharges.Text)
        command.Parameters.AddWithValue("@AdditionalCharges", txtAdditionalCharges.Text)
        command.Parameters.AddWithValue("@TotalAmount", txtTotalAmount.Text)
        command.Parameters.AddWithValue("@PaymentStatus", txtPaymentStatus.Text)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        MessageBox.Show("Invoice generated successfully!")
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class

