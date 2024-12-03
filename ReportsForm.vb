Imports MySql.Data.MySqlClient

Public Class ReportsForm

    Private connStr As String = "server=localhost;user id=root;password=jesse1234;database=parking_system"
    Private conn As MySqlConnection = New MySqlConnection(connStr)

    ' Open database connection
    Private Sub OpenConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    ' Close database connection
    Private Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub


    ' Generate Report based on selected type
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Try
            ' Open the database connection
            OpenConnection()

            ' Define the SQL query for generating the report
            Dim query As String = "SELECT vehicle_number, parking_slot, DATE(entry_time) AS entry_date, " &
                                  "COUNT(vehicle_number) AS total_entries, " &
                                  "SUM(CASE WHEN exit_time IS NULL THEN 0 " &
                                  "ELSE ROUND((TIMESTAMPDIFF(HOUR, entry_time, exit_time) + 1) * 5.00, 2) END) AS total_revenue " &
                                  "FROM parking_lot " &
                                  "WHERE entry_time BETWEEN @startDate AND @endDate " &
                                  "GROUP BY vehicle_number, parking_slot, DATE(entry_time);"

            ' Create command and parameters
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value.Date)
            cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value.Date)

            ' Execute the query and fill the data table
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Bind the result to the DataGridView
            dgvReports.DataSource = table

            ' Display a message box indicating successful report generation
            MessageBox.Show("Report generated successfully.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Display error message
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the database connection
            CloseConnection()
        End Try
    End Sub


    ' Load default settings or configurations when the form loads
    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the date pickers to current date
        dtpStartDate.Value = DateTime.Now.AddDays(-7) ' Default start date is a week ago
        dtpEndDate.Value = DateTime.Now ' Default end date is today
    End Sub

    Private Sub btnWeeklyReport_Click(sender As Object, e As EventArgs) Handles btnWeeklyReport.Click
        Dim today As DateTime = DateTime.Now
        dtpStartDate.Value = today.AddDays(-(today.DayOfWeek - DayOfWeek.Monday)) ' Start of the week (Monday)
        dtpEndDate.Value = today.AddDays(DayOfWeek.Sunday - today.DayOfWeek) ' End of the week (Sunday)
        btnGenerateReport.PerformClick() ' Generate report
    End Sub

    Private Sub btnMonthlyReport_Click(sender As Object, e As EventArgs) Handles btnMonthlyReport.Click
        Dim firstDayOfMonth As New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        Dim lastDayOfMonth As DateTime = firstDayOfMonth.AddMonths(1).AddDays(-1)
        dtpStartDate.Value = firstDayOfMonth
        dtpEndDate.Value = lastDayOfMonth
        btnGenerateReport.PerformClick() ' Generate report
    End Sub
End Class