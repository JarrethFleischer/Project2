Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
' Jarreth Fleischer Anak Majang (20DDT21F1017)
' Boon Sze Qian (20DDT21F1004)
Public Class DataVisualization
    Private Sub DataVisualization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoanDataSet.vBilEmployee' table. You can move, or remove it, as needed.
        ' Me.VBilEmployeeTableAdapter.Fill(Me.LoanDataSet.vBilEmployee)
        Dim query As String = String.Format("SELECT Department, COUNT(*) AS bil FROM employee GROUP BY Department")
        Dim dt As New DataTable
        Dim connectionString As String = "Data Source=JARRETH\JARRETH;Initial Catalog=Loan;Trusted_Connection=True;"
        Dim connection As New SqlConnection(connectionString)
        Using dad As New SqlDataAdapter(query, connection)
            dad.Fill(dt)
        End Using
        Chart1.DataSource = dt
        Chart1.Series(0).ChartType = SeriesChartType.Column
        Chart1.Legends(0).Enabled = True
        'Chart1.Series(0).YValueMembers = "Bil"

        Chart1.Series(0).XValueMember = "Department"
        Chart1.Series(0).YValueMembers = "Bil"
        Chart1.DataBind()
    End Sub

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
        RiskLevel.Show()
        Me.Hide()

    End Sub

    Private Sub DataVisualizationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataVisualizationToolStripMenuItem.Click
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class