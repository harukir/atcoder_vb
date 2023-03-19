''https://atcoder.jp/contests/abc289/tasks/abc289_d

'Imports System
'Imports System.IO
'Imports System.Text

'Public Class pg

'    Shared Sub Main()

'        Dim N As Integer = Integer.Parse(Console.ReadLine())
'        Dim arg As String() = Console.ReadLine().Split(" ")
'        Dim a As Integer()
'        ReDim a(N - 1)
'        For i As Integer = 0 To N - 1
'            a(i) = Integer.Parse(arg(i))
'        Next

'        Dim M As Integer = Integer.Parse(Console.ReadLine())
'        arg = Console.ReadLine().Split(" ")
'        Dim b As Integer()
'        ReDim b(M - 1)
'        For i As Integer = 0 To M - 1
'            b(i) = Integer.Parse(arg(i))
'        Next

'        Dim X As Integer = Integer.Parse(Console.ReadLine())

'        Dim canMoveH As New HashSet(Of Integer)
'        canMoveH.Add(0)

'        Dim bCnt As Integer = 0

'        Dim failureCnt As Integer = 0

'        For i As Integer = 1 To X

'            failureCnt += 1

'            If bCnt < b.Count AndAlso b(bCnt) = i Then
'                bCnt += 1
'                Continue For
'            End If

'            's“®‚Å‚«‚é‚©”»’è
'            For j As Integer = 0 To a.Count - 1

'                If i < a(j) Then Exit For

'                If canMoveH.Contains(i - a(j)) Then
'                    canMoveH.Add(i)
'                    failureCnt = 0
'                    Exit For
'                End If

'            Next

'            If failureCnt >= a(a.Count - 1) Then Exit For

'        Next

'        Console.WriteLine(If(canMoveH.Add(X), "No", "Yes"))

'    End Sub

'End Class
