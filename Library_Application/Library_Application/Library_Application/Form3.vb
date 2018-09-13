Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form3
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\lib.mdb;")
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\lib.mdb", FileAttributes.Hidden)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim cmds As New OleDbCommand("SELECT * FROM Profile1 WHERE uname = '" & TextBox1.Text & "'", con)
            Dim x As OleDbDataReader
            con.Open()
            x = cmds.ExecuteReader()
            x.Read()
            If TextBox1.Text = x.Item("uname") Then
                MessageBox.Show("User Name is Correct", "NOTIFICATION")
                If TextBox2.Text = x.Item("pword") Then
                    MessageBox.Show("Password is Correct", "NOTIFICATION")
                    Form4.Show()
                Else
                    MessageBox.Show("Password is Wrong", "NOTIFICATION")
                End If
            Else
                MessageBox.Show("Username is Correct", "NOTIFICATION")
            End If
        Catch
            MessageBox.Show("No User", "NOTIFICATION")
        End Try
        con.Close()
    End Sub
    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home.Click
        Form1.BringToFront()
        Me.Close()
    End Sub
End Class
