Imports System.IO
Imports System.Net

Public NotInheritable Class Form_update

    Private Sub Form_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label_updateAvailable.Text = "Update" & Form_main.liveVersion.Trim() & " is available for download"
        Try
            TextBox_changes.Text = New StreamReader(New WebClient().OpenRead("https://raw.githubusercontent.com/cmd430/Warframe-EHP-Calculator/master/Warframe%20EHP%20Calculator%20v2/latest_changes")).ReadToEnd
        Catch ex As Exception
            TextBox_changes.Text = "Error Loading Changes"
        End Try
    End Sub

    Private Sub Button_ignore_Click(sender As Object, e As EventArgs) Handles Button_ignore.Click
        Me.Close()
    End Sub

    Private Sub Button_download_Click(sender As Object, e As EventArgs) Handles Button_download.Click
        Process.Start(TextBox_downloadLink.Text)
    End Sub

End Class
