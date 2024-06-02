Public Class FormEmploye
    Private currentChildForm As Form
    Private Sub OpenChildForm(ChildForm As Form)
        'open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = ChildForm
        'end
        ChildForm.TopLevel = False
        ChildForm.FormBorderStyle = FormBorderStyle.None
        ChildForm.Dock = DockStyle.Fill
        ChildForm.BackColor = Color.FromArgb(186, 2, 3)
        PanelEmp.Controls.Add(ChildForm)
        PanelEmp.Tag = ChildForm
        ChildForm.BringToFront()
        ChildForm.Show()
    End Sub
    Private Sub BtnFEmp_Click(sender As Object, e As EventArgs) Handles BtnFEmp.Click
        OpenChildForm(New Fiche_Employe)
    End Sub
End Class