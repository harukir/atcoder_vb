''https://atcoder.jp/contests/abc291/tasks/abc291_c
'åãâ Ç™TLEÇ»ÇÃÇ≈Ç±ÇÍÇÉ{ÉcÇ…ÇµÅAABC291C_2Ç≈âÇ≠

'Imports System
'Imports System.Text

'Public Class pg

'    Shared Sub Main()

'        Dim N = Integer.Parse(Console.ReadLine())
'        Dim S = Console.ReadLine

'        Dim p As New List(Of String)
'        p.Add("0,0")

'        Dim result As String = "No"

'        Dim prevX As Integer = 0
'        Dim prevY As Integer = 0

'        Dim prevP As String = "0,0"

'        For Each c As Char In S

'            Select Case c
'                Case "R"c : prevX += 1
'                Case "L"c : prevX -= 1
'                Case "U"c : prevY += 1
'                Case "D"c : prevY -= 1
'            End Select

'            prevP = prevX.ToString & "," & prevY.ToString

'            If p.Contains(prevP) Then
'                result = "Yes"
'                Exit For
'            End If

'            p.Add(prevP)

'        Next

'        Console.WriteLine(result)

'    End Sub



'End Class
