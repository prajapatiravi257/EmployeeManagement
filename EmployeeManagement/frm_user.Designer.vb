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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_user))
        Me.pnl_header = New System.Windows.Forms.Panel()
        Me.lbl_loginuser = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.llbl_logout = New System.Windows.Forms.LinkLabel()
        Me.TabPage_holiday = New System.Windows.Forms.TabPage()
        Me.lb_holiday = New System.Windows.Forms.ListBox()
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
        Me.gb_personal_info_parent = New System.Windows.Forms.GroupBox()
        Me.gb_personal_info = New System.Windows.Forms.GroupBox()
        Me.btn_personalInfo_edit = New System.Windows.Forms.Button()
        Me.tb_zip = New System.Windows.Forms.TextBox()
        Me.lbl_zip = New System.Windows.Forms.Label()
        Me.tb_add = New System.Windows.Forms.TextBox()
        Me.lbl_add = New System.Windows.Forms.Label()
        Me.tb_city = New System.Windows.Forms.TextBox()
        Me.lbl_city = New System.Windows.Forms.Label()
        Me.cb_married_status = New System.Windows.Forms.ComboBox()
        Me.lbl_married_status = New System.Windows.Forms.Label()
        Me.tb_qual = New System.Windows.Forms.TextBox()
        Me.lbl_qual = New System.Windows.Forms.Label()
        Me.tb_mob = New System.Windows.Forms.TextBox()
        Me.lbl_mob = New System.Windows.Forms.Label()
        Me.dtp_dob = New System.Windows.Forms.DateTimePicker()
        Me.tb_email = New System.Windows.Forms.TextBox()
        Me.tb_lastname = New System.Windows.Forms.TextBox()
        Me.tb_firstname = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Fullname = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_val_dob = New System.Windows.Forms.Label()
        Me.lbl_val_empName = New System.Windows.Forms.Label()
        Me.lbl_val_empid = New System.Windows.Forms.Label()
        Me.lbl_dob = New System.Windows.Forms.Label()
        Me.lbl_empName = New System.Windows.Forms.Label()
        Me.PictureBox_profilePic = New System.Windows.Forms.PictureBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.TabControl_employee = New System.Windows.Forms.TabControl()
        Me.TabPage_reports = New System.Windows.Forms.TabPage()
        Me.pnl_header.SuspendLayout()
        Me.TabPage_holiday.SuspendLayout()
        Me.TabPage_leave.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gb_applyLeave.SuspendLayout()
        Me.TabPage_personal_details.SuspendLayout()
        Me.gb_personal_info_parent.SuspendLayout()
        Me.gb_personal_info.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox_profilePic, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPage_holiday.Controls.Add(Me.lb_holiday)
        Me.TabPage_holiday.Location = New System.Drawing.Point(4, 36)
        Me.TabPage_holiday.Name = "TabPage_holiday"
        Me.TabPage_holiday.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_holiday.Size = New System.Drawing.Size(1276, 462)
        Me.TabPage_holiday.TabIndex = 2
        Me.TabPage_holiday.Text = "Holidays"
        Me.TabPage_holiday.UseVisualStyleBackColor = True
        '
        'lb_holiday
        '
        Me.lb_holiday.FormattingEnabled = True
        Me.lb_holiday.Location = New System.Drawing.Point(290, 37)
        Me.lb_holiday.Name = "lb_holiday"
        Me.lb_holiday.Size = New System.Drawing.Size(703, 381)
        Me.lb_holiday.TabIndex = 0
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
        Me.GroupBox1.Size = New System.Drawing.Size(847, 348)
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
        Me.TabPage_personal_details.Controls.Add(Me.gb_personal_info_parent)
        Me.TabPage_personal_details.Location = New System.Drawing.Point(4, 36)
        Me.TabPage_personal_details.Name = "TabPage_personal_details"
        Me.TabPage_personal_details.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_personal_details.Size = New System.Drawing.Size(1276, 462)
        Me.TabPage_personal_details.TabIndex = 0
        Me.TabPage_personal_details.Text = "Personal Details"
        Me.TabPage_personal_details.UseVisualStyleBackColor = True
        '
        'gb_personal_info_parent
        '
        Me.gb_personal_info_parent.Controls.Add(Me.gb_personal_info)
        Me.gb_personal_info_parent.Controls.Add(Me.Panel1)
        Me.gb_personal_info_parent.Location = New System.Drawing.Point(99, 38)
        Me.gb_personal_info_parent.Name = "gb_personal_info_parent"
        Me.gb_personal_info_parent.Size = New System.Drawing.Size(1098, 376)
        Me.gb_personal_info_parent.TabIndex = 1
        Me.gb_personal_info_parent.TabStop = False
        '
        'gb_personal_info
        '
        Me.gb_personal_info.Controls.Add(Me.btn_personalInfo_edit)
        Me.gb_personal_info.Controls.Add(Me.tb_zip)
        Me.gb_personal_info.Controls.Add(Me.lbl_zip)
        Me.gb_personal_info.Controls.Add(Me.tb_add)
        Me.gb_personal_info.Controls.Add(Me.lbl_add)
        Me.gb_personal_info.Controls.Add(Me.tb_city)
        Me.gb_personal_info.Controls.Add(Me.lbl_city)
        Me.gb_personal_info.Controls.Add(Me.cb_married_status)
        Me.gb_personal_info.Controls.Add(Me.lbl_married_status)
        Me.gb_personal_info.Controls.Add(Me.tb_qual)
        Me.gb_personal_info.Controls.Add(Me.lbl_qual)
        Me.gb_personal_info.Controls.Add(Me.tb_mob)
        Me.gb_personal_info.Controls.Add(Me.lbl_mob)
        Me.gb_personal_info.Controls.Add(Me.dtp_dob)
        Me.gb_personal_info.Controls.Add(Me.tb_email)
        Me.gb_personal_info.Controls.Add(Me.tb_lastname)
        Me.gb_personal_info.Controls.Add(Me.tb_firstname)
        Me.gb_personal_info.Controls.Add(Me.lbl_email)
        Me.gb_personal_info.Controls.Add(Me.Label1)
        Me.gb_personal_info.Controls.Add(Me.lbl_Fullname)
        Me.gb_personal_info.Location = New System.Drawing.Point(367, 53)
        Me.gb_personal_info.Name = "gb_personal_info"
        Me.gb_personal_info.Size = New System.Drawing.Size(675, 267)
        Me.gb_personal_info.TabIndex = 3
        Me.gb_personal_info.TabStop = False
        Me.gb_personal_info.Text = "Personal Info"
        '
        'btn_personalInfo_edit
        '
        Me.btn_personalInfo_edit.Location = New System.Drawing.Point(569, 234)
        Me.btn_personalInfo_edit.Name = "btn_personalInfo_edit"
        Me.btn_personalInfo_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_personalInfo_edit.TabIndex = 34
        Me.btn_personalInfo_edit.Text = "Edit"
        Me.btn_personalInfo_edit.UseVisualStyleBackColor = True
        '
        'tb_zip
        '
        Me.tb_zip.Location = New System.Drawing.Point(280, 154)
        Me.tb_zip.MaxLength = 6
        Me.tb_zip.Name = "tb_zip"
        Me.tb_zip.Size = New System.Drawing.Size(102, 20)
        Me.tb_zip.TabIndex = 29
        '
        'lbl_zip
        '
        Me.lbl_zip.AutoSize = True
        Me.lbl_zip.Location = New System.Drawing.Point(225, 158)
        Me.lbl_zip.Name = "lbl_zip"
        Me.lbl_zip.Size = New System.Drawing.Size(49, 13)
        Me.lbl_zip.TabIndex = 33
        Me.lbl_zip.Text = "Zip code"
        '
        'tb_add
        '
        Me.tb_add.Location = New System.Drawing.Point(108, 191)
        Me.tb_add.MaxLength = 50
        Me.tb_add.Multiline = True
        Me.tb_add.Name = "tb_add"
        Me.tb_add.Size = New System.Drawing.Size(274, 20)
        Me.tb_add.TabIndex = 30
        '
        'lbl_add
        '
        Me.lbl_add.AutoSize = True
        Me.lbl_add.Location = New System.Drawing.Point(24, 194)
        Me.lbl_add.Name = "lbl_add"
        Me.lbl_add.Size = New System.Drawing.Size(45, 13)
        Me.lbl_add.TabIndex = 32
        Me.lbl_add.Text = "Address"
        '
        'tb_city
        '
        Me.tb_city.Location = New System.Drawing.Point(108, 154)
        Me.tb_city.MaxLength = 40
        Me.tb_city.Name = "tb_city"
        Me.tb_city.Size = New System.Drawing.Size(100, 20)
        Me.tb_city.TabIndex = 28
        '
        'lbl_city
        '
        Me.lbl_city.AutoSize = True
        Me.lbl_city.Location = New System.Drawing.Point(24, 158)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(24, 13)
        Me.lbl_city.TabIndex = 31
        Me.lbl_city.Text = "City"
        '
        'cb_married_status
        '
        Me.cb_married_status.FormattingEnabled = True
        Me.cb_married_status.Items.AddRange(New Object() {"Married", "Single"})
        Me.cb_married_status.Location = New System.Drawing.Point(504, 98)
        Me.cb_married_status.Name = "cb_married_status"
        Me.cb_married_status.Size = New System.Drawing.Size(141, 21)
        Me.cb_married_status.TabIndex = 11
        Me.cb_married_status.Text = "Single"
        '
        'lbl_married_status
        '
        Me.lbl_married_status.AutoSize = True
        Me.lbl_married_status.Location = New System.Drawing.Point(420, 102)
        Me.lbl_married_status.Name = "lbl_married_status"
        Me.lbl_married_status.Size = New System.Drawing.Size(75, 13)
        Me.lbl_married_status.TabIndex = 27
        Me.lbl_married_status.Text = "Married Status"
        '
        'tb_qual
        '
        Me.tb_qual.Location = New System.Drawing.Point(503, 191)
        Me.tb_qual.MaxLength = 30
        Me.tb_qual.Name = "tb_qual"
        Me.tb_qual.Size = New System.Drawing.Size(141, 20)
        Me.tb_qual.TabIndex = 10
        '
        'lbl_qual
        '
        Me.lbl_qual.AutoSize = True
        Me.lbl_qual.Location = New System.Drawing.Point(420, 194)
        Me.lbl_qual.Name = "lbl_qual"
        Me.lbl_qual.Size = New System.Drawing.Size(65, 13)
        Me.lbl_qual.TabIndex = 25
        Me.lbl_qual.Text = "Qualification"
        '
        'tb_mob
        '
        Me.tb_mob.Location = New System.Drawing.Point(503, 149)
        Me.tb_mob.MaxLength = 10
        Me.tb_mob.Name = "tb_mob"
        Me.tb_mob.Size = New System.Drawing.Size(142, 20)
        Me.tb_mob.TabIndex = 9
        '
        'lbl_mob
        '
        Me.lbl_mob.AutoSize = True
        Me.lbl_mob.Location = New System.Drawing.Point(420, 154)
        Me.lbl_mob.Name = "lbl_mob"
        Me.lbl_mob.Size = New System.Drawing.Size(56, 13)
        Me.lbl_mob.TabIndex = 17
        Me.lbl_mob.Text = "Mobile no."
        '
        'dtp_dob
        '
        Me.dtp_dob.Checked = False
        Me.dtp_dob.CustomFormat = "dd/MM/yyyy"
        Me.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_dob.Location = New System.Drawing.Point(504, 54)
        Me.dtp_dob.MaxDate = New Date(1998, 12, 31, 0, 0, 0, 0)
        Me.dtp_dob.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.dtp_dob.Name = "dtp_dob"
        Me.dtp_dob.ShowCheckBox = True
        Me.dtp_dob.Size = New System.Drawing.Size(111, 20)
        Me.dtp_dob.TabIndex = 2
        Me.dtp_dob.Value = New Date(1998, 12, 31, 0, 0, 0, 0)
        '
        'tb_email
        '
        Me.tb_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tb_email.Location = New System.Drawing.Point(108, 98)
        Me.tb_email.MaxLength = 60
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(272, 20)
        Me.tb_email.TabIndex = 5
        '
        'tb_lastname
        '
        Me.tb_lastname.Location = New System.Drawing.Point(248, 54)
        Me.tb_lastname.MaxLength = 30
        Me.tb_lastname.Name = "tb_lastname"
        Me.tb_lastname.Size = New System.Drawing.Size(132, 20)
        Me.tb_lastname.TabIndex = 1
        '
        'tb_firstname
        '
        Me.tb_firstname.Location = New System.Drawing.Point(108, 54)
        Me.tb_firstname.MaxLength = 30
        Me.tb_firstname.Name = "tb_firstname"
        Me.tb_firstname.Size = New System.Drawing.Size(122, 20)
        Me.tb_firstname.TabIndex = 0
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(24, 102)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(46, 13)
        Me.lbl_email.TabIndex = 4
        Me.lbl_email.Text = "Email ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(420, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date of birth"
        '
        'lbl_Fullname
        '
        Me.lbl_Fullname.AutoSize = True
        Me.lbl_Fullname.Location = New System.Drawing.Point(22, 57)
        Me.lbl_Fullname.Name = "lbl_Fullname"
        Me.lbl_Fullname.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Fullname.TabIndex = 0
        Me.lbl_Fullname.Text = "Full Name"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_val_dob)
        Me.Panel1.Controls.Add(Me.lbl_val_empName)
        Me.Panel1.Controls.Add(Me.lbl_val_empid)
        Me.Panel1.Controls.Add(Me.lbl_dob)
        Me.Panel1.Controls.Add(Me.lbl_empName)
        Me.Panel1.Controls.Add(Me.PictureBox_profilePic)
        Me.Panel1.Controls.Add(Me.lbl_name)
        Me.Panel1.Location = New System.Drawing.Point(52, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(278, 314)
        Me.Panel1.TabIndex = 2
        '
        'lbl_val_dob
        '
        Me.lbl_val_dob.AutoSize = True
        Me.lbl_val_dob.Location = New System.Drawing.Point(186, 265)
        Me.lbl_val_dob.Name = "lbl_val_dob"
        Me.lbl_val_dob.Size = New System.Drawing.Size(0, 13)
        Me.lbl_val_dob.TabIndex = 6
        '
        'lbl_val_empName
        '
        Me.lbl_val_empName.AutoSize = True
        Me.lbl_val_empName.Location = New System.Drawing.Point(186, 241)
        Me.lbl_val_empName.Name = "lbl_val_empName"
        Me.lbl_val_empName.Size = New System.Drawing.Size(0, 13)
        Me.lbl_val_empName.TabIndex = 5
        '
        'lbl_val_empid
        '
        Me.lbl_val_empid.AutoSize = True
        Me.lbl_val_empid.Location = New System.Drawing.Point(186, 215)
        Me.lbl_val_empid.Name = "lbl_val_empid"
        Me.lbl_val_empid.Size = New System.Drawing.Size(0, 13)
        Me.lbl_val_empid.TabIndex = 4
        '
        'lbl_dob
        '
        Me.lbl_dob.AutoSize = True
        Me.lbl_dob.Location = New System.Drawing.Point(43, 265)
        Me.lbl_dob.Name = "lbl_dob"
        Me.lbl_dob.Size = New System.Drawing.Size(68, 13)
        Me.lbl_dob.TabIndex = 3
        Me.lbl_dob.Text = "Date Of Birth"
        '
        'lbl_empName
        '
        Me.lbl_empName.AutoSize = True
        Me.lbl_empName.Location = New System.Drawing.Point(43, 241)
        Me.lbl_empName.Name = "lbl_empName"
        Me.lbl_empName.Size = New System.Drawing.Size(84, 13)
        Me.lbl_empName.TabIndex = 2
        Me.lbl_empName.Text = "Employee Name"
        '
        'PictureBox_profilePic
        '
        Me.PictureBox_profilePic.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_profilePic.Image = CType(resources.GetObject("PictureBox_profilePic.Image"), System.Drawing.Image)
        Me.PictureBox_profilePic.Location = New System.Drawing.Point(46, 21)
        Me.PictureBox_profilePic.Name = "PictureBox_profilePic"
        Me.PictureBox_profilePic.Size = New System.Drawing.Size(180, 165)
        Me.PictureBox_profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox_profilePic.TabIndex = 0
        Me.PictureBox_profilePic.TabStop = False
        Me.PictureBox_profilePic.WaitOnLoad = True
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(43, 215)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(67, 13)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Employee ID"
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
        Me.TabControl_employee.Padding = New System.Drawing.Point(10, 5)
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
        Me.TabPage_holiday.ResumeLayout(False)
        Me.TabPage_leave.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb_applyLeave.ResumeLayout(False)
        Me.gb_applyLeave.PerformLayout()
        Me.TabPage_personal_details.ResumeLayout(False)
        Me.gb_personal_info_parent.ResumeLayout(False)
        Me.gb_personal_info.ResumeLayout(False)
        Me.gb_personal_info.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox_profilePic, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox_profilePic As PictureBox
    Friend WithEvents gb_personal_info_parent As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_val_dob As Label
    Friend WithEvents lbl_val_empName As Label
    Friend WithEvents lbl_val_empid As Label
    Friend WithEvents lbl_dob As Label
    Friend WithEvents lbl_empName As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents gb_personal_info As GroupBox
    Friend WithEvents tb_zip As TextBox
    Friend WithEvents lbl_zip As Label
    Friend WithEvents tb_add As TextBox
    Friend WithEvents lbl_add As Label
    Friend WithEvents tb_city As TextBox
    Friend WithEvents lbl_city As Label
    Friend WithEvents cb_married_status As ComboBox
    Friend WithEvents lbl_married_status As Label
    Friend WithEvents tb_qual As TextBox
    Friend WithEvents lbl_qual As Label
    Friend WithEvents tb_mob As TextBox
    Friend WithEvents lbl_mob As Label
    Friend WithEvents dtp_dob As DateTimePicker
    Friend WithEvents tb_email As TextBox
    Friend WithEvents tb_lastname As TextBox
    Friend WithEvents tb_firstname As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Fullname As Label
    Friend WithEvents btn_personalInfo_edit As Button
    Friend WithEvents lb_holiday As ListBox
End Class
