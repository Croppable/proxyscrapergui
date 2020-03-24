Imports System.IO
Imports System.Net

Public Class Form1
    Dim sve As New SaveFileDialog
    Private Sub Scrape()
        Try
            Dim strURL As String = "https://api.proxyscrape.com/?request=displayproxies&proxytype=" + Me.proxyType.Text + "&timeout=10000"
            Dim strOutput As String = ""
            Dim wrResponse As WebResponse
            Dim wrRequest As WebRequest = HttpWebRequest.Create(strURL)
            wrResponse = wrRequest.GetResponse()
            Using sr As New StreamReader(wrResponse.GetResponseStream())
                strOutput = sr.ReadToEnd()
                sr.Close()
            End Using
            scrapedProxiesTxt.Text = strOutput
            MessageBox.Show("Done!")
        Catch ex As Exception
            MessageBox.Show("Unable To Scrape Proxies From Host!")
        End Try
    End Sub

    Private Function GetTheNewUpdate() As Boolean
        Dim Version As String = Application.ProductVersion
        Dim info As String() = New WebClient().DownloadString("https://pastebin.com/raw/bXYVBkLr").Split(vbLf)

        If Not info(0).Contains(Version) Then
            MessageBox.Show("This Version Is Out To Date!" + vbNewLine + "Check The Repo For The New Version!")
            Process.Start("https://github.com/Croppable/proxyscrapergui/")
            Me.Close()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub startScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startScrape.Click
        If Me.proxySelect.SelectedIndex = 0 Then
            proxyType.Text = "http"
            Scrape()
        ElseIf Me.proxySelect.SelectedIndex = 1 Then
            proxyType.Text = "socks4"
            Scrape()
        Else
            proxyType.Text = "socks5"
            Scrape()
        End If
    End Sub

    Private Sub saveProxies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveProxies.Click
        If scrapedProxiesTxt.Text = Nothing Then
            Exit Sub
        End If
        Dim I As New SaveFileDialog
        I.Title = "Save Proxies"
        I.Filter = "txt files (*.txt)|*.txt"
        If I.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim U As New StreamWriter(I.FileName)
            U.Write(scrapedProxiesTxt.Text)
            U.Close()
            MsgBox(I.FileName, MsgBoxStyle.Information, "Information")
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetTheNewUpdate()
        proxyType.Hide()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Process.Start("https://proxyscrape.com/")
    End Sub

    Private Sub HuraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuraButton1.Click
        Process.Start("https://github.com/Croppable/proxyscrapergui/")
    End Sub
End Class
