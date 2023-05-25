<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanApprovalForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoanApprovalForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbLoanTermRQ = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbRepayment = New System.Windows.Forms.TextBox()
        Me.tbLoanApprove = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbLoanRQ = New System.Windows.Forms.TextBox()
        Me.tbAnnual = New System.Windows.Forms.TextBox()
        Me.tbMonthly = New System.Windows.Forms.TextBox()
        Me.tbFax = New System.Windows.Forms.TextBox()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.tbType = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiskLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataVisualizationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(376, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loan Approval"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.tbLoanTermRQ)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.tbRepayment)
        Me.Panel1.Controls.Add(Me.tbLoanApprove)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.tbLoanRQ)
        Me.Panel1.Controls.Add(Me.tbAnnual)
        Me.Panel1.Controls.Add(Me.tbMonthly)
        Me.Panel1.Controls.Add(Me.tbFax)
        Me.Panel1.Controls.Add(Me.tbPhone)
        Me.Panel1.Controls.Add(Me.tbAddress)
        Me.Panel1.Controls.Add(Me.tbType)
        Me.Panel1.Controls.Add(Me.tbName)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(40, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 363)
        Me.Panel1.TabIndex = 1
        '
        'tbLoanTermRQ
        '
        Me.tbLoanTermRQ.Location = New System.Drawing.Point(696, 171)
        Me.tbLoanTermRQ.Name = "tbLoanTermRQ"
        Me.tbLoanTermRQ.ReadOnly = True
        Me.tbLoanTermRQ.Size = New System.Drawing.Size(249, 23)
        Me.tbLoanTermRQ.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(522, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 15)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Loan Term Requested:"
        '
        'tbRepayment
        '
        Me.tbRepayment.Location = New System.Drawing.Point(696, 252)
        Me.tbRepayment.Name = "tbRepayment"
        Me.tbRepayment.ReadOnly = True
        Me.tbRepayment.Size = New System.Drawing.Size(249, 23)
        Me.tbRepayment.TabIndex = 22
        '
        'tbLoanApprove
        '
        Me.tbLoanApprove.Location = New System.Drawing.Point(696, 213)
        Me.tbLoanApprove.Name = "tbLoanApprove"
        Me.tbLoanApprove.ReadOnly = True
        Me.tbLoanApprove.Size = New System.Drawing.Size(249, 23)
        Me.tbLoanApprove.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(522, 260)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Repayment Term:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(522, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Loan Amount Approved:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(429, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(771, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 53)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Reject"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SpringGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(886, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 57)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Approve"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tbLoanRQ
        '
        Me.tbLoanRQ.Location = New System.Drawing.Point(696, 132)
        Me.tbLoanRQ.Name = "tbLoanRQ"
        Me.tbLoanRQ.ReadOnly = True
        Me.tbLoanRQ.Size = New System.Drawing.Size(249, 23)
        Me.tbLoanRQ.TabIndex = 15
        '
        'tbAnnual
        '
        Me.tbAnnual.Location = New System.Drawing.Point(696, 83)
        Me.tbAnnual.Name = "tbAnnual"
        Me.tbAnnual.ReadOnly = True
        Me.tbAnnual.Size = New System.Drawing.Size(249, 23)
        Me.tbAnnual.TabIndex = 14
        '
        'tbMonthly
        '
        Me.tbMonthly.Location = New System.Drawing.Point(696, 25)
        Me.tbMonthly.Name = "tbMonthly"
        Me.tbMonthly.ReadOnly = True
        Me.tbMonthly.Size = New System.Drawing.Size(249, 23)
        Me.tbMonthly.TabIndex = 13
        '
        'tbFax
        '
        Me.tbFax.Location = New System.Drawing.Point(149, 303)
        Me.tbFax.Name = "tbFax"
        Me.tbFax.ReadOnly = True
        Me.tbFax.Size = New System.Drawing.Size(274, 23)
        Me.tbFax.TabIndex = 12
        '
        'tbPhone
        '
        Me.tbPhone.Location = New System.Drawing.Point(149, 249)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.ReadOnly = True
        Me.tbPhone.Size = New System.Drawing.Size(274, 23)
        Me.tbPhone.TabIndex = 11
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(149, 132)
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.ReadOnly = True
        Me.tbAddress.Size = New System.Drawing.Size(274, 89)
        Me.tbAddress.TabIndex = 10
        '
        'tbType
        '
        Me.tbType.Location = New System.Drawing.Point(149, 83)
        Me.tbType.Name = "tbType"
        Me.tbType.ReadOnly = True
        Me.tbType.Size = New System.Drawing.Size(274, 23)
        Me.tbType.TabIndex = 9
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(149, 25)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(274, 23)
        Me.tbName.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(522, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Loan Amount Requested:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(583, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Annual Income:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(528, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Approx Monthly Income:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Fax No.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Business Phone No.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(103, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Business Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Business Name:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.LoanApplicationToolStripMenuItem, Me.LoanApprovalToolStripMenuItem, Me.RiskLevelToolStripMenuItem, Me.DataVisualizationToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1061, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'LoanApplicationToolStripMenuItem
        '
        Me.LoanApplicationToolStripMenuItem.Name = "LoanApplicationToolStripMenuItem"
        Me.LoanApplicationToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.LoanApplicationToolStripMenuItem.Text = "Loan Application"
        '
        'LoanApprovalToolStripMenuItem
        '
        Me.LoanApprovalToolStripMenuItem.Name = "LoanApprovalToolStripMenuItem"
        Me.LoanApprovalToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.LoanApprovalToolStripMenuItem.Text = "Loan Approval"
        '
        'RiskLevelToolStripMenuItem
        '
        Me.RiskLevelToolStripMenuItem.Name = "RiskLevelToolStripMenuItem"
        Me.RiskLevelToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.RiskLevelToolStripMenuItem.Text = "Risk Level"
        '
        'DataVisualizationToolStripMenuItem
        '
        Me.DataVisualizationToolStripMenuItem.Name = "DataVisualizationToolStripMenuItem"
        Me.DataVisualizationToolStripMenuItem.Size = New System.Drawing.Size(143, 24)
        Me.DataVisualizationToolStripMenuItem.Text = "Data Visualization"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LoanApprovalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1061, 506)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LoanApprovalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Approval "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents tbLoanRQ As TextBox
    Friend WithEvents tbAnnual As TextBox
    Friend WithEvents tbMonthly As TextBox
    Friend WithEvents tbFax As TextBox
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents tbType As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanApprovalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiskLevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataVisualizationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbLoanTermRQ As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbRepayment As TextBox
    Friend WithEvents tbLoanApprove As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
