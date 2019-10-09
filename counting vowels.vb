Module Module1

    Sub Main()
        Dim str1 As String
        Dim vowel As String
        Dim counter As Integer
        Dim numberofvowels As Integer


        str1 = ""
        vowel = "aeiou"
        numberofvowels = 0
        counter = 0

        Console.WriteLine("enter string to check")
        str1 = Console.ReadLine

        str1 = LCase(str1)

        For count = 1 To Len(str1)
            If InStr(str1, Mid(vowel, count, 1)) Then
                numberofvowels = numberofvowels + 1
            End If
        Next
        console.writeline("numberofvowels")
        Console.ReadKey()
    End Sub

End Module
