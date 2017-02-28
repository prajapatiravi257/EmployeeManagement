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

    Private Sub DGV_leavelist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_leavelist.CellClick

    End Sub
End Class