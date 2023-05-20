'

Imports System
Imports System.Dynamic
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Text

Module pg

    Sub Main()

        'Dim S As String = in_s()
        'Dim N As Decimal = in_d()

        'Dim argS As String() = in_sAry()
        Dim argD As Decimal() = in_dAry()

        Dim N As Decimal = argD(0)
        Dim Q As Decimal = argD(1)

        Dim query As String()

        Dim ss As New Dictionary(Of Decimal, HashSet(Of Decimal))

        Dim ans As New StringBuilder

        For i As Decimal = 0 To Q - 1
            query = in_sAry()

            If query(0) = "1" Then

                Dim p1 As Decimal = Decimal.Parse(query(1))
                Dim p2 As Decimal = Decimal.Parse(query(2))

                If ss.ContainsKey(p1) Then
                    ss(p1).Add(p2)
                Else
                    ss.Add(p1, New HashSet(Of Decimal)({p2}.ToList))
                End If

                If ss.ContainsKey(p2) Then
                    ss(p2).Add(p1)
                Else
                    ss.Add(p2, New HashSet(Of Decimal)({p1}.ToList))
                End If

            End If

            If query(0) = "2" Then

                Dim p As Decimal = Decimal.Parse(query(1))

                If ss.ContainsKey(p) Then

                    Dim tempHash As New HashSet(Of Decimal)(ss(p))

                    For Each p2 As Decimal In tempHash

                        If ss.ContainsKey(p) Then ss.Remove(p)

                        If ss(p2).Contains(p) Then
                            ss(p2).Remove(p)
                            If ss(p2).Count = 0 Then ss.Remove(p2)
                        End If

                    Next
                End If

            End If

            ans.AppendLine((N - ss.Count).ToString)
        Next

        Console.WriteLine(ans.ToString)

    End Sub

    Function con(ByVal p1 As Decimal, ByVal p2 As Decimal) As String

        Return Math.Min(p1, p2).ToString & "," & Math.Max(p1, p2)

    End Function






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



