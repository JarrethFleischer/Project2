' Jarreth Fleischer Anak Majang (20DDT21F1017)
' Boon Sze Qian (20DDT21F1004)
Public Class Welcome
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNLoan.Click
        LoanApplicationForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RiskLevel.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dashboard.Show()
        Me.Hide()

    End Sub

End Class