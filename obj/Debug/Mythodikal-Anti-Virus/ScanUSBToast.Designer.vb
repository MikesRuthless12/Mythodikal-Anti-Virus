<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanUSBToast
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
        Me.scanUSBLabel = New System.Windows.Forms.Label()
        Me.exitPicBox = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.scanUSBDriveButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.exitPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'scanUSBLabel
        '
        Me.scanUSBLabel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scanUSBLabel.ForeColor = System.Drawing.Color.Snow
        Me.scanUSBLabel.Location = New System.Drawing.Point(37, 9)
        Me.scanUSBLabel.Name = "scanUSBLabel"
        Me.scanUSBLabel.Size = New System.Drawing.Size(345, 41)
        Me.scanUSBLabel.TabIndex = 70
        Me.scanUSBLabel.Text = "Would You Like To Scan The Newly Plugged In Device?  Device Name: "
        '
        'exitPicBox
        '
        Me.exitPicBox.BackColor = System.Drawing.SystemColors.Highlight
        Me.exitPicBox.Image = Global.MikesAntiVirusScanner.My.Resources.Resources.closeIcon
        Me.exitPicBox.Location = New System.Drawing.Point(388, 0)
        Me.exitPicBox.Name = "exitPicBox"
        Me.exitPicBox.Size = New System.Drawing.Size(52, 50)
        Me.exitPicBox.TabIndex = 71
        Me.exitPicBox.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'scanUSBDriveButton
        '
        Me.scanUSBDriveButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.scanUSBDriveButton.Font = New System.Drawing.Font("Snap ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scanUSBDriveButton.ForeColor = System.Drawing.Color.White
        Me.scanUSBDriveButton.Location = New System.Drawing.Point(15, 56)
        Me.scanUSBDriveButton.Name = "scanUSBDriveButton"
        Me.scanUSBDriveButton.Size = New System.Drawing.Size(412, 36)
        Me.scanUSBDriveButton.TabIndex = 72
        Me.scanUSBDriveButton.Text = "Scan Newly Plugged In USB Device"
        Me.scanUSBDriveButton.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(41, 116)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 73
        '
        'ScanUSBToast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(439, 105)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.scanUSBDriveButton)
        Me.Controls.Add(Me.exitPicBox)
        Me.Controls.Add(Me.scanUSBLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScanUSBToast"
        Me.Opacity = 0R
        Me.Text = "ScanUSBToast"
        CType(Me.exitPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents scanUSBLabel As Label
    Friend WithEvents exitPicBox As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents scanUSBDriveButton As Button
    Friend WithEvents TextBox1 As TextBox
End Class
