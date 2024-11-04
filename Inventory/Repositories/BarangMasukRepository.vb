Imports Inventory.Connection
Imports Inventory.DataTransfersObjects
Imports Inventory.Facades
Imports MySql.Data.MySqlClient

Namespace Repositories
    Public Class BarangMasukRepository
        Public Function GetAllData(Optional Search As String = "") As MySqlDataAdapter
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("SELECT barang_masuk.*, suppliers.name AS supplier_name, barang.unit AS barang_unit, barang.name AS barang_name, users.name AS provider FROM barang_masuk JOIN suppliers ON suppliers.id = barang_masuk.supplier_id JOIN barang ON barang_masuk.barang_id = barang.id JOIN users ON users.id = barang_masuk.user_id WHERE (barang.name LIKE @Search OR suppliers.name LIKE @Search) ORDER BY barang_masuk.id ASC", Database.Connection)
                Command.Parameters.AddWithValue("@Search", "%" & Search & "%")
                Return New MySqlDataAdapter(Command)
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Function Find(Id As String) As BarangMasuk
            Database.OpenConnection()

            Try
                Dim Command As New MySqlCommand("SELECT * FROM barang_masuk WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", Id)
                Using Reader As MySqlDataReader = Command.ExecuteReader
                    If Reader.Read Then
                        Dim Barang = New BarangMasuk With {
                        .Id = Id,
                        .Code = Reader("code"),
                        .UserId = Reader("user_id"),
                        .SupplierId = Reader("supplier_id"),
                        .Amount = Reader("amount"),
                        .BarangId = Reader("barang_id")}
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
        Public Function CreateNewData(BarangMasuk As BarangMasuk) As BarangMasuk
            Database.OpenConnection()
            Dim Transaction As MySqlTransaction = Database.Connection.BeginTransaction
            Try
                Dim InsertCommand As New MySqlCommand("INSERT INTO barang_masuk (code, user_id, supplier_id, barang_id, amount) VALUES (@code, @user, @supplier, @barang, @amount)", Database.Connection)
                InsertCommand.Parameters.AddWithValue("@code", BarangMasuk.Code)
                InsertCommand.Parameters.AddWithValue("@user", BarangMasuk.UserId)
                InsertCommand.Parameters.AddWithValue("@supplier", BarangMasuk.SupplierId)
                InsertCommand.Parameters.AddWithValue("@barang", BarangMasuk.BarangId)
                InsertCommand.Parameters.AddWithValue("@amount", BarangMasuk.Amount)
                InsertCommand.ExecuteNonQuery()

                Dim UpdateCommand As New MySqlCommand("UPDATE barang SET stock = stock + @stock WHERE id = @id", Database.Connection)
                UpdateCommand.Parameters.AddWithValue("@stock", BarangMasuk.Amount)
                UpdateCommand.Parameters.AddWithValue("@id", BarangMasuk.BarangId)
                UpdateCommand.ExecuteNonQuery()

                Transaction.Commit()

                Return BarangMasuk
            Catch ex As MySqlException
                Transaction.Rollback()
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
        Public Function UpadateData(BarangMasuk As BarangMasuk) As Integer
            Database.OpenConnection()

            Try
                Dim CommandBarangMasuk As New MySqlCommand("UPDATE barang_masuk SET code = @code, supplier_id = @supplier, barang_id = @barang, amount = @amount WHERE id = @id", Database.Connection)
                CommandBarangMasuk.Parameters.AddWithValue("@id", BarangMasuk.Id)
                CommandBarangMasuk.Parameters.AddWithValue("@code", BarangMasuk.Code)
                CommandBarangMasuk.Parameters.AddWithValue("@supplier", BarangMasuk.SupplierId)
                CommandBarangMasuk.Parameters.AddWithValue("@barang", BarangMasuk.BarangId)
                CommandBarangMasuk.Parameters.AddWithValue("@amount", BarangMasuk.Amount)
                Return Convert.ToInt32(CommandBarangMasuk.ExecuteNonQuery())
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Function DeleteData(BarangMasuk As BarangMasuk) As Integer
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("DELETE FROM barang_masuk WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", BarangMasuk.Id)
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
                Dim Command As New MySqlCommand("SELECT COUNT(*) FROM barang_masuk WHERE code = @code", Database.Connection)
                Command.Parameters.AddWithValue("@code", Code)
                Return Convert.ToInt32(Command.ExecuteScalar)

            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Shared Function GetTotalByMonth() As Integer
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("SELECT COUNT(barang_id) AS jumlah_barang FROM barang_masuk WHERE MONTH(created_at) = MONTH(CURDATE()) AND YEAR(created_at) = YEAR(CURDATE())", Database.Connection)
                Dim Reader As MySqlDataReader = Command.ExecuteReader
                Reader.Read()
                Dim Total As Integer = If(IsDBNull(Reader("jumlah_barang")), 0, Convert.ToInt32(Reader("jumlah_barang")))
                Reader.Close()
                Return Total
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace