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
    Private Sub ButtonReboot_Click(sender As Object, e As EventArgs) Handles ButtonReboot.Click
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        response = MsgBox("Do you want to restart the Computer?", style, "Reboot")
        If response = MsgBoxResult.Yes Then
            Dim startInfo As New ProcessStartInfo
            startInfo.FileName = "C:\Windows\System32\shutdown.exe"
            startInfo.Arguments = "-r -t 10"
            startInfo.UseShellExecute = True
            startInfo.WorkingDirectory = "C:\"
            startInfo.CreateNoWindow = True
            Process.Start(startInfo)
        End If
    End Sub

    Private Sub ButtonCustom_Click(sender As Object, e As EventArgs) Handles ButtonCustom.Click
        ' Dim btn As Button = sender

        ' Dim MyImage As Image
        ' MyImage = Image.FromFile("C:\Users\Simon\Downloads\firefox-icon.png")
        ' Dim img As Bitmap = New Bitmap(MyImage, New Size(26, 26))
        ' btn.Image = DirectCast(img, Image)

        ' btn.Image = Image.FromFile("C:\Users\Simon\Downloads\firefox-icon.png").GetThumbnailImage(26, 26, Nothing, IntPtr.Zero)
    End Sub
End Class
