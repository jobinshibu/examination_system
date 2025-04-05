Imports System.Data.SqlClient
Imports System.Data
Public Class answers
    Private Sub answers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindCourse()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadDatainGrd()
    End Sub

    Public Sub LoadDatainGrd()
        DataGridView1.Rows.Clear()
        con.Close()
        cmd = New SqlCommand("Select * from tbl_studentanswers with (nolock) where RegNo = '" & txtRegno.Text & "' and course = '" & cmbCourse.Text & "' and subject = '" & cmbSubject.Text & "' and exam_no = '" & cmbExamno.Text & "'", con)
        con.Open()
        dr = cmd.ExecuteReader
        Dim i As Integer = 0

        While dr.Read
            i += 1
            DataGridView1.Rows.Add(dr.Item("RegNo").ToString, dr.Item("Course").ToString, dr.Item("Subject").ToString, dr.Item("Exam_no").ToString, dr.Item("q_no").ToString, dr.Item("answer").ToString, dr.Item("crc_ans").ToString)

        End While
        dr.Close()
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

    Private Sub BindSubject()  '-------show all Subject in ComboBox
        cmbSubject.Items.Clear()
        ds.Clear()
        If con.State = 1 Then con.Close()
        qry = "Select distinct (subject) from tbl_course with (nolock) where course = '" & cmbCourse.Text & "' "
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
        qry = "Select distinct (Exam_no) from tbl_course with (nolock) where course = '" & cmbCourse.Text & "' And subject = '" & cmbSubject.Text & "'"
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
        BindSubject()

    End Sub

    Private Sub cmbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubject.SelectedIndexChanged
        BindExamno()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(imagebmp, 0, 0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colName = "Column8" Then
            If (MsgBox("Are you sure want to delete record?", vbYesNo + vbQuestion) = vbYes) Then
                qry = "Delete from tbl_studentanswers where RegNo = '" & txtRegno.Text & "' and course = '" & cmbCourse.Text & "' and subject = '" & cmbSubject.Text & "' and exam_no = '" & cmbExamno.Text & "'"
                i = InsertData(qry)
                If (i > 0) Then
                    MsgBox("Data Deleted successful", MsgBoxStyle.Information)
                    LoadDatainGrd()

                Else
                    MsgBox("Data Not Deleted", MsgBoxStyle.Exclamation)
                End If

            End If
        End If
    End Sub

End Class