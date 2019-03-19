<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrYearSelector
    Inherits ClimsoftVer4.ucrDataLinkCombobox

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrYearSelector))
        Me.cmsYear = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsYearViewLongYear = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsYearViewShortYear = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsYear.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsYear
        '
        Me.cmsYear.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsYearViewLongYear, Me.cmsYearViewShortYear})
        Me.cmsYear.Name = "cmsYear"
        resources.ApplyResources(Me.cmsYear, "cmsYear")
        '
        'cmsYearViewLongYear
        '
        Me.cmsYearViewLongYear.Checked = True
        Me.cmsYearViewLongYear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cmsYearViewLongYear.Name = "cmsYearViewLongYear"
        resources.ApplyResources(Me.cmsYearViewLongYear, "cmsYearViewLongYear")
        '
        'cmsYearViewShortYear
        '
        Me.cmsYearViewShortYear.Name = "cmsYearViewShortYear"
        resources.ApplyResources(Me.cmsYearViewShortYear, "cmsYearViewShortYear")
        '
        'ucrYearSelector
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "ucrYearSelector"
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsYear.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmsYear As ContextMenuStrip
    Friend WithEvents cmsYearViewLongYear As ToolStripMenuItem
    Friend WithEvents cmsYearViewShortYear As ToolStripMenuItem
End Class
