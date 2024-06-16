Imports System.Data.SqlClient

Public Class CheckOutForm
    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim query As String = "INSERT INTO CheckOuts (BookingID, CheckOutDate, TotalBillAmount) VALUES (@BookingID, @CheckOutDate, @TotalBillAmount)"
        Dim connectionString As String = "Data Source=KASTURI\SQLEXPRESS;Initial Catalog=Hotel_Reservation_System;Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)
        Dim command As New SqlCommand(query, connection)

        ' No need to include CheckOutID as it is an identity column
        command.Parameters.AddWithValue("@BookingID", txtBookingID.Text)
        command.Parameters.AddWithValue("@CheckOutDate", dtpCheckOutDate.Value)
        command.Parameters.AddWithValue("@TotalBillAmount", txtTotalBillAmount.Text)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        MessageBox.Show("Check-out successful!")
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CheckOutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class




