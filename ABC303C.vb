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
'        Dim H As Decimal = argD(2)
'        Dim K As Decimal = argD(3)

'        Dim S As String = in_s()

'        Dim healP As New HashSet(Of String)

'        Dim temp As Decimal()
'        For i As Decimal = 0 To M - 1
'            temp = in_dAry()
'            healP.Add(getP(temp(0), temp(1)))
'        Next

'        Dim genzaiP As New List(Of Decimal)
'        genzaiP.add(0)
'        genzaiP.add(0)

'        Dim vec As String

'        Dim isMoved As Boolean = True

'        For i As Decimal = 0 To N - 1

'            vec = S.Substring(i, 1)
'            move(genzaiP, vec)
'            H -= 1

'            If H < 0 Then
'                isMoved = False
'                Exit For
'            End If

'            If healP.Contains(getP(genzaiP)) AndAlso H < K Then
'                H = K
'                healP.Remove(getP(genzaiP))
'            End If

'        Next


'        Console.WriteLine(If(isMoved, "Yes", "No"))

'    End Sub


'    Function getP(p As List(Of Decimal)) As String
'        Return p(0).ToString & "," & p(1).ToString
'    End Function

'    Function getP(x As Decimal, y As Decimal) As String
'        Return x.ToString & "," & y.ToString
'    End Function

'    Sub move(genzaiP As List(Of Decimal), vec As String)

'        Select Case vec
'            Case "R" : genzaiP(0) += 1
'            Case "L" : genzaiP(0) -= 1
'            Case "U" : genzaiP(1) += 1
'            Case "D" : genzaiP(1) -= 1
'        End Select

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



