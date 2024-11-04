Imports Inventory.Connection
Imports Inventory.DataTransfersObjects
Imports Inventory.Facades
Imports MySql.Data.MySqlClient

Namespace Repositories
    Public Class BarangRepository
        Public Function GetAllBarang(Optional Search As String = "") As MySqlDataAdapter
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("SELECT * FROM barang WHERE name LIKE @Search ORDER BY id", Database.Connection)
                Command.Parameters.AddWithValue("@Search", "%" & Search & "%")
                Return New MySqlDataAdapter(Command)
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Function Find(Id As String) As Barang
            Database.OpenConnection()

            Try
                Dim Command As New MySqlCommand("SELECT * FROM barang WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", Id)
                Using Reader As MySqlDataReader = Command.ExecuteReader
                    If Reader.Read Then Return New Barang With {
                        .Id = Reader("id"),
                        .Name = Reader("name"),
                        .Stock = Reader("stock"),
                        .Unit = Reader("unit")}

                    Return Nothing
                End Using

            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
        Public Function CreateNewBarang(Barang As Barang) As Barang
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("INSERT INTO barang (name, unit) VALUES (@name, @unit)", Database.Connection)
                Command.Parameters.AddWithValue("@name", Barang.Name)
                Command.Parameters.AddWithValue("@unit", Barang.Unit)
                Command.ExecuteNonQuery()
                Return Barang
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
        Public Function UpadateBarang(Barang As Barang, Id As String) As Integer
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("UPDATE barang SET name = @name, unit = @unit WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", Id)
                Command.Parameters.AddWithValue("@name", Barang.Name)
                Command.Parameters.AddWithValue("@unit", Barang.Unit)
                Return Convert.ToInt32(Command.ExecuteNonQuery())
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Function DeleteBarang(Barang As Barang) As Integer
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("DELETE FROM barang WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", Barang.Id)
                Return Convert.ToInt32(Command.ExecuteScalar())
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
        Public Shared Sub UpStock(Barang As Barang)
            Database.OpenConnection()

            Try
                Dim Command As New MySqlCommand("UPDATE barang SET stock = stock + @stock WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@stock", Barang.Stock)
                Command.Parameters.AddWithValue("@id", Barang.Id)
                Command.ExecuteNonQuery()
            Catch ex As Exception
                Box.Danger(ex.Message)
            Finally
                Database.CloseConnection()
            End Try
        End Sub
        Public Shared Sub DownStock(Barang As Barang)
            Database.OpenConnection()

            Try
                Dim Command As New MySqlCommand("UPDATE barang SET stock = stock - @stock WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@stock", Barang.Stock)
                Command.Parameters.AddWithValue("@id", Barang.Id)
                Command.ExecuteNonQuery()
            Catch ex As Exception
                Box.Danger(ex.Message)
            Finally
                Database.CloseConnection()
            End Try
        End Sub

        Public Function FindByName(Name As String) As Barang
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("SELECT * FROM barang WHERE name = @name", Database.Connection)
                Command.Parameters.AddWithValue("@name", Name)

                Using Reader As MySqlDataReader = Command.ExecuteReader
                    If Reader.Read Then Return New Barang With {
                        .Id = Reader("id"),
                        .Name = Reader("name"),
                        .Unit = Reader("unit"),
                        .Stock = Reader("stock")
                        }
                End Using

                Return Nothing
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
    End Class
End Namespace