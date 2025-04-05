Imports System.Data
Imports System.Data.SqlClient

Public Class EditQuestion

    Private Sub EditQuestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadRecord()
    End Sub
    Public Sub LoadRecord()
        DataGridView1.Rows.Clear()
        con.Close()
        cmd = New SqlCommand("Select * from tbl_Question with(nolock)", con)
        con.Open()
        dr = cmd.ExecuteReader
        Dim i As Integer = 0

        While dr.Read
            i += 1
            DataGridView1.Rows.Add(dr.Item("q_id").ToString, dr.Item("q_no").ToString, dr.Item("course").ToString, dr.Item("sem").ToString, dr.Item("subject").ToString, dr.Item("exam_no").ToString, dr.Item("question").ToString, dr.Item("op_A").ToString, dr.Item("op_B").ToString, dr.Item("op_C").ToString, dr.Item("op_D").ToString, dr.Item("answer").ToString)

        End While
        dr.Close()
        con.Close()


    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "Column13" Then
            With UpdateQuestion

                _id = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString

                .txtQno.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .cmbCourse.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .cmbSem.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .cmbSubject.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .cmbExamno.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .txtQid.Text = _id
                .txtQuestion.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                .txtOptionA.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                .txtOptionB.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
                .txtOptionC.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
                .txtOptionD.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString
                .cmbAnswer.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString

                .ShowDialog()
            End With
        ElseIf colName = "Column14" Then
            If (MsgBox("Are you sure want to delete record?", vbYesNo + vbQuestion) = vbYes) Then
                qry = "Delete from tbl_Question where q_id=" & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString & ""
                i = InsertData(qry)
                If (i > 0) Then
                    MsgBox("Question Deleted successful", MsgBoxStyle.Information)
                    LoadRecord()


                Else
                    MsgBox("Question Not Deleted", MsgBoxStyle.Exclamation)
                End If

            End If
        End If

    End Sub
End Class