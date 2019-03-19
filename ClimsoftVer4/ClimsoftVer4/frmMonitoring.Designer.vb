<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitoring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonitoring))
        Me.TabMonitoring = New System.Windows.Forms.TabControl()
        Me.TabUsrRecords = New System.Windows.Forms.TabPage()
        Me.grpUsers = New System.Windows.Forms.GroupBox()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.DateTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeStart = New System.Windows.Forms.DateTimePicker()
        Me.cboUser = New System.Windows.Forms.ComboBox()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.optUsers = New System.Windows.Forms.RadioButton()
        Me.TabPerformance = New System.Windows.Forms.TabPage()
        Me.grpPerformance = New System.Windows.Forms.GroupBox()
        Me.cmdSave1 = New System.Windows.Forms.Button()
        Me.DataGridPerform = New System.Windows.Forms.DataGridView()
        Me.cmdRetrieve = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblTo1 = New System.Windows.Forms.Label()
        Me.lblFrom1 = New System.Windows.Forms.Label()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.optRange = New System.Windows.Forms.RadioButton()
        Me.OptMonthly = New System.Windows.Forms.RadioButton()
        Me.TabEntryVerify = New System.Windows.Forms.TabPage()
        Me.grpVerify = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optNotVerified = New System.Windows.Forms.RadioButton()
        Me.optVerified = New System.Windows.Forms.RadioButton()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdExtarct = New System.Windows.Forms.Button()
        Me.txtYear2 = New System.Windows.Forms.TextBox()
        Me.txtYear1 = New System.Windows.Forms.TextBox()
        Me.txtMonth2 = New System.Windows.Forms.TextBox()
        Me.txtMonth1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optKeyEntryForm = New System.Windows.Forms.RadioButton()
        Me.optAllForms = New System.Windows.Forms.RadioButton()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.cboForms = New System.Windows.Forms.ComboBox()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.grpSettings = New System.Windows.Forms.GroupBox()
        Me.lblDoubleEntryMode = New System.Windows.Forms.Label()
        Me.lblSingleEntryMode = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.optTargets = New System.Windows.Forms.RadioButton()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdretrieve1 = New System.Windows.Forms.Button()
        Me.DataGridSettings = New System.Windows.Forms.DataGridView()
        Me.ListViewRecs = New System.Windows.Forms.ListView()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.lblTrecs = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.TabMonitoring.SuspendLayout()
        Me.TabUsrRecords.SuspendLayout()
        Me.grpUsers.SuspendLayout()
        Me.TabPerformance.SuspendLayout()
        Me.grpPerformance.SuspendLayout()
        CType(Me.DataGridPerform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEntryVerify.SuspendLayout()
        Me.grpVerify.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabSettings.SuspendLayout()
        Me.grpSettings.SuspendLayout()
        CType(Me.DataGridSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabMonitoring
        '
        Me.TabMonitoring.Controls.Add(Me.TabUsrRecords)
        Me.TabMonitoring.Controls.Add(Me.TabPerformance)
        Me.TabMonitoring.Controls.Add(Me.TabEntryVerify)
        Me.TabMonitoring.Controls.Add(Me.TabSettings)
        resources.ApplyResources(Me.TabMonitoring, "TabMonitoring")
        Me.TabMonitoring.Name = "TabMonitoring"
        Me.TabMonitoring.SelectedIndex = 0
        '
        'TabUsrRecords
        '
        Me.TabUsrRecords.Controls.Add(Me.grpUsers)
        resources.ApplyResources(Me.TabUsrRecords, "TabUsrRecords")
        Me.TabUsrRecords.Name = "TabUsrRecords"
        Me.TabUsrRecords.UseVisualStyleBackColor = True
        '
        'grpUsers
        '
        Me.grpUsers.Controls.Add(Me.cmdView)
        Me.grpUsers.Controls.Add(Me.lblEndDate)
        Me.grpUsers.Controls.Add(Me.lblStartDate)
        Me.grpUsers.Controls.Add(Me.DateTimeEnd)
        Me.grpUsers.Controls.Add(Me.DateTimeStart)
        Me.grpUsers.Controls.Add(Me.cboUser)
        Me.grpUsers.Controls.Add(Me.optAll)
        Me.grpUsers.Controls.Add(Me.optUsers)
        resources.ApplyResources(Me.grpUsers, "grpUsers")
        Me.grpUsers.Name = "grpUsers"
        Me.grpUsers.TabStop = False
        '
        'cmdView
        '
        resources.ApplyResources(Me.cmdView, "cmdView")
        Me.cmdView.ForeColor = System.Drawing.Color.Black
        Me.cmdView.Name = "cmdView"
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'lblEndDate
        '
        resources.ApplyResources(Me.lblEndDate, "lblEndDate")
        Me.lblEndDate.Name = "lblEndDate"
        '
        'lblStartDate
        '
        resources.ApplyResources(Me.lblStartDate, "lblStartDate")
        Me.lblStartDate.Name = "lblStartDate"
        '
        'DateTimeEnd
        '
        resources.ApplyResources(Me.DateTimeEnd, "DateTimeEnd")
        Me.DateTimeEnd.Name = "DateTimeEnd"
        '
        'DateTimeStart
        '
        resources.ApplyResources(Me.DateTimeStart, "DateTimeStart")
        Me.DateTimeStart.Name = "DateTimeStart"
        '
        'cboUser
        '
        Me.cboUser.FormattingEnabled = True
        resources.ApplyResources(Me.cboUser, "cboUser")
        Me.cboUser.Name = "cboUser"
        '
        'optAll
        '
        resources.ApplyResources(Me.optAll, "optAll")
        Me.optAll.Name = "optAll"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'optUsers
        '
        resources.ApplyResources(Me.optUsers, "optUsers")
        Me.optUsers.Checked = True
        Me.optUsers.Name = "optUsers"
        Me.optUsers.TabStop = True
        Me.optUsers.UseVisualStyleBackColor = True
        '
        'TabPerformance
        '
        Me.TabPerformance.Controls.Add(Me.grpPerformance)
        resources.ApplyResources(Me.TabPerformance, "TabPerformance")
        Me.TabPerformance.Name = "TabPerformance"
        Me.TabPerformance.UseVisualStyleBackColor = True
        '
        'grpPerformance
        '
        Me.grpPerformance.Controls.Add(Me.cmdSave1)
        Me.grpPerformance.Controls.Add(Me.DataGridPerform)
        Me.grpPerformance.Controls.Add(Me.cmdRetrieve)
        Me.grpPerformance.Controls.Add(Me.lblYear)
        Me.grpPerformance.Controls.Add(Me.txtYear)
        Me.grpPerformance.Controls.Add(Me.lblMonth)
        Me.grpPerformance.Controls.Add(Me.lblTo1)
        Me.grpPerformance.Controls.Add(Me.lblFrom1)
        Me.grpPerformance.Controls.Add(Me.dtTo)
        Me.grpPerformance.Controls.Add(Me.dtFrom)
        Me.grpPerformance.Controls.Add(Me.cboMonth)
        Me.grpPerformance.Controls.Add(Me.optRange)
        Me.grpPerformance.Controls.Add(Me.OptMonthly)
        resources.ApplyResources(Me.grpPerformance, "grpPerformance")
        Me.grpPerformance.Name = "grpPerformance"
        Me.grpPerformance.TabStop = False
        '
        'cmdSave1
        '
        resources.ApplyResources(Me.cmdSave1, "cmdSave1")
        Me.cmdSave1.Name = "cmdSave1"
        Me.cmdSave1.UseVisualStyleBackColor = True
        '
        'DataGridPerform
        '
        Me.DataGridPerform.AllowUserToOrderColumns = True
        Me.DataGridPerform.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridPerform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPerform.GridColor = System.Drawing.SystemColors.ButtonFace
        resources.ApplyResources(Me.DataGridPerform, "DataGridPerform")
        Me.DataGridPerform.Name = "DataGridPerform"
        '
        'cmdRetrieve
        '
        resources.ApplyResources(Me.cmdRetrieve, "cmdRetrieve")
        Me.cmdRetrieve.Name = "cmdRetrieve"
        Me.cmdRetrieve.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'txtYear
        '
        resources.ApplyResources(Me.txtYear, "txtYear")
        Me.txtYear.Name = "txtYear"
        '
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        '
        'lblTo1
        '
        resources.ApplyResources(Me.lblTo1, "lblTo1")
        Me.lblTo1.Name = "lblTo1"
        '
        'lblFrom1
        '
        resources.ApplyResources(Me.lblFrom1, "lblFrom1")
        Me.lblFrom1.Name = "lblFrom1"
        '
        'dtTo
        '
        resources.ApplyResources(Me.dtTo, "dtTo")
        Me.dtTo.Name = "dtTo"
        '
        'dtFrom
        '
        resources.ApplyResources(Me.dtFrom, "dtFrom")
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Value = New Date(2018, 6, 21, 16, 47, 50, 0)
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {resources.GetString("cboMonth.Items"), resources.GetString("cboMonth.Items1"), resources.GetString("cboMonth.Items2"), resources.GetString("cboMonth.Items3"), resources.GetString("cboMonth.Items4"), resources.GetString("cboMonth.Items5"), resources.GetString("cboMonth.Items6"), resources.GetString("cboMonth.Items7"), resources.GetString("cboMonth.Items8"), resources.GetString("cboMonth.Items9"), resources.GetString("cboMonth.Items10"), resources.GetString("cboMonth.Items11")})
        resources.ApplyResources(Me.cboMonth, "cboMonth")
        Me.cboMonth.Name = "cboMonth"
        '
        'optRange
        '
        resources.ApplyResources(Me.optRange, "optRange")
        Me.optRange.Name = "optRange"
        Me.optRange.UseVisualStyleBackColor = True
        '
        'OptMonthly
        '
        resources.ApplyResources(Me.OptMonthly, "OptMonthly")
        Me.OptMonthly.Checked = True
        Me.OptMonthly.Name = "OptMonthly"
        Me.OptMonthly.TabStop = True
        Me.OptMonthly.UseVisualStyleBackColor = True
        '
        'TabEntryVerify
        '
        Me.TabEntryVerify.Controls.Add(Me.grpVerify)
        resources.ApplyResources(Me.TabEntryVerify, "TabEntryVerify")
        Me.TabEntryVerify.Name = "TabEntryVerify"
        Me.TabEntryVerify.UseVisualStyleBackColor = True
        '
        'grpVerify
        '
        Me.grpVerify.Controls.Add(Me.GroupBox2)
        Me.grpVerify.Controls.Add(Me.cmdSave)
        Me.grpVerify.Controls.Add(Me.cmdExtarct)
        Me.grpVerify.Controls.Add(Me.txtYear2)
        Me.grpVerify.Controls.Add(Me.txtYear1)
        Me.grpVerify.Controls.Add(Me.txtMonth2)
        Me.grpVerify.Controls.Add(Me.txtMonth1)
        Me.grpVerify.Controls.Add(Me.Label2)
        Me.grpVerify.Controls.Add(Me.Label1)
        Me.grpVerify.Controls.Add(Me.optKeyEntryForm)
        Me.grpVerify.Controls.Add(Me.optAllForms)
        Me.grpVerify.Controls.Add(Me.lblTo)
        Me.grpVerify.Controls.Add(Me.lblFrom)
        Me.grpVerify.Controls.Add(Me.cboForms)
        resources.ApplyResources(Me.grpVerify, "grpVerify")
        Me.grpVerify.Name = "grpVerify"
        Me.grpVerify.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optNotVerified)
        Me.GroupBox2.Controls.Add(Me.optVerified)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'optNotVerified
        '
        resources.ApplyResources(Me.optNotVerified, "optNotVerified")
        Me.optNotVerified.Checked = True
        Me.optNotVerified.Name = "optNotVerified"
        Me.optNotVerified.TabStop = True
        Me.optNotVerified.UseVisualStyleBackColor = True
        '
        'optVerified
        '
        resources.ApplyResources(Me.optVerified, "optVerified")
        Me.optVerified.Name = "optVerified"
        Me.optVerified.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        resources.ApplyResources(Me.cmdSave, "cmdSave")
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdExtarct
        '
        resources.ApplyResources(Me.cmdExtarct, "cmdExtarct")
        Me.cmdExtarct.Name = "cmdExtarct"
        Me.cmdExtarct.UseVisualStyleBackColor = True
        '
        'txtYear2
        '
        resources.ApplyResources(Me.txtYear2, "txtYear2")
        Me.txtYear2.Name = "txtYear2"
        '
        'txtYear1
        '
        resources.ApplyResources(Me.txtYear1, "txtYear1")
        Me.txtYear1.Name = "txtYear1"
        '
        'txtMonth2
        '
        resources.ApplyResources(Me.txtMonth2, "txtMonth2")
        Me.txtMonth2.Name = "txtMonth2"
        '
        'txtMonth1
        '
        resources.ApplyResources(Me.txtMonth1, "txtMonth1")
        Me.txtMonth1.Name = "txtMonth1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'optKeyEntryForm
        '
        resources.ApplyResources(Me.optKeyEntryForm, "optKeyEntryForm")
        Me.optKeyEntryForm.Checked = True
        Me.optKeyEntryForm.Name = "optKeyEntryForm"
        Me.optKeyEntryForm.TabStop = True
        Me.optKeyEntryForm.UseVisualStyleBackColor = True
        '
        'optAllForms
        '
        resources.ApplyResources(Me.optAllForms, "optAllForms")
        Me.optAllForms.Name = "optAllForms"
        Me.optAllForms.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        resources.ApplyResources(Me.lblTo, "lblTo")
        Me.lblTo.Name = "lblTo"
        '
        'lblFrom
        '
        resources.ApplyResources(Me.lblFrom, "lblFrom")
        Me.lblFrom.Name = "lblFrom"
        '
        'cboForms
        '
        Me.cboForms.FormattingEnabled = True
        resources.ApplyResources(Me.cboForms, "cboForms")
        Me.cboForms.Name = "cboForms"
        '
        'TabSettings
        '
        Me.TabSettings.Controls.Add(Me.grpSettings)
        resources.ApplyResources(Me.TabSettings, "TabSettings")
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.UseVisualStyleBackColor = True
        '
        'grpSettings
        '
        Me.grpSettings.Controls.Add(Me.lblDoubleEntryMode)
        Me.grpSettings.Controls.Add(Me.lblSingleEntryMode)
        Me.grpSettings.Controls.Add(Me.RadioButton1)
        Me.grpSettings.Controls.Add(Me.optTargets)
        Me.grpSettings.Controls.Add(Me.cmdUpdate)
        Me.grpSettings.Controls.Add(Me.cmdretrieve1)
        Me.grpSettings.Controls.Add(Me.DataGridSettings)
        resources.ApplyResources(Me.grpSettings, "grpSettings")
        Me.grpSettings.Name = "grpSettings"
        Me.grpSettings.TabStop = False
        '
        'lblDoubleEntryMode
        '
        resources.ApplyResources(Me.lblDoubleEntryMode, "lblDoubleEntryMode")
        Me.lblDoubleEntryMode.Name = "lblDoubleEntryMode"
        '
        'lblSingleEntryMode
        '
        resources.ApplyResources(Me.lblSingleEntryMode, "lblSingleEntryMode")
        Me.lblSingleEntryMode.Name = "lblSingleEntryMode"
        '
        'RadioButton1
        '
        resources.ApplyResources(Me.RadioButton1, "RadioButton1")
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'optTargets
        '
        resources.ApplyResources(Me.optTargets, "optTargets")
        Me.optTargets.Checked = True
        Me.optTargets.Name = "optTargets"
        Me.optTargets.TabStop = True
        Me.optTargets.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        resources.ApplyResources(Me.cmdUpdate, "cmdUpdate")
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdretrieve1
        '
        resources.ApplyResources(Me.cmdretrieve1, "cmdretrieve1")
        Me.cmdretrieve1.Name = "cmdretrieve1"
        Me.cmdretrieve1.UseVisualStyleBackColor = True
        '
        'DataGridSettings
        '
        Me.DataGridSettings.AllowUserToOrderColumns = True
        Me.DataGridSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSettings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        resources.ApplyResources(Me.DataGridSettings, "DataGridSettings")
        Me.DataGridSettings.Name = "DataGridSettings"
        '
        'ListViewRecs
        '
        Me.ListViewRecs.GridLines = True
        resources.ApplyResources(Me.ListViewRecs, "ListViewRecs")
        Me.ListViewRecs.Name = "ListViewRecs"
        Me.ListViewRecs.UseCompatibleStateImageBehavior = False
        Me.ListViewRecs.View = System.Windows.Forms.View.Details
        '
        'lblRecords
        '
        resources.ApplyResources(Me.lblRecords, "lblRecords")
        Me.lblRecords.Name = "lblRecords"
        '
        'lblTrecs
        '
        resources.ApplyResources(Me.lblTrecs, "lblTrecs")
        Me.lblTrecs.Name = "lblTrecs"
        '
        'cmdClose
        '
        resources.ApplyResources(Me.cmdClose, "cmdClose")
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        resources.ApplyResources(Me.cmdHelp, "cmdHelp")
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'frmMonitoring
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblTrecs)
        Me.Controls.Add(Me.lblRecords)
        Me.Controls.Add(Me.ListViewRecs)
        Me.Controls.Add(Me.TabMonitoring)
        Me.Name = "frmMonitoring"
        Me.TabMonitoring.ResumeLayout(False)
        Me.TabUsrRecords.ResumeLayout(False)
        Me.grpUsers.ResumeLayout(False)
        Me.grpUsers.PerformLayout()
        Me.TabPerformance.ResumeLayout(False)
        Me.grpPerformance.ResumeLayout(False)
        Me.grpPerformance.PerformLayout()
        CType(Me.DataGridPerform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEntryVerify.ResumeLayout(False)
        Me.grpVerify.ResumeLayout(False)
        Me.grpVerify.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabSettings.ResumeLayout(False)
        Me.grpSettings.ResumeLayout(False)
        Me.grpSettings.PerformLayout()
        CType(Me.DataGridSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabMonitoring As System.Windows.Forms.TabControl
    Friend WithEvents TabUsrRecords As System.Windows.Forms.TabPage
    Friend WithEvents TabEntryVerify As System.Windows.Forms.TabPage
    Friend WithEvents grpUsers As System.Windows.Forms.GroupBox
    Friend WithEvents grpVerify As System.Windows.Forms.GroupBox
    Friend WithEvents TabPerformance As System.Windows.Forms.TabPage
    Friend WithEvents grpPerformance As System.Windows.Forms.GroupBox
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents DateTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimeStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboUser As System.Windows.Forms.ComboBox
    Friend WithEvents optAll As System.Windows.Forms.RadioButton
    Friend WithEvents optUsers As System.Windows.Forms.RadioButton
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblTo1 As System.Windows.Forms.Label
    Friend WithEvents lblFrom1 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents optRange As System.Windows.Forms.RadioButton
    Friend WithEvents OptMonthly As System.Windows.Forms.RadioButton
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents cboForms As System.Windows.Forms.ComboBox
    Friend WithEvents TabSettings As System.Windows.Forms.TabPage
    Friend WithEvents grpSettings As System.Windows.Forms.GroupBox
    Friend WithEvents ListViewRecs As System.Windows.Forms.ListView
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents lblTrecs As System.Windows.Forms.Label
    Friend WithEvents cmdRetrieve As System.Windows.Forms.Button
    Friend WithEvents DataGridPerform As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSave1 As System.Windows.Forms.Button
    Friend WithEvents cmdretrieve1 As System.Windows.Forms.Button
    Friend WithEvents DataGridSettings As System.Windows.Forms.DataGridView
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdExtarct As System.Windows.Forms.Button
    Friend WithEvents txtYear2 As System.Windows.Forms.TextBox
    Friend WithEvents txtYear1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonth2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonth1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents optKeyEntryForm As System.Windows.Forms.RadioButton
    Friend WithEvents optAllForms As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optNotVerified As System.Windows.Forms.RadioButton
    Friend WithEvents optVerified As System.Windows.Forms.RadioButton
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents optTargets As System.Windows.Forms.RadioButton
    Friend WithEvents lblDoubleEntryMode As System.Windows.Forms.Label
    Friend WithEvents lblSingleEntryMode As System.Windows.Forms.Label
    Friend WithEvents cmdHelp As System.Windows.Forms.Button
End Class
