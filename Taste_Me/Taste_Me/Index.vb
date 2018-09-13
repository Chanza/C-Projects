Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Index
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\TasteMe.mdb;")
    Dim query As OleDbCommand
    Dim myfilelocation As String
    Dim newpic As String = ""

    Private Sub Index_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\TasteMe.mdb", FileAttributes.Hidden)
        PictureBox8.Visible = False
        PictureBox11.Visible = False

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        '**************   SELECT CODE  ********************************************************************************
        If TextBox1.Text = ("") Then
            MessageBox.Show("Please Enter User ID", "NOTIFICATION")

        Else

            Dim cmds As New OleDbCommand("select * from Profiles Where uname  = '" & TextBox1.Text & "' ", con)
            Dim x As OleDbDataReader
            con.Open()
            x = cmds.ExecuteReader
            x.Read()
            If TextBox1.Text = x.Item("uname") And TextBox2.Text = x.Item("pword") Then

                MessageBox.Show("WELCOME", "NOTIFICATION")
                Home.Show()

            Else
                MsgBox("Wrong Username/Password")
            End If
            con.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseHover
        PictureBox5.Visible = True

    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Visible = False
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseHover
        PictureBox6.Visible = True
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.Visible = False
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        TabControl1.Visible = False
        PictureBox10.Visible = False
        TextBox1.Visible = True
        TextBox2.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Button3.Visible = True
        PictureBox4.Visible = True

        PictureBox7.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Button4.Visible = False

        PictureBox8.Visible = False
        PictureBox11.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        TabControl1.Visible = True
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Button3.Visible = False
        PictureBox10.Visible = True
        TextBox1.Visible = False
        TextBox2.Visible = False
        PictureBox4.Visible = False

        PictureBox7.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Button4.Visible = False

        PictureBox8.Visible = False
        PictureBox11.Visible = False
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim z As String

        If TextBox3.Text = ("") Then
            z = MessageBox.Show("Please enter Full Name", "NOTIFICATION")
        Else
            If TextBox3.Text.Length < 5 Then
                z = MessageBox.Show("Full name too short", "NOTIFICATION")
            Else
                If TextBox4.Text = ("") Then
                    z = MessageBox.Show("Please enter User ID", "NOTIFICATION")
                Else
                    If TextBox4.Text.Length < 5 Then
                        z = MessageBox.Show("User name too short", "NOTIFICATION")
                    Else
                        If TextBox5.Text.Length < 5 Then
                            z = MessageBox.Show("Password name too short", "NOTIFICATION")
                        Else
                            If TextBox5.Text = ("") Then
                                z = MessageBox.Show("Please enter Password", "NOTIFICATION")
                            Else
                                If TextBox5.Text <> TextBox6.Text Then
                                    z = MessageBox.Show("Passwords do not match", "NOTIFICATION")
                                Else
                                    If ComboBox1.Text = ("") Then
                                        z = MessageBox.Show("Please enter Gender", "NOTIFICATION")
                                    Else
                                            If DateTimePicker1.Value.Year > 1997 Then
                                                z = MessageBox.Show("Must be 18 to register", "NOTIFICATION")
                                            Else
                                                If TextBox11.Text = ("") Then
                                                    z = MessageBox.Show("Please enter a valid email", "NOTIFICATION")
                                                Else
                                                        If TextBox11.Text.Length < 5 Then
                                                            z = MessageBox.Show("Email is too short", "NOTIFICATION")
                                                        Else
                                                            If TextBox13.Text = ("") Then
                                                                z = MessageBox.Show("Please enter a contact number", "NOTIFICATION")
                                                            Else
                                                                If TextBox13.Text.Length < 5 Then
                                                                    z = MessageBox.Show("Contact Number too short", "NOTIFICATION")
                                                                Else



                                                                        '**********THIS IS AN ISNERT CODE***********************************************************
                                                                        Dim x As String
                                                                        x = MessageBox.Show("Are you sure you want to save?", "CONFIRMATION", MessageBoxButtons.YesNo)
                                                                        If x = vbYes Then
                                                                            query = New OleDbCommand("insert into Profiles(fullname,uname,pword,gendr,dob,edress,con,pic)values('" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "','" & TextBox11.Text & "','" & TextBox13.Text & "', '" & myfilelocation & "')", con)

                                                                            con.Open()
                                                                            query.ExecuteNonQuery()
                                                                            con.Close()
                                                                            MessageBox.Show("New User Account Created", "NOTIFICATION")

                                                                            TabControl1.Visible = False
                                                                            PictureBox10.Visible = False
                                                                            TextBox1.Visible = True
                                                                            TextBox2.Visible = True
                                                                            Label10.Visible = True
                                                                            Label11.Visible = True
                                                                            Label12.Visible = True
                                                                            Button3.Visible = True
                                                                            PictureBox4.Visible = True

                                                                            PictureBox7.Visible = False
                                                                            TextBox7.Visible = False
                                                                            TextBox8.Visible = False
                                                                            Label13.Visible = False
                                                                            Label14.Visible = False
                                                                            Button4.Visible = False

                                                                        Else
                                                                            MessageBox.Show("Account Not Saved", "NOTIFICATION")
                                                                            TextBox3.Focus()

                                                                        End If

                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
               
        'End If

    End Sub

    Private Sub Button1_Click_2(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Try
            '**********   THIS IS TO OPEN DIALOG BOX & SELECT AN IMAGE TO UPLOAD INTO THE PICTURE BOX   *****************
            OpenFileDialog1.InitialDirectory = "c:\"
            OpenFileDialog1.Title = "choose image"
            OpenFileDialog1.Filter = "jpg|*.jpg"
            OpenFileDialog1.ShowDialog()
            myfilelocation = OpenFileDialog1.FileName
            PictureBox15.Image = Image.FromFile(myfilelocation)

            OpenFileDialog1.Reset()

        Catch
            MessageBox.Show("Image Not Uploaded", "NOTIFICATION")
        End Try

    End Sub

    Private Sub TabPage1_Click(sender As System.Object, e As System.EventArgs) Handles TabPage1.Click

    End Sub


    Private Sub TextBox2_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged


        'Try

        '    Dim cmds2 As New OleDbCommand("select * from Admin Where ID  = '" & TextBox1.Text & "' ", con)
        '    Dim w As OleDbDataReader
        '    con.Open()
        '    w = cmds2.ExecuteReader
        '    w.Read()
        '    If TextBox1.Text = w.Item("ID") Then

        '        PictureBox8.Visible = True
        '        PictureBox11.Visible = False

        '        con.Close()

        '    Else

        '        Dim cmds As New OleDbCommand("select * from Profiles Where uname  = '" & TextBox1.Text & "' ", con)
        '        Dim x As OleDbDataReader
        '        con.Open()
        '        x = cmds.ExecuteReader
        '        x.Read()
        '        If TextBox1.Text = x.Item("uname") Then

        '            PictureBox8.Visible = True
        '            PictureBox11.Visible = False

        '        Else
        '            If TextBox1.Text = ("") Then

        '                PictureBox8.Visible = False
        '                PictureBox11.Visible = True

        '            Else

        '                PictureBox11.Visible = True
        '                PictureBox8.Visible = False
        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        '    PictureBox11.Visible = True
        '    PictureBox8.Visible = False
        'End Try
        'con.Close()


        '*************  SELECT FROM DATABASE  *******************************************************************
        Try
            Dim cmds2 As New OleDbCommand("select * from Admin Where ID  = '" & TextBox1.Text & "' ", con)
            Dim w As OleDbDataReader
            con.Open()
            w = cmds2.ExecuteReader
            w.Read()
            If TextBox1.Text = w.Item("ID") Then

                PictureBox8.Visible = True
                PictureBox11.Visible = False

            End If
            con.Close()

        Catch ex As Exception

            Try
                con.Close()
                Dim cmds As New OleDbCommand("select * from Profiles Where uname  = '" & TextBox1.Text & "' ", con)
                Dim x As OleDbDataReader
                con.Open()
                x = cmds.ExecuteReader
                x.Read()
                If TextBox1.Text = x.Item("uname") Then

                    PictureBox8.Visible = True
                    PictureBox11.Visible = False

                    con.Close()
                Else
                    PictureBox11.Visible = True
                    PictureBox8.Visible = False
                End If


            Catch ex2 As Exception
                PictureBox11.Visible = True
                PictureBox8.Visible = False
            End Try
            con.Close()
        End Try



    End Sub

    Private Sub Label12_Click_1(sender As System.Object, e As System.EventArgs) Handles Label12.Click
        TextBox7.Visible = True
        TextBox8.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Button4.Visible = True
        PictureBox7.Visible = True

        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Button3.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        PictureBox4.Visible = False

        PictureBox8.Visible = False
        PictureBox11.Visible = False
    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim z As String

        If TextBox1.Text = ("") Then
            z = MessageBox.Show("Please enter your Username", "NOTIFICATION")
        Else
            If TextBox2.Text = ("") Then
                z = MessageBox.Show("Please enter your Password", "NOTIFICATION")
            Else
                


                    'Try
                    'Dim cmds2 As New OleDbCommand("select * from Admin Where ID  = '" & TextBox1.Text & "' ", con)
                    'Dim w As OleDbDataReader
                    'con.Open()
                    'w = cmds2.ExecuteReader
                    'w.Read()
                    'If TextBox1.Text = w.Item("ID") And TextBox2.Text = w.Item("pword") Then

                    '    MessageBox.Show("WELCOME ADMINISTRATOR", "NOTIFICATION")
                    '    AdminHome.Show()
                    '    con.Close()

                    'Else


                    '    Dim cmds As New OleDbCommand("select * from Profiles Where uname  = '" & TextBox1.Text & "' ", con)
                    '    Dim x As OleDbDataReader
                    '    con.Open()
                    '    x = cmds.ExecuteReader
                    '    x.Read()
                    '    If TextBox1.Text = x.Item("uname") And TextBox2.Text = x.Item("pword") Then

                    '        MessageBox.Show("WELCOME", "NOTIFICATION")
                    '        Home.Show()

                    '    Else
                    '        If TextBox1.Text = x.Item("uname") Then
                    '            PictureBox8.Visible = True
                    '            PictureBox11.Visible = False
                    '            MessageBox.Show("Password is Wrong", "NOTIFICATION")

                    '        Else
                    '            MsgBox("Wrong Username/Password")
                    '        End If

                    '        con.Close()
                    '    End If
                    'End If
                    '        Catch ex As Exception
                    '    PictureBox11.Visible = False
                    '    PictureBox8.Visible = False
                    '    MsgBox("Wrong Username/Password")
                    'End Try



                '**********   THIS IS THE SELECT CODE  *******************************************************
                Try
                    Dim cmds2 As New OleDbCommand("select * from Admin Where ID  = '" & TextBox1.Text & "' ", con)
                    Dim w As OleDbDataReader
                    con.Open()
                    w = cmds2.ExecuteReader
                    w.Read()
                    If TextBox1.Text = w.Item("ID") And TextBox2.Text = w.Item("pword") Then

                        MessageBox.Show("WELCOME ADMINISTRATOR", "NOTIFICATION")
                        AdminHome.Show()
                        con.Close()

                    End If
                    con.Close()

                Catch ex As Exception

                    Try
                        con.Close()
                        Dim cmds As New OleDbCommand("select * from Profiles Where uname  = '" & TextBox1.Text & "' ", con)
                        Dim x As OleDbDataReader
                        con.Open()
                        x = cmds.ExecuteReader
                        x.Read()
                        If TextBox1.Text = x.Item("uname") And TextBox2.Text = x.Item("pword") Then

                            MessageBox.Show("        * WELCOME * ", "NOTIFICATION")
                            Home.Show()
                            con.Close()
                            'Me.Hide()

                        Else
                            MsgBox("Wrong Username/Password")
                        End If


                    Catch ex2 As Exception
                        MsgBox("Error: Check Info")
                    End Try
                    con.Close()
                End Try

                '*****************************************************************


            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        PictureBox8.Visible = False
        PictureBox11.Visible = False
    End Sub
End Class