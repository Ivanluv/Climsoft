<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewSynopticRA1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim lblYear As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewSynopticRA1))
        Me.lblStationSelector = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.btnTDCF = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSequencer = New System.Windows.Forms.TextBox()
        Me.ucrNavigation = New ClimsoftVer4.ucrNavigation()
        Me.ucrDay = New ClimsoftVer4.ucrDay()
        Me.ucrSynopticRA1 = New ClimsoftVer4.ucrSynopticRA1()
        Me.ucrHour = New ClimsoftVer4.ucrHour()
        Me.ucrMonth = New ClimsoftVer4.ucrMonth()
        Me.ucrYearSelector = New ClimsoftVer4.ucrYearSelector()
        Me.ucrStationSelector = New ClimsoftVer4.ucrStationSelector()
        Me.chkAutoFillValues = New System.Windows.Forms.CheckBox()
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
        'lblHour
        '
        resources.ApplyResources(Me.lblHour, "lblHour")
        Me.lblHour.Name = "lblHour"
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
        'btnTDCF
        '
        resources.ApplyResources(Me.btnTDCF, "btnTDCF")
        Me.btnTDCF.Name = "btnTDCF"
        Me.btnTDCF.UseVisualStyleBackColor = True
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
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
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
        'txtSequencer
        '
        resources.ApplyResources(Me.txtSequencer, "txtSequencer")
        Me.txtSequencer.Name = "txtSequencer"
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
        'ucrSynopticRA1
        '
        resources.ApplyResources(Me.ucrSynopticRA1, "ucrSynopticRA1")
        Me.ucrSynopticRA1.Name = "ucrSynopticRA1"
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
        'ucrStationSelector
        '
        resources.ApplyResources(Me.ucrStationSelector, "ucrStationSelector")
        Me.ucrStationSelector.Name = "ucrStationSelector"
        '
        'chkAutoFillValues
        '
        resources.ApplyResources(Me.chkAutoFillValues, "chkAutoFillValues")
        Me.chkAutoFillValues.Checked = True
        Me.chkAutoFillValues.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoFillValues.ForeColor = System.Drawing.Color.Red
        Me.chkAutoFillValues.Name = "chkAutoFillValues"
        Me.chkAutoFillValues.UseVisualStyleBackColor = True
        '
        'chkRepeatEntry
        '
        resources.ApplyResources(Me.chkRepeatEntry, "chkRepeatEntry")
        Me.chkRepeatEntry.Name = "chkRepeatEntry"
        Me.chkRepeatEntry.UseVisualStyleBackColor = True
        '
        'frmNewSynopticRA1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkRepeatEntry)
        Me.Controls.Add(Me.chkAutoFillValues)
        Me.Controls.Add(Me.txtSequencer)
        Me.Controls.Add(Me.ucrNavigation)
        Me.Controls.Add(Me.btnTDCF)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ucrDay)
        Me.Controls.Add(Me.ucrSynopticRA1)
        Me.Controls.Add(Me.ucrHour)
        Me.Controls.Add(Me.ucrMonth)
        Me.Controls.Add(Me.ucrYearSelector)
        Me.Controls.Add(Me.ucrStationSelector)
        Me.Controls.Add(Me.lblStationSelector)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(lblYear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNewSynopticRA1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStationSelector As Label
    Friend WithEvents lblHour As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrStationSelector As ucrStationSelector
    Friend WithEvents ucrYearSelector As ucrYearSelector
    Friend WithEvents ucrMonth As ucrMonth
    Friend WithEvents ucrHour As ucrHour
    Friend WithEvents ucrSynopticRA1 As ucrSynopticRA1
    Friend WithEvents ucrDay As ucrDay
    Friend WithEvents btnTDCF As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents ucrNavigation As ucrNavigation
    Friend WithEvents txtSequencer As TextBox
    Friend WithEvents chkAutoFillValues As CheckBox
    Friend WithEvents chkRepeatEntry As CheckBox
End Class
