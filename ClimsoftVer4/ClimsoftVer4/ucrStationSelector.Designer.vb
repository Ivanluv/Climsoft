<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrStationSelector
    Inherits ClimsoftVer4.ucrDataLinkCombobox

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrStationSelector))
        Me.cmsStation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsStationNames = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsStationIDs = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsStationIDAndStation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsStationSortByID = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsStationSortyByName = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsFilterStations = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsStation.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsStation
        '
        Me.cmsStation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsStationNames, Me.cmsStationIDs, Me.cmsStationIDAndStation, Me.ToolStripSeparator2, Me.cmsStationSortByID, Me.cmsStationSortyByName, Me.cmsFilterStations, Me.ToolStripSeparator1})
        Me.cmsStation.Name = "cmsStation"
        resources.ApplyResources(Me.cmsStation, "cmsStation")
        '
        'cmsStationNames
        '
        Me.cmsStationNames.Name = "cmsStationNames"
        resources.ApplyResources(Me.cmsStationNames, "cmsStationNames")
        '
        'cmsStationIDs
        '
        Me.cmsStationIDs.Name = "cmsStationIDs"
        resources.ApplyResources(Me.cmsStationIDs, "cmsStationIDs")
        '
        'cmsStationIDAndStation
        '
        Me.cmsStationIDAndStation.Name = "cmsStationIDAndStation"
        resources.ApplyResources(Me.cmsStationIDAndStation, "cmsStationIDAndStation")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'cmsStationSortByID
        '
        Me.cmsStationSortByID.Name = "cmsStationSortByID"
        resources.ApplyResources(Me.cmsStationSortByID, "cmsStationSortByID")
        '
        'cmsStationSortyByName
        '
        Me.cmsStationSortyByName.Name = "cmsStationSortyByName"
        resources.ApplyResources(Me.cmsStationSortyByName, "cmsStationSortyByName")
        '
        'cmsFilterStations
        '
        Me.cmsFilterStations.Name = "cmsFilterStations"
        resources.ApplyResources(Me.cmsFilterStations, "cmsFilterStations")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'ucrStationSelector
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucrStationSelector"
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsStation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmsStation As ContextMenuStrip
    Friend WithEvents cmsStationNames As ToolStripMenuItem
    Friend WithEvents cmsStationIDs As ToolStripMenuItem
    Friend WithEvents cmsStationIDAndStation As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmsStationSortByID As ToolStripMenuItem
    Friend WithEvents cmsStationSortyByName As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmsFilterStations As ToolStripMenuItem
End Class
