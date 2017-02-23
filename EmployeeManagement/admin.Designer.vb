<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin
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
        Me.fly_parent = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnl_header = New System.Windows.Forms.Panel()
        Me.lbl_loginuser = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.llbl_logout = New System.Windows.Forms.LinkLabel()
        Me.tabcontrol_adm_master = New System.Windows.Forms.TabControl()
        Me.tabpage_adm_emp = New System.Windows.Forms.TabPage()
        Me.pnl_buttond = New System.Windows.Forms.Panel()
        Me.btn_new_event = New System.Windows.Forms.Button()
        Me.btn_newperson = New System.Windows.Forms.Button()
        Me.tabcontrol_adm_emp_child = New System.Windows.Forms.TabControl()
        Me.tapbpage_personal_details = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tabpage_working_hist = New System.Windows.Forms.TabPage()
        Me.tabpage_contact_person = New System.Windows.Forms.TabPage()
        Me.tabpage_woking_time_details = New System.Windows.Forms.TabPage()
        Me.tabpage_salary = New System.Windows.Forms.TabPage()
        Me.tabpage_holidays = New System.Windows.Forms.TabPage()
        Me.tabpage_adm_leave = New System.Windows.Forms.TabPage()
        Me.tabpage_adm_sal = New System.Windows.Forms.TabPage()
        Me.tabpage_adm_event = New System.Windows.Forms.TabPage()
        Me.fly_parent.SuspendLayout()
        Me.pnl_header.SuspendLayout()
        Me.tabcontrol_adm_master.SuspendLayout()
        Me.tabpage_adm_emp.SuspendLayout()
        Me.pnl_buttond.SuspendLayout()
        Me.tabcontrol_adm_emp_child.SuspendLayout()
        Me.tapbpage_personal_details.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.fly_parent.Size = New System.Drawing.Size(1279, 532)
        Me.fly_parent.TabIndex = 0
        '
        'pnl_header
        '
        Me.pnl_header.Controls.Add(Me.lbl_loginuser)
        Me.pnl_header.Controls.Add(Me.lbl_login)
        Me.pnl_header.Controls.Add(Me.llbl_logout)
        Me.pnl_header.Location = New System.Drawing.Point(3, 3)
        Me.pnl_header.Name = "pnl_header"
        Me.pnl_header.Size = New System.Drawing.Size(1299, 34)
        Me.pnl_header.TabIndex = 0
        '
        'lbl_loginuser
        '
        Me.lbl_loginuser.AutoSize = True
        Me.lbl_loginuser.Location = New System.Drawing.Point(88, 6)
        Me.lbl_loginuser.Name = "lbl_loginuser"
        Me.lbl_loginuser.Size = New System.Drawing.Size(0, 13)
        Me.lbl_loginuser.TabIndex = 5
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Location = New System.Drawing.Point(29, 6)
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
        'tabcontrol_adm_master
        '
        Me.tabcontrol_adm_master.Controls.Add(Me.tabpage_adm_emp)
        Me.tabcontrol_adm_master.Controls.Add(Me.tabpage_adm_leave)
        Me.tabcontrol_adm_master.Controls.Add(Me.tabpage_adm_sal)
        Me.tabcontrol_adm_master.Controls.Add(Me.tabpage_adm_event)
        Me.tabcontrol_adm_master.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabcontrol_adm_master.Location = New System.Drawing.Point(3, 43)
        Me.tabcontrol_adm_master.Name = "tabcontrol_adm_master"
        Me.tabcontrol_adm_master.Padding = New System.Drawing.Point(10, 10)
        Me.tabcontrol_adm_master.SelectedIndex = 0
        Me.tabcontrol_adm_master.Size = New System.Drawing.Size(1280, 490)
        Me.tabcontrol_adm_master.TabIndex = 4
        '
        'tabpage_adm_emp
        '
        Me.tabpage_adm_emp.Controls.Add(Me.pnl_buttond)
        Me.tabpage_adm_emp.Controls.Add(Me.tabcontrol_adm_emp_child)
        Me.tabpage_adm_emp.Location = New System.Drawing.Point(4, 36)
        Me.tabpage_adm_emp.Name = "tabpage_adm_emp"
        Me.tabpage_adm_emp.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_adm_emp.Size = New System.Drawing.Size(1272, 450)
        Me.tabpage_adm_emp.TabIndex = 0
        Me.tabpage_adm_emp.Text = "Employees"
        Me.tabpage_adm_emp.UseVisualStyleBackColor = True
        '
        'pnl_buttond
        '
        Me.pnl_buttond.Controls.Add(Me.btn_new_event)
        Me.pnl_buttond.Controls.Add(Me.btn_newperson)
        Me.pnl_buttond.Location = New System.Drawing.Point(3, 3)
        Me.pnl_buttond.Name = "pnl_buttond"
        Me.pnl_buttond.Size = New System.Drawing.Size(1266, 32)
        Me.pnl_buttond.TabIndex = 3
        '
        'btn_new_event
        '
        Me.btn_new_event.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_event.Location = New System.Drawing.Point(139, 4)
        Me.btn_new_event.Name = "btn_new_event"
        Me.btn_new_event.Size = New System.Drawing.Size(107, 23)
        Me.btn_new_event.TabIndex = 1
        Me.btn_new_event.Text = "New Events"
        Me.btn_new_event.UseVisualStyleBackColor = True
        '
        'btn_newperson
        '
        Me.btn_newperson.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_newperson.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newperson.Location = New System.Drawing.Point(25, 4)
        Me.btn_newperson.Name = "btn_newperson"
        Me.btn_newperson.Size = New System.Drawing.Size(96, 23)
        Me.btn_newperson.TabIndex = 0
        Me.btn_newperson.Text = " New Person"
        Me.btn_newperson.UseVisualStyleBackColor = True
        '
        'tabcontrol_adm_emp_child
        '
        Me.tabcontrol_adm_emp_child.Controls.Add(Me.tapbpage_personal_details)
        Me.tabcontrol_adm_emp_child.Controls.Add(Me.tabpage_working_hist)
        Me.tabcontrol_adm_emp_child.Controls.Add(Me.tabpage_contact_person)
        Me.tabcontrol_adm_emp_child.Controls.Add(Me.tabpage_woking_time_details)
        Me.tabcontrol_adm_emp_child.Controls.Add(Me.tabpage_salary)
        Me.tabcontrol_adm_emp_child.Controls.Add(Me.tabpage_holidays)
        Me.tabcontrol_adm_emp_child.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabcontrol_adm_emp_child.ItemSize = New System.Drawing.Size(90, 25)
        Me.tabcontrol_adm_emp_child.Location = New System.Drawing.Point(3, 41)
        Me.tabcontrol_adm_emp_child.Name = "tabcontrol_adm_emp_child"
        Me.tabcontrol_adm_emp_child.Padding = New System.Drawing.Point(8, 3)
        Me.tabcontrol_adm_emp_child.SelectedIndex = 0
        Me.tabcontrol_adm_emp_child.Size = New System.Drawing.Size(1266, 406)
        Me.tabcontrol_adm_emp_child.TabIndex = 2
        '
        'tapbpage_personal_details
        '
        Me.tapbpage_personal_details.Controls.Add(Me.DataGridView1)
        Me.tapbpage_personal_details.Location = New System.Drawing.Point(4, 29)
        Me.tapbpage_personal_details.Name = "tapbpage_personal_details"
        Me.tapbpage_personal_details.Padding = New System.Windows.Forms.Padding(3)
        Me.tapbpage_personal_details.Size = New System.Drawing.Size(1258, 373)
        Me.tapbpage_personal_details.TabIndex = 0
        Me.tapbpage_personal_details.Text = "Basic Info"
        Me.tapbpage_personal_details.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1210, 320)
        Me.DataGridView1.TabIndex = 0
        '
        'tabpage_working_hist
        '
        Me.tabpage_working_hist.Location = New System.Drawing.Point(4, 29)
        Me.tabpage_working_hist.Name = "tabpage_working_hist"
        Me.tabpage_working_hist.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_working_hist.Size = New System.Drawing.Size(1258, 373)
        Me.tabpage_working_hist.TabIndex = 1
        Me.tabpage_working_hist.Text = "Working History"
        Me.tabpage_working_hist.UseVisualStyleBackColor = True
        '
        'tabpage_contact_person
        '
        Me.tabpage_contact_person.Location = New System.Drawing.Point(4, 29)
        Me.tabpage_contact_person.Name = "tabpage_contact_person"
        Me.tabpage_contact_person.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_contact_person.Size = New System.Drawing.Size(1258, 373)
        Me.tabpage_contact_person.TabIndex = 2
        Me.tabpage_contact_person.Text = "Contact Person"
        Me.tabpage_contact_person.UseVisualStyleBackColor = True
        '
        'tabpage_woking_time_details
        '
        Me.tabpage_woking_time_details.Location = New System.Drawing.Point(4, 29)
        Me.tabpage_woking_time_details.Name = "tabpage_woking_time_details"
        Me.tabpage_woking_time_details.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_woking_time_details.Size = New System.Drawing.Size(1258, 373)
        Me.tabpage_woking_time_details.TabIndex = 3
        Me.tabpage_woking_time_details.Text = "Working Time Details"
        Me.tabpage_woking_time_details.UseVisualStyleBackColor = True
        '
        'tabpage_salary
        '
        Me.tabpage_salary.Location = New System.Drawing.Point(4, 29)
        Me.tabpage_salary.Name = "tabpage_salary"
        Me.tabpage_salary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_salary.Size = New System.Drawing.Size(1258, 373)
        Me.tabpage_salary.TabIndex = 4
        Me.tabpage_salary.Text = "Salary & Taxes"
        Me.tabpage_salary.UseVisualStyleBackColor = True
        '
        'tabpage_holidays
        '
        Me.tabpage_holidays.Location = New System.Drawing.Point(4, 29)
        Me.tabpage_holidays.Name = "tabpage_holidays"
        Me.tabpage_holidays.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_holidays.Size = New System.Drawing.Size(1258, 373)
        Me.tabpage_holidays.TabIndex = 5
        Me.tabpage_holidays.Text = "Holidays Details"
        Me.tabpage_holidays.UseVisualStyleBackColor = True
        '
        'tabpage_adm_leave
        '
        Me.tabpage_adm_leave.Location = New System.Drawing.Point(4, 36)
        Me.tabpage_adm_leave.Name = "tabpage_adm_leave"
        Me.tabpage_adm_leave.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_adm_leave.Size = New System.Drawing.Size(1272, 450)
        Me.tabpage_adm_leave.TabIndex = 1
        Me.tabpage_adm_leave.Text = "Leave"
        Me.tabpage_adm_leave.UseVisualStyleBackColor = True
        '
        'tabpage_adm_sal
        '
        Me.tabpage_adm_sal.Location = New System.Drawing.Point(4, 36)
        Me.tabpage_adm_sal.Name = "tabpage_adm_sal"
        Me.tabpage_adm_sal.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_adm_sal.Size = New System.Drawing.Size(1272, 450)
        Me.tabpage_adm_sal.TabIndex = 2
        Me.tabpage_adm_sal.Text = "Salary"
        Me.tabpage_adm_sal.UseVisualStyleBackColor = True
        '
        'tabpage_adm_event
        '
        Me.tabpage_adm_event.Location = New System.Drawing.Point(4, 36)
        Me.tabpage_adm_event.Name = "tabpage_adm_event"
        Me.tabpage_adm_event.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_adm_event.Size = New System.Drawing.Size(1272, 450)
        Me.tabpage_adm_event.TabIndex = 3
        Me.tabpage_adm_event.Text = "Events"
        Me.tabpage_adm_event.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 532)
        Me.Controls.Add(Me.fly_parent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin"
        Me.fly_parent.ResumeLayout(False)
        Me.pnl_header.ResumeLayout(False)
        Me.pnl_header.PerformLayout()
        Me.tabcontrol_adm_master.ResumeLayout(False)
        Me.tabpage_adm_emp.ResumeLayout(False)
        Me.pnl_buttond.ResumeLayout(False)
        Me.tabcontrol_adm_emp_child.ResumeLayout(False)
        Me.tapbpage_personal_details.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fly_parent As FlowLayoutPanel
    Friend WithEvents pnl_header As Panel
    Friend WithEvents tabcontrol_adm_master As TabControl
    Friend WithEvents tabpage_adm_emp As TabPage
    Friend WithEvents pnl_buttond As Panel
    Friend WithEvents btn_new_event As Button
    Friend WithEvents btn_newperson As Button
    Friend WithEvents tabcontrol_adm_emp_child As TabControl
    Friend WithEvents tabpage_working_hist As TabPage
    Friend WithEvents tabpage_contact_person As TabPage
    Friend WithEvents tabpage_woking_time_details As TabPage
    Friend WithEvents tabpage_salary As TabPage
    Friend WithEvents tabpage_holidays As TabPage
    Friend WithEvents tabpage_adm_leave As TabPage
    Friend WithEvents tabpage_adm_sal As TabPage
    Friend WithEvents tabpage_adm_event As TabPage
    Friend WithEvents lbl_login As Label
    Friend WithEvents llbl_logout As LinkLabel
    Friend WithEvents lbl_loginuser As Label
    Friend WithEvents tapbpage_personal_details As TabPage
    Friend WithEvents DataGridView1 As DataGridView
End Class
