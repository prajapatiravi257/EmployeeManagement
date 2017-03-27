<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dialog_add_person
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
        Me.tbl_button = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lbl_Fullname = New System.Windows.Forms.Label()
        Me.lbl_dob = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.tb_firstname = New System.Windows.Forms.TextBox()
        Me.tb_lastname = New System.Windows.Forms.TextBox()
        Me.tb_email = New System.Windows.Forms.TextBox()
        Me.dtp_dob = New System.Windows.Forms.DateTimePicker()
        Me.gb_basic_info = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rb_single = New System.Windows.Forms.RadioButton()
        Me.rb_married = New System.Windows.Forms.RadioButton()
        Me.lbl_married_status = New System.Windows.Forms.Label()
        Me.cb_addLoginUser = New System.Windows.Forms.CheckBox()
        Me.tb_exp = New System.Windows.Forms.TextBox()
        Me.panel_gen = New System.Windows.Forms.Panel()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.rb_male = New System.Windows.Forms.RadioButton()
        Me.rb_female = New System.Windows.Forms.RadioButton()
        Me.lbl_exp = New System.Windows.Forms.Label()
        Me.tb_qual = New System.Windows.Forms.TextBox()
        Me.lbl_qual = New System.Windows.Forms.Label()
        Me.tb_zip = New System.Windows.Forms.TextBox()
        Me.lbl_zip = New System.Windows.Forms.Label()
        Me.tb_add = New System.Windows.Forms.TextBox()
        Me.lbl_add = New System.Windows.Forms.Label()
        Me.tb_city = New System.Windows.Forms.TextBox()
        Me.lbl_city = New System.Windows.Forms.Label()
        Me.tb_mob = New System.Windows.Forms.TextBox()
        Me.lbl_mob = New System.Windows.Forms.Label()
        Me.lbl_note = New System.Windows.Forms.Label()
        Me.gb_workHistory = New System.Windows.Forms.GroupBox()
        Me.tb_post = New System.Windows.Forms.TextBox()
        Me.lbl_post = New System.Windows.Forms.Label()
        Me.lbl_left_date = New System.Windows.Forms.Label()
        Me.dtp_join_date = New System.Windows.Forms.DateTimePicker()
        Me.dtp_left_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_start_date = New System.Windows.Forms.Label()
        Me.tb_comp_name = New System.Windows.Forms.TextBox()
        Me.lbl_comp_name = New System.Windows.Forms.Label()
        Me.gb_sal_info = New System.Windows.Forms.GroupBox()
        Me.tb_allow = New System.Windows.Forms.TextBox()
        Me.lbl_sal_insure_yearly = New System.Windows.Forms.Label()
        Me.lbl_sal_percent = New System.Windows.Forms.Label()
        Me.lbl_allow = New System.Windows.Forms.Label()
        Me.tb_insure = New System.Windows.Forms.TextBox()
        Me.lbl_insure = New System.Windows.Forms.Label()
        Me.tb_taxes = New System.Windows.Forms.TextBox()
        Me.lbl_taxes = New System.Windows.Forms.Label()
        Me.tb_sal = New System.Windows.Forms.TextBox()
        Me.lbl_sal = New System.Windows.Forms.Label()
        Me.tbl_button.SuspendLayout()
        Me.gb_basic_info.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panel_gen.SuspendLayout()
        Me.gb_workHistory.SuspendLayout()
        Me.gb_sal_info.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_button
        '
        Me.tbl_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbl_button.ColumnCount = 2
        Me.tbl_button.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tbl_button.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tbl_button.Controls.Add(Me.btn_save, 0, 0)
        Me.tbl_button.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.tbl_button.Location = New System.Drawing.Point(541, 388)
        Me.tbl_button.Name = "tbl_button"
        Me.tbl_button.RowCount = 1
        Me.tbl_button.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tbl_button.Size = New System.Drawing.Size(146, 29)
        Me.tbl_button.TabIndex = 0
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.Location = New System.Drawing.Point(3, 3)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(67, 23)
        Me.btn_save.TabIndex = 19
        Me.btn_save.Text = "Save"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 20
        Me.Cancel_Button.Text = "Cancel"
        '
        'lbl_Fullname
        '
        Me.lbl_Fullname.AutoSize = True
        Me.lbl_Fullname.Location = New System.Drawing.Point(7, 20)
        Me.lbl_Fullname.Name = "lbl_Fullname"
        Me.lbl_Fullname.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Fullname.TabIndex = 0
        Me.lbl_Fullname.Text = "Full Name"
        '
        'lbl_dob
        '
        Me.lbl_dob.AutoSize = True
        Me.lbl_dob.Location = New System.Drawing.Point(7, 51)
        Me.lbl_dob.Name = "lbl_dob"
        Me.lbl_dob.Size = New System.Drawing.Size(65, 13)
        Me.lbl_dob.TabIndex = 2
        Me.lbl_dob.Text = "Date of birth"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(7, 82)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(46, 13)
        Me.lbl_email.TabIndex = 4
        Me.lbl_email.Text = "Email ID"
        '
        'tb_firstname
        '
        Me.tb_firstname.Location = New System.Drawing.Point(93, 13)
        Me.tb_firstname.MaxLength = 30
        Me.tb_firstname.Name = "tb_firstname"
        Me.tb_firstname.Size = New System.Drawing.Size(122, 20)
        Me.tb_firstname.TabIndex = 0
        '
        'tb_lastname
        '
        Me.tb_lastname.Location = New System.Drawing.Point(233, 13)
        Me.tb_lastname.MaxLength = 30
        Me.tb_lastname.Name = "tb_lastname"
        Me.tb_lastname.Size = New System.Drawing.Size(132, 20)
        Me.tb_lastname.TabIndex = 1
        '
        'tb_email
        '
        Me.tb_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tb_email.Location = New System.Drawing.Point(93, 79)
        Me.tb_email.MaxLength = 60
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(272, 20)
        Me.tb_email.TabIndex = 5
        '
        'dtp_dob
        '
        Me.dtp_dob.Checked = False
        Me.dtp_dob.CustomFormat = "dd/MM/yyyy"
        Me.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_dob.Location = New System.Drawing.Point(93, 48)
        Me.dtp_dob.MaxDate = New Date(1998, 12, 31, 0, 0, 0, 0)
        Me.dtp_dob.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.dtp_dob.Name = "dtp_dob"
        Me.dtp_dob.ShowCheckBox = True
        Me.dtp_dob.Size = New System.Drawing.Size(111, 20)
        Me.dtp_dob.TabIndex = 2
        Me.dtp_dob.Value = New Date(1998, 12, 31, 0, 0, 0, 0)
        '
        'gb_basic_info
        '
        Me.gb_basic_info.Controls.Add(Me.Panel1)
        Me.gb_basic_info.Controls.Add(Me.cb_addLoginUser)
        Me.gb_basic_info.Controls.Add(Me.tb_exp)
        Me.gb_basic_info.Controls.Add(Me.panel_gen)
        Me.gb_basic_info.Controls.Add(Me.lbl_exp)
        Me.gb_basic_info.Controls.Add(Me.tb_qual)
        Me.gb_basic_info.Controls.Add(Me.lbl_qual)
        Me.gb_basic_info.Controls.Add(Me.tb_zip)
        Me.gb_basic_info.Controls.Add(Me.lbl_zip)
        Me.gb_basic_info.Controls.Add(Me.tb_add)
        Me.gb_basic_info.Controls.Add(Me.lbl_add)
        Me.gb_basic_info.Controls.Add(Me.tb_city)
        Me.gb_basic_info.Controls.Add(Me.lbl_city)
        Me.gb_basic_info.Controls.Add(Me.tb_mob)
        Me.gb_basic_info.Controls.Add(Me.lbl_mob)
        Me.gb_basic_info.Controls.Add(Me.dtp_dob)
        Me.gb_basic_info.Controls.Add(Me.tb_email)
        Me.gb_basic_info.Controls.Add(Me.tb_lastname)
        Me.gb_basic_info.Controls.Add(Me.tb_firstname)
        Me.gb_basic_info.Controls.Add(Me.lbl_email)
        Me.gb_basic_info.Controls.Add(Me.lbl_dob)
        Me.gb_basic_info.Controls.Add(Me.lbl_Fullname)
        Me.gb_basic_info.Location = New System.Drawing.Point(12, 12)
        Me.gb_basic_info.Name = "gb_basic_info"
        Me.gb_basic_info.Size = New System.Drawing.Size(675, 195)
        Me.gb_basic_info.TabIndex = 1
        Me.gb_basic_info.TabStop = False
        Me.gb_basic_info.Text = "Basic Info"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rb_single)
        Me.Panel1.Controls.Add(Me.rb_married)
        Me.Panel1.Controls.Add(Me.lbl_married_status)
        Me.Panel1.Location = New System.Drawing.Point(401, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 31)
        Me.Panel1.TabIndex = 31
        '
        'rb_single
        '
        Me.rb_single.AutoSize = True
        Me.rb_single.Location = New System.Drawing.Point(162, 7)
        Me.rb_single.Name = "rb_single"
        Me.rb_single.Size = New System.Drawing.Size(54, 17)
        Me.rb_single.TabIndex = 35
        Me.rb_single.Text = "Single"
        Me.rb_single.UseVisualStyleBackColor = True
        '
        'rb_married
        '
        Me.rb_married.AutoSize = True
        Me.rb_married.Checked = True
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
        Me.lbl_married_status.Location = New System.Drawing.Point(4, 9)
        Me.lbl_married_status.Name = "lbl_married_status"
        Me.lbl_married_status.Size = New System.Drawing.Size(71, 13)
        Me.lbl_married_status.TabIndex = 33
        Me.lbl_married_status.Text = "Marital Status"
        '
        'cb_addLoginUser
        '
        Me.cb_addLoginUser.AutoSize = True
        Me.cb_addLoginUser.Location = New System.Drawing.Point(408, 144)
        Me.cb_addLoginUser.Name = "cb_addLoginUser"
        Me.cb_addLoginUser.Size = New System.Drawing.Size(234, 17)
        Me.cb_addLoginUser.TabIndex = 30
        Me.cb_addLoginUser.Text = "Check this to give employee the login acces"
        Me.cb_addLoginUser.UseVisualStyleBackColor = True
        '
        'tb_exp
        '
        Me.tb_exp.Location = New System.Drawing.Point(488, 113)
        Me.tb_exp.MaxLength = 2
        Me.tb_exp.Name = "tb_exp"
        Me.tb_exp.Size = New System.Drawing.Size(51, 20)
        Me.tb_exp.TabIndex = 12
        '
        'panel_gen
        '
        Me.panel_gen.Controls.Add(Me.lbl_gender)
        Me.panel_gen.Controls.Add(Me.rb_male)
        Me.panel_gen.Controls.Add(Me.rb_female)
        Me.panel_gen.Location = New System.Drawing.Point(223, 39)
        Me.panel_gen.Name = "panel_gen"
        Me.panel_gen.Size = New System.Drawing.Size(164, 35)
        Me.panel_gen.TabIndex = 0
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.Location = New System.Drawing.Point(3, 12)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(42, 13)
        Me.lbl_gender.TabIndex = 13
        Me.lbl_gender.Text = "Gender"
        '
        'rb_male
        '
        Me.rb_male.AutoSize = True
        Me.rb_male.Checked = True
        Me.rb_male.Location = New System.Drawing.Point(51, 11)
        Me.rb_male.Name = "rb_male"
        Me.rb_male.Size = New System.Drawing.Size(48, 17)
        Me.rb_male.TabIndex = 3
        Me.rb_male.TabStop = True
        Me.rb_male.Text = "Male"
        Me.rb_male.UseVisualStyleBackColor = True
        '
        'rb_female
        '
        Me.rb_female.AutoSize = True
        Me.rb_female.Location = New System.Drawing.Point(102, 11)
        Me.rb_female.Name = "rb_female"
        Me.rb_female.Size = New System.Drawing.Size(59, 17)
        Me.rb_female.TabIndex = 4
        Me.rb_female.TabStop = True
        Me.rb_female.Text = "Female"
        Me.rb_female.UseVisualStyleBackColor = True
        '
        'lbl_exp
        '
        Me.lbl_exp.AutoSize = True
        Me.lbl_exp.Location = New System.Drawing.Point(405, 117)
        Me.lbl_exp.Name = "lbl_exp"
        Me.lbl_exp.Size = New System.Drawing.Size(60, 13)
        Me.lbl_exp.TabIndex = 2
        Me.lbl_exp.Text = "Experience"
        '
        'tb_qual
        '
        Me.tb_qual.Location = New System.Drawing.Point(488, 50)
        Me.tb_qual.MaxLength = 30
        Me.tb_qual.Name = "tb_qual"
        Me.tb_qual.Size = New System.Drawing.Size(141, 20)
        Me.tb_qual.TabIndex = 10
        '
        'lbl_qual
        '
        Me.lbl_qual.AutoSize = True
        Me.lbl_qual.Location = New System.Drawing.Point(405, 54)
        Me.lbl_qual.Name = "lbl_qual"
        Me.lbl_qual.Size = New System.Drawing.Size(65, 13)
        Me.lbl_qual.TabIndex = 25
        Me.lbl_qual.Text = "Qualification"
        '
        'tb_zip
        '
        Me.tb_zip.Location = New System.Drawing.Point(263, 109)
        Me.tb_zip.MaxLength = 6
        Me.tb_zip.Name = "tb_zip"
        Me.tb_zip.Size = New System.Drawing.Size(102, 20)
        Me.tb_zip.TabIndex = 7
        '
        'lbl_zip
        '
        Me.lbl_zip.AutoSize = True
        Me.lbl_zip.Location = New System.Drawing.Point(208, 113)
        Me.lbl_zip.Name = "lbl_zip"
        Me.lbl_zip.Size = New System.Drawing.Size(49, 13)
        Me.lbl_zip.TabIndex = 23
        Me.lbl_zip.Text = "Zip code"
        '
        'tb_add
        '
        Me.tb_add.Location = New System.Drawing.Point(91, 142)
        Me.tb_add.MaxLength = 50
        Me.tb_add.Multiline = True
        Me.tb_add.Name = "tb_add"
        Me.tb_add.Size = New System.Drawing.Size(296, 20)
        Me.tb_add.TabIndex = 8
        '
        'lbl_add
        '
        Me.lbl_add.AutoSize = True
        Me.lbl_add.Location = New System.Drawing.Point(7, 145)
        Me.lbl_add.Name = "lbl_add"
        Me.lbl_add.Size = New System.Drawing.Size(45, 13)
        Me.lbl_add.TabIndex = 21
        Me.lbl_add.Text = "Address"
        '
        'tb_city
        '
        Me.tb_city.Location = New System.Drawing.Point(93, 110)
        Me.tb_city.MaxLength = 40
        Me.tb_city.Name = "tb_city"
        Me.tb_city.Size = New System.Drawing.Size(100, 20)
        Me.tb_city.TabIndex = 6
        '
        'lbl_city
        '
        Me.lbl_city.AutoSize = True
        Me.lbl_city.Location = New System.Drawing.Point(7, 113)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(24, 13)
        Me.lbl_city.TabIndex = 19
        Me.lbl_city.Text = "City"
        '
        'tb_mob
        '
        Me.tb_mob.Location = New System.Drawing.Point(488, 15)
        Me.tb_mob.MaxLength = 10
        Me.tb_mob.Name = "tb_mob"
        Me.tb_mob.Size = New System.Drawing.Size(142, 20)
        Me.tb_mob.TabIndex = 9
        '
        'lbl_mob
        '
        Me.lbl_mob.AutoSize = True
        Me.lbl_mob.Location = New System.Drawing.Point(405, 20)
        Me.lbl_mob.Name = "lbl_mob"
        Me.lbl_mob.Size = New System.Drawing.Size(56, 13)
        Me.lbl_mob.TabIndex = 17
        Me.lbl_mob.Text = "Mobile no."
        '
        'lbl_note
        '
        Me.lbl_note.AutoSize = True
        Me.lbl_note.Location = New System.Drawing.Point(49, 396)
        Me.lbl_note.Name = "lbl_note"
        Me.lbl_note.Size = New System.Drawing.Size(220, 13)
        Me.lbl_note.TabIndex = 29
        Me.lbl_note.Text = "NOTE: All the fields are mandatory to be filled"
        '
        'gb_workHistory
        '
        Me.gb_workHistory.Controls.Add(Me.tb_post)
        Me.gb_workHistory.Controls.Add(Me.lbl_post)
        Me.gb_workHistory.Controls.Add(Me.lbl_left_date)
        Me.gb_workHistory.Controls.Add(Me.dtp_join_date)
        Me.gb_workHistory.Controls.Add(Me.dtp_left_date)
        Me.gb_workHistory.Controls.Add(Me.lbl_start_date)
        Me.gb_workHistory.Controls.Add(Me.tb_comp_name)
        Me.gb_workHistory.Controls.Add(Me.lbl_comp_name)
        Me.gb_workHistory.Location = New System.Drawing.Point(12, 213)
        Me.gb_workHistory.Name = "gb_workHistory"
        Me.gb_workHistory.Size = New System.Drawing.Size(326, 170)
        Me.gb_workHistory.TabIndex = 16
        Me.gb_workHistory.TabStop = False
        Me.gb_workHistory.Text = "Work History"
        '
        'tb_post
        '
        Me.tb_post.Location = New System.Drawing.Point(105, 132)
        Me.tb_post.MaxLength = 50
        Me.tb_post.Name = "tb_post"
        Me.tb_post.Size = New System.Drawing.Size(120, 20)
        Me.tb_post.TabIndex = 16
        '
        'lbl_post
        '
        Me.lbl_post.AutoSize = True
        Me.lbl_post.Location = New System.Drawing.Point(7, 135)
        Me.lbl_post.Name = "lbl_post"
        Me.lbl_post.Size = New System.Drawing.Size(63, 13)
        Me.lbl_post.TabIndex = 13
        Me.lbl_post.Text = "Designation"
        '
        'lbl_left_date
        '
        Me.lbl_left_date.AutoSize = True
        Me.lbl_left_date.Location = New System.Drawing.Point(7, 103)
        Me.lbl_left_date.Name = "lbl_left_date"
        Me.lbl_left_date.Size = New System.Drawing.Size(49, 13)
        Me.lbl_left_date.TabIndex = 12
        Me.lbl_left_date.Text = "Left date"
        '
        'dtp_join_date
        '
        Me.dtp_join_date.Checked = False
        Me.dtp_join_date.CustomFormat = "dd/MM/yyyy"
        Me.dtp_join_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_join_date.Location = New System.Drawing.Point(105, 63)
        Me.dtp_join_date.Name = "dtp_join_date"
        Me.dtp_join_date.ShowCheckBox = True
        Me.dtp_join_date.Size = New System.Drawing.Size(99, 20)
        Me.dtp_join_date.TabIndex = 14
        Me.dtp_join_date.Value = New Date(2017, 2, 12, 0, 0, 0, 0)
        '
        'dtp_left_date
        '
        Me.dtp_left_date.Checked = False
        Me.dtp_left_date.CustomFormat = "dd/MM/yyyy"
        Me.dtp_left_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_left_date.Location = New System.Drawing.Point(105, 99)
        Me.dtp_left_date.Name = "dtp_left_date"
        Me.dtp_left_date.ShowCheckBox = True
        Me.dtp_left_date.Size = New System.Drawing.Size(99, 20)
        Me.dtp_left_date.TabIndex = 15
        Me.dtp_left_date.Value = New Date(2017, 2, 12, 0, 0, 0, 0)
        '
        'lbl_start_date
        '
        Me.lbl_start_date.AutoSize = True
        Me.lbl_start_date.Location = New System.Drawing.Point(7, 70)
        Me.lbl_start_date.Name = "lbl_start_date"
        Me.lbl_start_date.Size = New System.Drawing.Size(62, 13)
        Me.lbl_start_date.TabIndex = 5
        Me.lbl_start_date.Text = "Joined date"
        '
        'tb_comp_name
        '
        Me.tb_comp_name.Location = New System.Drawing.Point(105, 31)
        Me.tb_comp_name.MaxLength = 30
        Me.tb_comp_name.Name = "tb_comp_name"
        Me.tb_comp_name.Size = New System.Drawing.Size(120, 20)
        Me.tb_comp_name.TabIndex = 13
        '
        'lbl_comp_name
        '
        Me.lbl_comp_name.AutoSize = True
        Me.lbl_comp_name.Location = New System.Drawing.Point(7, 34)
        Me.lbl_comp_name.Name = "lbl_comp_name"
        Me.lbl_comp_name.Size = New System.Drawing.Size(82, 13)
        Me.lbl_comp_name.TabIndex = 0
        Me.lbl_comp_name.Text = "Company Name"
        '
        'gb_sal_info
        '
        Me.gb_sal_info.Controls.Add(Me.tb_allow)
        Me.gb_sal_info.Controls.Add(Me.lbl_sal_insure_yearly)
        Me.gb_sal_info.Controls.Add(Me.lbl_sal_percent)
        Me.gb_sal_info.Controls.Add(Me.lbl_allow)
        Me.gb_sal_info.Controls.Add(Me.tb_insure)
        Me.gb_sal_info.Controls.Add(Me.lbl_insure)
        Me.gb_sal_info.Controls.Add(Me.tb_taxes)
        Me.gb_sal_info.Controls.Add(Me.lbl_taxes)
        Me.gb_sal_info.Controls.Add(Me.tb_sal)
        Me.gb_sal_info.Controls.Add(Me.lbl_sal)
        Me.gb_sal_info.Location = New System.Drawing.Point(355, 213)
        Me.gb_sal_info.Name = "gb_sal_info"
        Me.gb_sal_info.Size = New System.Drawing.Size(332, 167)
        Me.gb_sal_info.TabIndex = 17
        Me.gb_sal_info.TabStop = False
        Me.gb_sal_info.Text = "Salary Info"
        '
        'tb_allow
        '
        Me.tb_allow.Location = New System.Drawing.Point(96, 132)
        Me.tb_allow.MaxLength = 4
        Me.tb_allow.Name = "tb_allow"
        Me.tb_allow.Size = New System.Drawing.Size(100, 20)
        Me.tb_allow.TabIndex = 18
        '
        'lbl_sal_insure_yearly
        '
        Me.lbl_sal_insure_yearly.AutoSize = True
        Me.lbl_sal_insure_yearly.Location = New System.Drawing.Point(202, 103)
        Me.lbl_sal_insure_yearly.Name = "lbl_sal_insure_yearly"
        Me.lbl_sal_insure_yearly.Size = New System.Drawing.Size(36, 13)
        Me.lbl_sal_insure_yearly.TabIndex = 15
        Me.lbl_sal_insure_yearly.Text = "Yearly"
        '
        'lbl_sal_percent
        '
        Me.lbl_sal_percent.AutoSize = True
        Me.lbl_sal_percent.Location = New System.Drawing.Point(151, 70)
        Me.lbl_sal_percent.Name = "lbl_sal_percent"
        Me.lbl_sal_percent.Size = New System.Drawing.Size(15, 13)
        Me.lbl_sal_percent.TabIndex = 14
        Me.lbl_sal_percent.Text = "%"
        '
        'lbl_allow
        '
        Me.lbl_allow.AutoSize = True
        Me.lbl_allow.Location = New System.Drawing.Point(20, 135)
        Me.lbl_allow.Name = "lbl_allow"
        Me.lbl_allow.Size = New System.Drawing.Size(61, 13)
        Me.lbl_allow.TabIndex = 6
        Me.lbl_allow.Text = "Allowances"
        '
        'tb_insure
        '
        Me.tb_insure.Location = New System.Drawing.Point(96, 99)
        Me.tb_insure.Name = "tb_insure"
        Me.tb_insure.ReadOnly = True
        Me.tb_insure.Size = New System.Drawing.Size(100, 20)
        Me.tb_insure.TabIndex = 5
        Me.tb_insure.TabStop = False
        Me.tb_insure.Text = "100000"
        '
        'lbl_insure
        '
        Me.lbl_insure.AutoSize = True
        Me.lbl_insure.Location = New System.Drawing.Point(20, 102)
        Me.lbl_insure.Name = "lbl_insure"
        Me.lbl_insure.Size = New System.Drawing.Size(54, 13)
        Me.lbl_insure.TabIndex = 4
        Me.lbl_insure.Text = "Insurance"
        '
        'tb_taxes
        '
        Me.tb_taxes.Location = New System.Drawing.Point(96, 66)
        Me.tb_taxes.Name = "tb_taxes"
        Me.tb_taxes.ReadOnly = True
        Me.tb_taxes.Size = New System.Drawing.Size(49, 20)
        Me.tb_taxes.TabIndex = 3
        Me.tb_taxes.TabStop = False
        Me.tb_taxes.Text = "15"
        '
        'lbl_taxes
        '
        Me.lbl_taxes.AutoSize = True
        Me.lbl_taxes.Location = New System.Drawing.Point(20, 69)
        Me.lbl_taxes.Name = "lbl_taxes"
        Me.lbl_taxes.Size = New System.Drawing.Size(36, 13)
        Me.lbl_taxes.TabIndex = 2
        Me.lbl_taxes.Text = "Taxes"
        '
        'tb_sal
        '
        Me.tb_sal.Location = New System.Drawing.Point(96, 31)
        Me.tb_sal.MaxLength = 7
        Me.tb_sal.Name = "tb_sal"
        Me.tb_sal.Size = New System.Drawing.Size(100, 20)
        Me.tb_sal.TabIndex = 17
        '
        'lbl_sal
        '
        Me.lbl_sal.AutoSize = True
        Me.lbl_sal.Location = New System.Drawing.Point(20, 34)
        Me.lbl_sal.Name = "lbl_sal"
        Me.lbl_sal.Size = New System.Drawing.Size(36, 13)
        Me.lbl_sal.TabIndex = 0
        Me.lbl_sal.Text = "Salary"
        '
        'dialog_add_person
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 429)
        Me.Controls.Add(Me.gb_sal_info)
        Me.Controls.Add(Me.gb_basic_info)
        Me.Controls.Add(Me.tbl_button)
        Me.Controls.Add(Me.gb_workHistory)
        Me.Controls.Add(Me.lbl_note)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dialog_add_person"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Person"
        Me.tbl_button.ResumeLayout(False)
        Me.gb_basic_info.ResumeLayout(False)
        Me.gb_basic_info.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panel_gen.ResumeLayout(False)
        Me.panel_gen.PerformLayout()
        Me.gb_workHistory.ResumeLayout(False)
        Me.gb_workHistory.PerformLayout()
        Me.gb_sal_info.ResumeLayout(False)
        Me.gb_sal_info.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbl_button As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lbl_Fullname As Label
    Friend WithEvents lbl_dob As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents tb_firstname As TextBox
    Friend WithEvents tb_lastname As TextBox
    Friend WithEvents tb_email As TextBox
    Friend WithEvents dtp_dob As DateTimePicker
    Friend WithEvents gb_basic_info As GroupBox
    Friend WithEvents lbl_gender As Label
    Friend WithEvents rb_female As RadioButton
    Friend WithEvents gb_workHistory As GroupBox
    Friend WithEvents rb_male As RadioButton
    Friend WithEvents tb_mob As TextBox
    Friend WithEvents lbl_mob As Label
    Friend WithEvents tb_zip As TextBox
    Friend WithEvents lbl_zip As Label
    Friend WithEvents tb_add As TextBox
    Friend WithEvents lbl_add As Label
    Friend WithEvents tb_city As TextBox
    Friend WithEvents lbl_city As Label
    Friend WithEvents lbl_note As Label
    Friend WithEvents tb_qual As TextBox
    Friend WithEvents lbl_qual As Label
    Friend WithEvents panel_gen As Panel
    Friend WithEvents lbl_exp As Label
    Friend WithEvents tb_post As TextBox
    Friend WithEvents lbl_post As Label
    Friend WithEvents lbl_left_date As Label
    Friend WithEvents dtp_join_date As DateTimePicker
    Friend WithEvents dtp_left_date As DateTimePicker
    Friend WithEvents lbl_start_date As Label
    Friend WithEvents tb_comp_name As TextBox
    Friend WithEvents lbl_comp_name As Label
    Friend WithEvents gb_sal_info As GroupBox
    Friend WithEvents lbl_allow As Label
    Friend WithEvents tb_insure As TextBox
    Friend WithEvents lbl_insure As Label
    Friend WithEvents tb_taxes As TextBox
    Friend WithEvents lbl_taxes As Label
    Friend WithEvents tb_sal As TextBox
    Friend WithEvents lbl_sal As Label
    Friend WithEvents lbl_sal_insure_yearly As Label
    Friend WithEvents lbl_sal_percent As Label
    Friend WithEvents tb_exp As TextBox
    Friend WithEvents tb_allow As TextBox
    Friend WithEvents cb_addLoginUser As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rb_single As RadioButton
    Friend WithEvents rb_married As RadioButton
    Friend WithEvents lbl_married_status As Label
End Class
