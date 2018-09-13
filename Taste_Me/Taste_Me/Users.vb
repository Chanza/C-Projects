Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Users
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\TasteMe.mdb;")
    Private Sub Users_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\TasteMe.mdb", FileAttributes.Hidden)

        Dim str As String
        Dim r As OleDbDataReader
        str = "SELECT * FROM Profiles"
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
        str = "SELECT * FROM Profiles"
        i = 0
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader
        Do While r.Read()
            DataGridView1.Item(0, i).Value = r("uname")
            DataGridView1.Item(1, i).Value = r("fullname")
            DataGridView1.Item(2, i).Value = r("edress")
           

            i = i + 1
        Loop
        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.TextBox1.Text = DataGridView1.Item(0, i).Value
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim y As String
        y = MessageBox.Show("Sure you want to delete this Profile?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            con.Close()
            Dim cmds As New OleDbCommand("DELETE * FROM Profiles WHERE uname = '" & TextBox1.Text & "'", con)

            con.Open()

            cmds.ExecuteReader()
            MessageBox.Show("Profile Deleted", "NOTIFICATION")
            con.Close()

            DataGridView1.Rows.Clear()

            Dim str As String
            Dim r As OleDbDataReader
            str = "SELECT * FROM Profiles"
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
            str = "SELECT * FROM Profiles"
            i = 0
            query = New OleDbCommand(str, con)
            r = query.ExecuteReader
            Do While r.Read()
                DataGridView1.Item(0, i).Value = r("uname")
                DataGridView1.Item(1, i).Value = r("fullname")
                DataGridView1.Item(2, i).Value = r("edress")


                i = i + 1
            Loop
            con.Close()
        Else
            MessageBox.Show("Profile NOT Deleted", "NOTIFICATION")
            con.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class