
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class dialog_add_person
    Dim datechange As Boolean = False
    Dim sal As Integer

    Private Sub dialog_add_person_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        tb_firstname.Focus()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        If rb_male.Checked Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        If rb_married.Checked Then
            maritalStatus = "Married"
        Else
            maritalStatus = "Single"
        End If

        If ValidateChildren(ValidationConstraints.None) Then
            If btn_save.Text = "Save" Then
                insertSql()
                DialogResult = DialogResult.OK
                Close()
            Else
                updateEmp()
                DialogResult = DialogResult.OK
                Close()
            End If

        Else
            DialogResult = DialogResult.None
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub insertSql()
        Dim result As Integer = 0

        Try

            sql = "INSERT INTO Emp_basic_details (firstname, lastname, email, dob, mob, city, address, zipcode, 
                            qualification, curr_exp, start_date, end_date, gender, marital_status)
               VALUES (@firstname, @lastname, @email, @dob, @mob, @city, @address, @zipcode, @qualification,
                        @curr_exp, @start_date, @end_date, @gender, @marital_status)"

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
                .AddWithValue("@curr_exp", tb_exp.Text)
                .AddWithValue("@start_date", dtp_join_date.Value)
                .AddWithValue("@end_date", dtp_left_date.Value)
                .AddWithValue("@gender", gender)
                .AddWithValue("@marital_status", maritalStatus)
            End With

            result = employeeDb(sql, sqlcmd)

            sql = "INSERT INTO Work_history(emp_id, comp_name, emp_name, p_start_date, p_end_date, post)
               SELECT                   emp_id, @comp_name, @emp_name, @p_start_date, @p_end_date, @post
               FROM       Emp_basic_details
               WHERE                      firstname = @firstname1 AND lastname = @lastname"

            sqlcmd = New SqlCommand(sql, sqlCon)

            With sqlcmd.Parameters
                .AddWithValue("@emp_name", tb_firstname.Text)
                .AddWithValue("@firstname1", tb_firstname.Text)
                .AddWithValue("@lastname", tb_lastname.Text)
                .AddWithValue("@comp_name", tb_comp_name.Text)
                .AddWithValue("@p_start_date", dtp_join_date.Value)
                .AddWithValue("@p_end_date", dtp_left_date.Value)
                .AddWithValue("@post", tb_post.Text)
            End With

            result += employeeDb(sql, sqlcmd)

            sql = "INSERT INTO Salary_information (emp_id,firstname, lastname, monthly_sal, monthly_taxes, monthly_allowance, monthly_insurances)
               SELECT emp_id, @firstname, @lastname, @monthly_sal, @monthly_taxes, @monthly_allowance, @monthly_insurances
               FROM       Emp_basic_details
               WHERE                      firstname = @emp_firstname AND lastname = @emp_lastname"

            sqlcmd = New SqlCommand(sql, sqlCon)

            With sqlcmd.Parameters
                .AddWithValue("@firstname", tb_firstname.Text)
                .AddWithValue("@lastname", tb_lastname.Text)
                .AddWithValue("@emp_firstname", tb_firstname.Text)
                .AddWithValue("@emp_lastname", tb_lastname.Text)
                .AddWithValue("@monthly_sal", tb_sal.Text)
                .AddWithValue("@monthly_allowance", tb_allow.Text)
                .AddWithValue("@monthly_insurances", tb_insure.Text)
                .AddWithValue("@monthly_taxes", tb_taxes.Text)
            End With

            result += employeeDb(sql, sqlcmd)

            sql = "INSERT INTO Contact_person_info (emp_id,c_firstname,c_lastname,c_email,c_mob,c_city,c_address,c_zipcode)
               Select emp_id,@c_firstname,@c_lastname,@c_email,@c_mob,@c_city,@c_address,@c_zipcode 
               FROM       Emp_basic_details               
               WHERE    firstname = @firstname AND lastname = @lastname "

            sqlcmd = New SqlCommand(sql, sqlCon)

            With sqlcmd.Parameters
                .AddWithValue("@c_firstname", tb_firstname.Text)
                .AddWithValue("@c_lastname", tb_lastname.Text)
                .AddWithValue("@firstname", tb_firstname.Text)
                .AddWithValue("@lastname", tb_lastname.Text)
                .AddWithValue("@c_city", tb_city.Text)
                .AddWithValue("@c_address", tb_add.Text)
                .AddWithValue("@c_zipcode", tb_zip.Text)
                .AddWithValue("@c_email", tb_email.Text)
                .AddWithValue("@c_mob", tb_mob.Text)
            End With

            result += employeeDb(sql, sqlcmd)

            If cb_addLoginUser.Checked Then 'add user to login_users table if checked
                sql = "INSERT INTO Login_users (emp_id,usertype,username,passwd)
                SELECT emp_id,@usertype,@username,@passwd
                FROM       Emp_basic_details
                WHERE   firstname = @firstname AND lastname = @lastname"

                sqlcmd = New SqlCommand(sql, sqlCon)

                With sqlcmd.Parameters
                    .AddWithValue("@firstname", tb_firstname.Text)
                    .AddWithValue("@lastname", tb_lastname.Text)
                    .AddWithValue("@username", tb_firstname.Text)
                    .AddWithValue("@passwd", tb_lastname.Text)
                    .AddWithValue("@usertype", "user")
                End With

                result += employeeDb(sql, sqlcmd)

            End If

            If result >= 4 Then
                MessageBox.Show("New Employee Added!")
            End If

        Catch ex As Exception
            MessageBox.Show(MessageBoxIcon.Error, ex.Message(), "Something went wrong try again")
        End Try

    End Sub

    Public Sub updateEmp()
        Dim result As Integer = 0

        Try
            sql = "UPDATE Emp_basic_details
               SET  firstname = @firstname, marital_status = @marital_status, gender = @gender, end_date = @end_date, 
                    start_date = @start_date, curr_exp = @curr_exp, qualification = @qualification, zipcode = @zipcode, 
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
                .AddWithValue("@curr_exp", tb_exp.Text)
                .AddWithValue("@start_date", dtp_join_date.Text)
                .AddWithValue("@end_date", dtp_left_date.Text)
                .AddWithValue("@gender", gender)
                .AddWithValue("@marital_status", maritalStatus)
                .AddWithValue("@emp_id", search_id)
            End With

            result = employeeDb(sql, sqlcmd)

            sql = "UPDATE Contact_person_info
               SET    c_firstname =@c_firstname, c_zipcode =@c_zipcode, c_address =@c_address, c_city =@c_city,
                    c_mob =@c_mob, c_email =@c_email, c_lastname =@c_lastname
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
                .AddWithValue("@emp_id", search_id)
            End With

            result += employeeDb(sql, sqlcmd)

            sql = "UPDATE  Work_history
              SET   comp_name = @comp_name, post = @post, p_end_date = @p_end_date, p_start_date = @p_start_date, 
                    emp_name = @emp_name
              WHERE   emp_id = @emp_id"

            sqlcmd = New SqlCommand(sql, sqlCon)

            With sqlcmd.Parameters
                .AddWithValue("@emp_name", tb_firstname.Text)
                .AddWithValue("@comp_name", tb_comp_name.Text)
                .AddWithValue("@p_start_date", dtp_join_date.Text)
                .AddWithValue("@p_end_date", dtp_left_date.Text)
                .AddWithValue("@post", tb_post.Text)
                .AddWithValue("@emp_id", search_id)
            End With

            result += employeeDb(sql, sqlcmd)



            sql = " Update  Salary_information
                SET    firstname = @firstname, monthly_insurances = @monthly_insurances, monthly_allowance = @monthly_allowance,
                        monthly_taxes = @monthly_taxes, monthly_sal = @monthly_sal, lastname = @lastname
                WHERE   emp_id = @emp_id"

            sqlcmd = New SqlCommand(sql, sqlCon)

            With sqlcmd.Parameters
                .AddWithValue("@firstname", tb_firstname.Text)
                .AddWithValue("@lastname", tb_lastname.Text)
                .AddWithValue("@monthly_sal", tb_sal.Text)
                .AddWithValue("@monthly_allowance", tb_allow.Text)
                .AddWithValue("@monthly_insurances", tb_insure.Text)
                .AddWithValue("@monthly_taxes", tb_taxes.Text)
                .AddWithValue("@emp_id", search_id)
            End With

            result += employeeDb(sql, sqlcmd)

            If cb_addLoginUser.Checked = False Then 'add user to login_users table if checked
                sql = "DELETE FROM Login_users WHERE emp_id=" & search_id
                result += employeeDS(sql)
            Else

                If Not checkQuery("SELECT COUNT(emp_id) FROM Emp_basic_details WHERE emp_id=" & search_id) = 1 Then

                    sql = "INSERT INTO Login_users (emp_id,usertype,username,passwd)
                SELECT emp_id,@usertype,@username,@passwd
                FROM       Emp_basic_details
                WHERE   firstname = @firstname AND lastname = @lastname"

                    sqlcmd = New SqlCommand(sql, sqlCon)

                    With sqlcmd.Parameters
                        .AddWithValue("@firstname", tb_firstname.Text)
                        .AddWithValue("@lastname", tb_lastname.Text)
                        .AddWithValue("@username", tb_firstname.Text)
                        .AddWithValue("@passwd", tb_lastname.Text)
                        .AddWithValue("@usertype", "user")
                    End With

                    result += employeeDb(sql, sqlcmd)

                End If
            End If

            If result >= 4 Then
                MessageBox.Show("New Employee Added!")
            End If

        Catch ex As Exception
            MessageBox.Show(MessageBoxIcon.Error, ex.Message(), "Something went wrong try again")
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
        If Not Regex.IsMatch(tb_qual.Text, rgx_str) Or String.IsNullOrEmpty(tb_qual.Text) Then
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
        If String.IsNullOrEmpty(tb_comp_name.Text) Then
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
