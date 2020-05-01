Imports System.ComponentModel

Public Class ScanUSBToast
    Dim currentUSBDrive As String = ""
    Dim exitNow As Boolean = False
    Dim secondsNow As String = 0
    Private Sub ScanUSBToast_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim scr As Screen = Screen.FromPoint(Cursor.Position)

        Me.Location = New Point(scr.WorkingArea.Right - Me.Width, scr.WorkingArea.Bottom - Me.Height)
        loadTimer.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles exitTimer.Tick
        If exitNow = False Then
            Dim closeTime As String = My.Settings.closeNotificationSeconds
            secondsNow += 1
            If secondsNow = closeTime.ToString.Replace(" Seconds", "") Then
                exitTimer.Interval = 10
                Me.Opacity -= 0.06
                If Me.Opacity = 0 Then
                    Me.Dispose()
                    exitTimer.Stop()
                End If
                secondsNow = 0
            End If
        Else
            exitTimer.Interval = 10
            Me.Opacity -= 0.06
            If Me.Opacity = 0 Then
                Me.Dispose()
                exitTimer.Stop()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles loadTimer.Tick
        Dim opacityFade As Single
        For opacityFade = 0 To 1 Step 0.01
            Me.Opacity = opacityFade
            Me.Refresh()
            System.Threading.Thread.Sleep(10)
        Next opacityFade
        Me.Opacity = 1
        loadTimer.Enabled = False
    End Sub

    Private Sub exitPicBox_Click(sender As Object, e As EventArgs) Handles exitPicBox.Click
        exitNow = True
        exitTimer.Start()
    End Sub

    Private Sub scanUSBDriveButton_Click(sender As Object, e As EventArgs) Handles scanUSBDriveButton.Click
        My.Settings.USBDriveScan = True
        currentUSBDrive = TextBox1.Text
        My.Settings.USBDrive = currentUSBDrive.ToString()
        Me.Hide()
    End Sub

    Private Sub secondsBGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles secondsBGW.DoWork
        exitTimer.Start()
    End Sub

    Private Sub secondsBGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles secondsBGW.RunWorkerCompleted
        exitTimer.Interval = 1000
    End Sub
End Class