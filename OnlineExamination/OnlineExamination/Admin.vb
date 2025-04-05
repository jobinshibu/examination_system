Public Class Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Results
            .TopLevel = False
            Panel4.Controls.Add(Results)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With Registration
            .TopLevel = False
            Panel4.Controls.Add(Registration)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Course
            .TopLevel = False
            Panel4.Controls.Add(Course)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With AddQuestion
            .TopLevel = False
            Panel4.Controls.Add(AddQuestion)
            .BringToFront()
            .Show()


        End With
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With answers
            .TopLevel = False
            Panel4.Controls.Add(answers)
            .BringToFront()
            .Show()


        End With
    End Sub
End Class