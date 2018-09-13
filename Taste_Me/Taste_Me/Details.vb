Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Details
    Dim query As OleDbCommand
    Dim myfilelocation As String
    Dim newpic As String = ""
    Dim a, b, c, sum, avg As Long
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\TasteMe.mdb;")

    Private Sub Details_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\TasteMe.mdb", FileAttributes.Hidden)


        If ViewAll.Visible = True Then
            Label6.Text = ViewAll.TextBox1.Text
        Else

        End If

        If MyRecipes.Visible = True Then
            Label6.Text = MyRecipes.TextBox1.Text
        Else

        End If

        If MyRecipes.Visible = False And ViewAll.Visible = False Then
            Label6.Text = Home.TextBox2.Text
        Else

        End If


        Dim cmds As New OleDbCommand("SELECT * FROM Recipes WHERE ID = " & Label6.Text & "", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()

        Label1.Text = x.Item("title")
        Label3.Text = x.Item("uname")
        Label5.Text = x.Item("catg")
        TextBox5.Text = x.Item("Rate")
        TextBox1.Text = x.Item("ingredients")
        TextBox2.Text = x.Item("steps")
        TextBox3.Text = x.Item("info")
        TextBox6.Text = x.Item("NumRaters")

        'If Label3.Text = Home.Label9.Text Then
        '    Button2.Visible = False
        '    Button4.Visible = True
        'Else
        '    Button2.Visible = True
        '    Button4.Visible = False
        'End If



        If x.Item("Rate") = "0" Then
            'If TextBox5.Text = "0" Then
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            TextBox5.Text = "0"

        Else
            If x.Item("Rate") = "1" Then
                'If TextBox5.Text = "1" Then
                PictureBox7.Visible = True
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                TextBox5.Text = "1"

            Else
                If x.Item("Rate") = "2" Then
                    PictureBox7.Visible = True
                    PictureBox8.Visible = True
                    PictureBox9.Visible = False
                    PictureBox10.Visible = False
                    PictureBox11.Visible = False
                    TextBox5.Text = "2"

                Else
                    If x.Item("Rate") = "3" Then
                        PictureBox7.Visible = True
                        PictureBox8.Visible = True
                        PictureBox9.Visible = True
                        PictureBox10.Visible = False
                        PictureBox11.Visible = False
                        TextBox5.Text = "3"

                    Else
                        If x.Item("Rate") = "4" Then
                            PictureBox7.Visible = True
                            PictureBox8.Visible = True
                            PictureBox9.Visible = True
                            PictureBox10.Visible = True
                            PictureBox11.Visible = False
                            TextBox5.Text = "4"

                        Else
                            PictureBox7.Visible = True
                            PictureBox8.Visible = True
                            PictureBox9.Visible = True
                            PictureBox10.Visible = True
                            PictureBox11.Visible = True
                            TextBox5.Text = "5"
                        End If
                    End If
                End If
            End If
        End If


        If AdminHome.Visible = True Then
            Button2.Visible = False
            Button4.Visible = True
        Else
            If Label3.Text = Home.Label9.Text Then
                Button2.Visible = False
                Button4.Visible = True
            Else
                Button2.Visible = True
                Button4.Visible = False
            End If
        End If


        PictureBox1.ImageLocation = x.Item("Pic")

        con.Close()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox17_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox17.Click
        PictureBox12.Visible = True
        PictureBox13.Visible = False
        PictureBox14.Visible = False
        PictureBox15.Visible = False
        PictureBox16.Visible = False
        TextBox4.Text = "1"
    End Sub

    Private Sub PictureBox18_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox18.Click
        PictureBox12.Visible = True
        PictureBox13.Visible = True
        PictureBox14.Visible = False
        PictureBox15.Visible = False
        PictureBox16.Visible = False
        TextBox4.Text = "2"
    End Sub

    Private Sub PictureBox19_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox19.Click
        PictureBox12.Visible = True
        PictureBox13.Visible = True
        PictureBox14.Visible = True
        PictureBox15.Visible = False
        PictureBox16.Visible = False
        TextBox4.Text = "3"
    End Sub

    Private Sub PictureBox20_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox20.Click
        PictureBox12.Visible = True
        PictureBox13.Visible = True
        PictureBox14.Visible = True
        PictureBox15.Visible = True
        PictureBox16.Visible = False
        TextBox4.Text = "4"
    End Sub

    Private Sub PictureBox21_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox21.Click
        PictureBox12.Visible = True
        PictureBox13.Visible = True
        PictureBox14.Visible = True
        PictureBox15.Visible = True
        PictureBox16.Visible = True
        TextBox4.Text = "5"
    End Sub

    Private Sub PictureBox12_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox12.Click
        PictureBox12.Visible = True
        PictureBox13.Visible = False
        PictureBox14.Visible = False
        PictureBox15.Visible = False
        PictureBox16.Visible = False
        TextBox4.Text = "1"
    End Sub

    Private Sub PictureBox13_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox13.Click
        PictureBox12.Visible = True
        PictureBox13.Visible = True
        PictureBox14.Visible = False
        PictureBox15.Visible = False
        PictureBox16.Visible = False
        TextBox4.Text = "2"
    End Sub

    Private Sub PictureBox14_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox14.Click
        PictureBox12.Visible = True
        PictureBox13.Visible = True
        PictureBox14.Visible = True
        PictureBox15.Visible = False
        PictureBox16.Visible = False
        TextBox4.Text = "3"
    End Sub

    Private Sub PictureBox15_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox15.Click
        PictureBox12.Visible = True
        PictureBox13.Visible = True
        PictureBox14.Visible = True
        PictureBox15.Visible = True
        PictureBox16.Visible = False
        TextBox4.Text = "4"
    End Sub

    Private Sub PictureBox16_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox16.Click
        PictureBox12.Visible = True
        PictureBox13.Visible = True
        PictureBox14.Visible = True
        PictureBox15.Visible = True
        PictureBox16.Visible = True
        TextBox4.Text = "5"
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        GroupBox4.Visible = True
        PictureBox17.Visible = True
        PictureBox18.Visible = True
        PictureBox19.Visible = True
        PictureBox20.Visible = True
        PictureBox21.Visible = True
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim y As String
        y = MessageBox.Show("Add Rating?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then

            a = TextBox5.Text
            b = TextBox6.Text
            c = TextBox4.Text

            avg = ((a * b) + c) / (b + 1)
            TextBox5.Text = avg
            sum = b + 1
            TextBox6.Text = sum

            con.Close()
            Dim str As String = "UPDATE Recipes SET Rate='" & TextBox5.Text & "', NumRaters='" & TextBox6.Text & "' WHERE ID=" & Label6.Text & " "
            Dim cmnds As New OleDbCommand(str, con)
            con.Open()
            cmnds.ExecuteNonQuery()
            'con.Close()

            MessageBox.Show("Added", "NOTIFICATION")
            con.Close()
            GroupBox4.Visible = False
            PictureBox17.Visible = False
            PictureBox18.Visible = False
            PictureBox19.Visible = False
            PictureBox20.Visible = False
            PictureBox21.Visible = False
            Button3.Visible = False
            Button2.Visible = False
        Else
            MessageBox.Show("Not Added", "NOTIFICATION")
            con.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        EditDetails.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        'GroupBox2.Visible = False

        Button5.Visible = False
        Button7.Visible = True

        GroupBox5.Visible = True


        Dim str As String
        Dim r As OleDbDataReader
        str = "SELECT * FROM Comments"
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
        str = "SELECT * FROM Comments WHERE ID = '" & Label6.Text & "'"
        i = 0
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader
        Do While r.Read()
            DataGridView1.Item(0, i).Value = r("uname")
            DataGridView1.Item(1, i).Value = r("comnt")

            i = i + 1
        Loop
        con.Close()

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Button5.Visible = True
        Button7.Visible = False
        GroupBox2.Visible = True
        GroupBox5.Visible = False
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim z As String
        If Label7.Text = ("") Then
            z = MessageBox.Show(" Textbox is Empty", "NOTIFICATION")

        Else


            'Dim x As String
            'x = MessageBox.Show("Are you sure you want to save?", "CONFIRMATION", MessageBoxButtons.YesNo)
            'If x = vbYes Then

            '***************Insert Code****************************************************************************************************************************************************************************************************************************************************************************************************************
            query = New OleDbCommand("insert into Comments(ID,uname,comnt)values('" & Label6.Text & "','" & Home.Label9.Text & "','" & TextBox7.Text & "')", con)

            con.Open()
            query.ExecuteNonQuery()
            con.Close()


            '***************   Reloads Datagrid   *****************************************************************

            DataGridView1.Rows.Clear()


            Dim str As String
            Dim r As OleDbDataReader
            str = "SELECT * FROM Comments"
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
            str = "SELECT * FROM Comments WHERE ID = '" & Label6.Text & "'"
            i = 0
            query = New OleDbCommand(str, con)
            r = query.ExecuteReader
            Do While r.Read()
                DataGridView1.Item(0, i).Value = r("uname")
                DataGridView1.Item(1, i).Value = r("comnt")

                i = i + 1
            Loop
            con.Close()

        End If
        'End If

        TextBox7.Clear()

    End Sub
End Class