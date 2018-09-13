Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form1
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\NursingC.mdb;")
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\NursingC.mdb", FileAttributes.Hidden)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If TextBox1.Text = ("") Then
            MessageBox.Show("Please Enter User ID", "NOTIFICATION")

        Else

            If RadioButton2.Checked = True Then
                Try
                    Dim cmds As New OleDbCommand("select * from admin Where ID  = '" & TextBox1.Text & "' ", con)
                    Dim x As OleDbDataReader
                    con.Open()
                    x = cmds.ExecuteReader
                    x.Read()
                    If TextBox1.Text = x.Item("ID") And TextBox2.Text = x.Item("Pword") Then

                        PictureBox6.Visible = False
                        PictureBox4.Visible = True
                        PictureBox7.Visible = True
                        MessageBox.Show("WELCOME", "NOTIFICATION")
                        Form2.Show()
                    Else
                        If TextBox1.Text = x.Item("ID") Then
                            PictureBox4.Visible = True
                            PictureBox7.Visible = False
                            PictureBox6.Visible = True

                        Else
                            MsgBox("Wrong Username/Password")
                        End If
                    End If


                Catch ex As Exception
                    PictureBox5.Visible = True
                    PictureBox6.Visible = True
                    MsgBox(ex.Message)
                End Try

                con.Close()
            Else

                Try
                    Dim cmds As New OleDbCommand("select * from staff Where ID  = '" & TextBox1.Text & "' ", con)
                    Dim x As OleDbDataReader
                    con.Open()
                    x = cmds.ExecuteReader
                    x.Read()
                    If TextBox1.Text = x.Item("ID") And TextBox2.Text = x.Item("Pword") Then

                        PictureBox6.Visible = False
                        PictureBox4.Visible = True
                        PictureBox7.Visible = True
                        MessageBox.Show("WELCOME", "NOTIFICATION")
                        Form9.Show()
                    Else
                        If TextBox1.Text = x.Item("ID") Then
                            PictureBox4.Visible = True
                            PictureBox7.Visible = False
                            PictureBox6.Visible = True

                        Else
                            MsgBox("Wrong Username/Password")
                        End If
                    End If


                Catch ex As Exception
                    PictureBox5.Visible = True
                    PictureBox6.Visible = True
                    MsgBox(ex.Message)
                End Try

                con.Close()

            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        GroupBox1.Visible = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        GroupBox1.Visible = True
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

      
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class