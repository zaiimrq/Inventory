Namespace Facades
    Module Box
        Public Sub Danger(Message As String)
            MessageBox.Show(Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
        Public Sub Success(Message As String)
            MessageBox.Show(Message, "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Public Sub Warning(Message As String)
            MessageBox.Show(Message, "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Sub
        Public Function Question(Message As String) As DialogResult
            Return MessageBox.Show(Message, "Question !", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        End Function
    End Module
End Namespace
