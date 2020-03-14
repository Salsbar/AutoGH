<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraw
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
        Me.MainScreenCapture = New System.Windows.Forms.PictureBox()
        Me.matchSpawnButton = New System.Windows.Forms.Button()
        Me.controllerStateLabel = New System.Windows.Forms.Label()
        Me.controllerLabel = New System.Windows.Forms.Label()
        Me.spawnLabel = New System.Windows.Forms.Label()
        Me.similarityLabel = New System.Windows.Forms.Label()
        Me.similarityLabelLabel = New System.Windows.Forms.Label()
        Me.testRoutineButton = New System.Windows.Forms.Button()
        Me.MatchedSpawnCapture = New System.Windows.Forms.PictureBox()
        Me.takePhotoButton = New System.Windows.Forms.Button()
        Me.startButton = New System.Windows.Forms.Button()
        Me.mainCaptureTimer = New System.Windows.Forms.Timer(Me.components)
        Me.modeTextLabel = New System.Windows.Forms.Label()
        Me.modeLabel = New System.Windows.Forms.Label()
        Me.gamesLabel = New System.Windows.Forms.Label()
        Me.gamesTextBox = New System.Windows.Forms.TextBox()
        Me.controllerCb = New System.Windows.Forms.ComboBox()
        Me.ControllerTextLabel = New System.Windows.Forms.Label()
        Me.deviceLabel = New System.Windows.Forms.Label()
        Me.deviceCb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.MainScreenCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatchedSpawnCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainScreenCapture
        '
        Me.MainScreenCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainScreenCapture.Location = New System.Drawing.Point(12, 12)
        Me.MainScreenCapture.Name = "MainScreenCapture"
        Me.MainScreenCapture.Size = New System.Drawing.Size(960, 540)
        Me.MainScreenCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainScreenCapture.TabIndex = 3
        Me.MainScreenCapture.TabStop = False
        '
        'matchSpawnButton
        '
        Me.matchSpawnButton.Location = New System.Drawing.Point(1061, 256)
        Me.matchSpawnButton.Name = "matchSpawnButton"
        Me.matchSpawnButton.Size = New System.Drawing.Size(82, 23)
        Me.matchSpawnButton.TabIndex = 23
        Me.matchSpawnButton.Text = "Match Spawn"
        Me.matchSpawnButton.UseVisualStyleBackColor = True
        '
        'controllerStateLabel
        '
        Me.controllerStateLabel.AutoSize = True
        Me.controllerStateLabel.Location = New System.Drawing.Point(1058, 538)
        Me.controllerStateLabel.Name = "controllerStateLabel"
        Me.controllerStateLabel.Size = New System.Drawing.Size(0, 13)
        Me.controllerStateLabel.TabIndex = 22
        '
        'controllerLabel
        '
        Me.controllerLabel.AutoSize = True
        Me.controllerLabel.Location = New System.Drawing.Point(989, 533)
        Me.controllerLabel.Name = "controllerLabel"
        Me.controllerLabel.Size = New System.Drawing.Size(51, 13)
        Me.controllerLabel.TabIndex = 21
        Me.controllerLabel.Text = "Controller"
        '
        'spawnLabel
        '
        Me.spawnLabel.AutoSize = True
        Me.spawnLabel.Location = New System.Drawing.Point(1065, 348)
        Me.spawnLabel.Name = "spawnLabel"
        Me.spawnLabel.Size = New System.Drawing.Size(0, 13)
        Me.spawnLabel.TabIndex = 20
        Me.spawnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'similarityLabel
        '
        Me.similarityLabel.AutoSize = True
        Me.similarityLabel.Location = New System.Drawing.Point(1090, 506)
        Me.similarityLabel.Name = "similarityLabel"
        Me.similarityLabel.Size = New System.Drawing.Size(0, 13)
        Me.similarityLabel.TabIndex = 19
        '
        'similarityLabelLabel
        '
        Me.similarityLabelLabel.AutoSize = True
        Me.similarityLabelLabel.Location = New System.Drawing.Point(989, 506)
        Me.similarityLabelLabel.Name = "similarityLabelLabel"
        Me.similarityLabelLabel.Size = New System.Drawing.Size(47, 13)
        Me.similarityLabelLabel.TabIndex = 18
        Me.similarityLabelLabel.Text = "Similarity"
        '
        'testRoutineButton
        '
        Me.testRoutineButton.Location = New System.Drawing.Point(1061, 285)
        Me.testRoutineButton.Name = "testRoutineButton"
        Me.testRoutineButton.Size = New System.Drawing.Size(82, 23)
        Me.testRoutineButton.TabIndex = 17
        Me.testRoutineButton.Text = "Test Routine"
        Me.testRoutineButton.UseVisualStyleBackColor = True
        '
        'MatchedSpawnCapture
        '
        Me.MatchedSpawnCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MatchedSpawnCapture.Location = New System.Drawing.Point(1066, 369)
        Me.MatchedSpawnCapture.Name = "MatchedSpawnCapture"
        Me.MatchedSpawnCapture.Size = New System.Drawing.Size(72, 124)
        Me.MatchedSpawnCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MatchedSpawnCapture.TabIndex = 16
        Me.MatchedSpawnCapture.TabStop = False
        '
        'takePhotoButton
        '
        Me.takePhotoButton.Location = New System.Drawing.Point(1061, 314)
        Me.takePhotoButton.Name = "takePhotoButton"
        Me.takePhotoButton.Size = New System.Drawing.Size(82, 23)
        Me.takePhotoButton.TabIndex = 15
        Me.takePhotoButton.Text = "Take Photo"
        Me.takePhotoButton.UseVisualStyleBackColor = True
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(992, 131)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(214, 35)
        Me.startButton.TabIndex = 24
        Me.startButton.Text = "Start Boosting"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'mainCaptureTimer
        '
        Me.mainCaptureTimer.Interval = 20
        '
        'modeTextLabel
        '
        Me.modeTextLabel.AutoSize = True
        Me.modeTextLabel.Location = New System.Drawing.Point(1101, 187)
        Me.modeTextLabel.Name = "modeTextLabel"
        Me.modeTextLabel.Size = New System.Drawing.Size(0, 13)
        Me.modeTextLabel.TabIndex = 26
        '
        'modeLabel
        '
        Me.modeLabel.AutoSize = True
        Me.modeLabel.Location = New System.Drawing.Point(989, 187)
        Me.modeLabel.Name = "modeLabel"
        Me.modeLabel.Size = New System.Drawing.Size(34, 13)
        Me.modeLabel.TabIndex = 25
        Me.modeLabel.Text = "Mode"
        '
        'gamesLabel
        '
        Me.gamesLabel.AutoSize = True
        Me.gamesLabel.Location = New System.Drawing.Point(989, 210)
        Me.gamesLabel.Name = "gamesLabel"
        Me.gamesLabel.Size = New System.Drawing.Size(40, 13)
        Me.gamesLabel.TabIndex = 27
        Me.gamesLabel.Text = "Games"
        '
        'gamesTextBox
        '
        Me.gamesTextBox.Location = New System.Drawing.Point(1080, 207)
        Me.gamesTextBox.Name = "gamesTextBox"
        Me.gamesTextBox.Size = New System.Drawing.Size(45, 20)
        Me.gamesTextBox.TabIndex = 29
        '
        'controllerCb
        '
        Me.controllerCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.controllerCb.FormattingEnabled = True
        Me.controllerCb.Items.AddRange(New Object() {"CM", "CM2", "CM3"})
        Me.controllerCb.Location = New System.Drawing.Point(992, 88)
        Me.controllerCb.Name = "controllerCb"
        Me.controllerCb.Size = New System.Drawing.Size(58, 21)
        Me.controllerCb.TabIndex = 33
        '
        'ControllerTextLabel
        '
        Me.ControllerTextLabel.AutoSize = True
        Me.ControllerTextLabel.Location = New System.Drawing.Point(989, 72)
        Me.ControllerTextLabel.Name = "ControllerTextLabel"
        Me.ControllerTextLabel.Size = New System.Drawing.Size(51, 13)
        Me.ControllerTextLabel.TabIndex = 32
        Me.ControllerTextLabel.Text = "Controller"
        '
        'deviceLabel
        '
        Me.deviceLabel.AutoSize = True
        Me.deviceLabel.Location = New System.Drawing.Point(989, 22)
        Me.deviceLabel.Name = "deviceLabel"
        Me.deviceLabel.Size = New System.Drawing.Size(81, 13)
        Me.deviceLabel.TabIndex = 31
        Me.deviceLabel.Text = "Capture Device"
        '
        'deviceCb
        '
        Me.deviceCb.Cursor = System.Windows.Forms.Cursors.Default
        Me.deviceCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.deviceCb.ForeColor = System.Drawing.Color.Black
        Me.deviceCb.FormattingEnabled = True
        Me.deviceCb.Items.AddRange(New Object() {"death_before_dishonor", "heartless", "relativity", "speed_trap"})
        Me.deviceCb.Location = New System.Drawing.Point(992, 38)
        Me.deviceCb.Name = "deviceCb"
        Me.deviceCb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.deviceCb.Size = New System.Drawing.Size(214, 21)
        Me.deviceCb.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1070, 348)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGraw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 564)
        Me.Controls.Add(Me.controllerCb)
        Me.Controls.Add(Me.ControllerTextLabel)
        Me.Controls.Add(Me.deviceLabel)
        Me.Controls.Add(Me.deviceCb)
        Me.Controls.Add(Me.gamesTextBox)
        Me.Controls.Add(Me.gamesLabel)
        Me.Controls.Add(Me.modeTextLabel)
        Me.Controls.Add(Me.modeLabel)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.matchSpawnButton)
        Me.Controls.Add(Me.controllerStateLabel)
        Me.Controls.Add(Me.controllerLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.spawnLabel)
        Me.Controls.Add(Me.similarityLabel)
        Me.Controls.Add(Me.similarityLabelLabel)
        Me.Controls.Add(Me.testRoutineButton)
        Me.Controls.Add(Me.MatchedSpawnCapture)
        Me.Controls.Add(Me.takePhotoButton)
        Me.Controls.Add(Me.MainScreenCapture)
        Me.Name = "frmGraw"
        Me.Text = "GRAW Booster"
        CType(Me.MainScreenCapture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatchedSpawnCapture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainScreenCapture As PictureBox
    Friend WithEvents matchSpawnButton As Button
    Friend WithEvents controllerStateLabel As Label
    Friend WithEvents controllerLabel As Label
    Friend WithEvents spawnLabel As Label
    Friend WithEvents similarityLabel As Label
    Friend WithEvents similarityLabelLabel As Label
    Friend WithEvents testRoutineButton As Button
    Friend WithEvents MatchedSpawnCapture As PictureBox
    Friend WithEvents takePhotoButton As Button
    Friend WithEvents startButton As Button
    Friend WithEvents mainCaptureTimer As Timer
    Friend WithEvents modeTextLabel As Label
    Friend WithEvents modeLabel As Label
    Friend WithEvents gamesLabel As Label
    Friend WithEvents gamesTextBox As TextBox
    Friend WithEvents controllerCb As ComboBox
    Friend WithEvents ControllerTextLabel As Label
    Friend WithEvents deviceLabel As Label
    Friend WithEvents deviceCb As ComboBox
    Friend WithEvents Label1 As Label
End Class
