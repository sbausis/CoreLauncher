Public Class CoreLauncherSettings
    Private ButtonCollection As New Microsoft.VisualBasic.Collection()
    Private Sub CoreLauncherSettings_Load(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles MyBase.Load

        CoreLauncherSettings_Load_ButtonSettings()
        CoreLauncherSettings_Load_ButtonBox()

    End Sub

    Private Sub CoreLauncherSettings_Load_ButtonBox()

        If ButtonBox.Items.Count <= 0 Then

            For Each btn As ButtonSettings In ButtonCollection
                ButtonBox.Items.Add(btn.Name)
            Next

        End If

        Me.ButtonBox.SelectedIndex = 0

    End Sub
    Private Sub CoreLauncherSettings_Load_ButtonSettings()

        If ButtonCollection.Count <= 0 Then

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
                            ButtonCollection.Add(newBtn, newBtn.Name)
                            buttonCnt += 1
                        End If

                    End If

                Next

            End If

        End If

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Dim newBtn As ButtonSettings = New ButtonSettings
        newBtn.Enabled = Me.EnabledBox.Checked
        newBtn.Name = Me.NameBox.Text
        newBtn.Exec = Me.ExecBox.Text
        newBtn.Args = Me.ArgsBox.Text
        newBtn.Path = Me.PathBox.Text
        newBtn.Icon = Me.IconBox.Text
        newBtn.ConfirmTitle = Me.CTitleBox.Text
        newBtn.ConfirmText = Me.CTextBox.Text
        Settings.SetButton(newBtn)

        ButtonCollection.Clear()
        CoreLauncherSettings_Load_ButtonSettings()

    End Sub

    Private Sub ButtonBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ButtonBox.SelectedIndexChanged
        Dim idx As ListBox = sender
        Dim btn As ButtonSettings = ButtonCollection.Item(idx.SelectedIndex + 1)
        If btn IsNot Nothing Then

            Me.EnabledBox.Checked = btn.Enabled
            Me.NameBox.Text = btn.Name
            Me.ExecBox.Text = btn.Exec
            Me.ArgsBox.Text = btn.Args
            Me.PathBox.Text = btn.Path
            Me.IconBox.Text = btn.Icon
            Me.CTitleBox.Text = btn.ConfirmTitle
            Me.CTextBox.Text = btn.ConfirmText

        End If

    End Sub

End Class