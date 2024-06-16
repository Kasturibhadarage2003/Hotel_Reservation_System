Public Class roomManagementForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RoomListForm.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddEditRoomForm.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RoomMaintenanceForm.Show()

    End Sub

    Private Sub roomManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class