Module TrappingErrors

    Sub Main()
        Dim userInput As String
        Dim userNumber As Integer

        Try
            Console.WriteLine("Please type a number and press enter")
            userInput = Console.ReadLine()
            userNumber = CInt(userInput)
        Catch ex As InvalidCastException

            Console.WriteLine(userInput & " + 5 is: ")
            Console.WriteLine(userNumber + 5)
            Console.ReadLine()
        End Try
    End Sub

End Module
