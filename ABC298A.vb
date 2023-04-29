''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim N As Decimal = Decimal.Parse(Console.ReadLine())
'        Dim S As String = Console.ReadLine()


'        Dim okCnt As Integer = 0
'        Dim isNg As Boolean = False

'        For i As Integer = 0 To S.Length - 1

'            If S.Substring(i, 1) = "o" Then
'                okCnt += 1
'            End If

'            If S.Substring(i, 1) = "x" Then
'                isNg = True
'                Exit For
'            End If
'        Next



'        Console.WriteLine(If(okCnt >= 1 AndAlso Not isNg, "Yes", "No"))

'    End Sub

'End Class
