Imports System.IO

Public Class notebad

    Dim CurrentFile As String = ""
    Private IsModified As Boolean = False

    Private Sub SaveFile()
        Try
            ' If the current file exists, save the contents to it
            If CurrentFile <> "" Then
                richTxtBox.SaveFile(CurrentFile, RichTextBoxStreamType.PlainText)
                Me.Text = Path.GetFileName(CurrentFile) + " - " + Me.Text
                MessageBox.Show("Saved Successfully", "Saved Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                IsModified = False
            Else
                ' Otherwise, show the SaveFileDialog and let the user select a file to save
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    richTxtBox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                    CurrentFile = SaveFileDialog1.FileName
                    Me.Text = Path.GetFileName(CurrentFile) + " - " + Me.Text
                    IsModified = False
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If IsModified Then
            ' Prompt the user to save changes
            Dim result As DialogResult = MessageBox.Show("Do you want to save changes ?", "My Notepad Application", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                ' Save the changes and close the program
                SaveFile()
            ElseIf result = DialogResult.No Then
                ' Discard the changes and close the program
                e.Cancel = False
            ElseIf result = DialogResult.Cancel Then
                ' Cancel the form closing event
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub richTxtBox_TextChanged(sender As Object, e As EventArgs) Handles richTxtBox.TextChanged
        IsModified = True
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        If IsModified Then
            SaveFile()
        End If

        Me.Text = "New Text" + " - " + "Notebad"

        richTxtBox.Clear()
    End Sub

    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click
        Try
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim fileName As String = Path.GetFileName(OpenFileDialog1.FileName)
                CurrentFile = fileName

                richTxtBox.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)

                Me.Text = fileName + " - " + Me.Text
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        SaveFile()
        IsModified = False
    End Sub

    Private Sub btn_saveas_Click(sender As Object, e As EventArgs) Handles btn_saveas.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            richTxtBox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            CurrentFile = SaveFileDialog1.FileName
            Me.Text = Path.GetFileName(CurrentFile) + " - " + Me.Text
            MessageBox.Show("Saved Successfully", "Saved Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            IsModified = False
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        If IsModified Then
            SaveFile()
        End If
        Me.Close()
    End Sub

    Private Sub btn_undo_Click(sender As Object, e As EventArgs) Handles btn_undo.Click
        richTxtBox.Undo()
    End Sub

    Private Sub btn_redo_Click(sender As Object, e As EventArgs) Handles btn_redo.Click
        richTxtBox.Redo()
    End Sub

    Private Sub btn_cut_Click(sender As Object, e As EventArgs) Handles btn_cut.Click
        ' Cut the selected text and copy it to the clipboard
        If richTxtBox.SelectedText <> "" Then
            richTxtBox.Cut()
        End If
    End Sub

    Private Sub btn_copy_Click(sender As Object, e As EventArgs) Handles btn_copy.Click
        ' Copy the selected text to the clipboard
        If richTxtBox.SelectedText <> "" Then
            richTxtBox.Copy()
        End If
    End Sub

    Private Sub btn_paste_Click(sender As Object, e As EventArgs) Handles btn_paste.Click
        ' Paste the text from the clipboard
        If Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) = True Then
            richTxtBox.Paste()
        End If
    End Sub

    Private Sub btn_selectAll_Click(sender As Object, e As EventArgs) Handles btn_selectAll.Click
        ' Select all the text in the RichTextBox control
        richTxtBox.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim font As New FontDialog
        With font
            .ShowApply = True
            If .ShowDialog = DialogResult.OK Then
                If richTxtBox.SelectedText <> "" Then
                    richTxtBox.SelectionFont = .Font
                Else
                    richTxtBox.Font = .Font
                End If

            End If
        End With
    End Sub

    Private Sub btn_rightToLeftRich_Click(sender As Object, e As EventArgs) Handles btn_rightToLeftRich.Click
        If btn_rightToLeftRich.Checked Then
            richTxtBox.RightToLeft = RightToLeft.No
            btn_rightToLeftRich.Checked = False
        Else
            richTxtBox.RightToLeft = RightToLeft.Yes
            btn_rightToLeftRich.Checked = True
        End If
    End Sub

    Private Sub btn_aboutApp_Click(sender As Object, e As EventArgs) Handles btn_aboutApp.Click
        AboutNotebad.Show()
    End Sub
End Class