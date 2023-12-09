Public Class Grafo
    Private adyacencias As Dictionary(Of Integer, List(Of Integer))

    Public Sub New()
        adyacencias = New Dictionary(Of Integer, List(Of Integer))()
    End Sub

    Public Sub AgregarVertice(vertice As Integer)
        If Not adyacencias.ContainsKey(vertice) Then
            adyacencias(vertice) = New List(Of Integer)()
        End If
    End Sub

    Public Sub AgregarArista(verticeInicio As Integer, verticeFin As Integer)
        AgregarVertice(verticeInicio)
        AgregarVertice(verticeFin)

        If Not adyacencias(verticeInicio).Contains(verticeFin) Then
            adyacencias(verticeInicio).Add(verticeFin)
        End If

        If Not adyacencias(verticeFin).Contains(verticeInicio) Then
            adyacencias(verticeFin).Add(verticeInicio)
        End If
    End Sub

    Public Function ObtenerVertices() As List(Of Integer)
        Return New List(Of Integer)(adyacencias.Keys)
    End Function

    Public Function ObtenerVecinos(vertice As Integer) As List(Of Integer)
        Return If(adyacencias.ContainsKey(vertice), adyacencias(vertice), New List(Of Integer)())
    End Function

    Public Sub EliminarVertice(vertice As Integer)
        If adyacencias.ContainsKey(vertice) Then
            adyacencias.Remove(vertice)

            ' Eliminar referencias a este vértice en otras listas de adyacencia
            For Each listaAdyacente In adyacencias.Values
                listaAdyacente.Remove(vertice)
            Next
        End If
    End Sub

    ' Método para eliminar una arista entre dos vértices
    Public Sub EliminarArista(verticeInicio As Integer, verticeFin As Integer)
        If adyacencias.ContainsKey(verticeInicio) AndAlso adyacencias.ContainsKey(verticeFin) Then
            adyacencias(verticeInicio).Remove(verticeFin)
            adyacencias(verticeFin).Remove(verticeInicio)
        End If
    End Sub
End Class
