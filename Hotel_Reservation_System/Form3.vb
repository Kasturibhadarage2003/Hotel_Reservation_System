Imports System.Data.SqlClient

Public Class RoomMaintenanceForm
    Dim connectionString As String = "Data Source=KASTURI\SQLEXPRESS;Initial Catalog=Hotel_Reservation_System;Integrated Security=True;"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim query As String = "INSERT INTO RoomMaintenance (RoomID, MaintenanceStartDate, MaintenanceEndDate, Status) VALUES (@RoomID, @MaintenanceStartDate, @MaintenanceEndDate, @Status)"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@RoomID", txtRoomID.Text)
            command.Parameters.AddWithValue("@MaintenanceStartDate", dtpMaintenanceStartDate.Value)
            command.Parameters.AddWithValue("@MaintenanceEndDate", dtpMaintenanceEndDate.Value)
            command.Parameters.AddWithValue("@Status", txtStatus.Text)

            connection.Open()
            command.ExecuteNonQuery()
        End Using

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub RoomMaintenanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

