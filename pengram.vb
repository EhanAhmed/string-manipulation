Module Module1

    Sub Main()
        Dim str1, Alphastr As String
        Dim nextchar As Char
        Dim count As Integer
        Dim ispangram As Boolean

        str1 = ""
        Alphastr = "abcdefghijklmnopqrstuvwxyz"
        nextchar = ""
        count = 0
        ispangram = True

        Console.WriteLine("enterstring")
        str1 = Console.ReadLine
        str1 = LCase(str1)

        For count = 1 To Len(Alphastr)
            nextchar = Mid(Alphastr, count, 1)
            If InStr(str1, nextchar) = 0 Then
                ispangram = False
                Exit For
            End If

        Next

        If ispangram = True Then
            Console.WriteLine("statement is pengram")
        Else
            Console.WriteLine("statement is not pengram")
        End If
        Console.ReadKey()

    End Sub

End Module
