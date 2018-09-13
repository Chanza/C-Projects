Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form8
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\NursingC.mdb;")
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\NursingC.mdb", FileAttributes.Hidden)


        If Form1.RadioButton1.Checked = True Then


            Label22.Text = Form9.Label6.Text

            Dim cmds As New OleDbCommand("SELECT * FROM staff WHERE ID = '" & Label22.Text & "'", con)
            Dim x As OleDbDataReader
            con.Open()
            x = cmds.ExecuteReader()
            x.Read()

            Label21.Text = x.Item("uname")
            Label24.Text = x.Item("gender")
            Label25.Text = x.Item("bdate")
            Label26.Text = x.Item("email")
            Label27.Text = x.Item("mobile")
            Label28.Text = x.Item("cert")
            Label29.Text = x.Item("sub")
            Label30.Text = x.Item("dept")
            Label31.Text = x.Item("salary")
            Label32.Text = x.Item("loc")
            Label33.Text = x.Item("hiredate")
            Label34.Text = x.Item("adress")
            Label35.Text = x.Item("cal")
            PictureBox1.Image = x.Item("pic")
            con.Close()


        Else

            Label22.Text = Form2.Label6.Text

            Dim cmds As New OleDbCommand("SELECT * FROM admin WHERE ID = '" & Label22.Text & "'", con)
            Dim x As OleDbDataReader
            con.Open()
            x = cmds.ExecuteReader()
            x.Read()

            Label21.Text = x.Item("uname")
            Label24.Text = x.Item("gender")
            Label25.Text = x.Item("bdate")
            Label26.Text = x.Item("email")
            Label27.Text = x.Item("mobile")
            
            Label30.Text = x.Item("dept")
            Label31.Text = x.Item("salary")
            Label32.Text = x.Item("loc")
            Label33.Text = x.Item("hiredate")
            Label34.Text = x.Item("adress")

            con.Close()

            Label28.Text = ("XXXX")
            Label29.Text = ("XXXX")
            Label35.Text = ("XXXX")
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 1
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim i As Integer = 1
        TabControl1.SelectedIndex = i + 1
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Dim i As Integer = 2
        TabControl1.SelectedIndex = i - 1
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim i As Integer = 1
        TabControl1.SelectedIndex = i - 1
    End Sub
End Class