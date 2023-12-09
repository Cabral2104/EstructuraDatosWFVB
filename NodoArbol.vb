Public Class NodoArbol
    Public Property Valor As Integer
    Public Property Izquierdo As NodoArbol
    Public Property Derecho As NodoArbol

    Public Sub New(valor As Integer)
        Me.Valor = valor
        Izquierdo = Nothing
        Derecho = Nothing
    End Sub
End Class

