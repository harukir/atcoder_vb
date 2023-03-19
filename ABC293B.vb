''https://atcoder.jp/contests/abc293/tasks/abc293_b

'Imports System
'Imports System.IO
'Imports System.Text

'Public Class pg

'    Shared Sub Main()

'        Dim N As Integer = Integer.Parse(Console.ReadLine())

'        Dim A As String() = Console.ReadLine().Split(" ")

'        Dim r As String()
'        ReDim r(N - 1)


'        For i As Integer = 0 To N - 1

'            If Not r(i) Is Nothing Then Continue For

'            r(Integer.Parse(A(i)) - 1) = "*"
'        Next


'        Dim rr As New StringBuilder
'        Dim rc As Integer = 0

'        For i As Integer = 0 To r.Count - 1
'            If r(i) Is Nothing Then
'                rc += 1
'                rr.Append((i + 1).ToString).Append(" ")
'            End If
'        Next

'        Console.WriteLine(rc.ToString)
'        Console.WriteLine(rr.ToString.Trim)

'    End Sub


'End Class
