Imports XnaFan.ImageComparison
Imports System.Xml
Imports DirectShowLib

Public Class frmCaptureViewer

    Dim snap As clsSnapshot

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

    Private Sub frmCaptureViewer_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not snap Is Nothing Then snap.Dispose()
    End Sub

    Private Sub mainCaptureTimer_Tick(sender As Object, e As EventArgs) Handles mainCaptureTimer.Tick
        Dim oldImage As Image = MainScreenCapture.Image
        MainScreenCapture.Image = snap.capture
        If Not oldImage Is Nothing Then oldImage.Dispose()
        MainScreenCapture.Refresh()
    End Sub

    Private Sub deviceCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles deviceCb.SelectedIndexChanged
        Try
            snap = New clsSnapshot(CType(deviceCb.SelectedItem, DsDevice).DevicePath)
            mainCaptureTimer.Enabled = True
        Catch ex As Exception
            MsgBox("Capture Device error:" & vbCrLf & ex.Message)
            Me.Close()
            Exit Sub
        End Try
    End Sub
End Class