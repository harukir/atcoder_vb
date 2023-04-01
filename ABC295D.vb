''https://atcoder.jp/contests/abc295/tasks/abc295_d
''—\‘z’Ê‚èTLEB

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim S As String = Console.ReadLine

'        Dim part As String

'        Dim c As Double = 0


'        For i As Integer = 0 To S.Length - 1

'            For j As Integer = 2 To S.Length Step 2

'                If i + j > S.Length Then Exit For

'                part = S.Substring(i, j)

'                Dim l As New Dictionary(Of String, Double)
'                For k As Integer = 0 To j - 1

'                    Dim target As String = part.Substring(k, 1)

'                    If l.ContainsKey(target) Then
'                        l(target) += 1
'                    Else
'                        l.Add(target, 1)
'                    End If
'                Next

'                Dim ssss As Boolean = True
'                For Each k As Double In l.Values
'                    If k Mod 2 <> 0 Then
'                        ssss = False
'                        Exit For
'                    End If
'                Next

'                If ssss Then
'                    c += 1
'                End If

'            Next


'        Next

'        Console.WriteLine(c.ToString)

'    End Sub

'End Class
