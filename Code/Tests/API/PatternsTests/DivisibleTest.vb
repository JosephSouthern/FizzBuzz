Imports FizzBuzz.API.FizzBuzzMachine
Imports NUnit.Framework

Namespace Tests.API.PatternsTests
    <TestFixture()> _
    Public Class DivisibleTest
        Private _divisiblePattern As DivisiblePattern

        <SetUp()> _
        Public Sub Setup()
            _divisiblePattern = New DivisiblePattern(3, "Fizz")
        End Sub

        <Test()> _
        Public Sub ShouldReturnTrueWhenDivibleByDivisor()
            Assert.AreEqual(True, _divisiblePattern.MatchesCriteria(9))
        End Sub

        <Test()> _
        Public Sub ShouldReturnFalseWhenNotDivibleByDivisor()
            Assert.AreEqual(False, _divisiblePattern.MatchesCriteria(11))
        End Sub

    End Class
End Namespace