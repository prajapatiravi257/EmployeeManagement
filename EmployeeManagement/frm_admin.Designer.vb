<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_admin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin))
        Me.fly_parent = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnl_header = New System.Windows.Forms.Panel()
        Me.lbl_loginuser = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.llbl_logout = New System.Windows.Forms.LinkLabel()
        Me.tabcontrol_adm_master = New System.Windows.Forms.TabControl()
        Me.tabpage_adm_emp = New System.Windows.Forms.TabPage()
        Me.pnl_buttond = New System.Windows.Forms.Panel()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_newperson = New System.Windows.Forms.Button()
        Me.tabcontrol_adm_emp_child = New System.Windows.Forms.TabControl()
        Me.tapbpage_personal_details = New System.Windows.Forms.TabPage()
        Me.DGV_emp_info = New System.Windows.Forms.DataGridView()
        Me.EmpidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marital_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrexpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_basic_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeManagementDataSet = New EmployeeManagement.EmployeeManagementDataSet()
        Me.BindingNavigator_basicinfo = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabpage_working_hist = New System.Windows.Forms.TabPage()
        Me.DGV_workhistory = New System.Windows.Forms.DataGridView()
        Me.EmpidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_start_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_end_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.post = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkhistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator_workhistory = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabpage_contact_person = New System.Windows.Forms.TabPage()
        Me.DGV_basic_info = New System.Windows.Forms.DataGridView()
        Me.EmpidDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CfirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CcityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_zipcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator_contactperson = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabpage_adm_leave = New System.Windows.Forms.TabPage()
        Me.gb_emp_leave_list = New System.Windows.Forms.GroupBox()
        Me.DGV_emp_leaves = New System.Windows.Forms.DataGridView()
        Me.EmpidDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeavedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumOfDaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeavereasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidleaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalleaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleavesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabpage_adm_sal = New System.Windows.Forms.TabPage()
        Me.gb_salary = New System.Windows.Forms.GroupBox()
        Me.tb_allow = New System.Windows.Forms.TextBox()
        Me.lbl_allowance = New System.Windows.Forms.Label()
        Me.btn_update_sal = New System.Windows.Forms.Button()
        Me.tb_sal_amt = New System.Windows.Forms.TextBox()
        Me.lbl_sal_amt = New System.Windows.Forms.Label()
        Me.tb_emp_id = New System.Windows.Forms.TextBox()
        Me.lbl_emp_id = New System.Windows.Forms.Label()
        Me.DGV_salary = New System.Windows.Forms.DataGridView()
        Me.EmpidDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlysalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monthly_allowance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlytaxesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlyinsurancesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryinformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeManagementDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabpage_adm_event_holidays = New System.Windows.Forms.TabPage()
        Me.gb_events = New System.Windows.Forms.GroupBox()
        Me.pnl_events = New System.Windows.Forms.Panel()
        Me.btn_delete_event = New System.Windows.Forms.Button()
        Me.dtp_event_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_event_date = New System.Windows.Forms.Label()
        Me.lbl_event_name = New System.Windows.Forms.Label()
        Me.tb_events = New System.Windows.Forms.TextBox()
        Me.btn_new_event = New System.Windows.Forms.Button()
        Me.DGV_adm_events = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gb_holidays = New System.Windows.Forms.GroupBox()
        Me.pnl_holidays = New System.Windows.Forms.Panel()
        Me.btn_delete_holiday = New System.Windows.Forms.Button()
        Me.btn_add_holidays = New System.Windows.Forms.Button()
        Me.lbl_holiday_date = New System.Windows.Forms.Label()
        Me.lbl_holiday_name = New System.Windows.Forms.Label()
        Me.tb_holidayName = New System.Windows.Forms.TextBox()
        Me.dtp_holidayDate = New System.Windows.Forms.DateTimePicker()
        Me.DGV_adm_holidays = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HolidaydateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HolidaynameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HolidayinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Emp_basic_detailsTableAdapter = New EmployeeManagement.EmployeeManagementDataSetTableAdapters.Emp_basic_detailsTableAdapter()
        Me.Work_historyTableAdapter = New EmployeeManagement.EmployeeManagementDataSetTableAdapters.Work_historyTableAdapter()
        Me.Contact_person_infoTableAdapter = New EmployeeManagement.EmployeeManagementDataSetTableAdapters.Contact_person_infoTableAdapter()
        Me.Holiday_infoTableAdapter = New EmployeeManagement.EmployeeManagementDataSetTableAdapters.Holiday_infoTableAdapter()
        Me.Emp_leavesTableAdapter = New EmployeeManagement.EmployeeManagementDataSetTableAdapters.Emp_leavesTableAdapter()
        Me.EventsTableAdapter = New EmployeeManagement.EmployeeManagementDataSetTableAdapters.EventsTableAdapter()
        Me.Salary_informationTableAdapter = New EmployeeManagement.EmployeeManagementDataSetTableAdapters.Salary_informationTableAdapter()
        Me.fly_parent.SuspendLayout()
        Me.pnl_header.SuspendLayout()
        Me.tabcontrol_adm_master.SuspendLayout()
        Me.tabpage_adm_emp.SuspendLayout()
        Me.pnl_buttond.SuspendLayout()
        Me.tabcontrol_adm_emp_child.SuspendLayout()
        Me.tapbpage_personal_details.SuspendLayout()
        CType(Me.DGV_emp_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Emp_basic_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator_basicinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator_basicinfo.SuspendLayout()
        Me.tabpage_working_hist.SuspendLayout()
        CType(Me.DGV_workhistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkhistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator_workhistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator_workhistory.SuspendLayout()
        Me.tabpage_contact_person.SuspendLayout()
        CType(Me.DGV_basic_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator_contactperson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator_contactperson.SuspendLayout()
        Me.tabpage_adm_leave.SuspendLayout()
        Me.gb_emp_leave_list.SuspendLayout()
        CType(Me.DGV_emp_leaves, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleavesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpage_adm_sal.SuspendLayout()
        Me.gb_salary.SuspendLayout()
        CType(Me.DGV_salary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryinformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeManagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpage_adm_event_holidays.SuspendLayout()
        Me.gb_events.SuspendLayout()
        Me.pnl_events.SuspendLayout()
        CType(Me.DGV_adm_events, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_holidays.SuspendLayout()
        Me.pnl_holidays.SuspendLayout()
        CType(Me.DGV_adm_holidays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidayinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fly_parent
        '
        Me.fly_parent.AutoSize = True
        Me.fly_parent.Controls.Add(Me.pnl_header)
        Me.fly_parent.Controls.Add(Me.tabcontrol_adm_master)
        Me.fly_parent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fly_parent.Location = New System.Drawing.Point(0, 0)
        Me.fly_parent.Name = "fly_parent"
        Me.fly_parent.Size = New System.Drawing.Size(1280, 633)
        Me.fly_parent.TabIndex = 0
        '
        'pnl_header
        '
        Me.pnl_header.Controls.Add(Me.lbl_loginuser)
        Me.pnl_header.Controls.Add(Me.lbl_login)
        Me.pnl_header.Controls.Add(Me.llbl_logout)
        Me.pnl_header.Location = New System.Drawing.Point(3, 3)
        Me.pnl_header.Name = "pnl_header"
        Me.pnl_header.Size = New System.Drawing.Size(1274, 39)
        Me.pnl_header.TabIndex = 0
        '
        'lbl_loginuser
        '
        Me.lbl_loginuser.AutoSize = True
        Me.lbl_loginuser.Location = New System.Drawing.Point(77, 7)
        Me.lbl_loginuser.Name = "lbl_loginuser"
        Me.lbl_loginuser.Size = New System.Drawing.Size(55, 15)
        Me.lbl_loginuser.TabIndex = 5
        Me.lbl_loginuser.Text = "username"
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Location = New System.Drawing.Point(13, 7)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(58, 15)
        Me.lbl_login.TabIndex = 4
        Me.lbl_login.Text = "Login as ::"
        '
        'llbl_logout
        '
        Me.llbl_logout.AutoSize = True
        Me.llbl_logout.Location = New System.Drawing.Point(1215, 7)
        Me.llbl_logout.Name = "llbl_logout"
        Me.llbl_logout.Size = New System.Drawing.Size(41, 15)
        Me.llbl_logout.TabIndex = 3
        Me.llbl_logout.TabStop = True
        Me.llbl_logout.Text = "Logout"
        '
        'tabcontrol_adm_master
        '
        Me.tabcontrol_adm_master.Controls.Add(Me.tabpage_adm_emp)
        Me.tabcontrol_adm_master.Controls.Add(Me.tabpage_adm_leave)
        Me.tabcontrol_adm_master.Controls.Add(Me.tabpage_adm_sal)
        Me.tabcontrol_adm_master.Controls.Add(Me.tabpage_adm_event_holidays)
        Me.tabcontrol_adm_master.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabcontrol_adm_master.Location = New System.Drawing.Point(3, 48)
        Me.tabcontrol_adm_master.Name = "tabcontrol_adm_master"
        Me.tabcontrol_adm_master.Padding = New System.Drawing.Point(10, 10)
        Me.tabcontrol_adm_master.SelectedIndex = 0
        Me.tabcontrol_adm_master.Size = New System.Drawing.Size(1300, 692)
        Me.tabcontrol_adm_master.TabIndex = 4
        '
        'tabpage_adm_emp
        '
        Me.tabpage_adm_emp.Controls.Add(Me.pnl_buttond)
        Me.tabpage_adm_emp.Controls.Add(Me.tabcontrol_adm_emp_child)
        Me.tabpage_adm_emp.Location = New System.Drawing.Point(4, 38)
        Me.tabpage_adm_emp.Name = "tabpage_adm_emp"
        Me.tabpage_adm_emp.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_adm_emp.Size = New System.Drawing.Size(1292, 650)
        Me.tabpage_adm_emp.TabIndex = 0
        Me.tabpage_adm_emp.Text = "Employees"
        Me.tabpage_adm_emp.UseVisualStyleBackColor = True
        '
        'pnl_buttond
        '
        Me.pnl_buttond.Controls.Add(Me.btn_delete)
        Me.pnl_buttond.Controls.Add(Me.btn_update)
        Me.pnl_buttond.Controls.Add(Me.btn_newperson)
        Me.pnl_buttond.Location = New System.Drawing.Point(-4, 3)
        Me.pnl_buttond.Name = "pnl_buttond"
        Me.pnl_buttond.Size = New System.Drawing.Size(1310, 35)
        Me.pnl_buttond.TabIndex = 3
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(297, 3)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(87, 27)
        Me.btn_delete.TabIndex = 2
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(163, 3)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(112, 27)
        Me.btn_update.TabIndex = 1
        Me.btn_update.Text = "Update Detail"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_newperson
        '
        Me.btn_newperson.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_newperson.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newperson.Location = New System.Drawing.Point(30, 3)
        Me.btn_newperson.Name = "btn_newperson"
        Me.btn_newperson.Size = New System.Drawing.Size(112, 27)
        Me.btn_newperson.TabIndex = 0
        Me.btn_newperson.Text = " New Person"
        Me.btn_newperson.UseVisualStyleBackColor = True
        '
        'tabcontrol_adm_emp_child
        '
        Me.tabcontrol_adm_emp_child.Controls.Add(Me.tapbpage_personal_details)
        Me.tabcontrol_adm_emp_child.Controls.Add(Me.tabpage_working_hist)
        Me.tabcontrol_adm_emp_child.Controls.Add(Me.tabpage_contact_person)
        Me.tabcontrol_adm_emp_child.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabcontrol_adm_emp_child.ItemSize = New System.Drawing.Size(90, 25)
        Me.tabcontrol_adm_emp_child.Location = New System.Drawing.Point(3, 49)
        Me.tabcontrol_adm_emp_child.Name = "tabcontrol_adm_emp_child"
        Me.tabcontrol_adm_emp_child.Padding = New System.Drawing.Point(8, 3)
        Me.tabcontrol_adm_emp_child.SelectedIndex = 0
        Me.tabcontrol_adm_emp_child.Size = New System.Drawing.Size(1286, 598)
        Me.tabcontrol_adm_emp_child.TabIndex = 2
        '
        'tapbpage_personal_details
        '
        Me.tapbpage_personal_details.Controls.Add(Me.DGV_emp_info)
        Me.tapbpage_personal_details.Controls.Add(Me.BindingNavigator_basicinfo)
        Me.tapbpage_personal_details.Location = New System.Drawing.Point(4, 29)
        Me.tapbpage_personal_details.Name = "tapbpage_personal_details"
        Me.tapbpage_personal_details.Padding = New System.Windows.Forms.Padding(3)
        Me.tapbpage_personal_details.Size = New System.Drawing.Size(1278, 565)
        Me.tapbpage_personal_details.TabIndex = 0
        Me.tapbpage_personal_details.Text = "Basic Info"
        Me.tapbpage_personal_details.UseVisualStyleBackColor = True
        '
        'DGV_emp_info
        '
        Me.DGV_emp_info.AllowUserToAddRows = False
        Me.DGV_emp_info.AllowUserToOrderColumns = True
        Me.DGV_emp_info.AutoGenerateColumns = False
        Me.DGV_emp_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_emp_info.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_emp_info.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_emp_info.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpidDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.marital_status, Me.QualificationDataGridViewTextBoxColumn, Me.CurrexpDataGridViewTextBoxColumn, Me.StartdateDataGridViewTextBoxColumn, Me.MobDataGridViewTextBoxColumn, Me.email})
        Me.DGV_emp_info.DataSource = Me.Emp_basic_infoBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_emp_info.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_emp_info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_emp_info.Location = New System.Drawing.Point(3, 28)
        Me.DGV_emp_info.Name = "DGV_emp_info"
        Me.DGV_emp_info.ReadOnly = True
        Me.DGV_emp_info.RowHeadersVisible = False
        Me.DGV_emp_info.RowHeadersWidth = 35
        Me.DGV_emp_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_emp_info.Size = New System.Drawing.Size(1272, 534)
        Me.DGV_emp_info.TabIndex = 0
        '
        'EmpidDataGridViewTextBoxColumn
        '
        Me.EmpidDataGridViewTextBoxColumn.DataPropertyName = "emp_id"
        Me.EmpidDataGridViewTextBoxColumn.FillWeight = 70.0!
        Me.EmpidDataGridViewTextBoxColumn.HeaderText = "Emp ID"
        Me.EmpidDataGridViewTextBoxColumn.Name = "EmpidDataGridViewTextBoxColumn"
        Me.EmpidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        Me.DobDataGridViewTextBoxColumn.ReadOnly = True
        '
        'marital_status
        '
        Me.marital_status.DataPropertyName = "marital_status"
        Me.marital_status.HeaderText = "Marital Status"
        Me.marital_status.Name = "marital_status"
        Me.marital_status.ReadOnly = True
        '
        'QualificationDataGridViewTextBoxColumn
        '
        Me.QualificationDataGridViewTextBoxColumn.DataPropertyName = "qualification"
        Me.QualificationDataGridViewTextBoxColumn.HeaderText = "Qualification"
        Me.QualificationDataGridViewTextBoxColumn.Name = "QualificationDataGridViewTextBoxColumn"
        Me.QualificationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrexpDataGridViewTextBoxColumn
        '
        Me.CurrexpDataGridViewTextBoxColumn.DataPropertyName = "curr_exp"
        Me.CurrexpDataGridViewTextBoxColumn.HeaderText = "Experience"
        Me.CurrexpDataGridViewTextBoxColumn.Name = "CurrexpDataGridViewTextBoxColumn"
        Me.CurrexpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StartdateDataGridViewTextBoxColumn
        '
        Me.StartdateDataGridViewTextBoxColumn.DataPropertyName = "start_date"
        Me.StartdateDataGridViewTextBoxColumn.HeaderText = "Start Date"
        Me.StartdateDataGridViewTextBoxColumn.Name = "StartdateDataGridViewTextBoxColumn"
        Me.StartdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MobDataGridViewTextBoxColumn
        '
        Me.MobDataGridViewTextBoxColumn.DataPropertyName = "mob"
        Me.MobDataGridViewTextBoxColumn.HeaderText = "Mobile No."
        Me.MobDataGridViewTextBoxColumn.Name = "MobDataGridViewTextBoxColumn"
        Me.MobDataGridViewTextBoxColumn.ReadOnly = True
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'Emp_basic_infoBindingSource
        '
        Me.Emp_basic_infoBindingSource.DataMember = "Emp_basic_details"
        Me.Emp_basic_infoBindingSource.DataSource = Me.EmployeeManagementDataSet
        '
        'EmployeeManagementDataSet
        '
        Me.EmployeeManagementDataSet.DataSetName = "EmployeeManagementDataSet"
        Me.EmployeeManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigator_basicinfo
        '
        Me.BindingNavigator_basicinfo.AddNewItem = Nothing
        Me.BindingNavigator_basicinfo.BindingSource = Me.Emp_basic_infoBindingSource
        Me.BindingNavigator_basicinfo.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator_basicinfo.DeleteItem = Nothing
        Me.BindingNavigator_basicinfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator_basicinfo.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator_basicinfo.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator_basicinfo.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator_basicinfo.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator_basicinfo.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator_basicinfo.Name = "BindingNavigator_basicinfo"
        Me.BindingNavigator_basicinfo.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator_basicinfo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BindingNavigator_basicinfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BindingNavigator_basicinfo.Size = New System.Drawing.Size(1272, 25)
        Me.BindingNavigator_basicinfo.TabIndex = 1
        Me.BindingNavigator_basicinfo.Text = "BindingNavigator_basic_info"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tabpage_working_hist
        '
        Me.tabpage_working_hist.Controls.Add(Me.DGV_workhistory)
        Me.tabpage_working_hist.Controls.Add(Me.BindingNavigator_workhistory)
        Me.tabpage_working_hist.Location = New System.Drawing.Point(4, 29)
        Me.tabpage_working_hist.Name = "tabpage_working_hist"
        Me.tabpage_working_hist.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_working_hist.Size = New System.Drawing.Size(1278, 565)
        Me.tabpage_working_hist.TabIndex = 1
        Me.tabpage_working_hist.Text = "Working History"
        Me.tabpage_working_hist.UseVisualStyleBackColor = True
        '
        'DGV_workhistory
        '
        Me.DGV_workhistory.AllowUserToAddRows = False
        Me.DGV_workhistory.AllowUserToOrderColumns = True
        Me.DGV_workhistory.AutoGenerateColumns = False
        Me.DGV_workhistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_workhistory.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_workhistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_workhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_workhistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpidDataGridViewTextBoxColumn1, Me.comp_name, Me.emp_name, Me.p_start_date, Me.p_end_date, Me.post})
        Me.DGV_workhistory.DataSource = Me.WorkhistoryBindingSource
        Me.DGV_workhistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_workhistory.Location = New System.Drawing.Point(3, 28)
        Me.DGV_workhistory.Name = "DGV_workhistory"
        Me.DGV_workhistory.ReadOnly = True
        Me.DGV_workhistory.RowHeadersVisible = False
        Me.DGV_workhistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_workhistory.Size = New System.Drawing.Size(1272, 534)
        Me.DGV_workhistory.TabIndex = 0
        '
        'EmpidDataGridViewTextBoxColumn1
        '
        Me.EmpidDataGridViewTextBoxColumn1.DataPropertyName = "emp_id"
        Me.EmpidDataGridViewTextBoxColumn1.FillWeight = 35.0!
        Me.EmpidDataGridViewTextBoxColumn1.HeaderText = "Emp ID"
        Me.EmpidDataGridViewTextBoxColumn1.Name = "EmpidDataGridViewTextBoxColumn1"
        Me.EmpidDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'comp_name
        '
        Me.comp_name.DataPropertyName = "comp_name"
        Me.comp_name.HeaderText = "Company Name"
        Me.comp_name.Name = "comp_name"
        Me.comp_name.ReadOnly = True
        '
        'emp_name
        '
        Me.emp_name.DataPropertyName = "emp_name"
        Me.emp_name.HeaderText = "Employee Name"
        Me.emp_name.Name = "emp_name"
        Me.emp_name.ReadOnly = True
        '
        'p_start_date
        '
        Me.p_start_date.DataPropertyName = "p_start_date"
        Me.p_start_date.HeaderText = "Join Date"
        Me.p_start_date.Name = "p_start_date"
        Me.p_start_date.ReadOnly = True
        '
        'p_end_date
        '
        Me.p_end_date.DataPropertyName = "p_end_date"
        Me.p_end_date.HeaderText = "Leave Date"
        Me.p_end_date.Name = "p_end_date"
        Me.p_end_date.ReadOnly = True
        '
        'post
        '
        Me.post.DataPropertyName = "post"
        Me.post.HeaderText = "Designation"
        Me.post.Name = "post"
        Me.post.ReadOnly = True
        '
        'WorkhistoryBindingSource
        '
        Me.WorkhistoryBindingSource.DataMember = "Work_history"
        Me.WorkhistoryBindingSource.DataSource = Me.EmployeeManagementDataSet
        '
        'BindingNavigator_workhistory
        '
        Me.BindingNavigator_workhistory.AddNewItem = Nothing
        Me.BindingNavigator_workhistory.BindingSource = Me.WorkhistoryBindingSource
        Me.BindingNavigator_workhistory.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator_workhistory.DeleteItem = Nothing
        Me.BindingNavigator_workhistory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5})
        Me.BindingNavigator_workhistory.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator_workhistory.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator_workhistory.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator_workhistory.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator_workhistory.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator_workhistory.Name = "BindingNavigator_workhistory"
        Me.BindingNavigator_workhistory.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator_workhistory.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BindingNavigator_workhistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BindingNavigator_workhistory.Size = New System.Drawing.Size(1272, 25)
        Me.BindingNavigator_workhistory.TabIndex = 1
        Me.BindingNavigator_workhistory.Text = "BindingNavigator_workhistory"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(58, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tabpage_contact_person
        '
        Me.tabpage_contact_person.Controls.Add(Me.DGV_basic_info)
        Me.tabpage_contact_person.Controls.Add(Me.BindingNavigator_contactperson)
        Me.tabpage_contact_person.Location = New System.Drawing.Point(4, 29)
        Me.tabpage_contact_person.Name = "tabpage_contact_person"
        Me.tabpage_contact_person.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_contact_person.Size = New System.Drawing.Size(1278, 565)
        Me.tabpage_contact_person.TabIndex = 2
        Me.tabpage_contact_person.Text = "Contact Person"
        Me.tabpage_contact_person.UseVisualStyleBackColor = True
        '
        'DGV_basic_info
        '
        Me.DGV_basic_info.AllowUserToAddRows = False
        Me.DGV_basic_info.AllowUserToOrderColumns = True
        Me.DGV_basic_info.AutoGenerateColumns = False
        Me.DGV_basic_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_basic_info.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_basic_info.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_basic_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_basic_info.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpidDataGridViewTextBoxColumn3, Me.CfirstnameDataGridViewTextBoxColumn, Me.ClastnameDataGridViewTextBoxColumn, Me.CmobDataGridViewTextBoxColumn, Me.c_email, Me.CcityDataGridViewTextBoxColumn, Me.CaddressDataGridViewTextBoxColumn, Me.c_zipcode})
        Me.DGV_basic_info.DataSource = Me.ContactPersonBindingSource
        Me.DGV_basic_info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_basic_info.Location = New System.Drawing.Point(3, 28)
        Me.DGV_basic_info.Name = "DGV_basic_info"
        Me.DGV_basic_info.ReadOnly = True
        Me.DGV_basic_info.RowHeadersVisible = False
        Me.DGV_basic_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_basic_info.Size = New System.Drawing.Size(1272, 534)
        Me.DGV_basic_info.TabIndex = 3
        '
        'EmpidDataGridViewTextBoxColumn3
        '
        Me.EmpidDataGridViewTextBoxColumn3.DataPropertyName = "emp_id"
        Me.EmpidDataGridViewTextBoxColumn3.FillWeight = 40.0!
        Me.EmpidDataGridViewTextBoxColumn3.HeaderText = "Emp ID"
        Me.EmpidDataGridViewTextBoxColumn3.Name = "EmpidDataGridViewTextBoxColumn3"
        Me.EmpidDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'CfirstnameDataGridViewTextBoxColumn
        '
        Me.CfirstnameDataGridViewTextBoxColumn.DataPropertyName = "c_firstname"
        Me.CfirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.CfirstnameDataGridViewTextBoxColumn.Name = "CfirstnameDataGridViewTextBoxColumn"
        Me.CfirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClastnameDataGridViewTextBoxColumn
        '
        Me.ClastnameDataGridViewTextBoxColumn.DataPropertyName = "c_lastname"
        Me.ClastnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.ClastnameDataGridViewTextBoxColumn.Name = "ClastnameDataGridViewTextBoxColumn"
        Me.ClastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CmobDataGridViewTextBoxColumn
        '
        Me.CmobDataGridViewTextBoxColumn.DataPropertyName = "c_mob"
        Me.CmobDataGridViewTextBoxColumn.HeaderText = "Mobile"
        Me.CmobDataGridViewTextBoxColumn.Name = "CmobDataGridViewTextBoxColumn"
        Me.CmobDataGridViewTextBoxColumn.ReadOnly = True
        '
        'c_email
        '
        Me.c_email.DataPropertyName = "c_email"
        Me.c_email.HeaderText = "Email"
        Me.c_email.Name = "c_email"
        Me.c_email.ReadOnly = True
        '
        'CcityDataGridViewTextBoxColumn
        '
        Me.CcityDataGridViewTextBoxColumn.DataPropertyName = "c_city"
        Me.CcityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CcityDataGridViewTextBoxColumn.Name = "CcityDataGridViewTextBoxColumn"
        Me.CcityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CaddressDataGridViewTextBoxColumn
        '
        Me.CaddressDataGridViewTextBoxColumn.DataPropertyName = "c_address"
        Me.CaddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.CaddressDataGridViewTextBoxColumn.Name = "CaddressDataGridViewTextBoxColumn"
        Me.CaddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'c_zipcode
        '
        Me.c_zipcode.DataPropertyName = "c_zipcode"
        Me.c_zipcode.HeaderText = "Zipcode"
        Me.c_zipcode.Name = "c_zipcode"
        Me.c_zipcode.ReadOnly = True
        '
        'ContactPersonBindingSource
        '
        Me.ContactPersonBindingSource.DataMember = "Contact_person_info"
        Me.ContactPersonBindingSource.DataSource = Me.EmployeeManagementDataSet
        '
        'BindingNavigator_contactperson
        '
        Me.BindingNavigator_contactperson.AddNewItem = Nothing
        Me.BindingNavigator_contactperson.BindingSource = Me.ContactPersonBindingSource
        Me.BindingNavigator_contactperson.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator_contactperson.DeleteItem = Nothing
        Me.BindingNavigator_contactperson.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3})
        Me.BindingNavigator_contactperson.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator_contactperson.MoveFirstItem = Me.ToolStripButton3
        Me.BindingNavigator_contactperson.MoveLastItem = Me.ToolStripButton6
        Me.BindingNavigator_contactperson.MoveNextItem = Me.ToolStripButton5
        Me.BindingNavigator_contactperson.MovePreviousItem = Me.ToolStripButton4
        Me.BindingNavigator_contactperson.Name = "BindingNavigator_contactperson"
        Me.BindingNavigator_contactperson.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator_contactperson.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BindingNavigator_contactperson.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BindingNavigator_contactperson.Size = New System.Drawing.Size(1272, 25)
        Me.BindingNavigator_contactperson.TabIndex = 2
        Me.BindingNavigator_contactperson.Text = "BindingNavigator_contactperson"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(58, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tabpage_adm_leave
        '
        Me.tabpage_adm_leave.Controls.Add(Me.gb_emp_leave_list)
        Me.tabpage_adm_leave.Location = New System.Drawing.Point(4, 38)
        Me.tabpage_adm_leave.Name = "tabpage_adm_leave"
        Me.tabpage_adm_leave.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_adm_leave.Size = New System.Drawing.Size(1292, 650)
        Me.tabpage_adm_leave.TabIndex = 1
        Me.tabpage_adm_leave.Text = "Leave"
        Me.tabpage_adm_leave.UseVisualStyleBackColor = True
        '
        'gb_emp_leave_list
        '
        Me.gb_emp_leave_list.Controls.Add(Me.DGV_emp_leaves)
        Me.gb_emp_leave_list.Location = New System.Drawing.Point(135, 53)
        Me.gb_emp_leave_list.Name = "gb_emp_leave_list"
        Me.gb_emp_leave_list.Size = New System.Drawing.Size(849, 440)
        Me.gb_emp_leave_list.TabIndex = 0
        Me.gb_emp_leave_list.TabStop = False
        Me.gb_emp_leave_list.Text = "Employe Leaves List"
        '
        'DGV_emp_leaves
        '
        Me.DGV_emp_leaves.AllowUserToAddRows = False
        Me.DGV_emp_leaves.AllowUserToOrderColumns = True
        Me.DGV_emp_leaves.AutoGenerateColumns = False
        Me.DGV_emp_leaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_emp_leaves.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DGV_emp_leaves.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_emp_leaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_emp_leaves.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpidDataGridViewTextBoxColumn4, Me.EmpnameDataGridViewTextBoxColumn, Me.LeavedateDataGridViewTextBoxColumn, Me.NumOfDaysDataGridViewTextBoxColumn, Me.LeavereasonDataGridViewTextBoxColumn, Me.PaidleaveDataGridViewTextBoxColumn, Me.TotalleaveDataGridViewTextBoxColumn})
        Me.DGV_emp_leaves.DataSource = Me.EmpleavesBindingSource
        Me.DGV_emp_leaves.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_emp_leaves.Location = New System.Drawing.Point(3, 40)
        Me.DGV_emp_leaves.Name = "DGV_emp_leaves"
        Me.DGV_emp_leaves.ReadOnly = True
        Me.DGV_emp_leaves.RowHeadersVisible = False
        Me.DGV_emp_leaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_emp_leaves.Size = New System.Drawing.Size(843, 397)
        Me.DGV_emp_leaves.TabIndex = 0
        '
        'EmpidDataGridViewTextBoxColumn4
        '
        Me.EmpidDataGridViewTextBoxColumn4.DataPropertyName = "emp_id"
        Me.EmpidDataGridViewTextBoxColumn4.HeaderText = "Emp ID"
        Me.EmpidDataGridViewTextBoxColumn4.Name = "EmpidDataGridViewTextBoxColumn4"
        Me.EmpidDataGridViewTextBoxColumn4.ReadOnly = True
        '
        'EmpnameDataGridViewTextBoxColumn
        '
        Me.EmpnameDataGridViewTextBoxColumn.DataPropertyName = "emp_name"
        Me.EmpnameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.EmpnameDataGridViewTextBoxColumn.Name = "EmpnameDataGridViewTextBoxColumn"
        Me.EmpnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LeavedateDataGridViewTextBoxColumn
        '
        Me.LeavedateDataGridViewTextBoxColumn.DataPropertyName = "leave_date"
        Me.LeavedateDataGridViewTextBoxColumn.HeaderText = "Leave Date"
        Me.LeavedateDataGridViewTextBoxColumn.Name = "LeavedateDataGridViewTextBoxColumn"
        Me.LeavedateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumOfDaysDataGridViewTextBoxColumn
        '
        Me.NumOfDaysDataGridViewTextBoxColumn.DataPropertyName = "numOfDays"
        Me.NumOfDaysDataGridViewTextBoxColumn.HeaderText = "Days"
        Me.NumOfDaysDataGridViewTextBoxColumn.Name = "NumOfDaysDataGridViewTextBoxColumn"
        Me.NumOfDaysDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LeavereasonDataGridViewTextBoxColumn
        '
        Me.LeavereasonDataGridViewTextBoxColumn.DataPropertyName = "leave_reason"
        Me.LeavereasonDataGridViewTextBoxColumn.HeaderText = "Leave Reason"
        Me.LeavereasonDataGridViewTextBoxColumn.Name = "LeavereasonDataGridViewTextBoxColumn"
        Me.LeavereasonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaidleaveDataGridViewTextBoxColumn
        '
        Me.PaidleaveDataGridViewTextBoxColumn.DataPropertyName = "paid_leave"
        Me.PaidleaveDataGridViewTextBoxColumn.HeaderText = "Paid_Leave"
        Me.PaidleaveDataGridViewTextBoxColumn.Name = "PaidleaveDataGridViewTextBoxColumn"
        Me.PaidleaveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalleaveDataGridViewTextBoxColumn
        '
        Me.TotalleaveDataGridViewTextBoxColumn.DataPropertyName = "total_leave"
        Me.TotalleaveDataGridViewTextBoxColumn.HeaderText = "Total_Leave"
        Me.TotalleaveDataGridViewTextBoxColumn.Name = "TotalleaveDataGridViewTextBoxColumn"
        Me.TotalleaveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleavesBindingSource
        '
        Me.EmpleavesBindingSource.DataMember = "Emp_leaves"
        Me.EmpleavesBindingSource.DataSource = Me.EmployeeManagementDataSet
        '
        'tabpage_adm_sal
        '
        Me.tabpage_adm_sal.Controls.Add(Me.gb_salary)
        Me.tabpage_adm_sal.Location = New System.Drawing.Point(4, 38)
        Me.tabpage_adm_sal.Name = "tabpage_adm_sal"
        Me.tabpage_adm_sal.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_adm_sal.Size = New System.Drawing.Size(1292, 650)
        Me.tabpage_adm_sal.TabIndex = 2
        Me.tabpage_adm_sal.Text = "Salary"
        Me.tabpage_adm_sal.UseVisualStyleBackColor = True
        '
        'gb_salary
        '
        Me.gb_salary.Controls.Add(Me.tb_allow)
        Me.gb_salary.Controls.Add(Me.lbl_allowance)
        Me.gb_salary.Controls.Add(Me.btn_update_sal)
        Me.gb_salary.Controls.Add(Me.tb_sal_amt)
        Me.gb_salary.Controls.Add(Me.lbl_sal_amt)
        Me.gb_salary.Controls.Add(Me.tb_emp_id)
        Me.gb_salary.Controls.Add(Me.lbl_emp_id)
        Me.gb_salary.Controls.Add(Me.DGV_salary)
        Me.gb_salary.Location = New System.Drawing.Point(47, 58)
        Me.gb_salary.Name = "gb_salary"
        Me.gb_salary.Size = New System.Drawing.Size(1173, 437)
        Me.gb_salary.TabIndex = 1
        Me.gb_salary.TabStop = False
        Me.gb_salary.Text = "Salary Manager"
        '
        'tb_allow
        '
        Me.tb_allow.Location = New System.Drawing.Point(679, 38)
        Me.tb_allow.MaxLength = 4
        Me.tb_allow.Name = "tb_allow"
        Me.tb_allow.Size = New System.Drawing.Size(116, 23)
        Me.tb_allow.TabIndex = 7
        '
        'lbl_allowance
        '
        Me.lbl_allowance.AutoSize = True
        Me.lbl_allowance.Location = New System.Drawing.Point(607, 42)
        Me.lbl_allowance.Name = "lbl_allowance"
        Me.lbl_allowance.Size = New System.Drawing.Size(59, 15)
        Me.lbl_allowance.TabIndex = 6
        Me.lbl_allowance.Text = "Allowance"
        '
        'btn_update_sal
        '
        Me.btn_update_sal.Location = New System.Drawing.Point(821, 36)
        Me.btn_update_sal.Name = "btn_update_sal"
        Me.btn_update_sal.Size = New System.Drawing.Size(127, 27)
        Me.btn_update_sal.TabIndex = 5
        Me.btn_update_sal.Text = "Update Salary"
        Me.btn_update_sal.UseVisualStyleBackColor = True
        '
        'tb_sal_amt
        '
        Me.tb_sal_amt.Location = New System.Drawing.Point(465, 38)
        Me.tb_sal_amt.MaxLength = 6
        Me.tb_sal_amt.Name = "tb_sal_amt"
        Me.tb_sal_amt.Size = New System.Drawing.Size(116, 23)
        Me.tb_sal_amt.TabIndex = 4
        '
        'lbl_sal_amt
        '
        Me.lbl_sal_amt.AutoSize = True
        Me.lbl_sal_amt.Location = New System.Drawing.Point(371, 42)
        Me.lbl_sal_amt.Name = "lbl_sal_amt"
        Me.lbl_sal_amt.Size = New System.Drawing.Size(82, 15)
        Me.lbl_sal_amt.TabIndex = 3
        Me.lbl_sal_amt.Text = "Salary Amount"
        '
        'tb_emp_id
        '
        Me.tb_emp_id.Location = New System.Drawing.Point(232, 39)
        Me.tb_emp_id.MaxLength = 4
        Me.tb_emp_id.Name = "tb_emp_id"
        Me.tb_emp_id.Size = New System.Drawing.Size(116, 23)
        Me.tb_emp_id.TabIndex = 2
        '
        'lbl_emp_id
        '
        Me.lbl_emp_id.AutoSize = True
        Me.lbl_emp_id.Location = New System.Drawing.Point(176, 42)
        Me.lbl_emp_id.Name = "lbl_emp_id"
        Me.lbl_emp_id.Size = New System.Drawing.Size(45, 15)
        Me.lbl_emp_id.TabIndex = 1
        Me.lbl_emp_id.Text = "Emp ID"
        '
        'DGV_salary
        '
        Me.DGV_salary.AllowUserToAddRows = False
        Me.DGV_salary.AllowUserToDeleteRows = False
        Me.DGV_salary.AutoGenerateColumns = False
        Me.DGV_salary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_salary.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DGV_salary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_salary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpidDataGridViewTextBoxColumn5, Me.firstname, Me.lastname, Me.MonthlysalDataGridViewTextBoxColumn, Me.monthly_allowance, Me.MonthlytaxesDataGridViewTextBoxColumn, Me.MonthlyinsurancesDataGridViewTextBoxColumn})
        Me.DGV_salary.DataSource = Me.SalaryinformationBindingSource
        Me.DGV_salary.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_salary.Location = New System.Drawing.Point(3, 87)
        Me.DGV_salary.Name = "DGV_salary"
        Me.DGV_salary.ReadOnly = True
        Me.DGV_salary.RowHeadersVisible = False
        Me.DGV_salary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_salary.Size = New System.Drawing.Size(1167, 347)
        Me.DGV_salary.TabIndex = 0
        '
        'EmpidDataGridViewTextBoxColumn5
        '
        Me.EmpidDataGridViewTextBoxColumn5.DataPropertyName = "emp_id"
        Me.EmpidDataGridViewTextBoxColumn5.HeaderText = "Emp ID"
        Me.EmpidDataGridViewTextBoxColumn5.Name = "EmpidDataGridViewTextBoxColumn5"
        Me.EmpidDataGridViewTextBoxColumn5.ReadOnly = True
        '
        'firstname
        '
        Me.firstname.DataPropertyName = "firstname"
        Me.firstname.HeaderText = "Firstname"
        Me.firstname.Name = "firstname"
        Me.firstname.ReadOnly = True
        '
        'lastname
        '
        Me.lastname.DataPropertyName = "lastname"
        Me.lastname.HeaderText = "Lastname"
        Me.lastname.Name = "lastname"
        Me.lastname.ReadOnly = True
        '
        'MonthlysalDataGridViewTextBoxColumn
        '
        Me.MonthlysalDataGridViewTextBoxColumn.DataPropertyName = "monthly_sal"
        Me.MonthlysalDataGridViewTextBoxColumn.HeaderText = "Monthly Salary"
        Me.MonthlysalDataGridViewTextBoxColumn.Name = "MonthlysalDataGridViewTextBoxColumn"
        Me.MonthlysalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'monthly_allowance
        '
        Me.monthly_allowance.DataPropertyName = "monthly_allowance"
        Me.monthly_allowance.HeaderText = "Allowance"
        Me.monthly_allowance.Name = "monthly_allowance"
        Me.monthly_allowance.ReadOnly = True
        '
        'MonthlytaxesDataGridViewTextBoxColumn
        '
        Me.MonthlytaxesDataGridViewTextBoxColumn.DataPropertyName = "monthly_taxes"
        Me.MonthlytaxesDataGridViewTextBoxColumn.HeaderText = "Taxes"
        Me.MonthlytaxesDataGridViewTextBoxColumn.Name = "MonthlytaxesDataGridViewTextBoxColumn"
        Me.MonthlytaxesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MonthlyinsurancesDataGridViewTextBoxColumn
        '
        Me.MonthlyinsurancesDataGridViewTextBoxColumn.DataPropertyName = "monthly_insurances"
        Me.MonthlyinsurancesDataGridViewTextBoxColumn.HeaderText = "Insurance"
        Me.MonthlyinsurancesDataGridViewTextBoxColumn.Name = "MonthlyinsurancesDataGridViewTextBoxColumn"
        Me.MonthlyinsurancesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalaryinformationBindingSource
        '
        Me.SalaryinformationBindingSource.DataMember = "Salary_information"
        Me.SalaryinformationBindingSource.DataSource = Me.EmployeeManagementDataSetBindingSource
        '
        'EmployeeManagementDataSetBindingSource
        '
        Me.EmployeeManagementDataSetBindingSource.DataSource = Me.EmployeeManagementDataSet
        Me.EmployeeManagementDataSetBindingSource.Position = 0
        '
        'tabpage_adm_event_holidays
        '
        Me.tabpage_adm_event_holidays.Controls.Add(Me.gb_events)
        Me.tabpage_adm_event_holidays.Controls.Add(Me.gb_holidays)
        Me.tabpage_adm_event_holidays.Location = New System.Drawing.Point(4, 38)
        Me.tabpage_adm_event_holidays.Name = "tabpage_adm_event_holidays"
        Me.tabpage_adm_event_holidays.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_adm_event_holidays.Size = New System.Drawing.Size(1292, 650)
        Me.tabpage_adm_event_holidays.TabIndex = 3
        Me.tabpage_adm_event_holidays.Text = "Holidays & Events   "
        Me.tabpage_adm_event_holidays.UseVisualStyleBackColor = True
        '
        'gb_events
        '
        Me.gb_events.Controls.Add(Me.pnl_events)
        Me.gb_events.Controls.Add(Me.DGV_adm_events)
        Me.gb_events.Location = New System.Drawing.Point(6, 42)
        Me.gb_events.Name = "gb_events"
        Me.gb_events.Size = New System.Drawing.Size(600, 427)
        Me.gb_events.TabIndex = 4
        Me.gb_events.TabStop = False
        Me.gb_events.Text = "Upcoming Events"
        '
        'pnl_events
        '
        Me.pnl_events.Controls.Add(Me.btn_delete_event)
        Me.pnl_events.Controls.Add(Me.dtp_event_date)
        Me.pnl_events.Controls.Add(Me.lbl_event_date)
        Me.pnl_events.Controls.Add(Me.lbl_event_name)
        Me.pnl_events.Controls.Add(Me.tb_events)
        Me.pnl_events.Controls.Add(Me.btn_new_event)
        Me.pnl_events.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_events.Location = New System.Drawing.Point(3, 19)
        Me.pnl_events.Name = "pnl_events"
        Me.pnl_events.Size = New System.Drawing.Size(594, 57)
        Me.pnl_events.TabIndex = 1
        '
        'btn_delete_event
        '
        Me.btn_delete_event.Location = New System.Drawing.Point(500, 14)
        Me.btn_delete_event.Name = "btn_delete_event"
        Me.btn_delete_event.Size = New System.Drawing.Size(87, 27)
        Me.btn_delete_event.TabIndex = 11
        Me.btn_delete_event.Text = "Delete"
        Me.btn_delete_event.UseVisualStyleBackColor = True
        '
        'dtp_event_date
        '
        Me.dtp_event_date.CustomFormat = "dd/MM/yyyy"
        Me.dtp_event_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_event_date.Location = New System.Drawing.Point(258, 15)
        Me.dtp_event_date.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtp_event_date.MinDate = New Date(2017, 3, 27, 0, 0, 0, 0)
        Me.dtp_event_date.Name = "dtp_event_date"
        Me.dtp_event_date.ShowCheckBox = True
        Me.dtp_event_date.Size = New System.Drawing.Size(129, 23)
        Me.dtp_event_date.TabIndex = 6
        Me.dtp_event_date.Value = New Date(2017, 3, 27, 0, 0, 0, 0)
        '
        'lbl_event_date
        '
        Me.lbl_event_date.AutoSize = True
        Me.lbl_event_date.Location = New System.Drawing.Point(216, 18)
        Me.lbl_event_date.Name = "lbl_event_date"
        Me.lbl_event_date.Size = New System.Drawing.Size(31, 15)
        Me.lbl_event_date.TabIndex = 5
        Me.lbl_event_date.Text = "Date"
        '
        'lbl_event_name
        '
        Me.lbl_event_name.AutoSize = True
        Me.lbl_event_name.Location = New System.Drawing.Point(19, 18)
        Me.lbl_event_name.Name = "lbl_event_name"
        Me.lbl_event_name.Size = New System.Drawing.Size(36, 15)
        Me.lbl_event_name.TabIndex = 4
        Me.lbl_event_name.Text = "Name"
        '
        'tb_events
        '
        Me.tb_events.Location = New System.Drawing.Point(66, 15)
        Me.tb_events.MaxLength = 20
        Me.tb_events.Name = "tb_events"
        Me.tb_events.Size = New System.Drawing.Size(142, 23)
        Me.tb_events.TabIndex = 3
        '
        'btn_new_event
        '
        Me.btn_new_event.Font = New System.Drawing.Font("Corbel", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_event.Location = New System.Drawing.Point(402, 14)
        Me.btn_new_event.Name = "btn_new_event"
        Me.btn_new_event.Size = New System.Drawing.Size(91, 27)
        Me.btn_new_event.TabIndex = 2
        Me.btn_new_event.Text = "Add Event"
        Me.btn_new_event.UseVisualStyleBackColor = True
        '
        'DGV_adm_events
        '
        Me.DGV_adm_events.AllowUserToAddRows = False
        Me.DGV_adm_events.AutoGenerateColumns = False
        Me.DGV_adm_events.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_adm_events.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DGV_adm_events.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_adm_events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_adm_events.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EventnameDataGridViewTextBoxColumn, Me.EventdateDataGridViewTextBoxColumn})
        Me.DGV_adm_events.DataSource = Me.EventsBindingSource
        Me.DGV_adm_events.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_adm_events.Location = New System.Drawing.Point(3, 82)
        Me.DGV_adm_events.Name = "DGV_adm_events"
        Me.DGV_adm_events.ReadOnly = True
        Me.DGV_adm_events.RowHeadersVisible = False
        Me.DGV_adm_events.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_adm_events.Size = New System.Drawing.Size(594, 342)
        Me.DGV_adm_events.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 35.0!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.EventsBindingSource.DataSource = Me.EmployeeManagementDataSetBindingSource
        '
        'gb_holidays
        '
        Me.gb_holidays.Controls.Add(Me.pnl_holidays)
        Me.gb_holidays.Controls.Add(Me.DGV_adm_holidays)
        Me.gb_holidays.Location = New System.Drawing.Point(619, 42)
        Me.gb_holidays.Name = "gb_holidays"
        Me.gb_holidays.Size = New System.Drawing.Size(648, 427)
        Me.gb_holidays.TabIndex = 3
        Me.gb_holidays.TabStop = False
        Me.gb_holidays.Text = "Holidays"
        '
        'pnl_holidays
        '
        Me.pnl_holidays.Controls.Add(Me.btn_delete_holiday)
        Me.pnl_holidays.Controls.Add(Me.btn_add_holidays)
        Me.pnl_holidays.Controls.Add(Me.lbl_holiday_date)
        Me.pnl_holidays.Controls.Add(Me.lbl_holiday_name)
        Me.pnl_holidays.Controls.Add(Me.tb_holidayName)
        Me.pnl_holidays.Controls.Add(Me.dtp_holidayDate)
        Me.pnl_holidays.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_holidays.Location = New System.Drawing.Point(3, 19)
        Me.pnl_holidays.Name = "pnl_holidays"
        Me.pnl_holidays.Size = New System.Drawing.Size(642, 57)
        Me.pnl_holidays.TabIndex = 2
        '
        'btn_delete_holiday
        '
        Me.btn_delete_holiday.Location = New System.Drawing.Point(546, 15)
        Me.btn_delete_holiday.Name = "btn_delete_holiday"
        Me.btn_delete_holiday.Size = New System.Drawing.Size(87, 27)
        Me.btn_delete_holiday.TabIndex = 10
        Me.btn_delete_holiday.Text = "Delete"
        Me.btn_delete_holiday.UseVisualStyleBackColor = True
        '
        'btn_add_holidays
        '
        Me.btn_add_holidays.Font = New System.Drawing.Font("Corbel", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_holidays.Location = New System.Drawing.Point(433, 15)
        Me.btn_add_holidays.Name = "btn_add_holidays"
        Me.btn_add_holidays.Size = New System.Drawing.Size(101, 27)
        Me.btn_add_holidays.TabIndex = 9
        Me.btn_add_holidays.Text = "Add Holidays"
        Me.btn_add_holidays.UseVisualStyleBackColor = True
        '
        'lbl_holiday_date
        '
        Me.lbl_holiday_date.AutoSize = True
        Me.lbl_holiday_date.Location = New System.Drawing.Point(229, 21)
        Me.lbl_holiday_date.Name = "lbl_holiday_date"
        Me.lbl_holiday_date.Size = New System.Drawing.Size(31, 15)
        Me.lbl_holiday_date.TabIndex = 8
        Me.lbl_holiday_date.Text = "Date"
        '
        'lbl_holiday_name
        '
        Me.lbl_holiday_name.AutoSize = True
        Me.lbl_holiday_name.Location = New System.Drawing.Point(21, 20)
        Me.lbl_holiday_name.Name = "lbl_holiday_name"
        Me.lbl_holiday_name.Size = New System.Drawing.Size(36, 15)
        Me.lbl_holiday_name.TabIndex = 7
        Me.lbl_holiday_name.Text = "Name"
        '
        'tb_holidayName
        '
        Me.tb_holidayName.Location = New System.Drawing.Point(69, 16)
        Me.tb_holidayName.MaxLength = 20
        Me.tb_holidayName.Name = "tb_holidayName"
        Me.tb_holidayName.Size = New System.Drawing.Size(142, 23)
        Me.tb_holidayName.TabIndex = 6
        '
        'dtp_holidayDate
        '
        Me.dtp_holidayDate.Checked = False
        Me.dtp_holidayDate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_holidayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_holidayDate.Location = New System.Drawing.Point(271, 16)
        Me.dtp_holidayDate.MaxDate = New Date(1998, 12, 31, 0, 0, 0, 0)
        Me.dtp_holidayDate.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.dtp_holidayDate.Name = "dtp_holidayDate"
        Me.dtp_holidayDate.ShowCheckBox = True
        Me.dtp_holidayDate.Size = New System.Drawing.Size(129, 23)
        Me.dtp_holidayDate.TabIndex = 3
        Me.dtp_holidayDate.Value = New Date(1998, 12, 31, 0, 0, 0, 0)
        '
        'DGV_adm_holidays
        '
        Me.DGV_adm_holidays.AllowUserToAddRows = False
        Me.DGV_adm_holidays.AutoGenerateColumns = False
        Me.DGV_adm_holidays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_adm_holidays.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DGV_adm_holidays.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_adm_holidays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_adm_holidays.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn2, Me.HolidaydateDataGridViewTextBoxColumn1, Me.HolidaynameDataGridViewTextBoxColumn1})
        Me.DGV_adm_holidays.DataSource = Me.HolidayinfoBindingSource
        Me.DGV_adm_holidays.Location = New System.Drawing.Point(3, 82)
        Me.DGV_adm_holidays.Name = "DGV_adm_holidays"
        Me.DGV_adm_holidays.ReadOnly = True
        Me.DGV_adm_holidays.RowHeadersVisible = False
        Me.DGV_adm_holidays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_adm_holidays.Size = New System.Drawing.Size(651, 342)
        Me.DGV_adm_holidays.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn2
        '
        Me.IdDataGridViewTextBoxColumn2.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn2.FillWeight = 35.0!
        Me.IdDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn2.Name = "IdDataGridViewTextBoxColumn2"
        Me.IdDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'HolidaydateDataGridViewTextBoxColumn1
        '
        Me.HolidaydateDataGridViewTextBoxColumn1.DataPropertyName = "holiday_date"
        Me.HolidaydateDataGridViewTextBoxColumn1.HeaderText = "Holiday Date"
        Me.HolidaydateDataGridViewTextBoxColumn1.Name = "HolidaydateDataGridViewTextBoxColumn1"
        Me.HolidaydateDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'HolidaynameDataGridViewTextBoxColumn1
        '
        Me.HolidaynameDataGridViewTextBoxColumn1.DataPropertyName = "holiday_name"
        Me.HolidaynameDataGridViewTextBoxColumn1.HeaderText = "Holiday Name"
        Me.HolidaynameDataGridViewTextBoxColumn1.Name = "HolidaynameDataGridViewTextBoxColumn1"
        Me.HolidaynameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'HolidayinfoBindingSource
        '
        Me.HolidayinfoBindingSource.DataMember = "Holiday_info"
        Me.HolidayinfoBindingSource.DataSource = Me.EmployeeManagementDataSet
        '
        'Emp_basic_detailsTableAdapter
        '
        Me.Emp_basic_detailsTableAdapter.ClearBeforeFill = True
        '
        'Work_historyTableAdapter
        '
        Me.Work_historyTableAdapter.ClearBeforeFill = True
        '
        'Contact_person_infoTableAdapter
        '
        Me.Contact_person_infoTableAdapter.ClearBeforeFill = True
        '
        'Holiday_infoTableAdapter
        '
        Me.Holiday_infoTableAdapter.ClearBeforeFill = True
        '
        'Emp_leavesTableAdapter
        '
        Me.Emp_leavesTableAdapter.ClearBeforeFill = True
        '
        'EventsTableAdapter
        '
        Me.EventsTableAdapter.ClearBeforeFill = True
        '
        'Salary_informationTableAdapter
        '
        Me.Salary_informationTableAdapter.ClearBeforeFill = True
        '
        'frm_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1280, 633)
        Me.Controls.Add(Me.fly_parent)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Panel"
        Me.fly_parent.ResumeLayout(False)
        Me.pnl_header.ResumeLayout(False)
        Me.pnl_header.PerformLayout()
        Me.tabcontrol_adm_master.ResumeLayout(False)
        Me.tabpage_adm_emp.ResumeLayout(False)
        Me.pnl_buttond.ResumeLayout(False)
        Me.tabcontrol_adm_emp_child.ResumeLayout(False)
        Me.tapbpage_personal_details.ResumeLayout(False)
        Me.tapbpage_personal_details.PerformLayout()
        CType(Me.DGV_emp_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Emp_basic_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator_basicinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator_basicinfo.ResumeLayout(False)
        Me.BindingNavigator_basicinfo.PerformLayout()
        Me.tabpage_working_hist.ResumeLayout(False)
        Me.tabpage_working_hist.PerformLayout()
        CType(Me.DGV_workhistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkhistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator_workhistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator_workhistory.ResumeLayout(False)
        Me.BindingNavigator_workhistory.PerformLayout()
        Me.tabpage_contact_person.ResumeLayout(False)
        Me.tabpage_contact_person.PerformLayout()
        CType(Me.DGV_basic_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator_contactperson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator_contactperson.ResumeLayout(False)
        Me.BindingNavigator_contactperson.PerformLayout()
        Me.tabpage_adm_leave.ResumeLayout(False)
        Me.gb_emp_leave_list.ResumeLayout(False)
        CType(Me.DGV_emp_leaves, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleavesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpage_adm_sal.ResumeLayout(False)
        Me.gb_salary.ResumeLayout(False)
        Me.gb_salary.PerformLayout()
        CType(Me.DGV_salary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryinformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeManagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpage_adm_event_holidays.ResumeLayout(False)
        Me.gb_events.ResumeLayout(False)
        Me.pnl_events.ResumeLayout(False)
        Me.pnl_events.PerformLayout()
        CType(Me.DGV_adm_events, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_holidays.ResumeLayout(False)
        Me.pnl_holidays.ResumeLayout(False)
        Me.pnl_holidays.PerformLayout()
        CType(Me.DGV_adm_holidays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidayinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fly_parent As FlowLayoutPanel
    Friend WithEvents pnl_header As Panel
    Friend WithEvents tabcontrol_adm_master As TabControl
    Friend WithEvents tabpage_adm_emp As TabPage
    Friend WithEvents pnl_buttond As Panel
    Friend WithEvents btn_newperson As Button
    Friend WithEvents tabpage_adm_leave As TabPage
    Friend WithEvents tabpage_adm_sal As TabPage
    Friend WithEvents tabpage_adm_event_holidays As TabPage
    Friend WithEvents lbl_login As Label
    Friend WithEvents llbl_logout As LinkLabel
    Friend WithEvents lbl_loginuser As Label
    Friend WithEvents Emp_basic_infoBindingSource As BindingSource
    Friend WithEvents EmployeeManagementDataSet As EmployeeManagementDataSet
    Friend WithEvents Emp_basic_detailsTableAdapter As EmployeeManagementDataSetTableAdapters.Emp_basic_detailsTableAdapter
    Friend WithEvents Work_historyTableAdapter As EmployeeManagementDataSetTableAdapters.Work_historyTableAdapter
    Friend WithEvents WorkhistoryBindingSource As BindingSource
    Friend WithEvents ContactPersonBindingSource As BindingSource
    Friend WithEvents Contact_person_infoTableAdapter As EmployeeManagementDataSetTableAdapters.Contact_person_infoTableAdapter
    Friend WithEvents HolidayinfoBindingSource As BindingSource
    Friend WithEvents Holiday_infoTableAdapter As EmployeeManagementDataSetTableAdapters.Holiday_infoTableAdapter
    Friend WithEvents EmpidDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents HolidayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HfromdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HenddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents gb_emp_leave_list As GroupBox
    Friend WithEvents DGV_emp_leaves As DataGridView
    Friend WithEvents EmpleavesBindingSource As BindingSource
    Friend WithEvents Emp_leavesTableAdapter As EmployeeManagementDataSetTableAdapters.Emp_leavesTableAdapter
    Friend WithEvents gb_events As GroupBox
    Friend WithEvents DGV_adm_events As DataGridView
    Friend WithEvents gb_holidays As GroupBox
    Friend WithEvents DGV_adm_holidays As DataGridView
    Friend WithEvents pnl_events As Panel
    Friend WithEvents pnl_holidays As Panel
    Friend WithEvents btn_new_event As Button
    Friend WithEvents lbl_event_date As Label
    Friend WithEvents lbl_event_name As Label
    Friend WithEvents tb_events As TextBox
    Friend WithEvents dtp_event_date As DateTimePicker
    Friend WithEvents lbl_holiday_date As Label
    Friend WithEvents lbl_holiday_name As Label
    Friend WithEvents tb_holidayName As TextBox
    Friend WithEvents dtp_holidayDate As DateTimePicker
    Friend WithEvents btn_add_holidays As Button
    Friend WithEvents EmployeeManagementDataSetBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents EventsBindingSource As BindingSource
    Friend WithEvents EventsTableAdapter As EmployeeManagementDataSetTableAdapters.EventsTableAdapter
    Friend WithEvents tabcontrol_adm_emp_child As TabControl
    Friend WithEvents tapbpage_personal_details As TabPage
    Friend WithEvents DGV_emp_info As DataGridView
    Friend WithEvents BindingNavigator_basicinfo As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents tabpage_working_hist As TabPage
    Friend WithEvents DGV_workhistory As DataGridView
    Friend WithEvents BindingNavigator_workhistory As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents tabpage_contact_person As TabPage
    Friend WithEvents DGV_basic_info As DataGridView
    Friend WithEvents BindingNavigator_contactperson As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ExtraleaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeavesleftDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_update As Button
    Friend WithEvents MarriedstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpidDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents EmpnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeavedateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumOfDaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeavereasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaidleaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalleaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EventnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EventdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents HolidaydateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents HolidaynameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmpidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents comp_name As DataGridViewTextBoxColumn
    Friend WithEvents emp_name As DataGridViewTextBoxColumn
    Friend WithEvents p_start_date As DataGridViewTextBoxColumn
    Friend WithEvents p_end_date As DataGridViewTextBoxColumn
    Friend WithEvents post As DataGridViewTextBoxColumn
    Friend WithEvents gb_salary As GroupBox
    Friend WithEvents DGV_salary As DataGridView
    Friend WithEvents SalaryinformationBindingSource As BindingSource
    Friend WithEvents Salary_informationTableAdapter As EmployeeManagementDataSetTableAdapters.Salary_informationTableAdapter
    Friend WithEvents btn_update_sal As Button
    Friend WithEvents tb_sal_amt As TextBox
    Friend WithEvents lbl_sal_amt As Label
    Friend WithEvents tb_emp_id As TextBox
    Friend WithEvents lbl_emp_id As Label
    Friend WithEvents EmpidDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CfirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CmobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents c_email As DataGridViewTextBoxColumn
    Friend WithEvents CcityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents c_zipcode As DataGridViewTextBoxColumn
    Friend WithEvents btn_delete As Button
    Friend WithEvents tb_allow As TextBox
    Friend WithEvents lbl_allowance As Label
    Friend WithEvents EmpidDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents lastname As DataGridViewTextBoxColumn
    Friend WithEvents MonthlysalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents monthly_allowance As DataGridViewTextBoxColumn
    Friend WithEvents MonthlytaxesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthlyinsurancesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents marital_status As DataGridViewTextBoxColumn
    Friend WithEvents QualificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrexpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents btn_delete_event As Button
    Friend WithEvents btn_delete_holiday As Button
End Class
