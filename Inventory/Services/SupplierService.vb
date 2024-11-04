Imports Inventory.DataTransfersObjects
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Repositories
Imports MySql.Data.MySqlClient

Namespace Services
    Public Class SupplierService
        Private Repository As New SupplierRepository

        Public Function Index(Optional Search As String = "") As DataTable
            Dim DataTable As New DataTable
            Dim Adapter As MySqlDataAdapter = Repository.GetAllSupplier(Search)

            Adapter.Fill(DataTable)

            Return DataTable
        End Function
        Public Sub Create(Supplier As Supplier)
            Dim Validated As Supplier = Me.Validate(Supplier)
            Repository.CreateNewSupplier(Validated)
        End Sub
        Public Function Update(Supplier As Supplier) As Boolean
            Dim Validated As Supplier = Me.Validate(Supplier)
            Dim OldSupplier As Supplier = Repository.Find(Validated.Id)

            If IsNothing(OldSupplier) Then Throw New ValidationException("Data Not Found !")

            Return Repository.UpadateSupplier(Validated, OldSupplier.Id) >= 1
        End Function
        Public Sub Destroy(Supplier As Supplier)
            Dim OldSupplier As Supplier = Repository.Find(Supplier.Id)

            If IsNothing(OldSupplier) Then Throw New ValidationException("Data Not Found !")

            Dim Result As DialogResult = Box.Question("Are You Sure ?")

            If Result = DialogResult.Yes Then
                Repository.DeleteSupplier(Supplier)
                TransactionRepository.DeleteDataOnNull()
            End If
        End Sub

        Public Function Validate(Supplier As Supplier) As Supplier

            If String.IsNullOrEmpty(Supplier.Name) Then Throw New ValidationException("Field Name Is Required !")

            Return New Supplier With {
                .Id = Supplier.Id,
                .Name = Supplier.Name
            }
        End Function
    End Class
End Namespace
