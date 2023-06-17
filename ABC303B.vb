''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Module pg

'    Sub Main()

'        'Dim S As String = in_s()
'        'Dim N As Decimal = in_d()

'        'Dim argS As String() = in_sAry()
'        'Dim argD As Decimal() = in_dAry()

'        Dim argD As Decimal() = in_dAry()
'        Dim N As Decimal = argD(0)
'        Dim M As Decimal = argD(1)

'        Dim pairedA As New Dictionary(Of Decimal, HashSet(Of Decimal))

'        For i As Decimal = 1 To N
'            pairedA.Add(i, New HashSet(Of Decimal))
'        Next

'        Dim a As Decimal()
'        For i As Decimal = 0 To M - 1
'            a = in_dAry()

'            For j As Decimal = 0 To a.Length - 2
'                pairedA(a(j)).Add(a(j + 1))
'                pairedA(a(j + 1)).Add(a(j))
'            Next

'        Next

'        Dim r As New HashSet(Of String)

'        For i As Decimal = 1 To N

'            For j As Decimal = 1 To N

'                If i = j Then Continue For

'                If pairedA(i).Contains(j) Then Continue For

'                r.Add(Math.Min(i, j).ToString & "," & Math.Max(i, j))

'            Next
'        Next

'        Console.WriteLine(r.Count.ToString)

'    End Sub







'#Region "ライブラリ"

'#Region "入力受け取り"

'    Function in_s() As String
'        Return Console.ReadLine()
'    End Function
'    Function in_d() As Decimal
'        Return Decimal.Parse(Console.ReadLine())
'    End Function
'    Function in_sAry(Optional dlm As String = " ") As String()
'        Return Console.ReadLine().Split(dlm)
'    End Function
'    Function in_dAry(Optional dlm As String = " ") As Decimal()
'        Dim arg As String() = Console.ReadLine().Split(dlm)
'        Dim d As Decimal()
'        ReDim d(arg.Length - 1)
'        For i As Integer = 0 To arg.Length - 1
'            d(i) = Decimal.Parse(arg(i))
'        Next
'        Return d
'    End Function


'#End Region

'    ''' <summary>数値が素数であるか判定します。</summary>
'    ''' <param name="Number">対象の数値を指定します。</param>
'    ''' <returns>Numberが素数である場合Trueを返します。</returns>
'    Function IsPrime(ByVal Number As Decimal) As Boolean
'        Dim K As Decimal

'        If Number < 2 Then Return False

'        For K = 2 To Decimal.Parse(Math.Sqrt(Number))
'            If Number Mod K = 0 Then Return False
'        Next

'        Return True

'    End Function

'#End Region

'End Module



