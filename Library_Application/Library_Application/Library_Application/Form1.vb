Public Class Form1

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            Form2.Show()
        Else
            If CheckBox2.Checked = True Then
                Form10.Show()
            Else

                MsgBox("Please Check a box whether Student or Librarian")
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True Then
            Form3.Show()
        Else
            If CheckBox2.Checked = True Then
                Form11.Show()
            Else

                MsgBox("Please Check a box whether Student or Liberarian")
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
