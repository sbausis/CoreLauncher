Public Class CoreLauncher
    Private Sub CoreLauncher_Load(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Set_Default_Settings()
        Me.Create_Buttons()
    End Sub

    Private Sub Set_Default_Settings()

        Dim newBtn As ButtonSettings

        newBtn = Settings.GetButton("Logout")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Logout", "C:\Windows\System32\logoff.exe", "", "C:\Windows\System32\", "icons\logoff-icon.png", "Logout", "Do you want to Logout now?", True)
        End If

        newBtn = Settings.GetButton("Reboot")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Reboot", "C:\Windows\System32\shutdown.exe", "-r -t 5", "C:\Windows\System32\", "icons\reboot-icon.png", "Reboot", "Do you want to restart the Computer?", True)
        End If

        newBtn = Settings.GetButton("Mozilla Firefox")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Mozilla Firefox", "C:\Program Files\FirefoxPortable\FirefoxPortable.exe", "localhost", "C:\Program Files\FirefoxPortable\", "icons\firefox-icon.png", "", "", True)
        End If

        newBtn = Settings.GetButton("Google Chrome")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Google Chrome", "C:\Program Files\GoogleChromePortable\GoogleChromePortable.exe", "localhost", "C:\Program Files\GoogleChromePortable\", "icons\chrome-icon.png", "", "", True)
        End If

        newBtn = Settings.GetButton("Command Line")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Command Line", "C:\Windows\System32\cmd.exe", "", "C:\", "icons\cmd-icon.png", "", "", True)
        End If

        newBtn = Settings.GetButton("Powershell")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Powershell", "C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", "", "C:\", "icons\powershell-icon.png", "", "", True)
        End If

        newBtn = Settings.GetButton("A43 File Explorer")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("A43 File Explorer", "C:\Program Files (x86)\A43\A43.exe", "", "C:\", "icons\explorer-icon.png", "", "", True)
        End If

        newBtn = Settings.GetButton("Task Manager")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Task Manager", "C:\Windows\System32\Taskmgr.exe", "", "C:\Windows\System32\", "icons\task-manager-icon.png", "", "", True)
        End If

        newBtn = Settings.GetButton("Registry Editor")
        If newBtn.Name.Length <= 0 Then
            Settings.SetButtonSettings("Registry Editor", "C:\Windows\System32\regedt32.exe", "", "C:\Windows\System32\", "icons\regedit-icon.png", "", "", True)
        End If

    End Sub
    Private Sub Create_Buttons()

        Dim buttonCnt As Integer = 1

        Dim dsSettings As New DataSet
        If System.IO.File.Exists(Application.ExecutablePath & ".Settings.xml") Then
            dsSettings.ReadXml(Application.ExecutablePath & ".Settings.xml")

            Dim drc As DataRowCollection = dsSettings.Tables("ButtonSettings").Rows
            For index As Integer = 1 To drc.Count

                Dim dr As DataRow = drc.Item(index - 1)
                If Boolean.TryParse(dr("Enabled"), False) Then

                    Dim newBtn As ButtonSettings = Settings.GetButton(dr("Name"))
                    If newBtn.Name.Length > 0 Then
                        Debug.Write("add Icon for " & dr("Name"))
                        Me.Create_NewButton(newBtn, (buttonCnt + 1))
                        buttonCnt += 1
                    End If

                End If

            Next

        End If

        Me.SetDesktopBounds(0, 0, 36, (buttonCnt * 36))

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

        If btn.ConfirmText.Length <= 0 Then
            AddHandler newBtn.Click, AddressOf ButtonHandler
        Else
            AddHandler newBtn.Click, AddressOf ButtonHandlerConfirm
        End If

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
            MsgBox(newBtn.Exec & " does Not exist.!. Change Path In " & Application.ExecutablePath & ".Settings.xml")
        End If
    End Sub
    Private Sub ButtonHandlerConfirm(sender As Object, e As EventArgs)
        Dim btn As Button = sender
        Dim newBtn As ButtonSettings = Settings.GetButton(btn.Tag)
        If System.IO.File.Exists(newBtn.Exec) Then
            Dim boxstyle As MsgBoxStyle
            Dim boxresponse As MsgBoxResult
            boxstyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            boxresponse = MsgBox(newBtn.ConfirmText, boxstyle, newBtn.ConfirmTitle)
            If boxresponse = MsgBoxResult.Yes Then
                Dim startInfo As New ProcessStartInfo
                startInfo.FileName = newBtn.Exec
                startInfo.Arguments = newBtn.Args
                startInfo.UseShellExecute = True
                startInfo.WorkingDirectory = newBtn.Path
                Process.Start(startInfo)
            End If
        Else
            MsgBox(newBtn.Exec & " does Not exist.!. Change Path In " & Application.ExecutablePath & ".Settings.xml")
        End If
    End Sub

    Private Sub AllwaysOnTopTimer_Tick(sender As Object, e As EventArgs) Handles AllwaysOnTopTimer.Tick
        If CoreLauncherSettings.Visible Then
            CoreLauncherSettings.TopMost = True
        Else
            Me.TopMost = True
        End If
    End Sub

    Private Sub Button_Settings_Click(sender As Object, e As EventArgs) Handles Button_Settings.Click
        If CoreLauncherSettings.Visible Then
            CoreLauncherSettings.Close()
        Else
            CoreLauncherSettings.Show()
        End If
    End Sub

End Class
