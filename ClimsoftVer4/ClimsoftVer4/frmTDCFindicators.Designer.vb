<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTDCFindicators
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTDCFindicators))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTemplate = New System.Windows.Forms.ComboBox()
        Me.txtMsgHeader = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpIndicators = New System.Windows.Forms.GroupBox()
        Me.lblInternationalDataSubCategory = New System.Windows.Forms.Label()
        Me.txtLocalTableVersionNumber = New System.Windows.Forms.TextBox()
        Me.lblLocalTableVersionNumber = New System.Windows.Forms.Label()
        Me.chkOptionalSectionInclusion = New System.Windows.Forms.CheckBox()
        Me.lblMastersTableVersionNumber = New System.Windows.Forms.Label()
        Me.txtMastersTableVersionNumber = New System.Windows.Forms.TextBox()
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
        Me.cmdUpadate = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpIndicators.SuspendLayout()
        Me.SuspendLayout()
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
        Me.grpIndicators.Controls.Add(Me.txtLocalTableVersionNumber)
        Me.grpIndicators.Controls.Add(Me.lblLocalTableVersionNumber)
        Me.grpIndicators.Controls.Add(Me.chkOptionalSectionInclusion)
        Me.grpIndicators.Controls.Add(Me.lblMastersTableVersionNumber)
        Me.grpIndicators.Controls.Add(Me.txtMastersTableVersionNumber)
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
        'cmdUpadate
        '
        resources.ApplyResources(Me.cmdUpadate, "cmdUpadate")
        Me.cmdUpadate.Name = "cmdUpadate"
        Me.cmdUpadate.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        resources.ApplyResources(Me.cmdNew, "cmdNew")
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        resources.ApplyResources(Me.cmdSave, "cmdSave")
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        resources.ApplyResources(Me.cmdClose, "cmdClose")
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmTDCFindicators
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdUpadate)
        Me.Controls.Add(Me.grpIndicators)
        Me.Controls.Add(Me.cmdNew)
        Me.Name = "frmTDCFindicators"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpIndicators.ResumeLayout(False)
        Me.grpIndicators.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTemplate As System.Windows.Forms.ComboBox
    Friend WithEvents txtMsgHeader As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grpIndicators As System.Windows.Forms.GroupBox
    Friend WithEvents lblInternationalDataSubCategory As System.Windows.Forms.Label
    Friend WithEvents txtLocalTableVersionNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblLocalTableVersionNumber As System.Windows.Forms.Label
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
    Friend WithEvents cmdUpadate As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
