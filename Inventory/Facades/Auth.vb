Imports Inventory.DataTransfersObjects
Imports Inventory.Exceptions
Imports Inventory.Repositories

Namespace Facades
    Module Auth
        Private Repository As New UserRepository

        Public Function Attempt(Guest As User) As Boolean
            Dim User As User = Repository.FindByUsername(Guest)

            If IsNothing(User) OrElse Not User.Password = Guest.Password Then Throw New ValidationException("Username Or Password Is Wrong !")

            Session.Create(User)
            Return User.Password = Guest.Password
        End Function

        Public Function User() As User
            Return Repository.Find(Session.IsValid)
        End Function

        Public Sub Logout()
            Session.Destroy()

            For Each OpenForm As Form In Application.OpenForms
                If TypeOf OpenForm IsNot FormSignIn Then OpenForm.Hide()
            Next

            FormSignIn.Show()
        End Sub
    End Module
End Namespace