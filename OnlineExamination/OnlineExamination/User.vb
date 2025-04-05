Imports System.Data.SqlClient

Public Class User
    'Dim roll As String
    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ShowProfile()

    End Sub
    Public Sub ShowProfile()
        qry = " select * from login with (nolock) where RegNo='" & roll1 & "' "
        Try
            If con.State = 1 Then con.Close()
            cmd = New SqlCommand(qry, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                lblRoll.Text = dr1.Item("RegNo").ToString
                lblName.Text = dr1.Item("Name").ToString
                name1 = lblName.Text
                lblGaurdian.Text = dr1.Item("Gaurdian").ToString
                lblNumber.Text = dr1.Item("Number").ToString
                lblEmail.Text = dr1.Item("Email").ToString
                lblGender.Text = dr1.Item("Gender").ToString
                lblCourse.Text = dr1.Item("Course").ToString
                lblSem.Text = dr1.Item("Semester").ToString
                lblAddress.Text = dr1.Item("Address").ToString
            Else
                MsgBox("Record not found try again")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Course1 = lblCourse.Text
        Semester = lblSem.Text
        Me.Hide()


        ChooseExam.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Course1 = lblCourse.Text
        userPhn = lblNumber.Text

        Updatepwd.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UserResult.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

        Form1.Show()
    End Sub
End Class