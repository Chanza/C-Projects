<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.Label15.Location = New System.Drawing.Point(428, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 23)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "STAFF HELP"
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
                        " any actions and cancel any processes ", "that are taking place.", "", "", "STAFF SPECIFIC FEATURES MANUAL", "", "VIEW FINANCIAL STATUS AND STATISTICS", "The staff member has the ability to view their financial status and statistics. W" & _
                        "hich is first activated by first clicking on", "the ‘View Financial Status’ button. A form showing the users current salary is br" & _
                        "ought up. Here the system calculates", "the bonus to be receives, adds it and shows how much the user is expected to get " & _
                        "in a year.", "Calculation of bonus is calculated based on length of employment. An example of t" & _
                        "he form is as seen below;", "", "     Bonus Rates  ", "5%   = Less than 2 years", "7%   = 3 years", "10% = 5 years", "15% = 7 years", "20% = 10 years or more", "", "", "*End.*"})
        Me.ListBox1.Location = New System.Drawing.Point(34, 35)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(923, 424)
        Me.ListBox1.TabIndex = 22
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(988, 488)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(40, 110)
        Me.Name = "Form10"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
