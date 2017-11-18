Imports System.Data.SqlClient
Public Class Mant_vendedores
    Private Sub LED_vendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_datos()
        cargar_cbox_agencias()

        Dim NuevaFuente As New Font("Segoe UI", 12, FontStyle.Regular)
        DgvDatos.Font = NuevaFuente

        lbel_registro.Text = DgvDatos.RowCount
    End Sub

    Dim consulta As New consulta

    Public Sub mostrar_datos()
        DgvDatos.DataSource = consulta.Consulta_Relacionada("SELECT Vendedores.Id_vendedor AS ID, Vendedores.Nombre AS NOMBRE, Vendedores.Agencia AS AGENCIA FROM Vendedores")
    End Sub

    Public Sub cargar_cbox_agencias()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT Nombre FROM Agencias"
        Dim da As SqlDataAdapter = New SqlDataAdapter(sql, consulta.conection)
        da.Fill(tabla)

        cbox_Agencia.DataSource = tabla
        cbox_Agencia.DisplayMember = "Nombre"
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
            MsgBox(Eliminar("Vendedores", "Id_vendedor", condicion))

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
            If tbox_nombre.Text.Equals("") = False And cbox_Agencia.Text.Equals("") = False Then
                MsgBox(insercionVendedores(tbox_nombre.Text, cbox_Agencia.Text))
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
            'PARA MODIFICAR
            Dim campos As String = " Nombre= '" & tbox_nombre.Text & "', Agencia= '" & cbox_Agencia.Text & "'"
            MsgBox(Actualizar("Vendedores", campos, condicion, "Id_vendedor"))

            mostrar_datos()
            limpiar_e_inhabilitar()
            lbel_registro.Text = DgvDatos.RowCount

        End If
    End Sub

    Public Sub limpiar_e_inhabilitar()
        tbox_nombre.Enabled = False
        cbox_Agencia.Enabled = False

        tbox_nombre.Text = ""
        cbox_Agencia.Text = ""

        btn_agregar.Enabled = True
        btn_editar.Enabled = True
        btn_eliminar.Enabled = True
        btn_aceptar.Visible = False
    End Sub

    Public Sub habilitar_textbox()
        btn_aceptar.Visible = True
        btn_agregar.Enabled = False
        btn_eliminar.Enabled = False
        btn_editar.Enabled = False

        tbox_nombre.Enabled = True
        cbox_Agencia.Enabled = True
    End Sub

    Private Sub DgvDatos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvDatos.CellMouseClick
        Dim i As Integer = DgvDatos.CurrentRow.Index

        tbox_nombre.Text = DgvDatos.Item(1, i).Value()
        cbox_Agencia.SelectedIndex = DgvDatos.Item(2, i).RowIndex

        condicion = DgvDatos.Item(0, i).Value()
    End Sub

End Class