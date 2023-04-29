''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Public Class pg


'    Shared Sub Main()

'        Dim N As Decimal = Decimal.Parse(Console.ReadLine())

'        Dim A As New List(Of List(Of String))
'        Dim B As New List(Of List(Of String))

'        For i As Integer = 0 To N - 1
'            A.Add(Console.ReadLine().Split(" ").ToList)
'        Next
'        For i As Integer = 0 To N - 1
'            B.Add(Console.ReadLine().Split(" ").ToList)
'        Next

'        Dim r As Boolean = judge(A, B)

'        If r Then
'            Console.WriteLine("Yes")
'            Exit Sub
'        End If

'        Dim tempA As New List(Of List(Of String))(A)



'        For i As Integer = 0 To 2

'            tempA = New List(Of List(Of String))(kaiten(tempA))

'            r = judge(tempA, B)

'            If r Then Exit For
'        Next


'        Console.WriteLine(If(r, "Yes", "No"))

'    End Sub

'    Private Shared Function kaiten(A As List(Of List(Of String))) As List(Of List(Of String))

'        Dim frame As New List(Of List(Of String))
'        Dim frameRow As New List(Of String)

'        For i As Integer = 0 To A.Count - 1
'            frameRow.Add("0")
'        Next
'        For i As Integer = 0 To A.Count - 1
'            frame.Add(New List(Of String)(frameRow))
'        Next

'        For i As Integer = 0 To A.Count - 1
'            For j As Integer = 0 To A.Count - 1
'                'frame((A.Count + 1) - (j + 1) - 1)(i) = A(i)(j)
'                frame(i)(j) = A((A.Count + 1) - (j + 1) - 1)(i)
'            Next
'        Next

'        Return frame
'    End Function

'    Private Shared Function judge(A As List(Of List(Of String)), B As List(Of List(Of String))) As Boolean

'        Dim r As Boolean = True
'        For i As Integer = 0 To A.Count - 1
'            For j As Integer = 0 To A.Count - 1
'                'If A(i)(j) <> B(i)(j) Then Return False

'                If B(i)(j) = "1" Then
'                    A(i)(j) = "0"
'                End If

'                If A(i)(j) = "1" Then r = False
'            Next
'        Next

'        Return r
'    End Function


'End Class
