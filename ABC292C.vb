''https://atcoder.jp/contests/abc292/tasks/abc292_c
''�����Ȃ������B�T���v���ɂ����Ă�wa�������邵�A��o������TLE����������B
''�T���v���̏o�͌덷���A��2�ł���3�ł��u8�v������(���͂̐��l�ŕϓ����Ȃ�����)�̂��C�ɂȂ�B

'Imports System
'Imports System.IO
'Imports System.Text

'Public Class pg

'    Shared Sub Main()

'        Dim N As Integer = Integer.Parse(Console.ReadLine())

'        Dim result As Integer = 0

'        '(N-1)/2 ��؂�̂Ă������[�v����
'        For i As Integer = 1 To Math.Floor((N - 1) / 2)

'            Dim lCnt As Integer = kosuuCalc(i)
'            Dim rCnt As Integer = kosuuCalc(N - i)

'            result += (lCnt * rCnt)

'        Next

'        result *= 2

'        '�����̏ꍇ�A�Ō�Ɂun/2:n/2�v���Z�o(N��8�Ȃ�u4:4�v���Z�o)
'        If (N Mod 2).Equals(0) Then

'            '���𓚊m�F��ǋL�F�𓚂�wa���o�Ă��������͂����B�ukosuuCalc(N / 2) * 2�v�łȂ��umath.pow(kosuuCalc(N / 2),2)�v
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
