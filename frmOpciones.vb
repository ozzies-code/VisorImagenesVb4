Public Class frmOpciones

    Const c_strNombreClave As String = "HKEY_CURRENT_USER\Software\SoftwareXYZ\VisorImagenes\"
    Private Sub btnOpciones_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        My.Computer.Registry.SetValue(c_strNombreClave, "NombreDeUsuario", txtNombreUsuario.Text)
        My.Computer.Registry.SetValue(c_strNombreClave, "ConfirmarSalida", chkConfirmarSalida.Checked)

        If optFondoDefecto.Checked Then
            My.Computer.Registry.SetValue(c_strNombreClave, "ColorDeFondo", "Gris")
        Else
            My.Computer.Registry.SetValue(c_strNombreClave, "ColorDeFondo", "Blanco")
        End If

        FrmVisorEventos.CargarPrederminados()

        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub

    Private Sub frmOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNombreUsuario.Text = CStr(My.Computer.Registry.GetValue(c_strNombreClave, "NombreDeUsuario", ""))

        chkConfirmarSalida.Checked = CBool(My.Computer.Registry.GetValue(c_strNombreClave, "ConfirmarSalida", "0"))

        If CStr(My.Computer.Registry.GetValue(c_strNombreClave, "ColorDeFondo", "Gris")) = "Gris" Then
            optFondoDefecto.Checked = True
        Else
            optFondoBlanco.Checked = True
        End If

    End Sub
End Class