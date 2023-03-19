''https://atcoder.jp/contests/abc294/tasks/abc294_c

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim arg As String() = Console.ReadLine().Split(" ")
'        Dim N As Integer = Integer.Parse(arg(0))
'        Dim M As Integer = Integer.Parse(arg(1))

'        arg = Console.ReadLine().Split(" ")
'        Dim a As Integer()
'        ReDim a(N - 1)
'        For i As Integer = 0 To N - 1
'            a(i) = Integer.Parse(arg(i))
'        Next

'        arg = Console.ReadLine().Split(" ")
'        Dim b As Integer()
'        ReDim b(M - 1)
'        For i As Integer = 0 To M - 1
'            b(i) = Integer.Parse(arg(i))
'        Next

'        Dim rA As New StringBuilder
'        Dim rB As New StringBuilder

'        Dim aCnt As Integer = 0
'        Dim bCnt As Integer = 0

'        For i As Integer = 1 To N + M
'            If Not aCnt = a.Length AndAlso (bCnt = b.Length OrElse a(aCnt) < b(bCnt)) Then
'                rA.Append(i.ToString).Append(" ")
'                aCnt += 1
'            Else
'                rB.Append(i.ToString).Append(" ")
'                bCnt += 1
'            End If
'        Next

'        Console.WriteLine(rA.ToString.Trim)
'        Console.WriteLine(rB.ToString.Trim)
'    End Sub

'End Class
