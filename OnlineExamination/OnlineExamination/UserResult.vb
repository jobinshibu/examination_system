Imports System.Data.SqlClient
Imports System.Data
Public Class UserResult

    Private Sub UserResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDatainGrd()
    End Sub
    Public Sub LoadDatainGrd()
        If con.State = 1 Then con.Close()
        ds.Clear()

        DataGridView1.DataSource = Nothing
        qry = "Select * from tbl_result with (nolock) where RegNo = '" & roll1 & "' "
        ds = FetchData(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MessageBox.Show("Data not found....")
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub
End Class