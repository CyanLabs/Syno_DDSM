Imports System.Threading
Imports Awesomium.Windows.Forms
Imports Awesomium.Core

Public Class frmMain
    Dim IP As String = "192.168.1.205"
    Dim updated As Boolean = False, newversion As String = ""
    Dim Updater As New Cyanlabs_Updater.Updater
    Private UpdateChecker As System.Threading.Thread = New Thread(AddressOf Updater.IsLatest)
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.Size = My.Settings.size
        Me.Location = My.Settings.location
        If My.Settings.state <> FormWindowState.Minimized Then
            Me.WindowState = My.Settings.state
        Else
            Me.WindowState = FormWindowState.Normal
        End If
        CheckForIllegalCrossThreadCalls = False
        If Environment.GetCommandLineArgs.Length > 1 Then
            For Each x As String In Environment.GetCommandLineArgs
                If x.Contains("-updated=") Then
                    updated = True
                    newversion = x.Replace("-updated=", "")
                End If
            Next
        End If
        If updated Then
            MsgBox("You have successfully updated to V" & newversion, MsgBoxStyle.Information, "Update Successful")
        ElseIf My.Settings.update = True Then
            ntfyIcon.ShowBalloonTip(5000, "Synology Desktop DSM", "Checking for updates!", ToolTipIcon.Info)
            UpdateChecker.IsBackground = True
            UpdateChecker.Start()
        End If
        If My.Settings.IP = "" Then
            frmSettings.Show()
        Else
            WebControl1.Source = New Uri("http://" & My.Settings.IP & ":5000")
        End If

    End Sub
    Private Sub NsButton2_Click(sender As Object, e As EventArgs) Handles imgSSH.Click, btnSSH.Click
        Process.Start(Application.StartupPath & "\plink.exe", "root@" & My.Settings.IP)
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmSettings.Show()
    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.ShowInTaskbar = False
        Me.Hide()
        ntfyIcon.ShowBalloonTip(3000)
    End Sub
    Private Sub ntfyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ntfyIcon.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Me.WindowState = FormWindowState.Maximized Then
            My.Settings.size = Me.Size
            My.Settings.location = Me.Location
        End If
        My.Settings.state = Me.WindowState
        My.Settings.Save()
        WebCore.Shutdown()
    End Sub

    Private Sub NsButton1_Click(sender As Object, e As EventArgs)
        WebControl1.ExecuteJavascriptWithResult("document.cookie;")
    End Sub
End Class