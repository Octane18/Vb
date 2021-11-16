Module Module1

    Sub Main()
        Dim Str1 As String
        Dim thisChar, Char1 As Char
        Dim Count, CharCount, alphaCount, digitCount, specialCount As Integer

        Str1 = ""
        thisChar = ""
        Char1 = ""
        CharCount = 0
        alphaCount = 0
        digitCount = 0
        specialCount = 0

        Console.Write("Enter Str1 : ")
        Str1 = Console.ReadLine
        Console.Write("Enter character to search for : ")
        Char1 = Console.ReadLine

        For Count = 1 To Str1.Length
            thisChar = Mid(Str1, Count, 1)
            If thisChar = Char1 Then
                CharCount = CharCount + 1
            ElseIf Asc(thisChar) >= 65 And Asc(thisChar) <= 90 Or Asc(thisChar) >= 97 And Asc(thisChar) <= 122 Then
                alphaCount = alphaCount + 1
            ElseIf Asc(thisChar) >= 48 And Asc(thisChar) <= 57 Then
                digitCount = digitCount + 1
            Else : specialCount = specialCount + 1
            End If
NEXT
        Console.WriteLine("Amount of times the character occured : " & CharCount)
        Console.WriteLine("alphabet count : " & alphaCount)
        Console.WriteLine("digit count : " & digitCount)
        Console.WriteLine("other character count : " & specialCount)
        Console.ReadKey()
    End Sub

End Module
