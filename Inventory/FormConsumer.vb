Imports Inventory.DataTransfersObjects
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Services

Public Class FormConsumer
    Private Service As New ConsumerService
    Public Event DeletedConsumer()
    Private Sub FormConsumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshForm()
        Call (New ToolTip).SetToolTip(Me.PanelRefresh, "Refresh")
    End Sub

    Public Sub RefreshForm()
        Call Me.FillDataGridView()
        Call Me.ClearInputForm()
    End Sub
    Private Sub ClearInputForm()
        Me.TextBoxId.Clear()
        Me.TextBoxName.Clear()
    End Sub

    Private Sub FillDataGridView(Optional Search As String = "")
        Me.DataGridViewConsumer.Rows.Clear()
        Me.DataGridViewConsumer.Columns("Id").Visible = False
        Dim No As Integer = 1
        Dim DataTable As DataTable = Service.Index(Search)

        If DataTable IsNot Nothing AndAlso DataTable.Rows.Count > 0 Then
            For Each Row As DataRow In DataTable.Rows
                Me.DataGridViewConsumer.Rows.Add(No, Row("id"), Row("name"))
                No += 1
            Next
        End If
    End Sub
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Me.FillDataGridView(Me.TextBoxSearch.Text)
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Try
            Service.Create(New Consumer With {
                .Name = Me.TextBoxName.Text
            })
            Me.RefreshForm()
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Try
            Service.Update(New Consumer With {
                .Id = Me.TextBoxId.Text,
                .Name = Me.TextBoxName.Text})
            Call RefreshForm()
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            Service.Destroy(New Consumer With {.Id = Me.TextBoxId.Text})
            Call RefreshForm()
            RaiseEvent DeletedConsumer()
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewConsumer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewConsumer.CellClick
        Dim Row = DataGridViewConsumer.Rows(e.RowIndex)
        Me.TextBoxId.Text = Row.Cells("Id").Value
        Me.TextBoxName.Text = Row.Cells("Nama").Value
    End Sub

    Public Sub SetTheme()
        Theme.Apply(Me)
    End Sub

    Private Sub FormConsumer_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call Me.SetTheme()
    End Sub

    Private Sub PanelRefresh_Click(sender As Object, e As EventArgs) Handles PanelRefresh.Click
        Me.RefreshForm()
    End Sub
End Class