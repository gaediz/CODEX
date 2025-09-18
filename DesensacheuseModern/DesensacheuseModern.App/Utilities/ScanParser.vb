Imports System
Imports DesensacheuseModern.Models

Namespace DesensacheuseModern.Utilities
    Public NotInheritable Class ScanParser
        Private Sub New()
        End Sub

        Public Shared Function TryParse(input As String, ByRef result As ScanResult, ByRef errorMessage As String) As Boolean
            result = Nothing
            errorMessage = String.Empty

            If String.IsNullOrWhiteSpace(input) Then
                errorMessage = "Le scan est vide."
                Return False
            End If

            Dim cleaned As String = input.Trim()
            If cleaned.Length < 8 Then
                errorMessage = "Le code scanné est incomplet."
                Return False
            End If

            Dim orderId As String = cleaned.Substring(0, Math.Min(8, cleaned.Length))
            Dim knifeSegmentLength As Integer = Math.Min(4, cleaned.Length)
            Dim knifeSegment As String = cleaned.Substring(cleaned.Length - knifeSegmentLength)
            Dim knifeDigit As Char = knifeSegment(0)

            If Not Char.IsDigit(knifeDigit) Then
                errorMessage = "Le numéro de couteau est invalide."
                Return False
            End If

            Dim knifeNumber As String = "0" & knifeDigit
            result = New ScanResult(orderId, knifeNumber, cleaned)
            Return True
        End Function
    End Class
End Namespace
