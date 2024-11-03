Imports Inventory.Connection
Imports Inventory.DataTransfersObjects
Imports Inventory.Facades
Imports MySql.Data.MySqlClient

Namespace Repositories
    Public Class UserRepository

        Public Function GetAllData(Search As String) As MySqlDataAdapter
            Database.OpenConnection()

            Try
                Dim Command As New MySqlCommand("SELECT * FROM users WHERE (name LIKE @search OR username LIKE @search) ORDER BY id DESC", Database.Connection)
                Command.Parameters.AddWithValue("@search", "%" & Search & "%")
                Return New MySqlDataAdapter(Command)
            Catch ex As Exception
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
        Public Function Find(Id As Integer) As User
            Database.OpenConnection()

            Try
                Dim Command As New MySqlCommand("SELECT * FROM users WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", Id)
                Using Reader As MySqlDataReader = Command.ExecuteReader
                    If Not Reader.Read Then Return Nothing

                    Dim User As New User With {
                        .Id = Reader("id"),
                        .Name = Reader("name"),
                        .Username = Reader("username"),
                        .Password = Reader("password")
                    }

                    Return User
                End Using
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Function FindByUsername(User As User) As User
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("SELECT * FROM users WHERE username = @username LIMIT 1", Database.Connection)
                Command.Parameters.AddWithValue("@username", User.Username)
                Using Reader As MySqlDataReader = Command.ExecuteReader
                    If Reader.Read Then
                        Dim StoredUser = New User With {
                        .Id = Reader("id"),
                        .Name = Reader("name"),
                        .Username = Reader("username"),
                        .Password = Reader("password").ToString
                    }
                        Return StoredUser
                    Else
                        Return Nothing
                    End If
                End Using
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function

        Public Function CreateData(User As User) As Integer
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("INSERT INTO users (name, username, password) VALUES (@name, @username, @password)", Database.Connection)
                Command.Parameters.AddWithValue("@name", User.Name)
                Command.Parameters.AddWithValue("@username", User.Username)
                Command.Parameters.AddWithValue("@password", User.Password)

                Return Convert.ToInt32(Command.ExecuteNonQuery)
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
        Public Function UpdateData(User As User) As Integer
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("UPDATE users SET name = @name, username = @username, password = @password WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@name", User.Name)
                Command.Parameters.AddWithValue("@username", User.Username)
                Command.Parameters.AddWithValue("@password", User.Password)
                Command.Parameters.AddWithValue("@id", User.Id)

                Return Convert.ToInt32(Command.ExecuteNonQuery)
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
        Public Function DeleteData(User As User) As Integer
            Database.OpenConnection()
            Try
                Dim Command As New MySqlCommand("DELETE FROM users WHERE id = @id", Database.Connection)
                Command.Parameters.AddWithValue("@id", User.Id)

                Return Convert.ToInt32(Command.ExecuteNonQuery)
            Catch ex As MySqlException
                Box.Danger(ex.Message)
                Return Nothing
            Finally
                Database.CloseConnection()
            End Try
        End Function
    End Class
End Namespace