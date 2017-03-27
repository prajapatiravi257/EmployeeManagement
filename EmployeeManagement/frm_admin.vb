
Imports System.Data.SqlClient

Public Class frm_admin
    Dim result As Integer

    Dim sql As String

    Private Sub btn_newperson_Click(sender As Object, e As EventArgs) Handles btn_newperson.Click
        Dim add_person As New dialog_add_person()
        add_person.Show()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim search As New dialog_search()
        search.Show()

    End Sub
    Private Sub llbl_logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_logout.LinkClicked
        logout(Me)
    End Sub

    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Salary_information' table. You can move, or remove it, as needed.
        Me.Salary_informationTableAdapter.Fill(Me.EmployeeManagementDataSet.Salary_information)
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Emp_basic_details' table. You can move, or remove it, as needed.
        Me.Emp_basic_detailsTableAdapter.Fill(Me.EmployeeManagementDataSet.Emp_basic_details)
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Events' table. You can move, or remove it, as needed.
        Me.EventsTableAdapter.Fill(Me.EmployeeManagementDataSet.Events)
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet1.Emp_leaves' table. You can move, or remove it, as needed.
        Me.Emp_leavesTableAdapter.Fill(Me.EmployeeManagementDataSet.Emp_leaves)
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Holiday_info' table. You can move, or remove it, as needed.
        Me.Holiday_infoTableAdapter.Fill(Me.EmployeeManagementDataSet.Holiday_info)
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Contact_person_info' table. You can move, or remove it, as needed.
        Me.Contact_person_infoTableAdapter.Fill(Me.EmployeeManagementDataSet.Contact_person_info)
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Work_history' table. You can move, or remove it, as needed.
        Me.Work_historyTableAdapter.Fill(Me.EmployeeManagementDataSet.Work_history)

    End Sub


    Private Sub btn_new_event_Click(sender As Object, e As EventArgs) Handles btn_new_event.Click
        sql = "INSERT INTO Events(event_name,event_date) 
                VALUES('" & tb_events.Text & "','" & dtp_event_date.Text & "')"

        result = employeeDS(sql)
        If result > 0 Then
            MessageBox.Show("New Event ADDED!")
        End If
    End Sub

    Private Sub btn_add_holidays_Click(sender As Object, e As EventArgs) Handles btn_add_holidays.Click
        sql = "INSERT INTO Events(holiday_name,holiday_date) 
                VALUES('" & tb_holidayName.Text & "','" & dtp_holidayDate.Text & "')"
        result = employeeDS(sql)
        If result > 0 Then
            MessageBox.Show("Holiday ADDED!")
        End If

    End Sub

    Public Sub updateDB()
        Emp_basic_detailsTableAdapter.Update(EmployeeManagementDataSet.Emp_basic_details)
        Work_historyTableAdapter.Update(EmployeeManagementDataSet.Work_history)
        Contact_person_infoTableAdapter.Update(EmployeeManagementDataSet.Contact_person_info)
        Salary_informationTableAdapter.Update(EmployeeManagementDataSet.Salary_information)
        Emp_leavesTableAdapter.Update(EmployeeManagementDataSet.Emp_leaves)
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If (MessageBox.Show("Are you Sure, You want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            Emp_basic_infoBindingSource.RemoveCurrent()
            updateDB()
        End If
    End Sub

    Private Sub btn_update_sal_Click(sender As Object, e As EventArgs) Handles btn_update_sal.Click


        sqlcmd = New SqlCommand(sql, sqlCon)

        sql = "UPDATE Salary_information
                SET monthly_sal=@monthly_sal,monthly_allowance=@monthly_allowance
                WHERE emp_id=@emp_id"

        With sqlcmd.Parameters
            .AddWithValue("@monthly_sal", tb_sal_amt.Text)
            .AddWithValue("@monthly_allowance", tb_allow.Text)
            .AddWithValue("@emp_id", search_id)
        End With

        If employeeDb(sql, sqlcmd) > 0 Then
            updateDB()
            MessageBox.Show("Salary Info Updated!")
        End If

    End Sub

    Private Sub btn_delete_event_Click(sender As Object, e As EventArgs) Handles btn_delete_event.Click
        If (MessageBox.Show("Are you Sure, You want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            EventsBindingSource.RemoveCurrent()
            updateDB()
        End If
    End Sub

    Private Sub btn_delete_holiday_Click(sender As Object, e As EventArgs) Handles btn_delete_holiday.Click
        If (MessageBox.Show("Are you Sure, You want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            HolidayinfoBindingSource.RemoveCurrent()
            updateDB()
        End If
    End Sub
End Class