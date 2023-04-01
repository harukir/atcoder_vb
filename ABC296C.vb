''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim arg As String() = Console.ReadLine().Split(" ")
'        Dim N As Integer = Integer.Parse(arg(0))
'        Dim X As Integer = Integer.Parse(arg(1))

'        Dim a As String() = Console.ReadLine().Split(" ")

'        Dim r As String = "No"

'        Dim h As HashSet(Of String) = a.ToHashSet

'        For Each aa As String In h

'            If h.Contains((X + Integer.Parse(aa)).ToString) Then
'                r = "Yes"
'                Exit For
'            End If

'        Next




'        'For i As Integer = 0 To a.Length - 1

'        '    If calc(a, i, X) Then
'        '        r = "Yes"
'        '        Exit For
'        '    End If
'        'Next

'        Console.WriteLine(r)

'    End Sub

'    'Private Shared Function calc(a As String(), targetNum As Integer, X As Integer) As Boolean

'    '    For i As Integer = targetNum To a.Length - 1
'    '        If (a(targetNum) - a(i)) = X OrElse (a(i) - a(targetNum)) = X Then Return True
'    '    Next

'    '    Return False
'    'End Function

'End Class
