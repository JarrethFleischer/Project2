<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataVisualization
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataVisualization))
        Me.LoanDataSet = New Project2.LoanDataSet()
        Me.VBilEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VBilEmployeeTableAdapter = New Project2.LoanDataSetTableAdapters.vBilEmployeeTableAdapter()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiskLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataVisualizationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.LoanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBilEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoanDataSet
        '
        Me.LoanDataSet.DataSetName = "LoanDataSet"
        Me.LoanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VBilEmployeeBindingSource
        '
        Me.VBilEmployeeBindingSource.DataMember = "vBilEmployee"
        Me.VBilEmployeeBindingSource.DataSource = Me.LoanDataSet
        '
        'VBilEmployeeTableAdapter
        '
        Me.VBilEmployeeTableAdapter.ClearBeforeFill = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(2, 29)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(801, 420)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.LoanApplicationToolStripMenuItem, Me.LoanApprovalToolStripMenuItem, Me.RiskLevelToolStripMenuItem, Me.DataVisualizationToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
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
        'DataVisualization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Chart1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DataVisualization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataVisualization"
        CType(Me.LoanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBilEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoanDataSet As LoanDataSet
    Friend WithEvents VBilEmployeeBindingSource As BindingSource
    Friend WithEvents VBilEmployeeTableAdapter As LoanDataSetTableAdapters.vBilEmployeeTableAdapter
    Friend WithEvents Chart1 As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanApprovalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiskLevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataVisualizationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
