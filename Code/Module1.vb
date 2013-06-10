Imports FizzBuzz.API.FizzBuzzMachine
Imports FizzBuzz.Model.Output

Module Module1

    Sub Main()

        Console.WriteLine("Original FizzBuzz.  3=Fizz 5=Buzz 3&5=FizzBuzz")
        OriginalFizzBuzz()
        Console.Write("Press Enter to continue program:")
        Console.ReadLine()


        Console.WriteLine(vbCrLf & vbCrLf & "Extened FizzBuzz.  Take Home Asssignment.  6=Frog 17=Dog 37=Chicken")
        ExtendedFizzBuzz()
        Console.Write("Press Enter to continue program:")
        Console.ReadLine()

        Console.WriteLine(vbCrLf & vbCrLf & "More Patterns FizzBuzz.  Find Prime numbers instead of divisible.")
        PrimePattern()
        Console.Write("Press Enter to continue program:")
        Console.ReadLine()

        Console.WriteLine(vbCrLf & vbCrLf & "Multiple Patterns Mixed Together.  Prime=Prime 3=Fizz 5=Buzz")
        MixedPatterns()

        Console.Write("Press Enter to end program:")
        Console.ReadLine()
    End Sub


    Public Sub OriginalFizzBuzz()
        Dim patternList As New List(Of IPattern)
        patternList.Add(New DivisiblePattern(3, "Fizz"))
        patternList.Add(New DivisiblePattern(5, "Buzz"))

        Dim fizzBuzz As New FizzBuzzMachine(1, 15, patternList, New ConsoleOutput)
        fizzBuzz.Start()

    End Sub

    Public Sub ExtendedFizzBuzz()
        Dim patternList As New List(Of IPattern)
        patternList.Add(New DivisiblePattern(6, "Frog"))
        patternList.Add(New DivisiblePattern(17, "Dog"))
        patternList.Add(New DivisiblePattern(37, "Chicken"))

        Dim fizzBuzz As New FizzBuzzMachine(3754, 3775, patternList, New ConsoleOutput)
        fizzBuzz.Start()
    End Sub

    Public Sub PrimePattern()
        Dim patternList As New List(Of IPattern)
        patternList.Add(New PrimePattern("Prime"))

        Dim fizzBuzz As New FizzBuzzMachine(1, 10, patternList, New ConsoleOutput)
        fizzBuzz.Start()
    End Sub

    Public Sub MixedPatterns()
        Dim patternList As New List(Of IPattern)
        patternList.Add(New PrimePattern("Prime"))
        patternList.Add(New DivisiblePattern(3, "Fizz"))
        patternList.Add(New DivisiblePattern(5, "Buzz"))

        Dim fizzBuzz As New FizzBuzzMachine(1, 15, patternList, New ConsoleOutput)
        fizzBuzz.Start()
    End Sub
End Module


