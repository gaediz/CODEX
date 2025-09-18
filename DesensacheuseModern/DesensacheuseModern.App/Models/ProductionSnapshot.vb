Imports System
Imports System.Collections.Generic

Namespace DesensacheuseModern.Models
    Public Class ProductionSnapshot
        Public Property Scan As ScanResult
        Public Property Formule As Formule
        Public Property Mode As String
        Public Property OperatorName As String
        Public Property StartedAt As DateTime
        Public Property CompletedAt As DateTime
        Public Property Products As List(Of ProductLineSnapshot)
    End Class
End Namespace
