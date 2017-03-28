Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports EmployeeManagement.EmployeeManagementDataSetTableAdapters

Module connection

    Public conString As String = "Data Source=DESKTOP-KKN0DTS;Initial Catalog=EmployeeManagement; MultipleActiveResultSets=True; User ID=sa;Password=123456"
    Public sqlCon As New SqlConnection(conString)
    Public dataAdapter As SqlDataAdapter
    Public sqlcmd As SqlCommand
    Public sql_dr As SqlDataReader
    Public dt As DataTable
    Public loginSuccess As Boolean = False
    Public sql As String
    Public errorProvider As New ErrorProvider()
    Public todayDate As String = Format(Date.Today, "dd/MM/yyyy").ToString()
    Public gender, maritalStatus As String
    Public search_id As Integer
    Public updateEmpInfo As Boolean = False
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
    Public Function employeeDB(sql As String) As Integer
        Dim result As Integer

        Try
            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If

            sqlcmd = New SqlCommand(sql, sqlCon)

            dataAdapter = New SqlDataAdapter(sqlcmd)

            dt = New DataTable()

            result = dataAdapter.Fill(dt)
            result = sqlcmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        sqlCon.Close()
        Return result

    End Function

    Public Function employeeDB(sql As String, sqlcmd As SqlCommand) As Integer
        Dim result As Integer

        Try
            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If

            result = sqlcmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        sqlCon.Close()
        Return result

    End Function
    Public Function userLogin(ByVal user As TextBox, ByVal passwd As TextBox) As Boolean

        username = user.Text
        password = passwd.Text

        Dim query As String = "SELECT usertype,username FROM Login_users WHERE username='" + username + "' AND passwd='" + password + "'"

        Try
            If Not sqlCon.State = ConnectionState.Open Then
                sqlCon.Open()
            End If

            sqlcmd = New SqlCommand(query, sqlCon)

            sql_dr = sqlcmd.ExecuteReader()

            Dim type, loginuser As String

            If sql_dr.Read() And sql_dr.HasRows Then

                type = sql_dr("usertype").ToString()
                loginuser = sql_dr("username").ToString().ToUpper()
                loginSuccess = True

                If type = "admin" Then

                    Dim adminpage As New frm_admin()

                    With adminpage
                        .Show()                     'trigger adminpage
                        .lbl_loginuser.Text = loginuser + " (Administrator)" 'add username login text
                    End With

                Else

                    Dim userPage As New frm_user()

                    With userPage
                        .Show()                     'trigger userpage 
                        .lbl_loginuser.Text = loginuser  'add username login text
                    End With

                End If

            Else
                loginCountCheck(user, passwd)

            End If

            closeDR(sql_dr)
            sqlCon.Close()

        Catch ex As Exception
            MsgBox("account does not exist!", MsgBoxStyle.Exclamation, "Failed to login with exception")

        End Try

        Return loginSuccess

    End Function

    Private Sub loginCountCheck(user As TextBox, passwd As TextBox)
        'integer variable to count the number of times, the user has tried loggin in
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
                    MessageBox.Show("High value of failed login attempts Application will be terminated" &
                                       " for security reasons", "Error", MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop)
                    End 'terminate application
                End If
            Case DialogResult.Cancel
                Application.Exit()  'terminate application

        End Select

    End Sub



End Module
