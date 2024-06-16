Imports System.Data.SqlClient

Public Class AddEditRoomForm
    Public RoomID As Integer?

    Private Sub AddEditRoomForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RoomID.HasValue Then
            LoadRoomData()
        End If
    End Sub

    Private Sub LoadRoomData()
        Dim query As String = "SELECT RoomID, RoomType, RoomStatus, PricePerNight, Amenities FROM Rooms WHERE RoomID = @RoomID"
        Dim connectionString As String = "Data Source=KASTURI\SQLEXPRESS;Initial Catalog=Hotel_Reservation_System;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)
        Dim command As New SqlCommand(query, connection)

        command.Parameters.AddWithValue("@RoomID", RoomID)
        connection.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            txtRoomID.Text = reader("RoomID").ToString()
            txtRoomType.Text = reader("RoomType").ToString()
            txtRoomStatus.Text = reader("RoomStatus").ToString()
            txtPricePerNight.Text = reader("PricePerNight").ToString()
            txtAmenities.Text = reader("Amenities").ToString()
        End If

        connection.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim query As String
        If RoomID.HasValue Then
            query = "UPDATE Rooms SET RoomType = @RoomType, RoomStatus = @RoomStatus, PricePerNight = @PricePerNight, Amenities = @Amenities WHERE RoomID = @RoomID"
        Else
            query = "INSERT INTO Rooms (RoomType, RoomStatus, PricePerNight, Amenities) VALUES (@RoomType, @RoomStatus, @PricePerNight, @Amenities)"
        End If

        Dim connectionString As String = "Data Source=KASTURI\SQLEXPRESS;Initial Catalog=Hotel_Reservation_System;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)
        Dim command As New SqlCommand(query, connection)

        command.Parameters.AddWithValue("@RoomID", txtRoomID.Text)
        command.Parameters.AddWithValue("@RoomType", txtRoomType.Text)
        command.Parameters.AddWithValue("@RoomStatus", txtRoomStatus.Text)
        command.Parameters.AddWithValue("@PricePerNight", txtPricePerNight.Text)
        command.Parameters.AddWithValue("@Amenities", txtAmenities.Text)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
