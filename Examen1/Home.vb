Public Class Home

    Private Sub ListaDeUsuariosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ListaDeUsuariosToolStripMenuItem.Click

        Me.Hide()
        TableOfUsers.Show()

    End Sub

    Private Sub ListaDeDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeDepartamentosToolStripMenuItem.Click

        Me.Hide()
        TableOfDepartament.Show()

    End Sub

    Private Sub ListaDeBienesInstitucionalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeBienesInstitucionalesToolStripMenuItem.Click

        Me.Hide()
        TableOfAssets.Show()

    End Sub

    Private Sub ListaDeEncargadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeEncargadosToolStripMenuItem.Click

        Me.Hide()
        TableOfManagers.Show()

    End Sub
End Class