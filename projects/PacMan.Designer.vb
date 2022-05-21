<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pacman_a
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pacman_a))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.start = New System.Windows.Forms.Button()
        Me.bag = New System.Windows.Forms.PictureBox()
        Me.end_ = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.time = New System.Windows.Forms.TextBox()
        Me.bomb1 = New System.Windows.Forms.PictureBox()
        Me.bomb2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.ghost = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bomb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bomb2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(1000, 1000)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(10, 10)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'start
        '
        Me.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.start.Font = New System.Drawing.Font("서울남산체 M", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.start.Location = New System.Drawing.Point(172, 17)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(75, 23)
        Me.start.TabIndex = 1
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = True
        '
        'bag
        '
        Me.bag.Image = CType(resources.GetObject("bag.Image"), System.Drawing.Image)
        Me.bag.Location = New System.Drawing.Point(528, 15)
        Me.bag.Name = "bag"
        Me.bag.Size = New System.Drawing.Size(52, 50)
        Me.bag.TabIndex = 3
        Me.bag.TabStop = False
        '
        'end_
        '
        Me.end_.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.end_.Font = New System.Drawing.Font("서울남산체 M", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.end_.Location = New System.Drawing.Point(253, 16)
        Me.end_.Name = "end_"
        Me.end_.Size = New System.Drawing.Size(49, 54)
        Me.end_.TabIndex = 4
        Me.end_.Text = "End"
        Me.end_.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("서울남산체 M", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(586, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pac_Score"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(586, 41)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(73, 26)
        Me.TextBox1.TabIndex = 6
        '
        'time
        '
        Me.time.BackColor = System.Drawing.SystemColors.Control
        Me.time.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.time.Font = New System.Drawing.Font("서울남산체 M", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.time.Location = New System.Drawing.Point(12, 38)
        Me.time.Multiline = True
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(95, 27)
        Me.time.TabIndex = 7
        '
        'bomb1
        '
        Me.bomb1.Image = CType(resources.GetObject("bomb1.Image"), System.Drawing.Image)
        Me.bomb1.Location = New System.Drawing.Point(315, 17)
        Me.bomb1.Name = "bomb1"
        Me.bomb1.Size = New System.Drawing.Size(52, 50)
        Me.bomb1.TabIndex = 8
        Me.bomb1.TabStop = False
        '
        'bomb2
        '
        Me.bomb2.Image = CType(resources.GetObject("bomb2.Image"), System.Drawing.Image)
        Me.bomb2.Location = New System.Drawing.Point(422, 17)
        Me.bomb2.Name = "bomb2"
        Me.bomb2.Size = New System.Drawing.Size(51, 50)
        Me.bomb2.TabIndex = 9
        Me.bomb2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("서울남산체 M", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "현재시각 :"
        '
        'btn1
        '
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("서울남산체 M", 9.0!)
        Me.btn1.Location = New System.Drawing.Point(374, 24)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(42, 40)
        Me.btn1.TabIndex = 11
        Me.btn1.Text = "DEL!"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("서울남산체 M", 9.0!)
        Me.btn2.Location = New System.Drawing.Point(479, 24)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(42, 41)
        Me.btn2.TabIndex = 12
        Me.btn2.Text = "DEL!"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(91, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 48)
        Me.Button1.TabIndex = 14
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(181, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 48)
        Me.Button2.TabIndex = 14
        Me.Button2.TabStop = False
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(253, 402)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 48)
        Me.Button3.TabIndex = 14
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(181, 476)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 48)
        Me.Button4.TabIndex = 14
        Me.Button4.TabStop = False
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(369, 476)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 48)
        Me.Button5.TabIndex = 14
        Me.Button5.TabStop = False
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.Control
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(374, 191)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(49, 48)
        Me.Button6.TabIndex = 14
        Me.Button6.TabStop = False
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.SystemColors.Control
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(565, 388)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(49, 48)
        Me.Button7.TabIndex = 14
        Me.Button7.TabStop = False
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Control
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.SystemColors.Control
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(253, 235)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(49, 48)
        Me.Button8.TabIndex = 14
        Me.Button8.TabStop = False
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.Control
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.SystemColors.Control
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(565, 307)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(49, 48)
        Me.Button9.TabIndex = 14
        Me.Button9.TabStop = False
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Control
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.SystemColors.Control
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(507, 456)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(49, 48)
        Me.Button10.TabIndex = 14
        Me.Button10.TabStop = False
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.Control
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.ForeColor = System.Drawing.SystemColors.Control
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.Location = New System.Drawing.Point(143, 213)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(49, 48)
        Me.Button11.TabIndex = 14
        Me.Button11.TabStop = False
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.Control
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.ForeColor = System.Drawing.SystemColors.Control
        Me.Button12.Image = CType(resources.GetObject("Button12.Image"), System.Drawing.Image)
        Me.Button12.Location = New System.Drawing.Point(395, 367)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(49, 48)
        Me.Button12.TabIndex = 14
        Me.Button12.TabStop = False
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.Control
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.ForeColor = System.Drawing.SystemColors.Control
        Me.Button13.Image = CType(resources.GetObject("Button13.Image"), System.Drawing.Image)
        Me.Button13.Location = New System.Drawing.Point(143, 345)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(49, 48)
        Me.Button13.TabIndex = 14
        Me.Button13.TabStop = False
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.SystemColors.Control
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.ForeColor = System.Drawing.SystemColors.Control
        Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
        Me.Button14.Location = New System.Drawing.Point(360, 267)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(49, 48)
        Me.Button14.TabIndex = 14
        Me.Button14.TabStop = False
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.SystemColors.Control
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.ForeColor = System.Drawing.SystemColors.Control
        Me.Button15.Image = CType(resources.GetObject("Button15.Image"), System.Drawing.Image)
        Me.Button15.Location = New System.Drawing.Point(484, 291)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(49, 48)
        Me.Button15.TabIndex = 14
        Me.Button15.TabStop = False
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.SystemColors.Control
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.ForeColor = System.Drawing.SystemColors.Control
        Me.Button16.Image = CType(resources.GetObject("Button16.Image"), System.Drawing.Image)
        Me.Button16.Location = New System.Drawing.Point(447, 213)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(49, 48)
        Me.Button16.TabIndex = 14
        Me.Button16.TabStop = False
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.SystemColors.Control
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.ForeColor = System.Drawing.SystemColors.Control
        Me.Button17.Image = CType(resources.GetObject("Button17.Image"), System.Drawing.Image)
        Me.Button17.Location = New System.Drawing.Point(435, 433)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(49, 48)
        Me.Button17.TabIndex = 14
        Me.Button17.TabStop = False
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.SystemColors.Control
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.ForeColor = System.Drawing.SystemColors.Control
        Me.Button18.Image = CType(resources.GetObject("Button18.Image"), System.Drawing.Image)
        Me.Button18.Location = New System.Drawing.Point(226, 181)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(49, 48)
        Me.Button18.TabIndex = 14
        Me.Button18.TabStop = False
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.SystemColors.Control
        Me.Button19.FlatAppearance.BorderSize = 0
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.ForeColor = System.Drawing.SystemColors.Control
        Me.Button19.Image = CType(resources.GetObject("Button19.Image"), System.Drawing.Image)
        Me.Button19.Location = New System.Drawing.Point(164, 402)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(49, 48)
        Me.Button19.TabIndex = 14
        Me.Button19.TabStop = False
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.SystemColors.Control
        Me.Button20.FlatAppearance.BorderSize = 0
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.ForeColor = System.Drawing.SystemColors.Control
        Me.Button20.Image = CType(resources.GetObject("Button20.Image"), System.Drawing.Image)
        Me.Button20.Location = New System.Drawing.Point(229, 327)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(49, 48)
        Me.Button20.TabIndex = 14
        Me.Button20.TabStop = False
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.SystemColors.Control
        Me.Button21.FlatAppearance.BorderSize = 0
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.ForeColor = System.Drawing.SystemColors.Control
        Me.Button21.Image = CType(resources.GetObject("Button21.Image"), System.Drawing.Image)
        Me.Button21.Location = New System.Drawing.Point(69, 191)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(49, 48)
        Me.Button21.TabIndex = 14
        Me.Button21.TabStop = False
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.SystemColors.Control
        Me.Button22.FlatAppearance.BorderSize = 0
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.ForeColor = System.Drawing.SystemColors.Control
        Me.Button22.Image = CType(resources.GetObject("Button22.Image"), System.Drawing.Image)
        Me.Button22.Location = New System.Drawing.Point(484, 367)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(49, 48)
        Me.Button22.TabIndex = 14
        Me.Button22.TabStop = False
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.SystemColors.Control
        Me.Button23.FlatAppearance.BorderSize = 0
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.ForeColor = System.Drawing.SystemColors.Control
        Me.Button23.Image = CType(resources.GetObject("Button23.Image"), System.Drawing.Image)
        Me.Button23.Location = New System.Drawing.Point(404, 303)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(49, 48)
        Me.Button23.TabIndex = 14
        Me.Button23.TabStop = False
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.SystemColors.Control
        Me.Button24.FlatAppearance.BorderSize = 0
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.ForeColor = System.Drawing.SystemColors.Control
        Me.Button24.Image = CType(resources.GetObject("Button24.Image"), System.Drawing.Image)
        Me.Button24.Location = New System.Drawing.Point(340, 388)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(49, 48)
        Me.Button24.TabIndex = 14
        Me.Button24.TabStop = False
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.SystemColors.Control
        Me.Button25.FlatAppearance.BorderSize = 0
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.ForeColor = System.Drawing.SystemColors.Control
        Me.Button25.Image = CType(resources.GetObject("Button25.Image"), System.Drawing.Image)
        Me.Button25.Location = New System.Drawing.Point(69, 456)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(49, 48)
        Me.Button25.TabIndex = 14
        Me.Button25.TabStop = False
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.SystemColors.Control
        Me.Button26.FlatAppearance.BorderSize = 0
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.ForeColor = System.Drawing.SystemColors.Control
        Me.Button26.Image = CType(resources.GetObject("Button26.Image"), System.Drawing.Image)
        Me.Button26.Location = New System.Drawing.Point(104, 291)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(49, 48)
        Me.Button26.TabIndex = 14
        Me.Button26.TabStop = False
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.SystemColors.Control
        Me.Button27.FlatAppearance.BorderSize = 0
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.ForeColor = System.Drawing.SystemColors.Control
        Me.Button27.Image = CType(resources.GetObject("Button27.Image"), System.Drawing.Image)
        Me.Button27.Location = New System.Drawing.Point(276, 456)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(49, 48)
        Me.Button27.TabIndex = 14
        Me.Button27.TabStop = False
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.SystemColors.Control
        Me.Button28.FlatAppearance.BorderSize = 0
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button28.ForeColor = System.Drawing.SystemColors.Control
        Me.Button28.Image = CType(resources.GetObject("Button28.Image"), System.Drawing.Image)
        Me.Button28.Location = New System.Drawing.Point(48, 348)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(49, 48)
        Me.Button28.TabIndex = 14
        Me.Button28.TabStop = False
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.SystemColors.Control
        Me.Button29.FlatAppearance.BorderSize = 0
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button29.ForeColor = System.Drawing.SystemColors.Control
        Me.Button29.Image = CType(resources.GetObject("Button29.Image"), System.Drawing.Image)
        Me.Button29.Location = New System.Drawing.Point(315, 235)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(49, 48)
        Me.Button29.TabIndex = 14
        Me.Button29.TabStop = False
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.SystemColors.Control
        Me.Button30.FlatAppearance.BorderSize = 0
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button30.ForeColor = System.Drawing.SystemColors.Control
        Me.Button30.Image = CType(resources.GetObject("Button30.Image"), System.Drawing.Image)
        Me.Button30.Location = New System.Drawing.Point(531, 235)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(49, 48)
        Me.Button30.TabIndex = 14
        Me.Button30.TabStop = False
        Me.Button30.UseVisualStyleBackColor = False
        '
        'reset
        '
        Me.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reset.Font = New System.Drawing.Font("서울남산체 M", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.reset.Location = New System.Drawing.Point(172, 46)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 23)
        Me.reset.TabIndex = 15
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'ghost
        '
        Me.ghost.BackgroundImage = CType(resources.GetObject("ghost.BackgroundImage"), System.Drawing.Image)
        Me.ghost.Enabled = False
        Me.ghost.Font = New System.Drawing.Font("서울남산체 M", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ghost.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ghost.Location = New System.Drawing.Point(308, 307)
        Me.ghost.Name = "ghost"
        Me.ghost.Size = New System.Drawing.Size(69, 48)
        Me.ghost.TabIndex = 16
        Me.ghost.Text = "클릭안댐"
        Me.ghost.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button31.Font = New System.Drawing.Font("서울남산체 M", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button31.Location = New System.Drawing.Point(113, 15)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(49, 55)
        Me.Button31.TabIndex = 17
        Me.Button31.Text = "설명"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'pacman_a
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 579)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.ghost)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.Button30)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bomb2)
        Me.Controls.Add(Me.bomb1)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.end_)
        Me.Controls.Add(Me.bag)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pacman_a"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pac_Man"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bomb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bomb2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents start As Button
    Friend WithEvents bag As PictureBox
    Friend WithEvents end_ As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents time As TextBox
    Friend WithEvents bomb1 As PictureBox
    Friend WithEvents bomb2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents reset As Button
    Friend WithEvents ghost As Button
    Friend WithEvents Button31 As Button
End Class
