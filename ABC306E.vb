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
'        Dim argD As Decimal() = in_dAry()

'        Dim N As Decimal = argD(0)
'        Dim K As Decimal = argD(0)
'        Dim Q As Decimal = argD(0)

'        Dim A As New Dictionary(Of Decimal, Decimal)


'        'Dim calcNum As New HashSet(Of Decimal) '計算に使う数字の管理
'        Dim calcNum As New Dictionary(Of Decimal, Decimal) '計算に使う数字と個数の管理

'        Dim num2A As New Dictionary(Of Decimal, HashSet(Of Decimal)) '数をもつAの管理

'        Dim X As Decimal
'        Dim Y As Decimal

'        Dim tempMinVal As Decimal = 0 '計算する内、一番小さい数

'        For i As Decimal = 0 To Q - 1

'            argD = in_dAry()
'            X = argD(0)
'            Y = argD(1)

'            Dim beforeAY As Decimal = If(A.ContainsKey(X), A(X), 0)

'            If num2A.ContainsKey(Y) AndAlso num2A(Y).Contains(X) Then
'                num2A(Y).Remove(X)
'            End If

'            If A.ContainsKey(X) Then
'                A.Add(X, Y)
'            Else
'                A(X) = Y
'            End If

'            If num2A.ContainsKey(Y) Then
'                num2A(Y).Add(X)
'            Else
'                num2A.Add(Y, New HashSet(Of Decimal)(1))
'            End If


'            '数を更新する

'            Dim is1 As Boolean = tempMinVal < Y
'            Dim is2 As Boolean = calcNum.ContainsKey(A(X))
'            'Dim is22 As Boolean = 

'            If is1 OrElse is2 Then
'                If calcNum.ContainsKey(beforeAY) Then
'                    calcNum(beforeAY) -= 1
'                End If
'            End If

'            If is1 Then
'                '①tempMinValが今回より小さかった場合、数字入れ替え
'                If calcNum(tempMinVal) <> 1 Then
'                    calcNum(tempMinVal) -= 1
'                Else
'                    calcNum.Remove(tempMinVal)
'                End If
'                If calcNum.ContainsKey(Y) Then
'                    calcNum(Y) += 1
'                Else
'                    calcNum.Add(Y, 1)
'                End If

'            ElseIf calcNum.ContainsKey(A(X)) Then
'                '②今採用している数のAが更新された場合

'                'Yが今使用している個数を下回ったら、num2A
'                If calcNum(X) >= num2A(Y).Count Then



'                Else

'                End If



'            End If






'            If i < K Then
'                If calcNum.ContainsKey(Y) Then
'                    calcNum(Y) += 1
'                Else
'                    calcNum.Add(, 1)
'                End If
'            End If




'            'Dim l As New List(Of Decimal)(num2A.Keys.ToList)
'            'l.Sort()




'        Next



'        Console.WriteLine()

'    End Sub

'    Sub dicAdd(dic As Dictionary(Of Decimal, Decimal), k As Decimal, v As Decimal)

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



