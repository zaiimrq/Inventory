<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboard))
        Label1 = New Label()
        Timer = New Timer(components)
        LabelTimer = New Label()
        MenuStrip1 = New MenuStrip()
        ManageToolStripMenuItem = New ToolStripMenuItem()
        BarangToolStripMenuItem = New ToolStripMenuItem()
        SupliersToolStripMenuItem = New ToolStripMenuItem()
        ConsumersToolStripMenuItem = New ToolStripMenuItem()
        TransactionsToolStripMenuItem = New ToolStripMenuItem()
        BarangMasukToolStripMenuItem = New ToolStripMenuItem()
        BarangKeluatrToolStripMenuItem = New ToolStripMenuItem()
        DetailTransactionToolStripMenuItem = New ToolStripMenuItem()
        AccountToolStripMenuItem = New ToolStripMenuItem()
        UsersToolStripMenuItem = New ToolStripMenuItem()
        ProfileToolStripMenuItem = New ToolStripMenuItem()
        SignOutToolStripMenuItem1 = New ToolStripMenuItem()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1 = New Panel()
        Label4 = New Label()
        LabelTotalSuppliers = New Label()
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        Label3 = New Label()
        LabelTotalConsumers = New Label()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        Label6 = New Label()
        LabelTotalBarang = New Label()
        PictureBox3 = New PictureBox()
        ThemeToggle = New CheckBox()
        LabelGreeting = New Label()
        MenuStrip1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' Timer
        ' 
        Timer.Interval = 1000
        ' 
        ' LabelTimer
        ' 
        resources.ApplyResources(LabelTimer, "LabelTimer")
        LabelTimer.Name = "LabelTimer"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        resources.ApplyResources(MenuStrip1, "MenuStrip1")
        MenuStrip1.Items.AddRange(New ToolStripItem() {ManageToolStripMenuItem, TransactionsToolStripMenuItem, AccountToolStripMenuItem})
        MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
        MenuStrip1.Name = "MenuStrip1"
        ' 
        ' ManageToolStripMenuItem
        ' 
        ManageToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BarangToolStripMenuItem, SupliersToolStripMenuItem, ConsumersToolStripMenuItem})
        ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        resources.ApplyResources(ManageToolStripMenuItem, "ManageToolStripMenuItem")
        ' 
        ' BarangToolStripMenuItem
        ' 
        BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        resources.ApplyResources(BarangToolStripMenuItem, "BarangToolStripMenuItem")
        ' 
        ' SupliersToolStripMenuItem
        ' 
        SupliersToolStripMenuItem.Name = "SupliersToolStripMenuItem"
        resources.ApplyResources(SupliersToolStripMenuItem, "SupliersToolStripMenuItem")
        ' 
        ' ConsumersToolStripMenuItem
        ' 
        ConsumersToolStripMenuItem.Name = "ConsumersToolStripMenuItem"
        resources.ApplyResources(ConsumersToolStripMenuItem, "ConsumersToolStripMenuItem")
        ' 
        ' TransactionsToolStripMenuItem
        ' 
        TransactionsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BarangMasukToolStripMenuItem, BarangKeluatrToolStripMenuItem, DetailTransactionToolStripMenuItem})
        TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        resources.ApplyResources(TransactionsToolStripMenuItem, "TransactionsToolStripMenuItem")
        ' 
        ' BarangMasukToolStripMenuItem
        ' 
        BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        resources.ApplyResources(BarangMasukToolStripMenuItem, "BarangMasukToolStripMenuItem")
        ' 
        ' BarangKeluatrToolStripMenuItem
        ' 
        BarangKeluatrToolStripMenuItem.Name = "BarangKeluatrToolStripMenuItem"
        resources.ApplyResources(BarangKeluatrToolStripMenuItem, "BarangKeluatrToolStripMenuItem")
        ' 
        ' DetailTransactionToolStripMenuItem
        ' 
        DetailTransactionToolStripMenuItem.Name = "DetailTransactionToolStripMenuItem"
        resources.ApplyResources(DetailTransactionToolStripMenuItem, "DetailTransactionToolStripMenuItem")
        ' 
        ' AccountToolStripMenuItem
        ' 
        AccountToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UsersToolStripMenuItem, ProfileToolStripMenuItem, SignOutToolStripMenuItem1})
        AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        resources.ApplyResources(AccountToolStripMenuItem, "AccountToolStripMenuItem")
        ' 
        ' UsersToolStripMenuItem
        ' 
        UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        resources.ApplyResources(UsersToolStripMenuItem, "UsersToolStripMenuItem")
        ' 
        ' ProfileToolStripMenuItem
        ' 
        ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        resources.ApplyResources(ProfileToolStripMenuItem, "ProfileToolStripMenuItem")
        ' 
        ' SignOutToolStripMenuItem1
        ' 
        SignOutToolStripMenuItem1.ForeColor = Color.Red
        SignOutToolStripMenuItem1.Name = "SignOutToolStripMenuItem1"
        resources.ApplyResources(SignOutToolStripMenuItem1, "SignOutToolStripMenuItem1")
        ' 
        ' FlowLayoutPanel1
        ' 
        resources.ApplyResources(FlowLayoutPanel1, "FlowLayoutPanel1")
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Controls.Add(Panel1)
        FlowLayoutPanel1.Controls.Add(Panel4)
        FlowLayoutPanel1.Controls.Add(Panel2)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CornflowerBlue
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(LabelTotalSuppliers)
        Panel1.Controls.Add(PictureBox1)
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.Name = "Panel1"
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.Name = "Label4"
        ' 
        ' LabelTotalSuppliers
        ' 
        resources.ApplyResources(LabelTotalSuppliers, "LabelTotalSuppliers")
        LabelTotalSuppliers.Name = "LabelTotalSuppliers"
        ' 
        ' PictureBox1
        ' 
        resources.ApplyResources(PictureBox1, "PictureBox1")
        PictureBox1.Name = "PictureBox1"
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.CornflowerBlue
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(LabelTotalConsumers)
        Panel4.Controls.Add(PictureBox2)
        resources.ApplyResources(Panel4, "Panel4")
        Panel4.Name = "Panel4"
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.Name = "Label3"
        ' 
        ' LabelTotalConsumers
        ' 
        resources.ApplyResources(LabelTotalConsumers, "LabelTotalConsumers")
        LabelTotalConsumers.Name = "LabelTotalConsumers"
        ' 
        ' PictureBox2
        ' 
        resources.ApplyResources(PictureBox2, "PictureBox2")
        PictureBox2.Name = "PictureBox2"
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.CornflowerBlue
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(LabelTotalBarang)
        Panel2.Controls.Add(PictureBox3)
        resources.ApplyResources(Panel2, "Panel2")
        Panel2.Name = "Panel2"
        ' 
        ' Label6
        ' 
        resources.ApplyResources(Label6, "Label6")
        Label6.Name = "Label6"
        ' 
        ' LabelTotalBarang
        ' 
        resources.ApplyResources(LabelTotalBarang, "LabelTotalBarang")
        LabelTotalBarang.Name = "LabelTotalBarang"
        ' 
        ' PictureBox3
        ' 
        resources.ApplyResources(PictureBox3, "PictureBox3")
        PictureBox3.Name = "PictureBox3"
        PictureBox3.TabStop = False
        ' 
        ' ThemeToggle
        ' 
        resources.ApplyResources(ThemeToggle, "ThemeToggle")
        ThemeToggle.BackColor = Color.Transparent
        ThemeToggle.Cursor = Cursors.Hand
        ThemeToggle.FlatAppearance.BorderSize = 0
        ThemeToggle.FlatAppearance.CheckedBackColor = Color.Transparent
        ThemeToggle.FlatAppearance.MouseDownBackColor = Color.Transparent
        ThemeToggle.FlatAppearance.MouseOverBackColor = Color.Transparent
        ThemeToggle.Name = "ThemeToggle"
        ThemeToggle.UseVisualStyleBackColor = False
        ' 
        ' LabelGreeting
        ' 
        resources.ApplyResources(LabelGreeting, "LabelGreeting")
        LabelGreeting.Name = "LabelGreeting"
        ' 
        ' FormDashboard
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(LabelGreeting)
        Controls.Add(ThemeToggle)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(LabelTimer)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "FormDashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents LabelTimer As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsumersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LabelTotalConsumers As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelTotalSuppliers As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelTotalBarang As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TransactionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangKeluatrToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThemeToggle As CheckBox
    Friend WithEvents LabelGreeting As Label
    Friend WithEvents DetailTransactionToolStripMenuItem As ToolStripMenuItem
End Class
