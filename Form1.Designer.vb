<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParkingForm
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
        Me.txtVehicleNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddEntry = New System.Windows.Forms.Button()
        Me.btnMarkExit = New System.Windows.Forms.Button()
        Me.btnUpdateEntry = New System.Windows.Forms.Button()
        Me.btnDeleteEntry = New System.Windows.Forms.Button()
        Me.btnViewStatus = New System.Windows.Forms.Button()
        Me.dgvParkingStatus = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblExitTime = New System.Windows.Forms.Label()
        Me.lblEntryTime = New System.Windows.Forms.Label()
        Me.cmbParkingSlot = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAboutConact = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValetBookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvParkingStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtVehicleNumber
        '
        Me.txtVehicleNumber.Location = New System.Drawing.Point(205, 122)
        Me.txtVehicleNumber.Name = "txtVehicleNumber"
        Me.txtVehicleNumber.Size = New System.Drawing.Size(252, 26)
        Me.txtVehicleNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vehicle Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Parking Slot:"
        '
        'btnAddEntry
        '
        Me.btnAddEntry.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnAddEntry.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEntry.Location = New System.Drawing.Point(32, 365)
        Me.btnAddEntry.Name = "btnAddEntry"
        Me.btnAddEntry.Size = New System.Drawing.Size(236, 47)
        Me.btnAddEntry.TabIndex = 5
        Me.btnAddEntry.Text = "AddEntry"
        Me.btnAddEntry.UseVisualStyleBackColor = False
        '
        'btnMarkExit
        '
        Me.btnMarkExit.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnMarkExit.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarkExit.Location = New System.Drawing.Point(32, 454)
        Me.btnMarkExit.Name = "btnMarkExit"
        Me.btnMarkExit.Size = New System.Drawing.Size(236, 47)
        Me.btnMarkExit.TabIndex = 5
        Me.btnMarkExit.Text = "MarkExit"
        Me.btnMarkExit.UseVisualStyleBackColor = False
        '
        'btnUpdateEntry
        '
        Me.btnUpdateEntry.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnUpdateEntry.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateEntry.Location = New System.Drawing.Point(394, 365)
        Me.btnUpdateEntry.Name = "btnUpdateEntry"
        Me.btnUpdateEntry.Size = New System.Drawing.Size(236, 47)
        Me.btnUpdateEntry.TabIndex = 5
        Me.btnUpdateEntry.Text = "UpdateEntry"
        Me.btnUpdateEntry.UseVisualStyleBackColor = False
        '
        'btnDeleteEntry
        '
        Me.btnDeleteEntry.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnDeleteEntry.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteEntry.Location = New System.Drawing.Point(394, 454)
        Me.btnDeleteEntry.Name = "btnDeleteEntry"
        Me.btnDeleteEntry.Size = New System.Drawing.Size(236, 47)
        Me.btnDeleteEntry.TabIndex = 5
        Me.btnDeleteEntry.Text = "DeleteEntry"
        Me.btnDeleteEntry.UseVisualStyleBackColor = False
        '
        'btnViewStatus
        '
        Me.btnViewStatus.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnViewStatus.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewStatus.Location = New System.Drawing.Point(989, 318)
        Me.btnViewStatus.Name = "btnViewStatus"
        Me.btnViewStatus.Size = New System.Drawing.Size(236, 47)
        Me.btnViewStatus.TabIndex = 5
        Me.btnViewStatus.Text = "ViewStatus"
        Me.btnViewStatus.UseVisualStyleBackColor = False
        '
        'dgvParkingStatus
        '
        Me.dgvParkingStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParkingStatus.Location = New System.Drawing.Point(473, 59)
        Me.dgvParkingStatus.Name = "dgvParkingStatus"
        Me.dgvParkingStatus.RowHeadersWidth = 62
        Me.dgvParkingStatus.RowTemplate.Height = 28
        Me.dgvParkingStatus.Size = New System.Drawing.Size(752, 253)
        Me.dgvParkingStatus.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cmbParkingSlot)
        Me.Panel1.Controls.Add(Me.dgvParkingStatus)
        Me.Panel1.Controls.Add(Me.btnViewStatus)
        Me.Panel1.Controls.Add(Me.btnDeleteEntry)
        Me.Panel1.Controls.Add(Me.btnUpdateEntry)
        Me.Panel1.Controls.Add(Me.btnMarkExit)
        Me.Panel1.Controls.Add(Me.btnAddEntry)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtVehicleNumber)
        Me.Panel1.Location = New System.Drawing.Point(44, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1289, 533)
        Me.Panel1.TabIndex = 7
        '
        'lblExitTime
        '
        Me.lblExitTime.AutoSize = True
        Me.lblExitTime.Location = New System.Drawing.Point(51, 369)
        Me.lblExitTime.Name = "lblExitTime"
        Me.lblExitTime.Size = New System.Drawing.Size(57, 20)
        Me.lblExitTime.TabIndex = 11
        Me.lblExitTime.Text = "Label4"
        '
        'lblEntryTime
        '
        Me.lblEntryTime.AutoSize = True
        Me.lblEntryTime.Location = New System.Drawing.Point(51, 296)
        Me.lblEntryTime.Name = "lblEntryTime"
        Me.lblEntryTime.Size = New System.Drawing.Size(57, 20)
        Me.lblEntryTime.TabIndex = 10
        Me.lblEntryTime.Text = "Label3"
        '
        'cmbParkingSlot
        '
        Me.cmbParkingSlot.FormattingEnabled = True
        Me.cmbParkingSlot.Items.AddRange(New Object() {"A1", "A2", "B1", "B2", "C1", "C2", "D1", "D2", "E1", "E2", "F1", "F2", "G1", "G2", "H1", "H2", "I1", "I2", "J1", "J2", "K1", "K2", "L1", "L2", "M1", "M2", "N1", "N2", "O1", "O2", "P1", "P2", ""})
        Me.cmbParkingSlot.Location = New System.Drawing.Point(205, 199)
        Me.cmbParkingSlot.Name = "cmbParkingSlot"
        Me.cmbParkingSlot.Size = New System.Drawing.Size(229, 28)
        Me.cmbParkingSlot.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1374, 33)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(203, 34)
        Me.mnuExit.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAboutConact})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'mnuAboutConact
        '
        Me.mnuAboutConact.Name = "mnuAboutConact"
        Me.mnuAboutConact.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.mnuAboutConact.Size = New System.Drawing.Size(282, 34)
        Me.mnuAboutConact.Text = "About/Conact"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ValetBookingsToolStripMenuItem, Me.ViewReportsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ValetBookingsToolStripMenuItem
        '
        Me.ValetBookingsToolStripMenuItem.Name = "ValetBookingsToolStripMenuItem"
        Me.ValetBookingsToolStripMenuItem.Size = New System.Drawing.Size(231, 34)
        Me.ValetBookingsToolStripMenuItem.Text = "Valet Bookings"
        '
        'ViewReportsToolStripMenuItem
        '
        Me.ViewReportsToolStripMenuItem.Name = "ViewReportsToolStripMenuItem"
        Me.ViewReportsToolStripMenuItem.Size = New System.Drawing.Size(231, 34)
        Me.ViewReportsToolStripMenuItem.Text = "View Reports"
        '
        'ParkingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1374, 596)
        Me.Controls.Add(Me.lblExitTime)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblEntryTime)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ParkingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.dgvParkingStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVehicleNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddEntry As Button
    Friend WithEvents btnMarkExit As Button
    Friend WithEvents btnUpdateEntry As Button
    Friend WithEvents btnDeleteEntry As Button
    Friend WithEvents btnViewStatus As Button
    Friend WithEvents dgvParkingStatus As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbParkingSlot As ComboBox
    Friend WithEvents lblExitTime As Label
    Friend WithEvents lblEntryTime As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAboutConact As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValetBookingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewReportsToolStripMenuItem As ToolStripMenuItem
End Class
