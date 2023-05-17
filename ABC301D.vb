''
''–¢AC

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim S As String = Console.ReadLine()
'        Dim N As Decimal = Decimal.Parse(Console.ReadLine())


'        If Convert2to10(S.Replace("?", "0")) > N Then
'            Console.WriteLine("-1")
'            Return
'        End If

'        Dim r As New StringBuilder

'        Dim temp As String

'        For i As Integer = 0 To S.Length - 1

'            temp = S.Substring(i, 1)

'            If temp = "?" Then
'                If N >= Convert2to10(r.ToString & "1" & S.Substring(i + 1).Replace("?", "0")) Then
'                    r.Append("1")
'                Else
'                    r.Append("0")
'                End If
'            Else
'                r.Append(temp)
'            End If

'        Next

'        Console.WriteLine(Convert2to10(r.ToString).ToString)

'    End Sub

'    Private Shared Function Convert2to10(Value As String) As Decimal

'        Dim Ret As Decimal
'        Dim K As Decimal
'        Dim X As Decimal

'        For K = 1 To Len(Value)
'            If Mid(Value, Len(Value) - K + 1, 1) = "1" Then
'                X = 2 ^ (K - 1)
'                Ret = Ret + X
'            End If
'        Next K

'        Convert2to10 = Ret

'    End Function

'End Class
