Imports System.Data.SqlClient

Public Class ExamResult

    Private Sub ExamResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblRegno.Text = roll1
        lblCourse.Text = Course1
        lblSubject.Text = subject
        lblExamno.Text = ExamNo
        If con.State = 1 Then con.Close()

        qry = "select count(*)as aa from tbl_studentanswers where answer=crc_ans and RegNo='" & lblRegno.Text & "' and course ='" & lblCourse.Text & "' and subject ='" & lblSubject.Text & "' and exam_no = '" & lblExamno.Text & "'"
        cmd = New SqlCommand(qry, con)
        con.Open()
        dr = cmd.ExecuteReader()
        If dr.Read Then
            lblC.Text = dr.Item("aa").ToString
        End If
        'total question
        qry = "select count(*) as totq from tbl_studentanswers where course='" & lblCourse.Text & "' and subject='" & lblSubject.Text & "' and exam_no = '" & lblExamno.Text & "'"
        cmd = New SqlCommand(qry, con)
        If con.State = 1 Then con.Close()
        con.Open()
        dr = cmd.ExecuteReader()
        If dr.Read Then
            lblTotal.Text = dr.Item("totq").ToString
        End If

        lblPer.Text = (Val(lblC.Text) * 100) / Val(lblTotal.Text)

        If Val(lblPer.Text) < 33 Then
            lblStatus.Text = "Fail"
        ElseIf Val(lblPer.Text) < 50 Then
            lblStatus.Text = " Second Class "
        ElseIf Val(lblPer.Text) < 90 Then
            'btnNext.Enabled = False
            lblStatus.Text = " First Class "
        ElseIf Val(lblPer.Text) >= 90 Then
            lblStatus.Text = "Distinction "
        End If


        qry = " insert into tbl_result (RegNo,course,subject,exam_no,total_qstn,correct_qstn,perc,status) values('" & lblRegno.Text & "','" & lblCourse.Text & "','" & lblSubject.Text & "','" & lblExamno.Text & "','" & lblTotal.Text & "','" & lblC.Text & "','" & lblPer.Text & "','" & lblStatus.Text & "')"
        i = InsertData(qry)
        If i > 0 Then
            MsgBox("this your report card", MsgBoxStyle.Information)
        Else

        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        lblCourse.Text = ""
        lblC.Text = ""
        lblTotal.Text = ""
        lblStatus.Text = ""
        lblSubject.Text = ""
        lblExamno.Text = ""
        lblRegno.Text = ""
        lblPer.Text = ""
        User.Show()
        Me.Close()


    End Sub

End Class


