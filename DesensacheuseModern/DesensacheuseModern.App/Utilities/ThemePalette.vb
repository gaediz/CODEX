Imports System.Drawing

Namespace DesensacheuseModern.Utilities
    Public NotInheritable Class ThemePalette
        Private Sub New()
        End Sub

        Public Shared ReadOnly Property BackgroundColor As Color
            Get
                Return Color.FromArgb(245, 246, 250)
            End Get
        End Property

        Public Shared ReadOnly Property PrimaryColor As Color
            Get
                Return Color.FromArgb(33, 150, 243)
            End Get
        End Property

        Public Shared ReadOnly Property AccentColor As Color
            Get
                Return Color.FromArgb(0, 200, 83)
            End Get
        End Property

        Public Shared ReadOnly Property WarningColor As Color
            Get
                Return Color.FromArgb(255, 143, 0)
            End Get
        End Property

        Public Shared ReadOnly Property TextColor As Color
            Get
                Return Color.FromArgb(33, 37, 41)
            End Get
        End Property
    End Class
End Namespace
