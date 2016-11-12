Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class Form1
    Dim f2 As New Form2
    Public jname As String
    Public jserver As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If server1.IsBusy = False Then
            server1.RunWorkerAsync()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If server1.IsBusy = False Then
            server1.RunWorkerAsync()
        End If
    End Sub

    Private Sub server1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles server1.DoWork
        Try
            Dim list As String = New System.Net.WebClient().DownloadString("http://zalim.orgfree.com/server_list.php")
            e.Result = list
        Catch ex As Exception
            e.Result = "error"
        End Try

    End Sub

    Private Sub server1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles server1.RunWorkerCompleted
        If e.Result = "error" Then
            MsgBox("server offline!")
            End
        Else
            Dim server_array As String() = e.Result.Split(New String() {","}, StringSplitOptions.None)
            ListBox1.Items.Clear()

            For i = 0 To server_array.Count - 2
                ListBox1.Items.Add(server_array(i))
            Next
            If ListBox1.Items.Count = 0 Then
                ListBox1.Items.Add("No Server Online")
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Please Select a server first")
        Else
            Dim name = InputBox("Enter Your Display Name (alphabet only)", "Zalim The Game")
            Dim rgx As New Regex("[^a-zA-Z ]")
            Dim name1 As String = rgx.Replace(name, "")
            jname = name1
            Dim a As String() = ListBox1.Text.ToString.Split(New String() {"|"}, StringSplitOptions.None)
            Dim arg As String = name1 & "," & a(1)
            jserver = a(1)
            ' MsgBox(arg)
            join1.RunWorkerAsync(arg)
        End If
        If ListBox1.Text = "No Server Online" Then
            MsgBox("No Server Online to join")
        End If

        'Code here to join game
    End Sub

    Private Sub server2_DoWork(sender As Object, e As DoWorkEventArgs) Handles server2.DoWork
        Dim a As String() = e.Argument.ToString.Split(New String() {","}, StringSplitOptions.None)
        Dim list As String = New System.Net.WebClient().DownloadString("http://zalim.orgfree.com/create_server.php?name=" & a(0) & "&server=" & a(1))
        e.Result = a(0) & "," & list
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name = InputBox("Enter Your Display Name (alphabet only)", "Zalim The Game")
        Dim server_name = InputBox("Enter The Name of Server (alphabet only)", "Zalim The Game")
        Dim rgx As New Regex("[^a-zA-Z ]")
        Dim name1 As String = rgx.Replace(name, "")
        Dim server_name1 As String = rgx.Replace(server_name, "")
        server2.RunWorkerAsync(name1 & "," & server_name1)


    End Sub
    Public Sub after_connect()

    End Sub

    Private Sub server2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles server2.RunWorkerCompleted
        'MsgBox(e.Result)
        Dim results As String() = e.Result.ToString.Split(New String() {","}, StringSplitOptions.None)

        MsgBox("server is online now!")

        f2.host_name.Text = results(0)
        f2.player_name = results(0)
        f2.ListBox1.Items.Add(results(0))
        f2.server_id = results(1)
        f2.sid.Text = results(1)
        f2.keep_interval.Enabled = True
        ' MsgBox(results(1))
        f2.Show()
        Me.Visible = False
        'Timer1.Enabled = True
        Me.Enabled = False
    End Sub

    Private Sub join1_DoWork(sender As Object, e As DoWorkEventArgs) Handles join1.DoWork
        Dim join_array As String() = e.Argument.Split(New String() {","}, StringSplitOptions.None)
        Dim list As String = New System.Net.WebClient().DownloadString("http://zalim.orgfree.com/join.php?name=" & join_array(0) & "&id=" & join_array(1))
        e.Result = list
    End Sub

    Private Sub server_timer_Tick(sender As Object, e As EventArgs) Handles server_timer.Tick
        If server1.IsBusy = False Then
            server1.RunWorkerAsync()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub join1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles join1.RunWorkerCompleted
        Dim f2 As New Form2
        f2.server_id = jserver
        f2.host_name.Text = e.Result
        f2.player_name = e.Result
        f2.user_name = jname
        f2.ListBox1.Items.Add(e.Result)
        f2.ListBox1.Items.Add(jname)
        f2.wt.Visible = False
        f2.keep_interval.Enabled = True
        f2.Show()
        f2.player = "join"
        f2.start_game()
        Me.Visible = False
        Me.Enabled = False
        'Timer1.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f3 As New Form3
        f3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Game Developed By : Hassan Nawaz" & vbCrLf & "http://steamcommunity.com/id/hassannawaz/",, "Zalim Game")
        Process.Start("http://steamcommunity.com/id/hassannawaz/")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("This is only for advanced users, it might cause any glitches or make game unplayable")
        Dim name = InputBox("Enter Your Display Name (alphabet only)", "Zalim The Game")
        Dim rgx As New Regex("[^a-zA-Z ]")
        Dim name1 As String = rgx.Replace(name, "")
        Dim ak As String = InputBox("enter server id", "Zalim Server Connect")
        Dim arg As String = name1 & "," & ak
        jname = name1
        ' MsgBox(arg)
        join1.RunWorkerAsync(arg)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
