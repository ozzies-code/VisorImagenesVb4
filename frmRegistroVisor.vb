Public Class frmRegistroVisor
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub frmRegistroVisor_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            Dim objArchivo As New System.IO.StreamReader(System.AppDomain.CurrentDomain.BaseDirectory() & "\RegImagenes.txt")
            txtRegistro.Text = objArchivo.ReadToEnd()
            objArchivo.Close()
            objArchivo.Dispose()

        Catch ex As Exception
            txtRegistro.Text = "No se pudo encontrar el archivo"
        End Try
    End Sub
End Class