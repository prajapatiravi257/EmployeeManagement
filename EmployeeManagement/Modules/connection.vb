Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail

Module connection
    Public conString As String = "Data Source=DESKTOP-KKN0DTS;Initial Catalog=EmployeeManagement;User ID=sa;Password=123456"
    Public sqlCon As New SqlConnection(conString)
    Public dataAdapter As SqlDataAdapter
    Public sqlcmd As New SqlCommand
    Public sql_dr As SqlDataReader
    Public ds As DataSet
    Public query As SqlCommandBuilder
    Public dt As DataTable
    Public loginSuccess As Boolean = False


    Public Sub addEmployee(ByVal sql As String)
        Try
            If sqlCon.State = False Then
                sqlCon.Open()
            End If
            sqlcmd = New SqlCommand(sql, sqlCon)

            dataAdapter = New SqlDataAdapter(sqlcmd)

            dt = New DataTable
            dataAdapter.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return

        End Try
        sqlCon.Close()
    End Sub

    Public Sub userLogin(ByVal user As TextBox, ByVal passwd As TextBox)

        Dim query As String = "select * from Login_users where username='" + user.Text + "' and passwd='" + passwd.Text + "'"
        Try
            If sqlCon.State = False Then
                sqlCon.Open()
            End If

            sqlcmd = New SqlCommand(query, sqlCon)

            sql_dr = sqlcmd.ExecuteReader
            Dim type As String

            If sql_dr.Read Then
                type = sql_dr.GetString(1)

                If sql_dr.HasRows Then
                    loginSuccess = True

                    Dim adminpage As admin = New admin()

                    With adminpage
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

        Catch ex As Exception
            MsgBox("account does not exist!", MsgBoxStyle.Exclamation, "Failed to login with exception")

        End Try

        sqlCon.Close()

    End Sub

End Module
