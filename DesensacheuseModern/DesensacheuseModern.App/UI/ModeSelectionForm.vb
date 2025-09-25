Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DesensacheuseModern.Models
Imports DesensacheuseModern.Services
Imports DesensacheuseModern.Utilities

Namespace DesensacheuseModern.UI
    Public Partial Class ModeSelectionForm
        Inherits Form

        Private ReadOnly _scan As ScanResult
        Private ReadOnly _formule As Formule
        Private ReadOnly _logger As ProductionLogger
        Private ReadOnly _recommendedMode As String

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
            _recommendedMode = If(String.IsNullOrWhiteSpace(_formule.TargetMode), String.Empty, _formule.TargetMode.Trim())

            InitializeComponent()

            DetailsLabel.Text = $"OF : {_formule.OrderOf}{Environment.NewLine}Formule : {_formule.FormulaNumber} | Couleur : {_formule.Color}{Environment.NewLine}Couteau : {_scan.KnifeNumber}"
            If String.IsNullOrEmpty(_recommendedMode) Then
                RecommendationLabel.Text = "Choisissez le mode adapté au poste."
            Else
                RecommendationLabel.Text = $"Mode conseillé : {_recommendedMode}"
            End If
            HighlightRecommendedMode()
        End Sub

        Private Sub OpenMainWindow(modeName As String)
            Hide()
            Using mainForm As New MainForm(_scan, _formule, modeName, _logger)
                mainForm.StartPosition = FormStartPosition.CenterParent
                mainForm.ShowDialog(Me)
            End Using
            Close()
        End Sub

        Private Sub DesensacheuseButton_Click(sender As Object, e As EventArgs) Handles DesensacheuseButton.Click
            OpenMainWindow("Désensacheuse")
        End Sub

        Private Sub PaletteButton_Click(sender As Object, e As EventArgs) Handles PaletteButton.Click
            OpenMainWindow("Palette")
        End Sub

        Private Sub HighlightRecommendedMode()
            Dim buttons As Button() = {DesensacheuseButton, PaletteButton}
            For Each button As Button In buttons
                Dim isRecommended As Boolean = Not String.IsNullOrEmpty(_recommendedMode) AndAlso String.Equals(button.Text, _recommendedMode, StringComparison.OrdinalIgnoreCase)

                Dim baseBackColor As Color = If(button Is DesensacheuseButton, ThemePalette.PrimaryColor, ThemePalette.SecondaryColor)
                button.BackColor = If(isRecommended, ThemePalette.AccentColor, baseBackColor)
                button.FlatAppearance.BorderSize = If(isRecommended, 2, 0)
                button.FlatAppearance.BorderColor = If(isRecommended, ThemePalette.AccentColor, baseBackColor)
                button.Font = New Font(button.Font, If(isRecommended, FontStyle.Bold, FontStyle.Regular))
            Next
        End Sub
    End Class
End Namespace
