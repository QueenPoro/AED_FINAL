Public Class Mant_inmuebles
    Private Sub Mant_inmuebles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_datos()
        conectar()

        Dim NuevaFuente As New Font("Segoe UI", 12, FontStyle.Regular)
        DgvDatos.Font = NuevaFuente

        lbel_registro.Text = DgvDatos.RowCount
    End Sub

    Dim consulta As New consulta

    Public Sub mostrar_datos()
        consulta.Consulta("SELECT Id_inmueble AS ID, Alquiler_o_venta AS TIPOINMUEBLE, Comercial_o_piso AS TIPOLOCAL, Direccion AS DIRECCION, Superficie AS SUPERFICIE, Talquiler_Precio AS PRECIOALQUILER, Talquiler_Fianza AS FIANZAALQUILER, Tventa_Precio AS PRECIOVENTA, Tventa_Estadohipoteca AS HIPOTECA, Tcomercial_licencia AS LICENCIACOMERCIAL, Tpiso_Nhabitaciones AS NoHABITACIONES, Tpiso_NcuartosBanio AS BAÑIOS, Tpiso_Tipogas AS TIPOGAS FROM Inmuebles", "Inmuebles")
        DgvDatos.DataSource = consulta.ds.Tables("Inmuebles")
    End Sub

    Dim activar_agregar As Boolean = False
    Dim condicion As Integer

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Panel1.Enabled = True
        activar_agregar = True
        btn_aceptar.Visible = True

        tbox_direccion.Text = ""
        tbox_superficie.Text = ""
        tbox_direccion.Enabled = True
        tbox_superficie.Enabled = True
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim opcion As DialogResult
        Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo
        Dim title As String = "Eliminar"

        opcion = MsgBox("Desea eliminar el registro seleccionado?", style, title)

        If opcion = DialogResult.Yes Then
            MsgBox(Eliminar("Inmuebles", "Id_inmueble", condicion))

            mostrar_datos()
            limpiar_e_inhabilitar()
            lbel_registro.Text = DgvDatos.RowCount
        End If
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        habilitar_panel()
        Panel1.Enabled = True

        activar_agregar = False
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If activar_agregar Then
            MsgBox(insercionInmuebles(cbox_TInmueble.Text, cbox_TLocal.Text, tbox_direccion.Text, Val(tbox_superficie.Text), Val(tbox_precioAlquiler.Text), Val(tbox_fianzaAlquiler.Text), Val(tbox_precioVenta.Text), cbox_hipoteca.Text, cbox_TLicencia.Text, Val(tbox_nhabitaciones.Text), Val(tbox_nbanios.Text), cbox_Tgas.Text))
            mostrar_datos()
            limpiar_e_inhabilitar()

            btn_aceptar.Visible = False
            btn_agregar.Enabled = True
            btn_editar.Enabled = True
            btn_eliminar.Enabled = True
            lbel_registro.Text = DgvDatos.RowCount

        Else
            Dim campos As String = "Alquiler_o_venta ='" & cbox_TInmueble.Text & "', Comercial_o_piso= '" &
            cbox_TLocal.Text & "', Direccion= '" & tbox_direccion.Text & "', Superficie= " &
            Val(tbox_superficie.Text) & ", Talquiler_Precio= " & Val(tbox_precioAlquiler.Text) & ", Talquiler_Fianza= " &
            Val(tbox_fianzaAlquiler.Text) & ", Tventa_Precio= " & Val(tbox_precioVenta.Text) & ", Tventa_Estadohipoteca= '" &
            cbox_hipoteca.Text & "', Tcomercial_licencia= '" & cbox_TLicencia.Text & "', Tpiso_Nhabitaciones= " &
            Val(tbox_nhabitaciones.Text) & ", Tpiso_Ncuartosbanio= " & Val(tbox_nbanios.Text) & ", Tpiso_Tipogas= '" & cbox_Tgas.Text & "'"
            MsgBox(Actualizar("Inmuebles", campos, condicion, "Id_inmueble"))

            mostrar_datos()
            limpiar_e_inhabilitar()
            lbel_registro.Text = DgvDatos.RowCount

        End If
    End Sub

    Private Sub cbox_Tinmueble_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_TInmueble.SelectedIndexChanged
        If cbox_TInmueble.Text = "Alquiler" Then 'Alquiler
            panel_alquiler.Visible = True
            panel_venta.Visible = False
            limpiarCuandoesAlquiler()

        Else 'Venta
            panel_alquiler.Visible = False
            panel_venta.Visible = True
        End If
    End Sub

    Public Sub limpiarCuandoesAlquiler()
        tbox_precioVenta.Text = 0
        cbox_hipoteca.Text = ""
    End Sub

    Public Sub limpiarCuandoesVenta()
        tbox_precioAlquiler.Text = 0
        tbox_fianzaAlquiler.Text = 0
    End Sub

    Public Sub limpiar_e_inhabilitar()
        cbox_TInmueble.Text = ""
        cbox_TLocal.Text = ""
        venta.cbox_hipoteca.Text = ""
        tbox_direccion.Text = ""
        tbox_superficie.Text = ""
        tbox_precioAlquiler.Text = ""
        tbox_fianzaAlquiler.Text = ""
        tbox_precioAlquiler.Text = ""
        tbox_precioVenta.Text = ""

        btn_aceptar.Visible = False
        btn_agregar.Enabled = True
        btn_eliminar.Enabled = True
        btn_editar.Enabled = True

        Panel1.Enabled = False
        panel_alquiler.Visible = False
        panel_comercial.Visible = False
        panel_piso.Visible = False
        panel_venta.Visible = False
    End Sub

    Public Sub habilitar_panel()
        btn_aceptar.Visible = True
        btn_agregar.Enabled = False
        btn_eliminar.Enabled = False
        btn_editar.Enabled = False

        Panel1.Enabled = True
    End Sub

    Private Sub DgvDatos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvDatos.CellMouseClick
        Dim i As Integer = DgvDatos.CurrentRow.Index

        cbox_TInmueble.Text = DgvDatos.Item(1, i).Value()
        cbox_TLocal.Text = DgvDatos.Item(2, i).Value()
        tbox_direccion.Text = DgvDatos.Item(3, i).Value()
        tbox_superficie.Text = DgvDatos.Item(4, i).Value()

        If DgvDatos.Item(1, i).Value() = "Alquiler" Then
            panel_alquiler.Visible = True
            panel_venta.Visible = False
            tbox_precioAlquiler.Text = DgvDatos.Item(5, i).Value()
            tbox_fianzaAlquiler.Text = DgvDatos.Item(6, i).Value()
        Else
            panel_venta.Visible = True
            panel_alquiler.Visible = False
            tbox_precioVenta.Text = DgvDatos.Item(7, i).Value()
            cbox_hipoteca.Text = DgvDatos.Item(8, i).Value()
        End If

        If DgvDatos.Item(2, i).Value() = "Comercial" Then
            panel_comercial.Visible = True
            panel_piso.Visible = False
            cbox_TLicencia.Text = DgvDatos.Item(9, i).Value()
        Else
            panel_piso.Visible = True
            panel_comercial.Visible = False
            tbox_nhabitaciones.Text = DgvDatos.Item(10, i).Value()
            tbox_nbanios.Text = DgvDatos.Item(11, i).Value()
            cbox_Tgas.Text = DgvDatos.Item(12, i).Value()
        End If

        condicion = DgvDatos.Item(0, i).Value()
    End Sub

    Private Sub cbox_TLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_TLocal.SelectedIndexChanged
        If cbox_TLocal.Text = "Comercial" Then 'Comercial
            panel_comercial.Visible = True
            panel_piso.Visible = False
            limpiarCuandoesComercial()
        Else 'Piso
            panel_comercial.Visible = False
            panel_piso.Visible = True
            limpiarCuandoesPiso()
        End If
    End Sub

    Public Sub limpiarCuandoesComercial()
        tbox_nhabitaciones.Text = 0
        tbox_nbanios.Text = 0
        cbox_Tgas.Text = ""
    End Sub

    Public Sub limpiarCuandoesPiso()
        cbox_TLicencia.Text = ""
    End Sub

End Class