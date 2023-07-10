''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Module pg

'    Sub Main()

'        'Dim S As String = in_s()
'        Dim N As Decimal = in_d()

'        'Dim argS As String() = in_sAry()
'        'Dim argD As Decimal() = in_dAry()

'        Dim dp0 As New List(Of Decimal)
'        Dim dp1 As New List(Of Decimal)

'        dp0.Add(0)
'        dp1.Add(0)

'        For i As Decimal = 0 To N - 1

'            Dim argD As Decimal() = in_dAry()

'            If argD(0) = 1 Then
'                '毒あり
'                dp1.Add(Math.Max(dp0(i) + argD(1), dp1(i)))
'                dp0.Add(dp0(i))
'            Else
'                '毒なし
'                dp0.Add(Math.Max(Math.Max(dp0(i) + argD(1), dp1(i) + argD(1)), dp0(i)))
'                dp1.Add(dp1(i))
'            End If
'        Next

'        Console.WriteLine(Math.Max(dp0(dp0.Count - 1), dp1(dp1.Count - 1)).ToString)

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



