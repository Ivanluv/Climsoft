<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrNavigation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrNavigation))
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.txtRecNum = New System.Windows.Forms.TextBox()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'txtRecNum
        '
        resources.ApplyResources(Me.txtRecNum, "txtRecNum")
        Me.txtRecNum.Name = "txtRecNum"
        '
        'btnMoveNext
        '
        resources.ApplyResources(Me.btnMoveNext, "btnMoveNext")
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'ucrNavigation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnMovePrevious)
        Me.Controls.Add(Me.btnMoveFirst)
        Me.Controls.Add(Me.btnMoveLast)
        Me.Controls.Add(Me.txtRecNum)
        Me.Controls.Add(Me.btnMoveNext)
        Me.Name = "ucrNavigation"
        CType(Me.dtbRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMovePrevious As Button
    Friend WithEvents btnMoveFirst As Button
    Friend WithEvents btnMoveLast As Button
    Friend WithEvents txtRecNum As TextBox
    Friend WithEvents btnMoveNext As Button
End Class
