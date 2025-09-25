Namespace DesensacheuseModern.UI
    Partial Class ScanForm
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
            Me.ContentPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.TitleLabel = New System.Windows.Forms.Label()
            Me.InstructionsLabel = New System.Windows.Forms.Label()
            Me.ScanTextBox = New System.Windows.Forms.TextBox()
            Me.ButtonsPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.ConfirmButton = New System.Windows.Forms.Button()
            Me.HistoryButton = New System.Windows.Forms.Button()
            Me.ErrorLabel = New System.Windows.Forms.Label()
            Me.ExitButton = New System.Windows.Forms.Button()
            Me.ContentPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'ContentPanel
            '
            Me.ContentPanel.ColumnCount = 1
            Me.ContentPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.ContentPanel.Controls.Add(Me.TitleLabel, 0, 0)
            Me.ContentPanel.Controls.Add(Me.InstructionsLabel, 0, 1)
            Me.ContentPanel.Controls.Add(Me.ScanTextBox, 0, 2)
            Me.ContentPanel.Controls.Add(Me.ButtonsPanel, 0, 3)
            Me.ContentPanel.Controls.Add(Me.ErrorLabel, 0, 4)
            Me.ContentPanel.Controls.Add(Me.ExitButton, 0, 5)
            Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ContentPanel.Location = New System.Drawing.Point(0, 0)
            Me.ContentPanel.Name = "ContentPanel"
            Me.ContentPanel.Padding = New System.Windows.Forms.Padding(30)
            Me.ContentPanel.RowCount = 6
            Me.ContentPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
            Me.ContentPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.ContentPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
            Me.ContentPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
            Me.ContentPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.ContentPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
            Me.ContentPanel.Size = New System.Drawing.Size(684, 401)
            Me.ContentPanel.TabIndex = 0
            '
            'TitleLabel
            '
            Me.TitleLabel.AutoSize = True
            Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.TitleLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.PrimaryColor
            Me.TitleLabel.Location = New System.Drawing.Point(33, 30)
            Me.TitleLabel.Name = "TitleLabel"
            Me.TitleLabel.Size = New System.Drawing.Size(618, 60)
            Me.TitleLabel.TabIndex = 0
            Me.TitleLabel.Text = "Bienvenue"
            Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'InstructionsLabel
            '
            Me.InstructionsLabel.AutoSize = True
            Me.InstructionsLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.InstructionsLabel.ForeColor = Global.DesensacheuseModern.Utilities.ThemePalette.TextColor
            Me.InstructionsLabel.Location = New System.Drawing.Point(33, 90)
            Me.InstructionsLabel.Name = "InstructionsLabel"
            Me.InstructionsLabel.Size = New System.Drawing.Size(618, 50)
            Me.InstructionsLabel.TabIndex = 1
            Me.InstructionsLabel.Text = "Scannez ou saisissez le code OF pour démarrer."
            Me.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ScanTextBox
            '
            Me.ScanTextBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ScanTextBox.Location = New System.Drawing.Point(33, 143)
            Me.ScanTextBox.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
            Me.ScanTextBox.Name = "ScanTextBox"
            Me.ScanTextBox.Size = New System.Drawing.Size(618, 27)
            Me.ScanTextBox.TabIndex = 2
            '
            'ButtonsPanel
            '
            Me.ButtonsPanel.BackColor = System.Drawing.Color.Transparent
            Me.ButtonsPanel.Controls.Add(Me.ConfirmButton)
            Me.ButtonsPanel.Controls.Add(Me.HistoryButton)
            Me.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ButtonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight
            Me.ButtonsPanel.Location = New System.Drawing.Point(33, 213)
            Me.ButtonsPanel.Name = "ButtonsPanel"
            Me.ButtonsPanel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            Me.ButtonsPanel.Size = New System.Drawing.Size(618, 64)
            Me.ButtonsPanel.TabIndex = 3
            Me.ButtonsPanel.WrapContents = False

            'ConfirmButton
            '
            Me.ConfirmButton.AutoSize = True
            Me.ConfirmButton.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.PrimaryColor
            Me.ConfirmButton.FlatAppearance.BorderSize = 0
            Me.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ConfirmButton.ForeColor = System.Drawing.Color.White
            Me.ConfirmButton.Location = New System.Drawing.Point(3, 8)
            Me.ConfirmButton.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
            Me.ConfirmButton.Name = "ConfirmButton"
            Me.ConfirmButton.Size = New System.Drawing.Size(304, 54)
            Me.ConfirmButton.TabIndex = 0
            Me.ConfirmButton.Text = "Valider"
            Me.ConfirmButton.UseVisualStyleBackColor = False

            'HistoryButton
            '
            Me.HistoryButton.AutoSize = True
            Me.HistoryButton.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.SecondaryColor
            Me.HistoryButton.FlatAppearance.BorderSize = 0
            Me.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.HistoryButton.ForeColor = System.Drawing.Color.White
            Me.HistoryButton.Location = New System.Drawing.Point(317, 8)
            Me.HistoryButton.Name = "HistoryButton"
            Me.HistoryButton.Size = New System.Drawing.Size(298, 54)
            Me.HistoryButton.TabIndex = 1
            Me.HistoryButton.Text = "Consulter l'historique"
            Me.HistoryButton.UseVisualStyleBackColor = False
            '
            'ErrorLabel
            '
            Me.ErrorLabel.AutoSize = True
            Me.ErrorLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(211, 47, 47)
            Me.ErrorLabel.Location = New System.Drawing.Point(33, 280)
            Me.ErrorLabel.Name = "ErrorLabel"
            Me.ErrorLabel.Size = New System.Drawing.Size(618, 51)
            Me.ErrorLabel.TabIndex = 4
            Me.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.ErrorLabel.Visible = False
            '
            'ExitButton
            '
            Me.ExitButton.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.WarningColor
            Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ExitButton.FlatAppearance.BorderSize = 0
            Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ExitButton.ForeColor = System.Drawing.Color.White
            Me.ExitButton.Location = New System.Drawing.Point(33, 334)
            Me.ExitButton.Name = "ExitButton"
            Me.ExitButton.Size = New System.Drawing.Size(618, 64)
            Me.ExitButton.TabIndex = 5
            Me.ExitButton.Text = "Quitter"
            Me.ExitButton.UseVisualStyleBackColor = False
            '
            'ScanForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = Global.DesensacheuseModern.Utilities.ThemePalette.BackgroundColor
            Me.ClientSize = New System.Drawing.Size(684, 401)
            Me.Controls.Add(Me.ContentPanel)
            Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "ScanForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Désensacheuse - Accueil"
            Me.AcceptButton = Me.ConfirmButton
            Me.ContentPanel.ResumeLayout(False)
            Me.ContentPanel.PerformLayout()
            Me.ButtonsPanel.ResumeLayout(False)
            Me.ButtonsPanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents ContentPanel As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TitleLabel As System.Windows.Forms.Label
        Friend WithEvents InstructionsLabel As System.Windows.Forms.Label
        Friend WithEvents ScanTextBox As System.Windows.Forms.TextBox
        Friend WithEvents ButtonsPanel As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents ConfirmButton As System.Windows.Forms.Button
        Friend WithEvents HistoryButton As System.Windows.Forms.Button
        Friend WithEvents ErrorLabel As System.Windows.Forms.Label
        Friend WithEvents ExitButton As System.Windows.Forms.Button
    End Class
End Namespace
