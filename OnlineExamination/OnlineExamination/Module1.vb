Imports System.Data
Imports System.Data.SqlClient

Module Module1

        Public cmd As New SqlCommand
        Public dr As SqlDataReader
        Public da As New SqlDataAdapter
        Public strUser As String = "JOBY"
    Public connectionstring As String = "Data Source=Joby;Initial Catalog=OnlineExam;Integrated Security=True"
    Public con As New SqlConnection(connectionstring)
        Public i As Integer = 0
        Public name1 As String = ""
        Public utype As String = ""
    Public userPass As String = ""
    Public userPhn As String = ""
    Public Str, gender As String
        Public ds As New DataSet
        Public qry As String = ""
        Public _id As String
    Public roll1 As String = ""
    Public stmt As String = ""
    Public rg As String = ""
    Public Course, Semester, ans As String
    Public subject As String = ""
    Public ExamNo As String = ""
    Public Course1 As String = ""
    Public p As Integer = 1
        Public qnum As Integer
        Public d1 As DateTime







        Public Function FetchData(ByVal qry As String) As DataSet
            da = New SqlDataAdapter(qry, con)
            ds = New DataSet
            da.Fill(ds)
            Return ds
        End Function

        ' create a function for insert/update/delete record

        Public Function InsertData(ByVal qry As String) As Integer
            If con.State = 1 Then con.Close()
            cmd = New SqlCommand(qry, con)
            con.Open()
            i = cmd.ExecuteNonQuery()
            If con.State = 1 Then con.Close()
            Return i

        End Function

    End Module
