''https://atcoder.jp/contests/abs/tasks/abc087_b

'Imports System

'Public Class pg

'    Private Shared matchPrice As Integer
'    Private Shared coinList As List(Of Integer)
'    Private Shared matchCount As Integer
'    Private Shared matchedPattern As List(Of List(Of Integer))


'    Shared Sub Main()

'        Dim a As Integer = Integer.Parse(Console.ReadLine())
'        Dim b As Integer = Integer.Parse(Console.ReadLine())
'        Dim c As Integer = Integer.Parse(Console.ReadLine())

'        matchPrice = Integer.Parse(Console.ReadLine())

'        coinList = New List(Of Integer)
'        matchedPattern = New List(Of List(Of Integer))
'        matchCount = 0


'        For i As Integer = 0 To a - 1
'            coinList.Add(500)
'        Next
'        For i As Integer = 0 To b - 1
'            coinList.Add(100)
'        Next
'        For i As Integer = 0 To c - 1
'            coinList.Add(50)
'        Next


'        Call recursionCalc(0)

'        Console.WriteLine(matchCount.ToString)

'    End Sub


'    Private Shared Sub recursionCalc(ByVal startIndex As Integer)

'        Dim targetCoins As New List(Of Integer)

'        For i As Integer = startIndex To coinList.Count - 1

'            targetCoins.Add(coinList(i))

'            If (Aggregate j As Integer In targetCoins Into Sum) > matchPrice Then Exit For

'            If isMatchedPattern(targetCoins) Then Exit For

'            addMatchCount(targetCoins)

'        Next

'        If startIndex < coinList.Count Then

'            recursionCalc(startIndex + 1)

'        End If

'    End Sub

'    Private Shared Sub addMatchCount(ByVal targetCoins As List(Of Integer))

'        If (Aggregate i As Integer In targetCoins Into Sum).Equals(matchPrice) Then
'            matchCount += 1
'            matchedPattern.Add(New List(Of Integer)(targetCoins))
'        End If

'    End Sub

'    ''' <summary>
'    ''' 過去使用したパターンか判定
'    ''' </summary>
'    ''' <param name="targetCoins"></param>
'    ''' <returns></returns>
'    Private Shared Function isMatchedPattern(ByVal targetCoins As List(Of Integer)) As Boolean

'        Dim isMatch As Boolean

'        For Each p As List(Of Integer) In (From mp As List(Of Integer) In matchedPattern Where mp.Count.Equals(targetCoins.Count)).ToList

'            isMatch = True

'            For i As Integer = 0 To p.Count - 1

'                If Not targetCoins(i).Equals(p(i)) Then
'                    isMatch = False
'                    Exit For
'                End If

'            Next

'            If isMatch Then Return True

'        Next

'        Return False
'    End Function

'End Class
