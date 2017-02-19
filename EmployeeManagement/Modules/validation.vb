Imports System.Net.Mail
Imports System.Text.RegularExpressions

Module validation

    Public Const rgx_zipcode As String = "^\d{6}$"
    Public Const rgx_mob As String = "/^(7|8|9)\d{9}$/"
    Public Const rgx_str As String = "^[A-Za-z]+$"
    Public Const rgx_digit As String = "[^\d]"



    Public Function validationcheck() As Boolean
        Dim addpersondialog As New dialog_add_person()
        Dim ErrorProvider As ErrorProvider = New ErrorProvider


        Dim isValid As Boolean = False
        For Each c As Control In addpersondialog.gb_basic_info.Controls
            If TypeOf c Is TextBox Then
                If (CType(c, TextBox).Text.Trim() = String.Empty) Then
                    ErrorProvider.SetError(c, "Required field.")
                    isValid = False
                    Exit For
                Else 'If (CType(c, TextBox).Text.Trim()  String.Empty) Then
                    ErrorProvider.SetError(c, "")
                    isValid = True
                    Continue For
                End If
            End If
        Next
        Return isValid

    End Function


    Public Function ValidateEmail(ByVal strCheck As String) As Boolean
        Try
            Dim vEmailAddress As New MailAddress(strCheck)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function


End Module
