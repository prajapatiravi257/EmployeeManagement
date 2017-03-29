Public Class frm_login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If Not (String.IsNullOrWhiteSpace(tb_username.Text) And String.IsNullOrEmpty(tb_passwd.Text)) Then
            If userLogin(tb_username, tb_passwd) = True Then
                Me.Close()
                loginSuccess = False
            End If
        Else
            MessageBox.Show("Enter your credentails")
        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Close()
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_username.Focus()
    End Sub
End Class
