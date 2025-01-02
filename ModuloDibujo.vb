Module ModuloDibujo

    Public Sub AbrirImagen()

        Try
            'Subrutina: Procedimiento que no devuelve un valor

            'Mostrar en el cuadro de diálogo Abrir Archivo

            If FrmVisorEventos.ofdSeleccionarImagen.ShowDialog = DialogResult.OK Then
                'Cargar la imagen en el PictureBox o Cuadro de Imagen
                FrmVisorEventos.picTexto.Image = Image.FromFile(FrmVisorEventos.ofdSeleccionarImagen.FileName)
                'Mostrar el nombre del archivo como titulo del formulario
                FrmVisorEventos.sbrMiBarraEstado.Items(0).Text = FrmVisorEventos.ofdSeleccionarImagen.FileName
                ActualizarRegistro(FrmVisorEventos.ofdSeleccionarImagen.FileName)
            End If

        Catch objExcepcion As System.OutOfMemoryException

            MessageBox.Show("El archivo elegido no es una imagen.", "Archivo no valido", MessageBoxButtons.OK)
        End Try

    End Sub

    Public Sub ActualizarRegistro(strNombreArchivo As String)

        Dim objArchivo As New System.IO.StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory() & "\RegImagenes.txt", True)

        objArchivo.WriteLine(Today() & "" & strNombreArchivo)
        objArchivo.Close()
        objArchivo.Dispose()
    End Sub

    Public Sub DibujarBordes(ByRef objCuadroimagen As PictureBox)

        Dim objGraphics As Graphics
        objGraphics = objCuadroimagen.Parent.CreateGraphics
        objGraphics.Clear(System.Drawing.SystemColors.Control)

        objGraphics.DrawRectangle(System.Drawing.Pens.Blue, objCuadroimagen.Left - 1, objCuadroimagen.Top - 1, objCuadroimagen.Width + 1, objCuadroimagen.Height + 1)
        objGraphics.Dispose()
    End Sub

End Module
