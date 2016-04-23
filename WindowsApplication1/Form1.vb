Public Class Form1
    Private Sub ButtonFirefox_Click(sender As Object, e As EventArgs) Handles ButtonFirefox.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "C:\Program Files\FirefoxPortable\FirefoxPortable.exe"
        startInfo.Arguments = "localhost"
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = "C:\"
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
End Class
