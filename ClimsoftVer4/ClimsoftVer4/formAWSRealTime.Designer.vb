<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAWSRealTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAWSRealTime))
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdMessages = New System.Windows.Forms.Button()
        Me.cmdDataStructures = New System.Windows.Forms.Button()
        Me.cmdSites = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdServers = New System.Windows.Forms.Button()
        Me.cmdProcess = New System.Windows.Forms.Button()
        Me.pnlProcessing = New System.Windows.Forms.Panel()
        Me.pnlProcessSettings = New System.Windows.Forms.Panel()
        Me.optStart = New System.Windows.Forms.RadioButton()
        Me.txtGMTDiff = New System.Windows.Forms.TextBox()
        Me.lblGMT = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.chkDeleteFile = New System.Windows.Forms.CheckBox()
        Me.txtTimeout = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtOffset = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtInterval = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.optStop = New System.Windows.Forms.RadioButton()
        Me.list_errors = New System.Windows.Forms.ListBox()
        Me.Ltime = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtQC = New System.Windows.Forms.TextBox()
        Me.txtNxtProcess = New System.Windows.Forms.TextBox()
        Me.txtNextProcess = New System.Windows.Forms.Label()
        Me.txtLastProcess = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDateTime = New System.Windows.Forms.TextBox()
        Me.lblDatetime = New System.Windows.Forms.Label()
        Me.lblSatus = New System.Windows.Forms.Label()
        Me.lblErrors = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstOutputFiles = New System.Windows.Forms.ListBox()
        Me.txtOutputFolder = New System.Windows.Forms.TextBox()
        Me.lblOutputFolder = New System.Windows.Forms.Label()
        Me.txtOutputServer = New System.Windows.Forms.TextBox()
        Me.lblOutputFTP = New System.Windows.Forms.Label()
        Me.pnlOutput = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblInputFiles = New System.Windows.Forms.Label()
        Me.lstInputFiles = New System.Windows.Forms.ListBox()
        Me.txtInputfolder = New System.Windows.Forms.TextBox()
        Me.lblInputFolder = New System.Windows.Forms.Label()
        Me.txtInputServer = New System.Windows.Forms.TextBox()
        Me.lblSever = New System.Windows.Forms.Label()
        Me.lblInputData = New System.Windows.Forms.Label()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.grpElements = New System.Windows.Forms.GroupBox()
        Me.pnlSites = New System.Windows.Forms.Panel()
        Me.grpSites = New System.Windows.Forms.GroupBox()
        Me.DataGridViewSites = New System.Windows.Forms.DataGridView()
        Me.chkPrefix = New System.Windows.Forms.CheckBox()
        Me.txtfilePrefix = New System.Windows.Forms.TextBox()
        Me.txtGTSHeader = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.chkGTSEncode = New System.Windows.Forms.CheckBox()
        Me.txtSiteName = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdViewUpdate = New System.Windows.Forms.Button()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.cmdUpdateSites = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.txtSitesNavigator = New System.Windows.Forms.TextBox()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.ComboBox()
        Me.txtDataStructure = New System.Windows.Forms.ComboBox()
        Me.txtFlag = New System.Windows.Forms.TextBox()
        Me.chkOperational = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtInFile = New System.Windows.Forms.TextBox()
        Me.lblInfile = New System.Windows.Forms.Label()
        Me.txtSiteID = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnlDataStructures = New System.Windows.Forms.Panel()
        Me.DataGridViewStructures = New System.Windows.Forms.DataGridView()
        Me.grpStructures1 = New System.Windows.Forms.GroupBox()
        Me.lblStructure = New System.Windows.Forms.Label()
        Me.grpStructures = New System.Windows.Forms.GroupBox()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.txtDelimiter = New System.Windows.Forms.ComboBox()
        Me.txtQualifier = New System.Windows.Forms.TextBox()
        Me.txtHeaders = New System.Windows.Forms.TextBox()
        Me.txtStrName = New System.Windows.Forms.TextBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdCreate = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblStrName = New System.Windows.Forms.Label()
        Me.cmbExistingStructures = New System.Windows.Forms.ComboBox()
        Me.pnlServers = New System.Windows.Forms.Panel()
        Me.pnlBaseStation = New System.Windows.Forms.Panel()
        Me.cmdBstAddNew = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.txtBasestationFTPMode = New System.Windows.Forms.ComboBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.cmdPrevRecord = New System.Windows.Forms.Button()
        Me.cmdFirstRecord = New System.Windows.Forms.Button()
        Me.cmdLastRecord = New System.Windows.Forms.Button()
        Me.cmdNextRecord = New System.Windows.Forms.Button()
        Me.txtbssNavigator = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblbaseStation = New System.Windows.Forms.Label()
        Me.cmdBstDelete = New System.Windows.Forms.Button()
        Me.cmdBsstUpdate = New System.Windows.Forms.Button()
        Me.cmdBstSave = New System.Windows.Forms.Button()
        Me.txtbaseStationPWConfirm = New System.Windows.Forms.TextBox()
        Me.txtbaseStationPW = New System.Windows.Forms.TextBox()
        Me.txtBaseStationUser = New System.Windows.Forms.TextBox()
        Me.txtBaseStationFolder = New System.Windows.Forms.TextBox()
        Me.txtBaseStationAddress = New System.Windows.Forms.TextBox()
        Me.lblConfirmInputPW = New System.Windows.Forms.Label()
        Me.lblInputPW = New System.Windows.Forms.Label()
        Me.lblInputUser = New System.Windows.Forms.Label()
        Me.lblFTPFolder = New System.Windows.Forms.Label()
        Me.lblBaseStationFTP = New System.Windows.Forms.Label()
        Me.pnlMSS = New System.Windows.Forms.Panel()
        Me.cmdmssRefresh = New System.Windows.Forms.Button()
        Me.cmdmssReset = New System.Windows.Forms.Button()
        Me.txtmssFTPMode = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdmssPrev = New System.Windows.Forms.Button()
        Me.cmdmssfirst = New System.Windows.Forms.Button()
        Me.cmdmssLast = New System.Windows.Forms.Button()
        Me.cmdmssNext = New System.Windows.Forms.Button()
        Me.txtmssNavigator = New System.Windows.Forms.TextBox()
        Me.lblFtpTransferMode = New System.Windows.Forms.Label()
        Me.lblMsgSwitch = New System.Windows.Forms.Label()
        Me.cmdMSSDelete = New System.Windows.Forms.Button()
        Me.cmdMSSUpdate = New System.Windows.Forms.Button()
        Me.cmdMSSAddNew = New System.Windows.Forms.Button()
        Me.txtMSSConfirm = New System.Windows.Forms.TextBox()
        Me.txtMSSPW = New System.Windows.Forms.TextBox()
        Me.txtmssUser = New System.Windows.Forms.TextBox()
        Me.txtMSSFolder = New System.Windows.Forms.TextBox()
        Me.txtMSSAddress = New System.Windows.Forms.TextBox()
        Me.lblmssConfirmPassword = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblServerSettings = New System.Windows.Forms.Label()
        Me.cmdMSS = New System.Windows.Forms.Button()
        Me.cmdBaseStation = New System.Windows.Forms.Button()
        Me.pnlMsgEncoding = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgrdCodeFlag = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkOptionalSection = New System.Windows.Forms.CheckBox()
        Me.LocaltableVersion = New System.Windows.Forms.TextBox()
        Me.MastertableVersion = New System.Windows.Forms.TextBox()
        Me.LocalSubcategory = New System.Windows.Forms.TextBox()
        Me.InternationalSubcategory = New System.Windows.Forms.TextBox()
        Me.txtDataCategory = New System.Windows.Forms.TextBox()
        Me.txtUpdateSequence = New System.Windows.Forms.TextBox()
        Me.txtOriginatingSubcentre = New System.Windows.Forms.TextBox()
        Me.txtOriginatingCentre = New System.Windows.Forms.TextBox()
        Me.txtBufrEdition = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtTemplate = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtMsgHeader = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlControl.SuspendLayout()
        Me.pnlProcessing.SuspendLayout()
        Me.pnlProcessSettings.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlSites.SuspendLayout()
        Me.grpSites.SuspendLayout()
        CType(Me.DataGridViewSites, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDataStructures.SuspendLayout()
        CType(Me.DataGridViewStructures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStructures1.SuspendLayout()
        Me.grpStructures.SuspendLayout()
        Me.pnlServers.SuspendLayout()
        Me.pnlBaseStation.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.pnlMSS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlMsgEncoding.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgrdCodeFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlControl
        '
        Me.pnlControl.BackColor = System.Drawing.Color.DarkSalmon
        Me.pnlControl.Controls.Add(Me.cmdHelp)
        Me.pnlControl.Controls.Add(Me.cmdMessages)
        Me.pnlControl.Controls.Add(Me.cmdDataStructures)
        Me.pnlControl.Controls.Add(Me.cmdSites)
        Me.pnlControl.Controls.Add(Me.cmdClose)
        Me.pnlControl.Controls.Add(Me.cmdServers)
        Me.pnlControl.Controls.Add(Me.cmdProcess)
        resources.ApplyResources(Me.pnlControl, "pnlControl")
        Me.pnlControl.Name = "pnlControl"
        '
        'cmdHelp
        '
        Me.cmdHelp.BackColor = System.Drawing.Color.LightSalmon
        resources.ApplyResources(Me.cmdHelp, "cmdHelp")
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.UseVisualStyleBackColor = False
        '
        'cmdMessages
        '
        Me.cmdMessages.BackColor = System.Drawing.Color.SeaShell
        resources.ApplyResources(Me.cmdMessages, "cmdMessages")
        Me.cmdMessages.Name = "cmdMessages"
        Me.cmdMessages.UseVisualStyleBackColor = False
        '
        'cmdDataStructures
        '
        Me.cmdDataStructures.BackColor = System.Drawing.Color.SeaShell
        resources.ApplyResources(Me.cmdDataStructures, "cmdDataStructures")
        Me.cmdDataStructures.Name = "cmdDataStructures"
        Me.cmdDataStructures.UseVisualStyleBackColor = False
        '
        'cmdSites
        '
        Me.cmdSites.BackColor = System.Drawing.Color.SeaShell
        resources.ApplyResources(Me.cmdSites, "cmdSites")
        Me.cmdSites.Name = "cmdSites"
        Me.cmdSites.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Coral
        resources.ApplyResources(Me.cmdClose, "cmdClose")
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdServers
        '
        Me.cmdServers.BackColor = System.Drawing.Color.SeaShell
        resources.ApplyResources(Me.cmdServers, "cmdServers")
        Me.cmdServers.Name = "cmdServers"
        Me.cmdServers.UseVisualStyleBackColor = False
        '
        'cmdProcess
        '
        Me.cmdProcess.BackColor = System.Drawing.Color.SeaShell
        resources.ApplyResources(Me.cmdProcess, "cmdProcess")
        Me.cmdProcess.Name = "cmdProcess"
        Me.cmdProcess.UseVisualStyleBackColor = False
        '
        'pnlProcessing
        '
        Me.pnlProcessing.BackColor = System.Drawing.Color.MistyRose
        Me.pnlProcessing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProcessing.Controls.Add(Me.pnlProcessSettings)
        Me.pnlProcessing.Controls.Add(Me.list_errors)
        Me.pnlProcessing.Controls.Add(Me.Ltime)
        Me.pnlProcessing.Controls.Add(Me.Panel4)
        Me.pnlProcessing.Controls.Add(Me.lblErrors)
        Me.pnlProcessing.Controls.Add(Me.Panel1)
        Me.pnlProcessing.Controls.Add(Me.grpElements)
        resources.ApplyResources(Me.pnlProcessing, "pnlProcessing")
        Me.pnlProcessing.Name = "pnlProcessing"
        '
        'pnlProcessSettings
        '
        Me.pnlProcessSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProcessSettings.Controls.Add(Me.optStart)
        Me.pnlProcessSettings.Controls.Add(Me.txtGMTDiff)
        Me.pnlProcessSettings.Controls.Add(Me.lblGMT)
        Me.pnlProcessSettings.Controls.Add(Me.Label9)
        Me.pnlProcessSettings.Controls.Add(Me.cmdSave)
        Me.pnlProcessSettings.Controls.Add(Me.chkDeleteFile)
        Me.pnlProcessSettings.Controls.Add(Me.txtTimeout)
        Me.pnlProcessSettings.Controls.Add(Me.Label10)
        Me.pnlProcessSettings.Controls.Add(Me.Label11)
        Me.pnlProcessSettings.Controls.Add(Me.txtPeriod)
        Me.pnlProcessSettings.Controls.Add(Me.Label12)
        Me.pnlProcessSettings.Controls.Add(Me.txtOffset)
        Me.pnlProcessSettings.Controls.Add(Me.Label13)
        Me.pnlProcessSettings.Controls.Add(Me.txtInterval)
        Me.pnlProcessSettings.Controls.Add(Me.Label14)
        Me.pnlProcessSettings.Controls.Add(Me.optStop)
        resources.ApplyResources(Me.pnlProcessSettings, "pnlProcessSettings")
        Me.pnlProcessSettings.Name = "pnlProcessSettings"
        '
        'optStart
        '
        resources.ApplyResources(Me.optStart, "optStart")
        Me.optStart.Name = "optStart"
        Me.optStart.UseVisualStyleBackColor = True
        '
        'txtGMTDiff
        '
        Me.txtGMTDiff.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtGMTDiff, "txtGMTDiff")
        Me.txtGMTDiff.Name = "txtGMTDiff"
        '
        'lblGMT
        '
        resources.ApplyResources(Me.lblGMT, "lblGMT")
        Me.lblGMT.Name = "lblGMT"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'cmdSave
        '
        resources.ApplyResources(Me.cmdSave, "cmdSave")
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'chkDeleteFile
        '
        resources.ApplyResources(Me.chkDeleteFile, "chkDeleteFile")
        Me.chkDeleteFile.Name = "chkDeleteFile"
        Me.chkDeleteFile.UseVisualStyleBackColor = True
        '
        'txtTimeout
        '
        resources.ApplyResources(Me.txtTimeout, "txtTimeout")
        Me.txtTimeout.Name = "txtTimeout"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'txtPeriod
        '
        resources.ApplyResources(Me.txtPeriod, "txtPeriod")
        Me.txtPeriod.Name = "txtPeriod"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'txtOffset
        '
        resources.ApplyResources(Me.txtOffset, "txtOffset")
        Me.txtOffset.Name = "txtOffset"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'txtInterval
        '
        resources.ApplyResources(Me.txtInterval, "txtInterval")
        Me.txtInterval.Name = "txtInterval"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'optStop
        '
        resources.ApplyResources(Me.optStop, "optStop")
        Me.optStop.Checked = True
        Me.optStop.Name = "optStop"
        Me.optStop.TabStop = True
        Me.optStop.UseVisualStyleBackColor = True
        '
        'list_errors
        '
        Me.list_errors.FormattingEnabled = True
        resources.ApplyResources(Me.list_errors, "list_errors")
        Me.list_errors.Name = "list_errors"
        '
        'Ltime
        '
        resources.ApplyResources(Me.Ltime, "Ltime")
        Me.Ltime.BackColor = System.Drawing.Color.SeaShell
        Me.Ltime.Name = "Ltime"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtQC)
        Me.Panel4.Controls.Add(Me.txtNxtProcess)
        Me.Panel4.Controls.Add(Me.txtNextProcess)
        Me.Panel4.Controls.Add(Me.txtLastProcess)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.ProgressBar1)
        Me.Panel4.Controls.Add(Me.txtStatus)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtDateTime)
        Me.Panel4.Controls.Add(Me.lblDatetime)
        Me.Panel4.Controls.Add(Me.lblSatus)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'txtQC
        '
        Me.txtQC.BackColor = System.Drawing.Color.MistyRose
        Me.txtQC.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtQC, "txtQC")
        Me.txtQC.Name = "txtQC"
        '
        'txtNxtProcess
        '
        Me.txtNxtProcess.BackColor = System.Drawing.Color.MistyRose
        resources.ApplyResources(Me.txtNxtProcess, "txtNxtProcess")
        Me.txtNxtProcess.Name = "txtNxtProcess"
        '
        'txtNextProcess
        '
        resources.ApplyResources(Me.txtNextProcess, "txtNextProcess")
        Me.txtNextProcess.Name = "txtNextProcess"
        '
        'txtLastProcess
        '
        Me.txtLastProcess.BackColor = System.Drawing.Color.MistyRose
        resources.ApplyResources(Me.txtLastProcess, "txtLastProcess")
        Me.txtLastProcess.Name = "txtLastProcess"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.SeaShell
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.MistyRose
        resources.ApplyResources(Me.txtStatus, "txtStatus")
        Me.txtStatus.Name = "txtStatus"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtDateTime
        '
        Me.txtDateTime.BackColor = System.Drawing.Color.MistyRose
        resources.ApplyResources(Me.txtDateTime, "txtDateTime")
        Me.txtDateTime.Name = "txtDateTime"
        '
        'lblDatetime
        '
        resources.ApplyResources(Me.lblDatetime, "lblDatetime")
        Me.lblDatetime.Name = "lblDatetime"
        '
        'lblSatus
        '
        resources.ApplyResources(Me.lblSatus, "lblSatus")
        Me.lblSatus.Name = "lblSatus"
        '
        'lblErrors
        '
        resources.ApplyResources(Me.lblErrors, "lblErrors")
        Me.lblErrors.Name = "lblErrors"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblInformation)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lstOutputFiles)
        Me.Panel3.Controls.Add(Me.txtOutputFolder)
        Me.Panel3.Controls.Add(Me.lblOutputFolder)
        Me.Panel3.Controls.Add(Me.txtOutputServer)
        Me.Panel3.Controls.Add(Me.lblOutputFTP)
        Me.Panel3.Controls.Add(Me.pnlOutput)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'lstOutputFiles
        '
        Me.lstOutputFiles.BackColor = System.Drawing.Color.SeaShell
        Me.lstOutputFiles.FormattingEnabled = True
        resources.ApplyResources(Me.lstOutputFiles, "lstOutputFiles")
        Me.lstOutputFiles.MultiColumn = True
        Me.lstOutputFiles.Name = "lstOutputFiles"
        '
        'txtOutputFolder
        '
        Me.txtOutputFolder.BackColor = System.Drawing.Color.MistyRose
        resources.ApplyResources(Me.txtOutputFolder, "txtOutputFolder")
        Me.txtOutputFolder.Name = "txtOutputFolder"
        '
        'lblOutputFolder
        '
        resources.ApplyResources(Me.lblOutputFolder, "lblOutputFolder")
        Me.lblOutputFolder.Name = "lblOutputFolder"
        '
        'txtOutputServer
        '
        Me.txtOutputServer.BackColor = System.Drawing.Color.MistyRose
        resources.ApplyResources(Me.txtOutputServer, "txtOutputServer")
        Me.txtOutputServer.Name = "txtOutputServer"
        '
        'lblOutputFTP
        '
        resources.ApplyResources(Me.lblOutputFTP, "lblOutputFTP")
        Me.lblOutputFTP.Name = "lblOutputFTP"
        '
        'pnlOutput
        '
        resources.ApplyResources(Me.pnlOutput, "pnlOutput")
        Me.pnlOutput.Name = "pnlOutput"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblInputFiles)
        Me.Panel2.Controls.Add(Me.lstInputFiles)
        Me.Panel2.Controls.Add(Me.txtInputfolder)
        Me.Panel2.Controls.Add(Me.lblInputFolder)
        Me.Panel2.Controls.Add(Me.txtInputServer)
        Me.Panel2.Controls.Add(Me.lblSever)
        Me.Panel2.Controls.Add(Me.lblInputData)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'lblInputFiles
        '
        resources.ApplyResources(Me.lblInputFiles, "lblInputFiles")
        Me.lblInputFiles.Name = "lblInputFiles"
        '
        'lstInputFiles
        '
        Me.lstInputFiles.BackColor = System.Drawing.Color.SeaShell
        Me.lstInputFiles.FormattingEnabled = True
        resources.ApplyResources(Me.lstInputFiles, "lstInputFiles")
        Me.lstInputFiles.MultiColumn = True
        Me.lstInputFiles.Name = "lstInputFiles"
        '
        'txtInputfolder
        '
        Me.txtInputfolder.BackColor = System.Drawing.Color.MistyRose
        resources.ApplyResources(Me.txtInputfolder, "txtInputfolder")
        Me.txtInputfolder.Name = "txtInputfolder"
        '
        'lblInputFolder
        '
        resources.ApplyResources(Me.lblInputFolder, "lblInputFolder")
        Me.lblInputFolder.Name = "lblInputFolder"
        '
        'txtInputServer
        '
        Me.txtInputServer.BackColor = System.Drawing.Color.MistyRose
        resources.ApplyResources(Me.txtInputServer, "txtInputServer")
        Me.txtInputServer.Name = "txtInputServer"
        '
        'lblSever
        '
        resources.ApplyResources(Me.lblSever, "lblSever")
        Me.lblSever.Name = "lblSever"
        '
        'lblInputData
        '
        resources.ApplyResources(Me.lblInputData, "lblInputData")
        Me.lblInputData.Name = "lblInputData"
        '
        'lblInformation
        '
        resources.ApplyResources(Me.lblInformation, "lblInformation")
        Me.lblInformation.Name = "lblInformation"
        '
        'grpElements
        '
        resources.ApplyResources(Me.grpElements, "grpElements")
        Me.grpElements.Name = "grpElements"
        Me.grpElements.TabStop = False
        '
        'pnlSites
        '
        Me.pnlSites.AllowDrop = True
        resources.ApplyResources(Me.pnlSites, "pnlSites")
        Me.pnlSites.BackColor = System.Drawing.Color.Linen
        Me.pnlSites.Controls.Add(Me.grpSites)
        Me.pnlSites.Name = "pnlSites"
        '
        'grpSites
        '
        Me.grpSites.Controls.Add(Me.DataGridViewSites)
        Me.grpSites.Controls.Add(Me.chkPrefix)
        Me.grpSites.Controls.Add(Me.txtfilePrefix)
        Me.grpSites.Controls.Add(Me.txtGTSHeader)
        Me.grpSites.Controls.Add(Me.Label42)
        Me.grpSites.Controls.Add(Me.chkGTSEncode)
        Me.grpSites.Controls.Add(Me.txtSiteName)
        Me.grpSites.Controls.Add(Me.Label41)
        Me.grpSites.Controls.Add(Me.cmdClear)
        Me.grpSites.Controls.Add(Me.cmdViewUpdate)
        Me.grpSites.Controls.Add(Me.cmdDel)
        Me.grpSites.Controls.Add(Me.cmdUpdateSites)
        Me.grpSites.Controls.Add(Me.cmdAdd)
        Me.grpSites.Controls.Add(Me.btnMovePrevious)
        Me.grpSites.Controls.Add(Me.btnMoveFirst)
        Me.grpSites.Controls.Add(Me.btnMoveLast)
        Me.grpSites.Controls.Add(Me.txtSitesNavigator)
        Me.grpSites.Controls.Add(Me.btnMoveNext)
        Me.grpSites.Controls.Add(Me.Label4)
        Me.grpSites.Controls.Add(Me.txtIP)
        Me.grpSites.Controls.Add(Me.txtDataStructure)
        Me.grpSites.Controls.Add(Me.txtFlag)
        Me.grpSites.Controls.Add(Me.chkOperational)
        Me.grpSites.Controls.Add(Me.Label18)
        Me.grpSites.Controls.Add(Me.Label17)
        Me.grpSites.Controls.Add(Me.Label16)
        Me.grpSites.Controls.Add(Me.txtInFile)
        Me.grpSites.Controls.Add(Me.lblInfile)
        Me.grpSites.Controls.Add(Me.txtSiteID)
        Me.grpSites.Controls.Add(Me.Label15)
        resources.ApplyResources(Me.grpSites, "grpSites")
        Me.grpSites.Name = "grpSites"
        Me.grpSites.TabStop = False
        '
        'DataGridViewSites
        '
        Me.DataGridViewSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataGridViewSites, "DataGridViewSites")
        Me.DataGridViewSites.Name = "DataGridViewSites"
        '
        'chkPrefix
        '
        resources.ApplyResources(Me.chkPrefix, "chkPrefix")
        Me.chkPrefix.Name = "chkPrefix"
        Me.chkPrefix.UseVisualStyleBackColor = True
        '
        'txtfilePrefix
        '
        resources.ApplyResources(Me.txtfilePrefix, "txtfilePrefix")
        Me.txtfilePrefix.Name = "txtfilePrefix"
        '
        'txtGTSHeader
        '
        resources.ApplyResources(Me.txtGTSHeader, "txtGTSHeader")
        Me.txtGTSHeader.Name = "txtGTSHeader"
        '
        'Label42
        '
        resources.ApplyResources(Me.Label42, "Label42")
        Me.Label42.Name = "Label42"
        '
        'chkGTSEncode
        '
        resources.ApplyResources(Me.chkGTSEncode, "chkGTSEncode")
        Me.chkGTSEncode.Name = "chkGTSEncode"
        Me.chkGTSEncode.UseVisualStyleBackColor = True
        '
        'txtSiteName
        '
        Me.txtSiteName.FormattingEnabled = True
        resources.ApplyResources(Me.txtSiteName, "txtSiteName")
        Me.txtSiteName.Name = "txtSiteName"
        '
        'Label41
        '
        resources.ApplyResources(Me.Label41, "Label41")
        Me.Label41.Name = "Label41"
        '
        'cmdClear
        '
        resources.ApplyResources(Me.cmdClear, "cmdClear")
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdViewUpdate
        '
        resources.ApplyResources(Me.cmdViewUpdate, "cmdViewUpdate")
        Me.cmdViewUpdate.Name = "cmdViewUpdate"
        Me.cmdViewUpdate.UseVisualStyleBackColor = True
        '
        'cmdDel
        '
        resources.ApplyResources(Me.cmdDel, "cmdDel")
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.UseVisualStyleBackColor = True
        '
        'cmdUpdateSites
        '
        resources.ApplyResources(Me.cmdUpdateSites, "cmdUpdateSites")
        Me.cmdUpdateSites.Name = "cmdUpdateSites"
        Me.cmdUpdateSites.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        resources.ApplyResources(Me.cmdAdd, "cmdAdd")
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'btnMovePrevious
        '
        resources.ApplyResources(Me.btnMovePrevious, "btnMovePrevious")
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        resources.ApplyResources(Me.btnMoveFirst, "btnMoveFirst")
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'btnMoveLast
        '
        resources.ApplyResources(Me.btnMoveLast, "btnMoveLast")
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'txtSitesNavigator
        '
        resources.ApplyResources(Me.txtSitesNavigator, "txtSitesNavigator")
        Me.txtSitesNavigator.Name = "txtSitesNavigator"
        '
        'btnMoveNext
        '
        resources.ApplyResources(Me.btnMoveNext, "btnMoveNext")
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtIP
        '
        Me.txtIP.FormattingEnabled = True
        resources.ApplyResources(Me.txtIP, "txtIP")
        Me.txtIP.Name = "txtIP"
        '
        'txtDataStructure
        '
        Me.txtDataStructure.FormattingEnabled = True
        resources.ApplyResources(Me.txtDataStructure, "txtDataStructure")
        Me.txtDataStructure.Name = "txtDataStructure"
        '
        'txtFlag
        '
        resources.ApplyResources(Me.txtFlag, "txtFlag")
        Me.txtFlag.Name = "txtFlag"
        '
        'chkOperational
        '
        resources.ApplyResources(Me.chkOperational, "chkOperational")
        Me.chkOperational.Name = "chkOperational"
        Me.chkOperational.UseVisualStyleBackColor = True
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'txtInFile
        '
        resources.ApplyResources(Me.txtInFile, "txtInFile")
        Me.txtInFile.Name = "txtInFile"
        '
        'lblInfile
        '
        resources.ApplyResources(Me.lblInfile, "lblInfile")
        Me.lblInfile.Name = "lblInfile"
        '
        'txtSiteID
        '
        Me.txtSiteID.FormattingEnabled = True
        resources.ApplyResources(Me.txtSiteID, "txtSiteID")
        Me.txtSiteID.Name = "txtSiteID"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'pnlDataStructures
        '
        Me.pnlDataStructures.BackColor = System.Drawing.Color.BurlyWood
        Me.pnlDataStructures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDataStructures.Controls.Add(Me.DataGridViewStructures)
        Me.pnlDataStructures.Controls.Add(Me.grpStructures1)
        resources.ApplyResources(Me.pnlDataStructures, "pnlDataStructures")
        Me.pnlDataStructures.Name = "pnlDataStructures"
        '
        'DataGridViewStructures
        '
        Me.DataGridViewStructures.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewStructures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataGridViewStructures, "DataGridViewStructures")
        Me.DataGridViewStructures.Name = "DataGridViewStructures"
        '
        'grpStructures1
        '
        Me.grpStructures1.Controls.Add(Me.lblStructure)
        Me.grpStructures1.Controls.Add(Me.grpStructures)
        Me.grpStructures1.Controls.Add(Me.cmbExistingStructures)
        resources.ApplyResources(Me.grpStructures1, "grpStructures1")
        Me.grpStructures1.Name = "grpStructures1"
        Me.grpStructures1.TabStop = False
        '
        'lblStructure
        '
        resources.ApplyResources(Me.lblStructure, "lblStructure")
        Me.lblStructure.Name = "lblStructure"
        '
        'grpStructures
        '
        Me.grpStructures.Controls.Add(Me.lblRecords)
        Me.grpStructures.Controls.Add(Me.txtDelimiter)
        Me.grpStructures.Controls.Add(Me.txtQualifier)
        Me.grpStructures.Controls.Add(Me.txtHeaders)
        Me.grpStructures.Controls.Add(Me.txtStrName)
        Me.grpStructures.Controls.Add(Me.cmdDelete)
        Me.grpStructures.Controls.Add(Me.cmdUpdate)
        Me.grpStructures.Controls.Add(Me.cmdCreate)
        Me.grpStructures.Controls.Add(Me.Label21)
        Me.grpStructures.Controls.Add(Me.Label20)
        Me.grpStructures.Controls.Add(Me.Label19)
        Me.grpStructures.Controls.Add(Me.lblStrName)
        Me.grpStructures.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        resources.ApplyResources(Me.grpStructures, "grpStructures")
        Me.grpStructures.Name = "grpStructures"
        Me.grpStructures.TabStop = False
        '
        'lblRecords
        '
        resources.ApplyResources(Me.lblRecords, "lblRecords")
        Me.lblRecords.Name = "lblRecords"
        '
        'txtDelimiter
        '
        Me.txtDelimiter.FormattingEnabled = True
        Me.txtDelimiter.Items.AddRange(New Object() {resources.GetString("txtDelimiter.Items"), resources.GetString("txtDelimiter.Items1"), resources.GetString("txtDelimiter.Items2")})
        resources.ApplyResources(Me.txtDelimiter, "txtDelimiter")
        Me.txtDelimiter.Name = "txtDelimiter"
        '
        'txtQualifier
        '
        resources.ApplyResources(Me.txtQualifier, "txtQualifier")
        Me.txtQualifier.Name = "txtQualifier"
        '
        'txtHeaders
        '
        resources.ApplyResources(Me.txtHeaders, "txtHeaders")
        Me.txtHeaders.Name = "txtHeaders"
        '
        'txtStrName
        '
        resources.ApplyResources(Me.txtStrName, "txtStrName")
        Me.txtStrName.Name = "txtStrName"
        '
        'cmdDelete
        '
        resources.ApplyResources(Me.cmdDelete, "cmdDelete")
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        resources.ApplyResources(Me.cmdUpdate, "cmdUpdate")
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdCreate
        '
        resources.ApplyResources(Me.cmdCreate, "cmdCreate")
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.Name = "Label21"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'lblStrName
        '
        resources.ApplyResources(Me.lblStrName, "lblStrName")
        Me.lblStrName.Name = "lblStrName"
        '
        'cmbExistingStructures
        '
        Me.cmbExistingStructures.FormattingEnabled = True
        resources.ApplyResources(Me.cmbExistingStructures, "cmbExistingStructures")
        Me.cmbExistingStructures.Name = "cmbExistingStructures"
        '
        'pnlServers
        '
        Me.pnlServers.BackColor = System.Drawing.Color.PeachPuff
        Me.pnlServers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlServers.Controls.Add(Me.pnlBaseStation)
        Me.pnlServers.Controls.Add(Me.pnlMSS)
        Me.pnlServers.Controls.Add(Me.lblServerSettings)
        Me.pnlServers.Controls.Add(Me.cmdMSS)
        Me.pnlServers.Controls.Add(Me.cmdBaseStation)
        resources.ApplyResources(Me.pnlServers, "pnlServers")
        Me.pnlServers.Name = "pnlServers"
        '
        'pnlBaseStation
        '
        Me.pnlBaseStation.BackColor = System.Drawing.Color.PapayaWhip
        Me.pnlBaseStation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBaseStation.Controls.Add(Me.cmdBstAddNew)
        Me.pnlBaseStation.Controls.Add(Me.cmdRefresh)
        Me.pnlBaseStation.Controls.Add(Me.cmdReset)
        Me.pnlBaseStation.Controls.Add(Me.txtBasestationFTPMode)
        Me.pnlBaseStation.Controls.Add(Me.GroupBox10)
        Me.pnlBaseStation.Controls.Add(Me.Label40)
        Me.pnlBaseStation.Controls.Add(Me.lblbaseStation)
        Me.pnlBaseStation.Controls.Add(Me.cmdBstDelete)
        Me.pnlBaseStation.Controls.Add(Me.cmdBsstUpdate)
        Me.pnlBaseStation.Controls.Add(Me.cmdBstSave)
        Me.pnlBaseStation.Controls.Add(Me.txtbaseStationPWConfirm)
        Me.pnlBaseStation.Controls.Add(Me.txtbaseStationPW)
        Me.pnlBaseStation.Controls.Add(Me.txtBaseStationUser)
        Me.pnlBaseStation.Controls.Add(Me.txtBaseStationFolder)
        Me.pnlBaseStation.Controls.Add(Me.txtBaseStationAddress)
        Me.pnlBaseStation.Controls.Add(Me.lblConfirmInputPW)
        Me.pnlBaseStation.Controls.Add(Me.lblInputPW)
        Me.pnlBaseStation.Controls.Add(Me.lblInputUser)
        Me.pnlBaseStation.Controls.Add(Me.lblFTPFolder)
        Me.pnlBaseStation.Controls.Add(Me.lblBaseStationFTP)
        resources.ApplyResources(Me.pnlBaseStation, "pnlBaseStation")
        Me.pnlBaseStation.Name = "pnlBaseStation"
        '
        'cmdBstAddNew
        '
        resources.ApplyResources(Me.cmdBstAddNew, "cmdBstAddNew")
        Me.cmdBstAddNew.Name = "cmdBstAddNew"
        Me.cmdBstAddNew.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        resources.ApplyResources(Me.cmdRefresh, "cmdRefresh")
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        resources.ApplyResources(Me.cmdReset, "cmdReset")
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'txtBasestationFTPMode
        '
        Me.txtBasestationFTPMode.FormattingEnabled = True
        Me.txtBasestationFTPMode.Items.AddRange(New Object() {resources.GetString("txtBasestationFTPMode.Items"), resources.GetString("txtBasestationFTPMode.Items1")})
        resources.ApplyResources(Me.txtBasestationFTPMode, "txtBasestationFTPMode")
        Me.txtBasestationFTPMode.Name = "txtBasestationFTPMode"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.cmdPrevRecord)
        Me.GroupBox10.Controls.Add(Me.cmdFirstRecord)
        Me.GroupBox10.Controls.Add(Me.cmdLastRecord)
        Me.GroupBox10.Controls.Add(Me.cmdNextRecord)
        Me.GroupBox10.Controls.Add(Me.txtbssNavigator)
        resources.ApplyResources(Me.GroupBox10, "GroupBox10")
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.TabStop = False
        '
        'cmdPrevRecord
        '
        resources.ApplyResources(Me.cmdPrevRecord, "cmdPrevRecord")
        Me.cmdPrevRecord.Name = "cmdPrevRecord"
        Me.cmdPrevRecord.UseVisualStyleBackColor = True
        '
        'cmdFirstRecord
        '
        resources.ApplyResources(Me.cmdFirstRecord, "cmdFirstRecord")
        Me.cmdFirstRecord.Name = "cmdFirstRecord"
        Me.cmdFirstRecord.UseVisualStyleBackColor = True
        '
        'cmdLastRecord
        '
        resources.ApplyResources(Me.cmdLastRecord, "cmdLastRecord")
        Me.cmdLastRecord.Name = "cmdLastRecord"
        Me.cmdLastRecord.UseVisualStyleBackColor = True
        '
        'cmdNextRecord
        '
        resources.ApplyResources(Me.cmdNextRecord, "cmdNextRecord")
        Me.cmdNextRecord.Name = "cmdNextRecord"
        Me.cmdNextRecord.UseVisualStyleBackColor = True
        '
        'txtbssNavigator
        '
        resources.ApplyResources(Me.txtbssNavigator, "txtbssNavigator")
        Me.txtbssNavigator.Name = "txtbssNavigator"
        '
        'Label40
        '
        resources.ApplyResources(Me.Label40, "Label40")
        Me.Label40.Name = "Label40"
        '
        'lblbaseStation
        '
        resources.ApplyResources(Me.lblbaseStation, "lblbaseStation")
        Me.lblbaseStation.Name = "lblbaseStation"
        '
        'cmdBstDelete
        '
        resources.ApplyResources(Me.cmdBstDelete, "cmdBstDelete")
        Me.cmdBstDelete.Name = "cmdBstDelete"
        Me.cmdBstDelete.UseVisualStyleBackColor = True
        '
        'cmdBsstUpdate
        '
        resources.ApplyResources(Me.cmdBsstUpdate, "cmdBsstUpdate")
        Me.cmdBsstUpdate.Name = "cmdBsstUpdate"
        Me.cmdBsstUpdate.UseVisualStyleBackColor = True
        '
        'cmdBstSave
        '
        resources.ApplyResources(Me.cmdBstSave, "cmdBstSave")
        Me.cmdBstSave.Name = "cmdBstSave"
        Me.cmdBstSave.UseVisualStyleBackColor = True
        '
        'txtbaseStationPWConfirm
        '
        resources.ApplyResources(Me.txtbaseStationPWConfirm, "txtbaseStationPWConfirm")
        Me.txtbaseStationPWConfirm.Name = "txtbaseStationPWConfirm"
        '
        'txtbaseStationPW
        '
        resources.ApplyResources(Me.txtbaseStationPW, "txtbaseStationPW")
        Me.txtbaseStationPW.Name = "txtbaseStationPW"
        '
        'txtBaseStationUser
        '
        resources.ApplyResources(Me.txtBaseStationUser, "txtBaseStationUser")
        Me.txtBaseStationUser.Name = "txtBaseStationUser"
        '
        'txtBaseStationFolder
        '
        resources.ApplyResources(Me.txtBaseStationFolder, "txtBaseStationFolder")
        Me.txtBaseStationFolder.Name = "txtBaseStationFolder"
        '
        'txtBaseStationAddress
        '
        resources.ApplyResources(Me.txtBaseStationAddress, "txtBaseStationAddress")
        Me.txtBaseStationAddress.Name = "txtBaseStationAddress"
        '
        'lblConfirmInputPW
        '
        resources.ApplyResources(Me.lblConfirmInputPW, "lblConfirmInputPW")
        Me.lblConfirmInputPW.Name = "lblConfirmInputPW"
        '
        'lblInputPW
        '
        resources.ApplyResources(Me.lblInputPW, "lblInputPW")
        Me.lblInputPW.Name = "lblInputPW"
        '
        'lblInputUser
        '
        resources.ApplyResources(Me.lblInputUser, "lblInputUser")
        Me.lblInputUser.Name = "lblInputUser"
        '
        'lblFTPFolder
        '
        resources.ApplyResources(Me.lblFTPFolder, "lblFTPFolder")
        Me.lblFTPFolder.Name = "lblFTPFolder"
        '
        'lblBaseStationFTP
        '
        resources.ApplyResources(Me.lblBaseStationFTP, "lblBaseStationFTP")
        Me.lblBaseStationFTP.Name = "lblBaseStationFTP"
        '
        'pnlMSS
        '
        Me.pnlMSS.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.pnlMSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMSS.Controls.Add(Me.cmdmssRefresh)
        Me.pnlMSS.Controls.Add(Me.cmdmssReset)
        Me.pnlMSS.Controls.Add(Me.txtmssFTPMode)
        Me.pnlMSS.Controls.Add(Me.GroupBox1)
        Me.pnlMSS.Controls.Add(Me.lblFtpTransferMode)
        Me.pnlMSS.Controls.Add(Me.lblMsgSwitch)
        Me.pnlMSS.Controls.Add(Me.cmdMSSDelete)
        Me.pnlMSS.Controls.Add(Me.cmdMSSUpdate)
        Me.pnlMSS.Controls.Add(Me.cmdMSSAddNew)
        Me.pnlMSS.Controls.Add(Me.txtMSSConfirm)
        Me.pnlMSS.Controls.Add(Me.txtMSSPW)
        Me.pnlMSS.Controls.Add(Me.txtmssUser)
        Me.pnlMSS.Controls.Add(Me.txtMSSFolder)
        Me.pnlMSS.Controls.Add(Me.txtMSSAddress)
        Me.pnlMSS.Controls.Add(Me.lblmssConfirmPassword)
        Me.pnlMSS.Controls.Add(Me.Label5)
        Me.pnlMSS.Controls.Add(Me.Label6)
        Me.pnlMSS.Controls.Add(Me.Label7)
        Me.pnlMSS.Controls.Add(Me.Label8)
        resources.ApplyResources(Me.pnlMSS, "pnlMSS")
        Me.pnlMSS.Name = "pnlMSS"
        '
        'cmdmssRefresh
        '
        resources.ApplyResources(Me.cmdmssRefresh, "cmdmssRefresh")
        Me.cmdmssRefresh.Name = "cmdmssRefresh"
        Me.cmdmssRefresh.UseVisualStyleBackColor = True
        '
        'cmdmssReset
        '
        resources.ApplyResources(Me.cmdmssReset, "cmdmssReset")
        Me.cmdmssReset.Name = "cmdmssReset"
        Me.cmdmssReset.UseVisualStyleBackColor = True
        '
        'txtmssFTPMode
        '
        Me.txtmssFTPMode.FormattingEnabled = True
        Me.txtmssFTPMode.Items.AddRange(New Object() {resources.GetString("txtmssFTPMode.Items"), resources.GetString("txtmssFTPMode.Items1")})
        resources.ApplyResources(Me.txtmssFTPMode, "txtmssFTPMode")
        Me.txtmssFTPMode.Name = "txtmssFTPMode"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdmssPrev)
        Me.GroupBox1.Controls.Add(Me.cmdmssfirst)
        Me.GroupBox1.Controls.Add(Me.cmdmssLast)
        Me.GroupBox1.Controls.Add(Me.cmdmssNext)
        Me.GroupBox1.Controls.Add(Me.txtmssNavigator)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'cmdmssPrev
        '
        resources.ApplyResources(Me.cmdmssPrev, "cmdmssPrev")
        Me.cmdmssPrev.Name = "cmdmssPrev"
        Me.cmdmssPrev.UseVisualStyleBackColor = True
        '
        'cmdmssfirst
        '
        resources.ApplyResources(Me.cmdmssfirst, "cmdmssfirst")
        Me.cmdmssfirst.Name = "cmdmssfirst"
        Me.cmdmssfirst.UseVisualStyleBackColor = True
        '
        'cmdmssLast
        '
        resources.ApplyResources(Me.cmdmssLast, "cmdmssLast")
        Me.cmdmssLast.Name = "cmdmssLast"
        Me.cmdmssLast.UseVisualStyleBackColor = True
        '
        'cmdmssNext
        '
        resources.ApplyResources(Me.cmdmssNext, "cmdmssNext")
        Me.cmdmssNext.Name = "cmdmssNext"
        Me.cmdmssNext.UseVisualStyleBackColor = True
        '
        'txtmssNavigator
        '
        resources.ApplyResources(Me.txtmssNavigator, "txtmssNavigator")
        Me.txtmssNavigator.Name = "txtmssNavigator"
        '
        'lblFtpTransferMode
        '
        resources.ApplyResources(Me.lblFtpTransferMode, "lblFtpTransferMode")
        Me.lblFtpTransferMode.Name = "lblFtpTransferMode"
        '
        'lblMsgSwitch
        '
        resources.ApplyResources(Me.lblMsgSwitch, "lblMsgSwitch")
        Me.lblMsgSwitch.Name = "lblMsgSwitch"
        '
        'cmdMSSDelete
        '
        resources.ApplyResources(Me.cmdMSSDelete, "cmdMSSDelete")
        Me.cmdMSSDelete.Name = "cmdMSSDelete"
        Me.cmdMSSDelete.UseVisualStyleBackColor = True
        '
        'cmdMSSUpdate
        '
        resources.ApplyResources(Me.cmdMSSUpdate, "cmdMSSUpdate")
        Me.cmdMSSUpdate.Name = "cmdMSSUpdate"
        Me.cmdMSSUpdate.UseVisualStyleBackColor = True
        '
        'cmdMSSAddNew
        '
        resources.ApplyResources(Me.cmdMSSAddNew, "cmdMSSAddNew")
        Me.cmdMSSAddNew.Name = "cmdMSSAddNew"
        Me.cmdMSSAddNew.UseVisualStyleBackColor = True
        '
        'txtMSSConfirm
        '
        resources.ApplyResources(Me.txtMSSConfirm, "txtMSSConfirm")
        Me.txtMSSConfirm.Name = "txtMSSConfirm"
        '
        'txtMSSPW
        '
        resources.ApplyResources(Me.txtMSSPW, "txtMSSPW")
        Me.txtMSSPW.Name = "txtMSSPW"
        '
        'txtmssUser
        '
        resources.ApplyResources(Me.txtmssUser, "txtmssUser")
        Me.txtmssUser.Name = "txtmssUser"
        '
        'txtMSSFolder
        '
        resources.ApplyResources(Me.txtMSSFolder, "txtMSSFolder")
        Me.txtMSSFolder.Name = "txtMSSFolder"
        '
        'txtMSSAddress
        '
        resources.ApplyResources(Me.txtMSSAddress, "txtMSSAddress")
        Me.txtMSSAddress.Name = "txtMSSAddress"
        '
        'lblmssConfirmPassword
        '
        resources.ApplyResources(Me.lblmssConfirmPassword, "lblmssConfirmPassword")
        Me.lblmssConfirmPassword.Name = "lblmssConfirmPassword"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'lblServerSettings
        '
        resources.ApplyResources(Me.lblServerSettings, "lblServerSettings")
        Me.lblServerSettings.Name = "lblServerSettings"
        '
        'cmdMSS
        '
        resources.ApplyResources(Me.cmdMSS, "cmdMSS")
        Me.cmdMSS.Name = "cmdMSS"
        Me.cmdMSS.UseVisualStyleBackColor = True
        '
        'cmdBaseStation
        '
        resources.ApplyResources(Me.cmdBaseStation, "cmdBaseStation")
        Me.cmdBaseStation.Name = "cmdBaseStation"
        Me.cmdBaseStation.UseVisualStyleBackColor = True
        '
        'pnlMsgEncoding
        '
        Me.pnlMsgEncoding.BackColor = System.Drawing.Color.Linen
        Me.pnlMsgEncoding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMsgEncoding.Controls.Add(Me.GroupBox6)
        Me.pnlMsgEncoding.Controls.Add(Me.GroupBox7)
        Me.pnlMsgEncoding.Controls.Add(Me.GroupBox5)
        resources.ApplyResources(Me.pnlMsgEncoding, "pnlMsgEncoding")
        Me.pnlMsgEncoding.Name = "pnlMsgEncoding"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgrdCodeFlag)
        resources.ApplyResources(Me.GroupBox6, "GroupBox6")
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.TabStop = False
        '
        'dgrdCodeFlag
        '
        Me.dgrdCodeFlag.BackgroundColor = System.Drawing.Color.Ivory
        Me.dgrdCodeFlag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.dgrdCodeFlag, "dgrdCodeFlag")
        Me.dgrdCodeFlag.Name = "dgrdCodeFlag"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkOptionalSection)
        Me.GroupBox7.Controls.Add(Me.LocaltableVersion)
        Me.GroupBox7.Controls.Add(Me.MastertableVersion)
        Me.GroupBox7.Controls.Add(Me.LocalSubcategory)
        Me.GroupBox7.Controls.Add(Me.InternationalSubcategory)
        Me.GroupBox7.Controls.Add(Me.txtDataCategory)
        Me.GroupBox7.Controls.Add(Me.txtUpdateSequence)
        Me.GroupBox7.Controls.Add(Me.txtOriginatingSubcentre)
        Me.GroupBox7.Controls.Add(Me.txtOriginatingCentre)
        Me.GroupBox7.Controls.Add(Me.txtBufrEdition)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.Label33)
        Me.GroupBox7.Controls.Add(Me.Label34)
        resources.ApplyResources(Me.GroupBox7, "GroupBox7")
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.TabStop = False
        '
        'chkOptionalSection
        '
        resources.ApplyResources(Me.chkOptionalSection, "chkOptionalSection")
        Me.chkOptionalSection.Name = "chkOptionalSection"
        Me.chkOptionalSection.Tag = "  "
        Me.chkOptionalSection.UseVisualStyleBackColor = True
        '
        'LocaltableVersion
        '
        resources.ApplyResources(Me.LocaltableVersion, "LocaltableVersion")
        Me.LocaltableVersion.Name = "LocaltableVersion"
        '
        'MastertableVersion
        '
        resources.ApplyResources(Me.MastertableVersion, "MastertableVersion")
        Me.MastertableVersion.Name = "MastertableVersion"
        '
        'LocalSubcategory
        '
        resources.ApplyResources(Me.LocalSubcategory, "LocalSubcategory")
        Me.LocalSubcategory.Name = "LocalSubcategory"
        '
        'InternationalSubcategory
        '
        resources.ApplyResources(Me.InternationalSubcategory, "InternationalSubcategory")
        Me.InternationalSubcategory.Name = "InternationalSubcategory"
        '
        'txtDataCategory
        '
        resources.ApplyResources(Me.txtDataCategory, "txtDataCategory")
        Me.txtDataCategory.Name = "txtDataCategory"
        '
        'txtUpdateSequence
        '
        resources.ApplyResources(Me.txtUpdateSequence, "txtUpdateSequence")
        Me.txtUpdateSequence.Name = "txtUpdateSequence"
        '
        'txtOriginatingSubcentre
        '
        resources.ApplyResources(Me.txtOriginatingSubcentre, "txtOriginatingSubcentre")
        Me.txtOriginatingSubcentre.Name = "txtOriginatingSubcentre"
        '
        'txtOriginatingCentre
        '
        resources.ApplyResources(Me.txtOriginatingCentre, "txtOriginatingCentre")
        Me.txtOriginatingCentre.Name = "txtOriginatingCentre"
        '
        'txtBufrEdition
        '
        resources.ApplyResources(Me.txtBufrEdition, "txtBufrEdition")
        Me.txtBufrEdition.Name = "txtBufrEdition"
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.Name = "Label25"
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.Name = "Label26"
        '
        'Label27
        '
        resources.ApplyResources(Me.Label27, "Label27")
        Me.Label27.Name = "Label27"
        '
        'Label28
        '
        resources.ApplyResources(Me.Label28, "Label28")
        Me.Label28.Name = "Label28"
        '
        'Label29
        '
        resources.ApplyResources(Me.Label29, "Label29")
        Me.Label29.Name = "Label29"
        '
        'Label30
        '
        resources.ApplyResources(Me.Label30, "Label30")
        Me.Label30.Name = "Label30"
        '
        'Label32
        '
        resources.ApplyResources(Me.Label32, "Label32")
        Me.Label32.Name = "Label32"
        '
        'Label33
        '
        resources.ApplyResources(Me.Label33, "Label33")
        Me.Label33.Name = "Label33"
        '
        'Label34
        '
        resources.ApplyResources(Me.Label34, "Label34")
        Me.Label34.Name = "Label34"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtTemplate)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txtMsgHeader)
        Me.GroupBox5.Controls.Add(Me.Label24)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Tag = ""
        '
        'txtTemplate
        '
        Me.txtTemplate.FormattingEnabled = True
        resources.ApplyResources(Me.txtTemplate, "txtTemplate")
        Me.txtTemplate.Name = "txtTemplate"
        '
        'Label23
        '
        resources.ApplyResources(Me.Label23, "Label23")
        Me.Label23.Name = "Label23"
        '
        'txtMsgHeader
        '
        resources.ApplyResources(Me.txtMsgHeader, "txtMsgHeader")
        Me.txtMsgHeader.Name = "txtMsgHeader"
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.Name = "Label24"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'formAWSRealTime
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlProcessing)
        Me.Controls.Add(Me.pnlSites)
        Me.Controls.Add(Me.pnlDataStructures)
        Me.Controls.Add(Me.pnlServers)
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.pnlMsgEncoding)
        Me.KeyPreview = True
        Me.Name = "formAWSRealTime"
        Me.pnlControl.ResumeLayout(False)
        Me.pnlProcessing.ResumeLayout(False)
        Me.pnlProcessing.PerformLayout()
        Me.pnlProcessSettings.ResumeLayout(False)
        Me.pnlProcessSettings.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlSites.ResumeLayout(False)
        Me.grpSites.ResumeLayout(False)
        Me.grpSites.PerformLayout()
        CType(Me.DataGridViewSites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDataStructures.ResumeLayout(False)
        CType(Me.DataGridViewStructures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStructures1.ResumeLayout(False)
        Me.grpStructures1.PerformLayout()
        Me.grpStructures.ResumeLayout(False)
        Me.grpStructures.PerformLayout()
        Me.pnlServers.ResumeLayout(False)
        Me.pnlServers.PerformLayout()
        Me.pnlBaseStation.ResumeLayout(False)
        Me.pnlBaseStation.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.pnlMSS.ResumeLayout(False)
        Me.pnlMSS.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlMsgEncoding.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgrdCodeFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlControl As System.Windows.Forms.Panel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdServers As System.Windows.Forms.Button
    Friend WithEvents cmdProcess As System.Windows.Forms.Button
    Friend WithEvents pnlProcessing As System.Windows.Forms.Panel
    Friend WithEvents pnlServers As System.Windows.Forms.Panel
    Friend WithEvents cmdSites As System.Windows.Forms.Button
    Friend WithEvents cmdMessages As System.Windows.Forms.Button
    Friend WithEvents cmdDataStructures As System.Windows.Forms.Button
    Friend WithEvents lblErrors As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnlOutput As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblInputData As System.Windows.Forms.Label
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents txtInputServer As System.Windows.Forms.TextBox
    Friend WithEvents lblSever As System.Windows.Forms.Label
    Friend WithEvents txtInputfolder As System.Windows.Forms.TextBox
    Friend WithEvents lblInputFolder As System.Windows.Forms.Label
    Friend WithEvents lblInputFiles As System.Windows.Forms.Label
    Friend WithEvents lstInputFiles As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstOutputFiles As System.Windows.Forms.ListBox
    Friend WithEvents txtOutputFolder As System.Windows.Forms.TextBox
    Friend WithEvents lblOutputFolder As System.Windows.Forms.Label
    Friend WithEvents txtOutputServer As System.Windows.Forms.TextBox
    Friend WithEvents lblOutputFTP As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDateTime As System.Windows.Forms.TextBox
    Friend WithEvents lblDatetime As System.Windows.Forms.Label
    Friend WithEvents lblSatus As System.Windows.Forms.Label
    Friend WithEvents txtNxtProcess As System.Windows.Forms.TextBox
    Friend WithEvents txtNextProcess As System.Windows.Forms.Label
    Friend WithEvents txtLastProcess As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdMSS As System.Windows.Forms.Button
    Friend WithEvents cmdBaseStation As System.Windows.Forms.Button
    Friend WithEvents pnlMSS As System.Windows.Forms.Panel
    Friend WithEvents cmdMSSDelete As System.Windows.Forms.Button
    Friend WithEvents cmdMSSUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdMSSAddNew As System.Windows.Forms.Button
    Friend WithEvents txtMSSConfirm As System.Windows.Forms.TextBox
    Friend WithEvents txtMSSPW As System.Windows.Forms.TextBox
    Friend WithEvents txtmssUser As System.Windows.Forms.TextBox
    Friend WithEvents txtMSSFolder As System.Windows.Forms.TextBox
    Friend WithEvents txtMSSAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblmssConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblServerSettings As System.Windows.Forms.Label
    Friend WithEvents pnlSites As System.Windows.Forms.Panel
    Friend WithEvents pnlMsgEncoding As System.Windows.Forms.Panel
    Friend WithEvents pnlDataStructures As System.Windows.Forms.Panel
    Friend WithEvents pnlBaseStation As System.Windows.Forms.Panel
    Friend WithEvents cmdBstDelete As System.Windows.Forms.Button
    Friend WithEvents cmdBsstUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdBstSave As System.Windows.Forms.Button
    Friend WithEvents txtbaseStationPWConfirm As System.Windows.Forms.TextBox
    Friend WithEvents txtbaseStationPW As System.Windows.Forms.TextBox
    Friend WithEvents txtBaseStationUser As System.Windows.Forms.TextBox
    Friend WithEvents txtBaseStationFolder As System.Windows.Forms.TextBox
    Friend WithEvents txtBaseStationAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmInputPW As System.Windows.Forms.Label
    Friend WithEvents lblInputPW As System.Windows.Forms.Label
    Friend WithEvents lblInputUser As System.Windows.Forms.Label
    Friend WithEvents lblFTPFolder As System.Windows.Forms.Label
    Friend WithEvents lblBaseStationFTP As System.Windows.Forms.Label
    Friend WithEvents grpStructures1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpStructures As System.Windows.Forms.GroupBox
    Friend WithEvents txtQualifier As System.Windows.Forms.TextBox
    Friend WithEvents txtHeaders As System.Windows.Forms.TextBox
    Friend WithEvents txtStrName As System.Windows.Forms.TextBox
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdCreate As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblStrName As System.Windows.Forms.Label
    Friend WithEvents cmbExistingStructures As System.Windows.Forms.ComboBox
    Friend WithEvents grpElements As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dgrdCodeFlag As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents chkOptionalSection As System.Windows.Forms.CheckBox
    Friend WithEvents LocaltableVersion As System.Windows.Forms.TextBox
    Friend WithEvents MastertableVersion As System.Windows.Forms.TextBox
    Friend WithEvents LocalSubcategory As System.Windows.Forms.TextBox
    Friend WithEvents InternationalSubcategory As System.Windows.Forms.TextBox
    Friend WithEvents txtDataCategory As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdateSequence As System.Windows.Forms.TextBox
    Friend WithEvents txtOriginatingSubcentre As System.Windows.Forms.TextBox
    Friend WithEvents txtBufrEdition As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTemplate As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtMsgHeader As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents pnlProcessSettings As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents chkDeleteFile As System.Windows.Forms.CheckBox
    Friend WithEvents txtTimeout As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPeriod As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtOffset As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtInterval As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents optStop As System.Windows.Forms.RadioButton
    Friend WithEvents optStart As System.Windows.Forms.RadioButton
    Friend WithEvents lblMsgSwitch As System.Windows.Forms.Label
    Friend WithEvents lblbaseStation As System.Windows.Forms.Label
    Friend WithEvents lblFtpTransferMode As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPrevRecord As System.Windows.Forms.Button
    Friend WithEvents cmdFirstRecord As System.Windows.Forms.Button
    Friend WithEvents cmdLastRecord As System.Windows.Forms.Button
    Friend WithEvents cmdNextRecord As System.Windows.Forms.Button
    Friend WithEvents txtbssNavigator As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdmssPrev As System.Windows.Forms.Button
    Friend WithEvents cmdmssfirst As System.Windows.Forms.Button
    Friend WithEvents cmdmssLast As System.Windows.Forms.Button
    Friend WithEvents cmdmssNext As System.Windows.Forms.Button
    Friend WithEvents txtmssNavigator As System.Windows.Forms.TextBox
    Friend WithEvents txtBasestationFTPMode As System.Windows.Forms.ComboBox
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdmssRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdmssReset As System.Windows.Forms.Button
    Friend WithEvents txtmssFTPMode As System.Windows.Forms.ComboBox
    Friend WithEvents grpSites As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.ComboBox
    Friend WithEvents txtDataStructure As System.Windows.Forms.ComboBox
    Friend WithEvents txtFlag As System.Windows.Forms.TextBox
    Friend WithEvents chkOperational As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtInFile As System.Windows.Forms.TextBox
    Friend WithEvents lblInfile As System.Windows.Forms.Label
    Friend WithEvents txtSiteID As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnMovePrevious As System.Windows.Forms.Button
    Friend WithEvents btnMoveFirst As System.Windows.Forms.Button
    Friend WithEvents btnMoveLast As System.Windows.Forms.Button
    Friend WithEvents txtSitesNavigator As System.Windows.Forms.TextBox
    Friend WithEvents btnMoveNext As System.Windows.Forms.Button
    Friend WithEvents cmdViewUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdDel As System.Windows.Forms.Button
    Friend WithEvents cmdUpdateSites As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents txtDelimiter As System.Windows.Forms.ComboBox
    Friend WithEvents lblStructure As System.Windows.Forms.Label
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Ltime As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents list_errors As System.Windows.Forms.ListBox
    Friend WithEvents DataGridViewStructures As System.Windows.Forms.DataGridView
    Friend WithEvents txtGMTDiff As System.Windows.Forms.TextBox
    Friend WithEvents lblGMT As System.Windows.Forms.Label
    Friend WithEvents txtSiteName As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewSites As System.Windows.Forms.DataGridView
    Friend WithEvents cmdHelp As System.Windows.Forms.Button
    Friend WithEvents chkGTSEncode As System.Windows.Forms.CheckBox
    Friend WithEvents txtGTSHeader As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtOriginatingCentre As System.Windows.Forms.TextBox
    Friend WithEvents txtfilePrefix As System.Windows.Forms.TextBox
    Friend WithEvents chkPrefix As System.Windows.Forms.CheckBox
    Friend WithEvents txtQC As System.Windows.Forms.TextBox
    Friend WithEvents cmdBstAddNew As Button
    Friend WithEvents BindingSource1 As BindingSource
End Class
