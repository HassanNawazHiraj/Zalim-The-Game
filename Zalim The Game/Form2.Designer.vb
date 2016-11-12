<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.wt = New System.Windows.Forms.Label()
        Me.turn_time = New System.Windows.Forms.Label()
        Me.host_name = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.keep = New System.ComponentModel.BackgroundWorker()
        Me.keep_interval = New System.Windows.Forms.Timer(Me.components)
        Me.setup1 = New System.ComponentModel.BackgroundWorker()
        Me.query = New System.ComponentModel.BackgroundWorker()
        Me.zalim = New System.Windows.Forms.Timer(Me.components)
        Me.move_upload = New System.ComponentModel.BackgroundWorker()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.check_turn = New System.Windows.Forms.Timer(Me.components)
        Me.turn_bg = New System.ComponentModel.BackgroundWorker()
        Me.win_timer = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sid = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(94, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 62)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(176, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 62)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(11, 89)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 62)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(94, 89)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(76, 62)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(176, 89)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(76, 62)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(10, 164)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(76, 62)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(94, 164)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(76, 62)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.Location = New System.Drawing.Point(176, 164)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(76, 62)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(258, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Time Left for turn :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Server Hosted By :"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(261, 159)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(174, 134)
        Me.ListBox1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(259, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "List of players"
        '
        'wt
        '
        Me.wt.AutoSize = True
        Me.wt.Location = New System.Drawing.Point(259, 61)
        Me.wt.Name = "wt"
        Me.wt.Size = New System.Drawing.Size(129, 13)
        Me.wt.TabIndex = 14
        Me.wt.Text = "Waiting for more players..."
        '
        'turn_time
        '
        Me.turn_time.AutoSize = True
        Me.turn_time.Location = New System.Drawing.Point(357, 12)
        Me.turn_time.Name = "turn_time"
        Me.turn_time.Size = New System.Drawing.Size(27, 13)
        Me.turn_time.TabIndex = 15
        Me.turn_time.Text = "N/A"
        '
        'host_name
        '
        Me.host_name.AutoSize = True
        Me.host_name.Location = New System.Drawing.Point(357, 25)
        Me.host_name.Name = "host_name"
        Me.host_name.Size = New System.Drawing.Size(27, 13)
        Me.host_name.TabIndex = 17
        Me.host_name.Text = "N/A"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(12, 266)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 18
        Me.Button10.Text = "Disconnect"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'keep
        '
        '
        'keep_interval
        '
        Me.keep_interval.Interval = 7000
        '
        'setup1
        '
        '
        'zalim
        '
        Me.zalim.Interval = 1000
        '
        'move_upload
        '
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(360, 109)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 19
        Me.Button11.Text = "join"
        Me.Button11.UseVisualStyleBackColor = True
        Me.Button11.Visible = False
        '
        'check_turn
        '
        Me.check_turn.Enabled = True
        Me.check_turn.Interval = 4000
        '
        'turn_bg
        '
        '
        'win_timer
        '
        Me.win_timer.Enabled = True
        Me.win_timer.Interval = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(441, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(393, 277)
        Me.WebBrowser1.TabIndex = 21
        Me.WebBrowser1.Url = New System.Uri("https://tlk.io/zalim", System.UriKind.Absolute)
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(93, 266)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 22
        Me.Button12.Text = "ping test"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(176, 265)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(79, 24)
        Me.Button13.TabIndex = 23
        Me.Button13.Text = "About"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Server Id :"
        '
        'sid
        '
        Me.sid.AutoSize = True
        Me.sid.Location = New System.Drawing.Point(321, 38)
        Me.sid.Name = "sid"
        Me.sid.Size = New System.Drawing.Size(27, 13)
        Me.sid.TabIndex = 25
        Me.sid.Text = "N/A"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 296)
        Me.Controls.Add(Me.sid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.host_name)
        Me.Controls.Add(Me.turn_time)
        Me.Controls.Add(Me.wt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Zalim Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents wt As Label
    Friend WithEvents turn_time As Label
    Friend WithEvents host_name As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents keep As System.ComponentModel.BackgroundWorker
    Friend WithEvents keep_interval As Timer
    Friend WithEvents setup1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents zalim As Timer
    Friend WithEvents query As System.ComponentModel.BackgroundWorker
    Friend WithEvents move_upload As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button11 As Button
    Friend WithEvents check_turn As Timer
    Friend WithEvents turn_bg As System.ComponentModel.BackgroundWorker
    Friend WithEvents win_timer As Timer
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents sid As Label
End Class
