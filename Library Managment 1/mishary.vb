Public Class mishary

    Dim s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20 As New System.Windows.Media.MediaPlayer
    Dim checkPlay As Boolean = False

    Sub playsound(ByVal filepath As String, ByVal s As System.Windows.Media.MediaPlayer, ByVal sender As System.Object)
        If checkPlay Then
            Exit Sub
        Else
            s.Open(New Uri(filepath, UriKind.Relative))
            s.Play()
            CType(sender, PictureBox).BackColor = Color.OrangeRed
            checkPlay = True
        End If
    End Sub

    Sub stopSound(ByVal s As System.Windows.Media.MediaPlayer)
        If checkPlay Then
            If s.Position <> TimeSpan.Zero AndAlso s.Position < s.NaturalDuration Then
                For Each pb In Me.Controls
                    If TypeOf pb Is PictureBox Then
                        CType(pb, PictureBox).BackColor = Color.Transparent
                    End If
                Next
            End If
            s.Stop()
            checkPlay = False
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        playsound("Quran/mishary/001.mp3", s1, sender)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        stopSound(s1)
    End Sub

    Private Sub PictureBox38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox38.Click
        playsound("Quran/mishary/012.mp3", s12, sender)
    End Sub

    Private Sub PictureBox37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.Click
        stopSound(s12)
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        playsound("Quran/mishary/002.mp3", s2, sender)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        stopSound(s2)
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        playsound("Quran/mishary/003.mp3", s3, sender)
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        stopSound(s3)
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        playsound("Quran/mishary/004.mp3", s4, sender)
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        stopSound(s4)
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        playsound("Quran/mishary/005.mp3", s5, sender)
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        stopSound(s5)
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        playsound("Quran/mishary/006.mp3", s6, sender)
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        stopSound(s6)
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        playsound("Quran/mishary/007.mp3", s7, sender)
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        stopSound(s7)
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        playsound("Quran/mishary/008.mp3", s8, sender)
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        stopSound(s8)
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        playsound("Quran/mishary/009.mp3", s9, sender)
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        stopSound(s9)
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        playsound("Quran/mishary/010.mp3", s10, sender)
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        stopSound(s10)
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        playsound("Quran/mishary/020.mp3", s20, sender)
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        stopSound(s20)
    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
        playsound("Quran/mishary/019.mp3", s19, sender)
    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        stopSound(s19)
    End Sub

    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox26.Click
        playsound("Quran/mishary/018.mp3", s18, sender)
    End Sub

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox25.Click
        stopSound(s18)
    End Sub

    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
        playsound("Quran/mishary/017.mp3", s17, sender)
    End Sub

    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox27.Click
        stopSound(s17)
    End Sub

    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        playsound("Quran/mishary/016.mp3", s16, sender)
    End Sub

    Private Sub PictureBox29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.Click
        stopSound(s16)
    End Sub

    Private Sub PictureBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox32.Click
        playsound("Quran/mishary/015.mp3", s15, sender)
    End Sub

    Private Sub PictureBox31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox31.Click
        stopSound(s15)
    End Sub

    Private Sub PictureBox34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox34.Click
        playsound("Quran/mishary/014.mp3", s14, sender)
    End Sub

    Private Sub PictureBox33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox33.Click
        stopSound(s14)
    End Sub

    Private Sub PictureBox36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox36.Click
        playsound("Quran/mishary/013.mp3", s13, sender)
    End Sub

    Private Sub PictureBox35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox35.Click
        stopSound(s13)
    End Sub

    Private Sub PictureBox40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox40.Click
        playsound("Quran/mishary/011.mp3", s11, sender)
    End Sub

    Private Sub PictureBox39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox39.Click
        stopSound(s11)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If checkPlay = False Then
            Me.Hide()
            Sheikhs.Show()
        Else
            MessageBox.Show("اوقف الصورة للرجوع", "Mishari Rashid Alafasy")
        End If
    End Sub

    Private Sub yaser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult = MessageBox.Show("Do you want to exit program ?", "Mishari Rashid Alafasy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Application.ExitThread()
        ElseIf result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub yaser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each pb In Me.Controls
            If TypeOf pb Is PictureBox Then
                CType(pb, PictureBox).Cursor = Cursors.Hand
            End If
        Next
    End Sub

End Class