﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.folderScanButton = New System.Windows.Forms.Button()
        Me.quarantineButton = New System.Windows.Forms.Button()
        Me.virusScanButton = New System.Windows.Forms.Button()
        Me.fullScanButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.iconPicBox = New System.Windows.Forms.PictureBox()
        Me.filesIconLabel = New System.Windows.Forms.Label()
        Me.totalProgressLabel = New System.Windows.Forms.Label()
        Me.percentLabel = New System.Windows.Forms.Label()
        Me.scanProgressBar = New System.Windows.Forms.ProgressBar()
        Me.realTimeLabel = New System.Windows.Forms.Label()
        Me.realTimeOffButton = New System.Windows.Forms.Button()
        Me.realTimeOnButton = New System.Windows.Forms.Button()
        Me.filesPropertiesButton = New System.Windows.Forms.Button()
        Me.copyHashButton = New System.Windows.Forms.Button()
        Me.stopFullScanButton = New System.Windows.Forms.Button()
        Me.quarantineGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.startFolderScan = New System.Windows.Forms.Button()
        Me.folderScanLabel = New System.Windows.Forms.Label()
        Me.stopFolderScan = New System.Windows.Forms.Button()
        Me.startFullScan = New System.Windows.Forms.Button()
        Me.stopQuickScan = New System.Windows.Forms.Button()
        Me.startQuickScan = New System.Windows.Forms.Button()
        Me.quickScanLabel = New System.Windows.Forms.Label()
        Me.deleteAllButton = New System.Windows.Forms.Button()
        Me.deletefileButton = New System.Windows.Forms.Button()
        Me.restoreAllButton = New System.Windows.Forms.Button()
        Me.restoreFileButton = New System.Windows.Forms.Button()
        Me.quarantineLabel = New System.Windows.Forms.Label()
        Me.fullScanLabel = New System.Windows.Forms.Label()
        Me.fileCountLabel = New System.Windows.Forms.Label()
        Me.onFileLabel = New System.Windows.Forms.Label()
        Me.numberInfectedFilesLabel = New System.Windows.Forms.Label()
        Me.infectedLabel = New System.Windows.Forms.Label()
        Me.elapsedTimeLabel = New System.Windows.Forms.Label()
        Me.elapsedLabel = New System.Windows.Forms.Label()
        Me.currentFile = New System.Windows.Forms.Label()
        Me.scanningFileLabel = New System.Windows.Forms.Label()
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
        Me.scanTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.getSignatures = New System.ComponentModel.BackgroundWorker()
        Me.scheduledScan = New System.Windows.Forms.Timer(Me.components)
        Me.loadMythodikalTimer = New System.Windows.Forms.Timer(Me.components)
        Me.scanRunningProcessesFull = New System.ComponentModel.BackgroundWorker()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.iconPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quarantineGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.titleLabel.Location = New System.Drawing.Point(167, 12)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(302, 27)
        Me.titleLabel.TabIndex = 5
        Me.titleLabel.Text = "Mythodikal Anti-Virus"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel2.Controls.Add(Me.folderScanButton)
        Me.Panel2.Controls.Add(Me.quarantineButton)
        Me.Panel2.Controls.Add(Me.virusScanButton)
        Me.Panel2.Controls.Add(Me.fullScanButton)
        Me.Panel2.Location = New System.Drawing.Point(2, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(214, 400)
        Me.Panel2.TabIndex = 6
        '
        'folderScanButton
        '
        Me.folderScanButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.folderScanButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folderScanButton.ForeColor = System.Drawing.SystemColors.Control
        Me.folderScanButton.Location = New System.Drawing.Point(3, 236)
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
        Me.quarantineButton.Location = New System.Drawing.Point(3, 347)
        Me.quarantineButton.Name = "quarantineButton"
        Me.quarantineButton.Size = New System.Drawing.Size(206, 39)
        Me.quarantineButton.TabIndex = 2
        Me.quarantineButton.Text = "Quarantine"
        Me.quarantineButton.UseVisualStyleBackColor = False
        '
        'virusScanButton
        '
        Me.virusScanButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.virusScanButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.virusScanButton.ForeColor = System.Drawing.SystemColors.Control
        Me.virusScanButton.Location = New System.Drawing.Point(5, 12)
        Me.virusScanButton.Name = "virusScanButton"
        Me.virusScanButton.Size = New System.Drawing.Size(206, 39)
        Me.virusScanButton.TabIndex = 1
        Me.virusScanButton.Text = "Quick Scan"
        Me.virusScanButton.UseVisualStyleBackColor = False
        '
        'fullScanButton
        '
        Me.fullScanButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.fullScanButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullScanButton.ForeColor = System.Drawing.SystemColors.Control
        Me.fullScanButton.Location = New System.Drawing.Point(3, 124)
        Me.fullScanButton.Name = "fullScanButton"
        Me.fullScanButton.Size = New System.Drawing.Size(206, 39)
        Me.fullScanButton.TabIndex = 0
        Me.fullScanButton.Text = "Full Scan"
        Me.fullScanButton.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InfoText
        Me.Panel3.Controls.Add(Me.iconPicBox)
        Me.Panel3.Controls.Add(Me.filesIconLabel)
        Me.Panel3.Controls.Add(Me.totalProgressLabel)
        Me.Panel3.Controls.Add(Me.percentLabel)
        Me.Panel3.Controls.Add(Me.scanProgressBar)
        Me.Panel3.Controls.Add(Me.realTimeLabel)
        Me.Panel3.Controls.Add(Me.realTimeOffButton)
        Me.Panel3.Controls.Add(Me.realTimeOnButton)
        Me.Panel3.Controls.Add(Me.filesPropertiesButton)
        Me.Panel3.Controls.Add(Me.copyHashButton)
        Me.Panel3.Controls.Add(Me.stopFullScanButton)
        Me.Panel3.Controls.Add(Me.quarantineGridView)
        Me.Panel3.Controls.Add(Me.startFolderScan)
        Me.Panel3.Controls.Add(Me.folderScanLabel)
        Me.Panel3.Controls.Add(Me.stopFolderScan)
        Me.Panel3.Controls.Add(Me.startFullScan)
        Me.Panel3.Controls.Add(Me.stopQuickScan)
        Me.Panel3.Controls.Add(Me.startQuickScan)
        Me.Panel3.Controls.Add(Me.quickScanLabel)
        Me.Panel3.Controls.Add(Me.deleteAllButton)
        Me.Panel3.Controls.Add(Me.deletefileButton)
        Me.Panel3.Controls.Add(Me.restoreAllButton)
        Me.Panel3.Controls.Add(Me.restoreFileButton)
        Me.Panel3.Controls.Add(Me.quarantineLabel)
        Me.Panel3.Controls.Add(Me.fullScanLabel)
        Me.Panel3.Controls.Add(Me.fileCountLabel)
        Me.Panel3.Controls.Add(Me.onFileLabel)
        Me.Panel3.Controls.Add(Me.numberInfectedFilesLabel)
        Me.Panel3.Controls.Add(Me.infectedLabel)
        Me.Panel3.Controls.Add(Me.elapsedTimeLabel)
        Me.Panel3.Controls.Add(Me.elapsedLabel)
        Me.Panel3.Controls.Add(Me.currentFile)
        Me.Panel3.Controls.Add(Me.scanningFileLabel)
        Me.Panel3.Location = New System.Drawing.Point(217, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(583, 400)
        Me.Panel3.TabIndex = 7
        '
        'iconPicBox
        '
        Me.iconPicBox.Location = New System.Drawing.Point(119, 212)
        Me.iconPicBox.Name = "iconPicBox"
        Me.iconPicBox.Size = New System.Drawing.Size(50, 39)
        Me.iconPicBox.TabIndex = 77
        Me.iconPicBox.TabStop = False
        '
        'filesIconLabel
        '
        Me.filesIconLabel.AutoSize = True
        Me.filesIconLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filesIconLabel.ForeColor = System.Drawing.Color.Snow
        Me.filesIconLabel.Location = New System.Drawing.Point(46, 223)
        Me.filesIconLabel.Name = "filesIconLabel"
        Me.filesIconLabel.Size = New System.Drawing.Size(58, 16)
        Me.filesIconLabel.TabIndex = 76
        Me.filesIconLabel.Text = "File's Icon:"
        '
        'totalProgressLabel
        '
        Me.totalProgressLabel.AutoSize = True
        Me.totalProgressLabel.ForeColor = System.Drawing.Color.White
        Me.totalProgressLabel.Location = New System.Drawing.Point(26, 371)
        Me.totalProgressLabel.Name = "totalProgressLabel"
        Me.totalProgressLabel.Size = New System.Drawing.Size(78, 13)
        Me.totalProgressLabel.TabIndex = 75
        Me.totalProgressLabel.Text = "Total Progress:"
        '
        'percentLabel
        '
        Me.percentLabel.AutoSize = True
        Me.percentLabel.ForeColor = System.Drawing.Color.White
        Me.percentLabel.Location = New System.Drawing.Point(543, 371)
        Me.percentLabel.Name = "percentLabel"
        Me.percentLabel.Size = New System.Drawing.Size(21, 13)
        Me.percentLabel.TabIndex = 74
        Me.percentLabel.Text = "0%"
        '
        'scanProgressBar
        '
        Me.scanProgressBar.Location = New System.Drawing.Point(119, 373)
        Me.scanProgressBar.Name = "scanProgressBar"
        Me.scanProgressBar.Size = New System.Drawing.Size(418, 10)
        Me.scanProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.scanProgressBar.TabIndex = 6
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
        'realTimeOffButton
        '
        Me.realTimeOffButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.realTimeOffButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.realTimeOffButton.ForeColor = System.Drawing.SystemColors.Control
        Me.realTimeOffButton.Location = New System.Drawing.Point(372, 12)
        Me.realTimeOffButton.Name = "realTimeOffButton"
        Me.realTimeOffButton.Size = New System.Drawing.Size(206, 39)
        Me.realTimeOffButton.TabIndex = 71
        Me.realTimeOffButton.Text = "Real-Time Scan Off"
        Me.realTimeOffButton.UseVisualStyleBackColor = False
        '
        'realTimeOnButton
        '
        Me.realTimeOnButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.realTimeOnButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.realTimeOnButton.ForeColor = System.Drawing.SystemColors.Control
        Me.realTimeOnButton.Location = New System.Drawing.Point(7, 10)
        Me.realTimeOnButton.Name = "realTimeOnButton"
        Me.realTimeOnButton.Size = New System.Drawing.Size(206, 39)
        Me.realTimeOnButton.TabIndex = 70
        Me.realTimeOnButton.Text = "Real-Time Scan On"
        Me.realTimeOnButton.UseVisualStyleBackColor = False
        '
        'filesPropertiesButton
        '
        Me.filesPropertiesButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.filesPropertiesButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filesPropertiesButton.ForeColor = System.Drawing.SystemColors.Control
        Me.filesPropertiesButton.Location = New System.Drawing.Point(372, 11)
        Me.filesPropertiesButton.Name = "filesPropertiesButton"
        Me.filesPropertiesButton.Size = New System.Drawing.Size(206, 39)
        Me.filesPropertiesButton.TabIndex = 69
        Me.filesPropertiesButton.Text = "Get File's Properties"
        Me.filesPropertiesButton.UseVisualStyleBackColor = False
        Me.filesPropertiesButton.Visible = False
        '
        'copyHashButton
        '
        Me.copyHashButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.copyHashButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyHashButton.ForeColor = System.Drawing.SystemColors.Control
        Me.copyHashButton.Location = New System.Drawing.Point(7, 10)
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
        Me.stopFullScanButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopFullScanButton.ForeColor = System.Drawing.SystemColors.Control
        Me.stopFullScanButton.Location = New System.Drawing.Point(372, 12)
        Me.stopFullScanButton.Name = "stopFullScanButton"
        Me.stopFullScanButton.Size = New System.Drawing.Size(206, 39)
        Me.stopFullScanButton.TabIndex = 67
        Me.stopFullScanButton.Text = "Stop Full Scan"
        Me.stopFullScanButton.UseVisualStyleBackColor = False
        Me.stopFullScanButton.Visible = False
        '
        'quarantineGridView
        '
        Me.quarantineGridView.AllowUserToAddRows = False
        Me.quarantineGridView.AllowUserToDeleteRows = False
        Me.quarantineGridView.AllowUserToResizeRows = False
        Me.quarantineGridView.BackgroundColor = System.Drawing.SystemColors.Desktop
        Me.quarantineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.quarantineGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.quarantineGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.quarantineGridView.GridColor = System.Drawing.Color.White
        Me.quarantineGridView.Location = New System.Drawing.Point(7, 55)
        Me.quarantineGridView.MultiSelect = False
        Me.quarantineGridView.Name = "quarantineGridView"
        Me.quarantineGridView.ReadOnly = True
        Me.quarantineGridView.RowHeadersVisible = False
        Me.quarantineGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.quarantineGridView.Size = New System.Drawing.Size(569, 306)
        Me.quarantineGridView.TabIndex = 51
        Me.quarantineGridView.Visible = False
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
        Me.folderScanLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folderScanLabel.ForeColor = System.Drawing.Color.Snow
        Me.folderScanLabel.Location = New System.Drawing.Point(210, 14)
        Me.folderScanLabel.Name = "folderScanLabel"
        Me.folderScanLabel.Size = New System.Drawing.Size(163, 27)
        Me.folderScanLabel.TabIndex = 61
        Me.folderScanLabel.Text = "Folder Scan"
        '
        'stopFolderScan
        '
        Me.stopFolderScan.BackColor = System.Drawing.SystemColors.Highlight
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
        'deleteAllButton
        '
        Me.deleteAllButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.deleteAllButton.Font = New System.Drawing.Font("Snap ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteAllButton.ForeColor = System.Drawing.Color.White
        Me.deleteAllButton.Location = New System.Drawing.Point(462, 363)
        Me.deleteAllButton.Name = "deleteAllButton"
        Me.deleteAllButton.Size = New System.Drawing.Size(115, 23)
        Me.deleteAllButton.TabIndex = 55
        Me.deleteAllButton.Text = "Delete All Files"
        Me.deleteAllButton.UseVisualStyleBackColor = False
        Me.deleteAllButton.Visible = False
        '
        'deletefileButton
        '
        Me.deletefileButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.deletefileButton.Font = New System.Drawing.Font("Snap ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletefileButton.ForeColor = System.Drawing.Color.White
        Me.deletefileButton.Location = New System.Drawing.Point(311, 363)
        Me.deletefileButton.Name = "deletefileButton"
        Me.deletefileButton.Size = New System.Drawing.Size(115, 23)
        Me.deletefileButton.TabIndex = 54
        Me.deletefileButton.Text = "Delete File"
        Me.deletefileButton.UseVisualStyleBackColor = False
        Me.deletefileButton.Visible = False
        '
        'restoreAllButton
        '
        Me.restoreAllButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.restoreAllButton.Font = New System.Drawing.Font("Snap ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restoreAllButton.ForeColor = System.Drawing.Color.White
        Me.restoreAllButton.Location = New System.Drawing.Point(155, 363)
        Me.restoreAllButton.Name = "restoreAllButton"
        Me.restoreAllButton.Size = New System.Drawing.Size(115, 23)
        Me.restoreAllButton.TabIndex = 53
        Me.restoreAllButton.Text = "Restore All"
        Me.restoreAllButton.UseVisualStyleBackColor = False
        Me.restoreAllButton.Visible = False
        '
        'restoreFileButton
        '
        Me.restoreFileButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.restoreFileButton.Font = New System.Drawing.Font("Snap ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restoreFileButton.ForeColor = System.Drawing.Color.White
        Me.restoreFileButton.Location = New System.Drawing.Point(3, 363)
        Me.restoreFileButton.Name = "restoreFileButton"
        Me.restoreFileButton.Size = New System.Drawing.Size(115, 23)
        Me.restoreFileButton.TabIndex = 52
        Me.restoreFileButton.Text = "Restore File"
        Me.restoreFileButton.UseVisualStyleBackColor = False
        Me.restoreFileButton.Visible = False
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
        'fileCountLabel
        '
        Me.fileCountLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileCountLabel.ForeColor = System.Drawing.Color.Snow
        Me.fileCountLabel.Location = New System.Drawing.Point(118, 297)
        Me.fileCountLabel.Name = "fileCountLabel"
        Me.fileCountLabel.Size = New System.Drawing.Size(460, 16)
        Me.fileCountLabel.TabIndex = 39
        Me.fileCountLabel.Text = "0 Out Of 0"
        '
        'onFileLabel
        '
        Me.onFileLabel.AutoSize = True
        Me.onFileLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onFileLabel.ForeColor = System.Drawing.Color.Snow
        Me.onFileLabel.Location = New System.Drawing.Point(12, 297)
        Me.onFileLabel.Name = "onFileLabel"
        Me.onFileLabel.Size = New System.Drawing.Size(92, 16)
        Me.onFileLabel.TabIndex = 38
        Me.onFileLabel.Text = "Currently On File:"
        '
        'numberInfectedFilesLabel
        '
        Me.numberInfectedFilesLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberInfectedFilesLabel.ForeColor = System.Drawing.Color.Snow
        Me.numberInfectedFilesLabel.Location = New System.Drawing.Point(118, 334)
        Me.numberInfectedFilesLabel.Name = "numberInfectedFilesLabel"
        Me.numberInfectedFilesLabel.Size = New System.Drawing.Size(460, 15)
        Me.numberInfectedFilesLabel.TabIndex = 37
        Me.numberInfectedFilesLabel.Text = "0"
        '
        'infectedLabel
        '
        Me.infectedLabel.AutoSize = True
        Me.infectedLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infectedLabel.ForeColor = System.Drawing.Color.Snow
        Me.infectedLabel.Location = New System.Drawing.Point(9, 334)
        Me.infectedLabel.Name = "infectedLabel"
        Me.infectedLabel.Size = New System.Drawing.Size(95, 16)
        Me.infectedLabel.TabIndex = 36
        Me.infectedLabel.Text = "# Of Files Infected:"
        '
        'elapsedTimeLabel
        '
        Me.elapsedTimeLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elapsedTimeLabel.ForeColor = System.Drawing.Color.Snow
        Me.elapsedTimeLabel.Location = New System.Drawing.Point(118, 261)
        Me.elapsedTimeLabel.Name = "elapsedTimeLabel"
        Me.elapsedTimeLabel.Size = New System.Drawing.Size(460, 19)
        Me.elapsedTimeLabel.TabIndex = 35
        Me.elapsedTimeLabel.Text = "0 Hours - 0 Minutes - 0 Seconds"
        '
        'elapsedLabel
        '
        Me.elapsedLabel.AutoSize = True
        Me.elapsedLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elapsedLabel.ForeColor = System.Drawing.Color.Snow
        Me.elapsedLabel.Location = New System.Drawing.Point(29, 260)
        Me.elapsedLabel.Name = "elapsedLabel"
        Me.elapsedLabel.Size = New System.Drawing.Size(75, 16)
        Me.elapsedLabel.TabIndex = 34
        Me.elapsedLabel.Text = "Elapsed Time:"
        '
        'currentFile
        '
        Me.currentFile.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentFile.ForeColor = System.Drawing.Color.Snow
        Me.currentFile.Location = New System.Drawing.Point(117, 56)
        Me.currentFile.Name = "currentFile"
        Me.currentFile.Size = New System.Drawing.Size(461, 148)
        Me.currentFile.TabIndex = 33
        '
        'scanningFileLabel
        '
        Me.scanningFileLabel.AutoSize = True
        Me.scanningFileLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scanningFileLabel.ForeColor = System.Drawing.Color.Snow
        Me.scanningFileLabel.Location = New System.Drawing.Point(4, 56)
        Me.scanningFileLabel.Name = "scanningFileLabel"
        Me.scanningFileLabel.Size = New System.Drawing.Size(103, 16)
        Me.scanningFileLabel.TabIndex = 32
        Me.scanningFileLabel.Text = "File Being Scanned:"
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
        Me.ListBox1.Location = New System.Drawing.Point(497, 487)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 70
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(12, 476)
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
        'scanTimer
        '
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(634, 476)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(132, 95)
        Me.ListBox3.TabIndex = 72
        '
        'getSignatures
        '
        '
        'scheduledScan
        '
        Me.scheduledScan.Enabled = True
        Me.scheduledScan.Interval = 1000
        '
        'loadMythodikalTimer
        '
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
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(805, 477)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.iconPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quarantineGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents titleLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents quarantineButton As Button
    Friend WithEvents virusScanButton As Button
    Friend WithEvents fullScanButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents fullScanLabel As Label
    Friend WithEvents fileCountLabel As Label
    Friend WithEvents onFileLabel As Label
    Friend WithEvents numberInfectedFilesLabel As Label
    Friend WithEvents infectedLabel As Label
    Friend WithEvents elapsedTimeLabel As Label
    Friend WithEvents elapsedLabel As Label
    Friend WithEvents currentFile As Label
    Friend WithEvents scanningFileLabel As Label
    Friend WithEvents deleteAllButton As Button
    Friend WithEvents deletefileButton As Button
    Friend WithEvents restoreAllButton As Button
    Friend WithEvents restoreFileButton As Button
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
    Friend WithEvents filesPropertiesButton As Button
    Friend WithEvents copyHashButton As Button
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents quarantineGridView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
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
    Friend WithEvents scanProgressBar As ProgressBar
    Friend WithEvents filesIconLabel As Label
    Friend WithEvents totalProgressLabel As Label
    Friend WithEvents percentLabel As Label
    Friend WithEvents iconPicBox As PictureBox
    Friend WithEvents scanTimer As Timer
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents getSignatures As System.ComponentModel.BackgroundWorker
    Friend WithEvents scheduledScan As Timer
    Friend WithEvents loadMythodikalTimer As Timer
    Friend WithEvents scanRunningProcessesFull As System.ComponentModel.BackgroundWorker
    Friend WithEvents statusLabel As Label
End Class