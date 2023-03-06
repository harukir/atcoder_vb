''https://atcoder.jp/contests/abc285/tasks/abc285_c

'Imports System
'Imports System.Text

'Public Class pg

'    Shared Sub Main()

'        Dim S = Console.ReadLine()

'        'Dim sum = 0
'        Dim sum As ULong = 0

'        For i = 0 To S.Count - 1

'            sum += (26 ^ (S.Count - i - 1) * ConvertAlphabet2Number(S(i)))

'        Next

'        Console.WriteLine(sum.ToString)

'    End Sub

'    Private Shared Function ConvertAlphabet2Number(ByVal alphabet As Char) As Integer
'        If alphabet.Equals("A"c) Then Return 1
'        If alphabet.Equals("B"c) Then Return 2
'        If alphabet.Equals("C"c) Then Return 3
'        If alphabet.Equals("D"c) Then Return 4
'        If alphabet.Equals("E"c) Then Return 5
'        If alphabet.Equals("F"c) Then Return 6
'        If alphabet.Equals("G"c) Then Return 7
'        If alphabet.Equals("H"c) Then Return 8
'        If alphabet.Equals("I"c) Then Return 9
'        If alphabet.Equals("J"c) Then Return 10
'        If alphabet.Equals("K"c) Then Return 11
'        If alphabet.Equals("L"c) Then Return 12
'        If alphabet.Equals("M"c) Then Return 13
'        If alphabet.Equals("N"c) Then Return 14
'        If alphabet.Equals("O"c) Then Return 15
'        If alphabet.Equals("P"c) Then Return 16
'        If alphabet.Equals("Q"c) Then Return 17
'        If alphabet.Equals("R"c) Then Return 18
'        If alphabet.Equals("S"c) Then Return 19
'        If alphabet.Equals("T"c) Then Return 20
'        If alphabet.Equals("U"c) Then Return 21
'        If alphabet.Equals("V"c) Then Return 22
'        If alphabet.Equals("W"c) Then Return 23
'        If alphabet.Equals("X"c) Then Return 24
'        If alphabet.Equals("Y"c) Then Return 25
'        If alphabet.Equals("Z"c) Then Return 26

'        Throw New Exception
'        Return 0
'    End Function

'End Class
