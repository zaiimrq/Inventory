
Namespace Facades
    Module UniqCode
        Public Function BM() As String
            Return "BM" & (New Random).Next(100, 1000)
        End Function
        Public Function BK() As String
            Return "BK" & (New Random).Next(100, 1000)
        End Function
    End Module
End Namespace
