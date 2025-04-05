Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=Joby;Initial Catalog=OnlineExam;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("Select * from login where RegNo ='" & txtRegNo.Text & "' and Password = '" & txtPass.Text & "' and UserType='" & cmbUserType.SelectedItem & "' ", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        roll1 = txtRegNo.Text
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("You Are Logged In As " + dt.Rows(0)(3))
            If (cmbUserType.SelectedIndex = 0) Then
                Dim a As New Admin
                a.Show()
                Me.Hide()
            Else
                Dim u As New User
                u.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Incorrect Credential")
        End If
    End Sub

    Private Sub txtRegNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRegNo.KeyPress
        Dim allowednos As String = "1234567890"
        If Not allowednos.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            MessageBox.Show("Please Enter Valid Character")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub
End Class