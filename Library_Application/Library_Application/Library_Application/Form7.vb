Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form7
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\lib.mdb;")
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\lib.mdb", FileAttributes.Hidden)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x As String

        x = MessageBox.Show("Are you sure you want to Add a New Book", "CONFIRM", MessageBoxButtons.YesNo)
        If x = vbYes Then

            query = New OleDbCommand("insert into Books(title,cat,isbn,author,volume,price,copies)values('" & TextBox10.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')", con)
            con.Open()
            query.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Record Added", "NOTIFICATION")

        Else
            MessageBox.Show("Record Not Added", "NOTIFICATION")


        End If
    End Sub

    Private Sub Ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

            Form8.Close()
            Form9.Close()
            Form10.Close()
            Form11.Close()
            Form12.Close()

        End If
    End Sub

    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home.Click
        Form12.BringToFront()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class