Imports Inventory.Repositories

Namespace Services
    Public Class TransactionService
        Public Shared Function Index(Optional Search As String = "") As DataTable
            Dim DataTable As New DataTable
            TransactionRepository.GetAllData(Search).Fill(DataTable)
            Return DataTable
        End Function
        Public Shared Function GetDataByCode(Code As String) As DataTable
            Dim DataTable As New DataTable
            TransactionRepository.GetAllDataByCode(Code).Fill(DataTable)
            Return DataTable
        End Function
    End Class
End Namespace