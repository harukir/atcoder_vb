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
'        Dim H As Decimal = argD(0)
'        Dim W As Decimal = argD(1)

'        Dim S As List(Of String)()
'        ReDim S(H - 1)

'        Dim sPoint As New List(Of List(Of Decimal))

'        Dim tempS As String
'        Dim tempSary As String()
'        ReDim tempSary(W - 1)
'        For i As Decimal = 0 To H - 1
'            tempS = in_s()
'            For j As Decimal = 0 To W - 1
'                tempSary(j) = tempS.Substring(j, 1)

'                If tempS.Substring(j, 1) = "s" Then sPoint.Add(New List(Of Decimal)({i, j}.ToList))
'            Next
'            S(i) = New List(Of String)(tempSary)
'        Next


'        Dim ans As List(Of String)

'        For Each sp As List(Of Decimal) In sPoint

'            Dim startH As Decimal = sp(0)
'            Dim startW As Decimal = sp(1)

'            For i As Decimal = -1 To 1
'                For j As Decimal = -1 To 1

'                    ans = New List(Of String)
'                    ans.Add((startH + 1).ToString & " " & (startW + 1).ToString)

'                    If sch(S, startH, startW, i, j, 2, ans) Then

'                        For k As Decimal = 0 To ans.Count - 1
'                            Console.WriteLine(ans(k))
'                        Next

'                        Return
'                    End If

'                Next
'            Next

'        Next





'    End Sub

'    Function sch(ByVal S As List(Of String)(), ByVal H As Decimal, ByVal W As Decimal, ByVal vecH As Decimal, ByVal vecW As Decimal, ByVal cnt As Decimal, ByVal ans As List(Of String)) As Boolean

'        Dim serchedS As String
'        Select Case cnt
'            Case 2 : serchedS = "n"
'            Case 3 : serchedS = "u"
'            Case 4 : serchedS = "k"
'            Case 5 : serchedS = "e"
'        End Select

'        If cnt > 5 Then Return True


'        Dim movedH As Decimal = H + vecH
'        Dim movedW As Decimal = W + vecW

'        If movedH < 0 OrElse movedW < 0 OrElse S.Count - 1 < movedH OrElse S(0).Count - 1 < movedW Then Return False

'        Dim r As Boolean = False

'        If S(H + vecH)(W + vecW) = serchedS Then

'            ans.Add((movedH + 1).ToString & " " & (movedW + 1).ToString)
'            r = sch(S, movedH, movedW, vecH, vecW, cnt + 1, ans)

'        End If

'        Return r

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



