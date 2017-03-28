Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frm_user
    Dim dr As SqlDataReader
    Dim sql As String
    Dim numDays, paidleave As Integer
    Dim leave_date As String


    Private Sub frm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Events' table. You can move, or remove it, as needed.
        Me.EventsTableAdapter.Fill(Me.EmployeeManagementDataSet.Events)
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Holiday_info' table. You can move, or remove it, as needed.
        Me.Holiday_infoTableAdapter.Fill(Me.EmployeeManagementDataSet.Holiday_info)

        getEmpInfo()
        RW_textboxes(True)

    End Sub

    Private Sub btn_personalInfo_edit_Click(sender As Object, e As EventArgs) Handles btn_personalInfo_edit.Click
        RW_textboxes(False)
        btn_personalInfo_update.Enabled = True
        btn_personalInfo_edit.Enabled = False
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_personalInfo_update.Click
        If rb_married.Checked Then
            maritalStatus = "Married"
        Else
            maritalStatus = "Single"
        End If
        If ValidateChildren(ValidationConstraints.None) Then
            empUpdate()
            btn_personalInfo_edit.Enabled = True
            btn_personalInfo_update.Enabled = False
        End If
    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        applyLeaves()
    End Sub


    Private Sub llbl_logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_logout.LinkClicked
        logout(Me) 'logout function call with form parameter
    End Sub

    Private Sub getEmpInfo()
        Dim loginPage As New frm_login()

        sql = "SELECT emp_id, firstname, lastname,email, dob, mob, city, address, zipcode, qualification, marital_status FROM Emp_basic_details WHERE firstname='" & username & "' AND lastname='" & password & "'"

        Try

            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If

            sqlcmd = New SqlCommand(sql, sqlCon)

            dr = sqlcmd.ExecuteReader()

            If dr.HasRows Then

                While dr.Read()
                    lbl_val_empid.Text = dr("emp_id").ToString()
                    lbl_val_empName.Text = dr("firstname").ToString() & " " & dr("lastname").ToString()
                    lbl_val_dob.Text = dr("dob").ToString()
                    tb_firstname.Text = dr("firstname").ToString()
                    tb_lastname.Text = dr("lastname").ToString()
                    tb_email.Text = dr("email").ToString()
                    dtp_dob.Text = lbl_val_dob.Text
                    tb_mob.Text = dr("mob").ToString()
                    tb_city.Text = dr("city").ToString()
                    tb_add.Text = dr("address").ToString()
                    tb_zip.Text = dr("zipcode").ToString()
                    tb_qual.Text = dr("qualification").ToString()
                    If dr("marital_status").ToString() = "Married" Then
                        rb_married.Checked = True
                    Else
                        rb_single.Checked = True
                    End If

                End While
                closeDR(dr)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        sqlCon.Close()

    End Sub


    Private Sub applyLeaves()

        Dim sr As SelectionRange = MonthCalendar_leaveDatePicker.SelectionRange
        numDays = sr.End.Subtract(sr.Start).Days + 1

        leave_date = sr.Start.ToShortDateString() & "-" & sr.End.ToShortDateString()

        If checkBox_addToPaidLeave.Checked Then
            paidleave = numDays
        Else
            paidleave = 0
        End If

        Try

            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If


            sql = "INSERT INTO Emp_leaves(emp_id,emp_name,leave_date,numOfDays,leave_reason,paid_leave) 
               values(@emp_id,@emp_name,@leave_date,@numOfDays,@leave_reason,@paid_leave)"

            sqlcmd = New SqlCommand(sql, sqlCon)
            With sqlcmd.Parameters

                .AddWithValue("@emp_id", lbl_val_empid.Text)
                .AddWithValue("@emp_name", lbl_val_empName.Text)
                .AddWithValue("@leave_date", leave_date)
                .AddWithValue("@numOfDays", numDays)
                .AddWithValue("@leave_reason", tb_reason.Text)
                .AddWithValue("@paid_leave", paidleave)

            End With

            If sqlcmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Leave Applied Succesfully")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        sqlCon.Close()

    End Sub


    Private Sub empUpdate()
        Dim result As Integer

        Try

            sql = "UPDATE Emp_basic_details
               SET  firstname = @firstname, marital_status = @marital_status,
                   qualification = @qualification, zipcode = @zipcode, 
                    address = @address, city = @city, mob = @mob, dob = @dob, email = @email, lastname = @lastname 
               WHERE   emp_id = @emp_id"

            sqlcmd = New SqlCommand(sql, sqlCon)

            With sqlcmd.Parameters
                .AddWithValue("@firstname", tb_firstname.Text)
                .AddWithValue("@lastname", tb_lastname.Text)
                .AddWithValue("@city", tb_city.Text)
                .AddWithValue("@address", tb_add.Text)
                .AddWithValue("@zipcode", tb_zip.Text)
                .AddWithValue("@email", tb_email.Text)
                .AddWithValue("@mob", tb_mob.Text)
                .AddWithValue("@dob", dtp_dob.Text)
                .AddWithValue("@qualification", tb_qual.Text)
                .AddWithValue("@marital_status", maritalStatus)
                .AddWithValue("@emp_id", lbl_val_empid.Text)
            End With

            result = employeeDB(sql, sqlcmd)

            sql = "UPDATE Contact_person_info
               SET    c_firstname =@c_firstname,c_lastname=@c_lastname, c_zipcode =@c_zipcode, c_address =@c_address, c_city =@c_city,
                    c_mob =@c_mob, c_email =@c_email
               WHERE   emp_id = @emp_id"

            sqlcmd = New SqlCommand(sql, sqlCon)

            With sqlcmd.Parameters
                .AddWithValue("@c_firstname", tb_firstname.Text)
                .AddWithValue("@c_lastname", tb_lastname.Text)
                .AddWithValue("@c_city", tb_city.Text)
                .AddWithValue("@c_address", tb_add.Text)
                .AddWithValue("@c_zipcode", tb_zip.Text)
                .AddWithValue("@c_email", tb_email.Text)
                .AddWithValue("@c_mob", tb_mob.Text)
                .AddWithValue("@emp_id", lbl_val_empid.Text)
            End With

            result += employeeDB(sql, sqlcmd)


            sqlcmd = New SqlCommand(sql, sqlCon)

            sql = "UPDATE Login_users SET
                    username=@username, passwd=@passwd
                WHERE emp_id=@emp_id"
            With sqlcmd.Parameters
                .AddWithValue("@username", tb_firstname.Text)
                .AddWithValue("@passwd", tb_lastname.Text)
                .AddWithValue("@emp_id", lbl_val_empid.Text)
            End With

            result += employeeDB(sql, sqlcmd)

            If result = 3 Then
                MessageBox.Show("Record's Updated of Employee ")
            End If

        Catch ex As Exception
            MsgBox("Sorry pal", ex.Message, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub RW_textboxes(rw As Boolean)
        Dim tb As TextBox

        If Not rw Then
            For Each ctrl As Control In gb_personal_info.Controls
                If TypeOf ctrl Is TextBox Then
                    tb = CType(ctrl, TextBox)
                    tb.ReadOnly = False
                End If
            Next
        Else
            For Each ctrl As Control In gb_personal_info.Controls
                If TypeOf ctrl Is TextBox Then
                    tb = CType(ctrl, TextBox)
                    tb.ReadOnly = True
                End If
            Next
        End If

    End Sub


    Private Sub tb_email_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_email.Validating
        If Not String.IsNullOrWhiteSpace(tb_email.Text) Then
            If ValidateEmail(tb_email.Text) = False Then
                errorProvider.SetError(tb_email, "Enter an valid email id")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub tb_email_Validated(sender As Object, e As EventArgs) Handles tb_email.Validated
        errorProvider.SetError(tb_email, String.Empty)
    End Sub

    Private Sub tb_firstname_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_firstname.Validating
        If Not Regex.IsMatch(tb_firstname.Text, rgx_str) Then
            errorProvider.SetError(tb_firstname, "Enter a valid name")
            e.Cancel = True
        End If
    End Sub

    Private Sub tb_firstname_Validated(sender As Object, e As EventArgs) Handles tb_firstname.Validated
        errorProvider.SetError(tb_firstname, String.Empty)
    End Sub


    Private Sub tb_lastname_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_lastname.Validating
        If Not Regex.IsMatch(tb_lastname.Text, rgx_str) Then
            errorProvider.SetError(tb_lastname, "Enter a valid lastname")
            e.Cancel = True
        End If
    End Sub

    Private Sub tb_city_Validated(sender As Object, e As EventArgs) Handles tb_city.Validated
        errorProvider.SetError(tb_city, String.Empty)
    End Sub

    Private Sub tb_city_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_city.Validating
        If Not Regex.IsMatch(tb_city.Text, rgx_str) Then
            errorProvider.SetError(tb_city, "Enter a valid city name")
            e.Cancel = True
        End If
    End Sub

    Private Sub tb_zip_Validated(sender As Object, e As EventArgs) Handles tb_zip.Validated
        errorProvider.SetError(tb_city, String.Empty)
    End Sub

    Private Sub tb_zip_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_zip.Validating
        If Not Regex.IsMatch(tb_zip.Text, rgx_zipcode) Then
            errorProvider.SetError(tb_zip, "Not a valid zip code")
            e.Cancel = True
        End If

    End Sub


    Private Sub tb_mob_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_mob.Validating
        If Not Regex.IsMatch(tb_mob.Text, rgx_mob) Then
            errorProvider.SetError(tb_mob, "Enter a valid Mobile number")
            e.Cancel = True
        End If

    End Sub

    Private Sub tb_mob_Validated(sender As Object, e As EventArgs) Handles tb_mob.Validated
        errorProvider.SetError(tb_mob, String.Empty)

    End Sub

    Private Sub tb_qual_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_qual.Validating
        If Not Regex.IsMatch(tb_qual.Text, rgx_str) Or String.IsNullOrEmpty(tb_qual.Text) Then
            errorProvider.SetError(tb_qual, "Enter a valid qualification")
            e.Cancel = True
        End If
    End Sub

    Private Sub tb_qual_Validated(sender As Object, e As EventArgs) Handles tb_qual.Validated
        errorProvider.SetError(tb_qual, String.Empty)
    End Sub

    Private Sub tb_lastname_Validated(sender As Object, e As EventArgs) Handles tb_lastname.Validated
        errorProvider.SetError(tb_lastname, String.Empty)
    End Sub


End Class