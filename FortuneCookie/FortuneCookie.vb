'Alexis Villagran
'RCET 2265
'Spring 2025
'WISDOMCOOKIE
'https://github.com/alxsvxn/FortuneCookie.git

Option Compare Text
Option Explicit On
Option Strict On
Module FortuneCookie
    Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim temp As Single
        Randomize()
        temp = Rnd()
        temp *= max - min
        temp += min
        Return CInt(temp)
    End Function
    Sub Main()
        Dim userInput As String
        Dim leave As Boolean = False

        Do
            Console.WriteLine("Welcome, Press ANY key then ENTER for your WISDOM!")
            Console.WriteLine("Or enter Q to EXIT")
            userInput = Console.ReadLine()
            leave = False
            Do

                If userInput = "Q" Then
                    leave = True
                End If

                Do While leave = False
                    Try
                        Select Case (RandomNumberBetween(1, 4))
                            Case 1
                                Console.WriteLine("The best thing about the future is that it comes one day at a time")
                                leave = True
                            Case 2
                                Console.WriteLine("Happiness is not something ready made. It comes from your own actions")
                                leave = True
                            Case 3
                                Console.WriteLine("A journey of a thousand miles begins with a single step")
                                leave = True
                            Case 4
                                Console.WriteLine("Don't cry because it's over. Smile because it happened.")
                                leave = True
                        End Select

                    Catch ex As Exception
                        'I don't think this try will have an exceptions since our the # will always be 1-4
                    End Try
                Loop

            Loop Until leave = True

        Loop While userInput <> "Q"

    End Sub

End Module
