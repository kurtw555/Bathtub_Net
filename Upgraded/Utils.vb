Imports System.Windows.Forms
Public Module Utils

    Public Function GetUserInput(prompt As String) As String
        Dim input As String = InputBox(prompt, "User Input")
        Return input
    End Function


End Module
