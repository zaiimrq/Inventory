<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSignIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSignIn))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        ButtonSignIn = New Button()
        Label2 = New Label()
        TextBoxPassword = New TextBox()
        Label1 = New Label()
        TextBoxUsername = New TextBox()
        Label4 = New Label()
        LinkLabelZaiimrq = New LinkLabel()
        Label5 = New Label()
        LinkLabelSan = New LinkLabel()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(30, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(400, 300)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel1.BackColor = Color.CornflowerBlue
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(ButtonSignIn)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBoxPassword)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBoxUsername)
        Panel1.Font = New Font("Geist Mono SemiBold", 12F, FontStyle.Bold)
        Panel1.Location = New Point(452, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(296, 300)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Location = New Point(121, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(60, 60)
        Panel2.TabIndex = 5
        ' 
        ' ButtonSignIn
        ' 
        ButtonSignIn.Cursor = Cursors.Hand
        ButtonSignIn.Font = New Font("Geist Mono", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSignIn.Location = New Point(16, 222)
        ButtonSignIn.Name = "ButtonSignIn"
        ButtonSignIn.Size = New Size(264, 38)
        ButtonSignIn.TabIndex = 4
        ButtonSignIn.Text = "Sign In"
        ButtonSignIn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxPassword.BorderStyle = BorderStyle.FixedSingle
        TextBoxPassword.Location = New Point(16, 168)
        TextBoxPassword.MaxLength = 255
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PasswordChar = "*"c
        TextBoxPassword.Size = New Size(264, 27)
        TextBoxPassword.TabIndex = 2
        TextBoxPassword.WordWrap = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxUsername.BorderStyle = BorderStyle.FixedSingle
        TextBoxUsername.Location = New Point(16, 105)
        TextBoxUsername.MaxLength = 255
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(264, 27)
        TextBoxUsername.TabIndex = 0
        TextBoxUsername.WordWrap = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Geist Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(25, 336)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 16)
        Label4.TabIndex = 2
        Label4.Text = "Built with ❤️ by "
        ' 
        ' LinkLabelZaiimrq
        ' 
        LinkLabelZaiimrq.AutoSize = True
        LinkLabelZaiimrq.Cursor = Cursors.Hand
        LinkLabelZaiimrq.Font = New Font("Geist Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabelZaiimrq.Location = New Point(155, 336)
        LinkLabelZaiimrq.Name = "LinkLabelZaiimrq"
        LinkLabelZaiimrq.Size = New Size(63, 16)
        LinkLabelZaiimrq.TabIndex = 3
        LinkLabelZaiimrq.TabStop = True
        LinkLabelZaiimrq.Text = "zaiimrq"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Geist Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(218, 336)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 16)
        Label5.TabIndex = 4
        Label5.Text = "and"
        ' 
        ' LinkLabelSan
        ' 
        LinkLabelSan.AutoSize = True
        LinkLabelSan.Cursor = Cursors.Hand
        LinkLabelSan.Font = New Font("Geist Mono", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabelSan.Location = New Point(249, 336)
        LinkLabelSan.Name = "LinkLabelSan"
        LinkLabelSan.Size = New Size(151, 16)
        LinkLabelSan.TabIndex = 5
        LinkLabelSan.TabStop = True
        LinkLabelSan.Text = "sanwiliamsofficial"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Geist Mono SemiBold", 10F, FontStyle.Bold)
        Label6.Location = New Point(30, 1)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 18)
        Label6.TabIndex = 6
        Label6.Text = "Welcome Back"
        ' 
        ' FormSignIn
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 361)
        Controls.Add(Label6)
        Controls.Add(LinkLabelSan)
        Controls.Add(Label5)
        Controls.Add(LinkLabelZaiimrq)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Font = New Font("Geist Mono SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        MaximizeBox = False
        MaximumSize = New Size(800, 400)
        MinimizeBox = False
        MinimumSize = New Size(800, 400)
        Name = "FormSignIn"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonSignIn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabelZaiimrq As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabelSan As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel

End Class
