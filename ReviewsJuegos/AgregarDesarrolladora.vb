Imports System.Data.SqlClient

Public Class AgregarDesarrolladora
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Crear parámetros para el procedimiento almacenado
        Dim IdUsuario As Integer = 1
        Dim parametros(1) As SqlParameter
        parametros(0) = New SqlParameter("@Desarrolladora", TxtAgDesarrolladora.Text)
        parametros(1) = New SqlParameter("@IdUsuarioCrea ", IdUsuario)




        ' Ejecutar el procedimiento almacenado
        ConexionSQL.ExecuteStoredProcedure("SP_AgregarDesarrolladora", parametros)
        MsgBox("Registro exitoso")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TxtAgDesarrolladora_TextChanged(sender As Object, e As EventArgs) Handles TxtAgDesarrolladora.TextChanged

    End Sub
End Class