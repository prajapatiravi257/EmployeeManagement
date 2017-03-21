<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_user
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_user))
        Me.pnl_header = New System.Windows.Forms.Panel()
        Me.lbl_loginuser = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.llbl_logout = New System.Windows.Forms.LinkLabel()
        Me.TabPage_holiday = New System.Windows.Forms.TabPage()
        Me.gb_events = New System.Windows.Forms.GroupBox()
        Me.DGV_user_events = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeManagementDataSet = New EmployeeManagement.EmployeeManagementDataSet()
        Me.gb_holidays = New System.Windows.Forms.GroupBox()
        Me.DGV_holidays = New System.Windows.Forms.DataGridView()
        Me.HolidaydateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HolidaynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HolidayinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage_leave = New System.Windows.Forms.TabPage()
        Me.gb_leave_ctrl = New System.Windows.Forms.GroupBox()
        Me.gb_leave_counter = New System.Windows.Forms.GroupBox()
        Me.tb_extra_leaves = New System.Windows.Forms.TextBox()
        Me.lbl_totalLeave = New System.Windows.Forms.Label()
        Me.lbl_leaveLeft = New System.Windows.Forms.Label()
        Me.tb_leaves_left = New System.Windows.Forms.TextBox()
        Me.lbl_extraLeave = New System.Windows.Forms.Label()
        Me.tb_total_leaves = New System.Windows.Forms.TextBox()
        Me.gb_applyLeave = New System.Windows.Forms.GroupBox()
        Me.btn_appl = New System.Windows.Forms.Button()
        Me.lbl_char_require = New System.Windows.Forms.Label()
        Me.checkBox_addToPaidLeave = New System.Windows.Forms.CheckBox()
        Me.tb_reason = New System.Windows.Forms.TextBox()
        Me.lbl_reason = New System.Windows.Forms.Label()
        Me.MonthCalendar_leaveDatePicker = New System.Windows.Forms.MonthCalendar()
        Me.TabPage_personal_details = New System.Windows.Forms.TabPage()
        Me.gb_personal_info_parent = New System.Windows.Forms.GroupBox()
        Me.gb_profilw = New System.Windows.Forms.GroupBox()
        Me.lbl_val_dob = New System.Windows.Forms.Label()
        Me.lbl_val_empName = New System.Windows.Forms.Label()
        Me.lbl_val_empid = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_empName = New System.Windows.Forms.Label()
        Me.lbl_dob = New System.Windows.Forms.Label()
        Me.PictureBox_profilePic = New System.Windows.Forms.PictureBox()
        Me.gb_personal_info = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_personalInfo_edit = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.pnl_maritalStatus = New System.Windows.Forms.Panel()
        Me.rb_single = New System.Windows.Forms.RadioButton()
        Me.rb_married = New System.Windows.Forms.RadioButton()
        Me.lbl_married_status = New System.Windows.Forms.Label()
        Me.tb_zip = New System.Windows.Forms.TextBox()
        Me.lbl_zip = New System.Windows.Forms.Label()
        Me.tb_add = New System.Windows.Forms.TextBox()
        Me.lbl_add = New System.Windows.Forms.Label()
        Me.tb_city = New System.Windows.Forms.TextBox()
        Me.lbl_city = New System.Windows.Forms.Label()
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
        Me.TabControl_employee = New System.Windows.Forms.TabControl()
        Me.TabPage_reports = New System.Windows.Forms.TabPage()
        Me.Holiday_infoTableAdapter = New EmployeeManagement.EmployeeManagementDataSetTableAdapters.Holiday_infoTableAdapter()
        Me.EventsTableAdapter = New EmployeeManagement.EmployeeManagementDataSetTableAdapters.EventsTableAdapter()
        Me.pnl_header.SuspendLayout()
        Me.TabPage_holiday.SuspendLayout()
        Me.gb_events.SuspendLayout()
        CType(Me.DGV_user_events, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_holidays.SuspendLayout()
        CType(Me.DGV_holidays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidayinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_leave.SuspendLayout()
        Me.gb_leave_ctrl.SuspendLayout()
        Me.gb_leave_counter.SuspendLayout()
        Me.gb_applyLeave.SuspendLayout()
        Me.TabPage_personal_details.SuspendLayout()
        Me.gb_personal_info_parent.SuspendLayout()
        Me.gb_profilw.SuspendLayout()
        CType(Me.PictureBox_profilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_personal_info.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnl_maritalStatus.SuspendLayout()
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
        Me.TabPage_holiday.Controls.Add(Me.gb_events)
        Me.TabPage_holiday.Controls.Add(Me.gb_holidays)
        Me.TabPage_holiday.Location = New System.Drawing.Point(4, 36)
        Me.TabPage_holiday.Name = "TabPage_holiday"
        Me.TabPage_holiday.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_holiday.Size = New System.Drawing.Size(1276, 462)
        Me.TabPage_holiday.TabIndex = 2
        Me.TabPage_holiday.Text = "Holidays & Events  "
        Me.TabPage_holiday.UseVisualStyleBackColor = True
        '
        'gb_events
        '
        Me.gb_events.Controls.Add(Me.DGV_user_events)
        Me.gb_events.Location = New System.Drawing.Point(45, 37)
        Me.gb_events.Name = "gb_events"
        Me.gb_events.Size = New System.Drawing.Size(395, 370)
        Me.gb_events.TabIndex = 2
        Me.gb_events.TabStop = False
        Me.gb_events.Text = "Upcoming Events"
        '
        'DGV_user_events
        '
        Me.DGV_user_events.AllowUserToAddRows = False
        Me.DGV_user_events.AllowUserToDeleteRows = False
        Me.DGV_user_events.AllowUserToOrderColumns = True
        Me.DGV_user_events.AutoGenerateColumns = False
        Me.DGV_user_events.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_user_events.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_user_events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_user_events.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.EventnameDataGridViewTextBoxColumn, Me.EventdateDataGridViewTextBoxColumn})
        Me.DGV_user_events.DataSource = Me.EventsBindingSource
        Me.DGV_user_events.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_user_events.Location = New System.Drawing.Point(3, 16)
        Me.DGV_user_events.Name = "DGV_user_events"
        Me.DGV_user_events.ReadOnly = True
        Me.DGV_user_events.RowHeadersVisible = False
        Me.DGV_user_events.Size = New System.Drawing.Size(389, 351)
        Me.DGV_user_events.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.FillWeight = 25.0!
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EventnameDataGridViewTextBoxColumn
        '
        Me.EventnameDataGridViewTextBoxColumn.DataPropertyName = "event_name"
        Me.EventnameDataGridViewTextBoxColumn.HeaderText = "Event Name"
        Me.EventnameDataGridViewTextBoxColumn.Name = "EventnameDataGridViewTextBoxColumn"
        Me.EventnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EventdateDataGridViewTextBoxColumn
        '
        Me.EventdateDataGridViewTextBoxColumn.DataPropertyName = "event_date"
        Me.EventdateDataGridViewTextBoxColumn.HeaderText = "Event Date"
        Me.EventdateDataGridViewTextBoxColumn.Name = "EventdateDataGridViewTextBoxColumn"
        Me.EventdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EventsBindingSource
        '
        Me.EventsBindingSource.DataMember = "Events"
        Me.EventsBindingSource.DataSource = Me.EmployeeManagementDataSet
        '
        'EmployeeManagementDataSet
        '
        Me.EmployeeManagementDataSet.DataSetName = "EmployeeManagementDataSet"
        Me.EmployeeManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gb_holidays
        '
        Me.gb_holidays.Controls.Add(Me.DGV_holidays)
        Me.gb_holidays.Location = New System.Drawing.Point(489, 37)
        Me.gb_holidays.Name = "gb_holidays"
        Me.gb_holidays.Size = New System.Drawing.Size(659, 370)
        Me.gb_holidays.TabIndex = 1
        Me.gb_holidays.TabStop = False
        Me.gb_holidays.Text = "Holidays"
        '
        'DGV_holidays
        '
        Me.DGV_holidays.AllowUserToAddRows = False
        Me.DGV_holidays.AllowUserToDeleteRows = False
        Me.DGV_holidays.AllowUserToOrderColumns = True
        Me.DGV_holidays.AutoGenerateColumns = False
        Me.DGV_holidays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_holidays.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_holidays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_holidays.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HolidaydateDataGridViewTextBoxColumn, Me.HolidaynameDataGridViewTextBoxColumn})
        Me.DGV_holidays.DataSource = Me.HolidayinfoBindingSource
        Me.DGV_holidays.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_holidays.Location = New System.Drawing.Point(3, 16)
        Me.DGV_holidays.Name = "DGV_holidays"
        Me.DGV_holidays.ReadOnly = True
        Me.DGV_holidays.RowHeadersVisible = False
        Me.DGV_holidays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_holidays.Size = New System.Drawing.Size(653, 351)
        Me.DGV_holidays.TabIndex = 0
        '
        'HolidaydateDataGridViewTextBoxColumn
        '
        Me.HolidaydateDataGridViewTextBoxColumn.DataPropertyName = "holiday_date"
        Me.HolidaydateDataGridViewTextBoxColumn.HeaderText = "Holiday Date"
        Me.HolidaydateDataGridViewTextBoxColumn.Name = "HolidaydateDataGridViewTextBoxColumn"
        Me.HolidaydateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HolidaynameDataGridViewTextBoxColumn
        '
        Me.HolidaynameDataGridViewTextBoxColumn.DataPropertyName = "holiday_name"
        Me.HolidaynameDataGridViewTextBoxColumn.HeaderText = "Holiday Name"
        Me.HolidaynameDataGridViewTextBoxColumn.Name = "HolidaynameDataGridViewTextBoxColumn"
        Me.HolidaynameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HolidayinfoBindingSource
        '
        Me.HolidayinfoBindingSource.DataMember = "Holiday_info"
        Me.HolidayinfoBindingSource.DataSource = Me.EmployeeManagementDataSet
        '
        'TabPage_leave
        '
        Me.TabPage_leave.Controls.Add(Me.gb_leave_ctrl)
        Me.TabPage_leave.Location = New System.Drawing.Point(4, 36)
        Me.TabPage_leave.Name = "TabPage_leave"
        Me.TabPage_leave.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_leave.Size = New System.Drawing.Size(1276, 462)
        Me.TabPage_leave.TabIndex = 1
        Me.TabPage_leave.Text = "Leave"
        Me.TabPage_leave.UseVisualStyleBackColor = True
        '
        'gb_leave_ctrl
        '
        Me.gb_leave_ctrl.Controls.Add(Me.gb_leave_counter)
        Me.gb_leave_ctrl.Controls.Add(Me.gb_applyLeave)
        Me.gb_leave_ctrl.Location = New System.Drawing.Point(192, 64)
        Me.gb_leave_ctrl.Name = "gb_leave_ctrl"
        Me.gb_leave_ctrl.Size = New System.Drawing.Size(863, 348)
        Me.gb_leave_ctrl.TabIndex = 0
        Me.gb_leave_ctrl.TabStop = False
        Me.gb_leave_ctrl.Text = "Leave Control Panel"
        '
        'gb_leave_counter
        '
        Me.gb_leave_counter.Controls.Add(Me.tb_extra_leaves)
        Me.gb_leave_counter.Controls.Add(Me.lbl_totalLeave)
        Me.gb_leave_counter.Controls.Add(Me.lbl_leaveLeft)
        Me.gb_leave_counter.Controls.Add(Me.tb_leaves_left)
        Me.gb_leave_counter.Controls.Add(Me.lbl_extraLeave)
        Me.gb_leave_counter.Controls.Add(Me.tb_total_leaves)
        Me.gb_leave_counter.Location = New System.Drawing.Point(30, 81)
        Me.gb_leave_counter.Name = "gb_leave_counter"
        Me.gb_leave_counter.Size = New System.Drawing.Size(157, 219)
        Me.gb_leave_counter.TabIndex = 6
        Me.gb_leave_counter.TabStop = False
        Me.gb_leave_counter.Text = "leaves Counter"
        '
        'tb_extra_leaves
        '
        Me.tb_extra_leaves.Location = New System.Drawing.Point(107, 168)
        Me.tb_extra_leaves.Name = "tb_extra_leaves"
        Me.tb_extra_leaves.ReadOnly = True
        Me.tb_extra_leaves.Size = New System.Drawing.Size(35, 20)
        Me.tb_extra_leaves.TabIndex = 8
        Me.tb_extra_leaves.Text = "0"
        '
        'lbl_totalLeave
        '
        Me.lbl_totalLeave.AutoSize = True
        Me.lbl_totalLeave.Location = New System.Drawing.Point(21, 48)
        Me.lbl_totalLeave.Name = "lbl_totalLeave"
        Me.lbl_totalLeave.Size = New System.Drawing.Size(69, 13)
        Me.lbl_totalLeave.TabIndex = 0
        Me.lbl_totalLeave.Text = "Total Leaves"
        '
        'lbl_leaveLeft
        '
        Me.lbl_leaveLeft.AutoSize = True
        Me.lbl_leaveLeft.Location = New System.Drawing.Point(21, 111)
        Me.lbl_leaveLeft.Name = "lbl_leaveLeft"
        Me.lbl_leaveLeft.Size = New System.Drawing.Size(59, 13)
        Me.lbl_leaveLeft.TabIndex = 1
        Me.lbl_leaveLeft.Text = "Leaves left"
        '
        'tb_leaves_left
        '
        Me.tb_leaves_left.Location = New System.Drawing.Point(107, 108)
        Me.tb_leaves_left.Name = "tb_leaves_left"
        Me.tb_leaves_left.ReadOnly = True
        Me.tb_leaves_left.Size = New System.Drawing.Size(35, 20)
        Me.tb_leaves_left.TabIndex = 7
        Me.tb_leaves_left.Text = "0"
        '
        'lbl_extraLeave
        '
        Me.lbl_extraLeave.AutoSize = True
        Me.lbl_extraLeave.Location = New System.Drawing.Point(21, 171)
        Me.lbl_extraLeave.Name = "lbl_extraLeave"
        Me.lbl_extraLeave.Size = New System.Drawing.Size(69, 13)
        Me.lbl_extraLeave.TabIndex = 3
        Me.lbl_extraLeave.Text = "Extra Leaves"
        '
        'tb_total_leaves
        '
        Me.tb_total_leaves.Location = New System.Drawing.Point(107, 45)
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
        Me.gb_personal_info_parent.Controls.Add(Me.gb_profilw)
        Me.gb_personal_info_parent.Controls.Add(Me.gb_personal_info)
        Me.gb_personal_info_parent.Location = New System.Drawing.Point(84, 42)
        Me.gb_personal_info_parent.Name = "gb_personal_info_parent"
        Me.gb_personal_info_parent.Size = New System.Drawing.Size(1098, 376)
        Me.gb_personal_info_parent.TabIndex = 1
        Me.gb_personal_info_parent.TabStop = False
        '
        'gb_profilw
        '
        Me.gb_profilw.Controls.Add(Me.lbl_val_dob)
        Me.gb_profilw.Controls.Add(Me.lbl_val_empName)
        Me.gb_profilw.Controls.Add(Me.lbl_val_empid)
        Me.gb_profilw.Controls.Add(Me.lbl_name)
        Me.gb_profilw.Controls.Add(Me.lbl_empName)
        Me.gb_profilw.Controls.Add(Me.lbl_dob)
        Me.gb_profilw.Controls.Add(Me.PictureBox_profilePic)
        Me.gb_profilw.Location = New System.Drawing.Point(39, 53)
        Me.gb_profilw.Name = "gb_profilw"
        Me.gb_profilw.Size = New System.Drawing.Size(270, 275)
        Me.gb_profilw.TabIndex = 4
        Me.gb_profilw.TabStop = False
        Me.gb_profilw.Text = "Profile"
        '
        'lbl_val_dob
        '
        Me.lbl_val_dob.AutoSize = True
        Me.lbl_val_dob.Location = New System.Drawing.Point(173, 244)
        Me.lbl_val_dob.Name = "lbl_val_dob"
        Me.lbl_val_dob.Size = New System.Drawing.Size(25, 13)
        Me.lbl_val_dob.TabIndex = 9
        Me.lbl_val_dob.Text = "dob"
        '
        'lbl_val_empName
        '
        Me.lbl_val_empName.AutoSize = True
        Me.lbl_val_empName.Location = New System.Drawing.Point(173, 220)
        Me.lbl_val_empName.Name = "lbl_val_empName"
        Me.lbl_val_empName.Size = New System.Drawing.Size(33, 13)
        Me.lbl_val_empName.TabIndex = 8
        Me.lbl_val_empName.Text = "name"
        '
        'lbl_val_empid
        '
        Me.lbl_val_empid.AutoSize = True
        Me.lbl_val_empid.Location = New System.Drawing.Point(173, 194)
        Me.lbl_val_empid.Name = "lbl_val_empid"
        Me.lbl_val_empid.Size = New System.Drawing.Size(41, 13)
        Me.lbl_val_empid.TabIndex = 7
        Me.lbl_val_empid.Text = "emp_id"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(31, 194)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(67, 13)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Employee ID"
        '
        'lbl_empName
        '
        Me.lbl_empName.AutoSize = True
        Me.lbl_empName.Location = New System.Drawing.Point(31, 220)
        Me.lbl_empName.Name = "lbl_empName"
        Me.lbl_empName.Size = New System.Drawing.Size(84, 13)
        Me.lbl_empName.TabIndex = 2
        Me.lbl_empName.Text = "Employee Name"
        '
        'lbl_dob
        '
        Me.lbl_dob.AutoSize = True
        Me.lbl_dob.Location = New System.Drawing.Point(31, 244)
        Me.lbl_dob.Name = "lbl_dob"
        Me.lbl_dob.Size = New System.Drawing.Size(68, 13)
        Me.lbl_dob.TabIndex = 3
        Me.lbl_dob.Text = "Date Of Birth"
        '
        'PictureBox_profilePic
        '
        Me.PictureBox_profilePic.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_profilePic.Image = CType(resources.GetObject("PictureBox_profilePic.Image"), System.Drawing.Image)
        Me.PictureBox_profilePic.Location = New System.Drawing.Point(34, 19)
        Me.PictureBox_profilePic.Name = "PictureBox_profilePic"
        Me.PictureBox_profilePic.Size = New System.Drawing.Size(180, 165)
        Me.PictureBox_profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox_profilePic.TabIndex = 0
        Me.PictureBox_profilePic.TabStop = False
        Me.PictureBox_profilePic.WaitOnLoad = True
        '
        'gb_personal_info
        '
        Me.gb_personal_info.Controls.Add(Me.TableLayoutPanel1)
        Me.gb_personal_info.Controls.Add(Me.pnl_maritalStatus)
        Me.gb_personal_info.Controls.Add(Me.tb_zip)
        Me.gb_personal_info.Controls.Add(Me.lbl_zip)
        Me.gb_personal_info.Controls.Add(Me.tb_add)
        Me.gb_personal_info.Controls.Add(Me.lbl_add)
        Me.gb_personal_info.Controls.Add(Me.tb_city)
        Me.gb_personal_info.Controls.Add(Me.lbl_city)
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
        Me.gb_personal_info.Size = New System.Drawing.Size(675, 275)
        Me.gb_personal_info.TabIndex = 3
        Me.gb_personal_info.TabStop = False
        Me.gb_personal_info.Text = "Personal Info"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_personalInfo_edit, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_update, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(481, 235)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(176, 34)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'btn_personalInfo_edit
        '
        Me.btn_personalInfo_edit.Location = New System.Drawing.Point(3, 3)
        Me.btn_personalInfo_edit.Name = "btn_personalInfo_edit"
        Me.btn_personalInfo_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_personalInfo_edit.TabIndex = 34
        Me.btn_personalInfo_edit.Text = "Edit"
        Me.btn_personalInfo_edit.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(91, 3)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 36
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'pnl_maritalStatus
        '
        Me.pnl_maritalStatus.Controls.Add(Me.rb_single)
        Me.pnl_maritalStatus.Controls.Add(Me.rb_married)
        Me.pnl_maritalStatus.Controls.Add(Me.lbl_married_status)
        Me.pnl_maritalStatus.Location = New System.Drawing.Point(417, 92)
        Me.pnl_maritalStatus.Name = "pnl_maritalStatus"
        Me.pnl_maritalStatus.Size = New System.Drawing.Size(228, 26)
        Me.pnl_maritalStatus.TabIndex = 35
        '
        'rb_single
        '
        Me.rb_single.AutoSize = True
        Me.rb_single.Location = New System.Drawing.Point(162, 7)
        Me.rb_single.Name = "rb_single"
        Me.rb_single.Size = New System.Drawing.Size(54, 17)
        Me.rb_single.TabIndex = 35
        Me.rb_single.TabStop = True
        Me.rb_single.Text = "Single"
        Me.rb_single.UseVisualStyleBackColor = True
        '
        'rb_married
        '
        Me.rb_married.AutoSize = True
        Me.rb_married.Location = New System.Drawing.Point(87, 7)
        Me.rb_married.Name = "rb_married"
        Me.rb_married.Size = New System.Drawing.Size(60, 17)
        Me.rb_married.TabIndex = 34
        Me.rb_married.TabStop = True
        Me.rb_married.Text = "Married"
        Me.rb_married.UseVisualStyleBackColor = True
        '
        'lbl_married_status
        '
        Me.lbl_married_status.AutoSize = True
        Me.lbl_married_status.Location = New System.Drawing.Point(3, 9)
        Me.lbl_married_status.Name = "lbl_married_status"
        Me.lbl_married_status.Size = New System.Drawing.Size(71, 13)
        Me.lbl_married_status.TabIndex = 33
        Me.lbl_married_status.Text = "Marital Status"
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
        Me.dtp_dob.CustomFormat = "dd/MM/yyyy"
        Me.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_dob.Location = New System.Drawing.Point(504, 54)
        Me.dtp_dob.MaxDate = New Date(1998, 12, 31, 0, 0, 0, 0)
        Me.dtp_dob.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.dtp_dob.Name = "dtp_dob"
        Me.dtp_dob.ShowCheckBox = True
        Me.dtp_dob.Size = New System.Drawing.Size(111, 20)
        Me.dtp_dob.TabIndex = 2
        Me.dtp_dob.Value = New Date(1988, 12, 31, 0, 0, 0, 0)
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
        'Holiday_infoTableAdapter
        '
        Me.Holiday_infoTableAdapter.ClearBeforeFill = True
        '
        'EventsTableAdapter
        '
        Me.EventsTableAdapter.ClearBeforeFill = True
        '
        'frm_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 536)
        Me.Controls.Add(Me.pnl_header)
        Me.Controls.Add(Me.TabControl_employee)
        Me.Name = "frm_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Panel"
        Me.pnl_header.ResumeLayout(False)
        Me.pnl_header.PerformLayout()
        Me.TabPage_holiday.ResumeLayout(False)
        Me.gb_events.ResumeLayout(False)
        CType(Me.DGV_user_events, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_holidays.ResumeLayout(False)
        CType(Me.DGV_holidays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidayinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_leave.ResumeLayout(False)
        Me.gb_leave_ctrl.ResumeLayout(False)
        Me.gb_leave_counter.ResumeLayout(False)
        Me.gb_leave_counter.PerformLayout()
        Me.gb_applyLeave.ResumeLayout(False)
        Me.gb_applyLeave.PerformLayout()
        Me.TabPage_personal_details.ResumeLayout(False)
        Me.gb_personal_info_parent.ResumeLayout(False)
        Me.gb_profilw.ResumeLayout(False)
        Me.gb_profilw.PerformLayout()
        CType(Me.PictureBox_profilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_personal_info.ResumeLayout(False)
        Me.gb_personal_info.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnl_maritalStatus.ResumeLayout(False)
        Me.pnl_maritalStatus.PerformLayout()
        Me.TabControl_employee.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_header As Panel
    Friend WithEvents lbl_loginuser As Label
    Friend WithEvents lbl_login As Label
    Friend WithEvents llbl_logout As LinkLabel
    Friend WithEvents TabPage_holiday As TabPage
    Friend WithEvents TabPage_leave As TabPage
    Friend WithEvents gb_leave_ctrl As GroupBox
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
    Friend WithEvents gb_profilw As GroupBox
    Friend WithEvents lbl_val_dob As Label
    Friend WithEvents lbl_val_empName As Label
    Friend WithEvents lbl_val_empid As Label
    Friend WithEvents gb_leave_counter As GroupBox
    Friend WithEvents DGV_holidays As DataGridView
    Friend WithEvents EmpidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HolidayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HfromdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HenddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents gb_events As GroupBox
    Friend WithEvents DGV_user_events As DataGridView
    Friend WithEvents gb_holidays As GroupBox
    Friend WithEvents EmployeeManagementDataSet As EmployeeManagementDataSet
    Friend WithEvents HolidayinfoBindingSource As BindingSource
    Friend WithEvents Holiday_infoTableAdapter As EmployeeManagementDataSetTableAdapters.Holiday_infoTableAdapter
    Friend WithEvents EventsBindingSource As BindingSource
    Friend WithEvents EventsTableAdapter As EmployeeManagementDataSetTableAdapters.EventsTableAdapter
    Friend WithEvents pnl_maritalStatus As Panel
    Friend WithEvents rb_single As RadioButton
    Friend WithEvents rb_married As RadioButton
    Friend WithEvents lbl_married_status As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_update As Button
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EventnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EventdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HolidaydateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HolidaynameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
