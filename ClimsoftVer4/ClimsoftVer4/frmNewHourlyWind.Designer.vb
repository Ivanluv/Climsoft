<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewHourlyWind
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
        Dim lblYear As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewHourlyWind))
        Me.lblStationSelector = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSpeedDigits = New System.Windows.Forms.TextBox()
        Me.txtDirectionDigits = New System.Windows.Forms.TextBox()
        Me.lblSpeedDigits = New System.Windows.Forms.Label()
        Me.lblDirectionDigits = New System.Windows.Forms.Label()
        Me.btnHourSelection = New System.Windows.Forms.Button()
        Me.lblSequencer = New System.Windows.Forms.Label()
        Me.txtSequencer = New System.Windows.Forms.TextBox()
        Me.ucrHourlyWind = New ClimsoftVer4.ucrHourlyWind()
        Me.ucrNavigation = New ClimsoftVer4.ucrNavigation()
        Me.ucrDay = New ClimsoftVer4.ucrDay()
        Me.ucrMonth = New ClimsoftVer4.ucrMonth()
        Me.ucrYearSelector = New ClimsoftVer4.ucrYearSelector()
        Me.ucrStationSelector = New ClimsoftVer4.ucrStationSelector()
        Me.chkRepeatEntry = New System.Windows.Forms.CheckBox()
        lblYear = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblYear
        '
        resources.ApplyResources(lblYear, "lblYear")
        lblYear.Name = "lblYear"
        '
        'lblStationSelector
        '
        resources.ApplyResources(Me.lblStationSelector, "lblStationSelector")
        Me.lblStationSelector.Name = "lblStationSelector"
        '
        'lblDay
        '
        resources.ApplyResources(Me.lblDay, "lblDay")
        Me.lblDay.Name = "lblDay"
        '
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        '
        'btnView
        '
        resources.ApplyResources(Me.btnView, "btnView")
        Me.btnView.Name = "btnView"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.Lime
        resources.ApplyResources(Me.btnUpload, "btnUpload")
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.UseVisualStyleBackColor = False
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
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Name = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = True
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
        'txtSpeedDigits
        '
        resources.ApplyResources(Me.txtSpeedDigits, "txtSpeedDigits")
        Me.txtSpeedDigits.Name = "txtSpeedDigits"
        '
        'txtDirectionDigits
        '
        resources.ApplyResources(Me.txtDirectionDigits, "txtDirectionDigits")
        Me.txtDirectionDigits.Name = "txtDirectionDigits"
        '
        'lblSpeedDigits
        '
        resources.ApplyResources(Me.lblSpeedDigits, "lblSpeedDigits")
        Me.lblSpeedDigits.ForeColor = System.Drawing.Color.Blue
        Me.lblSpeedDigits.Name = "lblSpeedDigits"
        '
        'lblDirectionDigits
        '
        resources.ApplyResources(Me.lblDirectionDigits, "lblDirectionDigits")
        Me.lblDirectionDigits.ForeColor = System.Drawing.Color.Blue
        Me.lblDirectionDigits.Name = "lblDirectionDigits"
        '
        'btnHourSelection
        '
        Me.btnHourSelection.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.btnHourSelection, "btnHourSelection")
        Me.btnHourSelection.Name = "btnHourSelection"
        Me.btnHourSelection.UseVisualStyleBackColor = True
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
        'ucrHourlyWind
        '
        resources.ApplyResources(Me.ucrHourlyWind, "ucrHourlyWind")
        Me.ucrHourlyWind.Name = "ucrHourlyWind"
        '
        'ucrNavigation
        '
        resources.ApplyResources(Me.ucrNavigation, "ucrNavigation")
        Me.ucrNavigation.Name = "ucrNavigation"
        '
        'ucrDay
        '
        resources.ApplyResources(Me.ucrDay, "ucrDay")
        Me.ucrDay.Name = "ucrDay"
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
        'ucrStationSelector
        '
        resources.ApplyResources(Me.ucrStationSelector, "ucrStationSelector")
        Me.ucrStationSelector.Name = "ucrStationSelector"
        '
        'chkRepeatEntry
        '
        resources.ApplyResources(Me.chkRepeatEntry, "chkRepeatEntry")
        Me.chkRepeatEntry.Name = "chkRepeatEntry"
        Me.chkRepeatEntry.UseVisualStyleBackColor = True
        '
        'frmNewHourlyWind
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkRepeatEntry)
        Me.Controls.Add(Me.ucrHourlyWind)
        Me.Controls.Add(Me.lblSequencer)
        Me.Controls.Add(Me.txtSequencer)
        Me.Controls.Add(Me.txtSpeedDigits)
        Me.Controls.Add(Me.txtDirectionDigits)
        Me.Controls.Add(Me.lblSpeedDigits)
        Me.Controls.Add(Me.lblDirectionDigits)
        Me.Controls.Add(Me.btnHourSelection)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ucrNavigation)
        Me.Controls.Add(Me.ucrDay)
        Me.Controls.Add(Me.ucrMonth)
        Me.Controls.Add(Me.ucrYearSelector)
        Me.Controls.Add(Me.ucrStationSelector)
        Me.Controls.Add(Me.lblStationSelector)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(lblYear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNewHourlyWind"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDay As ucrDay
    Friend WithEvents ucrMonth As ucrMonth
    Friend WithEvents ucrYearSelector As ucrYearSelector
    Friend WithEvents ucrStationSelector As ucrStationSelector
    Friend WithEvents lblStationSelector As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrNavigation As ucrNavigation
    Friend WithEvents btnView As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtSpeedDigits As TextBox
    Friend WithEvents txtDirectionDigits As TextBox
    Friend WithEvents lblSpeedDigits As Label
    Friend WithEvents lblDirectionDigits As Label
    Friend WithEvents btnHourSelection As Button
    Friend WithEvents lblSequencer As Label
    Friend WithEvents txtSequencer As TextBox
    Friend WithEvents ucrHourlyWind As ucrHourlyWind
    Friend WithEvents chkRepeatEntry As CheckBox
End Class
