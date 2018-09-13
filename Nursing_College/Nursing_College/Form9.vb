Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form9
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\NursingC.mdb;")
    Private Sub For92_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\NursingC.mdb", FileAttributes.Hidden)

        Label6.Text = Form1.TextBox1.Text
        Dim cmds As New OleDbCommand("SELECT * FROM staff WHERE ID = '" & Label6.Text & "'", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()

        Label5.Text = x.Item("uname")
        PictureBox1.ImageLocation = x.Item("Pic")

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form6.Close()
        Form8.Close()
        Form10.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form6.Close()
        Form10.Close()
        Form8.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to Log Out?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Form6.Close()
            Form8.Close()
            Form10.Close()
            Form1.TextBox2.Clear()
            Form1.PictureBox4.Visible = False
            Form1.PictureBox5.Visible = False
            Form1.PictureBox6.Visible = False
            Form1.PictureBox7.Visible = False
            Me.Close()
        Else
            Form6.Close()
            Form8.Close()
            Form10.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form8.Close()
        Form10.Close()
        Form6.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form6.Close()
        Form8.Close()
        Form10.Show()
    End Sub
End Class