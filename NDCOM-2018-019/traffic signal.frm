VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H00800000&
   Caption         =   "Traffic Signal"
   ClientHeight    =   5130
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   8355
   FillColor       =   &H00FFFF80&
   FillStyle       =   0  'Solid
   ForeColor       =   &H00FFFF80&
   LinkTopic       =   "Form1"
   ScaleHeight     =   5130
   ScaleWidth      =   8355
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Interval        =   3
      Left            =   600
      Top             =   2160
   End
   Begin VB.Shape Shape3 
      BackColor       =   &H0000FF00&
      BorderColor     =   &H0000FF00&
      FillColor       =   &H0000FF00&
      FillStyle       =   0  'Solid
      Height          =   615
      Left            =   5040
      Shape           =   3  'Circle
      Top             =   600
      Width           =   735
   End
   Begin VB.Shape Shape2 
      BackColor       =   &H0000FFFF&
      BorderColor     =   &H0000FFFF&
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   615
      Left            =   2760
      Shape           =   3  'Circle
      Top             =   600
      Width           =   735
   End
   Begin VB.Shape Shape1 
      BackColor       =   &H000000FF&
      BorderColor     =   &H000000FF&
      FillColor       =   &H000000FF&
      FillStyle       =   0  'Solid
      Height          =   615
      Left            =   600
      Shape           =   3  'Circle
      Top             =   600
      Width           =   735
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Timer1_Timer()
If Shape1.Visible = True Then
Shape1.Visible = False
Shape2.Visible = True
Shape3.Visible = False
Exit Sub
End If

If Shape2.Visible = True Then
Shape1.Visible = False
Shape2.Visible = False
Shape3.Visible = True
Exit Sub
End If

If Shape3.Visible = True Then
Shape1.Visible = True
Shape2.Visible = False
Shape3.Visible = False
Exit Sub
End If

End Sub
