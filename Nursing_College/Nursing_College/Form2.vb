Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form2
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\NursingC.mdb;")
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\NursingC.mdb", FileAttributes.Hidden)

        Label6.Text = Form1.TextBox1.Text
        Dim cmds As New OleDbCommand("SELECT * FROM admin WHERE ID = '" & Label6.Text & "'", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()

        Label5.Text = x.Item("uname")
        'con.Close()

    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Dim cmds2 As New OleDbCommand("SELECT * FROM staff WHERE ID = '" & TextBox1.Text & "'", con)
            Dim z As OleDbDataReader
            'con.Open()
            z = cmds2.ExecuteReader()
            z.Read()

            If TextBox1.Text = z.Item("ID") Then

                Label4.Visible = False
                Form3.Show()
                '    con.Close()
            Else
                Label4.Visible = True
                con.Close()
            End If
        Catch
            Label4.Visible = True
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()

        Form4.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to Log Out?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then

            Form3.Close()
            Form4.Close()
            Form5.Close()
            Form6.Close()
            Form7.Close()
            Form8.Close()

            Form1.TextBox2.Clear()
            Form1.TextBox2.Clear()
            Form1.PictureBox4.Visible = False
            Form1.PictureBox5.Visible = False
            Form1.PictureBox6.Visible = False
            Form1.PictureBox7.Visible = False
            Me.Close()
        Else
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Form6.Close()
            Form7.Close()
            Form8.Close()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form3.Close()
        Form4.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()

        Form5.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form7.Close()
        Form8.Close()

        Form6.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form8.Close()

        Form7.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Label4.Visible = False
        TextBox1.Clear()

        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()

        Label4.Visible = False
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()

        Form8.Show()
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class