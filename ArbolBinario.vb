Public Class ArbolBinario
    Private raiz As NodoArbol

    Public Sub New()
        raiz = Nothing
    End Sub

    ' Insertar un valor en el árbol
    Public Sub Insertar(valor As Integer)
        raiz = InsertarRec(raiz, valor)
    End Sub

    Private Function InsertarRec(raiz As NodoArbol, valor As Integer) As NodoArbol
        If raiz Is Nothing Then
            raiz = New NodoArbol(valor)
            Return raiz
        End If

        If valor < raiz.Valor Then
            raiz.Izquierdo = InsertarRec(raiz.Izquierdo, valor)
        ElseIf valor > raiz.Valor Then
            raiz.Derecho = InsertarRec(raiz.Derecho, valor)
        End If

        Return raiz
    End Function

    ' Eliminar un valor del árbol
    Public Sub Eliminar(valor As Integer)
        raiz = EliminarRec(raiz, valor)
    End Sub

    Private Function EliminarRec(raiz As NodoArbol, valor As Integer) As NodoArbol
        If raiz Is Nothing Then
            Return raiz
        End If

        If valor < raiz.Valor Then
            raiz.Izquierdo = EliminarRec(raiz.Izquierdo, valor)
        ElseIf valor > raiz.Valor Then
            raiz.Derecho = EliminarRec(raiz.Derecho, valor)
        Else
            If raiz.Izquierdo Is Nothing Then
                Return raiz.Derecho
            ElseIf raiz.Derecho Is Nothing Then
                Return raiz.Izquierdo
            End If

            raiz.Valor = MinValor(raiz.Derecho)
            raiz.Derecho = EliminarRec(raiz.Derecho, raiz.Valor)
        End If

        Return raiz
    End Function

    Private Function MinValor(raiz As NodoArbol) As Integer
        Dim minv As Integer = raiz.Valor
        While raiz.Izquierdo IsNot Nothing
            minv = raiz.Izquierdo.Valor
            raiz = raiz.Izquierdo
        End While
        Return minv
    End Function

    ' Realizar recorridos en el árbol
    Public Function Inorden() As List(Of Integer)
        Dim resultado As New List(Of Integer)()
        InordenRec(raiz, resultado)
        Return resultado
    End Function

    Private Sub InordenRec(raiz As NodoArbol, resultado As List(Of Integer))
        If raiz IsNot Nothing Then
            InordenRec(raiz.Izquierdo, resultado)
            resultado.Add(raiz.Valor)
            InordenRec(raiz.Derecho, resultado)
        End If
    End Sub

    Public Function Preorden() As List(Of Integer)
        Dim resultado As New List(Of Integer)()
        PreordenRec(raiz, resultado)
        Return resultado
    End Function

    Private Sub PreordenRec(raiz As NodoArbol, resultado As List(Of Integer))
        If raiz IsNot Nothing Then
            resultado.Add(raiz.Valor)
            PreordenRec(raiz.Izquierdo, resultado)
            PreordenRec(raiz.Derecho, resultado)
        End If
    End Sub

    Public Function Postorden() As List(Of Integer)
        Dim resultado As New List(Of Integer)()
        PostordenRec(raiz, resultado)
        Return resultado
    End Function

    Private Sub PostordenRec(raiz As NodoArbol, resultado As List(Of Integer))
        If raiz IsNot Nothing Then
            PostordenRec(raiz.Izquierdo, resultado)
            PostordenRec(raiz.Derecho, resultado)
            resultado.Add(raiz.Valor)
        End If
    End Sub

    Public Function ObtenerNodoRaiz() As NodoArbol
        Return raiz
    End Function
End Class