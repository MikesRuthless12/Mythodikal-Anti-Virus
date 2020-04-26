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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.scheduleScanGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.fullScanRadioButton = New System.Windows.Forms.RadioButton()
        Me.minuteUpAndDown = New System.Windows.Forms.NumericUpDown()
        Me.folderScanRadioButton = New System.Windows.Forms.RadioButton()
        Me.hourUpAndDown = New System.Windows.Forms.NumericUpDown()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.quickScanRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.aboutProgramLabel = New System.Windows.Forms.Label()
        Me.webProtectionCheckBox = New System.Windows.Forms.CheckBox()
        Me.webProtectionLabel = New System.Windows.Forms.Label()
        Me.realTimeCheckBox = New System.Windows.Forms.CheckBox()
        Me.realTimeProtectionLabel = New System.Windows.Forms.Label()
        Me.archivedFilesCheckBox = New System.Windows.Forms.CheckBox()
        Me.archivedFilesLabel = New System.Windows.Forms.Label()
        Me.windowsStartCheckBox = New System.Windows.Forms.CheckBox()
        Me.windowsStartLabel = New System.Windows.Forms.Label()
        Me.securityLabel = New System.Windows.Forms.Label()
        Me.generalLabel = New System.Windows.Forms.Label()
        Me.allowProgramsListBox = New System.Windows.Forms.ListBox()
        Me.removeProgramButton = New System.Windows.Forms.Button()
        Me.addProgramButton = New System.Windows.Forms.Button()
        Me.allowListLabel = New System.Windows.Forms.Label()
        Me.clearScanDateAndTimeButton = New System.Windows.Forms.Button()
        Me.scheduleDateAndTimeButton = New System.Windows.Forms.Button()
        Me.scheduleScanLabel = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.creditTimer = New System.Windows.Forms.Timer(Me.components)
        Me.militaryLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.exitPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.scheduleScanGroupBox.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.minuteUpAndDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hourUpAndDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
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
        Me.exitPicBox.BackColor = System.Drawing.SystemColors.Highlight
        Me.exitPicBox.Image = Global.MikesAntiVirusScanner.My.Resources.Resources.closeIcon
        Me.exitPicBox.Location = New System.Drawing.Point(750, -1)
        Me.exitPicBox.Name = "exitPicBox"
        Me.exitPicBox.Size = New System.Drawing.Size(52, 50)
        Me.exitPicBox.TabIndex = 6
        Me.exitPicBox.TabStop = False
        '
        'minimizePicBox
        '
        Me.minimizePicBox.BackColor = System.Drawing.SystemColors.Highlight
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
        Me.securityButton.BackColor = System.Drawing.SystemColors.Highlight
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
        Me.generalSettingsButton.BackColor = System.Drawing.SystemColors.Highlight
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
        Me.aboutButton.BackColor = System.Drawing.SystemColors.Highlight
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
        Me.allowListButton.BackColor = System.Drawing.SystemColors.Highlight
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
        Me.scheduleScanButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.scheduleScanButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scheduleScanButton.ForeColor = System.Drawing.SystemColors.Control
        Me.scheduleScanButton.Location = New System.Drawing.Point(5, 96)
        Me.scheduleScanButton.Name = "scheduleScanButton"
        Me.scheduleScanButton.Size = New System.Drawing.Size(206, 39)
        Me.scheduleScanButton.TabIndex = 0
        Me.scheduleScanButton.Text = "Schedule Scan Time"
        Me.scheduleScanButton.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.scheduleScanGroupBox)
        Me.Panel3.Controls.Add(Me.aboutProgramLabel)
        Me.Panel3.Controls.Add(Me.webProtectionCheckBox)
        Me.Panel3.Controls.Add(Me.webProtectionLabel)
        Me.Panel3.Controls.Add(Me.realTimeCheckBox)
        Me.Panel3.Controls.Add(Me.realTimeProtectionLabel)
        Me.Panel3.Controls.Add(Me.archivedFilesCheckBox)
        Me.Panel3.Controls.Add(Me.archivedFilesLabel)
        Me.Panel3.Controls.Add(Me.windowsStartCheckBox)
        Me.Panel3.Controls.Add(Me.windowsStartLabel)
        Me.Panel3.Controls.Add(Me.securityLabel)
        Me.Panel3.Controls.Add(Me.generalLabel)
        Me.Panel3.Controls.Add(Me.allowProgramsListBox)
        Me.Panel3.Controls.Add(Me.removeProgramButton)
        Me.Panel3.Controls.Add(Me.addProgramButton)
        Me.Panel3.Controls.Add(Me.allowListLabel)
        Me.Panel3.Controls.Add(Me.clearScanDateAndTimeButton)
        Me.Panel3.Controls.Add(Me.scheduleDateAndTimeButton)
        Me.Panel3.Controls.Add(Me.scheduleScanLabel)
        Me.Panel3.Location = New System.Drawing.Point(215, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(587, 400)
        Me.Panel3.TabIndex = 9
        '
        'scheduleScanGroupBox
        '
        Me.scheduleScanGroupBox.Controls.Add(Me.GroupBox8)
        Me.scheduleScanGroupBox.Controls.Add(Me.MonthCalendar2)
        Me.scheduleScanGroupBox.Location = New System.Drawing.Point(13, 107)
        Me.scheduleScanGroupBox.Name = "scheduleScanGroupBox"
        Me.scheduleScanGroupBox.Size = New System.Drawing.Size(560, 187)
        Me.scheduleScanGroupBox.TabIndex = 90
        Me.scheduleScanGroupBox.TabStop = False
        Me.scheduleScanGroupBox.Text = "Schedule Scan"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.militaryLabel)
        Me.GroupBox8.Controls.Add(Me.fullScanRadioButton)
        Me.GroupBox8.Controls.Add(Me.minuteUpAndDown)
        Me.GroupBox8.Controls.Add(Me.folderScanRadioButton)
        Me.GroupBox8.Controls.Add(Me.hourUpAndDown)
        Me.GroupBox8.Controls.Add(Me.Label27)
        Me.GroupBox8.Controls.Add(Me.quickScanRadioButton)
        Me.GroupBox8.Controls.Add(Me.Label29)
        Me.GroupBox8.Location = New System.Drawing.Point(251, 19)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(303, 162)
        Me.GroupBox8.TabIndex = 9
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Select Scan"
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
        Me.minuteUpAndDown.Location = New System.Drawing.Point(210, 118)
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
        Me.hourUpAndDown.Location = New System.Drawing.Point(211, 69)
        Me.hourUpAndDown.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.hourUpAndDown.Name = "hourUpAndDown"
        Me.hourUpAndDown.Size = New System.Drawing.Size(62, 20)
        Me.hourUpAndDown.TabIndex = 14
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(140, 123)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(42, 13)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Minute:"
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
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(149, 71)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 13)
        Me.Label29.TabIndex = 11
        Me.Label29.Text = "Hour:"
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(12, 19)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 0
        '
        'aboutProgramLabel
        '
        Me.aboutProgramLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutProgramLabel.ForeColor = System.Drawing.Color.Snow
        Me.aboutProgramLabel.Location = New System.Drawing.Point(12, 377)
        Me.aboutProgramLabel.Name = "aboutProgramLabel"
        Me.aboutProgramLabel.Size = New System.Drawing.Size(571, 400)
        Me.aboutProgramLabel.TabIndex = 89
        Me.aboutProgramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'webProtectionCheckBox
        '
        Me.webProtectionCheckBox.AutoSize = True
        Me.webProtectionCheckBox.Enabled = False
        Me.webProtectionCheckBox.ForeColor = System.Drawing.Color.White
        Me.webProtectionCheckBox.Location = New System.Drawing.Point(495, 336)
        Me.webProtectionCheckBox.Name = "webProtectionCheckBox"
        Me.webProtectionCheckBox.Size = New System.Drawing.Size(40, 17)
        Me.webProtectionCheckBox.TabIndex = 88
        Me.webProtectionCheckBox.Text = "Off"
        Me.webProtectionCheckBox.UseVisualStyleBackColor = True
        '
        'webProtectionLabel
        '
        Me.webProtectionLabel.AutoSize = True
        Me.webProtectionLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.webProtectionLabel.ForeColor = System.Drawing.Color.Snow
        Me.webProtectionLabel.Location = New System.Drawing.Point(238, 329)
        Me.webProtectionLabel.Name = "webProtectionLabel"
        Me.webProtectionLabel.Size = New System.Drawing.Size(220, 27)
        Me.webProtectionLabel.TabIndex = 87
        Me.webProtectionLabel.Text = "Web Protection:"
        Me.webProtectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'realTimeCheckBox
        '
        Me.realTimeCheckBox.AutoSize = True
        Me.realTimeCheckBox.Checked = True
        Me.realTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.realTimeCheckBox.ForeColor = System.Drawing.Color.White
        Me.realTimeCheckBox.Location = New System.Drawing.Point(495, 247)
        Me.realTimeCheckBox.Name = "realTimeCheckBox"
        Me.realTimeCheckBox.Size = New System.Drawing.Size(40, 17)
        Me.realTimeCheckBox.TabIndex = 86
        Me.realTimeCheckBox.Text = "On"
        Me.realTimeCheckBox.UseVisualStyleBackColor = True
        '
        'realTimeProtectionLabel
        '
        Me.realTimeProtectionLabel.AutoSize = True
        Me.realTimeProtectionLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.realTimeProtectionLabel.ForeColor = System.Drawing.Color.Snow
        Me.realTimeProtectionLabel.Location = New System.Drawing.Point(170, 240)
        Me.realTimeProtectionLabel.Name = "realTimeProtectionLabel"
        Me.realTimeProtectionLabel.Size = New System.Drawing.Size(293, 27)
        Me.realTimeProtectionLabel.TabIndex = 85
        Me.realTimeProtectionLabel.Text = "Real-Time Protection:"
        Me.realTimeProtectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'archivedFilesCheckBox
        '
        Me.archivedFilesCheckBox.AutoSize = True
        Me.archivedFilesCheckBox.Enabled = False
        Me.archivedFilesCheckBox.ForeColor = System.Drawing.Color.White
        Me.archivedFilesCheckBox.Location = New System.Drawing.Point(495, 158)
        Me.archivedFilesCheckBox.Name = "archivedFilesCheckBox"
        Me.archivedFilesCheckBox.Size = New System.Drawing.Size(40, 17)
        Me.archivedFilesCheckBox.TabIndex = 84
        Me.archivedFilesCheckBox.Text = "Off"
        Me.archivedFilesCheckBox.UseVisualStyleBackColor = True
        '
        'archivedFilesLabel
        '
        Me.archivedFilesLabel.AutoSize = True
        Me.archivedFilesLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.archivedFilesLabel.ForeColor = System.Drawing.Color.Snow
        Me.archivedFilesLabel.Location = New System.Drawing.Point(89, 151)
        Me.archivedFilesLabel.Name = "archivedFilesLabel"
        Me.archivedFilesLabel.Size = New System.Drawing.Size(374, 27)
        Me.archivedFilesLabel.TabIndex = 83
        Me.archivedFilesLabel.Text = "Scan Within Archived Files:"
        Me.archivedFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'windowsStartCheckBox
        '
        Me.windowsStartCheckBox.AutoSize = True
        Me.windowsStartCheckBox.Checked = True
        Me.windowsStartCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.windowsStartCheckBox.ForeColor = System.Drawing.Color.White
        Me.windowsStartCheckBox.Location = New System.Drawing.Point(496, 69)
        Me.windowsStartCheckBox.Name = "windowsStartCheckBox"
        Me.windowsStartCheckBox.Size = New System.Drawing.Size(40, 17)
        Me.windowsStartCheckBox.TabIndex = 82
        Me.windowsStartCheckBox.Text = "On"
        Me.windowsStartCheckBox.UseVisualStyleBackColor = True
        '
        'windowsStartLabel
        '
        Me.windowsStartLabel.AutoSize = True
        Me.windowsStartLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.windowsStartLabel.ForeColor = System.Drawing.Color.Snow
        Me.windowsStartLabel.Location = New System.Drawing.Point(3, 63)
        Me.windowsStartLabel.Name = "windowsStartLabel"
        Me.windowsStartLabel.Size = New System.Drawing.Size(458, 27)
        Me.windowsStartLabel.TabIndex = 81
        Me.windowsStartLabel.Text = "Start Program On Windows Start:"
        Me.windowsStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'securityLabel
        '
        Me.securityLabel.AutoSize = True
        Me.securityLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.securityLabel.ForeColor = System.Drawing.Color.Snow
        Me.securityLabel.Location = New System.Drawing.Point(231, 6)
        Me.securityLabel.Name = "securityLabel"
        Me.securityLabel.Size = New System.Drawing.Size(124, 27)
        Me.securityLabel.TabIndex = 79
        Me.securityLabel.Text = "Security"
        Me.securityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'generalLabel
        '
        Me.generalLabel.AutoSize = True
        Me.generalLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generalLabel.ForeColor = System.Drawing.Color.Snow
        Me.generalLabel.Location = New System.Drawing.Point(238, 5)
        Me.generalLabel.Name = "generalLabel"
        Me.generalLabel.Size = New System.Drawing.Size(111, 27)
        Me.generalLabel.TabIndex = 78
        Me.generalLabel.Text = "General"
        '
        'allowProgramsListBox
        '
        Me.allowProgramsListBox.BackColor = System.Drawing.SystemColors.Desktop
        Me.allowProgramsListBox.ForeColor = System.Drawing.Color.White
        Me.allowProgramsListBox.FormattingEnabled = True
        Me.allowProgramsListBox.Location = New System.Drawing.Point(0, 81)
        Me.allowProgramsListBox.Name = "allowProgramsListBox"
        Me.allowProgramsListBox.Size = New System.Drawing.Size(571, 316)
        Me.allowProgramsListBox.TabIndex = 77
        '
        'removeProgramButton
        '
        Me.removeProgramButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.removeProgramButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeProgramButton.ForeColor = System.Drawing.SystemColors.Control
        Me.removeProgramButton.Location = New System.Drawing.Point(373, 4)
        Me.removeProgramButton.Name = "removeProgramButton"
        Me.removeProgramButton.Size = New System.Drawing.Size(206, 39)
        Me.removeProgramButton.TabIndex = 76
        Me.removeProgramButton.Text = "Remove Program"
        Me.removeProgramButton.UseVisualStyleBackColor = False
        Me.removeProgramButton.Visible = False
        '
        'addProgramButton
        '
        Me.addProgramButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.addProgramButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addProgramButton.ForeColor = System.Drawing.SystemColors.Control
        Me.addProgramButton.Location = New System.Drawing.Point(5, 5)
        Me.addProgramButton.Name = "addProgramButton"
        Me.addProgramButton.Size = New System.Drawing.Size(206, 40)
        Me.addProgramButton.TabIndex = 75
        Me.addProgramButton.Text = "Add Program"
        Me.addProgramButton.UseVisualStyleBackColor = False
        Me.addProgramButton.Visible = False
        '
        'allowListLabel
        '
        Me.allowListLabel.AutoSize = True
        Me.allowListLabel.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allowListLabel.ForeColor = System.Drawing.Color.Snow
        Me.allowListLabel.Location = New System.Drawing.Point(219, 7)
        Me.allowListLabel.Name = "allowListLabel"
        Me.allowListLabel.Size = New System.Drawing.Size(148, 27)
        Me.allowListLabel.TabIndex = 73
        Me.allowListLabel.Text = "Allow List"
        '
        'clearScanDateAndTimeButton
        '
        Me.clearScanDateAndTimeButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.clearScanDateAndTimeButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearScanDateAndTimeButton.ForeColor = System.Drawing.SystemColors.Control
        Me.clearScanDateAndTimeButton.Location = New System.Drawing.Point(373, 6)
        Me.clearScanDateAndTimeButton.Name = "clearScanDateAndTimeButton"
        Me.clearScanDateAndTimeButton.Size = New System.Drawing.Size(206, 39)
        Me.clearScanDateAndTimeButton.TabIndex = 71
        Me.clearScanDateAndTimeButton.Text = "Clear Scan Date"
        Me.clearScanDateAndTimeButton.UseVisualStyleBackColor = False
        Me.clearScanDateAndTimeButton.Visible = False
        '
        'scheduleDateAndTimeButton
        '
        Me.scheduleDateAndTimeButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.scheduleDateAndTimeButton.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scheduleDateAndTimeButton.ForeColor = System.Drawing.SystemColors.Control
        Me.scheduleDateAndTimeButton.Location = New System.Drawing.Point(5, 4)
        Me.scheduleDateAndTimeButton.Name = "scheduleDateAndTimeButton"
        Me.scheduleDateAndTimeButton.Size = New System.Drawing.Size(206, 39)
        Me.scheduleDateAndTimeButton.TabIndex = 70
        Me.scheduleDateAndTimeButton.Text = "Schedule Scan Date"
        Me.scheduleDateAndTimeButton.UseVisualStyleBackColor = False
        Me.scheduleDateAndTimeButton.Visible = False
        '
        'scheduleScanLabel
        '
        Me.scheduleScanLabel.AutoSize = True
        Me.scheduleScanLabel.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scheduleScanLabel.ForeColor = System.Drawing.Color.Snow
        Me.scheduleScanLabel.Location = New System.Drawing.Point(214, 9)
        Me.scheduleScanLabel.Name = "scheduleScanLabel"
        Me.scheduleScanLabel.Size = New System.Drawing.Size(159, 22)
        Me.scheduleScanLabel.TabIndex = 68
        Me.scheduleScanLabel.Text = "Schedule S can"
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
        'settingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(810, 453)
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.scheduleScanGroupBox.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.minuteUpAndDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hourUpAndDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents scheduleScanLabel As Label
    Friend WithEvents scheduleDateAndTimeButton As Button
    Friend WithEvents clearScanDateAndTimeButton As Button
    Friend WithEvents addProgramButton As Button
    Friend WithEvents allowListLabel As Label
    Friend WithEvents securityLabel As Label
    Friend WithEvents generalLabel As Label
    Friend WithEvents webProtectionCheckBox As CheckBox
    Friend WithEvents webProtectionLabel As Label
    Friend WithEvents realTimeCheckBox As CheckBox
    Friend WithEvents realTimeProtectionLabel As Label
    Friend WithEvents archivedFilesCheckBox As CheckBox
    Friend WithEvents archivedFilesLabel As Label
    Friend WithEvents windowsStartCheckBox As CheckBox
    Friend WithEvents windowsStartLabel As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents aboutProgramLabel As Label
    Friend WithEvents creditTimer As Timer
    Friend WithEvents scheduleScanGroupBox As GroupBox
    Friend WithEvents minuteUpAndDown As NumericUpDown
    Friend WithEvents hourUpAndDown As NumericUpDown
    Friend WithEvents Label29 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents fullScanRadioButton As RadioButton
    Friend WithEvents folderScanRadioButton As RadioButton
    Friend WithEvents quickScanRadioButton As RadioButton
    Friend WithEvents Label27 As Label
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents removeProgramButton As Button
    Friend WithEvents allowProgramsListBox As ListBox
    Friend WithEvents militaryLabel As Label
End Class
