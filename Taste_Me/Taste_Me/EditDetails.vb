Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class EditDetails
    Dim query As OleDbCommand
    Dim myfilelocation As String
    Dim newpic As String = ""
    Dim a, b, c, sum, avg As Long
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\TasteMe.mdb;")
    Private Sub EditDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\TasteMe.mdb", FileAttributes.Hidden)
        'If Home.TextBox1.Text = "" Then
        '    Label6.Text = ViewAll.TextBox1.Text
        'Else
        '    Label6.Text = Home.TextBox2.Text
        'End If



        'Label6.Text = ViewAll.TextBox1.Text

        Label6.Text = Details.Label6.Text

        Dim cmds As New OleDbCommand("SELECT * FROM Recipes WHERE ID = " & Label6.Text & "", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()

        Label1.Text = x.Item("title")
        Label3.Text = x.Item("uname")
        Label5.Text = x.Item("catg")
        TextBox1.Text = x.Item("ingredients")
        TextBox2.Text = x.Item("steps")
        TextBox3.Text = x.Item("info")
        TextBox6.Text = x.Item("NumRaters")


        If x.Item("Rate") = "0" Then
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            TextBox5.Text = "0"

        Else
            If x.Item("Rate") = "1" Then
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

        PictureBox1.ImageLocation = x.Item("Pic")
        con.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        '**************THIS IS THE CODE USED USED TO UPDATE DATA IN THE DATABASE***********************************************************************************************************************
        Try
            con.Close()
            Dim y As String
            y = MessageBox.Show("Are you sure you want to save these changes?", "CONFIRMATION", MessageBoxButtons.YesNo)
            If y = vbYes Then
                Dim str As String = "UPDATE Recipes SET ingredients='" & TextBox1.Text & "', steps='" & TextBox2.Text & "', info='" & TextBox3.Text & "' WHERE  ID=" & Label6.Text & " "
                Dim cmnds As New OleDbCommand(str, con)
                con.Open()
                cmnds.ExecuteNonQuery()
                MessageBox.Show("Changes Saved", "NOTIFICATION")
                con.Close()
            Else
                MessageBox.Show("Changes Not Saved", "NOTIFICATION")
            End If

        Catch ex2 As Exception
            MessageBox.Show("Could Not Save", "ERROR_47")
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        con.Close()

        '*****************THIS CODE IS USED TO DELETE FROM DATABASE*************************************************************************
        Dim y As String
        y = MessageBox.Show("Sure you want to delete this Recipe?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim cmds As New OleDbCommand("DELETE * FROM Recipes WHERE ID = " & Label6.Text & "", con)

            con.Open()

            cmds.ExecuteReader()
            MessageBox.Show("Recipe Deleted", "NOTIFICATION")
            con.Close()
            Me.Close()
        Else
            MessageBox.Show("Recipe NOT Deleted", "NOTIFICATION")
        End If

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try

            OpenFileDialog1.InitialDirectory = "c:\"
            OpenFileDialog1.Title = "choose image"
            OpenFileDialog1.Filter = "jpg|*.jpg"
            OpenFileDialog1.ShowDialog()
            myfilelocation = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(myfilelocation)
            'MessageBox.Show("Image has been Uploaded", "NOTIFICATION")
            OpenFileDialog1.Reset()

        Catch
            MessageBox.Show("Image Not Uploaded", "NOTIFICATION")
        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        con.Close()
        Dim y As String
        y = MessageBox.Show("Are you sure you want to change image?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim str As String = "UPDATE Recipes SET pic='" & myfilelocation & "' WHERE  ID=" & Label6.Text & " "
            Dim cmnds As New OleDbCommand(str, con)
            con.Open()
            cmnds.ExecuteNonQuery()
            MessageBox.Show("Image Saved", "NOTIFICATION")
            con.Close()
        Else
            MessageBox.Show("Image Not Saved", "NOTIFICATION")
        End If
    End Sub
End Class