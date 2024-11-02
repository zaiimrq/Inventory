Imports Inventory.Connection
Imports Inventory.DataTransfersObjects
Imports Inventory.Facades
Imports MySql.Data.MySqlClient

Namespace Repositories
    Public Class ConsumerRepository
        Public Function GetAllConsumer(Optional Search As String = "") As MySqlDataAdapter
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("SELECT * FROM consumers WHERE name LIKE @Search ORDER BY id ASC", Database.Connection)
                Command.Parameters.AddWithValue("@Search", "%" & Search & "%")
                Return New MySqlDataAdapter(Command)
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Function Find(Id As String) As Consumer
            Database.OpenConnection()

            Try
                Dim Command As New MySqlCommand("SELECT * FROM consumers WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", Id)
                Using Reader As MySqlDataReader = Command.ExecuteReader
                    If Reader.Read Then
                        Dim Consumer = New Consumer With {
                        .Id = Id,
                        .Name = Reader("name")}

                        Reader.Close()
                        Return Consumer
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
        Public Function CreateNewConsumer(Consumer As Consumer) As Consumer
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("INSERT INTO consumers (name) VALUES (@name)", Database.Connection)
                Command.Parameters.AddWithValue("@name", Consumer.Name)
                Command.ExecuteNonQuery()
                Return Consumer
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
        Public Function UpadateConsumer(Consumer As Consumer, Id As String) As Integer
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("UPDATE consumers SET name = @name WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", Id)
                Command.Parameters.AddWithValue("@name", Consumer.Name)
                Return Convert.ToInt32(Command.ExecuteScalar())
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Function DeleteConsumer(Consumer As Consumer) As Integer
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("DELETE FROM consumers WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", Consumer.Id)
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