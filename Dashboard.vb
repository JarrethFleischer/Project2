Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
' Jarreth Fleischer Anak Majang (20DDT21F1017)
' Boon Sze Qian (20DDT21F1004)
Public Class Dashboard
    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Me.Hide()
        Me.Show()
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
        RiskLevel.Show()
        Me.Hide()
    End Sub

    Private Sub DataVisualizationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataVisualizationToolStripMenuItem.Click
        DataVisualization.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = String.Format("SELECT Department, COUNT(*) AS bil FROM employee GROUP BY Department")
        Dim dt As New DataTable
        Dim connectionString As String = "Data Source=JARRETH\JARRETH;Initial Catalog=Loan;Trusted_Connection=True;"
        Dim connection As New SqlConnection(connectionString)
        Using dad As New SqlDataAdapter(query, connection)
            dad.Fill(dt)
        End Using
        Chart1.DataSource = dt
        Chart1.Series(0).ChartType = SeriesChartType.Pie
        Chart1.Legends(0).Enabled = True
        'Chart1.Series(0).YValueMembers = "Bil"

        Chart1.Series(0).XValueMember = "Department"
        Chart1.Series(0).YValueMembers = "Bil"
        Chart1.DataBind()
    End Sub
End Class