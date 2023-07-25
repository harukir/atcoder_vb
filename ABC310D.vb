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


'        Dim tsm As New HashSet(Of Decimal)
'        Dim team As New List(Of Decimal)

'        dfs(tsm, team, N, 1, T, NGpair)


'        Console.WriteLine((r / 2).ToString)

'    End Sub


'    Sub dfs(teamShozokuMember As HashSet(Of Decimal), team As List(Of Decimal), N As Decimal, nowT As Decimal, T As Decimal, NGPair As List(Of List(Of Decimal)))


'        If nowT = T OrElse team.Count = N Then

'            Dim teamMember As New HashSet(Of Decimal)
'            Dim nextTSM As New HashSet(Of Decimal)(teamShozokuMember)

'            If nowT = T Then
'                For i As Decimal = 1 To N

'                    If Not teamShozokuMember.Contains(i) Then teamMember.Add(i)
'                Next
'            Else

'                For i As Decimal = 1 To team.Count
'                    If team(i - 1) = 1 Then
'                        teamMember.Add(i)
'                        nextTSM.Add(i)
'                    End If
'                Next
'            End If


'            If teamMember.Count = 0 Then Return

'            For i As Decimal = 0 To NGPair.Count - 1
'                If teamMember.Contains(NGPair(i)(0)) AndAlso teamMember.Contains(NGPair(i)(1)) Then Return
'            Next

'            If nowT = T Then
'                r += 1
'                Return
'            End If

'            dfs(nextTSM, New List(Of Decimal), N, nowT + 1, T, NGPair)

'            Return

'        End If

'        For i As Decimal = 0 To 1

'            If i = 1 AndAlso teamShozokuMember.Contains(team.Count + 1) Then Continue For

'            team.Add(i)
'            dfs(teamShozokuMember, New List(Of Decimal)(team), N, nowT, T, NGPair)
'            team.RemoveAt(team.Count - 1)
'        Next


'    End Sub


'    Sub a(N As Decimal, T As Decimal, NGpair As List(Of List(Of Decimal)))

'        '一つ目のチームを作る


'    End Sub





'#Region "ライブラリ"

'#Region "入力受け取り"

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
'    ''' サンプルとしてABC309D(https://atcoder.jp/contests/abc309/tasks/abc309_d)で使用したBFSである「引数のグラフの中で、startPから最も遠い距離を返すBFS」を実装
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

'    ''' <summary>数値が素数であるか判定します。</summary>
'    ''' <param name="Number">対象の数値を指定します。</param>
'    ''' <returns>Numberが素数である場合Trueを返します。</returns>
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



