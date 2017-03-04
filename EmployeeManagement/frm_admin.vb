Public Class frm_admin
    Private Sub btn_newperson_Click(sender As Object, e As EventArgs) Handles btn_newperson.Click
        Dim dialogbox As New dialog_add_person()
        dialogbox.ShowDialog()
        dialogbox.tb_firstname.Focus()
    End Sub

    Private Sub llbl_logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_logout.LinkClicked
        logout(Me)
    End Sub

    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Holiday_info' table. You can move, or remove it, as needed.
        Me.Holiday_infoTableAdapter.Fill(Me.EmployeeManagementDataSet.Holiday_info)
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Contact_person_info' table. You can move, or remove it, as needed.
        Me.Contact_person_infoTableAdapter.Fill(Me.EmployeeManagementDataSet.Contact_person_info)
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Work_history' table. You can move, or remove it, as needed.
        Me.Work_historyTableAdapter.Fill(Me.EmployeeManagementDataSet.Work_history)
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Emp_basic_details' table. You can move, or remove it, as needed.
        Me.Emp_basic_detailsTableAdapter.Fill(Me.EmployeeManagementDataSet.Emp_basic_details)

    End Sub

    Private Sub dgv_emp_info_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_emp_info.CellContentClick

    End Sub
End Class