Imports System.Data.SqlClient
' Jarreth Fleischer Anak Majang (20DDT21F1017)
' Boon Sze Qian (20DDT21F1004)

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click
        Dim connectionString As String = "Data Source=JARRETH\JARRETH;Initial Catalog=Loan;User Id=sa;Password=p@ssword;"
        Dim connection As New SqlConnection(connectionString)

        Dim query As String = "SELECT * FROM admin WHERE  username = @username AND password = @password"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@username", tbUsername.Text)
        command.Parameters.AddWithValue("@password", tbPassword.Text)
        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                Dim username As String = reader("username").ToString()
                Dim password As String = reader("password").ToString()

            End While

            MsgBox("Welcome")
            LoanApprovalForm.Show()
            Controls.Clear()
            InitializeComponent()
            Me.Hide()
        Else
            MsgBox("Invalid!")
            Controls.Clear()
            InitializeComponent()

            Me.Show()
        End If

    End Sub

End Class