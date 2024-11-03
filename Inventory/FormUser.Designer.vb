<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        Label1 = New Label()
        DataGridViewUser = New DataGridView()
        No = New DataGridViewTextBoxColumn()
        Id = New DataGridViewTextBoxColumn()
        Nama = New DataGridViewTextBoxColumn()
        Username = New DataGridViewTextBoxColumn()
        Password = New DataGridViewTextBoxColumn()
        TextBoxSearch = New TextBox()
        TextBoxName = New TextBox()
        ButtonCreate = New Button()
        ButtonUpdate = New Button()
        ButtonDelete = New Button()
        TextBoxId = New TextBox()
        TextBoxUsername = New TextBox()
        TextBoxPassword = New TextBox()
        PanelRefresh = New Panel()
        CType(DataGridViewUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Geist Mono Medium", 16F, FontStyle.Bold)
        Label1.Location = New Point(10, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 28)
        Label1.TabIndex = 0
        Label1.Text = "Semua Users"
        ' 
        ' DataGridViewUser
        ' 
        DataGridViewUser.AllowUserToAddRows = False
        DataGridViewUser.AllowUserToDeleteRows = False
        DataGridViewUser.BackgroundColor = SystemColors.Control
        DataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewUser.Columns.AddRange(New DataGridViewColumn() {No, Id, Nama, Username, Password})
        DataGridViewUser.Cursor = Cursors.Hand
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridViewUser.DefaultCellStyle = DataGridViewCellStyle1
        DataGridViewUser.Dock = DockStyle.Bottom
        DataGridViewUser.Location = New Point(9, 270)
        DataGridViewUser.Name = "DataGridViewUser"
        DataGridViewUser.ReadOnly = True
        DataGridViewUser.Size = New Size(766, 281)
        DataGridViewUser.TabIndex = 1
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
        Id.Width = 50
        ' 
        ' Nama
        ' 
        Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Nama.HeaderText = "Name"
        Nama.Name = "Nama"
        Nama.ReadOnly = True
        ' 
        ' Username
        ' 
        Username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Username.HeaderText = "Username"
        Username.Name = "Username"
        Username.ReadOnly = True
        ' 
        ' Password
        ' 
        Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Password.HeaderText = "Password"
        Password.Name = "Password"
        Password.ReadOnly = True
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
        ButtonCreate.BackgroundImageLayout = ImageLayout.Zoom
        ButtonCreate.Cursor = Cursors.Hand
        ButtonCreate.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        ButtonCreate.Location = New Point(9, 178)
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
        ButtonUpdate.Location = New Point(115, 178)
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
        ButtonDelete.Location = New Point(221, 178)
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
        ' TextBoxUsername
        ' 
        TextBoxUsername.BorderStyle = BorderStyle.FixedSingle
        TextBoxUsername.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        TextBoxUsername.Location = New Point(12, 105)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.PlaceholderText = "Username"
        TextBoxUsername.Size = New Size(295, 27)
        TextBoxUsername.TabIndex = 11
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.BorderStyle = BorderStyle.FixedSingle
        TextBoxPassword.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        TextBoxPassword.Location = New Point(12, 138)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PlaceholderText = "Password"
        TextBoxPassword.Size = New Size(295, 27)
        TextBoxPassword.TabIndex = 12
        ' 
        ' PanelRefresh
        ' 
        PanelRefresh.BackgroundImage = CType(resources.GetObject("PanelRefresh.BackgroundImage"), Image)
        PanelRefresh.BackgroundImageLayout = ImageLayout.Zoom
        PanelRefresh.Location = New Point(752, 28)
        PanelRefresh.Name = "PanelRefresh"
        PanelRefresh.Size = New Size(20, 20)
        PanelRefresh.TabIndex = 13
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 561)
        Controls.Add(PanelRefresh)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxUsername)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonUpdate)
        Controls.Add(ButtonCreate)
        Controls.Add(TextBoxSearch)
        Controls.Add(DataGridViewUser)
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
        Name = "FormUser"
        Padding = New Padding(9, 0, 9, 10)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Users"
        CType(DataGridViewUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewUser As DataGridView
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents PanelRefresh As Panel
End Class
