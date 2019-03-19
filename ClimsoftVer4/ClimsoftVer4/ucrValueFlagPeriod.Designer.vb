<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrValueFlagPeriod
    Inherits ClimsoftVer4.ucrBaseDataLink

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrValueFlagPeriod))
        Me.ucrValue = New ClimsoftVer4.ucrTextBox()
        Me.ucrFlag = New ClimsoftVer4.ucrTextBox()
        Me.ucrPeriod = New ClimsoftVer4.ucrTextBox()
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrValue
        '
        resources.ApplyResources(Me.ucrValue, "ucrValue")
        Me.ucrValue.Name = "ucrValue"
        Me.ucrValue.TextboxValue = ""
        '
        'ucrFlag
        '
        resources.ApplyResources(Me.ucrFlag, "ucrFlag")
        Me.ucrFlag.Name = "ucrFlag"
        Me.ucrFlag.TextboxValue = ""
        '
        'ucrPeriod
        '
        resources.ApplyResources(Me.ucrPeriod, "ucrPeriod")
        Me.ucrPeriod.Name = "ucrPeriod"
        Me.ucrPeriod.TextboxValue = ""
        '
        'ucrValueFlagPeriod
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrPeriod)
        Me.Controls.Add(Me.ucrFlag)
        Me.Controls.Add(Me.ucrValue)
        Me.Name = "ucrValueFlagPeriod"
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrValue As ucrTextBox
    Friend WithEvents ucrFlag As ucrTextBox
    Friend WithEvents ucrPeriod As ucrTextBox
End Class
