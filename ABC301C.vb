''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim S As String = Console.ReadLine()
'        Dim T As String = Console.ReadLine()

'        Dim Scnt As New Dictionary(Of String, Decimal)
'        Dim Tcnt As New Dictionary(Of String, Decimal)

'        Scnt.Add("a", 0)
'        Scnt.Add("b", 0)
'        Scnt.Add("c", 0)
'        Scnt.Add("d", 0)
'        Scnt.Add("e", 0)
'        Scnt.Add("f", 0)
'        Scnt.Add("g", 0)
'        Scnt.Add("h", 0)
'        Scnt.Add("i", 0)
'        Scnt.Add("j", 0)
'        Scnt.Add("k", 0)
'        Scnt.Add("l", 0)
'        Scnt.Add("m", 0)
'        Scnt.Add("n", 0)
'        Scnt.Add("o", 0)
'        Scnt.Add("p", 0)
'        Scnt.Add("q", 0)
'        Scnt.Add("r", 0)
'        Scnt.Add("s", 0)
'        Scnt.Add("t", 0)
'        Scnt.Add("u", 0)
'        Scnt.Add("v", 0)
'        Scnt.Add("w", 0)
'        Scnt.Add("x", 0)
'        Scnt.Add("y", 0)
'        Scnt.Add("z", 0)
'        Scnt.Add("@", 0)
'        Tcnt.Add("a", 0)
'        Tcnt.Add("b", 0)
'        Tcnt.Add("c", 0)
'        Tcnt.Add("d", 0)
'        Tcnt.Add("e", 0)
'        Tcnt.Add("f", 0)
'        Tcnt.Add("g", 0)
'        Tcnt.Add("h", 0)
'        Tcnt.Add("i", 0)
'        Tcnt.Add("j", 0)
'        Tcnt.Add("k", 0)
'        Tcnt.Add("l", 0)
'        Tcnt.Add("m", 0)
'        Tcnt.Add("n", 0)
'        Tcnt.Add("o", 0)
'        Tcnt.Add("p", 0)
'        Tcnt.Add("q", 0)
'        Tcnt.Add("r", 0)
'        Tcnt.Add("s", 0)
'        Tcnt.Add("t", 0)
'        Tcnt.Add("u", 0)
'        Tcnt.Add("v", 0)
'        Tcnt.Add("w", 0)
'        Tcnt.Add("x", 0)
'        Tcnt.Add("y", 0)
'        Tcnt.Add("z", 0)
'        Tcnt.Add("@", 0)

'        Dim r As String = "Yes"

'        For i As Decimal = 0 To S.Length - 1

'            Scnt(S.Substring(i, 1)) += 1
'            Tcnt(T.Substring(i, 1)) += 1

'        Next

'        For Each k As String In {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}

'            If k = "@" Then Continue For

'            If Scnt(k) = Tcnt(k) Then Continue For

'            If Not {"a", "t", "c", "o", "d", "e", "r"}.Contains(k) Then
'                r = "No"
'                Exit For
'            End If

'            Dim sa As Decimal = Math.Abs(Scnt(k) - Tcnt(k))

'            Dim atmarkCnt As Decimal = If(Scnt(k) > Tcnt(k), Tcnt("@"), Scnt("@"))

'            If sa > atmarkCnt Then
'                r = "No"
'                Exit For
'            End If

'            If Scnt(k) > Tcnt(k) Then
'                Tcnt("@") -= sa
'            Else
'                Scnt("@") -= sa
'            End If

'        Next




'        Console.WriteLine(r)

'    End Sub

'End Class
