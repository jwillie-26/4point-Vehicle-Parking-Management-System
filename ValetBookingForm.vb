Imports MySql.Data.MySqlClient

Public Class ValetBookingForm
    ' Connection string to connect to the MySQL database
    Private connStr As String = "server=localhost;user id=root;password=jesse1234;database=parking_system;"

    ' Method to load parking slots or other initialization on form load
    Private Sub ValetBookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                MessageBox.Show("Connection to the database was successful.", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Method to view bookings and bind them to the DataGridView
    Private Sub btnViewBookings_Click(sender As Object, e As EventArgs) Handles btnViewBookings.Click
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' Update status for expired bookings
                Dim updateQuery As String = "UPDATE valet_bookings SET status = 'Completed' WHERE exit_time < NOW() AND status = 'Booked'"
                Dim updateCmd As New MySqlCommand(updateQuery, conn)
                updateCmd.ExecuteNonQuery()

                ' Select and display bookings
                Dim query As String = "SELECT booking_id, vehicle_number, parking_slot, booked_time, exit_time, status FROM valet_bookings"
                Dim cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                adapter.Fill(table) ' Fill DataTable with query results
                dgvBookings.DataSource = table ' Bind DataTable to DataGridView
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "View Bookings", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Method to add a new valet booking
    Private Sub btnAddBooking_Click(sender As Object, e As EventArgs) Handles btnAddBooking.Click
        Try
            Using conn As New MySqlConnection(connStr)
                Dim query As String = "INSERT INTO valet_bookings (vehicle_number, parking_slot, booked_time, exit_time, status, client_name, client_contact) " &
                                      "VALUES (@vehicle_number, @parking_slot, @booked_time, @exit_time, 'Booked', @client_name, @client_contact)"
                Dim cmd As New MySqlCommand(query, conn)

                ' Bind parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@vehicle_number", txtVehicleNumber1.Text)
                cmd.Parameters.AddWithValue("@parking_slot", cmbParkingSlot1.Text)
                cmd.Parameters.AddWithValue("@booked_time", dtpBookedTime.Value)
                cmd.Parameters.AddWithValue("@exit_time", dtpExitTime.Value)
                cmd.Parameters.AddWithValue("@client_name", txtClientName.Text)
                cmd.Parameters.AddWithValue("@client_contact", txtClientContact.Text)

                conn.Open()
                cmd.ExecuteNonQuery() ' Execute the insert command

                MessageBox.Show("Booking added successfully!", "Add Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields() ' Clear input fields
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Add Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Clear the input fields after adding a booking
    Private Sub ClearFields()
        txtVehicleNumber1.Clear()
        txtClientName.Clear()
        txtClientContact.Clear()
        dtpBookedTime.Value = DateTime.Now
        dtpExitTime.Value = DateTime.Now
    End Sub

    ' Method to delete a selected booking
    Private Sub btnDeleteBooking_Click(sender As Object, e As EventArgs) Handles btnDeleteBooking.Click
        Try
            If dgvBookings.SelectedRows.Count > 0 Then
                Dim bookingId As Integer = Convert.ToInt32(dgvBookings.SelectedRows(0).Cells("booking_id").Value)

                Using conn As New MySqlConnection(connStr)
                    Dim query As String = "DELETE FROM valet_bookings WHERE booking_id = @booking_id"
                    Dim cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@booking_id", bookingId)

                    conn.Open()
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Booking deleted successfully!", "Delete Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnViewBookings.PerformClick() ' Refresh bookings view
                End Using
            Else
                MessageBox.Show("Please select a booking to delete.", "Delete Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Delete Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
