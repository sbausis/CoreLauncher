﻿Public Class Settings

    Public Shared Function GetButtonSettings(ByVal name As String) As String
        Dim sReturn As String = String.Empty
        Dim dsSettings As New DataSet
        If System.IO.File.Exists(Application.ExecutablePath & ".Settings.xml") Then
            dsSettings.ReadXml(Application.ExecutablePath & ".Settings.xml")
        End If

        If dsSettings.Tables("ButtonSettings") Is Nothing Then
            dsSettings.Tables.Add("ButtonSettings")
            dsSettings.Tables("ButtonSettings").Columns.Add("Enabled", GetType(Boolean))
            dsSettings.Tables("ButtonSettings").Columns.Add("Name", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Exec", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Args", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Path", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Icon", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("ConfirmTitle", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("ConfirmText", GetType(String))
        End If

        Dim dr() As DataRow = dsSettings.Tables("ButtonSettings").Select("Name = '" & name & "'")
        If dr.Length = 1 Then sReturn = dr(0)("Enabled").ToString & dr(0)("Exec").ToString & dr(0)("Args").ToString & dr(0)("Path").ToString & dr(0)("Icon").ToString & dr(0)("ConfirmTitle").ToString & dr(0)("ConfirmText").ToString

        Return sReturn
    End Function
    Public Shared Sub SetButtonSettings(name As String, exec As String, args As String, path As String, icon As String, confirmtitle As String, confirmtext As String, enabled As Boolean)
        Dim dsSettings As New DataSet
        If System.IO.File.Exists(Application.ExecutablePath & ".Settings.xml") Then
            dsSettings.ReadXml(Application.ExecutablePath & ".Settings.xml")
        End If

        If dsSettings.Tables("ButtonSettings") Is Nothing Then
            dsSettings.Tables.Add("ButtonSettings")
            dsSettings.Tables("ButtonSettings").Columns.Add("Enabled", GetType(Boolean))
            dsSettings.Tables("ButtonSettings").Columns.Add("Name", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Exec", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Args", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Path", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Icon", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("ConfirmTitle", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("ConfirmText", GetType(String))
        End If

        Dim dr() As DataRow = dsSettings.Tables("ButtonSettings").Select("Name = '" & name & "'")
        If dr.Length = 1 Then
            dr(0)("Enabled") = enabled
            dr(0)("Exec") = exec
            dr(0)("Args") = args
            dr(0)("Path") = path
            dr(0)("Icon") = icon
            dr(0)("ConfirmTitle") = confirmtitle
            dr(0)("ConfirmText") = confirmtext
        Else
            Dim drSetting As DataRow = dsSettings.Tables("ButtonSettings").NewRow
            drSetting("Enabled") = enabled
            drSetting("Name") = name
            drSetting("Exec") = exec
            drSetting("Args") = args
            drSetting("Path") = path
            drSetting("Icon") = icon
            drSetting("ConfirmTitle") = confirmtitle
            drSetting("ConfirmText") = confirmtext
            dsSettings.Tables("ButtonSettings").Rows.Add(drSetting)
        End If
        dsSettings.WriteXml(Application.ExecutablePath & ".Settings.xml")
    End Sub

    Public Shared Function GetButton(ByVal name As String) As ButtonSettings
        Dim btnRet As New ButtonSettings
        Dim dsSettings As New DataSet
        If System.IO.File.Exists(Application.ExecutablePath & ".Settings.xml") Then
            dsSettings.ReadXml(Application.ExecutablePath & ".Settings.xml")
        End If

        If dsSettings.Tables("ButtonSettings") Is Nothing Then
            dsSettings.Tables.Add("ButtonSettings")
            dsSettings.Tables("ButtonSettings").Columns.Add("Enabled", GetType(Boolean))
            dsSettings.Tables("ButtonSettings").Columns.Add("Name", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Exec", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Args", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Path", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Icon", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("ConfirmTitle", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("ConfirmText", GetType(String))
        End If

        Dim dr() As DataRow = dsSettings.Tables("ButtonSettings").Select("Name = '" & name & "'")
        If dr.Length = 1 Then
            btnRet.Enabled = Boolean.TryParse(dr(0)("Enabled"), False)
            btnRet.Name = dr(0)("Name").ToString
            btnRet.Exec = dr(0)("Exec").ToString
            btnRet.Args = dr(0)("Args").ToString
            btnRet.Path = dr(0)("Path").ToString
            btnRet.Icon = dr(0)("Icon").ToString
            btnRet.ConfirmTitle = dr(0)("ConfirmTitle").ToString
            btnRet.ConfirmText = dr(0)("ConfirmText").ToString
        End If

        Return btnRet
    End Function
    Public Shared Sub SetButton(btn As ButtonSettings)
        Dim dsSettings As New DataSet
        If System.IO.File.Exists(Application.ExecutablePath & ".Settings.xml") Then
            dsSettings.ReadXml(Application.ExecutablePath & ".Settings.xml")
        End If

        If dsSettings.Tables("ButtonSettings") Is Nothing Then
            dsSettings.Tables.Add("ButtonSettings")
            dsSettings.Tables("ButtonSettings").Columns.Add("Enabled", GetType(Boolean))
            dsSettings.Tables("ButtonSettings").Columns.Add("Name", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Exec", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Args", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Path", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("Icon", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("ConfirmTitle", GetType(String))
            dsSettings.Tables("ButtonSettings").Columns.Add("ConfirmText", GetType(String))
        End If

        Dim dr() As DataRow = dsSettings.Tables("ButtonSettings").Select("Name = '" & btn.Name & "'")
        If dr.Length = 1 Then
            dr(0)("Enabled") = btn.Enabled
            dr(0)("Exec") = btn.Exec
            dr(0)("Args") = btn.Args
            dr(0)("Path") = btn.Path
            dr(0)("Icon") = btn.Icon
            dr(0)("ConfirmTitle") = btn.ConfirmTitle
            dr(0)("ConfirmText") = btn.ConfirmText
        Else
            Dim drSetting As DataRow = dsSettings.Tables("ButtonSettings").NewRow
            drSetting("Enabled") = btn.Enabled
            drSetting("Name") = btn.Name
            drSetting("Exec") = btn.Exec
            drSetting("Args") = btn.Args
            drSetting("Path") = btn.Path
            drSetting("Icon") = btn.Icon
            drSetting("ConfirmTitle") = btn.ConfirmTitle
            drSetting("ConfirmText") = btn.ConfirmText
            dsSettings.Tables("ButtonSettings").Rows.Add(drSetting)
        End If
        dsSettings.WriteXml(Application.ExecutablePath & ".Settings.xml")
    End Sub

End Class