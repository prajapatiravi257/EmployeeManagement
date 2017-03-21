Imports Microsoft.Reporting.WinForms

Public Class frm_admin

    Dim sql As String

    Private Sub btn_newperson_Click(sender As Object, e As EventArgs) Handles btn_newperson.Click
        Dim dialogbox As New dialog_add_person()
        dialogbox.ShowDialog()
        dialogbox.tb_firstname.Focus()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim dialogbox As New dialog_search()
        dialogbox.ShowDialog()

    End Sub
    Private Sub llbl_logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_logout.LinkClicked
        logout(Me)
    End Sub

    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Emp_basic_details' table. You can move, or remove it, as needed.
        Me.Emp_basic_detailsTableAdapter.Fill(Me.EmployeeManagementDataSet.Emp_basic_details)

    End Sub


    Private Sub btn_new_event_Click(sender As Object, e As EventArgs) Handles btn_new_event.Click
        sql = "INSERT INTO Events(event_name,event_date) 
                VALUES('" & tb_events.Text & "','" & dtp_event_date.Text & "')"

        employeeINST(sql)

    End Sub

    Private Sub btn_add_holidays_Click(sender As Object, e As EventArgs) Handles btn_add_holidays.Click
        sql = "INSERT INTO Events(holiday_name,holiday_date) 
                VALUES('" & tb_holidayName.Text & "','" & dtp_holidayDate.Text & "')"
        employeeINST(sql)

    End Sub


End Class