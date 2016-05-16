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
        Me.Button_Reboot = New System.Windows.Forms.Button()
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
        Me.ClientSize = New System.Drawing.Size(36, 72)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Logoff)
        Me.Controls.Add(Me.Button_Reboot)
        Me.Controls.Add(Me.Button_Settings)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(36, 72)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(36, 72)
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
    Friend WithEvents Button_Reboot As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button_Logoff As Button
    Friend WithEvents AllwaysOnTopTimer As Timer
End Class
