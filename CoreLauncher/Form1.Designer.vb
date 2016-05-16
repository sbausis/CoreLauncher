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
        Me.Button_Settings = New System.Windows.Forms.Button()
        Me.ButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_Firefox = New System.Windows.Forms.Button()
        Me.Button_CMD = New System.Windows.Forms.Button()
        Me.Button_Powershell = New System.Windows.Forms.Button()
        Me.Button_FileExplorer = New System.Windows.Forms.Button()
        Me.Button_Taskmgr = New System.Windows.Forms.Button()
        Me.Button_Reboot = New System.Windows.Forms.Button()
        Me.Button_Chrome = New System.Windows.Forms.Button()
        Me.Button_Regedit = New System.Windows.Forms.Button()
        Me.Button_Logoff = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.AllwaysOnTopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button_Settings
        '
        Me.Button_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Settings.Enabled = False
        Me.Button_Settings.Image = CType(resources.GetObject("Button_Settings.Image"), System.Drawing.Image)
        Me.Button_Settings.Location = New System.Drawing.Point(0, 72)
        Me.Button_Settings.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Settings.Name = "Button_Settings"
        Me.Button_Settings.Size = New System.Drawing.Size(36, 36)
        Me.Button_Settings.TabIndex = 0
        Me.Button_Settings.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.Button_Settings, "Settings")
        Me.Button_Settings.UseVisualStyleBackColor = False
        Me.Button_Settings.Visible = False
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
        'Button_Firefox
        '
        Me.Button_Firefox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Firefox.Enabled = False
        Me.Button_Firefox.Image = CType(resources.GetObject("Button_Firefox.Image"), System.Drawing.Image)
        Me.Button_Firefox.Location = New System.Drawing.Point(0, 108)
        Me.Button_Firefox.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Firefox.Name = "Button_Firefox"
        Me.Button_Firefox.Size = New System.Drawing.Size(36, 36)
        Me.Button_Firefox.TabIndex = 1
        Me.Button_Firefox.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.Button_Firefox, "Firefox")
        Me.Button_Firefox.UseVisualStyleBackColor = True
        Me.Button_Firefox.Visible = False
        '
        'Button_CMD
        '
        Me.Button_CMD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_CMD.Enabled = False
        Me.Button_CMD.Image = CType(resources.GetObject("Button_CMD.Image"), System.Drawing.Image)
        Me.Button_CMD.Location = New System.Drawing.Point(0, 180)
        Me.Button_CMD.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_CMD.Name = "Button_CMD"
        Me.Button_CMD.Size = New System.Drawing.Size(36, 36)
        Me.Button_CMD.TabIndex = 3
        Me.Button_CMD.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.Button_CMD, "Command Line")
        Me.Button_CMD.UseVisualStyleBackColor = False
        Me.Button_CMD.Visible = False
        '
        'Button_Powershell
        '
        Me.Button_Powershell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Powershell.Enabled = False
        Me.Button_Powershell.Image = CType(resources.GetObject("Button_Powershell.Image"), System.Drawing.Image)
        Me.Button_Powershell.Location = New System.Drawing.Point(0, 216)
        Me.Button_Powershell.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Powershell.Name = "Button_Powershell"
        Me.Button_Powershell.Size = New System.Drawing.Size(36, 36)
        Me.Button_Powershell.TabIndex = 4
        Me.Button_Powershell.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.Button_Powershell, "Powershell")
        Me.Button_Powershell.UseVisualStyleBackColor = False
        Me.Button_Powershell.Visible = False
        '
        'Button_FileExplorer
        '
        Me.Button_FileExplorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_FileExplorer.Enabled = False
        Me.Button_FileExplorer.Image = CType(resources.GetObject("Button_FileExplorer.Image"), System.Drawing.Image)
        Me.Button_FileExplorer.Location = New System.Drawing.Point(0, 252)
        Me.Button_FileExplorer.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_FileExplorer.Name = "Button_FileExplorer"
        Me.Button_FileExplorer.Size = New System.Drawing.Size(36, 36)
        Me.Button_FileExplorer.TabIndex = 5
        Me.Button_FileExplorer.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.Button_FileExplorer, "A43 File Explorer")
        Me.Button_FileExplorer.UseVisualStyleBackColor = False
        Me.Button_FileExplorer.Visible = False
        '
        'Button_Taskmgr
        '
        Me.Button_Taskmgr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Taskmgr.Enabled = False
        Me.Button_Taskmgr.Image = CType(resources.GetObject("Button_Taskmgr.Image"), System.Drawing.Image)
        Me.Button_Taskmgr.Location = New System.Drawing.Point(0, 288)
        Me.Button_Taskmgr.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Taskmgr.Name = "Button_Taskmgr"
        Me.Button_Taskmgr.Size = New System.Drawing.Size(36, 36)
        Me.Button_Taskmgr.TabIndex = 6
        Me.Button_Taskmgr.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.Button_Taskmgr, "Task Manager")
        Me.Button_Taskmgr.UseVisualStyleBackColor = False
        Me.Button_Taskmgr.Visible = False
        '
        'Button_Reboot
        '
        Me.Button_Reboot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Reboot.Image = CType(resources.GetObject("Button_Reboot.Image"), System.Drawing.Image)
        Me.Button_Reboot.Location = New System.Drawing.Point(0, 36)
        Me.Button_Reboot.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Reboot.Name = "Button_Reboot"
        Me.Button_Reboot.Size = New System.Drawing.Size(36, 36)
        Me.Button_Reboot.TabIndex = 1
        Me.Button_Reboot.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.Button_Reboot, "Reboot")
        Me.Button_Reboot.UseVisualStyleBackColor = False
        '
        'Button_Chrome
        '
        Me.Button_Chrome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Chrome.Enabled = False
        Me.Button_Chrome.Image = CType(resources.GetObject("Button_Chrome.Image"), System.Drawing.Image)
        Me.Button_Chrome.Location = New System.Drawing.Point(0, 144)
        Me.Button_Chrome.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Chrome.Name = "Button_Chrome"
        Me.Button_Chrome.Size = New System.Drawing.Size(36, 36)
        Me.Button_Chrome.TabIndex = 2
        Me.Button_Chrome.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.Button_Chrome, "Chrome")
        Me.Button_Chrome.UseVisualStyleBackColor = False
        Me.Button_Chrome.Visible = False
        '
        'Button_Regedit
        '
        Me.Button_Regedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Regedit.Enabled = False
        Me.Button_Regedit.Image = CType(resources.GetObject("Button_Regedit.Image"), System.Drawing.Image)
        Me.Button_Regedit.Location = New System.Drawing.Point(0, 324)
        Me.Button_Regedit.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Regedit.Name = "Button_Regedit"
        Me.Button_Regedit.Size = New System.Drawing.Size(36, 36)
        Me.Button_Regedit.TabIndex = 7
        Me.Button_Regedit.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.Button_Regedit, "Regedit")
        Me.Button_Regedit.UseVisualStyleBackColor = False
        Me.Button_Regedit.Visible = False
        '
        'Button_Logoff
        '
        Me.Button_Logoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Logoff.Image = CType(resources.GetObject("Button_Logoff.Image"), System.Drawing.Image)
        Me.Button_Logoff.Location = New System.Drawing.Point(0, 0)
        Me.Button_Logoff.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Logoff.Name = "Button_Logoff"
        Me.Button_Logoff.Size = New System.Drawing.Size(36, 36)
        Me.Button_Logoff.TabIndex = 0
        Me.Button_Logoff.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.Button_Logoff, "Logoff")
        Me.Button_Logoff.UseVisualStyleBackColor = False
        '
        'AllwaysOnTopTimer
        '
        Me.AllwaysOnTopTimer.Enabled = True
        Me.AllwaysOnTopTimer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(36, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Logoff)
        Me.Controls.Add(Me.Button_Regedit)
        Me.Controls.Add(Me.Button_Chrome)
        Me.Controls.Add(Me.Button_Reboot)
        Me.Controls.Add(Me.Button_Taskmgr)
        Me.Controls.Add(Me.Button_FileExplorer)
        Me.Controls.Add(Me.Button_Powershell)
        Me.Controls.Add(Me.Button_CMD)
        Me.Controls.Add(Me.Button_Firefox)
        Me.Controls.Add(Me.Button_Settings)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(36, 360)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(36, 360)
        Me.Name = "Form1"
        Me.Opacity = 0.6R
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Settings As Button
    Friend WithEvents ButtonToolTip As ToolTip
    Friend WithEvents Button_Firefox As Button
    Friend WithEvents Button_CMD As Button
    Friend WithEvents Button_Powershell As Button
    Friend WithEvents Button_FileExplorer As Button
    Friend WithEvents Button_Taskmgr As Button
    Friend WithEvents Button_Reboot As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button_Chrome As Button
    Friend WithEvents Button_Regedit As Button
    Friend WithEvents Button_Logoff As Button
    Friend WithEvents AllwaysOnTopTimer As Timer
End Class
