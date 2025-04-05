<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddQuestion
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
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbExamno = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSem = New System.Windows.Forms.ComboBox()
        Me.txtQno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbAnswer = New System.Windows.Forms.ComboBox()
        Me.txtOptionD = New System.Windows.Forms.TextBox()
        Me.txtOptionC = New System.Windows.Forms.TextBox()
        Me.txtOptionB = New System.Windows.Forms.TextBox()
        Me.txtOptionA = New System.Windows.Forms.TextBox()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtQid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbCourse
        '
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(166, 124)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(255, 24)
        Me.cmbCourse.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(65, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(561, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Exam.No"
        '
        'cmbExamno
        '
        Me.cmbExamno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExamno.FormattingEnabled = True
        Me.cmbExamno.Location = New System.Drawing.Point(665, 125)
        Me.cmbExamno.Name = "cmbExamno"
        Me.cmbExamno.Size = New System.Drawing.Size(255, 24)
        Me.cmbExamno.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(559, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Subject"
        '
        'cmbSubject
        '
        Me.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Location = New System.Drawing.Point(660, 72)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(255, 24)
        Me.cmbSubject.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(45, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Semester"
        '
        'cmbSem
        '
        Me.cmbSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSem.FormattingEnabled = True
        Me.cmbSem.Location = New System.Drawing.Point(166, 172)
        Me.cmbSem.Name = "cmbSem"
        Me.cmbSem.Size = New System.Drawing.Size(255, 24)
        Me.cmbSem.TabIndex = 6
        '
        'txtQno
        '
        Me.txtQno.Location = New System.Drawing.Point(665, 169)
        Me.txtQno.Multiline = True
        Me.txtQno.Name = "txtQno"
        Me.txtQno.Size = New System.Drawing.Size(255, 28)
        Me.txtQno.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(561, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Qn.No"
        '
        'cmbAnswer
        '
        Me.cmbAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnswer.FormattingEnabled = True
        Me.cmbAnswer.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cmbAnswer.Location = New System.Drawing.Point(226, 547)
        Me.cmbAnswer.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAnswer.Name = "cmbAnswer"
        Me.cmbAnswer.Size = New System.Drawing.Size(256, 28)
        Me.cmbAnswer.TabIndex = 29
        '
        'txtOptionD
        '
        Me.txtOptionD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptionD.Location = New System.Drawing.Point(226, 498)
        Me.txtOptionD.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOptionD.Name = "txtOptionD"
        Me.txtOptionD.Size = New System.Drawing.Size(765, 26)
        Me.txtOptionD.TabIndex = 28
        '
        'txtOptionC
        '
        Me.txtOptionC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptionC.Location = New System.Drawing.Point(226, 451)
        Me.txtOptionC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOptionC.Name = "txtOptionC"
        Me.txtOptionC.Size = New System.Drawing.Size(765, 26)
        Me.txtOptionC.TabIndex = 27
        '
        'txtOptionB
        '
        Me.txtOptionB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptionB.Location = New System.Drawing.Point(226, 400)
        Me.txtOptionB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOptionB.Name = "txtOptionB"
        Me.txtOptionB.Size = New System.Drawing.Size(765, 26)
        Me.txtOptionB.TabIndex = 26
        '
        'txtOptionA
        '
        Me.txtOptionA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptionA.Location = New System.Drawing.Point(226, 360)
        Me.txtOptionA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOptionA.Name = "txtOptionA"
        Me.txtOptionA.Size = New System.Drawing.Size(765, 26)
        Me.txtOptionA.TabIndex = 25
        '
        'txtQuestion
        '
        Me.txtQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.Location = New System.Drawing.Point(226, 276)
        Me.txtQuestion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQuestion.Size = New System.Drawing.Size(765, 67)
        Me.txtQuestion.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(37, 551)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Correct Answer:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(86, 501)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Option (D)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(85, 451)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Option (C)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(82, 404)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Option (B)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(82, 360)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Option (A)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(89, 298)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Question:"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(307, 639)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(201, 57)
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.Text = "Insert"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNext.Location = New System.Drawing.Point(616, 639)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(201, 57)
        Me.btnNext.TabIndex = 31
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(886, 727)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 57)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "View/Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(62, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 25)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Qn.ID"
        '
        'txtQid
        '
        Me.txtQid.Location = New System.Drawing.Point(166, 68)
        Me.txtQid.Multiline = True
        Me.txtQid.Name = "txtQid"
        Me.txtQid.ReadOnly = True
        Me.txtQid.Size = New System.Drawing.Size(255, 28)
        Me.txtQid.TabIndex = 33
        '
        'AddQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 841)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtQid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbAnswer)
        Me.Controls.Add(Me.txtOptionD)
        Me.Controls.Add(Me.txtOptionC)
        Me.Controls.Add(Me.txtOptionB)
        Me.Controls.Add(Me.txtOptionA)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbSem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbExamno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCourse)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddQuestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbExamno As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSubject As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbSem As ComboBox
    Friend WithEvents txtQno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbAnswer As ComboBox
    Friend WithEvents txtOptionD As TextBox
    Friend WithEvents txtOptionC As TextBox
    Friend WithEvents txtOptionB As TextBox
    Friend WithEvents txtOptionA As TextBox
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtQid As TextBox
End Class
