Imports System.Data.OleDb

Public Class Form3

    Sub getDataToText()
        Try
            TextBox8.Text = DataGridView1.Rows(DataGridView1.SelectedRows.Item(0).Index).Cells(0).Value.ToString()
            TextBox2.Text = DataGridView1.Rows(DataGridView1.SelectedRows.Item(0).Index).Cells(1).Value.ToString()
            TextBox3.Text = DataGridView1.Rows(DataGridView1.SelectedRows.Item(0).Index).Cells(2).Value.ToString()
            TextBox4.Text = DataGridView1.Rows(DataGridView1.SelectedRows.Item(0).Index).Cells(3).Value.ToString()
            TextBox5.Text = DataGridView1.Rows(DataGridView1.SelectedRows.Item(0).Index).Cells(4).Value.ToString()
            TextBox6.Text = DataGridView1.Rows(DataGridView1.SelectedRows.Item(0).Index).Cells(5).Value.ToString()
            TextBox7.Text = DataGridView1.Rows(DataGridView1.SelectedRows.Item(0).Index).Cells(6).Value.ToString()
            TextBox9.Text = DataGridView1.Rows(DataGridView1.SelectedRows.Item(0).Index).Cells(7).Value.ToString()

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub BooksBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BooksBindingSource.EndEdit()

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooksDataSet3.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter2.Fill(Me.BooksDataSet3.books)
        'TODO: This line of code loads data into the 'BooksDataSet2.books' table. You can move, or remove it, as needed.
   
        Fill_DVG(DataGridView1, "SELECT * FROM books ")
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=books.accdb")
        Dim cmd As New OleDbCommand("Select COUNT(*) from books", con)
        con.Open()
        Dim cmd2 As New OleDbCommand("SELECT Type FROM books", con)
        Dim reader As OleDbDataReader = cmd2.ExecuteReader()

        While reader.Read()
            ComboBox1.Items.Add(reader("Type").ToString())
        End While
        Label13.Text = cmd.ExecuteScalar().ToString()
        reader.Close()
        con.Close()

        ' إنشاء HashSet لإزالة التكرار
        Dim uniqueSet As New HashSet(Of Object)(ComboBox1.Items.Cast(Of Object)().ToArray())

        ' تعيين العناصر المميزة إلى ComboBox
        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(uniqueSet.ToArray())
    End Sub

    Private Sub DataGridView1_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        'Dim i As Integer
        'For i = 0 To DataGridView1.Rows.Count - 1
        '    DataGridView1.Rows(i).Cells(0).Value = "Display Data"
        '    Dim ROW As DataGridViewRow = DataGridView1.Rows(i)
        'Next
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Try
            If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected = True Then
                TextBox8.Text = DataGridView1.CurrentRow.Cells(0).Value
                TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
                TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
                TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value
                TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value
                TextBox6.Text = DataGridView1.CurrentRow.Cells(5).Value
                TextBox7.Text = DataGridView1.CurrentRow.Cells(6).Value
                TextBox9.Text = DataGridView1.CurrentRow.Cells(7).Value

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_firstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_firstRecord.Click
        Try
            DataGridView1.ClearSelection()
            DataGridView1.Rows(0).Selected = True
            getDataToText()
        Catch ex As Exception
            Return
        End Try

    End Sub

    Private Sub btn_nextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nextRecord.Click
        Try
            DataGridView1.ClearSelection()
            DataGridView1.Rows(DataGridView1.CurrentRow.Index + 1).Selected = True
            getDataToText()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_prevRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prevRecord.Click
        Try
            Dim i As Integer
            If DataGridView1.SelectedRows.Count <> 0 Then
                i = DataGridView1.SelectedRows.Item(0).Index
            Else
                i = DataGridView1.RowCount - 1
            End If
            If i >= DataGridView1.RowCount - 1 Then i = -1
            DataGridView1.ClearSelection()
            DataGridView1.Rows(i + 1).Selected = True
            getDataToText()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_lastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_lastRecord.Click
        Try
            Dim i As Integer
            If DataGridView1.SelectedRows.Count <> 0 Then
                i = DataGridView1.SelectedRows.Item(0).Index
            Else
                i = 0
            End If
            If i >= DataGridView1.RowCount - 1 Then i = DataGridView1.RowCount
            DataGridView1.ClearSelection()
            DataGridView1.Rows(i - 1).Selected = True
            getDataToText()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM books WHERE Type = '" & ComboBox1.Text & "'", CON)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.SelectedIndex = 1 Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM books WHERE Type = '" & ComboBox1.Text & "'", CON)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.SelectedIndex = 2 Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM books WHERE Type = '" & ComboBox1.Text & "'", CON)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            If Trim(TextBox1.Text) <> "" Then
                Dim DT As New DataTable
                DT.Clear()
                Dim DA As New OleDb.OleDbDataAdapter
                DA = New OleDb.OleDbDataAdapter("SELECT * FROM books WHERE Title like '%" & Trim$(TextBox1.Text) & "%'", CON)
                DA.Fill(DT)
                DataGridView1.DataSource = DT.DefaultView

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_updateData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_updateData.Click
        DT.Clear()
        Fill_DVG(DataGridView1, "SELECT * FROM books ")
        For Each tx In Me.Controls
            If TypeOf tx Is TextBox Then
                CType(tx, TextBox).Text = ""
            End If
        Next
        ComboBox1.Text = ""
        MsgBox("Data Update successfully")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Do you want to exit program ?", "Show Books", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Application.ExitThread()
        ElseIf result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class