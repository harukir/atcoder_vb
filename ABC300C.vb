''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim arg As String() = Console.ReadLine().Split(" ")
'        Dim H As Decimal = Decimal.Parse(arg(0))
'        Dim W As Decimal = Decimal.Parse(arg(1))

'        Dim C As List(Of String)()
'        ReDim C(H - 1)

'        Dim s As String
'        Dim tempS As String()
'        ReDim tempS(W - 1)
'        For i As Decimal = 0 To H - 1
'            s = Console.ReadLine()
'            For j As Decimal = 0 To W - 1
'                tempS(j) = s.Substring(j, 1)
'            Next
'            C(i) = New List(Of String)(tempS)
'        Next




'        Dim result As Decimal()
'        ReDim result(Math.Min(H, W) - 1)




'        Dim startX As List(Of Decimal)
'        Dim X As Dictionary(Of Decimal, Decimal)

'        For i As Decimal = 0 To H - 1
'            startX = New List(Of Decimal)
'            X = New Dictionary(Of Decimal, Decimal)

'            For j As Decimal = 0 To W - 1

'                If C(i)(j) <> "#" Then Continue For

'                '#のときの処理
'                '右下をチェックして、右下があれば左側の#、なければ右側の#と捉える

'                If j < W - 1 AndAlso C(i + 1)(j + 1) = "#" Then
'                    startX.Add(j)
'                    X.Add(j, -1)
'                Else
'                    X(startX(startX.Count - 1)) = j
'                End If

'            Next

'            For Each k As Decimal In X.Keys

'                Dim siz As Decimal = X(k) - k

'                result((siz / 2) - 1) += 1

'                For l As Decimal = 1 To siz
'                    C(i + l)(k + l) = "."
'                    C(i + l)(X(k) - l) = "."
'                Next
'            Next


'        Next

'        Console.WriteLine(String.Join(" ", result))

'    End Sub

'End Class
