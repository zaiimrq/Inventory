<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBarangKeluar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarangKeluar))
        Label1 = New Label()
        DataGridViewBarangKeluar = New DataGridView()
        TextBoxSearch = New TextBox()
        ButtonCreate = New Button()
        ButtonUpdate = New Button()
        ButtonDelete = New Button()
        TextBoxId = New TextBox()
        ComboBoxBarang = New ComboBox()
        ComboBoxConsumer = New ComboBox()
        TextBoxAmount = New TextBox()
        PanelRefresh = New Panel()
        TextBoxCode = New TextBox()
        No = New DataGridViewTextBoxColumn()
        Id = New DataGridViewTextBoxColumn()
        Code = New DataGridViewTextBoxColumn()
        Barang = New DataGridViewTextBoxColumn()
        Consumer = New DataGridViewTextBoxColumn()
        Amount = New DataGridViewTextBoxColumn()
        Provider = New DataGridViewTextBoxColumn()
        Tnggal = New DataGridViewTextBoxColumn()
        CType(DataGridViewBarangKeluar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Geist Mono Medium", 16F, FontStyle.Bold)
        Label1.Location = New Point(11, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(278, 28)
        Label1.TabIndex = 0
        Label1.Text = "Semua Barang Keluar"
        ' 
        ' DataGridViewBarangKeluar
        ' 
        DataGridViewBarangKeluar.AllowUserToAddRows = False
        DataGridViewBarangKeluar.AllowUserToDeleteRows = False
        DataGridViewBarangKeluar.BackgroundColor = SystemColors.Control
        DataGridViewBarangKeluar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewBarangKeluar.Columns.AddRange(New DataGridViewColumn() {No, Id, Code, Barang, Consumer, Amount, Provider, Tnggal})
        DataGridViewBarangKeluar.Cursor = Cursors.Hand
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridViewBarangKeluar.DefaultCellStyle = DataGridViewCellStyle1
        DataGridViewBarangKeluar.Dock = DockStyle.Bottom
        DataGridViewBarangKeluar.Location = New Point(10, 270)
        DataGridViewBarangKeluar.Name = "DataGridViewBarangKeluar"
        DataGridViewBarangKeluar.ReadOnly = True
        DataGridViewBarangKeluar.Size = New Size(864, 281)
        DataGridViewBarangKeluar.TabIndex = 1
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
        ButtonCreate.Location = New Point(13, 211)
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
        ButtonUpdate.Location = New Point(119, 211)
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
        ButtonDelete.Location = New Point(225, 211)
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
        ComboBoxBarang.Location = New Point(13, 144)
        ComboBoxBarang.Name = "ComboBoxBarang"
        ComboBoxBarang.Size = New Size(292, 28)
        ComboBoxBarang.TabIndex = 11
        ' 
        ' ComboBoxConsumer
        ' 
        ComboBoxConsumer.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBoxConsumer.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBoxConsumer.FormattingEnabled = True
        ComboBoxConsumer.Location = New Point(13, 110)
        ComboBoxConsumer.Name = "ComboBoxConsumer"
        ComboBoxConsumer.Size = New Size(292, 28)
        ComboBoxConsumer.TabIndex = 12
        ' 
        ' TextBoxAmount
        ' 
        TextBoxAmount.BorderStyle = BorderStyle.FixedSingle
        TextBoxAmount.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        TextBoxAmount.Location = New Point(13, 178)
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
        TextBoxCode.Location = New Point(12, 77)
        TextBoxCode.Name = "TextBoxCode"
        TextBoxCode.PlaceholderText = "Code"
        TextBoxCode.ReadOnly = True
        TextBoxCode.Size = New Size(293, 27)
        TextBoxCode.TabIndex = 15
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
        ' Consumer
        ' 
        Consumer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Consumer.HeaderText = "Consumer"
        Consumer.Name = "Consumer"
        Consumer.ReadOnly = True
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
        ' FormBarangKeluar
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(TextBoxCode)
        Controls.Add(PanelRefresh)
        Controls.Add(TextBoxAmount)
        Controls.Add(ComboBoxConsumer)
        Controls.Add(ComboBoxBarang)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonUpdate)
        Controls.Add(ButtonCreate)
        Controls.Add(TextBoxSearch)
        Controls.Add(DataGridViewBarangKeluar)
        Controls.Add(Label1)
        Controls.Add(TextBoxId)
        Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        MaximumSize = New Size(900, 600)
        MinimumSize = New Size(900, 600)
        Name = "FormBarangKeluar"
        Padding = New Padding(10, 0, 10, 10)
        Text = "Barang Keluar"
        CType(DataGridViewBarangKeluar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewBarangKeluar As DataGridView
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents ComboBoxBarang As ComboBox
    Friend WithEvents ComboBoxConsumer As ComboBox
    Friend WithEvents PanelRefresh As Panel
    Friend WithEvents TextBoxCode As TextBox
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Barang As DataGridViewTextBoxColumn
    Friend WithEvents Consumer As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Provider As DataGridViewTextBoxColumn
    Friend WithEvents Tnggal As DataGridViewTextBoxColumn
End Class
