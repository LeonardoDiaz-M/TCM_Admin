Imports System.Text.RegularExpressions
Module clsUtilerias
    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(Trim(email))
        Return (m.Captures.Count <> 0)
    End Function
End Module
