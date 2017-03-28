
Imports System.Data.SqlClient

Public Class frm_admin
    Dim result As Integer
    Dim sql As String

    Private Sub btn_newperson_Click(sender As Object, e As EventArgs) Handles btn_newperson.Click
        Dim add_person As New dialog_add_person()
        add_person.ShowDialog()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim search As New dialog_search()
        search.ShowDialog()
    End Sub
    Private Sub llbl_logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_logout.LinkClicked
        logout(Me)
    End Sub

    Private Sub btn_delete_event_Click(sender As Object, e As EventArgs) Handles btn_delete_event.Click
        If (MessageBox.Show("Are you Sure, You want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            EventsBindingSource.RemoveCurrent()
            EventsBindingSource.EndEdit()
            EventsTableAdapter.Update(EmployeeManagementDataSet.Events)
        End If
    End Sub

    Private Sub btn_delete_holiday_Click(sender As Object, e As EventArgs) Handles btn_delete_holiday.Click
        If (MessageBox.Show("Are you Sure, You want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            HolidayinfoBindingSource.RemoveCurrent()
            HolidayinfoBindingSource.EndEdit()
            Holiday_infoTableAdapter.Update(EmployeeManagementDataSet.Holiday_info)
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If (MessageBox.Show("Are you Sure, You want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            Emp_basic_infoBindingSource.RemoveCurrent()
            Emp_basic_infoBindingSource.EndEdit()
            updateDB()
        End If
    End Sub

    Private Sub btn_update_sal_Click(sender As Object, e As EventArgs) Handles btn_update_sal.Click
        If IsNumeric(tb_emp_id) And IsNumeric(tb_sal_amt) And IsNumeric(tb_allow) Then
            If CInt(tb_sal_amt.Text) > 9000 And CInt(tb_allow.Text) Then
                updateSal()
            Else
                MessageBox.Show("Enter a valid amount")
            End If
        Else
            MessageBox.Show("Enter detail first")
        End If

    End Sub

    Private Sub updateSal()
        sqlcmd = New SqlCommand(sql, sqlCon)

        sql = "UPDATE Salary_information
                SET monthly_sal=@monthly_sal,monthly_allowance=@monthly_allowance
                WHERE emp_id=@emp_id"

        With sqlcmd.Parameters
            .AddWithValue("@monthly_sal", tb_sal_amt.Text)
            .AddWithValue("@monthly_allowance", tb_allow.Text)
            .AddWithValue("@emp_id", search_id)
        End With

        If employeeDB(sql, sqlcmd) > 0 Then
            DGV_fill()
            MessageBox.Show("Salary Info Updated!")
        End If
    End Sub

    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_fill()
    End Sub


    Private Sub btn_new_event_Click(sender As Object, e As EventArgs) Handles btn_new_event.Click

        If Not String.IsNullOrEmpty(tb_events.Text) And dtp_event_date.Value > Date.Today() Then

            sql = "INSERT INTO Events(event_name,event_date) 
                VALUES('" & tb_events.Text & "','" & dtp_event_date.Text & "')"

            result = employeeDB(sql)
            If result > 0 Then
                MessageBox.Show("New Event ADDED!")
            End If
        Else
            MessageBox.Show("Enter detail first!")
        End If

    End Sub

    Private Sub btn_add_holidays_Click(sender As Object, e As EventArgs) Handles btn_add_holidays.Click
        If Not String.IsNullOrEmpty(tb_holidayName.Text) And dtp_holidayDate.Value > Date.Today Then

            sql = "INSERT INTO Events(holiday_name,holiday_date) 
                VALUES('" & tb_holidayName.Text & "','" & dtp_holidayDate.Text & "')"

            result = employeeDB(sql)

            If result > 0 Then
                MessageBox.Show("Holiday ADDED!")
            End If
        Else
            MessageBox.Show("Enter detail first!")
        End If

    End Sub


    Private Sub frm_admin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        dtp_event_date.MaxDate = Date.Today.AddYears(1)
        dtp_event_date.MinDate = Date.Today.AddDays(1)
        dtp_holidayDate.MaxDate = Date.Today.AddYears(1)
        dtp_holidayDate.MinDate = Date.Today.AddDays(1)
    End Sub
    Private Sub DGV_fill()
        Me.Salary_informationTableAdapter.Fill(Me.EmployeeManagementDataSet.Salary_information)

        Me.Emp_basic_detailsTableAdapter.Fill(Me.EmployeeManagementDataSet.Emp_basic_details)

        Me.EventsTableAdapter.Fill(Me.EmployeeManagementDataSet.Events)

        Me.Emp_leavesTableAdapter.Fill(Me.EmployeeManagementDataSet.Emp_leaves)

        Me.Holiday_infoTableAdapter.Fill(Me.EmployeeManagementDataSet.Holiday_info)

        Me.Contact_person_infoTableAdapter.Fill(Me.EmployeeManagementDataSet.Contact_person_info)

        Me.Work_historyTableAdapter.Fill(Me.EmployeeManagementDataSet.Work_history)

    End Sub
    Public Sub updateDB()

        Emp_basic_detailsTableAdapter.Update(EmployeeManagementDataSet.Emp_basic_details)
        Work_historyTableAdapter.Update(EmployeeManagementDataSet.Work_history)
        Contact_person_infoTableAdapter.Update(EmployeeManagementDataSet.Contact_person_info)
        Salary_informationTableAdapter.Update(EmployeeManagementDataSet.Salary_information)
        Emp_leavesTableAdapter.Update(EmployeeManagementDataSet.Emp_leaves)

    End Sub

End Class