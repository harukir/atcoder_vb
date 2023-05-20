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
'        Dim M As Decimal = argD(1)

'        Dim S As New List(Of String)

'        For i As Integer = 0 To N - 1
'            S.Add(in_s)
'        Next

'        Dim serchedI As HashSet(Of Decimal)
'        Dim result As Boolean = False

'        For i As Decimal = 0 To S.Count - 1
'            serchedI = New HashSet(Of Decimal)
'            serchedI.Add(i)

'            If rec(S, serchedI, S(i)) Then
'                result = True
'                Exit For
'            End If

'        Next



'        Console.WriteLine(If(result, "Yes", "No"))

'    End Sub



'    Function rec(ByVal S As List(Of String), ByVal serchedI As HashSet(Of Decimal), ByVal beforeS As String) As Boolean

'        If S.Count = serchedI.Count Then Return True

'        Dim r As Boolean = False

'        For i As Decimal = 0 To S.Count - 1

'            Dim tempSerchedI As HashSet(Of Decimal) = New HashSet(Of Decimal)(serchedI)

'            If serchedI.Contains(i) Then Continue For

'            If Not judge(beforeS, S(i)) Then Continue For


'            tempSerchedI.Add(i)

'            If rec(S, tempSerchedI, S(i)) Then
'                r = True
'                Exit For
'            End If

'        Next

'        Return r

'    End Function

'    Function judge(ByVal beforeS As String, ByVal afterS As String) As Boolean

'        Dim elseCnt As Decimal = 0

'        For i As Integer = 0 To beforeS.Length - 1
'            If beforeS.Substring(i, 1) <> afterS.Substring(i, 1) Then elseCnt += 1
'        Next

'        Return elseCnt <= 1

'    End Function



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



