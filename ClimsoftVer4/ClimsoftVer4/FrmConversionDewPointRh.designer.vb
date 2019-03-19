<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConversionDewPointRh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConversionDewPointRh))
        Me.drybuld = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblTT = New System.Windows.Forms.Label()
        Me.humidity = New System.Windows.Forms.TextBox()
        Me.wetbulb = New System.Windows.Forms.TextBox()
        Me.dewpoint = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTw = New System.Windows.Forms.Label()
        Me.lblTd = New System.Windows.Forms.Label()
        Me.lblRH = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'drybuld
        '
        resources.ApplyResources(Me.drybuld, "drybuld")
        Me.drybuld.Name = "drybuld"
        '
        'btnOK
        '
        resources.ApplyResources(Me.btnOK, "btnOK")
        Me.btnOK.Name = "btnOK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblTT
        '
        resources.ApplyResources(Me.lblTT, "lblTT")
        Me.lblTT.Name = "lblTT"
        '
        'humidity
        '
        resources.ApplyResources(Me.humidity, "humidity")
        Me.humidity.Name = "humidity"
        '
        'wetbulb
        '
        resources.ApplyResources(Me.wetbulb, "wetbulb")
        Me.wetbulb.Name = "wetbulb"
        '
        'dewpoint
        '
        resources.ApplyResources(Me.dewpoint, "dewpoint")
        Me.dewpoint.Name = "dewpoint"
        '
        'btnClose
        '
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.Name = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTw
        '
        resources.ApplyResources(Me.lblTw, "lblTw")
        Me.lblTw.Name = "lblTw"
        '
        'lblTd
        '
        resources.ApplyResources(Me.lblTd, "lblTd")
        Me.lblTd.Name = "lblTd"
        '
        'lblRH
        '
        resources.ApplyResources(Me.lblRH, "lblRH")
        Me.lblRH.Name = "lblRH"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Name = "Label1"
        '
        'FrmConversionDewPointRh
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRH)
        Me.Controls.Add(Me.lblTd)
        Me.Controls.Add(Me.lblTw)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dewpoint)
        Me.Controls.Add(Me.wetbulb)
        Me.Controls.Add(Me.humidity)
        Me.Controls.Add(Me.lblTT)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.drybuld)
        Me.Name = "FrmConversionDewPointRh"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents drybuld As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents lblTT As Label
    Friend WithEvents humidity As TextBox
    Friend WithEvents wetbulb As TextBox
    Friend WithEvents dewpoint As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTw As Label
    Friend WithEvents lblTd As Label
    Friend WithEvents lblRH As Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
