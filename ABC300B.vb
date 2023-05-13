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

'        Dim A As List(Of String)()
'        ReDim A(H - 1)

'        'For i As Decimal = 0 To H - 1
'        '    A(i) = Console.ReadLine().Split(" ")
'        'Next

'        Dim s As String
'        Dim tempS As String()
'        ReDim tempS(W - 1)
'        For i As Decimal = 0 To H - 1
'            s = Console.ReadLine()
'            For j As Decimal = 0 To W - 1
'                tempS(j) = s.Substring(j, 1)
'            Next
'            A(i) = New List(Of String)(tempS)
'        Next


'        Dim B As List(Of String)()
'        ReDim B(H - 1)
'        'For i As Decimal = 0 To H - 1
'        '    B(i) = Console.ReadLine().Split(" ")
'        'Next

'        For i As Decimal = 0 To H - 1
'            s = Console.ReadLine()
'            For j As Decimal = 0 To W - 1
'                tempS(j) = s.Substring(j, 1)
'            Next
'            B(i) = New List(Of String)(tempS)
'        Next


'        Dim isS As Boolean = False

'        For i As Decimal = 0 To H - 1
'            For j As Decimal = 0 To W - 1
'                If isSame(A, B) Then
'                    isS = True
'                    Console.WriteLine("Yes")
'                    Return
'                End If
'                moveW(A)
'            Next

'            moveH(A)
'        Next

'        Console.WriteLine("No")

'    End Sub

'    Private Shared Sub moveH(ByRef A As List(Of String)())

'        Dim retA As List(Of String)()
'        ReDim retA(A.Count - 1)

'        For i As Decimal = 1 To A.Count - 1
'            retA(i - 1) = A(i)
'        Next

'        retA(A.Count - 1) = A(0)

'        A = retA

'    End Sub

'    Private Shared Sub moveW(ByRef A As List(Of String)())

'        Dim tempA As List(Of String)

'        For i As Decimal = 0 To A.Count - 1

'            tempA = New List(Of String)

'            For j As Decimal = 1 To A(0).Count - 1
'                tempA.Add(A(i)(j))
'            Next

'            tempA.Add(A(i)(0))

'            A(i) = New List(Of String)(tempA)

'        Next

'    End Sub

'    Private Shared Function isSame(ByVal A As List(Of String)(), ByVal B As List(Of String)()) As Boolean

'        For i As Decimal = 0 To A.Count - 1
'            For j As Decimal = 0 To A(0).Count - 1
'                If A(i)(j) <> B(i)(j) Then
'                    Return False
'                End If

'            Next
'        Next

'        Return True
'    End Function


'End Class
