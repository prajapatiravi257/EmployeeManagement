<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_user
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
        Me.pnl_header = New System.Windows.Forms.Panel()
        Me.lbl_loginuser = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.llbl_logout = New System.Windows.Forms.LinkLabel()
        Me.TabPage_holiday = New System.Windows.Forms.TabPage()
        Me.TabPage_leave = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_extra_leaves = New System.Windows.Forms.TextBox()
        Me.tb_leaves_left = New System.Windows.Forms.TextBox()
        Me.tb_total_leaves = New System.Windows.Forms.TextBox()
        Me.gb_applyLeave = New System.Windows.Forms.GroupBox()
        Me.btn_appl = New System.Windows.Forms.Button()
        Me.lbl_char_require = New System.Windows.Forms.Label()
        Me.checkBox_addToPaidLeave = New System.Windows.Forms.CheckBox()
        Me.tb_reason = New System.Windows.Forms.TextBox()
        Me.lbl_reason = New System.Windows.Forms.Label()
        Me.MonthCalendar_leaveDatePicker = New System.Windows.Forms.MonthCalendar()
        Me.lbl_extraLeave = New System.Windows.Forms.Label()
        Me.lbl_leaveLeft = New System.Windows.Forms.Label()
        Me.lbl_totalLeave = New System.Windows.Forms.Label()
        Me.TabPage_personal_details = New System.Windows.Forms.TabPage()
        Me.TabControl_employee = New System.Windows.Forms.TabControl()
        Me.TabPage_reports = New System.Windows.Forms.TabPage()
        Me.pnl_header.SuspendLayout()
        Me.TabPage_leave.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gb_applyLeave.SuspendLayout()
        Me.TabControl_employee.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_header
        '
        Me.pnl_header.Controls.Add(Me.lbl_loginuser)
        Me.pnl_header.Controls.Add(Me.lbl_login)
        Me.pnl_header.Controls.Add(Me.llbl_logout)
        Me.pnl_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_header.Location = New System.Drawing.Point(0, 0)
        Me.pnl_header.Name = "pnl_header"
        Me.pnl_header.Size = New System.Drawing.Size(1284, 34)
        Me.pnl_header.TabIndex = 1
        '
        'lbl_loginuser
        '
        Me.lbl_loginuser.AutoSize = True
        Me.lbl_loginuser.Location = New System.Drawing.Point(70, 6)
        Me.lbl_loginuser.Name = "lbl_loginuser"
        Me.lbl_loginuser.Size = New System.Drawing.Size(0, 13)
        Me.lbl_loginuser.TabIndex = 5
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Location = New System.Drawing.Point(11, 6)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(59, 13)
        Me.lbl_login.TabIndex = 4
        Me.lbl_login.Text = "Login as :: "
        '
        'llbl_logout
        '
        Me.llbl_logout.AutoSize = True
        Me.llbl_logout.Location = New System.Drawing.Point(1229, 6)
        Me.llbl_logout.Name = "llbl_logout"
        Me.llbl_logout.Size = New System.Drawing.Size(40, 13)
        Me.llbl_logout.TabIndex = 3
        Me.llbl_logout.TabStop = True
        Me.llbl_logout.Text = "Logout"
        '
        'TabPage_holiday
        '
        Me.TabPage_holiday.Location = New System.Drawing.Point(4, 36)
        Me.TabPage_holiday.Name = "TabPage_holiday"
        Me.TabPage_holiday.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_holiday.Size = New System.Drawing.Size(1276, 462)
        Me.TabPage_holiday.TabIndex = 2
        Me.TabPage_holiday.Text = "Holidays"
        Me.TabPage_holiday.UseVisualStyleBackColor = True
        '
        'TabPage_leave
        '
        Me.TabPage_leave.Controls.Add(Me.GroupBox1)
        Me.TabPage_leave.Location = New System.Drawing.Point(4, 36)
        Me.TabPage_leave.Name = "TabPage_leave"
        Me.TabPage_leave.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_leave.Size = New System.Drawing.Size(1276, 462)
        Me.TabPage_leave.TabIndex = 1
        Me.TabPage_leave.Text = "Leave"
        Me.TabPage_leave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_extra_leaves)
        Me.GroupBox1.Controls.Add(Me.tb_leaves_left)
        Me.GroupBox1.Controls.Add(Me.tb_total_leaves)
        Me.GroupBox1.Controls.Add(Me.gb_applyLeave)
        Me.GroupBox1.Controls.Add(Me.lbl_extraLeave)
        Me.GroupBox1.Controls.Add(Me.lbl_leaveLeft)
        Me.GroupBox1.Controls.Add(Me.lbl_totalLeave)
        Me.GroupBox1.Location = New System.Drawing.Point(208, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(838, 348)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Leave Control Panel"
        '
        'tb_extra_leaves
        '
        Me.tb_extra_leaves.Location = New System.Drawing.Point(107, 246)
        Me.tb_extra_leaves.Name = "tb_extra_leaves"
        Me.tb_extra_leaves.ReadOnly = True
        Me.tb_extra_leaves.Size = New System.Drawing.Size(35, 20)
        Me.tb_extra_leaves.TabIndex = 8
        Me.tb_extra_leaves.Text = "0"
        '
        'tb_leaves_left
        '
        Me.tb_leaves_left.Location = New System.Drawing.Point(107, 176)
        Me.tb_leaves_left.Name = "tb_leaves_left"
        Me.tb_leaves_left.ReadOnly = True
        Me.tb_leaves_left.Size = New System.Drawing.Size(35, 20)
        Me.tb_leaves_left.TabIndex = 7
        Me.tb_leaves_left.Text = "0"
        '
        'tb_total_leaves
        '
        Me.tb_total_leaves.Location = New System.Drawing.Point(107, 104)
        Me.tb_total_leaves.Name = "tb_total_leaves"
        Me.tb_total_leaves.ReadOnly = True
        Me.tb_total_leaves.Size = New System.Drawing.Size(35, 20)
        Me.tb_total_leaves.TabIndex = 6
        Me.tb_total_leaves.Text = "0"
        '
        'gb_applyLeave
        '
        Me.gb_applyLeave.Controls.Add(Me.btn_appl)
        Me.gb_applyLeave.Controls.Add(Me.lbl_char_require)
        Me.gb_applyLeave.Controls.Add(Me.checkBox_addToPaidLeave)
        Me.gb_applyLeave.Controls.Add(Me.tb_reason)
        Me.gb_applyLeave.Controls.Add(Me.lbl_reason)
        Me.gb_applyLeave.Controls.Add(Me.MonthCalendar_leaveDatePicker)
        Me.gb_applyLeave.Location = New System.Drawing.Point(209, 63)
        Me.gb_applyLeave.Name = "gb_applyLeave"
        Me.gb_applyLeave.Size = New System.Drawing.Size(604, 253)
        Me.gb_applyLeave.TabIndex = 5
        Me.gb_applyLeave.TabStop = False
        Me.gb_applyLeave.Text = "Apply Leave"
        '
        'btn_appl
        '
        Me.btn_appl.Location = New System.Drawing.Point(502, 205)
        Me.btn_appl.Name = "btn_appl"
        Me.btn_appl.Size = New System.Drawing.Size(75, 23)
        Me.btn_appl.TabIndex = 9
        Me.btn_appl.Text = "APPLY"
        Me.btn_appl.UseVisualStyleBackColor = True
        '
        'lbl_char_require
        '
        Me.lbl_char_require.AutoSize = True
        Me.lbl_char_require.Location = New System.Drawing.Point(411, 160)
        Me.lbl_char_require.Name = "lbl_char_require"
        Me.lbl_char_require.Size = New System.Drawing.Size(166, 13)
        Me.lbl_char_require.TabIndex = 8
        Me.lbl_char_require.Text = "Maximum 140 characters required"
        '
        'checkBox_addToPaidLeave
        '
        Me.checkBox_addToPaidLeave.AutoSize = True
        Me.checkBox_addToPaidLeave.Location = New System.Drawing.Point(90, 211)
        Me.checkBox_addToPaidLeave.Name = "checkBox_addToPaidLeave"
        Me.checkBox_addToPaidLeave.Size = New System.Drawing.Size(123, 17)
        Me.checkBox_addToPaidLeave.TabIndex = 7
        Me.checkBox_addToPaidLeave.Text = "Add To Paid Leaves"
        Me.checkBox_addToPaidLeave.UseVisualStyleBackColor = True
        '
        'tb_reason
        '
        Me.tb_reason.Location = New System.Drawing.Point(349, 59)
        Me.tb_reason.MaxLength = 141
        Me.tb_reason.Multiline = True
        Me.tb_reason.Name = "tb_reason"
        Me.tb_reason.Size = New System.Drawing.Size(228, 87)
        Me.tb_reason.TabIndex = 6
        '
        'lbl_reason
        '
        Me.lbl_reason.AutoSize = True
        Me.lbl_reason.Location = New System.Drawing.Point(288, 59)
        Me.lbl_reason.Name = "lbl_reason"
        Me.lbl_reason.Size = New System.Drawing.Size(47, 13)
        Me.lbl_reason.TabIndex = 5
        Me.lbl_reason.Text = "Reason:"
        '
        'MonthCalendar_leaveDatePicker
        '
        Me.MonthCalendar_leaveDatePicker.Location = New System.Drawing.Point(27, 34)
        Me.MonthCalendar_leaveDatePicker.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.MonthCalendar_leaveDatePicker.Name = "MonthCalendar_leaveDatePicker"
        Me.MonthCalendar_leaveDatePicker.TabIndex = 4
        '
        'lbl_extraLeave
        '
        Me.lbl_extraLeave.AutoSize = True
        Me.lbl_extraLeave.Location = New System.Drawing.Point(21, 249)
        Me.lbl_extraLeave.Name = "lbl_extraLeave"
        Me.lbl_extraLeave.Size = New System.Drawing.Size(69, 13)
        Me.lbl_extraLeave.TabIndex = 3
        Me.lbl_extraLeave.Text = "Extra Leaves"
        '
        'lbl_leaveLeft
        '
        Me.lbl_leaveLeft.AutoSize = True
        Me.lbl_leaveLeft.Location = New System.Drawing.Point(21, 179)
        Me.lbl_leaveLeft.Name = "lbl_leaveLeft"
        Me.lbl_leaveLeft.Size = New System.Drawing.Size(59, 13)
        Me.lbl_leaveLeft.TabIndex = 1
        Me.lbl_leaveLeft.Text = "Leaves left"
        '
        'lbl_totalLeave
        '
        Me.lbl_totalLeave.AutoSize = True
        Me.lbl_totalLeave.Location = New System.Drawing.Point(21, 107)
        Me.lbl_totalLeave.Name = "lbl_totalLeave"
        Me.lbl_totalLeave.Size = New System.Drawing.Size(69, 13)
        Me.lbl_totalLeave.TabIndex = 0
        Me.lbl_totalLeave.Text = "Total Leaves"
        '
        'TabPage_personal_details
        '
        Me.TabPage_personal_details.Location = New System.Drawing.Point(4, 36)
        Me.TabPage_personal_details.Name = "TabPage_personal_details"
        Me.TabPage_personal_details.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_personal_details.Size = New System.Drawing.Size(1276, 462)
        Me.TabPage_personal_details.TabIndex = 0
        Me.TabPage_personal_details.Text = "Personal Details"
        Me.TabPage_personal_details.UseVisualStyleBackColor = True
        '
        'TabControl_employee
        '
        Me.TabControl_employee.Controls.Add(Me.TabPage_personal_details)
        Me.TabControl_employee.Controls.Add(Me.TabPage_leave)
        Me.TabControl_employee.Controls.Add(Me.TabPage_holiday)
        Me.TabControl_employee.Controls.Add(Me.TabPage_reports)
        Me.TabControl_employee.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl_employee.ItemSize = New System.Drawing.Size(71, 32)
        Me.TabControl_employee.Location = New System.Drawing.Point(0, 34)
        Me.TabControl_employee.Name = "TabControl_employee"
        Me.TabControl_employee.Padding = New System.Drawing.Point(10, 10)
        Me.TabControl_employee.SelectedIndex = 0
        Me.TabControl_employee.Size = New System.Drawing.Size(1284, 502)
        Me.TabControl_employee.TabIndex = 0
        '
        'TabPage_reports
        '
        Me.TabPage_reports.Location = New System.Drawing.Point(4, 36)
        Me.TabPage_reports.Name = "TabPage_reports"
        Me.TabPage_reports.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_reports.Size = New System.Drawing.Size(1276, 462)
        Me.TabPage_reports.TabIndex = 3
        Me.TabPage_reports.Text = "Reports"
        Me.TabPage_reports.UseVisualStyleBackColor = True
        '
        'frm_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 536)
        Me.Controls.Add(Me.pnl_header)
        Me.Controls.Add(Me.TabControl_employee)
        Me.Name = "frm_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_user"
        Me.pnl_header.ResumeLayout(False)
        Me.pnl_header.PerformLayout()
        Me.TabPage_leave.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb_applyLeave.ResumeLayout(False)
        Me.gb_applyLeave.PerformLayout()
        Me.TabControl_employee.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_header As Panel
    Friend WithEvents lbl_loginuser As Label
    Friend WithEvents lbl_login As Label
    Friend WithEvents llbl_logout As LinkLabel
    Friend WithEvents TabPage_holiday As TabPage
    Friend WithEvents TabPage_leave As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gb_applyLeave As GroupBox
    Friend WithEvents lbl_char_require As Label
    Friend WithEvents checkBox_addToPaidLeave As CheckBox
    Friend WithEvents tb_reason As TextBox
    Friend WithEvents lbl_reason As Label
    Friend WithEvents lbl_extraLeave As Label
    Friend WithEvents lbl_leaveLeft As Label
    Friend WithEvents lbl_totalLeave As Label
    Friend WithEvents TabPage_personal_details As TabPage
    Friend WithEvents TabControl_employee As TabControl
    Friend WithEvents TabPage_reports As TabPage
    Friend WithEvents tb_extra_leaves As TextBox
    Friend WithEvents tb_leaves_left As TextBox
    Friend WithEvents tb_total_leaves As TextBox
    Friend WithEvents MonthCalendar_leaveDatePicker As MonthCalendar
    Friend WithEvents btn_appl As Button
End Class
