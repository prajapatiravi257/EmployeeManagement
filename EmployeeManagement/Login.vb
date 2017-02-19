Imports System.Text.RegularExpressions

Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        userLogin(UsernameTextBox, PasswordTextBox)
        If loginSuccess = True Then
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim errorProvider1 As ErrorProvider = New ErrorProvider()


    Private Sub PasswordTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PasswordTextBox.Validating
        If (String.IsNullOrEmpty(PasswordTextBox.Text)) Then

            errorProvider1.SetError(PasswordTextBox, "Password required!")

        ElseIf (Not Regex.IsMatch(PasswordTextBox.Text, "[A-Za-z][A-Za-z0-9]{2,7}")) Then

            errorProvider1.SetError(PasswordTextBox, "Password invalid!")

        Else

            errorProvider1.SetError(PasswordTextBox, Nothing)

        End If

    End Sub
End Class
