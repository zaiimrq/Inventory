Imports Inventory.DataTransfersObjects

Namespace Facades
    Module Session
        Public Sub Create(User As User)
            My.Settings.AuthenticatedUserId = Convert.ToInt32(User.Id)
            My.Settings.ExpireAt = DateTime.Now.AddHours(1)
            My.Settings.Save()
        End Sub
        Public Sub Destroy()
            My.Settings.AuthenticatedUserId = Nothing
            My.Settings.ExpireAt = DateTime.MinValue
            My.Settings.Save()
        End Sub

        Public Function IsValid() As Integer
            Dim TimeSession As DateTime = My.Settings.ExpireAt
            If TimeSession <> DateTime.MinValue AndAlso TimeSession >= DateTime.Now Then Return My.Settings.AuthenticatedUserId
            Return Nothing
        End Function
    End Module
End Namespace