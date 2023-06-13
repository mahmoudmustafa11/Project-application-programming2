Imports System.Data.OleDb

Module Module1
    Public CON As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=books.accdb")
    Public DT As New DataTable
    Public DA As New OleDbDataAdapter

    Public Sub Fill_DVG(ByVal DVG As DataGridView, ByVal OLEDB As String)
        DVG.DataSource = ""
        Dim DT As New DataTable
        Dim DA As New OleDbDataAdapter(OLEDB, CON)
        DA.Fill(DT)
        DVG.AutoGenerateColumns = False
        DVG.DataSource = DT.DefaultView
    End Sub

    Public Function CODEGENE(ByVal T_NAME, ByVal ID_) As Integer
        CODEGENE = 0
        Dim DT As New DataTable
        Dim DA As New OleDbDataAdapter(" SELECT * FROM " & T_NAME & " ORDER BY " & ID_ & "", CON)
        DA.Fill(DT)
        If DT.Rows.Count <> 0 Then
            Dim I = DT.Rows.Count - 1
            CODEGENE = Val(DT.Rows(I).Item(ID_))
        End If
    End Function
End Module
