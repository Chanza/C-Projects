Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form14
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\lib.mdb;")
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\lib.mdb", FileAttributes.Hidden)
        If Form1.CheckBox1.Checked = True Then

            TextBox3.Text = Form3.TextBox1.Text

            Dim cmds As New OleDbCommand("SELECT * FROM Profile1 WHERE uname = '" & TextBox3.Text & "'", con)
            Dim x As OleDbDataReader
            con.Open()
            x = cmds.ExecuteReader()
            x.Read()
            TextBox1.Text = x.Item("fname")
            TextBox2.Text = x.Item("sname")
            TextBox4.Text = x.Item("pword")
            TextBox8.Text = x.Item("em")
            TextBox9.Text = x.Item("mob")
            TextBox10.Text = x.Item("adrs")
            TextBox6.Text = x.Item("birth")
            ComboBox1.Text = x.Item("gender")
            con.Close()
        Else
            TextBox3.Text = Form11.TextBox1.Text
            Dim cmds As New OleDbCommand("SELECT * FROM Profile2 WHERE uname = '" & TextBox3.Text & "'", con)
            Dim x As OleDbDataReader
            con.Open()
            x = cmds.ExecuteReader()
            x.Read()
            TextBox1.Text = x.Item("fname")
            TextBox2.Text = x.Item("sname")
            TextBox4.Text = x.Item("pword")
            TextBox8.Text = x.Item("em")
            TextBox9.Text = x.Item("mob")
            TextBox10.Text = x.Item("adrs")
            TextBox6.Text = x.Item("birth")
            ComboBox1.Text = x.Item("gender")
            con.Close()
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Form1.CheckBox1.Checked = True Then
            Form4.BringToFront()
            Me.Close()
        Else
            Form12.BringToFront()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If Form1.CheckBox1.Checked = True Then

        '    If TextBox4.Text = TextBox5.Text Then
        '        Dim x As String
        '        x = MessageBox.Show("Are you sure you want to save?", "CONFIRMATION", MessageBoxButtons.YesNo)
        '        If x = vbYes Then

        '            Dim str As String = "UPDATE Profile1 SET fname='" & TextBox1.Text & "', sname='" & TextBox2.Text & "',pword='" & TextBox4.Text & "',em='" & TextBox8.Text & "',mob='" & TextBox9.Text & "',adrs='" & TextBox10.Text & "',birth='" & TextBox6.Text & "',gender='" & ComboBox1.Text & "' WHERE  uname='" & TextBox3.Text & " '"
        '            Dim cmnds As New OleDbCommand(str, con)
        '            con.Open()
        '            cmnds.ExecuteNonQuery()
        '            con.Close()
        '            MsgBox("Profile Updated")
        '        Else
        '            MessageBox.Show("Please Re-enter Password", "NOTIFICATION", MessageBoxButtons.YesNo)
        '            TextBox2.Focus()

        '        End If
        '    End If

        'Else

        '    If TextBox4.Text = TextBox5.Text Then
        '        Dim x As String
        '        x = MessageBox.Show("Are you sure you want to save?", "CONFIRMATION", MessageBoxButtons.YesNo)
        '        If x = vbYes Then

        '            Dim str As String = "UPDATE Profile2 SET fname='" & TextBox1.Text & "', sname='" & TextBox2.Text & "',pword='" & TextBox4.Text & "',em='" & TextBox8.Text & "',mob='" & TextBox9.Text & "',adrs='" & TextBox10.Text & "',birth='" & TextBox6.Text & "',gender='" & ComboBox1.Text & " where  uname='" & TextBox3.Text & "'"
        '            Dim cmnds As New OleDbCommand(str, con)
        '            con.Open()
        '            cmnds.ExecuteNonQuery()
        '            con.Close()
        '            MsgBox("Profile Updated")
        '        Else
        '            MessageBox.Show("Please Re-enter Password", "NOTIFICATION", MessageBoxButtons.YesNo)
        '            TextBox2.Focus()

        '        End If
        '    End If
        'End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
            Form7.Close()
            Form8.Close()
            Form9.Close()
            Form10.Close()
            Form11.Close()
            Form12.Close()
            Form13.Close()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Form1.CheckBox1.Checked = True Then

            If TextBox4.Text = TextBox5.Text Then
                Dim x As String
                x = MessageBox.Show("Are you sure you want to save?", "CONFIRMATION", MessageBoxButtons.YesNo)
                If x = vbYes Then

                    Dim str As String = "UPDATE Profile1 SET fname='" & TextBox1.Text & "', sname='" & TextBox2.Text & "',pword='" & TextBox4.Text & "',em='" & TextBox8.Text & "',mob='" & TextBox9.Text & "',adrs='" & TextBox10.Text & "',birth='" & TextBox6.Text & "',gender='" & ComboBox1.Text & "' WHERE  uname='" & TextBox3.Text & " '"
                    Dim cmnds As New OleDbCommand(str, con)
                    con.Open()
                    cmnds.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Profile Updated")
                Else
                    MessageBox.Show("Please Re-enter Password", "NOTIFICATION", MessageBoxButtons.YesNo)
                    TextBox2.Focus()

                End If
            End If

        Else

            If TextBox4.Text = TextBox5.Text Then
                Dim x As String
                x = MessageBox.Show("Are you sure you want to save?", "CONFIRMATION", MessageBoxButtons.YesNo)
                If x = vbYes Then

                    Dim str As String = "UPDATE Profile2 SET fname='" & TextBox1.Text & "', sname='" & TextBox2.Text & "',pword='" & TextBox4.Text & "',em='" & TextBox8.Text & "',mob='" & TextBox9.Text & "',adrs='" & TextBox10.Text & "',birth='" & TextBox6.Text & "',gender='" & ComboBox1.Text & " where  uname='" & TextBox3.Text & "'"
                    Dim cmnds As New OleDbCommand(str, con)
                    con.Open()
                    cmnds.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Profile Updated")
                Else
                    MessageBox.Show("Please Re-enter Password", "NOTIFICATION", MessageBoxButtons.YesNo)
                    TextBox2.Focus()

                End If
            End If
        End If
    End Sub
End Class