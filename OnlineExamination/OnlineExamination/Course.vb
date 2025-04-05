Imports System.Data.SqlClient

Public Class Course

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If cmbCourse.Text = "" Or txtSub.Text = "" Or cmbSem.Text = "" Or txtExamno.Text = "" Then
            MsgBox("Please enter the fields")
        Else
            qry = "select * from tbl_course where sl_no = '" & txtSl_no.Text & "' and Course='" & cmbCourse.Text & "' and Subject='" & txtSub.Text & "' and Semester = '" & cmbSem.Text & "' and Exam_No = '" & txtExamno.Text & "'"
            cmd = New SqlCommand(qry, con)
            If con.State = 1 Then con.Close()
            con.Open()

            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("Course & subject already exist", MsgBoxStyle.Critical)
                cmbCourse.Text = ""
                txtSub.Clear()
                txtExamno.Clear()
            Else
                qry = "insert into tbl_course (sl_no,course,subject,semester,Exam_No) values('" & txtSl_no.Text & "','" & cmbCourse.Text & "','" & txtSub.Text & "','" & cmbSem.Text & "','" & txtExamno.Text & "')"
                If con.State = 1 Then con.Close()

                InsertData(qry)
                MsgBox("Records Added Successfully", MsgBoxStyle.Information)


                cmbCourse.Text = ""
                txtSub.Clear()
                txtExamno.Clear()
                BindCourse()
                SerialNo()
                con.Close()
                bindgv()

            End If
        End If
    End Sub

    Private Sub Course_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindCourse()
        bindgv()
        SerialNo()
        btnUpdate.Visible = False
        btnDelete.Visible = False

    End Sub

    Public Sub bindgv()
        con = New SqlConnection("Data Source=Joby;Initial Catalog=OnlineExam;Integrated Security=True")
        con.Open()
        Dim query = "select * from tbl_course"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVCourse.DataSource = ds.Tables(0)

        con.Close()

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

    Private Sub SerialNo()
        Dim Slno As String = ""
        If con.State = 1 Then con.Close()
        Try
            qry = " select top 1 MAX(sl_no) as SLNO from tbl_course "
            cmd = New SqlCommand(qry, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If (dr1.Read()) Then
                Slno = dr1.Item("SLNO").ToString
                txtSl_no.Text = Val(Slno) + 1  '------------------add 1 in previous value

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If con.State = 1 Then con.Close()
    End Sub

    Private Sub DGVCourse_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVCourse.CellMouseClick
        Dim row As DataGridViewRow = DGVCourse.Rows(e.RowIndex)
        txtsl_no.Text = row.Cells(0).Value.ToString
        cmbCourse.Text = row.Cells(1).Value.ToString
        txtSub.Text = row.Cells(2).Value.ToString
        cmbSem.Text = row.Cells(3).Value.ToString
        txtExamno.Text = row.Cells(4).Value.ToString



        btnUpdate.Visible = True
        btnDelete.Visible = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If cmbCourse.Text = "" Or txtSub.Text = "" Or cmbSem.Text = "" Or txtExamno.Text = "" Then
            MsgBox("Please enter the fields")
        Else
            qry = "UPDATE tbl_course SET sl_no = '" & txtSl_no.Text & "',course = '" & cmbCourse.Text & "', Subject = '" & txtSub.Text & "' , Semester = '" & cmbSem.Text & "',Exam_No = '" & txtExamno.Text & "' WHERE sl_no ='" & txtSl_no.Text & "'"
            i = InsertData(qry)

            MsgBox("Record Updated Successfully", MsgBoxStyle.Information, "success")


            cmbCourse.Text = ""
            txtSub.Clear()
            txtExamno.Clear()
            BindCourse()
            bindgv()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        qry = "DELETE FROM tbl_course WHERE sl_no = '" & txtSl_no.Text & "'"
        i = InsertData(qry)

        MsgBox("User Data Deleted Successfully", MsgBoxStyle.Information, "success")

        cmbCourse.Text = ""
        txtSub.Clear()
        txtExamno.Clear()
        BindCourse()
        bindgv()
    End Sub

    Private Sub txtSub_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSub.KeyPress
        Dim allowedchars As String = "abcdefghijklnmopqrstuvwxyz"
        If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            MessageBox.Show("Please Enter Valid Character")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub cmbCourse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCourse.KeyPress
        Dim allowedchars As String = "abcdefghijklnmopqrstuvwxyz"
        If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            MessageBox.Show("Please Enter Valid Character")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub
End Class