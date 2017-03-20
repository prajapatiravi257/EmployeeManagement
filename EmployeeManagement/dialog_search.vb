Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class dialog_search

    Private Function getEmpDetail(sql As String)
        Try

            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If

            sqlcmd = New SqlCommand(sql, sqlCon)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader()

            'If dr.HasRows Then
            '    While dr.Read()
            '    End While
            'End If
            Return dr

        Catch ex As Exception
            MessageBox.Show("Something went wrong" & ex.Message)
        End Try
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If String.IsNullOrEmpty(tb_search_name.Text) Or Regex.IsMatch(tb_search_id.Text, rgx_digit) Then
            sql = "SELECT Emp_basic_details.*, Salary_information.monthly_sal, Salary_information.monthly_taxes, Salary_information.monthly_deduct, Salary_information.monthly_insurances, Work_history.comp_name, 
                          Work_history.emp_name, Work_history.p_start_date
                   FROM   Emp_basic_details INNER JOIN
                          Salary_information ON Emp_basic_details.emp_id = Salary_information.emp_id INNER JOIN
                          Work_history ON Emp_basic_details.emp_id = Work_history.emp_id
                   WHERE  emp_id = " & tb_search_id.Text & " OR firstname='" & tb_search_name.Text & "' AND lastname='" & tb_search_lastname.Text & "'"

        Else
            MessageBox.Show("Enter the Employee ID and employee name first")

        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
