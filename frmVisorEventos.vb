Public Class FrmVisorEventos

    Const c_predConfirmarSalida As Boolean = False
    Private m_strNombreUsuario As String
    Private m_blnConfirmarSalida As Boolean
    Private m_objColorFondoImagen As Color

    Private Sub picTexto_MouseMove(sender As Object, e As MouseEventArgs) Handles picTexto.MouseMove
        lblX.Text = "X: " & e.X
        lblY.Text = "Y: " & e.Y

        'Con el evento MouseMove se puede obtener la posición del mouse en el control PictureBox
        'y mostrarla en los controles Label lblX y lblY como coordenadas del objeto "e" asociado al evento MouseMove
    End Sub


    Private Sub picTexto_MouseLeave(sender As Object, e As EventArgs) Handles picTexto.MouseLeave
        'Con el evento Load se puede limpiar los controles Label lblX y lbl al cargarse el formulario en memoria
        lblX.Text = ""
        lblY.Text = ""

        'Con el evento MouseLeave se puede limpiar los controles Label lblX y lbl al detener el movimiento del raton
    End Sub

    Private Sub FrmVisorEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblX.Text = ""
        lblY.Text = ""

        CargarPrederminados()

    End Sub

    Public Sub CargarPrederminados()

        Const c_strNombreClave As String = "HKEY_CURRENT_USER\Software\SoftwareXYZ\VisorImagenes\"

        'Inicializa las variables de opciones.

        'm_blnConfirmarSalida = c_predConfirmarSalida
        m_blnConfirmarSalida = CBool(My.Computer.Registry.GetValue(c_strNombreClave, "ConfirmarSalida", "0"))

        'm_objColorFondoImagen = System.Drawing.SystemColors.Control
        If CStr(My.Computer.Registry.GetValue(c_strNombreClave, "ColorDeFondo", "Gris")) = "Gris" Then
            m_objColorFondoImagen = System.Drawing.SystemColors.Control
        Else
            m_objColorFondoImagen = System.Drawing.Color.White
        End If

        'Configura el color de fondo del cuadro de imagen

        picTexto.BackColor = m_objColorFondoImagen

        'Configura el valor de la confirmacion de salida
        mnuuConfirmarSalida.Checked = m_blnConfirmarSalida

    End Sub


    Private Sub mnuAbrirImagen_Click(sender As Object, e As EventArgs) Handles mnuAbrirImagen.Click
        ''Mostrar en el cuadro de diálogo Abrir Archivo
        'If ofdSeleccionarImagen.ShowDialog = DialogResult.OK Then
        '    'Cargar la imagen en el PictureBox
        '    picTexto.Image = Image.FromFile(ofdSeleccionarImagen.FileName)
        '    'Mostrar el nombre del archivo como titulo del formulario
        '    Me.Text = "Visor de Imagenes(" & ofdSeleccionarImagen.FileName & ")"
        'End If
        'Codigo sustituido por el modulodibujovb

        AbrirImagen() 'Se llama a la funcion del ModuloDibujo.vb
    End Sub

    Private Sub mnuuConfirmarSalida_Click(sender As Object, e As EventArgs) Handles mnuuConfirmarSalida.Click
        mnuConfirmarSalida.Checked = Not mnuConfirmarSalida.Checked
        m_blnConfirmarSalida = mnuuConfirmarSalida.Checked
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub mnuDibujarBordes_Click(sender As Object, e As EventArgs) Handles mnuDibujarBordes.Click
        'Dim objGraphics As Graphics
        'objGraphics = Me.CreateGraphics()
        'objGraphics.DrawRectangle(Pens.Blue, picTexto.Left - 1, picTexto.Top - 1, picTexto.Width + 1, picTexto.Height + 1)
        'objGraphics.Dispose()
        'Codigo sustituido por el modulodibujovb
        DibujarBordes(picTexto) 'Se llama a la funcion del ModuloDibujo.vb que recibe como parametro el objeto picTexto
    End Sub

    Private Sub mnuOpciones_Click(sender As Object, e As EventArgs) Handles mnuOpciones.Click
        frmOpciones.ShowDialog()
    End Sub

    Private Sub DibujarBordesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DibujarBordesToolStripMenuItem.Click
        Dim objGraphics As Graphics
        objGraphics = Me.CreateGraphics
        objGraphics.Clear(SystemColors.Control)

        objGraphics.DrawRectangle(Pens.Blue, picTexto.Left - 1, picTexto.Top - 1, picTexto.Width + 1, picTexto.Height + 1)
        objGraphics.Dispose()
    End Sub

    Private Sub tbbAbrirImagen_Click(sender As Object, e As EventArgs) Handles tbbAbrirImagen.Click
        ''Mostrar en el cuadro de diálogo Abrir Archivo
        'If ofdSeleccionarImagen.ShowDialog = DialogResult.OK Then
        '    'Cargar la imagen en el PictureBox o Cuadro de Imagen
        '    picTexto.Image = Image.FromFile(ofdSeleccionarImagen.FileName)
        '    'Mostrar el nombre del archivo como titulo del formulario
        '    Me.Text = "Visor de Imagenes(" & ofdSeleccionarImagen.FileName & ")"
        'End If
        'Codigo sustituido por el modulodibujovb

        AbrirImagen() 'Se llama a la funcion del ModuloDibujo.vb
    End Sub

    Private Sub tbbDibujarBordes_Click(sender As Object, e As EventArgs) Handles tbbDibujarBordes.Click
        'Dim objGraphics As Graphics
        'objGraphics = Me.CreateGraphics
        'objGraphics.Clear(SystemColors.Control)

        'objGraphics.DrawRectangle(Pens.Blue, picTexto.Left - 1, picTexto.Top - 1, picTexto.Width + 1, picTexto.Height + 1)
        'objGraphics.Dispose()
        'Codigo sustituido por el modulodibujovb
        DibujarBordes(picTexto) 'Se llama a la funcion del ModuloDibujo.vb que recibe como parametro el objeto picTexto
    End Sub

    Private Sub tbbOpciones_Click(sender As Object, e As EventArgs) Handles tbbOpciones.Click
        frmOpciones.ShowDialog()
    End Sub

    Private Sub picTexto_Click(sender As Object, e As EventArgs) Handles picTexto.Click

    End Sub

    Private Sub FrmVisorEventos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If m_blnConfirmarSalida Then
            If MessageBox.Show("Desea cerrar el programa Visor de Imagenes?", "Visor de Imagenes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub tbbAtributosArchivo_Click(sender As Object, e As EventArgs) Handles tbbAtributosArchivo.Click

        Dim strPropiedades As String
        Dim lngAtributos As Long

        If ofdSeleccionarImagen.FileName = "" Then Exit Sub

        'Obtener las fechas.
        strPropiedades = "Creado: " & System.IO.File.GetCreationTime(ofdSeleccionarImagen.FileName)
        strPropiedades = strPropiedades & "Acceso Reciente: " & System.IO.File.GetLastAccessTime(ofdSeleccionarImagen.FileName)
        strPropiedades = strPropiedades & vbCrLf
        strPropiedades = strPropiedades & "Modificado: " & System.IO.File.GetLastWriteTime(ofdSeleccionarImagen.FileName)

        'Obtener los atributos del archivo.
        lngAtributos = System.IO.File.GetAttributes(ofdSeleccionarImagen.FileName)

        'Utilizar un AND binario para extraer los atributos especificos
        strPropiedades = strPropiedades & vbCrLf
        strPropiedades = strPropiedades & "Normal: " & CBool(lngAtributos And IO.FileAttributes.Normal)

        strPropiedades = strPropiedades & vbCrLf
        strPropiedades = strPropiedades & "Oculto: " & CBool(lngAtributos And IO.FileAttributes.Hidden)

        strPropiedades = strPropiedades & vbCrLf
        strPropiedades = strPropiedades & "Solo Lectura: " & CBool(lngAtributos And IO.FileAttributes.ReadOnly)

        strPropiedades = strPropiedades & vbCrLf
        strPropiedades = strPropiedades & "Sistema: " & CBool(lngAtributos And IO.FileAttributes.System)

        strPropiedades = strPropiedades & vbCrLf
        strPropiedades = strPropiedades & "Archivo temporal: " & CBool(lngAtributos And IO.FileAttributes.Temporary)

        strPropiedades = strPropiedades & vbCrLf
        strPropiedades = strPropiedades & "Archivado: " & CBool(lngAtributos And IO.FileAttributes.Archive)

        MessageBox.Show(strPropiedades, "Visor de imagenes")
    End Sub

    Private Sub tbbMostrarRegistro_Click(sender As Object, e As EventArgs) Handles tbbMostrarRegistro.Click

        frmRegistroVisor.ShowDialog()
    End Sub
End Class
