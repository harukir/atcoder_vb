'https://atcoder.jp/contests/abc292/tasks/abc292_c
'��@�����Ď����BAC�B

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

            '����1�Ԗڂ���E���R�����������B
            'x��16�̏ꍇ�A�ς�16�ƂȂ�2�̐��̑g�ݍ��킹�́u1*16�A2*8�A4*4�A8*2�A16*1�v��5�B�u4*4�v�����ɁA���ӂƉE�ӂ����ւ���Ă����Ă���̂ŁA
            '���[�v�́�x�ȉ��ŉ񂹂΂����B
            If x < (i * i) Then Exit For

            If x Mod i = 0 Then
                result += 1
                If (i * i) <> x Then result += 1
            End If

        Next

        Return result

    End Function

End Class
