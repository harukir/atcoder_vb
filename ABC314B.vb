''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text
'Imports System.Xml

'Module pg

'    Sub Main()

'        'Dim S As String = in_s()
'        Dim N As Decimal = in_d()

'        'Dim argS As String() = in_sAry()
'        'Dim argD As Decimal() = in_dAry()

'        Dim deme2Person As New Dictionary(Of Decimal, HashSet(Of Decimal))
'        For i As Decimal = 0 To 37
'            deme2Person.Add(i, New HashSet(Of Decimal))
'        Next

'        Dim person2Betcnt As New Dictionary(Of Decimal, Decimal)

'        For i As Decimal = 1 To N

'            Dim C As Decimal = in_d()
'            Dim A As Decimal() = in_dAry()

'            person2Betcnt.Add(i, C)

'            For j As Decimal = 0 To C - 1
'                deme2Person(A(j)).Add(i)
'            Next
'        Next

'        Dim X As Decimal = in_d()

'        Dim r As New List(Of Decimal)
'        Dim minCnt As Decimal = 40

'        For Each p As Decimal In deme2Person(X)
'            If person2Betcnt(p) < minCnt Then
'                r.Clear()
'                r.Add(p)
'                minCnt = person2Betcnt(p)
'            ElseIf person2Betcnt(p) = minCnt Then
'                r.Add(p)
'            End If
'        Next

'        r.Sort()

'        Dim rr As String = String.Join(" ", r.ToArray)

'        Console.WriteLine(r.Count.ToString)
'        Console.WriteLine(rr.Trim)

'    End Sub







'#Region "ライブラリ"

'#Region "union find"
'    Class unionfind

'        'union by rank未実装

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



