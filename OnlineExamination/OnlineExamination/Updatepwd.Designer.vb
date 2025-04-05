<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Updatepwd
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
        Me.txtPhn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNpwd = New System.Windows.Forms.TextBox()
        Me.txtNApwd = New System.Windows.Forms.TextBox()
        Me.txtCpwd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPhn
        '
        Me.txtPhn.Location = New System.Drawing.Point(348, 78)
        Me.txtPhn.Multiline = True
        Me.txtPhn.Name = "txtPhn"
        Me.txtPhn.Size = New System.Drawing.Size(312, 33)
        Me.txtPhn.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(177, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "PHONE NO."
        '
        'txtNpwd
        '
        Me.txtNpwd.Location = New System.Drawing.Point(348, 215)
        Me.txtNpwd.Multiline = True
        Me.txtNpwd.Name = "txtNpwd"
        Me.txtNpwd.Size = New System.Drawing.Size(312, 33)
        Me.txtNpwd.TabIndex = 12
        '
        'txtNApwd
        '
        Me.txtNApwd.Location = New System.Drawing.Point(348, 287)
        Me.txtNApwd.Multiline = True
        Me.txtNApwd.Name = "txtNApwd"
        Me.txtNApwd.Size = New System.Drawing.Size(312, 33)
        Me.txtNApwd.TabIndex = 14
        '
        'txtCpwd
        '
        Me.txtCpwd.Location = New System.Drawing.Point(348, 148)
        Me.txtCpwd.Multiline = True
        Me.txtCpwd.Name = "txtCpwd"
        Me.txtCpwd.Size = New System.Drawing.Size(312, 33)
        Me.txtCpwd.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(124, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Current Password"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(270, 352)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(163, 50)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(154, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(28, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Enter New Password Again:"
        '
        'Updatepwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtCpwd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNApwd)
        Me.Controls.Add(Me.txtNpwd)
        Me.Controls.Add(Me.txtPhn)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Updatepwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPhn As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNpwd As TextBox
    Friend WithEvents txtNApwd As TextBox
    Friend WithEvents txtCpwd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
