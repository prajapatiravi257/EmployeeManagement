Imports System.Data.SqlClient

Public Class frm_user
    Dim dr As SqlDataReader
    Dim sql As String
    Dim numDays, paidleave As Integer
    Dim leave_date As String

    Private Sub getEmpInfo()
        Dim loginPage As New frm_login()

        sql = "SELECT emp_id, firstname, lastname,email, dob, mob, city, address, zipcode, qualification, married_status FROM Emp_basic_details WHERE firstname='" & username & "'" ' AND lastname='" & loginPage.passwd & "'"

        Try

            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If

            sqlcmd = New SqlCommand(sql, sqlCon)

            dr = sqlcmd.ExecuteReader()

            If dr.HasRows Then

                While dr.Read()
                    lbl_val_empid.Text = dr("emp_id").ToString()
                    lbl_val_empName.Text = dr("firstname").ToString() & " " & dr("lastname").ToString()
                    lbl_val_dob.Text = dr("dob").ToString()
                    tb_firstname.Text = dr("firstname").ToString()
                    tb_lastname.Text = dr("lastname").ToString()
                    tb_email.Text = dr("email").ToString()
                    dtp_dob.Text = lbl_val_dob.Text
                    tb_mob.Text = dr("mob").ToString()
                    tb_city.Text = dr("city").ToString()
                    tb_add.Text = dr("address").ToString()
                    tb_zip.Text = dr("zipcode").ToString()
                    tb_qual.Text = dr("qualification").ToString()
                    If dr("marital_status").ToString() = "Married" Then
                        rb_married.Checked = True
                    Else
                        rb_single.Checked = True
                    End If

                End While
                closeDR(dr)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        sqlCon.Close()

    End Sub


    Private Sub applyLeaves()

        Dim sr As SelectionRange = MonthCalendar_leaveDatePicker.SelectionRange
        numDays = sr.End.Subtract(sr.Start).Days + 1

        leave_date = sr.Start.ToString() & "-" & sr.End.ToString()

        If checkBox_addToPaidLeave.Checked Then
            paidleave = numDays
        Else
            paidleave = 0
        End If

        Try

            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If


            sql = "INSERT INTO Emp_leaves(emp_id,emp_name,leave_date,numOfDays,leave_reason,paid_leave) 
               values(@emp_id,@emp_name,@leave_date,@numOfDays,@leave_reason,@paid_leave)"

            sqlcmd = New SqlCommand(sql, sqlCon)
            With sqlcmd.Parameters
                .AddWithValue("@emp_id", lbl_val_empid.Text)
                .AddWithValue("@emp_name", lbl_val_empName.Text)
                .AddWithValue("@leave_date", leave_date)
                .AddWithValue("@numOfDays", numDays)
                .AddWithValue("@leave_reason", tb_reason.Text)
                .AddWithValue("@paid_leave", paidleave)

            End With
            sqlcmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        sqlCon.Close()

    End Sub

    Private Sub btn_appl_Click(sender As Object, e As EventArgs) Handles btn_appl.Click
        applyLeaves()
    End Sub


    Private Sub llbl_logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_logout.LinkClicked
        logout(Me) 'logout function call with form parameter
    End Sub


    Private Sub frm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Events' table. You can move, or remove it, as needed.
        Me.EventsTableAdapter.Fill(Me.EmployeeManagementDataSet.Events)
        'TODO: This line of code loads data into the 'EmployeeManagementDataSet.Holiday_info' table. You can move, or remove it, as needed.
        Me.Holiday_infoTableAdapter.Fill(Me.EmployeeManagementDataSet.Holiday_info)

        getEmpInfo()
        RW_textboxes(True)
        btn_update.Enabled = False

    End Sub

    Private Sub btn_personalInfo_edit_Click(sender As Object, e As EventArgs) Handles btn_personalInfo_edit.Click
        RW_textboxes(False)
        btn_update.Enabled = True
        btn_personalInfo_edit.Enabled = False

    End Sub

    Private Sub empUpdate()
        sql = "UPDATE Emp_basic_details SET 
firstname= '" & tb_firstname.Text & "', lastname ='" & tb_lastname.Text & "', email ='" & tb_email.Text & "', dob='" & dtp_dob.Text &
                       "', mob=" & tb_mob.Text & ", city='" & tb_city.Text & "', address='" & tb_add.Text & "', zipcode=" & tb_zip.Text &
                       ", qualification='" & tb_qual.Text & "', married_status='" & maritalStatus & "'
        WHERE emp_id=" & lbl_val_empid.Text

        employeeINST(sql)

    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        empUpdate()
        btn_personalInfo_edit.Enabled = True
    End Sub


    Private Sub RW_textboxes(rw As Boolean)
        Dim tb As TextBox

        If Not rw Then
            For Each ctrl As Control In gb_personal_info.Controls
                If TypeOf ctrl Is TextBox Then
                    tb = CType(ctrl, TextBox)
                    tb.ReadOnly = False
                End If
            Next

        Else
            For Each ctrl As Control In gb_personal_info.Controls
                If TypeOf ctrl Is TextBox Then
                    tb = CType(ctrl, TextBox)
                    tb.ReadOnly = True
                End If
            Next

        End If

    End Sub
End Class