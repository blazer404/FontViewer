Public Class main_form

    Public ComboFonts As New Drawing.Text.InstalledFontCollection

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim installedFonts As New System.Drawing.Text.InstalledFontCollection
        ComboFontStyle.DataSource = installedFonts.Families
        ComboFontStyle.DisplayMember = "Name"
        Try
            Label1.Font = New Font(ComboFonts.Families(ComboFontStyle.SelectedIndex), 12, FontStyle.Regular)
        Catch
            Try
                Label1.Font = New Font(ComboFonts.Families(ComboFontStyle.SelectedIndex), 12, FontStyle.Bold)
            Catch
                Label1.Font = New Font(ComboFonts.Families(ComboFontStyle.SelectedIndex), 12, FontStyle.Italic)
            End Try
        End Try
    End Sub

    Private Sub ComboFontStyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboFontStyle.SelectedIndexChanged
        Try
            Label1.Font = New Font(ComboFonts.Families(ComboFontStyle.SelectedIndex), 12, FontStyle.Regular)
        Catch
            Try
                Label1.Font = New Font(ComboFonts.Families(ComboFontStyle.SelectedIndex), 12, FontStyle.Bold)
            Catch
                Label1.Font = New Font(ComboFonts.Families(ComboFontStyle.SelectedIndex), 12, FontStyle.Italic)
            End Try
        End Try
    End Sub

End Class