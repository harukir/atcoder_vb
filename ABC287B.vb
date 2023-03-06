''https://atcoder.jp/contests/abc287/tasks/abc287_b

'Imports System
'Imports System.Text

'Public Class pg

'    Shared Sub Main()

'        Dim arg As String() = Console.ReadLine().Split(" ")
'        Dim N As Integer = Integer.Parse(arg(0))
'        Dim M As Integer = Integer.Parse(arg(1))

'        Dim S As New List(Of String)
'        For i As Integer = 0 To N - 1
'            S.Add(Console.ReadLine().Substring(3, 3))
'        Next

'        Dim T As New List(Of String)
'        For i As Integer = 0 To M - 1
'            T.Add(Console.ReadLine())
'        Next

'        Dim result As Integer = 0
'        For Each ss As String In S

'            For Each tt As String In T
'                If ss.Equals(tt) Then
'                    result += 1
'                    Exit For
'                End If
'            Next

'        Next

'        Console.WriteLine(result.ToString)

'    End Sub

'End Class
