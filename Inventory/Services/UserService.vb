Imports Inventory.DataTransfersObjects
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Repositories

Namespace Services
    Public Class UserService
        Private Repository As New UserRepository
        Public Function Login(User As User) As Boolean
            If String.IsNullOrEmpty(User.Username) Then Throw New ValidationException("Field Username Is Required !")
            If String.IsNullOrEmpty(User.Password) Then Throw New ValidationException("Field Password Is Required !")

            Return Auth.Attempt(User)
        End Function

        Public Function Index(Optional Search As String = "") As DataTable
            Dim DataTable As New DataTable
            Call Repository.GetAllData(Search).Fill(DataTable)
            Return DataTable
        End Function

        Public Sub Create(User As User)
            Dim Validated As User = Validate(User)

            If Not IsNothing(Repository.FindByUsername(Validated)) Then Throw New ValidationException("Username Must Be Unique !")
            Repository.CreateData(Validated)
        End Sub
        Public Function Update(User As User) As Integer
            Dim Validated As User = Validate(User)
            Dim OldUser As User = Repository.Find(Validated.Id)

            If IsNothing(OldUser) Then Throw New ValidationException("Data Not Found !")

            Return Repository.UpdateData(
                New User With {
                .Id = OldUser.Id,
                .Name = Validated.Name,
                .Username = Validated.Username,
                .Password = Validated.Password})
        End Function
        Public Function Destroy(User As User) As Integer
            If String.IsNullOrEmpty(User.Id) Then Throw New ValidationException("Data Not Found !")

            Dim Result As DialogResult = Box.Question("Are You Sure ?")
            If Not Result = DialogResult.Yes Then Return 0
            Return Repository.DeleteData(User)
        End Function

        Public Shared Function Validate(User As User) As User
            If String.IsNullOrEmpty(User.Name) Then Throw New ValidationException("Field Name Is Required !")
            If String.IsNullOrEmpty(User.Username) Then Throw New ValidationException("Field Username Is Required !")
            If String.IsNullOrEmpty(User.Password) Then Throw New ValidationException("Field Password Is Required !")

            Return User
        End Function
    End Class
End Namespace