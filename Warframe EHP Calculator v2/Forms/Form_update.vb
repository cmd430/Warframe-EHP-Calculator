Imports System.Net

Public NotInheritable Class Form_update

    Private Sub Form_update_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Label_updateAvailable.Text = "Update" & Form_main.liveVersion & " is available for download"
        Try
            Dim WebClient = New WebClient With {
                .CachePolicy = New Cache.RequestCachePolicy(Cache.RequestCacheLevel.NoCacheNoStore)
            }
            TextBox_changes.Text = WebClient.DownloadString("https://raw.githubusercontent.com/cmd430/Warframe-EHP-Calculator/master/Warframe%20EHP%20Calculator%20v2/latest_changes")
        Catch ex As Exception
            TextBox_changes.Text = "Error Loading Changes"
        End Try
    End Sub

    Private Sub Button_ignore_Click(sender As Object, e As EventArgs) Handles Button_ignore.Click
        Close()
    End Sub

    Private Sub Button_download_Click(sender As Object, e As EventArgs) Handles Button_download.Click
        Process.Start(TextBox_downloadLink.Text)
    End Sub

End Class
