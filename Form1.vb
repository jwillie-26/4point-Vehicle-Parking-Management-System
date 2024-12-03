Imports MySql.Data.MySqlClient

Public Class ParkingForm

    ' Define the hourly rate as a constant at the top of the class
    Const hourlyRate As Decimal = 5.0 ' Parking fee rate per hour

    ' MySQL connection string
    Private connStr As String = "server=localhost;user id=root;password=jesse1234;database=parking_system"
    Private conn As MySqlConnection = New MySqlConnection(connStr)

    ' Open MySQL connection
    Private Sub OpenConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    ' Close MySQL connection
    Private Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Private Function CalculateParkingFee(entryTime As DateTime, exitTime As DateTime) As Decimal
        ' Calculate the total time spent in the parking lot
        Dim totalTime As TimeSpan = exitTime - entryTime

        ' Round up to the nearest full hour
        Dim totalHours As Decimal = Math.Ceiling(totalTime.TotalHours)

        ' Calculate the total fee by multiplying the total hours by the hourly rate
        Dim totalFee As Decimal = totalHours * hourlyRate

        ' Return the total fee
        Return totalFee
    End Function


    ' Clear input fields
    Private Sub ClearFields()
        txtVehicleNumber.Text = ""
        cmbParkingSlot.SelectedIndex = -1 ' Reset ComboBox selection
        lblEntryTime.Text = ""
        lblExitTime.Text = ""
        txtVehicleNumber.Focus() ' Set focus back to the Vehicle Number field
    End Sub

    ' Add a new vehicle entry
    Private Sub btnAddEntry_Click(sender As Object, e As EventArgs) Handles btnAddEntry.Click
        Try
            OpenConnection()
            Dim query As String = "INSERT INTO parking_lot (vehicle_number, parking_slot, status) VALUES (@vehicle_number, @parking_slot, 'IN')"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@vehicle_number", txtVehicleNumber.Text)
            cmd.Parameters.AddWithValue("@parking_slot", cmbParkingSlot.SelectedItem.ToString()) ' ComboBox selection
            cmd.ExecuteNonQuery()

            MessageBox.Show("Vehicle Entry Added Successfully")
            ClearFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Mark a vehicle exit
    Private Sub btnMarkExit_Click(sender As Object, e As EventArgs) Handles btnMarkExit.Click
        Try
            OpenConnection()

            ' First, get the entry time from the database
            Dim querySelect As String = "SELECT entry_time FROM parking_lot WHERE vehicle_number = @vehicle_number AND status = 'IN'"
            Dim cmdSelect As New MySqlCommand(querySelect, conn)
            cmdSelect.Parameters.AddWithValue("@vehicle_number", txtVehicleNumber.Text)
            Dim reader As MySqlDataReader = cmdSelect.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim entryTime As DateTime = reader.GetDateTime("entry_time")
                reader.Close()

                ' Mark the vehicle as exited by updating the exit time and status
                Dim queryUpdate As String = "UPDATE parking_lot SET exit_time = CURRENT_TIMESTAMP, status = 'OUT' WHERE vehicle_number = @vehicle_number AND status = 'IN'"
                Dim cmdUpdate As New MySqlCommand(queryUpdate, conn)
                cmdUpdate.Parameters.AddWithValue("@vehicle_number", txtVehicleNumber.Text)
                cmdUpdate.ExecuteNonQuery()

                ' Get the exit time (current time)
                Dim exitTime As DateTime = DateTime.Now

                ' Calculate parking fee
                Dim totalFee As Decimal = CalculateParkingFee(entryTime, exitTime)

                ' Display the total fee to the user
                MessageBox.Show("Vehicle Exit Marked Successfully. Total Parking Fee: $" & totalFee.ToString("F2"))

                ClearFields()

            Else
                MessageBox.Show("Vehicle not found or already marked as exited.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Update vehicle entry
    Private Sub btnUpdateEntry_Click(sender As Object, e As EventArgs) Handles btnUpdateEntry.Click
        Try
            OpenConnection()

            ' SQL query to update the parking slot in the database
            Dim query As String = "UPDATE parking_lot SET parking_slot = @parking_slot WHERE vehicle_number = @vehicle_number AND status = 'IN'"
            Dim cmd As New MySqlCommand(query, conn)

            ' Pass the values from the textboxes to the query
            cmd.Parameters.AddWithValue("@vehicle_number", txtVehicleNumber.Text)
            cmd.Parameters.AddWithValue("@parking_slot", cmbParkingSlot.SelectedItem.ToString()) ' ComboBox selection

            ' Execute the query
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            ' Check if any rows were updated
            If rowsAffected = 0 Then
                MessageBox.Show("No vehicle found with the provided number or the vehicle has already exited.")
            Else
                MessageBox.Show("Vehicle Entry Updated Successfully")
                ClearFields()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message) ' Handle any errors
        Finally
            CloseConnection() ' Ensure the connection is closed
        End Try
    End Sub

    ' Delete vehicle entry
    Private Sub btnDeleteEntry_Click(sender As Object, e As EventArgs) Handles btnDeleteEntry.Click
        Try
            OpenConnection()

            ' SQL query to delete the entry from the database
            Dim query As String = "DELETE FROM parking_lot WHERE vehicle_number = @vehicle_number AND status = 'IN'"
            Dim cmd As New MySqlCommand(query, conn)

            ' Pass the value from the textbox to the query
            cmd.Parameters.AddWithValue("@vehicle_number", txtVehicleNumber.Text)

            ' Execute the query
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            ' If no rows were affected, it means the vehicle wasn't found
            If rowsAffected = 0 Then
                MessageBox.Show("No vehicle found with the provided number or the vehicle has already exited.")
            Else
                MessageBox.Show("Vehicle Entry Deleted Successfully")
                ClearFields()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message) ' Handle any errors
        Finally
            CloseConnection() ' Ensure the connection is closed
        End Try
    End Sub

    ' View parking lot status
    Private Sub btnViewStatus_Click(sender As Object, e As EventArgs) Handles btnViewStatus.Click
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM parking_lot"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvParkingStatus.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Form load event
    Private Sub ParkingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Perform any necessary form initialization
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        ' Ask the user for confirmation before exiting
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Close the application
            Application.Exit()
        End If
    End Sub

    Private Sub btnViewReports_Click(sender As Object, e As EventArgs)
        Dim reportsForm As New ReportsForm()
        reportsForm.Show()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    Private Sub mnuAboutConact_Click(sender As Object, e As EventArgs) Handles mnuAboutConact.Click
        MessageBox.Show("Contact Support: support@parkincpoint.com" & vbCrLf & "Phone: +254795360692",
                  "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ValetBookingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValetBookingsToolStripMenuItem.Click
        Dim valetForm As New ValetBookingForm()
        valetForm.Show() ' Show the Valet Bookings form
    End Sub

    Private Sub ViewReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewReportsToolStripMenuItem.Click
        Dim reportsForm As New ReportsForm()
        reportsForm.Show() ' Show the Reports form
    End Sub
End Class

