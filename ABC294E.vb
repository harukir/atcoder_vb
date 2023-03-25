''https://atcoder.jp/contests/abc294/tasks/abc294_e

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim arg As String() = Console.ReadLine().Split(" ")
'        Dim L As Long = Long.Parse(arg(0))
'        Dim N1 As Long = Long.Parse(arg(1))
'        Dim N2 As Long = Long.Parse(arg(2))

'        Dim row1 As New List(Of List(Of Long))
'        Dim row2 As New List(Of List(Of Long))

'        For i As Long = 0 To N1 - 1
'            arg = Console.ReadLine().Split()
'            row1.Add({Long.Parse(arg(0)), Long.Parse(arg(1))}.ToList)
'        Next
'        For i As Long = 0 To N2 - 1
'            arg = Console.ReadLine().Split()
'            row2.Add({Long.Parse(arg(0)), Long.Parse(arg(1))}.ToList)
'        Next

'        Dim r1RowPos As Long = 0
'        Dim r2RowPos As Long = 0
'        Dim r1ColPos As Long = row1(r1RowPos)(1)
'        Dim r2ColPos As Long = row2(r2RowPos)(1)
'        Dim minColPos As Long

'        Dim r1Mochikosi As Long = 0
'        Dim r2Mochikosi As Long = 0

'        Dim r As Long = 0

'        While 1 = 1

'            minColPos = Math.Min(r1ColPos, r2ColPos)

'            If row1(r1RowPos)(0) = row2(r2RowPos)(0) Then
'                r += minColPos
'            End If

'            r1Mochikosi += minColPos
'            r2Mochikosi += minColPos

'            If row1(r1RowPos)(1) = r1Mochikosi Then
'                r1RowPos += 1
'                r1Mochikosi = 0
'            End If
'            If r1RowPos = row1.Count Then Exit While
'            r1ColPos = row1(r1RowPos)(1) - r1Mochikosi

'            If row2(r2RowPos)(1) = r2Mochikosi Then
'                r2RowPos += 1
'                r2Mochikosi = 0
'            End If
'            If r2RowPos = row2.Count Then Exit While
'            r2ColPos = row2(r2RowPos)(1) - r2Mochikosi


'        End While

'        Console.WriteLine(r.ToString)
'    End Sub

'End Class
