Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text.Json
Imports DesensacheuseModern.Models

Namespace DesensacheuseModern.Services
    Public Class FormuleRepository
        Private ReadOnly _dataFilePath As String

        Public Sub New()
            Dim baseDirectory As String = AppContext.BaseDirectory
            _dataFilePath = Path.Combine(baseDirectory, "data", "formules.json")
        End Sub

        Public Sub New(dataFilePath As String)
            _dataFilePath = dataFilePath
        End Sub

        Public Function GetFormuleById(orderId As String) As Formule
            If String.IsNullOrWhiteSpace(orderId) Then
                Return Nothing
            End If

            If Not File.Exists(_dataFilePath) Then
                Throw New FileNotFoundException("Le fichier de données est introuvable.", _dataFilePath)
            End If

            Dim json As String = File.ReadAllText(_dataFilePath)
            Dim options As New JsonSerializerOptions With {
                .PropertyNameCaseInsensitive = True
            }
            Dim container As FormuleContainer = JsonSerializer.Deserialize(Of FormuleContainer)(json, options)

            If container Is Nothing OrElse container.Formules Is Nothing Then
                Return Nothing
            End If

            Dim match As Formule = container.Formules.FirstOrDefault(Function(f) String.Equals(f.Id, orderId, StringComparison.OrdinalIgnoreCase))
            Return match
        End Function

        Private Class FormuleContainer
            Public Property Formules As List(Of Formule)
        End Class
    End Class
End Namespace
