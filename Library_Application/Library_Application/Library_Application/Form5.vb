Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form5
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\lib.mdb;")
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\lib.mdb", FileAttributes.Hidden)

        TextBox3.Text = Form4.TextBox1.Text


        Dim cmds As New OleDbCommand("SELECT * FROM Books WHERE isbn = '" & TextBox3.Text & "'", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()

        TextBox10.Text = x.Item("title")
        TextBox2.Text = x.Item("cat")
        TextBox3.Text = x.Item("isbn")
        TextBox4.Text = x.Item("author")
        TextBox5.Text = x.Item("volume")
        TextBox6.Text = x.Item("price")
        TextBox1.Text = x.Item("copies")
        con.Close()

    End Sub

    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home.Click
        Form4.BringToFront()
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

            Form6.Close()
            Form7.Close()
            Form8.Close()
            Form9.Close()
            Form10.Close()
            Form11.Close()
            Form12.Close()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim str As String = "UPDATE Books SET title='" & TextBox10.Text & "', cat='" & TextBox2.Text & "',author='" & TextBox4.Text & "',volume='" & TextBox5.Text & "',price='" & TextBox6.Text & "' WHERE  isbn='" & TextBox3.Text & " '"
        Dim cmnds As New OleDbCommand(str, con)
        con.Open()
        cmnds.ExecuteNonQuery()
        con.Close()
        MsgBox("Book Details Updated")


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to delete this record from the Database?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim cmds As New OleDbCommand("DELETE * FROM Books WHERE title = '" & TextBox10.Text & "'", con)

            con.Open()
            cmds.ExecuteReader()
            MessageBox.Show("Record Deleted", "NOTIFICATION")
            con.Close()
        Else
            MessageBox.Show("Record NOT Deleted", "NOTIFICATION")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class