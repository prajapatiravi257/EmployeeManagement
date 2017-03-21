Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class dialog_search

    Private Function getEmpDetail(sql As String, update_person As dialog_add_person)
        Try

            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If

            sqlcmd = New SqlCommand(sql, sqlCon)
            Dim dr As SqlDataReader
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

                    If dr("username").ToString() Then

                    End If

                    With update_person
                        .Show()
                        .Name = "Update Person"
                        .tb_firstname.Text = dr("firstname").ToString()
                        .tb_lastname.Text = dr("lastname").ToString()
                        .tb_email.Text = dr("email").ToString()
                        .dtp_dob.Text = dr("dob").ToString()
                        .tb_mob.Text = dr("mob").ToString()
                        .tb_city.Text = dr("city").ToString()
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
            End If

            Return dr

        Catch ex As Exception
            MessageBox.Show("Something went wrong" & ex.Message)
        End Try
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If String.IsNullOrEmpty(tb_search_name.Text) And String.IsNullOrEmpty(tb_search_name.Text) Or Regex.IsMatch(tb_search_id.Text, rgx_digit) Then
            sql = "SELECT Emp_basic_details.*, Salary_information.monthly_sal, Salary_information.monthly_taxes, Salary_information.monthly_deduct, Salary_information.monthly_insurances, Work_history.comp_name, 
                          Work_history.emp_name, Work_history.p_start_date
                   FROM   Emp_basic_details INNER JOIN
                          Salary_information ON Emp_basic_details.emp_id = Salary_information.emp_id INNER JOIN
                          Work_history ON Emp_basic_details.emp_id = Work_history.emp_id
                   WHERE  emp_id = " & tb_search_id.Text & " OR firstname='" & tb_search_name.Text & "' AND lastname='" & tb_search_lastname.Text & "'"

            Me.DialogResult = DialogResult.OK
            Me.Close()
            Dim update_person As New dialog_add_person()


        Else
            Me.DialogResult = DialogResult.None

            MessageBox.Show("Enter the Employee ID And employee name first")

        End If


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
