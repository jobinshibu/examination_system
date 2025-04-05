<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Course
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSem = New System.Windows.Forms.ComboBox()
        Me.txtExamno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVCourse = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtSl_no = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DGVCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(293, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COURSE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(293, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SUBJECT"
        '
        'txtSub
        '
        Me.txtSub.Location = New System.Drawing.Point(428, 148)
        Me.txtSub.Multiline = True
        Me.txtSub.Name = "txtSub"
        Me.txtSub.Size = New System.Drawing.Size(312, 33)
        Me.txtSub.TabIndex = 2
        '
        'cmbCourse
        '
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(428, 100)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(312, 24)
        Me.cmbCourse.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(249, 323)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(168, 45)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(293, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SEMESTER"
        '
        'cmbSem
        '
        Me.cmbSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSem.FormattingEnabled = True
        Me.cmbSem.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbSem.Location = New System.Drawing.Point(429, 209)
        Me.cmbSem.Name = "cmbSem"
        Me.cmbSem.Size = New System.Drawing.Size(312, 24)
        Me.cmbSem.TabIndex = 6
        '
        'txtExamno
        '
        Me.txtExamno.Location = New System.Drawing.Point(428, 261)
        Me.txtExamno.Multiline = True
        Me.txtExamno.Name = "txtExamno"
        Me.txtExamno.Size = New System.Drawing.Size(312, 33)
        Me.txtExamno.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(293, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "EXAM.NO"
        '
        'DGVCourse
        '
        Me.DGVCourse.AllowUserToAddRows = False
        Me.DGVCourse.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DGVCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCourse.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DGVCourse.Location = New System.Drawing.Point(208, 383)
        Me.DGVCourse.Name = "DGVCourse"
        Me.DGVCourse.RowHeadersWidth = 51
        Me.DGVCourse.RowTemplate.Height = 24
        Me.DGVCourse.Size = New System.Drawing.Size(628, 390)
        Me.DGVCourse.TabIndex = 9
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdate.Location = New System.Drawing.Point(433, 323)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(168, 45)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Location = New System.Drawing.Point(607, 323)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(168, 45)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtSl_no
        '
        Me.txtSl_no.Location = New System.Drawing.Point(428, 38)
        Me.txtSl_no.Multiline = True
        Me.txtSl_no.Name = "txtSl_no"
        Me.txtSl_no.ReadOnly = True
        Me.txtSl_no.Size = New System.Drawing.Size(312, 33)
        Me.txtSl_no.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(293, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "SL.NO"
        '
        'Course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 825)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSl_no)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DGVCourse)
        Me.Controls.Add(Me.txtExamno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbSem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbCourse)
        Me.Controls.Add(Me.txtSub)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Course"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGVCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSub As TextBox
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSem As ComboBox
    Friend WithEvents txtExamno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGVCourse As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSl_no As TextBox
    Friend WithEvents Label5 As Label
End Class
