<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrDirectionSpeedFlag
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrDirectionSpeedFlag))
        Me.ucrDirection = New ClimsoftVer4.ucrTextBox()
        Me.ucrSpeed = New ClimsoftVer4.ucrTextBox()
        Me.ucrFlag = New ClimsoftVer4.ucrTextBox()
        Me.ucrDDFF = New ClimsoftVer4.ucrTextBox()
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrDirection
        '
        resources.ApplyResources(Me.ucrDirection, "ucrDirection")
        Me.ucrDirection.Name = "ucrDirection"
        Me.ucrDirection.TextboxValue = ""
        '
        'ucrSpeed
        '
        resources.ApplyResources(Me.ucrSpeed, "ucrSpeed")
        Me.ucrSpeed.Name = "ucrSpeed"
        Me.ucrSpeed.TextboxValue = ""
        '
        'ucrFlag
        '
        resources.ApplyResources(Me.ucrFlag, "ucrFlag")
        Me.ucrFlag.Name = "ucrFlag"
        Me.ucrFlag.TextboxValue = ""
        '
        'ucrDDFF
        '
        resources.ApplyResources(Me.ucrDDFF, "ucrDDFF")
        Me.ucrDDFF.Name = "ucrDDFF"
        Me.ucrDDFF.TextboxValue = ""
        '
        'ucrDirectionSpeedFlag
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrDDFF)
        Me.Controls.Add(Me.ucrFlag)
        Me.Controls.Add(Me.ucrSpeed)
        Me.Controls.Add(Me.ucrDirection)
        Me.Name = "ucrDirectionSpeedFlag"
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrDirection As ucrTextBox
    Friend WithEvents ucrSpeed As ucrTextBox
    Friend WithEvents ucrFlag As ucrTextBox
    Friend WithEvents ucrDDFF As ucrTextBox
End Class
