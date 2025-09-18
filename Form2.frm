VERSION 5.00
Begin VB.Form Form2 
   Caption         =   "Verification du lecteur Code Barre"
   ClientHeight    =   3285
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   9150
   LinkTopic       =   "Form2"
   ScaleHeight     =   3285
   ScaleWidth      =   9150
   Begin VB.CommandButton Command1 
      Caption         =   "Valider"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3240
      TabIndex        =   2
      Top             =   2520
      Width           =   1575
   End
   Begin VB.TextBox Text2 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1920
      TabIndex        =   1
      Top             =   1680
      Width           =   4695
   End
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1920
      TabIndex        =   0
      Top             =   840
      Width           =   4695
   End
   Begin VB.Label Label3 
      Caption         =   "TEST KO"
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
      Left            =   240
      TabIndex        =   5
      Top             =   1800
      Width           =   1455
   End
   Begin VB.Label Label2 
      Caption         =   "TEST OK"
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
      Left            =   240
      TabIndex        =   4
      Top             =   960
      Width           =   1455
   End
   Begin VB.Label Label1 
      Caption         =   "Veuillez Scanner les codes barres de test svp..."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   840
      TabIndex        =   3
      Top             =   120
      Width           =   6735
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()


If Text1.Text <> Text2.Text Then

MsgBox (" Le lecteur code barre fonctionne correctement")
ok = True
nbr_prepa = 0
Else

MsgBox (" LE LECTEUR CODE BARRE A UN DYSFONCTIONNEMENT VEUILLEZ CONTACTER LE SERVICE INFORMATIQUE...")
ok = False

End If


Dim rsaccess As New ADODB.Recordset
'Dim cnn1 As New ADODB.Connection

rsaccess.CursorLocation = adUseServer
'cnn1.Open "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\desensacheuse.mdb;Persist Security Info=False"
'Set rsaccess = cnn1.Execute("select * from table1")
rsaccess.Open "select * from test_cdb", "FILE NAME=C:\access_desensacheuse1.udl", adOpenDynamic, adLockOptimistic

rsaccess.AddNew
rsaccess.Fields("date").Value = Date
rsaccess.Fields("heure").Value = Time
rsaccess.Fields("saisieA").Value = Text1.Text
rsaccess.Fields("saisieB").Value = Text2.Text
rsaccess.Fields("fonctionnement_verrou").Value = ok
rsaccess.Update
rsaccess.Close

Me.Hide


End Sub

Private Sub Form_Load()
Text1.Text = ""
Text2.Text = ""
End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)
If KeyAscii = vbKeyReturn Then
    SendKeys "{TAB}"
KeyAscii = 0
End If
End Sub

Private Sub Text2_KeyPress(KeyAscii As Integer)
If KeyAscii = vbKeyReturn Then
    SendKeys "{TAB}"
KeyAscii = 0
End If
End Sub
