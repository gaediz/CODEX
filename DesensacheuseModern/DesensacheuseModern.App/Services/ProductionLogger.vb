Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text.Json
Imports System.Text.Json.Serialization
Imports DesensacheuseModern.Models

Namespace DesensacheuseModern.Services
    Public Class ProductionLogger
        Private ReadOnly _logFilePath As String

        Public Sub New()
            Dim baseDirectory As String = AppContext.BaseDirectory
            _logFilePath = Path.Combine(baseDirectory, "data", "production-log.json")
        End Sub

        Public Sub New(logFilePath As String)
            _logFilePath = logFilePath
        End Sub

        Public Sub Append(snapshot As ProductionSnapshot)
            If snapshot Is Nothing Then
                Throw New ArgumentNullException(NameOf(snapshot))
            End If

            Dim directory As String = Path.GetDirectoryName(_logFilePath)
            If Not String.IsNullOrEmpty(directory) AndAlso Not Directory.Exists(directory) Then
                Directory.CreateDirectory(directory)
            End If

            Dim entries As List(Of ProductionSnapshot) = ReadAllInternal()

            entries.Add(snapshot)
            Dim writeOptions As New JsonSerializerOptions With {
                .WriteIndented = True,
                .DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            }
            Dim payload As String = JsonSerializer.Serialize(entries, writeOptions)
            File.WriteAllText(_logFilePath, payload)
        End Sub

        Public Function ReadAll() As IReadOnlyList(Of ProductionSnapshot)
            Return ReadAllInternal()
        End Function

        Private Function ReadAllInternal() As List(Of ProductionSnapshot)
            Dim entries As List(Of ProductionSnapshot)
            If File.Exists(_logFilePath) Then
                Dim existing As String = File.ReadAllText(_logFilePath)
                If Not String.IsNullOrWhiteSpace(existing) Then
                    Dim options As New JsonSerializerOptions With {
                        .PropertyNameCaseInsensitive = True
                    }
                    entries = JsonSerializer.Deserialize(Of List(Of ProductionSnapshot))(existing, options)
                    If entries Is Nothing Then
                        entries = New List(Of ProductionSnapshot)()
                    End If
                Else
                    entries = New List(Of ProductionSnapshot)()
                End If
            Else
                entries = New List(Of ProductionSnapshot)()
            End If

            Return entries
        End Function
    End Class
End Namespace
