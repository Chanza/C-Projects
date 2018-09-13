Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Public Class Form4
    Dim query As OleDbCommand

    Dim ID(2) As String
    Dim uname(2) As String
    Dim pword(2) As String
    Dim gender(2) As String
    Dim bdate(2) As String
    Dim mobile(2) As String
    Dim email(2) As String
    Dim cert(2) As String
    Dim subj(2) As String
    Dim dept(2) As String
    Dim salary(2) As Integer
    Dim loc(2) As String
    Dim adress(2) As String
    Dim cal(2) As String
    Dim hiredate(2) As String
    Dim pic(2) As String

    Dim myfilelocation As String
    Dim newpic As String = ""
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\NursingC.mdb;")
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        File.SetAttributes(Application.StartupPath & "\NursingC.mdb", FileAttributes.Hidden)

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Form9.Show()
        Dim z As String

        If TextBox1.Text = ("") Then
            z = MessageBox.Show("Please enter Full name", "NOTIFICATION")
        Else
            If TextBox2.Text = ("") Then
                z = MessageBox.Show("Please enter User ID", "NOTIFICATION")
            Else
                If TextBox3.Text = ("") Then
                    z = MessageBox.Show("Please enter Password", "NOTIFICATION")
                Else
                    If TextBox3.Text <> TextBox4.Text Then
                        z = MessageBox.Show("Passwords do not match", "NOTIFICATION")
                    Else
                        If ComboBox1.Text = ("") Then
                            z = MessageBox.Show("Please enter Gender", "NOTIFICATION")
                        Else
                            If TextBox5.Text = ("") Then
                                z = MessageBox.Show("Please enter a valid email", "NOTIFICATION")
                            Else
                                If TextBox6.Text = ("") Then
                                    z = MessageBox.Show("Please enter a contact number", "NOTIFICATION")
                                Else
                                    If DateTimePicker1.Text = ("") Then
                                        z = MessageBox.Show("Enter Date of Birth", "NOTIFICATION")
                                    Else
                                        If TextBox7.Text = ("") Then
                                            z = MessageBox.Show("Please enter Certification", "NOTIFICATION")
                                        Else
                                            If TextBox8.Text = ("") Then
                                                z = MessageBox.Show("Please enter the Subjects", "NOTIFICATION")
                                            Else
                                                If TextBox9.Text = ("") Then
                                                    z = MessageBox.Show("Please enter the Department", "NOTIFICATION")
                                                Else
                                                    If TextBox10.Text = ("") Then
                                                        z = MessageBox.Show("Please enter the Salary", "NOTIFICATION")
                                                    Else
                                                        If TextBox12.Text = ("") Then
                                                            z = MessageBox.Show("Please enter Office Number", "NOTIFICATION")
                                                        Else
                                                            If DateTimePicker2.Text = ("") Then
                                                                z = MessageBox.Show("Please enter the Date of Hire", "NOTIFICATION")
                                                            Else
                                                                If TextBox11.Text = ("") Then
                                                                    z = MessageBox.Show("Please enter the Address", "NOTIFICATION")
                                                                Else
                                                                    If ComboBox2.Text = ("") Then
                                                                        z = MessageBox.Show("Please enter the Calender", "NOTIFICATION")
                                                                    Else




                                                                        'If TextBox3.Text = TextBox4.Text Then
                                                                        Dim x As String
                                                                        x = MessageBox.Show("Are you sure you want to save?", "CONFIRMATION", MessageBoxButtons.YesNo)
                                                                        If x = vbYes Then

                                                                            query = New OleDbCommand("insert into staff(uname,ID,pword,gender,bdate,email,mobile,cert,sub,dept,salary,loc,adress,hiredate,cal,pic)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox12.Text & "','" & TextBox11.Text & "','" & DateTimePicker2.Text & "','" & ComboBox2.Text & "', '" & myfilelocation & "')", con)
                                                                            'query = New OleDbCommand("insert into staff(ID,pword,gender,bdate,email,pic)values('" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox5.Text & "','" & DateTimePicker1.Text & "','" & myfilelocation & "')", con)
                                                                            con.Open()
                                                                            query.ExecuteNonQuery()
                                                                            'System.IO.File.Copy(OpenFileDialog1.FileName, Application.StartupPath + newpic)
                                                                            con.Close()
                                                                            MessageBox.Show("New User Account Created", "NOTIFICATION")

                                                                            Me.Close()

                                                                        Else
                                                                            MessageBox.Show("Account Not Saved", "NOTIFICATION")
                                                                            TextBox3.Focus()

                                                                        End If
                                                                        'MessageBox.Show("Check Passwords", "NOTIFICATION")
                                                                        'End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 1
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 2
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim i As Integer = 1
        TabControl1.SelectedIndex = i - 1
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Dim i As Integer = 2
        TabControl1.SelectedIndex = i - 1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
       
        Dim n As Integer
        n = InputBox("Enter the Number of User you wish to Add", XPos:=600, YPos:=250, Title:="Number of Users?")
        
            For i As Integer = 1 To n
                Dim x As Integer
                Do
                    uname(i) = InputBox("Please Enter User Name", XPos:=600, YPos:=250, Title:="Adding Users")

                    If IsNumeric(uname(i)) Then
                        MessageBox.Show("Numeric values are Not Allowed", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1

                If uname(i) = String.Empty Then

                    Exit For
                End If

                TextBox1.Text = uname(i)

                Do
                    ID(i) = InputBox("Please Enter the Staff ID Number", XPos:=600, YPos:=250, Title:="Adding Users")
                    If ID(i) = ("") Then
                        MessageBox.Show("Please enter the ID Number", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1
                TextBox2.Text = ID(i)

                Do
                    pword(i) = InputBox("Please give a Password", XPos:=600, YPos:=250, Title:="Adding Users")
                    If pword(i) = ("") Then
                        MessageBox.Show("Please give a Password", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1
                If pword(i) = String.Empty Then
                    Exit For
                End If
                TextBox3.Text = pword(i)

                Do
                    gender(i) = InputBox("Enter Gender", XPos:=600, YPos:=250, Title:="Adding Users")
                    If Not gender(i) = "male" And
                        Not gender(i) = "female" Then
                        MessageBox.Show("Gender should either be male or female", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1
                ComboBox1.Text = gender(i)

                Do
                    bdate(i) = InputBox("Enter staff Date of Birth (dd/mm/yyyy)", XPos:=600, YPos:=250, Title:="Adding Users")
                    If Not IsDate(bdate(i)) Then
                        MessageBox.Show("Wrong format, enter as dd/mm/yyyy", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1
                DateTimePicker1.Text = bdate(i)

                Do
                    cert(i) = InputBox("Enter Highest Qualification or Cetrificate", XPos:=600, YPos:=250, Title:="Adding Users")
                    If cert(i) = ("") Then
                        MessageBox.Show("Please enter Qualification", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1

                Dim a As Integer = 0
                TabControl1.SelectedIndex = a + 1

                TextBox7.Text = cert(i)

                Do
                    subj(i) = InputBox("Enter Subject(s)", XPos:=600, YPos:=250, Title:="Adding Users")
                    If subj(i) = ("") Then
                        MessageBox.Show("Please enter Subjects", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1
                TextBox8.Text = subj(i)

                Do
                    dept(i) = InputBox("Enter Department", XPos:=600, YPos:=250, Title:="Adding Users")
                    If dept(i) = ("") Then
                        MessageBox.Show("Please enter Department", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1
                TextBox9.Text = dept(i)


                Do
                    salary(i) = InputBox("Enter Staff's Salary", XPos:=600, YPos:=250, Title:="Adding Users")
                    If Not IsNumeric(salary(i)) Then
                        MessageBox.Show("Please enter Salary", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1
                TextBox10.Text = salary(i)

                Do
                    loc(i) = InputBox("Enter location of the Staff's Office", XPos:=600, YPos:=250, Title:="Adding Users")
                    If loc(i) = ("") Then
                        MessageBox.Show("Please enter Office Location", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1
                TextBox12.Text = loc(i)


                Do
                    hiredate(i) = InputBox("Enter staff's Hire Date (dd/mm/yyyy)", XPos:=600, YPos:=250, Title:="Adding Users")
                    If Not IsDate(hiredate(i)) Then
                        MessageBox.Show("Wrong format, enter as dd/mm/yyyy", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1
                DateTimePicker2.Text = hiredate(i)

                Do
                    email(i) = InputBox("Enter Email Address", XPos:=600, YPos:=250, Title:="Adding Users")
                    If email(i) = ("") Then
                        MessageBox.Show("Please enter Email", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1

                Dim b As Integer = 0
                TabControl1.SelectedIndex = b + 2

                TextBox5.Text = email(i)

                Do
                    mobile(i) = InputBox("Enter Mobile Number", XPos:=600, YPos:=250, Title:="Adding Users")
                    If mobile(i) = ("") Then
                        MessageBox.Show("Please enter Mobile Number", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1
                TextBox6.Text = mobile(i)

                Do
                    adress(i) = InputBox("Enter Address", XPos:=600, YPos:=250, Title:="Adding Users")
                    If adress(i) = ("") Then
                        MessageBox.Show("Please enter Address", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1
                TextBox11.Text = adress(i)

                Do
                    cal(i) = InputBox("Enter the Staff's Calender e.g A, B or C", XPos:=600, YPos:=250, Title:="Adding Users")
                    If cal(i) = ("") Or
                        Not cal(i) = "A" And
                        Not cal(i) = "B" And
                        Not cal(i) = "C" Then
                        MessageBox.Show("Please enter Calender (A, B or C)", "NOTIFICATION")
                        x = 0
                    Else
                        x = 1
                    End If
                Loop Until x = 1
                ComboBox2.Text = cal(i)


                'TextBox1.Text = uname(i)
                'TextBox2.Text = ID(i)
                'TextBox3.Text = pword(i)
                'ComboBox1.Text = gender(i)
                'DateTimePicker1.Text = bdate(i)
                'TextBox5.Text = mobile(i)
                'TextBox6.Text = email(i)
                'ComboBox2.Text = cal(i)
                'TextBox8.Text = subj(i)
                'TextBox10.Text = salary(i)
                'TextBox7.Text = cert(i)
                'TextBox9.Text = dept(i)
                'TextBox12.Text = loc(i)
                'TextBox11.Text = adress(i)
                'DateTimePicker2.Text = hiredate(i)
                'PictureBox1.Text = pic(i)

                Dim ans As Integer = MsgBox("Are You Sure You Want To Add The New Reccord?", vbYesNo)
                If ans = vbYes Then
                    'query = New OleDbCommand("insert into Staff(fname,stfID,lname,gender,dob,phno,mail,pass,addr,quali) values('" & TextBox1.Text & "','" & TextBox4.Text & "', '" & TextBox6.Text & "', '" & TextBox10.Text & "', '" & TextBox2.Text & "', '" & TextBox8.Text & "', '" & TextBox7.Text & "', '" & TextBox5.Text & "', '" & TextBox9.Text & "', '" & TextBox3.Text & "')", con)
                    query = New OleDbCommand("insert into staff(uname,ID,pword,gender,bdate,email,mobile,cert,sub,dept,salary,loc,adress,hiredate,cal,pic)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox12.Text & "','" & TextBox11.Text & "','" & DateTimePicker2.Text & "','" & ComboBox2.Text & "', '" & myfilelocation & "')", con)
                    con.Open()
                    Try
                        query.ExecuteNonQuery()
                        MessageBox.Show("New Staff member Successfully Added")

                        TextBox1.Clear()
                        TextBox2.Clear()
                        TextBox3.Clear()
                        TextBox4.Clear()
                        TextBox5.Clear()
                        TextBox6.Clear()
                        TextBox7.Clear()
                        TextBox8.Clear()
                        TextBox9.Clear()
                        TextBox10.Clear()
                        TextBox11.Clear()
                        TextBox12.Clear()
                        ComboBox1.ResetText()
                        DateTimePicker1.ResetText()
                        ComboBox2.ResetText()
                        DateTimePicker2.ResetText()

                    Catch ex As Exception
                        MsgBox("Staff ID Already Exists.. Try again")
                    End Try
                    con.Close()
                End If
            Next i


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim z As String

        If TextBox1.Text = ("") Then
            z = MessageBox.Show("Please enter Full name", "NOTIFICATION")
        Else
            If TextBox2.Text = ("") Then
                z = MessageBox.Show("Please enter User ID", "NOTIFICATION")
            Else
                If TextBox3.Text = ("") Then
                    z = MessageBox.Show("Please enter Password", "NOTIFICATION")
                Else
                    If TextBox3.Text <> TextBox4.Text Then
                        z = MessageBox.Show("Passwords do not match", "NOTIFICATION")
                    Else
                        If ComboBox1.Text = ("") Then
                            z = MessageBox.Show("Please enter Gender", "NOTIFICATION")
                        Else
                            If TextBox5.Text = ("") Then
                                z = MessageBox.Show("Please enter a valid email", "NOTIFICATION")
                            Else
                                If TextBox6.Text = ("") Then
                                    z = MessageBox.Show("Please enter a contact number", "NOTIFICATION")
                                Else
                                    If DateTimePicker1.Text = ("") Then
                                        z = MessageBox.Show("Enter Date of Birth", "NOTIFICATION")
                                    Else
                                        If TextBox7.Text = ("") Then
                                            z = MessageBox.Show("Please enter Certification", "NOTIFICATION")
                                        Else
                                            If TextBox8.Text = ("") Then
                                                z = MessageBox.Show("Please enter the Subjects", "NOTIFICATION")
                                            Else
                                                If TextBox9.Text = ("") Then
                                                    z = MessageBox.Show("Please enter the Department", "NOTIFICATION")
                                                Else
                                                    If TextBox10.Text = ("") Then
                                                        z = MessageBox.Show("Please enter the Salary", "NOTIFICATION")
                                                    Else
                                                        If TextBox12.Text = ("") Then
                                                            z = MessageBox.Show("Please enter Office Number", "NOTIFICATION")
                                                        Else
                                                            If DateTimePicker2.Text = ("") Then
                                                                z = MessageBox.Show("Please enter the Date of Hire", "NOTIFICATION")
                                                            Else
                                                                If TextBox11.Text = ("") Then
                                                                    z = MessageBox.Show("Please enter the Address", "NOTIFICATION")
                                                                Else
                                                                    If ComboBox2.Text = ("") Then
                                                                        z = MessageBox.Show("Please enter the Calender", "NOTIFICATION")
                                                                    Else




                                                                        'If TextBox3.Text = TextBox4.Text Then
                                                                        Dim x As String
                                                                        x = MessageBox.Show("Are you sure you want to save?", "CONFIRMATION", MessageBoxButtons.YesNo)
                                                                        If x = vbYes Then

                                                                            query = New OleDbCommand("insert into staff(uname,ID,pword,gender,bdate,email,mobile,cert,sub,dept,salary,loc,adress,hiredate,cal,pic)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox12.Text & "','" & TextBox11.Text & "','" & DateTimePicker2.Text & "','" & ComboBox2.Text & "', '" & myfilelocation & "')", con)
                                                                            'query = New OleDbCommand("insert into staff(ID,pword,gender,bdate,email,pic)values('" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox5.Text & "','" & DateTimePicker1.Text & "','" & myfilelocation & "')", con)
                                                                            con.Open()
                                                                            query.ExecuteNonQuery()
                                                                            'System.IO.File.Copy(OpenFileDialog1.FileName, Application.StartupPath + newpic)
                                                                            con.Close()
                                                                            MessageBox.Show("New User Account Created", "NOTIFICATION")

                                                                            Me.Close()

                                                                        Else
                                                                            MessageBox.Show("Account Not Saved", "NOTIFICATION")
                                                                            TextBox3.Focus()

                                                                        End If
                                                                        'MessageBox.Show("Check Passwords", "NOTIFICATION")
                                                                        'End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Dim i As Integer = 0
        TabControl1.SelectedIndex = i + 3
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim i As Integer = 3
        TabControl1.SelectedIndex = i - 1
    End Sub
End Class