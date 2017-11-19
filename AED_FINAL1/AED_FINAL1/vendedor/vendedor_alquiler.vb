Imports System.Data.SqlClient
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
        Me.Controls.Clear()

        Dim frm As New realizar_alquiler With {
            .TopLevel = False,
            .Visible = True
        }

        Me.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub vendedor_alquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_cbox()

    End Sub

    Dim consulta As New consulta

    Private Sub cargar_cbox()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT Nombre FROM Agencias"
        Dim da As SqlDataAdapter = New SqlDataAdapter(sql, consulta.conection)
        da.Fill(tabla)

        cbox_agencia.DataSource = tabla
        cbox_agencia.DisplayMember = "Nombre"
    End Sub

    Private Sub cbox_agencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_agencia.SelectedIndexChanged
        consulta.Consulta("SELECT * FROM Agencias WHERE Nombre='" & cbox_agencia.Text & "'", "Agencias")
        DgvDatos.DataSource = consulta.ds.Tables("Agencias")
    End Sub
End Class