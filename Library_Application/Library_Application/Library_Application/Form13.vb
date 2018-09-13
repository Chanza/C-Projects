Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form13
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\lib.mdb;")
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\lib.mdb", FileAttributes.Hidden)
        Label13.Visible = False
        Label14.Visible = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim cmds As New OleDbCommand("SELECT * FROM Books WHERE isbn = '" & TextBox11.Text & "'", con)
            Dim x As OleDbDataReader
            con.Open()
            x = cmds.ExecuteReader()
            x.Read()
            If TextBox11.Text = x.Item("isbn") Then
                Label13.Visible = True
                Label14.Visible = True
                Label14.Text = x.Item("title")
                Label13.Text = x.Item("copies")
            Else
                MessageBox.Show("Book Not Found", "NOTIFICATION")
            End If
        Catch
            MessageBox.Show("Book Not Found", "NOTIFICATION")
        End Try
                con.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim a, b As Date
        Dim c As Long
        Try
            Dim cmds As New OleDbCommand("SELECT * FROM Borrowed WHERE uid = '" & TextBox13.Text & "'", con)
            Dim x As OleDbDataReader
            con.Open()
            x = cmds.ExecuteReader()
            x.Read()
            If TextBox13.Text = x.Item("uid") Then
                TextBox7.Text = x.Item("bname")
                TextBox12.Text = x.Item("isbn")
                TextBox8.Text = x.Item("rd")
            Else
                MessageBox.Show("Record Not Found", "NOTIFICATION")
            End If
            'TextBox8.Text = Today

            a = Today
            b = TextBox8.Text
            c = DateDiff(DateInterval.DayOfYear, b, a)
            TextBox9.Text = c
            If c > 0 Then
                TextBox10.Text = c * 2
            End If
        Catch
            MessageBox.Show("Record Not Found", "NOTIFICATION")
        End Try
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim y As String
        y = MessageBox.Show("Are you sure you want to delete this record from the Database?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If y = vbYes Then
            Dim cmds As New OleDbCommand("DELETE * FROM Borrowed WHERE isbn = '" & TextBox13.Text & "'", con)

            con.Open()
            cmds.ExecuteReader()
            MessageBox.Show("Record Deleted", "NOTIFICATION")
            con.Close()
        Else
            MessageBox.Show("Record NOT Deleted", "NOTIFICATION")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        

        If Label13.Text > 0 Then

            Dim x As String
            x = MessageBox.Show("Are you sure you want to Add a New Book", "CONFIRM", MessageBoxButtons.YesNo)
            If x = vbYes Then

                query = New OleDbCommand("insert into Borrowed(isbn,bname,uname,uid,bd,rd)values('" & TextBox11.Text & "','" & Label14.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')", con)
                con.Open()
                query.ExecuteNonQuery()
                con.Close()

                Dim ncopy As Integer
                ncopy = Val(Label13.Text) - 1

                Dim int As String = "UPDATE Books SET copies=" & CInt(ncopy) & " where isbn= '" & TextBox11.Text & "'"
                Dim cmnds As New OleDbCommand(int, con)
                con.Open()
                cmnds.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Record Added", "NOTIFICATION")
            Else
                'MessageBox.Show("Record Not Added", "NOTIFICATION")
            End If
        Else
            MessageBox.Show("No more Book copies Available", "NOTIFICATION")
        End If
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged


    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        TextBox4.Text = Today
        TextBox5.Text = Today.AddDays(20)
    End Sub

    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home.Click
        Form4.BringToFront()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
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

        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub
End Class