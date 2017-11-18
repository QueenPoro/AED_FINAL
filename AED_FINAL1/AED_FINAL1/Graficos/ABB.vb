Imports System.Data.SqlClient
Public Class ABB
        Dim raiz As NodoArbol
        Dim cont_izq As Integer = 0, cont_der As Integer = 0
        Dim radio As Integer = 60
        Dim nodo As Graphics
        Dim aFont As New Font("Arial", 12, FontStyle.Bold)
        Dim validarIgual As Boolean
        Dim desplazado As Boolean = False

        Dim consult As New consulta

    '***************************
    '* A G R E G A R
    '***************************

    Public Sub agregar(ByVal n As Integer)
        'Se crea la instancia de la clase NodoArbol y se le envia al constructor
        'el dato que el usuario ingreso en el textbox
        Dim nuevonodo As New NodoArbol(n)
        nodo = Panel1.CreateGraphics()
        validarIgual = False

        'Primero se hace la validacion para saber si ya hay una raiz, puesto que si no hay raiz
        'obviamente no hay arbol, por ende, el dato se guarda en el nodo raiz
        If raiz Is Nothing Then
            raiz = nuevonodo
            raiz.x_Nodo = 400
            raiz.y_Nodo = 50
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
                            nodo.Clear(Color.White)
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
                            nodo.Clear(Color.White)
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
    Public Function vacio()
            If raiz Is Nothing Then
                Return True
            Else
                Return False
            End If
        End Function

    '***************************
    '* B U S Q U E D A
    '***************************

    Public Function buscar(n As Integer)
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

    '***************************
    '* D I B U J A D O
    '***************************

    Public Sub Dibujar_Nodo(x As Integer, y As Integer, n As Integer, brush As Brush)
        nodo.FillEllipse(brush, x, y, radio, radio)
        nodo.DrawString(n, aFont, Brushes.White, x + 5, y + 20)
    End Sub

    Public Sub Dibujar_Rama(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        nodo.DrawLine(pen, x1, y1, x2, y2)
    End Sub

    Public Sub igual(r As NodoArbol, aux_x As Integer, num As Integer)
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

    Public Sub desplazar(r As NodoArbol, pos As Integer)
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

    Public Sub redibujar(r As NodoArbol)
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

    Public Sub redibujar_tras_eliminacion()
        nodo.Clear(Color.White)
        Dibujar_Nodo(raiz.x_Nodo, raiz.y_Nodo, raiz.num, Brushes.Red)
        redibujar(raiz)
    End Sub

    '************************************************
    '* C O N V E R T I R A L I S T A E N L A Z A D A 
    '************************************************

    'SE CREA UNA CLASE PARA TRABAJAR CON UNA LISTA ENLAZADA SIMPLE
    Private Class NodoL
        Public codigo As Integer
        Public sig As NodoL

        Public Sub New(ByVal codigo As String)
            Me.codigo = Val(codigo)
            sig = Nothing
        End Sub
    End Class

    Private primero As NodoL

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

        'Dim aux As NodoL = primero


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        generarListaEnlazada()

        Dim aux As NodoL = primero

        While aux.sig IsNot Nothing
            agregar(aux.codigo)
            aux = aux.sig
        End While
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        e.Graphics.TranslateTransform(Panel1.AutoScrollPosition.X, Panel1.AutoScrollPosition.Y)
        e.Graphics.FillRectangle(Brushes.Red, 100, 100, 200, 200)
        e.Graphics.FillRectangle(Brushes.Blue, 300, 800, 400, 1500)
    End Sub

    Private Sub ABB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.AutoScrollMinSize = New Size(Panel1.ClientRectangle.Width - SystemInformation.VerticalScrollBarWidth, 1200)
    End Sub

    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel1.Scroll
        Panel1.Invalidate()

    End Sub
End Class