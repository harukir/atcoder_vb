''https://atcoder.jp/contests/abc163

'Imports System
'Imports System.Text

'Public Class pg

'    Shared Sub Main()

'        Dim N As Integer = Integer.Parse(Console.ReadLine())
'        'Dim boss As List(Of Integer) = (From s As String In Console.ReadLine().Split(" ") Select Integer.Parse(s)).ToList

'        Dim boss As String() = Console.ReadLine().Split(" ")

'        'Dim emp As New List(Of Integer)

'        'Dim bukaCnt As New List(Of String)

'        Dim sb As New StringBuilder

'        For i As Integer = 1 To N

'            'Dim tempI As Integer = i
'            'bukaCnt.Add((Aggregate j As Integer In boss Where j.Equals(tempI) Into Count()).ToString)

'            'sb.AppendLine((Aggregate j As Integer In boss Where j.Equals(tempI) Into Count()).ToString)

'            Dim c As Integer = 0

'            'For j As Integer = 2 To N
'            For Each j As String In boss
'                If j.Equals(i.ToString) Then c += 1
'            Next

'            sb.AppendLine(c.ToString)


'        Next


'        Console.WriteLine(Trim(sb.ToString))

'    End Sub

'End Class
