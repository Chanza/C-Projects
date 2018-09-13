Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class ViewAll
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\TasteMe.mdb;")
    Private Sub ViewAll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\TasteMe.mdb", FileAttributes.Hidden)

        '************THIS HELPS INSERT INTO THE DATAGID VIEW (AUTOMATICALLY)******************
        Dim str As String
        Dim r As OleDbDataReader
        str = "SELECT * FROM Recipes"
        Dim i As Integer
        i = 0
        con.Open()
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader
        Do While r.Read()
            DataGridView1.RowCount = DataGridView1.RowCount + 1
            i = i + 1
        Loop
        query.Dispose()
        str = "SELECT * FROM Recipes"
        i = 0
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader
        Do While r.Read()
            DataGridView1.Item(0, i).Value = r("title")
            DataGridView1.Item(1, i).Value = r("uname")
            DataGridView1.Item(2, i).Value = r("ID")
            DataGridView1.Item(3, i).Value = r("catg")
            DataGridView1.Item(4, i).Value = r("rate")
            DataGridView1.Item(5, i).Value = ("View Details")

            i = i + 1
        Loop
        con.Close()

        DataGridView1.Sort(DataGridView1.Columns(4), System.ComponentModel.ListSortDirection.Descending)
        
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'If e.RowIndex >= 0 Then
        '    Dim row As DataGridViewRow
        '    row = Me.DataGridView1.Rows(e.RowIndex)

        '    TextBox1.Text = row.Cells("Name of Recipe").Value.ToString
        '    'TextBox2.Text = row.Cells("uname").Value.ToString
        '    'TextBox3.Text = row.Cells("catg").Value.ToString
        'End If
    End Sub

    Private Sub DataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        '**********ENABLES THE CELLS TO BE SELECTABLE***************************
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.TextBox1.Text = DataGridView1.Item(2, i).Value

        Details.Show()

    End Sub
End Class