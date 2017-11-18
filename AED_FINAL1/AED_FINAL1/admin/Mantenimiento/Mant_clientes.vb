Imports System.Data.SqlClient
Public Class Mant_clientes
    Private Sub LED_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_datos()
        cargar_cbox_Inmueble()

        Dim NuevaFuente As New Font("Segoe UI", 12, FontStyle.Regular)
        DgvDatos.Font = NuevaFuente

        lbel_registro.Text = DgvDatos.RowCount
    End Sub

    Dim consulta As New consulta

    Public Sub mostrar_datos()
        DgvDatos.DataSource = consulta.Consulta_Relacionada("SELECT Cliente.Id_cliente AS ID, Cliente.Nombre AS NOMBRE, Cliente.IDinmueble AS ID_INMUEBLE FROM Cliente")
    End Sub

    Public Sub cargar_cbox_Inmueble()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT Id_inmueble FROM Inmuebles WHERE NOT Id_inmueble IN (SELECT IDinmueble FROM Cliente)"
        Dim da As SqlDataAdapter = New SqlDataAdapter(sql, consulta.conection)
        da.Fill(tabla)

        cbox_idinmueble.DataSource = tabla
        cbox_idinmueble.DisplayMember = "Id_inmueble"

        'Dim intValue(cbox_idinmueble.Items.Count - 1) As Integer

        'For i As Integer = 0 To cbox_idinmueble.Items.Count - 1
        'cbox_idinmueble.SelectedIndex = i
        'Next
    End Sub

    Dim activar_agregar As Boolean = False
    Dim condicion As Integer

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        habilitar_textbox()

        activar_agregar = True
        tbox_nombre.Text = ""
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim opcion As DialogResult
        Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo
        Dim title As String = "Eliminar"

        opcion = MsgBox("Desea eliminar el registro seleccionado?", style, title)

        If opcion = DialogResult.Yes Then
            MsgBox(Eliminar("Cliente", "Id_cliente", condicion))

            mostrar_datos()
            limpiar_e_inhabilitar()
            lbel_registro.Text = DgvDatos.RowCount
        End If
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        habilitar_textbox()

        activar_agregar = False
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If activar_agregar Then
            'PARA AGREGAR
            If tbox_nombre.Text.Equals("") = False And cbox_idinmueble.Text.Equals("") = False Then
                MsgBox(insercionClientes(tbox_nombre.Text, Val(cbox_idinmueble.Text)))
                mostrar_datos()
                limpiar_e_inhabilitar()

                btn_aceptar.Visible = False
                btn_agregar.Enabled = True
                btn_editar.Enabled = True
                btn_eliminar.Enabled = True
                lbel_registro.Text = DgvDatos.RowCount
                cargar_cbox_Inmueble()
            Else
                MsgBox("No se pudo insertar. Existen campos vacios")
            End If

        Else
            'PARA MODIFICAR
            Dim campos As String = "Nombre= '" & tbox_nombre.Text & "', Id_inmueble= " & Val(cbox_idinmueble.Text)
            MsgBox(Actualizar("Cliente", campos, condicion, "Id_cliente"))

            mostrar_datos()
            limpiar_e_inhabilitar()
            lbel_registro.Text = DgvDatos.RowCount
            cargar_cbox_Inmueble()
        End If

    End Sub

    Public Sub limpiar_e_inhabilitar()
        tbox_nombre.Enabled = False
        cbox_idinmueble.Enabled = False

        tbox_nombre.Text = ""
        cbox_idinmueble.Text = ""
    End Sub

    Public Sub habilitar_textbox()
        btn_aceptar.Visible = True
        btn_agregar.Enabled = False
        btn_eliminar.Enabled = False
        btn_editar.Enabled = False

        tbox_nombre.Enabled = True
        cbox_idinmueble.Enabled = True
    End Sub

    Private Sub DgvDatos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvDatos.CellMouseClick
        Dim i As Integer = DgvDatos.CurrentRow.Index

        tbox_nombre.Text = DgvDatos.Item(1, i).Value()
        cbox_idinmueble.Text = DgvDatos.Item(2, i).RowIndex

        condicion = DgvDatos.Item(0, i).Value()
    End Sub

End Class