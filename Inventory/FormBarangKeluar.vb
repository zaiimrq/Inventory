﻿Imports System.Globalization
Imports System.Threading
Imports Inventory.DataTransfersObjects
Imports Inventory.Exceptions
Imports Inventory.Facades
Imports Inventory.Services

Public Class FormBarangKeluar
    Private Service As New BarangKeluarService
    Private UniqueId As String = UniqCode.BK.ToString
    Public Event SyncDataBarang()
    Private Sub FormBarangKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Me.SetTheme()
        Call Me.RefreshForm()
        Call (New ToolTip).SetToolTip(Me.PanelRefresh, "Refresh")

        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")

        Me.TextBoxCode.Text = Me.UniqueId
    End Sub

    Public Sub RefreshForm()
        Call Me.FillDataGridView()
        Call Me.ClearInputForm()
        Call Me.FillComboBox()

        Me.TextBoxCode.Text = Me.UniqueId
    End Sub

    Private Sub FillComboBox()
        ComboBoxConsumer.DataSource = New ConsumerService().Index
        ComboBoxConsumer.ValueMember = "id"
        ComboBoxConsumer.DisplayMember = "name"

        ComboBoxBarang.DataSource = New BarangService().Index
        ComboBoxBarang.ValueMember = "id"
        ComboBoxBarang.DisplayMember = "name"
    End Sub
    Private Sub ClearInputForm()
        Me.TextBoxId.Clear()
        Me.ComboBoxConsumer.Controls.Clear()
        Me.ComboBoxBarang.Controls.Clear()
        Me.TextBoxAmount.Clear()
    End Sub

    Private Sub FillDataGridView(Optional Search As String = "")
        Me.DataGridViewBarangKeluar.Rows.Clear()
        Me.DataGridViewBarangKeluar.Columns("Id").Visible = False
        Dim No As Integer = 1

        For Each Row As DataRow In Service.Index(Search).Rows
            Me.DataGridViewBarangKeluar.Rows.Add(No, Row("id"), Row("code"), Row("barang_name"), Row("consumer_name"), Row("amount") & " " & Row("barang_unit"), Row("provider"), Convert.ToDateTime(Row("created_at")).ToString("dd MMMM yyyy"))
            No += 1
        Next
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Me.FillDataGridView(Me.TextBoxSearch.Text)
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Try
            Service.Create(New BarangKeluar With {
                .Id = Me.TextBoxId.Text,
                .Code = Me.TextBoxCode.Text,
                .ConsumerId = Me.ComboBoxConsumer.SelectedValue,
                .BarangId = Me.ComboBoxBarang.SelectedValue,
                .Amount = Me.TextBoxAmount.Text
            })
            Me.RefreshForm()
            RaiseEvent SyncDataBarang()
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Try
            Service.Update(New BarangKeluar With {
                .Id = Me.TextBoxId.Text,
                .Code = Me.TextBoxCode.Text,
                .ConsumerId = Me.ComboBoxConsumer.SelectedValue,
                .BarangId = Me.ComboBoxBarang.SelectedValue,
                .Amount = Me.TextBoxAmount.Text
             })
            Call RefreshForm()
            RaiseEvent SyncDataBarang()
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            Service.Destroy(New BarangKeluar With {.Id = Me.TextBoxId.Text})
            Call RefreshForm()
            RaiseEvent SyncDataBarang()
        Catch ex As ValidationException
            Box.Warning(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewBarangKeluar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBarangKeluar.CellClick
        If e.RowIndex >= 0 Then
            Dim Row = DataGridViewBarangKeluar.Rows(e.RowIndex)
            Me.TextBoxId.Text = Row.Cells("Id").Value
            Me.TextBoxCode.Text = Row.Cells("Code").Value
            Me.ComboBoxConsumer.Text = Row.Cells("Consumer").Value
            Me.ComboBoxBarang.Text = Row.Cells("Barang").Value

            Dim Str As String() = Row.Cells("Amount").Value.ToString().Split(" "c)

            Me.TextBoxAmount.Text = Str(0).Replace(",", ".")
        End If
    End Sub

    Public Sub SetTheme()
        Theme.Apply(Me)
        Dim DGF As DataGridView = Me.DataGridViewBarangKeluar
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

    Private Sub FormBarangKeluar_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call Me.SetTheme()
        AddHandler FormBarang.SyncDataBarang, AddressOf Me.RefreshForm
    End Sub

    Private Sub PanelRefresh_Click(sender As Object, e As EventArgs) Handles PanelRefresh.Click
        Me.RefreshForm()
    End Sub
End Class