Imports System.Data.SqlClient
Public Class ConexionSQL
    Private Shared cnx As SqlConnection = New SqlConnection()
    Private Shared Sub Connect()
        Try
            cnx.ConnectionString = "Data Source=localhost; Initial Catalog=ReviewJuego;Integrated Security=True"
            Call cnx.Open()
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos: " & ex.Message)
        End Try
    End Sub
    Private Shared Sub Disconect()
        Try
            If cnx.State = ConnectionState.Open Then
                Call cnx.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al desconectar de la base de datos: " & ex.Message)
        End Try
    End Sub
    ' Create a method to excecute a Selection query
    Public Shared Function SelectQuery(query As String) As DataTable
        Dim dt = New DataTable()
        Try
            Call Connect()
            Dim cmd = New SqlCommand(query, cnx)
            Dim da = New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta: " & ex.Message)
        Finally
            Call Disconect()
        End Try
        Return dt
    End Function
    ' Método para ejecutar un procedimiento almacenado
    Public Shared Sub ExecuteStoredProcedure(procedureName As String, Optional parameters As SqlParameter() = Nothing)

        Try
            Connect()
            Dim cmd As New SqlCommand(procedureName, cnx)
            cmd.CommandType = CommandType.StoredProcedure
            If parameters IsNot Nothing Then
                cmd.Parameters.AddRange(parameters)
            End If
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al ejecutar el procedimiento almacenado: " & ex.Message)
        Finally
            Disconect()
        End Try
    End Sub
End Class
