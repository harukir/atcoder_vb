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
'        Dim X As Decimal = argD(0)
'        Dim Y As Decimal = argD(1)
'        Dim Z As Decimal = argD(2)

'        Dim S As String = in_s()

'        Dim dpOn As New List(Of Decimal)
'        Dim dpOff As New List(Of Decimal)

'        Dim nowA As String = S.Substring(0, 1)

'        Dim tempA As String
'        Dim beforeA As String = nowA

'        Dim cnt As Decimal = 0

'        Dim isFirst As Boolean = True

'        For i As Decimal = 0 To S.Length - 1
'            tempA = S.Substring(i, 1)
'            If beforeA <> tempA Then

'                If isFirst Then
'                    If beforeA = "a" Then
'                        dpOff.Add(X * cnt)
'                        dpOn.Add((Y * cnt) + Z)
'                    Else
'                        dpOff.Add(Y * cnt)
'                        dpOn.Add((X * cnt) + Z)
'                    End If
'                Else
'                    If beforeA = "a" Then

'                        dpOff.Add(Math.Min(dpOff(dpOff.Count - 1) + (X * cnt), dpOn(dpOn.Count - 1) + Z + (X * cnt)))
'                        dpOn.Add(Math.Min(dpOn(dpOn.Count - 1) + (Y * cnt), dpOff(dpOff.Count - 2) + Z + (Y * cnt)))

'                    Else
'                        dpOff.Add(Math.Min(dpOff(dpOff.Count - 1) + (Y * cnt), dpOn(dpOn.Count - 1) + Z + (Y * cnt)))
'                        dpOn.Add(Math.Min(dpOn(dpOn.Count - 1) + (X * cnt), dpOff(dpOff.Count - 2) + Z + (X * cnt)))

'                    End If
'                End If

'                isFirst = False
'                cnt = 0
'            End If

'            cnt += 1



'            beforeA = tempA
'        Next

'        If isFirst Then
'            If beforeA = "a" Then
'                dpOff.Add(X * cnt)
'                dpOn.Add((Y * cnt) + Z)
'            Else
'                dpOff.Add(Y * cnt)
'                dpOn.Add((X * cnt) + Z)
'            End If
'        Else
'            If beforeA = "a" Then

'                dpOff.Add(Math.Min(dpOff(dpOff.Count - 1) + (X * cnt), dpOn(dpOn.Count - 1) + Z + (X * cnt)))
'                dpOn.Add(Math.Min(dpOn(dpOn.Count - 1) + (Y * cnt), dpOff(dpOff.Count - 2) + Z + (Y * cnt)))

'            Else
'                dpOff.Add(Math.Min(dpOff(dpOff.Count - 1) + (Y * cnt), dpOn(dpOn.Count - 1) + Z + (Y * cnt)))
'                dpOn.Add(Math.Min(dpOn(dpOn.Count - 1) + (X * cnt), dpOff(dpOff.Count - 2) + Z + (X * cnt)))

'            End If
'        End If



'        Console.WriteLine(Math.Min(dpOff(dpOff.Count - 1), dpOn(dpOn.Count - 1)).ToString)

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



