Imports System.Globalization
Imports System.Threading
Imports Inventory.DataTransfersObjects
Imports Inventory.Enums
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Services

Public Class FormBarang
    Private Service As New BarangService
    Public Event SyncDataBarang()
    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Me.SetTheme()
        Call Me.RefreshForm()
        Call (New ToolTip).SetToolTip(Me.PanelRefresh, "Refresh")

        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
    End Sub

    Public Sub RefreshForm()
        Call Me.FillDataGridView()
        Call Me.ClearInputForm()
        Call Me.FillComboBox()
    End Sub
    Private Sub ClearInputForm()
        Me.TextBoxId.Clear()
        Me.TextBoxName.Clear()
        Me.ComboBoxUnit.Controls.Clear()
    End Sub
    Private Sub FillComboBox()
        Me.ComboBoxUnit.DataSource = [Enum].GetValues(GetType(Enums.UnitEnum))
    End Sub
    Private Sub FillDataGridView(Optional Search As String = "")
        Me.DataGridViewBarang.Rows.Clear()
        Dim DataTable As DataTable = Service.Index(Search)

        If DataTable IsNot Nothing AndAlso DataTable.Rows.Count > 0 Then
            For Each Row As DataRow In DataTable.Rows
                Me.DataGridViewBarang.Rows.Add(Row("id"), Row("name"), Row("stock"), Row("unit"))
            Next
        End If
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Me.FillDataGridView(Me.TextBoxSearch.Text)
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Try
            Service.Create(New Barang With {
                .Name = Me.TextBoxName.Text,
                .Unit = Me.ComboBoxUnit.Text
            })
            Me.RefreshForm()
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Try
            Service.Update(New Barang With {
                .Id = Me.TextBoxId.Text,
                .Name = Me.TextBoxName.Text,
                .Unit = Me.ComboBoxUnit.Text
                           })
            Call RefreshForm()
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            Service.Destroy(New Barang With {.Id = Me.TextBoxId.Text})
            Call RefreshForm()
            RaiseEvent SyncDataBarang()
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBarang.CellClick
        If e.RowIndex >= 0 Then
            Dim Row = DataGridViewBarang.Rows(e.RowIndex)
            Me.TextBoxId.Text = Row.Cells("Id").Value
            Me.TextBoxName.Text = Row.Cells("Nama").Value
            Me.ComboBoxUnit.Text = Row.Cells("unit").Value
        End If
    End Sub

    Public Sub SetTheme()
        Theme.Apply(Me)
    End Sub

    Private Sub PanelRefresh_Click(sender As Object, e As EventArgs) Handles PanelRefresh.Click
        Me.RefreshForm()
    End Sub

    Private Sub FormBarang_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AddHandler FormBarangKeluar.SyncDataBarang, AddressOf Me.RefreshForm
        AddHandler FormBarangMasuk.SyncDataBarang, AddressOf Me.RefreshForm
    End Sub
End Class