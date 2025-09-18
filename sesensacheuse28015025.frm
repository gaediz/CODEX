VERSION 5.00
Object = "{648A5603-2C6E-101B-82B6-000000000014}#1.1#0"; "MSCOMM32.OCX"
Object = "{56BBC886-EB3A-48E0-9FD4-274DEABD1613}#4.3#0"; "DCON_X.OCX"
Begin VB.Form Form1 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00C0C0C0&
   ClientHeight    =   10230
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   15240
   ClipControls    =   0   'False
   FillColor       =   &H000000FF&
   HasDC           =   0   'False
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   MousePointer    =   1  'Arrow
   ScaleHeight     =   10230
   ScaleWidth      =   15240
   WindowState     =   2  'Maximized
   Begin DCON_XLib.DCON_X DCON_X1 
      Left            =   360
      Top             =   9240
      _Version        =   262147
      _ExtentX        =   873
      _ExtentY        =   661
      _StockProps     =   1
   End
   Begin VB.TextBox Textbox1 
      Height          =   495
      Left            =   3600
      TabIndex        =   108
      Text            =   "Text1"
      Top             =   10080
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.TextBox txtnomproduit 
      Height          =   375
      Index           =   7
      Left            =   3120
      TabIndex        =   107
      Top             =   1560
      Width           =   1695
   End
   Begin VB.TextBox txtlot2 
      BackColor       =   &H00FF8080&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   7440
      TabIndex        =   40
      Top             =   8280
      Width           =   1335
   End
   Begin VB.TextBox txtlot2 
      BackColor       =   &H00FF8080&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   7440
      TabIndex        =   34
      Top             =   7440
      Width           =   1335
   End
   Begin VB.TextBox txtlot2 
      BackColor       =   &H00FF8080&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   7440
      TabIndex        =   28
      Top             =   6600
      Width           =   1335
   End
   Begin VB.TextBox txtlot2 
      BackColor       =   &H00FF8080&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   7440
      TabIndex        =   22
      Top             =   5760
      Width           =   1335
   End
   Begin VB.TextBox txtlot2 
      BackColor       =   &H00FF8080&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   7440
      TabIndex        =   16
      Top             =   4920
      Width           =   1335
   End
   Begin VB.TextBox txtlot2 
      BackColor       =   &H00FF8080&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   7440
      TabIndex        =   10
      Top             =   4080
      Width           =   1335
   End
   Begin VB.TextBox txtlot1 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   6000
      TabIndex        =   39
      Top             =   8280
      Width           =   1335
   End
   Begin VB.TextBox txtlot1 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   6000
      TabIndex        =   33
      Top             =   7440
      Width           =   1335
   End
   Begin VB.TextBox txtlot1 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   6000
      TabIndex        =   27
      Top             =   6600
      Width           =   1335
   End
   Begin VB.TextBox txtlot1 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   6000
      TabIndex        =   21
      Top             =   5760
      Width           =   1335
   End
   Begin VB.TextBox txtlot1 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   6000
      TabIndex        =   15
      Top             =   4920
      Width           =   1335
   End
   Begin VB.TextBox txtlot1 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   6000
      TabIndex        =   9
      Top             =   4080
      Width           =   1335
   End
   Begin VB.TextBox txtlot2 
      BackColor       =   &H00FF8080&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   7440
      TabIndex        =   4
      Top             =   3240
      Width           =   1335
   End
   Begin VB.TextBox txtlot1 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   6000
      TabIndex        =   3
      Top             =   3240
      Width           =   1335
   End
   Begin VB.Timer Timer3 
      Interval        =   500
      Left            =   4920
      Top             =   10320
   End
   Begin MSCommLib.MSComm MSComm1 
      Left            =   8400
      Top             =   9720
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
      DTREnable       =   0   'False
   End
   Begin VB.Timer Timer2 
      Interval        =   100
      Left            =   5640
      Top             =   9720
   End
   Begin VB.CommandButton cmdmode 
      Caption         =   "Desensacheuse"
      Height          =   495
      Left            =   7200
      TabIndex        =   102
      Top             =   1560
      Visible         =   0   'False
      Width           =   1815
   End
   Begin VB.PictureBox MaskEdBox1 
      Height          =   375
      Left            =   2400
      ScaleHeight     =   315
      ScaleWidth      =   795
      TabIndex        =   100
      Top             =   10080
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.Timer Timer1 
      Interval        =   1000
      Left            =   4920
      Top             =   9720
   End
   Begin VB.TextBox txtcodematscan 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   4560
      TabIndex        =   38
      Top             =   8280
      Width           =   1335
   End
   Begin VB.TextBox txtcodematscan 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   4560
      TabIndex        =   32
      Top             =   7440
      Width           =   1335
   End
   Begin VB.TextBox txtcodematscan 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   4560
      TabIndex        =   26
      Top             =   6600
      Width           =   1335
   End
   Begin VB.TextBox txtcodematscan 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   4560
      TabIndex        =   20
      Top             =   5760
      Width           =   1335
   End
   Begin VB.TextBox txtcodematscan 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   4560
      TabIndex        =   14
      Top             =   4920
      Width           =   1335
   End
   Begin VB.TextBox txtcodematscan 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   4560
      TabIndex        =   8
      Top             =   4080
      Width           =   1335
   End
   Begin VB.TextBox txtcodematscan 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   4560
      TabIndex        =   2
      Top             =   3240
      Width           =   1335
   End
   Begin VB.CommandButton Command1 
      Caption         =   "ANNULER LA FORMULE"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   11160
      TabIndex        =   45
      Top             =   9840
      Width           =   1695
   End
   Begin VB.CommandButton CmdFormule_terminee 
      Caption         =   "FORMULE TERMINEE"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   13320
      TabIndex        =   44
      Top             =   9840
      Width           =   1695
   End
   Begin VB.CommandButton cmdproduit1 
      Caption         =   "VALIDER"
      Enabled         =   0   'False
      Height          =   495
      Index           =   6
      Left            =   14160
      TabIndex        =   43
      Top             =   8280
      Width           =   975
   End
   Begin VB.CommandButton cmdproduit1 
      Caption         =   "VALIDER"
      Enabled         =   0   'False
      Height          =   495
      Index           =   5
      Left            =   14160
      TabIndex        =   37
      Top             =   7440
      Width           =   975
   End
   Begin VB.CommandButton cmdproduit1 
      Caption         =   "VALIDER"
      Enabled         =   0   'False
      Height          =   495
      Index           =   4
      Left            =   14160
      TabIndex        =   31
      Top             =   6600
      Width           =   975
   End
   Begin VB.CommandButton cmdproduit1 
      Caption         =   "VALIDER"
      Enabled         =   0   'False
      Height          =   495
      Index           =   3
      Left            =   14160
      TabIndex        =   25
      Top             =   5760
      Width           =   975
   End
   Begin VB.CommandButton cmdproduit1 
      Caption         =   "VALIDER"
      Enabled         =   0   'False
      Height          =   495
      Index           =   2
      Left            =   14160
      TabIndex        =   19
      Top             =   4920
      Width           =   975
   End
   Begin VB.CommandButton cmdproduit1 
      Caption         =   "VALIDER"
      Enabled         =   0   'False
      Height          =   495
      Index           =   1
      Left            =   14160
      TabIndex        =   13
      Top             =   4080
      Width           =   975
   End
   Begin VB.CommandButton cmdproduit1 
      Caption         =   "VALIDER"
      Enabled         =   0   'False
      Height          =   495
      Index           =   0
      Left            =   14160
      TabIndex        =   7
      Top             =   3240
      Width           =   975
   End
   Begin VB.TextBox txtnbrsacpose 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   11160
      TabIndex        =   41
      Text            =   "0"
      Top             =   8280
      Width           =   615
   End
   Begin VB.TextBox txtnbrsacpose 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   11160
      TabIndex        =   35
      Text            =   "0"
      Top             =   7440
      Width           =   615
   End
   Begin VB.TextBox txtnbrsacpose 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   11160
      TabIndex        =   29
      Text            =   "0"
      Top             =   6600
      Width           =   615
   End
   Begin VB.TextBox txtnbrsacpose 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   11160
      TabIndex        =   23
      Text            =   "0"
      Top             =   5760
      Width           =   615
   End
   Begin VB.TextBox txtnbrsacpose 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   11160
      TabIndex        =   17
      Text            =   "0"
      Top             =   4920
      Width           =   615
   End
   Begin VB.TextBox txtnbrsacpose 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   11160
      TabIndex        =   11
      Text            =   "0"
      Top             =   4080
      Width           =   615
   End
   Begin VB.TextBox txtnbrsacpose 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   11160
      TabIndex        =   5
      Text            =   "0"
      Top             =   3240
      Width           =   615
   End
   Begin VB.TextBox txtcomplementbalance 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   13080
      TabIndex        =   42
      Top             =   8280
      Width           =   855
   End
   Begin VB.TextBox txtcomplementbalance 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   13080
      TabIndex        =   36
      Top             =   7440
      Width           =   855
   End
   Begin VB.TextBox txtcomplementbalance 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   13080
      TabIndex        =   30
      Top             =   6600
      Width           =   855
   End
   Begin VB.TextBox txtcomplementbalance 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   13080
      TabIndex        =   24
      Top             =   5760
      Width           =   855
   End
   Begin VB.TextBox txtcomplementbalance 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   13080
      TabIndex        =   18
      Top             =   4920
      Width           =   855
   End
   Begin VB.TextBox txtcomplementbalance 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   13080
      TabIndex        =   12
      Top             =   4080
      Width           =   855
   End
   Begin VB.TextBox txtcomplementbalance 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   13080
      Locked          =   -1  'True
      TabIndex        =   6
      Top             =   3240
      Width           =   855
   End
   Begin VB.TextBox txtcomplementrecette 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   12000
      TabIndex        =   93
      Top             =   8280
      Width           =   855
   End
   Begin VB.TextBox txtcomplementrecette 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   12000
      TabIndex        =   92
      Top             =   7440
      Width           =   855
   End
   Begin VB.TextBox txtcomplementrecette 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   12000
      TabIndex        =   91
      Top             =   6600
      Width           =   855
   End
   Begin VB.TextBox txtcomplementrecette 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   12000
      TabIndex        =   90
      Top             =   5760
      Width           =   855
   End
   Begin VB.TextBox txtcomplementrecette 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   12000
      TabIndex        =   89
      Top             =   4920
      Width           =   855
   End
   Begin VB.TextBox txtcomplementrecette 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   12000
      TabIndex        =   88
      Top             =   4080
      Width           =   855
   End
   Begin VB.TextBox txtcomplementrecette 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   12000
      TabIndex        =   87
      Top             =   3240
      Width           =   855
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Balance"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2175
      Left            =   10200
      TabIndex        =   84
      Top             =   120
      Width           =   4455
      Begin VB.CommandButton Cmdvalidpoids 
         Caption         =   "OK"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   960
         TabIndex        =   103
         Top             =   1200
         Width           =   2775
      End
      Begin VB.TextBox txtpoids 
         BackColor       =   &H00C0FFC0&
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   2040
         TabIndex        =   85
         Top             =   360
         Width           =   1335
      End
      Begin VB.Label Label9 
         BackColor       =   &H00C0C0C0&
         Caption         =   "Poids"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   1080
         TabIndex        =   86
         Top             =   480
         Width           =   855
      End
   End
   Begin VB.TextBox txtnumformule 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7440
      TabIndex        =   82
      TabStop         =   0   'False
      Top             =   840
      Width           =   1935
   End
   Begin VB.TextBox txtnbrsac 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   10200
      TabIndex        =   80
      TabStop         =   0   'False
      Top             =   8280
      Width           =   615
   End
   Begin VB.TextBox txtnbrsac 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   10200
      TabIndex        =   79
      TabStop         =   0   'False
      Top             =   7440
      Width           =   615
   End
   Begin VB.TextBox txtqteutiletotale 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   9000
      TabIndex        =   78
      TabStop         =   0   'False
      Top             =   8280
      Width           =   1095
   End
   Begin VB.TextBox txtqteutiletotale 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   9000
      TabIndex        =   77
      TabStop         =   0   'False
      Top             =   7440
      Width           =   1095
   End
   Begin VB.TextBox txtcodematpre 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   3120
      TabIndex        =   76
      TabStop         =   0   'False
      Top             =   8280
      Width           =   1335
   End
   Begin VB.TextBox txtcodematpre 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   3120
      TabIndex        =   75
      TabStop         =   0   'False
      Top             =   7440
      Width           =   1335
   End
   Begin VB.TextBox txtnomproduit 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   120
      TabIndex        =   74
      TabStop         =   0   'False
      Top             =   8280
      Width           =   2895
   End
   Begin VB.TextBox txtnomproduit 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   120
      TabIndex        =   73
      TabStop         =   0   'False
      Top             =   7440
      Width           =   2895
   End
   Begin VB.TextBox txtnbrsac 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   10200
      TabIndex        =   69
      TabStop         =   0   'False
      Top             =   6600
      Width           =   615
   End
   Begin VB.TextBox txtnbrsac 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   10200
      TabIndex        =   68
      TabStop         =   0   'False
      Top             =   5760
      Width           =   615
   End
   Begin VB.TextBox txtnbrsac 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   10200
      TabIndex        =   67
      TabStop         =   0   'False
      Top             =   4920
      Width           =   615
   End
   Begin VB.TextBox txtnbrsac 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   10200
      TabIndex        =   66
      TabStop         =   0   'False
      Top             =   4080
      Width           =   615
   End
   Begin VB.TextBox txtnbrsac 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   10200
      TabIndex        =   65
      TabStop         =   0   'False
      Text            =   "                     "
      Top             =   3240
      Width           =   615
   End
   Begin VB.TextBox text7 
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7440
      TabIndex        =   1
      Top             =   240
      Width           =   1935
   End
   Begin VB.TextBox txtnumof 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3120
      TabIndex        =   63
      TabStop         =   0   'False
      Top             =   240
      Width           =   1695
   End
   Begin VB.TextBox txtnumcouteau 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3120
      TabIndex        =   61
      TabStop         =   0   'False
      Top             =   840
      Width           =   1695
   End
   Begin VB.TextBox txtqteutiletotale 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   9000
      TabIndex        =   59
      TabStop         =   0   'False
      Top             =   6600
      Width           =   1095
   End
   Begin VB.TextBox txtqteutiletotale 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   9000
      TabIndex        =   58
      TabStop         =   0   'False
      Top             =   5760
      Width           =   1095
   End
   Begin VB.TextBox txtqteutiletotale 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   9000
      TabIndex        =   57
      TabStop         =   0   'False
      Top             =   4920
      Width           =   1095
   End
   Begin VB.TextBox txtqteutiletotale 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   9000
      TabIndex        =   56
      TabStop         =   0   'False
      Top             =   4080
      Width           =   1095
   End
   Begin VB.TextBox txtqteutiletotale 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   9000
      TabIndex        =   55
      TabStop         =   0   'False
      Top             =   3240
      Width           =   1095
   End
   Begin VB.TextBox txtcodematpre 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   3120
      TabIndex        =   54
      TabStop         =   0   'False
      Top             =   6600
      Width           =   1335
   End
   Begin VB.TextBox txtcodematpre 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   3120
      TabIndex        =   53
      TabStop         =   0   'False
      Top             =   5760
      Width           =   1335
   End
   Begin VB.TextBox txtcodematpre 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   3120
      TabIndex        =   52
      TabStop         =   0   'False
      Top             =   4920
      Width           =   1335
   End
   Begin VB.TextBox txtcodematpre 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   3120
      TabIndex        =   51
      TabStop         =   0   'False
      Top             =   4080
      Width           =   1335
   End
   Begin VB.TextBox txtcodematpre 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   3120
      TabIndex        =   50
      TabStop         =   0   'False
      Top             =   3240
      Width           =   1335
   End
   Begin VB.TextBox txtnomproduit 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   120
      TabIndex        =   49
      TabStop         =   0   'False
      Top             =   6600
      Width           =   2895
   End
   Begin VB.TextBox txtnomproduit 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   120
      TabIndex        =   48
      TabStop         =   0   'False
      Top             =   5760
      Width           =   2895
   End
   Begin VB.TextBox txtnomproduit 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   120
      TabIndex        =   47
      TabStop         =   0   'False
      Top             =   4920
      Width           =   2895
   End
   Begin VB.TextBox txtnomproduit 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   120
      TabIndex        =   46
      TabStop         =   0   'False
      Top             =   4080
      Width           =   2895
   End
   Begin VB.TextBox txtnomproduit 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   0
      TabStop         =   0   'False
      Top             =   3240
      Width           =   2895
   End
   Begin VB.Label Label15 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Numero du produit :"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   0
      TabIndex        =   106
      Top             =   1560
      Width           =   2775
   End
   Begin VB.Label Label14 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Lot N°2"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   7680
      TabIndex        =   105
      Top             =   2520
      Width           =   735
   End
   Begin VB.Label Label13 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Lot N°1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   6240
      TabIndex        =   104
      Top             =   2520
      Width           =   735
   End
   Begin VB.Label Label12 
      Caption         =   "Label12"
      Height          =   375
      Left            =   1200
      TabIndex        =   101
      Top             =   10080
      Visible         =   0   'False
      Width           =   975
   End
   Begin VB.Label Label6 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Code Mat pre Recette"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3120
      TabIndex        =   99
      Top             =   2520
      Width           =   1335
   End
   Begin VB.Label Label11 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Code Mat pre SCAN"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4560
      TabIndex        =   98
      Top             =   2520
      Width           =   1335
   End
   Begin VB.Label ALERTE 
      BackColor       =   &H000000FF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "IL Y A TROP DE SACS DANS LA MACHINE"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   24
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1200
      TabIndex        =   97
      Top             =   9120
      Visible         =   0   'False
      Width           =   10215
   End
   Begin VB.Shape Shape1 
      FillColor       =   &H00FFC0C0&
      FillStyle       =   0  'Solid
      Height          =   615
      Left            =   0
      Top             =   3120
      Width           =   14055
   End
   Begin VB.Label Label27 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Complement Ajouté (Kg)"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   13200
      TabIndex        =   96
      Top             =   2520
      Width           =   1215
   End
   Begin VB.Label Label20 
      Caption         =   "Kg"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   0
      Left            =   12480
      TabIndex        =   95
      Top             =   3360
      Width           =   255
   End
   Begin VB.Label Label19 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Complément Recette (Kg)"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   12000
      TabIndex        =   94
      Top             =   2520
      Width           =   1215
   End
   Begin VB.Label Label10 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Nbr SAC Comptés"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   11040
      TabIndex        =   83
      Top             =   2520
      Width           =   975
   End
   Begin VB.Label Label8 
      BackColor       =   &H00C0C0C0&
      Caption         =   "FORMULE"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5280
      TabIndex        =   81
      Top             =   840
      Width           =   1815
   End
   Begin VB.Label Label7 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Qté utile Totale (Kg)"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   9000
      TabIndex        =   72
      Top             =   2520
      Width           =   1095
   End
   Begin VB.Label Label5 
      BackColor       =   &H00C0C0C0&
      Caption         =   "NOM PRODUIT"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   840
      TabIndex        =   71
      Top             =   2520
      Width           =   1815
   End
   Begin VB.Label Label4 
      BackColor       =   &H00C0C0C0&
      Caption         =   "NBr SAC Recette"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   10080
      TabIndex        =   70
      Top             =   2520
      Width           =   1095
   End
   Begin VB.Label Label3 
      BackColor       =   &H00C0C0C0&
      Caption         =   "OPERATEUR:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5280
      TabIndex        =   64
      Top             =   240
      Width           =   1935
   End
   Begin VB.Label Label2 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Numero d'ID :"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   62
      Top             =   240
      Width           =   2775
   End
   Begin VB.Label Label1 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Numero de couteau :"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   60
      Top             =   840
      Width           =   2775
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public valcompteur, etagesac, nbrproduit As Integer
Public compteurtrou, compteursac As Integer
Public choixpaletteauto, validcode As Boolean
Public txtcodematscantronc, nomproduit As String
Public tolcomp1 As Boolean
Public tolerance As Single
Public tolerancetotale As Single
Public tolmaxp1 As Single
Public tolminp1 As Single
Public coloris As String
Public numof As String
Public nbr_prepa As Integer

'Public ucondit(7) As Integer
'Public qtemesuree(7) As Single

Private Sub Command10_Click()
Dim rs2 As New ADODB.Recordset
rs2.CursorLocation = adUseClient
rs2.Open "select * from oftermine", "FILE NAME=c:\desensacheuse.udl", adOpenDynamic, adLockOptimistic
rs2.AddNew
rs2.Fields("NOOF") = Text6.Text

Me.Hide
Dialog.Show
Dialog.Text1 = ""
'dialog1.SetFocus
End Sub

Private Sub Command11_Click()
Form2.Show
End Sub



Private Sub cmdproduit2_Click()
etagesac = 2
End Sub


Private Sub cmdproduit3_Click()
etagesac = 3
End Sub

Private Sub cmdproduit4_Click()
etagesac = 4
End Sub

Private Sub cmdproduit5_Click()
etagesac = 5
End Sub

Private Sub cmdproduit6_Click()
etagesac = 6
End Sub



Private Sub CmdFormule_terminee_Click()
'On Error GoTo securite
Dim rsaccess As New ADODB.Recordset
'Dim cnn1 As New ADODB.Connection

rsaccess.CursorLocation = adUseServer
'cnn1.Open "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\desensacheuse.mdb;Persist Security Info=False"
'Set rsaccess = cnn1.Execute("select * from table1")
rsaccess.Open "select * from table1", "FILE NAME=C:\access_desensacheuse1.udl", adOpenDynamic, adLockOptimistic

rsaccess.AddNew
rsaccess.Fields("date").Value = Date
rsaccess.Fields("heure").Value = Time

rsaccess.Fields("id").Value = txtnumof
rsaccess.Fields("coloris").Value = coloris
'rsaccess.Fields("article").Value = article
rsaccess.Fields("of").Value = numof


rsaccess.Fields("numcouteau").Value = txtnumcouteau
rsaccess.Fields("formule").Value = txtnumformule
rsaccess.Fields("operateur").Value = text7
rsaccess.Fields("nom_p1").Value = txtnomproduit(0)
rsaccess.Fields("nom_p2").Value = txtnomproduit(1)
rsaccess.Fields("nom_p3").Value = txtnomproduit(2)
rsaccess.Fields("nom_p4").Value = txtnomproduit(3)
rsaccess.Fields("nom_p5").Value = txtnomproduit(4)
rsaccess.Fields("nom_p6").Value = txtnomproduit(5)
rsaccess.Fields("nom_p7").Value = txtnomproduit(6)
rsaccess.Fields("codematpre_p1").Value = txtcodematpre(0)
rsaccess.Fields("codematpre_p2").Value = txtcodematpre(1)
rsaccess.Fields("codematpre_p3").Value = txtcodematpre(2)
rsaccess.Fields("codematpre_p4").Value = txtcodematpre(3)
rsaccess.Fields("codematpre_p5").Value = txtcodematpre(4)
rsaccess.Fields("codematpre_p6").Value = txtcodematpre(5)
rsaccess.Fields("codematpre_p7").Value = txtcodematpre(6)
rsaccess.Fields("qtetotale_recette_p1").Value = txtqteutiletotale(0)
rsaccess.Fields("qtetotale_recette_p2").Value = txtqteutiletotale(1)
rsaccess.Fields("qtetotale_recette_p3").Value = txtqteutiletotale(2)
rsaccess.Fields("qtetotale_recette_p4").Value = txtqteutiletotale(3)
rsaccess.Fields("qtetotale_recette_p5").Value = txtqteutiletotale(4)
rsaccess.Fields("qtetotale_recette_p6").Value = txtqteutiletotale(5)
rsaccess.Fields("qtetotale_recette_p7").Value = txtqteutiletotale(6)
rsaccess.Fields("Nbr_sacs_recette_p1").Value = txtnbrsac(0)
rsaccess.Fields("Nbr_sacs_recette_p2").Value = txtnbrsac(1)
rsaccess.Fields("Nbr_sacs_recette_p3").Value = txtnbrsac(2)
rsaccess.Fields("Nbr_sacs_recette_p4").Value = txtnbrsac(3)
rsaccess.Fields("Nbr_sacs_recette_p5").Value = txtnbrsac(4)
rsaccess.Fields("Nbr_sacs_recette_p6").Value = txtnbrsac(5)
rsaccess.Fields("Nbr_sacs_recette_p7").Value = txtnbrsac(6)
rsaccess.Fields("Nbr_sacs_comptes_p1").Value = txtnbrsacpose(0)
rsaccess.Fields("Nbr_sacs_comptes_p2").Value = txtnbrsacpose(1)
rsaccess.Fields("Nbr_sacs_comptes_p3").Value = txtnbrsacpose(2)
rsaccess.Fields("Nbr_sacs_comptes_p4").Value = txtnbrsacpose(3)
rsaccess.Fields("Nbr_sacs_comptes_p5").Value = txtnbrsacpose(4)
rsaccess.Fields("Nbr_sacs_comptes_p6").Value = txtnbrsacpose(5)
rsaccess.Fields("Nbr_sacs_comptes_p7").Value = txtnbrsacpose(6)
rsaccess.Fields("complement_recette_p1").Value = txtcomplementrecette(0)
rsaccess.Fields("complement_recette_p2").Value = txtcomplementrecette(1)
rsaccess.Fields("complement_recette_p3").Value = txtcomplementrecette(2)
rsaccess.Fields("complement_recette_p4").Value = txtcomplementrecette(3)
rsaccess.Fields("complement_recette_p5").Value = txtcomplementrecette(4)
rsaccess.Fields("complement_recette_p6").Value = txtcomplementrecette(5)
rsaccess.Fields("complement_recette_p7").Value = txtcomplementrecette(6)
rsaccess.Fields("complement_mesure_p1").Value = txtcomplementbalance(0)
rsaccess.Fields("complement_mesure_p2").Value = txtcomplementbalance(1)
rsaccess.Fields("complement_mesure_p3").Value = txtcomplementbalance(2)
rsaccess.Fields("complement_mesure_p4").Value = txtcomplementbalance(3)
rsaccess.Fields("complement_mesure_p5").Value = txtcomplementbalance(4)
rsaccess.Fields("complement_mesure_p6").Value = txtcomplementbalance(5)
rsaccess.Fields("complement_mesure_p7").Value = txtcomplementbalance(6)
rsaccess.Fields("lot1_p1").Value = txtlot1(0)
rsaccess.Fields("lot1_p2").Value = txtlot1(1)
rsaccess.Fields("lot1_p3").Value = txtlot1(2)
rsaccess.Fields("lot1_p4").Value = txtlot1(3)
rsaccess.Fields("lot1_p5").Value = txtlot1(4)
rsaccess.Fields("lot1_p6").Value = txtlot1(5)
rsaccess.Fields("lot1_p7").Value = txtlot1(6)
rsaccess.Fields("lot2_p1").Value = txtlot2(0)
rsaccess.Fields("lot2_p2").Value = txtlot2(1)
rsaccess.Fields("lot2_p3").Value = txtlot2(2)
rsaccess.Fields("lot2_p4").Value = txtlot2(3)
rsaccess.Fields("lot2_p5").Value = txtlot2(4)
rsaccess.Fields("lot2_p6").Value = txtlot2(5)
rsaccess.Fields("lot2_p7").Value = txtlot2(6)


If choixmode.choixpalette = True Then
    rsaccess.Fields("mode").Value = "Palette"
Else: rsaccess.Fields("mode").Value = "desensacheuse"

End If
choixmode.choixpalette = False
rsaccess.Update
Me.Hide
Dialog.Show

End Sub

Private Sub cmdmode_Click()
If choixmode.mode = True Then
    choixmode.mode = False
    cmdmode.Caption = "Palette"
    choixmode.choixpalette = True
Else
    choixmode.mode = True
    cmdmode.Caption = "Desensacheue"
End If


End Sub

Private Sub cmdproduit1_Click(Index As Integer)
Select Case Index

Case 0
etagesac = 1
txtcomplementbalance_Change 1
Shape1.FillColor = Val("&H00FFC0C0&")
'txtcomplementbalance(Index).Text = txtpoids.Text
'If txtnbrsacpose(0) > txtnbrsac(0) Then
'MsgBox "Il y a trop de sac..."
'End If

Shape1.Top = 3960
cmdproduit1(etagesac - 1).Enabled = False
choixpaletteauto = False
'Desactivation de la ligne precedente
txtnomproduit(etagesac - 1).Enabled = False
txtcodematpre(etagesac - 1).Enabled = False
txtqteutiletotale(etagesac - 1).Enabled = False
txtnbrsac(etagesac - 1).Enabled = False
txtnbrsacpose(etagesac - 1).Enabled = False
txtcomplementrecette(etagesac - 1).Enabled = False
txtcomplementbalance(etagesac - 1).Enabled = False
txtcodematscan(etagesac - 1).Enabled = False
txtlot1(etagesac - 1).Enabled = False
txtlot2(etagesac - 1).Enabled = False

'activation de la ligne suivante
txtnomproduit(etagesac).Enabled = True
txtcodematpre(etagesac).Enabled = True
txtqteutiletotale(etagesac).Enabled = True
txtnbrsac(etagesac).Enabled = True
txtnbrsacpose(etagesac).Enabled = True
txtcomplementrecette(etagesac).Enabled = True
txtcomplementbalance(etagesac).Enabled = True
txtcodematscan(etagesac).Enabled = True
txtlot1(etagesac).Enabled = True
txtlot2(etagesac).Enabled = True
txtcodematscan(etagesac).SetFocus



Case 1
etagesac = 2
txtcomplementbalance_Change 2
Shape1.FillColor = Val("&H00FFC0C0&")
Shape1.Top = 4800
'txtcomplementbalance(Index).Text = txtpoids.Text
cmdproduit1(etagesac - 1).Enabled = False
choixpaletteauto = False
'Desactivation de la ligne precedente
txtnomproduit(etagesac - 1).Enabled = False
txtcodematpre(etagesac - 1).Enabled = False
txtqteutiletotale(etagesac - 1).Enabled = False
txtnbrsac(etagesac - 1).Enabled = False
txtnbrsacpose(etagesac - 1).Enabled = False
txtcomplementrecette(etagesac - 1).Enabled = False
txtcomplementbalance(etagesac - 1).Enabled = False
txtcodematscan(etagesac - 1).Enabled = False
txtlot1(etagesac - 1).Enabled = False
txtlot2(etagesac - 1).Enabled = False

'activation de la ligne suivante
txtnomproduit(etagesac).Enabled = True
txtcodematpre(etagesac).Enabled = True
txtqteutiletotale(etagesac).Enabled = True
txtnbrsac(etagesac).Enabled = True
txtnbrsacpose(etagesac).Enabled = True
txtcomplementrecette(etagesac).Enabled = True
txtcomplementbalance(etagesac).Enabled = True
txtcodematscan(etagesac).Enabled = True
txtlot1(etagesac).Enabled = True
txtlot2(etagesac).Enabled = True
txtcodematscan(etagesac).SetFocus



Case 2
etagesac = 3
txtcomplementbalance_Change 3
Shape1.FillColor = Val("&H00FFC0C0&")
Shape1.Top = 5690
'txtcomplementbalance(Index).Text = txtpoids.Text
cmdproduit1(etagesac - 1).Enabled = False
choixpaletteauto = False
'Desactivation de la ligne precedente
txtnomproduit(etagesac - 1).Enabled = False
txtcodematpre(etagesac - 1).Enabled = False
txtqteutiletotale(etagesac - 1).Enabled = False
txtnbrsac(etagesac - 1).Enabled = False
txtnbrsacpose(etagesac - 1).Enabled = False
txtcomplementrecette(etagesac - 1).Enabled = False
txtcomplementbalance(etagesac - 1).Enabled = False
txtcodematscan(etagesac - 1).Enabled = False
txtlot1(etagesac - 1).Enabled = False
txtlot2(etagesac - 1).Enabled = False

'activation de la ligne suivante
txtnomproduit(etagesac).Enabled = True
txtcodematpre(etagesac).Enabled = True
txtqteutiletotale(etagesac).Enabled = True
txtnbrsac(etagesac).Enabled = True
txtnbrsacpose(etagesac).Enabled = True
txtcomplementrecette(etagesac).Enabled = True
txtcomplementbalance(etagesac).Enabled = True
txtcodematscan(etagesac).Enabled = True
txtlot1(etagesac).Enabled = True
txtlot2(etagesac).Enabled = True
txtcodematscan(etagesac).SetFocus



Case 3
etagesac = 4
txtcomplementbalance_Change 4
Shape1.FillColor = Val("&H00FFC0C0&")
Shape1.Top = 6480
'txtcomplementbalance(Index).Text = txtpoids.Text
cmdproduit1(etagesac - 1).Enabled = False
choixpaletteauto = False
'Desactivation de la ligne precedente
txtnomproduit(etagesac - 1).Enabled = False
txtcodematpre(etagesac - 1).Enabled = False
txtqteutiletotale(etagesac - 1).Enabled = False
txtnbrsac(etagesac - 1).Enabled = False
txtnbrsacpose(etagesac - 1).Enabled = False
txtcomplementrecette(etagesac - 1).Enabled = False
txtcomplementbalance(etagesac - 1).Enabled = False
txtcodematscan(etagesac - 1).Enabled = False
txtlot1(etagesac - 1).Enabled = False
txtlot2(etagesac - 1).Enabled = False

'activation de la ligne suivante
txtnomproduit(etagesac).Enabled = True
txtcodematpre(etagesac).Enabled = True
txtqteutiletotale(etagesac).Enabled = True
txtnbrsac(etagesac).Enabled = True
txtnbrsacpose(etagesac).Enabled = True
txtcomplementrecette(etagesac).Enabled = True
txtcomplementbalance(etagesac).Enabled = True
txtcodematscan(etagesac).Enabled = True
txtlot1(etagesac).Enabled = True
txtlot2(etagesac).Enabled = True
txtcodematscan(etagesac).SetFocus



Case 4
etagesac = 5
txtcomplementbalance_Change 5
Shape1.FillColor = Val("&H00FFC0C0&")
Shape1.Top = 7320
'txtcomplementbalance(Index).Text = txtpoids.Text
cmdproduit1(etagesac - 1).Enabled = False
choixpaletteauto = False
'Desactivation de la ligne precedente
txtnomproduit(etagesac - 1).Enabled = False
txtcodematpre(etagesac - 1).Enabled = False
txtqteutiletotale(etagesac - 1).Enabled = False
txtnbrsac(etagesac - 1).Enabled = False
txtnbrsacpose(etagesac - 1).Enabled = False
txtcomplementrecette(etagesac - 1).Enabled = False
txtcomplementbalance(etagesac - 1).Enabled = False
txtcodematscan(etagesac - 1).Enabled = False
txtlot1(etagesac - 1).Enabled = False
txtlot2(etagesac - 1).Enabled = False

'activation de la ligne suivante
txtnomproduit(etagesac).Enabled = True
txtcodematpre(etagesac).Enabled = True
txtqteutiletotale(etagesac).Enabled = True
txtnbrsac(etagesac).Enabled = True
txtnbrsacpose(etagesac).Enabled = True
txtcomplementrecette(etagesac).Enabled = True
txtcomplementbalance(etagesac).Enabled = True
txtcodematscan(etagesac).Enabled = True
txtlot1(etagesac).Enabled = True
txtlot2(etagesac).Enabled = True
txtcodematscan(etagesac).SetFocus


Case 5
etagesac = 6
txtcomplementbalance_Change 6
Shape1.FillColor = Val("&H00FFC0C0&")

Shape1.Top = 8160
'txtcomplementbalance(Index).Text = txtpoids.Text
cmdproduit1(etagesac - 1).Enabled = False
choixpaletteauto = False
'Desactivation de la ligne precedente
txtnomproduit(etagesac - 1).Enabled = False
txtcodematpre(etagesac - 1).Enabled = False
txtqteutiletotale(etagesac - 1).Enabled = False
txtnbrsac(etagesac - 1).Enabled = False
txtnbrsacpose(etagesac - 1).Enabled = False
txtcomplementrecette(etagesac - 1).Enabled = False
txtcomplementbalance(etagesac - 1).Enabled = False
txtcodematscan(etagesac - 1).Enabled = False
txtlot1(etagesac - 1).Enabled = False
txtlot2(etagesac - 1).Enabled = False

'activation de la ligne suivante
txtnomproduit(etagesac).Enabled = True
txtcodematpre(etagesac).Enabled = True
txtqteutiletotale(etagesac).Enabled = True
txtnbrsac(etagesac).Enabled = True
txtnbrsacpose(etagesac).Enabled = True
txtcomplementrecette(etagesac).Enabled = True
txtcomplementbalance(etagesac).Enabled = True
txtcodematscan(etagesac).Enabled = True
txtlot1(etagesac).Enabled = True
txtlot2(etagesac).Enabled = True
txtcodematscan(etagesac).SetFocus

Case 6
etagesac = 7
txtcomplementbalance_Change 7
Shape1.FillColor = Val("&H00FFC0C0&")

Shape1.Top = 9000
'txtcomplementbalance(Index).Text = txtpoids.Text
cmdproduit1(etagesac - 1).Enabled = False
choixpaletteauto = False
'Desactivation de la ligne precedente
txtnomproduit(etagesac - 1).Enabled = False
txtcodematpre(etagesac - 1).Enabled = False
txtqteutiletotale(etagesac - 1).Enabled = False
txtnbrsac(etagesac - 1).Enabled = False
txtnbrsacpose(etagesac - 1).Enabled = False
txtcomplementrecette(etagesac - 1).Enabled = False
txtcomplementbalance(etagesac - 1).Enabled = False
txtcodematscan(etagesac - 1).Enabled = False
txtlot1(etagesac - 1).Enabled = False
txtlot2(etagesac - 1).Enabled = False

'activation de la ligne suivante
txtnomproduit(etagesac).Enabled = True
txtcodematpre(etagesac).Enabled = True
txtqteutiletotale(etagesac).Enabled = True
txtnbrsac(etagesac).Enabled = True
txtnbrsacpose(etagesac).Enabled = True
txtcomplementrecette(etagesac).Enabled = True
txtcomplementbalance(etagesac).Enabled = True
txtcodematscan(etagesac).Enabled = True
txtlot1(etagesac).Enabled = True
txtlot2(etagesac).Enabled = True
txtcodematscan(etagesac).SetFocus


End Select

'On reinitialise les compte des sacs pour la prochaine operation

compteurtrou = 0
compteursac = 0



End Sub



Private Sub cmdtare_Click()
Timer3.Enabled = False
If MSComm1.PortOpen = True Then MSComm1.PortOpen = False
    
Dim Instring As String
    MSComm1.CommPort = 1
    MSComm1.Settings = "9600,N,8,1"
    MSComm1.InputLen = 0
    MSComm1.PortOpen = True
    MSComm1.Output = Chr$(2) + Chr$(84) + Chr$(3)
    'Do
    '    DoEvents
    'Loop Until MSComm1.InBufferCount >= 24
    'Instring = MSComm1.Input
    'MsgBox Instring
    
    MSComm1.PortOpen = False
    Timer3.Enabled = True
End Sub

Private Sub Cmdvalidpoids_Click()
txtcomplementbalance(etagesac) = txtpoids
End Sub

Private Sub Command1_Click()
reponse = MsgBox("Etes vous sure de vouloir annuler la formule?", vbYesNo, Certitude)
If reponse = vbYes Then
Shape1.FillColor = Val("&H00FFC0C0&")
choixpaletteauto = False
txtcomplementbalance(Index).Locked = True

    Dialog.Show
    Me.Hide
End If
End Sub

Private Sub Command2_Click()
valcompteur = valcompteur + 1
intnbrsacpose = Val(txtnbrsacpose(etagesac).Text)
intnbrsacpose = intnbrsacpose + 1
txtnbrsacpose(etagesac).Text = intnbrsacpose
If Val(txtnbrsacpose(etagesac).Text) > Val(txtnbrsac(etagesac).Text) Then
'MsgBox "Vous avez déposé trop de sac sur le tapis"
ALERTE.Visible = True
'Label1.LinkMode = 1
End If
End Sub



'Private Sub Command3_Click()
'Dim o As Outlook.Application
'
'    Set o = New Outlook.Application
'
'    Dim mail As Outlook.MailItem
'
'    Set mail = o.CreateItem(olMailItem)
'
'    With mail
'        .Subject = "Rapport desensacheuse"
'        .To = "gaetan.dizazzo@griffine.com"
'        .Body = "Rapport journalier de la desensacheuse"
'        .Attachments.Add "c:\desensacheuse.mdb"
'        .Send
'    End With
'
'    Set mi = Nothing
'    Set o = Nothing
'
'End Sub

Private Sub Form_Activate()

nbr_prepa = nbr_prepa + 1

'nbr_prepa = 45
If nbr_prepa >= 8 Then
'Me.Visible = False
Form2.Show 1
'Me.Visible = True
nbr_prepa = 0
End If





etagesac = 0
Form1.WindowState = 2
'choixmode.mode = True
text7.SetFocus
ALERTE.Visible = False
'MaskEdBox1.Text = "13:55:00"
Textbox1.Text = "13:55:00"
'txtnumcouteau.Text = Dialog.numcouteau
txtnumof.Text = Dialog.numof
Shape1.Top = 3120
Shape1.FillColor = Val("&H00FFC0C0&")
Dim rs As New ADODB.Recordset
'rs.CursorLocation = adUseClient

Dim noof, formule, couteau As String
validcode = False
text7.Text = ""
For i = 0 To 6
    txtnomproduit(i).Text = ""
    'Txt(i).Text = ""
    txtcodematpre(i).Text = ""
    txtqteutiletotale(i).Text = ""
    txtnbrsac(i).Text = ""
    txtnbrsacpose(i).Text = "0"
    txtcomplementrecette(i).Text = 0
    txtcomplementbalance(i).Text = 0
    txtcodematscan(i).Text = ""
    txtlot1(i).Text = ""
    txtlot2(i).Text = ""
    
Next i


txtnomproduit(0).Enabled = True
txtcodematpre(0).Enabled = True
txtqteutiletotale(0).Enabled = True
txtnbrsac(0).Enabled = True
txtnbrsacpose(0).Enabled = True
txtcomplementrecette(0).Enabled = True
txtcomplementbalance(0).Enabled = True
txtcodematscan(0).Enabled = True
txtlot1(0).Enabled = True
txtlot2(0).Enabled = True






For i = 1 To 6
    txtnomproduit(i).Enabled = False
    txtcodematpre(i).Enabled = False
    txtqteutiletotale(i).Enabled = False
    txtnbrsac(i).Enabled = False
    txtnbrsacpose(i).Enabled = False
    txtcomplementrecette(i).Enabled = False
    txtcomplementbalance(i).Enabled = False
    txtcodematscan(i).Enabled = False
    txtlot1(i).Enabled = False
    txtlot2(i).Enabled = False
    
Next i

If choixmode.choixpalette = False Then
    For i = 0 To 6
    txtcomplementbalance(i).Locked = True
    Next i
'ElseIf choixmode.choixpalette = True Then
Else
    For i = 0 To 6
    txtcomplementbalance(i).Locked = False
   Next i
End If

validcode = True
    
noof = txtnumof.Text
couteau = txtnumcouteau.Text

'Requette Avant modif pour QAD
'rs.Open "SELECT pt_desc1, pt_desc2,mstr.zzsv_couteau, mstr.zzsv_nbr,mstr.zzsv_coloris, mstr.zzsv_lot, mstr.zzsv_part, mstr.zzsv_qte_of, mstr.zzsv_qte_pet, det.zzsvd_part, det.zzsvd_qte_of, det.zzsvd_qte_pet , det.zzsvd_poidemb, det.zzsvd_type From coudb.PUB.zzsvd_det as det, coudb.PUB.zzsv_mstr as mstr,pub.pt_mstr WHERE pt_part = det.zzsvd_part AND det.zzsvd_lot = mstr.zzsv_lot AND (mstr.zzsv_lot =" & "'" & Dialog.chaine1 & "'" & ") AND (det.zzsvd_type = 'pou')", "FILE NAME=c:\connexion.udl"
'rs.Open "select * from griffine_supervision WHERE (id =" & "'" & Dialog.chaine1 & "'" & ") AND (typeformule='SF_PATES') AND ((typecode_mat ='CH')  OR (typecode_mat = 'CL')),FILE NAME=c:\connexion.udl"



Dim cmd As New ADODB.Command
Dim cnn As New ADODB.Connection

Set cnn = New ADODB.Connection
sconnstring = "DRIVER={Postgresql unicode};DATABASE=aquiweb;server=192.168.60.1;UID=griffine_beca;PWD=griffine_beca"
cnn.Open sconnstring


Dim strsql As String
'strsql = " select * from griffine_supervision WHERE (id =" & "'" & Dialog.chaine1 & "'" & ") AND (typeformule='SF_PATES') AND ((numero_op1 BETWEEN '17000' AND '17099') OR (numero_op1 BETWEEN '170000' AND '170999'))  ORDER BY numero_op2 " ' AND ((typecode_mat ='CH')  OR (typecode_mat = 'CL'))"
strsql = " select * from griffine_supervision WHERE (id =" & "'" & Dialog.chaine1 & "'" & ") AND (typeformule='SF_PATES') AND  (numero_op1='170')  ORDER BY numero_op2 " ' AND ((typecode_mat ='CH')  OR (typecode_mat = 'CL'))"


cmd.ActiveConnection = cnn
cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
cmd.CommandText = strsql

Set rs = New ADODB.Recordset
'rs.CursorType = adOpenStatic
'rs.LockType = adLockOptimistic

'Set rs = cmd.Execute
rs.Open strsql, cnn, adOpenStatic
'MsgBox (rs.RecordCount)



'Text9.Text = rs!formule
nbrproduit = rs.RecordCount
'txtnumcouteau.Text = rs!zzsv_couteau
coloris = rs!coloris 'zzsv_coloris
'article = rs!zzsv_pt_desc1 '& rs!zzsv_pt_desc2

numof = rs!of 'zzsv_nbr

If rs.RecordCount = 0 Then
    GoTo erreur
End If

i = 0

   For i = 0 To rs.RecordCount
    
        If rs.EOF = True Or rs.BOF = True Then
            GoTo fin
        End If
        
        
        txtnumformule.Text = rs!formule
        nbr_petrin = Int(Round((rs!qtt / rs!poidsnetformule) + 0.5))
        qte_petrin = rs!qte_recette / nbr_petrin
        
'Remplissage des champs en fonction de la requette...
        'ucondit(i) = rs!ucondit
        If Dialog1.doublage = False Then
        
            
            
            
            
            
            
            txtnumformule.Text = rs!formule 'zzsv_part
            
            
            'MODIF A FAIRE
            nbrsac = qte_petrin / rs!poidsbrutcode_mat
            
            If Not IsNull(rs!poidsbrutcode_mat) Then
            entiere = Int(nbrsac)
            Else: entiere = 0
            End If
            
            decimale = nbrsac - entiere
            
            'MODIF A FAIRE
            
            If Not IsNull(rs!poidsbrutcode_mat) Then
            
            complement = (decimale * rs!poidsbrutcode_mat) '/ 100
           Else
            complement = 0
           End If
            
        
          'text1(i).Text = rs!formule
            txtnomproduit(i).Text = rs!produit
            txtcodematpre(i).Text = rs!code_mat
            
            'MODIF A FAIRE
            txtqteutiletotale(i).Text = Round(qte_petrin, 1)
            txtcomplementrecette(i).Text = Round(complement, 1)
            txtnbrsac(i).Text = entiere
            
        ElseIf Dialog1.doublage = True Then
        
            
            nbrsac = (qte_petrin * 2) / rs!poidsbrutcode_mat
            entiere = Int(nbrsac)
            decimale = nbrsac - entiere
            complement = (decimale * rs!poidsbrutcode_mat) '/ 100)
        
          'text1(i).Text = rs!formule
            txtnomproduit(i).Text = rs!produit
            txtcodematpre(i).Text = rs!code_mat
            txtqteutiletotale(i).Text = Round((qte_petrin * 2), 1) '/ 100) * 2
            txtcomplementrecette(i).Text = Round(complement, 1)
            txtnbrsac(i).Text = entiere
        End If
 
        
        
'pour afficher uniquement les lignes concernées en fonction de la requette
        txtnomproduit(i).Visible = True
        txtcodematpre(i).Visible = True
        txtcodematscan(i).Visible = True
        txtqteutiletotale(i).Visible = True
        txtnbrsac(i).Visible = True
        txtcomplementrecette(i).Visible = True
        txtcomplementbalance(i).Visible = True
        cmdproduit1(i).Visible = True
        txtnbrsacpose(i).Visible = True
        'Label20(i).Visible = True
        rs.MoveNext
   Next i
  
rs.Close

'Set DataGrid1.DataSource = rs
GoTo fin
erreur:
MsgBox ("IL n'y a aucun enregistrement pour votre demande")
fin:
'Reinitialisation du compteur de sac et de trou à l'ouverture de la form
compteurtrou = 0
compteursac = 0
CmdFormule_terminee = False

End Sub
''''''''Private Sub Form_Activate()
''''''''
''''''''nbr_prepa = nbr_prepa + 1
''''''''
'''''''''nbr_prepa = 45
''''''''If nbr_prepa >= 8 Then
'''''''''Me.Visible = False
''''''''Form2.Show 1
'''''''''Me.Visible = True
''''''''nbr_prepa = 0
''''''''End If
''''''''
''''''''
''''''''
''''''''
''''''''
''''''''etagesac = 0
''''''''Form1.WindowState = 2
'''''''''choixmode.mode = True
''''''''text7.SetFocus
''''''''ALERTE.Visible = False
'''''''''MaskEdBox1.Text = "13:55:00"
''''''''Textbox1.Text = "13:55:00"
'''''''''txtnumcouteau.Text = Dialog.numcouteau
''''''''txtnumof.Text = Dialog.numof
''''''''Shape1.Top = 3120
''''''''Shape1.FillColor = Val("&H00FFC0C0&")
''''''''Dim rs As New ADODB.Recordset
'''''''''rs.CursorLocation = adUseClient
''''''''
''''''''Dim noof, formule, couteau As String
''''''''validcode = False
''''''''text7.Text = ""
''''''''For i = 0 To 6
''''''''    txtnomproduit(i).Text = ""
''''''''    'Txt(i).Text = ""
''''''''    txtcodematpre(i).Text = ""
''''''''    txtqteutiletotale(i).Text = ""
''''''''    txtnbrsac(i).Text = ""
''''''''    txtnbrsacpose(i).Text = "0"
''''''''    txtcomplementrecette(i).Text = 0
''''''''    txtcomplementbalance(i).Text = 0
''''''''    txtcodematscan(i).Text = ""
''''''''    txtlot1(i).Text = ""
''''''''    txtlot2(i).Text = ""
''''''''
''''''''Next i
''''''''
''''''''
''''''''txtnomproduit(0).Enabled = True
''''''''txtcodematpre(0).Enabled = True
''''''''txtqteutiletotale(0).Enabled = True
''''''''txtnbrsac(0).Enabled = True
''''''''txtnbrsacpose(0).Enabled = True
''''''''txtcomplementrecette(0).Enabled = True
''''''''txtcomplementbalance(0).Enabled = True
''''''''txtcodematscan(0).Enabled = True
''''''''txtlot1(0).Enabled = True
''''''''txtlot2(0).Enabled = True
''''''''
''''''''
''''''''
''''''''
''''''''
''''''''
''''''''For i = 1 To 6
''''''''    txtnomproduit(i).Enabled = False
''''''''    txtcodematpre(i).Enabled = False
''''''''    txtqteutiletotale(i).Enabled = False
''''''''    txtnbrsac(i).Enabled = False
''''''''    txtnbrsacpose(i).Enabled = False
''''''''    txtcomplementrecette(i).Enabled = False
''''''''    txtcomplementbalance(i).Enabled = False
''''''''    txtcodematscan(i).Enabled = False
''''''''    txtlot1(i).Enabled = False
''''''''    txtlot2(i).Enabled = False
''''''''
''''''''Next i
''''''''
''''''''If choixmode.choixpalette = False Then
''''''''    For i = 0 To 6
''''''''    txtcomplementbalance(i).Locked = True
''''''''    Next i
'''''''''ElseIf choixmode.choixpalette = True Then
''''''''Else
''''''''    For i = 0 To 6
''''''''    txtcomplementbalance(i).Locked = False
''''''''   Next i
''''''''End If
''''''''
''''''''validcode = True
''''''''
''''''''noof = txtnumof.Text
''''''''couteau = txtnumcouteau.Text
''''''''
'''''''''Requette Avant modif pour QAD
'''''''''rs.Open "SELECT pt_desc1, pt_desc2,mstr.zzsv_couteau, mstr.zzsv_nbr,mstr.zzsv_coloris, mstr.zzsv_lot, mstr.zzsv_part, mstr.zzsv_qte_of, mstr.zzsv_qte_pet, det.zzsvd_part, det.zzsvd_qte_of, det.zzsvd_qte_pet , det.zzsvd_poidemb, det.zzsvd_type From coudb.PUB.zzsvd_det as det, coudb.PUB.zzsv_mstr as mstr,pub.pt_mstr WHERE pt_part = det.zzsvd_part AND det.zzsvd_lot = mstr.zzsv_lot AND (mstr.zzsv_lot =" & "'" & Dialog.chaine1 & "'" & ") AND (det.zzsvd_type = 'pou')", "FILE NAME=c:\connexion.udl"
'''''''''rs.Open "select * from griffine_supervision WHERE (id =" & "'" & Dialog.chaine1 & "'" & ") AND (typeformule='SF_PATES') AND ((typecode_mat ='CH')  OR (typecode_mat = 'CL')),FILE NAME=c:\connexion.udl"
''''''''
''''''''
''''''''
''''''''Dim cmd As New ADODB.Command
''''''''Dim cnn As New ADODB.Connection
''''''''
''''''''Set cnn = New ADODB.Connection
''''''''sconnstring = "DRIVER={Postgresql unicode};DATABASE=aquiweb;server=10.121.132.8;UID=griffine_beca;PWD=griffine_beca"
''''''''cnn.Open sconnstring
''''''''
''''''''
''''''''Dim strsql As String
''''''''strsql = " select * from griffine_supervision WHERE (id =" & "'" & Dialog.chaine1 & "'" & ") AND (typeformule='SF_PATES') AND (numero_op='170') " ' AND ((typecode_mat ='CH')  OR (typecode_mat = 'CL'))"
''''''''
''''''''cmd.ActiveConnection = cnn
''''''''cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
''''''''cmd.CommandText = strsql
''''''''
''''''''Set rs = New ADODB.Recordset
'''''''''rs.CursorType = adOpenStatic
'''''''''rs.LockType = adLockOptimistic
''''''''
'''''''''Set rs = cmd.Execute
''''''''rs.Open strsql, cnn, adOpenStatic
'''''''''MsgBox (rs.RecordCount)
''''''''
''''''''
''''''''
'''''''''Text9.Text = rs!formule
''''''''nbrproduit = rs.RecordCount
'''''''''txtnumcouteau.Text = rs!zzsv_couteau
''''''''coloris = rs!coloris 'zzsv_coloris
'''''''''article = rs!zzsv_pt_desc1 '& rs!zzsv_pt_desc2
''''''''
''''''''numof = rs!of 'zzsv_nbr
''''''''
''''''''If rs.RecordCount = 0 Then
''''''''    GoTo erreur
''''''''End If
''''''''
''''''''i = 0
''''''''
''''''''   For i = 0 To rs.RecordCount
''''''''
''''''''        If rs.EOF = True Or rs.BOF = True Then
''''''''            GoTo fin
''''''''        End If
''''''''
''''''''
''''''''        txtnumformule.Text = rs!formule
''''''''        nbr_petrin = Int(Round((rs!qtt / rs!poidsnetformule) + 0.5))
''''''''        qte_petrin = rs!qte_recette / nbr_petrin
''''''''
'''''''''Remplissage des champs en fonction de la requette...
''''''''        'ucondit(i) = rs!ucondit
''''''''        If Dialog1.doublage = False Then
''''''''
''''''''
''''''''
''''''''
''''''''
''''''''
''''''''
''''''''            txtnumformule.Text = rs!formule 'zzsv_part
''''''''
''''''''
''''''''            'MODIF A FAIRE
''''''''            nbrsac = qte_petrin / rs!poidsbrutcode_mat
''''''''
''''''''            If Not IsNull(rs!poidsbrutcode_mat) Then
''''''''            entiere = Int(nbrsac)
''''''''            Else: entiere = 0
''''''''            End If
''''''''
''''''''            decimale = nbrsac - entiere
''''''''
''''''''            'MODIF A FAIRE
''''''''
''''''''            If Not IsNull(rs!poidsbrutcode_mat) Then
''''''''
''''''''            complement = (decimale * rs!poidsbrutcode_mat) '/ 100
''''''''           Else
''''''''            complement = 0
''''''''           End If
''''''''
''''''''
''''''''          'text1(i).Text = rs!formule
''''''''            txtnomproduit(i).Text = rs!produit
''''''''            txtcodematpre(i).Text = rs!code_mat
''''''''
''''''''            'MODIF A FAIRE
''''''''            txtqteutiletotale(i).Text = Round(qte_petrin, 1)
''''''''            txtcomplementrecette(i).Text = Round(complement, 1)
''''''''            txtnbrsac(i).Text = entiere
''''''''
''''''''        ElseIf Dialog1.doublage = True Then
''''''''
''''''''
''''''''            nbrsac = (qte_petrin * 2) / rs!poidsbrutcode_mat
''''''''            entiere = Int(nbrsac)
''''''''            decimale = nbrsac - entiere
''''''''            complement = (decimale * rs!poidsbrutcode_mat) '/ 100)
''''''''
''''''''          'text1(i).Text = rs!formule
''''''''            txtnomproduit(i).Text = rs!produit
''''''''            txtcodematpre(i).Text = rs!code_mat
''''''''            txtqteutiletotale(i).Text = Round((qte_petrin * 2), 1) '/ 100) * 2
''''''''            txtcomplementrecette(i).Text = Round(complement, 1)
''''''''            txtnbrsac(i).Text = entiere
''''''''        End If
''''''''
''''''''
''''''''
'''''''''pour afficher uniquement les lignes concernées en fonction de la requette
''''''''        txtnomproduit(i).Visible = True
''''''''        txtcodematpre(i).Visible = True
''''''''        txtcodematscan(i).Visible = True
''''''''        txtqteutiletotale(i).Visible = True
''''''''        txtnbrsac(i).Visible = True
''''''''        txtcomplementrecette(i).Visible = True
''''''''        txtcomplementbalance(i).Visible = True
''''''''        cmdproduit1(i).Visible = True
''''''''        txtnbrsacpose(i).Visible = True
''''''''        'Label20(i).Visible = True
''''''''        rs.MoveNext
''''''''   Next i
''''''''
''''''''rs.Close
''''''''
'''''''''Set DataGrid1.DataSource = rs
''''''''GoTo fin
''''''''erreur:
''''''''MsgBox ("IL n'y a aucun enregistrement pour votre demande")
''''''''fin:
'''''''''Reinitialisation du compteur de sac et de trou à l'ouverture de la form
''''''''compteurtrou = 0
''''''''compteursac = 0
''''''''CmdFormule_terminee = False
''''''''
''''''''End Sub



Private Sub text7_KeyPress(KeyAscii As Integer)
If KeyAscii = vbKeyReturn Then
    SendKeys "{TAB}"
KeyAscii = 0
End If

End Sub

'Private Sub text7_GotFocus()
'With Screen.ActiveForm
'If (TypeOf .ActiveControl Is TextBox) Then
'    .ActiveControl.SelStart = 0
'    .ActiveControl.SelLength = Len(.ActiveControl)
'End If
'End With

'End Sub

Private Sub Timer1_Timer()
On Error Resume Next
Label12.Caption = Time$
    If Label12.Caption = Textbox1.Text Then
     'If Time$ = "16:27:0" Then
        Dim dbsTemp As DAO.Database
        Set dbsTemp = DBEngine.OpenDatabase("c:\desensacheuse.mdb")
        dbsTemp.Synchronize "\\grifdc1\disk_e\bd\préparation\Desensacheuse\Replicadesensacheuse.mdb", dbRepImpExpChanges
        dbsTemp.Close
    End If



'txtcomplementbalance(0).Text = Text11.Text



End Sub

Private Sub Timer2_Timer()

 Dim Ret As Integer, i, cdii As Integer

    DCON_X1.BaudRate = 9600   ' setting the baudrate

    DCON_X1.CheckSum = False
    DCON_X1.COMPort = 4
    DCON_X1.ModuleID = CLng("&H" + "7050")
    DCON_X1.ModuleAddress = Val("&H" + "1")
    DCON_X1.PortOpen = True                           ' Open the ComPort
    If DCON_X1.ErrorCode <> 0 Then
        Exit Sub
    End If
    Ret = DCON_X1.DigitalIn

    If Ret = 127 Then
    compteurtrou = compteurtrou + 1
    End If


    If Ret = 124 And compteurtrou >= 1 Then
      compteursac = compteursac + 1
      compteurtrou = 0
    End If



    If (txtnbrsac(etagesac) = txtnbrsacpose(etagesac)) And choixmode.mode = True Then
       DCON_X1.DigitalOut Val("&h" + "1")
    Else: DCON_X1.DigitalOut Val("&h" + "0")
    End If

    If Val(txtnbrsacpose(etagesac).Text) > Val(txtnbrsac(etagesac).Text) Then
'MsgBox "Vous avez déposé trop de sac sur le tapis"
ALERTE.Visible = True
'Label1.LinkMode = 1
End If
   If choixmode.mode = True And choixpaletteauto = False Then
   txtnbrsacpose(etagesac).Text = compteursac
   End If
End Sub




Private Sub Timer3_Timer()
tolerance = 1.5
der = 0
Dim Instring As String
On Error Resume Next
    MSComm1.CommPort = 1
    MSComm1.Settings = "9600,N,8,1"
    MSComm1.InputLen = 0
    If MSComm1.PortOpen = False Then MSComm1.PortOpen = True
    'MSComm1.Output = Chr$(2) + Chr$(83) + Chr$(3)
    toto = Timer
    Do Until MSComm1.InBufferCount >= 40
        DoEvents
        
        If MSComm1.InBufferCount = 0 And Timer > toto + 0.3 Then
          ' MsgBox ("pas de reception")
           Exit Do
            
        End If
        
    Loop
    
    'Loop Until MSComm1.InBufferCount >= 40
    Instring = MSComm1.Input
    'MsgBox (Instring)
    var1 = Mid$(Instring, 18, 1)
    var2 = Mid$(Instring, 23, 1)
    tare = Mid$(Instring, 5, 6)
    Dim poskg As Integer
    poskg = InStr(Instring, "kg")
    poids = LTrim((Mid$(Instring, poskg - 7, 7)))
txtpoids = Val(poids)
    'poids = Mid$(Instring$, 10, 6)
    
    'If Asc(var1) = 13 Then
    
    'txtpoids = Val(poids) / 1000
      
      toto = Len(Format$(txtpoids, "#0.000"))
'txtpoids = Mid$(Format$(txtpoids, "#0.000"), 1, toto - 1)

      
       
    'End If
    MSComm1.PortOpen = False
    
If validcode = True Then
On Error Resume Next
tolerancetotale = txtqteutiletotale(etagesac) * 1.5 / 100
tolmaxp1 = txtcomplementrecette(etagesac) + tolerancetotale
tolminp1 = txtcomplementrecette(etagesac) - tolerancetotale
 
    
If tolminp1 < txtcomplementbalance(etagesac) And txtcomplementbalance(etagesac) < tolmaxp1 And txtcomplementbalance(etagesac) <> "" Then
    tolcomp1 = True
Else: tolcomp1 = False
End If

'Conditions imperatives pour passage au produit suivant

If txtnbrsacpose(etagesac) = txtnbrsac(etagesac) And tolcomp1 = True Then 'And txtcodematpre(etagesac) = txtcodematscantronc Then
   cmdproduit1(etagesac).Enabled = True
Else: cmdproduit1(etagesac).Enabled = False
End If
End If
If etagesac = nbrproduit Then
    CmdFormule_terminee.Enabled = True
Else: CmdFormule_terminee.Enabled = False
End If
End Sub



Private Sub txtcodematscan_KeyPress(Index As Integer, KeyAscii As Integer)
If KeyAscii = vbKeyReturn Then
    SendKeys "{TAB}"
KeyAscii = 0
End If
End Sub

Private Sub txtcodematscan_LostFocus(Index As Integer)
Dim longchainetxtcodematscan As Integer
longchainetxtcodematscan = Len(txtcodematscan(Index)) - 1

If longchainetxtcodematscan <= 0 Then
        longchainetxtcodematscan = 1
End If
    txtcodematscantronc = Right(txtcodematscan(Index), longchainetxtcodematscan)
If txtcodematscantronc <> txtcodematpre(Index).Text Then
   txtcodematscan(Index).BackColor = Val("&H000000FF&")
   MsgBox "Ce n'est pas le bon code, Veuillez le Scanner à nouveau SVP"
   txtcodematscan(Index).Text = ""
   txtcodematscan(Index).SetFocus
Else
   txtcodematscan(Index).BackColor = Val("&H00C0FFC0&")
End If

If txtcodematpre(Index).Text = "CH/01230" Then
    choixpaletteauto = True
    Shape1.FillColor = Val("&H000000FF&")
    txtcomplementbalance(Index).Locked = False
End If

If txtcodematpre(Index).Text = "CH/01202" Then
    choixpaletteauto = True
    Shape1.FillColor = Val("&H000000FF&")
    txtcomplementbalance(Index).Locked = False
End If

If txtcodematpre(Index).Text = "CH/01205" Then
    choixpaletteauto = True
    Shape1.FillColor = Val("&H000000FF&")
    txtcomplementbalance(Index).Locked = False
End If






End Sub

Private Sub txtcomplementbalance_Change(Index As Integer)



If validcode = True Then
    
    If longchainetxtcodematscan <= 0 Then
        longchainetxtcodematscan = 1
    End If
    txtcodematscantronc = Right(txtcodematscan(Index), longchainetxtcodematscan)

    'tolmaxp1 = Val(txtcomplementrecette(Index)) + ((Val(txtcomplementrecette(Index)) * 1.5) / 100)
    'tolminp1 = Val(txtcomplementrecette(Index)) - ((Val(txtcomplementrecette(Index)) * 1.5) / 100)
    
End If
End Sub


Private Sub txtlot1_KeyPress(Index As Integer, KeyAscii As Integer)
If KeyAscii = vbKeyReturn Then
    SendKeys "{TAB}"
KeyAscii = 0
End If
End Sub



Private Sub txtlot2_KeyPress(Index As Integer, KeyAscii As Integer)
If KeyAscii = vbKeyReturn Then
    SendKeys "{TAB}"
KeyAscii = 0
End If
End Sub

