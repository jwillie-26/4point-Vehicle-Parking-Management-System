<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValetBookingForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpEntryTime = New System.Windows.Forms.DateTimePicker()
        Me.cmbParkingSlot = New System.Windows.Forms.ComboBox()
        Me.txtVehicleNumber = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbParkingSlot1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDeleteBooking = New System.Windows.Forms.Button()
        Me.btnAddBooking = New System.Windows.Forms.Button()
        Me.btnViewBookings = New System.Windows.Forms.Button()
        Me.dgvBookings = New System.Windows.Forms.DataGridView()
        Me.txtClientContact = New System.Windows.Forms.TextBox()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.dtpExitTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpBookedTime = New System.Windows.Forms.DateTimePicker()
        Me.txtVehicleNumber1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.dtpEntryTime)
        Me.Panel1.Controls.Add(Me.cmbParkingSlot)
        Me.Panel1.Controls.Add(Me.txtVehicleNumber)
        Me.Panel1.Location = New System.Drawing.Point(53, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 436)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(258, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpEntryTime
        '
        Me.dtpEntryTime.Location = New System.Drawing.Point(294, 301)
        Me.dtpEntryTime.Name = "dtpEntryTime"
        Me.dtpEntryTime.Size = New System.Drawing.Size(200, 26)
        Me.dtpEntryTime.TabIndex = 2
        '
        'cmbParkingSlot
        '
        Me.cmbParkingSlot.FormattingEnabled = True
        Me.cmbParkingSlot.Location = New System.Drawing.Point(109, 168)
        Me.cmbParkingSlot.Name = "cmbParkingSlot"
        Me.cmbParkingSlot.Size = New System.Drawing.Size(216, 28)
        Me.cmbParkingSlot.TabIndex = 1
        '
        'txtVehicleNumber
        '
        Me.txtVehicleNumber.Location = New System.Drawing.Point(109, 82)
        Me.txtVehicleNumber.Name = "txtVehicleNumber"
        Me.txtVehicleNumber.Size = New System.Drawing.Size(216, 26)
        Me.txtVehicleNumber.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cmbParkingSlot1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnDeleteBooking)
        Me.Panel2.Controls.Add(Me.btnAddBooking)
        Me.Panel2.Controls.Add(Me.btnViewBookings)
        Me.Panel2.Controls.Add(Me.dgvBookings)
        Me.Panel2.Controls.Add(Me.txtClientContact)
        Me.Panel2.Controls.Add(Me.txtClientName)
        Me.Panel2.Controls.Add(Me.dtpExitTime)
        Me.Panel2.Controls.Add(Me.dtpBookedTime)
        Me.Panel2.Controls.Add(Me.txtVehicleNumber1)
        Me.Panel2.Location = New System.Drawing.Point(53, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1162, 503)
        Me.Panel2.TabIndex = 0
        '
        'cmbParkingSlot1
        '
        Me.cmbParkingSlot1.FormattingEnabled = True
        Me.cmbParkingSlot1.Items.AddRange(New Object() {"A1", "A2", "B1", "B2", "C1", "C2", "D1", "D2", "E1", "E2", "F1", "F2", "G1", "G2", "H1", "H2", "I1", "I2", "J1", "J2", "K1", "K2", "L1", "L2", "M1", "M2", "N1", "N2", "O1", "O2", "P1", "P2"})
        Me.cmbParkingSlot1.Location = New System.Drawing.Point(258, 114)
        Me.cmbParkingSlot1.Name = "cmbParkingSlot1"
        Me.cmbParkingSlot1.Size = New System.Drawing.Size(229, 28)
        Me.cmbParkingSlot1.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label6.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(58, 349)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 29)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Client Contact:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label5.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(77, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 29)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Client Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(104, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 29)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Exit Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(73, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 29)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Booked Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(77, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 29)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Parking Slot:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(50, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Vehicle Number:"
        '
        'btnDeleteBooking
        '
        Me.btnDeleteBooking.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnDeleteBooking.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteBooking.Location = New System.Drawing.Point(844, 416)
        Me.btnDeleteBooking.Name = "btnDeleteBooking"
        Me.btnDeleteBooking.Size = New System.Drawing.Size(236, 47)
        Me.btnDeleteBooking.TabIndex = 13
        Me.btnDeleteBooking.Text = "Delete Booking"
        Me.btnDeleteBooking.UseVisualStyleBackColor = False
        '
        'btnAddBooking
        '
        Me.btnAddBooking.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnAddBooking.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddBooking.Location = New System.Drawing.Point(109, 416)
        Me.btnAddBooking.Name = "btnAddBooking"
        Me.btnAddBooking.Size = New System.Drawing.Size(236, 47)
        Me.btnAddBooking.TabIndex = 12
        Me.btnAddBooking.Text = "Add Booking"
        Me.btnAddBooking.UseVisualStyleBackColor = False
        '
        'btnViewBookings
        '
        Me.btnViewBookings.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnViewBookings.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewBookings.Location = New System.Drawing.Point(479, 414)
        Me.btnViewBookings.Name = "btnViewBookings"
        Me.btnViewBookings.Size = New System.Drawing.Size(236, 47)
        Me.btnViewBookings.TabIndex = 11
        Me.btnViewBookings.Text = "View Bookings"
        Me.btnViewBookings.UseVisualStyleBackColor = False
        '
        'dgvBookings
        '
        Me.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookings.Location = New System.Drawing.Point(576, 50)
        Me.dgvBookings.Name = "dgvBookings"
        Me.dgvBookings.RowHeadersWidth = 62
        Me.dgvBookings.RowTemplate.Height = 28
        Me.dgvBookings.Size = New System.Drawing.Size(540, 292)
        Me.dgvBookings.TabIndex = 10
        '
        'txtClientContact
        '
        Me.txtClientContact.Location = New System.Drawing.Point(262, 352)
        Me.txtClientContact.Name = "txtClientContact"
        Me.txtClientContact.Size = New System.Drawing.Size(225, 26)
        Me.txtClientContact.TabIndex = 9
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(262, 301)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(225, 26)
        Me.txtClientName.TabIndex = 8
        '
        'dtpExitTime
        '
        Me.dtpExitTime.Location = New System.Drawing.Point(258, 233)
        Me.dtpExitTime.Name = "dtpExitTime"
        Me.dtpExitTime.Size = New System.Drawing.Size(276, 26)
        Me.dtpExitTime.TabIndex = 6
        '
        'dtpBookedTime
        '
        Me.dtpBookedTime.Location = New System.Drawing.Point(258, 168)
        Me.dtpBookedTime.Name = "dtpBookedTime"
        Me.dtpBookedTime.Size = New System.Drawing.Size(276, 26)
        Me.dtpBookedTime.TabIndex = 2
        '
        'txtVehicleNumber1
        '
        Me.txtVehicleNumber1.Location = New System.Drawing.Point(258, 56)
        Me.txtVehicleNumber1.Name = "txtVehicleNumber1"
        Me.txtVehicleNumber1.Size = New System.Drawing.Size(258, 26)
        Me.txtVehicleNumber1.TabIndex = 0
        '
        'ValetBookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1247, 603)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ValetBookingForm"
        Me.Text = "ValetBookingForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbParkingSlot As ComboBox
    Friend WithEvents txtVehicleNumber As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpEntryTime As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpBookedTime As DateTimePicker
    Friend WithEvents txtVehicleNumber1 As TextBox
    Friend WithEvents dtpExitTime As DateTimePicker
    Friend WithEvents dgvBookings As DataGridView
    Friend WithEvents txtClientContact As TextBox
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents btnDeleteBooking As Button
    Friend WithEvents btnAddBooking As Button
    Friend WithEvents btnViewBookings As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbParkingSlot1 As ComboBox
End Class
