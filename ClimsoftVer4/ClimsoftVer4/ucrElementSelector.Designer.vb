<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrElementSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrElementSelector))
        Me.cmsElement = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsElementsNames = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsElementIDs = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsElemntIDName = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsElementSortByID = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsElementSortyByName = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsElementsFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsElement.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsElement
        '
        Me.cmsElement.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsElementsNames, Me.cmsElementIDs, Me.cmsElemntIDName, Me.ToolStripSeparator2, Me.cmsElementSortByID, Me.cmsElementSortyByName, Me.cmsElementsFilter, Me.ToolStripSeparator1})
        Me.cmsElement.Name = "cmsStation"
        resources.ApplyResources(Me.cmsElement, "cmsElement")
        '
        'cmsElementsNames
        '
        Me.cmsElementsNames.Name = "cmsElementsNames"
        resources.ApplyResources(Me.cmsElementsNames, "cmsElementsNames")
        '
        'cmsElementIDs
        '
        Me.cmsElementIDs.Name = "cmsElementIDs"
        resources.ApplyResources(Me.cmsElementIDs, "cmsElementIDs")
        '
        'cmsElemntIDName
        '
        Me.cmsElemntIDName.Name = "cmsElemntIDName"
        resources.ApplyResources(Me.cmsElemntIDName, "cmsElemntIDName")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'cmsElementSortByID
        '
        Me.cmsElementSortByID.Name = "cmsElementSortByID"
        resources.ApplyResources(Me.cmsElementSortByID, "cmsElementSortByID")
        '
        'cmsElementSortyByName
        '
        Me.cmsElementSortyByName.Name = "cmsElementSortyByName"
        resources.ApplyResources(Me.cmsElementSortyByName, "cmsElementSortyByName")
        '
        'cmsElementsFilter
        '
        Me.cmsElementsFilter.Name = "cmsElementsFilter"
        resources.ApplyResources(Me.cmsElementsFilter, "cmsElementsFilter")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'ucrElementSelector
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucrElementSelector"
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsElement.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmsElement As ContextMenuStrip
    Friend WithEvents cmsElementsNames As ToolStripMenuItem
    Friend WithEvents cmsElementIDs As ToolStripMenuItem
    Friend WithEvents cmsElemntIDName As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmsElementSortByID As ToolStripMenuItem
    Friend WithEvents cmsElementSortyByName As ToolStripMenuItem
    Friend WithEvents cmsElementsFilter As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
