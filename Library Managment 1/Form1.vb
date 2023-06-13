Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("هذا المشروع يتضمن إدارة الكتب والاستفادة من الموارد المتاحة للاستماع للقرآن الكريم، حيث يعمل الفريق على تطوير مهاراتهم في إدارة المشاريع وتعزيز روح الفريق من خلال الاستماع للقرآن الكريم، وذلك بهدف تحقيق الأهداف المحددة للمشروع بكفاءة وفعالية.", , "About Project")
        My.Computer.Audio.Play("./وَقُل_رَّبِّ_زِدْنِي_عِلْمًا_القارئ_حمزة_يوسفMP3_160K.wav")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Sheikhs.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form2.Show()
        Me.Hide()
    End Sub

End Class
