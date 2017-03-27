Imports System.Net.Mail
Imports System.Text.RegularExpressions

Module validation

    Public Const rgx_zipcode As String = "^\d{6}$"
    Public Const rgx_mob As String = "^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}$"
    Public Const rgx_str As String = "^[A-Za-z]+$"
    Public Const rgx_digit As String = "[^\d]"
    Public Const rgx_emp_id As String = "^\d{4}$"

    Public Function ValidateEmail(ByVal strCheck As String) As Boolean
        Try
            Dim vEmailAddress As New MailAddress(strCheck)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function


End Module
