Imports Inventory.Enums

Namespace Facades
    Module Theme
        Public Property DarkColor = Color.FromArgb(45, 45, 48)
        Public Event SwitchedTheme()
        Public Function IsDark() As Boolean
            Return My.Settings.Theme = ThemeEnum.dark
        End Function
        Public Sub Dark()
            My.Settings.Theme = ThemeEnum.dark
            My.Settings.ThemeToggleIsChecked = True
            My.Settings.Save()

            RaiseEvent SwitchedTheme()
        End Sub

        Public Sub Light()
            My.Settings.Theme = ThemeEnum.light
            My.Settings.ThemeToggleIsChecked = False
            My.Settings.Save()

            RaiseEvent SwitchedTheme()
        End Sub
        Public Sub Apply(Form As Form)
            If Theme.IsDark() Then
                Form.BackColor = DarkColor
                Form.ForeColor = Color.White
            Else
                Form.BackColor = Color.White
                Form.ForeColor = Color.Black
            End If

            For Each Control As Control In Form.Controls
                If TypeOf Control Is DataGridView Then
                    Dim DGV As DataGridView = CType(Control, DataGridView)

                    If Theme.IsDark Then
                        DGV.DefaultCellStyle.ForeColor = Color.White
                        DGV.DefaultCellStyle.BackColor = Theme.DarkColor
                        DGV.BackgroundColor = Theme.DarkColor
                        DGV.ForeColor = Color.White
                        DGV.ColumnHeadersDefaultCellStyle.BackColor = Theme.DarkColor
                        DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                        DGV.EnableHeadersVisualStyles = False
                        DGV.RowHeadersDefaultCellStyle.BackColor = Theme.DarkColor
                        DGV.RowHeadersDefaultCellStyle.ForeColor = Color.White
                    Else
                        DGV.DefaultCellStyle.ForeColor = Color.Black
                        DGV.DefaultCellStyle.BackColor = SystemColors.Control
                        DGV.BackgroundColor = SystemColors.Control
                        DGV.ForeColor = Color.Black
                        DGV.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control
                        DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
                        DGV.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control
                        DGV.RowHeadersDefaultCellStyle.ForeColor = Color.Black
                        DGV.EnableHeadersVisualStyles = True
                    End If
                End If
            Next
        End Sub
    End Module
End Namespace