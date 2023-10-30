Module Real_Time_Clock
    Sub Main()
        'Changing the color of the console
        Console.BackgroundColor = ConsoleColor.DarkBlue
        Console.ForegroundColor = ConsoleColor.White

        Do
            'Initializing my variables and assign values
            Dim currentDateTime As DateTime = Date.Now
            Dim dayOfWeek As String = currentDateTime.DayOfWeek.ToString()
            Dim currentDate As String = currentDateTime.ToShortDateString()
            Dim currentTime As String = currentDateTime.ToLongTimeString()

            ' Clear the console to apply the background color
            Console.Clear()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("                                                     DATE AND TIME")
            Console.WriteLine()
            Console.WriteLine("                                                     " & dayOfWeek)
            Console.WriteLine("                                                     " & currentDate)
            Console.WriteLine("                                                     " & currentTime)
            Console.WriteLine()

            ' Wait for 1 second
            System.Threading.Thread.Sleep(1000)

        Loop

        Console.ReadKey()

    End Sub
End Module
