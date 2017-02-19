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
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lbl_Fullname = New System.Windows.Forms.Label()
        Me.lbl_dob = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.tb_firstname = New System.Windows.Forms.TextBox()
        Me.tb_lastname = New System.Windows.Forms.TextBox()
        Me.tb_email = New System.Windows.Forms.TextBox()
        Me.dtp_dob = New System.Windows.Forms.DateTimePicker()
        Me.gb_basic_info = New System.Windows.Forms.GroupBox()
        Me.tb_exp = New System.Windows.Forms.TextBox()
        Me.panel_gen = New System.Windows.Forms.Panel()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.rb_male = New System.Windows.Forms.RadioButton()
        Me.rb_female = New System.Windows.Forms.RadioButton()
        Me.lbl_note = New System.Windows.Forms.Label()
        Me.lbl_exp = New System.Windows.Forms.Label()
        Me.cb_married_status = New System.Windows.Forms.ComboBox()
        Me.lbl_married_status = New System.Windows.Forms.Label()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_post = New System.Windows.Forms.TextBox()
        Me.lbl_post = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_join_date = New System.Windows.Forms.DateTimePicker()
        Me.dtp_left_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_start_date = New System.Windows.Forms.Label()
        Me.tb_comp_name = New System.Windows.Forms.TextBox()
        Me.lbl_comp_name = New System.Windows.Forms.Label()
        Me.gb_sal_info = New System.Windows.Forms.GroupBox()
        Me.lbl_sal_insure_yearly = New System.Windows.Forms.Label()
        Me.lbl_sal_percent = New System.Windows.Forms.Label()
        Me.lbl_sal_month = New System.Windows.Forms.Label()
        Me.dtp_sal_to = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_sal_from = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_insure = New System.Windows.Forms.TextBox()
        Me.lbl_insure = New System.Windows.Forms.Label()
        Me.tb_taxes = New System.Windows.Forms.TextBox()
        Me.lbl_taxes = New System.Windows.Forms.Label()
        Me.tb_sal = New System.Windows.Forms.TextBox()
        Me.lbl_sal = New System.Windows.Forms.Label()
        Me.TableLayoutPanel.SuspendLayout()
        Me.gb_basic_info.SuspendLayout()
        Me.panel_gen.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gb_sal_info.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(541, 386)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 1
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
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
        Me.tb_firstname.Name = "tb_firstname"
        Me.tb_firstname.Size = New System.Drawing.Size(122, 20)
        Me.tb_firstname.TabIndex = 5
        '
        'tb_lastname
        '
        Me.tb_lastname.Location = New System.Drawing.Point(233, 13)
        Me.tb_lastname.Name = "tb_lastname"
        Me.tb_lastname.Size = New System.Drawing.Size(132, 20)
        Me.tb_lastname.TabIndex = 7
        '
        'tb_email
        '
        Me.tb_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tb_email.Location = New System.Drawing.Point(93, 79)
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(272, 20)
        Me.tb_email.TabIndex = 8
        '
        'dtp_dob
        '
        Me.dtp_dob.CustomFormat = "dd/MM/yyyy"
        Me.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_dob.Location = New System.Drawing.Point(93, 47)
        Me.dtp_dob.MaxDate = New Date(1998, 12, 31, 0, 0, 0, 0)
        Me.dtp_dob.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.dtp_dob.Name = "dtp_dob"
        Me.dtp_dob.Size = New System.Drawing.Size(84, 20)
        Me.dtp_dob.TabIndex = 9
        Me.dtp_dob.Value = New Date(1998, 12, 31, 0, 0, 0, 0)
        '
        'gb_basic_info
        '
        Me.gb_basic_info.Controls.Add(Me.tb_exp)
        Me.gb_basic_info.Controls.Add(Me.panel_gen)
        Me.gb_basic_info.Controls.Add(Me.lbl_note)
        Me.gb_basic_info.Controls.Add(Me.lbl_exp)
        Me.gb_basic_info.Controls.Add(Me.cb_married_status)
        Me.gb_basic_info.Controls.Add(Me.lbl_married_status)
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
        'tb_exp
        '
        Me.tb_exp.Location = New System.Drawing.Point(488, 113)
        Me.tb_exp.Name = "tb_exp"
        Me.tb_exp.Size = New System.Drawing.Size(51, 20)
        Me.tb_exp.TabIndex = 30
        '
        'panel_gen
        '
        Me.panel_gen.Controls.Add(Me.lbl_gender)
        Me.panel_gen.Controls.Add(Me.rb_male)
        Me.panel_gen.Controls.Add(Me.rb_female)
        Me.panel_gen.Location = New System.Drawing.Point(189, 39)
        Me.panel_gen.Name = "panel_gen"
        Me.panel_gen.Size = New System.Drawing.Size(176, 35)
        Me.panel_gen.TabIndex = 0
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.Location = New System.Drawing.Point(9, 13)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(42, 13)
        Me.lbl_gender.TabIndex = 13
        Me.lbl_gender.Text = "Gender"
        '
        'rb_male
        '
        Me.rb_male.AutoSize = True
        Me.rb_male.Location = New System.Drawing.Point(59, 11)
        Me.rb_male.Name = "rb_male"
        Me.rb_male.Size = New System.Drawing.Size(48, 17)
        Me.rb_male.TabIndex = 14
        Me.rb_male.TabStop = True
        Me.rb_male.Text = "Male"
        Me.rb_male.UseVisualStyleBackColor = True
        '
        'rb_female
        '
        Me.rb_female.AutoSize = True
        Me.rb_female.Location = New System.Drawing.Point(113, 11)
        Me.rb_female.Name = "rb_female"
        Me.rb_female.Size = New System.Drawing.Size(59, 17)
        Me.rb_female.TabIndex = 15
        Me.rb_female.TabStop = True
        Me.rb_female.Text = "Female"
        Me.rb_female.UseVisualStyleBackColor = True
        '
        'lbl_note
        '
        Me.lbl_note.AutoSize = True
        Me.lbl_note.Location = New System.Drawing.Point(218, 179)
        Me.lbl_note.Name = "lbl_note"
        Me.lbl_note.Size = New System.Drawing.Size(214, 13)
        Me.lbl_note.TabIndex = 29
        Me.lbl_note.Text = "Note* All the fields are mandatory to be filled"
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
        'cb_married_status
        '
        Me.cb_married_status.FormattingEnabled = True
        Me.cb_married_status.Items.AddRange(New Object() {"Married", "Single", "Widow"})
        Me.cb_married_status.Location = New System.Drawing.Point(489, 81)
        Me.cb_married_status.Name = "cb_married_status"
        Me.cb_married_status.Size = New System.Drawing.Size(141, 21)
        Me.cb_married_status.TabIndex = 28
        '
        'lbl_married_status
        '
        Me.lbl_married_status.AutoSize = True
        Me.lbl_married_status.Location = New System.Drawing.Point(405, 85)
        Me.lbl_married_status.Name = "lbl_married_status"
        Me.lbl_married_status.Size = New System.Drawing.Size(75, 13)
        Me.lbl_married_status.TabIndex = 27
        Me.lbl_married_status.Text = "Married Status"
        '
        'tb_qual
        '
        Me.tb_qual.Location = New System.Drawing.Point(488, 50)
        Me.tb_qual.Name = "tb_qual"
        Me.tb_qual.Size = New System.Drawing.Size(141, 20)
        Me.tb_qual.TabIndex = 26
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
        Me.tb_zip.TabIndex = 24
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
        Me.tb_add.Multiline = True
        Me.tb_add.Name = "tb_add"
        Me.tb_add.Size = New System.Drawing.Size(538, 20)
        Me.tb_add.TabIndex = 22
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
        Me.tb_city.Name = "tb_city"
        Me.tb_city.Size = New System.Drawing.Size(100, 20)
        Me.tb_city.TabIndex = 20
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
        Me.tb_mob.Name = "tb_mob"
        Me.tb_mob.Size = New System.Drawing.Size(142, 20)
        Me.tb_mob.TabIndex = 18
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_post)
        Me.GroupBox1.Controls.Add(Me.lbl_post)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp_join_date)
        Me.GroupBox1.Controls.Add(Me.dtp_left_date)
        Me.GroupBox1.Controls.Add(Me.lbl_start_date)
        Me.GroupBox1.Controls.Add(Me.tb_comp_name)
        Me.GroupBox1.Controls.Add(Me.lbl_comp_name)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 213)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 170)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Work History"
        '
        'tb_post
        '
        Me.tb_post.Location = New System.Drawing.Point(105, 132)
        Me.tb_post.Name = "tb_post"
        Me.tb_post.Size = New System.Drawing.Size(120, 20)
        Me.tb_post.TabIndex = 14
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Left date"
        '
        'dtp_join_date
        '
        Me.dtp_join_date.CustomFormat = "dd/MM/yyyy"
        Me.dtp_join_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_join_date.Location = New System.Drawing.Point(105, 63)
        Me.dtp_join_date.Name = "dtp_join_date"
        Me.dtp_join_date.Size = New System.Drawing.Size(84, 20)
        Me.dtp_join_date.TabIndex = 11
        Me.dtp_join_date.Value = New Date(2017, 2, 12, 0, 0, 0, 0)
        '
        'dtp_left_date
        '
        Me.dtp_left_date.CustomFormat = "dd/MM/yyyy"
        Me.dtp_left_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_left_date.Location = New System.Drawing.Point(105, 99)
        Me.dtp_left_date.Name = "dtp_left_date"
        Me.dtp_left_date.Size = New System.Drawing.Size(84, 20)
        Me.dtp_left_date.TabIndex = 10
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
        Me.tb_comp_name.Name = "tb_comp_name"
        Me.tb_comp_name.Size = New System.Drawing.Size(120, 20)
        Me.tb_comp_name.TabIndex = 1
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
        Me.gb_sal_info.Controls.Add(Me.lbl_sal_insure_yearly)
        Me.gb_sal_info.Controls.Add(Me.lbl_sal_percent)
        Me.gb_sal_info.Controls.Add(Me.lbl_sal_month)
        Me.gb_sal_info.Controls.Add(Me.dtp_sal_to)
        Me.gb_sal_info.Controls.Add(Me.Label3)
        Me.gb_sal_info.Controls.Add(Me.dtp_sal_from)
        Me.gb_sal_info.Controls.Add(Me.Label2)
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
        'lbl_sal_insure_yearly
        '
        Me.lbl_sal_insure_yearly.AutoSize = True
        Me.lbl_sal_insure_yearly.Location = New System.Drawing.Point(212, 103)
        Me.lbl_sal_insure_yearly.Name = "lbl_sal_insure_yearly"
        Me.lbl_sal_insure_yearly.Size = New System.Drawing.Size(36, 13)
        Me.lbl_sal_insure_yearly.TabIndex = 15
        Me.lbl_sal_insure_yearly.Text = "Yearly"
        '
        'lbl_sal_percent
        '
        Me.lbl_sal_percent.AutoSize = True
        Me.lbl_sal_percent.Location = New System.Drawing.Point(157, 70)
        Me.lbl_sal_percent.Name = "lbl_sal_percent"
        Me.lbl_sal_percent.Size = New System.Drawing.Size(44, 13)
        Me.lbl_sal_percent.TabIndex = 14
        Me.lbl_sal_percent.Text = "Percent"
        '
        'lbl_sal_month
        '
        Me.lbl_sal_month.AutoSize = True
        Me.lbl_sal_month.Location = New System.Drawing.Point(212, 34)
        Me.lbl_sal_month.Name = "lbl_sal_month"
        Me.lbl_sal_month.Size = New System.Drawing.Size(44, 13)
        Me.lbl_sal_month.TabIndex = 13
        Me.lbl_sal_month.Text = "Monthly"
        '
        'dtp_sal_to
        '
        Me.dtp_sal_to.CustomFormat = "dd/MM/yyyy"
        Me.dtp_sal_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_sal_to.Location = New System.Drawing.Point(228, 132)
        Me.dtp_sal_to.Name = "dtp_sal_to"
        Me.dtp_sal_to.Size = New System.Drawing.Size(84, 20)
        Me.dtp_sal_to.TabIndex = 12
        Me.dtp_sal_to.Value = New Date(2017, 2, 12, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "to"
        '
        'dtp_sal_from
        '
        Me.dtp_sal_from.CustomFormat = "dd/MM/yyyy"
        Me.dtp_sal_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_sal_from.Location = New System.Drawing.Point(96, 132)
        Me.dtp_sal_from.Name = "dtp_sal_from"
        Me.dtp_sal_from.Size = New System.Drawing.Size(84, 20)
        Me.dtp_sal_from.TabIndex = 10
        Me.dtp_sal_from.Value = New Date(2017, 2, 12, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Salary from"
        '
        'tb_insure
        '
        Me.tb_insure.Location = New System.Drawing.Point(96, 99)
        Me.tb_insure.Name = "tb_insure"
        Me.tb_insure.ReadOnly = True
        Me.tb_insure.Size = New System.Drawing.Size(100, 20)
        Me.tb_insure.TabIndex = 5
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
        Me.tb_taxes.Text = "15.00%"
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
        Me.tb_sal.Name = "tb_sal"
        Me.tb_sal.Size = New System.Drawing.Size(100, 20)
        Me.tb_sal.TabIndex = 1
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
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(699, 427)
        Me.Controls.Add(Me.gb_sal_info)
        Me.Controls.Add(Me.gb_basic_info)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dialog_add_person"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Person"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.gb_basic_info.ResumeLayout(False)
        Me.gb_basic_info.PerformLayout()
        Me.panel_gen.ResumeLayout(False)
        Me.panel_gen.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb_sal_info.ResumeLayout(False)
        Me.gb_sal_info.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
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
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents cb_married_status As ComboBox
    Friend WithEvents lbl_married_status As Label
    Friend WithEvents tb_qual As TextBox
    Friend WithEvents lbl_qual As Label
    Friend WithEvents panel_gen As Panel
    Friend WithEvents lbl_exp As Label
    Friend WithEvents tb_post As TextBox
    Friend WithEvents lbl_post As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_join_date As DateTimePicker
    Friend WithEvents dtp_left_date As DateTimePicker
    Friend WithEvents lbl_start_date As Label
    Friend WithEvents tb_comp_name As TextBox
    Friend WithEvents lbl_comp_name As Label
    Friend WithEvents gb_sal_info As GroupBox
    Friend WithEvents dtp_sal_to As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_sal_from As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_insure As TextBox
    Friend WithEvents lbl_insure As Label
    Friend WithEvents tb_taxes As TextBox
    Friend WithEvents lbl_taxes As Label
    Friend WithEvents tb_sal As TextBox
    Friend WithEvents lbl_sal As Label
    Friend WithEvents lbl_sal_insure_yearly As Label
    Friend WithEvents lbl_sal_percent As Label
    Friend WithEvents lbl_sal_month As Label
    Friend WithEvents tb_exp As TextBox
End Class
