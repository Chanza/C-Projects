<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(429, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 23)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "ADMIN HELP"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.ListBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Items.AddRange(New Object() {"", "LOG OUT", "To Log out, the user must simply click on the button labelled ‘Log Out’. ", "Once this is done a confirmation will appear, asking whether the user still inten" & _
                        "ds to log out, if so, they must click ‘Yes’,", "but if not they must chose ‘No’.", "", "VIEW PROFILE", "The user must click on the button named ‘Profile’, this will immediately change a" & _
                        " section of the home and show the", "user their individual profile with information. In this section, navigating betwe" & _
                        "en the different tabs or pages can be done", "by using the green navigational arrows, or clicking on the information tab they w" & _
                        "ish to view instantly.", "", "NAVIGATION", "This is done using the arrows. Provide easy switching between tabs. green in colo" & _
                        "ur.", " ", "", "REFRESH", "In the unlikely event of any problem, such as a page not appearing all the system" & _
                        " not performing like it is supposed to, ", "the ‘Refresh’ button – located at the top right has been provided. This will rest" & _
                        " any actions and cancel any processes ", "that are taking place.", "", "", "ADMIN SPECIFIC FEATURES MANUAL", "", "ADDING NEW STAFF MEMBER", "The administration member must first click on the button ‘Add New Academic Staff " & _
                        "Member’, there after a collection of", "tabs will appear. On this a new form will appear. The adding of users can be done" & _
                        " in two ways here. The first is when one", "wishes to add a single user and the second, to add multiple users in a role.", "", "*Adding a single user at a time;", "The information in the textboxes must be filled in. the user can navigate back an" & _
                        "d forth between tabs using the greens", "arrows or by actually clicking on a specific tab. Next the user must click on the" & _
                        " ‘Save’ button. ", "", "Possible error to stop the record from saving", "•" & Global.Microsoft.VisualBasic.ChrW(9) & "Textboxes are left empty", "•" & Global.Microsoft.VisualBasic.ChrW(9) & "Data is not keyed in correctly, only then will the system ", "These can be avoided all solved by doing what the message box suggests.", "", "*Adding multiple users;", "The ‘Add Multiple Users’ button clicked must be selected first. This will bring o" & _
                        "ut an input box asking how many users the", "admin intends to add. A digit must be keyed in. After a series of other input box" & _
                        " asking the user to fill specific data will", "continue to pop up in quick succession whenever one is filled until all required " & _
                        "information is entered. Once done the system", "asks to confirm the save. After which the system will start again asking for the " & _
                        "same data for the next user. This will continue", "until the specified number of users that was entered is satisfied. Only then will" & _
                        " the loop end unless the admin cancels it", "manually by clicking cancel.", "", "*End.*"})
        Me.ListBox1.Location = New System.Drawing.Point(37, 63)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(923, 424)
        Me.ListBox1.TabIndex = 21
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1004, 526)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(40, 110)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
