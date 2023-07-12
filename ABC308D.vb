''

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Text

'Module pg

'    Sub Main()

'        Dim argD As Decimal() = in_dAry()
'        Dim H As Decimal = argD(0)
'        Dim W As Decimal = argD(1)

'        Dim S As New List(Of List(Of String))

'        For i As Decimal = 0 To H - 1
'            S.Add(splitBlank(in_s))
'        Next

'        Dim arrived As New HashSet(Of String)
'        Dim r As Boolean = dfs(S, arrived, 0, 0, 0)


'        Console.WriteLine(If(r, "Yes", "No"))

'    End Sub

'    Function dfs(s As List(Of List(Of String)), arrived As HashSet(Of String), h As Decimal, w As Decimal, moveCntMod As Decimal) As Boolean

'        Dim moveStr As String = ""
'        Select Case moveCntMod
'            Case 0 : moveStr = "s"
'            Case 1 : moveStr = "n"
'            Case 2 : moveStr = "u"
'            Case 3 : moveStr = "k"
'            Case 4 : moveStr = "e"
'        End Select

'        If Not s(h)(w) = moveStr Then Return False

'        arrived.Add(h.ToString & "," & w.ToString)

'        If h = s.Count - 1 AndAlso w = s(0).Count - 1 Then Return True

'        Dim nextMoveCntMod As Decimal = (moveCntMod + 1) Mod 5
'        Dim nextH As Decimal
'        Dim nextW As Decimal
'        For i As Decimal = 0 To 3
'            nextH = h
'            nextW = w

'            Select Case i
'                Case 0 : nextH -= 1
'                Case 1 : nextH += 1
'                Case 2 : nextW -= 1
'                Case 3 : nextW += 1
'            End Select

'            If arrived.Contains(nextH.ToString & "," & nextW.ToString) Then Continue For

'            If nextH < 0 OrElse nextW < 0 OrElse nextH >= s.Count OrElse nextW >= s(0).Count Then Continue For

'            If dfs(s, arrived, nextH, nextW, nextMoveCntMod) Then Return True

'        Next

'        Return False

'    End Function


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



