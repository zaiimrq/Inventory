Imports Inventory.Connection
Imports Inventory.Facades
Imports MySql.Data.MySqlClient

Namespace Repositories
    Public Class DashboardRepository
        Public Function GetTotalData() As MySqlDataAdapter
            Database.OpenConnection()

            Try
                Dim Command As New MySqlCommand("SELECT 
                    (SELECT COUNT(*) FROM suppliers) AS total_suppliers,
                    (SELECT COUNT(*) FROM consumers) AS total_consumers, 
                    (SELECT COUNT(*) FROM barang) AS total_barang", Database.Connection)
                Return New MySqlDataAdapter(Command)

            Catch ex As Exception
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
    End Class
End Namespace