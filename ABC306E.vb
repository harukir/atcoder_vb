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
'        Dim K As Decimal = argD(0)
'        Dim Q As Decimal = argD(0)

'        Dim A As New Dictionary(Of Decimal, Decimal)


'        'Dim calcNum As New HashSet(Of Decimal) '�v�Z�Ɏg�������̊Ǘ�
'        Dim calcNum As New Dictionary(Of Decimal, Decimal) '�v�Z�Ɏg�������ƌ��̊Ǘ�

'        Dim num2A As New Dictionary(Of Decimal, HashSet(Of Decimal)) '��������A�̊Ǘ�

'        Dim X As Decimal
'        Dim Y As Decimal

'        Dim tempMinVal As Decimal = 0 '�v�Z������A��ԏ�������

'        For i As Decimal = 0 To Q - 1

'            argD = in_dAry()
'            X = argD(0)
'            Y = argD(1)

'            Dim beforeAY As Decimal = If(A.ContainsKey(X), A(X), 0)

'            If num2A.ContainsKey(Y) AndAlso num2A(Y).Contains(X) Then
'                num2A(Y).Remove(X)
'            End If

'            If A.ContainsKey(X) Then
'                A.Add(X, Y)
'            Else
'                A(X) = Y
'            End If

'            If num2A.ContainsKey(Y) Then
'                num2A(Y).Add(X)
'            Else
'                num2A.Add(Y, New HashSet(Of Decimal)(1))
'            End If


'            '�����X�V����

'            Dim is1 As Boolean = tempMinVal < Y
'            Dim is2 As Boolean = calcNum.ContainsKey(A(X))
'            'Dim is22 As Boolean = 

'            If is1 OrElse is2 Then
'                If calcNum.ContainsKey(beforeAY) Then
'                    calcNum(beforeAY) -= 1
'                End If
'            End If

'            If is1 Then
'                '�@tempMinVal�������菬���������ꍇ�A��������ւ�
'                If calcNum(tempMinVal) <> 1 Then
'                    calcNum(tempMinVal) -= 1
'                Else
'                    calcNum.Remove(tempMinVal)
'                End If
'                If calcNum.ContainsKey(Y) Then
'                    calcNum(Y) += 1
'                Else
'                    calcNum.Add(Y, 1)
'                End If

'            ElseIf calcNum.ContainsKey(A(X)) Then
'                '�A���̗p���Ă��鐔��A���X�V���ꂽ�ꍇ

'                'Y�����g�p���Ă���������������Anum2A
'                If calcNum(X) >= num2A(Y).Count Then



'                Else

'                End If



'            End If






'            If i < K Then
'                If calcNum.ContainsKey(Y) Then
'                    calcNum(Y) += 1
'                Else
'                    calcNum.Add(, 1)
'                End If
'            End If




'            'Dim l As New List(Of Decimal)(num2A.Keys.ToList)
'            'l.Sort()




'        Next



'        Console.WriteLine()

'    End Sub

'    Sub dicAdd(dic As Dictionary(Of Decimal, Decimal), k As Decimal, v As Decimal)

'    End Sub





'#Region "���C�u����"

'#Region "���͎󂯎��"

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

'    ''' <summary>���l���f���ł��邩���肵�܂��B</summary>
'    ''' <param name="Number">�Ώۂ̐��l���w�肵�܂��B</param>
'    ''' <returns>Number���f���ł���ꍇTrue��Ԃ��܂��B</returns>
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



