Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail

Module connection

    Public conString As String = "Data Source=DESKTOP-KKN0DTS;Initial Catalog=EmployeeManagement; MultipleActiveResultSets=True; User ID=sa;Password=123456"
    Public sqlCon As New SqlConnection(conString)
    Public dataAdapter As SqlDataAdapter
    Public sqlcmd As SqlCommand
    Public sql_dr As SqlDataReader
    Public ds As DataSet
    Public dt As DataTable
    Public loginSuccess As Boolean = False
    Public username, password As String

    Public Sub logout(page As Form)
        Dim login As New frm_login()
        login.Show()
        page.Close()
    End Sub
    Public Sub closeDR(dr As SqlDataReader)
        If Not dr.IsClosed Then
            dr.Close()
        End If
    End Sub
    Public Sub employeeINST(ByVal sql As String)
        Try
            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If
            sqlcmd = New SqlCommand(sql, sqlCon)

            dataAdapter = New SqlDataAdapter(sqlcmd)

            dt = New DataTable()

            dataAdapter.Fill(dt)

        Catch ex As Exception

            MsgBox(ex.Message)

            sqlCon.Close()
        End Try
    End Sub
    Public Sub userLogin(ByVal user As TextBox, ByVal passwd As TextBox)
        username = user.Text
        password = passwd.Text

        Dim query As String = "SELECT * FROM Login_users WHERE username='" + username + "' AND passwd='" + password + "'"

        Try
            If Not sqlCon.State = ConnectionState.Open Then
                sqlCon.Open()
            End If

            sqlcmd = New SqlCommand(query, sqlCon)

            sql_dr = sqlcmd.ExecuteReader()

            Dim type As String

            If sql_dr.Read() And sql_dr.HasRows Then

                type = sql_dr(2).ToString().ToUpper()

                loginSuccess = True

                If user.Text = "admin" Then

                    Dim adminpage As New frm_admin()

                    With adminpage
                        .Show()
                        .lbl_loginuser.Text = type
                    End With

                Else

                    Dim userPage As New frm_user()

                    With userPage
                        .Show()
                        .lbl_loginuser.Text = type
                    End With

                End If

            Else

                'integer variable to count the number of times
                'the user has tried loggin in
                Static count As Integer = 0

                'display promt 
                Dim prompt As DialogResult =
                MessageBox.Show("Invalid Username or Password!", "Login Error",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)

                Select Case prompt

                    Case DialogResult.Retry
                        'keep login displayed for another trial 
                        user.Text = ""
                        passwd.Text = ""
                        count += 1 'increment counter by one 
                        If count = 3 Then
                            MessageBox.Show("High value of failed login attempts " & count &
                                           " Application will be terminated" &
                                       " for security reasons", "Error", MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop)
                            End 'terminate application
                        End If
                    Case DialogResult.Cancel
                        Application.Exit()  'terminate application

                End Select
            End If

            closeDR(sql_dr)
            sqlCon.Close()

        Catch ex As Exception
            MsgBox("account does not exist!", MsgBoxStyle.Exclamation, "Failed to login with exception")

        End Try

    End Sub

End Module
