<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonSettings = New System.Windows.Forms.Button()
        Me.ButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonFirefox = New System.Windows.Forms.Button()
        Me.ButtonCMD = New System.Windows.Forms.Button()
        Me.ButtonPowershell = New System.Windows.Forms.Button()
        Me.ButtonFileExplorer = New System.Windows.Forms.Button()
        Me.ButtonCustom = New System.Windows.Forms.Button()
        Me.ButtonReboot = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'ButtonSettings
        '
        Me.ButtonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonSettings.Image = CType(resources.GetObject("ButtonSettings.Image"), System.Drawing.Image)
        Me.ButtonSettings.Location = New System.Drawing.Point(0, 0)
        Me.ButtonSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(36, 36)
        Me.ButtonSettings.TabIndex = 0
        Me.ButtonSettings.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.ButtonSettings, "Settings")
        Me.ButtonSettings.UseVisualStyleBackColor = False
        '
        'ButtonToolTip
        '
        Me.ButtonToolTip.AutomaticDelay = 10
        Me.ButtonToolTip.AutoPopDelay = 0
        Me.ButtonToolTip.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonToolTip.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ButtonToolTip.InitialDelay = 10
        Me.ButtonToolTip.ReshowDelay = 0
        Me.ButtonToolTip.ShowAlways = True
        Me.ButtonToolTip.UseAnimation = False
        Me.ButtonToolTip.UseFading = False
        '
        'ButtonFirefox
        '
        Me.ButtonFirefox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonFirefox.Image = CType(resources.GetObject("ButtonFirefox.Image"), System.Drawing.Image)
        Me.ButtonFirefox.Location = New System.Drawing.Point(0, 36)
        Me.ButtonFirefox.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonFirefox.Name = "ButtonFirefox"
        Me.ButtonFirefox.Size = New System.Drawing.Size(36, 36)
        Me.ButtonFirefox.TabIndex = 1
        Me.ButtonFirefox.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.ButtonFirefox, "Firefox")
        Me.ButtonFirefox.UseVisualStyleBackColor = True
        '
        'ButtonCMD
        '
        Me.ButtonCMD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonCMD.Image = CType(resources.GetObject("ButtonCMD.Image"), System.Drawing.Image)
        Me.ButtonCMD.Location = New System.Drawing.Point(0, 72)
        Me.ButtonCMD.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonCMD.Name = "ButtonCMD"
        Me.ButtonCMD.Size = New System.Drawing.Size(36, 36)
        Me.ButtonCMD.TabIndex = 2
        Me.ButtonCMD.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.ButtonCMD, "Command Line")
        Me.ButtonCMD.UseVisualStyleBackColor = False
        '
        'ButtonPowershell
        '
        Me.ButtonPowershell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonPowershell.Image = CType(resources.GetObject("ButtonPowershell.Image"), System.Drawing.Image)
        Me.ButtonPowershell.Location = New System.Drawing.Point(0, 108)
        Me.ButtonPowershell.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPowershell.Name = "ButtonPowershell"
        Me.ButtonPowershell.Size = New System.Drawing.Size(36, 36)
        Me.ButtonPowershell.TabIndex = 3
        Me.ButtonPowershell.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.ButtonPowershell, "Powershell")
        Me.ButtonPowershell.UseVisualStyleBackColor = False
        '
        'ButtonFileExplorer
        '
        Me.ButtonFileExplorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonFileExplorer.Image = CType(resources.GetObject("ButtonFileExplorer.Image"), System.Drawing.Image)
        Me.ButtonFileExplorer.Location = New System.Drawing.Point(0, 144)
        Me.ButtonFileExplorer.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonFileExplorer.Name = "ButtonFileExplorer"
        Me.ButtonFileExplorer.Size = New System.Drawing.Size(36, 36)
        Me.ButtonFileExplorer.TabIndex = 4
        Me.ButtonFileExplorer.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.ButtonFileExplorer, "A43 File Explorer")
        Me.ButtonFileExplorer.UseVisualStyleBackColor = False
        '
        'ButtonCustom
        '
        Me.ButtonCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonCustom.Image = CType(resources.GetObject("ButtonCustom.Image"), System.Drawing.Image)
        Me.ButtonCustom.Location = New System.Drawing.Point(0, 180)
        Me.ButtonCustom.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonCustom.Name = "ButtonCustom"
        Me.ButtonCustom.Size = New System.Drawing.Size(36, 36)
        Me.ButtonCustom.TabIndex = 5
        Me.ButtonCustom.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.ButtonCustom, "Custom")
        Me.ButtonCustom.UseVisualStyleBackColor = False
        '
        'ButtonReboot
        '
        Me.ButtonReboot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonReboot.Image = CType(resources.GetObject("ButtonReboot.Image"), System.Drawing.Image)
        Me.ButtonReboot.Location = New System.Drawing.Point(0, 216)
        Me.ButtonReboot.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonReboot.Name = "ButtonReboot"
        Me.ButtonReboot.Size = New System.Drawing.Size(36, 36)
        Me.ButtonReboot.TabIndex = 6
        Me.ButtonReboot.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.ButtonReboot, "Reboot")
        Me.ButtonReboot.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(36, 252)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonReboot)
        Me.Controls.Add(Me.ButtonCustom)
        Me.Controls.Add(Me.ButtonFileExplorer)
        Me.Controls.Add(Me.ButtonPowershell)
        Me.Controls.Add(Me.ButtonCMD)
        Me.Controls.Add(Me.ButtonFirefox)
        Me.Controls.Add(Me.ButtonSettings)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(36, 256)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(36, 252)
        Me.Name = "Form1"
        Me.Opacity = 0.6R
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonSettings As Button
    Friend WithEvents ButtonToolTip As ToolTip
    Friend WithEvents ButtonFirefox As Button
    Friend WithEvents ButtonCMD As Button
    Friend WithEvents ButtonPowershell As Button
    Friend WithEvents ButtonFileExplorer As Button
    Friend WithEvents ButtonCustom As Button
    Friend WithEvents ButtonReboot As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
