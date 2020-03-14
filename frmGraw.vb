Imports XnaFan.ImageComparison
Imports System.Xml
Imports DirectShowLib

Public Class frmGraw

    Dim snap As clsSnapshot
    Dim loadedBmps As New ArrayList
    Dim controllerIPS As New Dictionary(Of Byte, String)
    Dim activeScript As clsScript
    Dim isRunning = False

    Dim mode = True
    Dim GAME_COUNT = 70
    Dim currentGameCount = GAME_COUNT

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim capDevices() As DsDevice = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice)

        If capDevices.Length = 0 Then
            MsgBox("No capture devices found")
            Exit Sub
        End If
        deviceCb.Items.Clear()
        deviceCb.DisplayMember = "Name"
        For Each dev In capDevices
            deviceCb.Items.Add(dev)
        Next
    End Sub

    Private Sub frmGraw_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not snap Is Nothing Then snap.Dispose()

        disposeImages()
    End Sub

    Private Sub disposeImages()
        For Each bmp In loadedBmps
            bmp.Dispose()
        Next
        loadedBmps.Clear()
    End Sub

    Private Sub takePhotoButton_Click(sender As Object, e As EventArgs) Handles takePhotoButton.Click
        Dim filePath = "graw\images"

        Dim fis() As IO.FileInfo = (New IO.DirectoryInfo(filePath)).GetFiles()
        Dim imgIdx = fis.Length + 1

        Dim bmp As Bitmap = cropImage(MainScreenCapture.Image)
        bmp.Save(filePath & "\spawn" & imgIdx.ToString("D6") & ".png", System.Drawing.Imaging.ImageFormat.Png)

        'Dim scriptPath = "graw\leaderboard_boost_boneyard.axb"
        'activeScript = loadScriptXML(scriptPath, "kys")
        'activeScript.startScript()

    End Sub

    Private Sub mainCaptureTimer_Tick(sender As Object, e As EventArgs) Handles mainCaptureTimer.Tick
        Dim oldImage As Image = MainScreenCapture.Image
        MainScreenCapture.Image = snap.capture
        If Not oldImage Is Nothing Then oldImage.Dispose()
        MainScreenCapture.Refresh()

        If activeScript IsNot Nothing Then
            controllerStateLabel.Text = activeScript.state.ToString
        End If

        If mode Then
            modeTextLabel.Text = "solo"
        Else
            modeTextLabel.Text = "team"
        End If

        gamesTextBox.Text = currentGameCount
    End Sub

    Private Sub testRoutine_Click(sender As Object, e As EventArgs) Handles testRoutineButton.Click
        runScriptForCurrentSpawn()
    End Sub

    Private Sub loadSpawnImages()
        Dim fis() As IO.FileInfo = (New IO.DirectoryInfo("graw\images")).GetFiles()

        If loadedBmps.Count <> fis.Length Then
            loadedBmps.Clear()

            For Each fi As IO.FileInfo In fis
                Dim bmp = Image.FromFile(fi.FullName)
                bmp.Tag = fi.Name
                loadedBmps.Add(bmp)
            Next
        End If
    End Sub

    Private Sub runScriptForCurrentSpawn()
        Dim scriptPath = "graw\leaderboard_boost_boneyard.axb"
        activeScript = loadScriptXML(scriptPath, spawnLabel.Text)
        activeScript.startScript()
    End Sub

    Private Sub matchSpawn()
        Dim bestBmp As Bitmap
        Dim bestSimilarity = 0
        Dim sim As Double

        For Each bmp As Bitmap In loadedBmps
            sim = imgSimilarity(cropImage(MainScreenCapture.Image), bmp)
            'Debug.Print(sim.ToString)
            If sim <= bestSimilarity Then
                Continue For
            End If

            bestBmp = bmp
            bestSimilarity = sim
        Next

        MatchedSpawnCapture.Image = bestBmp
        spawnLabel.Text = bestBmp.Tag.ToString().Remove(11)
        similarityLabel.Text = bestSimilarity.ToString()
    End Sub

    Private Sub playSoloMatch()
        runScript("start_solo_match")

        Dim bestBmp As Bitmap
        Dim bestSimilarity = 0
        Dim sim As Double

        For Each bmp As Bitmap In loadedBmps
            sim = imgSimilarity(MainScreenCapture.Invoke(Function() cropImage(MainScreenCapture.Image)), bmp)
            'Debug.Print(sim.ToString)
            If sim <= bestSimilarity Then
                Continue For
            End If

            bestBmp = bmp
            bestSimilarity = sim
        Next

        MatchedSpawnCapture.Invoke(Sub() MatchedSpawnCapture.Image = bestBmp)
        Dim newSpawnLabel = bestBmp.Tag.ToString().Remove(11)
        spawnLabel.Invoke(Sub() spawnLabel.Text = newSpawnLabel)
        similarityLabel.Invoke(Sub() similarityLabel.Text = bestSimilarity.ToString())

        'If (bestSimilarity < 90) Then
        'isRunning = False
        'Return
        'End If

        runScript(newSpawnLabel)
        runScript("finish_solo_match")
    End Sub

    Private Function imgSimilarity(img1 As Bitmap, img2 As Bitmap) As Double
        Return 100.0 - 100.0 * img1.PercentageDifference(img2, 10)

        'Dim count = 0

        ' For i = 0 To img1.Width - 1
        '    For j = 0 To img1.Height - 1
        'If (img1.GetPixel(i, j).Equals(img2.GetPixel(i, j))) Then
        '           count += 1
        '        End If
        '    Next
        'Next

        'Return count / (img1.Height * img1.Width)

    End Function

    Private Function loadScriptXML(path As String, actionGroup As String) As clsScript
        Dim doc As New XmlDocument
        doc.Load(path)

        Dim actionGroups As New Dictionary(Of String, clsActionGroup)
        Dim actionGroupsXml As Xml.XmlNodeList = doc.SelectNodes("/XBScript/ActionGroups/ActionGroup")
        For Each agNode As Xml.XmlNode In actionGroupsXml
            Dim ag As New clsActionGroup(agNode.SelectSingleNode("Name").InnerText)
            For Each actNode As Xml.XmlNode In agNode.ChildNodes
                If actNode.Name <> "Name" Then
                    Dim action As clsAction = clsAction.fromXML(actNode, ag)
                    action.index = ag.actions.Count
                    ag.actions.Add(action)
                End If

            Next
            actionGroups.Add(ag.name, ag)
        Next

        ' Support ActionType.actGroup & ActionType.actLoop
        For Each group In actionGroups.Values
            For Each action As clsAction In group.actions
                If action.getActType = ActionType.actLoop Then
                    Dim aLoop As clsActionLoop = action
                    aLoop.linkTarget(group.actions)
                End If
                If action.getActType = ActionType.actGroup Then
                    Dim aGroup As clsActionAGroup = action
                    aGroup.linkTarget(actionGroups)
                End If
            Next
        Next

        ' Flatten actions list from action groups.
        Dim actions As New Generic.List(Of clsAction)
        For Each action As clsAction In actionGroups(actionGroup).actions
            actions.Add(action)
            If action.getActType = ActionType.actGroup Then
                Dim agAction As clsActionAGroup = action
                For i As Integer = 1 To agAction.repeat
                    actions.AddRange(agAction.target.getActions())
                Next
            End If
        Next

        Return New clsScript(actions, controllerIPS)
    End Function

    Private Sub runScript(scriptName As String)
        Dim scriptPath = "graw\leaderboard_boost_boneyard.axb"
        activeScript = loadScriptXML(scriptPath, scriptName)
        activeScript.startScript()

        While activeScript.state <> clsScript.scriptState.finished
            Continue While
        End While
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        ' Main loop already running
        If isRunning Then
            isRunning = False
            startButton.Text = "Start Boosting"
            Return
        End If

        ' Start up main loop
        startButton.Text = "Stop"

        loadSpawnImages()

        Dim ts As New System.Threading.ThreadStart(AddressOf Me.runBoostingLoop)
        Dim runThread = New System.Threading.Thread(ts)

        isRunning = True
        runThread.Start()
    End Sub

    Private Sub runBoostingLoop()
        While isRunning
            If activeScript IsNot Nothing AndAlso activeScript.state <> clsScript.scriptState.finished Then
                Continue While
            End If

            If mode Then
                playSoloMatch()
            Else
                runScript("play_team_match")
            End If

            currentGameCount = currentGameCount - 1
            If currentGameCount <= 0 Then
                mode = Not mode
                currentGameCount = GAME_COUNT

                If mode Then
                    runScript("menu_team_to_solo")
                Else
                    runScript("menu_solo_to_team")
                End If
            End If

        End While
    End Sub

    Private Sub matchSpawnButton_Click(sender As Object, e As EventArgs) Handles matchSpawnButton.Click
        loadSpawnImages()
        matchSpawn()
    End Sub

    Private Function cropImage(bmp As Bitmap) As Bitmap
        'Adjust the rectangle to your needs
        Dim rc As RectangleF = bmp.GetBounds(GraphicsUnit.Pixel)
        rc.Inflate(-0.25 * bmp.Width, 0)
        rc.Offset(-0.25 * bmp.Width, 0)
        'Create a new bitmap the size of the cropping rectangle
        Dim bmpCrop As New Bitmap(rc.Width, rc.Height, bmp.PixelFormat)

        'create a drawing surface from the new bitmap
        Dim g As Graphics = Graphics.FromImage(bmpCrop)
        'draw the cropped image
        g.DrawImage(bmp, 0, 0, rc, GraphicsUnit.Pixel)
        g.Dispose()
        Return bmpCrop
    End Function

    Private Sub gamesTextBox_TextChanged(sender As Object, e As EventArgs) Handles gamesTextBox.TextChanged
        currentGameCount = Val(gamesTextBox.Text)
    End Sub

    Private Sub controllerCb_TextChanged(sender As Object, e As EventArgs) Handles controllerCb.SelectedIndexChanged
        controllerIPS.Remove(1)
        controllerIPS.Add(1, controllerCb.Text)
    End Sub

    Private Sub deviceCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles deviceCb.SelectedIndexChanged
        Try
            If snap IsNot Nothing Then snap.Dispose()
            snap = New clsSnapshot(CType(deviceCb.SelectedItem, DsDevice).DevicePath)
            mainCaptureTimer.Enabled = True
        Catch ex As Exception
            MsgBox("Capture Device error:" & vbCrLf & ex.Message)
            Me.Close()
            Exit Sub
        End Try
    End Sub

End Class