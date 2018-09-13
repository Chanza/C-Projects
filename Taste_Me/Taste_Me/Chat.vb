Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Chat
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\TasteMe.mdb;")
    Dim query As OleDbCommand
    'Dim myfilelocation As String
    'Dim newpic As String = ""
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim z As String
        If TextBox1.Text = ("") Then
            z = MessageBox.Show("Enter a message", "NOTIFICATION")
        Else

            query = New OleDbCommand("insert into Msg(msgID,rev,sen,det)values('" & Label3.Text & "','" & Label1.Text & "','" & Home.Label9.Text & "','" & TextBox1.Text & "')", con)

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
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                i = i + 1
            Loop
            query.Dispose()
            str = "SELECT * FROM Msg WHERE msgID = '" & Label3.Text & "'"
            i = 0
            query = New OleDbCommand(str, con)
            r = query.ExecuteReader

            Do While r.Read()
                DataGridView1.Item(0, i).Value = r("det")
                DataGridView1.Item(1, i).Value = r("det")


                'DataGridView1.Item(5, i).Value = r("rd")

                If r("sen") = Label1.Text Then
                    DataGridView1.Item(1, i).Value = " "

                Else
                    DataGridView1.Item(0, i).Value = " "


                End If

                'If r("rd") < Today Then
                '    DataGridView1.Item(6, i).Value = "Overdue"
                'End If

                i = i + 1
            Loop
            con.Close()

            TextBox1.Clear()

            '****************************************************************

        End If
    End Sub

    Private Sub Chat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\TasteMe.mdb", FileAttributes.Hidden)

        Label1.Text = Home.ComboBox1.Text
        Label3.Text = Home.Label33.Text

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim str As String
        Dim r As OleDbDataReader
        str = "SELECT * FROM Msg"
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
        str = "SELECT * FROM Msg WHERE msgID = '" & Label3.Text & "'"
        i = 0
        query = New OleDbCommand(str, con)
        r = query.ExecuteReader

        Do While r.Read()
            DataGridView1.Item(0, i).Value = r("det")
            DataGridView1.Item(1, i).Value = r("det")


            'DataGridView1.Item(5, i).Value = r("rd")

            If r("sen") = Label1.Text Then
                DataGridView1.Item(1, i).Value = " "

            Else
                DataGridView1.Item(0, i).Value = " "


            End If

            'If r("rev") = Label1.Text Then
            '    DataGridView1.Item(1, i).Value = " "
            'End If

            'If r("rd") < Today Then
            '    DataGridView1.Item(6, i).Value = "Overdue"
            'End If

            i = i + 1
        Loop
        con.Close()

        TextBox1.Clear()
    End Sub
End Class