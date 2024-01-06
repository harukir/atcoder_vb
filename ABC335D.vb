''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Module pg

'    Sub Main()

'        'Dim S As String = in_s()
'        Dim N As Decimal = in_d()

'        'Dim argS As String() = in_sAry()
'        'Dim argD As Decimal() = in_dAry()

'        Dim grid As New List(Of List(Of String))

'        For i As Decimal = 0 To N - 1
'            grid.Add(New List(Of String))
'            For j As Decimal = 0 To N - 1
'                If (N + 1) / 2 = i + 1 AndAlso (N + 1) / 2 = j + 1 Then
'                    grid(i).Add("T")
'                Else
'                    grid(i).Add("0")
'                End If
'            Next
'        Next

'        Dim maxNum As Decimal = (N * N) - 1
'        Dim nowParts As Decimal = 1
'        Dim moveVec As String = "R"
'        Dim gridPosX As Decimal = 0
'        Dim gridPosY As Decimal = 0
'        Dim tempMoveCnt As Decimal = 0

'        Dim paddingDoneCntX As Decimal = 0
'        Dim paddingDoneCntY As Decimal = 0

'        While nowParts <= maxNum

'            grid(gridPosY)(gridPosX) = nowParts.ToString

'            nowParts += 1
'            tempMoveCnt += 1

'            Dim isVecChange As Boolean
'            If {"U", "D"}.Contains(moveVec) Then
'                isVecChange = tempMoveCnt >= (N - paddingDoneCntX)
'            Else
'                isVecChange = tempMoveCnt >= (N - paddingDoneCntY)
'            End If


'            If isVecChange Then
'                Select Case moveVec
'                    Case "U"
'                        moveVec = "R"
'                        paddingDoneCntY += 1
'                    Case "D"
'                        moveVec = "L"
'                        paddingDoneCntY += 1
'                    Case "L"
'                        moveVec = "U"
'                        paddingDoneCntX += 1
'                    Case "R"
'                        moveVec = "D"
'                        paddingDoneCntX += 1
'                End Select
'                tempMoveCnt = 0
'            End If

'            Select Case moveVec
'                Case "U" : gridPosY -= 1
'                Case "D" : gridPosY += 1
'                Case "L" : gridPosX -= 1
'                Case "R" : gridPosX += 1
'            End Select

'        End While

'        Dim r As New StringBuilder
'        For i As Decimal = 0 To N - 1
'            r.AppendLine(String.Join(Of String)(" ", grid(i)))
'        Next

'        Console.WriteLine(r.ToString.Trim)

'    End Sub






'#Region "���C�u����"

'#Region "union find"
'    Class unionfind

'        'union by rank������

'        ''' <summary>�e���X�g</summary>
'        Public par As List(Of Decimal)

'        ''' <summary>�[��(union by rank�������Ȃ̂ŁA����Ӗ��̂Ȃ����X�g)</summary>
'        Public rank As List(Of Decimal)

'        Sub New(ByVal itemCount As Decimal)

'            par = New List(Of Decimal)
'            rank = New List(Of Decimal)

'            For i As Decimal = 0 To itemCount
'                par.Add(i)
'                rank.Add(0)
'            Next
'        End Sub


'        Public Sub unite(ByVal x As Decimal, ByVal y As Decimal)

'            Dim rX As Decimal = root(x)
'            Dim rY As Decimal = root(y)

'            If rX = rY Then Return

'            par(rX) = rY

'            'If rank(rX) > rank(rY) Then
'            '    par(rY) = rX
'            'ElseIf rank(rX) < rank(rY) Then
'            '    par(rX) = rY
'            'Else
'            '    par(rX) = rY
'            '    rank(rX) += 1
'            'End If

'        End Sub

'        Public Function root(ByVal x As Decimal) As Decimal

'            If par(x) = x Then Return x

'            Dim rX As Decimal = root(par(x))

'            par(x) = rX

'            Return rX

'        End Function

'        Public Function isSame(ByVal x As Decimal, ByVal y As Decimal) As Boolean
'            Return root(x) = root(y)
'        End Function

'    End Class
'#End Region

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


'    Sub Fill(Of T)(lst As List(Of T), val As T, count As Decimal)
'        lst.Clear()
'        For i As Decimal = 0 To count - 1
'            lst.Add(val)
'        Next
'    End Sub

'    Function splitBlank(s As String) As List(Of String)

'        Dim r As New List(Of String)
'        For i As Decimal = 0 To s.Length - 1
'            r.Add(s.Substring(i, 1))
'        Next

'        Return r
'    End Function

'    Sub addDic(ByRef dic As Dictionary(Of Decimal, HashSet(Of Decimal)), ByVal key As Decimal, ByVal val As Decimal)

'        If dic.ContainsKey(key) Then
'            dic(key).Add(val)
'        Else
'            dic.Add(key, New HashSet(Of Decimal)({val}))
'        End If

'    End Sub

'    ''' <summary>
'    ''' �񕪒T��
'    ''' </summary>
'    ''' <param name="ary"></param>
'    ''' <param name="key"></param>
'    ''' <returns>
'    ''' ary�̒�����key�̒l�œ񕪒T�����s���B
'    ''' �߂�l��Return���̃R�����g�Q��
'    ''' �Q�lURL�Fhttps://qiita.com/drken/items/97e37dd6143e33a64c8c
'    ''' </returns>
'    Function binarySearch(ary As Decimal(), key As Decimal) As Decimal

'        Dim L As Decimal = -1 '�uindex = 0�v�������𖞂������Ƃ�����̂ŁA�����l�� -1
'        Dim R As Decimal = ary.Count '�uindex = a.size()-1�v�������𖞂����Ȃ����Ƃ�����̂ŁA�����l�� a.size()

'        ' �ǂ�ȓ񕪒T���ł������̏�������ς����ɂł���I
'        While (R - L > 1)

'            Dim M As Decimal = Math.Truncate(L + (R - L) / 2)

'            If ary(M) >= key Then
'                R = M
'            Else
'                L = M
'            End If
'        End While

'        'L �́ukey����(key�܂܂Ȃ�)�̓��A�ő�̒l(���X�g�ɊY���l���������-1)�v�AR �́ukey�ȏ�(key�܂�)�̓��A�ŏ��̒l(���X�g�ɊY���l���������-1)�v�ƂȂ�
'        'Return L
'        Return If(R <= ary.Count - 1, R, -1)

'    End Function
'    ''' <summary>
'    ''' �񕪒T��
'    ''' </summary>
'    ''' <param name="ary"></param>
'    ''' <param name="key"></param>
'    ''' <returns></returns>
'    Function binarySearch(ary As List(Of Decimal), key As Decimal) As Decimal
'        Return binarySearch(ary.ToArray, key)
'    End Function


'    ''' <summary>
'    ''' BFS
'    ''' �T���v���Ƃ���ABC309D(https://atcoder.jp/contests/abc309/tasks/abc309_d)�Ŏg�p����BFS�ł���u�����̃O���t�̒��ŁAstartP����ł�����������Ԃ�BFS�v������
'    ''' </summary>
'    ''' <param name="graph"></param>
'    ''' <param name="startP"></param>
'    ''' <returns></returns>
'    Function bfs(graph As Dictionary(Of Decimal, HashSet(Of Decimal)), startP As Decimal) As Decimal

'        Dim q As New Queue(Of Decimal)
'        q.Enqueue(startP)

'        Dim distance As New Dictionary(Of Decimal, Decimal)
'        distance.Add(startP, 0)

'        Dim maxDistance As Decimal = 0

'        While q.Count > 0

'            Dim p As Decimal = q.Dequeue

'            If Not graph.ContainsKey(p) Then Continue While

'            For Each pp As Decimal In graph(p)

'                If distance.ContainsKey(pp) Then Continue For

'                q.Enqueue(pp)

'                distance.Add(pp, distance(p) + 1)

'                maxDistance = Math.Max(maxDistance, distance(pp))

'            Next

'        End While

'        Return maxDistance

'    End Function

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
