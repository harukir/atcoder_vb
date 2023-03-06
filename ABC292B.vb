''https://atcoder.jp/contests/abc292/tasks/abc292_b

'Imports System
'Imports System.Text

'Public Class pg

'    Shared Sub Main()

'        Dim arg As String() = Console.ReadLine().Split(" ")
'        Dim N As String = arg(0)
'        Dim Q As String = arg(1)

'        Dim player As Integer()
'        ReDim player(N - 1)
'        For i As Integer = 0 To N - 1
'            player(i) = 0
'        Next

'        Dim ev As Integer()()
'        ReDim ev(Q - 1)

'        For i As Integer = 0 To Q - 1
'            arg = Console.ReadLine().Split(" ")
'            Dim tempArg(1) As Integer
'            tempArg(0) = Integer.Parse(arg(0))
'            tempArg(1) = Integer.Parse(arg(1))
'            ev(i) = tempArg
'        Next



'        For Each e As Integer() In ev
'            Select Case e(0)
'                Case 1
'                    player(e(1) - 1) += 1
'                Case 2
'                    player(e(1) - 1) += 2
'                Case 3
'                    Console.WriteLine(If(player(e(1) - 1) >= 2, "Yes", "No"))
'            End Select
'        Next

'    End Sub

'End Class
