<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        lblName = New Label()
        rbtnMale = New RadioButton()
        ComboBox1 = New ComboBox()
        chkbxSignMeUp = New CheckBox()
        TextBox2 = New TextBox()
        lblSurname = New Label()
        TextBox3 = New TextBox()
        lblEmailAddress = New Label()
        cboxProfession = New Label()
        Label5 = New Label()
        chkbxSubscribe = New CheckBox()
        rbtnFemale = New RadioButton()
        rbtnOther = New RadioButton()
        btnClickMe = New Button()
        Label6 = New Label()
        lblGender = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(324, 63)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 27)
        TextBox1.TabIndex = 0
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(173, 70)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 1
        lblName.Text = "Name"
        ' 
        ' rbtnMale
        ' 
        rbtnMale.AutoSize = True
        rbtnMale.Location = New Point(570, 86)
        rbtnMale.Name = "rbtnMale"
        rbtnMale.Size = New Size(63, 24)
        rbtnMale.TabIndex = 2
        rbtnMale.TabStop = True
        rbtnMale.Text = "Male"
        rbtnMale.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Manager", "Teacher", "Student"})
        ComboBox1.Location = New Point(324, 214)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 3
        ' 
        ' chkbxSignMeUp
        ' 
        chkbxSignMeUp.AutoSize = True
        chkbxSignMeUp.Location = New Point(324, 284)
        chkbxSignMeUp.Name = "chkbxSignMeUp"
        chkbxSignMeUp.Size = New Size(108, 24)
        chkbxSignMeUp.TabIndex = 4
        chkbxSignMeUp.Text = "Sign Me Up"
        chkbxSignMeUp.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(324, 114)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(151, 27)
        TextBox2.TabIndex = 0
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Location = New Point(173, 121)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(67, 20)
        lblSurname.TabIndex = 1
        lblSurname.Text = "Surname"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(324, 161)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(151, 27)
        TextBox3.TabIndex = 0
        ' 
        ' lblEmailAddress
        ' 
        lblEmailAddress.AutoSize = True
        lblEmailAddress.Location = New Point(173, 168)
        lblEmailAddress.Name = "lblEmailAddress"
        lblEmailAddress.Size = New Size(103, 20)
        lblEmailAddress.TabIndex = 1
        lblEmailAddress.Text = "Email Address"
        ' 
        ' cboxProfession
        ' 
        cboxProfession.AutoSize = True
        cboxProfession.Location = New Point(173, 222)
        cboxProfession.Name = "cboxProfession"
        cboxProfession.Size = New Size(77, 20)
        cboxProfession.TabIndex = 1
        cboxProfession.Text = "Profession"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(173, 222)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 1
        ' 
        ' chkbxSubscribe
        ' 
        chkbxSubscribe.AutoSize = True
        chkbxSubscribe.Location = New Point(324, 314)
        chkbxSubscribe.Name = "chkbxSubscribe"
        chkbxSubscribe.Size = New Size(95, 24)
        chkbxSubscribe.TabIndex = 4
        chkbxSubscribe.Text = "Subscribe"
        chkbxSubscribe.UseVisualStyleBackColor = True
        ' 
        ' rbtnFemale
        ' 
        rbtnFemale.AutoSize = True
        rbtnFemale.Location = New Point(570, 114)
        rbtnFemale.Name = "rbtnFemale"
        rbtnFemale.Size = New Size(78, 24)
        rbtnFemale.TabIndex = 2
        rbtnFemale.TabStop = True
        rbtnFemale.Text = "Female"
        rbtnFemale.UseVisualStyleBackColor = True
        ' 
        ' rbtnOther
        ' 
        rbtnOther.AutoSize = True
        rbtnOther.Location = New Point(570, 144)
        rbtnOther.Name = "rbtnOther"
        rbtnOther.Size = New Size(67, 24)
        rbtnOther.TabIndex = 2
        rbtnOther.TabStop = True
        rbtnOther.Text = "Other"
        rbtnOther.UseVisualStyleBackColor = True
        ' 
        ' btnClickMe
        ' 
        btnClickMe.Location = New Point(332, 383)
        btnClickMe.Name = "btnClickMe"
        btnClickMe.Size = New Size(94, 29)
        btnClickMe.TabIndex = 5
        btnClickMe.Text = "Click Me"
        btnClickMe.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Snap ITC", 16.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(149, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(499, 36)
        Label6.TabIndex = 1
        Label6.Text = "Sign Up For an Amazing Thing"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(560, 63)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(57, 20)
        lblGender.TabIndex = 1
        lblGender.Text = "Gender"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnClickMe)
        Controls.Add(chkbxSubscribe)
        Controls.Add(chkbxSignMeUp)
        Controls.Add(ComboBox1)
        Controls.Add(rbtnOther)
        Controls.Add(rbtnFemale)
        Controls.Add(rbtnMale)
        Controls.Add(Label5)
        Controls.Add(cboxProfession)
        Controls.Add(lblEmailAddress)
        Controls.Add(lblSurname)
        Controls.Add(Label6)
        Controls.Add(lblGender)
        Controls.Add(lblName)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents chkbxSignMeUp As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents cboxProfession As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chkbxSubscribe As CheckBox
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents rbtnOther As RadioButton
    Friend WithEvents btnClickMe As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblGender As Label
End Class
