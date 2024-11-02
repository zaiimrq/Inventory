Imports Inventory.Repositories

Namespace Services
    Public Class DashboardService
        Private Repository As New DashboardRepository
        Public Function Index() As DataTable
            Dim DataTable As New DataTable
            Dim Adapter = Repository.GetTotalData
            Adapter.Fill(DataTable)
            Return DataTable
        End Function
    End Class
End Namespace