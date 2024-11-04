Imports Inventory.DataTransfersObjects
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Repositories
Imports MySql.Data.MySqlClient

Namespace Services
    Public Class ConsumerService
        Private Repository As New ConsumerRepository

        Public Function Index(Optional Search As String = "") As DataTable
            Dim DataTable As New DataTable
            Dim Adapter As MySqlDataAdapter = Repository.GetAllConsumer(Search)

            Adapter.Fill(DataTable)

            Return DataTable
        End Function
        Public Sub Create(Consumer As Consumer)
            Dim Validated As Consumer = Me.Validate(Consumer)
            Repository.CreateNewConsumer(Validated)
        End Sub
        Public Function Update(Consumer As Consumer) As Boolean
            Dim Validated As Consumer = Me.Validate(Consumer)
            Dim OldConsumer As Consumer = Repository.Find(Validated.Id)

            If IsNothing(OldConsumer) Then Throw New ValidationException("Data Not Found !")

            Return Repository.UpadateConsumer(Validated, OldConsumer.Id) >= 1
        End Function
        Public Sub Destroy(Consumer As Consumer)
            Dim OldConsumer As Consumer = Repository.Find(Consumer.Id)

            If IsNothing(OldConsumer) Then Throw New ValidationException("Data Not Found !")

            Dim Result As DialogResult = Box.Question("Are You Sure ?")

            If Result = DialogResult.Yes Then
                Repository.DeleteConsumer(Consumer)
                TransactionRepository.DeleteDataOnNull()
            End If
        End Sub

        Public Function Validate(Consumer As Consumer) As Consumer

            If String.IsNullOrEmpty(Consumer.Name) Then Throw New ValidationException("Field Name Is Required !")

            Return New Consumer With {
                .Id = Consumer.Id,
                .Name = Consumer.Name
            }
        End Function
    End Class
End Namespace