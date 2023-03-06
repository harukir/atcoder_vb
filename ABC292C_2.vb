'https://atcoder.jp/contests/abc292/tasks/abc292_c
'解法を見て実装。AC。

Imports System
Imports System.IO
Imports System.Text

Public Class pg

    Shared Sub Main()

        Dim N As Integer = Integer.Parse(Console.ReadLine())

        Dim result As Integer = 0

        For i As Integer = 1 To N

            Dim lCnt As Integer = kosuuCalc(i)
            Dim rCnt As Integer = kosuuCalc(N - i)

            result += (lCnt * rCnt)

        Next

        Console.WriteLine(result.ToString)

    End Sub


    Private Shared Function kosuuCalc(ByVal x As Integer) As Integer

        Dim result As Integer

        For i As Integer = 1 To x

            '今回1番目からウロコが落ちた所。
            'xが16の場合、積が16となる2つの数の組み合わせは「1*16、2*8、4*4、8*2、16*1」の5個。「4*4」を境に、左辺と右辺を入れ替わっていっているので、
            'ループは√x以下で回せばいい。
            If x < (i * i) Then Exit For

            If x Mod i = 0 Then
                result += 1
                If (i * i) <> x Then result += 1
            End If

        Next

        Return result

    End Function

End Class
