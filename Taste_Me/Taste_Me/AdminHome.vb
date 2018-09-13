Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class AdminHome
    Dim query As OleDbCommand
    Dim myfilelocation As String
    Dim myfilelocation2 As String
    Dim newpic As String = ""
    Dim timercount As Integer = 1
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\TasteMe.mdb;")

    Private Sub AdminHome_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\TasteMe.mdb", FileAttributes.Hidden)
        Label9.Text = Index.TextBox1.Text


        Dim cmds As New OleDbCommand("SELECT * FROM Information WHERE title = 'slide1'", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()

        ComboBox5.Text = x.Item("det1")
        ComboBox6.Text = x.Item("det2")
        ComboBox7.Text = x.Item("det3")

        con.Close()


        Dim cmds2 As New OleDbCommand("SELECT * FROM Information WHERE title = 'slide2'", con)
        Dim y As OleDbDataReader
        con.Open()
        y = cmds2.ExecuteReader()
        y.Read()

        ComboBox8.Text = y.Item("det1")
        TextBox3.Text = y.Item("det3")

        con.Close()


        Dim cmds3 As New OleDbCommand("SELECT * FROM Information WHERE title = 'ad1'", con)
        Dim z As OleDbDataReader
        con.Open()
        z = cmds3.ExecuteReader()
        z.Read()

        PictureBox20.ImageLocation = z.Item("det3")

        con.Close()


        Dim cmds4 As New OleDbCommand("SELECT * FROM Information WHERE title = 'ad2'", con)
        Dim w As OleDbDataReader
        con.Open()
        w = cmds4.ExecuteReader()
        w.Read()

        PictureBox21.ImageLocation = w.Item("det3")

        con.Close()

        'Try
        Dim ds As New DataSet
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim adptr As New OleDbDataAdapter("select * from Recipes", con)
        adptr.Fill(ds, "Recipes")
        dt = ds.Tables(0)
        'ComboBox5.Items.Clear()
        For Each dr In dt.Rows
            ComboBox5.Items.Add(dr.Item("ID"))
        Next
        'Catch ex As Exception
        '    MsgBox("The Database could not be found. Try again")
        '    End
        'End Try

        Dim ds2 As New DataSet
        Dim dr2 As DataRow
        Dim dt2 As New DataTable
        Dim adptr2 As New OleDbDataAdapter("select * from Recipes", con)
        adptr2.Fill(ds2, "Recipes")
        dt2 = ds2.Tables(0)

        For Each dr2 In dt2.Rows
            ComboBox6.Items.Add(dr2.Item("ID"))
        Next

        Dim ds3 As New DataSet
        Dim dr3 As DataRow
        Dim dt3 As New DataTable
        Dim adptr3 As New OleDbDataAdapter("select * from Recipes", con)
        adptr3.Fill(ds3, "Recipes")
        dt3 = ds3.Tables(0)

        For Each dr3 In dt3.Rows
            ComboBox7.Items.Add(dr3.Item("ID"))
        Next

        Dim ds4 As New DataSet
        Dim dr4 As DataRow
        Dim dt4 As New DataTable
        Dim adptr4 As New OleDbDataAdapter("select * from Recipes", con)
        adptr4.Fill(ds4, "Recipes")
        dt4 = ds4.Tables(0)

        For Each dr4 In dt3.Rows
            ComboBox8.Items.Add(dr4.Item("ID"))
        Next

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to save these changes?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim str As String = "UPDATE Information SET det1='" & ComboBox5.Text & "', det2='" & ComboBox6.Text & "', det3='" & ComboBox7.Text & "' WHERE  title= 'slide1' "
            Dim cmnds As New OleDbCommand(str, con)
            con.Open()
            cmnds.ExecuteNonQuery()
            MessageBox.Show("Changes Saved", "NOTIFICATION")
            con.Close()
        Else
            MessageBox.Show("Changes Not Saved", "NOTIFICATION")
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to save these changes?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim str As String = "UPDATE Information SET det1='" & ComboBox8.Text & "', det3='" & TextBox3.Text & "' WHERE  title= 'slide2' "
            Dim cmnds As New OleDbCommand(str, con)
            con.Open()
            cmnds.ExecuteNonQuery()
            MessageBox.Show("Changes Saved", "NOTIFICATION")
            con.Close()
        Else
            MessageBox.Show("Changes Not Saved", "NOTIFICATION")
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to change image?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim str As String = "UPDATE Information SET det3='" & myfilelocation & "' WHERE  title= 'ad1' "
            Dim cmnds As New OleDbCommand(str, con)
            con.Open()
            cmnds.ExecuteNonQuery()
            MessageBox.Show("Image Saved", "NOTIFICATION")
            con.Close()
        Else
            MessageBox.Show("Image Not Saved", "NOTIFICATION")
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to change image?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim str As String = "UPDATE Information SET det3='" & myfilelocation2 & "' WHERE  title= 'ad2' "
            Dim cmnds As New OleDbCommand(str, con)
            con.Open()
            cmnds.ExecuteNonQuery()
            MessageBox.Show("Image Saved", "NOTIFICATION")
            con.Close()
        Else
            MessageBox.Show("Image Not Saved", "NOTIFICATION")
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Try

            OpenFileDialog1.InitialDirectory = "c:\"
            OpenFileDialog1.Title = "choose image"
            OpenFileDialog1.Filter = "jpg|*.jpg"
            OpenFileDialog1.ShowDialog()
            myfilelocation = OpenFileDialog1.FileName
            PictureBox20.Image = Image.FromFile(myfilelocation)
            'MessageBox.Show("Image has been Uploaded", "NOTIFICATION")
            OpenFileDialog1.Reset()

        Catch
            MessageBox.Show("Image Not Uploaded", "NOTIFICATION")
        End Try
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Try

            OpenFileDialog2.InitialDirectory = "c:\"
            OpenFileDialog2.Title = "choose image"
            OpenFileDialog2.Filter = "jpg|*.jpg"
            OpenFileDialog2.ShowDialog()
            myfilelocation2 = OpenFileDialog2.FileName
            PictureBox21.Image = Image.FromFile(myfilelocation2)
            'MessageBox.Show("Image has been Uploaded", "NOTIFICATION")
            OpenFileDialog2.Reset()

        Catch
            MessageBox.Show("Image Not Uploaded", "NOTIFICATION")
        End Try
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 2
    End Sub

    Private Sub PictureBox10_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox10.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 1
    End Sub

    Private Sub PictureBox14_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox14.Click
        Dim i As Integer = 1
        TabControl1.SelectedIndex = i - 1
    End Sub

    Private Sub PictureBox13_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox13.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 2
    End Sub

    Private Sub PictureBox16_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox16.Click
        Dim i As Integer = 2
        TabControl1.SelectedIndex = i - 1
    End Sub

    Private Sub PictureBox15_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox15.Click
        Dim i As Integer = 2
        TabControl1.SelectedIndex = i - 2
    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ComboBox5_TextChanged(sender As Object, e As System.EventArgs) Handles ComboBox5.TextChanged
        'Dim cmds As New OleDbCommand("SELECT * FROM Recipes WHERE ID = " & ComboBox5.Text & "", con)
        'Dim x As OleDbDataReader
        'con.Open()
        'x = cmds.ExecuteReader()
        'x.Read()

        'Label2.Text = x.Item("title")
        'Label4.Text = x.Item("uname")

        'con.Close()
    End Sub

    Private Sub ComboBox6_TextChanged(sender As Object, e As System.EventArgs) Handles ComboBox6.TextChanged

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dim cmds As New OleDbCommand("SELECT * FROM Recipes WHERE ID = " & ComboBox5.SelectedItem & "", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()
        Label2.Text = x.Item("title")
        Label4.Text = x.Item("uname")
        PictureBox7.ImageLocation = x.Item("Pic")
        con.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        ViewAll.Show()
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        Dim cmds As New OleDbCommand("SELECT * FROM Recipes WHERE ID = " & ComboBox6.SelectedItem & "", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()
        Label13.Text = x.Item("title")
        Label11.Text = x.Item("uname")
        PictureBox5.ImageLocation = x.Item("Pic")
        con.Close()
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        Dim cmds As New OleDbCommand("SELECT * FROM Recipes WHERE ID = " & ComboBox7.SelectedItem & "", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()
        Label16.Text = x.Item("title")
        Label14.Text = x.Item("uname")
        PictureBox8.ImageLocation = x.Item("Pic")
        con.Close()
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged
        Dim cmds As New OleDbCommand("SELECT * FROM Recipes WHERE ID = " & ComboBox8.SelectedItem & "", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()
        Label22.Text = x.Item("title")
        Label26.Text = x.Item("uname")
        Label25.Text = x.Item("ID")
        con.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Users.Show()

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
            Users.Close()

            Index.TextBox2.Clear()
            Index.Show()
            Me.Close()

        End If
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
        Users.Close()

    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseHover
        PictureBox4.Visible = False
    End Sub
End Class