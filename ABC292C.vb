''https://atcoder.jp/contests/abc292/tasks/abc292_c
''解けなかった。サンプルにおいてもwa発生するし、提出したらTLEも発生する。
''サンプルの出力誤差が、例2でも例3でも「8」だった(入力の数値で変動しなかった)のが気になる。

'Imports System
'Imports System.IO
'Imports System.Text

'Public Class pg

'    Shared Sub Main()

'        Dim N As Integer = Integer.Parse(Console.ReadLine())

'        Dim result As Integer = 0

'        '(N-1)/2 を切り捨てた数ループする
'        For i As Integer = 1 To Math.Floor((N - 1) / 2)

'            Dim lCnt As Integer = kosuuCalc(i)
'            Dim rCnt As Integer = kosuuCalc(N - i)

'            result += (lCnt * rCnt)

'        Next

'        result *= 2

'        '偶数の場合、最後に「n/2:n/2」を算出(Nが8なら「4:4」を算出)
'        If (N Mod 2).Equals(0) Then

'            '★解答確認後追記：解答でwaが出ていた原因はここ。「kosuuCalc(N / 2) * 2」でなく「math.pow(kosuuCalc(N / 2),2)」
'            result += (kosuuCalc(N / 2) * 2)

'        End If




'        Console.WriteLine(result.ToString)

'        'Dim a = kosuuCalc(100)
'        'Dim b = 1

'    End Sub


'    Private Shared Function kosuuCalc(ByVal x As Integer) As Integer

'        If x = 1 Then Return 1

'        Dim result As Integer = 0
'        Dim isSame As Boolean = False
'        For i = 2 To x - 1

'            Dim divResult As Integer = Math.Floor(x / i)
'            Dim modResult As Integer = x Mod i

'            If modResult <> 0 Then Continue For

'            If divResult < i Then Exit For

'            If divResult.Equals(i) Then
'                isSame = True
'                Exit For
'            End If

'            result += 1


'        Next

'        Return (result * 2) + 2 + If(isSame, 1, 0)

'    End Function



'End Class
