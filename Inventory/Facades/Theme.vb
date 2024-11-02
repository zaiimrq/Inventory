Imports Inventory.Enums

Namespace Facades
    Module Theme
        Public Property DarkColor = Color.FromArgb(45, 45, 48)
        Public Event SwitchedTheme()
        Public Function IsDark() As Boolean
            Return My.Settings.Theme = ThemeEnum.dark
        End Function
        Public Sub Dark(Form As Form)
            My.Settings.Theme = ThemeEnum.dark
            My.Settings.ThemeToggleIsChecked = True
            My.Settings.Save()

            RaiseEvent SwitchedTheme()
            Theme.Apply(Form)
        End Sub

        Public Sub Light(Form As Form)
            My.Settings.Theme = ThemeEnum.light
            My.Settings.ThemeToggleIsChecked = False
            My.Settings.Save()

            RaiseEvent SwitchedTheme()
            Theme.Apply(Form)
        End Sub
        Public Sub Apply(Form As Form)
            If Theme.IsDark() Then
                Form.BackColor = DarkColor
                Form.ForeColor = Color.White
            Else
                Form.BackColor = Color.White
                Form.ForeColor = Color.Black
            End If
        End Sub
    End Module
End Namespace