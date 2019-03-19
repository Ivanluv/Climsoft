<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewFormDaily2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewFormDaily2))
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.cmdAssignSameValue = New System.Windows.Forms.Button()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.grpUnits = New System.Windows.Forms.GroupBox()
        Me.lblVisibility = New System.Windows.Forms.Label()
        Me.LblCloudheight = New System.Windows.Forms.Label()
        Me.lblPrecip = New System.Windows.Forms.Label()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.ucrVisibilityUnits = New ClimsoftVer4.ucrDataLinkCombobox()
        Me.ucrCloudheightUnits = New ClimsoftVer4.ucrDataLinkCombobox()
        Me.ucrPrecipUnits = New ClimsoftVer4.ucrDataLinkCombobox()
        Me.ucrTempUnits = New ClimsoftVer4.ucrDataLinkCombobox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.chkEnableSequencer = New System.Windows.Forms.CheckBox()
        Me.ucrInputValue = New ClimsoftVer4.ucrTextBox()
        Me.ucrHour = New ClimsoftVer4.ucrHour()
        Me.ucrMonth = New ClimsoftVer4.ucrMonth()
        Me.ucrYearSelector = New ClimsoftVer4.ucrYearSelector()
        Me.ucrFormDaily = New ClimsoftVer4.ucrFormDaily2()
        Me.ucrElementSelector = New ClimsoftVer4.ucrElementSelector()
        Me.ucrStationSelector = New ClimsoftVer4.ucrStationSelector()
        Me.ucrDaiy2Navigation = New ClimsoftVer4.ucrNavigation()
        Me.lblSequencer = New System.Windows.Forms.Label()
        Me.txtSequencer = New System.Windows.Forms.TextBox()
        Me.chkRepeatEntry = New System.Windows.Forms.CheckBox()
        Me.grpUnits.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        '
        'lblHour
        '
        resources.ApplyResources(Me.lblHour, "lblHour")
        Me.lblHour.Name = "lblHour"
        '
        'cmdAssignSameValue
        '
        Me.cmdAssignSameValue.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.cmdAssignSameValue, "cmdAssignSameValue")
        Me.cmdAssignSameValue.Name = "cmdAssignSameValue"
        Me.cmdAssignSameValue.UseVisualStyleBackColor = True
        '
        'lblValue
        '
        resources.ApplyResources(Me.lblValue, "lblValue")
        Me.lblValue.ForeColor = System.Drawing.Color.Blue
        Me.lblValue.Name = "lblValue"
        '
        'grpUnits
        '
        Me.grpUnits.Controls.Add(Me.lblVisibility)
        Me.grpUnits.Controls.Add(Me.LblCloudheight)
        Me.grpUnits.Controls.Add(Me.lblPrecip)
        Me.grpUnits.Controls.Add(Me.lblTemperature)
        Me.grpUnits.Controls.Add(Me.ucrVisibilityUnits)
        Me.grpUnits.Controls.Add(Me.ucrCloudheightUnits)
        Me.grpUnits.Controls.Add(Me.ucrPrecipUnits)
        Me.grpUnits.Controls.Add(Me.ucrTempUnits)
        resources.ApplyResources(Me.grpUnits, "grpUnits")
        Me.grpUnits.Name = "grpUnits"
        Me.grpUnits.TabStop = False
        '
        'lblVisibility
        '
        resources.ApplyResources(Me.lblVisibility, "lblVisibility")
        Me.lblVisibility.Name = "lblVisibility"
        '
        'LblCloudheight
        '
        resources.ApplyResources(Me.LblCloudheight, "LblCloudheight")
        Me.LblCloudheight.Name = "LblCloudheight"
        '
        'lblPrecip
        '
        resources.ApplyResources(Me.lblPrecip, "lblPrecip")
        Me.lblPrecip.Name = "lblPrecip"
        '
        'lblTemperature
        '
        resources.ApplyResources(Me.lblTemperature, "lblTemperature")
        Me.lblTemperature.Name = "lblTemperature"
        '
        'ucrVisibilityUnits
        '
        resources.ApplyResources(Me.ucrVisibilityUnits, "ucrVisibilityUnits")
        Me.ucrVisibilityUnits.Name = "ucrVisibilityUnits"
        '
        'ucrCloudheightUnits
        '
        resources.ApplyResources(Me.ucrCloudheightUnits, "ucrCloudheightUnits")
        Me.ucrCloudheightUnits.Name = "ucrCloudheightUnits"
        '
        'ucrPrecipUnits
        '
        resources.ApplyResources(Me.ucrPrecipUnits, "ucrPrecipUnits")
        Me.ucrPrecipUnits.Name = "ucrPrecipUnits"
        '
        'ucrTempUnits
        '
        resources.ApplyResources(Me.ucrTempUnits, "ucrTempUnits")
        Me.ucrTempUnits.Name = "ucrTempUnits"
        '
        'btnView
        '
        resources.ApplyResources(Me.btnView, "btnView")
        Me.btnView.Name = "btnView"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        resources.ApplyResources(Me.btnHelp, "btnHelp")
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        resources.ApplyResources(Me.btnClear, "btnClear")
        Me.btnClear.Name = "btnClear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCommit
        '
        resources.ApplyResources(Me.btnCommit, "btnCommit")
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        resources.ApplyResources(Me.btnAddNew, "btnAddNew")
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        resources.ApplyResources(Me.btnUpdate, "btnUpdate")
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.Name = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.Lime
        resources.ApplyResources(Me.btnUpload, "btnUpload")
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'chkEnableSequencer
        '
        resources.ApplyResources(Me.chkEnableSequencer, "chkEnableSequencer")
        Me.chkEnableSequencer.Checked = True
        Me.chkEnableSequencer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnableSequencer.ForeColor = System.Drawing.Color.Red
        Me.chkEnableSequencer.Name = "chkEnableSequencer"
        Me.chkEnableSequencer.UseVisualStyleBackColor = True
        '
        'ucrInputValue
        '
        resources.ApplyResources(Me.ucrInputValue, "ucrInputValue")
        Me.ucrInputValue.Name = "ucrInputValue"
        Me.ucrInputValue.TextboxValue = ""
        '
        'ucrHour
        '
        resources.ApplyResources(Me.ucrHour, "ucrHour")
        Me.ucrHour.Name = "ucrHour"
        '
        'ucrMonth
        '
        resources.ApplyResources(Me.ucrMonth, "ucrMonth")
        Me.ucrMonth.Name = "ucrMonth"
        '
        'ucrYearSelector
        '
        resources.ApplyResources(Me.ucrYearSelector, "ucrYearSelector")
        Me.ucrYearSelector.Name = "ucrYearSelector"
        '
        'ucrFormDaily
        '
        resources.ApplyResources(Me.ucrFormDaily, "ucrFormDaily")
        Me.ucrFormDaily.Name = "ucrFormDaily"
        '
        'ucrElementSelector
        '
        resources.ApplyResources(Me.ucrElementSelector, "ucrElementSelector")
        Me.ucrElementSelector.Name = "ucrElementSelector"
        '
        'ucrStationSelector
        '
        resources.ApplyResources(Me.ucrStationSelector, "ucrStationSelector")
        Me.ucrStationSelector.Name = "ucrStationSelector"
        '
        'ucrDaiy2Navigation
        '
        resources.ApplyResources(Me.ucrDaiy2Navigation, "ucrDaiy2Navigation")
        Me.ucrDaiy2Navigation.Name = "ucrDaiy2Navigation"
        '
        'lblSequencer
        '
        resources.ApplyResources(Me.lblSequencer, "lblSequencer")
        Me.lblSequencer.Name = "lblSequencer"
        '
        'txtSequencer
        '
        resources.ApplyResources(Me.txtSequencer, "txtSequencer")
        Me.txtSequencer.Name = "txtSequencer"
        '
        'chkRepeatEntry
        '
        resources.ApplyResources(Me.chkRepeatEntry, "chkRepeatEntry")
        Me.chkRepeatEntry.Name = "chkRepeatEntry"
        Me.chkRepeatEntry.UseVisualStyleBackColor = True
        '
        'frmNewFormDaily2
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkRepeatEntry)
        Me.Controls.Add(Me.lblSequencer)
        Me.Controls.Add(Me.txtSequencer)
        Me.Controls.Add(Me.ucrDaiy2Navigation)
        Me.Controls.Add(Me.chkEnableSequencer)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpUnits)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.ucrInputValue)
        Me.Controls.Add(Me.cmdAssignSameValue)
        Me.Controls.Add(Me.ucrHour)
        Me.Controls.Add(Me.ucrMonth)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.ucrYearSelector)
        Me.Controls.Add(Me.ucrFormDaily)
        Me.Controls.Add(Me.ucrElementSelector)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrStationSelector)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNewFormDaily2"
        Me.grpUnits.ResumeLayout(False)
        Me.grpUnits.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrStationSelector As ucrStationSelector
    Friend WithEvents lblStation As Label
    Friend WithEvents lblElement As Label
    Friend WithEvents ucrElementSelector As ucrElementSelector
    Friend WithEvents ucrFormDaily As ucrFormDaily2
    Friend WithEvents ucrYearSelector As ucrYearSelector
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrMonth As ucrMonth
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrHour As ucrHour
    Friend WithEvents lblHour As Label
    Friend WithEvents cmdAssignSameValue As Button
    Friend WithEvents ucrInputValue As ucrTextBox
    Friend WithEvents lblValue As Label
    Friend WithEvents grpUnits As GroupBox
    Friend WithEvents ucrVisibilityUnits As ucrDataLinkCombobox
    Friend WithEvents ucrCloudheightUnits As ucrDataLinkCombobox
    Friend WithEvents ucrPrecipUnits As ucrDataLinkCombobox
    Friend WithEvents ucrTempUnits As ucrDataLinkCombobox
    Friend WithEvents lblVisibility As Label
    Friend WithEvents LblCloudheight As Label
    Friend WithEvents lblPrecip As Label
    Friend WithEvents lblTemperature As Label
    Friend WithEvents btnView As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCommit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents chkEnableSequencer As CheckBox
    Friend WithEvents ucrDaiy2Navigation As ucrNavigation
    Friend WithEvents lblSequencer As Label
    Friend WithEvents txtSequencer As TextBox
    Friend WithEvents chkRepeatEntry As CheckBox
End Class
