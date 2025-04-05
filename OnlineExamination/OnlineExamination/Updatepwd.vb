Imports System.Data.SqlClient
Public Class Updatepwd

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If con.State = 1 Then con.Close()
        If txtPhn.TextLength < 8 Then
            MsgBox("Minimum 8 Characters Required!")
            txtPhn.Text = ""
            txtPhn.Focus()
            Exit Sub
        End If

        If txtPhn.Text = "" Then Exit Sub
        If txtCpwd.Text = "" Then Exit Sub
        If txtNpwd.Text = "" Then Exit Sub
        If txtNApwd.Text = "" Then Exit Sub

        If txtPhn.Text <> Module1.userPhn And Module1.userPass <> txtCpwd.Text Then

            MsgBox("Invalid Admin password,you do not have the permission")
            txtPhn.Text = ""
            txtCpwd.Text = ""
            txtNpwd.Text = ""
            txtNApwd.Text = ""
            txtPhn.Focus()

        Else
            qry = "select * from login where password ='" & txtCpwd.Text & "'"
            con.Open()
            cmd = New SqlCommand(qry, con)
            dr = cmd.ExecuteReader
            If dr.Read() Then
                If txtNpwd.Text <> txtNApwd.Text Then
                    MsgBox("Please confirm the passwrod ")
                    txtNpwd.Clear()
                    txtNApwd.Clear()
                    txtNpwd.Focus()

                Else
                    qry = "Update login set password='" & txtNpwd.Text & "'"
                    InsertData(qry)
                    MsgBox("Password changed successfuly ")
                    Me.Close()
                    clr()

                End If

            Else
                MsgBox("Invalid Entry,", MsgBoxStyle.Critical)
                txtCpwd.Clear()
                txtCpwd.Focus()

            End If

        End If
        con.Close()


    End Sub

    Public Sub clr()
        txtPhn.Text = ""
        txtNApwd.Text = ""
        txtCpwd.Text = ""
        txtNpwd.Text = ""
    End Sub
End Class