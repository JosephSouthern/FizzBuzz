Imports FizzBuzz.API.FizzBuzzMachine
Imports NUnit.Framework
Imports FizzBuzz.Model.Output
Imports Rhino.Mocks

Namespace Tests.API.FizzBuzzMachineTests

    <TestFixture()> _
    Public Class WhenStartingFizzBuzzMachine
        Inherits TestFizzBuzzMachine

        <SetUp()> _
        Public Sub Setup()
            BeforeEach()

            Machine = New FizzBuzzMachine(StartRange, EndRange, PatternList, Output)
            Machine.Start()

        End Sub

        <Test()> _
        Public Sub AllPatternCriteriaShouldBeCalled()
            For i = StartRange To EndRange
                Dim value As Integer = i
                Pattern1.AssertWasCalled(Function(s) s.MatchesCriteria(value))
                Pattern2.AssertWasCalled(Function(s) s.MatchesCriteria(value))
            Next
        End Sub

        <Test()> _
        Public Sub WriteWasCalledEachTime()
            For i = StartRange To EndRange
                Dim value = i
                Output.AssertWasCalled(Function(x) x.Write(value.ToString()))
            Next
        End Sub


    End Class


    Public Class TestFizzBuzzMachine
        Protected Pattern1 As IPattern
        Protected Pattern2 As IPattern
        Protected PatternList As List(Of IPattern)
        Protected Machine As FizzBuzzMachine
        Protected Output As IOutput
        Protected StartRange As Integer = 1
        Protected EndRange As Integer = 100

        Public Sub BeforeEach()
            Pattern1 = MockRepository.GenerateMock(Of IPattern)()
            Pattern2 = MockRepository.GenerateMock(Of IPattern)()


            PatternList = New List(Of IPattern)
            PatternList.Add(Pattern1)
            PatternList.Add(Pattern2)

            Output = MockRepository.GenerateMock(Of IOutput)()


        End Sub

    End Class

End Namespace