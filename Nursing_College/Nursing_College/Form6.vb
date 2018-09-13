Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form6
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\NursingC.mdb;")
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\NursingC.mdb", FileAttributes.Hidden)

        Label10.Visible = False

        Dim a, b As Date
        Dim c As Long
        Dim cmds As New OleDbCommand("SELECT * FROM staff WHERE ID = '" & Form9.Label6.Text & "'", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()

        Label5.Text = x.Item("salary")
        Label10.Text = x.Item("hiredate")


        a = Today
        b = label10.Text
        c = DateDiff(DateInterval.Year, b, a)

        If c < 3 Then

            Label11.Text = 5
        Else
            If c < 4 Then
                Label11.Text = 7
            Else
                If c < 6 Then
                    Label11.Text = 10
                Else
                    If c < 8 Then
                        Label11.Text = 15
                    Else
                        Label11.Text = 10
                    End If
                End If
            End If
        End If

        Label6.Text = (Label5.Text / 100) * Label11.Text

        Label7.Text = Label5.Text + ((Label5.Text / 100) * Label11.Text)

        Label8.Text = Label7.Text * 12

        con.Close()


    End Sub
End Class