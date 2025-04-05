Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Registration

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bindgv()
        BindCourse()
        txtRegNo.Focus()


    End Sub

    Private Sub BindCourse()  '-------show all courses in ComboBox
        cmbCourse.Items.Clear()
        ds.Clear()
        If con.State = 1 Then con.Close()
        qry = "Select distinct (course) from tbl_course with (nolock)"
        ds = FetchData(qry)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim tblrow As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To tblrow
                cmbCourse.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
            Next
        Else
            MsgBox("Course not found...")
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=Joby;Initial Catalog=OnlineExam;Integrated Security=True"
        con.Open()
        If txtNum.TextLength <> 10 Then
            MsgBox("Enter Valid Mobile Number!")
            txtNum.Text = ""
            txtNum.Focus()
            Exit Sub
        End If

        If txtRegNo.TextLength <> 7 Then
            MsgBox("Register Number Is Not Valid!")
            txtRegNo.Text = ""
            txtRegNo.Focus()
            Exit Sub
        End If

        If txtPass.TextLength < 5 Then
            MsgBox("Password atleast contain 5 characters!")
            txtPass.Text = ""
            txtPass.Focus()
            Exit Sub
        End If

        Dim emailaddress = txtEmail.Text
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then

        Else

            MsgBox("Invalid Email address", MsgBoxStyle.Information)
            Exit Sub
        End If

        If (txtRegNo.Text = "" Or txtName.Text = "" Or txtNum.Text = "" Or txtGaurd.Text = "" Or txtEmail.Text = "" Or cmbGender.Text = "" Or cmbUserType.Text = "" Or cmbCourse.Text = "" Or cmbSem.Text = "" Or txtPass.Text = "" Or txtAddress.Text = "") Then
            MessageBox.Show("Please Enter The Details")
        Else
            Dim theQuery As String = "select * from login where RegNo = @roll1"
            Dim cmd1 As SqlCommand = New SqlCommand(theQuery, con)
            cmd1.Parameters.AddWithValue("@roll1", txtRegNo.Text)

            Dim reader As SqlDataReader = cmd1.ExecuteReader()

            If reader.HasRows Then
                MsgBox("User Already Exist", MsgBoxStyle.Exclamation, "Add New User!")
            Else
                qry = "INSERT INTO login VALUES('" & txtRegNo.Text & "', '" & txtName.Text & "', '" & txtPass.Text & "', '" & cmbUserType.Text & "', '" & txtGaurd.Text & "','" & txtNum.Text & "', '" & txtEmail.Text & "', '" & cmbGender.Text & "', '" & cmbCourse.Text & "', '" & cmbSem.Text & "', '" & txtAddress.Text & "')"
                i = InsertData(qry)
                If (i > 0) Then
                    MsgBox("User Details Inserted Successfully", MsgBoxStyle.Information, "success")
                    txtRegNo.Clear()
                    txtName.Clear()
                    txtNum.Clear()
                    txtGaurd.Clear()
                    txtEmail.Clear()
                    txtPass.Clear()
                    txtAddress.Clear()
                    bindgv()
                    txtRegNo.Focus()
                End If
            End If
        End If

        con.Close()
        bindgv()
    End Sub

    Public Sub bindgv()
        con = New SqlConnection("Data Source=Joby;Initial Catalog=OnlineExam;Integrated Security=True")
        con.Open()
        Dim query = "select * from login"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        con.Close()

    End Sub

    Private Sub txtRegNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRegNo.KeyPress
        Dim allowednos As String = "1234567890"
        If Not allowednos.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            MessageBox.Show("Please Enter Valid Character")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        Dim allowedchars As String = "abcdefghijklnmopqrstuvwxyz"
        If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            MessageBox.Show("Please Enter Valid Character")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum.KeyPress
        Dim allowednos As String = "1234567890"
        If Not allowednos.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            MessageBox.Show("Please Enter Valid Character")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtGaurd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGaurd.KeyPress
        Dim allowedchars As String = "abcdefghijklnmopqrstuvwxyz"
        If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            MessageBox.Show("Please Enter Valid Character")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim stmt As String


        con.ConnectionString = "Data Source=Joby;Initial Catalog=OnlineExam;Integrated Security=True"
        con.Open()

        If (txtSearch.Text = "") Then
            MessageBox.Show("Please Enter User Name")
        Else
            stmt = "SELECT * FROM login WHERE Name='" & txtSearch.Text & "' "
            cmd = New SqlCommand(stmt, con)
            dr = cmd.ExecuteReader

            If dr.Read Then

                txtSearch.Text = dr.GetValue(1)
                txtRegNo.Text = dr.GetValue(0)
                txtName.Text = dr.GetValue(1)
                txtNum.Text = dr.GetValue(5)
                txtGaurd.Text = dr.GetValue(4)
                cmbGender.Text = dr.GetValue(7)
                cmbCourse.Text = dr.GetValue(8)
                cmbSem.Text = dr.GetValue(9)
                txtEmail.Text = dr.GetValue(6)
                cmbUserType.Text = dr.GetValue(3)
                txtPass.Text = dr.GetValue(2)
                txtAddress.Text = dr.GetValue(10)
            Else
                MsgBox("No Record Found!")
            End If
        End If
        con.Close()
        txtRegNo.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim stmt As String

        con.ConnectionString = "Data Source=Joby;Initial Catalog=OnlineExam;Integrated Security=True"
        con.Open()
        If txtNum.TextLength <> 10 Then
            MsgBox("Enter Valid Mobile Number!")
            txtNum.Text = ""
            txtNum.Focus()
            Exit Sub
        End If

        Dim emailaddress = txtEmail.Text
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then

        Else

            MsgBox("Invalid Email address", MsgBoxStyle.Information)
            Exit Sub
        End If

        If (txtSearch.Text = "") Then
            MessageBox.Show("Please Enter User Name")
        Else

            If (txtRegNo.Text = "" Or txtName.Text = "" Or txtNum.Text = "" Or txtGaurd.Text = "" Or cmbGender.Text = "" Or cmbGender.Text = "" Or cmbCourse.Text = "" Or cmbSem.Text = "" Or txtEmail.Text = "" Or cmbUserType.Text = "" Or txtPass.Text = "" Or txtAddress.Text = "") Then
                MessageBox.Show("Please Enter All Fields")
            Else

                stmt = "UPDATE login SET RegNo = '" & txtRegNo.Text & "', Name = '" & txtName.Text & "' , Password = '" & txtPass.Text & "',UserType = '" & cmbUserType.Text & "',Gaurdian = '" & txtGaurd.Text & "',Number = '" & txtNum.Text & "',Email = '" & txtEmail.Text & "',Gender = '" & cmbGender.Text & "',Course = '" & cmbCourse.Text & "', Semester = '" & cmbSem.Text & "', Address = '" & txtAddress.Text & "' WHERE Name='" & txtName.Text & "'"
                cmd = New SqlCommand(stmt, con)
                cmd.ExecuteNonQuery()

                MsgBox("Record Updated Successfully", MsgBoxStyle.Information, "success")

                txtRegNo.Clear()
                txtName.Clear()
                txtNum.Clear()
                txtGaurd.Clear()
                txtEmail.Clear()
                txtPass.Clear()
                txtAddress.Clear()
                txtSearch.Clear()

            End If
        End If


        con.Close()
        bindgv()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim stmt As String

        con.ConnectionString = "Data Source=Joby;Initial Catalog=OnlineExam;Integrated Security=True"
        con.Open()

        If (txtSearch.Text = "") Then
            MessageBox.Show("Please Enter User Name To Delete Data")
        Else

            stmt = "DELETE FROM login WHERE Name = '" & txtSearch.Text & "'"
            cmd = New SqlCommand(stmt, con)
            cmd.ExecuteNonQuery()

            MsgBox("User Data Deleted Successfully", MsgBoxStyle.Information, "success")

            txtRegNo.Clear()
            txtName.Clear()
            txtNum.Clear()
            txtGaurd.Clear()
            txtEmail.Clear()
            txtPass.Clear()
            txtAddress.Clear()
            txtSearch.Clear()

        End If

        con.Close()
        bindgv()

    End Sub

End Class
