<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settingsForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.exitPicBox = New System.Windows.Forms.PictureBox()
        Me.minimizePicBox = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.securityButton = New System.Windows.Forms.Button()
        Me.generalSettingsButton = New System.Windows.Forms.Button()
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.allowListButton = New System.Windows.Forms.Button()
        Me.scheduleScanButton = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.creditTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.aboutProgramGroupBox = New System.Windows.Forms.GroupBox()
        Me.aboutProgramLabel = New System.Windows.Forms.Label()
        Me.allowedProgramsGroupBox = New System.Windows.Forms.GroupBox()
        Me.allowProgramsListBox = New System.Windows.Forms.ListBox()
        Me.allowListLabel = New System.Windows.Forms.Label()
        Me.removeProgramButton = New System.Windows.Forms.Button()
        Me.addProgramButton = New System.Windows.Forms.Button()
        Me.generalGroupBox = New System.Windows.Forms.GroupBox()
        Me.generalLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scanLogsOffRadioButton = New System.Windows.Forms.RadioButton()
        Me.notificationsLabel = New System.Windows.Forms.Label()
        Me.scanLogsOnRadioButton = New System.Windows.Forms.RadioButton()
        Me.languageLabel2 = New System.Windows.Forms.Label()
        Me.scanPriorityLabel = New System.Windows.Forms.Label()
        Me.scanLogsLabel2 = New System.Windows.Forms.Label()
        Me.scanLogsLabel = New System.Windows.Forms.Label()
        Me.scanPriorityComboBox = New System.Windows.Forms.ComboBox()
        Me.closeNotificationsLabel = New System.Windows.Forms.Label()
        Me.languageLabel = New System.Windows.Forms.Label()
        Me.closeNotificationsComboBox = New System.Windows.Forms.ComboBox()
        Me.languageComboBox = New System.Windows.Forms.ComboBox()
        Me.securityGroupBox = New System.Windows.Forms.GroupBox()
        Me.securityLabel = New System.Windows.Forms.Label()
        Me.webProtectionCheckBox = New System.Windows.Forms.CheckBox()
        Me.webProtectionLabel = New System.Windows.Forms.Label()
        Me.realTimeCheckBox = New System.Windows.Forms.CheckBox()
        Me.realTimeProtectionLabel = New System.Windows.Forms.Label()
        Me.archivedFilesCheckBox = New System.Windows.Forms.CheckBox()
        Me.archivedFilesLabel = New System.Windows.Forms.Label()
        Me.windowsStartCheckBox = New System.Windows.Forms.CheckBox()
        Me.windowsStartLabel = New System.Windows.Forms.Label()
        Me.scheduleScanGroupBox = New System.Windows.Forms.GroupBox()
        Me.scheduleScanLabel = New System.Windows.Forms.Label()
        Me.clearScanDateAndTimeButton = New System.Windows.Forms.Button()
        Me.scheduleDateAndTimeButton = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.amPMLabel = New System.Windows.Forms.Label()
        Me.militaryLabel = New System.Windows.Forms.Label()
        Me.fullScanRadioButton = New System.Windows.Forms.RadioButton()
        Me.minuteUpAndDown = New System.Windows.Forms.NumericUpDown()
        Me.folderScanRadioButton = New System.Windows.Forms.RadioButton()
        Me.hourUpAndDown = New System.Windows.Forms.NumericUpDown()
        Me.minuteLabel = New System.Windows.Forms.Label()
        Me.quickScanRadioButton = New System.Windows.Forms.RadioButton()
        Me.hourLabel = New System.Windows.Forms.Label()
        Me.aboutScheduledScansLabel = New System.Windows.Forms.Label()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Panel1.SuspendLayout()
        CType(Me.exitPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.aboutProgramGroupBox.SuspendLayout()
        Me.allowedProgramsGroupBox.SuspendLayout()
        Me.generalGroupBox.SuspendLayout()
        Me.securityGroupBox.SuspendLayout()
        Me.scheduleScanGroupBox.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.minuteUpAndDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hourUpAndDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.titleLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 50)
        Me.Panel1.TabIndex = 5
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.Snow
        Me.titleLabel.Location = New System.Drawing.Point(143, 12)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(425, 27)
        Me.titleLabel.TabIndex = 5
        Me.titleLabel.Text = "Mythodikal Anti-Virus Settings"
        '
        'exitPicBox
        '
        Me.exitPicBox.BackColor = System.Drawing.Color.DodgerBlue
        Me.exitPicBox.Image = Global.MikesAntiVirusScanner.My.Resources.Resources.closeIcon
        Me.exitPicBox.Location = New System.Drawing.Point(750, -1)
        Me.exitPicBox.Name = "exitPicBox"
        Me.exitPicBox.Size = New System.Drawing.Size(52, 50)
        Me.exitPicBox.TabIndex = 6
        Me.exitPicBox.TabStop = False
        '
        'minimizePicBox
        '
        Me.minimizePicBox.BackColor = System.Drawing.Color.DodgerBlue
        Me.minimizePicBox.Image = Global.MikesAntiVirusScanner.My.Resources.Resources.minimizeIcon
        Me.minimizePicBox.Location = New System.Drawing.Point(698, -1)
        Me.minimizePicBox.Name = "minimizePicBox"
        Me.minimizePicBox.Size = New System.Drawing.Size(52, 50)
        Me.minimizePicBox.TabIndex = 7
        Me.minimizePicBox.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.securityButton)
        Me.Panel2.Controls.Add(Me.generalSettingsButton)
        Me.Panel2.Controls.Add(Me.aboutButton)
        Me.Panel2.Controls.Add(Me.allowListButton)
        Me.Panel2.Controls.Add(Me.scheduleScanButton)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(214, 400)
        Me.Panel2.TabIndex = 8
        '
        'securityButton
        '
        Me.securityButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.securityButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.securityButton.ForeColor = System.Drawing.SystemColors.Control
        Me.securityButton.Location = New System.Drawing.Point(5, 262)
        Me.securityButton.Name = "securityButton"
        Me.securityButton.Size = New System.Drawing.Size(206, 39)
        Me.securityButton.TabIndex = 4
        Me.securityButton.Text = "Security"
        Me.securityButton.UseVisualStyleBackColor = False
        '
        'generalSettingsButton
        '
        Me.generalSettingsButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.generalSettingsButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generalSettingsButton.ForeColor = System.Drawing.SystemColors.Control
        Me.generalSettingsButton.Location = New System.Drawing.Point(5, 180)
        Me.generalSettingsButton.Name = "generalSettingsButton"
        Me.generalSettingsButton.Size = New System.Drawing.Size(206, 39)
        Me.generalSettingsButton.TabIndex = 3
        Me.generalSettingsButton.Text = "General Settings"
        Me.generalSettingsButton.UseVisualStyleBackColor = False
        '
        'aboutButton
        '
        Me.aboutButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.aboutButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutButton.ForeColor = System.Drawing.SystemColors.Control
        Me.aboutButton.Location = New System.Drawing.Point(5, 348)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(206, 39)
        Me.aboutButton.TabIndex = 2
        Me.aboutButton.Text = "About"
        Me.aboutButton.UseVisualStyleBackColor = False
        '
        'allowListButton
        '
        Me.allowListButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.allowListButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allowListButton.ForeColor = System.Drawing.SystemColors.Control
        Me.allowListButton.Location = New System.Drawing.Point(5, 12)
        Me.allowListButton.Name = "allowListButton"
        Me.allowListButton.Size = New System.Drawing.Size(206, 39)
        Me.allowListButton.TabIndex = 1
        Me.allowListButton.Text = "Allow Programs List"
        Me.allowListButton.UseVisualStyleBackColor = False
        '
        'scheduleScanButton
        '
        Me.scheduleScanButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.scheduleScanButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scheduleScanButton.ForeColor = System.Drawing.SystemColors.Control
        Me.scheduleScanButton.Location = New System.Drawing.Point(5, 96)
        Me.scheduleScanButton.Name = "scheduleScanButton"
        Me.scheduleScanButton.Size = New System.Drawing.Size(206, 39)
        Me.scheduleScanButton.TabIndex = 0
        Me.scheduleScanButton.Text = "Schedule Scan Time"
        Me.scheduleScanButton.UseVisualStyleBackColor = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.IncludeSubdirectories = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'creditTimer
        '
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.aboutProgramGroupBox)
        Me.Panel3.Controls.Add(Me.allowedProgramsGroupBox)
        Me.Panel3.Controls.Add(Me.generalGroupBox)
        Me.Panel3.Controls.Add(Me.securityGroupBox)
        Me.Panel3.Controls.Add(Me.scheduleScanGroupBox)
        Me.Panel3.Location = New System.Drawing.Point(215, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(587, 400)
        Me.Panel3.TabIndex = 12
        '
        'aboutProgramGroupBox
        '
        Me.aboutProgramGroupBox.BackColor = System.Drawing.Color.Black
        Me.aboutProgramGroupBox.Controls.Add(Me.aboutProgramLabel)
        Me.aboutProgramGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.aboutProgramGroupBox.Name = "aboutProgramGroupBox"
        Me.aboutProgramGroupBox.Size = New System.Drawing.Size(580, 389)
        Me.aboutProgramGroupBox.TabIndex = 147
        Me.aboutProgramGroupBox.TabStop = False
        '
        'aboutProgramLabel
        '
        Me.aboutProgramLabel.BackColor = System.Drawing.Color.Black
        Me.aboutProgramLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutProgramLabel.ForeColor = System.Drawing.Color.White
        Me.aboutProgramLabel.Location = New System.Drawing.Point(3, 383)
        Me.aboutProgramLabel.Name = "aboutProgramLabel"
        Me.aboutProgramLabel.Size = New System.Drawing.Size(575, 384)
        Me.aboutProgramLabel.TabIndex = 143
        Me.aboutProgramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'allowedProgramsGroupBox
        '
        Me.allowedProgramsGroupBox.BackColor = System.Drawing.Color.Black
        Me.allowedProgramsGroupBox.Controls.Add(Me.allowProgramsListBox)
        Me.allowedProgramsGroupBox.Controls.Add(Me.allowListLabel)
        Me.allowedProgramsGroupBox.Controls.Add(Me.removeProgramButton)
        Me.allowedProgramsGroupBox.Controls.Add(Me.addProgramButton)
        Me.allowedProgramsGroupBox.ForeColor = System.Drawing.Color.White
        Me.allowedProgramsGroupBox.Location = New System.Drawing.Point(3, 4)
        Me.allowedProgramsGroupBox.Name = "allowedProgramsGroupBox"
        Me.allowedProgramsGroupBox.Size = New System.Drawing.Size(580, 391)
        Me.allowedProgramsGroupBox.TabIndex = 137
        Me.allowedProgramsGroupBox.TabStop = False
        '
        'allowProgramsListBox
        '
        Me.allowProgramsListBox.BackColor = System.Drawing.Color.Black
        Me.allowProgramsListBox.ForeColor = System.Drawing.Color.White
        Me.allowProgramsListBox.FormattingEnabled = True
        Me.allowProgramsListBox.Location = New System.Drawing.Point(7, 61)
        Me.allowProgramsListBox.Name = "allowProgramsListBox"
        Me.allowProgramsListBox.Size = New System.Drawing.Size(566, 316)
        Me.allowProgramsListBox.TabIndex = 149
        '
        'allowListLabel
        '
        Me.allowListLabel.AutoSize = True
        Me.allowListLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allowListLabel.ForeColor = System.Drawing.Color.Snow
        Me.allowListLabel.Location = New System.Drawing.Point(214, 22)
        Me.allowListLabel.Name = "allowListLabel"
        Me.allowListLabel.Size = New System.Drawing.Size(148, 27)
        Me.allowListLabel.TabIndex = 148
        Me.allowListLabel.Text = "Allow List"
        '
        'removeProgramButton
        '
        Me.removeProgramButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.removeProgramButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeProgramButton.ForeColor = System.Drawing.SystemColors.Control
        Me.removeProgramButton.Location = New System.Drawing.Point(368, 15)
        Me.removeProgramButton.Name = "removeProgramButton"
        Me.removeProgramButton.Size = New System.Drawing.Size(206, 39)
        Me.removeProgramButton.TabIndex = 147
        Me.removeProgramButton.Text = "Remove Program"
        Me.removeProgramButton.UseVisualStyleBackColor = False
        '
        'addProgramButton
        '
        Me.addProgramButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.addProgramButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addProgramButton.ForeColor = System.Drawing.SystemColors.Control
        Me.addProgramButton.Location = New System.Drawing.Point(6, 13)
        Me.addProgramButton.Name = "addProgramButton"
        Me.addProgramButton.Size = New System.Drawing.Size(206, 40)
        Me.addProgramButton.TabIndex = 146
        Me.addProgramButton.Text = "Add Program"
        Me.addProgramButton.UseVisualStyleBackColor = False
        '
        'generalGroupBox
        '
        Me.generalGroupBox.Controls.Add(Me.generalLabel)
        Me.generalGroupBox.Controls.Add(Me.Label1)
        Me.generalGroupBox.Controls.Add(Me.scanLogsOffRadioButton)
        Me.generalGroupBox.Controls.Add(Me.notificationsLabel)
        Me.generalGroupBox.Controls.Add(Me.scanLogsOnRadioButton)
        Me.generalGroupBox.Controls.Add(Me.languageLabel2)
        Me.generalGroupBox.Controls.Add(Me.scanPriorityLabel)
        Me.generalGroupBox.Controls.Add(Me.scanLogsLabel2)
        Me.generalGroupBox.Controls.Add(Me.scanLogsLabel)
        Me.generalGroupBox.Controls.Add(Me.scanPriorityComboBox)
        Me.generalGroupBox.Controls.Add(Me.closeNotificationsLabel)
        Me.generalGroupBox.Controls.Add(Me.languageLabel)
        Me.generalGroupBox.Controls.Add(Me.closeNotificationsComboBox)
        Me.generalGroupBox.Controls.Add(Me.languageComboBox)
        Me.generalGroupBox.Location = New System.Drawing.Point(2, 3)
        Me.generalGroupBox.Name = "generalGroupBox"
        Me.generalGroupBox.Size = New System.Drawing.Size(582, 394)
        Me.generalGroupBox.TabIndex = 136
        Me.generalGroupBox.TabStop = False
        '
        'generalLabel
        '
        Me.generalLabel.AutoSize = True
        Me.generalLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generalLabel.ForeColor = System.Drawing.Color.Snow
        Me.generalLabel.Location = New System.Drawing.Point(238, 16)
        Me.generalLabel.Name = "generalLabel"
        Me.generalLabel.Size = New System.Drawing.Size(111, 27)
        Me.generalLabel.TabIndex = 132
        Me.generalLabel.Text = "General"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(60, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 25)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Scan Priority:"
        '
        'scanLogsOffRadioButton
        '
        Me.scanLogsOffRadioButton.AutoSize = True
        Me.scanLogsOffRadioButton.ForeColor = System.Drawing.Color.White
        Me.scanLogsOffRadioButton.Location = New System.Drawing.Point(476, 366)
        Me.scanLogsOffRadioButton.Name = "scanLogsOffRadioButton"
        Me.scanLogsOffRadioButton.Size = New System.Drawing.Size(39, 17)
        Me.scanLogsOffRadioButton.TabIndex = 129
        Me.scanLogsOffRadioButton.Text = "Off"
        Me.scanLogsOffRadioButton.UseVisualStyleBackColor = True
        '
        'notificationsLabel
        '
        Me.notificationsLabel.AutoSize = True
        Me.notificationsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notificationsLabel.ForeColor = System.Drawing.Color.White
        Me.notificationsLabel.Location = New System.Drawing.Point(64, 150)
        Me.notificationsLabel.Name = "notificationsLabel"
        Me.notificationsLabel.Size = New System.Drawing.Size(150, 25)
        Me.notificationsLabel.TabIndex = 23
        Me.notificationsLabel.Text = "Notifications:"
        '
        'scanLogsOnRadioButton
        '
        Me.scanLogsOnRadioButton.AutoSize = True
        Me.scanLogsOnRadioButton.Checked = True
        Me.scanLogsOnRadioButton.ForeColor = System.Drawing.Color.White
        Me.scanLogsOnRadioButton.Location = New System.Drawing.Point(265, 366)
        Me.scanLogsOnRadioButton.Name = "scanLogsOnRadioButton"
        Me.scanLogsOnRadioButton.Size = New System.Drawing.Size(39, 17)
        Me.scanLogsOnRadioButton.TabIndex = 27
        Me.scanLogsOnRadioButton.TabStop = True
        Me.scanLogsOnRadioButton.Text = "On"
        Me.scanLogsOnRadioButton.UseVisualStyleBackColor = True
        '
        'languageLabel2
        '
        Me.languageLabel2.AutoSize = True
        Me.languageLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.languageLabel2.ForeColor = System.Drawing.Color.White
        Me.languageLabel2.Location = New System.Drawing.Point(91, 58)
        Me.languageLabel2.Name = "languageLabel2"
        Me.languageLabel2.Size = New System.Drawing.Size(123, 25)
        Me.languageLabel2.TabIndex = 22
        Me.languageLabel2.Text = "Language:"
        '
        'scanPriorityLabel
        '
        Me.scanPriorityLabel.AutoSize = True
        Me.scanPriorityLabel.ForeColor = System.Drawing.Color.White
        Me.scanPriorityLabel.Location = New System.Drawing.Point(77, 277)
        Me.scanPriorityLabel.Name = "scanPriorityLabel"
        Me.scanPriorityLabel.Size = New System.Drawing.Size(131, 13)
        Me.scanPriorityLabel.TabIndex = 21
        Me.scanPriorityLabel.Text = "Program Scanning Priority:"
        '
        'scanLogsLabel2
        '
        Me.scanLogsLabel2.AutoSize = True
        Me.scanLogsLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scanLogsLabel2.ForeColor = System.Drawing.Color.White
        Me.scanLogsLabel2.Location = New System.Drawing.Point(84, 331)
        Me.scanLogsLabel2.Name = "scanLogsLabel2"
        Me.scanLogsLabel2.Size = New System.Drawing.Size(130, 25)
        Me.scanLogsLabel2.TabIndex = 26
        Me.scanLogsLabel2.Text = "Scan Logs:"
        '
        'scanLogsLabel
        '
        Me.scanLogsLabel.AutoSize = True
        Me.scanLogsLabel.ForeColor = System.Drawing.Color.White
        Me.scanLogsLabel.Location = New System.Drawing.Point(107, 368)
        Me.scanLogsLabel.Name = "scanLogsLabel"
        Me.scanLogsLabel.Size = New System.Drawing.Size(109, 13)
        Me.scanLogsLabel.TabIndex = 25
        Me.scanLogsLabel.Text = "Write Scanning Logs:"
        '
        'scanPriorityComboBox
        '
        Me.scanPriorityComboBox.Items.AddRange(New Object() {"Low Priority", "Normal Priority", "Above Normal Priority", "High Priority", "Really High Priority"})
        Me.scanPriorityComboBox.Location = New System.Drawing.Point(265, 275)
        Me.scanPriorityComboBox.Name = "scanPriorityComboBox"
        Me.scanPriorityComboBox.Size = New System.Drawing.Size(250, 21)
        Me.scanPriorityComboBox.TabIndex = 20
        '
        'closeNotificationsLabel
        '
        Me.closeNotificationsLabel.AutoSize = True
        Me.closeNotificationsLabel.ForeColor = System.Drawing.Color.White
        Me.closeNotificationsLabel.Location = New System.Drawing.Point(86, 186)
        Me.closeNotificationsLabel.Name = "closeNotificationsLabel"
        Me.closeNotificationsLabel.Size = New System.Drawing.Size(122, 13)
        Me.closeNotificationsLabel.TabIndex = 18
        Me.closeNotificationsLabel.Text = "Close Notifications After:"
        '
        'languageLabel
        '
        Me.languageLabel.AutoSize = True
        Me.languageLabel.ForeColor = System.Drawing.Color.White
        Me.languageLabel.Location = New System.Drawing.Point(57, 95)
        Me.languageLabel.Name = "languageLabel"
        Me.languageLabel.Size = New System.Drawing.Size(151, 13)
        Me.languageLabel.TabIndex = 17
        Me.languageLabel.Text = "Select Language For Program:"
        '
        'closeNotificationsComboBox
        '
        Me.closeNotificationsComboBox.FormattingEnabled = True
        Me.closeNotificationsComboBox.Items.AddRange(New Object() {"5 Seconds", "10 Seconds", "15 Seconds", "20 Seconds", "30 Seconds"})
        Me.closeNotificationsComboBox.Location = New System.Drawing.Point(265, 185)
        Me.closeNotificationsComboBox.Name = "closeNotificationsComboBox"
        Me.closeNotificationsComboBox.Size = New System.Drawing.Size(250, 21)
        Me.closeNotificationsComboBox.TabIndex = 16
        '
        'languageComboBox
        '
        Me.languageComboBox.FormattingEnabled = True
        Me.languageComboBox.Items.AddRange(New Object() {"English", "German"})
        Me.languageComboBox.Location = New System.Drawing.Point(265, 95)
        Me.languageComboBox.Name = "languageComboBox"
        Me.languageComboBox.Size = New System.Drawing.Size(250, 21)
        Me.languageComboBox.TabIndex = 15
        '
        'securityGroupBox
        '
        Me.securityGroupBox.BackColor = System.Drawing.Color.Black
        Me.securityGroupBox.Controls.Add(Me.securityLabel)
        Me.securityGroupBox.Controls.Add(Me.webProtectionCheckBox)
        Me.securityGroupBox.Controls.Add(Me.webProtectionLabel)
        Me.securityGroupBox.Controls.Add(Me.realTimeCheckBox)
        Me.securityGroupBox.Controls.Add(Me.realTimeProtectionLabel)
        Me.securityGroupBox.Controls.Add(Me.archivedFilesCheckBox)
        Me.securityGroupBox.Controls.Add(Me.archivedFilesLabel)
        Me.securityGroupBox.Controls.Add(Me.windowsStartCheckBox)
        Me.securityGroupBox.Controls.Add(Me.windowsStartLabel)
        Me.securityGroupBox.ForeColor = System.Drawing.Color.White
        Me.securityGroupBox.Location = New System.Drawing.Point(3, 4)
        Me.securityGroupBox.Name = "securityGroupBox"
        Me.securityGroupBox.Size = New System.Drawing.Size(581, 391)
        Me.securityGroupBox.TabIndex = 135
        Me.securityGroupBox.TabStop = False
        '
        'securityLabel
        '
        Me.securityLabel.AutoSize = True
        Me.securityLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.securityLabel.ForeColor = System.Drawing.Color.Snow
        Me.securityLabel.Location = New System.Drawing.Point(228, 20)
        Me.securityLabel.Name = "securityLabel"
        Me.securityLabel.Size = New System.Drawing.Size(124, 27)
        Me.securityLabel.TabIndex = 135
        Me.securityLabel.Text = "Security"
        Me.securityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'webProtectionCheckBox
        '
        Me.webProtectionCheckBox.AutoSize = True
        Me.webProtectionCheckBox.Enabled = False
        Me.webProtectionCheckBox.ForeColor = System.Drawing.Color.White
        Me.webProtectionCheckBox.Location = New System.Drawing.Point(513, 318)
        Me.webProtectionCheckBox.Name = "webProtectionCheckBox"
        Me.webProtectionCheckBox.Size = New System.Drawing.Size(40, 17)
        Me.webProtectionCheckBox.TabIndex = 134
        Me.webProtectionCheckBox.Text = "Off"
        Me.webProtectionCheckBox.UseVisualStyleBackColor = True
        '
        'webProtectionLabel
        '
        Me.webProtectionLabel.AutoSize = True
        Me.webProtectionLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.webProtectionLabel.ForeColor = System.Drawing.Color.Snow
        Me.webProtectionLabel.Location = New System.Drawing.Point(256, 311)
        Me.webProtectionLabel.Name = "webProtectionLabel"
        Me.webProtectionLabel.Size = New System.Drawing.Size(220, 27)
        Me.webProtectionLabel.TabIndex = 133
        Me.webProtectionLabel.Text = "Web Protection:"
        Me.webProtectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'realTimeCheckBox
        '
        Me.realTimeCheckBox.AutoSize = True
        Me.realTimeCheckBox.Checked = True
        Me.realTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.realTimeCheckBox.ForeColor = System.Drawing.Color.White
        Me.realTimeCheckBox.Location = New System.Drawing.Point(513, 229)
        Me.realTimeCheckBox.Name = "realTimeCheckBox"
        Me.realTimeCheckBox.Size = New System.Drawing.Size(40, 17)
        Me.realTimeCheckBox.TabIndex = 132
        Me.realTimeCheckBox.Text = "On"
        Me.realTimeCheckBox.UseVisualStyleBackColor = True
        '
        'realTimeProtectionLabel
        '
        Me.realTimeProtectionLabel.AutoSize = True
        Me.realTimeProtectionLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.realTimeProtectionLabel.ForeColor = System.Drawing.Color.Snow
        Me.realTimeProtectionLabel.Location = New System.Drawing.Point(188, 222)
        Me.realTimeProtectionLabel.Name = "realTimeProtectionLabel"
        Me.realTimeProtectionLabel.Size = New System.Drawing.Size(293, 27)
        Me.realTimeProtectionLabel.TabIndex = 131
        Me.realTimeProtectionLabel.Text = "Real-Time Protection:"
        Me.realTimeProtectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'archivedFilesCheckBox
        '
        Me.archivedFilesCheckBox.AutoSize = True
        Me.archivedFilesCheckBox.Enabled = False
        Me.archivedFilesCheckBox.ForeColor = System.Drawing.Color.White
        Me.archivedFilesCheckBox.Location = New System.Drawing.Point(513, 140)
        Me.archivedFilesCheckBox.Name = "archivedFilesCheckBox"
        Me.archivedFilesCheckBox.Size = New System.Drawing.Size(40, 17)
        Me.archivedFilesCheckBox.TabIndex = 130
        Me.archivedFilesCheckBox.Text = "Off"
        Me.archivedFilesCheckBox.UseVisualStyleBackColor = True
        '
        'archivedFilesLabel
        '
        Me.archivedFilesLabel.AutoSize = True
        Me.archivedFilesLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.archivedFilesLabel.ForeColor = System.Drawing.Color.Snow
        Me.archivedFilesLabel.Location = New System.Drawing.Point(107, 133)
        Me.archivedFilesLabel.Name = "archivedFilesLabel"
        Me.archivedFilesLabel.Size = New System.Drawing.Size(374, 27)
        Me.archivedFilesLabel.TabIndex = 129
        Me.archivedFilesLabel.Text = "Scan Within Archived Files:"
        Me.archivedFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'windowsStartCheckBox
        '
        Me.windowsStartCheckBox.AutoSize = True
        Me.windowsStartCheckBox.Checked = True
        Me.windowsStartCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.windowsStartCheckBox.ForeColor = System.Drawing.Color.White
        Me.windowsStartCheckBox.Location = New System.Drawing.Point(514, 51)
        Me.windowsStartCheckBox.Name = "windowsStartCheckBox"
        Me.windowsStartCheckBox.Size = New System.Drawing.Size(40, 17)
        Me.windowsStartCheckBox.TabIndex = 128
        Me.windowsStartCheckBox.Text = "On"
        Me.windowsStartCheckBox.UseVisualStyleBackColor = True
        '
        'windowsStartLabel
        '
        Me.windowsStartLabel.AutoSize = True
        Me.windowsStartLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.windowsStartLabel.ForeColor = System.Drawing.Color.Snow
        Me.windowsStartLabel.Location = New System.Drawing.Point(26, 51)
        Me.windowsStartLabel.Name = "windowsStartLabel"
        Me.windowsStartLabel.Size = New System.Drawing.Size(458, 27)
        Me.windowsStartLabel.TabIndex = 127
        Me.windowsStartLabel.Text = "Start Program On Windows Start:"
        Me.windowsStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'scheduleScanGroupBox
        '
        Me.scheduleScanGroupBox.BackColor = System.Drawing.Color.Black
        Me.scheduleScanGroupBox.Controls.Add(Me.scheduleScanLabel)
        Me.scheduleScanGroupBox.Controls.Add(Me.clearScanDateAndTimeButton)
        Me.scheduleScanGroupBox.Controls.Add(Me.scheduleDateAndTimeButton)
        Me.scheduleScanGroupBox.Controls.Add(Me.GroupBox8)
        Me.scheduleScanGroupBox.Controls.Add(Me.aboutScheduledScansLabel)
        Me.scheduleScanGroupBox.Controls.Add(Me.MonthCalendar2)
        Me.scheduleScanGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.scheduleScanGroupBox.Location = New System.Drawing.Point(4, 3)
        Me.scheduleScanGroupBox.Name = "scheduleScanGroupBox"
        Me.scheduleScanGroupBox.Size = New System.Drawing.Size(578, 392)
        Me.scheduleScanGroupBox.TabIndex = 133
        Me.scheduleScanGroupBox.TabStop = False
        Me.scheduleScanGroupBox.Text = "Schedule Monthly Scan"
        '
        'scheduleScanLabel
        '
        Me.scheduleScanLabel.AutoSize = True
        Me.scheduleScanLabel.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scheduleScanLabel.ForeColor = System.Drawing.Color.Snow
        Me.scheduleScanLabel.Location = New System.Drawing.Point(214, 36)
        Me.scheduleScanLabel.Name = "scheduleScanLabel"
        Me.scheduleScanLabel.Size = New System.Drawing.Size(151, 22)
        Me.scheduleScanLabel.TabIndex = 118
        Me.scheduleScanLabel.Text = "Schedule Scan"
        '
        'clearScanDateAndTimeButton
        '
        Me.clearScanDateAndTimeButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.clearScanDateAndTimeButton.Enabled = False
        Me.clearScanDateAndTimeButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearScanDateAndTimeButton.ForeColor = System.Drawing.SystemColors.Control
        Me.clearScanDateAndTimeButton.Location = New System.Drawing.Point(368, 29)
        Me.clearScanDateAndTimeButton.Name = "clearScanDateAndTimeButton"
        Me.clearScanDateAndTimeButton.Size = New System.Drawing.Size(206, 39)
        Me.clearScanDateAndTimeButton.TabIndex = 117
        Me.clearScanDateAndTimeButton.Text = "Clear Scan Date"
        Me.clearScanDateAndTimeButton.UseVisualStyleBackColor = False
        '
        'scheduleDateAndTimeButton
        '
        Me.scheduleDateAndTimeButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.scheduleDateAndTimeButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scheduleDateAndTimeButton.ForeColor = System.Drawing.SystemColors.Control
        Me.scheduleDateAndTimeButton.Location = New System.Drawing.Point(4, 29)
        Me.scheduleDateAndTimeButton.Name = "scheduleDateAndTimeButton"
        Me.scheduleDateAndTimeButton.Size = New System.Drawing.Size(206, 39)
        Me.scheduleDateAndTimeButton.TabIndex = 116
        Me.scheduleDateAndTimeButton.Text = "Schedule Scan Date"
        Me.scheduleDateAndTimeButton.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.amPMLabel)
        Me.GroupBox8.Controls.Add(Me.militaryLabel)
        Me.GroupBox8.Controls.Add(Me.fullScanRadioButton)
        Me.GroupBox8.Controls.Add(Me.minuteUpAndDown)
        Me.GroupBox8.Controls.Add(Me.folderScanRadioButton)
        Me.GroupBox8.Controls.Add(Me.hourUpAndDown)
        Me.GroupBox8.Controls.Add(Me.minuteLabel)
        Me.GroupBox8.Controls.Add(Me.quickScanRadioButton)
        Me.GroupBox8.Controls.Add(Me.hourLabel)
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(271, 207)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(303, 162)
        Me.GroupBox8.TabIndex = 115
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Select Scan"
        '
        'amPMLabel
        '
        Me.amPMLabel.AutoSize = True
        Me.amPMLabel.ForeColor = System.Drawing.Color.White
        Me.amPMLabel.Location = New System.Drawing.Point(256, 71)
        Me.amPMLabel.Name = "amPMLabel"
        Me.amPMLabel.Size = New System.Drawing.Size(23, 13)
        Me.amPMLabel.TabIndex = 18
        Me.amPMLabel.Text = "AM"
        '
        'militaryLabel
        '
        Me.militaryLabel.AutoSize = True
        Me.militaryLabel.ForeColor = System.Drawing.Color.White
        Me.militaryLabel.Location = New System.Drawing.Point(100, 21)
        Me.militaryLabel.Name = "militaryLabel"
        Me.militaryLabel.Size = New System.Drawing.Size(173, 13)
        Me.militaryLabel.TabIndex = 17
        Me.militaryLabel.Text = "Hours And Minutes In Military Time:"
        '
        'fullScanRadioButton
        '
        Me.fullScanRadioButton.AutoSize = True
        Me.fullScanRadioButton.ForeColor = System.Drawing.Color.White
        Me.fullScanRadioButton.Location = New System.Drawing.Point(9, 71)
        Me.fullScanRadioButton.Name = "fullScanRadioButton"
        Me.fullScanRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.fullScanRadioButton.TabIndex = 6
        Me.fullScanRadioButton.TabStop = True
        Me.fullScanRadioButton.Text = "Full Scan"
        Me.fullScanRadioButton.UseVisualStyleBackColor = True
        '
        'minuteUpAndDown
        '
        Me.minuteUpAndDown.Location = New System.Drawing.Point(188, 120)
        Me.minuteUpAndDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.minuteUpAndDown.Name = "minuteUpAndDown"
        Me.minuteUpAndDown.Size = New System.Drawing.Size(62, 20)
        Me.minuteUpAndDown.TabIndex = 16
        '
        'folderScanRadioButton
        '
        Me.folderScanRadioButton.AutoSize = True
        Me.folderScanRadioButton.ForeColor = System.Drawing.Color.White
        Me.folderScanRadioButton.Location = New System.Drawing.Point(8, 123)
        Me.folderScanRadioButton.Name = "folderScanRadioButton"
        Me.folderScanRadioButton.Size = New System.Drawing.Size(82, 17)
        Me.folderScanRadioButton.TabIndex = 8
        Me.folderScanRadioButton.TabStop = True
        Me.folderScanRadioButton.Text = "Folder Scan"
        Me.folderScanRadioButton.UseVisualStyleBackColor = True
        '
        'hourUpAndDown
        '
        Me.hourUpAndDown.Location = New System.Drawing.Point(188, 69)
        Me.hourUpAndDown.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.hourUpAndDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.hourUpAndDown.Name = "hourUpAndDown"
        Me.hourUpAndDown.Size = New System.Drawing.Size(62, 20)
        Me.hourUpAndDown.TabIndex = 14
        Me.hourUpAndDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'minuteLabel
        '
        Me.minuteLabel.AutoSize = True
        Me.minuteLabel.ForeColor = System.Drawing.Color.White
        Me.minuteLabel.Location = New System.Drawing.Point(140, 123)
        Me.minuteLabel.Name = "minuteLabel"
        Me.minuteLabel.Size = New System.Drawing.Size(42, 13)
        Me.minuteLabel.TabIndex = 4
        Me.minuteLabel.Text = "Minute:"
        '
        'quickScanRadioButton
        '
        Me.quickScanRadioButton.AutoSize = True
        Me.quickScanRadioButton.ForeColor = System.Drawing.Color.White
        Me.quickScanRadioButton.Location = New System.Drawing.Point(9, 19)
        Me.quickScanRadioButton.Name = "quickScanRadioButton"
        Me.quickScanRadioButton.Size = New System.Drawing.Size(81, 17)
        Me.quickScanRadioButton.TabIndex = 7
        Me.quickScanRadioButton.TabStop = True
        Me.quickScanRadioButton.Text = "Quick Scan"
        Me.quickScanRadioButton.UseVisualStyleBackColor = True
        '
        'hourLabel
        '
        Me.hourLabel.AutoSize = True
        Me.hourLabel.ForeColor = System.Drawing.Color.White
        Me.hourLabel.Location = New System.Drawing.Point(149, 71)
        Me.hourLabel.Name = "hourLabel"
        Me.hourLabel.Size = New System.Drawing.Size(33, 13)
        Me.hourLabel.TabIndex = 11
        Me.hourLabel.Text = "Hour:"
        '
        'aboutScheduledScansLabel
        '
        Me.aboutScheduledScansLabel.ForeColor = System.Drawing.Color.White
        Me.aboutScheduledScansLabel.Location = New System.Drawing.Point(18, 114)
        Me.aboutScheduledScansLabel.Name = "aboutScheduledScansLabel"
        Me.aboutScheduledScansLabel.Size = New System.Drawing.Size(545, 47)
        Me.aboutScheduledScansLabel.TabIndex = 18
        Me.aboutScheduledScansLabel.Text = resources.GetString("aboutScheduledScansLabel.Text")
        Me.aboutScheduledScansLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(8, 207)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 0
        '
        'settingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(807, 457)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.minimizePicBox)
        Me.Controls.Add(Me.exitPicBox)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "settingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "settingsForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.exitPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.aboutProgramGroupBox.ResumeLayout(False)
        Me.allowedProgramsGroupBox.ResumeLayout(False)
        Me.allowedProgramsGroupBox.PerformLayout()
        Me.generalGroupBox.ResumeLayout(False)
        Me.generalGroupBox.PerformLayout()
        Me.securityGroupBox.ResumeLayout(False)
        Me.securityGroupBox.PerformLayout()
        Me.scheduleScanGroupBox.ResumeLayout(False)
        Me.scheduleScanGroupBox.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.minuteUpAndDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hourUpAndDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents titleLabel As Label
    Friend WithEvents exitPicBox As PictureBox
    Friend WithEvents minimizePicBox As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents securityButton As Button
    Friend WithEvents generalSettingsButton As Button
    Friend WithEvents aboutButton As Button
    Friend WithEvents allowListButton As Button
    Friend WithEvents scheduleScanButton As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents creditTimer As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents aboutProgramGroupBox As GroupBox
    Friend WithEvents aboutProgramLabel As Label
    Friend WithEvents allowedProgramsGroupBox As GroupBox
    Friend WithEvents generalGroupBox As GroupBox
    Friend WithEvents generalLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents scanLogsOffRadioButton As RadioButton
    Friend WithEvents notificationsLabel As Label
    Friend WithEvents scanLogsOnRadioButton As RadioButton
    Friend WithEvents languageLabel2 As Label
    Friend WithEvents scanPriorityLabel As Label
    Friend WithEvents scanLogsLabel2 As Label
    Friend WithEvents scanLogsLabel As Label
    Friend WithEvents scanPriorityComboBox As ComboBox
    Friend WithEvents closeNotificationsLabel As Label
    Friend WithEvents languageLabel As Label
    Friend WithEvents closeNotificationsComboBox As ComboBox
    Friend WithEvents languageComboBox As ComboBox
    Friend WithEvents securityGroupBox As GroupBox
    Friend WithEvents securityLabel As Label
    Friend WithEvents webProtectionCheckBox As CheckBox
    Friend WithEvents webProtectionLabel As Label
    Friend WithEvents realTimeCheckBox As CheckBox
    Friend WithEvents realTimeProtectionLabel As Label
    Friend WithEvents archivedFilesCheckBox As CheckBox
    Friend WithEvents archivedFilesLabel As Label
    Friend WithEvents windowsStartCheckBox As CheckBox
    Friend WithEvents windowsStartLabel As Label
    Friend WithEvents scheduleScanGroupBox As GroupBox
    Friend WithEvents scheduleScanLabel As Label
    Friend WithEvents clearScanDateAndTimeButton As Button
    Friend WithEvents scheduleDateAndTimeButton As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents amPMLabel As Label
    Friend WithEvents militaryLabel As Label
    Friend WithEvents fullScanRadioButton As RadioButton
    Friend WithEvents minuteUpAndDown As NumericUpDown
    Friend WithEvents folderScanRadioButton As RadioButton
    Friend WithEvents hourUpAndDown As NumericUpDown
    Friend WithEvents minuteLabel As Label
    Friend WithEvents quickScanRadioButton As RadioButton
    Friend WithEvents hourLabel As Label
    Friend WithEvents aboutScheduledScansLabel As Label
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents allowProgramsListBox As ListBox
    Friend WithEvents allowListLabel As Label
    Friend WithEvents removeProgramButton As Button
    Friend WithEvents addProgramButton As Button
End Class
