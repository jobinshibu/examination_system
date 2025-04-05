Imports System.Data
Imports System.Data.SqlClient
Public Class UpdateQuestion

    Private Sub UpdateQuestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindCourse()
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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
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

            qry = "Update tbl_Question set  q_no = '" & txtQno.Text & "', course='" & cmbCourse.Text & "',sem = '" & cmbSem.Text & "', subject='" & cmbSubject.Text & "',exam_no = '" & cmbExamno.Text & "', question='" & txtQuestion.Text & "',op_A='" & txtOptionA.Text & "',op_B='" & txtOptionB.Text & "',op_C='" & txtOptionC.Text & "',op_D='" & txtOptionD.Text & "',answer='" & cmbAnswer.Text & "' where q_id= " & _id & " "
            i = InsertData(qry)
            If (i > 0) Then

                MsgBox("Question Updated successful", MsgBoxStyle.Information)
                With EditQuestion
                    .LoadRecord()
                End With
                Me.Dispose()
            Else
                MsgBox("Question Not Added", MsgBoxStyle.Exclamation)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class