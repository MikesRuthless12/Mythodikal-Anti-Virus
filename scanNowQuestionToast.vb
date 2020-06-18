Public Class scanNowQuestionToast
    Dim currentUSBDrive As String = ""
    Dim exitNow As Boolean = False
    Dim secondsNow As String = 0
    Private Sub exitTimer_Tick(sender As Object, e As EventArgs) Handles exitTimer.Tick
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

    Private Sub loadTimer_Tick(sender As Object, e As EventArgs) Handles loadTimer.Tick
        Dim opacityFade As Single
        For opacityFade = 0 To 1 Step 0.01
            Me.Opacity = opacityFade
            Me.Refresh()
            System.Threading.Thread.Sleep(10)
        Next opacityFade
        Me.Opacity = 1
        loadTimer.Enabled = False
    End Sub

    Private Sub secondsBGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles secondsBGW.DoWork
        exitTimer.Start()
    End Sub

    Private Sub secondsBGW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles secondsBGW.RunWorkerCompleted
        exitTimer.Interval = 1000
    End Sub

    Private Sub scanNowQuestionToast_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim scr As Screen = Screen.FromPoint(Cursor.Position)

        Me.Location = New Point(scr.WorkingArea.Right - Me.Width, scr.WorkingArea.Bottom - Me.Height)
        loadTimer.Enabled = True

        Dim month As String = My.Settings.scanDateMonth

        Dim day As String = My.Settings.scanDateDay

        Dim year As String = My.Settings.scanDateYear

        Dim iDate As String = "" & month & "/" & day & "/" & year & ""

        Dim oDate As DateTime = Convert.ToDateTime(iDate)
        Dim d As DateTime = Date.Today

        Dim sinceLastScan As String = (d - oDate).TotalDays
        If sinceLastScan >= 5 Then
            scanCPULabel.Text = "It Has Been " & sinceLastScan & " Days Since Your Last Scan. Would You Like To Scan Now?"
        End If
    End Sub

    Private Sub quickScanButton_Click(sender As Object, e As EventArgs) Handles quickScanButton.Click
        If mainForm.quickScanBGW.IsBusy = False And mainForm.fullScanBGW.IsBusy = False And mainForm.folderScanBGW.IsBusy = False Then
            mainForm.quickScanButton_Click(sender, e)
            System.Threading.Thread.Sleep(1000)
            mainForm.startQuickScan_Click(sender, e)
            exitNow = True
            exitTimer.Start()
        End If
    End Sub

    Private Sub fullScanButton_Click(sender As Object, e As EventArgs) Handles fullScanButton.Click
        If mainForm.quickScanBGW.IsBusy = False And mainForm.fullScanBGW.IsBusy = False And mainForm.folderScanBGW.IsBusy = False Then
            mainForm.fullScanButton_Click(sender, e)
            System.Threading.Thread.Sleep(1000)
            mainForm.startFullScan_Click(sender, e)
            exitNow = True
            exitTimer.Start()
        End If
    End Sub

    Private Sub exitPicBox_Click(sender As Object, e As EventArgs) Handles exitPicBox.Click
        exitNow = True
        exitTimer.Start()
    End Sub
End Class