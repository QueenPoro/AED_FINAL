Public Class NodoArbol
    Public num As Integer
    Public Izq, Der As NodoArbol
    Public x_Nodo, y_Nodo As Integer
    Public x1_line, x2_line, y1_line, y2_line As Integer

    Sub New(ByVal num As Integer)
        Me.num = num
        Izq = Nothing
        Der = Nothing
    End Sub
End Class


