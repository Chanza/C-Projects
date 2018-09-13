<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manual
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"", "REGISTER ACCOUNT:", "In order to use this system to any degree, one needs to first register. This can " & _
                "be done very easily. First of all the ‘Register Button’ must be clicked. This wi" & _
                "ll display the register box with", "empty fields. All these fields must be field with the right amount of characters " & _
                "and order. The system will not individuals register with any empty textboxes. Th" & _
                "ey must fill in;", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Username", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Password", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Full name", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Gender", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Date of birth", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Email", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Number", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Profile picture (optional)", "", "After which they must click ‘Save’. If it is a success then the message ‘Account " & _
                "Saved’ is displayed’, if not then ‘Not Saved’ is displayed. ", "", "LOGIN:", "In order to login, simply click ‘Login Button’ then enter the exact username and " & _
                "password that were used to register. ", "If username is correct, a tick is displayed if wrong then a wrong mark.  If the p" & _
                "assword is wrong the message ‘Wrong Username’ is displayed, but if correct a ‘We" & _
                "lcome Message’ is shown ", "and the user directed to their ‘Home Page’.", "  ", "", "ADD RECIPE:", "In order for the user to add a recipe, they must first get to the ‘Add Recipe For" & _
                "m’. This can be done by either going to the navigation bar (which is available f" & _
                "rom all form), using the drop ", "down menu and selecting the link ‘Add Recipe’ or they can simply go to the bottom" & _
                " right of the page (on the home from) and clicking on the shortcut ‘Add Recipe I" & _
                "con’.", "Once any of these two are done the chef is led to the form where they must enter " & _
                "all the required details and then clicking the ‘Save Button’. They fields requir" & _
                "ed are;", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Recipe title", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Category", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Ingredients", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Steps", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Additional Information", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Image of meal / beverage (optional)", "Every time a field is entered the next to be entered appears and no field can be " & _
                "left empty before saving, that is, it happens automatically.", "", "EDIT & DELETE RECIPE:", "The user must either go to a recipe they have added (cannot edit or delete anothe" & _
                "r user’s recipe) by searching for it or checking on the list of all their added " & _
                "recipes (link on the Navigation", "bar to ‘View My Recipes’). Once they find one, they must click the ‘Edit/Delete B" & _
                "utton’ and a new form is brought up. ", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Edit: change what they want to and then click ‘Save Changes’.", "" & Global.Microsoft.VisualBasic.ChrW(9) & "Delete: click the ‘Delete Button’ and when system asks ‘Yes or No’, select yes." & _
                "", "", "SEARCH FOR RECIPE:", "The user must enter a recipe they are looking for into the search textbox on the " & _
                "‘Home Form’, if available then  all the recipe is shown, but if it is not then t" & _
                "he message ‘Recipe Not Found’ ", "is shown.", "Note: Other main features are Rate, Comment, Chat and Logout."})
        Me.ListBox1.Location = New System.Drawing.Point(49, 83)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(905, 351)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MANUAL"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(938, 451)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 47)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 510)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(16, 132)
        Me.Name = "Manual"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Manual"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
