Namespace Model.Output

    Public Class ConsoleOutput
        Implements IOutput

        Public Function Write(ByVal value As String) As Boolean Implements IOutput.Write
            Console.WriteLine(value)
            Return True
        End Function

    End Class
End Namespace