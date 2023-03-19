''https://atcoder.jp/contests/abc293/tasks/abc293_c
''§ŒÀŽžŠÔ1•ª”¼Œã‚ÉACB‚Ù‚ñ‚Æ‚ÉƒMƒŠƒMƒŠŠÔ‚É‡‚í‚È‚¢‚Ì‰÷‚µ‚·‚¬‚½

'Imports System
'Imports System.IO
'Imports System.Runtime.CompilerServices
'Imports System.Text

'Public Class pg

'    Private Shared maxHMoveCnt As Integer
'    Private Shared maxWMoveCnt As Integer
'    Private Shared totalMoveCnt As Integer

'    Private Shared grid As List(Of String())

'    Private Shared result As Integer

'    Shared Sub Main()

'        Dim arg As String() = Console.ReadLine().Split(" ")
'        Dim H As Integer = Integer.Parse(arg(0))
'        Dim W As Integer = Integer.Parse(arg(1))

'        grid = New List(Of String())
'        For i As Integer = 0 To H - 1
'            grid.Add(Console.ReadLine().Split(" "))
'        Next

'        result = 0

'        maxHMoveCnt = H - 1
'        maxWMoveCnt = W - 1
'        totalMoveCnt = H - 1 + W - 1

'        Dim HMoveCnt As Integer = 0
'        Dim WMoveCnt As Integer = 0

'        Dim r As String = ""

'        rec(r, 0, 0)

'        Console.WriteLine(result.ToString)

'    End Sub


'    Private Shared Function rec(ByVal r As String, ByVal HMovedCount As Integer, ByVal WMovedcount As Integer) As Boolean


'        If (HMovedCount > maxHMoveCnt AndAlso WMovedcount = maxWMoveCnt) OrElse (HMovedCount = maxHMoveCnt AndAlso WMovedcount > maxWMoveCnt) Then
'            If judge(r) Then result += 1
'            Return True
'        End If

'        If HMovedCount > maxHMoveCnt OrElse WMovedcount > maxWMoveCnt Then Return False
'        r = r & grid(HMovedCount)(WMovedcount) & " "

'        Dim rrr As Boolean = rec(r, HMovedCount + 1, WMovedcount)
'        If Not rrr Then rec(r, HMovedCount, WMovedcount + 1)

'        Return False
'    End Function

'    Private Shared Function judge(ByVal r As String) As Boolean

'        Dim b As IEnumerable(Of String) = r.Trim.Split(" ").Distinct

'        Dim a As String() = b.ToArray

'        Return a.Count.Equals(r.Trim.Split(" ").Count)

'    End Function

'End Class
