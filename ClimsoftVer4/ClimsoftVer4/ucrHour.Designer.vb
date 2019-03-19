<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrHour
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrHour))
        Me.cmsHour = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsHour24 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsHour12 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsHour.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsHour
        '
        Me.cmsHour.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsHour24, Me.cmsHour12})
        Me.cmsHour.Name = "cmsYear"
        resources.ApplyResources(Me.cmsHour, "cmsHour")
        '
        'cmsHour24
        '
        Me.cmsHour24.Checked = True
        Me.cmsHour24.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cmsHour24.Name = "cmsHour24"
        resources.ApplyResources(Me.cmsHour24, "cmsHour24")
        '
        'cmsHour12
        '
        Me.cmsHour12.Name = "cmsHour12"
        resources.ApplyResources(Me.cmsHour12, "cmsHour12")
        '
        'ucrHour
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "ucrHour"
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsHour.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmsHour As ContextMenuStrip
    Friend WithEvents cmsHour24 As ToolStripMenuItem
    Friend WithEvents cmsHour12 As ToolStripMenuItem
End Class
