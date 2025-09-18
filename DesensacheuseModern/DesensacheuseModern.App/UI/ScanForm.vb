Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DesensacheuseModern.Models
Imports DesensacheuseModern.Services
Imports DesensacheuseModern.Utilities

Namespace DesensacheuseModern.UI
    Public Class ScanForm
        Inherits Form

        Private ReadOnly _repository As FormuleRepository
        Private ReadOnly _logger As ProductionLogger

        Private ReadOnly _titleLabel As Label
        Private ReadOnly _instructionsLabel As Label
        Private ReadOnly _scanTextBox As TextBox
        Private ReadOnly _confirmButton As Button
        Private ReadOnly _exitButton As Button
        Private ReadOnly _errorLabel As Label
        Private ReadOnly _contentPanel As TableLayoutPanel

        Public Sub New(repository As FormuleRepository, logger As ProductionLogger)
            If repository Is Nothing Then
                Throw New ArgumentNullException(NameOf(repository))
            End If

            If logger Is Nothing Then
                Throw New ArgumentNullException(NameOf(logger))
            End If

            _repository = repository
            _logger = logger

            Text = "Désensacheuse - Accueil"
            StartPosition = FormStartPosition.CenterScreen
            FormBorderStyle = FormBorderStyle.FixedDialog
            MaximizeBox = False
            MinimizeBox = False
            ClientSize = New Size(720, 420)
            Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
            BackColor = ThemePalette.BackgroundColor

            _contentPanel = New TableLayoutPanel() With {
                .Dock = DockStyle.Fill,
                .ColumnCount = 1,
                .RowCount = 6,
                .Padding = New Padding(30),
                .BackColor = Color.Transparent
            }
            _contentPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 60))
            _contentPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 50))
            _contentPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 60))
            _contentPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 60))
            _contentPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100))
            _contentPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 50))

            _titleLabel = New Label() With {
                .Text = "Bienvenue",
                .Dock = DockStyle.Fill,
                .Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point),
                .ForeColor = ThemePalette.PrimaryColor,
                .TextAlign = ContentAlignment.MiddleCenter
            }

            _instructionsLabel = New Label() With {
                .Text = "Scannez le code OF pour démarrer.",
                .Dock = DockStyle.Fill,
                .ForeColor = ThemePalette.TextColor,
                .TextAlign = ContentAlignment.MiddleCenter
            }

            _scanTextBox = New TextBox() With {
                .Dock = DockStyle.Fill,
                .Margin = New Padding(0, 10, 0, 10)
            }

            _confirmButton = New Button() With {
                .Text = "Valider",
                .Dock = DockStyle.Fill,
                .BackColor = ThemePalette.PrimaryColor,
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat
            }
            _confirmButton.FlatAppearance.BorderSize = 0

            _exitButton = New Button() With {
                .Text = "Quitter",
                .Dock = DockStyle.Fill,
                .BackColor = ThemePalette.WarningColor,
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat
            }
            _exitButton.FlatAppearance.BorderSize = 0

            _errorLabel = New Label() With {
                .Dock = DockStyle.Fill,
                .ForeColor = Color.FromArgb(211, 47, 47),
                .TextAlign = ContentAlignment.MiddleCenter,
                .Visible = False
            }

            _contentPanel.Controls.Add(_titleLabel, 0, 0)
            _contentPanel.Controls.Add(_instructionsLabel, 0, 1)
            _contentPanel.Controls.Add(_scanTextBox, 0, 2)
            _contentPanel.Controls.Add(_confirmButton, 0, 3)
            _contentPanel.Controls.Add(_errorLabel, 0, 4)
            _contentPanel.Controls.Add(_exitButton, 0, 5)

            Controls.Add(_contentPanel)

            AcceptButton = _confirmButton

            AddHandler _confirmButton.Click, AddressOf OnConfirmClick
            AddHandler _exitButton.Click, Sub(sender, args) Close()
        End Sub

        Protected Overrides Sub OnShown(e As EventArgs)
            MyBase.OnShown(e)
            _scanTextBox.Focus()
        End Sub

        Private Sub OnConfirmClick(sender As Object, e As EventArgs)
            _errorLabel.Visible = False
            Dim scanValue As String = _scanTextBox.Text
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

            _scanTextBox.Clear()
            _scanTextBox.Focus()
            Show()
        End Sub

        Private Sub ShowError(message As String)
            _errorLabel.Text = message
            _errorLabel.Visible = True
        End Sub
    End Class
End Namespace
