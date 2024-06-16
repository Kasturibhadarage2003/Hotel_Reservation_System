Imports System.Data.SqlClient

Public Class CustomerListForm
    Private Sub CustomerListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerData()
    End Sub

    Private Sub LoadCustomerData()
        Dim query As String = "SELECT CustomerID, Name, ContactNumber, Email, Address FROM Customers"
        Dim connectionString As String = "Data Source=KASTURI\SQLEXPRESS;Initial Catalog=Hotel_Reservation_System;Integrated Security=True;"
        Dim adapter As New SqlDataAdapter(query, connectionString)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridViewCustomers.DataSource = table
    End Sub
End Class

