Imports System.Collections.Generic

Namespace DesensacheuseModern.Models
    Public Class Formule
        Public Property Id As String
        Public Property OrderOf As String
        Public Property FormulaNumber As String
        Public Property Color As String
        Public Property TargetMode As String
        Public Property Products As List(Of ProductLine)
    End Class
End Namespace
