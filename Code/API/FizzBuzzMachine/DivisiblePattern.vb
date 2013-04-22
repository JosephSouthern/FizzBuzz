Namespace API.FizzBuzzMachine
    Public Class DivisiblePattern
        Implements IPattern

        Private ReadOnly _divisor As Integer
        Private ReadOnly _outputValue As String

        Public Sub New(ByVal divisor As Integer, ByVal outputValue As String)
            _divisor = divisor
            _outputValue = outputValue
        End Sub

        Public Function MatchesCriteria(ByVal i As Integer) As Boolean Implements IPattern.MatchesCriteria
            If i Mod _divisor = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function OutputValue() As String Implements IPattern.OutputValue
            Return _outputValue
        End Function
    End Class
End Namespace