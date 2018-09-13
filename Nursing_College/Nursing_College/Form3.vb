Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form3
    Dim newpic As String = ""
    Dim imagelocation As String
    Dim myfilelocation As String

    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\NursingC.mdb;")
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\NursingC.mdb", FileAttributes.Hidden)

        Form2.Label4.Visible = False
        TextBox2.Text = Form2.TextBox1.Text

        Dim cmds As New OleDbCommand("SELECT * FROM staff WHERE ID = '" & TextBox2.Text & "'", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()

        TextBox1.Text = x.Item("uname")
        'TextBox2.Text = x.Item("ID")
        TextBox3.Text = x.Item("pword")
        TextBox4.Text = x.Item("pword")
        ComboBox1.Text = x.Item("gender")
        DateTimePicker1.Text = x.Item("bdate")
        TextBox5.Text = x.Item("email")
        TextBox6.Text = x.Item("mobile")
        TextBox7.Text = x.Item("cert")
        TextBox8.Text = x.Item("sub")
        TextBox9.Text = x.Item("dept")
        TextBox10.Text = x.Item("salary")
        TextBox12.Text = x.Item("loc")
        DateTimePicker2.Text = x.Item("hiredate")
        TextBox11.Text = x.Item("adress")
        ComboBox2.Text = x.Item("cal")
        PictureBox1.ImageLocation = x.Item("Pic")

        'con.Close()
    End Sub
    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 1
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 2
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim i As Integer = 1
        TabControl1.SelectedIndex = i - 1
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Dim i As Integer = 2
        TabControl1.SelectedIndex = i - 1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to delete this User from the Database?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim cmds As New OleDbCommand("DELETE * FROM staff WHERE ID = '" & TextBox2.Text & "'", con)

            'con.Open()

            cmds.ExecuteReader()
            MessageBox.Show("Profile Deleted", "NOTIFICATION")
            'con.Close()
            Me.Close()
        Else
            MessageBox.Show("Profile NOT Deleted", "NOTIFICATION")
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to delete this User from the Database?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim cmds As New OleDbCommand("DELETE * FROM staff WHERE ID = '" & TextBox2.Text & "'", con)

            'con.Open()

            cmds.ExecuteReader()
            MessageBox.Show("Profile Deleted", "NOTIFICATION")
            'con.Close()
            Me.Close()
        Else
            MessageBox.Show("Profile NOT Deleted", "NOTIFICATION")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to delete this User from the Database?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim cmds As New OleDbCommand("DELETE * FROM staff WHERE ID = '" & TextBox2.Text & "'", con)

            'con.Open()

            cmds.ExecuteReader()
            MessageBox.Show("Profile Deleted", "NOTIFICATION")
            'con.Close()
            Me.Close()
        Else
            MessageBox.Show("Profile NOT Deleted", "NOTIFICATION")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox3.Text = TextBox4.Text Then

            Dim y As String
            y = MessageBox.Show("Are you sure you want to save these changes?", "CONFIRMATION", MessageBoxButtons.YesNo)
            If y = vbYes Then
                Dim str As String = "UPDATE staff SET bdate='" & DateTimePicker1.Text & "', uname='" & TextBox1.Text & "',pword='" & TextBox3.Text & "',gender='" & ComboBox1.Text & "',email='" & TextBox5.Text & "',mobile='" & TextBox6.Text & "',cert='" & TextBox7.Text & "',sub='" & TextBox8.Text & "',dept='" & TextBox9.Text & "',salary='" & TextBox10.Text & "',loc='" & TextBox12.Text & "',hiredate='" & DateTimePicker2.Text & "',adress='" & TextBox11.Text & "',cal='" & ComboBox2.Text & "' WHERE  ID='" & TextBox2.Text & " '"
                Dim cmnds As New OleDbCommand(str, con)
                'con.Open()
                cmnds.ExecuteNonQuery()
                MessageBox.Show("Changes Saved", "NOTIFICATION")
                'con.Close()
            Else
                MessageBox.Show("Changes Not Saved", "NOTIFICATION")

            End If
        Else
            MessageBox.Show("Check Password", "NOTIFICATION")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox3.Text = TextBox4.Text Then

            Dim y As String
            y = MessageBox.Show("Are you sure you want to save these changes?", "CONFIRMATION", MessageBoxButtons.YesNo)
            If y = vbYes Then
                Dim str As String = "UPDATE staff SET uname='" & TextBox1.Text & "',bdate='" & DateTimePicker1.Text & "',pword='" & TextBox3.Text & "',gender='" & ComboBox1.Text & "',email='" & TextBox5.Text & "',mobile='" & TextBox6.Text & "',cert='" & TextBox7.Text & "',sub='" & TextBox8.Text & "',dept='" & TextBox9.Text & "',salary='" & TextBox10.Text & "',loc='" & TextBox12.Text & "',hiredate='" & DateTimePicker2.Text & "',adress='" & TextBox11.Text & "',cal='" & ComboBox2.Text & "',pic='" & myfilelocation & "' WHERE  ID='" & TextBox2.Text & " '"
                Dim cmnds As New OleDbCommand(str, con)
                'con.Open()
                cmnds.ExecuteNonQuery()

                MessageBox.Show("Changes Saved", "NOTIFICATION")
                'con.Close()
            Else
                MessageBox.Show("Changes Not Saved", "NOTIFICATION")

            End If
        Else
            MessageBox.Show("Check Password", "NOTIFICATION")

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox3.Text = TextBox4.Text Then

            Dim y As String
            y = MessageBox.Show("Are you sure you want to save these changes?", "CONFIRMATION", MessageBoxButtons.YesNo)
            If y = vbYes Then
                Dim str As String = "UPDATE staff SET bdate='" & DateTimePicker1.Text & "', uname='" & TextBox1.Text & "',pword='" & TextBox3.Text & "',gender='" & ComboBox1.Text & "',email='" & TextBox5.Text & "',mobile='" & TextBox6.Text & "',cert='" & TextBox7.Text & "',sub='" & TextBox8.Text & "',dept='" & TextBox9.Text & "',salary='" & TextBox10.Text & "',loc='" & TextBox12.Text & "',hiredate='" & DateTimePicker2.Text & "',adress='" & TextBox11.Text & "',cal='" & ComboBox2.Text & "' WHERE  ID='" & TextBox2.Text & " '"
                Dim cmnds As New OleDbCommand(str, con)
                'con.Open()
                cmnds.ExecuteNonQuery()
                MessageBox.Show("Changes Saved", "NOTIFICATION")
                'con.Close()
            Else
                MessageBox.Show("Changes Not Saved", "NOTIFICATION")
            End If
        Else
            MessageBox.Show("Check Password", "NOTIFICATION")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.InitialDirectory = "c:\"
        OpenFileDialog1.Title = "choose image"
        OpenFileDialog1.Filter = "jpg|*.jpg"
        OpenFileDialog1.ShowDialog()
        myfilelocation = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(myfilelocation)
        MessageBox.Show("Image has been Uploaded", "NOTIFICATION")
        OpenFileDialog1.Reset()
        con.Close()
    End Sub
End Class