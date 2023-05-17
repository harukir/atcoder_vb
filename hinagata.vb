'

Imports System
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Text

Module pg

    Sub Main()

        'Dim S As String = in_s()
        Dim N As Decimal = in_d()

        'Dim argS As String() = in_sAry()
        'Dim argD As Decimal() = in_dAry()

        Dim a As Boolean = IsPrime(N)

        Dim aaaa = ""


        'Dim result As New List(Of String)

        'For i As Integer = 0 To A.Count - 1

        '    result.Add(A(i).ToString)

        '    If i = A.Count - 1 Then Continue For

        '    If Math.Abs(A(i) - A(i + 1)) = 1 Then Continue For

        '    If A(i) < A(i + 1) Then

        '        For j As Integer = 1 To Math.Abs(A(i) - A(i + 1)) - 1
        '            result.Add((A(i) + j).ToString)
        '        Next

        '    Else

        '        For j As Integer = 1 To Math.Abs(A(i) - A(i + 1)) - 1
        '            result.Add((A(i) - j).ToString)
        '        Next

        '    End If
        'Next

        'Console.WriteLine(String.Join(" ", result.ToArray))

        Console.WriteLine()

    End Sub

#Region "ライブラリ"

#Region "入力受け取り"

    Function in_s() As String
        Return Console.ReadLine()
    End Function
    Function in_d() As Decimal
        Return Decimal.Parse(Console.ReadLine())
    End Function
    Function in_sAry(Optional dlm As String = " ") As String()
        Return Console.ReadLine().Split(dlm)
    End Function
    Function in_dAry(Optional dlm As String = " ") As Decimal()
        Dim arg As String() = Console.ReadLine().Split(dlm)
        Dim d As Decimal()
        ReDim d(arg.Length - 1)
        For i As Integer = 0 To arg.Length - 1
            d(i) = Decimal.Parse(arg(i))
        Next
        Return d
    End Function


#End Region

    ''' <summary>数値が素数であるか判定します。</summary>
    ''' <param name="Number">対象の数値を指定します。</param>
    ''' <returns>Numberが素数である場合Trueを返します。</returns>
    Function IsPrime(ByVal Number As Decimal) As Boolean
        Dim K As Decimal

        If Number < 2 Then Return False

        For K = 2 To Decimal.Parse(Math.Sqrt(Number))
            If Number Mod K = 0 Then Return False
        Next

        Return True

    End Function

#End Region

End Module



