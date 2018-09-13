Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form6
    Dim query As OleDbCommand

    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\lib.mdb;")
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\lib.mdb", FileAttributes.Hidden)
        Label1.Visible = False

        TextBox10.Text = Form12.ComboBox1.Text

        Dim cmds As New OleDbCommand("SELECT * FROM Books WHERE title = '" & TextBox10.Text & "'", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()
        Label1.Visible = True

        TextBox2.Text = x.Item("cat")
        TextBox3.Text = x.Item("isbn")
        TextBox4.Text = x.Item("author")
        TextBox5.Text = x.Item("volume")
        TextBox6.Text = x.Item("price")
        Label1.Text = x.Item("copies")
        con.Close()

    End Sub

    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
    End Sub

    Private Sub Ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim y As String
        y = MessageBox.Show("Are you sure you want to Log Out", "CONFIRM", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Form1.Show()

        Else

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox2.Clear()
        Me.Refresh()

        'Dim cmds As New OleDbCommand("SELECT * FROM Books WHERE title = '" & TextBox2.Text & "'", con)
        'Dim x As OleDbDataReader
        'con.Open()
        'x = cmds.ExecuteReader()
        'x.Read()
        'TextBox2.Text = x.Item("title")
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form5.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form5.Show()
    End Sub

    Private Sub Home_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home.Click
        Form12.BringToFront()
        Me.Close()
    End Sub

    Private Sub Out_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Out.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to Log Out", "CONFIRM", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Form1.BringToFront()
            Me.Close()

            Form2.Close()
            Form3.Close()
            Form4.Close()
            Form5.Close()

            Form7.Close()
            Form8.Close()
            Form9.Close()
            Form10.Close()
            Form11.Close()
            Form12.Close()

        End If
    End Sub
End Class