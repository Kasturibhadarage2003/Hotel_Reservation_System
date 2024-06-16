<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckInForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCheckInID = New System.Windows.Forms.TextBox()
        Me.txtBookingID = New System.Windows.Forms.TextBox()
        Me.txtNumberOfGuests = New System.Windows.Forms.TextBox()
        Me.dtpCheckInDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CheckIn ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Booking ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(251, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CheckIn Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(251, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Number Of Guests"
        '
        'txtCheckInID
        '
        Me.txtCheckInID.Location = New System.Drawing.Point(583, 121)
        Me.txtCheckInID.Name = "txtCheckInID"
        Me.txtCheckInID.Size = New System.Drawing.Size(277, 26)
        Me.txtCheckInID.TabIndex = 6
        '
        'txtBookingID
        '
        Me.txtBookingID.Location = New System.Drawing.Point(583, 179)
        Me.txtBookingID.Name = "txtBookingID"
        Me.txtBookingID.Size = New System.Drawing.Size(277, 26)
        Me.txtBookingID.TabIndex = 7
        '
        'txtNumberOfGuests
        '
        Me.txtNumberOfGuests.Location = New System.Drawing.Point(583, 310)
        Me.txtNumberOfGuests.Name = "txtNumberOfGuests"
        Me.txtNumberOfGuests.Size = New System.Drawing.Size(277, 26)
        Me.txtNumberOfGuests.TabIndex = 11
        '
        'dtpCheckInDate
        '
        Me.dtpCheckInDate.Location = New System.Drawing.Point(583, 251)
        Me.dtpCheckInDate.Name = "dtpCheckInDate"
        Me.dtpCheckInDate.Size = New System.Drawing.Size(277, 26)
        Me.dtpCheckInDate.TabIndex = 13
        '
        'btnCheckIn
        '
        Me.btnCheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIn.Location = New System.Drawing.Point(333, 405)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(122, 43)
        Me.btnCheckIn.TabIndex = 14
        Me.btnCheckIn.Text = "CheckIn"
        Me.btnCheckIn.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(687, 405)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 43)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(427, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 46)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "CHECK IN "
        '
        'CheckInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1083, 489)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCheckIn)
        Me.Controls.Add(Me.dtpCheckInDate)
        Me.Controls.Add(Me.txtNumberOfGuests)
        Me.Controls.Add(Me.txtBookingID)
        Me.Controls.Add(Me.txtCheckInID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CheckInForm"
        Me.Text = "CheckInForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCheckInID As TextBox
    Friend WithEvents txtBookingID As TextBox
    Friend WithEvents txtNumberOfGuests As TextBox
    Friend WithEvents dtpCheckInDate As DateTimePicker
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label3 As Label
End Class
