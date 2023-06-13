Public Class loginManager

    Sub checkLogin(uName As String, pWord As String)
        Dim uNameArr() As String = {"mahmoudmostafa11199", "ahmedHamdi", "mohamed206", "arafa411", "faisel2002"}
        Dim pWordArr() As String = {"2210", "1410", "2062001", "1999", "2001"}

        Dim username As Integer
        For username = 0 To 4
            If uNameArr(username) = uName Then

                If pWordArr(username) = pWord Then
                    ErrorProvider1.SetError(TextBox2, "")
                    Me.Hide()
                    AddBook.Show()
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                Else
                    ErrorProvider1.SetError(TextBox2, "Password is incorrect")
                End If
                ErrorProvider1.SetError(TextBox1, "")

            Else
                ErrorProvider1.SetError(TextBox1, "Username is incorrect")
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkLogin(TextBox1.Text, TextBox2.Text)
    End Sub
End Class