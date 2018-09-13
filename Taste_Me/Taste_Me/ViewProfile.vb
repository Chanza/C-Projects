Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class ViewProfile
    Dim query As OleDbCommand
    Dim myfilelocation As String
    Dim newpic As String = ""
    Dim timercount As Integer = 1
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\TasteMe.mdb;")
    Private Sub ViewProfile_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\TasteMe.mdb", FileAttributes.Hidden)
        Label2.Text = Home.Label9.Text

        Dim cmds As New OleDbCommand("SELECT * FROM Profiles WHERE uname = '" & Label2.Text & "'", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()

        TextBox1.Text = x.Item("fullname")
        TextBox2.Text = x.Item("pword")
        TextBox3.Text = x.Item("edress")
        TextBox4.Text = x.Item("con")
        ComboBox1.Text = x.Item("gendr")
        DateTimePicker1.Text = x.Item("dob")
        PictureBox1.ImageLocation = x.Item("pic")
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try

            OpenFileDialog1.InitialDirectory = "c:\"
            OpenFileDialog1.Title = "choose image"
            OpenFileDialog1.Filter = "jpg|*.jpg"
            OpenFileDialog1.ShowDialog()
            myfilelocation = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(myfilelocation)
            MessageBox.Show("Image has been Uploaded", "NOTIFICATION")
            OpenFileDialog1.Reset()

        Catch
            MessageBox.Show("Image Not Uploaded", "NOTIFICATION")
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        con.Close()
        Dim y As String
        y = MessageBox.Show("Sure you want to save these changes?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim str As String = "UPDATE Profiles SET fullname='" & TextBox1.Text & "',dob='" & DateTimePicker1.Text & "',edress='" & TextBox3.Text & "',gendr='" & ComboBox1.Text & "',con='" & TextBox4.Text & "' WHERE  uname='" & Label2.Text & " '"
            Dim cmnds As New OleDbCommand(str, con)
            con.Open()
            cmnds.ExecuteNonQuery()

            MessageBox.Show("Changes Saved", "NOTIFICATION")
            con.Close()
        Else
            MessageBox.Show("Changes Not Saved", "NOTIFICATION")

        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim y As String
        y = MessageBox.Show("Sure you want to delete this Profile?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            con.Close()
            Dim cmds As New OleDbCommand("DELETE * FROM Profiles WHERE uname = '" & Label2.Text & "'", con)

            con.Open()

            cmds.ExecuteReader()
            MessageBox.Show("Profile Deleted", "NOTIFICATION")
            con.Close()
            Me.Close()
            Home.Close()
        Else
            MessageBox.Show("Profile NOT Deleted", "NOTIFICATION")
            con.Close()

        End If
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 1
    End Sub

    Private Sub PictureBox12_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox12.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 2
    End Sub

    Private Sub PictureBox13_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox13.Click
        Dim i As Integer = 1
        TabControl1.SelectedIndex = i - 1
    End Sub

    Private Sub PictureBox14_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox14.Click
        Dim i As Integer = 2
        TabControl1.SelectedIndex = i - 1
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        TextBox2.Visible = True
        TextBox5.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Button6.Visible = True
        PictureBox3.Visible = True
        PictureBox2.Visible = True

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        con.Close()
        Dim n As String
        n = MessageBox.Show("Change Password?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If n = vbNo Then

            MessageBox.Show("Not Changed", "NOTIFICATION")
        Else

            If TextBox5.Text = TextBox2.Text Then
                Dim str As String = "UPDATE Profiles SET pword='" & TextBox2.Text & "' WHERE  uname='" & Label2.Text & " '"
                Dim cmnds As New OleDbCommand(str, con)
                con.Open()
                cmnds.ExecuteNonQuery()

                MessageBox.Show("Password Changed", "NOTIFICATION")
                con.Close()
                TextBox2.Visible = False
                TextBox5.Visible = False
                Label3.Visible = False
                Label4.Visible = False
                Button6.Visible = False
                PictureBox3.Visible = False
                PictureBox2.Visible = False
            Else
                MessageBox.Show("Passwords do not Match", "NOTIFICATION")
                con.Close()
            End If
        End If



        'Dim n As String
        'n = MessageBox.Show("Change Password?", "CONFIRMATION", MessageBoxButtons.YesNo)
        'If n = vbNo Then

        '    If TextBox5.Text = TextBox2.Text Then
        '        Dim str As String = "UPDATE Profiles SET pword='" & TextBox2.Text & "' WHERE  uname='" & Label2.Text & " '"
        '        Dim cmnds As New OleDbCommand(str, con)
        '        con.Open()
        '        cmnds.ExecuteNonQuery()

        '        MessageBox.Show("Password Changed", "NOTIFICATION")
        '        con.Close()
        '    Else
        '        MessageBox.Show("Not Changed", "NOTIFICATION")

        '        else

        '        MessageBox.Show("Passwords do not Match", "NOTIFICATION")
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        TextBox2.Visible = False
        TextBox5.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Button6.Visible = False
        PictureBox3.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        con.Close()
        Dim y As String
        y = MessageBox.Show("Sure you want to save these changes?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim str As String = "UPDATE Profiles SET pic='" & myfilelocation & "' WHERE  uname='" & Label2.Text & " '"
            Dim cmnds As New OleDbCommand(str, con)
            con.Open()
            cmnds.ExecuteNonQuery()

            MessageBox.Show("Saved", "NOTIFICATION")
            con.Close()
        Else
            MessageBox.Show("Not Saved", "NOTIFICATION")
        End If
    End Sub
End Class