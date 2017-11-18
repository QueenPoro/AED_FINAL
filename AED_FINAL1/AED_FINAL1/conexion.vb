Imports System.Data.SqlClient

Module conexion
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Public dataset As New DataSet
    Private comandb As SqlCommandBuilder


    'FUNCION DE CONEXION A LA BASE DE DATOS'
    '***********************************************************************************************************************************************'

    Sub conectar()
        Try
            conexiones = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scarlethsotelo\source\repos\AED_FINAL1\AED_FINAL1\Database.mdf;Integrated Security=True")
            conexiones.Open()
            'MsgBox("Conexion exitosa", MsgBoxStyle.Information, "Se ha conectado correctamente") '
        Catch ex As Exception
            MsgBox("Error al realizar la conexion" & ex.Message, MsgBoxStyle.Critical, "Error de conexion")
            conexiones.Close() 'Cierra la conexion'
        End Try
    End Sub

    '***********************************************************************************************************************************************'

    Dim codigo As New Codigo

    'FUNCION DE INSERCION DE AGENCIAS'
    '***************************************************************************************************************************************************'
    Function insercionAgencias(Titular As String, Direccion As String, Telefono As Integer, Fax As String, ZonaActuacion As String, Nombre As String)
        Dim resultado As String = ""
        Dim cod As Integer = codigo.obtener_codigo("Agencias", "Id") 'Se obtiene un codigo aleatorio

        Try
            enunciado = New SqlCommand("INSERT INTO Agencias(Id,Titular,Nombre,Telefonos,Fax,ZonaActuacion,Direccion) VALUES(" & cod & ",'" & Titular & "','" & Nombre & "'," & Telefono & ",'" & Fax & "','" & ZonaActuacion & "','" & Direccion & "')", conexiones)
            enunciado.ExecuteNonQuery()
            resultado = "Se ha insertado correctamente"

        Catch ex As Exception
            resultado = "No se ha podido insertar"

        End Try

        Return resultado
    End Function

    'FUNCION DE INSERCION DE VENDEDORES'
    '***************************************************************************************************************************************************'
    Function insercionVendedores(Nombre As String, Agencia As String)
        Dim resultado As String = ""
        Dim cod As Integer = codigo.obtener_codigo("Vendedores", "Id_vendedor") 'Se obtiene un codigo aleatorio

        Try
            enunciado = New SqlCommand("INSERT INTO Vendedores VALUES(" & cod & ",'" & Nombre & "','" & Agencia & "')", conexiones)
            enunciado.ExecuteNonQuery()
            resultado = "Se ha insertado correctamente"

        Catch ex As Exception
            resultado = "No se ha podido insertar"

        End Try

        Return resultado
    End Function

    'FUNCION DE INSERCION DE CLIENTES'
    '***************************************************************************************************************************************************'
    Function insercionClientes(Nombre As String, inmueble As String)
        Dim resultado As String = ""
        Dim cod As Integer = codigo.obtener_codigo("Cliente", "Id_cliente") 'Se obtiene un codigo aleatorio

        Try
            enunciado = New SqlCommand("INSERT INTO Cliente VALUES(" & cod & ",'" & Nombre & "'," & inmueble & ")", conexiones)
            enunciado.ExecuteNonQuery()
            resultado = "Se ha insertado correctamente"

        Catch ex As Exception
            resultado = "No se ha podido insertar"

        End Try

        Return resultado
    End Function

    'FUNCION DE INSERCION DE INMUEBLES'
    '***************************************************************************************************************************************************'
    Function insercionInmuebles(alquiler_o_venta As String, comercial_o_piso As String, direccion As String, superficie As Double, alquiler_precio As Double, alquiler_fianza As Double, venta_precio As Double, hipoteca As String, licencia_comercial As String, n_habitaciones As Integer, n_banios As Integer, tipoGas As String)
        Dim resultado As String = ""
        Dim cod As Integer = codigo.obtener_codigo("Inmuebles", "Id_inmueble") 'Se obtiene un codigo aleatorio

        Try
            enunciado = New SqlCommand("INSERT INTO Inmuebles VALUES(" & cod & ",'" & alquiler_o_venta & "','" & comercial_o_piso & "','" & direccion & "'," & superficie & "," & alquiler_precio & "," & alquiler_fianza & "," & venta_precio & ",'" & hipoteca & "','" & licencia_comercial & "'," & n_habitaciones & "," & n_banios & ",'" & tipoGas & "')", conexiones)
            enunciado.ExecuteNonQuery()
            resultado = "Se ha insertado correctamente"

        Catch ex As Exception
            resultado = "No se ha podido insertar"

        End Try

        Return resultado
    End Function

    '******************************************************************************************************************************************************'


    'FUNCION DE ELIMINACION'
    '***************************************************************************************************************************************************'
    Function Eliminar(ByVal tabla As String, ByVal identificacion As String, fragmento As String) As String
        Dim resultado As String

        Try
            enunciado = New SqlCommand("DELETE FROM " & tabla & " WHERE " & fragmento & "=" & identificacion, conexiones)
            enunciado.ExecuteNonQuery()
            resultado = "Se elimino el registro correctamente"

        Catch ex As Exception
            resultado = "No se elimino elimino el registro" + ex.ToString

        End Try
        Return resultado
    End Function
    '******************************************************************************************************************************************************'


    'FUNCION DE MODIFICAR'
    '***************************************************************************************************************************************************'
    Function Actualizar(ByVal tabla As String, ByVal campos As String, ByVal condicion As Integer, ByVal id As String) As String
        Dim resultado As String = ""

        Try
            Dim actualiza As String = "UPDATE " & tabla & " SET " & campos & " WHERE " & id & "=" & condicion
            enunciado = New SqlCommand(actualiza, conexiones)
            enunciado.ExecuteNonQuery()
            resultado = "Se Actualizo Correctamente los datos"

        Catch ex As Exception
            resultado = "No se actualizo los datos correctamente" + ex.ToString

        End Try

        Return resultado
    End Function
End Module
