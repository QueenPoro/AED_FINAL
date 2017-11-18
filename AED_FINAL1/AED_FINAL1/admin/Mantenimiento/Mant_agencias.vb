Imports System.Data.SqlClient

Public Class Mant_agencias
    Private Sub LED_agencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_datos()
        conectar()

        Dim NuevaFuente As New Font("Segoe UI", 12, FontStyle.Regular)
        DgvDatos.Font = NuevaFuente

        lbel_registro.Text = DgvDatos.RowCount
    End Sub

    Dim consulta As New consulta

    Public Sub mostrar_datos()
        consulta.Consulta("select Id as 'ID', Titular as 'TITULAR', Nombre as 'NOMBRE', Telefonos as 'TELEFONOS', Fax as 'FAX', ZonaActuacion as 'ZONA ACTUACION', Direccion as 'DIRECCION' from Agencias", "Agencias")
        DgvDatos.DataSource = consulta.ds.Tables("Agencias")
    End Sub

    Dim activar_agregar As Boolean = False
    Dim condicion As Integer

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        habilitar_textbox()

        activar_agregar = True

        tbox_titular.Text = ""
        tbox_direccion.Text = ""
        tbox_fax.Text = ""
        tbox_nombre.Text = ""
        tbox_telefono.Text = ""
        tbox_zonaActuacion.Text = ""
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim opcion As DialogResult
        Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo
        Dim title As String = "Eliminar"

        opcion = MsgBox("Desea eliminar el registro seleccionado?", style, title)

        If opcion = DialogResult.Yes Then
            MsgBox(Eliminar("Agencias", "Id", condicion))

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
            If tbox_direccion.Text.Equals("") = False And tbox_fax.Text.Equals("") = False And tbox_nombre.Text.Equals("") = False And tbox_telefono.Text.Equals("") = False And tbox_titular.Text.Equals("") = False And tbox_zonaActuacion.Text.Equals("") = False And IsNumeric(tbox_telefono) = False Then
                MsgBox(insercionAgencias(tbox_titular.Text, tbox_direccion.Text, Val(tbox_telefono.Text), tbox_fax.Text, tbox_zonaActuacion.Text, tbox_nombre.Text))
                mostrar_datos()
                limpiar_e_inhabilitar()

                btn_aceptar.Visible = False
                btn_agregar.Enabled = True
                btn_editar.Enabled = True
                btn_eliminar.Enabled = True
                lbel_registro.Text = DgvDatos.RowCount
            Else
                MsgBox("No se pudo insertar. Existen campos vacios")
            End If

        Else
            Dim campos As String = "Titular ='" & tbox_titular.Text & "', Nombre= '" &
            tbox_nombre.Text & "', Direccion= '" & tbox_direccion.Text & "', Telefonos= " &
            Val(tbox_telefono.Text) & ", Fax= '" & tbox_fax.Text & "', ZonaActuacion= '" &
            tbox_zonaActuacion.Text & "'"
            MsgBox(Actualizar("Agencias", campos, condicion, "Id"))

            mostrar_datos()
            limpiar_e_inhabilitar()
            lbel_registro.Text = DgvDatos.RowCount

        End If
    End Sub

    Public Sub limpiar_e_inhabilitar()
        tbox_titular.Enabled = False
        tbox_direccion.Enabled = False
        tbox_fax.Enabled = False
        tbox_nombre.Enabled = False
        tbox_telefono.Enabled = False
        tbox_zonaActuacion.Enabled = False

        tbox_titular.Text = ""
        tbox_direccion.Text = ""
        tbox_fax.Text = ""
        tbox_nombre.Text = ""
        tbox_telefono.Text = ""
        tbox_zonaActuacion.Text = ""
    End Sub

    Public Sub habilitar_textbox()
        btn_aceptar.Visible = True
        btn_agregar.Enabled = False
        btn_eliminar.Enabled = False
        btn_editar.Enabled = False

        tbox_titular.Enabled = True
        tbox_direccion.Enabled = True
        tbox_fax.Enabled = True
        tbox_nombre.Enabled = True
        tbox_telefono.Enabled = True
        tbox_zonaActuacion.Enabled = True
    End Sub

    Private Sub DgvDatos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvDatos.CellMouseClick
        Dim i As Integer = DgvDatos.CurrentRow.Index

        tbox_titular.Text = DgvDatos.Item(1, i).Value()
        tbox_nombre.Text = DgvDatos.Item(2, i).Value()
        tbox_telefono.Text = DgvDatos.Item(3, i).Value()
        tbox_fax.Text = DgvDatos.Item(4, i).Value()
        tbox_zonaActuacion.Text = DgvDatos.Item(5, i).Value()
        tbox_direccion.Text = DgvDatos.Item(6, i).Value()

        condicion = DgvDatos.Item(0, i).Value()
    End Sub

End Class