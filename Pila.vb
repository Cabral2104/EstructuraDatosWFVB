Public Class Pila
    Private elementos As New Stack(Of Integer)

    ' Agrega un elemento a la pila
    Public Sub Apilar(dato As Integer)
        elementos.Push(dato)
    End Sub

    ' Elimina y retorna el elemento en la cima de la pila
    Public Function Desapilar() As Integer
        If elementos.Count > 0 Then
            Return elementos.Pop()
        Else
            Throw New InvalidOperationException("La pila está vacía.")
        End If
    End Function

    ' Retorna el elemento en la cima de la pila sin eliminarlo
    Public Function Peek() As Integer
        If elementos.Count > 0 Then
            Return elementos.Peek()
        Else
            Throw New InvalidOperationException("La pila está vacía.")
        End If
    End Function

    ' Verifica si la pila está vacía
    Public Function EstaVacia() As Boolean
        Return elementos.Count = 0
    End Function

    ' Retorna la cantidad de elementos en la pila
    Public Function Contar() As Integer
        Return elementos.Count
    End Function

    ' Limpia todos los elementos de la pila
    Public Sub Limpiar()
        elementos.Clear()
    End Sub

    ' Retorna una copia superficial de la pila actual
    Public Function Clonar() As Pila
        Dim nuevaPila As New Pila()
        nuevaPila.elementos = New Stack(Of Integer)(elementos)
        Return nuevaPila
    End Function

    Public Function ObtenerElementos() As Stack(Of Integer)
        Return elementos
    End Function
End Class

