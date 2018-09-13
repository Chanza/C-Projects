Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form9
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\lib.mdb;")
    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\lib.mdb", FileAttributes.Hidden)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim str As String
        Dim r As OleDbDataReader
        str = "SELECT * FROM Borrowed"
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
        str = "SELECT * FROM Borrowed"
        i = 0
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader

        Do While r.Read()
            DataGridView1.Item(0, i).Value = r("bname")
            DataGridView1.Item(1, i).Value = r("isbn")
            DataGridView1.Item(2, i).Value = r("uid")
            DataGridView1.Item(3, i).Value = r("uname")
            DataGridView1.Item(4, i).Value = r("bd")
            DataGridView1.Item(5, i).Value = r("rd")

            If r("rd") < Today Then
                DataGridView1.Item(6, i).Value = "Overdue"
            End If

            i = i + 1
        Loop
        con.Close()
    End Sub

    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home.Click
        Form4.BringToFront()
        Me.Close()
    End Sub

    Private Sub Out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
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
            Form8.Close()

            Form10.Close()
            Form11.Close()
            Form12.Close()

        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class