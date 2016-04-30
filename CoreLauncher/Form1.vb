Public Class Form1
    Private Sub ButtonFirefox_Click(sender As Object, e As EventArgs) Handles ButtonFirefox.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Program Files\FirefoxPortable\FirefoxPortable.exe"
        startInfo.Arguments = "localhost"
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\Program Files\FirefoxPortable\"
        Process.Start(startInfo)
    End Sub
    Private Sub ButtonChrome_Click(sender As Object, e As EventArgs) Handles ButtonChrome.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Program Files\GoogleChromePortable\GoogleChromePortable.exe"
        startInfo.Arguments = "localhost"
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\Program Files\GoogleChromePortable\"
        Process.Start(startInfo)
    End Sub
    Private Sub ButtonCMD_Click(sender As Object, e As EventArgs) Handles ButtonCMD.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Windows\System32\cmd.exe"
        startInfo.Arguments = ""
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\"
        Process.Start(startInfo)
    End Sub
    Private Sub ButtonPowershell_Click(sender As Object, e As EventArgs) Handles ButtonPowershell.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe"
        startInfo.Arguments = ""
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\"
        Process.Start(startInfo)
    End Sub
    Private Sub ButtonFileExplorer_Click(sender As Object, e As EventArgs) Handles ButtonFileExplorer.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Program Files (x86)\A43\A43.exe"
        startInfo.Arguments = ""
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\"
        Process.Start(startInfo)
    End Sub
    Private Sub ButtonTaskmgr_Click(sender As Object, e As EventArgs) Handles ButtonTaskmgr.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Windows\System32\Taskmgr.exe"
        startInfo.Arguments = ""
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\Windows\System32\"
        Process.Start(startInfo)
    End Sub
    Private Sub ButtonRegedit_Click(sender As Object, e As EventArgs) Handles ButtonRegedit.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Windows\System32\regedt32.exe"
        startInfo.Arguments = ""
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\Windows\System32\"
        Process.Start(startInfo)
    End Sub
    Private Sub ButtonLogoff_Click(sender As Object, e As EventArgs) Handles ButtonLogoff.Click
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
    Private Sub ButtonReboot_Click(sender As Object, e As EventArgs) Handles ButtonReboot.Click
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
