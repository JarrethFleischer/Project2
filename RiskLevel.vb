' Jarreth Fleischer Anak Majang (20DDT21F1017)
' Boon Sze Qian (20DDT21F1004)

Public Class RiskLevel
    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dashboard.Show()
        Me.Hide()


    End Sub

    Private Sub LoanApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanApplicationToolStripMenuItem.Click
        LoanApplicationForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoanApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanApprovalToolStripMenuItem.Click
        Login.Show()

        Me.Hide()

    End Sub

    Private Sub RiskLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RiskLevelToolStripMenuItem.Click
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub DataVisualizationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataVisualizationToolStripMenuItem.Click
        DataVisualization.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class