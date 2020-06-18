<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scanNowQuestionToast
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scanNowQuestionToast))
        Me.quickScanButton = New System.Windows.Forms.Button()
        Me.scanCPULabel = New System.Windows.Forms.Label()
        Me.exitPicBox = New System.Windows.Forms.PictureBox()
        Me.fullScanButton = New System.Windows.Forms.Button()
        Me.exitTimer = New System.Windows.Forms.Timer(Me.components)
        Me.loadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.secondsBGW = New System.ComponentModel.BackgroundWorker()
        CType(Me.exitPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'quickScanButton
        '
        Me.quickScanButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.quickScanButton.Font = New System.Drawing.Font("Snap ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quickScanButton.ForeColor = System.Drawing.Color.White
        Me.quickScanButton.Location = New System.Drawing.Point(2, 56)
        Me.quickScanButton.Name = "quickScanButton"
        Me.quickScanButton.Size = New System.Drawing.Size(175, 36)
        Me.quickScanButton.TabIndex = 75
        Me.quickScanButton.Text = "Start Quick Scan"
        Me.quickScanButton.UseVisualStyleBackColor = False
        '
        'scanCPULabel
        '
        Me.scanCPULabel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scanCPULabel.ForeColor = System.Drawing.Color.Snow
        Me.scanCPULabel.Location = New System.Drawing.Point(2, 9)
        Me.scanCPULabel.Name = "scanCPULabel"
        Me.scanCPULabel.Size = New System.Drawing.Size(356, 41)
        Me.scanCPULabel.TabIndex = 73
        Me.scanCPULabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitPicBox
        '
        Me.exitPicBox.BackColor = System.Drawing.Color.DodgerBlue
        Me.exitPicBox.Image = Global.MikesAntiVirusScanner.My.Resources.Resources.closeIcon
        Me.exitPicBox.Location = New System.Drawing.Point(364, 0)
        Me.exitPicBox.Name = "exitPicBox"
        Me.exitPicBox.Size = New System.Drawing.Size(52, 50)
        Me.exitPicBox.TabIndex = 74
        Me.exitPicBox.TabStop = False
        '
        'fullScanButton
        '
        Me.fullScanButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.fullScanButton.Font = New System.Drawing.Font("Snap ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullScanButton.ForeColor = System.Drawing.Color.White
        Me.fullScanButton.Location = New System.Drawing.Point(239, 56)
        Me.fullScanButton.Name = "fullScanButton"
        Me.fullScanButton.Size = New System.Drawing.Size(175, 36)
        Me.fullScanButton.TabIndex = 76
        Me.fullScanButton.Text = "Start Full Scan"
        Me.fullScanButton.UseVisualStyleBackColor = False
        '
        'exitTimer
        '
        Me.exitTimer.Enabled = True
        Me.exitTimer.Interval = 1000
        '
        'loadTimer
        '
        '
        'secondsBGW
        '
        '
        'scanNowQuestionToast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(419, 96)
        Me.Controls.Add(Me.fullScanButton)
        Me.Controls.Add(Me.quickScanButton)
        Me.Controls.Add(Me.exitPicBox)
        Me.Controls.Add(Me.scanCPULabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "scanNowQuestionToast"
        CType(Me.exitPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents quickScanButton As Button
    Friend WithEvents exitPicBox As PictureBox
    Friend WithEvents scanCPULabel As Label
    Friend WithEvents fullScanButton As Button
    Friend WithEvents exitTimer As Timer
    Friend WithEvents loadTimer As Timer
    Friend WithEvents secondsBGW As System.ComponentModel.BackgroundWorker
End Class
