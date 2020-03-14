<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuake
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
        Me.mapCb = New System.Windows.Forms.ComboBox()
        Me.takePhotoButton = New System.Windows.Forms.Button()
        Me.MainScreenCapture = New System.Windows.Forms.PictureBox()
        Me.MatchedSpawnCapture = New System.Windows.Forms.PictureBox()
        Me.mainCaptureTimer = New System.Windows.Forms.Timer(Me.components)
        Me.testRoutineButton = New System.Windows.Forms.Button()
        Me.similarityLabelLabel = New System.Windows.Forms.Label()
        Me.teamCb = New System.Windows.Forms.ComboBox()
        Me.mapLabel = New System.Windows.Forms.Label()
        Me.teamLabel = New System.Windows.Forms.Label()
        Me.similarityLabel = New System.Windows.Forms.Label()
        Me.spawnLabel = New System.Windows.Forms.Label()
        Me.startButton = New System.Windows.Forms.Button()
        Me.controllerLabel = New System.Windows.Forms.Label()
        Me.controllerStateLabel = New System.Windows.Forms.Label()
        Me.matchSpawnButton = New System.Windows.Forms.Button()
        Me.deviceLabel = New System.Windows.Forms.Label()
        Me.deviceCb = New System.Windows.Forms.ComboBox()
        Me.ControllerTextLabel = New System.Windows.Forms.Label()
        Me.controllerCb = New System.Windows.Forms.ComboBox()
        CType(Me.MainScreenCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatchedSpawnCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mapCb
        '
        Me.mapCb.Cursor = System.Windows.Forms.Cursors.Default
        Me.mapCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mapCb.ForeColor = System.Drawing.Color.Black
        Me.mapCb.FormattingEnabled = True
        Me.mapCb.Items.AddRange(New Object() {"death_before_dishonor", "heartless", "relativity", "speed_trap"})
        Me.mapCb.Location = New System.Drawing.Point(229, 73)
        Me.mapCb.Name = "mapCb"
        Me.mapCb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mapCb.Size = New System.Drawing.Size(214, 21)
        Me.mapCb.TabIndex = 0
        '
        'takePhotoButton
        '
        Me.takePhotoButton.Location = New System.Drawing.Point(798, 315)
        Me.takePhotoButton.Name = "takePhotoButton"
        Me.takePhotoButton.Size = New System.Drawing.Size(82, 23)
        Me.takePhotoButton.TabIndex = 1
        Me.takePhotoButton.Text = "Take Photo"
        Me.takePhotoButton.UseVisualStyleBackColor = True
        '
        'MainScreenCapture
        '
        Me.MainScreenCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainScreenCapture.Location = New System.Drawing.Point(12, 218)
        Me.MainScreenCapture.Name = "MainScreenCapture"
        Me.MainScreenCapture.Size = New System.Drawing.Size(720, 405)
        Me.MainScreenCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainScreenCapture.TabIndex = 2
        Me.MainScreenCapture.TabStop = False
        '
        'MatchedSpawnCapture
        '
        Me.MatchedSpawnCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MatchedSpawnCapture.Location = New System.Drawing.Point(765, 363)
        Me.MatchedSpawnCapture.Name = "MatchedSpawnCapture"
        Me.MatchedSpawnCapture.Size = New System.Drawing.Size(144, 124)
        Me.MatchedSpawnCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MatchedSpawnCapture.TabIndex = 3
        Me.MatchedSpawnCapture.TabStop = False
        '
        'mainCaptureTimer
        '
        Me.mainCaptureTimer.Interval = 33
        '
        'testRoutineButton
        '
        Me.testRoutineButton.Location = New System.Drawing.Point(798, 286)
        Me.testRoutineButton.Name = "testRoutineButton"
        Me.testRoutineButton.Size = New System.Drawing.Size(82, 23)
        Me.testRoutineButton.TabIndex = 4
        Me.testRoutineButton.Text = "Test Routine"
        Me.testRoutineButton.UseVisualStyleBackColor = True
        '
        'similarityLabelLabel
        '
        Me.similarityLabelLabel.AutoSize = True
        Me.similarityLabelLabel.Location = New System.Drawing.Point(762, 502)
        Me.similarityLabelLabel.Name = "similarityLabelLabel"
        Me.similarityLabelLabel.Size = New System.Drawing.Size(47, 13)
        Me.similarityLabelLabel.TabIndex = 5
        Me.similarityLabelLabel.Text = "Similarity"
        '
        'teamCb
        '
        Me.teamCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.teamCb.FormattingEnabled = True
        Me.teamCb.Items.AddRange(New Object() {"marine", "strogg"})
        Me.teamCb.Location = New System.Drawing.Point(229, 118)
        Me.teamCb.Name = "teamCb"
        Me.teamCb.Size = New System.Drawing.Size(214, 21)
        Me.teamCb.TabIndex = 6
        '
        'mapLabel
        '
        Me.mapLabel.AutoSize = True
        Me.mapLabel.Location = New System.Drawing.Point(226, 57)
        Me.mapLabel.Name = "mapLabel"
        Me.mapLabel.Size = New System.Drawing.Size(28, 13)
        Me.mapLabel.TabIndex = 7
        Me.mapLabel.Text = "Map"
        '
        'teamLabel
        '
        Me.teamLabel.AutoSize = True
        Me.teamLabel.Location = New System.Drawing.Point(226, 102)
        Me.teamLabel.Name = "teamLabel"
        Me.teamLabel.Size = New System.Drawing.Size(34, 13)
        Me.teamLabel.TabIndex = 8
        Me.teamLabel.Text = "Team"
        '
        'similarityLabel
        '
        Me.similarityLabel.AutoSize = True
        Me.similarityLabel.Location = New System.Drawing.Point(832, 502)
        Me.similarityLabel.Name = "similarityLabel"
        Me.similarityLabel.Size = New System.Drawing.Size(0, 13)
        Me.similarityLabel.TabIndex = 9
        '
        'spawnLabel
        '
        Me.spawnLabel.AutoSize = True
        Me.spawnLabel.Location = New System.Drawing.Point(795, 344)
        Me.spawnLabel.Name = "spawnLabel"
        Me.spawnLabel.Size = New System.Drawing.Size(0, 13)
        Me.spawnLabel.TabIndex = 10
        Me.spawnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(272, 155)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(127, 45)
        Me.startButton.TabIndex = 11
        Me.startButton.Text = "Suicide Squad"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'controllerLabel
        '
        Me.controllerLabel.AutoSize = True
        Me.controllerLabel.Location = New System.Drawing.Point(762, 558)
        Me.controllerLabel.Name = "controllerLabel"
        Me.controllerLabel.Size = New System.Drawing.Size(51, 13)
        Me.controllerLabel.TabIndex = 12
        Me.controllerLabel.Text = "Controller"
        '
        'controllerStateLabel
        '
        Me.controllerStateLabel.AutoSize = True
        Me.controllerStateLabel.Location = New System.Drawing.Point(832, 558)
        Me.controllerStateLabel.Name = "controllerStateLabel"
        Me.controllerStateLabel.Size = New System.Drawing.Size(0, 13)
        Me.controllerStateLabel.TabIndex = 13
        '
        'matchSpawnButton
        '
        Me.matchSpawnButton.Location = New System.Drawing.Point(798, 257)
        Me.matchSpawnButton.Name = "matchSpawnButton"
        Me.matchSpawnButton.Size = New System.Drawing.Size(82, 23)
        Me.matchSpawnButton.TabIndex = 14
        Me.matchSpawnButton.Text = "Match Spawn"
        Me.matchSpawnButton.UseVisualStyleBackColor = True
        '
        'deviceLabel
        '
        Me.deviceLabel.AutoSize = True
        Me.deviceLabel.Location = New System.Drawing.Point(226, 10)
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
        Me.deviceCb.Location = New System.Drawing.Point(229, 26)
        Me.deviceCb.Name = "deviceCb"
        Me.deviceCb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.deviceCb.Size = New System.Drawing.Size(214, 21)
        Me.deviceCb.TabIndex = 15
        '
        'ControllerTextLabel
        '
        Me.ControllerTextLabel.AutoSize = True
        Me.ControllerTextLabel.Location = New System.Drawing.Point(468, 10)
        Me.ControllerTextLabel.Name = "ControllerTextLabel"
        Me.ControllerTextLabel.Size = New System.Drawing.Size(51, 13)
        Me.ControllerTextLabel.TabIndex = 18
        Me.ControllerTextLabel.Text = "Controller"
        '
        'controllerCb
        '
        Me.controllerCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.controllerCb.FormattingEnabled = True
        Me.controllerCb.Items.AddRange(New Object() {"CM", "CM2", "CM3"})
        Me.controllerCb.Location = New System.Drawing.Point(471, 26)
        Me.controllerCb.Name = "controllerCb"
        Me.controllerCb.Size = New System.Drawing.Size(58, 21)
        Me.controllerCb.TabIndex = 21
        '
        'frmQuake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 635)
        Me.Controls.Add(Me.controllerCb)
        Me.Controls.Add(Me.ControllerTextLabel)
        Me.Controls.Add(Me.deviceLabel)
        Me.Controls.Add(Me.deviceCb)
        Me.Controls.Add(Me.matchSpawnButton)
        Me.Controls.Add(Me.controllerStateLabel)
        Me.Controls.Add(Me.controllerLabel)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.spawnLabel)
        Me.Controls.Add(Me.similarityLabel)
        Me.Controls.Add(Me.teamLabel)
        Me.Controls.Add(Me.mapLabel)
        Me.Controls.Add(Me.teamCb)
        Me.Controls.Add(Me.similarityLabelLabel)
        Me.Controls.Add(Me.testRoutineButton)
        Me.Controls.Add(Me.MatchedSpawnCapture)
        Me.Controls.Add(Me.MainScreenCapture)
        Me.Controls.Add(Me.takePhotoButton)
        Me.Controls.Add(Me.mapCb)
        Me.Name = "frmQuake"
        Me.Text = "Quake 4 Booster"
        CType(Me.MainScreenCapture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatchedSpawnCapture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mapCb As ComboBox
    Friend WithEvents takePhotoButton As Button
    Friend WithEvents MainScreenCapture As PictureBox
    Friend WithEvents MatchedSpawnCapture As PictureBox
    Friend WithEvents mainCaptureTimer As Timer
    Friend WithEvents testRoutineButton As Button
    Friend WithEvents similarityLabelLabel As Label
    Friend WithEvents teamCb As ComboBox
    Friend WithEvents mapLabel As Label
    Friend WithEvents teamLabel As Label
    Friend WithEvents similarityLabel As Label
    Friend WithEvents spawnLabel As Label
    Friend WithEvents startButton As Button
    Friend WithEvents controllerLabel As Label
    Friend WithEvents controllerStateLabel As Label
    Friend WithEvents matchSpawnButton As Button
    Friend WithEvents deviceLabel As Label
    Friend WithEvents deviceCb As ComboBox
    Friend WithEvents ControllerTextLabel As Label
    Friend WithEvents controllerCb As ComboBox
End Class
