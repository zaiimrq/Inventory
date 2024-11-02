Imports Inventory.Connection
Imports Inventory.DataTransfersObjects
Imports Inventory.Facades
Imports MySql.Data.MySqlClient

Namespace Repositories
    Public Class SupplierRepository
        Public Function GetAllSupplier(Optional Search As String = "") As MySqlDataAdapter
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("SELECT * FROM suppliers WHERE name LIKE @Search ORDER BY id ASC", Database.Connection)
                Command.Parameters.AddWithValue("@Search", "%" & Search & "%")
                Return New MySqlDataAdapter(Command)
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Function Find(Id As String) As Supplier
            Database.OpenConnection()

            Try
                Dim Command As New MySqlCommand("SELECT * FROM suppliers WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", Id)
                Using Reader As MySqlDataReader = Command.ExecuteReader
                    If Reader.Read Then
                        Dim Supplier = New Supplier With {
                        .Id = Id,
                        .Name = Reader("name")}

                        Reader.Close()
                        Return Supplier
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
        Public Function CreateNewSupplier(Supplier As Supplier) As Supplier
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("INSERT INTO suppliers (name) VALUES (@name)", Database.Connection)
                Command.Parameters.AddWithValue("@name", Supplier.Name)
                Command.ExecuteNonQuery()
                Return Supplier
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
        Public Function UpadateSupplier(Supplier As Supplier, Id As String) As Integer
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("UPDATE suppliers SET name = @name WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", Id)
                Command.Parameters.AddWithValue("@name", Supplier.Name)
                Return Convert.ToInt32(Command.ExecuteScalar())
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Function DeleteSupplier(Supplier As Supplier) As Integer
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("DELETE FROM suppliers WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", Supplier.Id)
                Return Convert.ToInt32(Command.ExecuteScalar())
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
    End Class
End Namespace