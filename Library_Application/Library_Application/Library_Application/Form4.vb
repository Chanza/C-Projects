Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form4
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\lib.mdb;")
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Visible = False
        Label6.Visible = False
        File.SetAttributes(Application.StartupPath & "\lib.mdb", FileAttributes.Hidden)
        'Try
        '    Dim ds As New DataSet
        '    Dim dr As DataRow
        '    Dim dt As New DataTable
        '    Dim adptr As New OleDbDataAdapter("select * from Books", con)
        '    adptr.Fill(ds, "Books")
        '    dt = ds.Tables(0)
        '    ComboBox1.Items.Clear()
        '    For Each dr In dt.Rows
        '        ComboBox1.Items.Add(dr.Item("title"))
        '    Next
        'Catch ex As Exception
        '    MsgBox("The Database could not be found. Try again")
        '    End
        'End Try

    End Sub

    Private Sub Out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Out.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to Log Out", "CONFIRM", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Form1.BringToFront()
            Me.Close()

            Form2.Close()
            Form3.Close()

            Form5.Close()
            Form6.Close()
            Form7.Close()
            Form8.Close()
            Form9.Close()
            Form10.Close()
            Form11.Close()
            Form12.Close()

        End If
    End Sub

    Private Sub Ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form8.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form9.Show()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox1.Text = ("") Then
            MessageBox.Show("Please select a Book", "NOTIFICATION")
        Else
            Form5.Show()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox1.Text = ("") Then
            MessageBox.Show("Please select a Book", "NOTIFICATION")
        Else
            Form5.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form7.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to delete this record from the Database?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim cmds As New OleDbCommand("DELETE * FROM Books WHERE title = '" & TextBox1.Text & "'", con)

            con.Open()
            cmds.ExecuteReader()
            MessageBox.Show("Record Deleted", "NOTIFICATION")
            con.Close()
        Else
            MessageBox.Show("Record NOT Deleted", "NOTIFICATION")
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form13.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Dim cmds As New OleDbCommand("SELECT * FROM Books WHERE isbn = '" & TextBox1.Text & "'", con)
            Dim x As OleDbDataReader
            con.Open()
            x = cmds.ExecuteReader()
            x.Read()

            If TextBox1.Text = x.Item("isbn") Then
                Label4.Visible = True
                Label6.Visible = True

                Label6.Text = x.Item("title")
                Label4.Text = x.Item("copies")

            Else
                MessageBox.Show("Book Not Found", "NOTIFICATION")
            End If
        Catch
            MessageBox.Show("Book Not Found", "NOTIFICATION")
        End Try
        con.Close()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form14.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form15.Show()
    End Sub
End Class