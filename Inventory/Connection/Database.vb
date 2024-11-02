Imports Inventory.Facades
Imports MySql.Data.MySqlClient

Namespace Connection
    Module Database
        Private Property DSN As String = "Server=localhost;Database=inventory;User=root"
        Public Property Connection As New MySqlConnection(DSN)

        Public Sub OpenConnection()
            Try
                If Connection.State = ConnectionState.Closed Then Connection.Open()
            Catch ex As MySqlException
                Box.Danger(ex.Message)
            End Try
        End Sub
        Public Sub CloseConnection()
            Try
                If Connection.State = ConnectionState.Open Then Connection.Close()
            Catch ex As MySqlException
                Box.Danger(ex.Message)
            End Try
        End Sub
    End Module
End Namespace
