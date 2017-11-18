Imports System.Data.SqlClient
Public Class Codigo
    Private table As String
    Private campo As String

    'SE CREA UNA CLASE PARA TRABAJAR CON UNA LISTA ENLAZADA SIMPLE
    Private Class Nodo
        Public codigo As Integer
        Public sig As Nodo

        Public Sub New(ByVal codigo As String)
            Me.codigo = Val(codigo)
            sig = Nothing
        End Sub
    End Class

    Private primero As Nodo

    Public Function obtener_codigo(ByVal tabla As String, ByVal campo As String) As Integer
        Dim num_final As Integer = 0
        Dim extra As Integer = 0
        Dim aux As String = ""
        Dim value As Integer
        table = tabla
        Me.campo = campo

        While aux.Length < 5
            value = genera(10000) 'genera un numero aleatorio entre 0 y 10000

            aux &= value.ToString 'Se concatena el digito anterior con el nuevo

            If aux.Length > 5 Then 'Si tras la concatenacion el numero a excedido las 5 cifras
                Dim i As Integer = 0

                While i < 5
                    extra &= Val(aux.ElementAt(i)) 'Se agregan los digitos de uno en uno hasta completar los 5

                    i += 1
                End While

                Return extra 'Inmediatamente se retorna este numero final
            End If

            If aux.Length = 5 Then 'Si el numero generado tiene 5 cifras
                generarListaEnlazada()
                If primero Is Nothing Then 'Significa que es el primer registro
                    Return Val(aux)
                Else
                    If comprobarRepetido(aux) Then 'Si el codigo existe le suma una unidad
                        num_final = Val(aux)
                        num_final += 1

                    End If
                End If
            End If
        End While

        Return Val(aux) 'Retorna el codigo generado 
    End Function

    Dim consult As New consulta

    'SE PASAN LOS DATOS DEL DATATABLE A UNA LISTA ENLAZADA SIMPLE
    Private Sub generarListaEnlazada()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT " & campo & " FROM " & table & "'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(sql, consult.conection)
        da.Fill(tabla)

        Dim i As Integer = 0
        Dim puntero As Nodo = primero

        'Se recorre cada fila(row) de la tabla
        For Each row As DataRow In tabla.Rows
            Dim nuevoNodo As New Nodo(tabla.Rows(i)(campo).ToString()) 'Se guarda el id perteneciente a cada row
            'Se realiza el almacenamiento en la lista enlazada
            If primero Is Nothing Then
                primero = nuevoNodo
                puntero = primero
            Else
                While puntero.sig IsNot Nothing
                    puntero = puntero.sig
                End While
                puntero.sig = nuevoNodo
            End If

            i += 1 'Se incrementa la la fila
        Next row
    End Sub

    Private Function comprobarRepetido(ByVal codigo As String)
        'Se utiliza el algoritmo de busqueda binaria para comprobar si el codigo ya existe
        Dim aux As Nodo = primero

        While aux.sig IsNot Nothing
            If aux.codigo = Val(codigo) Then 'Si encuentra un codigo repetido retorna true
                Return True
            End If

            aux = aux.sig
        End While

        Return False 'Retorna false si el codigo no existe
    End Function

    Private Function genera(ByVal max As Integer) As Integer
        Dim randNumber As New Random(DateTime.Now.Millisecond) 'Se usa el datetime porque siempre toma un milisegundo actual distinto

        Return randNumber.Next(0, max)
    End Function

End Class
