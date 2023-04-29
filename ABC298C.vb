''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim N As Decimal = Decimal.Parse(Console.ReadLine())
'        Dim Q As Decimal = Decimal.Parse(Console.ReadLine())

'        Dim qList As New List(Of String())
'        For i As Integer = 0 To Q - 1
'            qList.Add(Console.ReadLine.Split)
'        Next

'        Dim hakoKey As New Dictionary(Of Decimal, List(Of Decimal))
'        Dim kazuKey As New Dictionary(Of Decimal, List(Of Decimal))

'        For i As Integer = 0 To qList.Count - 1

'            If qList(i)(0) = "1" Then

'                Dim kazu As Decimal = Decimal.Parse(qList(i)(1))
'                Dim hako As Decimal = Decimal.Parse(qList(i)(2))

'                If Not hakoKey.ContainsKey(hako) Then
'                    hakoKey.Add(hako, New List(Of Decimal))
'                End If
'                hakoKey(hako).Add(kazu)

'                If Not kazuKey.ContainsKey(kazu) Then
'                    kazuKey.Add(kazu, New List(Of Decimal))
'                End If
'                kazuKey(kazu).Add(hako)

'            End If

'            If qList(i)(0) = "2" Then
'                Dim hako As Decimal = Decimal.Parse(qList(i)(1))
'                Dim sb As New StringBuilder

'                Dim temp As Decimal() = hakoKey(hako).ToArray

'                Array.Sort(temp)
'                For Each d As Decimal In temp
'                    sb.Append(d.ToString).Append(" ")
'                Next

'                Console.WriteLine(sb.ToString.Trim)
'            End If

'            If qList(i)(0) = "3" Then
'                Dim kazu As Decimal = Decimal.Parse(qList(i)(1))
'                Dim sb As New StringBuilder


'                Dim temp As Decimal() = kazuKey(kazu).ToArray
'                Array.Sort(temp)

'                Dim beforeD As Decimal = -1
'                For Each d As Decimal In temp
'                    If beforeD = d Then Continue For
'                    sb.Append(d.ToString).Append(" ")
'                    beforeD = d
'                Next

'                Console.WriteLine(sb.ToString.Trim)
'            End If
'        Next

'    End Sub

'End Class
