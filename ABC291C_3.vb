''https://atcoder.jp/contests/abc291/tasks/abc291_c
''コンテスト解答を見た上で正解コーディング。無印ソースでやってることを使う関数変えてやったらできた。

'Imports System
'Imports System.Text

'Public Class pg

'    Shared Sub Main()

'        Dim N = Integer.Parse(Console.ReadLine())
'        Dim S = Console.ReadLine

'        Dim result As String = "No"

'        Dim p As New HashSet(Of String)

'        Dim nowX As Integer = 0
'        Dim nowY As Integer = 0
'        p.Add("0,0")


'        For Each c As Char In S

'            Select Case c
'                Case "R"c
'                    nowX += 1
'                Case "L"c
'                    nowX -= 1
'                Case "U"c
'                    nowY += 1
'                Case "D"c
'                    nowY -= 1
'            End Select

'            If Not p.Add(nowX.ToString & "," & nowY.ToString) Then
'                result = "Yes"
'                Exit For
'            End If

'        Next

'        Console.WriteLine(result)

'    End Sub



'End Class
