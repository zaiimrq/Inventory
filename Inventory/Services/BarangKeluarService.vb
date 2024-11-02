Imports Inventory.DataTransfersObjects
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Repositories
Imports MySql.Data.MySqlClient

Namespace Services
    Public Class BarangKeluarService
        Private Repository As New BarangKeluarRepository
        Private BarangRepository As New BarangRepository

        Public Function Index(Optional Search As String = "") As DataTable
            Dim DataTable As New DataTable
            Dim Adapter As MySqlDataAdapter = Repository.GetAllData(Search)

            Adapter.Fill(DataTable)

            Return DataTable
        End Function
        Public Sub Create(BarangKeluar As BarangKeluar)
            Dim Validated As BarangKeluar = Me.Validate(BarangKeluar)

            Dim Barang As Barang = (New BarangRepository).Find(Validated.BarangId)

            If (Barang.Stock - Validated.Amount) < 0 Then Throw New ValidationException("The Stock Of " & Barang.Name & " Is " & Barang.Stock & Barang.Unit & " !")

            Repository.CreateNewData(Validated)
        End Sub
        Public Function Update(BarangKeluar As BarangKeluar) As Boolean
            Dim Validated As BarangKeluar = Me.Validate(BarangKeluar)
            Dim OldBarangKeluar As BarangKeluar = Repository.Find(Validated.Id)

            If IsNothing(OldBarangKeluar) Then Throw New ValidationException("Data Not Found !")

            Dim Barang As Barang = (New BarangRepository).Find(Validated.BarangId)


            If Validated.Amount > OldBarangKeluar.Amount Then
                If (Validated.Amount - OldBarangKeluar.Amount) > Barang.Stock Then Throw New ValidationException("The Stock Of " & Barang.Name & " Is " & Barang.Stock & Barang.Unit & " !")
                BarangRepository.DownStock(New Barang With {
                    .Id = Validated.BarangId,
                    .Stock = Validated.Amount - OldBarangKeluar.Amount
                 })
            ElseIf Validated.Amount < OldBarangKeluar.Amount Then
                BarangRepository.UpStock(New Barang With {
                    .Id = Validated.BarangId,
                    .Stock = OldBarangKeluar.Amount - Validated.Amount
                 })
            End If

            Return Repository.UpadateData(Validated) >= 1
        End Function
        Public Function Destroy(BarangKeluar As BarangKeluar) As Boolean
            Dim OldBarangKeluar As BarangKeluar = Repository.Find(BarangKeluar.Id)

            If IsNothing(OldBarangKeluar) Then Throw New ValidationException("Data Not Found !")

            Dim Result As DialogResult = Box.Question("Are You Sure ?")

            If Result = DialogResult.Yes Then
                BarangRepository.UpStock(New Barang With {
                    .Id = OldBarangKeluar.BarangId,
                    .Stock = OldBarangKeluar.Amount
                                           })
                Return Repository.DeleteData(OldBarangKeluar) >= 1
            End If
            Return Nothing
        End Function

        Public Function Validate(BarangKeluar As BarangKeluar) As BarangKeluar
            If String.IsNullOrEmpty(BarangKeluar.ConsumerId) Then Throw New ValidationException("Field Consumer Is Required !")
            If String.IsNullOrEmpty(BarangKeluar.BarangId) Then Throw New ValidationException("Field Barang Is Required !")
            If String.IsNullOrEmpty(BarangKeluar.Amount) Then Throw New ValidationException("Field Amount Is Required !")
            If Not IsNumeric(BarangKeluar.Amount) Then Throw New ValidationException("Field Amount Must Be Numeric !")
            If BarangKeluar.Amount.Contains(","c) Then Throw New ValidationException("Field Amount Must Use Dot (.) For Decimal !")
            If BarangKeluar.Amount <= 0 Then Throw New ValidationException("Field Amount Must Be Greater Than 0 !")


            Return New BarangKeluar With {
                .Id = BarangKeluar.Id,
                .Code = BarangKeluar.Code,
                .UserId = Auth.User.Id,
                .ConsumerId = BarangKeluar.ConsumerId,
                .BarangId = BarangKeluar.BarangId,
                .Amount = BarangKeluar.Amount
            }
        End Function
    End Class
End Namespace