Imports FizzBuzz.API.FizzBuzzMachine
Imports NUnit.Framework

Namespace Tests.API.PatternsTests
    <TestFixture()> _
    Public Class PrimeTest
        Private _primePattern As PrimePattern

        <SetUp()> _
        Public Sub SetUp()
            _primePattern = New PrimePattern("PRIME")
        End Sub

        <Test()> _
        Public Sub ShouldReturnTrueWhenPrime()
            Assert.AreEqual(True, _primePattern.MatchesCriteria(2))
            Assert.AreEqual(True, _primePattern.MatchesCriteria(3))
            Assert.AreEqual(True, _primePattern.MatchesCriteria(5))
            Assert.AreEqual(True, _primePattern.MatchesCriteria(7))
            Assert.AreEqual(True, _primePattern.MatchesCriteria(11))
            Assert.AreEqual(True, _primePattern.MatchesCriteria(13))
            Assert.AreEqual(True, _primePattern.MatchesCriteria(17))
            Assert.AreEqual(True, _primePattern.MatchesCriteria(19))
            Assert.AreEqual(True, _primePattern.MatchesCriteria(23))
            Assert.AreEqual(True, _primePattern.MatchesCriteria(29))
            Assert.AreEqual(True, _primePattern.MatchesCriteria(31))
            Assert.AreEqual(True, _primePattern.MatchesCriteria(37))
            Assert.AreEqual(True, _primePattern.MatchesCriteria(3571))
        End Sub

        <Test()> _
        Public Sub ShouldReturnFalseWhenNotPrime()
            Assert.AreEqual(False, _primePattern.MatchesCriteria(6))
        End Sub


    End Class

End Namespace