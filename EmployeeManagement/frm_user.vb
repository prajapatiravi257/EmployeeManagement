Imports System.Data.SqlClient

Public Class frm_user
    Public Const totalPaidLeave As Integer = 20
    Public leaveLeft As Integer = 0
    Public UnpaidLeaves As Integer = 0
    Public numDays As Integer
    Public leaveReason As String

    Private Sub updateLeaves()
        tb_total_leaves.Text = totalPaidLeave
        tb_leaves_left.Text = leaveLeft
        tb_extra_leaves.Text = UnpaidLeaves
    End Sub


    Private Sub getLeave()
        Try
            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If
            Dim query As String = "SELECT extra_leave,leaves_left,total_leave FROM Emp_leaves FROM Emp_leaves"
            dataAdapter = New SqlDataAdapter()
            sqlcmd = New SqlCommand(query, sqlCon)
            ds = New DataSet("Emp_management")
            dataAdapter.Fill(ds)
            tb_extra_leaves.DataBindings.Add("number", ds.Tables("Emp_leave"), "extra_leave")
            tb_leaves_left.DataBindings.Add("number", ds.Tables("Emp_leave"), "leaves_left")
            tb_total_leaves.DataBindings.Add("number", ds.Tables("Emp_leave"), "total_leave")
            sqlCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btn_appl_Click(sender As Object, e As EventArgs) Handles btn_appl.Click
        leaveReason = tb_reason.Text
        Dim sr As SelectionRange = MonthCalendar_leaveDatePicker.SelectionRange
        numDays = sr.End.Subtract(sr.Start).Days + 1
        If Not String.IsNullOrWhiteSpace(tb_reason.Text) Then
            leaveReason = tb_reason.Text

            If checkBox_addToPaidLeave.Checked Then
                leaveLeft = totalPaidLeave - numDays
            Else
                UnpaidLeaves += numDays
            End If

        End If

        updateLeaves()

    End Sub

    Private Sub checkBox_addToPaidLeave_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox_addToPaidLeave.CheckedChanged
        If leaveLeft <> 0 Then
            MsgBox("No Paid Leaves Left")
        End If
    End Sub

    Private Sub llbl_logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_logout.LinkClicked
        Dim login As frm_login = New frm_login()
        login.Show()
        Me.Close()
    End Sub
End Class