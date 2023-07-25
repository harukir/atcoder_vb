''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Module pg

'    Sub Main()

'        Dim argD As Decimal() = in_dAry()
'        Dim N As Decimal = argD(0)
'        Dim M As Decimal = argD(1)

'        Dim shohin As New List(Of List(Of Decimal))
'        Dim shohinKinou As New Dictionary(Of Decimal, HashSet(Of Decimal))


'        For i As Decimal = 0 To N - 1

'            shohin.Add(New List(Of Decimal)(in_dAry))
'            shohin(i).RemoveAt(1)
'            Dim tempShohin As New List(Of Decimal)(shohin(i))
'            tempShohin.RemoveAt(0)

'            shohinKinou.Add(i, New HashSet(Of Decimal)(tempShohin))

'        Next


'        'iがjの上位互換かを調べる

'        Dim isjoigokan As Boolean = False
'        For i As Decimal = 0 To shohin.Count - 1



'            For j As Decimal = 0 To shohin.Count - 1

'                If i = j Then Continue For

'                If shohin(i)(0) > shohin(j)(0) Then Continue For

'                Dim tempIsJoigokan As Boolean = True

'                For Each k As Decimal In shohinKinou(j)

'                    If Not shohinKinou(i).Contains(k) Then
'                        tempIsJoigokan = False
'                        Exit For
'                    End If

'                Next

'                If Not tempIsJoigokan Then Continue For

'                If shohin(i)(0) = shohin(j)(0) AndAlso shohinKinou(i).Count = shohinKinou(j).Count Then Continue For

'                isjoigokan = True
'                Exit For

'            Next

'            If isjoigokan Then Exit For

'        Next

'        Console.WriteLine(If(isjoigokan, "Yes", "No"))

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



