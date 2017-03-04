Imports System.Data.SqlClient

Public Class frm_user
    Dim dr As SqlDataReader

    Private Sub getLeave()
        Try
            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If

            Dim query As String = "SELECT extra_leave,leaves_left,total_leave FROM Emp_leaves"

            sqlcmd = New SqlCommand(query, sqlCon)

            dr = sqlcmd.ExecuteReader()

            If dr.HasRows Then
                While dr.Read()

                    tb_extra_leaves.Text = dr(0).ToString()
                    tb_leaves_left.Text = dr(1).ToString()
                    tb_total_leaves.Text = dr(2).ToString()

                End While


                closeDR(dr)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        sqlCon.Close()

    End Sub

    Private Sub getEmpInfo()
        Dim loginPage As New frm_login()

        Dim sql As String = "SELECT emp_id, firstname, lastname,email, dob, mob, city, address, zipcode, qualification, married_status FROM Emp_basic_details WHERE firstname='" & username & "'" ' AND lastname='" & loginPage.passwd & "'"

        Try

            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If

            sqlcmd = New SqlCommand(sql, sqlCon)

            dr = sqlcmd.ExecuteReader()

            If dr.HasRows Then

                While dr.Read()
                lbl_val_empid.Text = dr(0).ToString()
                lbl_val_empName.Text = dr(1).ToString() & " " & dr(2).ToString()
                tb_firstname.Text = dr(1).ToString()
                tb_lastname.Text = dr(2).ToString()
                tb_email.Text = dr(3).ToString()
                lbl_val_dob.Text = dr(4).ToString()
                dtp_dob.Text = dr(4).ToString()
                tb_mob.Text = dr(5).ToString()
                tb_city.Text = dr(6).ToString()
                tb_add.Text = dr(7).ToString()
                tb_zip.Text = dr(8).ToString()
                tb_qual.Text = dr(9).ToString()
                cb_married_status.Text = dr(10).ToString()

            End While
                closeDR(dr)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        sqlCon.Close()

    End Sub

    Private Sub btn_appl_Click(sender As Object, e As EventArgs) Handles btn_appl.Click
        'leaveReason = tb_reason.Text
        'Dim sr As SelectionRange = MonthCalendar_leaveDatePicker.SelectionRange
        'numDays = sr.End.Subtract(sr.Start).Days + 1
        'If Not String.IsNullOrWhiteSpace(tb_reason.Text) Then
        '    leaveReason = tb_reason.Text

        '    If checkBox_addToPaidLeave.Checked Then
        '        leaveLeft = totalPaidLeave - numDays
        '    Else
        '        UnpaidLeaves += numDays
        '    End If

        'End If

    End Sub

    Private Sub checkBox_addToPaidLeave_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox_addToPaidLeave.CheckedChanged
        'If leaveLeft <> 0 Then
        '    MsgBox("No Paid Leaves Left")
        'End If
    End Sub

    Private Sub llbl_logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_logout.LinkClicked
        logout(Me) 'logout function call with form parameter
    End Sub

    Private Sub frm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getLeave()
        getEmpInfo()

    End Sub

    Private Sub RW_textboxes()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then

            End If
        Next
    End Sub
    Private Sub btn_personalInfo_edit_Click(sender As Object, e As EventArgs) Handles btn_personalInfo_edit.Click

    End Sub
End Class