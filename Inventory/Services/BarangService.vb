Imports Inventory.DataTransfersObjects
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Repositories
Imports MySql.Data.MySqlClient

Namespace Services
    Public Class BarangService
        Private Repository As New BarangRepository

        Public Function Index(Optional Search As String = "") As DataTable
            Dim DataTable As New DataTable
            Dim Adapter As MySqlDataAdapter = Repository.GetAllBarang(Search)

            Adapter.Fill(DataTable)

            Return DataTable
        End Function
        Public Sub Create(Barang As Barang)
            Dim Validated As Barang = Me.Validate(Barang)

            If Not IsNothing(Repository.FindByName(Validated.Name)) Then Throw New ValidationException("The " & Validated.Name & " Is Already Exists !")
            Repository.CreateNewBarang(Validated)
        End Sub
        Public Function Update(Barang As Barang) As Boolean
            Dim Validated As Barang = Me.Validate(Barang)
            Dim OldBarang As Barang = Repository.Find(Validated.Id)

            If IsNothing(OldBarang) Then Throw New ValidationException("Data Not Found !")

            Return Repository.UpadateBarang(Validated, OldBarang.Id) >= 1
        End Function
        Public Function Destroy(Barang As Barang) As Boolean
            Dim OldBarang As Barang = Repository.Find(Barang.Id)

            If IsNothing(OldBarang) Then Throw New ValidationException("Data Not Found !")

            Dim Result As DialogResult = Box.Question("Are You Sure ?")

            If Result = DialogResult.Yes Then Return Repository.DeleteBarang(Barang) >= 1
            Return Nothing
        End Function

        Public Function Validate(Barang As Barang) As Barang

            If String.IsNullOrEmpty(Barang.Name) Then Throw New ValidationException("Field Name Is Required !")
            If String.IsNullOrEmpty(Barang.Unit) Then Throw New ValidationException("Field Unit Is Required !")

            Return New Barang With {
                .Id = Barang.Id,
                .Name = Barang.Name,
                .Unit = Barang.Unit
            }
        End Function
    End Class
End Namespace