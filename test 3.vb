Module Module1

    Sub Main()
        Dim str1 As String
        Dim nextchar, highrepchar As Char
        Dim highrepcharcount, count As Integer
        Dim x As Integer

        str1 = ""
        nextchar = ""
        highrepchar = ""
        highrepcharcount = 0
        count = 0
        x = 0

        Console.WriteLine("Enter string")
        str1 = Console.ReadLine()

        str1 = UCase(str1)

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If InStr(str1, nextchar) <> 0 Then
                highrepcharcount = highrepcharcount + 1
            End If
            If highrepcharcount > x Then
                highrepchar = nextchar
            End If
            Console.WriteLine(highrepchar)
        Next






    End Sub

End Module
