Imports System.Runtime.InteropServices
Imports System.IO
Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Management
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Text

Public Class mainForm

    'Dim sha512 As String = ""

    Public signaturesCount As Integer = 0
    Dim signatures() As String = Nothing
    Dim pathName As String = ""
    Private filePath As String
    Private fileStream As FileStream
    Private streamWriter As StreamWriter


    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    'Dim cn As OleDbConnection
    'Dim cmd As OleDbCommand
    'Dim dr As OleDbDataReader

    Private _loc As String = String.Empty
    Private _enc As Encryption = New Encryption()
    Private _password As String = "MythodikalAntiVirus!"

    Private USBDrivePluggedIn As String = ""

    Dim fileCountOn As Integer = 0
    Dim currentDirectory As String = ""
    'Dim currentSHA512Hash As String = ""
    Dim numberInfected As Integer = 0


    Dim mainDrive As String = Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 3)

    'Dim exts As List(Of String) = New List(Of String)
    'Dim quickScanDirectories As List(Of String) = New List(Of String)
    'Dim fileList As List(Of String) = New List(Of String)
    'Dim dirList As List(Of String) = New List(Of String)
    Dim cancelFullScan As Boolean = False
    Dim cancelQuickScan As Boolean = False
    Dim cancelFolderScan As Boolean = False
    Dim cancelRealTimeScan As Boolean = False

    Dim elapsedTimerSW As New Stopwatch

    Dim seconds1 As Integer = 0
    Dim minutes1 As Integer = 0
    Dim hours1 As Integer = 0

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private ReadOnly _salt As Byte() = New Byte() {&H56, &H47, &H98, &H33, &H88, &H13, &H77, &H10}
    Private Const _iterations As Integer = 1042
    Class Encryption
        Private ReadOnly _salt As Byte() = New Byte() {&H56, &H47, &H98, &H33, &H88, &H13, &H77, &H10}
        Private Const _iterations As Integer = 1042

        Public Sub DecryptFile(sourceFilename As String, destinationFilename As String, password As String)
            Dim aes As AesManaged = New AesManaged()
            aes.BlockSize = aes.LegalBlockSizes(0).MaxSize
            aes.KeySize = aes.LegalKeySizes(0).MaxSize
            ' NB: Rfc2898DeriveBytes initialization and subsequent calls to   GetBytes   must be eactly the same, including order, on both the encryption and decryption sides.
            Dim key As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(password, _salt, _iterations)
            aes.Key = key.GetBytes(aes.KeySize / 8)
            aes.IV = key.GetBytes(aes.BlockSize / 8)
            aes.Mode = CipherMode.CBC
            Dim transform As ICryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV)
            Using destination As FileStream = New FileStream(destinationFilename, FileMode.CreateNew, FileAccess.Write, FileShare.None)
                Using _cryptoStream As CryptoStream = New CryptoStream(destination, transform, CryptoStreamMode.Write)
                    Try

                        Using source As FileStream = New FileStream(sourceFilename, FileMode.Open, FileAccess.Read, FileShare.Read)
                            source.CopyTo(_cryptoStream)
                        End Using
                    Catch exception As CryptographicException

                        If exception.Message = "Padding is invalid and cannot be removed." Then
                            Throw New ApplicationException("Universal Microsoft Cryptographic Exception (Not to be believed!)", exception)
                        Else Throw
                        End If
                    End Try
                End Using
            End Using
        End Sub

        Public Sub EncryptFile(sourceFilename As String, destinationFilename As String, password As String)
            Dim aes As AesManaged = New AesManaged()
            aes.BlockSize = aes.LegalBlockSizes(0).MaxSize
            aes.KeySize = aes.LegalKeySizes(0).MaxSize
            ' NB: Rfc2898DeriveBytes initialization and subsequent calls to   GetBytes   must be exactly the same, including order, on both the encryption and decryption sides.
            Dim key As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(password, _salt, _iterations)
            aes.Key = key.GetBytes(aes.KeySize / 8)
            aes.IV = key.GetBytes(aes.BlockSize / 8)
            aes.Mode = CipherMode.CBC
            Dim transform As ICryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV)
            Using destination As FileStream = New FileStream(destinationFilename, FileMode.CreateNew, FileAccess.Write, FileShare.None)
                Using _cryptoStream As CryptoStream = New CryptoStream(destination, transform, CryptoStreamMode.Write)
                    Using source As FileStream = New FileStream(sourceFilename, FileMode.Open, FileAccess.Read, FileShare.Read)
                        source.CopyTo(_cryptoStream)
                    End Using
                End Using
            End Using
        End Sub
    End Class

    Sub scanProcesses()
        statusLabel.Text = "Scanning Running Processes..."
        Dim procs() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcesses
        Dim f As String
        For Each proc As System.Diagnostics.Process In procs

            f = GetProcessFileName(proc)
            '  If f.Length > 0 Then
            currentFile.Text = f.ToString()
            Dim sigProc As String = GetCRC32(f.ToString())
            statusLabel.Text = "CRC32 " & sigProc
            statusLabel.Refresh()

            Dim intValue As Integer
            intValue = Array.BinarySearch(signatures, sigProc)
            If intValue > 0 Then
                Dim row As String() = New String() {f.ToString(), sigProc, GetFileSize(f.ToString())}
                quarantineGridView.Rows.Add(row)
                numberInfected += 1
                numberInfectedFilesLabel.ForeColor = Color.Red
                numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
                scanProgressBar.BackColor = Color.Red
            Else
                'MsgBox("No value found", , "Error")
            End If
        Next
    End Sub

    'Sub scanProcessesFull()
    '    statusLabel.Text = "Scanning Running Processes..."
    '    Dim procs() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcesses
    '    Dim f As String
    '    For Each proc As System.Diagnostics.Process In procs

    '        f = GetProcessFileName(proc)
    '        '  If f.Length > 0 Then
    '        currentFile.Text = f.ToString()
    '        statusLabel.Text = "SHA-512 Hash " & GenerateSHA512String(f.ToString())
    '        statusLabel.Refresh()

    '        'Dim idx As Integer = signatures.IndexOf(GenerateSHA512String(f.ToString()))

    '        'If idx = -1 Then
    '        'Else
    '        '    Dim row As String() = New String() {(f.ToString()), (GenerateSHA512String(f.ToString())), GetFileSize((f.ToString()))}
    '        '    quarantineGridView.Rows.Add(row)
    '        '    numberInfected += 1
    '        '    numberInfectedFilesLabel.ForeColor = Color.Red
    '        '    numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
    '        'End If
    '    Next


    '    fullScanBGW.RunWorkerAsync()
    '    fullScanBGW.WorkerSupportsCancellation = True
    '    scanTimer.Start()
    '    elapsedTimerSW.Start()
    '    fileCountOn = 0
    '    CheckForIllegalCrossThreadCalls = False
    'End Sub


    Sub scanSubfolders(ByVal FolderLocation As String, ByVal lstbox As ListBox)
        For Each s In My.Computer.FileSystem.GetFiles(FolderLocation)
            Try
                lstbox.Items.Add(s)
            Catch ex As Exception

            End Try
        Next
        For Each s In My.Computer.FileSystem.GetDirectories(FolderLocation)
            Try
                scanSubfolders(s, ListBox3)
            Catch ex As Exception

            End Try
        Next
    End Sub

    Public Shared Function GenerateSHA512String(ByVal inputString As String) As String
        Dim sha512 As SHA512 = SHA512Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha512.ComputeHash(bytes)
        Return GetStringFromHash(hash)
    End Function

    Private Shared Function GetStringFromHash(ByVal hash As Byte()) As String
        Dim result As StringBuilder = New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            result.Append(hash(i).ToString("X2"))
        Next

        Return result.ToString()
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

    Private WithEvents MediaConnectWatcher As ManagementEventWatcher = Nothing
    Public USBDriveName As String
    Public USBDriveLetter As String

    Public Sub StartDetection()
        ' __InstanceOperationEvent will trap both Creation and Deletion of class instances
        Dim query2 As New WqlEventQuery("SELECT * FROM __InstanceOperationEvent WITHIN 1 " _
  & "WHERE TargetInstance ISA 'Win32_DiskDrive'")

        MediaConnectWatcher = New ManagementEventWatcher
        MediaConnectWatcher.Query = query2
        MediaConnectWatcher.Start()
    End Sub


    Private Sub Arrived(ByVal sender As Object, ByVal e As System.Management.EventArrivedEventArgs) Handles MediaConnectWatcher.EventArrived

        Dim mbo, obj As ManagementBaseObject

        ' the first thing we have to do is figure out if this is a creation or deletion event
        mbo = CType(e.NewEvent, ManagementBaseObject)
        ' next we need a copy of the instance that was either created or deleted
        obj = CType(mbo("TargetInstance"), ManagementBaseObject)

        Select Case mbo.ClassPath.ClassName
            Case "__InstanceCreationEvent"
                If obj("InterfaceType") = "USB" Then
                    'MsgBox(obj("Caption") & " (Drive letter " & GetDriveLetterFromDisk(obj("Name")) & ") has been plugged in")
                    USBDrivePluggedIn = "" & GetDriveLetterFromDisk(obj("Name")) & ""
                    If folderScanBGW.IsBusy = False And quickScanBGW.IsBusy = False And fullScanBGW.IsBusy = False Then
                        ScanUSBToast.scanUSBLabel.Text = "Would You Like To Scan The Newly Plugged In Device?  Device Name: " & USBDrivePluggedIn & "\"
                        ScanUSBToast.TextBox1.Text = USBDrivePluggedIn.ToString() & "\"
                        ScanUSBToast.ShowDialog()

                    End If

                Else
                    'MsgBox(obj("InterfaceType"))
                End If
            Case "__InstanceDeletionEvent"
                If obj("InterfaceType") = "USB" Then
                    ' MsgBox(obj("Caption") & " has been unplugged")
                    USBDrivePluggedIn = ""
                    If obj("Caption") = USBDriveName Then
                        USBDriveLetter = ""
                        USBDriveName = ""
                    End If
                Else
                    ' MsgBox(obj("InterfaceType"))
                End If
            Case Else
                'MsgBox("nope: " & obj("Caption"))
        End Select
    End Sub

    Private Function GetDriveLetterFromDisk(ByVal Name As String) As String
        Dim oq_part, oq_disk As ObjectQuery
        Dim mos_part, mos_disk As ManagementObjectSearcher
        Dim obj_part, obj_disk As ManagementObject
        Dim ans As String = ""

        ' WMI queries use the "\" as an escape charcter
        Name = Replace(Name, "\", "\\")

        ' First we map the Win32_DiskDrive instance with the association called
        ' Win32_DiskDriveToDiskPartition. Then we map the Win23_DiskPartion
        ' instance with the assocation called Win32_LogicalDiskToPartition

        oq_part = New ObjectQuery("ASSOCIATORS OF {Win32_DiskDrive.DeviceID=""" & Name & """} WHERE AssocClass = Win32_DiskDriveToDiskPartition")
        mos_part = New ManagementObjectSearcher(oq_part)
        For Each obj_part In mos_part.Get()

            oq_disk = New ObjectQuery("ASSOCIATORS OF {Win32_DiskPartition.DeviceID=""" & obj_part("DeviceID") & """} WHERE AssocClass = Win32_LogicalDiskToPartition")
            mos_disk = New ManagementObjectSearcher(oq_disk)
            For Each obj_disk In mos_disk.Get()
                ans &= obj_disk("Name") & ","
            Next
        Next

        Return ans.Trim(","c)
    End Function

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


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles minimizePicBox.Click
        If Me.WindowState = FormWindowState.Normal Then
            NotifyIcon1.Visible = True
            ShowInTaskbar = False
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub fullScanButton_Click(sender As Object, e As EventArgs) Handles fullScanButton.Click
        realTimeLabel.Visible = False
        realTimeOffButton.Visible = False
        realTimeOnButton.Visible = False
        copyHashButton.Visible = False
        filesPropertiesButton.Visible = False
        startFolderScan.Visible = False
        stopFolderScan.Visible = False
        stopFullScanButton.Visible = True
        startQuickScan.Visible = False
        startFullScan.Visible = True
        stopQuickScan.Visible = False
        quickScanLabel.Visible = False
        fullScanLabel.Visible = True
        quarantineLabel.Visible = False
        folderScanLabel.Visible = False
        quarantineGridView.Visible = False
        restoreAllButton.Visible = False
        restoreFileButton.Visible = False
        deleteAllButton.Visible = False
        deletefileButton.Visible = False
        quarantineGroupBox.Visible = False
        scanGroupBox.Visible = True
    End Sub

    Private Sub quickScanButton_Click(sender As Object, e As EventArgs) Handles quickScanButton.Click
        realTimeLabel.Visible = False
        realTimeOffButton.Visible = False
        realTimeOnButton.Visible = False
        copyHashButton.Visible = False
        filesPropertiesButton.Visible = False
        startFolderScan.Visible = False
        stopFolderScan.Visible = False
        stopFullScanButton.Visible = False
        startQuickScan.Visible = True
        startFullScan.Visible = False
        stopQuickScan.Visible = True
        quickScanLabel.Visible = True
        fullScanLabel.Visible = False
        quarantineLabel.Visible = False
        folderScanLabel.Visible = False
        quarantineGridView.Visible = False
        restoreAllButton.Visible = False
        restoreFileButton.Visible = False
        deleteAllButton.Visible = False
        deletefileButton.Visible = False
        quarantineGroupBox.Visible = False
        scanGroupBox.Visible = True
    End Sub

    Private Sub quarantineButton_Click(sender As Object, e As EventArgs) Handles quarantineButton.Click
        copyHashButton.Visible = True
        filesPropertiesButton.Visible = True
        startFolderScan.Visible = False
        stopFolderScan.Visible = False
        stopFullScanButton.Visible = False
        startQuickScan.Visible = False
        startFullScan.Visible = False
        stopQuickScan.Visible = False
        quickScanLabel.Visible = False
        fullScanLabel.Visible = False
        quarantineLabel.Visible = True
        folderScanLabel.Visible = False
        quarantineGridView.Visible = True
        restoreAllButton.Visible = True
        restoreFileButton.Visible = True
        deleteAllButton.Visible = True
        deletefileButton.Visible = True
        quarantineGroupBox.Visible = True
        scanGroupBox.Visible = False
    End Sub

    Private Sub folderScanButton_Click(sender As Object, e As EventArgs) Handles folderScanButton.Click
        realTimeLabel.Visible = False
        realTimeOffButton.Visible = False
        realTimeOnButton.Visible = False
        copyHashButton.Visible = False
        filesPropertiesButton.Visible = False
        startFolderScan.Visible = True
        stopFolderScan.Visible = True
        stopFullScanButton.Visible = False
        startQuickScan.Visible = False
        startFullScan.Visible = False
        stopQuickScan.Visible = False
        quickScanLabel.Visible = False
        fullScanLabel.Visible = False
        quarantineLabel.Visible = False
        folderScanLabel.Visible = True
        quarantineGridView.Visible = False
        restoreAllButton.Visible = False
        restoreFileButton.Visible = False
        deleteAllButton.Visible = False
        deletefileButton.Visible = False
        quarantineGroupBox.Visible = False
        scanGroupBox.Visible = True
    End Sub

    Private Sub exitPicBox_Click(sender As Object, e As EventArgs) Handles exitPicBox.Click
        If folderScanBGW.IsBusy = True Then
            If cancelFolderScan = True Then
                If (folderScanBGW.CancellationPending = True) Then
                    Do
                        If (folderScanBGW.CancellationPending = True) Then
                            If (folderScanBGW.IsBusy = True) Then
                                folderScanBGW.CancelAsync()
                            End If
                        End If
                    Loop
                End If
            End If
        ElseIf quickScanBGW.IsBusy = True Then
            If cancelQuickScan = True Then
                If (quickScanBGW.CancellationPending = True) Then
                    Do
                        If (quickScanBGW.CancellationPending = True) Then
                            If (quickScanBGW.IsBusy = True) Then
                                quickScanBGW.CancelAsync()
                            End If
                        End If
                    Loop
                End If
            End If
        ElseIf fullScanBGW.IsBusy = True Then
            If cancelFullScan = True Then
                If (fullScanBGW.CancellationPending = True) Then
                    Do
                        If (fullScanBGW.CancellationPending = True) Then
                            If (fullScanBGW.IsBusy = True) Then
                                fullScanBGW.CancelAsync()
                            End If
                        End If
                    Loop
                End If
            End If
        End If
        Me.Close()
    End Sub

    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next
        If MessageBox.Show("Are You Sure That You Want To Exit Mythodikal Anti-Virus?", "Exit Mythodikal Anti-Virus?", MessageBoxButtons.YesNo,
MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            e.Cancel = True
        Else
            MediaConnectWatcher.Stop()
        End If
    End Sub

    Private Sub startFolderScan_Click(sender As Object, e As EventArgs) Handles startFolderScan.Click
        cancelFolderScan = False
        Dim blah As New FolderBrowserDialog
        blah.ShowNewFolderButton = True
        If (blah.ShowDialog() = DialogResult.OK) Then
            currentDirectory = blah.SelectedPath & "\"
        Else
            Exit Sub
        End If
        If folderScanBGW.IsBusy = True Then
            Exit Sub
        Else
            startFolderScan.Enabled = True
            statusLabel.Text = "Program May Become Unresponsive For A Moment While Loading Parts Of The Scan List."
            statusLabel.Refresh()
            WriteToLog("Folder Scan Started At: " & Date.Now.ToString() & "")
            folderScanBGW.RunWorkerAsync()
            folderScanBGW.WorkerSupportsCancellation = True
            fileCountOn = 0
            CheckForIllegalCrossThreadCalls = False
            scanTimer.Start()
            elapsedTimerSW.Start()
            fileCountOn = 0
        End If
    End Sub




    'Public Shared Async Function ProcessDirectoryAsync2(ByVal path As String, ByVal searchPattern As String) As Task(Of IEnumerable(Of String))
    '    Dim subdirs = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly)
    '    Dim results = Await Task.WhenAll(subdirs.[Select](Function(s) Task.Run(Function() (s))))
    '    Return results
    'End Function

    Public Shared Async Function ProcessDirectoryAsync(ByVal path As String, ByVal searchPattern As String) As Task(Of IEnumerable(Of String))
        Dim files = Directory.GetFiles(path, searchPattern, SearchOption.AllDirectories)
        Dim subdirs = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly)
        Dim results = Await Task.WhenAll(files.[Select](Function(f) Task.Run(Function() (f))))
        Dim results2 = Await Task.WhenAll(subdirs.[Select](Function(s) Task.Run(Function() (s))))
        Return results
        Return results2
    End Function



    'Public Shared Function Decode(ByVal body As String)
    '    Dim validChecksum As String = ""
    '    'If body Is Nothing Then Throw New ArgumentNullException(NameOf(body))
    '    'If body.Length < 12 Then Throw New InvalidOperationException("Ops, wrong size of input packet")
    '    Using zip As New ZipFile(body)
    '        For Each entry In zip
    '            Using memoryStream = New MemoryStream(entry.FileName)
    '                'Dim e1 As ZipEntry = zip.Item(entry.FileName)
    '                'Using s As Ionic.Crc.CrcCalculatorStream = e1.OpenReader
    '                Using binaryread As New BinaryReader(memoryStream)

    '                    Dim packetLength = binaryread.ReadInt32()



    '                    If (packetLength < 12) Then
    '                        Throw New InvalidOperationException(String.Format("invalid packet length: {0}", packetLength))
    '                    End If

    '                    Dim seq = binaryread.ReadInt32()
    '                    Dim packet As Byte() = binaryread.ReadBytes(packetLength - 12)
    '                    Dim checksum = (Int(binaryread.ReadInt32()))

    '                    Dim crc32 = New Ionic.Crc.CRC32()
    '                    crc32.SlurpBlock(packet, 0, packetLength - 4)

    '                    validChecksum = crc32.Crc32Result

    '                    If (Not (checksum = validChecksum)) Then

    '                        Throw New InvalidOperationException("invalid checksum! skip")
    '                    End If
    '                    MessageBox.Show(crc32.Crc32Result)
    '                End Using
    '            End Using
    '        Next
    '    End Using

    '    Return validChecksum

    'End Function

    Private Sub folderScanBGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles folderScanBGW.DoWork
        On Error Resume Next
        CheckForIllegalCrossThreadCalls = False
        folderScanBGW.WorkerSupportsCancellation = True

        scanSubfolders(currentDirectory, Me.ListBox3)
        '        'fileCount = 0

        '        Dim _searchPatternList As List(Of String) = New List(Of String)()
        '        Dim allowedPrograms As List(Of String) = New List(Of String)()
        '        Dim SourceDir As DirectoryInfo = New DirectoryInfo(currentDirectory)


        '        For Each ChildFile In SourceDir.GetFiles()
        '            If cancelFolderScan = True Then
        '                If (folderScanBGW.CancellationPending = True) Then
        '                    Do
        '                        If (folderScanBGW.CancellationPending = True) Then
        '                            If (folderScanBGW.IsBusy = True) Then
        '                                folderScanBGW.CancelAsync()
        '                                e.Cancel = True
        '                                Exit For
        '                            End If
        '                        End If
        '                    Loop
        '                End If
        '            End If
        '            Dim myExtension As String = System.IO.Path.GetExtension(ChildFile.FullName)
        '            currentFile.Text = ChildFile.FullName
        '            If myExtension = ".zip" Or myExtension = "*.gzip" Or myExtension = "*.rar" Or myExtension = "*.7zip" Then
        '                '   Dim crc32 As New Ionic.Crc.CRC32
        '                'Using zip1 As New ZipFile(ChildFile.FullName)
        '                '    Dim s1 As String
        '                '    For Each s1 In zip1
        '                '        Dim blah = New ICSharpCode.SharpZipLib.Checksum.Crc32
        '                '        MessageBox.Show(blah.Equals(s1.ToString()))
        '                '    Next
        '                'End Using
        '                '' Dim blah As New FileInfo(entry.ToString())

        '                'MessageBox.Show(validChecksum)

        '                '        currentFile.Refresh()
        '                '        statusLabel.Text = "CRC32 Hash: " & (validChecksum)
        '                '        statusLabel.Refresh()


        '                'If currentSHA512Hash = "a9f49cff5a3eef0d9acb33ac5d81bf8b80ac879133c3b2405f4bf0ba8c21140d252f1a66bebfc0515ffd05035b315c78ed406dc5855b0f66664dbdc45ad3d496" Then
        '                '            Dim row As String() = New String() {ChildFile.FullName, currentSHA512Hash, GetFileSize(ChildFile.FullName)}
        '                '            quarantineGridView.Rows.Add(row)
        '                '            numberInfected += 1
        '                '            numberInfectedFilesLabel.ForeColor = Color.Red
        '                '            numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
        '                '            'ProgressBar1.BackColor = Color.Red
        '                '        End If

        '                '    Next

        '                'End Using
        '                'fileCountOn += 1

        '                'GoTo nextfile
        '            End If











        '            fileCountOn += 1






        '            If ChildFile.Length >= 4194304 Then
        '                GoTo nextfile
        '            Else
        '                If cancelFolderScan = True Then
        '                    fileCountOn = 0
        '                    'fileCount = 0
        '                    fileCountLabel.Text = "0 Out Of 0"
        '                    numberInfectedFilesLabel.Text = "0"
        '                    numberInfectedFilesLabel.ForeColor = Color.White
        '                    ProgressBar1.ForeColor = Color.Blue
        '                    percentLabel.Text = "0%"
        '                    ProgressBar1.Value = 0
        '                    scanningFileLabel.Text = "File Being Scanned"
        '                    currentFile.Text = ""
        '                    folderScanBGW.CancelAsync()
        '                    Exit Sub
        '                End If
        '                Dim secondsTotal As Integer = elapsedTimerSW.Elapsed.TotalSeconds

        '                seconds1 = secondsTotal
        '                If seconds1 = 60 Then
        '                    secondsTotal = 0
        '                    seconds1 = 0
        '                    elapsedTimerSW.Restart()
        '                    minutes1 += 1
        '                    If minutes1 = 60 Then
        '                        hours1 += 1
        '                        minutes1 = 0
        '                    End If
        '                End If

        '                ' MessageBox.Show(GetCRC32(ChildFile.FullName()))

        '                elapsedTimeLabel.Text = "" & hours1.ToString() & " Hour(s) - " & minutes1.ToString() & " Minute(s) - " & seconds1.ToString() & " Second(s)"
        '                elapsedTimeLabel.Refresh()


        '                For x As Integer = 0 To ListBox2.Items.Count - 1
        '                    If cancelFolderScan = True Then

        '                        If (folderScanBGW.CancellationPending = True) Then
        '                            Do
        '                                If (folderScanBGW.CancellationPending = True) Then
        '                                    If (folderScanBGW.IsBusy = True) Then
        '                                        folderScanBGW.CancelAsync()
        '                                        e.Cancel = True
        '                                        Exit For
        '                                    End If

        '                                End If
        '                            Loop
        '                        End If

        '                    End If
        '                    Dim fileNow As String = ListBox2.Items(x).Substring(0, ListBox2.Items(x).Length - 1)
        '                    If (fileNow = (ChildFile.FullName)) Then
        '                        GoTo nextfile
        '                    Else
        '                        Exit For
        '                    End If
        '                Next

        '                'For i = 0 To ListBox1.Items.Count - 1

        '                '    ListBox1.SelectedIndex = i
        '                '    Dim myVariable As String = System.IO.Path.GetExtension(ChildFile.ToString())

        '                '    Dim blah As String = ListBox1.Items(i).ToString.Remove(0, 1)
        '                '    If blah = myVariable Then



        '                currentFile.Text = "" & ChildFile.FullName
        '                currentFile.Refresh()


        '                statusLabel.Text = "CRC32 Hash: " & GetCRC32(ChildFile.FullName)
        '                statusLabel.Refresh()

        '                fileCountOn += 1


        '                fileCountLabel.Text = "" & fileCount
        '                fileCountLabel.Refresh()



        '                Dim stringtosearch As String = GetCRC32(ChildFile.FullName)

        '                filterData(stringtosearch)
        '                If DataGridView1.Rows.Count > 0 Then

        '                    Dim row As String() = New String() {ChildFile.FullName, stringtosearch, GetFileSize(ChildFile.FullName)}
        '                    quarantineGridView.Rows.Add(row)
        '                    numberInfected += 1
        '                    numberInfectedFilesLabel.ForeColor = Color.Red
        '                    numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
        '                    DataGridView1.Rows.Clear()
        '                End If

        '                'Else
        '                '    'nothing TODO
        '                'End If

        '                'Next
        'nextfile:
        '            End If

        '        Next



        '        Dim SubDir As DirectoryInfo

        '        For Each SubDir In SourceDir.GetDirectories()
        '            If cancelFolderScan = True Then
        '                If (folderScanBGW.CancellationPending = True) Then
        '                    Do
        '                        If (folderScanBGW.CancellationPending = True) Then
        '                            If (folderScanBGW.IsBusy = True) Then
        '                                folderScanBGW.CancelAsync()
        '                                e.Cancel = True
        '                                Exit For
        '                            End If

        '                        End If
        '                    Loop
        '                End If
        '            End If
        '            RecursiveFileGetter(SubDir.FullName)
        '        Next
    End Sub




    Public Function GetCRC32(ByVal sFileName As String) As String
        Try
            Dim FS As FileStream = New FileStream(sFileName, FileMode.Open, System.IO.FileAccess.Read, FileShare.Read, 4096)
            Dim CRC32Result As Integer = &HFFFFFFFF
            If FS.Length < 1024 Then
                Dim blah As String = FS.Length
                Dim Buffer(blah.ToString) As Byte
                Dim ReadSize As Integer = FS.Length


                Dim Count As Integer = FS.Read(Buffer, 0, ReadSize)
                Dim CRC32Table(256) As Integer
                Dim DWPolynomial As Integer = &HEDB88320
                Dim DWCRC As Integer
                Dim i As Integer, j As Integer, n As Integer

                'Create CRC32 Table
                For i = 0 To 255
                    DWCRC = i
                    For j = 8 To 1 Step -1
                        If (DWCRC And 1) Then
                            DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                            DWCRC = DWCRC Xor DWPolynomial
                        Else
                            DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                        End If
                    Next j
                    CRC32Table(i) = DWCRC
                Next i

                'Calcualting CRC32 Hash
                Do While (Count > 0)
                    For i = 0 To Count - 1
                        n = (CRC32Result And &HFF) Xor Buffer(i)
                        CRC32Result = ((CRC32Result And &HFFFFFF00) \ &H100) And &HFFFFFF
                        CRC32Result = CRC32Result Xor CRC32Table(n)
                    Next i
                    Count = FS.Read(Buffer, 0, ReadSize)
                Loop
                Return Hex(Not (CRC32Result))
            Else
                Dim Buffer(1024) As Byte
                Dim ReadSize As Integer = 1024

                Dim Count As Integer = FS.Read(Buffer, 0, ReadSize)
                Dim CRC32Table(256) As Integer
                Dim DWPolynomial As Integer = &HEDB88320
                Dim DWCRC As Integer
                Dim i As Integer, j As Integer, n As Integer

                'Create CRC32 Table
                For i = 0 To 255
                    DWCRC = i
                    For j = 8 To 1 Step -1
                        If (DWCRC And 1) Then
                            DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                            DWCRC = DWCRC Xor DWPolynomial
                        Else
                            DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                        End If
                    Next j
                    CRC32Table(i) = DWCRC
                Next i

                'Calcualting CRC32 Hash
                Do While (Count > 0)
                    For i = 0 To Count - 1
                        n = (CRC32Result And &HFF) Xor Buffer(i)
                        CRC32Result = ((CRC32Result And &HFFFFFF00) \ &H100) And &HFFFFFF
                        CRC32Result = CRC32Result Xor CRC32Table(n)
                    Next i
                    Count = FS.Read(Buffer, 0, ReadSize)
                Loop
                Return Hex(Not (CRC32Result))
            End If

        Catch ex As Exception
            Return ""
        End Try

    End Function


    Private Sub menuPicBox_Click(sender As Object, e As EventArgs) Handles menuPicBox.Click
        Dim btn As PictureBox = CType(sender, PictureBox)
        ContextMenuStrip1.Show(btn, New System.Drawing.Point(0, btn.Height))
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            ctrl.Enabled = False
        Next
        statusLabel.Enabled = True
        titleLabel.Enabled = True
        Panel1.Enabled = True

        CheckForIllegalCrossThreadCalls = False
        statusLabel.Text = "Loading Virus Signature Database.  This Should Take Less Than A Minutes To Load.  Thanks For Being Patient..."
        statusLabel.Refresh()
        getSignatures.RunWorkerAsync()
        minimizePicBox.Enabled = True
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles folderScanBGW.RunWorkerCompleted
        'If cancelFolderScan = True Then
        '    statusLabel.Text = ("Folder Scan Cancelled! - Scanned A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text)
        '    statusLabel.Refresh()
        '    currentFile.Text = ""
        '    fileCountOn = 0
        '    fileCountLabel.Text = "0 Out Of 0"
        '    numberInfectedFilesLabel.Text = "0"
        '    numberInfectedFilesLabel.ForeColor = Color.White
        '    scanProgressBar.ForeColor = Color.Blue
        '    percentLabel.Text = "0%"
        '    scanProgressBar.Value = 0
        '    elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
        '    cancelFolderScan = False
        '    elapsedTimerSW.Stop()
        '    elapsedTimerSW.Reset()
        '    If My.Settings.USBDriveScan = True Then
        '        statusLabel.Text = ("USB Device Scan Cancelled! - Scanned A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text)
        '        statusLabel.Refresh()
        '        My.Settings.USBDriveScan = False
        '        Timer1.Enabled = True
        '    End If
        'Else
        '    statusLabel.Text = ("Folder Scan Conmpleted! - Scanned A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text)
        '    statusLabel.Refresh()
        '    currentFile.Text = ""
        '    fileCountOn = 0
        '    'fileCount = 0
        '    fileCountLabel.Text = "0 Out Of 0"
        '    numberInfectedFilesLabel.Text = "0"
        '    numberInfectedFilesLabel.ForeColor = Color.White
        '    scanProgressBar.ForeColor = Color.Blue
        '    percentLabel.Text = "0%"
        '    scanProgressBar.Value = 0
        '    cancelFullScan = False
        '    elapsedTimerSW.Stop()
        '    elapsedTimerSW.Reset()
        '    elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
        '    If My.Settings.USBDriveScan = True Then
        '        statusLabel.Text = ("USB Device Scan Completed! - Scanned A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text)
        '        statusLabel.Refresh()
        '        My.Settings.USBDriveScan = False
        '        Timer1.Enabled = True
        '    End If
        'End If
    End Sub


    Public Function sha512hashOfFile(ByVal fileToHash As String) As String
        Dim rdr As FileStream
        Dim sha As New SHA512CryptoServiceProvider
        Dim bytes() As Byte
        Dim rtn As String = ""
        If File.Exists(fileToHash) Then
            rdr = New FileStream(fileToHash, FileMode.Open, System.IO.FileAccess.Read)
            bytes = sha.ComputeHash(rdr)
            rtn = ByteArrayToString(bytes)
        End If
        Return rtn
    End Function

    Private Function ByteArrayToString(ByVal arrInput() As Byte) As String
        Dim sb As New System.Text.StringBuilder(arrInput.Length * 2)
        For i As Integer = 0 To arrInput.Length - 1
            sb.Append(arrInput(i).ToString("X2"))
        Next
        Return sb.ToString().ToLower
    End Function

    Dim DoubleBytes As Double

    Public Function GetFileSize(ByVal TheFile As String) As String
        If TheFile.Length = 0 Then Return ""
        If Not System.IO.File.Exists(TheFile) Then Return ""
        '---
        Dim TheSize As ULong = My.Computer.FileSystem.GetFileInfo(TheFile).Length
        Dim SizeType As String = ""
        '---

        Try
            Select Case TheSize
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(TheSize / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(TheSize / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(TheSize / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(TheSize / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = TheSize ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function


    Private Sub stopFolderScan_Click(sender As Object, e As EventArgs) Handles stopFolderScan.Click
        cancelFolderScan = True
        scanTimer.Stop()
        folderScanBGW.Dispose()
        If cancelFolderScan = True Then
            If ListBox1.Items.Count = 0 Then
                statusLabel.Text = ("Folder Scan Cancelled Scanning - A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - " & ListBox1.Items.Count & " Threats Detected")
                statusLabel.Refresh()
                WriteToLog("" & ListBox1.Items.Count & " Threats Were Detected.")
            Else
                statusLabel.Text = ("Folder Scan Cancelled Scanning - A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - No Threats Detected")
                statusLabel.Refresh()
                WriteToLog("No Threats Were Detected.")
            End If
            currentFile.Text = ""
            fileCountOn = 0
            fileCountLabel.Text = "0 Out Of 0"
            numberInfectedFilesLabel.Text = "0"
            numberInfectedFilesLabel.ForeColor = Color.White
            scanProgressBar.ForeColor = Color.Blue
            percentLabel.Text = "0%"
            scanProgressBar.Value = 0
            elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
            cancelFolderScan = False
            elapsedTimerSW.Stop()
            elapsedTimerSW.Reset()
            If My.Settings.USBDriveScan = True Then
                statusLabel.Text = ("USB Device Scan Cancelled! - Scanned A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text)
                WriteToLog("" & ListBox1.Items.Count & " Threats Were Detected.")
                statusLabel.Refresh()
                My.Settings.USBDriveScan = False
                USBDriveScanTimer.Enabled = True
            End If
        Else
            If ListBox1.Items.Count = 0 Then
                statusLabel.Text = ("Folder Scan Completed Scanning - A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - " & ListBox1.Items.Count & " Threats Detected")
                statusLabel.Refresh()
                WriteToLog("" & ListBox1.Items.Count & " Threats Were Detected.")
            Else
                statusLabel.Text = ("Folder Scan Completed Scanning - A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - No Threats Detected")
                statusLabel.Refresh()
                WriteToLog("No Threats Were Detected.")
            End If
            currentFile.Text = ""
            fileCountOn = 0
            'fileCount = 0
            fileCountLabel.Text = "0 Out Of 0"
            numberInfectedFilesLabel.Text = "0"
            numberInfectedFilesLabel.ForeColor = Color.White
            scanProgressBar.ForeColor = Color.Blue
            percentLabel.Text = "0%"
            scanProgressBar.Value = 0
            cancelFullScan = False
            elapsedTimerSW.Stop()
            elapsedTimerSW.Reset()
            elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
            If My.Settings.USBDriveScan = True Then
                statusLabel.Text = ("USB Device Scan Completed! - Scanned A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text)
                statusLabel.Refresh()
                WriteToLog("USB Device Scan Was Completed By User At: " & Date.Now & "")
                WriteToLog("" & ListBox1.Items.Count & " Threats Were Detected.")
                My.Settings.USBDriveScan = False
                USBDriveScanTimer.Enabled = True
            End If
        End If
        elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
        elapsedTimeLabel.Refresh()
    End Sub

    Private Sub startQuickScan_Click(sender As Object, e As EventArgs) Handles startQuickScan.Click
        CheckForIllegalCrossThreadCalls = False
        If quickScanBGW.IsBusy = True Then
            Exit Sub
        Else
            startQuickScan.Enabled = False
            statusLabel.Text = "Program May Become Unresponsive For A Moment While Loading Parts Of The Scan List."
            statusLabel.Refresh()
            WriteToLog("Quick Scan Started At: " & Date.Now.ToString() & "")
            scanRunningProcessesQuick.RunWorkerAsync()


        End If
    End Sub

    '    Private Sub RecursiveFileGetter3(ByVal SourcePath As String)
    '        statusLabel.Text = "Scanning Running Processes..."
    '        Dim procs() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcesses
    '        Dim f As String

    '        For Each proc As System.Diagnostics.Process In procs
    '            f = GetProcessFileName(proc)
    '            '  If f.Length > 0 Then
    '            currentFile.Text = f.ToString()
    '            statusLabel.Text = "CRC32 Hash " & GetCRC32(f.ToString())
    '            statusLabel.Refresh()
    '            'fileCountOn += 1
    '            fileCountLabel.Text = "" & fileCountOn & " Out Of " & ListBox3.Items.Count & ""
    '            fileCountLabel.Refresh()

    '            If currentSHA512Hash = "a9f49cff5a3eef0d9acb33ac5d81bf8b80ac879133c3b2405f4bf0ba8c21140d252f1a66bebfc0515ffd05035b315c78ed406dc5855b0f66664dbdc45ad3d496" Then
    '                Dim row As String() = New String() {(f.ToString()), currentSHA512Hash, GetFileSize((f.ToString()))}
    '                quarantineGridView.Rows.Add(row)
    '                numberInfected += 1
    '                numberInfectedFilesLabel.ForeColor = Color.Red
    '                numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
    '                scanProgressBar.BackColor = Color.Red
    '            End If

    '            If cancelQuickScan = True Then
    '                If (quickScanBGW.CancellationPending = True) Then
    '                    Do
    '                        If (quickScanBGW.CancellationPending = True) Then
    '                            If (quickScanBGW.IsBusy = True) Then
    '                                quickScanBGW.CancelAsync()
    '                                'e.Cancel = True
    '                                Exit For
    '                            End If

    '                        End If
    '                    Loop
    '                End If
    '            End If

    '        Next




    '        Dim _searchPatternList As List(Of String) = New List(Of String)()
    '        Dim allowedPrograms As List(Of String) = New List(Of String)()
    '        Dim SourceDir As DirectoryInfo = New DirectoryInfo(SourcePath)
    '        Try

    '            For Each ChildFile In SourceDir.GetFiles()
    '                If cancelQuickScan = True Then
    '                    If (quickScanBGW.CancellationPending = True) Then
    '                        Do
    '                            If (quickScanBGW.CancellationPending = True) Then
    '                                If (quickScanBGW.IsBusy = True) Then
    '                                    quickScanBGW.CancelAsync()
    '                                    'e.Cancel = True
    '                                    Exit For
    '                                End If

    '                            End If
    '                        Loop
    '                    End If
    '                End If


    '                If ChildFile.Length >= 4194304 Then
    '                    GoTo nextfile
    '                Else
    '                    If cancelFolderScan = True Then
    '                        fileCountOn = 0
    '                        'fileCount = 0
    '                        fileCountLabel.Text = "0 Out Of 0"
    '                        numberInfectedFilesLabel.Text = "0"
    '                        numberInfectedFilesLabel.ForeColor = Color.White
    '                        scanProgressBar.ForeColor = Color.Blue
    '                        percentLabel.Text = "0%"
    '                        scanProgressBar.Value = 0
    '                        scanningFileLabel.Text = "File Being Scanned"
    '                        currentFile.Text = ""
    '                        folderScanBGW.CancelAsync()
    '                        Exit Sub
    '                    End If
    '                    Dim secondsTotal As Integer = elapsedTimerSW.Elapsed.TotalSeconds

    '                    seconds1 = secondsTotal
    '                    If seconds1 = 60 Then
    '                        secondsTotal = 0
    '                        seconds1 = 0
    '                        elapsedTimerSW.Restart()
    '                        minutes1 += 1
    '                        If minutes1 = 60 Then
    '                            hours1 += 1
    '                            minutes1 = 0
    '                        End If
    '                    End If



    '                    elapsedTimeLabel.Text = "" & hours1.ToString() & " Hour(s) - " & minutes1.ToString() & " Minute(s) - " & seconds1.ToString() & " Second(s)"
    '                    elapsedTimeLabel.Refresh()

    '                    For x As Integer = 0 To ListBox2.Items.Count - 1
    '                        If cancelQuickScan = True Then
    '                            If (quickScanBGW.CancellationPending = True) Then
    '                                Do
    '                                    If (quickScanBGW.CancellationPending = True) Then
    '                                        If (quickScanBGW.IsBusy = True) Then
    '                                            quickScanBGW.CancelAsync()
    '                                            'e.Cancel = True
    '                                            Exit For
    '                                        End If

    '                                    End If
    '                                Loop
    '                            End If
    '                        End If
    '                        If (ListBox2.Items(x).ToString.Contains(ChildFile.FullName & "\")) Then

    '                            GoTo nextfile
    '                        End If
    '                    Next



    '                    For i = 0 To ListBox1.Items.Count - 1

    '                        ListBox1.SelectedIndex = i
    '                        Dim myVariable As String = System.IO.Path.GetExtension(ChildFile.ToString())

    '                        Dim blah As String = ListBox1.Items(i).ToString.Remove(0, 1)
    '                        If blah = myVariable Then



    '                            currentFile.Text = "" & ChildFile.FullName
    '                            currentFile.Refresh()

    '                            statusLabel.Text = "CRC32 Hash " & GetCRC32(ChildFile.FullName)
    '                            statusLabel.Refresh()
    '                            fileCountOn += 1

    '                            fileCountLabel.Text = "" & fileCountOn & " Out Of " & ListBox3.Items.Count & ""
    '                            fileCountLabel.Refresh()

    '                            If currentSHA512Hash = "a9f49cff5a3eef0d9acb33ac5d81bf8b80ac879133c3b2405f4bf0ba8c21140d252f1a66bebfc0515ffd05035b315c78ed406dc5855b0f66664dbdc45ad3d496" Then
    '                                Dim row As String() = New String() {ChildFile.FullName, currentSHA512Hash, GetFileSize(ChildFile.FullName)}
    '                                quarantineGridView.Rows.Add(row)
    '                                numberInfected += 1
    '                                numberInfectedFilesLabel.ForeColor = Color.Red
    '                                numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
    '                                scanProgressBar.BackColor = Color.Red
    '                            End If

    '                        Else
    '                        End If

    '                    Next
    'nextfile:
    '                End If

    '            Next



    '            Dim SubDir As DirectoryInfo

    '            For Each SubDir In SourceDir.GetDirectories()
    '                If cancelQuickScan = True Then
    '                    If (quickScanBGW.CancellationPending = True) Then
    '                        Do
    '                            If (quickScanBGW.CancellationPending = True) Then
    '                                If (quickScanBGW.IsBusy = True) Then
    '                                    quickScanBGW.CancelAsync()
    '                                    'e.Cancel = True
    '                                    Exit For
    '                                End If

    '                            End If
    '                        Loop
    '                    End If
    '                End If
    '                RecursiveFileGetter(SubDir.FullName)

    '            Next

    '        Catch ex As UnauthorizedAccessException
    '        End Try
    '    End Sub



    Private Sub quickScanBGW_DoWork(sender As Object, e As DoWorkEventArgs) Handles quickScanBGW.DoWork
        On Error Resume Next
        CheckForIllegalCrossThreadCalls = False
        quickScanBGW.WorkerSupportsCancellation = True

        scanSubfolders(mainDrive & "\Windows\System", Me.ListBox3)
        scanSubfolders(mainDrive & "\Windows\System32", Me.ListBox3)


        '        For Each quickScan As String In quickScanDirectories
        '            currentDirectory = quickScan
        '            statusLabel.Text = "Scanning Running Processes..."
        '            Dim procs() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcesses
        '            Dim f As String

        '            For Each proc As System.Diagnostics.Process In procs
        '                If cancelQuickScan = True Then

        '                    If (quickScanBGW.CancellationPending = True) Then
        '                        Do
        '                            If (quickScanBGW.CancellationPending = True) Then
        '                                If (quickScanBGW.IsBusy = True) Then
        '                                    quickScanBGW.CancelAsync()
        '                                    e.Cancel = True
        '                                    Exit For
        '                                End If

        '                            End If
        '                        Loop
        '                    End If

        '                End If
        '                f = GetProcessFileName(proc)
        '                '  If f.Length > 0 Then
        '                currentFile.Text = f.ToString()
        '                statusLabel.Text = "CRC32 Hash " & GetCRC32(f.ToString())
        '                statusLabel.Refresh()
        '                fileCountOn += 1
        '                fileCountLabel.Text = "" & fileCount
        '                fileCountLabel.Refresh()

        '                If currentSHA512Hash = "a9f49cff5a3eef0d9acb33ac5d81bf8b80ac879133c3b2405f4bf0ba8c21140d252f1a66bebfc0515ffd05035b315c78ed406dc5855b0f66664dbdc45ad3d496" Then
        '                    Dim row As String() = New String() {(f.ToString()), currentSHA512Hash, GetFileSize((f.ToString()))}
        '                    quarantineGridView.Rows.Add(row)
        '                    numberInfected += 1
        '                    numberInfectedFilesLabel.ForeColor = Color.Red
        '                    numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
        '                    ProgressBar1.BackColor = Color.Red
        '                End If

        '            Next




        '            Dim _searchPatternList As List(Of String) = New List(Of String)()
        '            Dim allowedPrograms As List(Of String) = New List(Of String)()
        '            Dim SourceDir As DirectoryInfo = New DirectoryInfo(currentDirectory)
        '            Try

        '                For Each ChildFile In SourceDir.GetFiles()
        '                    If cancelQuickScan = True Then

        '                        If (quickScanBGW.CancellationPending = True) Then
        '                            Do
        '                                If (quickScanBGW.CancellationPending = True) Then
        '                                    If (quickScanBGW.IsBusy = True) Then
        '                                        quickScanBGW.CancelAsync()
        '                                        e.Cancel = True
        '                                        Exit For
        '                                    End If

        '                                End If
        '                            Loop
        '                        End If

        '                    End If


        '                    If ChildFile.Length >= 4194304 Then
        '                        GoTo nextfile
        '                    Else
        '                        If cancelFolderScan = True Then
        '                            fileCountOn = 0
        '                            'fileCount = 0
        '                            fileCountLabel.Text = "0 Out Of 0"
        '                            numberInfectedFilesLabel.Text = "0"
        '                            numberInfectedFilesLabel.ForeColor = Color.White
        '                            ProgressBar1.ForeColor = Color.Blue
        '                            percentLabel.Text = "0%"
        '                            ProgressBar1.Value = 0
        '                            scanningFileLabel.Text = "File Being Scanned"
        '                            currentFile.Text = ""
        '                            If cancelQuickScan = True Then

        '                                If (quickScanBGW.CancellationPending = True) Then
        '                                    Do
        '                                        If (quickScanBGW.CancellationPending = True) Then
        '                                            If (quickScanBGW.IsBusy = True) Then
        '                                                quickScanBGW.CancelAsync()
        '                                                e.Cancel = True
        '                                                Exit For
        '                                            End If

        '                                        End If
        '                                    Loop
        '                                End If
        '                            End If
        '                        End If

        '                        Dim secondsTotal As Integer = elapsedTimerSW.Elapsed.TotalSeconds

        '                        seconds1 = secondsTotal
        '                        If seconds1 = 60 Then
        '                            secondsTotal = 0
        '                            seconds1 = 0
        '                            elapsedTimerSW.Restart()
        '                            minutes1 += 1
        '                            If minutes1 = 60 Then
        '                                hours1 += 1
        '                                minutes1 = 0
        '                            End If
        '                        End If



        '                        elapsedTimeLabel.Text = "" & hours1.ToString() & " Hour(s) - " & minutes1.ToString() & " Minute(s) - " & seconds1.ToString() & " Second(s)"
        '                        elapsedTimeLabel.Refresh()

        '                        For x As Integer = 0 To ListBox2.Items.Count - 1
        '                            If cancelQuickScan = True Then

        '                                If (quickScanBGW.CancellationPending = True) Then
        '                                    Do
        '                                        If (quickScanBGW.CancellationPending = True) Then
        '                                            If (quickScanBGW.IsBusy = True) Then
        '                                                quickScanBGW.CancelAsync()
        '                                                e.Cancel = True
        '                                                Exit For
        '                                            End If

        '                                        End If
        '                                    Loop
        '                                End If

        '                            End If
        '                            Dim fileNow As String = ListBox2.Items(x).ToString.Substring(ListBox2.Items(x).ToString - 1)
        '                            If (fileNow = (ChildFile.FullName)) Then
        '                                GoTo nextfile
        '                            Else
        '                                Exit For
        '                            End If
        '                        Next
        '                    End If




        '                    For i = 0 To ListBox1.Items.Count - 1

        '                        ListBox1.SelectedIndex = i
        '                        Dim myVariable As String = System.IO.Path.GetExtension(ChildFile.ToString())

        '                        Dim blah As String = ListBox1.Items(i).ToString.Remove(0, 1)
        '                        If blah = myVariable Then



        '                            currentFile.Text = "" & ChildFile.FullName
        '                            currentFile.Refresh()

        '                            statusLabel.Text = "CRC32 Hash " & GetCRC32(ChildFile.FullName)
        '                            statusLabel.Refresh()
        '                            fileCountOn += 1

        '                            fileCountLabel.Text = "" & fileCount
        '                            fileCountLabel.Refresh()

        '                            If currentSHA512Hash = "a9f49cff5a3eef0d9acb33ac5d81bf8b80ac879133c3b2405f4bf0ba8c21140d252f1a66bebfc0515ffd05035b315c78ed406dc5855b0f66664dbdc45ad3d496" Then
        '                                Dim row As String() = New String() {ChildFile.FullName, currentSHA512Hash, GetFileSize(ChildFile.FullName)}
        '                                quarantineGridView.Rows.Add(row)
        '                                numberInfected += 1
        '                                numberInfectedFilesLabel.ForeColor = Color.Red
        '                                numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
        '                                ProgressBar1.BackColor = Color.Red
        '                            End If

        '                        Else
        '                        End If

        '                    Next
        'nextfile:

        '                Next



        '                Dim SubDir As DirectoryInfo

        '                For Each SubDir In SourceDir.GetDirectories()
        '                    If cancelQuickScan = True Then

        '                        If (quickScanBGW.CancellationPending = True) Then
        '                            Do
        '                                If (quickScanBGW.CancellationPending = True) Then
        '                                    If (quickScanBGW.IsBusy = True) Then
        '                                        quickScanBGW.CancelAsync()
        '                                        e.Cancel = True
        '                                        Exit For
        '                                    End If

        '                                End If
        '                            Loop
        '                        End If

        '                    End If

        '                    RecursiveFileGetter(SubDir.FullName)

        '                Next

        '            Catch ex As UnauthorizedAccessException
        '            End Try
        '        Next
    End Sub


    Private Sub stopQuickScan_Click(sender As Object, e As EventArgs) Handles stopQuickScan.Click
        cancelQuickScan = True
        scanTimer.Stop()
        folderScanBGW.Dispose()
        If cancelQuickScan = True Then
            If ListBox1.Items.Count = 0 Then
                statusLabel.Text = ("Quick Scan Cancelled Scanning - A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - " & ListBox1.Items.Count & " Threats Detected")
                statusLabel.Refresh()
                WriteToLog("" & ListBox1.Items.Count & " Threats Were Detected.")
            Else
                statusLabel.Text = ("Quick Scan Cancelled Scanning - A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - No Threats Detected")
                statusLabel.Refresh()
                WriteToLog("No Threats Were Detected.")
            End If
            currentFile.Text = ""
            fileCountOn = 0
            fileCountLabel.Text = "0 Out Of 0"
            numberInfectedFilesLabel.Text = "0"
            numberInfectedFilesLabel.ForeColor = Color.White
            scanProgressBar.ForeColor = Color.Blue
            percentLabel.Text = "0%"
            scanProgressBar.Value = 0
            elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
            cancelFolderScan = False
            elapsedTimerSW.Stop()
            elapsedTimerSW.Reset()
            If My.Settings.USBDriveScan = True Then
                statusLabel.Text = ("USB Device Scan Cancelled! - Scanned A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text)
                statusLabel.Refresh()
                My.Settings.USBDriveScan = False
                USBDriveScanTimer.Enabled = True
            End If
        Else
            If ListBox1.Items.Count = 0 Then
                statusLabel.Text = ("Quick Scan Cancelled Scanning - A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - " & ListBox1.Items.Count & " Threats Detected")
                statusLabel.Refresh()
                WriteToLog("" & ListBox1.Items.Count & " Threats Were Detected.")
            Else
                statusLabel.Text = ("Quick Scan Cancelled Scanning - A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - No Threats Detected")
                statusLabel.Refresh()
                WriteToLog("No Threats Were Detected.")
            End If
            currentFile.Text = ""
            fileCountOn = 0
            fileCountLabel.Text = "0 Out Of 0"
            numberInfectedFilesLabel.Text = "0"
            numberInfectedFilesLabel.ForeColor = Color.White
            scanProgressBar.ForeColor = Color.Blue
            percentLabel.Text = "0%"
            scanProgressBar.Value = 0
            cancelFullScan = False
            elapsedTimerSW.Stop()
            elapsedTimerSW.Reset()
            elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
        End If
        elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
        elapsedTimeLabel.Refresh()
    End Sub

    Private Sub quickScanBGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles quickScanBGW.RunWorkerCompleted
        'If cancelQuickScan = True Then
        '    statusLabel.Text = ("Quick Scan Cancelled! - Scanned A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text)
        '    statusLabel.Refresh()
        '    currentFile.Text = ""
        '    fileCountOn = 0
        '    'fileCount = 0
        '    fileCountLabel.Text = "0 Out Of 0"
        '    numberInfectedFilesLabel.Text = "0"
        '    numberInfectedFilesLabel.ForeColor = Color.White
        '    scanProgressBar.ForeColor = Color.Blue
        '    percentLabel.Text = "0%"
        '    scanProgressBar.Value = 0
        '    cancelQuickScan = False
        '    elapsedTimerSW.Stop()
        '    elapsedTimerSW.Reset()
        '    elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
        'Else
        '    statusLabel.Text = ("Quick Scan Completed! - Scanned A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text)
        '    statusLabel.Refresh()
        '    currentFile.Text = ""
        '    fileCountOn = 0
        '    'fileCount = 0
        '    fileCountLabel.Text = "0 Out Of 0"
        '    numberInfectedFilesLabel.Text = "0"
        '    numberInfectedFilesLabel.ForeColor = Color.White
        '    scanProgressBar.ForeColor = Color.Blue
        '    percentLabel.Text = "0%"
        '    scanProgressBar.Value = 0
        '    cancelFullScan = False
        '    elapsedTimerSW.Stop()
        '    elapsedTimerSW.Reset()
        '    elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
        'End If


    End Sub

    Public Function ListAllDrives() As String()
        Dim arDrives() As String
        arDrives = Directory.GetLogicalDrives()
        Return arDrives
    End Function

    Private Sub fullScanBGW_DoWork(sender As Object, e As DoWorkEventArgs) Handles fullScanBGW.DoWork
        CheckForIllegalCrossThreadCalls = False
        fullScanBGW.WorkerSupportsCancellation = True

        scanSubfolders(mainDrive, Me.ListBox3)





        '        Dim _searchPatternList As List(Of String) = New List(Of String)()
        '        Dim SourceDir As DirectoryInfo = New DirectoryInfo(currentDirectory)
        '        Try



        '            For Each ChildFile In SourceDir.GetFiles()
        '                MessageBox.Show(ChildFile.FullName)
        '                If cancelFullScan = True Then
        '                    If (fullScanBGW.CancellationPending = True) Then
        '                        Do
        '                            If (fullScanBGW.CancellationPending = True) Then
        '                                If (fullScanBGW.IsBusy = True) Then
        '                                    fullScanBGW.CancelAsync()
        '                                    e.Cancel = True
        '                                    Exit For
        '                                End If

        '                            End If
        '                        Loop
        '                    End If
        '                End If
        '                If ChildFile.Length >= 4194304 Then
        '                    GoTo nextfile
        '                Else

        '                    If cancelFolderScan = True Then
        '                        fileCountOn = 0
        '                        'fileCount = 0
        '                        fileCountLabel.Text = "0 Out Of 0"
        '                        numberInfectedFilesLabel.Text = "0"
        '                        numberInfectedFilesLabel.ForeColor = Color.White
        '                        ProgressBar1.ForeColor = Color.Blue
        '                        percentLabel.Text = "0%"
        '                        ProgressBar1.Value = 0
        '                        scanningFileLabel.Text = "File Being Scanned"
        '                        currentFile.Text = ""
        '                        If cancelFullScan = True Then
        '                            If (fullScanBGW.CancellationPending = True) Then
        '                                Do
        '                                    If (fullScanBGW.CancellationPending = True) Then
        '                                        If (fullScanBGW.IsBusy = True) Then
        '                                            fullScanBGW.CancelAsync()
        '                                            e.Cancel = True
        '                                            Exit For
        '                                        End If

        '                                    End If
        '                                Loop
        '                            End If
        '                        End If
        '                        Exit Sub
        '                    End If
        '                    Dim secondsTotal As Integer = elapsedTimerSW.Elapsed.TotalSeconds

        '                    seconds1 = secondsTotal
        '                    If seconds1 = 60 Then
        '                        secondsTotal = 0
        '                        seconds1 = 0
        '                        elapsedTimerSW.Restart()
        '                        minutes1 += 1
        '                        If minutes1 = 60 Then
        '                            hours1 += 1
        '                            minutes1 = 0
        '                        End If
        '                    End If



        '                    elapsedTimeLabel.Text = "" & hours1.ToString() & " Hour(s) - " & minutes1.ToString() & " Minute(s) - " & seconds1.ToString() & " Second(s)"
        '                    elapsedTimeLabel.Refresh()
        '                    For x As Integer = 0 To ListBox2.Items.Count - 1
        '                        If cancelFullScan = True Then

        '                            If (fullScanBGW.CancellationPending = True) Then
        '                                Do
        '                                    If (fullScanBGW.CancellationPending = True) Then
        '                                        If (fullScanBGW.IsBusy = True) Then
        '                                            fullScanBGW.CancelAsync()
        '                                            e.Cancel = True
        '                                            Exit For
        '                                        End If

        '                                    End If
        '                                Loop
        '                            End If

        '                        End If
        '                        Dim fileNow As String = ListBox2.Items(x).ToString.Substring(ListBox2.Items(x).ToString - 1)
        '                        If (fileNow = (ChildFile.FullName)) Then
        '                            GoTo nextfile
        '                        Else
        '                            Exit For
        '                        End If
        '                    Next
        '                    For i = 0 To ListBox1.Items.Count - 1

        '                        If cancelFullScan = True Then
        '                            If (fullScanBGW.CancellationPending = True) Then
        '                                Do
        '                                    If (fullScanBGW.CancellationPending = True) Then
        '                                        If (fullScanBGW.IsBusy = True) Then
        '                                            fullScanBGW.CancelAsync()
        '                                            e.Cancel = True
        '                                            Exit For
        '                                        End If

        '                                    End If
        '                                Loop
        '                            End If
        '                        End If

        '                        ListBox1.SelectedIndex = i
        '                        Dim myVariable As String = System.IO.Path.GetExtension(ChildFile.ToString())

        '                        Dim blah As String = ListBox1.Items(i).ToString.Remove(0, 1)
        '                        If blah = myVariable Then



        '                            currentFile.Text = "" & ChildFile.FullName
        '                            currentFile.Refresh()
        '                            statusLabel.Text = "CRC32 Hash " & GetCRC32(ChildFile.FullName)
        '                            statusLabel.Refresh()
        '                            fileCountOn += 1
        '                            currentFile.Text = "" & ChildFile.FullName
        '                            fileCountLabel.Text = "" & fileCount
        '                            fileCountLabel.Refresh()

        '                            If currentSHA512Hash = "a9f49cff5a3eef0d9acb33ac5d81bf8b80ac879133c3b2405f4bf0ba8c21140d252f1a66bebfc0515ffd05035b315c78ed406dc5855b0f66664dbdc45ad3d496" Then
        '                                Dim row As String() = New String() {ChildFile.FullName, currentSHA512Hash, GetFileSize(ChildFile.FullName)}
        '                                quarantineGridView.Rows.Add(row)
        '                                numberInfected += 1
        '                                numberInfectedFilesLabel.ForeColor = Color.Red
        '                                numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
        '                                ProgressBar1.BackColor = Color.Red
        '                            End If
        '                        Else
        '                        End If

        '                    Next
        'nextfile:
        '                End If
        '            Next



        '            Dim SubDir As DirectoryInfo

        '            For Each SubDir In SourceDir.GetDirectories()
        '                If cancelFullScan = True Then
        '                    If (fullScanBGW.CancellationPending = True) Then
        '                        Do
        '                            If (fullScanBGW.CancellationPending = True) Then
        '                                If (fullScanBGW.IsBusy = True) Then
        '                                    fullScanBGW.CancelAsync()
        '                                    e.Cancel = True
        '                                    Exit For
        '                                End If

        '                            End If
        '                        Loop
        '                    End If
        '                End If
        '                RecursiveFileGetter(SubDir.FullName)

        '            Next

        '        Catch ex As UnauthorizedAccessException
        '        End Try
    End Sub

    '    Private Sub RecursiveFileGetter2(ByVal SourcePath As String)

    '        statusLabel.Text = "Scanning Running Processes..."
    '        Dim procs() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcesses
    '        Dim f As String

    '        For Each proc As System.Diagnostics.Process In procs
    '            f = GetProcessFileName(proc)
    '            '  If f.Length > 0 Then
    '            currentFile.Text = f.ToString()
    '            statusLabel.Text = "SHA-512 Hash " & GenerateSHA512String(f.ToString())
    '            statusLabel.Refresh()
    '            fileCountOn += 1
    '            fileCountLabel.Text = "" & fileCountOn & " Out Of " & ListBox3.Items.Count & ""
    '            fileCountLabel.Refresh()

    '            If currentSHA512Hash = "a9f49cff5a3eef0d9acb33ac5d81bf8b80ac879133c3b2405f4bf0ba8c21140d252f1a66bebfc0515ffd05035b315c78ed406dc5855b0f66664dbdc45ad3d496" Then
    '                Dim row As String() = New String() {(f.ToString()), currentSHA512Hash, GetFileSize((f.ToString()))}
    '                quarantineGridView.Rows.Add(row)
    '                numberInfected += 1
    '                numberInfectedFilesLabel.ForeColor = Color.Red
    '                numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
    '                scanProgressBar.BackColor = Color.Red
    '            End If

    '        Next


    '        Dim _searchPatternList As List(Of String) = New List(Of String)()
    '        Dim SourceDir As DirectoryInfo = New DirectoryInfo(SourcePath)
    '        Try



    '            For Each ChildFile In SourceDir.GetFiles()

    '                If cancelFullScan = True Then
    '                    If (fullScanBGW.CancellationPending = True) Then
    '                        Do
    '                            If (fullScanBGW.CancellationPending = True) Then
    '                                If (fullScanBGW.IsBusy = True) Then
    '                                    fullScanBGW.CancelAsync()
    '                                    ' e.Cancel = True
    '                                    Exit For
    '                                End If

    '                            End If
    '                        Loop
    '                    End If
    '                End If
    '                If ChildFile.Length >= 4194304 Then
    '                    GoTo nextfile
    '                Else

    '                    If cancelFolderScan = True Then
    '                        fileCountOn = 0
    '                        'fileCount = 0
    '                        fileCountLabel.Text = "0 Out Of 0"
    '                        numberInfectedFilesLabel.Text = "0"
    '                        numberInfectedFilesLabel.ForeColor = Color.White
    '                        scanProgressBar.ForeColor = Color.Blue
    '                        percentLabel.Text = "0%"
    '                        scanProgressBar.Value = 0
    '                        scanningFileLabel.Text = "File Being Scanned"
    '                        currentFile.Text = ""
    '                        folderScanBGW.CancelAsync()
    '                        Exit Sub
    '                    End If
    '                    Dim secondsTotal As Integer = elapsedTimerSW.Elapsed.TotalSeconds

    '                    seconds1 = secondsTotal
    '                    If seconds1 = 60 Then
    '                        secondsTotal = 0
    '                        seconds1 = 0
    '                        elapsedTimerSW.Restart()
    '                        minutes1 += 1
    '                        If minutes1 = 60 Then
    '                            hours1 += 1
    '                            minutes1 = 0
    '                        End If
    '                    End If



    '                    elapsedTimeLabel.Text = "" & hours1.ToString() & " Hour(s) - " & minutes1.ToString() & " Minute(s) - " & seconds1.ToString() & " Second(s)"
    '                    elapsedTimeLabel.Refresh()
    '                    For x As Integer = 0 To ListBox2.Items.Count - 1
    '                        If (ListBox2.Items(x).ToString.Contains(ChildFile.FullName & "\")) Then
    '                            GoTo nextfile
    '                        End If
    '                    Next

    '                    For i = 0 To ListBox1.Items.Count - 1

    '                        If cancelFullScan = True Then
    '                            If (fullScanBGW.CancellationPending = True) Then
    '                                Do
    '                                    If (fullScanBGW.CancellationPending = True) Then
    '                                        If (fullScanBGW.IsBusy = True) Then
    '                                            fullScanBGW.CancelAsync()
    '                                            '     e.Cancel = True
    '                                            Exit For
    '                                        End If

    '                                    End If
    '                                Loop
    '                            End If
    '                        End If

    '                        ListBox1.SelectedIndex = i
    '                        Dim myVariable As String = System.IO.Path.GetExtension(ChildFile.ToString())

    '                        Dim blah As String = ListBox1.Items(i).ToString.Remove(0, 1)
    '                        If blah = myVariable Then



    '                            currentFile.Text = "" & ChildFile.FullName
    '                            currentFile.Refresh()
    '                            statusLabel.Text = "CRC32 Hash " & GetCRC32(ChildFile.FullName)
    '                            statusLabel.Refresh()
    '                            fileCountOn += 1
    '                            currentFile.Text = "" & ChildFile.FullName
    '                            fileCountLabel.Text = "" & fileCountOn & " Out Of " & ListBox3.Items.Count & ""
    '                            fileCountLabel.Refresh()

    '                            If currentSHA512Hash = "a9f49cff5a3eef0d9acb33ac5d81bf8b80ac879133c3b2405f4bf0ba8c21140d252f1a66bebfc0515ffd05035b315c78ed406dc5855b0f66664dbdc45ad3d496" Then
    '                                Dim row As String() = New String() {ChildFile.FullName, currentSHA512Hash, GetFileSize(ChildFile.FullName)}
    '                                quarantineGridView.Rows.Add(row)
    '                                numberInfected += 1
    '                                numberInfectedFilesLabel.ForeColor = Color.Red
    '                                numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
    '                                scanProgressBar.BackColor = Color.Red
    '                            End If
    '                        Else

    '                        End If

    '                    Next
    'nextfile:
    '                End If
    '            Next



    '            Dim SubDir As DirectoryInfo

    '            For Each SubDir In SourceDir.GetDirectories()
    '                If cancelFullScan = True Then
    '                    If (fullScanBGW.CancellationPending = True) Then
    '                        Do
    '                            If (fullScanBGW.CancellationPending = True) Then
    '                                If (fullScanBGW.IsBusy = True) Then
    '                                    fullScanBGW.CancelAsync()
    '                                    ' e.Cancel = True
    '                                    Exit For
    '                                End If

    '                            End If
    '                        Loop
    '                    End If
    '                End If
    '                RecursiveFileGetter(SubDir.FullName)

    '            Next

    '        Catch ex As UnauthorizedAccessException
    '        End Try
    '    End Sub

    Private Sub fullScanBGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles fullScanBGW.RunWorkerCompleted
        'If cancelFullScan = True Then
        '    statusLabel.Text = ("Full Scan Cancelled! - Scanned A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text)
        '    statusLabel.Refresh()
        '    currentFile.Text = ""
        '    fileCountOn = 0
        '    'fileCount = 0
        '    fileCountLabel.Text = "0 Out Of 0"
        '    numberInfectedFilesLabel.Text = "0"
        '    numberInfectedFilesLabel.ForeColor = Color.White
        '    scanProgressBar.ForeColor = Color.Blue
        '    percentLabel.Text = "0%"
        '    scanProgressBar.Value = 0
        '    cancelFullScan = False
        '    elapsedTimerSW.Stop()
        '    elapsedTimerSW.Reset()
        '    elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"

        'Else
        '    statusLabel.Text = ("Full Scan Completed! - Scanned A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text)
        '    statusLabel.Refresh()
        '    currentFile.Text = ""
        '    fileCountOn = 0
        '    'fileCount = 0
        '    fileCountLabel.Text = "0 Out Of 0"
        '    numberInfectedFilesLabel.Text = "0"
        '    numberInfectedFilesLabel.ForeColor = Color.White
        '    scanProgressBar.ForeColor = Color.Blue
        '    percentLabel.Text = "0%"
        '    scanProgressBar.Value = 0
        '    cancelFullScan = False
        '    elapsedTimerSW.Stop()
        '    elapsedTimerSW.Reset()
        '    elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
        'End If
    End Sub










    Private Sub startFullScan_Click(sender As Object, e As EventArgs) Handles startFullScan.Click
        cancelFullScan = False
        CheckForIllegalCrossThreadCalls = False
        If fullScanBGW.IsBusy = True Then
            Exit Sub
        Else
            startFullScan.Enabled = False
            statusLabel.Text = "Program May Become Unresponsive For A Moment While Loading Parts Of The Scan List."
            statusLabel.Refresh()
            WriteToLog("Full Scan Started At: " & Date.Now.ToString() & "")
            scanRunningProcessesFull.RunWorkerAsync()
        End If
    End Sub


    Private Function GetProcessFileName(proc As System.Diagnostics.Process) As String
        Dim strRet As String = String.Empty

        Try
            strRet = proc.MainModule.FileName
        Catch ex As Exception
            ' This catch used to ignore "Access Is denied" exception.
        End Try
        Return strRet
    End Function


    Private Sub stopFullScanButton_Click(sender As Object, e As EventArgs) Handles stopFullScanButton.Click
        cancelFullScan = True
        scanTimer.Stop()
        fullScanBGW.Dispose()
        If cancelFullScan = True Then
            If ListBox1.Items.Count = 0 Then
                statusLabel.Text = ("Full Scan Cancelled Scanning - A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - " & ListBox1.Items.Count & " Threats Detected")
                statusLabel.Refresh()
                WriteToLog("" & ListBox1.Items.Count & " Threats Were Detected.")
            Else
                statusLabel.Text = ("Full Scan Cancelled Scanning - A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - No Threats Detected")
                statusLabel.Refresh()
                WriteToLog("No Threats Were Detected.")
            End If
            currentFile.Text = ""
            fileCountOn = 0
            fileCountLabel.Text = "0 Out Of 0"
            numberInfectedFilesLabel.Text = "0"
            numberInfectedFilesLabel.ForeColor = Color.White
            scanProgressBar.ForeColor = Color.Blue
            percentLabel.Text = "0%"
            scanProgressBar.Value = 0
            elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
            cancelFolderScan = False
            elapsedTimerSW.Stop()
            elapsedTimerSW.Reset()
        Else
            If ListBox1.Items.Count = 0 Then
                statusLabel.Text = ("Full Scan Completed Scanning - A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - " & ListBox1.Items.Count & " Threats Detected")
                statusLabel.Refresh()
                WriteToLog("" & ListBox1.Items.Count & " Threats Were Detected.")
            Else
                statusLabel.Text = ("Full Scan Completed Scanning - A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - No Threats Detected")
                statusLabel.Refresh()
                WriteToLog("No Threats Were Detected.")
            End If
            currentFile.Text = ""
            fileCountOn = 0
            'fileCount = 0
            fileCountLabel.Text = "0 Out Of 0"
            numberInfectedFilesLabel.Text = "0"
            numberInfectedFilesLabel.ForeColor = Color.White
            scanProgressBar.ForeColor = Color.Blue
            percentLabel.Text = "0%"
            scanProgressBar.Value = 0
            cancelFullScan = False
            elapsedTimerSW.Stop()
            elapsedTimerSW.Reset()
            elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
        End If
        elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
        elapsedTimeLabel.Refresh()
    End Sub

    Private Sub copyHashButton_Click(sender As Object, e As EventArgs) Handles copyHashButton.Click
        If quarantineGridView.Rows.Count > 0 And quarantineGridView.SelectedRows.Count > 0 Then
            Clipboard.SetText(quarantineGridView.CurrentRow.Cells(1).Value)
        End If
    End Sub



    Public Structure SHELLEXECUTEINFO
        Public cbSize As Integer
        Public fMask As Integer
        Public hwnd As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpVerb As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpFile As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpParameters As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpDirectory As String
        Dim nShow As Integer
        Dim hInstApp As IntPtr
        Dim lpIDList As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpClass As String
        Public hkeyClass As IntPtr
        Public dwHotKey As Integer
        Public hIcon As IntPtr
        Public hProcess As IntPtr
    End Structure


    Private Const SEE_MASK_INVOKEIDLIST = &HC
    Private Const SEE_MASK_NOCLOSEPROCESS = &H40
    Private Const SEE_MASK_FLAG_NO_UI = &H400
    Public Const SW_SHOW As Short = 5

    <DllImport("Shell32", CharSet:=Runtime.InteropServices.CharSet.Auto, SetLastError:=True)>
    Public Shared Function ShellExecuteEx(ByRef lpExecInfo As SHELLEXECUTEINFO) As Boolean
    End Function

    Private Sub filesPropertiesButton_Click(sender As Object, e As EventArgs) Handles filesPropertiesButton.Click
        If quarantineGridView.Rows.Count > 0 And quarantineGridView.SelectedRows.Count > 0 Then
            Dim sei As New SHELLEXECUTEINFO
            sei.cbSize = Marshal.SizeOf(sei)
            sei.lpVerb = "properties"
            sei.lpFile = (quarantineGridView.CurrentRow.Cells(0).Value)
            sei.nShow = SW_SHOW
            sei.fMask = SEE_MASK_INVOKEIDLIST
            If Not ShellExecuteEx(sei) Then
                Dim ex As New System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error())
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If



    End Sub

    Private Sub QuickScanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuickScanToolStripMenuItem.Click
        copyHashButton.Visible = False
        filesPropertiesButton.Visible = False
        startQuickScan.Visible = True
        startFullScan.Visible = False
        stopFullScanButton.Visible = False
        startFolderScan.Visible = False
        stopFolderScan.Visible = False
        stopQuickScan.Visible = True
        quickScanLabel.Visible = True
        fullScanLabel.Visible = False
        quarantineLabel.Visible = False
        folderScanLabel.Visible = False
        quarantineGridView.Visible = False
        restoreAllButton.Visible = False
        restoreFileButton.Visible = False
        deleteAllButton.Visible = False
        deletefileButton.Visible = False

        infectedLabel.Visible = True
        onFileLabel.Visible = True
        elapsedLabel.Visible = True
        scanningFileLabel.Visible = True
        numberInfectedFilesLabel.Visible = True
        scanProgressBar.Visible = True
        percentLabel.Visible = True
        fileCountLabel.Visible = True
        currentFile.Visible = True
        elapsedTimeLabel.Visible = True
    End Sub

    Private Sub FullScanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullScanToolStripMenuItem.Click
        copyHashButton.Visible = False
        filesPropertiesButton.Visible = False
        startQuickScan.Visible = False
        startFullScan.Visible = True
        stopFullScanButton.Visible = True
        startFolderScan.Visible = False
        stopFolderScan.Visible = False
        stopQuickScan.Visible = False
        quickScanLabel.Visible = False
        fullScanLabel.Visible = True
        quarantineLabel.Visible = False
        folderScanLabel.Visible = False
        quarantineGridView.Visible = False
        restoreAllButton.Visible = False
        restoreFileButton.Visible = False
        deleteAllButton.Visible = False
        deletefileButton.Visible = False

        infectedLabel.Visible = True
        onFileLabel.Visible = True
        elapsedLabel.Visible = True
        scanningFileLabel.Visible = True
        numberInfectedFilesLabel.Visible = True
        scanProgressBar.Visible = True
        percentLabel.Visible = True
        fileCountLabel.Visible = True
        currentFile.Visible = True
        elapsedTimeLabel.Visible = True
    End Sub

    Private Sub FolderScanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderScanToolStripMenuItem.Click
        copyHashButton.Visible = False
        filesPropertiesButton.Visible = False
        startQuickScan.Visible = False
        startFullScan.Visible = False
        stopFullScanButton.Visible = False
        startFolderScan.Visible = True
        stopFolderScan.Visible = True
        stopQuickScan.Visible = False
        quickScanLabel.Visible = True
        fullScanLabel.Visible = False
        quarantineLabel.Visible = False
        folderScanLabel.Visible = True
        quarantineGridView.Visible = False
        restoreAllButton.Visible = False
        restoreFileButton.Visible = False
        deleteAllButton.Visible = False
        deletefileButton.Visible = False
        infectedLabel.Visible = True
        onFileLabel.Visible = True
        elapsedLabel.Visible = True
        scanningFileLabel.Visible = True
        numberInfectedFilesLabel.Visible = True
        scanProgressBar.Visible = True
        percentLabel.Visible = True
        fileCountLabel.Visible = True
        currentFile.Visible = True
        elapsedTimeLabel.Visible = True
    End Sub

    Private Sub QuarantineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuarantineToolStripMenuItem.Click
        copyHashButton.Visible = True
        filesPropertiesButton.Visible = True
        startFolderScan.Visible = False
        stopFolderScan.Visible = False
        stopFullScanButton.Visible = False
        startQuickScan.Visible = False
        startFullScan.Visible = False
        stopQuickScan.Visible = False
        quickScanLabel.Visible = False
        fullScanLabel.Visible = False
        quarantineLabel.Visible = True
        folderScanLabel.Visible = False
        quarantineGridView.Visible = True
        restoreAllButton.Visible = True
        restoreFileButton.Visible = True
        deleteAllButton.Visible = True
        deletefileButton.Visible = True
        scanProgressBar.Visible = False
        percentLabel.Visible = False

        infectedLabel.Visible = False
        onFileLabel.Visible = False
        elapsedLabel.Visible = False
        scanningFileLabel.Visible = False
        numberInfectedFilesLabel.Visible = False
        scanProgressBar.Visible = False
        percentLabel.Visible = False
        fileCountLabel.Visible = False
        currentFile.Visible = False
        elapsedTimeLabel.Visible = False
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        settingsForm.ShowDialog()
    End Sub

    '    Private Sub RecursiveFileGetter(ByVal SourcePath As String)

    '        Dim _searchPatternList As List(Of String) = New List(Of String)()
    '        Dim allowedPrograms As List(Of String) = New List(Of String)()
    '        Dim SourceDir As DirectoryInfo = New DirectoryInfo(SourcePath)
    '        Try

    '            For Each ChildFile In SourceDir.GetFiles()


    '                If cancelFolderScan = True Then
    '                    If (folderScanBGW.CancellationPending = True) Then
    '                        Do
    '                            If (folderScanBGW.CancellationPending = True) Then
    '                                If (folderScanBGW.IsBusy = True) Then
    '                                    folderScanBGW.CancelAsync()
    '                                    'e.Cancel = True
    '                                    Exit For
    '                                End If

    '                            End If
    '                        Loop
    '                    End If
    '                End If
    '                ' If 'fileCount = 5 Then
    '                'ssageBox.Show(GetCRC32(ChildFile.FullName()))
    '                '    End If
    '                Dim myExtension As String = System.IO.Path.GetExtension(ChildFile.FullName)
    '                If myExtension = ".zip" Or myExtension = "*.gzip" Or myExtension = "*.rar" Or myExtension = "*.7zip" Then

    '                    '   Dim crc32 As New Ionic.Crc.CRC32


    '                    'Dim strmFile As FileStream = File.OpenRead(ChildFile.FullName)

    '                    'Dim entry = New ZipEntry(Path.GetFileName(strmFile))
    '                    'Dim s1 As ZipEntry In strmFile
    '                    'For Each entry2 In ZipEntry(strmFile)
    '                    '    Dim blah = New ICSharpCode.SharpZipLib.Checksum.Crc32
    '                    '    MessageBox.Show(blah.Equals(s1.ToString()))
    '                    'Next
    '                    'End Using
    '                    'Dim crc32 As New Ionic.Crc.CRC32
    '                    'Using zip1 As New ZipFile(ChildFile.FullName)
    '                    '    Dim s441 As String
    '                    '    For Each s441 In zip1
    '                    '        Dim e1 As ZipEntry = zip1(s441.ToString())
    '                    '        Using memstream As New MemoryStream(zip1.ToString())

    '                    '            Using binary As New BinaryReader(memstream)
    '                    '                Dim n As Integer
    '                    '                Dim buffer As Byte() = New Byte(4096) {}
    '                    '                Dim totalBytesRead As Integer = 0
    '                    '                Do
    '                    '                    n = binary.Read(buffer, 0, buffer.Length)
    '                    '                    totalBytesRead = (totalBytesRead + n)
    '                    '                    MessageBox.Show(crc32.ComputeCrc32(n, totalBytesRead))

    '                    '                Loop While (n <> totalBytesRead)
    '                    '            End Using
    '                    '        End Using
    '                    '    Next
    '                    'End Using





    '                    '        Using s As Ionic.Crc.CrcCalculatorStream = e1.OpenReader
    '                    '            Dim n As Integer
    '                    '            Dim buffer As Byte() = New Byte(4096) {}
    '                    '            Dim totalBytesRead As Integer = 0
    '                    '            Do
    '                    '                n = s.Read(buffer, 0, buffer.Length)
    '                    '                totalBytesRead = (totalBytesRead + n)

    '                    '                crc32.SlurpBlock(buffer, 0, buffer.Length)

    '                    '            Loop While (n <> totalBytesRead)
    '                    '            MessageBox.Show(crc32.Crc32Result)
    '                    '        End Using
    '                    '    Next
    '                    'End Using
    '                    '' Dim blah As New FileInfo(entry.ToString())

    '                    'MessageBox.Show(validChecksum)

    '                    '        currentFile.Refresh()
    '                    '        statusLabel.Text = "CRC32 Hash: " & (validChecksum)
    '                    '        statusLabel.Refresh()


    '                    'If currentSHA512Hash = "a9f49cff5a3eef0d9acb33ac5d81bf8b80ac879133c3b2405f4bf0ba8c21140d252f1a66bebfc0515ffd05035b315c78ed406dc5855b0f66664dbdc45ad3d496" Then
    '                    '            Dim row As String() = New String() {ChildFile.FullName, currentSHA512Hash, GetFileSize(ChildFile.FullName)}
    '                    '            quarantineGridView.Rows.Add(row)
    '                    '            numberInfected += 1
    '                    '            numberInfectedFilesLabel.ForeColor = Color.Red
    '                    '            numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
    '                    '            'ProgressBar1.BackColor = Color.Red
    '                    '        End If

    '                    '    Next

    '                    'End Using
    '                    'fileCountOn += 1

    '                    'GoTo nextfile
    '                End If

    '                fileCountOn += 1


    '                If ChildFile.Length >= 4194304 Then
    '                    GoTo nextfile
    '                Else
    '                    currentFile.Text = "" & ChildFile.FullName
    '                    currentFile.Refresh()
    '                    If cancelFolderScan = True Then
    '                        fileCountOn = 0
    '                        'fileCount = 0
    '                        fileCountLabel.Text = "0 Out Of 0"
    '                        numberInfectedFilesLabel.Text = "0"
    '                        numberInfectedFilesLabel.ForeColor = Color.White
    '                        scanProgressBar.ForeColor = Color.Blue
    '                        percentLabel.Text = "0%"
    '                        scanProgressBar.Value = 0
    '                        scanningFileLabel.Text = "File Being Scanned"
    '                        currentFile.Text = ""
    '                        folderScanBGW.CancelAsync()
    '                        Exit Sub
    '                    End If
    '                    Dim secondsTotal As Integer = elapsedTimerSW.Elapsed.TotalSeconds

    '                    seconds1 = secondsTotal
    '                    If seconds1 = 60 Then
    '                        secondsTotal = 0
    '                        seconds1 = 0
    '                        elapsedTimerSW.Restart()
    '                        minutes1 += 1
    '                        If minutes1 = 60 Then
    '                            hours1 += 1
    '                            minutes1 = 0
    '                        End If
    '                    End If


    '                    '     MessageBox.Show(GetCRC32(ChildFile.FullName()))
    '                    elapsedTimeLabel.Text = "" & hours1.ToString() & " Hour(s) - " & minutes1.ToString() & " Minute(s) - " & seconds1.ToString() & " Second(s)"
    '                    elapsedTimeLabel.Refresh()

    '                    '  For i = 0 To ListBox1.Items.Count - 1

    '                    'ListBox1.SelectedIndex = i
    '                    'Dim myVariable As String = System.IO.Path.GetExtension(ChildFile.ToString())

    '                    'Dim blah As String = ListBox1.Items(i).ToString.Remove(0, 1)
    '                    'If blah = myVariable Then

    '                    For x As Integer = 0 To ListBox2.Items.Count - 1
    '                        If cancelFolderScan = True Then
    '                            If (folderScanBGW.CancellationPending = True) Then
    '                                Do
    '                                    If (folderScanBGW.CancellationPending = True) Then
    '                                        If (folderScanBGW.IsBusy = True) Then
    '                                            folderScanBGW.CancelAsync()
    '                                            'e.Cancel = True
    '                                            Exit For
    '                                        End If

    '                                    End If
    '                                Loop
    '                            End If
    '                        End If
    '                        If (ListBox2.Items(x).ToString.Contains(ChildFile.FullName & "\")) Then
    '                            'ListBox2.Items.Add("String found at " & (x + 1).ToString) 'Indexing is zero-based
    '                            GoTo nextfile
    '                        End If
    '                    Next



    '                    statusLabel.Text = "CRC32 Hash: " & GetCRC32(ChildFile.FullName)
    '                    statusLabel.Refresh()
    '                    fileCountOn += 1

    '                    fileCountLabel.Text = "" & fileCountOn
    '                    fileCountLabel.Refresh()

    '                    Dim stringtosearch As String = GetCRC32(ChildFile.FullName)
    '                    'filterData(stringtosearch)
    '                    'If DataGridView1.Rows.Count > 0 Then

    '                    '    Dim row As String() = New String() {ChildFile.FullName, stringtosearch, GetFileSize(ChildFile.FullName)}
    '                    '    quarantineGridView.Rows.Add(row)
    '                    '    numberInfected += 1
    '                    '    numberInfectedFilesLabel.ForeColor = Color.Red
    '                    '    numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
    '                    '    DataGridView1.Rows.Clear()
    '                    'End If


    '                    'Else
    '                End If

    'nextfile:

    '            Next



    '            Dim SubDir As DirectoryInfo

    '            For Each SubDir In SourceDir.GetDirectories()
    '                If cancelFolderScan = True Then
    '                    If (folderScanBGW.CancellationPending = True) Then
    '                        Do
    '                            If (folderScanBGW.CancellationPending = True) Then
    '                                If (folderScanBGW.IsBusy = True) Then
    '                                    folderScanBGW.CancelAsync()
    '                                    'e.Cancel = True
    '                                    Exit For
    '                                End If

    '                            End If
    '                        Loop
    '                    End If
    '                End If
    '                RecursiveFileGetter(SubDir.FullName)

    '            Next

    '        Catch ex As UnauthorizedAccessException
    '        End Try
    '    End Sub


    'Public Function QuarantineItems(_location As String) As List(Of String)
    '    Dim item As List(Of String) = New List(Of String)()
    '    Dim d As DirectoryInfo = New DirectoryInfo(_location)
    '    For Each file As System.IO.FileInfo In d.GetFiles("*.*")
    '        AddFileToQuarantine(file.FullName)
    '        Dim row As String() = New String() {file.FullName, GetCRC32(file.FullName), GetFileSize(file.FullName)}
    '        quarantineGridView.Rows.Add(row)
    '    Next

    '    Return item
    'End Function

    Public Function AddFileToQuarantine(file As String) As String
        Dim file_name3 As String = Path.GetFileName(file)
        _enc.EncryptFile(file, _loc & file_name3, _password)
        Dim row As String() = New String() {file.ToString(), GenerateSHA512String(file_name3.ToString()), GetFileSize(file_name3.ToString())}
        quarantineGridView.Rows.Add(row)
        If System.IO.File.Exists(file) Then
            System.IO.File.Move(file, _loc)
        End If
        Return _loc & file_name3
    End Function

    Public Sub DeleteFileFromQuarantine()
        Dim des As String = _loc & "\" & Path.GetFileName((quarantineGridView.CurrentRow.Cells(0).Value))
        _enc.DecryptFile((quarantineGridView.CurrentRow.Cells(0).Value), des, _password)
        Try
            If quarantineGridView.Rows.Count > 0 And quarantineGridView.SelectedRows.Count > 0 Then
                Dim FileToDelete As String
                FileToDelete = (quarantineGridView.CurrentRow.Cells(0).Value)
                If System.IO.File.Exists(des) = True Then
                    System.IO.File.Delete(des)
                    MessageBox.Show("" & quarantineGridView.CurrentRow.Cells(0).Value & " Has Been Deleted!", "Mythodikal Anti-Virus", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    quarantineGridView.Rows.Remove(quarantineGridView.CurrentRow)
                End If
            End If
        Catch
        End Try
    End Sub
    Public Sub RestoreFileFromQuarantine()
        Dim des As String = _loc & "\" & Path.GetFileName((quarantineGridView.CurrentRow.Cells(0).Value))
        _enc.DecryptFile((quarantineGridView.CurrentRow.Cells(0).Value), des, _password)
        Try
            If quarantineGridView.Rows.Count > 0 And quarantineGridView.SelectedRows.Count > 0 Then
                Dim FileToRestore As String
                FileToRestore = (quarantineGridView.CurrentRow.Cells(0).Value)
                If System.IO.File.Exists(des) = True Then
                    System.IO.File.Move(des, (quarantineGridView.CurrentRow.Cells(0).Value))
                    MessageBox.Show("" & quarantineGridView.CurrentRow.Cells(0).Value & " Has Been Restored", "Mythodikal Anti-Virus", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    quarantineGridView.Rows.Remove(quarantineGridView.CurrentRow)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub RestoreAllFilesFromQuarantine()
        Dim d As DirectoryInfo = New DirectoryInfo(_loc)
        For Each file2 As System.IO.FileInfo In d.GetFiles("*.*")
            Try
                quarantineGridView.Rows(0).Selected = True

                If quarantineGridView.Rows.Count > 0 Then
                    For i = 0 To quarantineGridView.Rows.Count - 1
                        quarantineGridView.Rows(0).Selected = True
                        If System.IO.File.Exists(file2.FullName) = True Then
                            System.IO.File.Move(file2.FullName, (quarantineGridView.CurrentRow.Cells(0).Value))
                            MessageBox.Show(file2.FullName & " Has Been Restored", "Mythodikal Anti-Virus",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
                            quarantineGridView.Rows.Remove(quarantineGridView.CurrentRow)
                        End If
                    Next

                End If
            Catch ex As Exception
            End Try
        Next
    End Sub


    Public Sub DeleteAllFilesInQuarantine()
        Dim d As DirectoryInfo = New DirectoryInfo(_loc)
        For Each file As System.IO.FileInfo In d.GetFiles("*.*")
            Try
                quarantineGridView.Rows(0).Selected = True
                If quarantineGridView.Rows.Count > 0 Then
                    For i = 0 To quarantineGridView.Rows.Count - 1
                        quarantineGridView.Rows(0).Selected = True
                        If System.IO.File.Exists(file.FullName) = True Then
                            System.IO.File.Delete(file.FullName)

                            quarantineGridView.Rows.Remove(quarantineGridView.CurrentRow)
                        End If
                    Next
                End If
            Catch ex As Exception
            End Try
        Next
        MessageBox.Show("All Files Have Been Deleted From Quarantine.", "Mythodikal Anti-Virus",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub restoreFileButton_Click(sender As Object, e As EventArgs)
        RestoreFileFromQuarantine()
    End Sub

    Private Sub restoreAllButton_Click(sender As Object, e As EventArgs)
        RestoreAllFilesFromQuarantine()
    End Sub

    Private Sub deleteAllButton_Click(sender As Object, e As EventArgs)
        DeleteAllFilesInQuarantine()
    End Sub

    Private Sub deletefileButton_Click(sender As Object, e As EventArgs)
        DeleteFileFromQuarantine()
    End Sub

    Private Sub USBDriveScanTimer_Tick(sender As Object, e As EventArgs) Handles USBDriveScanTimer.Tick
        If My.Settings.USBDriveScan = True Then
            currentDirectory = My.Settings.USBDrive
            cancelFolderScan = False
            CheckForIllegalCrossThreadCalls = False
            If fullScanBGW.IsBusy = True Then
                Exit Sub
            End If
            If quickScanBGW.IsBusy = True Then
                Exit Sub
            End If
            If folderScanBGW.IsBusy = True Then
                Exit Sub
            Else
                copyHashButton.Visible = False
                filesPropertiesButton.Visible = False
                startQuickScan.Visible = False
                startFullScan.Visible = False
                stopFullScanButton.Visible = False
                startFolderScan.Visible = True
                stopFolderScan.Visible = True
                stopQuickScan.Visible = False
                quickScanLabel.Visible = True
                fullScanLabel.Visible = False
                quarantineLabel.Visible = False
                folderScanLabel.Visible = True
                quarantineGridView.Visible = False
                restoreAllButton.Visible = False
                restoreFileButton.Visible = False
                deleteAllButton.Visible = False
                deletefileButton.Visible = False
                infectedLabel.Visible = True
                onFileLabel.Visible = True
                elapsedLabel.Visible = True
                scanningFileLabel.Visible = True
                numberInfectedFilesLabel.Visible = True
                scanProgressBar.Visible = True
                percentLabel.Visible = True
                fileCountLabel.Visible = True
                currentFile.Visible = True
                elapsedTimeLabel.Visible = True
                elapsedTimerSW.Start()
                'fileCount = 0
                WriteToLog("USB Drive Scan Started At: " & Date.Now.ToString() & "")
                scanTimer.Start()
                elapsedTimerSW.Start()
                folderScanBGW.RunWorkerAsync()
                folderScanBGW.WorkerSupportsCancellation = True
                fileCountOn = 0
                CheckForIllegalCrossThreadCalls = False
                USBDriveScanTimer.Enabled = False
            End If
        End If
    End Sub

    'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
    '    On Error Resume Next
    '    If My.Settings.realTimeScan = True Then
    '        If folderScanBGW.IsBusy = False And quickScanBGW.IsBusy = False And fullScanBGW.IsBusy = False Then
    '            If folderScanBGW.IsBusy = False Then
    '                cancelRealTimeScan = False
    '                'fileCount = 0
    '                FileSystemWatcher1.Path = "" & mainDrive & ""
    '                FileSystemWatcher1.IncludeSubdirectories = True
    '                FileSystemWatcher1.NotifyFilter = 0
    '                FileSystemWatcher1.NotifyFilter = FileSystemWatcher1.NotifyFilter Or NotifyFilters.FileName
    '                FileSystemWatcher1.EnableRaisingEvents = True
    '                cancelFolderScan = False
    '                realTimeLabel.Visible = True
    '                realTimeOffButton.Visible = True
    '                realTimeOnButton.Visible = True
    '                copyHashButton.Visible = False
    '                filesPropertiesButton.Visible = False
    '                startQuickScan.Visible = False
    '                startFullScan.Visible = False
    '                stopFullScanButton.Visible = False
    '                startFolderScan.Visible = False
    '                stopFolderScan.Visible = False
    '                stopQuickScan.Visible = False
    '                quickScanLabel.Visible = False
    '                fullScanLabel.Visible = False
    '                quarantineLabel.Visible = False
    '                folderScanLabel.Visible = False
    '                quarantineGridView.Visible = False
    '                restoreAllButton.Visible = False
    '                restoreFileButton.Visible = False
    '                deleteAllButton.Visible = False
    '                deletefileButton.Visible = False
    '                infectedLabel.Visible = True
    '                onFileLabel.Visible = True
    '                elapsedLabel.Visible = True
    '                scanningFileLabel.Visible = True
    '                numberInfectedFilesLabel.Visible = True
    '                ProgressBar1.Visible = True
    '                percentLabel.Visible = True
    '                fileCountLabel.Visible = True
    '                currentFile.Visible = True
    '                elapsedTimeLabel.Visible = True
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub realTimeOnButton_Click(sender As Object, e As EventArgs) Handles realTimeOnButton.Click
        Dim aPath As String = Application.StartupPath()
        If IO.File.Exists(aPath & "\ProgramSettings.ini") Then
            IO.File.Delete(aPath & "\ProgramSettings.ini")
        Else
            settingsForm.realTimeCheckBox.Checked = True
            settingsForm.realTimeCheckBox.Text = "On"
            My.Settings.realTimeScan = True
            realTimeLabel.Visible = True
            realTimeOffButton.Visible = True
            realTimeOnButton.Visible = True
            copyHashButton.Visible = False
            filesPropertiesButton.Visible = False
            startQuickScan.Visible = False
            startFullScan.Visible = False
            stopFullScanButton.Visible = False
            startFolderScan.Visible = False
            stopFolderScan.Visible = False
            stopQuickScan.Visible = False
            quickScanLabel.Visible = True
            fullScanLabel.Visible = False
            quarantineLabel.Visible = False
            folderScanLabel.Visible = False
            quarantineGridView.Visible = False
            restoreAllButton.Visible = False
            restoreFileButton.Visible = False
            deleteAllButton.Visible = False
            deletefileButton.Visible = False
            infectedLabel.Visible = True
            onFileLabel.Visible = True
            elapsedLabel.Visible = True
            scanningFileLabel.Visible = True
            numberInfectedFilesLabel.Visible = True
            scanProgressBar.Visible = True
            percentLabel.Visible = True
            fileCountLabel.Visible = True
            currentFile.Visible = True
            elapsedTimeLabel.Visible = True
            FileSystemWatcher1.EnableRaisingEvents = True
            WriteToLog("Real Time Scan Started At: " & Date.Now & "")
        End If




        Using writer As New StreamWriter(aPath & "\ProgramSettings.ini", True)
            If settingsForm.realTimeCheckBox.Checked = False Then
                writer.WriteLine("realCheck = True")
                settingsForm.realTimeCheckBox.Checked = True
                settingsForm.realTimeCheckBox.Text = "On"
                My.Settings.realTimeScan = True
                realTimeLabel.Visible = True
                realTimeOffButton.Visible = True
                realTimeOnButton.Visible = True
                copyHashButton.Visible = False
                filesPropertiesButton.Visible = False
                startQuickScan.Visible = False
                startFullScan.Visible = False
                stopFullScanButton.Visible = False
                startFolderScan.Visible = False
                stopFolderScan.Visible = False
                stopQuickScan.Visible = False
                quickScanLabel.Visible = True
                fullScanLabel.Visible = False
                quarantineLabel.Visible = False
                folderScanLabel.Visible = False
                quarantineGridView.Visible = False
                restoreAllButton.Visible = False
                restoreFileButton.Visible = False
                deleteAllButton.Visible = False
                deletefileButton.Visible = False
                infectedLabel.Visible = True
                onFileLabel.Visible = True
                elapsedLabel.Visible = True
                scanningFileLabel.Visible = True
                numberInfectedFilesLabel.Visible = True
                scanProgressBar.Visible = True
                percentLabel.Visible = True
                fileCountLabel.Visible = True
                currentFile.Visible = True
                elapsedTimeLabel.Visible = True
                FileSystemWatcher1.EnableRaisingEvents = True
                WriteToLog("Real Time Scan Started At: " & Date.Now & "")
            Else
            End If
        End Using
        statusLabel.Text = "Starting Real-Time Scan..."
        statusLabel.Refresh()
        realTimeOnButton.Enabled = False
        realTimeOffButton.Enabled = True
        My.Settings.realTimeScan = True
        My.Settings.Save()

    End Sub

    Private Sub realTimeOffButton_Click(sender As Object, e As EventArgs) Handles realTimeOffButton.Click

        cancelRealTimeScan = True
        If My.Settings.realTimeScan = True Then
            My.Settings.realTimeScan = False
            statusLabel.Text = ("Real-Time Scan Stopped! - Scanned A Total Of " & fileCountOn & " Files")
            statusLabel.Refresh()
            settingsForm.realTimeCheckBox.Text = "Off"
            My.Settings.realTimeScan = False
            realTimeLabel.Visible = True
            realTimeOffButton.Visible = True
            realTimeOnButton.Visible = True
            copyHashButton.Visible = False
            filesPropertiesButton.Visible = False
            startQuickScan.Visible = False
            startFullScan.Visible = False
            stopFullScanButton.Visible = False
            startFolderScan.Visible = False
            stopFolderScan.Visible = False
            stopQuickScan.Visible = False
            quickScanLabel.Visible = True
            fullScanLabel.Visible = False
            quarantineLabel.Visible = False
            folderScanLabel.Visible = False
            quarantineGridView.Visible = False
            restoreAllButton.Visible = False
            restoreFileButton.Visible = False
            deleteAllButton.Visible = False
            deletefileButton.Visible = False
            infectedLabel.Visible = True
            onFileLabel.Visible = True
            elapsedLabel.Visible = True
            scanningFileLabel.Visible = True
            numberInfectedFilesLabel.Visible = True
            scanProgressBar.Visible = True
            percentLabel.Visible = True
            fileCountLabel.Visible = True
            currentFile.Visible = True
            elapsedTimeLabel.Visible = True
        End If
        Dim aPath As String = Application.StartupPath()
        If IO.File.Exists(aPath & "\ProgramSettings.ini") Then
            IO.File.Delete(aPath & "\ProgramSettings.ini")
        Else
            settingsForm.realTimeCheckBox.Checked = True

        End If




        Using writer As New StreamWriter(aPath & "\ProgramSettings.ini", True)
            If settingsForm.realTimeCheckBox.Checked = True Then
                writer.WriteLine("realCheck = False")
                settingsForm.realTimeCheckBox.Text = "Off"
                My.Settings.realTimeScan = False
                realTimeLabel.Visible = True
                realTimeOffButton.Visible = True
                realTimeOnButton.Visible = True
                copyHashButton.Visible = False
                filesPropertiesButton.Visible = False
                startQuickScan.Visible = False
                startFullScan.Visible = False
                stopFullScanButton.Visible = False
                startFolderScan.Visible = False
                stopFolderScan.Visible = False
                stopQuickScan.Visible = False
                quickScanLabel.Visible = False
                fullScanLabel.Visible = False
                quarantineLabel.Visible = False
                folderScanLabel.Visible = False
                quarantineGridView.Visible = False
                restoreAllButton.Visible = False
                restoreFileButton.Visible = False
                deleteAllButton.Visible = False
                deletefileButton.Visible = False
                infectedLabel.Visible = True
                onFileLabel.Visible = True
                elapsedLabel.Visible = True
                scanningFileLabel.Visible = True
                numberInfectedFilesLabel.Visible = True
                scanProgressBar.Visible = True
                percentLabel.Visible = True
                fileCountLabel.Visible = True
                currentFile.Visible = True
                elapsedTimeLabel.Visible = True
                FileSystemWatcher1.EnableRaisingEvents = False
                WriteToLog("Real Time Scan Stopped At: " & Date.Now & "")
            Else
            End If
        End Using
        statusLabel.Text = "Real-Time Scan Stopped..."
        statusLabel.Refresh()
        realTimeOnButton.Enabled = True
        realTimeOffButton.Enabled = False
        My.Settings.realTimeScan = False
        My.Settings.Save()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        realTimeLabel.Visible = True
        realTimeOffButton.Visible = True
        realTimeOnButton.Visible = True

        startQuickScan.Visible = False
        startFullScan.Visible = False
        startFolderScan.Visible = False
        stopFolderScan.Visible = False
        stopQuickScan.Visible = False
        quickScanLabel.Visible = False
        fullScanLabel.Visible = False
        quarantineLabel.Visible = False
        folderScanLabel.Visible = False
        quarantineGridView.Visible = False
        restoreAllButton.Visible = False
        restoreFileButton.Visible = False
        deleteAllButton.Visible = False
        deletefileButton.Visible = False

        infectedLabel.Visible = True
        onFileLabel.Visible = True
        elapsedLabel.Visible = True
        scanningFileLabel.Visible = True
        numberInfectedFilesLabel.Visible = True
        scanProgressBar.Visible = True
        percentLabel.Visible = True
        fileCountLabel.Visible = True
        currentFile.Visible = True
        elapsedTimeLabel.Visible = True
    End Sub

    'Public Sub filterData(valueToSearch As String)
    '    Try
    '        Dim searchQuery As String = "SELECT * FROM VirusHasListFinal2 WHERE Hashes LIKE '%" & valueToSearch & "%'"
    '        Dim command As New SqlCommand(searchQuery, connection)
    '        Dim adapter As New SqlDataAdapter(command)
    '        Dim table As New DataTable()

    '        adapter.Fill(table)

    '        DataGridView1.DataSource = table
    '    Catch ex As Exception

    '    End Try


    'End Sub

    Private Sub scanTimer_Tick(sender As Object, e As EventArgs) Handles scanTimer.Tick
        restoreFileButton.Enabled = False
        restoreAllButton.Enabled = False
        deletefileButton.Enabled = False
        deleteAllButton.Enabled = False
        copyHashButton.Enabled = False
        filesPropertiesButton.Enabled = False


        scanProgressBar.Maximum = Conversions.ToString(ListBox3.Items.Count)
        fileCountLabel.Text = "" & fileCountOn & " Out Of " & Conversions.ToString(ListBox3.Items.Count)

        If Not scanProgressBar.Value = scanProgressBar.Maximum Then
            If (quickScanBGW.CancellationPending = True) Then
                Do
                    If (quickScanBGW.CancellationPending = True) Then
                        If (quickScanBGW.IsBusy = True) Then
                            quickScanBGW.CancelAsync()
                            GoTo cancelScan
                        End If

                    End If
                Loop
            End If
            If (fullScanBGW.CancellationPending = True) Then
                Do
                    If (fullScanBGW.CancellationPending = True) Then
                        If (fullScanBGW.IsBusy = True) Then
                            fullScanBGW.CancelAsync()
                            GoTo cancelScan
                        End If

                    End If
                Loop
            End If
            If (folderScanBGW.CancellationPending = True) Then
                Do
                    If (folderScanBGW.CancellationPending = True) Then
                        If (folderScanBGW.IsBusy = True) Then
                            folderScanBGW.CancelAsync()
                            GoTo cancelScan
                        End If

                    End If
                Loop
            End If
            Try

                ListBox3.SelectedIndex = ListBox3.SelectedIndex + 1
                currentFile.Text = ListBox3.SelectedItem.ToString
            Catch ex As Exception
            End Try




            Try

                Dim secondsTotal As Integer = elapsedTimerSW.Elapsed.TotalSeconds

                seconds1 = secondsTotal
                If seconds1 = 60 Then
                    secondsTotal = 0
                    seconds1 = 0
                    elapsedTimerSW.Restart()
                    minutes1 += 1
                    If minutes1 = 60 Then
                        hours1 += 1
                        minutes1 = 0
                    End If
                End If



                elapsedTimeLabel.Text = "" & hours1.ToString() & " Hour(s) - " & minutes1.ToString() & " Minute(s) - " & seconds1.ToString() & " Second(s)"
                elapsedTimeLabel.Refresh()
                scanProgressBar.Increment(1)
                scanProgressBar.Refresh()

                numberInfectedFilesLabel.Text = Conversions.ToString(quarantineGridView.Rows.Count)
                fileCountOn += 1

                Dim sig As String = GetCRC32(ListBox3.SelectedItem)
                statusLabel.Text = "CRC32 Hash: " & sig
                statusLabel.Refresh()
                iconPicBox.Image = Drawing.Icon.ExtractAssociatedIcon(ListBox3.SelectedItem).ToBitmap()
                iconPicBox.Refresh()
                fileCountLabel.Text = fileCountOn & " Out Of " & ListBox3.Items.Count
                fileCountLabel.Refresh()
                Dim num As Decimal
                num = (Conversions.ToString(scanProgressBar.Value) / ListBox3.Items.Count) * 100
                Dim numPercent As Decimal = Math.Round(num, 2)
                percentLabel.Text = numPercent.ToString() & "%"
                percentLabel.Refresh()

                'This is my check against the database, but the database is too big of a file to upload to GitHub
                'Dim intValue As Integer
                'intValue = Array.BinarySearch(signatures, sig)
                'If intValue > 0 Then
                '    Dim row As String() = New String() {ListBox3.SelectedItem, sig, GetFileSize(ListBox3.SelectedItem)}
                '    quarantineGridView.Rows.Add(row)
                '    numberInfected += 1
                '    numberInfectedFilesLabel.ForeColor = Color.Red
                '    numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
                '    scanProgressBar.BackColor = Color.Red
                'Else
                '    'MsgBox("No value found", , "Error")
                'End If


                'Dim idx As Integer = signatures.IndexOf(GenerateSHA512String(ListBox3.SelectedItem))

                'If idx = -1 Then

                'Else
                '    AddFileToQuarantine(ListBox3.SelectedItem)
                '    numberInfected += 1
                '    numberInfectedFilesLabel.ForeColor = Color.Red
                '    numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
                'End If




            Catch ex As Exception
            End Try






        Else
cancelScan:
            scanTimer.Stop()
            If quarantineGridView.Rows.Count > 0 Then
                statusLabel.Text = ("Finished Scanning A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - " & ListBox1.Items.Count & " Threats Detected")
                statusLabel.Refresh()
                copyHashButton.Enabled = True
                filesPropertiesButton.Enabled = True
                restoreFileButton.Enabled = True
                restoreAllButton.Enabled = True
                deletefileButton.Enabled = True
                deleteAllButton.Enabled = True
                startFullScan.Enabled = True
                startQuickScan.Enabled = True
                startFolderScan.Enabled = True
                realTimeOnButton.Enabled = True
                iconPicBox.Image = Nothing
                currentFile.Text = ""
                fileCountOn = 0
                fileCountLabel.Text = "0 Out O"
                numberInfectedFilesLabel.Text = "0"
                numberInfectedFilesLabel.ForeColor = Color.White
                scanProgressBar.ForeColor = Color.Blue
                percentLabel.Text = "0%"
                elapsedTimerSW.Stop()
                elapsedTimerSW.Reset()
                elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
                scanProgressBar.Value = 0

                quarantineButton_Click(sender, e)
            Else
                statusLabel.Text = ("Finished Scanning A Total Of " & fileCountOn & " Files In " & elapsedTimeLabel.Text & " - No Threats Detected")
                statusLabel.Refresh()
                restoreFileButton.Enabled = True
                restoreAllButton.Enabled = True
                deletefileButton.Enabled = True
                deleteAllButton.Enabled = True
                startFullScan.Enabled = True
                startQuickScan.Enabled = True
                startFolderScan.Enabled = True
                realTimeOnButton.Enabled = True
                iconPicBox.Image = Nothing
                currentFile.Text = ""
                fileCountOn = 0
                fileCountLabel.Text = "0 Out O"
                numberInfectedFilesLabel.Text = "0"
                numberInfectedFilesLabel.ForeColor = Color.White
                scanProgressBar.ForeColor = Color.Blue
                percentLabel.Text = "0%"
                elapsedTimerSW.Stop()
                elapsedTimerSW.Reset()
                elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
                scanProgressBar.Value = 0
            End If
        End If
    End Sub

    Private Sub getSignatures_DoWork(sender As Object, e As DoWorkEventArgs) Handles getSignatures.DoWork
        Try
            If IO.File.Exists((Application.StartupPath & "\" & "VirusSignatures.dat")) Then
                signatures = System.IO.File.ReadAllLines(Application.StartupPath & "\" & "VirusSignatures.dat").OrderBy(Function(x) Asc(x)).ToArray
            Else
                MessageBox.Show("You Must Have The (VirusSignatures.dat) File Inside Of The Main Program Directory!", "Mythodikal Anti-Virus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            signaturesCount = signatures.Count
        Catch ex As IO.FileNotFoundException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        On Error GoTo done

        Dim fileNow As New IO.FileInfo(e.FullPath)
        If fileNow.FullName.Contains("Tera") Then
            GoTo done
        End If
        If fileNow.Length >= 4194304 Then
            GoTo done
        Else
            ListBox3.Items.Add(e.FullPath)

            For x As Integer = 0 To ListBox2.Items.Count - 1
                If cancelRealTimeScan = True Then
                    My.Settings.realTimeScan = False
                    FileSystemWatcher1.Dispose()
                    fileCountOn = 0
                    'fileCount = 0
                    fileCountLabel.Text = "0 Out Of 0"
                    numberInfectedFilesLabel.Text = "0"
                    numberInfectedFilesLabel.ForeColor = Color.White
                    scanProgressBar.ForeColor = Color.Blue
                    percentLabel.Text = "0%"
                    scanProgressBar.Value = 0
                    scanningFileLabel.Text = "File Being Scanned: "
                    currentFile.Text = ""
                    Exit Sub
                End If
                Dim fileNow2 As String = ListBox2.Items(x).Substring(0, ListBox2.Items(x).Length - 1)
                If (fileNow2 = (e.FullPath)) Then
                    GoTo done
                Else
                End If
            Next




            For i = 0 To ListBox1.Items.Count - 1
                If cancelRealTimeScan = True Then
                    My.Settings.realTimeScan = False
                    FileSystemWatcher1.Dispose()
                    fileCountOn = 0
                    'fileCount = 0
                    fileCountLabel.Text = "0 Out Of 0"
                    numberInfectedFilesLabel.Text = "0"
                    numberInfectedFilesLabel.ForeColor = Color.White
                    scanProgressBar.ForeColor = Color.Blue
                    percentLabel.Text = "0%"
                    scanProgressBar.Value = 0
                    scanningFileLabel.Text = "File Being Scanned: "
                    currentFile.Text = ""
                    Exit For
                    Exit Sub
                End If
                ListBox1.SelectedIndex = i
                Dim myVariable As String = System.IO.Path.GetExtension(e.FullPath())

                Dim blah As String = ListBox1.Items(i).ToString.Remove(0, 1)
                If blah = myVariable Then



                    currentFile.Text = "" & e.FullPath
                    currentFile.Refresh()
                    Dim sig As String = GetCRC32(e.FullPath)
                    statusLabel.Text = "CRC32 Hash " & sig
                    statusLabel.Refresh()
                    fileCountOn += 1

                    fileCountLabel.Text = "" & fileCountOn & " Out Of " & ListBox3.Items.Count & ""
                    fileCountLabel.Refresh()
                    'This is my check against the database, but the database is too big of a file to upload to GitHub
                    'Dim intValue As Integer
                    'intValue = Array.BinarySearch(signatures, sig)
                    'If intValue > 0 Then
                    '    Dim row As String() = New String() {e.FullPath, GetCRC32(e.FullPath), GetFileSize(e.FullPath)}
                    '    quarantineGridView.Rows.Add(row)
                    '    numberInfected += 1
                    '    numberInfectedFilesLabel.ForeColor = Color.Red
                    '    numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
                    '    scanProgressBar.BackColor = Color.Red
                    'Else
                    '    'MsgBox("No value found", , "Error")
                    'End If
                Else
                End If

            Next
done:
        End If
    End Sub

    Private Sub FileSystemWatcher1_Renamed(sender As Object, e As RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        On Error GoTo done

        Dim fileNow As New IO.FileInfo(e.FullPath)
        If fileNow.FullName.Contains("Tera") Then
            GoTo done
        End If
        If fileNow.Length >= 4194304 Then
            GoTo done
        Else
            ListBox3.Items.Add(e.FullPath)

            For x As Integer = 0 To ListBox2.Items.Count - 1
                If cancelRealTimeScan = True Then
                    My.Settings.realTimeScan = False
                    FileSystemWatcher1.Dispose()
                    fileCountOn = 0
                    'fileCount = 0
                    fileCountLabel.Text = "0 Out Of 0"
                    numberInfectedFilesLabel.Text = "0"
                    numberInfectedFilesLabel.ForeColor = Color.White
                    scanProgressBar.ForeColor = Color.Blue
                    percentLabel.Text = "0%"
                    scanProgressBar.Value = 0
                    scanningFileLabel.Text = "File Being Scanned: "
                    currentFile.Text = ""
                    Exit Sub
                End If
                Dim fileNow2 As String = ListBox2.Items(x).Substring(0, ListBox2.Items(x).Length - 1)
                If (fileNow2 = (e.FullPath)) Then
                    GoTo done
                Else
                End If
            Next




            For i = 0 To ListBox1.Items.Count - 1
                If cancelRealTimeScan = True Then
                    My.Settings.realTimeScan = False
                    FileSystemWatcher1.Dispose()
                    fileCountOn = 0
                    'fileCount = 0
                    fileCountLabel.Text = "0 Out Of 0"
                    numberInfectedFilesLabel.Text = "0"
                    numberInfectedFilesLabel.ForeColor = Color.White
                    scanProgressBar.ForeColor = Color.Blue
                    percentLabel.Text = "0%"
                    scanProgressBar.Value = 0
                    scanningFileLabel.Text = "File Being Scanned: "
                    currentFile.Text = ""
                    Exit For
                    Exit Sub
                End If
                ListBox1.SelectedIndex = i
                Dim myVariable As String = System.IO.Path.GetExtension(e.FullPath())

                Dim blah As String = ListBox1.Items(i).ToString.Remove(0, 1)
                If blah = myVariable Then



                    currentFile.Text = "" & e.FullPath
                    currentFile.Refresh()

                    Dim sig As String = GetCRC32(e.FullPath)
                    statusLabel.Text = "CRC32 Hash " & sig
                    statusLabel.Refresh()
                    fileCountOn += 1

                    fileCountLabel.Text = "" & fileCountOn & " Out Of " & ListBox3.Items.Count & ""
                    fileCountLabel.Refresh()

                    'This is my check against the database, but the database is too big of a file to upload to GitHub
                    'Dim intValue As Integer
                    'intValue = Array.BinarySearch(signatures, sig)
                    'If intValue > 0 Then
                    '    Dim row As String() = New String() {e.FullPath, GetCRC32(e.FullPath), GetFileSize(e.FullPath)}
                    '    quarantineGridView.Rows.Add(row)
                    '    numberInfected += 1
                    '    numberInfectedFilesLabel.ForeColor = Color.Red
                    '    numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
                    '    scanProgressBar.BackColor = Color.Red
                    'Else
                    '    'MsgBox("No value found", , "Error")
                    'End If
                    'End If
                Else
                End If

            Next
done:
        End If
    End Sub

    Private Sub FileSystemWatcher1_Created(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Created
        On Error GoTo done

        Dim fileNow As New IO.FileInfo(e.FullPath)
        If fileNow.FullName.Contains("Tera") Then
            GoTo done
        End If
        ListBox3.Items.Add(e.FullPath)

        For x As Integer = 0 To ListBox2.Items.Count - 1
            If cancelRealTimeScan = True Then
                My.Settings.realTimeScan = False
                FileSystemWatcher1.Dispose()
                fileCountOn = 0
                'fileCount = 0
                fileCountLabel.Text = "0 Out Of 0"
                numberInfectedFilesLabel.Text = "0"
                numberInfectedFilesLabel.ForeColor = Color.White
                scanProgressBar.ForeColor = Color.Blue
                percentLabel.Text = "0%"
                scanProgressBar.Value = 0
                scanningFileLabel.Text = "File Being Scanned: "
                currentFile.Text = ""
                Exit Sub
            End If
            Dim fileNow2 As String = ListBox2.Items(x).Substring(0, ListBox2.Items(x).Length - 1)
            If (fileNow2 = (e.FullPath)) Then
                GoTo done
            Else
            End If
        Next




        For i = 0 To ListBox1.Items.Count - 1
            If cancelRealTimeScan = True Then
                My.Settings.realTimeScan = False
                FileSystemWatcher1.Dispose()
                fileCountOn = 0
                'fileCount = 0
                fileCountLabel.Text = "0 Out Of 0"
                numberInfectedFilesLabel.Text = "0"
                numberInfectedFilesLabel.ForeColor = Color.White
                scanProgressBar.ForeColor = Color.Blue
                percentLabel.Text = "0%"
                scanProgressBar.Value = 0
                scanningFileLabel.Text = "File Being Scanned: "
                currentFile.Text = ""
                Exit For
                Exit Sub
            End If
            ListBox1.SelectedIndex = i
            Dim myVariable As String = System.IO.Path.GetExtension(e.FullPath())

            Dim blah As String = ListBox1.Items(i).ToString.Remove(0, 1)
            If blah = myVariable Then



                currentFile.Text = "" & e.FullPath
                currentFile.Refresh()
                Dim sig As String = GetCRC32(e.FullPath)
                statusLabel.Text = "CRC32 Hash " & sig
                statusLabel.Refresh()
                fileCountOn += 1

                fileCountLabel.Text = "" & fileCountOn & " Out Of " & ListBox3.Items.Count & ""
                fileCountLabel.Refresh()

                'This is my check against the database, but the database is too big of a file to upload to GitHub
                'Dim intValue As Integer
                'intValue = Array.BinarySearch(signatures, sig)
                'If intValue > 0 Then
                '    Dim row As String() = New String() {e.FullPath, GetCRC32(e.FullPath), GetFileSize(e.FullPath)}
                '    quarantineGridView.Rows.Add(row)
                '    numberInfected += 1
                '    numberInfectedFilesLabel.ForeColor = Color.Red
                '    numberInfectedFilesLabel.Text = numberInfected.ToString("N0")
                '    scanProgressBar.BackColor = Color.Red
                'Else
                '    'MsgBox("No value found", , "Error")
                'End If
                'Dim idx As Integer = signatures.IndexOf(GenerateSHA512String(e.FullPath))
                'If idx = -1 Then

                'Else


                'End If
            Else
            End If
        Next
done:
    End Sub

    Private Sub scheduledScan_Tick(sender As Object, e As EventArgs) Handles scheduledScanTimer.Tick
        Dim date1 As Date = settingsForm.MonthCalendar2.SelectionEnd()
        'MessageBox.Show(date1)
        If settingsForm.MonthCalendar2.TodayDate = date1 Then
            '  MessageBox.Show(settingsForm.MonthCalendar2.TodayDate)
            If settingsForm.hourUpAndDown.Value = TimeOfDay.Hour Then
                If settingsForm.minuteUpAndDown.Value = TimeOfDay.Minute Then
                    If settingsForm.quickScanRadioButton.Checked Then
                        CheckForIllegalCrossThreadCalls = False
                        If quickScanBGW.IsBusy = True Then
                            Exit Sub
                        ElseIf scanTimer.Enabled = False Then
                            quickScanButton_Click(sender, e)
                            scheduledScanTimer.Enabled = False
                            scanRunningProcessesQuick.RunWorkerAsync()
                            scanProgressBar.Update()
                            WriteToLog("Quick Scan Started - " & Date.Now.ToString() & "")
                            CheckForIllegalCrossThreadCalls = False
                            scanTimer.Start()
                            elapsedTimerSW.Start()
                            fileCountOn = 0
                        End If
                    End If
                    If settingsForm.fullScanRadioButton.Checked Then
                        CheckForIllegalCrossThreadCalls = False
                        If fullScanBGW.IsBusy = True Then
                            Exit Sub
                        ElseIf scanTimer.Enabled = False Then
                            fullScanButton_Click(sender, e)
                            scheduledScanTimer.Enabled = False
                            scanRunningProcessesFull.RunWorkerAsync()
                            scanProgressBar.Update()
                            WriteToLog("Full Scan Started - " & Date.Now.ToString() & "")
                            CheckForIllegalCrossThreadCalls = False
                            scanTimer.Start()
                            elapsedTimerSW.Start()
                            fileCountOn = 0
                        End If
                    End If
                    If settingsForm.folderScanRadioButton.Checked Then
                        Dim blah As New FolderBrowserDialog
                        blah.ShowNewFolderButton = True
                        If (blah.ShowDialog() = DialogResult.OK) Then
                            currentDirectory = blah.SelectedPath & "\"
                        Else
                            Exit Sub
                        End If
                        If folderScanBGW.IsBusy = True Then
                            Exit Sub
                        ElseIf scanTimer.Enabled = False Then
                            folderScanButton_Click(sender, e)
                            scheduledScanTimer.Enabled = False
                            scanSubfolders(currentDirectory, Me.ListBox3)
                            WriteToLog("Folder Scan Started - " & Date.Now.ToString() & "")
                            scanTimer.Start()
                            elapsedTimerSW.Start()
                            folderScanBGW.RunWorkerAsync()
                            folderScanBGW.WorkerSupportsCancellation = True
                            fileCountOn = 0
                            CheckForIllegalCrossThreadCalls = False
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub getSignatures_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles getSignatures.RunWorkerCompleted
        statusLabel.Text = "Loaded A Total Of " & signaturesCount.ToString("N0") & " Virus Signatures..."
        loadMythodikalTimer.Enabled = True

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles loadMythodikalTimer.Tick
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            ctrl.Enabled = True
        Next

        Dim numLoadsNow As Integer = 0
        numLoadsNow = My.Settings.numLoads
        numLoadsNow += 1
        My.Settings.numLoads = numLoadsNow

        If numLoadsNow = 1 Then
            MessageBox.Show("Welcome To Mythodikal Anti-Virus!  I Hope That You Enjoy This Program" &
            "As Much As I Had The Pleasure Of Programming It! Thanks For The Support", "Mythodikal Anti-Virus", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'connection.Open()
        StartDetection()
        _loc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        _loc = "" & _loc & "\MythodikalAntiVirus\Quarantine\"

        If Not Directory.Exists(_loc) Then
            Directory.CreateDirectory(_loc)
        End If






        Dim aPath As String = Application.StartupPath()
        If IO.File.Exists(aPath & "\ProgramSettings.ini") Then
            Dim lines = IO.File.ReadAllLines(aPath & "\ProgramSettings.ini")
            If lines.Contains("realCheck = False") Then
                My.Settings.realTimeScan = False
                realTimeOffButton.Enabled = False
                realTimeOnButton.Enabled = True
            Else
                My.Settings.realTimeScan = True
                realTimeOffButton.Enabled = True
                realTimeOnButton.Enabled = False
                statusLabel.Text = "Starting Real-Time Scan..."
                FileSystemWatcher1.EnableRaisingEvents = True
                WriteToLog("Real Time Scan Started At: " & Date.Now & "")
            End If

            If lines.Contains("realCheck = False") Then
                settingsForm.realTimeCheckBox.Checked = False
                settingsForm.realTimeCheckBox.Text = "Off"
                My.Settings.realTimeScan = False
            Else
                settingsForm.realTimeCheckBox.Checked = True
                settingsForm.realTimeCheckBox.Text = "On"
                My.Settings.realTimeScan = True
            End If

            If lines.Contains("windowsStart = False") Then
                settingsForm.windowsStartCheckBox.Checked = False
                settingsForm.windowsStartCheckBox.Text = "Off"
            Else
                settingsForm.windowsStartCheckBox.Checked = True
                settingsForm.windowsStartCheckBox.Text = "On"
            End If

            If lines.Contains("archiveFiles = False") Then
                settingsForm.archivedFilesCheckBox.Checked = False
                settingsForm.archivedFilesCheckBox.Text = "Off"
            Else
                settingsForm.archivedFilesCheckBox.Checked = True
                settingsForm.archivedFilesCheckBox.Text = "On"
            End If

            If lines.Contains("webProtect = False") Then
                settingsForm.webProtectionCheckBox.Checked = False
                settingsForm.webProtectionCheckBox.Text = "Off"
            Else
                settingsForm.webProtectionCheckBox.Checked = True
                settingsForm.webProtectionCheckBox.Text = "On"
            End If

            If lines.Contains("scheduledScan = False") Then
                settingsForm.scheduleDateAndTimeButton.Enabled = True
                settingsForm.clearScanDateAndTimeButton.Enabled = False
            Else
                settingsForm.scheduleDateAndTimeButton.Enabled = False
                settingsForm.clearScanDateAndTimeButton.Enabled = True
            End If
            If lines.Contains("quickScan = True") = True Then
                settingsForm.quickScanRadioButton.Checked = True
            Else
                settingsForm.quickScanRadioButton.Checked = False
            End If
            If lines.Contains("fullScan = True") = True Then
                settingsForm.fullScanRadioButton.Checked = True
            Else
                settingsForm.fullScanRadioButton.Checked = False
            End If
            If lines.Contains("folderScan = True") = True Then
                settingsForm.folderScanRadioButton.Checked = True
            Else
                settingsForm.folderScanRadioButton.Checked = False
            End If
            Dim dateEnd As Date = Nothing
            If My.Settings.scheduleDate = "" Then
                settingsForm.MonthCalendar2.SelectionEnd = Date.Today
            Else
                dateEnd = My.Settings.scheduleDate
            End If
            If lines.Contains("scanDate = " & dateEnd) Then
                settingsForm.MonthCalendar2.SelectionEnd = dateEnd
            Else
            End If
            Dim scanHourNow As String = Nothing
            If My.Settings.scheduleHour = "" Then
                settingsForm.hourUpAndDown.Value = 0
            Else
                scanHourNow = My.Settings.scheduleHour
            End If
            If lines.Contains("scanHour = " & scanHourNow) Then
                settingsForm.hourUpAndDown.Value = scanHourNow
            Else
            End If

            Dim scanMinuteNow As String = Nothing
            If My.Settings.scheduleMinute = "" Then
                settingsForm.minuteUpAndDown.Value = 0
            Else
                scanMinuteNow = My.Settings.scheduleMinute
            End If
            If lines.Contains("scanMinute = " & scanMinuteNow) Then
                settingsForm.minuteUpAndDown.Value = scanMinuteNow
            Else
            End If
        End If

        If My.Settings.allowedProgramsList Is Nothing Then
            My.Settings.allowedProgramsList = New System.Collections.Specialized.StringCollection()
        Else
            settingsForm.allowProgramsListBox.Items.Clear()
            For Each allowedProgram As String In My.Settings.allowedProgramsList
                settingsForm.allowProgramsListBox.Items.Add(allowedProgram)
            Next
        End If
        My.Settings.Save()
        ListBox2.Items.AddRange(settingsForm.allowProgramsListBox.Items)

        realTimeLabel.Visible = True
        realTimeOffButton.Visible = True
        realTimeOnButton.Visible = True
        copyHashButton.Visible = False
        filesPropertiesButton.Visible = False
        startFolderScan.Visible = False
        stopFolderScan.Visible = False
        stopFullScanButton.Visible = False
        startQuickScan.Visible = False
        startFullScan.Visible = False
        stopQuickScan.Visible = False
        quickScanLabel.Visible = False
        fullScanLabel.Visible = False
        quarantineLabel.Visible = False
        folderScanLabel.Visible = False
        quarantineGridView.Visible = False
        restoreAllButton.Visible = False
        restoreFileButton.Visible = False
        deleteAllButton.Visible = False
        deletefileButton.Visible = False
        quarantineGroupBox.Visible = False
        scanGroupBox.Visible = True
        loadMythodikalTimer.Enabled = False
        exitPicBox.Enabled = True
    End Sub

    Private Sub scanRunningProcessesQuick_DoWork(sender As Object, e As DoWorkEventArgs) Handles scanRunningProcessesQuick.DoWork
        scanProcesses()
    End Sub

    Private Sub scanRunningProcesses_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles scanRunningProcessesQuick.RunWorkerCompleted
        quickScanBGW.RunWorkerAsync()
        quickScanBGW.WorkerSupportsCancellation = True

        scanTimer.Start()
        elapsedTimerSW.Start()
        fileCountOn = 0
    End Sub

    Private Sub scanRunningProcessesFull_DoWork(sender As Object, e As DoWorkEventArgs) Handles scanRunningProcessesFull.DoWork
        scanProcesses()

    End Sub

    Private Sub scanRunningProcessesFull_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles scanRunningProcessesFull.RunWorkerCompleted
        fullScanBGW.RunWorkerAsync()
        fullScanBGW.WorkerSupportsCancellation = True

        scanTimer.Start()
        elapsedTimerSW.Start()
        fileCountOn = 0
    End Sub

    Private Sub startQuickScan_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles startQuickScan.ChangeUICues

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class



