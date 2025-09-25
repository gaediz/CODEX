Namespace DesensacheuseModern.UI
    Partial Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        <System.Diagnostics.DebuggerNonUserCode>
        Protected Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        ' Required method for Designer support - do not modify
        ' the contents of this method with the code editor.
        <System.Diagnostics.DebuggerStepThrough>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.RootLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.HeaderPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.TitleLabel = New System.Windows.Forms.Label()
            Me.SummaryPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.SummaryLabel = New System.Windows.Forms.Label()
            Me.SummaryProgressBar = New System.Windows.Forms.ProgressBar()
            Me.ProgressHintLabel = New System.Windows.Forms.Label()
            Me.InfoPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.OrderValueLabel = New System.Windows.Forms.Label()
            Me.KnifeValueLabel = New System.Windows.Forms.Label()
            Me.ColorValueLabel = New System.Windows.Forms.Label()
            Me.ModeValueLabel = New System.Windows.Forms.Label()
            Me.OperatorCaptionLabel = New System.Windows.Forms.Label()
            Me.OperatorTextBox = New System.Windows.Forms.TextBox()
            Me.ScanPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.ScanEntryLabel = New System.Windows.Forms.Label()
            Me.ScanEntryTextBox = New System.Windows.Forms.TextBox()
            Me.ProductsGrid = New System.Windows.Forms.DataGridView()
            Me.FooterPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.IncrementButton = New System.Windows.Forms.Button()
            Me.DecrementButton = New System.Windows.Forms.Button()
            Me.MarkCompleteButton = New System.Windows.Forms.Button()
            Me.ResetButton = New System.Windows.Forms.Button()
            Me.SaveButton = New System.Windows.Forms.Button()
            Me.CompleteSessionButton = New System.Windows.Forms.Button()
            Me.CloseButton = New System.Windows.Forms.Button()
            Me.MainStatusStrip = New System.Windows.Forms.StatusStrip()
            Me.ClockStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
            Me.RootLayoutPanel.SuspendLayout()
            Me.HeaderPanel.SuspendLayout()
            Me.InfoPanel.SuspendLayout()
            Me.ScanPanel.SuspendLayout()
            CType(Me.ProductsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.FooterPanel.SuspendLayout()
            Me.MainStatusStrip.SuspendLayout()
            Me.SuspendLayout()
            '
            'RootLayoutPanel
            '
            Me.RootLayoutPanel.ColumnCount = 1
            Me.RootLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.RootLayoutPanel.Controls.Add(Me.HeaderPanel, 0, 0)
            Me.RootLayoutPanel.Controls.Add(Me.ProductsGrid, 0, 1)
            Me.RootLayoutPanel.Controls.Add(Me.FooterPanel, 0, 2)
            Me.RootLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RootLayoutPanel.Location = New System.Drawing.Point(0, 0)
            Me.RootLayoutPanel.Name = "RootLayoutPanel"
            Me.RootLayoutPanel.RowCount = 3
            Me.RootLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
            Me.RootLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.RootLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
            Me.RootLayoutPanel.Size = New System.Drawing.Size(984, 611)
            Me.RootLayoutPanel.TabIndex = 0
            '
            'HeaderPanel
            '
            Me.HeaderPanel.ColumnCount = 2
            Me.HeaderPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.HeaderPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.HeaderPanel.Controls.Add(Me.TitleLabel, 0, 0)
            Me.HeaderPanel.Controls.Add(Me.SummaryPanel, 0, 1)
            Me.HeaderPanel.Controls.Add(Me.InfoPanel, 0, 2)
            Me.HeaderPanel.Controls.Add(Me.ScanPanel, 1, 2)
            Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.HeaderPanel.Location = New System.Drawing.Point(3, 3)
            Me.HeaderPanel.Name = "HeaderPanel"
            Me.HeaderPanel.Padding = New System.Windows.Forms.Padding(20)
            Me.HeaderPanel.RowCount = 3
            Me.HeaderPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
            Me.HeaderPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
            Me.HeaderPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.HeaderPanel.Size = New System.Drawing.Size(978, 194)
            Me.HeaderPanel.TabIndex = 0
            '
            'TitleLabel
            '
            Me.TitleLabel.AutoSize = True
            Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.TitleLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.PrimaryColor
            Me.TitleLabel.Location = New System.Drawing.Point(23, 20)
            Me.TitleLabel.Name = "TitleLabel"
            Me.TitleLabel.Size = New System.Drawing.Size(458, 60)
            Me.TitleLabel.TabIndex = 0
            Me.TitleLabel.Text = "Formule"
            Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.HeaderPanel.SetColumnSpan(Me.TitleLabel, 2)
            '
            'SummaryPanel
            '
            Me.SummaryPanel.ColumnCount = 1
            Me.SummaryPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.SummaryPanel.Controls.Add(Me.SummaryLabel, 0, 0)
            Me.SummaryPanel.Controls.Add(Me.SummaryProgressBar, 0, 1)
            Me.SummaryPanel.Controls.Add(Me.ProgressHintLabel, 0, 2)
            Me.SummaryPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SummaryPanel.Location = New System.Drawing.Point(23, 83)
            Me.SummaryPanel.Name = "SummaryPanel"
            Me.SummaryPanel.RowCount = 3
            Me.SummaryPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
            Me.SummaryPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.SummaryPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.SummaryPanel.Size = New System.Drawing.Size(458, 84)
            Me.SummaryPanel.TabIndex = 6
            Me.HeaderPanel.SetColumnSpan(Me.SummaryPanel, 2)

            'SummaryLabel
            '
            Me.SummaryLabel.AutoSize = True
            Me.SummaryLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SummaryLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.SummaryLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.TextColor
            Me.SummaryLabel.Location = New System.Drawing.Point(3, 0)
            Me.SummaryLabel.Name = "SummaryLabel"
            Me.SummaryLabel.Size = New System.Drawing.Size(452, 32)
            Me.SummaryLabel.TabIndex = 0
            Me.SummaryLabel.Text = "Sacs posés : 0/0 | Produits terminés : 0/0"
            Me.SummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

            'SummaryProgressBar
            '
            Me.SummaryProgressBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SummaryProgressBar.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.AccentColor
            Me.SummaryProgressBar.Location = New System.Drawing.Point(3, 35)
            Me.SummaryProgressBar.MarqueeAnimationSpeed = 0
            Me.SummaryProgressBar.Maximum = 100
            Me.SummaryProgressBar.Name = "SummaryProgressBar"
            Me.SummaryProgressBar.Size = New System.Drawing.Size(452, 14)
            Me.SummaryProgressBar.Step = 1
            Me.SummaryProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
            Me.SummaryProgressBar.TabIndex = 1

            'ProgressHintLabel
            '
            Me.ProgressHintLabel.AutoSize = True
            Me.ProgressHintLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ProgressHintLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.SecondaryTextColor
            Me.ProgressHintLabel.Location = New System.Drawing.Point(3, 52)
            Me.ProgressHintLabel.Name = "ProgressHintLabel"
            Me.ProgressHintLabel.Size = New System.Drawing.Size(452, 32)
            Me.ProgressHintLabel.TabIndex = 2
            Me.ProgressHintLabel.Text = "0% du plan réalisé"
            Me.ProgressHintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'InfoPanel
            '
            Me.InfoPanel.ColumnCount = 3
            Me.InfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
            Me.InfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
            Me.InfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
            Me.InfoPanel.Controls.Add(Me.OrderValueLabel, 0, 0)
            Me.InfoPanel.Controls.Add(Me.KnifeValueLabel, 1, 0)
            Me.InfoPanel.Controls.Add(Me.ColorValueLabel, 2, 0)
            Me.InfoPanel.Controls.Add(Me.ModeValueLabel, 0, 1)
            Me.InfoPanel.Controls.Add(Me.OperatorCaptionLabel, 1, 1)
            Me.InfoPanel.Controls.Add(Me.OperatorTextBox, 2, 1)
            Me.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.InfoPanel.Location = New System.Drawing.Point(23, 173)
            Me.InfoPanel.Name = "InfoPanel"
            Me.InfoPanel.RowCount = 2
            Me.InfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.InfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.InfoPanel.Size = New System.Drawing.Size(458, 54)
            Me.InfoPanel.TabIndex = 2
            '
            'OrderValueLabel
            '
            Me.OrderValueLabel.AutoSize = True
            Me.OrderValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OrderValueLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.TextColor
            Me.OrderValueLabel.Location = New System.Drawing.Point(3, 0)
            Me.OrderValueLabel.Name = "OrderValueLabel"
            Me.OrderValueLabel.Size = New System.Drawing.Size(144, 24)
            Me.OrderValueLabel.TabIndex = 0
            Me.OrderValueLabel.Text = "OF :"
            Me.OrderValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'KnifeValueLabel
            '
            Me.KnifeValueLabel.AutoSize = True
            Me.KnifeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KnifeValueLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.TextColor
            Me.KnifeValueLabel.Location = New System.Drawing.Point(153, 0)
            Me.KnifeValueLabel.Name = "KnifeValueLabel"
            Me.KnifeValueLabel.Size = New System.Drawing.Size(144, 24)
            Me.KnifeValueLabel.TabIndex = 1
            Me.KnifeValueLabel.Text = "Couteau :"
            Me.KnifeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ColorValueLabel
            '
            Me.ColorValueLabel.AutoSize = True
            Me.ColorValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ColorValueLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.TextColor
            Me.ColorValueLabel.Location = New System.Drawing.Point(303, 0)
            Me.ColorValueLabel.Name = "ColorValueLabel"
            Me.ColorValueLabel.Size = New System.Drawing.Size(152, 24)
            Me.ColorValueLabel.TabIndex = 2
            Me.ColorValueLabel.Text = "Couleur :"
            Me.ColorValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ModeValueLabel
            '
            Me.ModeValueLabel.AutoSize = True
            Me.ModeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ModeValueLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.TextColor
            Me.ModeValueLabel.Location = New System.Drawing.Point(3, 27)
            Me.ModeValueLabel.Name = "ModeValueLabel"
            Me.ModeValueLabel.Size = New System.Drawing.Size(144, 27)
            Me.ModeValueLabel.TabIndex = 3
            Me.ModeValueLabel.Text = "Mode :"
            Me.ModeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'OperatorCaptionLabel
            '
            Me.OperatorCaptionLabel.AutoSize = True
            Me.OperatorCaptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OperatorCaptionLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.TextColor
            Me.OperatorCaptionLabel.Location = New System.Drawing.Point(153, 27)
            Me.OperatorCaptionLabel.Name = "OperatorCaptionLabel"
            Me.OperatorCaptionLabel.Size = New System.Drawing.Size(144, 27)
            Me.OperatorCaptionLabel.TabIndex = 4
            Me.OperatorCaptionLabel.Text = "Opérateur :"
            Me.OperatorCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'OperatorTextBox
            '
            Me.OperatorTextBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OperatorTextBox.Location = New System.Drawing.Point(303, 30)
            Me.OperatorTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
            Me.OperatorTextBox.Name = "OperatorTextBox"
            Me.OperatorTextBox.Size = New System.Drawing.Size(152, 24)
            Me.OperatorTextBox.TabIndex = 5
            '
            'ScanPanel
            '
            Me.ScanPanel.ColumnCount = 2
            Me.ScanPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
            Me.ScanPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.ScanPanel.Controls.Add(Me.ScanEntryLabel, 0, 0)
            Me.ScanPanel.Controls.Add(Me.ScanEntryTextBox, 1, 0)
            Me.ScanPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ScanPanel.Location = New System.Drawing.Point(487, 173)
            Me.ScanPanel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.ScanPanel.Name = "ScanPanel"
            Me.ScanPanel.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
            Me.ScanPanel.RowCount = 1
            Me.ScanPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.ScanPanel.Size = New System.Drawing.Size(468, 54)
            Me.ScanPanel.TabIndex = 3
            '
            'ScanEntryLabel
            '
            Me.ScanEntryLabel.AutoSize = True
            Me.ScanEntryLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ScanEntryLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.TextColor
            Me.ScanEntryLabel.Location = New System.Drawing.Point(23, 10)
            Me.ScanEntryLabel.Name = "ScanEntryLabel"
            Me.ScanEntryLabel.Size = New System.Drawing.Size(144, 34)
            Me.ScanEntryLabel.TabIndex = 0
            Me.ScanEntryLabel.Text = "Scan produit :"
            Me.ScanEntryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ScanEntryTextBox
            '
            Me.ScanEntryTextBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ScanEntryTextBox.Location = New System.Drawing.Point(173, 13)
            Me.ScanEntryTextBox.Name = "ScanEntryTextBox"
            Me.ScanEntryTextBox.Size = New System.Drawing.Size(272, 29)
            Me.ScanEntryTextBox.TabIndex = 1
            '
            'ProductsGrid
            '
            Me.ProductsGrid.AllowUserToAddRows = False
            Me.ProductsGrid.AllowUserToDeleteRows = False
            Me.ProductsGrid.AutoGenerateColumns = False
            Me.ProductsGrid.BackgroundColor = Global.DesensacheuseModern.Utilities.ThemePalette.SurfaceColor
            Me.ProductsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.ProductsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.ProductsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.PrimaryColor
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle1.SelectionBackColor = Global.DesensacheuseModern.Utilities.ThemePalette.PrimaryColor
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.ProductsGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.ProductsGrid.ColumnHeadersHeight = 44
            Me.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.SurfaceColor
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            DataGridViewCellStyle2.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.TextColor
            DataGridViewCellStyle2.SelectionBackColor = Global.DesensacheuseModern.Utilities.ThemePalette.SecondaryColor
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.ProductsGrid.DefaultCellStyle = DataGridViewCellStyle2
            Me.ProductsGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ProductsGrid.EnableHeadersVisualStyles = False
            Me.ProductsGrid.GridColor = Global.DesensacheuseModern.Utilities.ThemePalette.BorderColor
            Me.ProductsGrid.Location = New System.Drawing.Point(3, 243)
            Me.ProductsGrid.MultiSelect = False
            Me.ProductsGrid.Name = "ProductsGrid"
            Me.ProductsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.ProductsGrid.RowHeadersVisible = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(238, 244, 255)
            DataGridViewCellStyle3.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.TextColor
            DataGridViewCellStyle3.SelectionBackColor = Global.DesensacheuseModern.Utilities.ThemePalette.SecondaryColor
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
            Me.ProductsGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.ProductsGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.ProductsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.ProductsGrid.Size = New System.Drawing.Size(978, 285)
            Me.ProductsGrid.RowTemplate.Height = 36
            Me.ProductsGrid.TabIndex = 1
            '
            'FooterPanel
            '
            Me.FooterPanel.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.SurfaceColor
            Me.FooterPanel.Controls.Add(Me.IncrementButton)
            Me.FooterPanel.Controls.Add(Me.DecrementButton)
            Me.FooterPanel.Controls.Add(Me.MarkCompleteButton)
            Me.FooterPanel.Controls.Add(Me.ResetButton)
            Me.FooterPanel.Controls.Add(Me.SaveButton)
            Me.FooterPanel.Controls.Add(Me.CompleteSessionButton)
            Me.FooterPanel.Controls.Add(Me.CloseButton)
            Me.FooterPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FooterPanel.Location = New System.Drawing.Point(3, 534)
            Me.FooterPanel.Name = "FooterPanel"
            Me.FooterPanel.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
            Me.FooterPanel.Size = New System.Drawing.Size(978, 74)
            Me.FooterPanel.TabIndex = 2
            Me.FooterPanel.WrapContents = False
            '
            'IncrementButton
            '
            Me.IncrementButton.AutoSize = True
            Me.IncrementButton.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.PrimaryColor
            Me.IncrementButton.FlatAppearance.BorderSize = 0
            Me.IncrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.IncrementButton.ForeColor = System.Drawing.Color.White
            Me.IncrementButton.Location = New System.Drawing.Point(23, 13)
            Me.IncrementButton.Name = "IncrementButton"
            Me.IncrementButton.Size = New System.Drawing.Size(95, 31)
            Me.IncrementButton.TabIndex = 0
            Me.IncrementButton.Text = "+1 sac"
            Me.IncrementButton.UseVisualStyleBackColor = False
            '
            'DecrementButton
            '
            Me.DecrementButton.AutoSize = True
            Me.DecrementButton.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.WarningColor
            Me.DecrementButton.FlatAppearance.BorderSize = 0
            Me.DecrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.DecrementButton.ForeColor = System.Drawing.Color.White
            Me.DecrementButton.Location = New System.Drawing.Point(124, 13)
            Me.DecrementButton.Name = "DecrementButton"
            Me.DecrementButton.Size = New System.Drawing.Size(93, 31)
            Me.DecrementButton.TabIndex = 1
            Me.DecrementButton.Text = "-1 sac"
            Me.DecrementButton.UseVisualStyleBackColor = False
            '
            'MarkCompleteButton
            '
            Me.MarkCompleteButton.AutoSize = True
            Me.MarkCompleteButton.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.AccentColor
            Me.MarkCompleteButton.FlatAppearance.BorderSize = 0
            Me.MarkCompleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.MarkCompleteButton.ForeColor = System.Drawing.Color.White
            Me.MarkCompleteButton.Location = New System.Drawing.Point(223, 13)
            Me.MarkCompleteButton.Name = "MarkCompleteButton"
            Me.MarkCompleteButton.Size = New System.Drawing.Size(135, 31)
            Me.MarkCompleteButton.TabIndex = 2
            Me.MarkCompleteButton.Text = "Marquer terminé"
            Me.MarkCompleteButton.UseVisualStyleBackColor = False
            '
            'ResetButton
            '
            Me.ResetButton.AutoSize = True
            Me.ResetButton.BackColor = System.Drawing.Color.FromArgb(96, 125, 139)
            Me.ResetButton.FlatAppearance.BorderSize = 0
            Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ResetButton.ForeColor = System.Drawing.Color.White
            Me.ResetButton.Location = New System.Drawing.Point(364, 13)
            Me.ResetButton.Name = "ResetButton"
            Me.ResetButton.Size = New System.Drawing.Size(106, 31)
            Me.ResetButton.TabIndex = 3
            Me.ResetButton.Text = "Réinitialiser"
            Me.ResetButton.UseVisualStyleBackColor = False
            '
            'SaveButton
            '
            Me.SaveButton.AutoSize = True
            Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(56, 142, 60)
            Me.SaveButton.FlatAppearance.BorderSize = 0
            Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.SaveButton.ForeColor = System.Drawing.Color.White
            Me.SaveButton.Location = New System.Drawing.Point(476, 13)
            Me.SaveButton.Name = "SaveButton"
            Me.SaveButton.Size = New System.Drawing.Size(111, 31)
            Me.SaveButton.TabIndex = 4
            Me.SaveButton.Text = "Enregistrer"
            Me.SaveButton.UseVisualStyleBackColor = False

            'CompleteSessionButton
            '
            Me.CompleteSessionButton.AutoSize = True
            Me.CompleteSessionButton.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.AccentColor
            Me.CompleteSessionButton.FlatAppearance.BorderSize = 0
            Me.CompleteSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.CompleteSessionButton.ForeColor = System.Drawing.Color.White
            Me.CompleteSessionButton.Location = New System.Drawing.Point(593, 13)
            Me.CompleteSessionButton.Name = "CompleteSessionButton"
            Me.CompleteSessionButton.Size = New System.Drawing.Size(162, 31)
            Me.CompleteSessionButton.TabIndex = 5
            Me.CompleteSessionButton.Text = "Terminer la session"
            Me.CompleteSessionButton.UseVisualStyleBackColor = False
            '
            'CloseButton
            '
            Me.CloseButton.AutoSize = True
            Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(84, 110, 122)
            Me.CloseButton.FlatAppearance.BorderSize = 0
            Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.CloseButton.ForeColor = System.Drawing.Color.White
            Me.CloseButton.Location = New System.Drawing.Point(761, 13)
            Me.CloseButton.Name = "CloseButton"
            Me.CloseButton.Size = New System.Drawing.Size(82, 31)
            Me.CloseButton.TabIndex = 6
            Me.CloseButton.Text = "Fermer"
            Me.CloseButton.UseVisualStyleBackColor = False
            '
            'MainStatusStrip
            '
            Me.MainStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClockStatusLabel})
            Me.MainStatusStrip.Location = New System.Drawing.Point(0, 589)
            Me.MainStatusStrip.Name = "MainStatusStrip"
            Me.MainStatusStrip.Size = New System.Drawing.Size(984, 22)
            Me.MainStatusStrip.TabIndex = 1
            Me.MainStatusStrip.Text = "StatusStrip1"
            '
            'ClockStatusLabel
            '
            Me.ClockStatusLabel.Name = "ClockStatusLabel"
            Me.ClockStatusLabel.Size = New System.Drawing.Size(118, 17)
            Me.ClockStatusLabel.Text = "Temps écoulé : 00:00:00"
            '
            'ClockTimer
            '
            Me.ClockTimer.Interval = 1000
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.BackgroundColor
            Me.ClientSize = New System.Drawing.Size(984, 611)
            Me.Controls.Add(Me.RootLayoutPanel)
            Me.Controls.Add(Me.MainStatusStrip)
            Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.Name = "MainForm"
            Me.Text = "Désensacheuse - Suivi de production"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.RootLayoutPanel.ResumeLayout(False)
            Me.HeaderPanel.ResumeLayout(False)
            Me.HeaderPanel.PerformLayout()
            Me.SummaryPanel.ResumeLayout(False)
            Me.SummaryPanel.PerformLayout()
            Me.InfoPanel.ResumeLayout(False)
            Me.InfoPanel.PerformLayout()
            Me.ScanPanel.ResumeLayout(False)
            Me.ScanPanel.PerformLayout()
            CType(Me.ProductsGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.FooterPanel.ResumeLayout(False)
            Me.FooterPanel.PerformLayout()
            Me.MainStatusStrip.ResumeLayout(False)
            Me.MainStatusStrip.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents RootLayoutPanel As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents HeaderPanel As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TitleLabel As System.Windows.Forms.Label
        Friend WithEvents SummaryPanel As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents SummaryLabel As System.Windows.Forms.Label
        Friend WithEvents SummaryProgressBar As System.Windows.Forms.ProgressBar
        Friend WithEvents ProgressHintLabel As System.Windows.Forms.Label
        Friend WithEvents InfoPanel As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents OrderValueLabel As System.Windows.Forms.Label
        Friend WithEvents KnifeValueLabel As System.Windows.Forms.Label
        Friend WithEvents ColorValueLabel As System.Windows.Forms.Label
        Friend WithEvents ModeValueLabel As System.Windows.Forms.Label
        Friend WithEvents OperatorCaptionLabel As System.Windows.Forms.Label
        Friend WithEvents OperatorTextBox As System.Windows.Forms.TextBox
        Friend WithEvents ScanPanel As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents ScanEntryLabel As System.Windows.Forms.Label
        Friend WithEvents ScanEntryTextBox As System.Windows.Forms.TextBox
        Friend WithEvents ProductsGrid As System.Windows.Forms.DataGridView
        Friend WithEvents FooterPanel As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents IncrementButton As System.Windows.Forms.Button
        Friend WithEvents DecrementButton As System.Windows.Forms.Button
        Friend WithEvents MarkCompleteButton As System.Windows.Forms.Button
        Friend WithEvents ResetButton As System.Windows.Forms.Button
        Friend WithEvents SaveButton As System.Windows.Forms.Button
        Friend WithEvents CompleteSessionButton As System.Windows.Forms.Button
        Friend WithEvents CloseButton As System.Windows.Forms.Button
        Friend WithEvents MainStatusStrip As System.Windows.Forms.StatusStrip
        Friend WithEvents ClockStatusLabel As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents ClockTimer As System.Windows.Forms.Timer
    End Class
End Namespace
