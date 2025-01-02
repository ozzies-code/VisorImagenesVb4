<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpciones))
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.chkConfirmarSalida = New System.Windows.Forms.CheckBox()
        Me.TabOpciones = New System.Windows.Forms.TabControl()
        Me.pgePagGeneral = New System.Windows.Forms.TabPage()
        Me.pgApariencia = New System.Windows.Forms.TabPage()
        Me.grpFondoporDefecto = New System.Windows.Forms.GroupBox()
        Me.optFondoBlanco = New System.Windows.Forms.RadioButton()
        Me.optFondoDefecto = New System.Windows.Forms.RadioButton()
        Me.TabOpciones.SuspendLayout()
        Me.pgePagGeneral.SuspendLayout()
        Me.pgApariencia.SuspendLayout()
        Me.grpFondoporDefecto.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Firebrick
        Me.btnAceptar.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnAceptar.Location = New System.Drawing.Point(412, 22)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(95, 39)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnCancelar.Location = New System.Drawing.Point(412, 67)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 39)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.AcceptsReturn = True
        Me.txtNombreUsuario.AcceptsTab = True
        Me.txtNombreUsuario.Location = New System.Drawing.Point(119, 21)
        Me.txtNombreUsuario.MaxLength = 0
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNombreUsuario.Size = New System.Drawing.Size(255, 20)
        Me.txtNombreUsuario.TabIndex = 4
        Me.txtNombreUsuario.Text = "Texto de muestra. Un cuadro de texto de varias lineas  distribuye el texto como s" &
    "ea necesario"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.ForeColor = System.Drawing.Color.Black
        Me.lblNombreUsuario.Location = New System.Drawing.Point(15, 24)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(98, 13)
        Me.lblNombreUsuario.TabIndex = 7
        Me.lblNombreUsuario.Text = "Nombre de Usuario"
        '
        'chkConfirmarSalida
        '
        Me.chkConfirmarSalida.AutoSize = True
        Me.chkConfirmarSalida.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConfirmarSalida.ForeColor = System.Drawing.Color.Black
        Me.chkConfirmarSalida.Location = New System.Drawing.Point(119, 56)
        Me.chkConfirmarSalida.Name = "chkConfirmarSalida"
        Me.chkConfirmarSalida.Size = New System.Drawing.Size(126, 18)
        Me.chkConfirmarSalida.TabIndex = 8
        Me.chkConfirmarSalida.Text = "Confirmar Salida"
        Me.chkConfirmarSalida.UseVisualStyleBackColor = True
        '
        'TabOpciones
        '
        Me.TabOpciones.Controls.Add(Me.pgePagGeneral)
        Me.TabOpciones.Controls.Add(Me.pgApariencia)
        Me.TabOpciones.Location = New System.Drawing.Point(2, 2)
        Me.TabOpciones.Name = "TabOpciones"
        Me.TabOpciones.SelectedIndex = 0
        Me.TabOpciones.Size = New System.Drawing.Size(404, 179)
        Me.TabOpciones.TabIndex = 10
        '
        'pgePagGeneral
        '
        Me.pgePagGeneral.Controls.Add(Me.lblNombreUsuario)
        Me.pgePagGeneral.Controls.Add(Me.chkConfirmarSalida)
        Me.pgePagGeneral.Controls.Add(Me.txtNombreUsuario)
        Me.pgePagGeneral.Location = New System.Drawing.Point(4, 22)
        Me.pgePagGeneral.Name = "pgePagGeneral"
        Me.pgePagGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.pgePagGeneral.Size = New System.Drawing.Size(396, 153)
        Me.pgePagGeneral.TabIndex = 0
        Me.pgePagGeneral.Text = "General"
        Me.pgePagGeneral.UseVisualStyleBackColor = True
        '
        'pgApariencia
        '
        Me.pgApariencia.Controls.Add(Me.grpFondoporDefecto)
        Me.pgApariencia.Location = New System.Drawing.Point(4, 22)
        Me.pgApariencia.Name = "pgApariencia"
        Me.pgApariencia.Padding = New System.Windows.Forms.Padding(3)
        Me.pgApariencia.Size = New System.Drawing.Size(396, 153)
        Me.pgApariencia.TabIndex = 1
        Me.pgApariencia.Text = "Apariencia"
        Me.pgApariencia.UseVisualStyleBackColor = True
        '
        'grpFondoporDefecto
        '
        Me.grpFondoporDefecto.Controls.Add(Me.optFondoBlanco)
        Me.grpFondoporDefecto.Controls.Add(Me.optFondoDefecto)
        Me.grpFondoporDefecto.Location = New System.Drawing.Point(23, 22)
        Me.grpFondoporDefecto.Name = "grpFondoporDefecto"
        Me.grpFondoporDefecto.Size = New System.Drawing.Size(202, 74)
        Me.grpFondoporDefecto.TabIndex = 10
        Me.grpFondoporDefecto.TabStop = False
        Me.grpFondoporDefecto.Text = "Color de fondo por defecto"
        '
        'optFondoBlanco
        '
        Me.optFondoBlanco.AutoSize = True
        Me.optFondoBlanco.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFondoBlanco.ForeColor = System.Drawing.Color.Black
        Me.optFondoBlanco.Location = New System.Drawing.Point(7, 48)
        Me.optFondoBlanco.Name = "optFondoBlanco"
        Me.optFondoBlanco.Size = New System.Drawing.Size(65, 18)
        Me.optFondoBlanco.TabIndex = 11
        Me.optFondoBlanco.TabStop = True
        Me.optFondoBlanco.Text = "Blanco"
        Me.optFondoBlanco.UseVisualStyleBackColor = True
        '
        'optFondoDefecto
        '
        Me.optFondoDefecto.AutoSize = True
        Me.optFondoDefecto.Checked = True
        Me.optFondoDefecto.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFondoDefecto.ForeColor = System.Drawing.Color.Black
        Me.optFondoDefecto.Location = New System.Drawing.Point(7, 19)
        Me.optFondoDefecto.Name = "optFondoDefecto"
        Me.optFondoDefecto.Size = New System.Drawing.Size(122, 18)
        Me.optFondoDefecto.TabIndex = 10
        Me.optFondoDefecto.TabStop = True
        Me.optFondoDefecto.Text = "Gris por Defecto"
        Me.optFondoDefecto.UseVisualStyleBackColor = True
        '
        'frmOpciones
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(519, 337)
        Me.Controls.Add(Me.TabOpciones)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmOpciones"
        Me.Text = "OPCIONES DEL VISOR DE IMAGENES"
        Me.TabOpciones.ResumeLayout(False)
        Me.pgePagGeneral.ResumeLayout(False)
        Me.pgePagGeneral.PerformLayout()
        Me.pgApariencia.ResumeLayout(False)
        Me.grpFondoporDefecto.ResumeLayout(False)
        Me.grpFondoporDefecto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents chkConfirmarSalida As CheckBox
    Friend WithEvents TabOpciones As TabControl
    Friend WithEvents pgePagGeneral As TabPage
    Friend WithEvents pgApariencia As TabPage
    Friend WithEvents grpFondoporDefecto As GroupBox
    Friend WithEvents optFondoBlanco As RadioButton
    Friend WithEvents optFondoDefecto As RadioButton
End Class
