Imports Inventory.Connection
Imports Inventory.DataTransfersObjects
Imports Inventory.Facades
Imports MySql.Data.MySqlClient

Namespace Repositories
    Public Class BarangKeluarRepository
        Public Function GetAllData(Optional Search As String = "") As MySqlDataAdapter
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("SELECT barang_keluar.*, consumers.name AS consumer_name, barang.unit AS barang_unit, barang.name AS barang_name, users.name AS provider FROM barang_keluar JOIN consumers ON consumers.id = barang_keluar.consumer_id JOIN barang ON barang_keluar.barang_id = barang.id JOIN users ON users.id = barang_keluar.user_id WHERE (barang.name LIKE @Search OR consumers.name LIKE @Search OR barang_keluar.id LIKE @Search) ORDER BY barang_keluar.created_at DESC", Database.Connection)
                Command.Parameters.AddWithValue("@Search", "%" & Search & "%")
                Return New MySqlDataAdapter(Command)
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Function Find(Id As String) As BarangKeluar
            Database.OpenConnection()

            Try
                Dim Command As New MySqlCommand("SELECT * FROM barang_keluar WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", Id)
                Using Reader As MySqlDataReader = Command.ExecuteReader
                    If Reader.Read Then
                        Dim Barang = New BarangKeluar With {
                        .Id = Id,
                        .Code = Reader("code"),
                        .UserId = Reader("user_id"),
                        .ConsumerId = Reader("consumer_id"),
                        .Amount = Reader("amount"),
                        .BarangId = Reader("barang_id")}

                        Reader.Close()
                        Return Barang
                    End If

                    Return Nothing
                End Using

            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
        Public Function CreateNewData(BarangKeluar As BarangKeluar) As BarangKeluar
            Database.OpenConnection()
            Dim Transaction As MySqlTransaction = Database.Connection.BeginTransaction
            Try
                Dim InsertCommand As New MySqlCommand("INSERT INTO barang_keluar (code, user_id, consumer_id, barang_id, amount) VALUES (@code, @user, @consumer, @barang, @amount)", Database.Connection)
                InsertCommand.Parameters.AddWithValue("@code", BarangKeluar.Code)
                InsertCommand.Parameters.AddWithValue("@user", BarangKeluar.UserId)
                InsertCommand.Parameters.AddWithValue("@consumer", BarangKeluar.ConsumerId)
                InsertCommand.Parameters.AddWithValue("@barang", BarangKeluar.BarangId)
                InsertCommand.Parameters.AddWithValue("@amount", BarangKeluar.Amount)
                InsertCommand.ExecuteNonQuery()

                Dim UpdateCommand As New MySqlCommand("UPDATE barang SET stock = stock - @stock WHERE id = @id", Database.Connection)
                UpdateCommand.Parameters.AddWithValue("@stock", BarangKeluar.Amount)
                UpdateCommand.Parameters.AddWithValue("@id", BarangKeluar.BarangId)
                UpdateCommand.ExecuteNonQuery()

                Transaction.Commit()

                Return BarangKeluar
            Catch ex As MySqlException
                Transaction.Rollback()
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
        Public Function UpadateData(BarangKeluar As BarangKeluar) As Integer
            Database.OpenConnection()

            Try
                Dim CommandBarangKeluar As New MySqlCommand("UPDATE barang_keluar SET code = @code, consumer_id = @consumer, barang_id = @barang, amount = @amount WHERE id = @id", Database.Connection)
                CommandBarangKeluar.Parameters.AddWithValue("@id", BarangKeluar.Id)
                CommandBarangKeluar.Parameters.AddWithValue("@code", BarangKeluar.Code)
                CommandBarangKeluar.Parameters.AddWithValue("@consumer", BarangKeluar.ConsumerId)
                CommandBarangKeluar.Parameters.AddWithValue("@barang", BarangKeluar.BarangId)
                CommandBarangKeluar.Parameters.AddWithValue("@amount", BarangKeluar.Amount)
                Return Convert.ToInt32(CommandBarangKeluar.ExecuteNonQuery())
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Function DeleteData(BarangKeluar As BarangKeluar) As Integer
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("DELETE FROM barang_keluar WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", BarangKeluar.Id)
                Return Command.ExecuteNonQuery
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return 0
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Function FindByCode(Code As String) As Integer
            Database.OpenConnection()

            Try
                Dim Command As New MySqlCommand("SELECT COUNT(*) FROM barang_keluar WHERE code = @code", Database.Connection)
                Command.Parameters.AddWithValue("@code", Code)
                Return Convert.ToInt32(Command.ExecuteScalar)

            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
    End Class
End Namespace