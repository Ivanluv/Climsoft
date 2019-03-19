<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntryForms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntryForms))
        Me.lstvForms = New System.Windows.Forms.ListView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStriptxtSpace = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripApply = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripReset = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdHelp = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupSelections = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtEMonth = New System.Windows.Forms.TextBox()
        Me.txtEYear = New System.Windows.Forms.TextBox()
        Me.txtBmonth = New System.Windows.Forms.TextBox()
        Me.txtBYear = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkSkipUploaded = New System.Windows.Forms.CheckBox()
        Me.optSelectRecords = New System.Windows.Forms.RadioButton()
        Me.optAllRecords = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupSelections.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvForms
        '
        Me.lstvForms.AllowColumnReorder = True
        Me.lstvForms.AllowDrop = True
        Me.lstvForms.CheckBoxes = True
        Me.lstvForms.FullRowSelect = True
        Me.lstvForms.GridLines = True
        Me.lstvForms.LabelEdit = True
        resources.ApplyResources(Me.lstvForms, "lstvForms")
        Me.lstvForms.Name = "lstvForms"
        Me.lstvForms.UseCompatibleStateImageBehavior = False
        Me.lstvForms.View = System.Windows.Forms.View.Details
        '
        'ToolStrip1
        '
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStriptxtSpace, Me.ToolStripApply, Me.ToolStripSeparator4, Me.ToolStripSeparator1, Me.ToolStripReset, Me.ToolStripSeparator3, Me.ToolStripSeparator2, Me.cmdClose, Me.ToolStripSeparator6, Me.ToolStripSeparator7, Me.cmdHelp})
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'ToolStriptxtSpace
        '
        resources.ApplyResources(Me.ToolStriptxtSpace, "ToolStriptxtSpace")
        Me.ToolStriptxtSpace.Name = "ToolStriptxtSpace"
        '
        'ToolStripApply
        '
        Me.ToolStripApply.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStripApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.ToolStripApply, "ToolStripApply")
        Me.ToolStripApply.Name = "ToolStripApply"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'ToolStripReset
        '
        Me.ToolStripReset.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStripReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.ToolStripReset, "ToolStripReset")
        Me.ToolStripReset.Name = "ToolStripReset"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.cmdClose, "cmdClose")
        Me.cmdClose.Name = "cmdClose"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        resources.ApplyResources(Me.ToolStripSeparator7, "ToolStripSeparator7")
        '
        'cmdHelp
        '
        Me.cmdHelp.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.cmdHelp, "cmdHelp")
        Me.cmdHelp.Name = "cmdHelp"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupSelections)
        Me.GroupBox1.Controls.Add(Me.chkSkipUploaded)
        Me.GroupBox1.Controls.Add(Me.optSelectRecords)
        Me.GroupBox1.Controls.Add(Me.optAllRecords)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'GroupSelections
        '
        Me.GroupSelections.Controls.Add(Me.Label6)
        Me.GroupSelections.Controls.Add(Me.Label5)
        Me.GroupSelections.Controls.Add(Me.TxtEMonth)
        Me.GroupSelections.Controls.Add(Me.txtEYear)
        Me.GroupSelections.Controls.Add(Me.txtBmonth)
        Me.GroupSelections.Controls.Add(Me.txtBYear)
        Me.GroupSelections.Controls.Add(Me.Label3)
        Me.GroupSelections.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.GroupSelections, "GroupSelections")
        Me.GroupSelections.Name = "GroupSelections"
        Me.GroupSelections.TabStop = False
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'TxtEMonth
        '
        resources.ApplyResources(Me.TxtEMonth, "TxtEMonth")
        Me.TxtEMonth.Name = "TxtEMonth"
        '
        'txtEYear
        '
        resources.ApplyResources(Me.txtEYear, "txtEYear")
        Me.txtEYear.Name = "txtEYear"
        '
        'txtBmonth
        '
        resources.ApplyResources(Me.txtBmonth, "txtBmonth")
        Me.txtBmonth.Name = "txtBmonth"
        '
        'txtBYear
        '
        resources.ApplyResources(Me.txtBYear, "txtBYear")
        Me.txtBYear.Name = "txtBYear"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'chkSkipUploaded
        '
        resources.ApplyResources(Me.chkSkipUploaded, "chkSkipUploaded")
        Me.chkSkipUploaded.Checked = True
        Me.chkSkipUploaded.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSkipUploaded.Name = "chkSkipUploaded"
        Me.chkSkipUploaded.UseVisualStyleBackColor = True
        '
        'optSelectRecords
        '
        resources.ApplyResources(Me.optSelectRecords, "optSelectRecords")
        Me.optSelectRecords.Name = "optSelectRecords"
        Me.optSelectRecords.UseVisualStyleBackColor = True
        '
        'optAllRecords
        '
        resources.ApplyResources(Me.optAllRecords, "optAllRecords")
        Me.optAllRecords.Checked = True
        Me.optAllRecords.Name = "optAllRecords"
        Me.optAllRecords.TabStop = True
        Me.optAllRecords.UseVisualStyleBackColor = True
        '
        'frmEntryForms
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lstvForms)
        Me.Name = "frmEntryForms"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupSelections.ResumeLayout(False)
        Me.GroupSelections.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvForms As ListView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripApply As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripReset As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdClose As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents cmdHelp As ToolStripButton
    Friend WithEvents ToolStriptxtSpace As ToolStripLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkSkipUploaded As CheckBox
    Friend WithEvents optSelectRecords As RadioButton
    Friend WithEvents optAllRecords As RadioButton
    Friend WithEvents GroupSelections As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtEMonth As TextBox
    Friend WithEvents txtEYear As TextBox
    Friend WithEvents txtBmonth As TextBox
    Friend WithEvents txtBYear As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
