''https://atcoder.jp/contests/abs/tasks/abc081_b
'
'imports System
'
'Public Class pg
'
'    Shared Sub Main()
'
'        dim n as integer = integer.parse(Console.ReadLine())
'
'        dim aList as integer() = (from s as string in Console.ReadLine().split(" ") select integer.parse(s)).toarray
'
'        dim cnt as integer = 0
'
'        for i as integer = 0 to 1 step 0
'
'            if not (from ii as integer in aList where (ii mod (2 ^ (cnt+1))) = 0).tolist.count.equals(n) then
'                Console.WriteLine(cnt.tostring)
'                exit sub
'            end if
'
'            cnt += 1
'
'        next
'
'    End Sub
'
'End Class
