Imports System.Data.SqlClient
Imports System.Net.NetworkInformation
' Jarreth Fleischer Anak Majang (20DDT21F1017)
' Boon Sze Qian (20DDT21F1004)
Public Class LoanApprovalForm
    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dashboard.Show()
        Me.Hide()

    End Sub

    Private Sub LoanApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanApplicationToolStripMenuItem.Click
        LoanApplicationForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoanApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanApprovalToolStripMenuItem.Click
        Me.Hide()
        Me.Show()
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

        Dim query As String = "SELECT * FROM loanapplication WHERE businessname = @businessname"
        Dim command As New SqlCommand(query, connection)

        command.Parameters.AddWithValue("@businessname", tbName.Text)

        connection.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()

        While reader.Read()
            tbName.Text = reader("businessname").ToString
            tbType.Text = reader("businesstype").ToString
            tbAddress.Text = reader("address").ToString()
            tbPhone.Text = reader("phone").ToString()
            tbFax.Text = reader("faxno").ToString()
            tbMonthly.Text = reader("approxmonthly").ToString()
            tbAnnual.Text = reader("annualincome").ToString()
            tbLoanRQ.Text = reader("loanamount").ToString()
            tbLoanTermRQ.Text = reader("loanterm").ToString()
        End While

        Dim jumlah As Double = Val(tbLoanRQ.Text)
        Dim bayar As Int16 = Val(tbLoanTermRQ.Text)
        If bayar < 5 Then
            tbRepayment.Text = bayar.ToString
        Else
            tbRepayment.Text = bayar.ToString - 2
        End If
        If jumlah > 200000 Then
            tbLoanApprove.Text = jumlah.ToString("c2") * 0.9
        Else
            tbLoanApprove.Text = jumlah.ToString("c2")
        End If

        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Notifying the Requester that their request has been approved")
        Me.Hide()
        Welcome.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Notifying the Requester that their request has been rejected")
        Me.Hide()
        Welcome.Show()
    End Sub

End Class