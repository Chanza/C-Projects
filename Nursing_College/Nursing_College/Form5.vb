Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form5
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\NursingC.mdb;")
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\NursingC.mdb", FileAttributes.Hidden)
        Dim str As String
        Dim r As OleDbDataReader
        str = "SELECT * FROM staff"
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
        str = "SELECT * FROM staff"
        i = 0
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader
        Do While r.Read()
            DataGridView1.Item(0, i).Value = r("ID")
            DataGridView1.Item(1, i).Value = r("uname")
            DataGridView1.Item(2, i).Value = r("gender")
            DataGridView1.Item(3, i).Value = r("bdate")
            DataGridView1.Item(4, i).Value = r("email")
            DataGridView1.Item(5, i).Value = r("mobile")
            DataGridView1.Item(6, i).Value = r("dept")
            DataGridView1.Item(7, i).Value = r("cert")
            DataGridView1.Item(8, i).Value = r("sub")
            DataGridView1.Item(9, i).Value = r("loc")
            DataGridView1.Item(10, i).Value = r("hiredate")
            DataGridView1.Item(11, i).Value = r("salary")
            DataGridView1.Item(12, i).Value = r("adress")
            DataGridView1.Item(13, i).Value = r("cal")

            i = i + 1
        Loop
        con.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class