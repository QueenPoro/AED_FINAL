Public Class NodoLista
    Public id As Integer
    Public sig As NodoLista
    Public ant As NodoLista
    Public x, y As Integer
    Public x1_line, y1_line, x2_line, y2_line As Integer

    Public Sub New(id As Integer, sig As NodoLista, ant As NodoLista)
        Me.id = id
        Me.sig = sig
        Me.ant = ant
    End Sub

    Public Sub New(id As Integer)
        Me.id = id
        sig = Nothing
        ant = Nothing
    End Sub

End Class
