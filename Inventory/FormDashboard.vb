Imports System.Globalization
Imports Inventory.Facades
Imports Inventory.Services

Public Class FormDashboard
    Private Service As New DashboardService
    Private GreetingText As String = "Welcome Back, "
    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SetTimer()
        Call InitialStats()
        Call Theme.Apply(Me)
        Call SetToolStripTheme()

        Me.ThemeToggle.Checked = Theme.IsDark
        If Theme.IsDark Then
            Me.ThemeToggle.BackgroundImage = Image.FromFile("C:\Users\zaiimrq\source\repos\Inventory\Inventory\Assets\Icons\sun.png")
            Call (New ToolTip).SetToolTip(Me.ThemeToggle, "Light Mode")
        Else
            Me.ThemeToggle.BackgroundImage = Image.FromFile("C:\Users\zaiimrq\source\repos\Inventory\Inventory\Assets\Icons\moon.png")
            Call (New ToolTip).SetToolTip(Me.ThemeToggle, "Dark Mode")
        End If

        Me.UsersToolStripMenuItem.Visible = Auth.User.Username = "admin"
        Me.LabelGreeting.Text = Me.GreetingText & Auth.User.Name
    End Sub

    Private Sub SetTimer()
        Me.Timer.Start()
        Me.LabelTimer.Text = DateTime.Now.ToString("HH:mm:ss, d MMMM yyyy", CultureInfo.InvariantCulture)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Me.LabelTimer.Text = DateTime.Now.ToString("HH:mm:ss, d MMMM yyyy", CultureInfo.InvariantCulture)
    End Sub

    Private Sub InitialStats()
        Dim Stats As DataTable = Service.Index
        Me.LabelTotalSuppliers.Text = Convert.ToInt32(Stats.Rows(0)("total_suppliers"))
        Me.LabelTotalConsumers.Text = Convert.ToInt32(Stats.Rows(0)("total_consumers"))
        Me.LabelTotalBarang.Text = Convert.ToInt32(Stats.Rows(0)("total_barang"))
    End Sub


    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        FormBarang.Show()
        AddHandler Theme.SwitchedTheme, AddressOf FormBarang.SetTheme
    End Sub

    Private Sub FormDashboard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub SignOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem1.Click
        Me.Hide()
        Auth.Logout()
    End Sub

    Private Sub SupliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupliersToolStripMenuItem.Click
        FormSupplier.Show()
        AddHandler Theme.SwitchedTheme, AddressOf FormSupplier.SetTheme
    End Sub

    Private Sub BarangMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangMasukToolStripMenuItem.Click
        FormBarangMasuk.Show()

        Dim FormBarangIsOpen As FormBarang = Application.OpenForms.OfType(Of FormBarang).FirstOrDefault
        If FormBarangIsOpen IsNot Nothing Then
            AddHandler FormBarangMasuk.SyncDataBarang, AddressOf FormBarangIsOpen.RefreshForm
        End If

        AddHandler Theme.SwitchedTheme, AddressOf FormBarangMasuk.SetTheme
    End Sub

    Private Sub ConsumersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsumersToolStripMenuItem.Click
        FormConsumer.Show()
        AddHandler Theme.SwitchedTheme, AddressOf FormConsumer.SetTheme
    End Sub

    Private Sub BarangKeluatrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangKeluatrToolStripMenuItem.Click
        FormBarangKeluar.Show()

        Dim FormBarangIsOpen As FormBarang = Application.OpenForms.OfType(Of FormBarang).FirstOrDefault
        If FormBarangIsOpen IsNot Nothing Then
            AddHandler FormBarangKeluar.SyncDataBarang, AddressOf FormBarangIsOpen.RefreshForm
        End If

        AddHandler Theme.SwitchedTheme, AddressOf FormBarangKeluar.SetTheme
    End Sub

    Private Sub FormDashboard_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AddHandler FormBarangKeluar.SyncDataBarang, AddressOf FormBarang.RefreshForm
        AddHandler FormBarangMasuk.SyncDataBarang, AddressOf FormBarang.RefreshForm
        AddHandler FormProfile.UpdatedProfile, AddressOf Me.UpdatedProfileHandler
    End Sub

    Private Sub ThemeToggle_CheckedChanged(sender As Object, e As EventArgs) Handles ThemeToggle.CheckedChanged
        If Me.ThemeToggle.Checked Then
            Call Theme.Dark(Me)
            Call (New ToolTip).SetToolTip(Me.ThemeToggle, "Light Mode")

            Me.ThemeToggle.BackgroundImage = Image.FromFile("C:\Users\zaiimrq\source\repos\Inventory\Inventory\Assets\Icons\sun.png")
            Me.ThemeToggle.BackColor = Theme.DarkColor
        Else
            Call Theme.Light(Me)
            Call (New ToolTip).SetToolTip(Me.ThemeToggle, "Dark Mode")

            Me.ThemeToggle.BackgroundImage = Image.FromFile("C:\Users\zaiimrq\source\repos\Inventory\Inventory\Assets\Icons\moon.png")
            Me.ThemeToggle.BackColor = Color.White
        End If
        Call Me.SetToolStripTheme()
    End Sub

    Public Sub SetToolStripTheme()
        Me.ManageToolStripMenuItem.ForeColor = If(Theme.IsDark, Color.White, Color.Black)
        Me.TransactionsToolStripMenuItem.ForeColor = If(Theme.IsDark, Color.White, Color.Black)
        Me.AccountToolStripMenuItem.ForeColor = If(Theme.IsDark, Color.White, Color.Black)
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        FormUser.Show()
        AddHandler Theme.SwitchedTheme, AddressOf FormUser.SetTheme
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        FormProfile.Show()
    End Sub

    Private Sub UpdatedProfileHandler()
        Me.LabelGreeting.Text = Me.GreetingText & Auth.User.Name
    End Sub
End Class