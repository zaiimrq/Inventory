Imports Inventory.DataTransfersObjects
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Services

Public Class FormSupplier
    Private Service As New SupplierService
    Private Sub FormSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.DataGridViewSupplier.Rows.Clear()
        Me.DataGridViewSupplier.Columns("Id").Visible = False
        Dim No As Integer = 1

        For Each Row As DataRow In Service.Index(Search).Rows
            Me.DataGridViewSupplier.Rows.Add(No, Row("id"), Row("name"))
            No += 1
        Next
    End Sub
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Me.FillDataGridView(Me.TextBoxSearch.Text)
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Try
            Service.Create(New Supplier With {
                .Name = Me.TextBoxName.Text
            })
            Me.RefreshForm()
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Try
            Service.Update(New Supplier With {
                .Id = Me.TextBoxId.Text,
                .Name = Me.TextBoxName.Text})
            Call RefreshForm()
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            Service.Destroy(New Supplier With {.Id = Me.TextBoxId.Text})
            Call RefreshForm()
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewSupplier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSupplier.CellClick
        If e.RowIndex >= 0 Then
            Dim Row = DataGridViewSupplier.Rows(e.RowIndex)
            Me.TextBoxId.Text = Row.Cells("Id").Value
            Me.TextBoxName.Text = Row.Cells("Nama").Value
        End If
    End Sub

    Public Sub SetTheme()
        Theme.Apply(Me)
        Dim DGF As DataGridView = Me.DataGridViewSupplier
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

    Private Sub FormSupplier_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call Me.SetTheme()
    End Sub

    Private Sub PanelRefresh_Click(sender As Object, e As EventArgs) Handles PanelRefresh.Click
        Me.RefreshForm()
    End Sub
End Class