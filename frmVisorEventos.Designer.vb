<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVisorEventos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVisorEventos))
        Me.picTexto = New System.Windows.Forms.PictureBox()
        Me.mnuContextualImagen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DibujarBordesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdSeleccionarImagen = New System.Windows.Forms.OpenFileDialog()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConfirmarSalida = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbrirImagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfirmarSalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuuConfirmarSalida = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDibujarBordes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbrBarraHerrPpal = New System.Windows.Forms.ToolStrip()
        Me.tbbAbrirImagen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbbDibujarBordes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbbOpciones = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbbAtributosArchivo = New System.Windows.Forms.ToolStripButton()
        Me.sbrMiBarraEstado = New System.Windows.Forms.StatusStrip()
        Me.lblEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbbMostrarRegistro = New System.Windows.Forms.ToolStripButton()
        CType(Me.picTexto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuContextualImagen.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.tbrBarraHerrPpal.SuspendLayout()
        Me.sbrMiBarraEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'picTexto
        '
        Me.picTexto.ContextMenuStrip = Me.mnuContextualImagen
        Me.picTexto.Image = CType(resources.GetObject("picTexto.Image"), System.Drawing.Image)
        Me.picTexto.Location = New System.Drawing.Point(0, 51)
        Me.picTexto.Name = "picTexto"
        Me.picTexto.Size = New System.Drawing.Size(330, 242)
        Me.picTexto.TabIndex = 5
        Me.picTexto.TabStop = False
        '
        'mnuContextualImagen
        '
        Me.mnuContextualImagen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DibujarBordesToolStripMenuItem})
        Me.mnuContextualImagen.Name = "mnuContextualImagen"
        Me.mnuContextualImagen.Size = New System.Drawing.Size(152, 26)
        '
        'DibujarBordesToolStripMenuItem
        '
        Me.DibujarBordesToolStripMenuItem.Name = "DibujarBordesToolStripMenuItem"
        Me.DibujarBordesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.DibujarBordesToolStripMenuItem.Text = "Dibujar bordes"
        '
        'ofdSeleccionarImagen
        '
        Me.ofdSeleccionarImagen.FileName = "OpenFileDialog1"
        Me.ofdSeleccionarImagen.Filter = "Archivos de mapa de bits|*.BMP|JPEG|*.JPG"
        Me.ofdSeleccionarImagen.Title = "Seleccionar Imagen"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.ForeColor = System.Drawing.Color.White
        Me.lblX.Location = New System.Drawing.Point(336, 250)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(21, 21)
        Me.lblX.TabIndex = 4
        Me.lblX.Text = "X"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.ForeColor = System.Drawing.Color.White
        Me.lblY.Location = New System.Drawing.Point(336, 271)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(21, 21)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "Y"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(410, 24)
        Me.MenuStrip2.TabIndex = 7
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConfirmarSalida, Me.mnuAbrirImagen, Me.ConfirmarSalidaToolStripMenuItem, Me.mnuuConfirmarSalida, Me.mnuSalir})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'mnuConfirmarSalida
        '
        Me.mnuConfirmarSalida.Name = "mnuConfirmarSalida"
        Me.mnuConfirmarSalida.Size = New System.Drawing.Size(185, 22)
        Me.mnuConfirmarSalida.Text = "Confirmar Salida"
        '
        'mnuAbrirImagen
        '
        Me.mnuAbrirImagen.Name = "mnuAbrirImagen"
        Me.mnuAbrirImagen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAbrirImagen.Size = New System.Drawing.Size(185, 22)
        Me.mnuAbrirImagen.Text = "&Abrir Imagen"
        '
        'ConfirmarSalidaToolStripMenuItem
        '
        Me.ConfirmarSalidaToolStripMenuItem.Name = "ConfirmarSalidaToolStripMenuItem"
        Me.ConfirmarSalidaToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ConfirmarSalidaToolStripMenuItem.Text = "Confirmar Salida"
        '
        'mnuuConfirmarSalida
        '
        Me.mnuuConfirmarSalida.Checked = True
        Me.mnuuConfirmarSalida.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuuConfirmarSalida.Name = "mnuuConfirmarSalida"
        Me.mnuuConfirmarSalida.Size = New System.Drawing.Size(185, 22)
        Me.mnuuConfirmarSalida.Text = "Confirmar Salida"
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(185, 22)
        Me.mnuSalir.Text = "&Salir"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDibujarBordes, Me.ToolStripSeparator1, Me.mnuOpciones})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "&Herramientas"
        '
        'mnuDibujarBordes
        '
        Me.mnuDibujarBordes.Name = "mnuDibujarBordes"
        Me.mnuDibujarBordes.Size = New System.Drawing.Size(151, 22)
        Me.mnuDibujarBordes.Text = "Dibujar &Bordes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'mnuOpciones
        '
        Me.mnuOpciones.Name = "mnuOpciones"
        Me.mnuOpciones.Size = New System.Drawing.Size(151, 22)
        Me.mnuOpciones.Text = "&Opciones"
        '
        'tbrBarraHerrPpal
        '
        Me.tbrBarraHerrPpal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbbAbrirImagen, Me.ToolStripSeparator2, Me.tbbDibujarBordes, Me.ToolStripSeparator3, Me.tbbOpciones, Me.ToolStripSeparator4, Me.tbbAtributosArchivo, Me.tbbMostrarRegistro})
        Me.tbrBarraHerrPpal.Location = New System.Drawing.Point(0, 24)
        Me.tbrBarraHerrPpal.Name = "tbrBarraHerrPpal"
        Me.tbrBarraHerrPpal.Size = New System.Drawing.Size(410, 25)
        Me.tbrBarraHerrPpal.TabIndex = 9
        Me.tbrBarraHerrPpal.Text = "ToolStrip1"
        '
        'tbbAbrirImagen
        '
        Me.tbbAbrirImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbAbrirImagen.Image = CType(resources.GetObject("tbbAbrirImagen.Image"), System.Drawing.Image)
        Me.tbbAbrirImagen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbAbrirImagen.Name = "tbbAbrirImagen"
        Me.tbbAbrirImagen.Size = New System.Drawing.Size(23, 22)
        Me.tbbAbrirImagen.Text = "Abrir Imagen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tbbDibujarBordes
        '
        Me.tbbDibujarBordes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbDibujarBordes.Image = CType(resources.GetObject("tbbDibujarBordes.Image"), System.Drawing.Image)
        Me.tbbDibujarBordes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbDibujarBordes.Name = "tbbDibujarBordes"
        Me.tbbDibujarBordes.Size = New System.Drawing.Size(23, 22)
        Me.tbbDibujarBordes.Text = "Dibujar Bordes"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tbbOpciones
        '
        Me.tbbOpciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbOpciones.Image = CType(resources.GetObject("tbbOpciones.Image"), System.Drawing.Image)
        Me.tbbOpciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbOpciones.Name = "tbbOpciones"
        Me.tbbOpciones.Size = New System.Drawing.Size(23, 22)
        Me.tbbOpciones.Text = "Opciones"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tbbAtributosArchivo
        '
        Me.tbbAtributosArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbAtributosArchivo.Image = CType(resources.GetObject("tbbAtributosArchivo.Image"), System.Drawing.Image)
        Me.tbbAtributosArchivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbAtributosArchivo.Name = "tbbAtributosArchivo"
        Me.tbbAtributosArchivo.Size = New System.Drawing.Size(23, 22)
        Me.tbbAtributosArchivo.Text = "Obtener los atributos del archivo"
        Me.tbbAtributosArchivo.ToolTipText = "Obtener los atributos del archivo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'sbrMiBarraEstado
        '
        Me.sbrMiBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEstado})
        Me.sbrMiBarraEstado.Location = New System.Drawing.Point(0, 296)
        Me.sbrMiBarraEstado.Name = "sbrMiBarraEstado"
        Me.sbrMiBarraEstado.Size = New System.Drawing.Size(410, 22)
        Me.sbrMiBarraEstado.SizingGrip = False
        Me.sbrMiBarraEstado.TabIndex = 10
        Me.sbrMiBarraEstado.Text = "StatusStrip1"
        '
        'lblEstado
        '
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(180, 17)
        Me.lblEstado.Text = "No hay ninguna imagen cargada"
        '
        'tbbMostrarRegistro
        '
        Me.tbbMostrarRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbMostrarRegistro.Image = CType(resources.GetObject("tbbMostrarRegistro.Image"), System.Drawing.Image)
        Me.tbbMostrarRegistro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbMostrarRegistro.Name = "tbbMostrarRegistro"
        Me.tbbMostrarRegistro.Size = New System.Drawing.Size(23, 22)
        Me.tbbMostrarRegistro.Text = "Ver Registro de Imagenes"
        '
        'FrmVisorEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(410, 318)
        Me.Controls.Add(Me.sbrMiBarraEstado)
        Me.Controls.Add(Me.tbrBarraHerrPpal)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.picTexto)
        Me.Controls.Add(Me.MenuStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmVisorEventos"
        Me.Text = "Visor de Eventos"
        CType(Me.picTexto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuContextualImagen.ResumeLayout(False)
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.tbrBarraHerrPpal.ResumeLayout(False)
        Me.tbrBarraHerrPpal.PerformLayout()
        Me.sbrMiBarraEstado.ResumeLayout(False)
        Me.sbrMiBarraEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picTexto As PictureBox
    Friend WithEvents ofdSeleccionarImagen As OpenFileDialog
    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAbrirImagen As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents mnuDibujarBordes As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuOpciones As ToolStripMenuItem
    Friend WithEvents mnuConfirmarSalida As ToolStripMenuItem
    Friend WithEvents ConfirmarSalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuuConfirmarSalida As ToolStripMenuItem
    Friend WithEvents mnuContextualImagen As ContextMenuStrip
    Friend WithEvents DibujarBordesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbrBarraHerrPpal As ToolStrip
    Friend WithEvents tbbAbrirImagen As ToolStripButton
    Friend WithEvents tbbDibujarBordes As ToolStripButton
    Friend WithEvents tbbOpciones As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents sbrMiBarraEstado As StatusStrip
    Friend WithEvents lblEstado As ToolStripStatusLabel
    Friend WithEvents tbbAtributosArchivo As ToolStripButton
    Friend WithEvents tbbMostrarRegistro As ToolStripButton
End Class
