Public Class DashboardForm
    Private Sub btnRoomManagement_Click(sender As Object, e As EventArgs) Handles btnRoomManagement.Click
        ' Open Room Management Section
        Dim roomManagementForm As New roomManagementForm()
        roomManagementForm.Show()
    End Sub

    Private Sub btnBookingManagement_Click(sender As Object, e As EventArgs) Handles btnBookingManagement.Click
        ' Open Booking Management Section
        Dim bookingManagementForm As New bookingManagementForm()
        bookingManagementForm.Show()
    End Sub

    Private Sub btnCustomerManagement_Click(sender As Object, e As EventArgs) Handles btnCustomerManagement.Click
        ' Open Customer Management Section
        Dim customerManagementForm As New customerManagementForm()
        customerManagementForm.Show()
    End Sub

    Private Sub btnCheckInOut_Click(sender As Object, e As EventArgs) Handles btnCheckInOut.Click
        ' Open Check-in/Check-out Section
        Dim checkInOutForm As New checkInOutForm()
        checkInOutForm.Show()
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        ' Open Billing Section
        Dim billingForm As New billingForm()
        billingForm.Show()
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        ' Close the application
        Application.Exit()
    End Sub
End Class
