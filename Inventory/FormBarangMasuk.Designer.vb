<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBarangMasuk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarangMasuk))
        Label1 = New Label()
        DataGridViewBarangMasuk = New DataGridView()
        TextBoxSearch = New TextBox()
        ButtonCreate = New Button()
        ButtonUpdate = New Button()
        ButtonDelete = New Button()
        TextBoxId = New TextBox()
        ComboBoxBarang = New ComboBox()
        ComboBoxSupplier = New ComboBox()
        TextBoxAmount = New TextBox()
        PanelRefresh = New Panel()
        TextBoxCode = New TextBox()
        LabelAmountUnit = New Label()
        No = New DataGridViewTextBoxColumn()
        Id = New DataGridViewTextBoxColumn()
        Code = New DataGridViewTextBoxColumn()
        Barang = New DataGridViewTextBoxColumn()
        Supplier = New DataGridViewTextBoxColumn()
        Amount = New DataGridViewTextBoxColumn()
        Provider = New DataGridViewTextBoxColumn()
        Tnggal = New DataGridViewTextBoxColumn()
        CType(DataGridViewBarangMasuk, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Geist Mono Medium", 16F, FontStyle.Bold)
        Label1.Location = New Point(11, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 28)
        Label1.TabIndex = 0
        Label1.Text = "Semua Barang Masuk"
        ' 
        ' DataGridViewBarangMasuk
        ' 
        DataGridViewBarangMasuk.AllowUserToAddRows = False
        DataGridViewBarangMasuk.BackgroundColor = SystemColors.Control
        DataGridViewBarangMasuk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewBarangMasuk.Columns.AddRange(New DataGridViewColumn() {No, Id, Code, Barang, Supplier, Amount, Provider, Tnggal})
        DataGridViewBarangMasuk.Cursor = Cursors.Hand
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridViewBarangMasuk.DefaultCellStyle = DataGridViewCellStyle1
        DataGridViewBarangMasuk.Dock = DockStyle.Bottom
        DataGridViewBarangMasuk.Location = New Point(10, 270)
        DataGridViewBarangMasuk.Name = "DataGridViewBarangMasuk"
        DataGridViewBarangMasuk.ReadOnly = True
        DataGridViewBarangMasuk.Size = New Size(864, 281)
        DataGridViewBarangMasuk.TabIndex = 1
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.BorderStyle = BorderStyle.FixedSingle
        TextBoxSearch.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        TextBoxSearch.Location = New Point(532, 220)
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.PlaceholderText = "Search..."
        TextBoxSearch.Size = New Size(340, 27)
        TextBoxSearch.TabIndex = 2
        ' 
        ' ButtonCreate
        ' 
        ButtonCreate.BackColor = Color.CornflowerBlue
        ButtonCreate.Cursor = Cursors.Hand
        ButtonCreate.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        ButtonCreate.Location = New Point(10, 208)
        ButtonCreate.Name = "ButtonCreate"
        ButtonCreate.Padding = New Padding(3)
        ButtonCreate.Size = New Size(83, 36)
        ButtonCreate.TabIndex = 7
        ButtonCreate.Text = "Create"
        ButtonCreate.UseVisualStyleBackColor = False
        ' 
        ' ButtonUpdate
        ' 
        ButtonUpdate.BackColor = Color.Orange
        ButtonUpdate.Cursor = Cursors.Hand
        ButtonUpdate.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        ButtonUpdate.Location = New Point(116, 208)
        ButtonUpdate.Name = "ButtonUpdate"
        ButtonUpdate.Padding = New Padding(3)
        ButtonUpdate.Size = New Size(83, 36)
        ButtonUpdate.TabIndex = 8
        ButtonUpdate.Text = "Update"
        ButtonUpdate.UseVisualStyleBackColor = False
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.BackColor = Color.Red
        ButtonDelete.Cursor = Cursors.Hand
        ButtonDelete.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        ButtonDelete.Location = New Point(222, 208)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Padding = New Padding(3)
        ButtonDelete.Size = New Size(83, 36)
        ButtonDelete.TabIndex = 9
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = False
        ' 
        ' TextBoxId
        ' 
        TextBoxId.BorderStyle = BorderStyle.FixedSingle
        TextBoxId.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        TextBoxId.Location = New Point(12, 76)
        TextBoxId.Name = "TextBoxId"
        TextBoxId.PlaceholderText = "Id"
        TextBoxId.ReadOnly = True
        TextBoxId.Size = New Size(293, 27)
        TextBoxId.TabIndex = 10
        ' 
        ' ComboBoxBarang
        ' 
        ComboBoxBarang.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBoxBarang.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBoxBarang.Cursor = Cursors.Hand
        ComboBoxBarang.FormattingEnabled = True
        ComboBoxBarang.Location = New Point(12, 141)
        ComboBoxBarang.Name = "ComboBoxBarang"
        ComboBoxBarang.Size = New Size(292, 28)
        ComboBoxBarang.TabIndex = 11
        ' 
        ' ComboBoxSupplier
        ' 
        ComboBoxSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBoxSupplier.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBoxSupplier.FormattingEnabled = True
        ComboBoxSupplier.Location = New Point(12, 109)
        ComboBoxSupplier.Name = "ComboBoxSupplier"
        ComboBoxSupplier.Size = New Size(292, 28)
        ComboBoxSupplier.TabIndex = 12
        ' 
        ' TextBoxAmount
        ' 
        TextBoxAmount.BorderStyle = BorderStyle.FixedSingle
        TextBoxAmount.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        TextBoxAmount.Location = New Point(12, 175)
        TextBoxAmount.MaxLength = 20
        TextBoxAmount.Name = "TextBoxAmount"
        TextBoxAmount.PlaceholderText = "Amount"
        TextBoxAmount.Size = New Size(292, 27)
        TextBoxAmount.TabIndex = 13
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
        ' TextBoxCode
        ' 
        TextBoxCode.BorderStyle = BorderStyle.FixedSingle
        TextBoxCode.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        TextBoxCode.Location = New Point(12, 76)
        TextBoxCode.Name = "TextBoxCode"
        TextBoxCode.PlaceholderText = "Code"
        TextBoxCode.ReadOnly = True
        TextBoxCode.Size = New Size(293, 27)
        TextBoxCode.TabIndex = 15
        ' 
        ' LabelAmountUnit
        ' 
        LabelAmountUnit.AutoSize = True
        LabelAmountUnit.BackColor = Color.Transparent
        LabelAmountUnit.Font = New Font("Geist Mono", 10F)
        LabelAmountUnit.Location = New Point(244, 179)
        LabelAmountUnit.Name = "LabelAmountUnit"
        LabelAmountUnit.Size = New Size(56, 18)
        LabelAmountUnit.TabIndex = 17
        LabelAmountUnit.Text = "Karton"
        LabelAmountUnit.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' No
        ' 
        No.HeaderText = "No"
        No.Name = "No"
        No.ReadOnly = True
        No.Width = 45
        ' 
        ' Id
        ' 
        Id.HeaderText = "Id"
        Id.Name = "Id"
        Id.ReadOnly = True
        Id.Visible = False
        Id.Width = 75
        ' 
        ' Code
        ' 
        Code.HeaderText = "Code"
        Code.Name = "Code"
        Code.ReadOnly = True
        Code.Width = 75
        ' 
        ' Barang
        ' 
        Barang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Barang.HeaderText = "Barang"
        Barang.Name = "Barang"
        Barang.ReadOnly = True
        ' 
        ' Supplier
        ' 
        Supplier.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Supplier.HeaderText = "Supplier"
        Supplier.Name = "Supplier"
        Supplier.ReadOnly = True
        ' 
        ' Amount
        ' 
        Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Amount.HeaderText = "Amount"
        Amount.Name = "Amount"
        Amount.ReadOnly = True
        ' 
        ' Provider
        ' 
        Provider.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Provider.HeaderText = "Provider"
        Provider.Name = "Provider"
        Provider.ReadOnly = True
        ' 
        ' Tnggal
        ' 
        Tnggal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Tnggal.HeaderText = "Tanggal"
        Tnggal.Name = "Tnggal"
        Tnggal.ReadOnly = True
        ' 
        ' FormBarangMasuk
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(884, 561)
        Controls.Add(LabelAmountUnit)
        Controls.Add(TextBoxCode)
        Controls.Add(PanelRefresh)
        Controls.Add(TextBoxAmount)
        Controls.Add(ComboBoxSupplier)
        Controls.Add(ComboBoxBarang)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonUpdate)
        Controls.Add(ButtonCreate)
        Controls.Add(TextBoxSearch)
        Controls.Add(DataGridViewBarangMasuk)
        Controls.Add(Label1)
        Controls.Add(TextBoxId)
        Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        MaximumSize = New Size(900, 600)
        MinimumSize = New Size(900, 600)
        Name = "FormBarangMasuk"
        Padding = New Padding(10, 0, 10, 10)
        Text = "Barang Masuk"
        CType(DataGridViewBarangMasuk, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewBarangMasuk As DataGridView
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents ComboBoxBarang As ComboBox
    Friend WithEvents ComboBoxSupplier As ComboBox
    Friend WithEvents PanelRefresh As Panel
    Friend WithEvents TextBoxCode As TextBox
    Friend WithEvents LabelAmountUnit As Label
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Barang As DataGridViewTextBoxColumn
    Friend WithEvents Supplier As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Provider As DataGridViewTextBoxColumn
    Friend WithEvents Tnggal As DataGridViewTextBoxColumn
End Class
