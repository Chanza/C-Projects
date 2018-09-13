Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class MyRecipes
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\TasteMe.mdb;")
    Private Sub MyRecipes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\TasteMe.mdb", FileAttributes.Hidden)
        Label1.Text = Home.Label9.Text

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
        str = "SELECT * FROM Recipes WHERE uname = '" & Label1.Text & "'"
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
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.TextBox1.Text = DataGridView1.Item(2, i).Value

        Details.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Dim i As Integer
        'i = DataGridView1.CurrentRow.Index
        'Me.TextBox1.Text = DataGridView1.Item(2, i).Value

        'Details.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class