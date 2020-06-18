<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.quarantineGroupBox = New System.Windows.Forms.GroupBox()
        Me.quarantineGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.restoreFileButton = New System.Windows.Forms.Button()
        Me.restoreAllButton = New System.Windows.Forms.Button()
        Me.deletefileButton = New System.Windows.Forms.Button()
        Me.deleteAllButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.realTimeScanButton = New System.Windows.Forms.Button()
        Me.folderScanButton = New System.Windows.Forms.Button()
        Me.quarantineButton = New System.Windows.Forms.Button()
        Me.quickScanButton = New System.Windows.Forms.Button()
        Me.fullScanButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.scanGroupBox = New System.Windows.Forms.GroupBox()
        Me.numFilesPerSecondLabel = New System.Windows.Forms.Label()
        Me.filePerSecondLabel = New System.Windows.Forms.Label()
        Me.timeLeftLabel = New System.Windows.Forms.Label()
        Me.iconPicBox = New System.Windows.Forms.PictureBox()
        Me.filesIconLabel = New System.Windows.Forms.Label()
        Me.totalProgressLabel = New System.Windows.Forms.Label()
        Me.percentLabel = New System.Windows.Forms.Label()
        Me.scanProgressBar = New System.Windows.Forms.ProgressBar()
        Me.fileCountLabel = New System.Windows.Forms.Label()
        Me.onFileLabel = New System.Windows.Forms.Label()
        Me.numberInfectedFilesLabel = New System.Windows.Forms.Label()
        Me.infectedLabel = New System.Windows.Forms.Label()
        Me.elapsedTimeLabel = New System.Windows.Forms.Label()
        Me.elapsedLabel = New System.Windows.Forms.Label()
        Me.currentFile = New System.Windows.Forms.Label()
        Me.scanningFileLabel = New System.Windows.Forms.Label()
        Me.realTimeLabel = New System.Windows.Forms.Label()
        Me.copyHashButton = New System.Windows.Forms.Button()
        Me.stopFullScanButton = New System.Windows.Forms.Button()
        Me.filesPropertiesButton = New System.Windows.Forms.Button()
        Me.realTimeOffButton = New System.Windows.Forms.Button()
        Me.realTimeOnButton = New System.Windows.Forms.Button()
        Me.startFolderScan = New System.Windows.Forms.Button()
        Me.folderScanLabel = New System.Windows.Forms.Label()
        Me.stopFolderScan = New System.Windows.Forms.Button()
        Me.startFullScan = New System.Windows.Forms.Button()
        Me.stopQuickScan = New System.Windows.Forms.Button()
        Me.startQuickScan = New System.Windows.Forms.Button()
        Me.quickScanLabel = New System.Windows.Forms.Label()
        Me.quarantineLabel = New System.Windows.Forms.Label()
        Me.fullScanLabel = New System.Windows.Forms.Label()
        Me.folderScanBGW = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FolderScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuarantineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quickScanBGW = New System.ComponentModel.BackgroundWorker()
        Me.fullScanBGW = New System.ComponentModel.BackgroundWorker()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.scanRunningProcessesQuick = New System.ComponentModel.BackgroundWorker()
        Me.menuPicBox = New System.Windows.Forms.PictureBox()
        Me.minimizePicBox = New System.Windows.Forms.PictureBox()
        Me.exitPicBox = New System.Windows.Forms.PictureBox()
        Me.USBDriveScanTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.getSignatures = New System.ComponentModel.BackgroundWorker()
        Me.scheduledScanTimer = New System.Windows.Forms.Timer(Me.components)
        Me.scanRunningProcessesFull = New System.ComponentModel.BackgroundWorker()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.notifyQuarantineFile = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.etaTimer = New System.Windows.Forms.Timer(Me.components)
        Me.realTimeScanBGW = New System.ComponentModel.BackgroundWorker()
        Me.loadMythodikal = New System.ComponentModel.BackgroundWorker()
        Me.scanFilesBGW = New System.ComponentModel.BackgroundWorker()
        Me.filesPerSecTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.quarantineGroupBox.SuspendLayout()
        CType(Me.quarantineGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.scanGroupBox.SuspendLayout()
        CType(Me.iconPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.menuPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.titleLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(638, 52)
        Me.Panel1.TabIndex = 4
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.Snow
        Me.titleLabel.Location = New System.Drawing.Point(3, 14)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(479, 27)
        Me.titleLabel.TabIndex = 5
        Me.titleLabel.Text = "Mythodikal Anti-Virus - Last Scan: "
        '
        'quarantineGroupBox
        '
        Me.quarantineGroupBox.Controls.Add(Me.quarantineGridView)
        Me.quarantineGroupBox.Controls.Add(Me.restoreFileButton)
        Me.quarantineGroupBox.Controls.Add(Me.restoreAllButton)
        Me.quarantineGroupBox.Controls.Add(Me.deletefileButton)
        Me.quarantineGroupBox.Controls.Add(Me.deleteAllButton)
        Me.quarantineGroupBox.Location = New System.Drawing.Point(8, 55)
        Me.quarantineGroupBox.Name = "quarantineGroupBox"
        Me.quarantineGroupBox.Size = New System.Drawing.Size(575, 341)
        Me.quarantineGroupBox.TabIndex = 75
        Me.quarantineGroupBox.TabStop = False
        '
        'quarantineGridView
        '
        Me.quarantineGridView.AllowUserToAddRows = False
        Me.quarantineGridView.AllowUserToDeleteRows = False
        Me.quarantineGridView.AllowUserToOrderColumns = True
        Me.quarantineGridView.BackgroundColor = System.Drawing.SystemColors.Desktop
        Me.quarantineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.quarantineGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.quarantineGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.quarantineGridView.GridColor = System.Drawing.Color.White
        Me.quarantineGridView.Location = New System.Drawing.Point(8, 19)
        Me.quarantineGridView.MultiSelect = False
        Me.quarantineGridView.Name = "quarantineGridView"
        Me.quarantineGridView.ReadOnly = True
        Me.quarantineGridView.RowHeadersVisible = False
        Me.quarantineGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.quarantineGridView.Size = New System.Drawing.Size(556, 281)
        Me.quarantineGridView.TabIndex = 66
        '
        'Column1
        '
        Me.Column1.HeaderText = "Virus Location"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 250
        '
        'Column2
        '
        Me.Column2.HeaderText = "Virus Hash"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Size Of File"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'restoreFileButton
        '
        Me.restoreFileButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.restoreFileButton.Font = New System.Drawing.Font("Snap ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restoreFileButton.ForeColor = System.Drawing.Color.White
        Me.restoreFileButton.Location = New System.Drawing.Point(8, 311)
        Me.restoreFileButton.Name = "restoreFileButton"
        Me.restoreFileButton.Size = New System.Drawing.Size(115, 23)
        Me.restoreFileButton.TabIndex = 65
        Me.restoreFileButton.Text = "Restore File"
        Me.restoreFileButton.UseVisualStyleBackColor = False
        '
        'restoreAllButton
        '
        Me.restoreAllButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.restoreAllButton.Font = New System.Drawing.Font("Snap ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restoreAllButton.ForeColor = System.Drawing.Color.White
        Me.restoreAllButton.Location = New System.Drawing.Point(149, 311)
        Me.restoreAllButton.Name = "restoreAllButton"
        Me.restoreAllButton.Size = New System.Drawing.Size(115, 23)
        Me.restoreAllButton.TabIndex = 64
        Me.restoreAllButton.Text = "Restore All"
        Me.restoreAllButton.UseVisualStyleBackColor = False
        '
        'deletefileButton
        '
        Me.deletefileButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.deletefileButton.Font = New System.Drawing.Font("Snap ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletefileButton.ForeColor = System.Drawing.Color.White
        Me.deletefileButton.Location = New System.Drawing.Point(300, 311)
        Me.deletefileButton.Name = "deletefileButton"
        Me.deletefileButton.Size = New System.Drawing.Size(115, 23)
        Me.deletefileButton.TabIndex = 63
        Me.deletefileButton.Text = "Delete File"
        Me.deletefileButton.UseVisualStyleBackColor = False
        '
        'deleteAllButton
        '
        Me.deleteAllButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.deleteAllButton.Font = New System.Drawing.Font("Snap ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteAllButton.ForeColor = System.Drawing.Color.White
        Me.deleteAllButton.Location = New System.Drawing.Point(449, 311)
        Me.deleteAllButton.Name = "deleteAllButton"
        Me.deleteAllButton.Size = New System.Drawing.Size(115, 25)
        Me.deleteAllButton.TabIndex = 62
        Me.deleteAllButton.Text = "Delete All Files"
        Me.deleteAllButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel2.Controls.Add(Me.realTimeScanButton)
        Me.Panel2.Controls.Add(Me.folderScanButton)
        Me.Panel2.Controls.Add(Me.quarantineButton)
        Me.Panel2.Controls.Add(Me.quickScanButton)
        Me.Panel2.Controls.Add(Me.fullScanButton)
        Me.Panel2.Location = New System.Drawing.Point(2, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(214, 400)
        Me.Panel2.TabIndex = 6
        '
        'realTimeScanButton
        '
        Me.realTimeScanButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.realTimeScanButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.realTimeScanButton.ForeColor = System.Drawing.SystemColors.Control
        Me.realTimeScanButton.Location = New System.Drawing.Point(3, 267)
        Me.realTimeScanButton.Name = "realTimeScanButton"
        Me.realTimeScanButton.Size = New System.Drawing.Size(206, 39)
        Me.realTimeScanButton.TabIndex = 75
        Me.realTimeScanButton.Text = "Real Time Scan"
        Me.realTimeScanButton.UseVisualStyleBackColor = False
        '
        'folderScanButton
        '
        Me.folderScanButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.folderScanButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folderScanButton.ForeColor = System.Drawing.SystemColors.Control
        Me.folderScanButton.Location = New System.Drawing.Point(3, 182)
        Me.folderScanButton.Name = "folderScanButton"
        Me.folderScanButton.Size = New System.Drawing.Size(206, 39)
        Me.folderScanButton.TabIndex = 3
        Me.folderScanButton.Text = "Folder Scan"
        Me.folderScanButton.UseVisualStyleBackColor = False
        '
        'quarantineButton
        '
        Me.quarantineButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.quarantineButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quarantineButton.ForeColor = System.Drawing.SystemColors.Control
        Me.quarantineButton.Location = New System.Drawing.Point(5, 352)
        Me.quarantineButton.Name = "quarantineButton"
        Me.quarantineButton.Size = New System.Drawing.Size(206, 39)
        Me.quarantineButton.TabIndex = 2
        Me.quarantineButton.Text = "Quarantine"
        Me.quarantineButton.UseVisualStyleBackColor = False
        '
        'quickScanButton
        '
        Me.quickScanButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.quickScanButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quickScanButton.ForeColor = System.Drawing.SystemColors.Control
        Me.quickScanButton.Location = New System.Drawing.Point(5, 12)
        Me.quickScanButton.Name = "quickScanButton"
        Me.quickScanButton.Size = New System.Drawing.Size(206, 39)
        Me.quickScanButton.TabIndex = 1
        Me.quickScanButton.Text = "Quick Scan"
        Me.quickScanButton.UseVisualStyleBackColor = False
        '
        'fullScanButton
        '
        Me.fullScanButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.fullScanButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullScanButton.ForeColor = System.Drawing.SystemColors.Control
        Me.fullScanButton.Location = New System.Drawing.Point(3, 97)
        Me.fullScanButton.Name = "fullScanButton"
        Me.fullScanButton.Size = New System.Drawing.Size(206, 39)
        Me.fullScanButton.TabIndex = 0
        Me.fullScanButton.Text = "Full Scan"
        Me.fullScanButton.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InfoText
        Me.Panel3.Controls.Add(Me.quarantineGroupBox)
        Me.Panel3.Controls.Add(Me.scanGroupBox)
        Me.Panel3.Controls.Add(Me.realTimeLabel)
        Me.Panel3.Controls.Add(Me.copyHashButton)
        Me.Panel3.Controls.Add(Me.stopFullScanButton)
        Me.Panel3.Controls.Add(Me.filesPropertiesButton)
        Me.Panel3.Controls.Add(Me.realTimeOffButton)
        Me.Panel3.Controls.Add(Me.realTimeOnButton)
        Me.Panel3.Controls.Add(Me.startFolderScan)
        Me.Panel3.Controls.Add(Me.folderScanLabel)
        Me.Panel3.Controls.Add(Me.stopFolderScan)
        Me.Panel3.Controls.Add(Me.startFullScan)
        Me.Panel3.Controls.Add(Me.stopQuickScan)
        Me.Panel3.Controls.Add(Me.startQuickScan)
        Me.Panel3.Controls.Add(Me.quickScanLabel)
        Me.Panel3.Controls.Add(Me.quarantineLabel)
        Me.Panel3.Controls.Add(Me.fullScanLabel)
        Me.Panel3.Location = New System.Drawing.Point(217, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(583, 400)
        Me.Panel3.TabIndex = 7
        '
        'scanGroupBox
        '
        Me.scanGroupBox.Controls.Add(Me.numFilesPerSecondLabel)
        Me.scanGroupBox.Controls.Add(Me.filePerSecondLabel)
        Me.scanGroupBox.Controls.Add(Me.timeLeftLabel)
        Me.scanGroupBox.Controls.Add(Me.iconPicBox)
        Me.scanGroupBox.Controls.Add(Me.filesIconLabel)
        Me.scanGroupBox.Controls.Add(Me.totalProgressLabel)
        Me.scanGroupBox.Controls.Add(Me.percentLabel)
        Me.scanGroupBox.Controls.Add(Me.scanProgressBar)
        Me.scanGroupBox.Controls.Add(Me.fileCountLabel)
        Me.scanGroupBox.Controls.Add(Me.onFileLabel)
        Me.scanGroupBox.Controls.Add(Me.numberInfectedFilesLabel)
        Me.scanGroupBox.Controls.Add(Me.infectedLabel)
        Me.scanGroupBox.Controls.Add(Me.elapsedTimeLabel)
        Me.scanGroupBox.Controls.Add(Me.elapsedLabel)
        Me.scanGroupBox.Controls.Add(Me.currentFile)
        Me.scanGroupBox.Controls.Add(Me.scanningFileLabel)
        Me.scanGroupBox.Location = New System.Drawing.Point(7, 63)
        Me.scanGroupBox.Name = "scanGroupBox"
        Me.scanGroupBox.Size = New System.Drawing.Size(571, 333)
        Me.scanGroupBox.TabIndex = 73
        Me.scanGroupBox.TabStop = False
        '
        'numFilesPerSecondLabel
        '
        Me.numFilesPerSecondLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numFilesPerSecondLabel.ForeColor = System.Drawing.Color.Snow
        Me.numFilesPerSecondLabel.Location = New System.Drawing.Point(111, 248)
        Me.numFilesPerSecondLabel.Name = "numFilesPerSecondLabel"
        Me.numFilesPerSecondLabel.Size = New System.Drawing.Size(453, 15)
        Me.numFilesPerSecondLabel.TabIndex = 92
        Me.numFilesPerSecondLabel.Text = "0"
        '
        'filePerSecondLabel
        '
        Me.filePerSecondLabel.AutoSize = True
        Me.filePerSecondLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filePerSecondLabel.ForeColor = System.Drawing.Color.Snow
        Me.filePerSecondLabel.Location = New System.Drawing.Point(24, 247)
        Me.filePerSecondLabel.Name = "filePerSecondLabel"
        Me.filePerSecondLabel.Size = New System.Drawing.Size(74, 16)
        Me.filePerSecondLabel.TabIndex = 91
        Me.filePerSecondLabel.Text = "Files Per/Sec:"
        '
        'timeLeftLabel
        '
        Me.timeLeftLabel.AutoSize = True
        Me.timeLeftLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.timeLeftLabel.Location = New System.Drawing.Point(43, 270)
        Me.timeLeftLabel.Name = "timeLeftLabel"
        Me.timeLeftLabel.Size = New System.Drawing.Size(183, 13)
        Me.timeLeftLabel.TabIndex = 78
        Me.timeLeftLabel.Text = "Time Left:       0 Hours And 0 Minutes"
        '
        'iconPicBox
        '
        Me.iconPicBox.Location = New System.Drawing.Point(115, 168)
        Me.iconPicBox.Name = "iconPicBox"
        Me.iconPicBox.Size = New System.Drawing.Size(30, 30)
        Me.iconPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconPicBox.TabIndex = 90
        Me.iconPicBox.TabStop = False
        '
        'filesIconLabel
        '
        Me.filesIconLabel.AutoSize = True
        Me.filesIconLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filesIconLabel.ForeColor = System.Drawing.Color.Snow
        Me.filesIconLabel.Location = New System.Drawing.Point(40, 174)
        Me.filesIconLabel.Name = "filesIconLabel"
        Me.filesIconLabel.Size = New System.Drawing.Size(58, 16)
        Me.filesIconLabel.TabIndex = 89
        Me.filesIconLabel.Text = "File's Icon:"
        '
        'totalProgressLabel
        '
        Me.totalProgressLabel.AutoSize = True
        Me.totalProgressLabel.ForeColor = System.Drawing.Color.White
        Me.totalProgressLabel.Location = New System.Drawing.Point(20, 310)
        Me.totalProgressLabel.Name = "totalProgressLabel"
        Me.totalProgressLabel.Size = New System.Drawing.Size(78, 13)
        Me.totalProgressLabel.TabIndex = 88
        Me.totalProgressLabel.Text = "Total Progress:"
        '
        'percentLabel
        '
        Me.percentLabel.AutoSize = True
        Me.percentLabel.ForeColor = System.Drawing.Color.White
        Me.percentLabel.Location = New System.Drawing.Point(527, 309)
        Me.percentLabel.Name = "percentLabel"
        Me.percentLabel.Size = New System.Drawing.Size(21, 13)
        Me.percentLabel.TabIndex = 87
        Me.percentLabel.Text = "0%"
        '
        'scanProgressBar
        '
        Me.scanProgressBar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.scanProgressBar.Location = New System.Drawing.Point(113, 312)
        Me.scanProgressBar.Name = "scanProgressBar"
        Me.scanProgressBar.Size = New System.Drawing.Size(407, 10)
        Me.scanProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.scanProgressBar.TabIndex = 78
        '
        'fileCountLabel
        '
        Me.fileCountLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileCountLabel.ForeColor = System.Drawing.Color.Snow
        Me.fileCountLabel.Location = New System.Drawing.Point(111, 226)
        Me.fileCountLabel.Name = "fileCountLabel"
        Me.fileCountLabel.Size = New System.Drawing.Size(453, 16)
        Me.fileCountLabel.TabIndex = 86
        Me.fileCountLabel.Text = "0 Out Of 0"
        '
        'onFileLabel
        '
        Me.onFileLabel.AutoSize = True
        Me.onFileLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onFileLabel.ForeColor = System.Drawing.Color.Snow
        Me.onFileLabel.Location = New System.Drawing.Point(6, 225)
        Me.onFileLabel.Name = "onFileLabel"
        Me.onFileLabel.Size = New System.Drawing.Size(92, 16)
        Me.onFileLabel.TabIndex = 85
        Me.onFileLabel.Text = "Currently On File:"
        '
        'numberInfectedFilesLabel
        '
        Me.numberInfectedFilesLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberInfectedFilesLabel.ForeColor = System.Drawing.Color.Snow
        Me.numberInfectedFilesLabel.Location = New System.Drawing.Point(111, 288)
        Me.numberInfectedFilesLabel.Name = "numberInfectedFilesLabel"
        Me.numberInfectedFilesLabel.Size = New System.Drawing.Size(453, 15)
        Me.numberInfectedFilesLabel.TabIndex = 84
        Me.numberInfectedFilesLabel.Text = "0"
        '
        'infectedLabel
        '
        Me.infectedLabel.AutoSize = True
        Me.infectedLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infectedLabel.ForeColor = System.Drawing.Color.Snow
        Me.infectedLabel.Location = New System.Drawing.Point(26, 288)
        Me.infectedLabel.Name = "infectedLabel"
        Me.infectedLabel.Size = New System.Drawing.Size(72, 16)
        Me.infectedLabel.TabIndex = 83
        Me.infectedLabel.Text = "Files Infected:"
        '
        'elapsedTimeLabel
        '
        Me.elapsedTimeLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elapsedTimeLabel.ForeColor = System.Drawing.Color.Snow
        Me.elapsedTimeLabel.Location = New System.Drawing.Point(111, 204)
        Me.elapsedTimeLabel.Name = "elapsedTimeLabel"
        Me.elapsedTimeLabel.Size = New System.Drawing.Size(453, 19)
        Me.elapsedTimeLabel.TabIndex = 82
        Me.elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
        '
        'elapsedLabel
        '
        Me.elapsedLabel.AutoSize = True
        Me.elapsedLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elapsedLabel.ForeColor = System.Drawing.Color.Snow
        Me.elapsedLabel.Location = New System.Drawing.Point(23, 203)
        Me.elapsedLabel.Name = "elapsedLabel"
        Me.elapsedLabel.Size = New System.Drawing.Size(75, 16)
        Me.elapsedLabel.TabIndex = 81
        Me.elapsedLabel.Text = "Elapsed Time:"
        '
        'currentFile
        '
        Me.currentFile.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentFile.ForeColor = System.Drawing.Color.Snow
        Me.currentFile.Location = New System.Drawing.Point(117, 10)
        Me.currentFile.Name = "currentFile"
        Me.currentFile.Size = New System.Drawing.Size(448, 149)
        Me.currentFile.TabIndex = 80
        '
        'scanningFileLabel
        '
        Me.scanningFileLabel.AutoSize = True
        Me.scanningFileLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scanningFileLabel.ForeColor = System.Drawing.Color.Snow
        Me.scanningFileLabel.Location = New System.Drawing.Point(31, 10)
        Me.scanningFileLabel.Name = "scanningFileLabel"
        Me.scanningFileLabel.Size = New System.Drawing.Size(67, 16)
        Me.scanningFileLabel.TabIndex = 79
        Me.scanningFileLabel.Text = "Current File:"
        '
        'realTimeLabel
        '
        Me.realTimeLabel.AutoSize = True
        Me.realTimeLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.realTimeLabel.ForeColor = System.Drawing.Color.Snow
        Me.realTimeLabel.Location = New System.Drawing.Point(223, 15)
        Me.realTimeLabel.Name = "realTimeLabel"
        Me.realTimeLabel.Size = New System.Drawing.Size(136, 27)
        Me.realTimeLabel.TabIndex = 72
        Me.realTimeLabel.Text = "Real-Time"
        '
        'copyHashButton
        '
        Me.copyHashButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.copyHashButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyHashButton.ForeColor = System.Drawing.SystemColors.Control
        Me.copyHashButton.Location = New System.Drawing.Point(5, 10)
        Me.copyHashButton.Name = "copyHashButton"
        Me.copyHashButton.Size = New System.Drawing.Size(206, 39)
        Me.copyHashButton.TabIndex = 68
        Me.copyHashButton.Text = "Copy Hash"
        Me.copyHashButton.UseVisualStyleBackColor = False
        Me.copyHashButton.Visible = False
        '
        'stopFullScanButton
        '
        Me.stopFullScanButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.stopFullScanButton.Enabled = False
        Me.stopFullScanButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopFullScanButton.ForeColor = System.Drawing.SystemColors.Control
        Me.stopFullScanButton.Location = New System.Drawing.Point(370, 10)
        Me.stopFullScanButton.Name = "stopFullScanButton"
        Me.stopFullScanButton.Size = New System.Drawing.Size(206, 39)
        Me.stopFullScanButton.TabIndex = 67
        Me.stopFullScanButton.Text = "Stop Full Scan"
        Me.stopFullScanButton.UseVisualStyleBackColor = False
        Me.stopFullScanButton.Visible = False
        '
        'filesPropertiesButton
        '
        Me.filesPropertiesButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.filesPropertiesButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filesPropertiesButton.ForeColor = System.Drawing.SystemColors.Control
        Me.filesPropertiesButton.Location = New System.Drawing.Point(372, 10)
        Me.filesPropertiesButton.Name = "filesPropertiesButton"
        Me.filesPropertiesButton.Size = New System.Drawing.Size(206, 39)
        Me.filesPropertiesButton.TabIndex = 69
        Me.filesPropertiesButton.Text = "Get File's Properties"
        Me.filesPropertiesButton.UseVisualStyleBackColor = False
        Me.filesPropertiesButton.Visible = False
        '
        'realTimeOffButton
        '
        Me.realTimeOffButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.realTimeOffButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.realTimeOffButton.ForeColor = System.Drawing.SystemColors.Control
        Me.realTimeOffButton.Location = New System.Drawing.Point(372, 11)
        Me.realTimeOffButton.Name = "realTimeOffButton"
        Me.realTimeOffButton.Size = New System.Drawing.Size(206, 38)
        Me.realTimeOffButton.TabIndex = 71
        Me.realTimeOffButton.Text = "Real-Time Scan Off"
        Me.realTimeOffButton.UseVisualStyleBackColor = False
        '
        'realTimeOnButton
        '
        Me.realTimeOnButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.realTimeOnButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.realTimeOnButton.ForeColor = System.Drawing.SystemColors.Control
        Me.realTimeOnButton.Location = New System.Drawing.Point(5, 10)
        Me.realTimeOnButton.Name = "realTimeOnButton"
        Me.realTimeOnButton.Size = New System.Drawing.Size(206, 39)
        Me.realTimeOnButton.TabIndex = 70
        Me.realTimeOnButton.Text = "Real-Time Scan On"
        Me.realTimeOnButton.UseVisualStyleBackColor = False
        '
        'startFolderScan
        '
        Me.startFolderScan.BackColor = System.Drawing.SystemColors.Highlight
        Me.startFolderScan.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startFolderScan.ForeColor = System.Drawing.SystemColors.Control
        Me.startFolderScan.Location = New System.Drawing.Point(7, 11)
        Me.startFolderScan.Name = "startFolderScan"
        Me.startFolderScan.Size = New System.Drawing.Size(206, 39)
        Me.startFolderScan.TabIndex = 62
        Me.startFolderScan.Text = "Start Folder Scan"
        Me.startFolderScan.UseVisualStyleBackColor = False
        Me.startFolderScan.Visible = False
        '
        'folderScanLabel
        '
        Me.folderScanLabel.AutoSize = True
        Me.folderScanLabel.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folderScanLabel.ForeColor = System.Drawing.Color.Snow
        Me.folderScanLabel.Location = New System.Drawing.Point(216, 15)
        Me.folderScanLabel.Name = "folderScanLabel"
        Me.folderScanLabel.Size = New System.Drawing.Size(151, 25)
        Me.folderScanLabel.TabIndex = 61
        Me.folderScanLabel.Text = "Folder Scan"
        '
        'stopFolderScan
        '
        Me.stopFolderScan.BackColor = System.Drawing.SystemColors.Highlight
        Me.stopFolderScan.Enabled = False
        Me.stopFolderScan.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopFolderScan.ForeColor = System.Drawing.SystemColors.Control
        Me.stopFolderScan.Location = New System.Drawing.Point(372, 10)
        Me.stopFolderScan.Name = "stopFolderScan"
        Me.stopFolderScan.Size = New System.Drawing.Size(206, 39)
        Me.stopFolderScan.TabIndex = 60
        Me.stopFolderScan.Text = "Stop Folder Scan"
        Me.stopFolderScan.UseVisualStyleBackColor = False
        Me.stopFolderScan.Visible = False
        '
        'startFullScan
        '
        Me.startFullScan.BackColor = System.Drawing.SystemColors.Highlight
        Me.startFullScan.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startFullScan.ForeColor = System.Drawing.SystemColors.Control
        Me.startFullScan.Location = New System.Drawing.Point(7, 12)
        Me.startFullScan.Name = "startFullScan"
        Me.startFullScan.Size = New System.Drawing.Size(206, 39)
        Me.startFullScan.TabIndex = 59
        Me.startFullScan.Text = "Start Full Scan"
        Me.startFullScan.UseVisualStyleBackColor = False
        Me.startFullScan.Visible = False
        '
        'stopQuickScan
        '
        Me.stopQuickScan.BackColor = System.Drawing.SystemColors.Highlight
        Me.stopQuickScan.Enabled = False
        Me.stopQuickScan.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopQuickScan.ForeColor = System.Drawing.SystemColors.Control
        Me.stopQuickScan.Location = New System.Drawing.Point(372, 11)
        Me.stopQuickScan.Name = "stopQuickScan"
        Me.stopQuickScan.Size = New System.Drawing.Size(206, 39)
        Me.stopQuickScan.TabIndex = 58
        Me.stopQuickScan.Text = "Stop Quick Scan"
        Me.stopQuickScan.UseVisualStyleBackColor = False
        '
        'startQuickScan
        '
        Me.startQuickScan.BackColor = System.Drawing.SystemColors.Highlight
        Me.startQuickScan.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startQuickScan.ForeColor = System.Drawing.SystemColors.Control
        Me.startQuickScan.Location = New System.Drawing.Point(7, 11)
        Me.startQuickScan.Name = "startQuickScan"
        Me.startQuickScan.Size = New System.Drawing.Size(206, 39)
        Me.startQuickScan.TabIndex = 57
        Me.startQuickScan.Text = "Start Quick Scan"
        Me.startQuickScan.UseVisualStyleBackColor = False
        '
        'quickScanLabel
        '
        Me.quickScanLabel.AutoSize = True
        Me.quickScanLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quickScanLabel.ForeColor = System.Drawing.Color.Snow
        Me.quickScanLabel.Location = New System.Drawing.Point(214, 13)
        Me.quickScanLabel.Name = "quickScanLabel"
        Me.quickScanLabel.Size = New System.Drawing.Size(154, 27)
        Me.quickScanLabel.TabIndex = 56
        Me.quickScanLabel.Text = "Quick Scan"
        '
        'quarantineLabel
        '
        Me.quarantineLabel.AutoSize = True
        Me.quarantineLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quarantineLabel.ForeColor = System.Drawing.Color.Snow
        Me.quarantineLabel.Location = New System.Drawing.Point(214, 15)
        Me.quarantineLabel.Name = "quarantineLabel"
        Me.quarantineLabel.Size = New System.Drawing.Size(155, 27)
        Me.quarantineLabel.TabIndex = 50
        Me.quarantineLabel.Text = "Quarantine"
        Me.quarantineLabel.Visible = False
        '
        'fullScanLabel
        '
        Me.fullScanLabel.AutoSize = True
        Me.fullScanLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullScanLabel.ForeColor = System.Drawing.Color.Snow
        Me.fullScanLabel.Location = New System.Drawing.Point(225, 15)
        Me.fullScanLabel.Name = "fullScanLabel"
        Me.fullScanLabel.Size = New System.Drawing.Size(132, 27)
        Me.fullScanLabel.TabIndex = 44
        Me.fullScanLabel.Text = "Full Scan"
        '
        'folderScanBGW
        '
        Me.folderScanBGW.WorkerSupportsCancellation = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FolderScanToolStripMenuItem, Me.FullScanToolStripMenuItem, Me.QuickScanToolStripMenuItem, Me.ToolStripMenuItem3, Me.ToolStripMenuItem1, Me.QuarantineToolStripMenuItem, Me.ToolStripMenuItem2, Me.SettingsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(156, 148)
        '
        'FolderScanToolStripMenuItem
        '
        Me.FolderScanToolStripMenuItem.Name = "FolderScanToolStripMenuItem"
        Me.FolderScanToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.FolderScanToolStripMenuItem.Text = "Folder Scan"
        '
        'FullScanToolStripMenuItem
        '
        Me.FullScanToolStripMenuItem.Name = "FullScanToolStripMenuItem"
        Me.FullScanToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.FullScanToolStripMenuItem.Text = "Full Scan"
        '
        'QuickScanToolStripMenuItem
        '
        Me.QuickScanToolStripMenuItem.Name = "QuickScanToolStripMenuItem"
        Me.QuickScanToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.QuickScanToolStripMenuItem.Text = "Quick Scan"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(155, 22)
        Me.ToolStripMenuItem3.Text = "Real-Time Scan"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 6)
        '
        'QuarantineToolStripMenuItem
        '
        Me.QuarantineToolStripMenuItem.Name = "QuarantineToolStripMenuItem"
        Me.QuarantineToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.QuarantineToolStripMenuItem.Text = "Quarantine"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'quickScanBGW
        '
        Me.quickScanBGW.WorkerSupportsCancellation = True
        '
        'fullScanBGW
        '
        Me.fullScanBGW.WorkerSupportsCancellation = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(518, 589)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 70
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(12, 500)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(475, 95)
        Me.ListBox2.TabIndex = 71
        '
        'scanRunningProcessesQuick
        '
        '
        'menuPicBox
        '
        Me.menuPicBox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.menuPicBox.Image = Global.MikesAntiVirusScanner.My.Resources.Resources.menuIcon
        Me.menuPicBox.Location = New System.Drawing.Point(644, 2)
        Me.menuPicBox.Name = "menuPicBox"
        Me.menuPicBox.Size = New System.Drawing.Size(47, 50)
        Me.menuPicBox.TabIndex = 3
        Me.menuPicBox.TabStop = False
        '
        'minimizePicBox
        '
        Me.minimizePicBox.BackColor = System.Drawing.SystemColors.Highlight
        Me.minimizePicBox.Image = Global.MikesAntiVirusScanner.My.Resources.Resources.minimizeIcon
        Me.minimizePicBox.Location = New System.Drawing.Point(693, 2)
        Me.minimizePicBox.Name = "minimizePicBox"
        Me.minimizePicBox.Size = New System.Drawing.Size(52, 50)
        Me.minimizePicBox.TabIndex = 2
        Me.minimizePicBox.TabStop = False
        '
        'exitPicBox
        '
        Me.exitPicBox.BackColor = System.Drawing.SystemColors.Highlight
        Me.exitPicBox.Image = Global.MikesAntiVirusScanner.My.Resources.Resources.closeIcon
        Me.exitPicBox.Location = New System.Drawing.Point(748, 2)
        Me.exitPicBox.Name = "exitPicBox"
        Me.exitPicBox.Size = New System.Drawing.Size(52, 50)
        Me.exitPicBox.TabIndex = 0
        Me.exitPicBox.TabStop = False
        '
        'USBDriveScanTimer
        '
        Me.USBDriveScanTimer.Enabled = True
        Me.USBDriveScanTimer.Interval = 1000
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.IncludeSubdirectories = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Double Click To Open Mythodikal Anti-Virus"
        Me.NotifyIcon1.BalloonTipTitle = "Mythodikal Anti-Virus"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Double Click To Open Mythodikal Anti-Virus"
        Me.NotifyIcon1.Visible = True
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(493, 500)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(264, 95)
        Me.ListBox3.TabIndex = 72
        '
        'getSignatures
        '
        '
        'scheduledScanTimer
        '
        Me.scheduledScanTimer.Enabled = True
        Me.scheduledScanTimer.Interval = 1000
        '
        'scanRunningProcessesFull
        '
        '
        'statusLabel
        '
        Me.statusLabel.BackColor = System.Drawing.SystemColors.ControlText
        Me.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.statusLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.ForeColor = System.Drawing.Color.Snow
        Me.statusLabel.Location = New System.Drawing.Point(3, 452)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(797, 22)
        Me.statusLabel.TabIndex = 77
        Me.statusLabel.Text = "Status Bar"
        '
        'notifyQuarantineFile
        '
        Me.notifyQuarantineFile.Text = "NotifyIcon2"
        Me.notifyQuarantineFile.Visible = True
        '
        'etaTimer
        '
        Me.etaTimer.Interval = 250
        '
        'realTimeScanBGW
        '
        Me.realTimeScanBGW.WorkerSupportsCancellation = True
        '
        'loadMythodikal
        '
        '
        'scanFilesBGW
        '
        Me.scanFilesBGW.WorkerSupportsCancellation = True
        '
        'filesPerSecTimer
        '
        Me.filesPerSecTimer.Interval = 1000
        '
        'BackgroundWorker1
        '
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(806, 480)
        Me.Controls.Add(Me.statusLabel)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.menuPicBox)
        Me.Controls.Add(Me.minimizePicBox)
        Me.Controls.Add(Me.exitPicBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mythodikal Anti-Virus"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.quarantineGroupBox.ResumeLayout(False)
        CType(Me.quarantineGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.scanGroupBox.ResumeLayout(False)
        Me.scanGroupBox.PerformLayout()
        CType(Me.iconPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.menuPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents exitPicBox As PictureBox
    Friend WithEvents minimizePicBox As PictureBox
    Friend WithEvents menuPicBox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents quarantineButton As Button
    Friend WithEvents quickScanButton As Button
    Friend WithEvents fullScanButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents fullScanLabel As Label
    Friend WithEvents quarantineLabel As Label
    Friend WithEvents quickScanLabel As Label
    Friend WithEvents stopFolderScan As Button
    Friend WithEvents startFullScan As Button
    Friend WithEvents stopQuickScan As Button
    Friend WithEvents startQuickScan As Button
    Friend WithEvents folderScanButton As Button
    Friend WithEvents startFolderScan As Button
    Friend WithEvents folderScanLabel As Label
    Friend WithEvents folderScanBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FolderScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuickScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents QuarantineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents stopFullScanButton As Button
    Friend WithEvents quickScanBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents fullScanBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents copyHashButton As Button
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents scanRunningProcessesQuick As System.ComponentModel.BackgroundWorker
    Friend WithEvents USBDriveScanTimer As Timer
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents realTimeLabel As Label
    Friend WithEvents realTimeOffButton As Button
    Friend WithEvents realTimeOnButton As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents getSignatures As System.ComponentModel.BackgroundWorker
    Friend WithEvents scheduledScanTimer As Timer
    Friend WithEvents scanRunningProcessesFull As System.ComponentModel.BackgroundWorker
    Friend WithEvents statusLabel As Label
    Friend WithEvents scanGroupBox As GroupBox
    Friend WithEvents iconPicBox As PictureBox
    Friend WithEvents filesIconLabel As Label
    Friend WithEvents totalProgressLabel As Label
    Friend WithEvents percentLabel As Label
    Friend WithEvents scanProgressBar As ProgressBar
    Friend WithEvents fileCountLabel As Label
    Friend WithEvents onFileLabel As Label
    Friend WithEvents numberInfectedFilesLabel As Label
    Friend WithEvents elapsedTimeLabel As Label
    Friend WithEvents elapsedLabel As Label
    Friend WithEvents currentFile As Label
    Friend WithEvents scanningFileLabel As Label
    Friend WithEvents filesPropertiesButton As Button
    Friend WithEvents notifyQuarantineFile As NotifyIcon
    Friend WithEvents timeLeftLabel As Label
    Friend WithEvents etaTimer As Timer
    Friend WithEvents realTimeScanBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents realTimeScanButton As Button
    Friend WithEvents loadMythodikal As System.ComponentModel.BackgroundWorker
    Friend WithEvents quarantineGroupBox As GroupBox
    Friend WithEvents quarantineGridView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents restoreFileButton As Button
    Friend WithEvents restoreAllButton As Button
    Friend WithEvents deletefileButton As Button
    Friend WithEvents deleteAllButton As Button
    Friend WithEvents scanFilesBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents numFilesPerSecondLabel As Label
    Friend WithEvents filePerSecondLabel As Label
    Friend WithEvents infectedLabel As Label
    Friend WithEvents filesPerSecTimer As Timer
    Friend WithEvents titleLabel As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
