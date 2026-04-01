Imports System.Data.SqlClient
Public Class Reset
    Dim connectionString As String = "Data Source=DESKTOP-TV2H6SR;Initial Catalog=student;Integrated Security=True;"

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

  
    Dim securityCode = txtSecuritycode.Text.Trim
    Dim username = txtUsername.Text.Trim
    Dim password = txtPassword.Text.Trim
    If String.IsNullOrWhiteSpace(securityCode) OrElse String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter all information.")
            Return
    End If

    ' Check if the security code is correct
    If securityCode.ToLower = "sittal" Then
    Try
    ' Connect to the database
    Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    ' Update the username and password in the database
                    Dim query = "UPDATE Users SET Username = @Username, Password = @Password"
    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Username", username)
                        command.Parameters.AddWithValue("@Password", password)
                        command.ExecuteNonQuery()

                        MessageBox.Show("Signup successful. Username and password updated.")
                    End Using
    End Using
    Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
    Else
            MessageBox.Show("Invalid security code.")
        End If
    End Sub


    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim LoginForm As New Login
        LoginForm.Show()
        Hide()
    End Sub


End Class

