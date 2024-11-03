<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProfile))
        Label1 = New Label()
        TextBoxName = New TextBox()
        TextBoxUsername = New TextBox()
        Label2 = New Label()
        TextBoxPassword = New TextBox()
        Label3 = New Label()
        ButtonUpdate = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' TextBoxName
        ' 
        TextBoxName.BorderStyle = BorderStyle.FixedSingle
        TextBoxName.Font = New Font("Geist Mono Medium", 12F, FontStyle.Bold)
        TextBoxName.Location = New Point(12, 106)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(326, 27)
        TextBoxName.TabIndex = 1
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.BorderStyle = BorderStyle.FixedSingle
        TextBoxUsername.Font = New Font("Geist Mono Medium", 12F, FontStyle.Bold)
        TextBoxUsername.Location = New Point(12, 159)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(326, 27)
        TextBoxUsername.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 2
        Label2.Text = "Username"
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.BorderStyle = BorderStyle.FixedSingle
        TextBoxPassword.Font = New Font("Geist Mono Medium", 12F, FontStyle.Bold)
        TextBoxPassword.Location = New Point(12, 212)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(326, 27)
        TextBoxPassword.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 4
        Label3.Text = "Password"
        ' 
        ' ButtonUpdate
        ' 
        ButtonUpdate.BackColor = Color.Orange
        ButtonUpdate.Cursor = Cursors.Hand
        ButtonUpdate.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        ButtonUpdate.Location = New Point(245, 245)
        ButtonUpdate.Name = "ButtonUpdate"
        ButtonUpdate.Padding = New Padding(3)
        ButtonUpdate.Size = New Size(92, 36)
        ButtonUpdate.TabIndex = 9
        ButtonUpdate.Text = "Update"
        ButtonUpdate.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Geist Mono Medium", 16F, FontStyle.Bold)
        Label5.Location = New Point(12, 33)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 28)
        Label5.TabIndex = 11
        Label5.Text = "Profile"
        ' 
        ' FormProfile
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(349, 361)
        Controls.Add(Label5)
        Controls.Add(ButtonUpdate)
        Controls.Add(TextBoxPassword)
        Controls.Add(Label3)
        Controls.Add(TextBoxUsername)
        Controls.Add(Label2)
        Controls.Add(TextBoxName)
        Controls.Add(Label1)
        Font = New Font("Geist Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlText
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        MaximumSize = New Size(365, 400)
        MinimizeBox = False
        MinimumSize = New Size(365, 400)
        Name = "FormProfile"
        Padding = New Padding(9, 10, 9, 10)
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Profile"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents Label5 As Label
End Class
