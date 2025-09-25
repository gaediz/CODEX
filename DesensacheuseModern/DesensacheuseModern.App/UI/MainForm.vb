Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DesensacheuseModern.Models
Imports DesensacheuseModern.Services
Imports DesensacheuseModern.ViewModels
Imports DesensacheuseModern.Utilities

Namespace DesensacheuseModern.UI
    Public Partial Class MainForm
        Inherits Form

        Private ReadOnly _scan As ScanResult
        Private ReadOnly _formule As Formule
        Private ReadOnly _mode As String
        Private ReadOnly _logger As ProductionLogger
        Private ReadOnly _productBindingList As BindingList(Of ProductLineViewModel)
        Private ReadOnly _bindingSource As BindingSource
        Private ReadOnly _productSubscriptions As New Dictionary(Of ProductLineViewModel, PropertyChangedEventHandler)()
        Private _startTime As DateTime

        Public Sub New(scan As ScanResult, formule As Formule, mode As String, logger As ProductionLogger)
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
            _mode = mode
            _logger = logger

            _productBindingList = New BindingList(Of ProductLineViewModel)(formule.Products.Select(Function(p) New ProductLineViewModel(p)).ToList())
            _bindingSource = New BindingSource With {
                .DataSource = _productBindingList
            }

            InitializeComponent()

            TitleLabel.Text = $"Formule {_formule.FormulaNumber}"
            OrderValueLabel.Text = $"OF : {_formule.OrderOf}"
            KnifeValueLabel.Text = $"Couteau : {_scan.KnifeNumber}"
            ColorValueLabel.Text = $"Couleur : {_formule.Color}"
            ModeValueLabel.Text = $"Mode : {_mode}"

            ProductsGrid.DataSource = _bindingSource
            ConfigureGridColumns()

            SubscribeToProductChanges()

            _startTime = DateTime.Now
            ClockTimer.Interval = 1000
            ClockTimer.Start()

            UpdateSummary()
        End Sub

        Private Sub SubscribeToProductChanges()
            For Each item As ProductLineViewModel In _productBindingList
                Dim handler As PropertyChangedEventHandler = AddressOf HandleProductPropertyChanged
                AddHandler item.PropertyChanged, handler
                _productSubscriptions(item) = handler
            Next
        End Sub

        Private Sub HandleProductPropertyChanged(sender As Object, e As PropertyChangedEventArgs)
            If e.PropertyName = NameOf(ProductLineViewModel.PlacedBagCount) OrElse
               e.PropertyName = NameOf(ProductLineViewModel.IsComplete) OrElse
               e.PropertyName = NameOf(ProductLineViewModel.MeasuredComplementKg) Then
                UpdateSummary()
            End If
        End Sub

        Private Sub ConfigureGridColumns()
            ProductsGrid.Columns.Clear()

            ProductsGrid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Produit",
                .DataPropertyName = NameOf(ProductLineViewModel.ProductName),
                .ReadOnly = True,
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            ProductsGrid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Code matière",
                .DataPropertyName = NameOf(ProductLineViewModel.MaterialCode),
                .ReadOnly = True,
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            ProductsGrid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Code scan",
                .DataPropertyName = NameOf(ProductLineViewModel.ScanCode),
                .ReadOnly = True,
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            ProductsGrid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Qté recette (kg)",
                .DataPropertyName = NameOf(ProductLineViewModel.RecipeQuantityKg),
                .ReadOnly = True,
                .DefaultCellStyle = New DataGridViewCellStyle() With {.Format = "N1"},
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            ProductsGrid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Nb sacs recette",
                .DataPropertyName = NameOf(ProductLineViewModel.RecipeBagCount),
                .ReadOnly = True,
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            ProductsGrid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Nb sacs posés",
                .DataPropertyName = NameOf(ProductLineViewModel.PlacedBagCount),
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            ProductsGrid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Nb sacs restants",
                .DataPropertyName = NameOf(ProductLineViewModel.RemainingBags),
                .ReadOnly = True,
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            ProductsGrid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Complément recette (kg)",
                .DataPropertyName = NameOf(ProductLineViewModel.RecipeComplementKg),
                .ReadOnly = True,
                .DefaultCellStyle = New DataGridViewCellStyle() With {.Format = "N2"},
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            ProductsGrid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Complément mesuré (kg)",
                .DataPropertyName = NameOf(ProductLineViewModel.MeasuredComplementKg),
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            ProductsGrid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Lot 1",
                .DataPropertyName = NameOf(ProductLineViewModel.Lot1),
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            ProductsGrid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Lot 2",
                .DataPropertyName = NameOf(ProductLineViewModel.Lot2),
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            ProductsGrid.Columns.Add(New DataGridViewCheckBoxColumn() With {
                .HeaderText = "Terminé",
                .DataPropertyName = NameOf(ProductLineViewModel.IsComplete),
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })
        End Sub

        Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
            Dim elapsed As TimeSpan = DateTime.Now - _startTime
            ClockStatusLabel.Text = $"Temps écoulé : {elapsed:hh\:mm\:ss}"
        End Sub

        Private Sub ScanEntryTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ScanEntryTextBox.KeyDown
            If e.KeyCode = Keys.Enter Then
                e.Handled = True
                e.SuppressKeyPress = True
                FocusProductByScan(ScanEntryTextBox.Text)
                ScanEntryTextBox.Clear()
            End If
        End Sub

        Private Sub FocusProductByScan(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Return
            End If

            Dim trimmed As String = value.Trim()
            Dim index As Integer = -1
            For i As Integer = 0 To _productBindingList.Count - 1
                Dim item As ProductLineViewModel = _productBindingList(i)
                If String.Equals(item.ScanCode, trimmed, StringComparison.OrdinalIgnoreCase) OrElse
                   String.Equals(item.MaterialCode, trimmed, StringComparison.OrdinalIgnoreCase) Then
                    index = i
                    Exit For
                End If
            Next

            If index >= 0 Then
                ProductsGrid.ClearSelection()
                ProductsGrid.Rows(index).Selected = True
                ProductsGrid.CurrentCell = ProductsGrid.Rows(index).Cells(0)
                AdjustSelectedProduct(1)
            End If
        End Sub

        Private Sub AdjustSelectedProduct(delta As Integer)
            If ProductsGrid.CurrentRow Is Nothing Then
                Return
            End If

            Dim item As ProductLineViewModel = TryCast(ProductsGrid.CurrentRow.DataBoundItem, ProductLineViewModel)
            If item Is Nothing Then
                Return
            End If

            Dim newValue As Integer = item.PlacedBagCount + delta
            If newValue < 0 Then
                newValue = 0
            End If
            item.PlacedBagCount = newValue
            UpdateSummary()
        End Sub

        Private Sub IncrementButton_Click(sender As Object, e As EventArgs) Handles IncrementButton.Click
            AdjustSelectedProduct(1)
        End Sub

        Private Sub DecrementButton_Click(sender As Object, e As EventArgs) Handles DecrementButton.Click
            AdjustSelectedProduct(-1)
        End Sub

        Private Sub MarkCompleteButton_Click(sender As Object, e As EventArgs) Handles MarkCompleteButton.Click
            If ProductsGrid.CurrentRow Is Nothing Then
                Return
            End If

            Dim item As ProductLineViewModel = TryCast(ProductsGrid.CurrentRow.DataBoundItem, ProductLineViewModel)
            If item Is Nothing Then
                Return
            End If

            item.MarkComplete()
            UpdateSummary()
        End Sub

        Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
            For Each item As ProductLineViewModel In _productBindingList
                item.Reset()
            Next
            UpdateSummary()
        End Sub

        Private Sub ProductsGrid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsGrid.CellValueChanged
            If e.RowIndex >= 0 Then
                UpdateSummary()
            End If
        End Sub

        Private Sub ProductsGrid_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles ProductsGrid.CurrentCellDirtyStateChanged
            If ProductsGrid.IsCurrentCellDirty Then
                ProductsGrid.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End Sub

        Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
            TrySaveSession(showSuccessMessage:=True)
        End Sub

        Private Sub CompleteSessionButton_Click(sender As Object, e As EventArgs) Handles CompleteSessionButton.Click
            If TrySaveSession(showSuccessMessage:=True) Then
                DialogResult = DialogResult.OK
                Close()
            End If
        End Sub

        Private Function TrySaveSession(showSuccessMessage As Boolean) As Boolean
            If String.IsNullOrWhiteSpace(OperatorTextBox.Text) Then
                MessageBox.Show(Me, "Veuillez saisir le nom de l'opérateur.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                OperatorTextBox.Focus()
                Return False
            End If

            Dim snapshot As ProductionSnapshot = BuildSnapshot()
            Try
                _logger.Append(snapshot)
                If showSuccessMessage Then
                    MessageBox.Show(Me, "Données enregistrées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Return True
            Catch ex As Exception
                MessageBox.Show(Me, "Erreur lors de l'enregistrement : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Private Function BuildSnapshot() As ProductionSnapshot
            Dim snapshot As New ProductionSnapshot() With {
                .Scan = _scan,
                .Formule = _formule,
                .Mode = _mode,
                .OperatorName = OperatorTextBox.Text.Trim(),
                .StartedAt = _startTime,
                .CompletedAt = DateTime.Now,
                .Products = _productBindingList.Select(Function(p) p.ToSnapshot()).ToList()
            }
            Return snapshot
        End Function

        Private Sub UpdateSummary()
            Dim totalPlanned As Integer = _productBindingList.Sum(Function(p) p.RecipeBagCount)
            Dim totalPlaced As Integer = _productBindingList.Sum(Function(p) p.PlacedBagCount)
            Dim completed As Integer = _productBindingList.Count(Function(p) p.IsComplete)
            Dim totalProducts As Integer = _productBindingList.Count

            SummaryLabel.Text = $"Sacs posés : {totalPlaced}/{totalPlanned} | Produits terminés : {completed}/{totalProducts}"
            UpdateProgressVisuals(totalPlaced, totalPlanned)
            RefreshRowStyles()
        End Sub

        Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
            Close()
        End Sub

        Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
            For Each pair As KeyValuePair(Of ProductLineViewModel, PropertyChangedEventHandler) In _productSubscriptions
                RemoveHandler pair.Key.PropertyChanged, pair.Value
            Next
            _productSubscriptions.Clear()
            ClockTimer.Stop()
            ClockTimer.Dispose()
            MyBase.OnFormClosed(e)
        End Sub

        Private Sub UpdateProgressVisuals(totalPlaced As Integer, totalPlanned As Integer)
            Dim progressValue As Integer = 0
            If totalPlanned > 0 Then
                progressValue = CInt(Math.Min(100, Math.Round((totalPlaced / totalPlanned) * 100, MidpointRounding.AwayFromZero)))
            End If

            SummaryProgressBar.Value = progressValue
            ProgressHintLabel.Text = $"{progressValue}% du plan réalisé"
        End Sub

        Private Sub RefreshRowStyles()
            For Each row As DataGridViewRow In ProductsGrid.Rows
                Dim item As ProductLineViewModel = TryCast(row.DataBoundItem, ProductLineViewModel)
                If item IsNot Nothing AndAlso item.IsComplete Then
                    row.DefaultCellStyle.BackColor = ThemePalette.CompletedRowColor
                    row.DefaultCellStyle.ForeColor = ThemePalette.CompletedRowTextColor
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 142, 60)
                    row.DefaultCellStyle.SelectionForeColor = ThemePalette.CompletedRowTextColor
                Else
                    row.DefaultCellStyle.BackColor = ThemePalette.SurfaceColor
                    row.DefaultCellStyle.ForeColor = ThemePalette.TextColor
                    row.DefaultCellStyle.SelectionBackColor = ThemePalette.SecondaryColor
                    row.DefaultCellStyle.SelectionForeColor = Color.White
                End If
            Next
        End Sub

        Private Sub ProductsGrid_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles ProductsGrid.DataBindingComplete
            RefreshRowStyles()
        End Sub
    End Class
End Namespace
