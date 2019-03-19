<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formImports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formImports))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmHelp = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdProcess = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCSV = New System.Windows.Forms.Button()
        Me.txtCSV = New System.Windows.Forms.TextBox()
        Me.OpenFileImport = New System.Windows.Forms.OpenFileDialog()
        Me.listErrors = New System.Windows.Forms.ListBox()
        Me.lblErrors = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Snow
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdReset)
        Me.Panel1.Controls.Add(Me.cmHelp)
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Controls.Add(Me.cmdProcess)
        Me.Panel1.Controls.Add(Me.cmdStart)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'cmdReset
        '
        resources.ApplyResources(Me.cmdReset, "cmdReset")
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmHelp
        '
        resources.ApplyResources(Me.cmHelp, "cmHelp")
        Me.cmHelp.Name = "cmHelp"
        Me.cmHelp.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        resources.ApplyResources(Me.cmdClose, "cmdClose")
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdProcess
        '
        resources.ApplyResources(Me.cmdProcess, "cmdProcess")
        Me.cmdProcess.Name = "cmdProcess"
        Me.cmdProcess.UseVisualStyleBackColor = True
        '
        'cmdStart
        '
        resources.ApplyResources(Me.cmdStart, "cmdStart")
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdCSV)
        Me.GroupBox1.Controls.Add(Me.txtCSV)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'cmdCSV
        '
        resources.ApplyResources(Me.cmdCSV, "cmdCSV")
        Me.cmdCSV.Name = "cmdCSV"
        Me.cmdCSV.UseVisualStyleBackColor = True
        '
        'txtCSV
        '
        resources.ApplyResources(Me.txtCSV, "txtCSV")
        Me.txtCSV.Name = "txtCSV"
        '
        'OpenFileImport
        '
        Me.OpenFileImport.FileName = "imports"
        '
        'listErrors
        '
        Me.listErrors.FormattingEnabled = True
        resources.ApplyResources(Me.listErrors, "listErrors")
        Me.listErrors.Name = "listErrors"
        '
        'lblErrors
        '
        resources.ApplyResources(Me.lblErrors, "lblErrors")
        Me.lblErrors.Name = "lblErrors"
        '
        'lblSummary
        '
        resources.ApplyResources(Me.lblSummary, "lblSummary")
        Me.lblSummary.BackColor = System.Drawing.SystemColors.Control
        Me.lblSummary.Name = "lblSummary"
        '
        'formImports
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.lblErrors)
        Me.Controls.Add(Me.listErrors)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "formImports"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdProcess As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCSV As System.Windows.Forms.Button
    Friend WithEvents txtCSV As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileImport As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmHelp As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listErrors As System.Windows.Forms.ListBox
    Friend WithEvents lblErrors As System.Windows.Forms.Label
    Friend WithEvents lblSummary As System.Windows.Forms.Label
End Class
