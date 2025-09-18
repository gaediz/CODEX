Namespace DesensacheuseModern.Models
    Public Class ScanResult
        Public Sub New(orderId As String, knifeNumber As String, rawValue As String)
            Me.OrderId = orderId
            Me.KnifeNumber = knifeNumber
            Me.RawValue = rawValue
        End Sub

        Public Property OrderId As String
        Public Property KnifeNumber As String
        Public Property RawValue As String
    End Class
End Namespace
