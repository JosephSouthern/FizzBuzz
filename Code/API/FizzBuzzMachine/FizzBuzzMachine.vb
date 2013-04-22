Imports FizzBuzz.Model.Output

Namespace API.FizzBuzzMachine
    Public Class FizzBuzzMachine
        Private ReadOnly _startRange As Integer
        Private ReadOnly _endRange As Integer
        Private ReadOnly _output As IOutput
        Private ReadOnly _patterns As List(Of IPattern)

        Public Sub New(ByVal startRange As Integer, ByVal endRange As Integer, ByVal patterns As List(Of IPattern), ByVal output As IOutput)
            If startRange > endRange Then Throw New Exception("Start Range must be less than end range.")

            _startRange = startRange
            _endRange = endRange
            _patterns = patterns
            _output = output
        End Sub

        Public Sub Start()
            For i = _startRange To _endRange
                Dim result As String = ""

                For Each p In _patterns
                    If p.MatchesCriteria(i) Then
                        result = result & p.OutputValue()
                    End If
                Next

                If result = "" Then result = i.ToString()

                _output.Write(result)

            Next
        End Sub

    End Class
End Namespace