Imports System.Data.SqlClient
Public Class Login
    Dim connectionString As String = "Data Source=DESKTOP-TV2H6SR;Initial Catalog=student;Integrated Security=True;"
    Dim connection As New SqlConnection(connectionString)
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text.Trim
        Dim password = txtPassword.Text.Trim

        ' Check if username and password are provided
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If

        Try
            ' Connect to the database
            connection.Open()

            ' Query to check if the user exists and the password matches
            Dim query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Password", password)

            ' Execute the query
            Dim count = Convert.ToInt32(command.ExecuteScalar)

            If count > 0 Then
                MessageBox.Show("Login successful.")
                Dim dashboardForm As New Dashboard
                dashboardForm.Show()
                Hide()

                ' TODO: Navigate to the main application form or perform other actions upon successful login
            Else
                MessageBox.Show("Invalid username or password.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            ' Close the database connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim ResetForm As New Reset
        ResetForm.Show()
        Hide()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            MessageBox.Show("Action performed!")
            Application.Exit()
        End If

    End Sub
End Class

