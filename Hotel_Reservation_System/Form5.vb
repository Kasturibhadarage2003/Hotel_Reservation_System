Imports System.Data.SqlClient

Public Class AddEditBookingForm
    Public BookingID As Integer?

    Private Sub AddEditBookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If BookingID.HasValue Then
            LoadBookingData()
        End If
    End Sub

    Private Sub LoadBookingData()
        Dim query As String = "SELECT BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, NumberOfGuests, Status FROM Bookings WHERE BookingID = @BookingID"
        Dim connectionString As String = "Data Source=KASTURI\SQLEXPRESS;Initial Catalog=Hotel_Reservation_System;Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)
        Dim command As New SqlCommand(query, connection)

        command.Parameters.AddWithValue("@BookingID", BookingID)
        connection.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            txtBookingID.Text = reader("BookingID").ToString()
            txtCustomerName.Text = reader("CustomerID").ToString() ' Changed to txtCustomerID
            txtRoomID.Text = reader("RoomID").ToString()
            dtpCheckInDate.Value = Convert.ToDateTime(reader("CheckInDate"))
            dtpCheckOutDate.Value = Convert.ToDateTime(reader("CheckOutDate"))
            txtNumberOfGuests.Text = reader("NumberOfGuests").ToString()
            txtStatus.Text = reader("Status").ToString()
        End If

        connection.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim query As String
        If BookingID.HasValue Then
            query = "UPDATE Bookings SET CustomerID = @CustomerID, RoomID = @RoomID, CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, NumberOfGuests = @NumberOfGuests, Status = @Status WHERE BookingID = @BookingID"
        Else
            query = "INSERT INTO Bookings (CustomerID, RoomID, CheckInDate, CheckOutDate, NumberOfGuests, Status) VALUES (@CustomerID, @RoomID, @CheckInDate, @CheckOutDate, @NumberOfGuests, @Status)"
        End If

        Dim connectionString As String = "Data Source=KASTURI\SQLEXPRESS;Initial Catalog=Hotel_Reservation_System;Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)
        Dim command As New SqlCommand(query, connection)

        command.Parameters.AddWithValue("@BookingID", txtBookingID.Text)
        command.Parameters.AddWithValue("@CustomerID", txtCustomerName.Text) ' Changed to txtCustomerID
        command.Parameters.AddWithValue("@RoomID", txtRoomID.Text)
        command.Parameters.AddWithValue("@CheckInDate", dtpCheckInDate.Value)
        command.Parameters.AddWithValue("@CheckOutDate", dtpCheckOutDate.Value)
        command.Parameters.AddWithValue("@NumberOfGuests", txtNumberOfGuests.Text)
        command.Parameters.AddWithValue("@Status", txtStatus.Text)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class


