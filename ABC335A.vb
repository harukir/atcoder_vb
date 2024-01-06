''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Module pg

'    Sub Main()

'        Dim S As String = in_s()
'        'Dim N As Decimal = in_d()

'        'Dim argS As String() = in_sAry()
'        'Dim argD As Decimal() = in_dAry()



'        Console.WriteLine(S.Substring(0, S.Length - 1) & "4")

'    End Sub






'#Region "ライブラリ"

'#Region "union find"
'    Class unionfind

'        'union by rank未実装

'        ''' <summary>親リスト</summary>
'        Public par As List(Of Decimal)

'        ''' <summary>深さ(union by rank未実装なので、現状意味のないリスト)</summary>
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
'    ''' 二分探索
'    ''' </summary>
'    ''' <param name="ary"></param>
'    ''' <param name="key"></param>
'    ''' <returns>
'    ''' aryの中からkeyの値で二分探索を行う。
'    ''' 戻り値はReturn部のコメント参照
'    ''' 参考URL：https://qiita.com/drken/items/97e37dd6143e33a64c8c
'    ''' </returns>
'    Function binarySearch(ary As Decimal(), key As Decimal) As Decimal

'        Dim L As Decimal = -1 '「index = 0」が条件を満たすこともあるので、初期値は -1
'        Dim R As Decimal = ary.Count '「index = a.size()-1」が条件を満たさないこともあるので、初期値は a.size()

'        ' どんな二分探索でもここの書き方を変えずにできる！
'        While (R - L > 1)

'            Dim M As Decimal = Math.Truncate(L + (R - L) / 2)

'            If ary(M) >= key Then
'                R = M
'            Else
'                L = M
'            End If
'        End While

'        'L は「key未満(key含まない)の内、最大の値(リストに該当値が無ければ-1)」、R は「key以上(key含む)の内、最小の値(リストに該当値が無ければ-1)」となる
'        'Return L
'        Return If(R <= ary.Count - 1, R, -1)

'    End Function
'    ''' <summary>
'    ''' 二分探索
'    ''' </summary>
'    ''' <param name="ary"></param>
'    ''' <param name="key"></param>
'    ''' <returns></returns>
'    Function binarySearch(ary As List(Of Decimal), key As Decimal) As Decimal
'        Return binarySearch(ary.ToArray, key)
'    End Function


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

