''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Module pg

'    Dim r As Decimal


'    Sub Main()

'        r = 0

'        Dim argD As Decimal() = in_dAry()
'        Dim N As Decimal = argD(0)
'        Dim T As Decimal = argD(1)
'        Dim M As Decimal = argD(2)

'        Dim NGpair As New List(Of List(Of Decimal))

'        For i As Decimal = 0 To M - 1
'            NGpair.Add(New List(Of Decimal)(in_dAry))
'        Next


'        Dim teamDic As New Dictionary(Of Decimal, HashSet(Of Decimal))
'        For i As Decimal = 0 To T - 1
'            teamDic.Add(i, New HashSet(Of Decimal))
'        Next


'        Dim llll As New List(Of Dictionary(Of Decimal, HashSet(Of Decimal)))
'        dfs(teamDic, N, NGpair, T, 1)


'        Console.WriteLine((r).ToString)

'    End Sub


'    Sub dfs(teamDic As Dictionary(Of Decimal, HashSet(Of Decimal)), N As Decimal, NGPair As List(Of List(Of Decimal)), T As Decimal, ByVal nowMember As Decimal)

'        If nowMember > N Then


'            For Each h As HashSet(Of Decimal) In teamDic.Values

'                If h.Count = 0 Then Return

'                For i As Decimal = 0 To NGPair.Count - 1
'                    If h.Contains(NGPair(i)(0)) AndAlso h.Contains(NGPair(i)(1)) Then Return
'                Next

'            Next

'            r += 1
'            Return

'        End If

'        For i As Decimal = 0 To T - 1

'            teamDic(i).Add(nowMember)
'            dfs(teamDic, N, NGPair, T, nowMember + 1)
'            teamDic(i).Remove(nowMember)
'        Next

'        Dim aaaa = ""

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



