Public Class pacman_a

    Private Sub pacman_a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = 0
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter
        Dim url As String
        url = Application.StartupPath & "\" & "bgm.mp3"
        AxWindowsMediaPlayer1.URL = url
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = TimeOfDay
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim rnd As New Random
        Button1.Top = Button1.Top + rnd.Next(1, 30)
        Button1.Left = Button1.Left + rnd.Next(1, 30)
        Button2.Left = Button2.Left + rnd.Next(5, 30)
        Button3.Top = Button3.Top - rnd.Next(3, 30)
        Button3.Left = Button3.Left + rnd.Next(5, 30)
        Button4.Top = Button4.Top + rnd.Next(6, 30)
        Button5.Top = Button5.Top + rnd.Next(1, 30)
        Button5.Left = Button5.Left - rnd.Next(3, 30)
        Button6.Top = Button6.Top - rnd.Next(4, 30)
        Button6.Left = Button6.Left - rnd.Next(4, 30)
        Button7.Left = Button7.Left + rnd.Next(2, 30)
        Button8.Top = Button8.Top - rnd.Next(1, 30)
        Button8.Left = Button8.Left - rnd.Next(1, 30)
        Button9.Top = Button9.Top - rnd.Next(5, 30)
        Button9.Left = Button9.Left - rnd.Next(6, 30)
        Button10.Top = Button10.Top + rnd.Next(7, 30)
        Button10.Left = Button10.Left - rnd.Next(8, 30)
        Button11.Top = Button11.Top + rnd.Next(7, 10)
        Button12.Top = Button12.Top + rnd.Next(2, 10)
        Button12.Left = Button12.Left - rnd.Next(2, 10)
        Button13.Top = Button13.Top + rnd.Next(2, 10)
        Button13.Left = Button13.Left - rnd.Next(2, 10)
        Button14.Top = Button14.Top + rnd.Next(2, 10)
        Button14.Left = Button14.Left - rnd.Next(2, 10)
        Button15.Top = Button15.Top + rnd.Next(2, 10)
        Button15.Left = Button15.Left - rnd.Next(2, 10)
        Button16.Top = Button16.Top + rnd.Next(2, 10)
        Button16.Left = Button16.Left - rnd.Next(2, 10)
        Button17.Top = Button17.Top + rnd.Next(2, 10)
        Button17.Left = Button17.Left + rnd.Next(2, 10)
        Button18.Left = Button18.Left - rnd.Next(5, 10)
        Button19.Top = Button19.Top - rnd.Next(2, 10)
        Button19.Left = Button19.Left - rnd.Next(2, 10)
        Button20.Top = Button20.Top - rnd.Next(5, 10)
        Button21.Top = Button21.Top - rnd.Next(2, 10)
        Button21.Left = Button21.Left + rnd.Next(2, 10)
        Button22.Top = Button22.Top - rnd.Next(2, 10)
        Button22.Left = Button22.Left + rnd.Next(6, 10)
        Button23.Left = Button23.Left + rnd.Next(2, 10)
        Button24.Top = Button24.Top - rnd.Next(1, 10)
        Button24.Left = Button24.Left + rnd.Next(1, 10)
        Button25.Top = Button25.Top - rnd.Next(8, 10)
        Button26.Top = Button26.Top + rnd.Next(1, 10)
        Button26.Left = Button26.Left + rnd.Next(1, 10)
        Button27.Top = Button27.Top - rnd.Next(1, 10)
        Button27.Left = Button27.Left + rnd.Next(1, 10)
        Button28.Top = Button28.Top + rnd.Next(1, 10)
        Button28.Left = Button28.Left + rnd.Next(1, 10)
        Button29.Top = Button29.Top - rnd.Next(1, 10)
        Button29.Left = Button29.Left + rnd.Next(1, 10)
        Button30.Top = Button30.Top - rnd.Next(1, 10)
        Button30.Left = Button30.Left - rnd.Next(1, 10)
    End Sub
    Private Sub time_TextChanged(sender As Object, e As EventArgs) Handles time.TextChanged
        Timer1.Enabled = True
        time.Text = TimeOfDay
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles end_.Click
        End
    End Sub

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        If start.Text = "Start" Then
            Timer2.Enabled = True
            TextBox1.Text = 0
            start.Text = "Stop"
        Else
            Timer2.Enabled = False
            MsgBox(TextBox1.Text & "마리!")
            start.Text = "Start"
        End If

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles reset.Click
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Button7.Visible = True
        Button8.Visible = True
        Button9.Visible = True
        Button10.Visible = True
        Button11.Visible = True
        Button12.Visible = True
        Button13.Visible = True
        Button14.Visible = True
        Button15.Visible = True
        Button16.Visible = True
        Button17.Visible = True
        Button18.Visible = True
        Button19.Visible = True
        Button20.Visible = True
        Button21.Visible = True
        Button22.Visible = True
        Button23.Visible = True
        Button24.Visible = True
        Button25.Visible = True
        Button26.Visible = True
        Button27.Visible = True
        Button28.Visible = True
        Button29.Visible = True
        Button30.Visible = True

        Button1.Top = ghost.Top
        Button2.Top = ghost.Top
        Button3.Top = ghost.Top
        Button4.Top = ghost.Top
        Button5.Top = ghost.Top
        Button6.Top = ghost.Top
        Button7.Top = ghost.Top
        Button8.Top = ghost.Top
        Button9.Top = ghost.Top
        Button10.Top = ghost.Top
        Button11.Top = ghost.Top
        Button12.Top = ghost.Top
        Button13.Top = ghost.Top
        Button14.Top = ghost.Top
        Button15.Top = ghost.Top
        Button16.Top = ghost.Top
        Button17.Top = ghost.Top
        Button18.Top = ghost.Top
        Button19.Top = ghost.Top
        Button20.Top = ghost.Top
        Button21.Top = ghost.Top
        Button22.Top = ghost.Top
        Button23.Top = ghost.Top
        Button24.Top = ghost.Top
        Button25.Top = ghost.Top
        Button26.Top = ghost.Top
        Button27.Top = ghost.Top
        Button28.Top = ghost.Top
        Button29.Top = ghost.Top
        Button30.Top = ghost.Top

        Button1.Left = ghost.Left
        Button2.Left = ghost.Left
        Button3.Left = ghost.Left
        Button4.Left = ghost.Left
        Button5.Left = ghost.Left
        Button6.Left = ghost.Left
        Button7.Left = ghost.Left
        Button8.Left = ghost.Left
        Button9.Left = ghost.Left
        Button10.Left = ghost.Left
        Button11.Left = ghost.Left
        Button12.Left = ghost.Left
        Button13.Left = ghost.Left
        Button14.Left = ghost.Left
        Button15.Left = ghost.Left
        Button16.Left = ghost.Left
        Button17.Left = ghost.Left
        Button18.Left = ghost.Left
        Button19.Left = ghost.Left
        Button20.Left = ghost.Left
        Button21.Left = ghost.Left
        Button22.Left = ghost.Left
        Button23.Left = ghost.Left
        Button24.Left = ghost.Left
        Button25.Left = ghost.Left
        Button26.Left = ghost.Left
        Button27.Left = ghost.Left
        Button28.Left = ghost.Left
        Button29.Left = ghost.Left
        Button30.Left = ghost.Left

        TextBox1.Clear()
        TextBox1.Text = 0
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Button30.Visible = False
        TextBox1.Text = TextBox1.Text + 1
    End Sub
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Button28.Visible = False
        TextBox1.Text = TextBox1.Text + 1
    End Sub
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Button29.Visible = False
        TextBox1.Text = TextBox1.Text + 1
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Button27.Visible = False
        TextBox1.Text = TextBox1.Text + 1
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox1.Text = TextBox1.Text + 1
        Button26.Visible = False
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox1.Text = TextBox1.Text + 1
        Button25.Visible = False
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox1.Text = TextBox1.Text + 1
        Button24.Visible = False
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox1.Text = TextBox1.Text + 1
        Button23.Visible = False
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox1.Text = TextBox1.Text + 1
        Button22.Visible = False
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = TextBox1.Text + 1
        Button21.Visible = False
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = TextBox1.Text + 1
        Button20.Visible = False
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = TextBox1.Text + 1
        Button19.Visible = False
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = TextBox1.Text + 1
        Button18.Visible = False
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = TextBox1.Text + 1
        Button17.Visible = False
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text + 1
        Button16.Visible = False
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = TextBox1.Text + 2
        Button15.Visible = False
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text + 2
        Button14.Visible = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text + 2
        Button13.Visible = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text + 2
        Button12.Visible = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text + 2
        Button11.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + 2
        Button10.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + 2
        Button9.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + 2
        Button8.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + 2
        Button7.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + 2
        Button6.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + 2
        Button5.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + 2
        Button4.Visible = False
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + 2
        Button2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + 2
        Button1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + 2
        Button3.Visible = False
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Button16.Visible = False
        Button17.Visible = False
        Button18.Visible = False
        Button19.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Button23.Visible = False
        Button24.Visible = False
        Button25.Visible = False
        Button26.Visible = False
        Button27.Visible = False
        Button28.Visible = False
        Button29.Visible = False
        Button30.Visible = False
    End Sub

    Private Sub Button31_Click_1(sender As Object, e As EventArgs) Handles Button31.Click
        MsgBox("클릭하여 팩맨을 잡는다." & vbCrLf & "White_Pac = 2 Points" & vbCrLf & "Black_Pac = 1 Points" & vbCrLf & vbCrLf & "BOMB = Delete(No/Points)")
    End Sub
End Class
