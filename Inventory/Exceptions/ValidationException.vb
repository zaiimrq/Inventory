﻿Namespace Exceptions
    Public Class ValidationException
        Inherits Exception

        Public Sub New(Message As String)
            MyBase.New(Message)
        End Sub
    End Class
End Namespace