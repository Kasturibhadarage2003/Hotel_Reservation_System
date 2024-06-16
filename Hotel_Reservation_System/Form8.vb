Imports System.Data.SqlClient

Public Class CheckInForm
    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        Dim query As String = "INSERT INTO CheckIns (BookingID, CheckInDate, NumberOfGuests) VALUES (@BookingID, @CheckInDate, @NumberOfGuests)"
        Dim connectionString As String = "Data Source=KASTURI\SQLEXPRESS;Initial Catalog=Hotel_Reservation_System;Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)
        Dim command As New SqlCommand(query, connection)

        ' Removing the CheckInID parameter as it is an identity column
        ' command.Parameters.AddWithValue("@CheckInID", txtCheckInID.Text)
        command.Parameters.AddWithValue("@BookingID", txtBookingID.Text)
        ' command.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text)
        ' command.Parameters.AddWithValue("@RoomID", txtRoomID.Text)
        command.Parameters.AddWithValue("@CheckInDate", dtpCheckInDate.Value)
        command.Parameters.AddWithValue("@NumberOfGuests", txtNumberOfGuests.Text)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        MessageBox.Show("Check-in successful!")
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CheckInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

