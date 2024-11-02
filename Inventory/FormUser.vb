Imports System.Globalization
Imports System.Threading
Imports Inventory.DataTransfersObjects
Imports Inventory.Enums
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Services

Public Class FormUser
    Private Service As New UserService
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Me.SetTheme()
        Call Me.RefreshForm()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")

        Call (New ToolTip).SetToolTip(Me.PanelRefresh, "Refresh")
    End Sub

    Public Sub RefreshForm()
        Call Me.FillDataGridView()
        Call Me.ClearInputForm()
    End Sub
    Private Sub ClearInputForm()
        Me.TextBoxId.Clear()
        Me.TextBoxName.Clear()
        Me.TextBoxUsername.Clear()
        Me.TextBoxPassword.Clear()
    End Sub
    Private Sub FillDataGridView(Optional Search As String = "")
        Me.DataGridViewUser.Rows.Clear()
        Me.DataGridViewUser.Columns("Id").Visible = False

        Dim No As Integer = 1
        For Each Row As DataRow In Service.Index(Search).Rows
            Me.DataGridViewUser.Rows.Add(No, Row("id"), Row("name"), Row("username"), Row("password"))
            No += 1
        Next
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        FillDataGridView(TextBoxSearch.Text)
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click

        Try
            Service.Create(New User With {
               .Name = TextBoxName.Text,
               .Username = TextBoxUsername.Text,
               .Password = TextBoxPassword.Text
                           })
            Me.RefreshForm()
        Catch ex As ValidationException
            Warning(ex.Message)
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Try
            Service.Update(New User With {
                .Id = TextBoxId.Text,
               .Name = TextBoxName.Text,
               .Username = TextBoxUsername.Text,
               .Password = TextBoxPassword.Text
             })
            RefreshForm()
        Catch ex As ValidationException
            Warning(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            Service.Destroy(New User With {.Id = TextBoxId.Text})
            RefreshForm()
        Catch ex As ValidationException
            Warning(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUser.CellClick
        If e.RowIndex >= 0 Then
            Dim Row = DataGridViewUser.Rows(e.RowIndex)
            TextBoxId.Text = Row.Cells("Id").Value
            TextBoxName.Text = Row.Cells("Nama").Value
            TextBoxUsername.Text = Row.Cells("Username").Value
            TextBoxPassword.Text = Row.Cells("Password").Value
        End If
    End Sub

    Public Sub SetTheme()
        Theme.Apply(Me)
        Dim DGF As DataGridView = Me.DataGridViewUser
        If Theme.IsDark Then
            DGF.DefaultCellStyle.ForeColor = Color.White
            DGF.DefaultCellStyle.BackColor = Theme.DarkColor
            DGF.BackgroundColor = Theme.DarkColor
            DGF.ForeColor = Color.White
            DGF.ColumnHeadersDefaultCellStyle.BackColor = Theme.DarkColor
            DGF.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DGF.EnableHeadersVisualStyles = False
            DGF.RowHeadersDefaultCellStyle.BackColor = Theme.DarkColor
            DGF.RowHeadersDefaultCellStyle.ForeColor = Color.White
        Else
            DGF.DefaultCellStyle.ForeColor = Color.Black
            DGF.DefaultCellStyle.BackColor = SystemColors.Control
            DGF.BackgroundColor = SystemColors.Control
            DGF.ForeColor = Color.Black
            DGF.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control
            DGF.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            DGF.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control
            DGF.RowHeadersDefaultCellStyle.ForeColor = Color.Black
            DGF.EnableHeadersVisualStyles = True
        End If
    End Sub

    Private Sub PanelRefresh_Click(sender As Object, e As EventArgs) Handles PanelRefresh.Click
        Me.RefreshForm()
    End Sub
End Class