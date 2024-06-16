Imports System.Data.SqlClient

Public Class BookingListForm
    Private Sub BookingListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookingData()
    End Sub

    Private Sub LoadBookingData()
        Dim query As String = "SELECT BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, Status FROM Bookings"
        Dim connectionString As String = "Data Source=KASTURI\SQLEXPRESS;Initial Catalog=Hotel_Reservation_System;Integrated Security=True;"
        Dim adapter As New SqlDataAdapter(query, connectionString)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridViewBookings.DataSource = table
    End Sub
End Class

