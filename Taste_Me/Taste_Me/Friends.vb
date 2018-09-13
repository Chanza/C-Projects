Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Friends
    Dim query As OleDbCommand
    Dim myfilelocation As String
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\TasteMe.mdb;")
    Private Sub Friends_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\TasteMe.mdb", FileAttributes.Hidden)

        'Dim ds1 As New DataSet
        'Dim dr1 As DataRow
        'Dim dt1 As New DataTable
        'Dim adptr1 As New OleDbDataAdapter("select * from Friends  where fren1 = '" & Home.Label9.Text & "' and status = 'pending'", con)
        'adptr1.Fill(ds1, "Friends where fren1 = '" & Home.Label9.Text & "' and status ='pending'")
        'dt1 = ds1.Tables(0)



        Dim ds2 As New DataSet
        Dim dr2 As DataRow
        Dim dt2 As New DataTable
        Dim adptr2 As New OleDbDataAdapter("select * from Friends  where fren2 = '" & Home.Label9.Text & "' and status ='pending'", con)
        adptr2.Fill(ds2, "Friends where fren2 = '" & Home.Label9.Text & "' and status = 'pending'")
        dt2 = ds2.Tables(0)

        For Each dr2 In dt2.Rows
            ComboBox2.Items.Add(dr2.Item("fren1"))
            'ComboBox1.Items.Add(dr1.Item("fren1"))
        Next

        'For Each dr1 In dt1.Rows
        '    ComboBox2.Items.Add(dr1.Item("fren2"))
        '    'ComboBox1.Items.Add(dr1.Item("fren1"))
        'Next

    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Dim cmds2 As New OleDbCommand("SELECT * FROM Profiles WHERE uname = '" & TextBox2.Text & "'", con)
        Dim z As OleDbDataReader
        con.Open()
        z = cmds2.ExecuteReader()
        z.Read()

        If TextBox2.Text = "" Then
            Label3.Visible = True
            PictureBox10.Visible = False
            TabControl1.Visible = False
            Button4.Visible = False
        Else

            If TextBox2.Text = Home.Label9.Text Then

                Label3.Visible = True
                PictureBox10.Visible = False
                TabControl1.Visible = False

                Button8.Visible = False
                Button1.Visible = False
                Button4.Visible = False
                Button6.Visible = False
            Else
                'Try
                If TextBox2.Text = z.Item("uname") Then

                    TextBox5.Text = z.Item("uname")
                    TextBox1.Text = z.Item("fullname")
                    TextBox7.Text = z.Item("gendr")
                    TextBox8.Text = z.Item("dob")
                    TextBox3.Text = z.Item("edress")
                    TextBox4.Text = z.Item("con")
                    PictureBox1.ImageLocation = z.Item("Pic")

                    TabControl1.Visible = True
                    PictureBox10.Visible = True


                    con.Close()

                    Dim cmds3 As New OleDbCommand("select * from Friends WHERE fren1 = '" & TextBox2.Text & "' and status = 'pending'", con)
                    Dim s As OleDbDataReader
                    con.Open()
                    s = cmds3.ExecuteReader
                    s.Read()
                    If Home.Label9.Text = s.Item("fren2") Then

                        'Label12.Visible = False
                        Button8.Visible = True
                        Button1.Visible = True

                    End If
                    con.Close()

                    Dim cmds4 As New OleDbCommand("select * from Friends WHERE fren1 = '" & Home.Label9.Text & "' and status = 'accepted'", con)
                    Dim t As OleDbDataReader
                    con.Open()
                    t = cmds4.ExecuteReader
                    t.Read()
                    If TextBox2.Text = t.Item("fren2") Then

                        Label12.Visible = False
                        Button6.Visible = True


                    Else
                        con.Close()

                        Dim cmds5 As New OleDbCommand("select * from Friends WHERE fren2 = '" & Home.Label9.Text & "' and status = 'accepted'", con)
                        Dim r As OleDbDataReader
                        con.Open()
                        r = cmds5.ExecuteReader
                        r.Read()
                        If TextBox2.Text = r.Item("fren1") Then

                            Label12.Visible = False
                            Button6.Visible = True


                        End If
                    End If
                    con.Close()

                Else
                    Label3.Visible = True
                End If

                    'Catch ex2 As Exception
                    '    Label3.Visible = True
                    'End Try
                    con.Close()

            End If
        End If
        con.Close()


        'Dim cmds As New OleDbCommand("select * from Friends WHERE fren1 = '" & TextBox2.Text & "'", con)
        'Dim w As OleDbDataReader
        'con.Open()
        'w = cmds.ExecuteReader
        'w.Read()
        'If TextBox2.Text = w.Item("fren2") Then

        '    Label12.Visible = False
        'End If

        'If TextBox9.Text = w.Item("fren2") Then

        '    MessageBox.Show("WELCOME ADMINISTRATOR", "NOTIFICATION")

        '    con.Close()
        'End If
        'End If
        con.Close()

        'Dim cmds3 As New OleDbCommand("select * from Friends", con)
        'Dim y As OleDbDataReader
        'con.Open()
        'y = cmds3.ExecuteReader
        'y.Read()



        'If TextBox2.Text = y.Item("fren2") Then
        '    Label12.Text = "1"
        'Else
        '    Label12.Text = "2"
        'End If




        '        'Button4.Visible = True


        'Dim cmds3 As New OleDbCommand("select * from Friends  where fren1 = '" & Home.Label9.Text & "'", con)
        'Dim y As OleDbDataReader
        'con.Open()
        'y = cmds3.ExecuteReader
        'y.Read()


        ''If ComboBox5.Text = y.Item("fren1") Then
        'If TextBox2.Text = y.Item("fren2") And Home.Label9.Text = y.Item("fren1") Then
        '    'Label37.Text = "1"

        '    ''Label34.Text = "1"
        '    con.Close()
        '    Dim cmds As New OleDbCommand("SELECT * FROM Friends WHERE fren2 = '" & TextBox2.Text & "' and fren1 = '" & Home.Label9.Text & "'", con)
        '    Dim x As OleDbDataReader
        '    con.Open()
        '    x = cmds.ExecuteReader()
        '    x.Read()
        '    Label12.Text = x.Item("status")
        '    con.Close()
        '    'Label37.Text = "1"
        '    ''Chat.Close()

        'Else

        '    'Label37.Text = "2"

        '    con.Close()
        '    Dim cmds As New OleDbCommand("SELECT * FROM Friends WHERE fren1 = '" & TextBox2.Text & "' and fren2 = '" & Home.Label9.Text & "'", con)
        '    Dim x As OleDbDataReader
        '    con.Open()
        '    x = cmds.ExecuteReader()
        '    x.Read()
        '    Label12.Text = x.Item("status")
        '    con.Close()
        'Label37.Text = "2"
        'Chat.Close()

        'Else

        '    MessageBox.Show("User Not Found", "NOTIFICATION")

        'End If


        'If Label13.Text = "pending" Then
        '    Button8.Visible = True
        '    Button1.Visible = True
        '    Button4.Visible = False
        '    Button6.Visible = False
        'Else

        '    If Label13.Text = "accepted" Then
        '        Button8.Visible = False
        '        Button1.Visible = False
        '        Button4.Visible = False
        '        Button6.Visible = True
        '    Else
        '        If Label13.Text = "denied" Then
        '            Button8.Visible = False
        '            Button1.Visible = False
        '            Button4.Visible = False
        '            Button6.Visible = False
        '        Else
        '            Button8.Visible = False
        '            Button1.Visible = False
        '            Button4.Visible = True
        '            Button6.Visible = False

        '        End If
        '    End If
        'End If

        'con.Close()







        '            Else






        '                Label3.Visible = True
        '                PictureBox10.Visible = False
        '                TabControl1.Visible = False
        '                Button4.Visible = False
        '            End If
        '        End If
        '    End If
        'End If

        'con.Close()


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Label13.Text = "1"
        DataGridView1.Rows.Clear()

        Dim str As String
        Dim r As OleDbDataReader
        str = "SELECT * FROM Friends"
        Dim i As Integer
        i = 0
        con.Open()
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader
        Do While r.Read()
            DataGridView1.RowCount = DataGridView1.RowCount + 1
            i = i + 1
        Loop
        query.Dispose()
        str = "SELECT * FROM Friends WHERE fren2 = '" & Home.Label9.Text & "' and status = 'accepted'"
        i = 0
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader
        Do While r.Read()
            DataGridView1.Item(0, i).Value = r("fren1")

            i = i + 1
        Loop
        con.Close()



        Dim str2 As String
        Dim r2 As OleDbDataReader
        str2 = "SELECT * FROM Friends"
        'Dim i As Integer
        i = 0
        con.Open()
        query = New OleDbCommand(str2, con)
        r2 = query.ExecuteReader
        Do While r2.Read()
            DataGridView1.RowCount = DataGridView1.RowCount + 1
            i = i + 1
        Loop
        query.Dispose()
        str2 = "SELECT * FROM Friends WHERE fren1 = '" & Home.Label9.Text & "' and status = 'accepted'"
        i = 0
        query = New OleDbCommand(str2, con)
        r2 = query.ExecuteReader
        Do While r2.Read()
            DataGridView1.Item(0, i).Value = r2("fren2")

            i = i + 1
        Loop
        con.Close()

        DataGridView1.Visible = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Label3.Visible = False
        Label13.Text = "null"
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 1
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 1
    End Sub

    Private Sub PictureBox13_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox13.Click
        Dim i As Integer = 1
        TabControl1.SelectedIndex = i - 1
    End Sub

    Private Sub PictureBox12_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox12.Click
        Dim i As Integer = 1
        TabControl1.SelectedIndex = i - 1
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        con.Close()

        Dim cmds2 As New OleDbCommand("SELECT * FROM Profiles WHERE uname = '" & ComboBox2.Text & "'", con)
        Dim z As OleDbDataReader
        con.Open()
        z = cmds2.ExecuteReader()
        z.Read()

        TextBox5.Text = z.Item("uname")
        TextBox1.Text = z.Item("fullname")
        TextBox7.Text = z.Item("gendr")
        TextBox8.Text = z.Item("dob")
        TextBox3.Text = z.Item("edress")
        TextBox4.Text = z.Item("con")
        PictureBox1.ImageLocation = z.Item("Pic")

        TabControl1.Visible = True
        PictureBox10.Visible = True
        Button1.Visible = True
        Button8.Visible = True

        Button4.Visible = False
        Button6.Visible = False
        Label3.Visible = False
        DataGridView1.Visible = False

        con.Close()


        Dim cmds3 As New OleDbCommand("select * from Friends", con)
        Dim y As OleDbDataReader
        con.Open()
        y = cmds3.ExecuteReader
        y.Read()


        'If ComboBox5.Text = y.Item("fren1") Then
        If ComboBox2.SelectedItem = y.Item("fren2") And Home.Label9.Text = y.Item("fren1") Then

            Label4.Text = "1"
            con.Close()
            Dim cmds As New OleDbCommand("SELECT * FROM Friends WHERE fren2 = '" & ComboBox2.Text & "' and fren1 = '" & Home.Label9.Text & "'", con)
            Dim x As OleDbDataReader
            con.Open()
            x = cmds.ExecuteReader()
            x.Read()
            Label11.Text = x.Item("ID")
            con.Close()
            'Label37.Text = "1"
            ''Chat.Close()

        Else

            'If Label9.Text = y.Item("fren2") And ComboBox1.SelectedItem = y.Item("fren1") Then
            Label4.Text = "2"

            con.Close()
            Dim cmds4 As New OleDbCommand("SELECT * FROM Friends WHERE fren1 = '" & ComboBox2.Text & "' and fren2 = '" & Home.Label9.Text & "'", con)
            Dim j As OleDbDataReader
            con.Open()
            j = cmds4.ExecuteReader()
            j.Read()
            Label11.Text = j.Item("ID")
            con.Close()
            'Label37.Text = "2"
            'Chat.Close()

            'Else

            '    MessageBox.Show("User Not Found", "NOTIFICATION")

        End If

        'End If

        con.Close()

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim y As String
        y = MessageBox.Show("Add Friend?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim str As String = "UPDATE Friends SET status ='accepted' WHERE  ID=" & Label11.Text & " "
            Dim cmnds As New OleDbCommand(str, con)
            con.Open()
            cmnds.ExecuteNonQuery()
            MessageBox.Show("Accept", "NOTIFICATION")
            con.Close()

            TabControl1.Visible = False
            PictureBox10.Visible = False
            Button1.Visible = False
            Button8.Visible = False
        Else
            MessageBox.Show("Not Accepted", "NOTIFICATION")

        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim y As String
        y = MessageBox.Show("Deny Request?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim str As String = "UPDATE Friends SET status ='denied' WHERE  ID=" & Label11.Text & " "
            Dim cmnds As New OleDbCommand(str, con)
            con.Open()
            cmnds.ExecuteNonQuery()
            MessageBox.Show("Denied", "NOTIFICATION")
            con.Close()

            TabControl1.Visible = False
            PictureBox10.Visible = False
            Button1.Visible = False
            Button8.Visible = False
        Else
            MessageBox.Show("Not Denied", "NOTIFICATION")

        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        'If TextBox3.Text = TextBox4.Text Then
        Dim x As String
        x = MessageBox.Show("Send Request?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If x = vbYes Then

            query = New OleDbCommand("insert into Friends(fren1,fren2,status)values('" & Home.Label9.Text & "','" & TextBox2.Text & "','pending')", con)
            con.Open()
            query.ExecuteNonQuery()
            'System.IO.File.Copy(OpenFileDialog1.FileName, Application.StartupPath + newpic)
            con.Close()
            MessageBox.Show("Sent", "NOTIFICATION")

            TabControl1.Visible = False
            PictureBox10.Visible = False
            Button4.Visible = False

        Else
            MessageBox.Show("Not Sent", "NOTIFICATION")
            TextBox1.Focus()

        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.Label12.Text = DataGridView1.Item(0, i).Value



        Dim cmds2 As New OleDbCommand("SELECT * FROM Profiles WHERE uname = '" & Label12.Text & "'", con)
        Dim z As OleDbDataReader
        con.Open()
        z = cmds2.ExecuteReader()
        z.Read()

        TextBox5.Text = z.Item("uname")
        TextBox1.Text = z.Item("fullname")
        TextBox7.Text = z.Item("gendr")
        TextBox8.Text = z.Item("dob")
        TextBox3.Text = z.Item("edress")
        TextBox4.Text = z.Item("con")
        PictureBox1.ImageLocation = z.Item("Pic")

        TabControl1.Visible = True
        PictureBox10.Visible = True

        If Label12.Text = Home.Label9.Text Then
            Button6.Visible = False
        Else
            If Label13.Text = "1" Then
                Button6.Visible = True
            Else
                Button4.Visible = True
                Button6.Visible = False
            End If
        End If

        'Button4.Visible = False
        Button8.Visible = False
        Button1.Visible = False
        Label3.Visible = False


        con.Close()

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Try
            Dim y As String
            y = MessageBox.Show("Delete Friend?", "CONFIRMATION", MessageBoxButtons.YesNo)
            If y = vbYes Then
                Dim str As String = "UPDATE Friends SET status ='denied' WHERE  ID=" & Label11.Text & " "
                Dim cmnds As New OleDbCommand(str, con)
                con.Open()
                cmnds.ExecuteNonQuery()
                MessageBox.Show("Delete", "NOTIFICATION")
                con.Close()

                TabControl1.Visible = False
                PictureBox10.Visible = False
                Button1.Visible = False
                Button8.Visible = False
            Else
                MessageBox.Show("Not Deleted", "NOTIFICATION")
            End If
        Catch ex2 As Exception
            MsgBox("User Unfriended")
        End Try
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Label13.Text = "2"
        DataGridView1.Rows.Clear()

        Dim str As String
        Dim r As OleDbDataReader
        str = "SELECT * FROM Profiles"
        Dim i As Integer
        i = 0
        con.Open()
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader
        Do While r.Read()
            DataGridView1.RowCount = DataGridView1.RowCount + 1
            i = i + 1
        Loop
        query.Dispose()
        str = "SELECT * FROM Profiles"
        i = 0
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader
        Do While r.Read()
            DataGridView1.Item(0, i).Value = r("uname")

            i = i + 1
        Loop
        con.Close()

        DataGridView1.Visible = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs)
        'con.Close()

        'Dim cmds2 As New OleDbCommand("select * from Friends  where fren1 = '" & TextBox9.Text & "'", con)
        'Dim y As OleDbDataReader
        'con.Open()
        'y = cmds2.ExecuteReader
        'y.Read()


        ''If ComboBox5.Text = y.Item("fren1") Then
        'If TextBox10.Text = y.Item("fren2") And TextBox9.Text = y.Item("fren1") Then
        '    Label13.Text = "1"

        '    ''Label34.Text = "1"
        '    con.Close()
        '    Dim cmds As New OleDbCommand("SELECT * FROM Friends WHERE fren2 = '" & TextBox10.Text & "' and fren1 = '" & TextBox9.Text & "'", con)
        '    Dim x As OleDbDataReader
        '    con.Open()
        '    x = cmds.ExecuteReader()
        '    x.Read()
        '    'Label12.Text = x.Item("status")
        '    con.Close()
        '    'Label37.Text = "1"
        '    ''Chat.Close()

        'Else

        '    'If Label9.Text = y.Item("fren2") And ComboBox1.SelectedItem = y.Item("fren1") Then
        '    Label13.Text = "2"

        '    con.Close()
        '    Dim cmds As New OleDbCommand("SELECT * FROM Friends WHERE fren1 = '" & TextBox10.Text & "' and fren2 = '" & TextBox9.Text & "'", con)
        '    Dim x As OleDbDataReader
        '    con.Open()
        '    x = cmds.ExecuteReader()
        '    x.Read()
        '    'Label12.Text = x.Item("status")
        '    con.Close()
        '    'Label37.Text = "2"
        '    'Chat.Close()

        '    'Else

        '    '    MessageBox.Show("User Not Found", "NOTIFICATION")

        'End If
        'con.Close()


        Dim cmds As New OleDbCommand("select * from Friends Where status  = 'pending'", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader
        x.Read()
        If Home.Label9.Text = x.Item("fren1") Then

            MessageBox.Show("WELCOME", "NOTIFICATION")


        End If
        con.Close()


    End Sub
End Class