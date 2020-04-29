Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices
Public Class settingsForm

    Dim scheduledScan As Boolean = False
    Dim mainDrive As String = Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 3)
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    Dim exts As List(Of String) = New List(Of String)

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Public Sub WriteToLog(ByVal msg As String)

        'check and make the directory if necessary; this is set to look in 
        'the application folder, you may wish to place the error log in 
        'another location depending upon the user's role and write access to 
        'different areas of the file system
        If Not System.IO.Directory.Exists(Application.StartupPath & "\Log\") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\Log\")
        End If


        'check the file
        Try

            Dim fs As FileStream = New FileStream(Application.StartupPath & "\Log\Log.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
            Dim s As StreamWriter = New StreamWriter(fs)
            s.Close()
            fs.Close()

            Dim fs1 As FileStream = New FileStream(Application.StartupPath & "\Log\Log.txt", FileMode.Append, FileAccess.Write)
            Dim s1 As StreamWriter = New StreamWriter(fs1)
            s1.Write(msg & vbCrLf)
            s1.Close()
            fs1.Close()


        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim ex2 As Exception = exception1
            ProjectData.ClearProjectError()
        End Try




    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub titleLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles titleLabel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub clearScanDateAndTimeButton_Click(sender As Object, e As EventArgs) Handles clearScanDateAndTimeButton.Click
        scheduledScan = True
        scheduleDateAndTimeButton.Enabled = True
        clearScanDateAndTimeButton.Enabled = False
        mainForm.scheduledScanTimer.Enabled = False
        quickScanRadioButton.Checked = False
        fullScanRadioButton.Checked = False
        folderScanRadioButton.Checked = False
        MonthCalendar2.SelectionEnd = Date.Today
        hourUpAndDown.Value = 1
        minuteUpAndDown.Value = 0
    End Sub

    Private Sub allowListButton_Click(sender As Object, e As EventArgs) Handles allowListButton.Click
        aboutScheduledScansLabel.Visible = False
        aboutProgramLabel.Visible = False
        scheduleScanLabel.Visible = False
        scheduleScanGroupBox.Visible = False
        scheduleDateAndTimeButton.Visible = False
        clearScanDateAndTimeButton.Visible = False
        generalLabel.Visible = False
        allowListLabel.Visible = True
        allowProgramsListBox.Visible = True
        addProgramButton.Visible = True
        removeProgramButton.Visible = True
        securityLabel.Visible = False
        realTimeProtectionLabel.Visible = False
        realTimeCheckBox.Visible = False
        webProtectionLabel.Visible = False
        webProtectionCheckBox.Visible = False
        windowsStartLabel.Visible = False
        windowsStartCheckBox.Visible = False
        archivedFilesLabel.Visible = False
        archivedFilesCheckBox.Visible = False
        If allowProgramsListBox.Items.Count > 0 Then
            allowProgramsListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub generalSettingsButton_Click(sender As Object, e As EventArgs) Handles generalSettingsButton.Click
        aboutScheduledScansLabel.Visible = False
        aboutProgramLabel.Visible = False
        scheduleScanLabel.Visible = False
        scheduleScanGroupBox.Visible = False
        scheduleDateAndTimeButton.Visible = False
        clearScanDateAndTimeButton.Visible = False
        allowProgramsListBox.Visible = False
        generalLabel.Visible = True
        addProgramButton.Visible = False
        removeProgramButton.Visible = False
        securityLabel.Visible = False
        realTimeProtectionLabel.Visible = False
        realTimeCheckBox.Visible = False
        webProtectionLabel.Visible = False
        webProtectionCheckBox.Visible = False
        windowsStartLabel.Visible = False
        windowsStartCheckBox.Visible = False
        archivedFilesLabel.Visible = False
        archivedFilesCheckBox.Visible = False
    End Sub

    Private Sub securityButton_Click(sender As Object, e As EventArgs) Handles securityButton.Click
        aboutScheduledScansLabel.Visible = False
        aboutProgramLabel.Visible = False
        scheduleScanLabel.Visible = False
        scheduleScanGroupBox.Visible = False
        scheduleDateAndTimeButton.Visible = False
        clearScanDateAndTimeButton.Visible = False
        allowListLabel.Visible = False
        allowProgramsListBox.Visible = False
        generalLabel.Visible = False
        addProgramButton.Visible = False
        removeProgramButton.Visible = False
        securityLabel.Visible = True
        realTimeProtectionLabel.Visible = True
        realTimeCheckBox.Visible = True
        webProtectionLabel.Visible = True
        webProtectionCheckBox.Visible = True
        windowsStartLabel.Visible = True
        windowsStartCheckBox.Visible = True
        archivedFilesLabel.Visible = True
        archivedFilesCheckBox.Visible = True
    End Sub

    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        creditTimer.Interval = 20
        creditTimer.Enabled = True
        aboutProgramLabel.Top = Panel3.Height
        scheduleScanLabel.Visible = False
        scheduleScanGroupBox.Visible = False
        scheduleDateAndTimeButton.Visible = False
        clearScanDateAndTimeButton.Visible = False
        allowListLabel.Visible = False
        allowProgramsListBox.Visible = False
        generalLabel.Visible = False
        aboutProgramLabel.Visible = True
        aboutProgramLabel.Location = New Point(8, 396)
        addProgramButton.Visible = False
        removeProgramButton.Visible = False
        securityLabel.Visible = False
        realTimeProtectionLabel.Visible = False
        realTimeCheckBox.Visible = False
        webProtectionLabel.Visible = False
        webProtectionCheckBox.Visible = False
        windowsStartLabel.Visible = False
        windowsStartCheckBox.Visible = False
        archivedFilesLabel.Visible = False
        archivedFilesCheckBox.Visible = False
        aboutScheduledScansLabel.Visible = False
    End Sub

    Private Sub settingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        aboutProgramLabel.Text = "About Mythodikal Anti-Virus" & vbCrLf & vbCrLf &
                                 "Version 1.0.0" & vbCrLf & vbCrLf &
                                 "Programmed By:" & vbCrLf &
                                 "Mike DoubleYou" & vbCrLf & vbCrLf &
                                 "Programmed WIth:" & vbCrLf &
                                 "VB.Net - Visual Studio 2019 Enterprise" & vbCrLf & vbCrLf &
                                 "Number Of Times Loaded: " & My.Settings.numLoads & "" & vbCrLf & vbCrLf &
                                 "Total Virus Signatures: " & mainForm.signaturesCount.ToString("N0") & ""

        Dim aPath As String = Application.StartupPath()
        If IO.File.Exists(aPath & "\ProgramSettings.ini") Then
            Dim lines = IO.File.ReadAllLines(aPath & "\ProgramSettings.ini")
            If lines.Contains("realCheck = False") Then
                My.Settings.realTimeScan = False
                mainForm.realTimeOffButton.Enabled = False
                mainForm.realTimeOnButton.Enabled = True
            Else
                My.Settings.realTimeScan = True
                mainForm.realTimeOffButton.Enabled = True
                mainForm.realTimeOnButton.Enabled = False
                mainForm.statusLabel.Text = "Starting Real-Time Scan..."
                FileSystemWatcher1.EnableRaisingEvents = True
                WriteToLog("Real Time Scan Started At: " & Date.Now & "")
            End If

            If lines.Contains("realCheck = False") Then
                realTimeCheckBox.Checked = False
                realTimeCheckBox.Text = "Off"
                My.Settings.realTimeScan = False
            Else
                realTimeCheckBox.Checked = True
                realTimeCheckBox.Text = "On"
                My.Settings.realTimeScan = True
            End If

            If lines.Contains("windowsStart = False") Then
                windowsStartCheckBox.Checked = False
                windowsStartCheckBox.Text = "Off"
            Else
                windowsStartCheckBox.Checked = True
                windowsStartCheckBox.Text = "On"
            End If

            If lines.Contains("archiveFiles = False") Then
                archivedFilesCheckBox.Checked = False
                archivedFilesCheckBox.Text = "Off"
            Else
                archivedFilesCheckBox.Checked = True
                archivedFilesCheckBox.Text = "On"
            End If

            If lines.Contains("webProtect = False") Then
                webProtectionCheckBox.Checked = False
                webProtectionCheckBox.Text = "Off"
            Else
                webProtectionCheckBox.Checked = True
                webProtectionCheckBox.Text = "On"
            End If

            If lines.Contains("scheduledScan = False") Then
                scheduleDateAndTimeButton.Enabled = True
                clearScanDateAndTimeButton.Enabled = False
            Else
                scheduleDateAndTimeButton.Enabled = False
                clearScanDateAndTimeButton.Enabled = True
            End If
            If lines.Contains("quickScan = True") = True Then
                quickScanRadioButton.Checked = True
            Else
                quickScanRadioButton.Checked = False
            End If
            If lines.Contains("fullScan = True") = True Then
                fullScanRadioButton.Checked = True
            Else
                fullScanRadioButton.Checked = False
            End If
            If lines.Contains("folderScan = True") = True Then
                folderScanRadioButton.Checked = True
            Else
                folderScanRadioButton.Checked = False
            End If
            Dim dateEnd As Date = Nothing
            If My.Settings.scheduleDate = "" Then
                MonthCalendar2.SelectionEnd = Date.Today
            Else
                dateEnd = My.Settings.scheduleDate
            End If
            If lines.Contains("scanDate = " & dateEnd) Then
                MonthCalendar2.SelectionEnd = dateEnd
            Else
            End If
            Dim scanHourNow As String = Nothing
            If My.Settings.scheduleHour = "" Then
                hourUpAndDown.Value = 0
            Else
                scanHourNow = My.Settings.scheduleHour
            End If
            If lines.Contains("scanHour = " & scanHourNow) Then
                hourUpAndDown.Value = scanHourNow
            Else
            End If

            Dim scanMinuteNow As String = Nothing
            If My.Settings.scheduleMinute = "" Then
                minuteUpAndDown.Value = 0
            Else
                scanMinuteNow = My.Settings.scheduleMinute
            End If
            If lines.Contains("scanMinute = " & scanMinuteNow) Then
                minuteUpAndDown.Value = scanMinuteNow
            Else
            End If
        End If

        aboutProgramLabel.Visible = False
        scheduleScanLabel.Visible = False
        scheduleScanGroupBox.Visible = False
        scheduleDateAndTimeButton.Visible = False
        clearScanDateAndTimeButton.Visible = False
        allowListLabel.Visible = False
        allowProgramsListBox.Visible = False
        generalLabel.Visible = False
        addProgramButton.Visible = False
        removeProgramButton.Visible = False
        securityLabel.Visible = True
        realTimeProtectionLabel.Visible = True
        realTimeCheckBox.Visible = True
        webProtectionLabel.Visible = True
        webProtectionCheckBox.Visible = True
        windowsStartLabel.Visible = True
        windowsStartCheckBox.Visible = True
        archivedFilesLabel.Visible = True
        archivedFilesCheckBox.Visible = True
    End Sub

    Private Sub exitPicBox_Click(sender As Object, e As EventArgs) Handles exitPicBox.Click
        If My.Settings.allowedProgramsList Is Nothing Then
            My.Settings.allowedProgramsList = New System.Collections.Specialized.StringCollection()
        Else
            My.Settings.allowedProgramsList.Clear()
            For Each allowedProgram As String In allowProgramsListBox.Items
                My.Settings.allowedProgramsList.Add(allowedProgram)
            Next
        End If
        Dim aPath As String = Application.StartupPath()
        If IO.File.Exists(aPath & "\ProgramSettings.ini") Then
            IO.File.Delete(aPath & "\ProgramSettings.ini")
        Else
            realTimeCheckBox.Checked = True

        End If




        Using writer As New StreamWriter(aPath & "\ProgramSettings.ini", True)
            If realTimeCheckBox.Checked = True Then
                writer.WriteLine("realCheck = True")
            Else
                writer.WriteLine("realCheck = False")
                realTimeCheckBox.Checked = False
            End If

            If webProtectionCheckBox.Checked = True Then
                writer.WriteLine("webProtect = True")
            Else
                writer.WriteLine("webProtect = False")
                webProtectionCheckBox.Checked = False
            End If

            If archivedFilesCheckBox.Checked = True Then
                writer.WriteLine("archiveFiles = True")
            Else
                writer.WriteLine("archiveFiles = False")
                archivedFilesCheckBox.Checked = False
            End If

            If windowsStartCheckBox.Checked = True Then
                writer.WriteLine("windowsStart = True")
            Else
                writer.WriteLine("windowsStart = False")
                windowsStartCheckBox.Checked = False
            End If
            If scheduleDateAndTimeButton.Enabled = True Then
                writer.WriteLine("scheduledScan = False")
            Else
                writer.WriteLine("scheduledScan = True")
                If quickScanRadioButton.Checked = True Then
                    writer.WriteLine("quickScan = True")
                Else
                    writer.WriteLine("quickScan = False")
                End If
                If fullScanRadioButton.Checked = True Then
                    writer.WriteLine("fullScan = True")
                Else
                    writer.WriteLine("fullScan = False")
                End If
                If folderScanRadioButton.Checked = True Then
                    writer.WriteLine("folderScan = True")
                Else
                    writer.WriteLine("folderScan = False")
                End If
                Dim dateEnd As Date = MonthCalendar2.SelectionEnd
                My.Settings.scheduleDate = dateEnd

                writer.WriteLine("scanDate = " & dateEnd)
                writer.WriteLine("scanHour = " & hourUpAndDown.Value)
                writer.WriteLine("scanMinute = " & minuteUpAndDown.Value)
                My.Settings.scheduleHour = hourUpAndDown.Value
                My.Settings.scheduleMinute = minuteUpAndDown.Value
                My.Settings.Save()
            End If
        End Using


        My.Settings.Save()
        Me.Hide()
    End Sub

    Private Sub minimizePicBox_Click(sender As Object, e As EventArgs) Handles minimizePicBox.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub addProgramButton_Click(sender As Object, e As EventArgs) Handles addProgramButton.Click
        Try

            Dim blah As New OpenFileDialog
            blah.FileName = ""
            blah.Multiselect = False
            blah.Title = "Add Program To Allowed List"
            If (blah.ShowDialog() = DialogResult.OK) Then
                Dim currDir As String = blah.FileName & "\"
                allowProgramsListBox.Items.Add(currDir)
                allowProgramsListBox.SelectedIndex = 0
                allowProgramsListBox.Text = ""
            Else
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub removeProgramButton_Click(sender As Object, e As EventArgs) Handles removeProgramButton.Click
        If allowProgramsListBox.SelectedIndex = -1 Then
            Exit Sub
        Else
            allowProgramsListBox.Items.Remove(allowProgramsListBox.SelectedItem)
        End If
    End Sub

    Private Sub realTimeCheckBox_Click(sender As Object, e As EventArgs) Handles realTimeCheckBox.Click
        If realTimeCheckBox.Checked = True Then
            realTimeCheckBox.Text = "On"
            My.Settings.realTimeScan = True
            mainForm.realTimeLabel.Visible = True
            mainForm.realTimeOffButton.Visible = True
            mainForm.realTimeOnButton.Visible = True
            mainForm.copyHashButton.Visible = False
            mainForm.filesPropertiesButton.Visible = False
            mainForm.startQuickScan.Visible = False
            mainForm.startFullScan.Visible = False
            mainForm.stopFullScanButton.Visible = False
            mainForm.startFolderScan.Visible = False
            mainForm.stopFolderScan.Visible = False
            mainForm.stopQuickScan.Visible = False
            mainForm.quickScanLabel.Visible = True
            mainForm.fullScanLabel.Visible = False
            mainForm.quarantineLabel.Visible = False
            mainForm.folderScanLabel.Visible = False
            mainForm.quarantineGridView.Visible = False
            mainForm.restoreAllButton.Visible = False
            mainForm.restoreFileButton.Visible = False
            mainForm.deleteAllButton.Visible = False
            mainForm.deletefileButton.Visible = False
            mainForm.infectedLabel.Visible = True
            mainForm.onFileLabel.Visible = True
            mainForm.elapsedLabel.Visible = True
            mainForm.scanningFileLabel.Visible = True
            mainForm.numberInfectedFilesLabel.Visible = True
            mainForm.scanProgressBar.Visible = True
            mainForm.percentLabel.Visible = True
            mainForm.fileCountLabel.Visible = True
            mainForm.currentFile.Visible = True
            mainForm.elapsedTimeLabel.Visible = True
            mainForm.statusLabel.Text = "Real-Time Scan Started..."
            mainForm.statusLabel.Refresh()
            FileSystemWatcher1.EnableRaisingEvents = True
            FileSystemWatcher1.Path = mainDrive
            WriteToLog("Real Time Scan Started At:  " & Date.Now & "")
        Else
            realTimeCheckBox.Text = "Off"
            My.Settings.realTimeScan = False
            mainForm.realTimeLabel.Visible = True
            mainForm.realTimeOffButton.Visible = True
            mainForm.realTimeOnButton.Visible = True
            mainForm.copyHashButton.Visible = False
            mainForm.filesPropertiesButton.Visible = False
            mainForm.startQuickScan.Visible = False
            mainForm.startFullScan.Visible = False
            mainForm.stopFullScanButton.Visible = False
            mainForm.startFolderScan.Visible = False
            mainForm.stopFolderScan.Visible = False
            mainForm.stopQuickScan.Visible = False
            mainForm.quickScanLabel.Visible = False
            mainForm.fullScanLabel.Visible = False
            mainForm.quarantineLabel.Visible = False
            mainForm.folderScanLabel.Visible = False
            mainForm.quarantineGridView.Visible = False
            mainForm.restoreAllButton.Visible = False
            mainForm.restoreFileButton.Visible = False
            mainForm.deleteAllButton.Visible = False
            mainForm.deletefileButton.Visible = False
            mainForm.infectedLabel.Visible = True
            mainForm.onFileLabel.Visible = True
            mainForm.elapsedLabel.Visible = True
            mainForm.scanningFileLabel.Visible = True
            mainForm.numberInfectedFilesLabel.Visible = True
            mainForm.scanProgressBar.Visible = True
            mainForm.percentLabel.Visible = True
            mainForm.fileCountLabel.Visible = True
            mainForm.currentFile.Visible = True
            mainForm.elapsedTimeLabel.Visible = True
            mainForm.statusLabel.Text = "Real-Time Scan Stopped..."
            mainForm.statusLabel.Refresh()
            FileSystemWatcher1.EnableRaisingEvents = False
            FileSystemWatcher1.Path = mainDrive
            WriteToLog("Real Time Scan Stopped At: " & Date.Now & "")
        End If

        If realTimeCheckBox.Checked = True Then
            mainForm.realTimeOnButton.Enabled = False
            mainForm.realTimeOffButton.Enabled = True
        Else
            mainForm.realTimeOnButton.Enabled = True
            mainForm.realTimeOffButton.Enabled = False
        End If
    End Sub

    Private Sub settingsForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim aPath As String = Application.StartupPath()
        '   MessageBox.Show(aPath & "\ProgramSettings.ini")
        If IO.File.Exists(aPath & "\ProgramSettings.ini") Then
            Dim lines = IO.File.ReadAllLines(aPath & "\ProgramSettings.ini")

            If lines.Contains("realCheck = False") Then
                realTimeCheckBox.Checked = False
                realTimeCheckBox.Text = "Off"
                My.Settings.realTimeScan = False
                mainForm.realTimeOnButton.Enabled = True
                mainForm.realTimeOffButton.Enabled = False
            Else
                realTimeCheckBox.Checked = True
                realTimeCheckBox.Text = "On"
                My.Settings.realTimeScan = True
                mainForm.realTimeOnButton.Enabled = False
                mainForm.realTimeOffButton.Enabled = True
            End If

            If lines.Contains("windowsStart = False") Then
                windowsStartCheckBox.Checked = False
                windowsStartCheckBox.Text = "Off"
            Else
                windowsStartCheckBox.Checked = True
                windowsStartCheckBox.Text = "On"
            End If

            If lines.Contains("archiveFiles = False") Then
                archivedFilesCheckBox.Checked = False
                archivedFilesCheckBox.Text = "Off"
            Else
                archivedFilesCheckBox.Checked = True
                archivedFilesCheckBox.Text = "On"
            End If

            If lines.Contains("webProtect = False") Then
                webProtectionCheckBox.Checked = False
                webProtectionCheckBox.Text = "Off"
            Else
                webProtectionCheckBox.Checked = True
                webProtectionCheckBox.Text = "On"
            End If
        Else

        End If
    End Sub

    Private Sub VscrollTmr_Tick(sender As Object, e As EventArgs) Handles creditTimer.Tick
        aboutProgramLabel.Location = New Point(aboutProgramLabel.Location.X, aboutProgramLabel.Location.Y - 1)
        If aboutProgramLabel.Location = New Point(8, -385) Then
            aboutProgramLabel.Location = New Point(8, 396)
        End If
    End Sub

    Private Sub windowsStartCheckBox_Click(sender As Object, e As EventArgs) Handles windowsStartCheckBox.Click
        If windowsStartCheckBox.Checked = True Then
            windowsStartCheckBox.Text = "On"
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
        Else
            windowsStartCheckBox.Text = "Off"
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
        End If
    End Sub

    Private Sub webProtectionCheckBox_Click(sender As Object, e As EventArgs) Handles webProtectionCheckBox.Click
        If webProtectionCheckBox.Checked = True Then
            webProtectionCheckBox.Text = "On"
        Else
            webProtectionCheckBox.Text = "Off"
        End If
    End Sub

    Private Sub archivedFilesCheckBox_Click(sender As Object, e As EventArgs) Handles archivedFilesCheckBox.Click
        If archivedFilesCheckBox.Checked = True Then
            archivedFilesCheckBox.Text = "On"
        Else
            archivedFilesCheckBox.Text = "Off"
        End If
    End Sub

    Private Sub scheduleScanButton_Click(sender As Object, e As EventArgs) Handles scheduleScanButton.Click
        aboutScheduledScansLabel.Visible = True
        aboutProgramLabel.Visible = False
        scheduleScanLabel.Visible = True
        scheduleScanGroupBox.Visible = True
        scheduleDateAndTimeButton.Visible = True
        clearScanDateAndTimeButton.Visible = True
        generalLabel.Visible = False
        allowListLabel.Visible = False
        allowProgramsListBox.Visible = False
        addProgramButton.Visible = False
        removeProgramButton.Visible = False
        securityLabel.Visible = False
        realTimeProtectionLabel.Visible = False
        realTimeCheckBox.Visible = False
        webProtectionLabel.Visible = False
        webProtectionCheckBox.Visible = False
        windowsStartLabel.Visible = False
        windowsStartCheckBox.Visible = False
        archivedFilesLabel.Visible = False
        archivedFilesCheckBox.Visible = False
    End Sub

    Private Sub scheduleDateAndTimeButton_Click(sender As Object, e As EventArgs) Handles scheduleDateAndTimeButton.Click
        If quickScanRadioButton.Checked = True Or fullScanRadioButton.Checked = True Or folderScanRadioButton.Checked = True Then
            If hourUpAndDown.Value >= 1 Then
                scheduledScan = True
                mainForm.scheduledScanTimer.Enabled = True
                scheduleDateAndTimeButton.Enabled = False
                clearScanDateAndTimeButton.Enabled = True
            End If
        Else
            MessageBox.Show("You Must Select The Type Of Scan To Perform On That Date!", "Mythodikal Anti-Virus", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub hourUpAndDown_ValueChanged(sender As Object, e As EventArgs) Handles hourUpAndDown.ValueChanged
        If hourUpAndDown.Value >= 12 Then
            amPMLabel.Text = "PM"
        Else
            amPMLabel.Text = "AM"
        End If
        If hourUpAndDown.Value = 24 Then
            amPMLabel.Text = "AM"
        End If
    End Sub
End Class