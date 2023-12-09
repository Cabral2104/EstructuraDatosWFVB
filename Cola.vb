Public Class Cola
    Private elementos As New Queue(Of Integer)

    ' Agrega un elemento al final de la cola
    Public Sub Encolar(dato As Integer)
        elementos.Enqueue(dato)
    End Sub

    ' Elimina y retorna el elemento al principio de la cola
    Public Function Desencolar() As Integer
        If elementos.Count > 0 Then
            Return elementos.Dequeue()
        Else
            Throw New InvalidOperationException("La cola está vacía.")
        End If
    End Function

    ' Retorna el elemento al principio de la cola sin eliminarlo
    Public Function Peek() As Integer
        If elementos.Count > 0 Then
            Return elementos.Peek()
        Else
            Throw New InvalidOperationException("La cola está vacía.")
        End If
    End Function

    ' Verifica si la cola está vacía
    Public Function EstaVacia() As Boolean
        Return elementos.Count = 0
    End Function

    ' Retorna la cantidad de elementos en la cola
    Public Function Contar() As Integer
        Return elementos.Count
    End Function

    ' Limpia todos los elementos de la cola
    Public Sub Limpiar()
        elementos.Clear()
    End Sub

    ' Retorna una copia superficial de la cola actual
    Public Function Clonar() As Cola
        Dim nuevaCola As New Cola()
        nuevaCola.elementos = New Queue(Of Integer)(elementos)
        Return nuevaCola
    End Function

    ' Nuevo método para obtener una nueva cola con elementos ordenados
    Public Function Ordenar() As Cola
        Dim elementosOrdenados = elementos.OrderBy(Function(x) x).ToArray()

        Dim colaOrdenada As New Cola()
        For Each elemento In elementosOrdenados
            colaOrdenada.Encolar(elemento)
        Next

        Return colaOrdenada
    End Function

    Public Function ObtenerElementosComoArreglo() As Integer()
        Return elementos.ToArray()
    End Function
End Class

