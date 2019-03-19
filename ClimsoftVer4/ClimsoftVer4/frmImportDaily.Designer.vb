<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportDaily
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportDaily))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmdOpenFile = New System.Windows.Forms.Button()
        Me.dlgOpenImportFile = New System.Windows.Forms.OpenFileDialog()
        Me.txtImportFile = New System.Windows.Forms.TextBox()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.optComma = New System.Windows.Forms.RadioButton()
        Me.OptTAB = New System.Windows.Forms.RadioButton()
        Me.OptOthers = New System.Windows.Forms.RadioButton()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.lstColumn = New System.Windows.Forms.ListBox()
        Me.cmbFields = New System.Windows.Forms.ComboBox()
        Me.cmdRename = New System.Windows.Forms.Button()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.lblDelimiters = New System.Windows.Forms.Label()
        Me.cmdLoadData = New System.Windows.Forms.Button()
        Me.txtObsHour = New System.Windows.Forms.TextBox()
        Me.lblStartRow = New System.Windows.Forms.Label()
        Me.txtStartRow = New System.Windows.Forms.TextBox()
        Me.cmdtest = New System.Windows.Forms.Button()
        Me.chkScale = New System.Windows.Forms.CheckBox()
        Me.cmdSaveSpecs = New System.Windows.Forms.Button()
        Me.cmdLoadSpecs = New System.Windows.Forms.Button()
        Me.dlgSaveSchema = New System.Windows.Forms.SaveFileDialog()
        Me.pnlHeaders = New System.Windows.Forms.Panel()
        Me.lblColumnHeaders = New System.Windows.Forms.Label()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtStn = New System.Windows.Forms.TextBox()
        Me.lblStn = New System.Windows.Forms.Label()
        Me.lblDefaultObsHour = New System.Windows.Forms.Label()
        Me.lblTRecords = New System.Windows.Forms.Label()
        Me.lblStnEror = New System.Windows.Forms.Label()
        Me.lblElmeror = New System.Windows.Forms.Label()
        Me.lstStations = New System.Windows.Forms.ListBox()
        Me.lstElements = New System.Windows.Forms.ListBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeaders.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        '
        'cmdOpenFile
        '
        resources.ApplyResources(Me.cmdOpenFile, "cmdOpenFile")
        Me.cmdOpenFile.Name = "cmdOpenFile"
        Me.cmdOpenFile.UseVisualStyleBackColor = True
        '
        'dlgOpenImportFile
        '
        Me.dlgOpenImportFile.FileName = "txtImport"
        '
        'txtImportFile
        '
        resources.ApplyResources(Me.txtImportFile, "txtImportFile")
        Me.txtImportFile.Name = "txtImportFile"
        '
        'cmdView
        '
        resources.ApplyResources(Me.cmdView, "cmdView")
        Me.cmdView.Name = "cmdView"
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'optComma
        '
        resources.ApplyResources(Me.optComma, "optComma")
        Me.optComma.Checked = True
        Me.optComma.Name = "optComma"
        Me.optComma.TabStop = True
        Me.optComma.UseVisualStyleBackColor = True
        '
        'OptTAB
        '
        resources.ApplyResources(Me.OptTAB, "OptTAB")
        Me.OptTAB.Name = "OptTAB"
        Me.OptTAB.UseVisualStyleBackColor = True
        '
        'OptOthers
        '
        resources.ApplyResources(Me.OptOthers, "OptOthers")
        Me.OptOthers.Name = "OptOthers"
        Me.OptOthers.UseVisualStyleBackColor = True
        '
        'txtOther
        '
        resources.ApplyResources(Me.txtOther, "txtOther")
        Me.txtOther.Name = "txtOther"
        '
        'cmdClear
        '
        resources.ApplyResources(Me.cmdClear, "cmdClear")
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'lstColumn
        '
        Me.lstColumn.FormattingEnabled = True
        resources.ApplyResources(Me.lstColumn, "lstColumn")
        Me.lstColumn.Name = "lstColumn"
        '
        'cmbFields
        '
        Me.cmbFields.FormattingEnabled = True
        Me.cmbFields.Items.AddRange(New Object() {resources.GetString("cmbFields.Items"), resources.GetString("cmbFields.Items1"), resources.GetString("cmbFields.Items2"), resources.GetString("cmbFields.Items3"), resources.GetString("cmbFields.Items4"), resources.GetString("cmbFields.Items5"), resources.GetString("cmbFields.Items6"), resources.GetString("cmbFields.Items7"), resources.GetString("cmbFields.Items8"), resources.GetString("cmbFields.Items9"), resources.GetString("cmbFields.Items10"), resources.GetString("cmbFields.Items11"), resources.GetString("cmbFields.Items12"), resources.GetString("cmbFields.Items13"), resources.GetString("cmbFields.Items14"), resources.GetString("cmbFields.Items15"), resources.GetString("cmbFields.Items16"), resources.GetString("cmbFields.Items17"), resources.GetString("cmbFields.Items18"), resources.GetString("cmbFields.Items19"), resources.GetString("cmbFields.Items20"), resources.GetString("cmbFields.Items21"), resources.GetString("cmbFields.Items22"), resources.GetString("cmbFields.Items23"), resources.GetString("cmbFields.Items24"), resources.GetString("cmbFields.Items25"), resources.GetString("cmbFields.Items26"), resources.GetString("cmbFields.Items27"), resources.GetString("cmbFields.Items28"), resources.GetString("cmbFields.Items29"), resources.GetString("cmbFields.Items30"), resources.GetString("cmbFields.Items31"), resources.GetString("cmbFields.Items32"), resources.GetString("cmbFields.Items33"), resources.GetString("cmbFields.Items34"), resources.GetString("cmbFields.Items35"), resources.GetString("cmbFields.Items36"), resources.GetString("cmbFields.Items37"), resources.GetString("cmbFields.Items38"), resources.GetString("cmbFields.Items39"), resources.GetString("cmbFields.Items40")})
        resources.ApplyResources(Me.cmbFields, "cmbFields")
        Me.cmbFields.Name = "cmbFields"
        '
        'cmdRename
        '
        resources.ApplyResources(Me.cmdRename, "cmdRename")
        Me.cmdRename.Name = "cmdRename"
        Me.cmdRename.UseVisualStyleBackColor = True
        '
        'lblColumns
        '
        resources.ApplyResources(Me.lblColumns, "lblColumns")
        Me.lblColumns.Name = "lblColumns"
        '
        'lblFieldName
        '
        resources.ApplyResources(Me.lblFieldName, "lblFieldName")
        Me.lblFieldName.Name = "lblFieldName"
        '
        'lblDelimiters
        '
        resources.ApplyResources(Me.lblDelimiters, "lblDelimiters")
        Me.lblDelimiters.Name = "lblDelimiters"
        '
        'cmdLoadData
        '
        resources.ApplyResources(Me.cmdLoadData, "cmdLoadData")
        Me.cmdLoadData.Name = "cmdLoadData"
        Me.cmdLoadData.UseVisualStyleBackColor = True
        '
        'txtObsHour
        '
        resources.ApplyResources(Me.txtObsHour, "txtObsHour")
        Me.txtObsHour.Name = "txtObsHour"
        '
        'lblStartRow
        '
        resources.ApplyResources(Me.lblStartRow, "lblStartRow")
        Me.lblStartRow.Name = "lblStartRow"
        '
        'txtStartRow
        '
        resources.ApplyResources(Me.txtStartRow, "txtStartRow")
        Me.txtStartRow.Name = "txtStartRow"
        '
        'cmdtest
        '
        resources.ApplyResources(Me.cmdtest, "cmdtest")
        Me.cmdtest.Name = "cmdtest"
        Me.cmdtest.UseVisualStyleBackColor = True
        '
        'chkScale
        '
        resources.ApplyResources(Me.chkScale, "chkScale")
        Me.chkScale.Name = "chkScale"
        Me.chkScale.UseVisualStyleBackColor = True
        '
        'cmdSaveSpecs
        '
        resources.ApplyResources(Me.cmdSaveSpecs, "cmdSaveSpecs")
        Me.cmdSaveSpecs.Name = "cmdSaveSpecs"
        Me.cmdSaveSpecs.UseVisualStyleBackColor = True
        '
        'cmdLoadSpecs
        '
        resources.ApplyResources(Me.cmdLoadSpecs, "cmdLoadSpecs")
        Me.cmdLoadSpecs.Name = "cmdLoadSpecs"
        Me.cmdLoadSpecs.UseVisualStyleBackColor = True
        '
        'pnlHeaders
        '
        Me.pnlHeaders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeaders.Controls.Add(Me.lblColumnHeaders)
        Me.pnlHeaders.Controls.Add(Me.lstColumn)
        Me.pnlHeaders.Controls.Add(Me.cmdLoadSpecs)
        Me.pnlHeaders.Controls.Add(Me.cmdSaveSpecs)
        Me.pnlHeaders.Controls.Add(Me.cmbFields)
        Me.pnlHeaders.Controls.Add(Me.cmdRename)
        Me.pnlHeaders.Controls.Add(Me.lblColumns)
        Me.pnlHeaders.Controls.Add(Me.lblFieldName)
        resources.ApplyResources(Me.pnlHeaders, "pnlHeaders")
        Me.pnlHeaders.Name = "pnlHeaders"
        '
        'lblColumnHeaders
        '
        resources.ApplyResources(Me.lblColumnHeaders, "lblColumnHeaders")
        Me.lblColumnHeaders.Name = "lblColumnHeaders"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        resources.ApplyResources(Me.ToolStripLabel1, "ToolStripLabel1")
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
        'lblRecords
        '
        resources.ApplyResources(Me.lblRecords, "lblRecords")
        Me.lblRecords.ForeColor = System.Drawing.Color.Red
        Me.lblRecords.Name = "lblRecords"
        '
        'lblType
        '
        resources.ApplyResources(Me.lblType, "lblType")
        Me.lblType.Name = "lblType"
        '
        'txtStn
        '
        resources.ApplyResources(Me.txtStn, "txtStn")
        Me.txtStn.Name = "txtStn"
        '
        'lblStn
        '
        resources.ApplyResources(Me.lblStn, "lblStn")
        Me.lblStn.Name = "lblStn"
        '
        'lblDefaultObsHour
        '
        resources.ApplyResources(Me.lblDefaultObsHour, "lblDefaultObsHour")
        Me.lblDefaultObsHour.Name = "lblDefaultObsHour"
        '
        'lblTRecords
        '
        resources.ApplyResources(Me.lblTRecords, "lblTRecords")
        Me.lblTRecords.Name = "lblTRecords"
        '
        'lblStnEror
        '
        resources.ApplyResources(Me.lblStnEror, "lblStnEror")
        Me.lblStnEror.Name = "lblStnEror"
        '
        'lblElmeror
        '
        resources.ApplyResources(Me.lblElmeror, "lblElmeror")
        Me.lblElmeror.Name = "lblElmeror"
        '
        'lstStations
        '
        Me.lstStations.FormattingEnabled = True
        resources.ApplyResources(Me.lstStations, "lstStations")
        Me.lstStations.Name = "lstStations"
        '
        'lstElements
        '
        Me.lstElements.FormattingEnabled = True
        resources.ApplyResources(Me.lstElements, "lstElements")
        Me.lstElements.Name = "lstElements"
        '
        'frmImportDaily
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstElements)
        Me.Controls.Add(Me.lstStations)
        Me.Controls.Add(Me.lblElmeror)
        Me.Controls.Add(Me.lblStnEror)
        Me.Controls.Add(Me.lblTRecords)
        Me.Controls.Add(Me.lblDefaultObsHour)
        Me.Controls.Add(Me.lblStn)
        Me.Controls.Add(Me.txtStn)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblRecords)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.pnlHeaders)
        Me.Controls.Add(Me.cmdtest)
        Me.Controls.Add(Me.chkScale)
        Me.Controls.Add(Me.txtStartRow)
        Me.Controls.Add(Me.lblStartRow)
        Me.Controls.Add(Me.txtObsHour)
        Me.Controls.Add(Me.cmdLoadData)
        Me.Controls.Add(Me.lblDelimiters)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.txtOther)
        Me.Controls.Add(Me.OptOthers)
        Me.Controls.Add(Me.OptTAB)
        Me.Controls.Add(Me.optComma)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.txtImportFile)
        Me.Controls.Add(Me.cmdOpenFile)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmImportDaily"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeaders.ResumeLayout(False)
        Me.pnlHeaders.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdOpenFile As System.Windows.Forms.Button
    Friend WithEvents dlgOpenImportFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtImportFile As System.Windows.Forms.TextBox
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents optComma As System.Windows.Forms.RadioButton
    Friend WithEvents OptTAB As System.Windows.Forms.RadioButton
    Friend WithEvents OptOthers As System.Windows.Forms.RadioButton
    Friend WithEvents txtOther As System.Windows.Forms.TextBox
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents lstColumn As System.Windows.Forms.ListBox
    Friend WithEvents cmbFields As System.Windows.Forms.ComboBox
    Friend WithEvents cmdRename As System.Windows.Forms.Button
    Friend WithEvents lblColumns As System.Windows.Forms.Label
    Friend WithEvents lblFieldName As System.Windows.Forms.Label
    Friend WithEvents lblDelimiters As System.Windows.Forms.Label
    Friend WithEvents cmdLoadData As System.Windows.Forms.Button
    Friend WithEvents txtObsHour As System.Windows.Forms.TextBox
    Friend WithEvents lblStartRow As System.Windows.Forms.Label
    Friend WithEvents txtStartRow As System.Windows.Forms.TextBox
    Friend WithEvents cmdtest As System.Windows.Forms.Button
    Friend WithEvents chkScale As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSaveSpecs As System.Windows.Forms.Button
    Friend WithEvents cmdLoadSpecs As System.Windows.Forms.Button
    Friend WithEvents dlgSaveSchema As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pnlHeaders As System.Windows.Forms.Panel
    Friend WithEvents lblColumnHeaders As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdHelp As System.Windows.Forms.Button
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents txtStn As System.Windows.Forms.TextBox
    Friend WithEvents lblStn As System.Windows.Forms.Label
    Friend WithEvents lblDefaultObsHour As System.Windows.Forms.Label
    Friend WithEvents lblTRecords As System.Windows.Forms.Label
    Friend WithEvents lblStnEror As Label
    Friend WithEvents lblElmeror As Label
    Friend WithEvents lstStations As ListBox
    Friend WithEvents lstElements As ListBox
End Class
