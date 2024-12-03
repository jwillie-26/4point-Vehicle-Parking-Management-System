Imports MySql.Data.MySqlClient

Public Class LoginForm

    Private connStr As String = "server=localhost;user id=root;password=jesse1234;database=parking_system"
    Private conn As MySqlConnection = New MySqlConnection(connStr)

    ' Open connection
    Private Sub OpenConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    ' Close connection
    Private Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    ' Validate login credentials
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM admins WHERE employee_id = @employee_id AND password = @password"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@employee_id", txtEmployeeID.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Login Successful!")
                Me.Hide()

                ' Show LoadingForm
                LoadingForm.Show()

            Else
                MessageBox.Show("Invalid Employee ID or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub
End Class
