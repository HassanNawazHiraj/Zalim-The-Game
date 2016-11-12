Imports System.ComponentModel

Public Class Form3
    Dim swatch As New Stopwatch
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        swatch.Start()
        Button1.Enabled = False
        netreq.RunWorkerAsync()

    End Sub

    Private Sub ping_time_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub netreq_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles netreq.DoWork
        Dim list As String = New System.Net.WebClient().DownloadString("http://zalim.orgfree.com/server_list.php")
    End Sub

    Private Sub netreq_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles netreq.RunWorkerCompleted

        Button1.Enabled = True
        swatch.Done()
        TextBox1.Text = CInt((swatch.ElapsedTime * 1000)) & " ms"
    End Sub


End Class