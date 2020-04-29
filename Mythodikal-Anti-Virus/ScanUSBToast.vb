Public Class ScanUSBToast
    Dim currentUSBDrive As String = ""
    Private Sub ScanUSBToast_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim scr As Screen = Screen.FromPoint(Cursor.Position)

        Me.Location = New Point(scr.WorkingArea.Right - Me.Width, scr.WorkingArea.Bottom - Me.Height)
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity -= 0.06
        If Me.Opacity = 0 Then Me.Dispose()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim opacityFade As Single
        For opacityFade = 0 To 1 Step 0.01
            Me.Opacity = opacityFade
            Me.Refresh()
            System.Threading.Thread.Sleep(10)
        Next opacityFade
        Me.Opacity = 1
        Timer2.Enabled = False
    End Sub

    Private Sub exitPicBox_Click(sender As Object, e As EventArgs) Handles exitPicBox.Click
        Timer1.Enabled = True
    End Sub

    Private Sub scanUSBDriveButton_Click(sender As Object, e As EventArgs) Handles scanUSBDriveButton.Click
        My.Settings.USBDriveScan = True
        currentUSBDrive = TextBox1.Text
        My.Settings.USBDrive = currentUSBDrive.ToString()
        Me.Hide()
    End Sub
End Class