''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Module pg

'    Sub Main()

'        'Dim S As String = in_s()
'        Dim N As Decimal = in_d()

'        'Dim argS As String() = in_sAry()
'        Dim A As Decimal() = in_dAry()

'        'Dim h As New Dictionary(Of Decimal, List(Of Decimal))
'        Dim h As New Dictionary(Of Decimal, Queue(Of Decimal))

'        'For i As Decimal = 0 To A.Length - 1
'        '    If Not h.ContainsKey(A(i)) Then
'        '        h.Add(A(i), New List(Of Decimal)({i}))
'        '    Else
'        '        h(A(i)).Add(i)
'        '    End If
'        'Next

'        For i As Decimal = 0 To A.Length - 1
'            If Not h.ContainsKey(A(i)) Then
'                h.Add(A(i), New Queue(Of Decimal)({i}))
'            Else
'                h(A(i)).Enqueue(i)
'            End If
'        Next




'        Dim r As Decimal = 0
'        Dim calcedCnt As Decimal
'        Dim calcedIndex As New HashSet(Of Decimal)

'        For i As Decimal = 0 To N - 3

'            If calcedIndex.Contains(A(i)) Then Continue For

'            calcedCnt = 1

'            Dim tempL As New Queue(Of Decimal)(h(A(i)))

'            Dim fst As Decimal = tempL.Dequeue

'            Dim sadfads As Decimal = 0
'            Dim befo As Decimal = 0
'            Dim ccc As Decimal = 0

'            While 1 = 1
'                If tempL.Count < 1 Then Exit While

'                Dim k As Decimal = tempL.Dequeue

'                sadfads = befo + ((k - fst - 1) * calcedCnt)

'                r += sadfads

'                befo = sadfads
'                calcedCnt += 1

'                fst = k



'            End While

'            calcedIndex.Add(A(i))

'        Next

'        Console.WriteLine(r.ToString)

'    End Sub







'#Region "���C�u����"

'#Region "union find"
'    Class unionfind

'        'union by rank������

'        Public par As List(Of Decimal)
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



