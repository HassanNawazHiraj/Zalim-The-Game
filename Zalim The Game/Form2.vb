Imports System.ComponentModel

Public Class Form2
    Public player As String = "host"
    Public server_id As String
    Public player_name As String
    Public user_name As String
    Public turn As String = "host"
    Public tick As Integer = 0
    Public game_data As String = "h,1,2,3,4,5,6,7,8,9,time"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  ListBox1.Items.Add(player_name)

    End Sub
    Public Sub enable_table()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

    End Sub
    Public Sub disable_table()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False

    End Sub
    Private Sub keep_interval_Tick(sender As Object, e As EventArgs) Handles keep_interval.Tick
        If keep.IsBusy = False Then
            keep.RunWorkerAsync(server_id)
        End If
        Me.Text = "Zalim Game | Ticks : " & tick
        tick = tick + 1
    End Sub

    Private Sub keep_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles keep.DoWork
        Dim list As String = New System.Net.WebClient().DownloadString("http://zalim.orgfree.com/server_keep.php?id=" & server_id & "&t=" & Int(Rnd() * 5530) + 1)
        e.Result = list
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If player = "host" Then
            Dim list As String = New System.Net.WebClient().DownloadString("http://zalim.orgfree.com/remove_server.php?id=" & server_id & "&t=" & Int(Rnd() * 5530) + 1)
            Application.Restart()
        Else
            Application.Restart()
        End If

    End Sub

    Private Sub keep_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles keep.RunWorkerCompleted
        If e.Result = "non" Then
        Else

            Me.Text = "Zalim Game"
            ListBox1.Items.Add(e.Result)
            user_name = e.Result
            start_game()

        End If
    End Sub
    Public Sub start_game()
        keep_interval.Enabled = False
        wt.Text = "Game Started"
        If player = "host" Then

            setup1.RunWorkerAsync(server_id)


        End If

        If player = "join" Then
            start_turn()
            disable_table()

        End If
    End Sub

    Private Sub setup_DoWork(sender As Object, e As DoWorkEventArgs) Handles setup1.DoWork
        Dim list As String = New System.Net.WebClient().DownloadString("http://zalim.orgfree.com/game_query.php?q=setup&id=" & e.Argument & "&t=" & Int(Rnd() * 5530) + 1)
        e.Result = e.Argument
    End Sub
    Public Sub start_turn()
        zalim.Enabled = False
        turn_time.Text = player_name & "'s turn"

    End Sub

    Private Sub zalim_Tick(sender As Object, e As EventArgs) Handles zalim.Tick
        turn_time.Text = tick
        tick = tick - 1
        If tick < 15 Then
            wt.Text = "please make your move quickly" & vbCrLf & " or your turn will end"
        End If
        If tick = -1 Then
            upload_move("empty")
            zalim.Enabled = False

        End If
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ' Dim list As String = New System.Net.WebClient().DownloadString("http://zalim.orgfree.com/remove_server.php?id=" & server_id)

    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub setup_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles setup1.RunWorkerCompleted
        '  MsgBox(e.Result)
        tick = 40
        zalim.Enabled = True
        enable_table()
    End Sub
    Public Function create_string_for_upload(split_array As String())
        Dim temp As String
        For i = 0 To split_array.Count - 1
            If i = split_array.Count - 1 Then
                temp = temp & split_array(i)
            Else
                temp = temp & split_array(i) & ","
            End If

        Next
        Return temp

    End Function

    Public Function upload_move(box As String)

        If turn = "host" Then
            If player = "host" Then
                Dim data_split As String() = game_data.Split(New String() {","}, StringSplitOptions.None)
                If box = "empty" Then

                Else
                    data_split(box) = "h"
                End If

                data_split(0) = "p"
                game_data = create_string_for_upload(data_split)
                turn = "player"
                'current_turn.Text = user_name
                disable_table()
                Dim bg_data As String = server_id & "|" & create_string_for_upload(data_split)
                move_upload.RunWorkerAsync(bg_data)
                zalim.Enabled = False
                turn_time.Text = user_name & "'s turn"
                Return player_name
            End If
        End If
        If turn = "player" Then
            If player = "join" Then
                Dim data_split As String() = game_data.Split(New String() {","}, StringSplitOptions.None)
                If box = "empty" Then

                Else
                    data_split(box) = "p"
                End If
                data_split(0) = "h"
                game_data = create_string_for_upload(data_split)
                turn = "host"
                'current_turn.Text = player_name
                disable_table()
                Dim bg_data As String = server_id & "|" & create_string_for_upload(data_split)
                move_upload.RunWorkerAsync(bg_data)
                zalim.Enabled = False
                turn_time.Text = player_name & "'s turn"
                Return user_name
            End If
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "1" Then
            Button1.Text = upload_move(1)
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "2" Then
            Button2.Text = upload_move(2)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "3" Then
            Button3.Text = upload_move(3)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "4" Then
            Button4.Text = upload_move(4)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = "5" Then
            Button5.Text = upload_move(5)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.Text = "6" Then
            Button6.Text = upload_move(6)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.Text = "7" Then
            Button7.Text = upload_move(7)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.Text = "8" Then
            Button8.Text = upload_move(8)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button9.Text = "9" Then
            Button9.Text = upload_move(9)
        End If

    End Sub

    Private Sub move_upload_DoWork(sender As Object, e As DoWorkEventArgs) Handles move_upload.DoWork
        Dim datas As String() = e.Argument.ToString.Split(New String() {"|"}, StringSplitOptions.None)

        Dim list As String = New System.Net.WebClient().DownloadString("http://zalim.orgfree.com/game_query.php?q=data_upload&id=" & datas(0) & "&data=" & datas(1) & "&t=" & Int(Rnd() * 5530) + 1)
        e.Result = "http://zalim.orgfree.com/game_query.php?q=upload_data&id=" & datas(0) & "&data=" & datas(1) & "&t=" & Int(Rnd() * 5530) + 1
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim list As String = New System.Net.WebClient().DownloadString("http://zalim.orgfree.com/join.php?name=zalim&id=" & server_id & "&t=" & Int(Rnd() * 5530) + 1)

    End Sub

    Private Sub move_upload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles move_upload.RunWorkerCompleted
        tick = 40

    End Sub
    Public Sub win(num As String)
        win_timer.Enabled = False
        win_timer.Stop()
        win_timer.Enabled = False
        win_timer.Stop()
        win_timer.Enabled = False
        win_timer.Stop()
        win_timer.Enabled = False
        win_timer.Stop()
        win_timer.Enabled = False
        win_timer.Stop()
        Select Case (num)
            Case 1
                MsgBox(Button1.Text & " has won")
            Case 2
                MsgBox(Button4.Text & " has won")
            Case 3
                MsgBox(Button7.Text & " has won")
            Case 4
                MsgBox(Button1.Text & " has won")
            Case 5
                MsgBox(Button2.Text & " has won")
            Case 6
                MsgBox(Button3.Text & " has won")
            Case 7
                MsgBox(Button1.Text & " has won")
            Case 8
                MsgBox(Button7.Text & " has won")
        End Select

        Application.Restart()
    End Sub
    Private Sub check_turn_Tick(sender As Object, e As EventArgs) Handles check_turn.Tick




        If player = "host" And turn = "player" Then
            If turn_bg.IsBusy = False Then
                turn_bg.RunWorkerAsync(server_id)
            End If

        End If
        If player = "join" And turn = "host" Then
            If turn_bg.IsBusy = False Then
                turn_bg.RunWorkerAsync(server_id)
            End If
        End If
    End Sub

    Private Sub turn_bg_DoWork(sender As Object, e As DoWorkEventArgs) Handles turn_bg.DoWork
        Dim list As String = New System.Net.WebClient().DownloadString("http://zalim.orgfree.com/game_query.php?q=data_get&id=" & e.Argument & "&t=" & Int(Rnd() * 5530) + 1)
        e.Result = list

    End Sub
    Public Sub remap(sdata As String)
        Dim result_split As String() = sdata.ToString.Split(New String() {","}, StringSplitOptions.None)
        For i = 1 To 9
            change_button(i, result_split(i))
        Next
    End Sub

    Private Sub turn_bg_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles turn_bg.RunWorkerCompleted
        Dim result_split As String() = e.Result.ToString.Split(New String() {","}, StringSplitOptions.None)
        ' MsgBox(result_split(0))
        'TextBox1.Text = player & "," & result_split(0) & "|" & e.Result & "|" & server_id
        If player = "join" And result_split(0) = "p" Then
            turn = "player"
            'current_turn.Text = user_name
            game_data = e.Result
            remap(e.Result)
            tick = 40
            zalim.Enabled = True
            enable_table()
        End If
        If player = "host" And result_split(0) = "h" Then
            turn = "host"
            'current_turn.Text = player_name
            game_data = e.Result
            remap(e.Result)
            tick = 40
            zalim.Enabled = True
            enable_table()
        End If
    End Sub

    Public Sub change_button(num As String, player2 As String)


        Select Case (num)

            Case 1
                Select Case (player2)
                    Case "p"
                        Button1.Text = user_name
                    Case "h"
                        Button1.Text = player_name
                End Select
            Case 2
                Select Case (player2)
                    Case "p"
                        Button2.Text = user_name
                    Case "h"
                        Button2.Text = player_name
                End Select


            Case 3
                Select Case (player2)
                    Case "p"
                        Button3.Text = user_name
                    Case "h"
                        Button3.Text = player_name
                End Select

            Case 4
                Select Case (player2)
                    Case "p"
                        Button4.Text = user_name
                    Case "h"
                        Button4.Text = player_name
                End Select

            Case 5
                Select Case (player2)
                    Case "p"
                        Button5.Text = user_name
                    Case "h"
                        Button5.Text = player_name
                End Select

            Case 6
                Select Case (player2)
                    Case "p"
                        Button6.Text = user_name
                    Case "h"
                        Button6.Text = player_name
                End Select

            Case 7
                Select Case (player2)
                    Case "p"
                        Button7.Text = user_name
                    Case "h"
                        Button7.Text = player_name
                End Select

            Case 8
                Select Case (player2)
                    Case "p"
                        Button8.Text = user_name
                    Case "h"
                        Button8.Text = player_name
                End Select

            Case 9
                Select Case (player2)
                    Case "p"
                        Button9.Text = user_name
                    Case "h"
                        Button9.Text = player_name
                End Select


        End Select

    End Sub

    Private Sub win_timer_Tick(sender As Object, e As EventArgs) Handles win_timer.Tick
        Dim moves As String() = game_data.Split(New String() {","}, StringSplitOptions.None)
        If moves(1).ToString = moves(2).ToString AndAlso moves(3).ToString = moves(2).ToString Then
            win(1)
            win_timer.Enabled = False
            win_timer.Stop()
        End If
        If moves(4).ToString = moves(5).ToString AndAlso moves(6).ToString = moves(5).ToString Then
            win(2)
            win_timer.Enabled = False
            win_timer.Stop()
        End If
        If moves(7).ToString = moves(8).ToString AndAlso moves(9).ToString = moves(8).ToString Then
            win(3)
            win_timer.Enabled = False
            win_timer.Stop()
        End If
        If moves(1).ToString = moves(4).ToString AndAlso moves(7).ToString = moves(4).ToString Then
            win(4)
            win_timer.Enabled = False
            win_timer.Stop()
        End If
        If moves(2).ToString = moves(5).ToString AndAlso moves(8).ToString = moves(5).ToString Then
            win(5)
            win_timer.Enabled = False
            win_timer.Stop()
        End If
        If moves(3).ToString = moves(6).ToString AndAlso moves(9).ToString = moves(6).ToString Then
            win(6)
            win_timer.Enabled = False
            win_timer.Stop()
        End If
        If moves(1).ToString = moves(5).ToString AndAlso moves(9).ToString = moves(5).ToString Then
            win(7)
            win_timer.Enabled = False
            win_timer.Stop()
        End If
        If moves(7).ToString = moves(5).ToString AndAlso moves(3).ToString = moves(5).ToString Then
            win(8)
            win_timer.Enabled = False
            win_timer.Stop()
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim f3 As New Form3
        f3.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        MsgBox("Game Developed By : Hassan Nawaz" & vbCrLf & "http://steamcommunity.com/id/hassannawaz/",, "Zalim Game")
        Process.Start("http://steamcommunity.com/id/hassannawaz/")
    End Sub
End Class