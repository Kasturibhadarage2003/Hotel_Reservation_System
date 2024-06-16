<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.btnRoomManagement = New System.Windows.Forms.Button()
        Me.btnBookingManagement = New System.Windows.Forms.Button()
        Me.btnCustomerManagement = New System.Windows.Forms.Button()
        Me.btnCheckInOut = New System.Windows.Forms.Button()
        Me.btnBilling = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRoomManagement
        '
        Me.btnRoomManagement.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnRoomManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoomManagement.Location = New System.Drawing.Point(821, 3)
        Me.btnRoomManagement.Name = "btnRoomManagement"
        Me.btnRoomManagement.Size = New System.Drawing.Size(363, 100)
        Me.btnRoomManagement.TabIndex = 0
        Me.btnRoomManagement.Text = "Room_Management"
        Me.btnRoomManagement.UseVisualStyleBackColor = False
        '
        'btnBookingManagement
        '
        Me.btnBookingManagement.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnBookingManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookingManagement.Location = New System.Drawing.Point(821, 107)
        Me.btnBookingManagement.Name = "btnBookingManagement"
        Me.btnBookingManagement.Size = New System.Drawing.Size(363, 100)
        Me.btnBookingManagement.TabIndex = 1
        Me.btnBookingManagement.Text = "Booking_Management"
        Me.btnBookingManagement.UseVisualStyleBackColor = False
        '
        'btnCustomerManagement
        '
        Me.btnCustomerManagement.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCustomerManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerManagement.Location = New System.Drawing.Point(821, 213)
        Me.btnCustomerManagement.Name = "btnCustomerManagement"
        Me.btnCustomerManagement.Size = New System.Drawing.Size(363, 100)
        Me.btnCustomerManagement.TabIndex = 2
        Me.btnCustomerManagement.Text = "Customer_Management"
        Me.btnCustomerManagement.UseVisualStyleBackColor = False
        '
        'btnCheckInOut
        '
        Me.btnCheckInOut.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCheckInOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckInOut.Location = New System.Drawing.Point(821, 319)
        Me.btnCheckInOut.Name = "btnCheckInOut"
        Me.btnCheckInOut.Size = New System.Drawing.Size(363, 100)
        Me.btnCheckInOut.TabIndex = 3
        Me.btnCheckInOut.Text = "CheckInOut"
        Me.btnCheckInOut.UseVisualStyleBackColor = False
        '
        'btnBilling
        '
        Me.btnBilling.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnBilling.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBilling.Location = New System.Drawing.Point(821, 425)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(363, 100)
        Me.btnBilling.TabIndex = 4
        Me.btnBilling.Text = "Billing"
        Me.btnBilling.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 43)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "WELCOME TO "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(625, 71)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = """CELESTIAL COMFORTS HOTEL"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Papyrus", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(177, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(316, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Experience Luxury Unleashed."
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(821, 531)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(363, 100)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(83, 213)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(558, 401)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(1182, 634)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBilling)
        Me.Controls.Add(Me.btnCheckInOut)
        Me.Controls.Add(Me.btnCustomerManagement)
        Me.Controls.Add(Me.btnBookingManagement)
        Me.Controls.Add(Me.btnRoomManagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRoomManagement As Button
    Friend WithEvents btnBookingManagement As Button
    Friend WithEvents btnCustomerManagement As Button
    Friend WithEvents btnCheckInOut As Button
    Friend WithEvents btnBilling As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
