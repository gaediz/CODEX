Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DesensacheuseModern.Models
Imports DesensacheuseModern.Services
Imports DesensacheuseModern.Utilities

Namespace DesensacheuseModern.UI
    Public Partial Class ScanForm
        Inherits Form

        Private ReadOnly _repository As FormuleRepository
        Private ReadOnly _logger As ProductionLogger

        Public Sub New(repository As FormuleRepository, logger As ProductionLogger)
            If repository Is Nothing Then
                Throw New ArgumentNullException(NameOf(repository))
            End If

            If logger Is Nothing Then
                Throw New ArgumentNullException(NameOf(logger))
            End If

            _repository = repository
            _logger = logger

            InitializeComponent()
        End Sub

        Protected Overrides Sub OnShown(e As EventArgs)
            MyBase.OnShown(e)
            ScanTextBox.Focus()
        End Sub

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            ErrorLabel.Visible = False
            Dim scanValue As String = ScanTextBox.Text
            Dim scanResult As ScanResult = Nothing
            Dim message As String = String.Empty

            If Not ScanParser.TryParse(scanValue, scanResult, message) Then
                ShowError(message)
                Return
            End If

            Dim formule As Formule = Nothing
            Try
                formule = _repository.GetFormuleById(scanResult.OrderId)
            Catch ex As FileNotFoundException
                ShowError(ex.Message)
                Return
            Catch ex As Exception
                ShowError("Une erreur est survenue lors de la lecture des données : " & ex.Message)
                Return
            End Try

            If formule Is Nothing Then
                ShowError("Aucune formule n'a été trouvée pour l'identifiant " & scanResult.OrderId & ".")
                Return
            End If

            Hide()
            Using selectionForm As New ModeSelectionForm(scanResult, formule, _logger)
                selectionForm.StartPosition = FormStartPosition.CenterParent
                selectionForm.ShowDialog(Me)
            End Using

            ScanTextBox.Clear()
            ScanTextBox.Focus()
            Show()
        End Sub

        Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
            Close()
        End Sub

        Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
            Using historyForm As New HistoryForm(_logger)
                historyForm.StartPosition = FormStartPosition.CenterParent
                historyForm.ShowDialog(Me)
            End Using
        End Sub

        Private Sub ShowError(message As String)
            ErrorLabel.Text = message
            ErrorLabel.Visible = True
        End Sub
    End Class
End Namespace
