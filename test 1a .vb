Module Module1

    Sub Main()
        Dim binarynumber As String
        Dim validbinarystring As Boolean
        Dim count As Integer
        Dim nextchar As String

        binarynumber = ""
        validbinarystring = True
        count = 0
        nextchar = ""

        Console.WriteLine("enter binary number")
        binarynumber = Console.ReadLine


        For count = 1 To Len(binarynumber)
            If Len(binarynumber) <> 8 Then
                validbinarystring = False
            End If
        Next

        For count = 1 To Len(binarynumber)
            nextchar = Mid(binarynumber, count, 1)
            If nextchar <> 0 Or nextchar <> 1 Then
                validbinarystring = False

            End If

        Next

        If validbinarystring = True Then
            Console.Write("valid string")
        Else
            Console.Write("Invalid string")
        End If
    End Sub

End Module
