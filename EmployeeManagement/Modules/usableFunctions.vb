Module usableFunctions

    Public Function emptyBoxCheck(ByVal form As Form) As Boolean
        Dim EmptyTextBoxFound As Boolean = False 'Boolean flag for empty textbox 
        Dim EmptyTextBoxName As String = ""

        For Each ctl As Control In form.Controls

            If TypeOf ctl Is TextBox And ctl.Text.Length = 0 Then
                EmptyTextBoxName = ctl.Name
                EmptyTextBoxFound = True
                Exit For
            End If
        Next
        Return EmptyTextBoxFound
    End Function

End Module
