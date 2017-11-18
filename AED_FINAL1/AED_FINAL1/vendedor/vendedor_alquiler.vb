Public Class vendedor_alquiler

    Private Sub tbox_buscar_Enter(sender As Object, e As EventArgs)
        tbox_buscar.text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Select Case ComboBox1.SelectedIndex
            Case 0
                tbox_buscar.text = "Buscar por precio"
            Case 1
                tbox_buscar.text = "Buscar por fianza"
            Case 2
                tbox_buscar.text = "Buscar por tipo de local"
        End Select
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Panel1.Controls.Clear()

        Dim frm As New realizar_alquiler With {
            .TopLevel = False,
            .Visible = True
        }

        Me.Panel1.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub vendedor_alquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_datos()

    End Sub

    Dim conexion As New consulta

    Public Sub mostrar_datos()
        conexion.Consulta("select * from Agencias", "Agencias")
        DgvDatos.DataSource = conexion.ds.Tables("Agencias")
    End Sub
End Class