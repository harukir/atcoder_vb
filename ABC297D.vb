''https://atcoder.jp/contests/abc297/tasks/abc297_d

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim arg As String() = Console.ReadLine().Split(" ")
'        Dim A As Decimal = Decimal.Parse(arg(0))
'        Dim B As Decimal = Decimal.Parse(arg(1))

'        Dim r As Decimal = 0

'        Dim maxVal As Decimal
'        Dim minVal As Decimal

'        While 1 = 1

'            If A = B Then Exit While

'            minVal = Math.Min(A, B)
'            maxVal = Math.Max(A, B)

'            Dim addC As Decimal = Math.Ceiling(maxVal / minVal) - 1

'            r += addC

'            If A > B Then
'                A = A - (B * addC)
'            Else
'                B = B - (A * addC)
'            End If

'        End While

'        Console.WriteLine(r.ToString)

'    End Sub

'End Class
