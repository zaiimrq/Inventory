Imports Inventory.DataTransfersObjects
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Repositories
Imports MySql.Data.MySqlClient

Namespace Services
    Public Class BarangMasukService
        Private Repository As New BarangMasukRepository
        Private BarangRepository As New BarangRepository

        Public Function Index(Optional Search As String = "") As DataTable
            Dim DataTable As New DataTable
            Dim Adapter As MySqlDataAdapter = Repository.GetAllData(Search)

            Adapter.Fill(DataTable)

            Return DataTable
        End Function
        Public Sub Create(BarangMasuk As BarangMasuk)
            Dim Validated As BarangMasuk = Me.Validate(BarangMasuk)
            If Not IsNothing(Repository.Find(Validated.Id)) Then Throw New ValidationException("Data Already Exists !")
            Repository.CreateNewData(Validated)
            TransactionRepository.CreateData(New Transaction With {.Code = Validated.Code})
        End Sub
        Public Function Update(BarangMasuk As BarangMasuk) As Boolean
            Dim Validated As BarangMasuk = Me.Validate(BarangMasuk)
            Dim OldBarangMasuk As BarangMasuk = Repository.Find(Validated.Id)

            If IsNothing(OldBarangMasuk) Then Throw New ValidationException("Data Not Found !")
            Dim BarangRepository As New BarangRepository

            If Validated.Amount > OldBarangMasuk.Amount Then
                BarangRepository.UpStock(New Barang With {
                    .Id = Validated.BarangId,
                    .Stock = Validated.Amount - OldBarangMasuk.Amount
                 })
            ElseIf Validated.Amount < OldBarangMasuk.Amount Then
                BarangRepository.DownStock(New Barang With {
                    .Id = Validated.BarangId,
                    .Stock = OldBarangMasuk.Amount - Validated.Amount
                 })
            End If

            Return Repository.UpadateData(Validated) >= 1
        End Function
        Public Sub Destroy(BarangMasuk As BarangMasuk)
            Dim OldBarangMasuk As BarangMasuk = Repository.Find(BarangMasuk.Id)

            If IsNothing(OldBarangMasuk) Then Throw New ValidationException("Data Not Found !")

            Dim Result As DialogResult = Box.Question("Are You Sure ?")

            If Result = DialogResult.Yes Then
                BarangRepository.DownStock(New Barang With {
                    .Id = OldBarangMasuk.BarangId,
                    .Stock = OldBarangMasuk.Amount
                                           })
                Call Repository.DeleteData(OldBarangMasuk)
                If Repository.FindByCode(OldBarangMasuk.Code) = 0 Then TransactionRepository.DeleteData(OldBarangMasuk.Code)
            End If
        End Sub

        Public Function Validate(BarangMasuk As BarangMasuk) As BarangMasuk
            If String.IsNullOrEmpty(BarangMasuk.SupplierId) Then Throw New ValidationException("Field Supplier Is Required !")
            If String.IsNullOrEmpty(BarangMasuk.BarangId) Then Throw New ValidationException("Field Barang Is Required !")
            If String.IsNullOrEmpty(BarangMasuk.Amount) Then Throw New ValidationException("Field Amount Is Required !")
            If Not IsNumeric(BarangMasuk.Amount) Then Throw New ValidationException("Field Amount Must Be Numeric !")
            If BarangMasuk.Amount.Contains(","c) Then Throw New ValidationException("Field Amount Must Use Dot (.) For Decimal !")
            If BarangMasuk.Amount <= 0 Then Throw New ValidationException("Field Amount Must Be Greater Than 0 !")


            Return New BarangMasuk With {
                .Id = BarangMasuk.Id,
                .Code = BarangMasuk.Code,
                .UserId = Auth.User.Id,
                .SupplierId = BarangMasuk.SupplierId,
                .BarangId = BarangMasuk.BarangId,
                .Amount = BarangMasuk.Amount
            }
        End Function
    End Class
End Namespace