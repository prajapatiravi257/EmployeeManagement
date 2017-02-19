Public Class admin

    Private Sub btn_newperson_Click(sender As Object, e As EventArgs) Handles btn_newperson.Click
        Dim dialogbox As dialog_add_person = New dialog_add_person()
        dialogbox.ShowDialog()

    End Sub


    Private Sub llbl_logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_logout.LinkClicked
        Dim login As Login = New Login()
        login.Show()
        Me.Close()

    End Sub

End Class