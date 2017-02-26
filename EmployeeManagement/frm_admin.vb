Public Class frm_admin

    Private Sub btn_newperson_Click(sender As Object, e As EventArgs) Handles btn_newperson.Click
        Dim dialogbox As dialog_add_person = New dialog_add_person()
        dialogbox.ShowDialog()
        dialogbox.tb_firstname.Focus()

    End Sub


    Private Sub llbl_logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_logout.LinkClicked
        Dim login As frm_login = New frm_login()
        login.Show()
        Me.Close()
    End Sub

    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Emp_basic_details' table. You can move, or remove it, as needed.
        Me.Emp_basic_detailsTableAdapter.Fill(Me.EmployeeManagementDataSet.Emp_basic_details)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class