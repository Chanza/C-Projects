Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form10
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\lib.mdb;")
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\lib.mdb", FileAttributes.Hidden)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As String
        If TextBox4.Text = TextBox5.Text Then
            x = MessageBox.Show("Are you sure you want to save?", "CONFIRMATION", MessageBoxButtons.YesNo)
            If x = vbYes Then

                query = New OleDbCommand("insert into Profile2(uname,pword,fname,sname,em,mob,adrs,birth,gender)values('" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & DateTimePicker1.Text & "','" & ComboBox1.Text & "')", con)
                con.Open()
                query.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("New User Account Created", "NOTIFICATION")
                Me.Hide()
                Form11.Show()

            Else
                MessageBox.Show("Please Re-enter Password", "NOTIFICATION", MessageBoxButtons.YesNo)
                TextBox2.Focus()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.BringToFront()
        Me.Close()
    End Sub
End Class
