Public Class Form1
    Private Sub Form1_Load(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Create_Buttons()
    End Sub

    Private Sub Set_Default_Settings()

        Dim newBtn As ButtonSettings

        newBtn = Settings.GetButton("Mozilla Firefox")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Mozilla Firefox", "C:\Program Files\FirefoxPortable\FirefoxPortable.exe", "localhost", "C:\Program Files\FirefoxPortable\", "icons\firefox-icon.png", True)
            newBtn = Settings.GetButton("Mozilla Firefox")
        End If
        Me.Create_NewButton(newBtn, 3)

        newBtn = Settings.GetButton("Google Chrome")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Google Chrome", "C:\Program Files\GoogleChromePortable\GoogleChromePortable.exe", "localhost", "C:\Program Files\GoogleChromePortable\", "icons\chrome-icon.png", True)
            newBtn = Settings.GetButton("Google Chrome")
        End If
        Me.Create_NewButton(newBtn, 4)

        newBtn = Settings.GetButton("Command Line")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Command Line", "C:\Windows\System32\cmd.exe", "", "C:\", "icons\cmd-icon.png", True)
            newBtn = Settings.GetButton("Command Line")
        End If
        Me.Create_NewButton(newBtn, 5)


        newBtn = Settings.GetButton("Powershell")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Powershell", "C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", "", "C:\", "icons\powershell-icon.png", True)
            newBtn = Settings.GetButton("Powershell")
        End If
        Me.Create_NewButton(newBtn, 6)

        newBtn = Settings.GetButton("A43 File Explorer")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("A43 File Explorer", "C:\Program Files (x86)\A43\A43.exe", "", "C:\", "icons\explorer-icon.png", True)
            newBtn = Settings.GetButton("A43 File Explorer")
        End If
        Me.Create_NewButton(newBtn, 7)

        newBtn = Settings.GetButton("Task Manager")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Task Manager", "C:\Windows\System32\Taskmgr.exe", "", "C:\Windows\System32\", "icons\task-manager-icon.png", True)
            newBtn = Settings.GetButton("Task Manager")
        End If
        Me.Create_NewButton(newBtn, 8)

        newBtn = Settings.GetButton("Registry Editor")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Registry Editor", "C:\Windows\System32\regedt32.exe", "", "C:\Windows\System32\", "icons\regedit-icon.png", True)
            newBtn = Settings.GetButton("Registry Editor")
        End If
        Me.Create_NewButton(newBtn, 9)

    End Sub
    Private Sub Create_Buttons()

        Dim newBtn As ButtonSettings

        newBtn = Settings.GetButton("Mozilla Firefox")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Mozilla Firefox", "C:\Program Files\FirefoxPortable\FirefoxPortable.exe", "localhost", "C:\Program Files\FirefoxPortable\", "icons\firefox-icon.png", True)
            newBtn = Settings.GetButton("Mozilla Firefox")
        End If
        Me.Create_NewButton(newBtn, 3)

        newBtn = Settings.GetButton("Google Chrome")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Google Chrome", "C:\Program Files\GoogleChromePortable\GoogleChromePortable.exe", "localhost", "C:\Program Files\GoogleChromePortable\", "icons\chrome-icon.png", True)
            newBtn = Settings.GetButton("Google Chrome")
        End If
        Me.Create_NewButton(newBtn, 4)

        newBtn = Settings.GetButton("Command Line")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Command Line", "C:\Windows\System32\cmd.exe", "", "C:\", "icons\cmd-icon.png", True)
            newBtn = Settings.GetButton("Command Line")
        End If
        Me.Create_NewButton(newBtn, 5)


        newBtn = Settings.GetButton("Powershell")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Powershell", "C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", "", "C:\", "icons\powershell-icon.png", True)
            newBtn = Settings.GetButton("Powershell")
        End If
        Me.Create_NewButton(newBtn, 6)

        newBtn = Settings.GetButton("A43 File Explorer")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("A43 File Explorer", "C:\Program Files (x86)\A43\A43.exe", "", "C:\", "icons\explorer-icon.png", True)
            newBtn = Settings.GetButton("A43 File Explorer")
        End If
        Me.Create_NewButton(newBtn, 7)

        newBtn = Settings.GetButton("Task Manager")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Task Manager", "C:\Windows\System32\Taskmgr.exe", "", "C:\Windows\System32\", "icons\task-manager-icon.png", True)
            newBtn = Settings.GetButton("Task Manager")
        End If
        Me.Create_NewButton(newBtn, 8)

        newBtn = Settings.GetButton("Registry Editor")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Registry Editor", "C:\Windows\System32\regedt32.exe", "", "C:\Windows\System32\", "icons\regedit-icon.png", True)
            newBtn = Settings.GetButton("Registry Editor")
        End If
        Me.Create_NewButton(newBtn, 9)

    End Sub
    Private Sub Create_NewButton(btn As ButtonSettings, num As Integer)

        Dim btnImage As Image = Nothing
        If My.Computer.FileSystem.FileExists(btn.Icon) Then
            btnImage = Image.FromFile(btn.Icon)
        End If

        Dim btnPos As Integer = ((num - 1) * 36)

        Dim newBtn As New Button
        With newBtn
            .SetBounds(0, btnPos, 36, 36)
            .Tag = btn.Name
            .Image = btnImage
        End With

        Me.ButtonToolTip.SetToolTip(newBtn, btn.Name)

        AddHandler newBtn.Click, AddressOf ButtonHandler
        Me.Controls.Add(newBtn)
    End Sub
    Private Sub ButtonHandler(sender As Object, e As EventArgs)
        Dim btn As Button = sender
        Dim newBtn As ButtonSettings = Settings.GetButton(btn.Tag)
        If System.IO.File.Exists(newBtn.Exec) Then
            Dim startInfo As New ProcessStartInfo
            startInfo.FileName = newBtn.Exec
            startInfo.Arguments = newBtn.Args
            startInfo.UseShellExecute = True
            startInfo.WorkingDirectory = newBtn.Path
            Process.Start(startInfo)
        Else
            MsgBox(newBtn.Exec & " does not exist.!. Change Path in " & Application.ExecutablePath & ".Settings.xml")
        End If
    End Sub

    Private Sub AllwaysOnTopTimer_Tick(sender As Object, e As EventArgs) Handles AllwaysOnTopTimer.Tick
        Me.TopMost = True
    End Sub

    Private Sub Set_Default_Settings()

        Dim nameStr As String = Settings.GetSetting("Icon1_Name")
        If nameStr.Trim.Length <= 0 Then
            Settings.SetSetting("Icon1_Name", "MyCustomIcon")
        End If

        Dim execStr As String = Settings.GetSetting("Icon1_Exec")
        If execStr.Trim.Length <= 0 Then
            Settings.SetSetting("Icon1_Exec", "C:\Windows\System32\cmd.exe")
        End If

        Dim argsStr As String = Settings.GetSetting("Icon1_Args")
        If argsStr.Trim.Length <= 0 Then
            Settings.SetSetting("Icon1_Args", "echo Hello World")
        End If

        Dim pathStr As String = Settings.GetSetting("Icon1_Path")
        If pathStr.Trim.Length <= 0 Then
            Settings.SetSetting("Icon1_Path", "C:\")
        End If

        Dim iconStr As String = Settings.GetSetting("Icon1_Icon")
        If iconStr.Trim.Length <= 0 Then
            Settings.SetSetting("Icon1_Icon", "C:\Projects\CoreLauncher\CoreLauncher\My Project\cmd-icon.png")
        End If

        'Me.ButtonSettings.Tag = "Icon1"
        'Dim tstStr As String = Settings.GetSetting("Icon1_Icon")
        'Me.ButtonSettings.Image = Image.FromFile("C:\Projects\CoreLauncher\CoreLauncher\My Project\cmd-icon.png")
        'AddHandler ButtonSettings.Click, AddressOf Custom_Click

        Me.Create_Button(1)

    End Sub
    Private Sub Create_Button(num As Integer)

        Dim numStr As String = num.ToString
        Dim btnTag As String = "Icon" & numStr

        Dim btnName As String = Settings.GetSetting(btnTag & "_Name")
        If btnName.Trim.Length <= 0 Then
            btnName = btnTag
        End If

        Dim btnIcon As String = Settings.GetSetting(btnTag & "_Icon")
        Dim btnImage As Image = Nothing
        If My.Computer.FileSystem.FileExists(btnIcon) Then
            btnImage = Image.FromFile(btnIcon)
        End If

        Dim btnPos As Integer = ((num - 1) * 36)

        Dim newBtn As New Button
        With newBtn
            .SetBounds(0, btnPos, 36, 36)
            .Tag = btnTag
            .Image = btnImage
        End With

        Me.ButtonToolTip.SetToolTip(newBtn, btnName)

        AddHandler newBtn.Click, AddressOf Custom_Click
        Me.Controls.Add(newBtn)
    End Sub
    Private Sub Custom_Click(sender As Object, e As EventArgs)
        Dim btn As Button = sender
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = Settings.GetSetting(btn.Tag & "_Exec")
        startInfo.Arguments = Settings.GetSetting(btn.Tag & "_Args")
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = Settings.GetSetting(btn.Tag & "_Path")
        Process.Start(startInfo)
    End Sub

    Private Sub ButtonFirefox_Click(sender As Object, e As EventArgs) Handles Button_Firefox.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Program Files\FirefoxPortable\FirefoxPortable.exe"
        startInfo.Arguments = "localhost"
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\Program Files\FirefoxPortable\"
        Process.Start(startInfo)
    End Sub
    Private Sub ButtonChrome_Click(sender As Object, e As EventArgs) Handles Button_Chrome.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Program Files\GoogleChromePortable\GoogleChromePortable.exe"
        startInfo.Arguments = "localhost"
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\Program Files\GoogleChromePortable\"
        Process.Start(startInfo)
    End Sub
    Private Sub ButtonCMD_Click(sender As Object, e As EventArgs) Handles Button_CMD.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Windows\System32\cmd.exe"
        startInfo.Arguments = ""
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\"
        Process.Start(startInfo)
    End Sub
    Private Sub ButtonPowershell_Click(sender As Object, e As EventArgs) Handles Button_Powershell.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe"
        startInfo.Arguments = ""
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\"
        Process.Start(startInfo)
    End Sub
    Private Sub ButtonFileExplorer_Click(sender As Object, e As EventArgs) Handles Button_FileExplorer.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Program Files (x86)\A43\A43.exe"
        startInfo.Arguments = ""
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\"
        Process.Start(startInfo)
    End Sub
    Private Sub ButtonTaskmgr_Click(sender As Object, e As EventArgs) Handles Button_Taskmgr.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Windows\System32\Taskmgr.exe"
        startInfo.Arguments = ""
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\Windows\System32\"
        Process.Start(startInfo)
    End Sub
    Private Sub ButtonRegedit_Click(sender As Object, e As EventArgs) Handles Button_Regedit.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Windows\System32\regedt32.exe"
        startInfo.Arguments = ""
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\Windows\System32\"
        Process.Start(startInfo)
    End Sub

    Private Sub ButtonLogoff_Click(sender As Object, e As EventArgs) Handles Button_Logoff.Click
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        response = MsgBox("Do you want to Logout now?", style, "Logoff")
        If response = MsgBoxResult.Yes Then
            Dim startInfo As New ProcessStartInfo
            startInfo.FileName = "C:\Windows\System32\logoff.exe"
            startInfo.Arguments = ""
            startInfo.UseShellExecute = True
            startInfo.WorkingDirectory = "C:\Windows\System32\"
            startInfo.CreateNoWindow = True
            Process.Start(startInfo)
        End If
    End Sub
    Private Sub ButtonReboot_Click(sender As Object, e As EventArgs) Handles Button_Reboot.Click
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        response = MsgBox("Do you want to restart the Computer?", style, "Reboot")
        If response = MsgBoxResult.Yes Then
            Dim startInfo As New ProcessStartInfo
            startInfo.FileName = "C:\Windows\System32\shutdown.exe"
            startInfo.Arguments = "-r -t 5"
            startInfo.UseShellExecute = True
            startInfo.WorkingDirectory = "C:\Windows\System32\"
            startInfo.CreateNoWindow = True
            Process.Start(startInfo)
        End If
    End Sub

End Class
