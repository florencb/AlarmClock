<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblTimeDisplay = New System.Windows.Forms.Label()
        Me.txtAlarmTime = New System.Windows.Forms.TextBox()
        Me.tmrDisplayTIme = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAlarm = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBeep = New System.Windows.Forms.Timer(Me.components)
        Me.btnSetAlarm = New System.Windows.Forms.Button()
        Me.btnStopAlarm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTimeDisplay
        '
        Me.lblTimeDisplay.AutoSize = True
        Me.lblTimeDisplay.Font = New System.Drawing.Font("Courier New", 24.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeDisplay.ForeColor = System.Drawing.Color.GreenYellow
        Me.lblTimeDisplay.Location = New System.Drawing.Point(50, 27)
        Me.lblTimeDisplay.Name = "lblTimeDisplay"
        Me.lblTimeDisplay.Size = New System.Drawing.Size(137, 38)
        Me.lblTimeDisplay.TabIndex = 0
        Me.lblTimeDisplay.Text = "Label1"
        '
        'txtAlarmTime
        '
        Me.txtAlarmTime.Location = New System.Drawing.Point(67, 88)
        Me.txtAlarmTime.Name = "txtAlarmTime"
        Me.txtAlarmTime.Size = New System.Drawing.Size(150, 20)
        Me.txtAlarmTime.TabIndex = 1
        '
        'tmrDisplayTIme
        '
        Me.tmrDisplayTIme.Enabled = True
        '
        'tmrAlarm
        '
        '
        'tmrBeep
        '
        '
        'btnSetAlarm
        '
        Me.btnSetAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetAlarm.ForeColor = System.Drawing.Color.Gold
        Me.btnSetAlarm.Location = New System.Drawing.Point(33, 140)
        Me.btnSetAlarm.Name = "btnSetAlarm"
        Me.btnSetAlarm.Size = New System.Drawing.Size(75, 23)
        Me.btnSetAlarm.TabIndex = 2
        Me.btnSetAlarm.Text = "Set Alarm"
        Me.btnSetAlarm.UseVisualStyleBackColor = True
        '
        'btnStopAlarm
        '
        Me.btnStopAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopAlarm.ForeColor = System.Drawing.Color.Gold
        Me.btnStopAlarm.Location = New System.Drawing.Point(176, 140)
        Me.btnStopAlarm.Name = "btnStopAlarm"
        Me.btnStopAlarm.Size = New System.Drawing.Size(75, 23)
        Me.btnStopAlarm.TabIndex = 3
        Me.btnStopAlarm.Text = "Stop "
        Me.btnStopAlarm.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 189)
        Me.Controls.Add(Me.btnStopAlarm)
        Me.Controls.Add(Me.btnSetAlarm)
        Me.Controls.Add(Me.txtAlarmTime)
        Me.Controls.Add(Me.lblTimeDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarm Clock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTimeDisplay As System.Windows.Forms.Label
    Friend WithEvents txtAlarmTime As System.Windows.Forms.TextBox
    Friend WithEvents tmrDisplayTIme As System.Windows.Forms.Timer
    Friend WithEvents tmrAlarm As System.Windows.Forms.Timer
    Friend WithEvents tmrBeep As System.Windows.Forms.Timer
    Friend WithEvents btnSetAlarm As System.Windows.Forms.Button
    Friend WithEvents btnStopAlarm As System.Windows.Forms.Button

End Class
