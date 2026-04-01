Imports System.Data.SqlClient
Imports System.Data

Public Class Fees
    Dim connectionString As String = "Data Source=DESKTOP-TV2H6SR;Initial Catalog=student;Integrated Security=True;"
    Dim connection As New SqlConnection(connectionString)
    Dim dashboard As Dashboard

    Public Sub New(Optional ByVal dashboard As Dashboard = Nothing)
        InitializeComponent()
        Me.dashboard = dashboard
    End Sub

    Private Sub Fees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentIds()
        DisplayFeeDepositData()
    End Sub

    Private Sub LoadStudentIds()
        Try
            Dim cmd As New SqlCommand("SELECT ID FROM STable", connection)
            Dim dr As SqlDataReader

            connection.Open()
            dr = cmd.ExecuteReader()
            StIdCb.Items.Clear()
            While dr.Read()
                StIdCb.Items.Add(dr("ID").ToString())
            End While
        Catch ex As Exception

        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub DisplayFeeDepositData()
        Try
            Dim cmd As New SqlCommand("SELECT * FROM STable", connection)
            Dim dt As New DataTable()
            Dim adapter As New SqlDataAdapter(cmd)

            connection.Open()
            adapter.Fill(dt)
            DGVFeesDeposit.DataSource = dt
        Catch ex As Exception

        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub StIdCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StIdCb.SelectedIndexChanged
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim selectedId As Integer = Convert.ToInt32(StIdCb.SelectedItem)
            Dim cmd As New SqlCommand("SELECT Sname FROM STable WHERE ID = @ID", connection)
            cmd.Parameters.AddWithValue("@ID", selectedId)
            Dim name As String = Convert.ToString(cmd.ExecuteScalar())
            StNameTb.Text = name
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If StIdCb.SelectedIndex = -1 Then
            MessageBox.Show("Please select a student from the list.")
            Return
        End If
        Try
            Dim selectedId As Integer = Convert.ToInt32(StIdCb.SelectedItem)
            Dim paymentAmount As Integer = Convert.ToInt32(StAmountTb.Text)

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New SqlCommand("SELECT Sfees FROM STable WHERE ID = @ID", connection)
            cmd.Parameters.AddWithValue("@ID", selectedId)
            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                Dim existingFee As Integer = Convert.ToInt32(result)
                Dim remainingFee As Integer = existingFee - paymentAmount

                If remainingFee >= 0 Then
                    Dim updateCmd As New SqlCommand("UPDATE STable SET Sfees = @Fees WHERE ID = @ID", connection)
                    updateCmd.Parameters.AddWithValue("@Fees", remainingFee)
                    updateCmd.Parameters.AddWithValue("@ID", selectedId)
                    updateCmd.ExecuteNonQuery()


                    LoadStudentIds()
                    DisplayFeeDepositData()

                    MessageBox.Show("Payment successful.")

                Else
                    MessageBox.Show("Payment failed. Entered amount exceeds remaining fee.")
                End If
            Else
                MessageBox.Show("Error: Student not found.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)

        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim StudentForm As New Student()
        StudentForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim LoginForm As New Login()
            LoginForm.Show()
            Me.Hide()
            Application.Exit()
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dashboardForm As New Dashboard()
        dashboardForm.Show()
        Me.Hide()
    End Sub
End Class
