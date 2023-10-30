Module _1D_Array_of_100
    Sub Main()
        ' Initializing my array
        Dim random_number As New Random()
        'Array 99 = 100 indexes
        Dim my_array(99) As Integer
        'count for display purpose : Number #'count'
        Dim count As Integer = 1
        'count each number starting at 0
        Dim num1 As Integer = 0
        Dim num2 As Integer = 0
        Dim num3 As Integer = 0
        Dim num4 As Integer = 0
        Dim num5 As Integer = 0
        Dim num6 As Integer = 0
        Dim num7 As Integer = 0
        Dim num8 As Integer = 0
        Dim num9 As Integer = 0
        Dim num10 As Integer = 0
        Dim num11 As Integer = 0
        Dim num12 As Integer = 0

        Console.WriteLine("**********************************************************")
        Console.WriteLine("***************   RANDOM NUMBERS! ************************")
        Console.WriteLine("**********************************************************")
        'Starting a loop (100)
        For i As Integer = 0 To my_array.Length - 1
            my_array(i) = random_number.Next(1, 13)
            Console.WriteLine("Number #" & count & ": " & my_array(i))
            count += 1

            'Select Case to count each number
            Select Case my_array(i)
                Case 1
                    num1 += 1
                Case 2
                    num2 += 1
                Case 3
                    num3 += 1
                Case 4
                    num4 += 1
                Case 5
                    num5 += 1
                Case 6
                    num6 += 1
                Case 7
                    num7 += 1
                Case 8
                    num8 += 1
                Case 9
                    num9 += 1
                Case 10
                    num10 += 1
                Case 11
                    num11 += 1
                Case 12
                    num12 += 1
            End Select

        Next

        'Display the count of each number
        Console.WriteLine()
        Console.WriteLine("**********************************************************")
        Console.WriteLine("*************   COUNT OF EACH NUMBER *********************")
        Console.WriteLine("**********************************************************")
        Console.WriteLine("Number 1: " & num1)
        Console.WriteLine("Number 2: " & num2)
        Console.WriteLine("Number 3: " & num3)
        Console.WriteLine("Number 4: " & num4)
        Console.WriteLine("Number 5: " & num5)
        Console.WriteLine("Number 6: " & num6)
        Console.WriteLine("Number 7: " & num7)
        Console.WriteLine("Number 8: " & num8)
        Console.WriteLine("Number 9: " & num9)
        Console.WriteLine("Number 10: " & num10)
        Console.WriteLine("Number 11: " & num11)
        Console.WriteLine("Number 12: " & num12)

        'Sum of all the count (Should equal 100)
        Console.WriteLine()
        Console.WriteLine("**********************************************************")
        Console.WriteLine("*************   VERIFICATION *********************")
        Console.WriteLine("**********************************************************")
        Console.WriteLine("Sum of the count of each number: " & num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12)

        Console.ReadKey()
    End Sub
End Module
