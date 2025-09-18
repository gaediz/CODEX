Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DesensacheuseModern.Models
Imports DesensacheuseModern.Services
Imports DesensacheuseModern.Utilities
Imports DesensacheuseModern.ViewModels

Namespace DesensacheuseModern.UI
    Public Class MainForm
        Inherits Form

        Private ReadOnly _scan As ScanResult
        Private ReadOnly _formule As Formule
        Private ReadOnly _mode As String
        Private ReadOnly _logger As ProductionLogger
        Private ReadOnly _productBindingList As BindingList(Of ProductLineViewModel)
        Private ReadOnly _bindingSource As BindingSource
        Private ReadOnly _clockTimer As Timer
        Private ReadOnly _summaryLabel As Label
        Private ReadOnly _timeStatusLabel As ToolStripStatusLabel
        Private ReadOnly _operatorTextBox As TextBox
        Private ReadOnly _scanEntryTextBox As TextBox
        Private ReadOnly _grid As DataGridView

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

            Text = "Désensacheuse - Suivi de production"
            Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
            WindowState = FormWindowState.Maximized
            BackColor = ThemePalette.BackgroundColor

            Dim rootLayout As New TableLayoutPanel() With {
                .Dock = DockStyle.Fill,
                .RowCount = 3,
                .ColumnCount = 1
            }
            rootLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 180))
            rootLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100))
            rootLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 80))

            Dim headerPanel As New TableLayoutPanel() With {
                .Dock = DockStyle.Fill,
                .ColumnCount = 2,
                .RowCount = 2,
                .Padding = New Padding(20)
            }
            headerPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 60))
            headerPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100))
            headerPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
            headerPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))

            Dim titleLabel As New Label() With {
                .Text = $"Formule {_formule.FormulaNumber}",
                .Dock = DockStyle.Fill,
                .Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point),
                .ForeColor = ThemePalette.PrimaryColor,
                .TextAlign = ContentAlignment.MiddleLeft
            }

            _summaryLabel = New Label() With {
                .Dock = DockStyle.Fill,
                .ForeColor = ThemePalette.TextColor,
                .Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point),
                .TextAlign = ContentAlignment.MiddleRight
            }

            headerPanel.Controls.Add(titleLabel, 0, 0)
            headerPanel.SetColumnSpan(titleLabel, 2)
            headerPanel.Controls.Add(_summaryLabel, 0, 1)
            headerPanel.SetColumnSpan(_summaryLabel, 2)

            Dim infoPanel As New TableLayoutPanel() With {
                .Dock = DockStyle.Fill,
                .ColumnCount = 3,
                .RowCount = 2
            }
            infoPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.0F))
            infoPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.0F))
            infoPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 34.0F))
            infoPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
            infoPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))

            Dim orderLabel As New Label() With {
                .Text = $"OF : {_formule.OrderOf}",
                .Dock = DockStyle.Fill,
                .ForeColor = ThemePalette.TextColor,
                .TextAlign = ContentAlignment.MiddleLeft
            }

            Dim knifeLabel As New Label() With {
                .Text = $"Couteau : {_scan.KnifeNumber}",
                .Dock = DockStyle.Fill,
                .ForeColor = ThemePalette.TextColor,
                .TextAlign = ContentAlignment.MiddleLeft
            }

            Dim colorLabel As New Label() With {
                .Text = $"Couleur : {_formule.Color}",
                .Dock = DockStyle.Fill,
                .ForeColor = ThemePalette.TextColor,
                .TextAlign = ContentAlignment.MiddleLeft
            }

            Dim modeLabel As New Label() With {
                .Text = $"Mode : {_mode}",
                .Dock = DockStyle.Fill,
                .ForeColor = ThemePalette.TextColor,
                .TextAlign = ContentAlignment.MiddleLeft
            }

            Dim operatorLabel As New Label() With {
                .Text = "Opérateur :",
                .Dock = DockStyle.Fill,
                .ForeColor = ThemePalette.TextColor,
                .TextAlign = ContentAlignment.MiddleLeft
            }

            _operatorTextBox = New TextBox() With {
                .Dock = DockStyle.Fill
            }

            Dim scanEntryLabel As New Label() With {
                .Text = "Scan produit :",
                .Dock = DockStyle.Fill,
                .ForeColor = ThemePalette.TextColor,
                .TextAlign = ContentAlignment.MiddleLeft
            }

            _scanEntryTextBox = New TextBox() With {
                .Dock = DockStyle.Fill
            }

            infoPanel.Controls.Add(orderLabel, 0, 0)
            infoPanel.Controls.Add(knifeLabel, 1, 0)
            infoPanel.Controls.Add(colorLabel, 2, 0)
            infoPanel.Controls.Add(modeLabel, 0, 1)
            infoPanel.Controls.Add(operatorLabel, 1, 1)
            infoPanel.Controls.Add(_operatorTextBox, 2, 1)

            Dim scanPanel As New TableLayoutPanel() With {
                .Dock = DockStyle.Fill,
                .ColumnCount = 2,
                .RowCount = 1,
                .Padding = New Padding(20, 10, 20, 10)
            }
            scanPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150))
            scanPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))
            scanPanel.Controls.Add(scanEntryLabel, 0, 0)
            scanPanel.Controls.Add(_scanEntryTextBox, 1, 0)

            headerPanel.Controls.Add(infoPanel, 0, 1)
            headerPanel.Controls.Add(scanPanel, 1, 1)

            _grid = New DataGridView() With {
                .Dock = DockStyle.Fill,
                .AutoGenerateColumns = False,
                .DataSource = _bindingSource,
                .AllowUserToAddRows = False,
                .AllowUserToDeleteRows = False,
                .RowHeadersVisible = False,
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                .MultiSelect = False,
                .BackgroundColor = Color.White,
                .BorderStyle = BorderStyle.None
            }

            ConfigureGridColumns()

            Dim footerPanel As New FlowLayoutPanel() With {
                .Dock = DockStyle.Fill,
                .FlowDirection = FlowDirection.LeftToRight,
                .Padding = New Padding(20, 10, 20, 10)
            }

            Dim incrementButton As New Button() With {
                .Text = "+1 sac",
                .BackColor = ThemePalette.PrimaryColor,
                .ForeColor = Color.White,
                .AutoSize = True,
                .FlatStyle = FlatStyle.Flat
            }
            incrementButton.FlatAppearance.BorderSize = 0

            Dim decrementButton As New Button() With {
                .Text = "-1 sac",
                .BackColor = ThemePalette.WarningColor,
                .ForeColor = Color.White,
                .AutoSize = True,
                .FlatStyle = FlatStyle.Flat
            }
            decrementButton.FlatAppearance.BorderSize = 0

            Dim markCompleteButton As New Button() With {
                .Text = "Marquer terminé",
                .BackColor = ThemePalette.AccentColor,
                .ForeColor = Color.White,
                .AutoSize = True,
                .FlatStyle = FlatStyle.Flat
            }
            markCompleteButton.FlatAppearance.BorderSize = 0

            Dim resetButton As New Button() With {
                .Text = "Réinitialiser",
                .BackColor = Color.FromArgb(96, 125, 139),
                .ForeColor = Color.White,
                .AutoSize = True,
                .FlatStyle = FlatStyle.Flat
            }
            resetButton.FlatAppearance.BorderSize = 0

            Dim saveButton As New Button() With {
                .Text = "Enregistrer",
                .BackColor = Color.FromArgb(56, 142, 60),
                .ForeColor = Color.White,
                .AutoSize = True,
                .FlatStyle = FlatStyle.Flat
            }
            saveButton.FlatAppearance.BorderSize = 0

            Dim closeButton As New Button() With {
                .Text = "Fermer",
                .BackColor = Color.FromArgb(84, 110, 122),
                .ForeColor = Color.White,
                .AutoSize = True,
                .FlatStyle = FlatStyle.Flat
            }
            closeButton.FlatAppearance.BorderSize = 0

            footerPanel.Controls.Add(incrementButton)
            footerPanel.Controls.Add(decrementButton)
            footerPanel.Controls.Add(markCompleteButton)
            footerPanel.Controls.Add(resetButton)
            footerPanel.Controls.Add(saveButton)
            footerPanel.Controls.Add(closeButton)

            Dim status As New StatusStrip()
            _timeStatusLabel = New ToolStripStatusLabel()
            status.Items.Add(_timeStatusLabel)

            rootLayout.Controls.Add(headerPanel, 0, 0)
            rootLayout.Controls.Add(_grid, 0, 1)
            rootLayout.Controls.Add(footerPanel, 0, 2)

            Controls.Add(rootLayout)
            Controls.Add(status)

            _clockTimer = New Timer() With {
                .Interval = 1000
            }

            AddHandler incrementButton.Click, Sub(sender, args) AdjustSelectedProduct(1)
            AddHandler decrementButton.Click, Sub(sender, args) AdjustSelectedProduct(-1)
            AddHandler markCompleteButton.Click, AddressOf OnMarkComplete
            AddHandler resetButton.Click, AddressOf OnReset
            AddHandler saveButton.Click, AddressOf OnSave
            AddHandler closeButton.Click, Sub(sender, args) Close()
            AddHandler _clockTimer.Tick, AddressOf OnTimerTick
            AddHandler _scanEntryTextBox.KeyDown, AddressOf OnScanEntryKeyDown
            AddHandler _grid.CellValueChanged, AddressOf OnGridCellValueChanged
            AddHandler _grid.CurrentCellDirtyStateChanged, AddressOf OnGridCurrentCellDirtyStateChanged

            _startTime = DateTime.Now
            _clockTimer.Start()
            UpdateSummary()
        End Sub

        Private Sub ConfigureGridColumns()
            _grid.Columns.Clear()

            _grid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Produit",
                .DataPropertyName = NameOf(ProductLineViewModel.ProductName),
                .ReadOnly = True,
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            _grid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Code matière",
                .DataPropertyName = NameOf(ProductLineViewModel.MaterialCode),
                .ReadOnly = True,
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            _grid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Code scan",
                .DataPropertyName = NameOf(ProductLineViewModel.ScanCode),
                .ReadOnly = True,
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            _grid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Qté recette (kg)",
                .DataPropertyName = NameOf(ProductLineViewModel.RecipeQuantityKg),
                .ReadOnly = True,
                .DefaultCellStyle = New DataGridViewCellStyle() With {.Format = "N1"},
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            _grid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Nb sacs recette",
                .DataPropertyName = NameOf(ProductLineViewModel.RecipeBagCount),
                .ReadOnly = True,
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            _grid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Nb sacs posés",
                .DataPropertyName = NameOf(ProductLineViewModel.PlacedBagCount),
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            _grid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Nb sacs restants",
                .DataPropertyName = NameOf(ProductLineViewModel.RemainingBags),
                .ReadOnly = True,
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            _grid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Complément recette (kg)",
                .DataPropertyName = NameOf(ProductLineViewModel.RecipeComplementKg),
                .ReadOnly = True,
                .DefaultCellStyle = New DataGridViewCellStyle() With {.Format = "N2"},
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            _grid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Complément mesuré (kg)",
                .DataPropertyName = NameOf(ProductLineViewModel.MeasuredComplementKg),
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            _grid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Lot 1",
                .DataPropertyName = NameOf(ProductLineViewModel.Lot1),
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            _grid.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "Lot 2",
                .DataPropertyName = NameOf(ProductLineViewModel.Lot2),
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })

            _grid.Columns.Add(New DataGridViewCheckBoxColumn() With {
                .HeaderText = "Terminé",
                .DataPropertyName = NameOf(ProductLineViewModel.IsComplete),
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            })
        End Sub

        Private Sub OnTimerTick(sender As Object, e As EventArgs)
            Dim elapsed As TimeSpan = DateTime.Now - _startTime
            _timeStatusLabel.Text = $"Temps écoulé : {elapsed:hh\:mm\:ss}"
        End Sub

        Private Sub OnScanEntryKeyDown(sender As Object, e As KeyEventArgs)
            If e.KeyCode = Keys.Enter Then
                e.Handled = True
                e.SuppressKeyPress = True
                FocusProductByScan(_scanEntryTextBox.Text)
                _scanEntryTextBox.Clear()
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
                _grid.ClearSelection()
                _grid.Rows(index).Selected = True
                _grid.CurrentCell = _grid.Rows(index).Cells(0)
                AdjustSelectedProduct(1)
            End If
        End Sub

        Private Sub AdjustSelectedProduct(delta As Integer)
            If _grid.CurrentRow Is Nothing Then
                Return
            End If

            Dim item As ProductLineViewModel = TryCast(_grid.CurrentRow.DataBoundItem, ProductLineViewModel)
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

        Private Sub OnMarkComplete(sender As Object, e As EventArgs)
            If _grid.CurrentRow Is Nothing Then
                Return
            End If

            Dim item As ProductLineViewModel = TryCast(_grid.CurrentRow.DataBoundItem, ProductLineViewModel)
            If item Is Nothing Then
                Return
            End If

            item.MarkComplete()
            UpdateSummary()
        End Sub

        Private Sub OnReset(sender As Object, e As EventArgs)
            For Each item As ProductLineViewModel In _productBindingList
                item.PlacedBagCount = 0
                item.MeasuredComplementKg = 0D
                item.IsComplete = False
            Next
            UpdateSummary()
        End Sub

        Private Sub OnGridCellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
            If e.RowIndex >= 0 Then
                UpdateSummary()
            End If
        End Sub

        Private Sub OnGridCurrentCellDirtyStateChanged(sender As Object, e As EventArgs)
            If _grid.IsCurrentCellDirty Then
                _grid.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End Sub

        Private Sub OnSave(sender As Object, e As EventArgs)
            If String.IsNullOrWhiteSpace(_operatorTextBox.Text) Then
                MessageBox.Show(Me, "Veuillez saisir le nom de l'opérateur.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                _operatorTextBox.Focus()
                Return
            End If

            Dim snapshot As ProductionSnapshot = BuildSnapshot()
            Try
                _logger.Append(snapshot)
                MessageBox.Show(Me, "Données enregistrées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(Me, "Erreur lors de l'enregistrement : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Function BuildSnapshot() As ProductionSnapshot
            Dim snapshot As New ProductionSnapshot() With {
                .Scan = _scan,
                .Formule = _formule,
                .Mode = _mode,
                .OperatorName = _operatorTextBox.Text.Trim(),
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

            _summaryLabel.Text = $"Sacs posés : {totalPlaced}/{totalPlanned} | Produits terminés : {completed}/{totalProducts}"
        End Sub

        Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
            _clockTimer.Stop()
            _clockTimer.Dispose()
            MyBase.OnFormClosed(e)
        End Sub
    End Class
End Namespace
