<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSynopTDCF
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
        Dim lblYYYY As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSynopTDCF))
        Me.TabProcessing = New System.Windows.Forms.TabControl()
        Me.TabProcess = New System.Windows.Forms.TabPage()
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.txtMsgbFile = New System.Windows.Forms.TextBox()
        Me.grpBinaryMessage = New System.Windows.Forms.GroupBox()
        Me.txtEncoded = New System.Windows.Forms.TextBox()
        Me.grpObsHeaders = New System.Windows.Forms.GroupBox()
        Me.lblBBB = New System.Windows.Forms.Label()
        Me.cboBBB = New System.Windows.Forms.ComboBox()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.cboStation = New System.Windows.Forms.ComboBox()
        Me.lblHH = New System.Windows.Forms.Label()
        Me.lblDD = New System.Windows.Forms.Label()
        Me.lblMM = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.cboHour = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblEncodedFile = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdViewDecsriptors = New System.Windows.Forms.Button()
        Me.cmdEncode = New System.Windows.Forms.Button()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.grpMsgSwitch = New System.Windows.Forms.GroupBox()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtFolder = New System.Windows.Forms.TextBox()
        Me.cboFTP = New System.Windows.Forms.ComboBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblFolder = New System.Windows.Forms.Label()
        Me.lblTransferMode = New System.Windows.Forms.Label()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTemplate = New System.Windows.Forms.ComboBox()
        Me.txtMsgHeader = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpIndicators = New System.Windows.Forms.GroupBox()
        Me.lblInternationalDataSubCategory = New System.Windows.Forms.Label()
        Me.cmdUpadate = New System.Windows.Forms.Button()
        Me.txtLocalTableVersionNumber = New System.Windows.Forms.TextBox()
        Me.lblLocalTableVersionNumber = New System.Windows.Forms.Label()
        Me.chkOptionalSectionInclusion = New System.Windows.Forms.CheckBox()
        Me.lblMastersTableVersionNumber = New System.Windows.Forms.Label()
        Me.txtMastersTableVersionNumber = New System.Windows.Forms.TextBox()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.lblLocalDataSubCateory = New System.Windows.Forms.Label()
        Me.txtLocalDataSubCategory = New System.Windows.Forms.TextBox()
        Me.txtInternationalDataSubCategory = New System.Windows.Forms.TextBox()
        Me.lblDataCategory = New System.Windows.Forms.Label()
        Me.txtDataCategory = New System.Windows.Forms.TextBox()
        Me.lblOptionalSectionInclusion = New System.Windows.Forms.Label()
        Me.txtUpdateSequenceNumber = New System.Windows.Forms.TextBox()
        Me.lblUpdateSequenceNumber = New System.Windows.Forms.Label()
        Me.lblOriginatingGeneratingSubCentre = New System.Windows.Forms.Label()
        Me.txtOriginatingGeneratingSubCentre = New System.Windows.Forms.TextBox()
        Me.lblOriginatingOriginatingCentre = New System.Windows.Forms.Label()
        Me.txtOriginatingGeneratingCentre = New System.Windows.Forms.TextBox()
        Me.lblBUFREditionNumber = New System.Windows.Forms.Label()
        Me.txtBUFREditionNumber = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.lblBinaryBox = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.TabHelp = New System.Windows.Forms.TabPage()
        lblYYYY = New System.Windows.Forms.Label()
        Me.TabProcessing.SuspendLayout()
        Me.TabProcess.SuspendLayout()
        Me.grpBinaryMessage.SuspendLayout()
        Me.grpObsHeaders.SuspendLayout()
        Me.TabSettings.SuspendLayout()
        Me.grpMsgSwitch.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpIndicators.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblYYYY
        '
        resources.ApplyResources(lblYYYY, "lblYYYY")
        lblYYYY.Name = "lblYYYY"
        '
        'TabProcessing
        '
        Me.TabProcessing.Controls.Add(Me.TabProcess)
        Me.TabProcessing.Controls.Add(Me.TabSettings)
        Me.TabProcessing.Controls.Add(Me.TabHelp)
        resources.ApplyResources(Me.TabProcessing, "TabProcessing")
        Me.TabProcessing.Name = "TabProcessing"
        Me.TabProcessing.SelectedIndex = 0
        '
        'TabProcess
        '
        Me.TabProcess.Controls.Add(Me.cmdSend)
        Me.TabProcess.Controls.Add(Me.txtMsgbFile)
        Me.TabProcess.Controls.Add(Me.grpBinaryMessage)
        Me.TabProcess.Controls.Add(Me.grpObsHeaders)
        Me.TabProcess.Controls.Add(Me.lblEncodedFile)
        Me.TabProcess.Controls.Add(Me.cmdClose)
        Me.TabProcess.Controls.Add(Me.cmdViewDecsriptors)
        Me.TabProcess.Controls.Add(Me.cmdEncode)
        resources.ApplyResources(Me.TabProcess, "TabProcess")
        Me.TabProcess.Name = "TabProcess"
        Me.TabProcess.UseVisualStyleBackColor = True
        '
        'cmdSend
        '
        resources.ApplyResources(Me.cmdSend, "cmdSend")
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'txtMsgbFile
        '
        resources.ApplyResources(Me.txtMsgbFile, "txtMsgbFile")
        Me.txtMsgbFile.Name = "txtMsgbFile"
        '
        'grpBinaryMessage
        '
        Me.grpBinaryMessage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpBinaryMessage.Controls.Add(Me.txtEncoded)
        resources.ApplyResources(Me.grpBinaryMessage, "grpBinaryMessage")
        Me.grpBinaryMessage.Name = "grpBinaryMessage"
        Me.grpBinaryMessage.TabStop = False
        '
        'txtEncoded
        '
        resources.ApplyResources(Me.txtEncoded, "txtEncoded")
        Me.txtEncoded.Name = "txtEncoded"
        '
        'grpObsHeaders
        '
        Me.grpObsHeaders.BackColor = System.Drawing.Color.Gainsboro
        Me.grpObsHeaders.Controls.Add(Me.lblBBB)
        Me.grpObsHeaders.Controls.Add(Me.cboBBB)
        Me.grpObsHeaders.Controls.Add(Me.lblStation)
        Me.grpObsHeaders.Controls.Add(Me.cboStation)
        Me.grpObsHeaders.Controls.Add(Me.lblHH)
        Me.grpObsHeaders.Controls.Add(Me.lblDD)
        Me.grpObsHeaders.Controls.Add(Me.lblMM)
        Me.grpObsHeaders.Controls.Add(Me.cboMonth)
        Me.grpObsHeaders.Controls.Add(Me.cboDay)
        Me.grpObsHeaders.Controls.Add(Me.cboHour)
        Me.grpObsHeaders.Controls.Add(lblYYYY)
        Me.grpObsHeaders.Controls.Add(Me.txtYear)
        resources.ApplyResources(Me.grpObsHeaders, "grpObsHeaders")
        Me.grpObsHeaders.Name = "grpObsHeaders"
        Me.grpObsHeaders.TabStop = False
        '
        'lblBBB
        '
        resources.ApplyResources(Me.lblBBB, "lblBBB")
        Me.lblBBB.Name = "lblBBB"
        Me.lblBBB.Tag = "BBB"
        '
        'cboBBB
        '
        Me.cboBBB.FormattingEnabled = True
        resources.ApplyResources(Me.cboBBB, "cboBBB")
        Me.cboBBB.Name = "cboBBB"
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'cboStation
        '
        Me.cboStation.FormattingEnabled = True
        resources.ApplyResources(Me.cboStation, "cboStation")
        Me.cboStation.Name = "cboStation"
        '
        'lblHH
        '
        resources.ApplyResources(Me.lblHH, "lblHH")
        Me.lblHH.Name = "lblHH"
        '
        'lblDD
        '
        resources.ApplyResources(Me.lblDD, "lblDD")
        Me.lblDD.Name = "lblDD"
        '
        'lblMM
        '
        resources.ApplyResources(Me.lblMM, "lblMM")
        Me.lblMM.Name = "lblMM"
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {resources.GetString("cboMonth.Items"), resources.GetString("cboMonth.Items1"), resources.GetString("cboMonth.Items2"), resources.GetString("cboMonth.Items3"), resources.GetString("cboMonth.Items4"), resources.GetString("cboMonth.Items5"), resources.GetString("cboMonth.Items6"), resources.GetString("cboMonth.Items7"), resources.GetString("cboMonth.Items8"), resources.GetString("cboMonth.Items9"), resources.GetString("cboMonth.Items10"), resources.GetString("cboMonth.Items11")})
        resources.ApplyResources(Me.cboMonth, "cboMonth")
        Me.cboMonth.Name = "cboMonth"
        '
        'cboDay
        '
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Items.AddRange(New Object() {resources.GetString("cboDay.Items"), resources.GetString("cboDay.Items1"), resources.GetString("cboDay.Items2"), resources.GetString("cboDay.Items3"), resources.GetString("cboDay.Items4"), resources.GetString("cboDay.Items5"), resources.GetString("cboDay.Items6"), resources.GetString("cboDay.Items7"), resources.GetString("cboDay.Items8"), resources.GetString("cboDay.Items9"), resources.GetString("cboDay.Items10"), resources.GetString("cboDay.Items11"), resources.GetString("cboDay.Items12"), resources.GetString("cboDay.Items13"), resources.GetString("cboDay.Items14"), resources.GetString("cboDay.Items15"), resources.GetString("cboDay.Items16"), resources.GetString("cboDay.Items17"), resources.GetString("cboDay.Items18"), resources.GetString("cboDay.Items19"), resources.GetString("cboDay.Items20"), resources.GetString("cboDay.Items21"), resources.GetString("cboDay.Items22"), resources.GetString("cboDay.Items23"), resources.GetString("cboDay.Items24"), resources.GetString("cboDay.Items25"), resources.GetString("cboDay.Items26"), resources.GetString("cboDay.Items27"), resources.GetString("cboDay.Items28"), resources.GetString("cboDay.Items29"), resources.GetString("cboDay.Items30")})
        resources.ApplyResources(Me.cboDay, "cboDay")
        Me.cboDay.Name = "cboDay"
        '
        'cboHour
        '
        Me.cboHour.FormattingEnabled = True
        Me.cboHour.Items.AddRange(New Object() {resources.GetString("cboHour.Items"), resources.GetString("cboHour.Items1"), resources.GetString("cboHour.Items2"), resources.GetString("cboHour.Items3"), resources.GetString("cboHour.Items4"), resources.GetString("cboHour.Items5"), resources.GetString("cboHour.Items6"), resources.GetString("cboHour.Items7"), resources.GetString("cboHour.Items8"), resources.GetString("cboHour.Items9"), resources.GetString("cboHour.Items10"), resources.GetString("cboHour.Items11"), resources.GetString("cboHour.Items12"), resources.GetString("cboHour.Items13"), resources.GetString("cboHour.Items14"), resources.GetString("cboHour.Items15"), resources.GetString("cboHour.Items16"), resources.GetString("cboHour.Items17"), resources.GetString("cboHour.Items18"), resources.GetString("cboHour.Items19"), resources.GetString("cboHour.Items20"), resources.GetString("cboHour.Items21"), resources.GetString("cboHour.Items22"), resources.GetString("cboHour.Items23"), resources.GetString("cboHour.Items24")})
        resources.ApplyResources(Me.cboHour, "cboHour")
        Me.cboHour.Name = "cboHour"
        '
        'txtYear
        '
        resources.ApplyResources(Me.txtYear, "txtYear")
        Me.txtYear.Name = "txtYear"
        '
        'lblEncodedFile
        '
        resources.ApplyResources(Me.lblEncodedFile, "lblEncodedFile")
        Me.lblEncodedFile.Name = "lblEncodedFile"
        '
        'cmdClose
        '
        resources.ApplyResources(Me.cmdClose, "cmdClose")
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdViewDecsriptors
        '
        resources.ApplyResources(Me.cmdViewDecsriptors, "cmdViewDecsriptors")
        Me.cmdViewDecsriptors.Name = "cmdViewDecsriptors"
        Me.cmdViewDecsriptors.UseVisualStyleBackColor = True
        '
        'cmdEncode
        '
        resources.ApplyResources(Me.cmdEncode, "cmdEncode")
        Me.cmdEncode.Name = "cmdEncode"
        Me.cmdEncode.UseVisualStyleBackColor = True
        '
        'TabSettings
        '
        Me.TabSettings.Controls.Add(Me.grpMsgSwitch)
        Me.TabSettings.Controls.Add(Me.GroupBox1)
        Me.TabSettings.Controls.Add(Me.grpIndicators)
        Me.TabSettings.Controls.Add(Me.lblBinaryBox)
        Me.TabSettings.Controls.Add(Me.cmdCancel)
        resources.ApplyResources(Me.TabSettings, "TabSettings")
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.UseVisualStyleBackColor = True
        '
        'grpMsgSwitch
        '
        Me.grpMsgSwitch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpMsgSwitch.Controls.Add(Me.cmdUpdate)
        Me.grpMsgSwitch.Controls.Add(Me.txtConfirmPassword)
        Me.grpMsgSwitch.Controls.Add(Me.txtPassword)
        Me.grpMsgSwitch.Controls.Add(Me.txtLogin)
        Me.grpMsgSwitch.Controls.Add(Me.txtFolder)
        Me.grpMsgSwitch.Controls.Add(Me.cboFTP)
        Me.grpMsgSwitch.Controls.Add(Me.txtServer)
        Me.grpMsgSwitch.Controls.Add(Me.lblConfirmPassword)
        Me.grpMsgSwitch.Controls.Add(Me.lblPassword)
        Me.grpMsgSwitch.Controls.Add(Me.lblLogin)
        Me.grpMsgSwitch.Controls.Add(Me.lblFolder)
        Me.grpMsgSwitch.Controls.Add(Me.lblTransferMode)
        Me.grpMsgSwitch.Controls.Add(Me.lblServer)
        resources.ApplyResources(Me.grpMsgSwitch, "grpMsgSwitch")
        Me.grpMsgSwitch.Name = "grpMsgSwitch"
        Me.grpMsgSwitch.TabStop = False
        '
        'cmdUpdate
        '
        resources.ApplyResources(Me.cmdUpdate, "cmdUpdate")
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'txtConfirmPassword
        '
        resources.ApplyResources(Me.txtConfirmPassword, "txtConfirmPassword")
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        '
        'txtPassword
        '
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.Name = "txtPassword"
        '
        'txtLogin
        '
        resources.ApplyResources(Me.txtLogin, "txtLogin")
        Me.txtLogin.Name = "txtLogin"
        '
        'txtFolder
        '
        resources.ApplyResources(Me.txtFolder, "txtFolder")
        Me.txtFolder.Name = "txtFolder"
        '
        'cboFTP
        '
        Me.cboFTP.FormattingEnabled = True
        Me.cboFTP.Items.AddRange(New Object() {resources.GetString("cboFTP.Items"), resources.GetString("cboFTP.Items1")})
        resources.ApplyResources(Me.cboFTP, "cboFTP")
        Me.cboFTP.Name = "cboFTP"
        '
        'txtServer
        '
        resources.ApplyResources(Me.txtServer, "txtServer")
        Me.txtServer.Name = "txtServer"
        '
        'lblConfirmPassword
        '
        resources.ApplyResources(Me.lblConfirmPassword, "lblConfirmPassword")
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        '
        'lblPassword
        '
        resources.ApplyResources(Me.lblPassword, "lblPassword")
        Me.lblPassword.Name = "lblPassword"
        '
        'lblLogin
        '
        resources.ApplyResources(Me.lblLogin, "lblLogin")
        Me.lblLogin.Name = "lblLogin"
        '
        'lblFolder
        '
        resources.ApplyResources(Me.lblFolder, "lblFolder")
        Me.lblFolder.Name = "lblFolder"
        '
        'lblTransferMode
        '
        resources.ApplyResources(Me.lblTransferMode, "lblTransferMode")
        Me.lblTransferMode.Name = "lblTransferMode"
        '
        'lblServer
        '
        resources.ApplyResources(Me.lblServer, "lblServer")
        Me.lblServer.Name = "lblServer"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.lblHeader)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboTemplate)
        Me.GroupBox1.Controls.Add(Me.txtMsgHeader)
        Me.GroupBox1.Controls.Add(Me.Label7)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lblHeader
        '
        resources.ApplyResources(Me.lblHeader, "lblHeader")
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Tag = "Header"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        Me.Label1.Tag = "Template"
        '
        'cboTemplate
        '
        Me.cboTemplate.FormattingEnabled = True
        resources.ApplyResources(Me.cboTemplate, "cboTemplate")
        Me.cboTemplate.Name = "cboTemplate"
        '
        'txtMsgHeader
        '
        resources.ApplyResources(Me.txtMsgHeader, "txtMsgHeader")
        Me.txtMsgHeader.Name = "txtMsgHeader"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        Me.Label7.Tag = "Template"
        '
        'grpIndicators
        '
        Me.grpIndicators.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpIndicators.Controls.Add(Me.lblInternationalDataSubCategory)
        Me.grpIndicators.Controls.Add(Me.cmdUpadate)
        Me.grpIndicators.Controls.Add(Me.txtLocalTableVersionNumber)
        Me.grpIndicators.Controls.Add(Me.lblLocalTableVersionNumber)
        Me.grpIndicators.Controls.Add(Me.chkOptionalSectionInclusion)
        Me.grpIndicators.Controls.Add(Me.lblMastersTableVersionNumber)
        Me.grpIndicators.Controls.Add(Me.txtMastersTableVersionNumber)
        Me.grpIndicators.Controls.Add(Me.cmdNew)
        Me.grpIndicators.Controls.Add(Me.lblLocalDataSubCateory)
        Me.grpIndicators.Controls.Add(Me.txtLocalDataSubCategory)
        Me.grpIndicators.Controls.Add(Me.txtInternationalDataSubCategory)
        Me.grpIndicators.Controls.Add(Me.lblDataCategory)
        Me.grpIndicators.Controls.Add(Me.txtDataCategory)
        Me.grpIndicators.Controls.Add(Me.lblOptionalSectionInclusion)
        Me.grpIndicators.Controls.Add(Me.txtUpdateSequenceNumber)
        Me.grpIndicators.Controls.Add(Me.lblUpdateSequenceNumber)
        Me.grpIndicators.Controls.Add(Me.lblOriginatingGeneratingSubCentre)
        Me.grpIndicators.Controls.Add(Me.txtOriginatingGeneratingSubCentre)
        Me.grpIndicators.Controls.Add(Me.lblOriginatingOriginatingCentre)
        Me.grpIndicators.Controls.Add(Me.txtOriginatingGeneratingCentre)
        Me.grpIndicators.Controls.Add(Me.lblBUFREditionNumber)
        Me.grpIndicators.Controls.Add(Me.txtBUFREditionNumber)
        Me.grpIndicators.Controls.Add(Me.Label44)
        Me.grpIndicators.Controls.Add(Me.Label49)
        resources.ApplyResources(Me.grpIndicators, "grpIndicators")
        Me.grpIndicators.Name = "grpIndicators"
        Me.grpIndicators.TabStop = False
        Me.grpIndicators.Tag = "Indicators"
        '
        'lblInternationalDataSubCategory
        '
        resources.ApplyResources(Me.lblInternationalDataSubCategory, "lblInternationalDataSubCategory")
        Me.lblInternationalDataSubCategory.Name = "lblInternationalDataSubCategory"
        Me.lblInternationalDataSubCategory.Tag = "Data_Category"
        '
        'cmdUpadate
        '
        resources.ApplyResources(Me.cmdUpadate, "cmdUpadate")
        Me.cmdUpadate.Name = "cmdUpadate"
        Me.cmdUpadate.UseVisualStyleBackColor = True
        '
        'txtLocalTableVersionNumber
        '
        resources.ApplyResources(Me.txtLocalTableVersionNumber, "txtLocalTableVersionNumber")
        Me.txtLocalTableVersionNumber.Name = "txtLocalTableVersionNumber"
        '
        'lblLocalTableVersionNumber
        '
        resources.ApplyResources(Me.lblLocalTableVersionNumber, "lblLocalTableVersionNumber")
        Me.lblLocalTableVersionNumber.Name = "lblLocalTableVersionNumber"
        Me.lblLocalTableVersionNumber.Tag = "Table_Version_Number"
        '
        'chkOptionalSectionInclusion
        '
        resources.ApplyResources(Me.chkOptionalSectionInclusion, "chkOptionalSectionInclusion")
        Me.chkOptionalSectionInclusion.Name = "chkOptionalSectionInclusion"
        Me.chkOptionalSectionInclusion.UseVisualStyleBackColor = True
        '
        'lblMastersTableVersionNumber
        '
        resources.ApplyResources(Me.lblMastersTableVersionNumber, "lblMastersTableVersionNumber")
        Me.lblMastersTableVersionNumber.Name = "lblMastersTableVersionNumber"
        Me.lblMastersTableVersionNumber.Tag = "Masters_Table_Version_Number"
        '
        'txtMastersTableVersionNumber
        '
        resources.ApplyResources(Me.txtMastersTableVersionNumber, "txtMastersTableVersionNumber")
        Me.txtMastersTableVersionNumber.Name = "txtMastersTableVersionNumber"
        '
        'cmdNew
        '
        resources.ApplyResources(Me.cmdNew, "cmdNew")
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'lblLocalDataSubCateory
        '
        resources.ApplyResources(Me.lblLocalDataSubCateory, "lblLocalDataSubCateory")
        Me.lblLocalDataSubCateory.Name = "lblLocalDataSubCateory"
        Me.lblLocalDataSubCateory.Tag = "Local_Data_Sub_Cateory"
        '
        'txtLocalDataSubCategory
        '
        resources.ApplyResources(Me.txtLocalDataSubCategory, "txtLocalDataSubCategory")
        Me.txtLocalDataSubCategory.Name = "txtLocalDataSubCategory"
        '
        'txtInternationalDataSubCategory
        '
        resources.ApplyResources(Me.txtInternationalDataSubCategory, "txtInternationalDataSubCategory")
        Me.txtInternationalDataSubCategory.Name = "txtInternationalDataSubCategory"
        '
        'lblDataCategory
        '
        resources.ApplyResources(Me.lblDataCategory, "lblDataCategory")
        Me.lblDataCategory.Name = "lblDataCategory"
        Me.lblDataCategory.Tag = "Data_Category"
        '
        'txtDataCategory
        '
        resources.ApplyResources(Me.txtDataCategory, "txtDataCategory")
        Me.txtDataCategory.Name = "txtDataCategory"
        '
        'lblOptionalSectionInclusion
        '
        resources.ApplyResources(Me.lblOptionalSectionInclusion, "lblOptionalSectionInclusion")
        Me.lblOptionalSectionInclusion.Name = "lblOptionalSectionInclusion"
        Me.lblOptionalSectionInclusion.Tag = "Optional_Section_Inclusion"
        '
        'txtUpdateSequenceNumber
        '
        resources.ApplyResources(Me.txtUpdateSequenceNumber, "txtUpdateSequenceNumber")
        Me.txtUpdateSequenceNumber.Name = "txtUpdateSequenceNumber"
        '
        'lblUpdateSequenceNumber
        '
        resources.ApplyResources(Me.lblUpdateSequenceNumber, "lblUpdateSequenceNumber")
        Me.lblUpdateSequenceNumber.Name = "lblUpdateSequenceNumber"
        Me.lblUpdateSequenceNumber.Tag = "Update_Sequence_Number"
        '
        'lblOriginatingGeneratingSubCentre
        '
        resources.ApplyResources(Me.lblOriginatingGeneratingSubCentre, "lblOriginatingGeneratingSubCentre")
        Me.lblOriginatingGeneratingSubCentre.Name = "lblOriginatingGeneratingSubCentre"
        Me.lblOriginatingGeneratingSubCentre.Tag = "Originating_Generating_SubCentre"
        '
        'txtOriginatingGeneratingSubCentre
        '
        resources.ApplyResources(Me.txtOriginatingGeneratingSubCentre, "txtOriginatingGeneratingSubCentre")
        Me.txtOriginatingGeneratingSubCentre.Name = "txtOriginatingGeneratingSubCentre"
        '
        'lblOriginatingOriginatingCentre
        '
        resources.ApplyResources(Me.lblOriginatingOriginatingCentre, "lblOriginatingOriginatingCentre")
        Me.lblOriginatingOriginatingCentre.Name = "lblOriginatingOriginatingCentre"
        Me.lblOriginatingOriginatingCentre.Tag = "Originating_Generating_Centre"
        '
        'txtOriginatingGeneratingCentre
        '
        resources.ApplyResources(Me.txtOriginatingGeneratingCentre, "txtOriginatingGeneratingCentre")
        Me.txtOriginatingGeneratingCentre.Name = "txtOriginatingGeneratingCentre"
        '
        'lblBUFREditionNumber
        '
        resources.ApplyResources(Me.lblBUFREditionNumber, "lblBUFREditionNumber")
        Me.lblBUFREditionNumber.Name = "lblBUFREditionNumber"
        Me.lblBUFREditionNumber.Tag = "BUFR_edition_Number"
        '
        'txtBUFREditionNumber
        '
        resources.ApplyResources(Me.txtBUFREditionNumber, "txtBUFREditionNumber")
        Me.txtBUFREditionNumber.Name = "txtBUFREditionNumber"
        '
        'Label44
        '
        resources.ApplyResources(Me.Label44, "Label44")
        Me.Label44.Name = "Label44"
        '
        'Label49
        '
        resources.ApplyResources(Me.Label49, "Label49")
        Me.Label49.Name = "Label49"
        '
        'lblBinaryBox
        '
        resources.ApplyResources(Me.lblBinaryBox, "lblBinaryBox")
        Me.lblBinaryBox.Name = "lblBinaryBox"
        '
        'cmdCancel
        '
        resources.ApplyResources(Me.cmdCancel, "cmdCancel")
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'TabHelp
        '
        resources.ApplyResources(Me.TabHelp, "TabHelp")
        Me.TabHelp.Name = "TabHelp"
        Me.TabHelp.UseVisualStyleBackColor = True
        '
        'frmSynopTDCF
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabProcessing)
        Me.Name = "frmSynopTDCF"
        Me.TabProcessing.ResumeLayout(False)
        Me.TabProcess.ResumeLayout(False)
        Me.TabProcess.PerformLayout()
        Me.grpBinaryMessage.ResumeLayout(False)
        Me.grpBinaryMessage.PerformLayout()
        Me.grpObsHeaders.ResumeLayout(False)
        Me.grpObsHeaders.PerformLayout()
        Me.TabSettings.ResumeLayout(False)
        Me.TabSettings.PerformLayout()
        Me.grpMsgSwitch.ResumeLayout(False)
        Me.grpMsgSwitch.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpIndicators.ResumeLayout(False)
        Me.grpIndicators.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabProcessing As System.Windows.Forms.TabControl
    Friend WithEvents TabProcess As System.Windows.Forms.TabPage
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdViewDecsriptors As System.Windows.Forms.Button
    Friend WithEvents cmdEncode As System.Windows.Forms.Button
    Friend WithEvents TabHelp As System.Windows.Forms.TabPage
    Friend WithEvents lblEncodedFile As System.Windows.Forms.Label
    Friend WithEvents TabSettings As System.Windows.Forms.TabPage
    Friend WithEvents lblBinaryBox As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents grpIndicators As System.Windows.Forms.GroupBox
    Friend WithEvents chkOptionalSectionInclusion As System.Windows.Forms.CheckBox
    Friend WithEvents lblMastersTableVersionNumber As System.Windows.Forms.Label
    Friend WithEvents txtMastersTableVersionNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblLocalDataSubCateory As System.Windows.Forms.Label
    Friend WithEvents txtLocalDataSubCategory As System.Windows.Forms.TextBox
    Friend WithEvents txtInternationalDataSubCategory As System.Windows.Forms.TextBox
    Friend WithEvents lblDataCategory As System.Windows.Forms.Label
    Friend WithEvents txtDataCategory As System.Windows.Forms.TextBox
    Friend WithEvents lblOptionalSectionInclusion As System.Windows.Forms.Label
    Friend WithEvents txtUpdateSequenceNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblUpdateSequenceNumber As System.Windows.Forms.Label
    Friend WithEvents lblOriginatingGeneratingSubCentre As System.Windows.Forms.Label
    Friend WithEvents txtOriginatingGeneratingSubCentre As System.Windows.Forms.TextBox
    Friend WithEvents lblOriginatingOriginatingCentre As System.Windows.Forms.Label
    Friend WithEvents txtOriginatingGeneratingCentre As System.Windows.Forms.TextBox
    Friend WithEvents lblBUFREditionNumber As System.Windows.Forms.Label
    Friend WithEvents txtBUFREditionNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents lblLocalTableVersionNumber As System.Windows.Forms.Label
    Friend WithEvents lblInternationalDataSubCategory As System.Windows.Forms.Label
    Friend WithEvents txtLocalTableVersionNumber As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTemplate As System.Windows.Forms.ComboBox
    Friend WithEvents txtMsgHeader As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents cmdUpadate As System.Windows.Forms.Button
    Friend WithEvents grpMsgSwitch As System.Windows.Forms.GroupBox
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtFolder As System.Windows.Forms.TextBox
    Friend WithEvents cboFTP As System.Windows.Forms.ComboBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblFolder As System.Windows.Forms.Label
    Friend WithEvents lblTransferMode As System.Windows.Forms.Label
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents grpObsHeaders As System.Windows.Forms.GroupBox
    Friend WithEvents lblStation As System.Windows.Forms.Label
    Friend WithEvents cboStation As System.Windows.Forms.ComboBox
    Friend WithEvents lblHH As System.Windows.Forms.Label
    Friend WithEvents lblDD As System.Windows.Forms.Label
    Friend WithEvents lblMM As System.Windows.Forms.Label
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cboDay As System.Windows.Forms.ComboBox
    Friend WithEvents cboHour As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtMsgbFile As System.Windows.Forms.TextBox
    Friend WithEvents grpBinaryMessage As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSend As System.Windows.Forms.Button
    Friend WithEvents lblBBB As System.Windows.Forms.Label
    Friend WithEvents cboBBB As System.Windows.Forms.ComboBox
    Friend WithEvents txtEncoded As System.Windows.Forms.TextBox
End Class
