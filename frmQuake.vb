Imports XnaFan.ImageComparison
Imports System.Xml
Imports DirectShowLib

Public Class frmQuake

    Dim snap As clsSnapshot
    Dim loadedBmps As New ArrayList
    Dim controllerIPS As New Dictionary(Of Byte, String)
    Dim activeScript As clsScript
    Dim scriptThread As System.Threading.Thread
    Dim isRunning = False

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
    Private Sub frmQuake_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not snap Is Nothing Then snap.Dispose()

        disposeImages()
    End Sub

    Private Sub takePhotoButton_Click(sender As Object, e As EventArgs) Handles takePhotoButton.Click
        If mapCb.SelectedIndex < 0 Or teamCb.SelectedIndex < 0 Then
            MsgBox("Pick map/team.")
            Return
        End If

        Dim filePath = "images\" & mapCb.SelectedItem.ToString() & "\" & teamCb.SelectedItem.ToString()

        Dim fis() As IO.FileInfo = (New IO.DirectoryInfo(filePath)).GetFiles()
        Dim imgIdx = fis.Length + 1

        Dim bmp As Bitmap = MainScreenCapture.Image
        bmp.Save(filePath & "\spawn" & imgIdx.ToString("D6") & ".png", System.Drawing.Imaging.ImageFormat.Png)
    End Sub

    Private Sub mainCaptureTimer_Tick(sender As Object, e As EventArgs) Handles mainCaptureTimer.Tick
        Dim oldImage As Image = MainScreenCapture.Image
        MainScreenCapture.Image = snap.capture
        If Not oldImage Is Nothing Then oldImage.Dispose()
        MainScreenCapture.Refresh()

        If activeScript IsNot Nothing Then
            controllerStateLabel.Text = activeScript.state.ToString
        End If
    End Sub

    Private Sub testRoutine_Click(sender As Object, e As EventArgs) Handles testRoutineButton.Click
        runScriptForCurrentSpawn()
    End Sub

    Private Sub loadSpawnImages()
        Dim fis() As IO.FileInfo = (New IO.DirectoryInfo("images\" & mapCb.SelectedItem.ToString() & "\" & teamCb.SelectedItem.ToString())).GetFiles()

        If loadedBmps.Count <> fis.Length Then
            disposeImages()

            For Each fi As IO.FileInfo In fis
                Dim bmp = Image.FromFile(fi.FullName)
                bmp.Tag = fi.Name
                loadedBmps.Add(bmp)
            Next
        End If
    End Sub

    Private Sub runScriptForCurrentSpawn()
        Dim map = mapCb.SelectedItem.ToString()
        Dim filename As String
        If map = "heartless" Then
            filename = map & "_" & teamCb.SelectedItem.ToString()
        Else
            filename = map
        End If

        If activeScript IsNot Nothing Then activeScript.stopScript()

        Dim scriptPath = "scripts\" & filename & ".axb"
        activeScript = loadScriptXML(scriptPath, spawnLabel.Text)
        activeScript.startScript()
    End Sub

    Private Sub matchSpawn()
        Dim bestBmp As Bitmap
        Dim bestSimilarity = 0
        Dim sim As Double

        For Each bmp As Bitmap In loadedBmps
            sim = imgSimilarity(MainScreenCapture.Image, bmp)
            'Debug.Print(sim.ToString)
            If sim <= bestSimilarity Then
                Continue For
            End If

            bestBmp = bmp
            bestSimilarity = sim
        Next

        MatchedSpawnCapture.Image = bestBmp
        spawnLabel.Text = bestBmp.Tag.ToString().Substring(0, bestBmp.Tag.ToString().Length - 4)
        similarityLabel.Text = bestSimilarity.ToString()
    End Sub

    Private Sub runPitJumpRoutineInvoke()
        Dim bestBmp As Bitmap
        Dim bestSimilarity = 0
        Dim sim As Double

        For Each bmp As Bitmap In loadedBmps
            sim = imgSimilarity(MainScreenCapture.Invoke(Function() MainScreenCapture.Image), bmp)
            'Debug.Print(sim.ToString)
            If sim <= bestSimilarity Then
                Continue For
            End If

            bestBmp = bmp
            bestSimilarity = sim
        Next

        MatchedSpawnCapture.Invoke(Sub() MatchedSpawnCapture.Image = bestBmp)
        Dim newSpawnLabel = bestBmp.Tag.ToString().Substring(0, bestBmp.Tag.ToString().Length - 4)
        spawnLabel.Invoke(Sub() spawnLabel.Text = newSpawnLabel)
        similarityLabel.Invoke(Sub() similarityLabel.Text = bestSimilarity.ToString())

        'If (bestSimilarity < 90) Then
        'isRunning = False
        'Return
        'End If

        Dim map = mapCb.Invoke(Function() mapCb.SelectedItem.ToString())
        Dim filename As String
        If map = "heartless" Then
            filename = map & "_" & teamCb.Invoke(Function() teamCb.SelectedItem.ToString())
        Else
            filename = map
        End If

        Dim actionGroup As String
        If bestSimilarity < 30 And (map = "heartless" Or map = "death_before_dishonor") Then
            actionGroup = "backup"
        Else
            actionGroup = newSpawnLabel
        End If

        If activeScript IsNot Nothing Then activeScript.stopScript()

        Dim scriptPath = "scripts\" & filename & ".axb"
        activeScript = loadScriptXML(scriptPath, actionGroup)
        activeScript.startScript()
    End Sub

    Private Function imgSimilarity(img1 As Bitmap, img2 As Bitmap) As Double
        Return 100.0 - 100.0 * img1.PercentageDifference(img2, 5)

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

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        If mapCb.SelectedIndex < 0 Or teamCb.SelectedIndex < 0 Then
            MsgBox("Pick map/team.")
            Return
        End If

        ' Main loop already running
        If isRunning Then
            isRunning = False
            startButton.Text = "Suicide Squad"
            deviceCb.Enabled = True
            controllerCb.Enabled = True
            mapCb.Enabled = True
            teamCb.Enabled = True
            scriptThread.Join()
            Return
        End If

        ' Start up main loop
        startButton.Text = "Stop"
        deviceCb.Enabled = False
        controllerCb.Enabled = False
        mapCb.Enabled = False
        teamCb.Enabled = False

        loadSpawnImages()

        Dim ts As New System.Threading.ThreadStart(AddressOf Me.runPitJumpRoutineOnLoop)
        scriptThread = New System.Threading.Thread(ts)

        isRunning = True
        scriptThread.Start()
    End Sub

    Private Sub runPitJumpRoutineOnLoop()
        While isRunning
            If activeScript IsNot Nothing AndAlso activeScript.state <> clsScript.scriptState.finished Then
                Continue While
            End If

            runPitJumpRoutineInvoke()
        End While
    End Sub

    Private Sub matchSpawnButton_Click(sender As Object, e As EventArgs) Handles matchSpawnButton.Click
        loadSpawnImages()
        matchSpawn()
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

    Private Sub mapCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mapCb.SelectedIndexChanged
        disposeImages()
    End Sub

    Private Sub teamCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles teamCb.SelectedIndexChanged
        disposeImages()
    End Sub

    Private Sub disposeImages()
        For Each bmp In loadedBmps
            bmp.Dispose()
        Next
        loadedBmps.Clear()
    End Sub
End Class