Module Module1

    Sub Main()

        Dim Str1, Newstr, repchar, repwith, thischar As String

        Dim count As Integer


        Str1 = ""
        Newstr = ""
        repchar = ""
        repwith = ""
        thischar = ""
        count = 0


        Console.WriteLine("Enter string:")
        Str1 = Console.ReadLine()

        Console.Write("Enter char:")
        repchar = Console.ReadLine()

        Console.Write("Enter new char :")
        repwith = Console.ReadLine()

           For Counter = 1 To Len(Str1)
            thischar = Mid(Str1, Counter, 1)
            If thischar = repchar Then
                thischar = repwith
            End If
            Newstr = Newstr & thischar
        Next
        Console.WriteLine("newstring=" & Newstr)
        Console.ReadKey()


    End Sub

End Module

