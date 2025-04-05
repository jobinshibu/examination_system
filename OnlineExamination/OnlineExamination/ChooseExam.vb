Imports System.Data.SqlClient

Public Class ChooseExam

    Private Sub ChooseExam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = 1 Then con.Close()
        cmbSubject.Enabled = True
        txtCourse.Text = Course1
        txtSem.Text = Semester
        BindSubject()
    End Sub
    Private Sub BindSubject()  '-------show all Subject in ComboBox
        cmbSubject.Items.Clear()
        ds.Clear()
        If con.State = 1 Then con.Close()
        qry = "Select distinct (subject) from tbl_course with (nolock) where course = '" & txtCourse.Text & "' And semester = '" & txtSem.Text & "' "
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
        qry = "Select distinct (Exam_no) from tbl_course with (nolock) where course = '" & txtCourse.Text & "' And semester = '" & txtSem.Text & "' And subject = '" & cmbSubject.Text & "'"
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

    Private Sub cmbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubject.SelectedIndexChanged
        BindExamno()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        con.Open()
        subject = cmbSubject.Text
        ExamNo = cmbExamno.Text
        If txtCourse.Text = "" Or txtSem.Text = "" Or cmbSubject.Text = "" Or cmbExamno.Text = "" Then
            MsgBox("Please enter the fields")

        Else
            Dim theQuery As String = "select * from tbl_studentanswers where RegNo = '" & roll1 & "' And course = @Course1 And subject = '" & cmbSubject.Text & "' And Exam_no = '" & cmbExamno.Text & "'"
            Dim cmd1 As SqlCommand = New SqlCommand(theQuery, con)
            cmd1.Parameters.AddWithValue("@Course1", txtCourse.Text)

            Dim reader As SqlDataReader = cmd1.ExecuteReader()

            If reader.HasRows Then
                MsgBox("You are no longer eligible to attend exam", MsgBoxStyle.Exclamation, "Already Submitted!")
                Me.Close()
                User.Show()
            Else
                'show start exam from
                Me.Close()
                ExamTest.Show()

            End If
        End If

        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        User.Show()

    End Sub
End Class