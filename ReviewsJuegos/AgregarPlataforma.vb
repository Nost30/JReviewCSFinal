Imports System.Data.SqlClient

Public Class AgregarPlataforma
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Crear parámetros para el procedimiento almacenado
        Dim IdUsuario As Integer = 1
        Dim parametros(1) As SqlParameter
        parametros(0) = New SqlParameter("@NombrePlataforma", TxtAgPlata.Text)
        parametros(1) = New SqlParameter("@IdUsuarioCrea ", IdUsuario)




        ' Ejecutar el procedimiento almacenado
        ConexionSQL.ExecuteStoredProcedure("SP_AgregarPlataforma", parametros)
        MsgBox("Registro exitoso")
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()

    End Sub
End Class