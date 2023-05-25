Imports System.Data.SqlClient
Imports System.Windows
' Jarreth Fleischer Anak Majang (20DDT21F1017)
' Boon Sze Qian (20DDT21F1004)
Public Class LoanApplicationForm
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim folderBrowserDialog As New FolderBrowserDialog()

        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedFolder As String = folderBrowserDialog.SelectedPath
            ' Do something with the selected folder path
        End If
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ApplicationFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationFormToolStripMenuItem.Click
        Me.Hide()
        Me.Show()
        Controls.Clear()
        InitializeComponent()

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connectionString As String = "Data Source=JARRETH\JARRETH;Initial Catalog=Loan;User Id=sa;Password=p@ssword;"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()

        Dim query As String = "INSERT INTO loanapplication(businessname, businesstype, address, phone, faxno, approxmonthly, annualincome, loanamount, loanterm) VALUES (@businessname, @businesstype, @address, @phone, @faxno, @approxmonthly, @annualincome, @loanamount, @loanterm)"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@businessname", tbBusinessname.Text)
        command.Parameters.AddWithValue("@businesstype", tbBusinesstype.Text)
        command.Parameters.AddWithValue("@address", tbAddress.Text)
        command.Parameters.AddWithValue("@phone", tbPhone.Text)
        command.Parameters.AddWithValue("@faxno", tbFax.Text)
        command.Parameters.AddWithValue("@approxmonthly", tbMonthly.Text)
        command.Parameters.AddWithValue("@annualincome", tbAnnual.Text)
        command.Parameters.AddWithValue("@loanamount", tbLoanAmount.Text)
        command.Parameters.AddWithValue("@loanterm", tbLoanTerm.Text)
        command.ExecuteNonQuery()
        connection.Close()
        MsgBox("Approval will be notified soon!")
        Controls.Clear()
        InitializeComponent()


    End Sub
End Class