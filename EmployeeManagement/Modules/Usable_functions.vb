Imports System.Data.SqlClient

Module Usable_functions
    Dim result As Int32 = 0

    Public Function checkQuery(query As String) As Integer
        sqlcmd = New SqlCommand(query, sqlCon)

        Try
            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If

            result = Convert.ToInt32(sqlcmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        sqlCon.Close()

        Return Result

    End Function

    Public Function deleteRow_DGV(sql As String, DGV As DataGridView) As Integer
        Try
            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If
            sqlcmd = New SqlCommand(sql, sqlCon)


            result = Convert.ToInt32(sqlcmd.ExecuteScalar())

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return result
    End Function
End Module
