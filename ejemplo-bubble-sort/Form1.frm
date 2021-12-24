VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3825
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   6360
   LinkTopic       =   "Form1"
   ScaleHeight     =   3825
   ScaleWidth      =   6360
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Llenar datos"
      Height          =   495
      Left            =   4560
      TabIndex        =   5
      Top             =   840
      Width           =   1335
   End
   Begin VB.Frame Frame1 
      Caption         =   "Bubble sort "
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3615
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   6135
      Begin VB.CommandButton Command2 
         Caption         =   "Ordenar datos"
         Height          =   495
         Left            =   4440
         TabIndex        =   6
         Top             =   1440
         Width           =   1335
      End
      Begin VB.ListBox lstOriginal 
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   2490
         ItemData        =   "Form1.frx":0000
         Left            =   120
         List            =   "Form1.frx":0002
         TabIndex        =   2
         Top             =   720
         Width           =   1935
      End
      Begin VB.ListBox lstSorted 
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   2490
         ItemData        =   "Form1.frx":0004
         Left            =   2160
         List            =   "Form1.frx":0006
         TabIndex        =   1
         Top             =   720
         Width           =   1935
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Valores"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Left            =   240
         TabIndex        =   4
         Top             =   360
         Width           =   705
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         Caption         =   "Valores ordenados"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Left            =   2160
         TabIndex        =   3
         Top             =   360
         Width           =   1740
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Option Base 1
Dim Listadatos(10) As Long

Private Sub Command1_Click()
    
    Dim x As Long
    
    Call Randomize
    Call lstOriginal.Clear
    Erase Listadatos
    
    For x = LBound(Listadatos) To UBound(Listadatos)
        Listadatos(x) = 1 + Int(100 * Rnd())
        Call lstOriginal.AddItem(Listadatos(x))
    Next x
    
    Call lstSorted.Clear
    
End Sub

Private Sub Command2_Click()
    
    Dim x As Long
    Call lstSorted.Clear
    Call BubbleSort(Listadatos)
    
    For x = 1 To UBound(Listadatos)
        Call lstSorted.AddItem(Listadatos(x))
    Next x
    
End Sub

Public Sub BubbleSort(Lista() As Long)
    Dim p As Long
    Dim c As Long
    Dim h As Long
    
    For p = 1 To (UBound(Lista) - 1)
        For c = 1 To (UBound(Lista) - 1)
            If Lista(c) > Lista(c + 1) Then
                h = Lista(c)
                Lista(c) = Lista(c + 1)
                Lista(c + 1) = h
            End If
        Next c
    Next p
End Sub

