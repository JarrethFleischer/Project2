<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiskLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataVisualizationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Bisque
        Me.Label6.Location = New System.Drawing.Point(25, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(440, 54)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Why loan from us?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(529, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(369, 50)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Repayment Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(32, 383)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(269, 50)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "RM 801,500"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(25, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(393, 50)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Total Money Lent:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(32, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 50)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "405 person"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(25, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 50)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Loan Disbursed:"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(483, 111)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(462, 378)
        Me.Chart1.TabIndex = 10
        Me.Chart1.Text = "Chart1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.LoanApplicationToolStripMenuItem, Me.LoanApprovalToolStripMenuItem, Me.RiskLevelToolStripMenuItem, Me.DataVisualizationToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(945, 28)
        Me.MenuStrip1.TabIndex = 11
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
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(945, 491)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Chart1 As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanApprovalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiskLevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataVisualizationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
