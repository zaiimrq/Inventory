Imports Inventory.Facades
Imports Inventory.Services

Public Class FormShowTransaction
    Private Property Code As String
    Public Sub New(Code As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Code = Code
    End Sub
    Private Sub FormShowTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InitializeData()

        Call Me.SetTheme()
    End Sub

    Private Sub InitializeData()
        Me.ListBoxTransaction.Items.Clear()
        Dim No As Integer = 1

        For Each Row As DataRow In TransactionService.GetDataByCode(Me.Code).Rows
            Dim Item As String = No & ". " & Row("name") & " " & Row("Amount") & " " & Row("unit")
            Me.ListBoxTransaction.Items.Add(Item)
            No += 1
        Next
    End Sub

    Private Sub SetTheme()
        Theme.Apply(Me)
        If Theme.IsDark Then
            Me.ListBoxTransaction.BackColor = Theme.DarkColor
            Me.ListBoxTransaction.ForeColor = SystemColors.Control
        Else
            Me.ListBoxTransaction.BackColor = Color.White
            Me.ListBoxTransaction.ForeColor = Color.Black
        End If
    End Sub

    Private Sub FormShowTransaction_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AddHandler Theme.SwitchedTheme, AddressOf Me.SetTheme
    End Sub
End Class