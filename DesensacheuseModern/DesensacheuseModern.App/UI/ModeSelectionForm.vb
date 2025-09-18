Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DesensacheuseModern.Models
Imports DesensacheuseModern.Services
Imports DesensacheuseModern.Utilities

Namespace DesensacheuseModern.UI
    Public Class ModeSelectionForm
        Inherits Form

        Private ReadOnly _scan As ScanResult
        Private ReadOnly _formule As Formule
        Private ReadOnly _logger As ProductionLogger

        Private ReadOnly _headerPanel As TableLayoutPanel
        Private ReadOnly _desensacheuseButton As Button
        Private ReadOnly _paletteButton As Button
        Private ReadOnly _infoLabel As Label

        Public Sub New(scan As ScanResult, formule As Formule, logger As ProductionLogger)
            If scan Is Nothing Then
                Throw New ArgumentNullException(NameOf(scan))
            End If

            If formule Is Nothing Then
                Throw New ArgumentNullException(NameOf(formule))
            End If

            If logger Is Nothing Then
                Throw New ArgumentNullException(NameOf(logger))
            End If

            _scan = scan
            _formule = formule
            _logger = logger

            Text = "Sélection du mode"
            Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
            StartPosition = FormStartPosition.CenterParent
            FormBorderStyle = FormBorderStyle.FixedDialog
            MaximizeBox = False
            MinimizeBox = False
            ClientSize = New Size(680, 360)
            BackColor = ThemePalette.BackgroundColor

            _headerPanel = New TableLayoutPanel() With {
                .Dock = DockStyle.Fill,
                .ColumnCount = 1,
                .RowCount = 4,
                .Padding = New Padding(20)
            }
            _headerPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 60))
            _headerPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 60))
            _headerPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100))
            _headerPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 80))

            Dim titleLabel As New Label() With {
                .Text = "Mode de fonctionnement",
                .Dock = DockStyle.Fill,
                .Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point),
                .ForeColor = ThemePalette.PrimaryColor,
                .TextAlign = ContentAlignment.MiddleCenter
            }

            Dim detailsLabel As New Label() With {
                .Dock = DockStyle.Fill,
                .ForeColor = ThemePalette.TextColor,
                .TextAlign = ContentAlignment.MiddleCenter
            }
            detailsLabel.Text = $"OF : {_formule.OrderOf}{Environment.NewLine}Formule : {_formule.FormulaNumber} | Couleur : {_formule.Color}{Environment.NewLine}Couteau : {_scan.KnifeNumber}"

            _infoLabel = New Label() With {
                .Dock = DockStyle.Fill,
                .ForeColor = ThemePalette.TextColor,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Text = "Choisissez le mode adapté au poste."
            }

            Dim buttonPanel As New TableLayoutPanel() With {
                .Dock = DockStyle.Fill,
                .ColumnCount = 2,
                .RowCount = 1,
                .Padding = New Padding(0, 10, 0, 0)
            }
            buttonPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
            buttonPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
            buttonPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))

            _desensacheuseButton = New Button() With {
                .Text = "Désensacheuse",
                .Dock = DockStyle.Fill,
                .BackColor = ThemePalette.PrimaryColor,
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat
            }
            _desensacheuseButton.FlatAppearance.BorderSize = 0

            _paletteButton = New Button() With {
                .Text = "Palette",
                .Dock = DockStyle.Fill,
                .BackColor = ThemePalette.AccentColor,
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat
            }
            _paletteButton.FlatAppearance.BorderSize = 0

            buttonPanel.Controls.Add(_desensacheuseButton, 0, 0)
            buttonPanel.Controls.Add(_paletteButton, 1, 0)

            _headerPanel.Controls.Add(titleLabel, 0, 0)
            _headerPanel.Controls.Add(detailsLabel, 0, 1)
            _headerPanel.Controls.Add(_infoLabel, 0, 2)
            _headerPanel.Controls.Add(buttonPanel, 0, 3)

            Controls.Add(_headerPanel)

            AddHandler _desensacheuseButton.Click, Sub(sender, args) OpenMainWindow("Désensacheuse")
            AddHandler _paletteButton.Click, Sub(sender, args) OpenMainWindow("Palette")
        End Sub

        Private Sub OpenMainWindow(modeName As String)
            Hide()
            Using mainForm As New MainForm(_scan, _formule, modeName, _logger)
                mainForm.StartPosition = FormStartPosition.CenterParent
                mainForm.ShowDialog(Me)
            End Using
            Close()
        End Sub
    End Class
End Namespace
