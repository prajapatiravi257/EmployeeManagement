﻿Imports System.Text.RegularExpressions

Public Class dialog_add_person
    Dim gender, sql As String
    Dim datechange As Boolean = False
    Dim errorProvider As ErrorProvider = New ErrorProvider()
    Public sal As Integer


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If rb_male.Checked Then
            gender = "Male"
        Else rb_female.Checked Then
            gender = "Female"
        End If

        Dim EmptyTextBoxFound As Boolean = False 'Boolean flag for empty textbox 
        Dim EmptyTextBoxName As String = ""

        For Each ctl As Control In Me.Controls

            If TypeOf ctl Is TextBox And ctl.Text.Length = 0 Then
                EmptyTextBoxName = ctl.Name
                EmptyTextBoxFound = True
                Exit For
            End If
        Next

        Dim todayDate As String = Format(Date.Today, "dd/MM/yyyy").ToString()

        Try

            If ValidateChildren() = False Then
                DialogResult = DialogResult.None
            Else
                sql = "INSERT INTO Emp_basic_details (firstname, lastname, dob, mob, city, address,
               zipcode, qualification, curr_exp, start_date, gender, married_status)
               VALUES('" & tb_firstname.Text & "', '" & tb_lastname.Text & "', '" & dtp_dob.Text &
                       "', " & tb_mob.Text & ", '" & tb_city.Text & "', '" & tb_add.Text & "', " & tb_zip.Text &
                       ", '" & tb_qual.Text & "', " & tb_exp.Text & ",'" & todayDate & "', '" & gender & "', '" & cb_married_status.Text & "')"
                MessageBox.Show(sql)
                'employeeINST(sql) ' inserts row in Emp_basic_details table

                sql = "INSERT INTO Work_history (comp_name, emp_name, p_start_date, p_end_date, post)
                VALUES ('" & tb_comp_name.Text & "','" & tb_firstname.Text & "','" & dtp_join_date.Text &
                        "','" & dtp_left_date.Text & "','" & tb_qual.Text & "')"
                MessageBox.Show(sql)
                'employeeINST(sql) ' inserts row in Work_history table

                sql = "INSERT INTO Salary_information (monthly_sal, monthly_taxes, monthly_deduct, monthly_insurances)
                VALUES (" & tb_sal.Text & "," & tb_taxes.Text & "," & tb_allow.Text & "," & tb_insure.Text & ")"
                MessageBox.Show(sql)
                'employeeINST(sql)  ' inserts row in Salary_information table

                Me.DialogResult = DialogResult.OK
                Me.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Something went wrong try again")
        End Try

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub tb_firstname_Validated(sender As Object, e As EventArgs) Handles tb_firstname.Validated
        If Not Regex.IsMatch(tb_firstname.Text, rgx_str) Then
            errorProvider.SetError(tb_firstname, "Not a valid name")
        Else
            errorProvider.SetError(tb_firstname, String.Empty)
        End If
    End Sub

    Private Sub tb_lastname_Validated(sender As Object, e As EventArgs) Handles tb_lastname.Validated
        If Not Regex.IsMatch(tb_lastname.Text, rgx_str) Then
            errorProvider.SetError(tb_lastname, "Enter a proper lastname")
        Else
            errorProvider.SetError(tb_lastname, String.Empty)
        End If
    End Sub

    Private Sub tb_mob_Validated(sender As Object, e As EventArgs) Handles tb_mob.Validated
        If Not Regex.IsMatch(tb_mob.Text, rgx_mob) Then
            errorProvider.SetError(tb_mob, "Not a valid Mobile number")
        Else
            errorProvider.SetError(tb_mob, String.Empty)
        End If
    End Sub

    Private Sub tb_qual_Validated(sender As Object, e As EventArgs) Handles tb_qual.Validated
        If Not Regex.IsMatch(tb_qual.Text, rgx_str) Then
            errorProvider.SetError(tb_qual, "Not a valid character")
        Else
            errorProvider.SetError(tb_qual, String.Empty)
        End If
    End Sub

    Private Sub tb_city_Validated(sender As Object, e As EventArgs) Handles tb_city.Validated
        If Not Regex.IsMatch(tb_city.Text, rgx_str) Then
            errorProvider.SetError(tb_city, "Enter a valid city name")
        Else
            errorProvider.SetError(tb_city, String.Empty)
        End If
    End Sub

    Private Sub tb_zip_Validated(sender As Object, e As EventArgs) Handles tb_zip.Validated
        If Not Regex.IsMatch(tb_zip.Text, rgx_zipcode) Then
            errorProvider.SetError(tb_zip, "Not a valid zip code")
        Else
            errorProvider.SetError(tb_zip, String.Empty)
        End If
    End Sub

    Private Sub tb_exp_Validated(sender As Object, e As EventArgs) Handles tb_exp.Validated
        If Not IsNumeric(tb_exp.Text) Then
            errorProvider.SetError(tb_exp, "Enter a valid digit")
        Else
            errorProvider.SetError(tb_exp, String.Empty)
        End If
    End Sub

    Private Sub tb_add_Validated(sender As Object, e As EventArgs) Handles tb_add.Validated
        If Not Regex.IsMatch(tb_add.Text, rgx_str) Then
            errorProvider.SetError(tb_add, "Enter a valid address")
        Else
            errorProvider.SetError(tb_add, String.Empty)
        End If
    End Sub

    Private Sub tb_comp_name_Validated(sender As Object, e As EventArgs) Handles tb_comp_name.Validated
        If Not Regex.IsMatch(tb_comp_name.Text, rgx_str) Then
            errorProvider.SetError(tb_comp_name, "Enter a valid name")
        Else
            errorProvider.SetError(tb_comp_name, String.Empty)
        End If
    End Sub

    Private Sub tb_post_Validated(sender As Object, e As EventArgs) Handles tb_post.Validated
        If Not Regex.IsMatch(tb_post.Text, rgx_str) Then
            errorProvider.SetError(tb_post, "Enter a valid designation")
        Else
            errorProvider.SetError(tb_post, String.Empty)
        End If
    End Sub

    Private Sub tb_sal_Validated(sender As Object, e As EventArgs) Handles tb_sal.Validated
        If Not IsNumeric(tb_sal.Text) Or IsNothing(tb_sal.Text) Then

            errorProvider.SetError(tb_sal, "Enter a valid Number")
        Else
            errorProvider.SetError(tb_sal, String.Empty)
        End If

    End Sub

    Private Sub cb_married_status_Validated(sender As Object, e As EventArgs) Handles cb_married_status.Validated
        If cb_married_status.SelectionLength < 0 Then
            errorProvider.SetError(cb_married_status, "Please Select your maratial status")
        Else
            errorProvider.SetError(cb_married_status, String.Empty)
        End If
    End Sub

    Private Sub tb_allow_Validated(sender As Object, e As EventArgs) Handles tb_allow.Validated
        If Not IsNumeric(tb_allow.Text) Or IsNothing(tb_allow.Text) Then

            errorProvider.SetError(tb_allow, "Enter a valid Number")
        Else
            errorProvider.SetError(tb_allow, String.Empty)
        End If

    End Sub

    Private Sub dtp_dob_Validated(sender As Object, e As EventArgs) Handles dtp_dob.Validated
        If Not dtp_dob.Checked Then
            errorProvider.SetError(dtp_dob, "Enter your Birth date")
        Else
            errorProvider.SetError(dtp_dob, String.Empty)
        End If
    End Sub

    Private Sub dtp_join_date_Validated(sender As Object, e As EventArgs) Handles dtp_join_date.Validated
        If Not dtp_dob.Checked Then
            errorProvider.SetError(dtp_join_date, "Enter your Birth date")
        Else
            errorProvider.SetError(dtp_join_date, String.Empty)
        End If
    End Sub

    Private Sub dtp_left_date_Validated(sender As Object, e As EventArgs) Handles dtp_left_date.Validated
        If Not dtp_dob.Checked Then
            errorProvider.SetError(dtp_left_date, "Enter your Birth date")
        Else
            errorProvider.SetError(dtp_left_date, String.Empty)
        End If
    End Sub

    Private Sub rb_female_CheckedChanged(sender As Object, e As EventArgs) Handles rb_female.CheckedChanged

    End Sub

    Private Sub tb_email_Validated(sender As Object, e As EventArgs) Handles tb_email.Validated
        If ValidateEmail(tb_email.Text) = False Then
            errorProvider.SetError(tb_email, "Enter an valid email id")
        Else
            errorProvider.SetError(tb_email, String.Empty)
        End If
    End Sub

End Class