Namespace DesensacheuseModern.UI
    Partial Class ModeSelectionForm
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
            Me.ContentLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.TitleLabel = New System.Windows.Forms.Label()
            Me.DetailsLabel = New System.Windows.Forms.Label()
            Me.RecommendationLabel = New System.Windows.Forms.Label()
            Me.InfoLabel = New System.Windows.Forms.Label()
            Me.ButtonPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.DesensacheuseButton = New System.Windows.Forms.Button()
            Me.PaletteButton = New System.Windows.Forms.Button()
            Me.ContentLayoutPanel.SuspendLayout()
            Me.ButtonPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'ContentLayoutPanel
            '
            Me.ContentLayoutPanel.ColumnCount = 1
            Me.ContentLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.ContentLayoutPanel.Controls.Add(Me.TitleLabel, 0, 0)
            Me.ContentLayoutPanel.Controls.Add(Me.DetailsLabel, 0, 1)
            Me.ContentLayoutPanel.Controls.Add(Me.RecommendationLabel, 0, 2)
            Me.ContentLayoutPanel.Controls.Add(Me.InfoLabel, 0, 3)
            Me.ContentLayoutPanel.Controls.Add(Me.ButtonPanel, 0, 4)
            Me.ContentLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ContentLayoutPanel.Location = New System.Drawing.Point(0, 0)
            Me.ContentLayoutPanel.Name = "ContentLayoutPanel"
            Me.ContentLayoutPanel.Padding = New System.Windows.Forms.Padding(20)
            Me.ContentLayoutPanel.RowCount = 5
            Me.ContentLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
            Me.ContentLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
            Me.ContentLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.ContentLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.ContentLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
            Me.ContentLayoutPanel.Size = New System.Drawing.Size(664, 360)
            Me.ContentLayoutPanel.TabIndex = 0
            '
            'TitleLabel
            '
            Me.TitleLabel.AutoSize = True
            Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.TitleLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.PrimaryColor
            Me.TitleLabel.Location = New System.Drawing.Point(23, 20)
            Me.TitleLabel.Name = "TitleLabel"
            Me.TitleLabel.Size = New System.Drawing.Size(618, 60)
            Me.TitleLabel.TabIndex = 0
            Me.TitleLabel.Text = "Mode de fonctionnement"
            Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'DetailsLabel
            '
            Me.DetailsLabel.AutoSize = True
            Me.DetailsLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DetailsLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.TextColor
            Me.DetailsLabel.Location = New System.Drawing.Point(23, 80)
            Me.DetailsLabel.Name = "DetailsLabel"
            Me.DetailsLabel.Size = New System.Drawing.Size(618, 80)
            Me.DetailsLabel.TabIndex = 1
            Me.DetailsLabel.Text = "Informations"
            Me.DetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'RecommendationLabel
            '
            Me.RecommendationLabel.AutoSize = True
            Me.RecommendationLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RecommendationLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.SecondaryTextColor
            Me.RecommendationLabel.Location = New System.Drawing.Point(23, 160)
            Me.RecommendationLabel.Name = "RecommendationLabel"
            Me.RecommendationLabel.Size = New System.Drawing.Size(618, 40)
            Me.RecommendationLabel.TabIndex = 2
            Me.RecommendationLabel.Text = "Mode conseillé"
            Me.RecommendationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'InfoLabel
            '
            Me.InfoLabel.AutoSize = True
            Me.InfoLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.InfoLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.TextColor
            Me.InfoLabel.Location = New System.Drawing.Point(23, 200)
            Me.InfoLabel.Name = "InfoLabel"
            Me.InfoLabel.Size = New System.Drawing.Size(618, 121)
            Me.InfoLabel.TabIndex = 3
            Me.InfoLabel.Text = "Sélectionnez le mode qui correspond à votre opération."
            Me.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ButtonPanel
            '
            Me.ButtonPanel.ColumnCount = 2
            Me.ButtonPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.ButtonPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.ButtonPanel.Controls.Add(Me.DesensacheuseButton, 0, 0)
            Me.ButtonPanel.Controls.Add(Me.PaletteButton, 1, 0)
            Me.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ButtonPanel.Location = New System.Drawing.Point(23, 244)
            Me.ButtonPanel.Name = "ButtonPanel"
            Me.ButtonPanel.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.ButtonPanel.RowCount = 1
            Me.ButtonPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.ButtonPanel.Size = New System.Drawing.Size(618, 95)
            Me.ButtonPanel.TabIndex = 3
            '
            'DesensacheuseButton
            '
            Me.DesensacheuseButton.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.PrimaryColor
            Me.DesensacheuseButton.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DesensacheuseButton.FlatAppearance.BorderSize = 0
            Me.DesensacheuseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.DesensacheuseButton.ForeColor = System.Drawing.Color.White
            Me.DesensacheuseButton.Location = New System.Drawing.Point(3, 23)
            Me.DesensacheuseButton.Name = "DesensacheuseButton"
            Me.DesensacheuseButton.Size = New System.Drawing.Size(303, 69)
            Me.DesensacheuseButton.TabIndex = 0
            Me.DesensacheuseButton.Text = "Désensacheuse"
            Me.DesensacheuseButton.UseVisualStyleBackColor = False
            '
            'PaletteButton
            '
            Me.PaletteButton.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.SecondaryColor
            Me.PaletteButton.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PaletteButton.FlatAppearance.BorderSize = 0
            Me.PaletteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.PaletteButton.ForeColor = System.Drawing.Color.White
            Me.PaletteButton.Location = New System.Drawing.Point(312, 23)
            Me.PaletteButton.Name = "PaletteButton"
            Me.PaletteButton.Size = New System.Drawing.Size(303, 69)
            Me.PaletteButton.TabIndex = 1
            Me.PaletteButton.Text = "Palette"
            Me.PaletteButton.UseVisualStyleBackColor = False
            '
            'ModeSelectionForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.BackgroundColor
            Me.ClientSize = New System.Drawing.Size(664, 360)
            Me.Controls.Add(Me.ContentLayoutPanel)
            Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "ModeSelectionForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Sélection du mode"
            Me.ContentLayoutPanel.ResumeLayout(False)
            Me.ContentLayoutPanel.PerformLayout()
            Me.ButtonPanel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents ContentLayoutPanel As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TitleLabel As System.Windows.Forms.Label
        Friend WithEvents DetailsLabel As System.Windows.Forms.Label
        Friend WithEvents RecommendationLabel As System.Windows.Forms.Label
        Friend WithEvents InfoLabel As System.Windows.Forms.Label
        Friend WithEvents ButtonPanel As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents DesensacheuseButton As System.Windows.Forms.Button
        Friend WithEvents PaletteButton As System.Windows.Forms.Button
    End Class
End Namespace
