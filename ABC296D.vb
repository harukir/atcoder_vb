'

Imports System
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text

Public Class pg


    Shared Sub Main()

        Dim arg As String() = Console.ReadLine().Split(" ")
        Dim N As Double = Double.Parse(arg(0))
        Dim M As Double = Double.Parse(arg(1))

        If Math.Pow(N, 2) < M Then
            Console.WriteLine("-1")
            Exit Sub
        End If

        If N >= M Then
            Console.WriteLine(M.ToString)
            Exit Sub
        End If

        'If IsPrime(M) Then
        '    Console.WriteLine("-1")
        '    Exit Sub
        'End If

        Dim cnt As Double = M - 1

        Dim ssss As Double

        Dim aaaa As Double

        While 1 = 1

            cnt += 1

            'If IsPrime(cnt) Then Continue While

            ssss = Math.Truncate(Math.Sqrt(cnt))

            'aaaa = Math.Pow(ssss + 1, 2)

            'Dim h As New HashSet(Of Double)
            'For i As Double = cnt To aaaa - 1
            '    h.Add(i)
            'Next


            Dim aabb = Math.Ceiling(cnt / N)

            For i As Double = aabb To ssss
                If (cnt Mod i) = 0 AndAlso (cnt / i) <= N Then
                    Exit While
                End If
            Next

        End While


        Console.WriteLine(cnt.ToString)

    End Sub

    'Public Shared Function IsPrime(ByVal Number As Double) As Boolean
    '    Dim K As Long

    '    If Number < 2 Then
    '        Return False
    '    End If

    '    For K = 2 To CDbl(Math.Sqrt(Number))
    '        If Number Mod K = 0 Then
    '            Return False
    '        End If
    '    Next K

    '    Return True

    'End Function

End Class
