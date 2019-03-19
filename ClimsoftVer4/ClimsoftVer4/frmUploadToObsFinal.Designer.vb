<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUploadToObsFinal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUploadToObsFinal))
        Me.lblProcessingStatus = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblEndMonth = New System.Windows.Forms.Label()
        Me.lblBeginMonth = New System.Windows.Forms.Label()
        Me.lblEndYear = New System.Windows.Forms.Label()
        Me.lblBeginYear = New System.Windows.Forms.Label()
        Me.txtEndMonth = New System.Windows.Forms.TextBox()
        Me.txtBeginMonth = New System.Windows.Forms.TextBox()
        Me.txtEndYear = New System.Windows.Forms.TextBox()
        Me.txtBeginYear = New System.Windows.Forms.TextBox()
        Me.chkAllElements = New System.Windows.Forms.CheckBox()
        Me.chkAllStations = New System.Windows.Forms.CheckBox()
        Me.lstViewElements = New System.Windows.Forms.ListView()
        Me.LstViewStations = New System.Windows.Forms.ListView()
        Me.cmdUploadData = New System.Windows.Forms.Button()
        Me.txtDataTransferProgress = New System.Windows.Forms.TextBox()
        Me.lblTableRecords = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblProcessingStatus
        '
        resources.ApplyResources(Me.lblProcessingStatus, "lblProcessingStatus")
        Me.lblProcessingStatus.ForeColor = System.Drawing.Color.Red
        Me.lblProcessingStatus.Name = "lblProcessingStatus"
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
        'chkAllElements
        '
        resources.ApplyResources(Me.chkAllElements, "chkAllElements")
        Me.chkAllElements.Name = "chkAllElements"
        Me.chkAllElements.UseVisualStyleBackColor = True
        '
        'chkAllStations
        '
        resources.ApplyResources(Me.chkAllStations, "chkAllStations")
        Me.chkAllStations.Name = "chkAllStations"
        Me.chkAllStations.UseVisualStyleBackColor = True
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
        'cmdUploadData
        '
        resources.ApplyResources(Me.cmdUploadData, "cmdUploadData")
        Me.cmdUploadData.Name = "cmdUploadData"
        Me.cmdUploadData.UseVisualStyleBackColor = True
        '
        'txtDataTransferProgress
        '
        Me.txtDataTransferProgress.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.txtDataTransferProgress, "txtDataTransferProgress")
        Me.txtDataTransferProgress.Name = "txtDataTransferProgress"
        '
        'lblTableRecords
        '
        resources.ApplyResources(Me.lblTableRecords, "lblTableRecords")
        Me.lblTableRecords.ForeColor = System.Drawing.Color.Black
        Me.lblTableRecords.Name = "lblTableRecords"
        '
        'frmUploadToObsFinal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTableRecords)
        Me.Controls.Add(Me.txtDataTransferProgress)
        Me.Controls.Add(Me.cmdUploadData)
        Me.Controls.Add(Me.chkAllElements)
        Me.Controls.Add(Me.chkAllStations)
        Me.Controls.Add(Me.lstViewElements)
        Me.Controls.Add(Me.LstViewStations)
        Me.Controls.Add(Me.lblProcessingStatus)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblEndMonth)
        Me.Controls.Add(Me.lblBeginMonth)
        Me.Controls.Add(Me.lblEndYear)
        Me.Controls.Add(Me.lblBeginYear)
        Me.Controls.Add(Me.txtEndMonth)
        Me.Controls.Add(Me.txtBeginMonth)
        Me.Controls.Add(Me.txtEndYear)
        Me.Controls.Add(Me.txtBeginYear)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUploadToObsFinal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProcessingStatus As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblEndMonth As System.Windows.Forms.Label
    Friend WithEvents lblBeginMonth As System.Windows.Forms.Label
    Friend WithEvents lblEndYear As System.Windows.Forms.Label
    Friend WithEvents lblBeginYear As System.Windows.Forms.Label
    Friend WithEvents txtEndMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtBeginMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtEndYear As System.Windows.Forms.TextBox
    Friend WithEvents txtBeginYear As System.Windows.Forms.TextBox
    Friend WithEvents chkAllElements As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllStations As System.Windows.Forms.CheckBox
    Public WithEvents lstViewElements As System.Windows.Forms.ListView
    Public WithEvents LstViewStations As System.Windows.Forms.ListView
    Friend WithEvents cmdUploadData As System.Windows.Forms.Button
    Friend WithEvents txtDataTransferProgress As System.Windows.Forms.TextBox
    Friend WithEvents lblTableRecords As System.Windows.Forms.Label
End Class
