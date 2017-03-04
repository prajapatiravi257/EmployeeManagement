Imports System.Text.RegularExpressions

Public Class dialog_add_person
    Dim gender, sql As String
    Dim datechange As Boolean = False
    Dim errorProvider As New ErrorProvider()
    Dim todayDate As String = Format(Date.Today, "dd/MM/yyyy").ToString()
    Dim sal As Integer
    Dim frm_admin As New frm_admin()


    Private Sub dialog_add_person_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        tb_firstname.Focus()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If rb_male.Checked Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        If ValidateChildren(ValidationConstraints.None) Then
            insertSql()
            frm_admin.dgv_emp_info.Update()
            DialogResult = DialogResult.OK
            Close()
        Else
            DialogResult = DialogResult.None
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub insertSql()
        Try
            sql = "INSERT INTO Emp_basic_details (firstname, lastname,email, dob, mob, city, address,
               zipcode, qualification, curr_exp, start_date, gender, married_status)
               VALUES('" & tb_firstname.Text & "', '" & tb_lastname.Text & "', '" & tb_email.Text & "', '" & dtp_dob.Text &
                       "', " & tb_mob.Text & ", '" & tb_city.Text & "', '" & tb_add.Text & "', " & tb_zip.Text &
                       ", '" & tb_qual.Text & "', " & tb_exp.Text & ",'" & todayDate & "', '" & gender & "', '" & cb_married_status.Text & "')"

            employeeINST(sql) ' inserts row in Emp_basic_details table
            sql = "INSERT INTO Work_history (emp_id,comp_name, emp_name, p_start_date, p_end_date, post)
                SELECT emp_id, '" & tb_comp_name.Text & "','" & tb_firstname.Text & "','" & dtp_join_date.Text &
                        "','" & dtp_left_date.Text & "','" & tb_qual.Text & "' FROM Emp_basic_details WHERE firstname='" & tb_firstname.Text & "' AND lastname='" & tb_lastname.Text & "'"

            employeeINST(sql) ' inserts row in Work_history table
            sql = "INSERT INTO Salary_information (emp_id,monthly_sal, monthly_taxes, monthly_deduct, monthly_insurances)
                SELECT emp_id," & tb_sal.Text & "," & tb_taxes.Text & "," & tb_allow.Text & "," & tb_insure.Text &
                " FROM Emp_basic_details WHERE firstname='" & tb_firstname.Text & "' AND lastname='" & tb_lastname.Text & "'"

            employeeINST(sql)  ' inserts row in Salary_information table
            sql = "INSERT INTO Contact_person_info (emp_id,c_firstname,c_lastname,c_email.c_mob,c_city,c_address)
                    SELECT emp_id, '" & tb_firstname.Text & "', '" & tb_lastname.Text &
                    "', '" & tb_email.Text & "', '" & tb_mob.Text & "', '" & tb_city.Text & "', '" & tb_add.Text & "' 
                    FROM Emp_basic_details WHERE firstname='" & tb_firstname.Text & "' AND lastname='" & tb_lastname.Text & "'"
            employeeINST(sql)   'inserts row in Contact_person_info

            If CheckBox_addLoginUser.Checked Then 'add user to login_users table if checked
                sql = "INSERT INTO Login_users (emp_id,username,passwd)
                SELECT emp_id, '" & tb_firstname.Text & "', '" & tb_lastname.Text & "' 
                    FROM Emp_basic_details WHERE firstname='" & tb_firstname.Text & "' AND lastname='" & tb_lastname.Text & "'"
                employeeINST(sql)
            End If


        Catch ex As Exception
            MsgBox(ex.Message())
            MessageBox.Show(MessageBoxIcon.Error, "Something went wrong try again")
        End Try

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

    Private Sub tb_lastname_Validated(sender As Object, e As EventArgs) Handles tb_lastname.Validated
        errorProvider.SetError(tb_lastname, String.Empty)
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
        If Not Regex.IsMatch(tb_qual.Text, rgx_str) Or String.IsNullOrWhiteSpace(tb_qual.Text) Then
            errorProvider.SetError(tb_qual, "Enter a valid qualification")
            e.Cancel = True
        End If
    End Sub

    Private Sub tb_qual_Validated(sender As Object, e As EventArgs) Handles tb_qual.Validated
        errorProvider.SetError(tb_qual, String.Empty)
    End Sub

    Private Sub tb_city_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_city.Validating
        If Not Regex.IsMatch(tb_city.Text, rgx_str) Then
            errorProvider.SetError(tb_city, "Enter a valid city name")
            e.Cancel = True
        End If
    End Sub

    Private Sub tb_city_Validated(sender As Object, e As EventArgs) Handles tb_city.Validated
        errorProvider.SetError(tb_city, String.Empty)
    End Sub

    Private Sub tb_zip_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_zip.Validating
        If Not Regex.IsMatch(tb_zip.Text, rgx_zipcode) Then
            errorProvider.SetError(tb_zip, "Not a valid zip code")
            e.Cancel = True
        End If
    End Sub

    Private Sub tb_zip_Validated(sender As Object, e As EventArgs) Handles tb_zip.Validated
        errorProvider.SetError(tb_zip, String.Empty)
    End Sub


    Private Sub tb_exp_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_exp.Validating
        If Not IsNumeric(tb_exp.Text) And String.IsNullOrWhiteSpace(tb_exp.Text) Then
            errorProvider.SetError(tb_exp, "Enter a valid digit")
            e.Cancel = True
        End If
    End Sub

    Private Sub tb_exp_Validated(sender As Object, e As EventArgs) Handles tb_exp.Validated
        errorProvider.SetError(tb_exp, String.Empty)
    End Sub

    Private Sub tb_add_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_add.Validating
        If String.IsNullOrEmpty(tb_add.Text) Then
            errorProvider.SetError(tb_add, "Enter a valid address")
            e.Cancel = True
        End If
    End Sub

    Private Sub tb_add_Validated(sender As Object, e As EventArgs) Handles tb_add.Validated
        errorProvider.SetError(tb_add, String.Empty)
    End Sub

    Private Sub tb_comp_name_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_comp_name.Validating
        If Not Regex.IsMatch(tb_comp_name.Text, rgx_str) Then
            errorProvider.SetError(tb_comp_name, "Enter a valid name")
            e.Cancel = True
        End If
    End Sub

    Private Sub tb_comp_name_Validated(sender As Object, e As EventArgs) Handles tb_comp_name.Validated
        errorProvider.SetError(tb_comp_name, String.Empty)
    End Sub

    Private Sub tb_post_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_post.Validating
        If Not Regex.IsMatch(tb_post.Text, rgx_str) Then
            errorProvider.SetError(tb_post, "Enter a valid designation")
            e.Cancel = True
        End If
    End Sub

    Private Sub tb_post_Validated(sender As Object, e As EventArgs) Handles tb_post.Validated
        errorProvider.SetError(tb_post, String.Empty)
    End Sub

    Private Sub tb_sal_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_sal.Validating
        If Not IsNumeric(tb_sal.Text) And String.IsNullOrWhiteSpace(tb_sal.Text) Then
            errorProvider.SetError(tb_sal, "Enter a valid Number")
            e.Cancel = True
        End If

    End Sub


    Private Sub tb_sal_Validated(sender As Object, e As EventArgs) Handles tb_sal.Validated
        errorProvider.SetError(tb_sal, String.Empty)
    End Sub

    Private Sub cb_married_status_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cb_married_status.Validating
        If String.IsNullOrEmpty(cb_married_status.Text) Then
            errorProvider.SetError(cb_married_status, "Please Select your maratial status")
            e.Cancel = True
        End If
    End Sub

    Private Sub cb_married_status_Validated(sender As Object, e As EventArgs) Handles cb_married_status.Validated
        errorProvider.SetError(cb_married_status, String.Empty)
    End Sub

    Private Sub tb_allow_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_allow.Validating
        If Not IsNumeric(tb_allow.Text) And String.IsNullOrWhiteSpace(tb_allow.Text) Then
            errorProvider.SetError(tb_allow, "Enter a valid Number")
            e.Cancel = True
        End If
    End Sub

    Private Sub tb_allow_Validated(sender As Object, e As EventArgs) Handles tb_allow.Validated
        errorProvider.SetError(tb_allow, String.Empty)
    End Sub

    Private Sub dtp_dob_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtp_dob.Validating
        If Not dtp_dob.Checked Then
            errorProvider.SetError(dtp_dob, "Enter your Birth date")
            e.Cancel = True
        End If
    End Sub

    Private Sub dtp_dob_Validated(sender As Object, e As EventArgs) Handles dtp_dob.Validated
        errorProvider.SetError(dtp_dob, String.Empty)
    End Sub

    Private Sub dtp_join_date_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtp_join_date.Validating
        If Not dtp_dob.Checked Then
            errorProvider.SetError(dtp_join_date, "Enter the joining date")
            e.Cancel = True
        End If
    End Sub

    Private Sub dtp_join_date_Validated(sender As Object, e As EventArgs) Handles dtp_join_date.Validated
        errorProvider.SetError(dtp_join_date, String.Empty)
    End Sub

    Private Sub dtp_left_date_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtp_left_date.Validating
        If Not dtp_dob.Checked Then
            errorProvider.SetError(dtp_left_date, "Enter the date you left")
            e.Cancel = True
        End If
    End Sub

    Private Sub dtp_left_date_Validated(sender As Object, e As EventArgs) Handles dtp_left_date.Validated
        errorProvider.SetError(dtp_left_date, String.Empty)
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

End Class
