Imports System.Data.OleDb

Public Class AddBook

    Sub showData()
        Try
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter
            DT.Clear()
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM books WHERE Title = '" & TextBox2.Text & "'", CON)
            DA.Fill(DT)
            If DT.Rows.Count > 0 Then
                If Not IsDBNull(DT.Rows(0).Item("Title")) Then
                    TextBox1.Text = DT.Rows(0).Item("ID")
                    TextBox2.Text = DT.Rows(0).Item("Title")
                    TextBox3.Text = DT.Rows(0).Item("Author")
                    TextBox4.Text = DT.Rows(0).Item("PublicationDate")
                    TextBox5.Text = DT.Rows(0).Item("Publisher")
                    TextBox6.Text = DT.Rows(0).Item("NumAvailable")
                    TextBox7.Text = DT.Rows(0).Item("Type")
                    TextBox8.Text = DT.Rows(0).Item("LinkBook")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BooksBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BooksBindingSource.EndEdit()

    End Sub

    Private Sub AddBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Format(CODEGENE("books", "ID") + 1, "0000")
    End Sub

    Private Sub btn_saveBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_saveBook.Click
        Try
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM books WHERE Title = '" & TextBox2.Text & "'", CON)
            DA.Fill(DT)
            If DT.Rows.Count > 0 Then
                MessageBox.Show("The book is already registered", "Warning message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim DR = DT.NewRow
                DR!ID = TextBox1.Text
                DR!Title = TextBox2.Text
                DR!Author = TextBox3.Text
                DR!PublicationDate = TextBox4.Text
                DR!Publisher = TextBox5.Text
                DR!NumAvailable = TextBox6.Text
                DR!Type = TextBox7.Text
                DR!LinkBook = TextBox8.Text
                DT.Rows.Add(DR)
                Dim Save As New OleDb.OleDbCommandBuilder(DA)
                Save.QuotePrefix = "["
                Save.QuoteSuffix = "]"
                DA.Update(DT)
                DT.AcceptChanges()
                btn_addNewBook_Click(Nothing, Nothing)
                TextBox1.Text = Format(CODEGENE("books", "ID") + 1, "0000")
                MessageBox.Show("Data saved successfully", "Warning message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_addNewBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addNewBook.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub btn_editBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editBook.Click
        Try
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM books WHERE Title = '" & TextBox2.Text & "'", CON)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
                MessageBox.Show("The book is already registered", "Warning message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim DR = DT.Rows(0)
                DR!ID = TextBox1.Text
                DR!Title = TextBox2.Text
                DR!Author = TextBox3.Text
                DR!PublicationDate = TextBox4.Text
                DR!Publisher = TextBox5.Text
                DR!NumAvailable = TextBox6.Text
                DR!Type = TextBox7.Text
                DR!LinkBook = TextBox8.Text
                Dim Save As New OleDb.OleDbCommandBuilder(DA)
                Save.QuotePrefix = "["
                Save.QuoteSuffix = "]"
                DA.Update(DT)
                DT.AcceptChanges()
                btn_addNewBook_Click(Nothing, Nothing)
                TextBox1.Text = Format(CODEGENE("books", "ID") + 1, "0000")
                MessageBox.Show("Data edit successfully", "Warning message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_rmvBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_rmvBook.Click
        Try
            If MessageBox.Show("Are you sure to delete the current record ?", "Warning message", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Exit Sub
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM books WHERE Title = '" & TextBox2.Text & "'", CON)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
            Else
                Dim DR = DT.Rows(0)
                DR.Delete()
                Dim Save As New OleDb.OleDbCommandBuilder(DA)
                DA.Update(DT)
                DT.AcceptChanges()
                TextBox1.Text = Format(CODEGENE("books", "ID") + 1, "0000")
                MessageBox.Show("Data remove successfully", "Warning message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            showData()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub AddBook_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Do you want to exit program ?", "Add Books", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Application.ExitThread()
        ElseIf result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class