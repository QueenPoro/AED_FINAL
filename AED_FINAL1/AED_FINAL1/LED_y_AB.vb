Imports System.Data.SqlClient
Public Class LED_y_AB
    Dim firstClick_abb As Boolean = True
    Dim cont As Integer

    Public Sub custom_boton(pos_btn As Integer)
        Select Case pos_btn
            Case 0
                Me.btn_LED.Normalcolor = Color.RoyalBlue
                Me.btn_LED.Textcolor = Color.White

                Me.btn_ABB.Normalcolor = Color.Transparent
                Me.btn_ABB.Textcolor = Color.FromArgb(49, 60, 75)
            Case 1
                Me.btn_LED.Normalcolor = Color.Transparent
                Me.btn_LED.Textcolor = Color.FromArgb(49, 60, 75)

                Me.btn_ABB.Normalcolor = Color.RoyalBlue
                Me.btn_ABB.Textcolor = Color.White
        End Select
    End Sub

    Private Sub btn_LED_Click(sender As Object, e As EventArgs) Handles btn_LED.Click
        Dim aux As NodoL = primero
        If firstClick_abb Then
            nodo.Clear(Color.FromArgb(240, 240, 240))
            While aux.sig IsNot Nothing
                If cont < 8 Then
                    agregarLE(aux.codigo, False)
                    cont += 1
                Else
                    agregarLE(aux.codigo, True)
                    cont = 0
                End If
                aux = aux.sig
                Threading.Thread.Sleep(600)
            End While
        Else
            nodo.Clear(Color.FromArgb(240, 240, 240))

            inicio = Nothing
            cont = 0

            While aux.sig IsNot Nothing
                If cont < 8 Then
                    agregarLE(aux.codigo, False)
                    cont += 1
                Else
                    agregarLE(aux.codigo, True)
                    cont = 0
                End If
                aux = aux.sig
                Threading.Thread.Sleep(600)
            End While
        End If

        If cont < 8 Then
            agregarLE(aux.codigo, False)
        Else
            agregarLE(aux.codigo, True)
        End If

        custom_boton(0)
    End Sub

    Private Sub btn_ABB_Click(sender As Object, e As EventArgs) Handles btn_ABB.Click
        If firstClick_abb Then
            Dim aux As NodoL = primero

            While aux.sig IsNot Nothing
                agregar(aux.codigo)
                aux = aux.sig
                Threading.Thread.Sleep(600)
            End While
            firstClick_abb = False
        Else
            nodo.Clear(Color.FromArgb(240, 240, 240))
            raiz = Nothing
            Dim aux As NodoL = primero

            While aux.sig IsNot Nothing
                agregar(aux.codigo)
                aux = aux.sig
            End While
        End If

        custom_boton(1)
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Form1.base.Controls.Clear()

        Dim frm As New inicio With {
            .TopLevel = False,
            .Visible = True
        }

        Form1.base.Controls.Add(frm)
        frm.Show()
    End Sub

    '######################################################################################
    '##
    '## L I S T A - E N L A Z A D A
    '######################################################################################

    Dim aFont As New Font("Arial", 12, FontStyle.Bold)
    Dim node As Graphics
    Dim inicio, fin As NodoLista

    '***********************************************
    '* C O N V E R T I R  L I S T A E N L A Z A D A 
    '***********************************************

    'Se utiliza uns lista enlazada simple, para almacenar la base de datos
    Private Class NodoL
        Public codigo As Integer
        Public sig As NodoL

        Public Sub New(ByVal codigo As String)
            Me.codigo = Val(codigo)
            sig = Nothing
        End Sub
    End Class

    Dim primero As NodoL

    Private Sub generarListaEnlazada()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT * FROM Agencias"
        Dim da As SqlDataAdapter = New SqlDataAdapter(sql, consult.conection)
        da.Fill(tabla)

        Dim i As Integer = 0
        Dim puntero As NodoL = primero

        'Se recorre cada fila(row) de la tabla
        For Each row As DataRow In tabla.Rows
            Dim nuevoNodo As New NodoL(tabla.Rows(i)("Id").ToString()) 'Se guarda el id perteneciente a cada row
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

            i += 1 'Se incrementa la fila
        Next row
    End Sub

    '***********************************************
    '* A G R E G A R  L I S T A E N L A Z A D A
    '***********************************************
    'Agregar al final
    Private Sub agregarLE(id As Integer, limitePantalla As Boolean)
        node = Me.CreateGraphics
        If estaVacia() <> True Then
            If limitePantalla Then
                'El final se iguala al nuevo nodo
                fin = New NodoLista(id, Nothing, fin)
                'El siguiente del que estaba de final ahora es el nuevo fin
                fin.ant.sig = fin

                fin.x1_line = 0
                fin.y1_line = 0
                fin.x2_line = 0

                fin.x = inicio.x
                fin.y = inicio.y + 120

                dibujarLE(fin.x, fin.y, id, Brushes.Blue)

            Else
                fin = New NodoLista(id, Nothing, fin)
                fin.ant.sig = fin

                fin.x1_line = fin.ant.x + 60
                fin.y1_line = fin.ant.y + 25
                fin.x2_line = fin.x1_line + 60

                dibujarConexion(fin.x1_line, fin.y1_line, fin.x2_line)

                fin.x = fin.x2_line
                fin.y = fin.ant.y

                dibujarLE(fin.x, fin.y, id, Brushes.Blue)
            End If
        Else
            inicio = New NodoLista(id)
            fin = inicio
            inicio.x = 250
            inicio.y = 50

            dibujarLE(inicio.x, inicio.y, id, Brushes.Blue)
        End If
    End Sub

    Private Function estaVacia()
        Return inicio Is Nothing
    End Function

    '***********************************************
    '* D I B U J A R  L I S T A E N L A Z A D A
    '***********************************************

    Private Sub dibujarLE(x As Integer, y As Integer, n As Integer, brush As Brush)
        node.FillEllipse(brush, x, y, 60, 50)
        node.DrawString(n, aFont, Brushes.White, x + 5, y + 16)
    End Sub

    Private Sub dibujarConexion(x1 As Integer, y1 As Integer, x2 As Integer)
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        node.DrawLine(pen, x1, y1, x2, y1)
    End Sub

    '######################################################################################
    '##
    '##  A R B O L - B I N A R I O
    '######################################################################################
    Dim raiz As NodoArbol
    Dim radio As Integer = 60
    Dim nodo As Graphics
    Dim validarIgual As Boolean
    Dim desplazado As Boolean = False

    Dim consult As New consulta

    '***************************
    '* A G R E G A R  A R B O L
    '***************************

    Private Sub agregar(ByVal n As Integer)
        'Se crea la instancia de la clase NodoArbol y se le envia al constructor
        'el dato que el usuario ingreso en el textbox
        Dim nuevonodo As New NodoArbol(n)
        nodo = Me.CreateGraphics()
        validarIgual = False

        'Primero se hace la validacion para saber si ya hay una raiz, puesto que si no hay raiz
        'obviamente no hay arbol, por ende, el dato se guarda en el nodo raiz
        If raiz Is Nothing Then
            raiz = nuevonodo
            raiz.x_Nodo = 650
            raiz.y_Nodo = 10
            Dibujar_Nodo(raiz.x_Nodo, raiz.y_Nodo, n, Brushes.Red)

        Else
            'Se crea un nodo auxiliar que inicialmente apunta a la raiz. Esta variable axiliar
            'tiene el proposito de funcionar como un puntero que recorre el arbol (incrementar en nodos)
            Dim aux As NodoArbol = raiz
            'Se crea un nodo padre
            Dim padre As NodoArbol

            While (True)
                padre = aux

                If n < aux.num Then
                    aux = aux.Izq
                    nuevonodo.x_Nodo = padre.x_Nodo - 60
                    nuevonodo.y_Nodo = padre.y_Nodo + 100

                    nuevonodo.x1_line = nuevonodo.x_Nodo + 90
                    nuevonodo.y1_line = nuevonodo.y_Nodo - 40
                    nuevonodo.x2_line = nuevonodo.x_Nodo + 30
                    nuevonodo.y2_line = nuevonodo.y_Nodo

                    If aux Is Nothing Then
                        padre.Izq = nuevonodo

                        igual(raiz, nuevonodo.x_Nodo, n)

                        If validarIgual Then
                            nodo.Clear(Color.FromArgb(240, 240, 240))
                            Dibujar_Nodo(raiz.x_Nodo, raiz.y_Nodo, raiz.num, Brushes.Red)
                            desplazar(raiz, Nothing)
                            redibujar(raiz)
                            desplazado = True

                        Else
                            Dibujar_Nodo(padre.Izq.x_Nodo, padre.Izq.y_Nodo, n, Brushes.Red)
                            Dibujar_Rama(padre.Izq.x1_line, padre.Izq.y1_line, padre.Izq.x2_line, padre.Izq.y2_line)
                        End If

                        Return
                    End If
                Else
                    aux = aux.Der
                    nuevonodo.x_Nodo = padre.x_Nodo + 60
                    nuevonodo.y_Nodo = padre.y_Nodo + 100

                    nuevonodo.x1_line = nuevonodo.x_Nodo - 30
                    nuevonodo.y1_line = nuevonodo.y_Nodo - 40
                    nuevonodo.x2_line = nuevonodo.x_Nodo + 30
                    nuevonodo.y2_line = nuevonodo.y_Nodo

                    If aux Is Nothing Then
                        padre.Der = nuevonodo

                        igual(raiz, nuevonodo.x_Nodo, n)

                        If validarIgual Then
                            nodo.Clear(Color.FromArgb(240, 240, 240))
                            Dibujar_Nodo(raiz.x_Nodo, raiz.y_Nodo, raiz.num, Brushes.Red)
                            desplazar(raiz, Nothing)
                            redibujar(raiz)
                            desplazado = True

                        Else
                            Dibujar_Nodo(padre.Der.x_Nodo, padre.Der.y_Nodo, n, Brushes.Red)
                            Dibujar_Rama(padre.Der.x1_line, padre.Der.y1_line, padre.Der.x2_line, padre.Der.y2_line)
                        End If
                        Return
                    End If
                End If
            End While
        End If
    End Sub

    'Metodo para saber cuando el arbol esta vacio
    Private Function vacio()
        If raiz Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    '****************************
    '* B U S Q U E D A  A R B O L
    '****************************

    Private Function buscar(n As Integer)
        Dim aux As NodoArbol = raiz

        While aux.num <> n
            If n < aux.num Then
                aux = aux.Izq
            Else
                aux = aux.Der
            End If

            'Si llego al final y no encontro el dato
            If aux Is Nothing Then
                Return Nothing
            End If
        End While

        Return aux
    End Function

    '****************************
    '* D I B U J A D O  A R B O L
    '****************************

    Private Sub Dibujar_Nodo(x As Integer, y As Integer, n As Integer, brush As Brush)
        nodo.FillEllipse(brush, x, y, radio, radio)
        nodo.DrawString(n, aFont, Brushes.White, x + 5, y + 20)
    End Sub

    Private Sub Dibujar_Rama(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        nodo.DrawLine(pen, x1, y1, x2, y2)
    End Sub

    Private Sub igual(r As NodoArbol, aux_x As Integer, num As Integer)
        If r IsNot Nothing Then
            igual(r.Izq, aux_x, num)
            igual(r.Der, aux_x, num)
            If r IsNot raiz Then
                If ((r.num <> num) And (aux_x = r.x_Nodo)) Then
                    validarIgual = True
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub desplazar(r As NodoArbol, pos As Integer)
        If r IsNot Nothing Then
            desplazar(r.Izq, 0)
            desplazar(r.Der, 1)
            If r IsNot raiz Then
                If pos = 0 And r.num < raiz.num Then
                    r.x_Nodo -= 80
                    If r Is raiz.Izq Then
                        r.x2_line -= 80
                    Else
                        r.x1_line -= 80
                        r.x2_line -= 80
                    End If

                ElseIf pos = 0 And r.num > raiz.num Then
                    r.x_Nodo += 80
                    If r Is raiz.Izq Then
                        r.x2_line += 80
                    Else
                        r.x1_line += 80
                        r.x2_line += 80
                    End If

                ElseIf pos = 1 And r.num > raiz.num Then
                    r.x_Nodo += 80
                    If r Is raiz.Der Then
                        r.x2_line += 80
                    Else
                        r.x1_line += 80
                        r.x2_line += 80
                    End If

                ElseIf pos = 1 And r.num < raiz.num Then
                    r.x_Nodo -= 80
                    If r Is raiz.Der Then
                        r.x2_line -= 80
                    Else
                        r.x1_line -= 80
                        r.x2_line -= 80
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub LED_y_AB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generarListaEnlazada()
    End Sub

    Private Sub redibujar(r As NodoArbol)
        If r IsNot Nothing Then
            redibujar(r.Izq)
            redibujar(r.Der)
            If r IsNot raiz Then
                Dibujar_Nodo(r.x_Nodo, r.y_Nodo, r.num, Brushes.Red)
                'Threading.Thread.Sleep(400)
                Dibujar_Rama(r.x1_line, r.y1_line, r.x2_line, r.y2_line)
            End If
        End If
    End Sub

End Class