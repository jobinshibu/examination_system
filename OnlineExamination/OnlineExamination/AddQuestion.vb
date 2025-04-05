Imports System.Data.SqlClient

Public Class AddQuestion

    Private Sub AddQuestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindCourse()
        QuestionNo()
        btnNext.Visible = True
        btnAdd.Enabled = True
        'lblQueID.Visible = False


    End Sub

    Private Sub QuestionNo()
        Dim Qno As String = ""
        If con.State = 1 Then con.Close()
        Try
            qry = " select top 1 MAX(q_id) as QID from tbl_Question "
            cmd = New SqlCommand(qry, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If (dr1.Read()) Then
                Qno = dr1.Item("QID").ToString
                txtQid.Text = Val(Qno) + 1  '------------------add 1 in previous value

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If con.State = 1 Then con.Close()
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

    Private Sub BindSemester()  '-------show all Semester in ComboBox
        cmbSem.Items.Clear()
        ds.Clear()
        If con.State = 1 Then con.Close()
        qry = "Select distinct (semester) from tbl_course with (nolock) where course ='" & cmbCourse.Text & "'"
        ds = FetchData(qry)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim tblrow As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To tblrow
                cmbSem.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
            Next
        Else
            MsgBox("Semester not found...")
        End If
    End Sub

    Private Sub BindSubject()  '-------show all Subject in ComboBox
        cmbSubject.Items.Clear()
        ds.Clear()
        If con.State = 1 Then con.Close()
        qry = "Select distinct (subject) from tbl_course with (nolock) where course = '" & cmbCourse.Text & "' And semester = '" & cmbSem.Text & "' "
        ds = FetchData(qry)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim tblrow As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To tblrow
                cmbSubject.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
            Next
        Else
            MsgBox("Subject not found...")
        End If
    End Sub

    Private Sub BindExamno()  '-------show all Subject in ComboBox
        cmbExamno.Items.Clear()
        ds.Clear()
        If con.State = 1 Then con.Close()
        qry = "Select distinct (Exam_no) from tbl_course with (nolock) where course = '" & cmbCourse.Text & "' And semester = '" & cmbSem.Text & "' And subject = '" & cmbSubject.Text & "'"
        ds = FetchData(qry)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim tblrow As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To tblrow
                cmbExamno.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
            Next
        Else
            MsgBox("Exam Number not found...")
        End If
    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        BindSemester()

    End Sub

    Private Sub cmbSem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSem.SelectedIndexChanged
        BindSubject()
    End Sub

    Private Sub cmbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubject.SelectedIndexChanged
        BindExamno()
        txtQno.Clear()
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'validation code
        If txtQid.Text.Trim() = "" Then
            txtQid.Focus() : Exit Sub
        ElseIf txtQuestion.Text.Trim() = "" Then
            txtQuestion.Focus() : Exit Sub

        ElseIf txtOptionA.Text.Trim() = "" Then
            txtOptionA.Focus() : Exit Sub
        ElseIf txtOptionB.Text.Trim() = "" Then
            txtOptionB.Focus() : Exit Sub
        ElseIf txtOptionC.Text.Trim() = "" Then
            txtOptionC.Focus() : Exit Sub
        ElseIf txtOptionD.Text.Trim() = "" Then
            txtOptionD.Focus() : Exit Sub
        ElseIf cmbAnswer.Text.Trim() = "" Then
            cmbAnswer.Focus() : Exit Sub

        ElseIf cmbCourse.Text.Trim() = "" Then
            cmbCourse.Focus() : Exit Sub
        ElseIf cmbSubject.Text.Trim() = "" Then
            cmbSubject.Focus() : Exit Sub
        ElseIf cmbSem.Text.Trim() = "" Then
            cmbSem.Focus() : Exit Sub
        ElseIf cmbExamno.Text.Trim() = "" Then
            cmbExamno.Focus() : Exit Sub
        ElseIf txtQno.Text.Trim() = "" Then
            txtQno.Focus() : Exit Sub
        End If

        Try
            qry = "Insert into tbl_Question (q_id,q_no,course,sem,subject,exam_no,question,op_A,op_B,op_C,op_D,answer) values('" & txtQid.Text & "','" & txtQno.Text & "','" & cmbCourse.Text & "','" & cmbSem.Text & "','" & cmbSubject.Text & "','" & cmbExamno.Text & "','" & txtQuestion.Text & "','" & txtOptionA.Text & "','" & txtOptionB.Text & "','" & txtOptionC.Text & "','" & txtOptionD.Text & "','" & cmbAnswer.Text & "')"
            i = InsertData(qry)
            If (i > 0) Then
                MsgBox("Question Added successful", MsgBoxStyle.Information)
                btnAdd.Enabled = False
                btnNext.Enabled = True
                btnNext.Visible = True


            Else
                MsgBox("Question Not Added", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'Clear some controls values
        btnAdd.Enabled = True

        txtQid.Clear()
        txtQno.Clear()
        txtQuestion.Clear()
        txtQuestion.Focus()
        txtOptionA.Clear()
        txtOptionB.Clear()
        txtOptionC.Clear()
        txtOptionD.Clear()
        cmbAnswer.Text = ""
        QuestionNo()
        btnNext.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With EditQuestion
            .Show()
        End With
    End Sub
End Class
