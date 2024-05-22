Imports System.Data.SqlClient

Public Class AgregarGenero
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Crear parámetros para el procedimiento almacenado
        Dim IdUsuario As Integer = 1
        Dim parametros(1) As SqlParameter
        parametros(0) = New SqlParameter("@Genero", TxtAgGenero.Text)
        parametros(1) = New SqlParameter("@IdUsuarioCrea ", IdUsuario)




        ' Ejecutar el procedimiento almacenado
        ConexionSQL.ExecuteStoredProcedure("SP_AgregarGenero", parametros)
        MsgBox("Registro exitoso")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TxtAgGenero_TextChanged(sender As Object, e As EventArgs) Handles TxtAgGenero.TextChanged

    End Sub
End Class