Imports System.Data
Imports System.Data.SqlClient

Public Class ExamTest
    Dim d, diff As TimeSpan
    Dim d2 As DateTime

    Private Sub ExamTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        d1 = Now.AddSeconds(30)
        btnSubmit.Enabled = False

        If con.State = 1 Then con.Close()
        qry = "select course from login where RegNo='" & roll1 & "'"

        Try

            cmd = New SqlCommand(qry, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                lblcourse.Text = dr1.Item("course").ToString
                Course1 = lblcourse.Text
            End If
            If con.State = 1 Then con.Close()
            qry = "select subject from tbl_course where course='" & lblcourse.Text & "'and subject='" & subject & "' and Exam_No = '" & ExamNo & "'"
            cmd = New SqlCommand(qry, con)
            con.Open()
            dr1 = cmd.ExecuteReader()
            If dr1.Read() Then
                lblSubject.Text = dr1.Item("subject").ToString
                subject = lblSubject.Text
            End If
            If con.State = 1 Then con.Close()
            qry = "select Semester from tbl_course where course='" & lblcourse.Text & "'and subject='" & subject & "' and Exam_No = '" & ExamNo & "'"
            cmd = New SqlCommand(qry, con)
            con.Open()
            dr1 = cmd.ExecuteReader()
            If dr1.Read() Then
                lblsem.Text = dr1.Item("semester").ToString
                Semester = lblsem.Text
            End If
            If con.State = 1 Then con.Close()
            qry = "select Exam_No from tbl_course where course='" & lblcourse.Text & "'and subject='" & subject & "' and Exam_No = '" & ExamNo & "'"
            cmd = New SqlCommand(qry, con)
            con.Open()
            dr1 = cmd.ExecuteReader()
            If dr1.Read() Then
                lblexamno.Text = dr1.Item("Exam_No").ToString
                ExamNo = lblexamno.Text
            End If
            If con.State = 1 Then con.Close()
            'Show Question 
            qry = "select q_no,question ,op_A ,op_B,op_C ,op_D ,answer  from tbl_Question with (nolock) where q_no = 1 and course='" & lblcourse.Text & "' and subject='" & lblSubject.Text & "' and exam_no = '" & lblexamno.Text & "'"

            cmd = New SqlCommand(qry, con)
            con.Open()
            dr1 = cmd.ExecuteReader()
            If dr1.Read() Then
                lblqstn.Text = dr1.Item("q_no").ToString
                txtqstn.Text = dr1.Item("question").ToString
                rdoA.Text = dr1.Item("op_A").ToString
                rdoB.Text = dr1.Item("op_B").ToString
                rdoC.Text = dr1.Item("op_C").ToString
                rdoD.Text = dr1.Item("op_D").ToString
                lblAns.Text = dr1.Item("answer").ToString
                qnum = lblqstn.Text
                lblName.Text = Module1.name1
                lblRegNo.Text = Module1.roll1

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If con.State = 1 Then con.Close()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If con.State = 1 Then con.Close()

        If (rdoA.Checked = False And rdoB.Checked = False And rdoC.Checked = False And rdoD.Checked = False) Then
            MsgBox("Plz Give the answer...select any option", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            qnum = qnum + 1
            qry = "select max(q_no)as q_no from tbl_Question with (nolock) where course='" & lblcourse.Text & "' and subject='" & subject & "' and Exam_No = '" & ExamNo & "'"
            cmd = New SqlCommand(qry, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read Then
                If qnum <= dr1.Item("q_no").ToString Then
                    lblqstn.Text = qnum
                Else
                    btnNext.Enabled = False
                    btnSubmit.Enabled = True
                    MsgBox("this is Last question", MsgBoxStyle.Exclamation)
                End If
            End If

        End If
        If con.State = 1 Then con.Close()
    End Sub

    Private Sub lblqstn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblqstn.TextChanged
        If lblqstn.Text <> "" Then
            qry = "select q_no,question,op_A,op_B,op_C,op_D,answer from tbl_Question where course='" & lblcourse.Text & "' and subject='" & lblSubject.Text & "' and Exam_No = '" & ExamNo & "' and q_no='" & lblqstn.Text & "'"
            If con.State = 1 Then con.Close()
            cmd = New SqlCommand(qry, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read Then
                txtqstn.Text = dr1.Item("question").ToString
                rdoA.Text = dr1.Item("op_A").ToString
                rdoB.Text = dr1.Item("op_B").ToString
                rdoC.Text = dr1.Item("op_C").ToString
                rdoD.Text = dr1.Item("op_D").ToString
                lblAns.Text = dr1.Item("answer").ToString

                qnum = lblqstn.Text
                rdoA.Checked = False
                rdoB.Checked = False
                rdoC.Checked = False
                rdoD.Checked = False

            End If
            qry = "select answer from tbl_studentanswers where RegNo ='" & roll1 & "'and course='" & lblcourse.Text & "'and subject='" & lblSubject.Text & "' and Exam_No = '" & ExamNo & "' and q_no='" & lblqstn.Text & "'"
            If con.State = 1 Then con.Close()
            cmd = New SqlCommand(qry, con)
            con.Open()
            dr1 = cmd.ExecuteReader()
            If dr1.Read Then
                If dr1.Item("answer").ToString = "A" Then
                    rdoA.Checked = True
                ElseIf dr1.Item("answer").ToString = "B" Then
                    rdoB.Checked = True
                ElseIf dr1.Item("answer").ToString = "C" Then
                    rdoC.Checked = True
                ElseIf dr1.Item("answer").ToString = "D" Then
                    rdoD.Checked = True

                End If
            End If

            If qnum <> 0 Then
                qry = "select max(q_no)as q_no from tbl_Question where course='" & lblcourse.Text & "' and subject='" & lblSubject.Text & "' and Exam_No = '" & ExamNo & "' "
                If con.State = 1 Then con.Close()
                cmd = New SqlCommand(qry, con)
                con.Open()
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then
                    If IsDBNull(Convert.ToInt32(dr1.Item("q_no").ToString)) = False Then
                        If qnum <= dr1.Item("q_no").ToString Then
                            btnNext.Enabled = True
                        Else
                            btnNext.Enabled = False
                            btnPrev.Enabled = True

                        End If

                    End If

                End If
                qry = "select min(q_no)as q_no from tbl_Question where course='" & lblcourse.Text & "' and subject='" & lblSubject.Text & "' and Exam_No = '" & ExamNo & "'"
                If con.State = 1 Then con.Close()
                cmd = New SqlCommand(qry, con)
                con.Open()
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then
                    If IsDBNull(Convert.ToInt32(dr1.Item("q_no").ToString)) = False Then
                        If qnum <= dr1.Item("q_no").ToString Then
                            btnPrev.Enabled = False
                        Else
                            btnPrev.Enabled = True


                        End If
                    End If


                End If





            End If
        End If
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        qnum = lblqstn.Text
        qnum = qnum - 1
        If qnum >= 1 Then
            lblqstn.Text = qnum
        Else
            btnPrev.Enabled = False

        End If
    End Sub

    Private Sub rdoA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoA.CheckedChanged
        If rdoA.Checked = True Then
            answer()
            'Delete duplicate
            qry = "delete from tbl_studentanswers where RegNo ='" & roll1 & "' and course='" & lblcourse.Text & "'and subject='" & lblSubject.Text & "'and exam_no = '" & lblexamno.Text & "' and q_no='" & lblqstn.Text & "'"
            InsertData(qry)

            'insert
            qry = "insert into tbl_studentanswers (RegNo,course,subject,exam_no,q_no,answer,crc_ans) values('" & roll1 & "','" & lblcourse.Text & "','" & lblSubject.Text & "','" & lblexamno.Text & "','" & lblqstn.Text & "','" & ans & "','" & lblAns.Text & "')"
            InsertData(qry)

        End If
    End Sub

    Public Sub answer()
        If rdoA.Checked = True Then
            ans = "A"
        ElseIf rdoB.Checked = True Then
            ans = "B"
        ElseIf rdoC.Checked = True Then
            ans = "C"
        ElseIf rdoD.Checked = True Then
            ans = "D"
        Else
            MsgBox("Please Answer to Question", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub rdoB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoB.CheckedChanged
        If rdoB.Checked = True Then
            answer()
            'Delete duplicate
            qry = "delete from tbl_studentanswers where RegNo ='" & roll1 & "' and course='" & lblcourse.Text & "'and subject='" & lblSubject.Text & "'and exam_no = '" & lblexamno.Text & "' and q_no='" & lblqstn.Text & "'"
            InsertData(qry)

            'insert
            qry = "insert into tbl_studentanswers (RegNo,course,subject,exam_no,q_no,answer,crc_ans) values('" & roll1 & "','" & lblcourse.Text & "','" & lblSubject.Text & "','" & lblexamno.Text & "','" & lblqstn.Text & "','" & ans & "','" & lblAns.Text & "')"
            InsertData(qry)

        End If
    End Sub

    Private Sub rdoC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoC.CheckedChanged
        If rdoC.Checked = True Then
            answer()
            'Delete duplicate
            qry = "delete from tbl_studentanswers where RegNo ='" & roll1 & "' and course='" & lblcourse.Text & "'and subject='" & lblSubject.Text & "'and exam_no = '" & lblexamno.Text & "' and q_no='" & lblqstn.Text & "'"
            InsertData(qry)

            'insert
            qry = "insert into tbl_studentanswers (RegNo,course,subject,exam_no,q_no,answer,crc_ans) values('" & roll1 & "','" & lblcourse.Text & "','" & lblSubject.Text & "','" & lblexamno.Text & "','" & lblqstn.Text & "','" & ans & "','" & lblAns.Text & "')"
            InsertData(qry)

        End If
    End Sub


    Private Sub rdoD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoD.CheckedChanged
        If rdoD.Checked = True Then
            answer()
            'Delete duplicate
            qry = "delete from tbl_studentanswers where RegNo ='" & roll1 & "' and course='" & lblcourse.Text & "'and subject='" & lblSubject.Text & "'and exam_no = '" & lblexamno.Text & "' and q_no='" & lblqstn.Text & "'"
            InsertData(qry)

            'insert
            qry = "insert into tbl_studentanswers (RegNo,course,subject,exam_no,q_no,answer,crc_ans) values('" & roll1 & "','" & lblcourse.Text & "','" & lblSubject.Text & "','" & lblexamno.Text & "','" & lblqstn.Text & "','" & ans & "','" & lblAns.Text & "')"
            InsertData(qry)

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        lblTime1.Text = String.Format("{0:T}", System.DateTime.Now)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        d2 = Now

        If d2 > d1 Then
            ExamResult.Show()
            Me.Close()

            Timer2.Enabled = False
            Timer2.Stop()
        End If
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Me.Dispose()

        ExamResult.Show()

    End Sub
End Class