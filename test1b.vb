Module Module1

    Sub Main()
        Dim binarynumber As String
        Dim lengthofstr As Integer
        Dim nextchar As Char
        Dim denaryvalue As Integer
        Dim count As Integer
        Dim str1 As String
        Dim str2 As String
        Dim validbinarynumber As Boolean
        Dim char2 As Char


        binarynumber = ""
        denaryvalue = 0
        count = 0
        lengthofstr = 0
        nextchar = ""
        str1 = ""
        str2 = ""
        validbinarynumber = True
        char2 = ""

        Console.Write("enter a binary string: ")
        binarynumber = Console.ReadLine

        For count = binarynumber To 1 Step -1
            char2 = Mid(binarynumber, count, 1)
            str1 = str1 & char2
        Next

        For count = binarynumber To 1 Step -1
            nextchar = Mid(str1, count, 1)
            denaryvalue = denaryvalue + (2 ^ count * nextchar) / 2

        Next
        Console.WriteLine(denaryvalue)

        End If







    End Sub

End Module
