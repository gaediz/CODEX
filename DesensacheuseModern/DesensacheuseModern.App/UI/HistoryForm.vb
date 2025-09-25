Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DesensacheuseModern.Models
Imports DesensacheuseModern.Services
Imports DesensacheuseModern.Utilities
Imports System.Drawing

Namespace DesensacheuseModern.UI
    Public Partial Class HistoryForm
        Inherits Form

        Private ReadOnly _logger As ProductionLogger
        Private _entries As List(Of ProductionSnapshot) = New List(Of ProductionSnapshot)()

        Public Sub New(logger As ProductionLogger)
            If logger Is Nothing Then
                Throw New ArgumentNullException(NameOf(logger))
            End If

            _logger = logger
            InitializeComponent()
            ConfigureGrid()
        End Sub

        Private Sub ConfigureGrid()
            HistoryGrid.AutoGenerateColumns = False
            HistoryGrid.Columns.Clear()

            Dim dateColumn As New DataGridViewTextBoxColumn() With {
                .HeaderText = "Début",
                .DataPropertyName = NameOf(HistoryRow.StartedAtDisplay),
                .FillWeight = 120.0F
            }

            Dim operatorColumn As New DataGridViewTextBoxColumn() With {
                .HeaderText = "Opérateur",
                .DataPropertyName = NameOf(HistoryRow.OperatorName),
                .FillWeight = 120.0F
            }

            Dim modeColumn As New DataGridViewTextBoxColumn() With {
                .HeaderText = "Mode",
                .DataPropertyName = NameOf(HistoryRow.ModeName),
                .FillWeight = 90.0F
            }

            Dim ofColumn As New DataGridViewTextBoxColumn() With {
                .HeaderText = "OF",
                .DataPropertyName = NameOf(HistoryRow.OrderOf),
                .FillWeight = 120.0F
            }

            Dim formulaColumn As New DataGridViewTextBoxColumn() With {
                .HeaderText = "Formule",
                .DataPropertyName = NameOf(HistoryRow.FormulaNumber),
                .FillWeight = 120.0F
            }

            Dim completedColumn As New DataGridViewTextBoxColumn() With {
                .HeaderText = "Fin",
                .DataPropertyName = NameOf(HistoryRow.CompletedAtDisplay),
                .FillWeight = 120.0F
            }

            HistoryGrid.Columns.AddRange(New DataGridViewColumn() {dateColumn, operatorColumn, modeColumn, ofColumn, formulaColumn, completedColumn})

            HistoryGrid.ColumnHeadersDefaultCellStyle.BackColor = ThemePalette.PrimaryColor
            HistoryGrid.ColumnHeadersDefaultCellStyle.ForeColor = Drawing.Color.White
            HistoryGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            HistoryGrid.DefaultCellStyle.BackColor = ThemePalette.SurfaceColor
            HistoryGrid.DefaultCellStyle.ForeColor = ThemePalette.TextColor
            HistoryGrid.DefaultCellStyle.SelectionBackColor = ThemePalette.SecondaryColor
            HistoryGrid.DefaultCellStyle.SelectionForeColor = Drawing.Color.White
            HistoryGrid.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.FromArgb(238, 244, 255)
            HistoryGrid.RowTemplate.Height = 32
        End Sub

        Protected Overrides Sub OnShown(e As EventArgs)
            MyBase.OnShown(e)
            LoadEntries()
        End Sub

        Private Sub LoadEntries()
            Try
                Dim snapshots As IReadOnlyList(Of ProductionSnapshot) = _logger.ReadAll()
                _entries = snapshots.OrderByDescending(Function(s) s.CompletedAt).ThenByDescending(Function(s) s.StartedAt).ToList()

                Dim rows As List(Of HistoryRow) = _entries.Select(Function(entry) New HistoryRow(entry)).ToList()
                HistoryGrid.DataSource = rows

                Dim hasEntries As Boolean = rows.Count > 0
                HistoryGrid.Visible = hasEntries
                EmptyLabel.Visible = Not hasEntries

                If hasEntries Then
                    HistoryGrid.ClearSelection()
                    HistoryGrid.Rows(0).Selected = True
                    DisplayEntryDetails(rows(0).Snapshot)
                Else
                    DetailsTextBox.Clear()
                End If
            Catch ex As Exception
                HistoryGrid.Visible = False
                EmptyLabel.Visible = True
                EmptyLabel.Text = "Erreur lors du chargement de l'historique." & Environment.NewLine & ex.Message
            End Try
        End Sub

        Private Sub HistoryGrid_SelectionChanged(sender As Object, e As EventArgs) Handles HistoryGrid.SelectionChanged
            If HistoryGrid.CurrentRow Is Nothing Then
                Return
            End If

            Dim row As HistoryRow = TryCast(HistoryGrid.CurrentRow.DataBoundItem, HistoryRow)
            If row Is Nothing Then
                Return
            End If

            DisplayEntryDetails(row.Snapshot)
        End Sub

        Private Sub DisplayEntryDetails(snapshot As ProductionSnapshot)
            If snapshot Is Nothing Then
                DetailsTextBox.Clear()
                Return
            End If

            Dim builder As New StringBuilder()
            builder.AppendLine($"OF : {snapshot.Formule?.OrderOf}")
            builder.AppendLine($"Formule : {snapshot.Formule?.FormulaNumber}")
            builder.AppendLine($"Opérateur : {snapshot.OperatorName}")
            builder.AppendLine($"Mode : {snapshot.Mode}")
            builder.AppendLine($"Début : {FormatDate(snapshot.StartedAt)}")
            builder.AppendLine($"Fin : {FormatDate(snapshot.CompletedAt)}")
            builder.AppendLine("Ingrédients :")

            If snapshot.Products IsNot Nothing AndAlso snapshot.Products.Count > 0 Then
                For Each product As ProductLineSnapshot In snapshot.Products
                    builder.AppendLine($" • {product.Name} - sacs posés {product.PlacedBagCount}/{product.RecipeBagCount} | Complément {product.MeasuredComplementKg:0.##} kg")
                Next
            Else
                builder.AppendLine(" • Aucun produit enregistré")
            End If

            DetailsTextBox.Text = builder.ToString()
        End Sub

        Private Shared Function FormatDate(value As DateTime) As String
            If value = DateTime.MinValue Then
                Return "-"
            End If

            Return value.ToString("dd/MM/yyyy HH:mm")
        End Function

        Private Sub ReloadButton_Click(sender As Object, e As EventArgs) Handles ReloadButton.Click
            LoadEntries()
        End Sub

        Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
            Close()
        End Sub

        Private Class HistoryRow
            Public Sub New(snapshot As ProductionSnapshot)
                Me.Snapshot = snapshot
                OperatorName = snapshot.OperatorName
                ModeName = snapshot.Mode
                OrderOf = snapshot.Formule?.OrderOf
                FormulaNumber = snapshot.Formule?.FormulaNumber
                StartedAtDisplay = FormatDate(snapshot.StartedAt)
                CompletedAtDisplay = FormatDate(snapshot.CompletedAt)
            End Sub

            Public ReadOnly Property Snapshot As ProductionSnapshot
            Public ReadOnly Property OperatorName As String
            Public ReadOnly Property ModeName As String
            Public ReadOnly Property OrderOf As String
            Public ReadOnly Property FormulaNumber As String
            Public ReadOnly Property StartedAtDisplay As String
            Public ReadOnly Property CompletedAtDisplay As String
        End Class
    End Class
End Namespace
