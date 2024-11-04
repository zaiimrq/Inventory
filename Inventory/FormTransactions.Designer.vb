<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransactions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransactions))
        Label1 = New Label()
        DataGridViewTransactions = New DataGridView()
        PanelRefresh = New Panel()
        TextBoxSearch = New TextBox()
        No = New DataGridViewTextBoxColumn()
        Code = New DataGridViewTextBoxColumn()
        Jumlah = New DataGridViewTextBoxColumn()
        Type = New DataGridViewTextBoxColumn()
        Tanggal = New DataGridViewTextBoxColumn()
        CType(DataGridViewTransactions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Geist Mono Medium", 16F, FontStyle.Bold)
        Label1.Location = New Point(11, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 28)
        Label1.TabIndex = 0
        Label1.Text = "List Of Transactions"
        ' 
        ' DataGridViewTransactions
        ' 
        DataGridViewTransactions.AllowUserToAddRows = False
        DataGridViewTransactions.AllowUserToDeleteRows = False
        DataGridViewTransactions.BackgroundColor = SystemColors.Control
        DataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewTransactions.Columns.AddRange(New DataGridViewColumn() {No, Code, Jumlah, Type, Tanggal})
        DataGridViewTransactions.Cursor = Cursors.Hand
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridViewTransactions.DefaultCellStyle = DataGridViewCellStyle1
        DataGridViewTransactions.Dock = DockStyle.Bottom
        DataGridViewTransactions.Location = New Point(10, 116)
        DataGridViewTransactions.Name = "DataGridViewTransactions"
        DataGridViewTransactions.ReadOnly = True
        DataGridViewTransactions.Size = New Size(864, 435)
        DataGridViewTransactions.TabIndex = 1
        ' 
        ' PanelRefresh
        ' 
        PanelRefresh.BackgroundImage = CType(resources.GetObject("PanelRefresh.BackgroundImage"), Image)
        PanelRefresh.BackgroundImageLayout = ImageLayout.Zoom
        PanelRefresh.Cursor = Cursors.Hand
        PanelRefresh.Location = New Point(851, 28)
        PanelRefresh.Name = "PanelRefresh"
        PanelRefresh.Size = New Size(20, 20)
        PanelRefresh.TabIndex = 14
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.BorderStyle = BorderStyle.FixedSingle
        TextBoxSearch.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        TextBoxSearch.Location = New Point(534, 73)
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.PlaceholderText = "Search..."
        TextBoxSearch.Size = New Size(340, 27)
        TextBoxSearch.TabIndex = 15
        ' 
        ' No
        ' 
        No.HeaderText = "No"
        No.Name = "No"
        No.ReadOnly = True
        No.Width = 45
        ' 
        ' Code
        ' 
        Code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Code.HeaderText = "Kode"
        Code.Name = "Code"
        Code.ReadOnly = True
        ' 
        ' Jumlah
        ' 
        Jumlah.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Jumlah.HeaderText = "Jumlah"
        Jumlah.Name = "Jumlah"
        Jumlah.ReadOnly = True
        ' 
        ' Type
        ' 
        Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Type.HeaderText = "Type"
        Type.Name = "Type"
        Type.ReadOnly = True
        Type.Resizable = DataGridViewTriState.True
        ' 
        ' Tanggal
        ' 
        Tanggal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Tanggal.HeaderText = "Tanggal"
        Tanggal.Name = "Tanggal"
        Tanggal.ReadOnly = True
        ' 
        ' FormTransactions
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(TextBoxSearch)
        Controls.Add(PanelRefresh)
        Controls.Add(DataGridViewTransactions)
        Controls.Add(Label1)
        Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        MaximumSize = New Size(900, 600)
        MinimumSize = New Size(900, 600)
        Name = "FormTransactions"
        Padding = New Padding(10, 0, 10, 10)
        Text = "Transactions"
        CType(DataGridViewTransactions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTransactions As DataGridView
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents PanelRefresh As Panel
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Tanggal As DataGridViewTextBoxColumn
End Class
