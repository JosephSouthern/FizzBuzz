Namespace API.FizzBuzzMachine

    Public Class PrimePattern
        Implements IPattern

        Private ReadOnly _outputValue As String

        Public Sub New(ByVal outputValue As String)
            _outputValue = outputValue
        End Sub

        Public Function MatchesCriteria(ByVal value As Integer) As Boolean Implements IPattern.MatchesCriteria
            If value <= 1 Then Return False
            For i = 2 To value - 1
                If value Mod i = 0 Then
                    Return False
                End If
            Next
            Return True
        End Function

        Public Function OutputValue() As String Implements IPattern.OutputValue
            Return _outputValue
        End Function
    End Class

End Namespace