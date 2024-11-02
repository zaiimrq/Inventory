Imports Inventory.DataTransfersObjects
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Services

Public Class FormSignIn
    Private Service As New UserService
    Private Sub LinkLabelZaiimrq_Click(sender As Object, e As EventArgs) Handles LinkLabelZaiimrq.Click
        Try
            Process.Start(New ProcessStartInfo With {
                .FileName = "https://instagram.com/zaiimrq",
                .UseShellExecute = True
             })

        Catch ex As Exception
            Box.Danger(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabelSan_Click(sender As Object, e As EventArgs) Handles LinkLabelSan.Click
        Try
            Process.Start(New ProcessStartInfo With {
                .FileName = "https://instagram.com/sanwiliamsofficial",
                .UseShellExecute = True
             })

        Catch ex As Exception
            Box.Danger(ex.Message)
        End Try
    End Sub

    Private Sub ButtonSignIn_Click(sender As Object, e As EventArgs) Handles ButtonSignIn.Click
        Dim Guest As New User With {
            .Username = Me.TextBoxUsername.Text,
            .Password = Me.TextBoxPassword.Text}
        Try
            If Service.Login(Guest) Then
                Me.Hide()
                Dim Form As New FormDashboard
                Form.Show()

                Me.TextBoxUsername.Clear()
                Me.TextBoxPassword.Clear()
            End If
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try

    End Sub

    Private Sub FormSignIn_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub TextBoxUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBoxPassword.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBoxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ButtonSignIn.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class
