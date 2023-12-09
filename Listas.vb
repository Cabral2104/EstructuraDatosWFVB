Public Class Lista
    Private elementos As New List(Of Integer)

    ' Inserta un elemento al final de la lista
    Public Sub Insertar(dato As Integer)
        elementos.Add(dato)
    End Sub

    ' Elimina la primera ocurrencia del elemento en la lista
    Public Sub Eliminar(dato As Integer)
        elementos.Remove(dato)
    End Sub

    ' Verifica si un elemento está presente en la lista
    Public Function Contiene(dato As Integer) As Boolean
        Return elementos.Contains(dato)
    End Function

    ' Retorna el índice de la primera ocurrencia del elemento en la lista
    ' Retorna -1 si no se encuentra
    Public Function Buscar(dato As Integer) As Integer
        Return elementos.IndexOf(dato)
    End Function

    ' Retorna la cantidad de elementos en la lista
    Public Function Contar() As Integer
        Return elementos.Count
    End Function

    ' Retorna una copia de la lista
    Public Function ObtenerElementos() As List(Of Integer)
        Return New List(Of Integer)(elementos)
    End Function

    ' Ordena los elementos de la lista
    Public Sub Ordenar()
        elementos.Sort()
    End Sub

    ' Elimina todos los elementos de la lista
    Public Sub Limpiar()
        elementos.Clear()
    End Sub

    ' Realiza una copia superficial de la lista actual
    Public Function Clonar() As Lista
        Dim nuevaLista As New Lista()
        nuevaLista.elementos.AddRange(elementos)
        Return nuevaLista
    End Function
End Class

