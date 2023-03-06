''https://atcoder.jp/contests/abc290/tasks/abc290_b

'Imports System
'Imports System.Text

'Public Class pg

'    Shared Sub Main()

'        Const maru As Char = "o"c
'        Const batu As Char = "x"c

'        Dim args As String() = Console.ReadLine().Split(" ")
'        Dim N As Integer = Integer.Parse(args(0))
'        Dim K As Integer = Integer.Parse(args(1))
'        Dim S As String = Console.ReadLine

'        Dim result As New StringBuilder

'        Dim cnt As Integer = 0
'        For Each ss In S

'            result.Append(If(cnt < K, ss, batu))

'            If ss.Equals(maru) Then cnt += 1

'        Next

'        Console.WriteLine(result.ToString)

'    End Sub

'End Class
