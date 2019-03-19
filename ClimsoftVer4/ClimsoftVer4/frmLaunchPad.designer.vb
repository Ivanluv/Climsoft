<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaunchPad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLaunchPad))
        Me.btnStationInformation = New System.Windows.Forms.Button()
        Me.btnElementInformation = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.btnSynopticData = New System.Windows.Forms.Button()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.lblConection = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStationInformation
        '
        resources.ApplyResources(Me.btnStationInformation, "btnStationInformation")
        Me.btnStationInformation.Name = "btnStationInformation"
        Me.btnStationInformation.UseVisualStyleBackColor = True
        '
        'btnElementInformation
        '
        resources.ApplyResources(Me.btnElementInformation, "btnElementInformation")
        Me.btnElementInformation.Name = "btnElementInformation"
        Me.btnElementInformation.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.btnUpdate, Me.ToolStripSeparator1, Me.btnClose})
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        resources.ApplyResources(Me.ToolStripLabel1, "ToolStripLabel1")
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.btnUpdate, "btnUpdate")
        Me.btnUpdate.Name = "btnUpdate"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.Name = "btnClose"
        '
        'btnSynopticData
        '
        resources.ApplyResources(Me.btnSynopticData, "btnSynopticData")
        Me.btnSynopticData.Name = "btnSynopticData"
        Me.btnSynopticData.UseVisualStyleBackColor = True
        '
        'lblServer
        '
        resources.ApplyResources(Me.lblServer, "lblServer")
        Me.lblServer.Name = "lblServer"
        '
        'lblPort
        '
        resources.ApplyResources(Me.lblPort, "lblPort")
        Me.lblPort.Name = "lblPort"
        '
        'txtServer
        '
        resources.ApplyResources(Me.txtServer, "txtServer")
        Me.txtServer.Name = "txtServer"
        '
        'txtDatabase
        '
        resources.ApplyResources(Me.txtDatabase, "txtDatabase")
        Me.txtDatabase.Name = "txtDatabase"
        '
        'txtPort
        '
        resources.ApplyResources(Me.txtPort, "txtPort")
        Me.txtPort.Name = "txtPort"
        '
        'lblDatabase
        '
        resources.ApplyResources(Me.lblDatabase, "lblDatabase")
        Me.lblDatabase.Name = "lblDatabase"
        '
        'lblConection
        '
        resources.ApplyResources(Me.lblConection, "lblConection")
        Me.lblConection.Name = "lblConection"
        '
        'frmLaunchPad
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblConection)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.btnSynopticData)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnElementInformation)
        Me.Controls.Add(Me.btnStationInformation)
        Me.MaximizeBox = False
        Me.Name = "frmLaunchPad"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStationInformation As System.Windows.Forms.Button
    Friend WithEvents btnElementInformation As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSynopticData As System.Windows.Forms.Button
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents lblDatabase As System.Windows.Forms.Label
    Friend WithEvents lblConection As System.Windows.Forms.Label
End Class
