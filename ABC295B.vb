''https://atcoder.jp/contests/abc295/tasks/abc295_b

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim arg() As String = Console.ReadLine().Split(" ")
'        Dim R As Integer = Integer.Parse(arg(0))
'        Dim C As Integer = Integer.Parse(arg(1))

'        Dim bb As String

'        Dim lst As List(Of String)

'        Dim b As New List(Of List(Of String))
'        For i As Integer = 0 To R - 1

'            bb = Console.ReadLine()
'            lst = New List(Of String)

'            For j As Integer = 0 To bb.Length - 1

'                lst.Add(bb.Substring(j, 1))

'            Next

'            b.Add(New List(Of String)(lst))

'        Next



'        Dim pow As Integer

'        For rr As Integer = 0 To R - 1
'            For cc As Integer = 0 To C - 1

'                If {"#", "."}.Contains(b(rr)(cc)) Then Continue For

'                pow = Integer.Parse(b(rr)(cc))

'                bomb(b(rr), cc, pow)

'                For k As Integer = 2 To pow
'                    If (rr - (k - 1)) >= 0 Then
'                        bomb(b(rr - (k - 1)), cc, pow - (k - 1))
'                    End If
'                    If (rr + (k - 1)) <= b.Count - 1 Then
'                        bomb(b(rr + (k - 1)), cc, pow - (k - 1))
'                    End If
'                Next


'                If (rr - pow) >= 0 AndAlso b(rr - pow)(cc) = "#" Then
'                    b(rr - pow)(cc) = "."
'                End If

'                If (rr + pow) <= b.Count - 1 AndAlso b(rr + pow)(cc) = "#" Then
'                    b(rr + pow)(cc) = "."
'                End If

'                b(rr)(cc) = "."

'            Next
'        Next

'        Dim rrr As New StringBuilder

'        For rr As Integer = 0 To R - 1
'            For cc As Integer = 0 To C - 1
'                rrr.Append(b(rr)(cc))
'            Next
'            rrr.AppendLine()
'        Next

'        Console.WriteLine(rrr.ToString.Trim)

'    End Sub

'    Private Shared Sub bomb(ByRef arg As List(Of String), ByVal center As Integer, ByVal pow As Integer)

'        For i As Integer = center - pow To center + pow

'            If i < 0 OrElse i > arg.Count - 1 Then Continue For

'            If arg(i) = "#" Then arg(i) = "."

'        Next

'    End Sub

'End Class
