<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notebad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(notebad))
        Me.btn_menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_new = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_open = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_save = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_saveas = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_menuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_undo = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_redo = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_selectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_menuFormat = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_rightToLeftRich = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_aboutApp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.richTxtBox = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_menuFile
        '
        Me.btn_menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_new, Me.btn_open, Me.btn_save, Me.btn_saveas, Me.btn_exit})
        Me.btn_menuFile.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_menuFile.Name = "btn_menuFile"
        Me.btn_menuFile.Size = New System.Drawing.Size(41, 23)
        Me.btn_menuFile.Text = "File"
        '
        'btn_new
        '
        Me.btn_new.Name = "btn_new"
        Me.btn_new.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.btn_new.Size = New System.Drawing.Size(206, 24)
        Me.btn_new.Text = "New         "
        '
        'btn_open
        '
        Me.btn_open.Name = "btn_open"
        Me.btn_open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.btn_open.Size = New System.Drawing.Size(206, 24)
        Me.btn_open.Text = "Open"
        '
        'btn_save
        '
        Me.btn_save.Name = "btn_save"
        Me.btn_save.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.btn_save.Size = New System.Drawing.Size(206, 24)
        Me.btn_save.Text = "Save"
        '
        'btn_saveas
        '
        Me.btn_saveas.Name = "btn_saveas"
        Me.btn_saveas.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.btn_saveas.Size = New System.Drawing.Size(206, 24)
        Me.btn_saveas.Text = "SaveAs"
        '
        'btn_exit
        '
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(206, 24)
        Me.btn_exit.Text = "Exit"
        '
        'btn_menuEdit
        '
        Me.btn_menuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_undo, Me.btn_redo, Me.btn_cut, Me.btn_copy, Me.btn_paste, Me.btn_selectAll})
        Me.btn_menuEdit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_menuEdit.Name = "btn_menuEdit"
        Me.btn_menuEdit.Size = New System.Drawing.Size(44, 23)
        Me.btn_menuEdit.Text = "Edit"
        '
        'btn_undo
        '
        Me.btn_undo.Name = "btn_undo"
        Me.btn_undo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.btn_undo.Size = New System.Drawing.Size(182, 24)
        Me.btn_undo.Text = "Undo"
        '
        'btn_redo
        '
        Me.btn_redo.Name = "btn_redo"
        Me.btn_redo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.btn_redo.Size = New System.Drawing.Size(182, 24)
        Me.btn_redo.Text = "Redo"
        '
        'btn_cut
        '
        Me.btn_cut.Name = "btn_cut"
        Me.btn_cut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.btn_cut.Size = New System.Drawing.Size(182, 24)
        Me.btn_cut.Text = "Cut"
        '
        'btn_copy
        '
        Me.btn_copy.Name = "btn_copy"
        Me.btn_copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.btn_copy.Size = New System.Drawing.Size(182, 24)
        Me.btn_copy.Text = "Copy"
        '
        'btn_paste
        '
        Me.btn_paste.Name = "btn_paste"
        Me.btn_paste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.btn_paste.Size = New System.Drawing.Size(182, 24)
        Me.btn_paste.Text = "Paste"
        '
        'btn_selectAll
        '
        Me.btn_selectAll.Name = "btn_selectAll"
        Me.btn_selectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.btn_selectAll.Size = New System.Drawing.Size(182, 24)
        Me.btn_selectAll.Text = "Select All"
        '
        'btn_menuFormat
        '
        Me.btn_menuFormat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.btn_rightToLeftRich})
        Me.btn_menuFormat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_menuFormat.Name = "btn_menuFormat"
        Me.btn_menuFormat.Size = New System.Drawing.Size(65, 23)
        Me.btn_menuFormat.Text = "Format"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(244, 24)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'btn_rightToLeftRich
        '
        Me.btn_rightToLeftRich.Name = "btn_rightToLeftRich"
        Me.btn_rightToLeftRich.Size = New System.Drawing.Size(244, 24)
        Me.btn_rightToLeftRich.Text = "Right to Left Reading order"
        '
        'btn_aboutApp
        '
        Me.btn_aboutApp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_aboutApp.Name = "btn_aboutApp"
        Me.btn_aboutApp.Size = New System.Drawing.Size(59, 23)
        Me.btn_aboutApp.Text = "About"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_menuFile, Me.btn_menuEdit, Me.btn_menuFormat, Me.btn_aboutApp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(598, 27)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'richTxtBox
        '
        Me.richTxtBox.AcceptsTab = True
        Me.richTxtBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.richTxtBox.Location = New System.Drawing.Point(0, 27)
        Me.richTxtBox.Name = "richTxtBox"
        Me.richTxtBox.Size = New System.Drawing.Size(598, 460)
        Me.richTxtBox.TabIndex = 5
        Me.richTxtBox.Text = ""
        '
        'notebad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 487)
        Me.Controls.Add(Me.richTxtBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "notebad"
        Me.Text = "Notebad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_menuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_new As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_open As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_saveas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_menuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_undo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_redo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_cut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_paste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_selectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_menuFormat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_rightToLeftRich As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_aboutApp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents richTxtBox As System.Windows.Forms.RichTextBox
End Class
