Imports Inventory.Connection
Imports Inventory.DataTransfersObjects
Imports Inventory.Facades
Imports MySql.Data.MySqlClient

Namespace Repositories
    Public Class TransactionRepository

        Public Shared Sub DeleteDataOnNull()
            Database.OpenConnection()

            Try
                Dim Command As New MySqlCommand("DELETE FROM transactions WHERE code NOT IN (SELECT code FROM barang_masuk) OR code NOT IN (SELECT code FROM barang_keluar)", Database.Connection)
                Command.ExecuteNonQuery()
            Catch ex As MysqlException
                Box.Danger(ex.Message)
            End Try
        End Sub
        Public Shared Function GetAllData(Optional Search As String = "") As MySqlDataAdapter
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("SELECT t.*, COUNT(bk.code) AS jumlah_bk, COUNT(bm.code) AS jumlah_bm FROM transactions t LEFT JOIN barang_masuk bm ON bm.code = t.code LEFT JOIN barang_keluar bk ON bk.code = t.code WHERE t.code LIKE @search GROUP BY t.id ORDER BY t.id DESC", Database.Connection)
                Command.Parameters.AddWithValue("@search", "%" & Search & "%")
                Return New MySqlDataAdapter(Command)
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Shared Sub CreateData(Transaction As Transaction)
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("INSERT INTO transactions (code) SELECT @code FROM DUAL WHERE NOT EXISTS(SELECT 1 FROM transactions WHERE code = @code)", Database.Connection)
                Command.Parameters.AddWithValue("@code", Transaction.Code)
                Command.ExecuteNonQuery()
            Catch ex As MySqlException
                Box.Danger(ex.Message)
            Finally
                Database.CloseConnection()
            End Try
        End Sub

        Public Shared Sub DeleteData(Code As String)
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("DELETE FROM transactions WHERE code = @code", Database.Connection)
                Command.Parameters.AddWithValue("@code", Code)
                Command.ExecuteNonQuery()
            Catch ex As MySqlException
                Box.Danger(ex.Message)
            Finally
                Database.CloseConnection()
            End Try
        End Sub

        Public Shared Function GetAllDataByCode(Code As String) As MySqlDataAdapter
            Database.OpenConnection()

            Try
                Dim Command As New MySqlCommand("SELECT bm.amount AS bm_amount, bk.amount AS bk_amount, b.unit, b.name FROM transactions t LEFT JOIN barang_masuk bm ON bm.code = t.code LEFT JOIN barang_keluar bk ON bk.code = t.code LEFT JOIN barang b ON b.id = COALESCE(bm.barang_id, bk.barang_id) WHERE t.code = @code", Database.Connection)
                Command.Parameters.AddWithValue("@code", Code)
                Return New MySqlDataAdapter(Command)
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace
