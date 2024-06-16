Imports System.Data.SqlClient

Public Class RoomListForm
    Private Sub RoomListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoomData()
    End Sub

    Private Sub LoadRoomData()
        Dim query As String = "SELECT RoomID, RoomType, RoomStatus, PricePerNight FROM Rooms"
        Dim connectionString As String = "Data Source=KASTURI\SQLEXPRESS;Initial Catalog=Hotel_Reservation_System;Integrated Security=True"
        'Dim connection As New SqlConnection(connectionString)
        Dim adapter As New SqlDataAdapter(query, connectionString)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridViewRooms.DataSource = table
    End Sub


End Class
