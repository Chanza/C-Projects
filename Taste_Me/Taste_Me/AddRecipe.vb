Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class AddRecipe
    Dim query As OleDbCommand
    Dim myfilelocation As String
    Dim newpic As String = ""
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\TasteMe.mdb;")
    Private Sub AddRecipe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\TasteMe.mdb", FileAttributes.Hidden)
        Label2.Text = Home.Label9.Text
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label3.Visible = True
        TextBox2.Visible = True
        PictureBox3.Visible = True

        PictureBox9.Visible = True
        PictureBox10.Visible = True
        PictureBox8.Visible = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Label4.Visible = True
        TextBox3.Visible = True
        PictureBox4.Visible = True

        PictureBox14.Visible = True
        PictureBox17.Visible = True
        PictureBox13.Visible = True
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        Label5.Visible = True
        PictureBox1.Visible = True
        Button1.Visible = True
        PictureBox6.Visible = True

        Button5.Visible = True
        PictureBox7.Visible = True

        PictureBox12.Visible = True
        PictureBox11.Visible = True
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        Label6.Visible = True
        TextBox4.Visible = True
        PictureBox5.Visible = True

        PictureBox15.Visible = True
        PictureBox16.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try

            OpenFileDialog1.InitialDirectory = "c:\"
            OpenFileDialog1.Title = "choose image"
            OpenFileDialog1.Filter = "jpg|*.jpg"
            OpenFileDialog1.ShowDialog()
            myfilelocation = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(myfilelocation)
            MessageBox.Show("Image has been Uploaded", "NOTIFICATION")
            OpenFileDialog1.Reset()

            'OpenFileDialog1.ShowDialog()
            'PictureBox1.ImageLocation = OpenFileDialog1.FileName
            'newpic = "pic" + TextBox2.Text + IO.Path.GetExtension(OpenFileDialog1.FileName)

        Catch
            MessageBox.Show("Image Not Uploaded", "NOTIFICATION")
        End Try
    End Sub

    Private Sub Button5_Click_1(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim z As String

        If TextBox1.Text = ("") Then
            z = MessageBox.Show("Please enter Recipe Name", "NOTIFICATION")
        Else
            If ComboBox1.Text = ("") Then
                z = MessageBox.Show("Please enter Recipe Category", "NOTIFICATION")
            Else
                If TextBox2.Text = ("") Then
                    z = MessageBox.Show("Please enter the Ingredients needed", "NOTIFICATION")
                Else
                    If TextBox3.Text = ("") Then
                        z = MessageBox.Show("Please enter Steps to prepare Meal", "NOTIFICATION")
                    Else
                        If TextBox4.Text = ("") Then
                            z = MessageBox.Show("Please enter More Info", "NOTIFICATION")
                        Else
                            If Label2.Text = ("") Then
                                z = MessageBox.Show(" Uname Missing", "NOTIFICATION")

                            Else


                                Dim x As String
                                x = MessageBox.Show("Are you sure you want to save?", "CONFIRMATION", MessageBoxButtons.YesNo)
                                If x = vbYes Then

                                    '***************Insert Code****************************************************************************************************************************************************************************************************************************************************************************************************************
                                    query = New OleDbCommand("insert into Recipes(title,catg,ingredients,steps,info,uname,pic,Rate,NumRaters)values('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & Label2.Text & "','" & myfilelocation & "','" & Label7.Text & "','" & Label8.Text & "')", con)

                                    con.Open()
                                    query.ExecuteNonQuery()
                                    con.Close()
                                    MessageBox.Show("New Recipe Added", "NOTIFICATION")

                                    Me.Close()

                                Else
                                    MessageBox.Show("Account Not Saved", "NOTIFICATION")
                                    TextBox1.Focus()

                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class