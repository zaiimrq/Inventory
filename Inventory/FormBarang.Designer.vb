<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarang))
        Label1 = New Label()
        DataGridViewBarang = New DataGridView()
        Id = New DataGridViewTextBoxColumn()
        Nama = New DataGridViewTextBoxColumn()
        Stock = New DataGridViewTextBoxColumn()
        Unit = New DataGridViewTextBoxColumn()
        TextBoxSearch = New TextBox()
        TextBoxName = New TextBox()
        ButtonCreate = New Button()
        ButtonUpdate = New Button()
        ButtonDelete = New Button()
        TextBoxId = New TextBox()
        ComboBoxUnit = New ComboBox()
        PanelRefresh = New Panel()
        CType(DataGridViewBarang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Geist Mono Medium", 16F, FontStyle.Bold)
        Label1.Location = New Point(10, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 28)
        Label1.TabIndex = 0
        Label1.Text = "Semua Barang"
        ' 
        ' DataGridViewBarang
        ' 
        DataGridViewBarang.AllowUserToAddRows = False
        DataGridViewBarang.AllowUserToDeleteRows = False
        DataGridViewBarang.BackgroundColor = SystemColors.Control
        DataGridViewBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewBarang.Columns.AddRange(New DataGridViewColumn() {Id, Nama, Stock, Unit})
        DataGridViewBarang.Cursor = Cursors.Hand
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridViewBarang.DefaultCellStyle = DataGridViewCellStyle1
        DataGridViewBarang.Dock = DockStyle.Bottom
        DataGridViewBarang.Location = New Point(9, 270)
        DataGridViewBarang.Name = "DataGridViewBarang"
        DataGridViewBarang.ReadOnly = True
        DataGridViewBarang.Size = New Size(766, 281)
        DataGridViewBarang.TabIndex = 1
        ' 
        ' Id
        ' 
        Id.HeaderText = "Id"
        Id.Name = "Id"
        Id.ReadOnly = True
        Id.Width = 50
        ' 
        ' Nama
        ' 
        Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Nama.HeaderText = "Name"
        Nama.Name = "Nama"
        Nama.ReadOnly = True
        ' 
        ' Stock
        ' 
        Stock.HeaderText = "Stock"
        Stock.Name = "Stock"
        Stock.ReadOnly = True
        ' 
        ' Unit
        ' 
        Unit.HeaderText = "Unit"
        Unit.Name = "Unit"
        Unit.ReadOnly = True
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.BorderStyle = BorderStyle.FixedSingle
        TextBoxSearch.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        TextBoxSearch.Location = New Point(435, 218)
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.PlaceholderText = "Search..."
        TextBoxSearch.Size = New Size(340, 27)
        TextBoxSearch.TabIndex = 2
        ' 
        ' TextBoxName
        ' 
        TextBoxName.BorderStyle = BorderStyle.FixedSingle
        TextBoxName.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        TextBoxName.Location = New Point(12, 72)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.PlaceholderText = "Name"
        TextBoxName.Size = New Size(295, 27)
        TextBoxName.TabIndex = 4
        ' 
        ' ButtonCreate
        ' 
        ButtonCreate.BackColor = Color.CornflowerBlue
        ButtonCreate.Cursor = Cursors.Hand
        ButtonCreate.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        ButtonCreate.Location = New Point(9, 150)
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
        ButtonUpdate.Location = New Point(115, 150)
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
        ButtonDelete.Location = New Point(221, 150)
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
        TextBoxId.Location = New Point(12, 72)
        TextBoxId.Name = "TextBoxId"
        TextBoxId.PlaceholderText = "Id"
        TextBoxId.ReadOnly = True
        TextBoxId.Size = New Size(293, 27)
        TextBoxId.TabIndex = 10
        TextBoxId.Visible = False
        ' 
        ' ComboBoxUnit
        ' 
        ComboBoxUnit.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxUnit.FormattingEnabled = True
        ComboBoxUnit.Location = New Point(12, 105)
        ComboBoxUnit.Name = "ComboBoxUnit"
        ComboBoxUnit.Size = New Size(295, 28)
        ComboBoxUnit.TabIndex = 11
        ' 
        ' PanelRefresh
        ' 
        PanelRefresh.BackgroundImage = CType(resources.GetObject("PanelRefresh.BackgroundImage"), Image)
        PanelRefresh.BackgroundImageLayout = ImageLayout.Zoom
        PanelRefresh.Location = New Point(752, 28)
        PanelRefresh.Name = "PanelRefresh"
        PanelRefresh.Size = New Size(20, 20)
        PanelRefresh.TabIndex = 14
        ' 
        ' FormBarang
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 561)
        Controls.Add(PanelRefresh)
        Controls.Add(ComboBoxUnit)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonUpdate)
        Controls.Add(ButtonCreate)
        Controls.Add(TextBoxSearch)
        Controls.Add(DataGridViewBarang)
        Controls.Add(Label1)
        Controls.Add(TextBoxName)
        Controls.Add(TextBoxId)
        Cursor = Cursors.Hand
        Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        MaximumSize = New Size(800, 600)
        MinimumSize = New Size(800, 600)
        Name = "FormBarang"
        Padding = New Padding(9, 0, 9, 10)
        Text = "Barang"
        CType(DataGridViewBarang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewBarang As DataGridView
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents ComboBoxUnit As ComboBox
    Friend WithEvents PanelRefresh As Panel
End Class
