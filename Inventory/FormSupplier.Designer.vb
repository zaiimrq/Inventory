<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSupplier))
        Label1 = New Label()
        ButtonDelete = New Button()
        ButtonUpdate = New Button()
        ButtonCreate = New Button()
        TextBoxName = New TextBox()
        TextBoxId = New TextBox()
        TextBoxSearch = New TextBox()
        DataGridViewSupplier = New DataGridView()
        No = New DataGridViewTextBoxColumn()
        Id = New DataGridViewTextBoxColumn()
        Nama = New DataGridViewTextBoxColumn()
        PanelRefresh = New Panel()
        CType(DataGridViewSupplier, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Geist Mono Medium", 16F, FontStyle.Bold)
        Label1.Location = New Point(10, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 28)
        Label1.TabIndex = 1
        Label1.Text = "Semua Supplier"
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.BackColor = Color.Red
        ButtonDelete.Cursor = Cursors.Hand
        ButtonDelete.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        ButtonDelete.Location = New Point(222, 117)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Padding = New Padding(3)
        ButtonDelete.Size = New Size(83, 36)
        ButtonDelete.TabIndex = 16
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = False
        ' 
        ' ButtonUpdate
        ' 
        ButtonUpdate.BackColor = Color.Orange
        ButtonUpdate.Cursor = Cursors.Hand
        ButtonUpdate.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        ButtonUpdate.Location = New Point(116, 117)
        ButtonUpdate.Name = "ButtonUpdate"
        ButtonUpdate.Padding = New Padding(3)
        ButtonUpdate.Size = New Size(83, 36)
        ButtonUpdate.TabIndex = 15
        ButtonUpdate.Text = "Update"
        ButtonUpdate.UseVisualStyleBackColor = False
        ' 
        ' ButtonCreate
        ' 
        ButtonCreate.BackColor = Color.CornflowerBlue
        ButtonCreate.Cursor = Cursors.Hand
        ButtonCreate.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        ButtonCreate.Location = New Point(10, 117)
        ButtonCreate.Name = "ButtonCreate"
        ButtonCreate.Padding = New Padding(3)
        ButtonCreate.Size = New Size(83, 36)
        ButtonCreate.TabIndex = 14
        ButtonCreate.Text = "Create"
        ButtonCreate.UseVisualStyleBackColor = False
        ' 
        ' TextBoxName
        ' 
        TextBoxName.BorderStyle = BorderStyle.FixedSingle
        TextBoxName.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        TextBoxName.Location = New Point(10, 75)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.PlaceholderText = "Name"
        TextBoxName.Size = New Size(295, 27)
        TextBoxName.TabIndex = 11
        ' 
        ' TextBoxId
        ' 
        TextBoxId.BorderStyle = BorderStyle.FixedSingle
        TextBoxId.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        TextBoxId.Location = New Point(12, 75)
        TextBoxId.Name = "TextBoxId"
        TextBoxId.PlaceholderText = "Id"
        TextBoxId.ReadOnly = True
        TextBoxId.Size = New Size(293, 27)
        TextBoxId.TabIndex = 17
        TextBoxId.Visible = False
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.BorderStyle = BorderStyle.FixedSingle
        TextBoxSearch.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        TextBoxSearch.Location = New Point(418, 156)
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.PlaceholderText = "Search..."
        TextBoxSearch.Size = New Size(256, 27)
        TextBoxSearch.TabIndex = 19
        ' 
        ' DataGridViewSupplier
        ' 
        DataGridViewSupplier.AllowUserToAddRows = False
        DataGridViewSupplier.AllowUserToDeleteRows = False
        DataGridViewSupplier.BackgroundColor = SystemColors.Control
        DataGridViewSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewSupplier.Columns.AddRange(New DataGridViewColumn() {No, Id, Nama})
        DataGridViewSupplier.Cursor = Cursors.Hand
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridViewSupplier.DefaultCellStyle = DataGridViewCellStyle1
        DataGridViewSupplier.Dock = DockStyle.Bottom
        DataGridViewSupplier.Location = New Point(10, 189)
        DataGridViewSupplier.Name = "DataGridViewSupplier"
        DataGridViewSupplier.ReadOnly = True
        DataGridViewSupplier.Size = New Size(664, 262)
        DataGridViewSupplier.TabIndex = 18
        ' 
        ' No
        ' 
        No.HeaderText = "No"
        No.Name = "No"
        No.ReadOnly = True
        No.Width = 50
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
        ' PanelRefresh
        ' 
        PanelRefresh.BackgroundImage = CType(resources.GetObject("PanelRefresh.BackgroundImage"), Image)
        PanelRefresh.BackgroundImageLayout = ImageLayout.Zoom
        PanelRefresh.Cursor = Cursors.Hand
        PanelRefresh.Location = New Point(654, 28)
        PanelRefresh.Name = "PanelRefresh"
        PanelRefresh.Size = New Size(20, 20)
        PanelRefresh.TabIndex = 20
        ' 
        ' FormSupplier
        ' 
        AutoScaleDimensions = New SizeF(11F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(684, 461)
        Controls.Add(PanelRefresh)
        Controls.Add(TextBoxSearch)
        Controls.Add(DataGridViewSupplier)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonUpdate)
        Controls.Add(ButtonCreate)
        Controls.Add(TextBoxName)
        Controls.Add(TextBoxId)
        Controls.Add(Label1)
        Font = New Font("Geist Mono Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        MaximumSize = New Size(700, 500)
        MinimumSize = New Size(700, 500)
        Name = "FormSupplier"
        Padding = New Padding(10, 0, 10, 10)
        Text = "Suppliers"
        CType(DataGridViewSupplier, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents DataGridViewSupplier As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents PanelRefresh As Panel
End Class
