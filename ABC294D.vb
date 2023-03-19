''https://atcoder.jp/contests/abc294/tasks/abc294_d
'TLEî≠ê∂ÅB_2ÇÃï˚Ç≈AC

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim arg As String() = Console.ReadLine().Split(" ")
'        Dim N As Integer = Integer.Parse(arg(0))
'        Dim Q As Integer = Integer.Parse(arg(1))

'        'Dim nCalledStats As String
'        'Dim nMovedStats As String
'        'For i As Integer = 0 To N - 1
'        '    nCalledStats += "0"
'        '    nMovedStats += "0"
'        'Next

'        Dim calledMax As Integer = 0
'        Dim uketuked As New HashSet(Of Integer)

'        Dim r As New StringBuilder

'        For i As Integer = 0 To Q - 1
'            arg = Console.ReadLine().Split(" ")

'            Select Case arg(0)
'                Case "1"
'                    calledMax += 1
'                    'nCalledStats = 

'                Case "2"
'                    uketuked.Add(Integer.Parse(arg(1)))
'                Case "3"
'                    For j As Integer = 1 To calledMax
'                        If uketuked.Contains(j) Then Continue For
'                        r.AppendLine(j.ToString)
'                        Exit For
'                    Next
'            End Select

'        Next

'        Console.WriteLine(r.ToString.Trim)
'    End Sub

'End Class
