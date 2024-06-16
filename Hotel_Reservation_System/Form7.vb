Imports System.Data.SqlClient

Public Class AddEditCustomerForm
    Public CustomerID As Integer?
    Dim connectionString As String = "Data Source=KASTURI\SQLEXPRESS;Initial Catalog=Hotel_Reservation_System;Integrated Security=True;"

    Private Sub AddEditCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CustomerID.HasValue Then
            LoadCustomerData()
        End If
    End Sub

    Private Sub LoadCustomerData()
        Dim query As String = "SELECT CustomerID, Name, ContactNumber, Email, Address FROM Customers WHERE CustomerID = @CustomerID"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@CustomerID", CustomerID)

            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                txtCustomerID.Text = reader("CustomerID").ToString()
                txtName.Text = reader("Name").ToString()
                txtContactNumber.Text = reader("ContactNumber").ToString()
                txtEmail.Text = reader("Email").ToString()
                txtAddress.Text = reader("Address").ToString()
            End If

            reader.Close()
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateCustomerData() Then
            If CustomerID.HasValue Then
                UpdateCustomerData()
            Else
                InsertCustomerData()
            End If
            MessageBox.Show("Customer data saved successfully.")
            Me.Close()
        Else
            MessageBox.Show("Please fill in all required fields.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close() ' Close the form without saving changes
    End Sub

    Private Function ValidateCustomerData() As Boolean
        ' Add your validation logic here
        If String.IsNullOrEmpty(txtName.Text) Then
            MessageBox.Show("Name is required.")
            Return False
        End If

        ' For example, check if required fields are filled
        If String.IsNullOrEmpty(txtContactNumber.Text) Then
            MessageBox.Show("Contact Number is required.")
            Return False
        End If
        Return True ' All required fields are filled
    End Function

    Private Sub UpdateCustomerData()
        Dim query As String = "UPDATE Customers SET Name = @Name, ContactNumber = @ContactNumber, Email = @Email, Address = @Address WHERE CustomerID = @CustomerID"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@CustomerID", CustomerID)
            command.Parameters.AddWithValue("@Name", txtName.Text)
            command.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
            command.Parameters.AddWithValue("@Email", txtEmail.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)

            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub InsertCustomerData()
        Dim query As String = "INSERT INTO Customers (Name, ContactNumber, Email, Address) VALUES (@Name, @ContactNumber, @Email, @Address)"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Name", txtName.Text)
            command.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
            command.Parameters.AddWithValue("@Email", txtEmail.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)

            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub
End Class

