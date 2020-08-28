Imports System.Linq.Expressions

Module TrappingErrors

    Sub Main()
        Dim userInput As String
        Dim userNumber As Integer

        Do
            Try
                Console.WriteLine("Please type a number and press enter. Enter Q to quit.")
                userInput = Console.ReadLine()
                userNumber = CInt(userInput)
            Catch ex As InvalidCastException
                Console.WriteLine("I asked for a number you entered: " & userInput)
            Catch ex As OverflowException
                Console.WriteLine("Sorry, the number you entered is too big")

                Console.WriteLine(userInput & " + 5 is: ")
                Console.WriteLine(userNumber + 5)
                Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("You broke it")
                Console.WriteLine(ex.Message)
            End Try
        Loop Until userInput = "Q" Or userInput = "q"
    End Sub

End Module
