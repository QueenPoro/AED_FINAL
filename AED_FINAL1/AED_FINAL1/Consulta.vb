Imports System.Data.SqlClient

Public Class consulta
    Public conection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scarlethsotelo\source\repos\AED_FINAL1\AED_FINAL1\Database.mdf;Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        conection.Open()
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conection)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)

        conection.Close()
    End Sub

    Public Function Consulta_Relacionada(sql As String)
        Dim adaptador As SqlDataAdapter
        Dim tabladedatos As New DataTable
        Try
            adaptador = New SqlDataAdapter(sql, conection)
            adaptador.Fill(tabladedatos)
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        End Try

        Return tabladedatos
    End Function

End Class
