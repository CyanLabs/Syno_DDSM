Public Class frmSettings

    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        My.Settings.IP = txtIP.Text
        My.Settings.Save()
        If NsCheckBox1.Checked = True Then My.Settings.update = True Else My.Settings.update = False
        frmMain.WebControl1.Source = New Uri("http://" & My.Settings.IP & ":5000")
        Me.Close()
    End Sub

    Private Sub Settings_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtIP.Text = My.Settings.IP
        NsCheckBox1.Checked = My.Settings.update
        If My.Settings.update = True Then NsCheckBox1.Checked = True Else NsCheckBox1.Checked = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Process.Start("http://cyanlabs.co.uk")
    End Sub
End Class