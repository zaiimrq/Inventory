<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormShowTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormShowTransaction))
        ListBoxTransaction = New ListBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ListBoxTransaction
        ' 
        ListBoxTransaction.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ListBoxTransaction.BackColor = SystemColors.Control
        ListBoxTransaction.BorderStyle = BorderStyle.None
        ListBoxTransaction.Font = New Font("Geist Mono", 12F)
        ListBoxTransaction.FormattingEnabled = True
        ListBoxTransaction.ItemHeight = 20
        ListBoxTransaction.Location = New Point(18, 79)
        ListBoxTransaction.Margin = New Padding(4)
        ListBoxTransaction.Name = "ListBoxTransaction"
        ListBoxTransaction.Size = New Size(348, 400)
        ListBoxTransaction.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Geist Mono Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(18, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 20)
        Label1.TabIndex = 1
        Label1.Text = "List Of Items"
        ' 
        ' FormShowTransaction
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 461)
        Controls.Add(Label1)
        Controls.Add(ListBoxTransaction)
        Font = New Font("Geist Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        MaximizeBox = False
        MaximumSize = New Size(400, 500)
        MinimizeBox = False
        MinimumSize = New Size(400, 500)
        Name = "FormShowTransaction"
        Padding = New Padding(14, 13, 14, 13)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Show Transaction"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBoxTransaction As ListBox
    Friend WithEvents Label1 As Label
End Class
