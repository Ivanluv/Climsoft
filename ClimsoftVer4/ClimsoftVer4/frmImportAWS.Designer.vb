<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportAWS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportAWS))
        Me.btnBrowseSchemaFile = New System.Windows.Forms.Button()
        Me.btnBrowseDataFile = New System.Windows.Forms.Button()
        Me.lblSchemaFile = New System.Windows.Forms.Label()
        Me.txtSchemaFile = New System.Windows.Forms.TextBox()
        Me.lblDataFile = New System.Windows.Forms.Label()
        Me.txtDataFile = New System.Windows.Forms.TextBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtStationColumn = New System.Windows.Forms.TextBox()
        Me.lblStationColumn = New System.Windows.Forms.Label()
        Me.txtDateColumn = New System.Windows.Forms.TextBox()
        Me.lblDateColumn = New System.Windows.Forms.Label()
        Me.txtTimeColumn = New System.Windows.Forms.TextBox()
        Me.lblTimeColumn = New System.Windows.Forms.Label()
        Me.txtValStartColumn = New System.Windows.Forms.TextBox()
        Me.lblValStartColumn = New System.Windows.Forms.Label()
        Me.lblGuidelines = New System.Windows.Forms.Label()
        Me.txtHourAdjustment = New System.Windows.Forms.TextBox()
        Me.lblTimeAdjustment = New System.Windows.Forms.Label()
        Me.lblHourAdjustment = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.frameSetSchedule = New System.Windows.Forms.GroupBox()
        Me.lblScheduleMinute = New System.Windows.Forms.Label()
        Me.lblscheduleHour = New System.Windows.Forms.Label()
        Me.txtTimerStartMinute = New System.Windows.Forms.TextBox()
        Me.txtTimerStartHour = New System.Windows.Forms.TextBox()
        Me.btnSetSchedule = New System.Windows.Forms.Button()
        Me.lblTimerActivationStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.frameSetSchedule.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBrowseSchemaFile
        '
        resources.ApplyResources(Me.btnBrowseSchemaFile, "btnBrowseSchemaFile")
        Me.btnBrowseSchemaFile.Name = "btnBrowseSchemaFile"
        Me.btnBrowseSchemaFile.UseVisualStyleBackColor = True
        '
        'btnBrowseDataFile
        '
        resources.ApplyResources(Me.btnBrowseDataFile, "btnBrowseDataFile")
        Me.btnBrowseDataFile.Name = "btnBrowseDataFile"
        Me.btnBrowseDataFile.UseVisualStyleBackColor = True
        '
        'lblSchemaFile
        '
        resources.ApplyResources(Me.lblSchemaFile, "lblSchemaFile")
        Me.lblSchemaFile.Name = "lblSchemaFile"
        '
        'txtSchemaFile
        '
        resources.ApplyResources(Me.txtSchemaFile, "txtSchemaFile")
        Me.txtSchemaFile.Name = "txtSchemaFile"
        '
        'lblDataFile
        '
        resources.ApplyResources(Me.lblDataFile, "lblDataFile")
        Me.lblDataFile.Name = "lblDataFile"
        '
        'txtDataFile
        '
        resources.ApplyResources(Me.txtDataFile, "txtDataFile")
        Me.txtDataFile.Name = "txtDataFile"
        '
        'btnHelp
        '
        resources.ApplyResources(Me.btnHelp, "btnHelp")
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        resources.ApplyResources(Me.btnOK, "btnOK")
        Me.btnOK.Name = "btnOK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtStationColumn
        '
        resources.ApplyResources(Me.txtStationColumn, "txtStationColumn")
        Me.txtStationColumn.Name = "txtStationColumn"
        '
        'lblStationColumn
        '
        resources.ApplyResources(Me.lblStationColumn, "lblStationColumn")
        Me.lblStationColumn.Name = "lblStationColumn"
        '
        'txtDateColumn
        '
        resources.ApplyResources(Me.txtDateColumn, "txtDateColumn")
        Me.txtDateColumn.Name = "txtDateColumn"
        '
        'lblDateColumn
        '
        resources.ApplyResources(Me.lblDateColumn, "lblDateColumn")
        Me.lblDateColumn.Name = "lblDateColumn"
        '
        'txtTimeColumn
        '
        resources.ApplyResources(Me.txtTimeColumn, "txtTimeColumn")
        Me.txtTimeColumn.Name = "txtTimeColumn"
        '
        'lblTimeColumn
        '
        resources.ApplyResources(Me.lblTimeColumn, "lblTimeColumn")
        Me.lblTimeColumn.Name = "lblTimeColumn"
        '
        'txtValStartColumn
        '
        resources.ApplyResources(Me.txtValStartColumn, "txtValStartColumn")
        Me.txtValStartColumn.Name = "txtValStartColumn"
        '
        'lblValStartColumn
        '
        resources.ApplyResources(Me.lblValStartColumn, "lblValStartColumn")
        Me.lblValStartColumn.Name = "lblValStartColumn"
        '
        'lblGuidelines
        '
        resources.ApplyResources(Me.lblGuidelines, "lblGuidelines")
        Me.lblGuidelines.ForeColor = System.Drawing.Color.Red
        Me.lblGuidelines.Name = "lblGuidelines"
        '
        'txtHourAdjustment
        '
        resources.ApplyResources(Me.txtHourAdjustment, "txtHourAdjustment")
        Me.txtHourAdjustment.Name = "txtHourAdjustment"
        '
        'lblTimeAdjustment
        '
        resources.ApplyResources(Me.lblTimeAdjustment, "lblTimeAdjustment")
        Me.lblTimeAdjustment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTimeAdjustment.Name = "lblTimeAdjustment"
        '
        'lblHourAdjustment
        '
        resources.ApplyResources(Me.lblHourAdjustment, "lblHourAdjustment")
        Me.lblHourAdjustment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHourAdjustment.Name = "lblHourAdjustment"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frameSetSchedule
        '
        Me.frameSetSchedule.Controls.Add(Me.lblScheduleMinute)
        Me.frameSetSchedule.Controls.Add(Me.lblscheduleHour)
        Me.frameSetSchedule.Controls.Add(Me.txtTimerStartMinute)
        Me.frameSetSchedule.Controls.Add(Me.txtTimerStartHour)
        resources.ApplyResources(Me.frameSetSchedule, "frameSetSchedule")
        Me.frameSetSchedule.Name = "frameSetSchedule"
        Me.frameSetSchedule.TabStop = False
        '
        'lblScheduleMinute
        '
        resources.ApplyResources(Me.lblScheduleMinute, "lblScheduleMinute")
        Me.lblScheduleMinute.Name = "lblScheduleMinute"
        '
        'lblscheduleHour
        '
        resources.ApplyResources(Me.lblscheduleHour, "lblscheduleHour")
        Me.lblscheduleHour.Name = "lblscheduleHour"
        '
        'txtTimerStartMinute
        '
        resources.ApplyResources(Me.txtTimerStartMinute, "txtTimerStartMinute")
        Me.txtTimerStartMinute.Name = "txtTimerStartMinute"
        '
        'txtTimerStartHour
        '
        resources.ApplyResources(Me.txtTimerStartHour, "txtTimerStartHour")
        Me.txtTimerStartHour.Name = "txtTimerStartHour"
        '
        'btnSetSchedule
        '
        resources.ApplyResources(Me.btnSetSchedule, "btnSetSchedule")
        Me.btnSetSchedule.Name = "btnSetSchedule"
        Me.btnSetSchedule.UseVisualStyleBackColor = True
        '
        'lblTimerActivationStatus
        '
        resources.ApplyResources(Me.lblTimerActivationStatus, "lblTimerActivationStatus")
        Me.lblTimerActivationStatus.ForeColor = System.Drawing.Color.Red
        Me.lblTimerActivationStatus.Name = "lblTimerActivationStatus"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Name = "Label1"
        '
        'frmImportAWS
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTimerActivationStatus)
        Me.Controls.Add(Me.btnSetSchedule)
        Me.Controls.Add(Me.frameSetSchedule)
        Me.Controls.Add(Me.lblHourAdjustment)
        Me.Controls.Add(Me.lblTimeAdjustment)
        Me.Controls.Add(Me.txtHourAdjustment)
        Me.Controls.Add(Me.lblGuidelines)
        Me.Controls.Add(Me.lblValStartColumn)
        Me.Controls.Add(Me.txtValStartColumn)
        Me.Controls.Add(Me.lblTimeColumn)
        Me.Controls.Add(Me.txtTimeColumn)
        Me.Controls.Add(Me.lblDateColumn)
        Me.Controls.Add(Me.txtDateColumn)
        Me.Controls.Add(Me.lblStationColumn)
        Me.Controls.Add(Me.txtStationColumn)
        Me.Controls.Add(Me.btnBrowseSchemaFile)
        Me.Controls.Add(Me.btnBrowseDataFile)
        Me.Controls.Add(Me.lblSchemaFile)
        Me.Controls.Add(Me.txtSchemaFile)
        Me.Controls.Add(Me.lblDataFile)
        Me.Controls.Add(Me.txtDataFile)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportAWS"
        Me.frameSetSchedule.ResumeLayout(False)
        Me.frameSetSchedule.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowseSchemaFile As System.Windows.Forms.Button
    Friend WithEvents btnBrowseDataFile As System.Windows.Forms.Button
    Friend WithEvents lblSchemaFile As System.Windows.Forms.Label
    Friend WithEvents txtSchemaFile As System.Windows.Forms.TextBox
    Friend WithEvents lblDataFile As System.Windows.Forms.Label
    Friend WithEvents txtDataFile As System.Windows.Forms.TextBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtStationColumn As System.Windows.Forms.TextBox
    Friend WithEvents lblStationColumn As System.Windows.Forms.Label
    Friend WithEvents txtDateColumn As System.Windows.Forms.TextBox
    Friend WithEvents lblDateColumn As System.Windows.Forms.Label
    Friend WithEvents txtTimeColumn As System.Windows.Forms.TextBox
    Friend WithEvents lblTimeColumn As System.Windows.Forms.Label
    Friend WithEvents txtValStartColumn As System.Windows.Forms.TextBox
    Friend WithEvents lblValStartColumn As System.Windows.Forms.Label
    Friend WithEvents lblGuidelines As System.Windows.Forms.Label
    Friend WithEvents txtHourAdjustment As System.Windows.Forms.TextBox
    Friend WithEvents lblTimeAdjustment As System.Windows.Forms.Label
    Friend WithEvents lblHourAdjustment As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents frameSetSchedule As System.Windows.Forms.GroupBox
    Friend WithEvents lblScheduleMinute As System.Windows.Forms.Label
    Friend WithEvents lblscheduleHour As System.Windows.Forms.Label
    Friend WithEvents txtTimerStartMinute As System.Windows.Forms.TextBox
    Friend WithEvents txtTimerStartHour As System.Windows.Forms.TextBox
    Friend WithEvents btnSetSchedule As System.Windows.Forms.Button
    Friend WithEvents lblTimerActivationStatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
