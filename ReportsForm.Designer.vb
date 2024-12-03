<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.btnWeeklyReport = New System.Windows.Forms.Button()
        Me.btnMonthlyReport = New System.Windows.Forms.Button()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(181, 274)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(279, 26)
        Me.dtpEndDate.TabIndex = 1
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(181, 194)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(279, 26)
        Me.dtpStartDate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(292, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Parking Reports"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(38, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "StartDate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(48, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "EndDate:"
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnGenerateReport.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnGenerateReport.Location = New System.Drawing.Point(330, 394)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(236, 47)
        Me.btnGenerateReport.TabIndex = 4
        Me.btnGenerateReport.Text = "GenerateReport"
        Me.btnGenerateReport.UseVisualStyleBackColor = False
        '
        'dgvReports
        '
        Me.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReports.Location = New System.Drawing.Point(485, 77)
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.RowHeadersWidth = 62
        Me.dgvReports.RowTemplate.Height = 28
        Me.dgvReports.Size = New System.Drawing.Size(466, 223)
        Me.dgvReports.TabIndex = 5
        '
        'btnWeeklyReport
        '
        Me.btnWeeklyReport.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnWeeklyReport.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnWeeklyReport.Location = New System.Drawing.Point(1, 109)
        Me.btnWeeklyReport.Name = "btnWeeklyReport"
        Me.btnWeeklyReport.Size = New System.Drawing.Size(236, 47)
        Me.btnWeeklyReport.TabIndex = 6
        Me.btnWeeklyReport.Text = "WeeklyReport"
        Me.btnWeeklyReport.UseVisualStyleBackColor = False
        '
        'btnMonthlyReport
        '
        Me.btnMonthlyReport.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnMonthlyReport.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnMonthlyReport.Location = New System.Drawing.Point(243, 109)
        Me.btnMonthlyReport.Name = "btnMonthlyReport"
        Me.btnMonthlyReport.Size = New System.Drawing.Size(236, 47)
        Me.btnMonthlyReport.TabIndex = 6
        Me.btnMonthlyReport.Text = "MonthlyReport"
        Me.btnMonthlyReport.UseVisualStyleBackColor = False
        '
        'ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(963, 487)
        Me.Controls.Add(Me.btnMonthlyReport)
        Me.Controls.Add(Me.btnWeeklyReport)
        Me.Controls.Add(Me.dgvReports)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Name = "ReportsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportsForm"
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents btnWeeklyReport As Button
    Friend WithEvents btnMonthlyReport As Button
End Class
