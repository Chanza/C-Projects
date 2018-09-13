Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Home
    Dim query As OleDbCommand
    Dim myfilelocation As String
    Dim newpic As String = ""
    Dim timercount As Integer = 1
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\TasteMe.mdb;")

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        If Label37.Text = "1" Then

            Label36.Text = ComboBox1.Text
            DataGridView2.Refresh()
            DataGridView2.Visible = True
            Label36.Visible = True
            Button5.Visible = True
            Button6.Visible = True
            Button7.Visible = True
            TextBox4.Visible = True
            ComboBox1.ResetText()

        Else

            If Label37.Text = "2" Then

                Label36.Text = ComboBox1.Text
                DataGridView2.Refresh()
                DataGridView2.Visible = True
                Label36.Visible = True
                Button5.Visible = True
                Button6.Visible = True
                Button7.Visible = True
                TextBox4.Visible = True
                ComboBox1.ResetText()

            Else

                DataGridView2.Visible = False
                Label36.Visible = False
                Button5.Visible = False
                Button6.Visible = False
                Button7.Visible = False
                TextBox4.Clear()
                TextBox4.Visible = False
                MessageBox.Show("User Not Found", "NOTIFICATION")

            End If
        End If

        DataGridView2.Rows.Clear()

        Dim str As String
        Dim r As OleDbDataReader
        str = "SELECT * FROM Msg"
        Dim i As Integer
        i = 0
        con.Open()
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader
        Do While r.Read()
            DataGridView2.RowCount = DataGridView2.RowCount + 1
            i = i + 1
        Loop
        query.Dispose()
        str = "SELECT * FROM Msg WHERE msgID = '" & Label33.Text & "'"
        i = 0
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader

        Do While r.Read()
            DataGridView2.Item(0, i).Value = r("det")
            DataGridView2.Item(1, i).Value = r("det")
            DataGridView2.Item(2, i).Value = r("ID")

            'DataGridView1.Item(5, i).Value = r("rd")

            If r("sen") = Label36.Text Then
                DataGridView2.Item(1, i).Value = " "

            Else
                DataGridView2.Item(0, i).Value = " "


            End If

            'If r("rd") < Today Then
            '    DataGridView1.Item(6, i).Value = "Overdue"
            'End If

            i = i + 1
        Loop
        con.Close()

        TextBox4.Clear()



        DataGridView2.Sort(DataGridView2.Columns(2), System.ComponentModel.ListSortDirection.Ascending)


        'Scroll to the last row.
        Me.DataGridView2.FirstDisplayedScrollingRowIndex = Me.DataGridView2.RowCount - 1

        'Select the last row.
        Me.DataGridView2.Rows(Me.DataGridView2.RowCount - 1).Selected = True


        Timer2.Enabled = True

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs)
        Reciepes.Show()
    End Sub

    Private Sub Home_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\TasteMe.mdb", FileAttributes.Hidden)
        Label9.Text = Index.TextBox1.Text
        Dim cmds As New OleDbCommand("SELECT * FROM Profiles WHERE uname = '" & Label9.Text & "'", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()

        Label5.Text = x.Item("fullname")
        PictureBox1.ImageLocation = x.Item("Pic")
        con.Close()


        Dim cmds2 As New OleDbCommand("SELECT * FROM Information WHERE title = 'slide1' ", con)
        Dim k As OleDbDataReader
        con.Open()
        k = cmds2.ExecuteReader()
        k.Read()

        Label29.Text = k.Item("det1")
        Label30.Text = k.Item("det2")
        Label31.Text = k.Item("det3")

        con.Close()

        Dim cmds7 As New OleDbCommand("SELECT * FROM Information WHERE title = 'slide2' ", con)
        Dim m As OleDbDataReader
        con.Open()
        m = cmds7.ExecuteReader()
        m.Read()

        Label25.Text = m.Item("det1")
        TextBox3.Text = m.Item("det3")

        con.Close()

        Dim cmds8 As New OleDbCommand("SELECT * FROM Information WHERE title = 'ad1' ", con)
        Dim s As OleDbDataReader
        con.Open()
        s = cmds8.ExecuteReader()
        s.Read()

        PictureBox20.ImageLocation = s.Item("det3")

        con.Close()


        Dim cmds9 As New OleDbCommand("SELECT * FROM Information WHERE title = 'ad2' ", con)
        Dim t As OleDbDataReader
        con.Open()
        t = cmds9.ExecuteReader()
        t.Read()

        PictureBox21.ImageLocation = t.Item("det3")

        con.Close()

        '*****************   SELECTING FROM DATABASE   *******************************************************
        Dim cmds3 As New OleDbCommand("SELECT * FROM Recipes WHERE ID = " & Label29.Text & "", con)
        Dim z As OleDbDataReader
        con.Open()
        z = cmds3.ExecuteReader()
        z.Read()

        Label2.Text = z.Item("title")
        Label4.Text = z.Item("uname")
        PictureBox5.ImageLocation = z.Item("Pic")

        con.Close()

        Dim cmds4 As New OleDbCommand("SELECT * FROM Recipes WHERE ID = " & Label30.Text & "", con)
        Dim p As OleDbDataReader
        con.Open()
        p = cmds4.ExecuteReader()
        p.Read()

        Label13.Text = p.Item("title")
        Label11.Text = p.Item("uname")
        PictureBox7.ImageLocation = p.Item("Pic")

        con.Close()


        Dim cmds5 As New OleDbCommand("SELECT * FROM Recipes WHERE ID = " & Label31.Text & "", con)
        Dim q As OleDbDataReader
        con.Open()
        q = cmds5.ExecuteReader()
        q.Read()

        Label16.Text = q.Item("title")
        Label14.Text = q.Item("uname")
        PictureBox8.ImageLocation = q.Item("Pic")

        con.Close()


        Dim cmds6 As New OleDbCommand("SELECT * FROM Recipes WHERE ID = " & Label25.Text & "", con)
        Dim j As OleDbDataReader
        con.Open()
        j = cmds6.ExecuteReader()
        j.Read()

        Label22.Text = j.Item("title")
        Label26.Text = j.Item("uname")
        PictureBox19.ImageLocation = j.Item("Pic")

        con.Close()

        Timer1.Enabled = True


        'Dim cmds10 As New OleDbCommand("select * from Friends", con)
        'Dim h As OleDbDataReader
        'con.Open()
        'h = cmds10.ExecuteReader
        'h.Read()
        'If Label9.Text = h.Item("fren1") Then

        Dim ds1 As New DataSet
        Dim dr1 As DataRow
        Dim dt1 As New DataTable
        Dim adptr1 As New OleDbDataAdapter("select * from Friends  where fren1 = '" & Label9.Text & "' and status = 'accepted'", con)
        adptr1.Fill(ds1, "Friends where fren1 = '" & Label9.Text & "'  and status = 'accepted'")
        dt1 = ds1.Tables(0)



        Dim ds2 As New DataSet
        Dim dr2 As DataRow
        Dim dt2 As New DataTable
        Dim adptr2 As New OleDbDataAdapter("select * from Friends  where fren2 = '" & Label9.Text & "' and status = 'accepted'", con)
        adptr2.Fill(ds2, "Friends where fren2 = '" & Label9.Text & "'  and status = 'accepted'")
        dt2 = ds2.Tables(0)

        For Each dr2 In dt2.Rows
            ComboBox1.Items.Add(dr2.Item("fren1"))
            'ComboBox1.Items.Add(dr1.Item("fren1"))
        Next

        For Each dr1 In dt1.Rows
            ComboBox1.Items.Add(dr1.Item("fren2"))
            'ComboBox1.Items.Add(dr1.Item("fren1"))
        Next

        'Else


        'Dim ds1 As New DataSet
        'Dim dr1 As DataRow
        'Dim dt1 As New DataTable
        'Dim adptr1 As New OleDbDataAdapter("select * from Friends where fren1 = '" & Label9.Text & "'", con)
        'adptr1.Fill(ds1, "Friends")
        'dt1 = ds1.Tables(0)

        'For Each dr1 In dt1.Rows
        '    ComboBox1.Items.Add(dr1.Item("fren1"))
        'Next

        con.Close()
        'End If

        con.Close()

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)
        ViewAll.Show()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs)
        AddRecipe.Show()
    End Sub

    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        DataGridView1.Rows.Clear()
        'Try
        '    Dim cmds2 As New OleDbCommand("SELECT * FROM Recipes WHERE title = '" & TextBox1.Text & "'", con)
        '    Dim z As OleDbDataReader
        '    con.Open()
        '    z = cmds2.ExecuteReader()
        '    z.Read()

        '    If TextBox1.Text = z.Item("title") Then

        '        Label6.Visible = True
        '        Label7.Visible = True
        '        Label8.Visible = False
        '        con.Close()



        '        Dim str As String
        '        Dim r As OleDbDataReader
        '        str = "SELECT * FROM Recipies"
        '        Dim i As Integer
        '        i = 0
        '        con.Open()
        '        query = New OleDbCommand(str, con)
        '        r = query.ExecuteReader
        '        Do While r.Read()
        '            DataGridView1.RowCount = DataGridView1.RowCount + 1
        '            i = i + 1
        '        Loop
        '        query.Dispose()
        '        str = "SELECT * FROM Recipies WHERE title = '" & TextBox1.Text & "'"
        '        i = 0
        '        query = New OleDbCommand(str, con)
        '        r = query.ExecuteReader

        '        Do While r.Read()
        '            DataGridView1.Item(0, i).Value = r("ID")
        '            DataGridView1.Item(1, i).Value = r("title")
        '            DataGridView1.Item(2, i).Value = "by"
        '            DataGridView1.Item(3, i).Value = r("uname")

        '            i = i + 1
        '        Loop
        '        con.Close()






        '    Else
        '        Label8.Visible = True
        '        Label6.Visible = False
        '        Label7.Visible = False
        '        con.Close()
        '    End If
        'Catch
        '    Label8.Visible = True
        'End Try



        

        Try
            Dim cmds2 As New OleDbCommand("SELECT * FROM Recipes WHERE title = '" & TextBox1.Text & "'", con)
            Dim z As OleDbDataReader
            con.Open()
            z = cmds2.ExecuteReader()
            z.Read()

            If TextBox1.Text = z.Item("title") Then

                Label6.Visible = True
                Label34.Visible = True
                DataGridView1.Refresh()
                DataGridView1.Visible = True
                Label8.Visible = False

                con.Close()


                Dim str As String
                Dim r As OleDbDataReader
                str = "SELECT * FROM Recipes"
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
                str = "SELECT * FROM Recipes WHERE title = '" & TextBox1.Text & "'"
                i = 0
                query = New OleDbCommand(str, con)
                r = query.ExecuteReader

                Do While r.Read()
                    DataGridView1.Item(0, i).Value = r("ID")
                    DataGridView1.Item(1, i).Value = r("title")
                    DataGridView1.Item(2, i).Value = "by"
                    DataGridView1.Item(3, i).Value = r("uname")
                    DataGridView1.Item(4, i).Value = r("Rate")

                    i = i + 1
                Loop
                con.Close()

                DataGridView1.Sort(DataGridView1.Columns(4), System.ComponentModel.ListSortDirection.Descending)

            Else
                Label8.Visible = True
                Label6.Visible = False
                Label34.Visible = False
                DataGridView1.Visible = False
                con.Close()
            End If


        Catch
            Label8.Visible = True
            Label6.Visible = False
            Label34.Visible = False
            DataGridView1.Visible = False
            con.Close()
        End Try



    End Sub

    Private Sub DataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.TextBox2.Text = DataGridView1.Item(0, i).Value

        Details.Show()

        'Me.TextBox2.Text = DataGridView1.Item(1, i).Value
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As System.EventArgs) Handles TextBox1.Leave

    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As System.EventArgs) Handles TextBox1.MouseLeave
        Timer1.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Label8.Visible = False
        Timer1.Enabled = False
        'DataGridView1.Refresh()
        'Me.Refresh()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseHover
        PictureBox4.Visible = True
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        AddRecipe.Close()
        Chat.Close()
        Details.Close()
        EditDetails.Close()
        Friends.Close()
        MyRecipes.Close()
        Reciepes.Close()
        ViewAll.Close()
        ViewProfile.Close()
        Info.Close()
        Manual.Close()
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Visible = False
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs)
        'PictureBox5.Visible = True
        'PictureBox5.BringToFront()
        ComboBox2.DroppedDown = False
    End Sub

    Private Sub ComboBox2_MouseLeave(sender As Object, e As System.EventArgs) Handles ComboBox2.MouseLeave
        ComboBox2.DroppedDown = False
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = ("VIEW ALL") Then
            ViewAll.Show()
            AddRecipe.Close()
            Chat.Close()
            Details.Close()
            EditDetails.Close()
            Friends.Close()
            MyRecipes.Close()
            Reciepes.Close()

            ViewProfile.Close()
            Info.Close()
            Manual.Close()
        Else
            If ComboBox2.Text = ("ADD RECIPE") Then
                AddRecipe.Show()

                Chat.Close()
                Details.Close()
                EditDetails.Close()
                Friends.Close()
                MyRecipes.Close()
                Reciepes.Close()
                ViewAll.Close()
                ViewProfile.Close()
                Info.Close()
                Manual.Close()
                If ComboBox2.Text = ("VIEW MY RECIPES") Then
                    MyRecipes.Show()
                    AddRecipe.Close()
                    Chat.Close()
                    Details.Close()
                    EditDetails.Close()
                    Friends.Close()
                    MyRecipes.Close()

                    ViewAll.Close()
                    ViewProfile.Close()
                    Info.Close()
                    Manual.Close()
                Else
                    ComboBox2.DroppedDown = False
                    ComboBox3.DroppedDown = False
                    ComboBox4.DroppedDown = False
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox6_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox6.MouseHover
        ComboBox2.DroppedDown = True
        ComboBox3.DroppedDown = False
        ComboBox4.DroppedDown = False
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox6.MouseLeave
        'ComboBox2.DroppedDown = False
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseHover
        ComboBox3.DroppedDown = True
        ComboBox2.DroppedDown = False
        ComboBox4.DroppedDown = False
    End Sub

    Private Sub PictureBox11_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox11.Click

    End Sub

    Private Sub PictureBox11_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox11.MouseHover
        PictureBox12.Visible = True
        Label17.Visible = True
        Label18.Visible = True
    End Sub

    Private Sub PictureBox12_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox12.MouseLeave
        PictureBox12.Visible = False
        Label17.Visible = False
        Label18.Visible = False
    End Sub

    Private Sub PictureBox10_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox10.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 1
    End Sub

    Private Sub PictureBox13_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox13.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 2
    End Sub

    Private Sub PictureBox14_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox14.Click
        Dim i As Integer = 1
        TabControl1.SelectedIndex = i - 1
    End Sub

    Private Sub PictureBox16_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox16.Click
        Dim i As Integer = 2
        TabControl1.SelectedIndex = i - 1
    End Sub

    Private Sub PictureBox15_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox15.Click
        Dim i As Integer = 2
        TabControl1.SelectedIndex = i - 2
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 2
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label19.Text = timercount.ToString
        Dim i As Integer = 0
        timercount += 1
        If timercount = 45 Then


            '    Dim i As Integer = 0
            TabControl1.SelectedIndex = i + 1

        Else
            If timercount = 90 Then


                '    Dim i As Integer = 0
                TabControl1.SelectedIndex = i + 2
            Else
                If timercount = 135 Then


                    Dim z As Integer = 2
                    TabControl1.SelectedIndex = z - 2


                    timercount = 1
                Else

                End If
            End If
        End If
    End Sub

    Private Sub PictureBox17_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox17.MouseHover
        ComboBox4.DroppedDown = True
        ComboBox2.DroppedDown = False
        ComboBox3.DroppedDown = False
    End Sub

    Private Sub PictureBox12_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox12.Click
        AddRecipe.Show()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ViewProfile.Show()
        AddRecipe.Close()
        Chat.Close()
        Details.Close()
        EditDetails.Close()
        Friends.Close()
        MyRecipes.Close()
        Reciepes.Close()
        ViewAll.Close()

        Info.Close()
        Manual.Close()
    End Sub

    Private Sub PictureBox22_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox22.Click
        Timer1.Enabled = False
        PictureBox25.Visible = True
        PictureBox27.Visible = True
        PictureBox26.Visible = True
    End Sub

    Private Sub PictureBox25_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox25.Click
        Timer1.Enabled = True
        PictureBox25.Visible = False
        PictureBox27.Visible = False
        PictureBox26.Visible = False
    End Sub

    Private Sub PictureBox23_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox23.Click
        Timer1.Enabled = False
        PictureBox26.Visible = True
        PictureBox27.Visible = True
        PictureBox25.Visible = True
    End Sub

    Private Sub PictureBox26_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox26.Click
        Timer1.Enabled = True
        PictureBox26.Visible = False
        PictureBox27.Visible = False
        PictureBox25.Visible = False

    End Sub

    Private Sub PictureBox24_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox24.Click
        Timer1.Enabled = False
        PictureBox27.Visible = True
        PictureBox25.Visible = True
        PictureBox26.Visible = True
    End Sub

    Private Sub PictureBox27_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox27.Click
        Timer1.Enabled = True
        PictureBox27.Visible = False
        PictureBox25.Visible = False
        PictureBox26.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged


        Dim cmds2 As New OleDbCommand("select * from Friends  where fren1 = '" & Label9.Text & "'", con)
        Dim y As OleDbDataReader
        con.Open()
        y = cmds2.ExecuteReader
        y.Read()


        'If ComboBox5.Text = y.Item("fren1") Then
        If ComboBox1.SelectedItem = y.Item("fren2") And Label9.Text = y.Item("fren1") Then
            Label37.Text = "1"

            ''Label34.Text = "1"
            con.Close()
            Dim cmds As New OleDbCommand("SELECT * FROM Friends WHERE fren2 = '" & ComboBox1.Text & "' and fren1 = '" & Label9.Text & "'", con)
            Dim x As OleDbDataReader
            con.Open()
            x = cmds.ExecuteReader()
            x.Read()
            Label33.Text = x.Item("ID")
            con.Close()
            'Label37.Text = "1"
            ''Chat.Close()

        Else

            'If Label9.Text = y.Item("fren2") And ComboBox1.SelectedItem = y.Item("fren1") Then
            Label37.Text = "2"

            con.Close()
            Dim cmds As New OleDbCommand("SELECT * FROM Friends WHERE fren1 = '" & ComboBox1.SelectedItem & "' and fren2 = '" & Label9.Text & "'", con)
            Dim x As OleDbDataReader
            con.Open()
            x = cmds.ExecuteReader()
            x.Read()
            Label33.Text = x.Item("ID")
            con.Close()
            'Label37.Text = "2"
            'Chat.Close()

            'Else

            '    MessageBox.Show("User Not Found", "NOTIFICATION")

        End If

        'End If

        con.Close()
    End Sub

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        DataGridView2.Rows.Clear()

        Dim z As String
        If TextBox4.Text = ("") Then
            z = MessageBox.Show("Enter a message", "NOTIFICATION")
        Else

            query = New OleDbCommand("insert into Msg(msgID,rev,sen,det)values('" & Label33.Text & "','" & Label36.Text & "','" & Label9.Text & "','" & TextBox4.Text & "')", con)

            con.Open()
            query.ExecuteNonQuery()

            con.Close()



            '***************************************************************

            Dim str As String
            Dim r As OleDbDataReader
            str = "SELECT * FROM Msg"
            Dim i As Integer
            i = 0
            con.Open()
            query = New OleDbCommand(str, con)
            r = query.ExecuteReader
            Do While r.Read()
                DataGridView2.RowCount = DataGridView2.RowCount + 1
                i = i + 1
            Loop
            query.Dispose()
            str = "SELECT * FROM Msg WHERE msgID = '" & Label33.Text & "'"
            i = 0
            query = New OleDbCommand(str, con)
            r = query.ExecuteReader

            Do While r.Read()
                DataGridView2.Item(0, i).Value = r("det")
                DataGridView2.Item(1, i).Value = r("det")


                'DataGridView1.Item(5, i).Value = r("rd")

                If r("sen") = Label36.Text Then
                    DataGridView2.Item(1, i).Value = " "

                Else
                    DataGridView2.Item(0, i).Value = " "


                End If

                'If r("rd") < Today Then
                '    DataGridView1.Item(6, i).Value = "Overdue"
                'End If

                i = i + 1
            Loop
            con.Close()

            TextBox4.Clear()

            '****************************************************************
            'Scroll to the last row.
            Me.DataGridView2.FirstDisplayedScrollingRowIndex = Me.DataGridView2.RowCount - 1

            'Select the last row.
            Me.DataGridView2.Rows(Me.DataGridView2.RowCount - 1).Selected = True

        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        DataGridView2.Rows.Clear()

        Dim str As String
        Dim r As OleDbDataReader
        str = "SELECT * FROM Msg"
        Dim i As Integer
        i = 0
        con.Open()
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader
        Do While r.Read()
            DataGridView2.RowCount = DataGridView2.RowCount + 1
            i = i + 1
        Loop
        query.Dispose()
        str = "SELECT * FROM Msg WHERE msgID = '" & Label33.Text & "'"
        i = 0
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader

        Do While r.Read()
            DataGridView2.Item(0, i).Value = r("det")
            DataGridView2.Item(1, i).Value = r("det")


            'DataGridView1.Item(5, i).Value = r("rd")

            If r("sen") = Label36.Text Then
                DataGridView2.Item(1, i).Value = " "

            Else
                DataGridView2.Item(0, i).Value = " "


            End If

            'If r("rd") < Today Then
            '    DataGridView1.Item(6, i).Value = "Overdue"
            'End If

            i = i + 1
        Loop
        con.Close()

        TextBox4.Clear()

        'Scroll to the last row.
        Me.DataGridView2.FirstDisplayedScrollingRowIndex = Me.DataGridView2.RowCount - 1

        'Select the last row.
        Me.DataGridView2.Rows(Me.DataGridView2.RowCount - 1).Selected = True

    End Sub

    Private Sub Button7_Click_1(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        DataGridView2.Visible = False
        Label36.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        TextBox4.Clear()
        TextBox4.Visible = False
        Label37.Text = "Num"
        Timer2.Enabled = False
        Timer1.Enabled = True
    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = ("VIEW FRIENDS") Then
            Friends.Show()
            AddRecipe.Close()
            Chat.Close()
            Details.Close()
            EditDetails.Close()

            MyRecipes.Close()
            Reciepes.Close()
            ViewAll.Close()
            ViewProfile.Close()
            Info.Close()
            Manual.Close()
        Else
            If ComboBox3.Text = ("MANAGE FRIENDS") Then
                Friends.Show()
                AddRecipe.Close()
                Chat.Close()
                Details.Close()
                EditDetails.Close()

                MyRecipes.Close()
                Reciepes.Close()
                ViewAll.Close()
                ViewProfile.Close()
                Info.Close()
                Manual.Close()
            Else
                ComboBox2.DroppedDown = False
                ComboBox3.DroppedDown = False
                ComboBox4.DroppedDown = False
            End If
            End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim x As String
        x = MessageBox.Show("Log Out?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If x = vbYes Then
            AddRecipe.Close()
            Chat.Close()
            Details.Close()
            EditDetails.Close()
            Friends.Close()
            MyRecipes.Close()
            Reciepes.Close()
            ViewAll.Close()
            ViewProfile.Close()
            Info.Close()
            Manual.Close()

            Index.TextBox2.Clear()
            Index.Show()
            Me.Close()

        End If
    End Sub

    Private Sub TextBox4_MouseLeave(sender As Object, e As System.EventArgs) Handles TextBox4.MouseLeave
        Timer1.Enabled = True
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        'timercount = 10
        Label35.Text = timercount.ToString

        timercount += 1
        If timercount > 25 Then

            DataGridView2.Rows.Clear()

            Dim str As String
            Dim r As OleDbDataReader
            str = "SELECT * FROM Msg"
            Dim i As Integer
            i = 0
            con.Open()
            query = New OleDbCommand(str, con)
            r = query.ExecuteReader
            Do While r.Read()
                DataGridView2.RowCount = DataGridView2.RowCount + 1
                i = i + 1
            Loop
            query.Dispose()
            str = "SELECT * FROM Msg WHERE msgID = '" & Label33.Text & "'"
            i = 0
            query = New OleDbCommand(str, con)
            r = query.ExecuteReader

            Do While r.Read()
                DataGridView2.Item(0, i).Value = r("det")
                DataGridView2.Item(1, i).Value = r("det")
                DataGridView2.Item(2, i).Value = r("ID")


                'DataGridView1.Item(5, i).Value = r("rd")

                If r("sen") = Label36.Text Then
                    DataGridView2.Item(1, i).Value = " "

                Else
                    DataGridView2.Item(0, i).Value = " "


                End If

                'If r("rd") < Today Then
                '    DataGridView1.Item(6, i).Value = "Overdue"
                'End If

                i = i + 1
            Loop
            con.Close()

            timercount = 1


            DataGridView2.Sort(DataGridView2.Columns(2), System.ComponentModel.ListSortDirection.Ascending)


            'Scroll to the last row.
            Me.DataGridView2.FirstDisplayedScrollingRowIndex = Me.DataGridView2.RowCount - 1

            'Select the last row.
            Me.DataGridView2.Rows(Me.DataGridView2.RowCount - 1).Selected = True


        End If
    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As System.EventArgs) Handles DataGridView2.Click

    End Sub

    Private Sub DataGridView2_Leave(sender As Object, e As System.EventArgs) Handles DataGridView2.Leave
        'Timer2.Enabled = True
    End Sub

    Private Sub DataGridView2_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView2.MouseClick
        'Timer2.Enabled = False
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.Text = ("ABOUT US") Then
            Info.Show()
            AddRecipe.Close()
            Chat.Close()
            Details.Close()
            EditDetails.Close()
            Friends.Close()
            MyRecipes.Close()
            Reciepes.Close()
            ViewAll.Close()
            ViewProfile.Close()

            Manual.Close()
        Else
            If ComboBox4.Text = ("MANUAL / HELP") Then
                Manual.Show()
                AddRecipe.Close()
                Chat.Close()
                Details.Close()
                EditDetails.Close()
                Friends.Close()
                MyRecipes.Close()
                Reciepes.Close()
                ViewAll.Close()
                ViewProfile.Close()
                Info.Close()

            Else
                ComboBox2.DroppedDown = False
                ComboBox3.DroppedDown = False
                ComboBox4.DroppedDown = False
            End If
        End If
    End Sub
End Class