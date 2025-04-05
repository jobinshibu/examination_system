<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamTest
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTime1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdoD = New System.Windows.Forms.RadioButton()
        Me.rdoC = New System.Windows.Forms.RadioButton()
        Me.rdoB = New System.Windows.Forms.RadioButton()
        Me.rdoA = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtqstn = New System.Windows.Forms.TextBox()
        Me.lblqstn = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblexamno = New System.Windows.Forms.Label()
        Me.lblsem = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblcourse = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTime1
        '
        Me.lblTime1.AutoSize = True
        Me.lblTime1.Font = New System.Drawing.Font("Century Schoolbook", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime1.ForeColor = System.Drawing.Color.Red
        Me.lblTime1.Location = New System.Drawing.Point(1540, 127)
        Me.lblTime1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime1.Name = "lblTime1"
        Me.lblTime1.Size = New System.Drawing.Size(69, 30)
        Me.lblTime1.TabIndex = 21
        Me.lblTime1.Text = "time"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Red
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(1136, 943)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(200, 75)
        Me.btnSubmit.TabIndex = 18
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(553, 944)
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(200, 75)
        Me.btnPrev.TabIndex = 19
        Me.btnPrev.Text = "PREV"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(847, 944)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(200, 75)
        Me.btnNext.TabIndex = 20
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.rdoD)
        Me.Panel2.Controls.Add(Me.rdoC)
        Me.Panel2.Controls.Add(Me.rdoB)
        Me.Panel2.Controls.Add(Me.rdoA)
        Me.Panel2.Location = New System.Drawing.Point(9, 615)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2025, 258)
        Me.Panel2.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(99, 198)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 23)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "(D)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(99, 142)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "(C)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(98, 85)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "(B)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(98, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "(A)"
        '
        'rdoD
        '
        Me.rdoD.AutoSize = True
        Me.rdoD.BackColor = System.Drawing.Color.Transparent
        Me.rdoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoD.ForeColor = System.Drawing.Color.Aqua
        Me.rdoD.Location = New System.Drawing.Point(150, 198)
        Me.rdoD.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoD.Name = "rdoD"
        Me.rdoD.Size = New System.Drawing.Size(131, 24)
        Me.rdoD.TabIndex = 3
        Me.rdoD.TabStop = True
        Me.rdoD.Text = "RadioButton4"
        Me.rdoD.UseVisualStyleBackColor = False
        '
        'rdoC
        '
        Me.rdoC.AutoSize = True
        Me.rdoC.BackColor = System.Drawing.Color.Transparent
        Me.rdoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoC.ForeColor = System.Drawing.Color.Aqua
        Me.rdoC.Location = New System.Drawing.Point(150, 141)
        Me.rdoC.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoC.Name = "rdoC"
        Me.rdoC.Size = New System.Drawing.Size(131, 24)
        Me.rdoC.TabIndex = 2
        Me.rdoC.TabStop = True
        Me.rdoC.Text = "RadioButton3"
        Me.rdoC.UseVisualStyleBackColor = False
        '
        'rdoB
        '
        Me.rdoB.AutoSize = True
        Me.rdoB.BackColor = System.Drawing.Color.Transparent
        Me.rdoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoB.ForeColor = System.Drawing.Color.Aqua
        Me.rdoB.Location = New System.Drawing.Point(149, 85)
        Me.rdoB.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoB.Name = "rdoB"
        Me.rdoB.Size = New System.Drawing.Size(131, 24)
        Me.rdoB.TabIndex = 1
        Me.rdoB.TabStop = True
        Me.rdoB.Text = "RadioButton2"
        Me.rdoB.UseVisualStyleBackColor = False
        '
        'rdoA
        '
        Me.rdoA.AutoSize = True
        Me.rdoA.BackColor = System.Drawing.Color.Transparent
        Me.rdoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoA.ForeColor = System.Drawing.Color.Aqua
        Me.rdoA.Location = New System.Drawing.Point(149, 27)
        Me.rdoA.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoA.Name = "rdoA"
        Me.rdoA.Size = New System.Drawing.Size(131, 24)
        Me.rdoA.TabIndex = 0
        Me.rdoA.TabStop = True
        Me.rdoA.Text = "RadioButton1"
        Me.rdoA.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.txtqstn)
        Me.GroupBox2.Controls.Add(Me.lblqstn)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 400)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(2025, 204)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Question"
        '
        'txtqstn
        '
        Me.txtqstn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqstn.Location = New System.Drawing.Point(96, 29)
        Me.txtqstn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtqstn.Multiline = True
        Me.txtqstn.Name = "txtqstn"
        Me.txtqstn.ReadOnly = True
        Me.txtqstn.Size = New System.Drawing.Size(1780, 146)
        Me.txtqstn.TabIndex = 2
        '
        'lblqstn
        '
        Me.lblqstn.AutoSize = True
        Me.lblqstn.Font = New System.Drawing.Font("Century", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqstn.ForeColor = System.Drawing.Color.Black
        Me.lblqstn.Location = New System.Drawing.Point(41, 28)
        Me.lblqstn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblqstn.Name = "lblqstn"
        Me.lblqstn.Size = New System.Drawing.Size(22, 23)
        Me.lblqstn.TabIndex = 1
        Me.lblqstn.Text = "1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(8, 28)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 23)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Q-"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkOrchid
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lblexamno)
        Me.GroupBox1.Controls.Add(Me.lblsem)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblSubject)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblcourse)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblRegNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(5, 185)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(2030, 195)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Info"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1608, 112)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 36)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Exam No.:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1608, 31)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 36)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Semester:"
        '
        'lblexamno
        '
        Me.lblexamno.AutoSize = True
        Me.lblexamno.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexamno.ForeColor = System.Drawing.Color.Yellow
        Me.lblexamno.Location = New System.Drawing.Point(1788, 110)
        Me.lblexamno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblexamno.Name = "lblexamno"
        Me.lblexamno.Size = New System.Drawing.Size(125, 36)
        Me.lblexamno.TabIndex = 4
        Me.lblexamno.Text = "examno"
        '
        'lblsem
        '
        Me.lblsem.AutoSize = True
        Me.lblsem.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsem.ForeColor = System.Drawing.Color.Yellow
        Me.lblsem.Location = New System.Drawing.Point(1786, 30)
        Me.lblsem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsem.Name = "lblsem"
        Me.lblsem.Size = New System.Drawing.Size(72, 36)
        Me.lblsem.TabIndex = 5
        Me.lblsem.Text = "sem"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(747, 109)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 36)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Subject:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(747, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 36)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Course:"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.ForeColor = System.Drawing.Color.Yellow
        Me.lblSubject.Location = New System.Drawing.Point(891, 109)
        Me.lblSubject.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(122, 36)
        Me.lblSubject.TabIndex = 1
        Me.lblSubject.Text = "Subject"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 36)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Student Name:"
        '
        'lblcourse
        '
        Me.lblcourse.AutoSize = True
        Me.lblcourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourse.ForeColor = System.Drawing.Color.Yellow
        Me.lblcourse.Location = New System.Drawing.Point(888, 27)
        Me.lblcourse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcourse.Name = "lblcourse"
        Me.lblcourse.Size = New System.Drawing.Size(111, 36)
        Me.lblcourse.TabIndex = 1
        Me.lblcourse.Text = "course"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 36)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Student RegNo:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Yellow
        Me.lblName.Location = New System.Drawing.Point(271, 111)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(96, 36)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'lblRegNo
        '
        Me.lblRegNo.AutoSize = True
        Me.lblRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegNo.ForeColor = System.Drawing.Color.Yellow
        Me.lblRegNo.Location = New System.Drawing.Point(268, 30)
        Me.lblRegNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(109, 36)
        Me.lblRegNo.TabIndex = 1
        Me.lblRegNo.Text = "Regno"
        '
        'lblAns
        '
        Me.lblAns.AutoSize = True
        Me.lblAns.Font = New System.Drawing.Font("Century Schoolbook", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAns.ForeColor = System.Drawing.Color.Black
        Me.lblAns.Location = New System.Drawing.Point(1710, 779)
        Me.lblAns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(106, 30)
        Me.lblAns.TabIndex = 12
        Me.lblAns.Text = "Answer"
        Me.lblAns.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1940, 104)
        Me.Panel1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(581, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(528, 56)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Examination System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(175, -15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 35)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Start Exam"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'lblTime2
        '
        Me.lblTime2.AutoSize = True
        Me.lblTime2.Font = New System.Drawing.Font("Century Schoolbook", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime2.ForeColor = System.Drawing.Color.Red
        Me.lblTime2.Location = New System.Drawing.Point(153, 127)
        Me.lblTime2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(69, 30)
        Me.lblTime2.TabIndex = 22
        Me.lblTime2.Text = "time"
        '
        'ExamTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1940, 1100)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTime2)
        Me.Controls.Add(Me.lblTime1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ExamTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTime1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rdoD As RadioButton
    Friend WithEvents rdoC As RadioButton
    Friend WithEvents rdoB As RadioButton
    Friend WithEvents rdoA As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtqstn As TextBox
    Friend WithEvents lblqstn As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblcourse As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblRegNo As Label
    Friend WithEvents lblAns As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblexamno As Label
    Friend WithEvents lblsem As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblTime2 As Label
End Class
