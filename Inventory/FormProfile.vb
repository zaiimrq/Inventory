Imports Inventory.DataTransfersObjects
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Services

Public Class FormProfile
    Private Service As New UserService
    Public Event UpdatedProfile()
    Private Sub FormProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Me.SetTheme()
        Call Me.SetInputForm()
    End Sub

    Private Sub FormProfile_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AddHandler Theme.SwitchedTheme, AddressOf Me.SetTheme
    End Sub

    Private Sub SetTheme()
        Theme.Apply(Me)

        If Not Theme.IsDark Then Me.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub SetInputForm()
        Me.TextBoxName.Text = Auth.User.Name
        Me.TextBoxUsername.Text = Auth.User.Username
        Me.TextBoxPassword.Text = Auth.User.Password
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Try
            Dim Result As Integer = Service.Update(New User With {
                .Id = Auth.User.Id,
                .Name = Me.TextBoxName.Text,
                .Username = Me.TextBoxUsername.Text,
                .Password = Me.TextBoxPassword.Text
             })
            If Result >= 1 Then Box.Success("Success Update Data")
            Call Me.SetInputForm()

            RaiseEvent UpdatedProfile()
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxName_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ButtonUpdate.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class