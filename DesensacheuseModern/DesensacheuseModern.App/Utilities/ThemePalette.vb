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

        Public Shared ReadOnly Property SurfaceColor As Color
            Get
                Return Color.White
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

        Public Shared ReadOnly Property SecondaryColor As Color
            Get
                Return Color.FromArgb(100, 181, 246)
            End Get
        End Property

        Public Shared ReadOnly Property WarningColor As Color
            Get
                Return Color.FromArgb(255, 143, 0)
            End Get
        End Property

        Public Shared ReadOnly Property CriticalColor As Color
            Get
                Return Color.FromArgb(211, 47, 47)
            End Get
        End Property

        Public Shared ReadOnly Property TextColor As Color
            Get
                Return Color.FromArgb(33, 37, 41)
            End Get
        End Property

        Public Shared ReadOnly Property SecondaryTextColor As Color
            Get
                Return Color.FromArgb(85, 90, 100)
            End Get
        End Property

        Public Shared ReadOnly Property BorderColor As Color
            Get
                Return Color.FromArgb(223, 228, 234)
            End Get
        End Property

        Public Shared ReadOnly Property CompletedRowColor As Color
            Get
                Return Color.FromArgb(67, 160, 71)
            End Get
        End Property

        Public Shared ReadOnly Property CompletedRowTextColor As Color
            Get
                Return Color.White
            End Get
        End Property
    End Class
End Namespace
