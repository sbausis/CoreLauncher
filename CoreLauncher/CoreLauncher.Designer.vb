<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CoreLauncher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoreLauncher))
        Me.Button_Settings = New System.Windows.Forms.Button()
        Me.ButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.AllwaysOnTopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button_Settings
        '
        Me.Button_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Settings.Image = CType(resources.GetObject("Button_Settings.Image"), System.Drawing.Image)
        Me.Button_Settings.Location = New System.Drawing.Point(0, 0)
        Me.Button_Settings.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Settings.Name = "Button_Settings"
        Me.Button_Settings.Size = New System.Drawing.Size(36, 36)
        Me.Button_Settings.TabIndex = 0
        Me.Button_Settings.Tag = ""
        Me.ButtonToolTip.SetToolTip(Me.Button_Settings, "Settings")
        Me.Button_Settings.UseVisualStyleBackColor = False
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
        Me.ClientSize = New System.Drawing.Size(36, 36)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Settings)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(36, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(36, 36)
        Me.Name = "CoreLauncher"
        Me.Opacity = 0.6R
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Settings As Button
    Friend WithEvents ButtonToolTip As ToolTip
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents AllwaysOnTopTimer As Timer
End Class
