Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form15
    Dim query As OleDbCommand
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\lib.mdb;")
    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\lib.mdb", FileAttributes.Hidden)
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False

        Label7.Text = Form4.TextBox1.Text
        Dim cmds As New OleDbCommand("SELECT * FROM Books WHERE isbn = '" & Label7.Text & "'", con)
        Dim x As OleDbDataReader
        con.Open()
        x = cmds.ExecuteReader()
        x.Read()
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True

        Label7.Text = x.Item("isbn")
        Label8.Text = x.Item("copies")
        Label9.Text = x.Item("price")
        Label6.Text = x.Item("title")
        con.Close()
    End Sub
End Class