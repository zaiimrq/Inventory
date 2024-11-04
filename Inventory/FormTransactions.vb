Imports System.Globalization
Imports System.Threading
Imports Inventory.DataTransfersObjects
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Repositories
Imports Inventory.Services

Public Class FormTransactions
    Private ReadOnly Service As New BarangService
    Public Event SyncDataBarang()

    Private Sub FormTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Me.RefreshForm()
        Call (New ToolTip).SetToolTip(Me.PanelRefresh, "Refresh")

        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")

    End Sub

    Public Sub RefreshForm()
        Call Me.FillDataGridView()
        Call Me.SetTheme()
    End Sub

    Private Sub FillDataGridView(Optional Search As String = "")
        Dim No As Integer = 1

        Me.DataGridViewTransactions.Rows.Clear()
        Dim DataTable As DataTable = TransactionService.Index(Search)

        If DataTable IsNot Nothing AndAlso DataTable.Rows.Count > 0 Then
            For Each Row As DataRow In DataTable.Rows
                Dim Type As String = If(Row("code").ToString.StartsWith("BM"), "Masuk", "Keluar")
                Dim Jumlah As String = If(Row("code").ToString.StartsWith("BM"), Row("jumlah_bm"), Row("jumlah_bk"))

                Me.DataGridViewTransactions.Rows.Add(No, Row("code"), Jumlah, Type, Convert.ToDateTime(Row("created_at")).ToString("dd MMMM yyyy"))
                No += 1
            Next
        End If
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        FillDataGridView(TextBoxSearch.Text)
    End Sub

    Public Sub SetTheme()
        Theme.Apply(Me)
    End Sub

    Private Sub FormTransactions_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call Me.SetTheme()
        AddHandler Theme.SwitchedTheme, AddressOf Me.SetTheme
        AddHandler FormBarangKeluar.SyncDataBarang, AddressOf Me.RefreshForm
        AddHandler FormBarangMasuk.SyncDataBarang, AddressOf Me.RefreshForm
        AddHandler FormBarang.SyncDataBarang, AddressOf Me.RefreshForm
        AddHandler FormSupplier.DeletedSupplier, AddressOf Me.RefreshForm
        AddHandler FormConsumer.DeletedConsumer, AddressOf Me.RefreshForm
    End Sub

    Private Sub PanelRefresh_Click(sender As Object, e As EventArgs) Handles PanelRefresh.Click
        Me.RefreshForm()
    End Sub

    Private Sub DataGridViewTransactions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTransactions.CellClick

        For Each Form As Form In Application.OpenForms
            If TypeOf Form Is FormShowTransaction Then
                Form.Hide()
            End If
        Next

        If e.RowIndex >= 0 Then
            Dim Row As DataGridViewRow = Me.DataGridViewTransactions.Rows(e.RowIndex)
            Dim Form As New FormShowTransaction(Row.Cells("Code").Value)
            Form.Show()
        End If
    End Sub
End Class