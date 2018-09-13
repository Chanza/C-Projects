Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form8
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\lib.mdb;")
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        File.SetAttributes(Application.StartupPath & "\lib.mdb", FileAttributes.Hidden)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String
        Dim r As OleDbDataReader
        str = "SELECT * FROM Books"
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
        str = "SELECT * FROM Books"
        i = 0
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader
        Do While r.Read()
            DataGridView1.Item(0, i).Value = r("title")
            DataGridView1.Item(1, i).Value = r("cat")
            DataGridView1.Item(2, i).Value = r("isbn")
            DataGridView1.Item(3, i).Value = r("author")
            DataGridView1.Item(4, i).Value = r("volume")
            DataGridView1.Item(5, i).Value = r("price")
            DataGridView1.Item(6, i).Value = r("copies")

            i = i + 1
        Loop
        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home.Click
        If Form1.CheckBox1.Checked = True Then
            Form4.Show()
        Else
            If Form1.CheckBox2.Checked = True Then
                Form12.Show()
            Else
            End If
        End If
        Me.Close()
    End Sub

    Private Sub Out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Out.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to Log Out", "CONFIRM", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Form1.BringToFront()
            Me.Close()

            Form2.Close()
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Form6.Close()
            Form7.Close()

            Form9.Close()
            Form10.Close()
            Form11.Close()
            Form12.Close()

        End If
    End Sub
End Class
