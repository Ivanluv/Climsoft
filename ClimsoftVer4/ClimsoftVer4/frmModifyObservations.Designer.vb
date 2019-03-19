<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifyObservations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifyObservations))
        Me.DataGridViewObservations = New System.Windows.Forms.DataGridView()
        Me.GrBxSelection = New System.Windows.Forms.GroupBox()
        Me.txtEndHour = New System.Windows.Forms.TextBox()
        Me.txtStartHour = New System.Windows.Forms.TextBox()
        Me.lblEndHour = New System.Windows.Forms.Label()
        Me.lblStartHour = New System.Windows.Forms.Label()
        Me.txtEndDay = New System.Windows.Forms.TextBox()
        Me.txtStartDay = New System.Windows.Forms.TextBox()
        Me.lblEndDay = New System.Windows.Forms.Label()
        Me.lblStartDay = New System.Windows.Forms.Label()
        Me.txtEndMonth = New System.Windows.Forms.TextBox()
        Me.txtStartMonth = New System.Windows.Forms.TextBox()
        Me.txtEndYear = New System.Windows.Forms.TextBox()
        Me.txtStartYear = New System.Windows.Forms.TextBox()
        Me.txtElement = New System.Windows.Forms.TextBox()
        Me.txtStation = New System.Windows.Forms.TextBox()
        Me.lblEndMonth = New System.Windows.Forms.Label()
        Me.lblStartMonth = New System.Windows.Forms.Label()
        Me.lblEndYear = New System.Windows.Forms.Label()
        Me.lblStartYear = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblSation = New System.Windows.Forms.Label()
        Me.GrBxCommands = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdUpade = New System.Windows.Forms.Button()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.GrBxDataBase = New System.Windows.Forms.GroupBox()
        Me.optFinal = New System.Windows.Forms.RadioButton()
        Me.optInitial = New System.Windows.Forms.RadioButton()
        Me.lblrecords = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridViewObservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBxSelection.SuspendLayout()
        Me.GrBxCommands.SuspendLayout()
        Me.GrBxDataBase.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewObservations
        '
        Me.DataGridViewObservations.AllowDrop = True
        Me.DataGridViewObservations.AllowUserToAddRows = False
        Me.DataGridViewObservations.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewObservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataGridViewObservations, "DataGridViewObservations")
        Me.DataGridViewObservations.Name = "DataGridViewObservations"
        '
        'GrBxSelection
        '
        Me.GrBxSelection.Controls.Add(Me.txtEndHour)
        Me.GrBxSelection.Controls.Add(Me.txtStartHour)
        Me.GrBxSelection.Controls.Add(Me.lblEndHour)
        Me.GrBxSelection.Controls.Add(Me.lblStartHour)
        Me.GrBxSelection.Controls.Add(Me.txtEndDay)
        Me.GrBxSelection.Controls.Add(Me.txtStartDay)
        Me.GrBxSelection.Controls.Add(Me.lblEndDay)
        Me.GrBxSelection.Controls.Add(Me.lblStartDay)
        Me.GrBxSelection.Controls.Add(Me.txtEndMonth)
        Me.GrBxSelection.Controls.Add(Me.txtStartMonth)
        Me.GrBxSelection.Controls.Add(Me.txtEndYear)
        Me.GrBxSelection.Controls.Add(Me.txtStartYear)
        Me.GrBxSelection.Controls.Add(Me.txtElement)
        Me.GrBxSelection.Controls.Add(Me.txtStation)
        Me.GrBxSelection.Controls.Add(Me.lblEndMonth)
        Me.GrBxSelection.Controls.Add(Me.lblStartMonth)
        Me.GrBxSelection.Controls.Add(Me.lblEndYear)
        Me.GrBxSelection.Controls.Add(Me.lblStartYear)
        Me.GrBxSelection.Controls.Add(Me.lblElement)
        Me.GrBxSelection.Controls.Add(Me.lblSation)
        resources.ApplyResources(Me.GrBxSelection, "GrBxSelection")
        Me.GrBxSelection.Name = "GrBxSelection"
        Me.GrBxSelection.TabStop = False
        '
        'txtEndHour
        '
        resources.ApplyResources(Me.txtEndHour, "txtEndHour")
        Me.txtEndHour.Name = "txtEndHour"
        '
        'txtStartHour
        '
        resources.ApplyResources(Me.txtStartHour, "txtStartHour")
        Me.txtStartHour.Name = "txtStartHour"
        '
        'lblEndHour
        '
        resources.ApplyResources(Me.lblEndHour, "lblEndHour")
        Me.lblEndHour.Name = "lblEndHour"
        '
        'lblStartHour
        '
        resources.ApplyResources(Me.lblStartHour, "lblStartHour")
        Me.lblStartHour.Name = "lblStartHour"
        '
        'txtEndDay
        '
        resources.ApplyResources(Me.txtEndDay, "txtEndDay")
        Me.txtEndDay.Name = "txtEndDay"
        '
        'txtStartDay
        '
        resources.ApplyResources(Me.txtStartDay, "txtStartDay")
        Me.txtStartDay.Name = "txtStartDay"
        '
        'lblEndDay
        '
        resources.ApplyResources(Me.lblEndDay, "lblEndDay")
        Me.lblEndDay.Name = "lblEndDay"
        '
        'lblStartDay
        '
        resources.ApplyResources(Me.lblStartDay, "lblStartDay")
        Me.lblStartDay.Name = "lblStartDay"
        '
        'txtEndMonth
        '
        resources.ApplyResources(Me.txtEndMonth, "txtEndMonth")
        Me.txtEndMonth.Name = "txtEndMonth"
        '
        'txtStartMonth
        '
        resources.ApplyResources(Me.txtStartMonth, "txtStartMonth")
        Me.txtStartMonth.Name = "txtStartMonth"
        '
        'txtEndYear
        '
        resources.ApplyResources(Me.txtEndYear, "txtEndYear")
        Me.txtEndYear.Name = "txtEndYear"
        '
        'txtStartYear
        '
        resources.ApplyResources(Me.txtStartYear, "txtStartYear")
        Me.txtStartYear.Name = "txtStartYear"
        '
        'txtElement
        '
        resources.ApplyResources(Me.txtElement, "txtElement")
        Me.txtElement.Name = "txtElement"
        '
        'txtStation
        '
        resources.ApplyResources(Me.txtStation, "txtStation")
        Me.txtStation.Name = "txtStation"
        '
        'lblEndMonth
        '
        resources.ApplyResources(Me.lblEndMonth, "lblEndMonth")
        Me.lblEndMonth.Name = "lblEndMonth"
        '
        'lblStartMonth
        '
        resources.ApplyResources(Me.lblStartMonth, "lblStartMonth")
        Me.lblStartMonth.Name = "lblStartMonth"
        '
        'lblEndYear
        '
        resources.ApplyResources(Me.lblEndYear, "lblEndYear")
        Me.lblEndYear.Name = "lblEndYear"
        '
        'lblStartYear
        '
        resources.ApplyResources(Me.lblStartYear, "lblStartYear")
        Me.lblStartYear.Name = "lblStartYear"
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'lblSation
        '
        resources.ApplyResources(Me.lblSation, "lblSation")
        Me.lblSation.Name = "lblSation"
        '
        'GrBxCommands
        '
        Me.GrBxCommands.Controls.Add(Me.Button1)
        Me.GrBxCommands.Controls.Add(Me.cmdClose)
        Me.GrBxCommands.Controls.Add(Me.cmdDelete)
        Me.GrBxCommands.Controls.Add(Me.cmdUpade)
        Me.GrBxCommands.Controls.Add(Me.cmdView)
        resources.ApplyResources(Me.GrBxCommands, "GrBxCommands")
        Me.GrBxCommands.Name = "GrBxCommands"
        Me.GrBxCommands.TabStop = False
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        resources.ApplyResources(Me.cmdClose, "cmdClose")
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        resources.ApplyResources(Me.cmdDelete, "cmdDelete")
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdUpade
        '
        resources.ApplyResources(Me.cmdUpade, "cmdUpade")
        Me.cmdUpade.Name = "cmdUpade"
        Me.cmdUpade.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        resources.ApplyResources(Me.cmdView, "cmdView")
        Me.cmdView.Name = "cmdView"
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'GrBxDataBase
        '
        Me.GrBxDataBase.Controls.Add(Me.optFinal)
        Me.GrBxDataBase.Controls.Add(Me.optInitial)
        resources.ApplyResources(Me.GrBxDataBase, "GrBxDataBase")
        Me.GrBxDataBase.Name = "GrBxDataBase"
        Me.GrBxDataBase.TabStop = False
        '
        'optFinal
        '
        resources.ApplyResources(Me.optFinal, "optFinal")
        Me.optFinal.Name = "optFinal"
        Me.optFinal.UseVisualStyleBackColor = True
        '
        'optInitial
        '
        resources.ApplyResources(Me.optInitial, "optInitial")
        Me.optInitial.Checked = True
        Me.optInitial.Name = "optInitial"
        Me.optInitial.TabStop = True
        Me.optInitial.UseVisualStyleBackColor = True
        '
        'lblrecords
        '
        resources.ApplyResources(Me.lblrecords, "lblrecords")
        Me.lblrecords.Name = "lblrecords"
        '
        'frmModifyObservations
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblrecords)
        Me.Controls.Add(Me.GrBxDataBase)
        Me.Controls.Add(Me.GrBxCommands)
        Me.Controls.Add(Me.GrBxSelection)
        Me.Controls.Add(Me.DataGridViewObservations)
        Me.Name = "frmModifyObservations"
        CType(Me.DataGridViewObservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBxSelection.ResumeLayout(False)
        Me.GrBxSelection.PerformLayout()
        Me.GrBxCommands.ResumeLayout(False)
        Me.GrBxDataBase.ResumeLayout(False)
        Me.GrBxDataBase.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewObservations As System.Windows.Forms.DataGridView
    Friend WithEvents GrBxSelection As System.Windows.Forms.GroupBox
    Friend WithEvents txtEndMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtStartMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtEndYear As System.Windows.Forms.TextBox
    Friend WithEvents txtStartYear As System.Windows.Forms.TextBox
    Friend WithEvents txtElement As System.Windows.Forms.TextBox
    Friend WithEvents txtStation As System.Windows.Forms.TextBox
    Friend WithEvents lblEndMonth As System.Windows.Forms.Label
    Friend WithEvents lblStartMonth As System.Windows.Forms.Label
    Friend WithEvents lblEndYear As System.Windows.Forms.Label
    Friend WithEvents lblStartYear As System.Windows.Forms.Label
    Friend WithEvents lblElement As System.Windows.Forms.Label
    Friend WithEvents lblSation As System.Windows.Forms.Label
    Friend WithEvents GrBxCommands As System.Windows.Forms.GroupBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdUpade As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents GrBxDataBase As System.Windows.Forms.GroupBox
    Friend WithEvents optFinal As System.Windows.Forms.RadioButton
    Friend WithEvents optInitial As System.Windows.Forms.RadioButton
    Friend WithEvents lblrecords As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtEndHour As System.Windows.Forms.TextBox
    Friend WithEvents txtStartHour As System.Windows.Forms.TextBox
    Friend WithEvents lblEndHour As System.Windows.Forms.Label
    Friend WithEvents lblStartHour As System.Windows.Forms.Label
    Friend WithEvents txtEndDay As System.Windows.Forms.TextBox
    Friend WithEvents txtStartDay As System.Windows.Forms.TextBox
    Friend WithEvents lblEndDay As System.Windows.Forms.Label
    Friend WithEvents lblStartDay As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As BindingSource
End Class
