''https://atcoder.jp/contests/abc294/tasks/abc294_d

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim arg As String() = Console.ReadLine().Split(" ")
'        Dim N As Integer = Integer.Parse(arg(0))
'        Dim Q As Integer = Integer.Parse(arg(1))

'        Dim calledMax As Integer = 0
'        Dim uketuked As New HashSet(Of Integer)

'        Dim waitMin As Integer = 1

'        Dim r As New StringBuilder

'        For i As Integer = 0 To Q - 1
'            arg = Console.ReadLine().Split(" ")

'            Select Case arg(0)
'                Case "1"
'                    calledMax += 1

'                Case "2"
'                    Dim u As Integer = Integer.Parse(arg(1))
'                    uketuked.Add(u)
'                    If waitMin = u Then
'                        For j As Integer = waitMin + 1 To N + 1
'                            If uketuked.Contains(j) Then Continue For
'                            waitMin = j
'                            Exit For
'                        Next
'                    End If
'                Case "3"
'                    r.AppendLine(waitMin.ToString)
'            End Select

'        Next

'        Console.WriteLine(r.ToString.Trim)
'    End Sub

'End Class
