Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class dialog_search

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If Regex.IsMatch(tb_search_id.Text, rgx_emp_id) Then

            Dim update_person As New dialog_add_person()
            search_id = CInt(tb_search_id.Text)
            getEmpDetail(update_person)
            Me.DialogResult = DialogResult.OK

        Else
            Me.DialogResult = DialogResult.None

            MessageBox.Show("Enter the Employee ID")

        End If

    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub getEmpDetail(update_person As dialog_add_person)

        sql = "SELECT Emp_basic_details.*, Login_users.username, Salary_information.monthly_sal, Salary_information.monthly_taxes, Salary_information.monthly_allowance, Salary_information.monthly_insurances, 
                          Work_history.comp_name, Work_history.p_start_date, Work_history.p_end_date, Work_history.post
                   FROM   Emp_basic_details INNER JOIN
                          Login_users ON Emp_basic_details.emp_id = Login_users.emp_id INNER JOIN
                          Salary_information ON Emp_basic_details.emp_id = Salary_information.emp_id INNER JOIN
                          Work_history ON Emp_basic_details.emp_id = Work_history.emp_id
                   WHERE  Emp_basic_details.emp_id = " & search_id

        Try

            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If
            Dim dr As SqlDataReader

            sqlcmd = New SqlCommand(sql, sqlCon)
            dr = sqlcmd.ExecuteReader()

            If dr.HasRows Then
                While dr.Read()

                    If dr("marital_status").ToString() = "Married" Then
                        update_person.rb_married.Checked = True
                    Else
                        update_person.rb_single.Checked = True
                    End If


                    If dr("gender").ToString() = "Male" Then
                        update_person.rb_male.Checked = True
                    Else
                        update_person.rb_single.Checked = True
                    End If

                    If dr("username").ToString().Length() <= 0 Then
                        update_person.cb_addLoginUser.Checked = True
                    Else
                        update_person.cb_addLoginUser.Checked = True
                    End If

                    With update_person
                        .Show()
                        .BringToFront()
                        .Text = "Update Person"
                        .btn_save.Text = "Update"
                        .tb_firstname.Text = dr("firstname").ToString()
                        .tb_lastname.Text = dr("lastname").ToString()
                        .tb_email.Text = dr("email").ToString()
                        .dtp_dob.Text = dr("dob").ToString()
                        .tb_mob.Text = dr("mob").ToString()
                        .tb_city.Text = dr("city").ToString()
                        .tb_exp.Text = dr("curr_exp").ToString()
                        .tb_add.Text = dr("address").ToString()
                        .tb_zip.Text = dr("zipcode").ToString()
                        .tb_qual.Text = dr("qualification").ToString()
                        .tb_comp_name.Text = dr("comp_name").ToString()
                        .tb_post.Text = dr("post").ToString()
                        .dtp_join_date.Text = dr("start_date").ToString()
                        .dtp_left_date.Text = dr("end_date").ToString()
                        .tb_sal.Text = dr("monthly_sal").ToString()
                        .tb_taxes.Text = dr("monthly_taxes").ToString()
                        .tb_insure.Text = dr("monthly_insurances").ToString()
                        .tb_allow.Text = dr("monthly_allowance").ToString()
                    End With
                End While
                Me.Close()
            Else
                MessageBox.Show("Not Found!")
            End If

            closeDR(dr)
            updateEmpInfo = True
        Catch ex As Exception
            MessageBox.Show("Something went wrong " & ex.Message)
        End Try
    End Sub

    Private Sub dialog_search_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        tb_search_id.Focus()
    End Sub
End Class
