<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCaptureViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.MainScreenCapture = New System.Windows.Forms.PictureBox()
        Me.mainCaptureTimer = New System.Windows.Forms.Timer(Me.components)
        Me.deviceLabel = New System.Windows.Forms.Label()
        Me.deviceCb = New System.Windows.Forms.ComboBox()
        CType(Me.MainScreenCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainScreenCapture
        '
        Me.MainScreenCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainScreenCapture.Location = New System.Drawing.Point(12, 59)
        Me.MainScreenCapture.Name = "MainScreenCapture"
        Me.MainScreenCapture.Size = New System.Drawing.Size(960, 540)
        Me.MainScreenCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainScreenCapture.TabIndex = 2
        Me.MainScreenCapture.TabStop = False
        '
        'mainCaptureTimer
        '
        Me.mainCaptureTimer.Interval = 33
        '
        'deviceLabel
        '
        Me.deviceLabel.AutoSize = True
        Me.deviceLabel.Location = New System.Drawing.Point(382, 9)
        Me.deviceLabel.Name = "deviceLabel"
        Me.deviceLabel.Size = New System.Drawing.Size(81, 13)
        Me.deviceLabel.TabIndex = 16
        Me.deviceLabel.Text = "Capture Device"
        '
        'deviceCb
        '
        Me.deviceCb.Cursor = System.Windows.Forms.Cursors.Default
        Me.deviceCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.deviceCb.ForeColor = System.Drawing.Color.Black
        Me.deviceCb.FormattingEnabled = True
        Me.deviceCb.Items.AddRange(New Object() {"death_before_dishonor", "heartless", "relativity", "speed_trap"})
        Me.deviceCb.Location = New System.Drawing.Point(385, 26)
        Me.deviceCb.Name = "deviceCb"
        Me.deviceCb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.deviceCb.Size = New System.Drawing.Size(214, 21)
        Me.deviceCb.TabIndex = 15
        '
        'frmCaptureViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 611)
        Me.Controls.Add(Me.deviceLabel)
        Me.Controls.Add(Me.deviceCb)
        Me.Controls.Add(Me.MainScreenCapture)
        Me.Name = "frmCaptureViewer"
        Me.Text = "Capture Card Viewer"
        CType(Me.MainScreenCapture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainScreenCapture As PictureBox
    Friend WithEvents mainCaptureTimer As Timer
    Friend WithEvents deviceLabel As Label
    Friend WithEvents deviceCb As ComboBox
End Class
