<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQC))
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.pnlAdvanced = New System.Windows.Forms.Panel()
        Me.lblQcAdvanced = New System.Windows.Forms.Label()
        Me.pnlQcStandard = New System.Windows.Forms.Panel()
        Me.txtEndMonth = New System.Windows.Forms.TextBox()
        Me.txtBeginMonth = New System.Windows.Forms.TextBox()
        Me.txtEndYear = New System.Windows.Forms.TextBox()
        Me.txtBeginYear = New System.Windows.Forms.TextBox()
        Me.lblEndMonth = New System.Windows.Forms.Label()
        Me.lblBeginMonth = New System.Windows.Forms.Label()
        Me.lblEndYear = New System.Windows.Forms.Label()
        Me.lblBeginYear = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.LstViewStations = New System.Windows.Forms.ListView()
        Me.lstViewElements = New System.Windows.Forms.ListView()
        Me.chkAllStations = New System.Windows.Forms.CheckBox()
        Me.chkAllElements = New System.Windows.Forms.CheckBox()
        Me.cmdPerformQC = New System.Windows.Forms.Button()
        Me.lblQCtype = New System.Windows.Forms.Label()
        Me.lblDataTransferProgress = New System.Windows.Forms.Label()
        Me.pnlQCTypes = New System.Windows.Forms.Panel()
        Me.optInterElement = New System.Windows.Forms.RadioButton()
        Me.optAbsoluteLimits = New System.Windows.Forms.RadioButton()
        Me.lblStationsElementsList = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlAdvanced.SuspendLayout()
        Me.pnlQcStandard.SuspendLayout()
        Me.pnlQCTypes.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdApply
        '
        resources.ApplyResources(Me.cmdApply, "cmdApply")
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        resources.ApplyResources(Me.cmdOk, "cmdOk")
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        resources.ApplyResources(Me.cmdCancel, "cmdCancel")
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        resources.ApplyResources(Me.cmdHelp, "cmdHelp")
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'pnlAdvanced
        '
        Me.pnlAdvanced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAdvanced.Controls.Add(Me.lblQcAdvanced)
        resources.ApplyResources(Me.pnlAdvanced, "pnlAdvanced")
        Me.pnlAdvanced.Name = "pnlAdvanced"
        '
        'lblQcAdvanced
        '
        resources.ApplyResources(Me.lblQcAdvanced, "lblQcAdvanced")
        Me.lblQcAdvanced.Name = "lblQcAdvanced"
        '
        'pnlQcStandard
        '
        Me.pnlQcStandard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlQcStandard.Controls.Add(Me.txtEndMonth)
        Me.pnlQcStandard.Controls.Add(Me.txtBeginMonth)
        Me.pnlQcStandard.Controls.Add(Me.txtEndYear)
        Me.pnlQcStandard.Controls.Add(Me.txtBeginYear)
        Me.pnlQcStandard.Controls.Add(Me.lblEndMonth)
        Me.pnlQcStandard.Controls.Add(Me.lblBeginMonth)
        Me.pnlQcStandard.Controls.Add(Me.lblEndYear)
        Me.pnlQcStandard.Controls.Add(Me.lblBeginYear)
        resources.ApplyResources(Me.pnlQcStandard, "pnlQcStandard")
        Me.pnlQcStandard.Name = "pnlQcStandard"
        '
        'txtEndMonth
        '
        resources.ApplyResources(Me.txtEndMonth, "txtEndMonth")
        Me.txtEndMonth.Name = "txtEndMonth"
        '
        'txtBeginMonth
        '
        resources.ApplyResources(Me.txtBeginMonth, "txtBeginMonth")
        Me.txtBeginMonth.Name = "txtBeginMonth"
        '
        'txtEndYear
        '
        resources.ApplyResources(Me.txtEndYear, "txtEndYear")
        Me.txtEndYear.Name = "txtEndYear"
        '
        'txtBeginYear
        '
        resources.ApplyResources(Me.txtBeginYear, "txtBeginYear")
        Me.txtBeginYear.Name = "txtBeginYear"
        '
        'lblEndMonth
        '
        resources.ApplyResources(Me.lblEndMonth, "lblEndMonth")
        Me.lblEndMonth.Name = "lblEndMonth"
        '
        'lblBeginMonth
        '
        resources.ApplyResources(Me.lblBeginMonth, "lblBeginMonth")
        Me.lblBeginMonth.Name = "lblBeginMonth"
        '
        'lblEndYear
        '
        resources.ApplyResources(Me.lblEndYear, "lblEndYear")
        Me.lblEndYear.Name = "lblEndYear"
        '
        'lblBeginYear
        '
        resources.ApplyResources(Me.lblBeginYear, "lblBeginYear")
        Me.lblBeginYear.Name = "lblBeginYear"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.btnUpdate, "btnUpdate")
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'LstViewStations
        '
        Me.LstViewStations.CheckBoxes = True
        Me.LstViewStations.FullRowSelect = True
        Me.LstViewStations.GridLines = True
        resources.ApplyResources(Me.LstViewStations, "LstViewStations")
        Me.LstViewStations.Name = "LstViewStations"
        Me.LstViewStations.UseCompatibleStateImageBehavior = False
        Me.LstViewStations.View = System.Windows.Forms.View.Details
        '
        'lstViewElements
        '
        Me.lstViewElements.CheckBoxes = True
        Me.lstViewElements.FullRowSelect = True
        Me.lstViewElements.GridLines = True
        resources.ApplyResources(Me.lstViewElements, "lstViewElements")
        Me.lstViewElements.Name = "lstViewElements"
        Me.lstViewElements.UseCompatibleStateImageBehavior = False
        Me.lstViewElements.View = System.Windows.Forms.View.Details
        '
        'chkAllStations
        '
        resources.ApplyResources(Me.chkAllStations, "chkAllStations")
        Me.chkAllStations.Name = "chkAllStations"
        Me.chkAllStations.UseVisualStyleBackColor = True
        '
        'chkAllElements
        '
        resources.ApplyResources(Me.chkAllElements, "chkAllElements")
        Me.chkAllElements.Name = "chkAllElements"
        Me.chkAllElements.UseVisualStyleBackColor = True
        '
        'cmdPerformQC
        '
        resources.ApplyResources(Me.cmdPerformQC, "cmdPerformQC")
        Me.cmdPerformQC.Name = "cmdPerformQC"
        Me.cmdPerformQC.UseVisualStyleBackColor = True
        '
        'lblQCtype
        '
        resources.ApplyResources(Me.lblQCtype, "lblQCtype")
        Me.lblQCtype.ForeColor = System.Drawing.Color.Black
        Me.lblQCtype.Name = "lblQCtype"
        '
        'lblDataTransferProgress
        '
        resources.ApplyResources(Me.lblDataTransferProgress, "lblDataTransferProgress")
        Me.lblDataTransferProgress.ForeColor = System.Drawing.Color.Red
        Me.lblDataTransferProgress.Name = "lblDataTransferProgress"
        '
        'pnlQCTypes
        '
        Me.pnlQCTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlQCTypes.Controls.Add(Me.optInterElement)
        Me.pnlQCTypes.Controls.Add(Me.optAbsoluteLimits)
        resources.ApplyResources(Me.pnlQCTypes, "pnlQCTypes")
        Me.pnlQCTypes.Name = "pnlQCTypes"
        '
        'optInterElement
        '
        resources.ApplyResources(Me.optInterElement, "optInterElement")
        Me.optInterElement.Name = "optInterElement"
        Me.optInterElement.UseVisualStyleBackColor = True
        '
        'optAbsoluteLimits
        '
        resources.ApplyResources(Me.optAbsoluteLimits, "optAbsoluteLimits")
        Me.optAbsoluteLimits.Checked = True
        Me.optAbsoluteLimits.Name = "optAbsoluteLimits"
        Me.optAbsoluteLimits.TabStop = True
        Me.optAbsoluteLimits.UseVisualStyleBackColor = True
        '
        'lblStationsElementsList
        '
        resources.ApplyResources(Me.lblStationsElementsList, "lblStationsElementsList")
        Me.lblStationsElementsList.ForeColor = System.Drawing.Color.Black
        Me.lblStationsElementsList.Name = "lblStationsElementsList"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'frmQC
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStationsElementsList)
        Me.Controls.Add(Me.pnlQCTypes)
        Me.Controls.Add(Me.lblDataTransferProgress)
        Me.Controls.Add(Me.lblQCtype)
        Me.Controls.Add(Me.cmdPerformQC)
        Me.Controls.Add(Me.chkAllElements)
        Me.Controls.Add(Me.chkAllStations)
        Me.Controls.Add(Me.lstViewElements)
        Me.Controls.Add(Me.LstViewStations)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.pnlAdvanced)
        Me.Controls.Add(Me.pnlQcStandard)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdApply)
        Me.Name = "frmQC"
        Me.pnlAdvanced.ResumeLayout(False)
        Me.pnlAdvanced.PerformLayout()
        Me.pnlQcStandard.ResumeLayout(False)
        Me.pnlQcStandard.PerformLayout()
        Me.pnlQCTypes.ResumeLayout(False)
        Me.pnlQCTypes.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdHelp As System.Windows.Forms.Button
    Friend WithEvents pnlAdvanced As System.Windows.Forms.Panel
    Friend WithEvents lblQcAdvanced As System.Windows.Forms.Label
    Friend WithEvents pnlQcStandard As System.Windows.Forms.Panel
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Public WithEvents LstViewStations As System.Windows.Forms.ListView
    Public WithEvents lstViewElements As System.Windows.Forms.ListView
    Friend WithEvents txtEndMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtBeginMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtEndYear As System.Windows.Forms.TextBox
    Friend WithEvents txtBeginYear As System.Windows.Forms.TextBox
    Friend WithEvents lblEndMonth As System.Windows.Forms.Label
    Friend WithEvents lblBeginMonth As System.Windows.Forms.Label
    Friend WithEvents lblEndYear As System.Windows.Forms.Label
    Friend WithEvents lblBeginYear As System.Windows.Forms.Label
    Friend WithEvents chkAllStations As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllElements As System.Windows.Forms.CheckBox
    Friend WithEvents cmdPerformQC As System.Windows.Forms.Button
    Friend WithEvents lblQCtype As System.Windows.Forms.Label
    Friend WithEvents lblDataTransferProgress As System.Windows.Forms.Label
    Friend WithEvents pnlQCTypes As System.Windows.Forms.Panel
    Friend WithEvents optInterElement As System.Windows.Forms.RadioButton
    Friend WithEvents optAbsoluteLimits As System.Windows.Forms.RadioButton
    Friend WithEvents lblStationsElementsList As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingSource2 As BindingSource
End Class
