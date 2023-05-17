''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim N As Decimal = Decimal.Parse(Console.ReadLine())
'        Dim arg As String() = Console.ReadLine().Split(" ")
'        Dim A As New List(Of Decimal)
'        For i As Integer = 0 To N - 1
'            A.Add(Decimal.Parse(arg(i)))
'        Next

'        Dim result As New List(Of String)

'        For i As Integer = 0 To A.Count - 1

'            result.Add(A(i).ToString)

'            If i = A.Count - 1 Then Continue For

'            If Math.Abs(A(i) - A(i + 1)) = 1 Then Continue For

'            If A(i) < A(i + 1) Then

'                For j As Integer = 1 To Math.Abs(A(i) - A(i + 1)) - 1
'                    result.Add((A(i) + j).ToString)
'                Next

'            Else

'                For j As Integer = 1 To Math.Abs(A(i) - A(i + 1)) - 1
'                    result.Add((A(i) - j).ToString)
'                Next

'            End If
'        Next

'        Console.WriteLine(String.Join(" ", result.ToArray))


'    End Sub

'End Class
