VERSION 5.00
Begin VB.Form Dialog 
   BackColor       =   &H00C0C0C0&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Boîte de dialogue"
   ClientHeight    =   3195
   ClientLeft      =   2340
   ClientTop       =   4275
   ClientWidth     =   9735
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   3195
   ScaleWidth      =   9735
   ShowInTaskbar   =   0   'False
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   24
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   960
      TabIndex        =   1
      Top             =   1920
      Width           =   7335
   End
   Begin VB.CommandButton CancelButton 
      Caption         =   "Annuler"
      Height          =   375
      Left            =   8280
      TabIndex        =   2
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton OKButton 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   8280
      TabIndex        =   0
      Top             =   600
      Width           =   1215
   End
   Begin VB.Label Label1 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Veuillez Scanner le code barre correspondant à l'OF..."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   360
      TabIndex        =   3
      Top             =   720
      Width           =   7815
   End
End
Attribute VB_Name = "Dialog"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

'Option Explicit

Dim chaine2 As String
Public numcouteau, numof, chaine1 As String





Private Sub CancelButton_Click()
Text1.Text = ""
End Sub

Private Sub Form_Activate()
Text1.Text = ""
Text1.SetFocus
Dialog.Left = (MDIForm1.ScaleWidth - Dialog.Width) / 2
Dialog.Top = (MDIForm1.ScaleHeight - Dialog.Height) / 2

End Sub

Private Sub Form_Load()
'Text1.Text = ""

End Sub

Public Sub OKButton_Click()


chaine1 = Text1.Text
If chaine1 <> "" Then
    chaine2 = VBA.Right(chaine1, 4)
    numcouteau = Left(chaine2, 1)
    numof = Left(chaine1, 8)
    numcouteau = "0" & numcouteau
    
    
End If


choixmode.Show
Me.Hide

End Sub

