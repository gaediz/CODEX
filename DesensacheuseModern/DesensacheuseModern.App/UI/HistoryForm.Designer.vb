Namespace DesensacheuseModern.UI
    Partial Class HistoryForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer

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

        <System.Diagnostics.DebuggerStepThrough>
        Private Sub InitializeComponent()
            Me.RootLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.TitleLabel = New System.Windows.Forms.Label()
            Me.DescriptionLabel = New System.Windows.Forms.Label()
            Me.HistoryGrid = New System.Windows.Forms.DataGridView()
            Me.EmptyLabel = New System.Windows.Forms.Label()
            Me.DetailsTextBox = New System.Windows.Forms.TextBox()
            Me.ButtonsPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.ReloadButton = New System.Windows.Forms.Button()
            Me.CloseButton = New System.Windows.Forms.Button()
            Me.GridContainerPanel = New System.Windows.Forms.Panel()
            Me.RootLayoutPanel.SuspendLayout()
            CType(Me.HistoryGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ButtonsPanel.SuspendLayout()
            Me.GridContainerPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'RootLayoutPanel
            '
            Me.RootLayoutPanel.ColumnCount = 1
            Me.RootLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.RootLayoutPanel.Controls.Add(Me.TitleLabel, 0, 0)
            Me.RootLayoutPanel.Controls.Add(Me.DescriptionLabel, 0, 1)
            Me.RootLayoutPanel.Controls.Add(Me.GridContainerPanel, 0, 2)
            Me.RootLayoutPanel.Controls.Add(Me.DetailsTextBox, 0, 3)
            Me.RootLayoutPanel.Controls.Add(Me.ButtonsPanel, 0, 4)
            Me.RootLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RootLayoutPanel.Location = New System.Drawing.Point(0, 0)
            Me.RootLayoutPanel.Name = "RootLayoutPanel"
            Me.RootLayoutPanel.Padding = New System.Windows.Forms.Padding(20)
            Me.RootLayoutPanel.RowCount = 5
            Me.RootLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
            Me.RootLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.RootLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
            Me.RootLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
            Me.RootLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
            Me.RootLayoutPanel.Size = New System.Drawing.Size(900, 560)
            Me.RootLayoutPanel.TabIndex = 0
            '
            'TitleLabel
            '
            Me.TitleLabel.AutoSize = True
            Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.TitleLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.PrimaryColor
            Me.TitleLabel.Location = New System.Drawing.Point(23, 20)
            Me.TitleLabel.Name = "TitleLabel"
            Me.TitleLabel.Size = New System.Drawing.Size(854, 60)
            Me.TitleLabel.TabIndex = 0
            Me.TitleLabel.Text = "Historique des productions"
            Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'DescriptionLabel
            '
            Me.DescriptionLabel.AutoSize = True
            Me.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DescriptionLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.SecondaryTextColor
            Me.DescriptionLabel.Location = New System.Drawing.Point(23, 80)
            Me.DescriptionLabel.Name = "DescriptionLabel"
            Me.DescriptionLabel.Size = New System.Drawing.Size(854, 40)
            Me.DescriptionLabel.TabIndex = 1
            Me.DescriptionLabel.Text = "Consultez les sessions enregistrées récemment."
            Me.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GridContainerPanel
            '
            Me.GridContainerPanel.Controls.Add(Me.HistoryGrid)
            Me.GridContainerPanel.Controls.Add(Me.EmptyLabel)
            Me.GridContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridContainerPanel.Location = New System.Drawing.Point(23, 123)
            Me.GridContainerPanel.Name = "GridContainerPanel"
            Me.GridContainerPanel.Size = New System.Drawing.Size(854, 207)
            Me.GridContainerPanel.TabIndex = 2
            '
            'HistoryGrid
            '
            Me.HistoryGrid.AllowUserToAddRows = False
            Me.HistoryGrid.AllowUserToDeleteRows = False
            Me.HistoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.HistoryGrid.BackgroundColor = Global.DesensacheuseModern.Utilities.ThemePalette.SurfaceColor
            Me.HistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.HistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.HistoryGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.HistoryGrid.EnableHeadersVisualStyles = False
            Me.HistoryGrid.Location = New System.Drawing.Point(0, 0)
            Me.HistoryGrid.MultiSelect = False
            Me.HistoryGrid.Name = "HistoryGrid"
            Me.HistoryGrid.ReadOnly = True
            Me.HistoryGrid.RowHeadersVisible = False
            Me.HistoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.HistoryGrid.Size = New System.Drawing.Size(854, 207)
            Me.HistoryGrid.TabIndex = 0
            '
            'EmptyLabel
            '
            Me.EmptyLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.EmptyLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.EmptyLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.SecondaryTextColor
            Me.EmptyLabel.Location = New System.Drawing.Point(0, 0)
            Me.EmptyLabel.Name = "EmptyLabel"
            Me.EmptyLabel.Size = New System.Drawing.Size(854, 207)
            Me.EmptyLabel.TabIndex = 1
            Me.EmptyLabel.Text = "Aucune production enregistrée pour le moment."
            Me.EmptyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.EmptyLabel.Visible = False
            '
            'DetailsTextBox
            '
            Me.DetailsTextBox.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.SurfaceColor
            Me.DetailsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DetailsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DetailsTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.DetailsTextBox.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.TextColor
            Me.DetailsTextBox.Location = New System.Drawing.Point(23, 336)
            Me.DetailsTextBox.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
            Me.DetailsTextBox.Multiline = True
            Me.DetailsTextBox.Name = "DetailsTextBox"
            Me.DetailsTextBox.ReadOnly = True
            Me.DetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DetailsTextBox.Size = New System.Drawing.Size(854, 150)
            Me.DetailsTextBox.TabIndex = 3
            '
            'ButtonsPanel
            '
            Me.ButtonsPanel.Controls.Add(Me.ReloadButton)
            Me.ButtonsPanel.Controls.Add(Me.CloseButton)
            Me.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ButtonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
            Me.ButtonsPanel.Location = New System.Drawing.Point(23, 492)
            Me.ButtonsPanel.Name = "ButtonsPanel"
            Me.ButtonsPanel.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.ButtonsPanel.Size = New System.Drawing.Size(854, 65)
            Me.ButtonsPanel.TabIndex = 4
            Me.ButtonsPanel.WrapContents = False
            '
            'ReloadButton
            '
            Me.ReloadButton.AutoSize = True
            Me.ReloadButton.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.SecondaryColor
            Me.ReloadButton.FlatAppearance.BorderSize = 0
            Me.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ReloadButton.ForeColor = System.Drawing.Color.White
            Me.ReloadButton.Location = New System.Drawing.Point(606, 13)
            Me.ReloadButton.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
            Me.ReloadButton.Name = "ReloadButton"
            Me.ReloadButton.Size = New System.Drawing.Size(115, 44)
            Me.ReloadButton.TabIndex = 0
            Me.ReloadButton.Text = "Actualiser"
            Me.ReloadButton.UseVisualStyleBackColor = False
            '
            'CloseButton
            '
            Me.CloseButton.AutoSize = True
            Me.CloseButton.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.AccentColor
            Me.CloseButton.FlatAppearance.BorderSize = 0
            Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.CloseButton.ForeColor = System.Drawing.Color.White
            Me.CloseButton.Location = New System.Drawing.Point(734, 13)
            Me.CloseButton.Name = "CloseButton"
            Me.CloseButton.Size = New System.Drawing.Size(107, 44)
            Me.CloseButton.TabIndex = 1
            Me.CloseButton.Text = "Fermer"
            Me.CloseButton.UseVisualStyleBackColor = False
            '
            'HistoryForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.BackgroundColor
            Me.ClientSize = New System.Drawing.Size(900, 560)
            Me.Controls.Add(Me.RootLayoutPanel)
            Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "HistoryForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Historique des productions"
            Me.RootLayoutPanel.ResumeLayout(False)
            Me.RootLayoutPanel.PerformLayout()
            CType(Me.HistoryGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ButtonsPanel.ResumeLayout(False)
            Me.ButtonsPanel.PerformLayout()
            Me.GridContainerPanel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents RootLayoutPanel As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TitleLabel As System.Windows.Forms.Label
        Friend WithEvents DescriptionLabel As System.Windows.Forms.Label
        Friend WithEvents HistoryGrid As System.Windows.Forms.DataGridView
        Friend WithEvents EmptyLabel As System.Windows.Forms.Label
        Friend WithEvents DetailsTextBox As System.Windows.Forms.TextBox
        Friend WithEvents ButtonsPanel As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents ReloadButton As System.Windows.Forms.Button
        Friend WithEvents CloseButton As System.Windows.Forms.Button
        Friend WithEvents GridContainerPanel As System.Windows.Forms.Panel
    End Class
End Namespace
