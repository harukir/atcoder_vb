''https://atcoder.jp/contests/abc297/tasks/abc297_b

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim S As String = Console.ReadLine()

'        Dim r As String = "No"

'        Dim b1 As Integer = -1
'        Dim b2 As Integer = -1

'        Dim r1 As Integer = -1
'        Dim r2 As Integer = -1


'        Dim koma As String

'        Dim isB As Boolean = False
'        Dim isR As Boolean = False

'        For i As Integer = 0 To S.Length - 1

'            koma = S.Substring(i, 1)

'            If koma = "B" Then
'                If b1 = -1 Then
'                    b1 = i
'                Else
'                    If (b1 Mod 2) <> (i Mod 2) Then
'                        isB = True
'                    End If
'                End If
'            End If

'            If koma = "R" Then
'                If r1 = -1 Then
'                    r1 = i
'                Else
'                    r2 = i
'                End If
'            End If

'            If koma = "K" Then
'                If r1 >= 0 AndAlso r2 = -1 Then
'                    isR = True
'                End If
'            End If

'        Next

'        Console.WriteLine(If(isB AndAlso isR, "Yes", "No"))

'    End Sub

'End Class
