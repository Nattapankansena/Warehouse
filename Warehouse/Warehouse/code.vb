Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes



Module code
    'ฐานข้อมูล
    Friend cn As New SqlConnection("Data Source=NTP; Initial Catalog=Warehouse; Integrated Security=SSPI;")
    'CMD SqlCommand
    Friend cmd As New SqlCommand
    'Da sqldataadapter
    Friend DA As New SqlDataAdapter
    'SQL = คำสั่ง
    Friend Sql As String

    'SQL DATA SET
    Friend DS As DataSet


    'ฟังชั่นเปิดฐานข้อมูล
    Friend Sub connect_open()
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub



End Module
