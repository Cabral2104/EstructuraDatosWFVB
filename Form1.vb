Public Class Form1
    Inherits Form
    Private lista As New Lista()
    Private pila As New Pila()
    Private cola As New Cola()
    Private arbol As New ArbolBinario()
    Private grafo As New Grafo()

    Private dato As Integer
    Private valor As Integer
    Private vertice As Integer
    Private inicio As Integer
    Private fin As Integer
    Private verticeEliminar As Integer
    Private inicioEliminar As Integer
    Private finEliminar As Integer
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ActualizarLista()
        lstResultado.Items.Clear()
        For Each elemento In lista.ObtenerElementos()
            lstResultado.Items.Add(elemento)
        Next
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        If Integer.TryParse(txtDato.Text, dato) Then
            lista.Insertar(dato)
            ActualizarLista()
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Integer.TryParse(txtDato.Text, dato) Then
            lista.Eliminar(dato)
            ActualizarLista()
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        ActualizarLista()
    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        lista.Ordenar()
        ActualizarLista()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lista.Limpiar()
        ActualizarLista()
    End Sub

    'PILAS

    Private Sub btnApilar_Click(sender As Object, e As EventArgs) Handles btnApilar.Click
        If Integer.TryParse(txtDatoPila.Text, dato) Then
            pila.Apilar(dato)
            ActualizarPila()
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

    Private Sub btnDesapilar_Click(sender As Object, e As EventArgs) Handles btnDesapilar.Click
        Try
            Dim elementoDesapilado As Integer = pila.Desapilar()
            MessageBox.Show($"Elemento desapilado: {elementoDesapilado}")
            ActualizarPila()
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPeek_Click(sender As Object, e As EventArgs) Handles btnPeek.Click
        Try
            Dim elementoEnCima As Integer = pila.Peek()
            MessageBox.Show($"Elemento en la cima: {elementoEnCima}")
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEstaVacia_Click(sender As Object, e As EventArgs) Handles btnEstaVacia.Click
        Dim estaVacia As Boolean = pila.EstaVacia()
        MessageBox.Show($"La pila está vacía: {estaVacia}")
    End Sub

    Private Sub btnContarPila_Click(sender As Object, e As EventArgs) Handles btnContarPila.Click
        Dim cantidadElementos As Integer = pila.Contar()
        MessageBox.Show($"Cantidad de elementos en la pila: {cantidadElementos}")
    End Sub

    Private Sub btnLimpiarPila_Click(sender As Object, e As EventArgs) Handles btnLimpiarPila.Click
        pila.Limpiar()
        ActualizarPila()
    End Sub

    Private Sub btnClonarPila_Click(sender As Object, e As EventArgs) Handles btnClonarPila.Click
        Dim nuevaPila As Pila = pila.Clonar()
        ActualizarPila(nuevaPila)
    End Sub

    Private Sub ActualizarPila()
        lstResultadoPila.Items.Clear()
        For Each elemento In pila.ObtenerElementos()
            lstResultadoPila.Items.Add(elemento.ToString())
        Next
    End Sub

    Private Sub ActualizarPila(pila As Pila)
        lstResultadoPila.Items.Clear()
        For Each elemento In pila.ObtenerElementos()
            lstResultadoPila.Items.Add(elemento.ToString())
        Next
    End Sub

    'COLAS

    Private Sub btnEncolar_Click(sender As Object, e As EventArgs) Handles btnEncolar.Click
        If Integer.TryParse(txtDatoCola.Text, dato) Then
            cola.Encolar(dato)
            ActualizarCola()
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

    Private Sub btnDesencolar_Click(sender As Object, e As EventArgs) Handles btnDesencolar.Click
        Try
            Dim elementoDesencolado As Integer = cola.Desencolar()
            MessageBox.Show($"Elemento desencolado: {elementoDesencolado}")
            ActualizarCola()
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPeekCola_Click(sender As Object, e As EventArgs) Handles btnPeekCola.Click
        Try
            Dim elementoEnFrente As Integer = cola.Peek()
            MessageBox.Show($"Elemento en el frente: {elementoEnFrente}")
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEstaVaciaCola_Click(sender As Object, e As EventArgs) Handles btnEstaVaciaCola.Click
        Dim estaVacia As Boolean = cola.EstaVacia()
        MessageBox.Show($"La cola está vacía: {estaVacia}")
    End Sub

    Private Sub btnContarCola_Click(sender As Object, e As EventArgs) Handles btnContarCola.Click
        Dim cantidadElementos As Integer = cola.Contar()
        MessageBox.Show($"Cantidad de elementos en la cola: {cantidadElementos}")
    End Sub

    Private Sub btnLimpiarCola_Click(sender As Object, e As EventArgs) Handles btnLimpiarCola.Click
        cola.Limpiar()
        ActualizarCola()
    End Sub

    Private Sub btnOrdenarCola_Click(sender As Object, e As EventArgs) Handles btnOrdenarCola.Click
        Dim colaOrdenada As Cola = cola.Ordenar()
        ActualizarCola(colaOrdenada)
    End Sub

    Private Sub ActualizarCola()
        lstResultadoCola.Items.Clear()
        For Each elemento As Integer In cola.ObtenerElementosComoArreglo()
            lstResultadoCola.Items.Add(elemento.ToString())
        Next
    End Sub

    Private Sub ActualizarCola(cola As Cola)
        lstResultadoCola.Items.Clear()
        For Each elemento As Integer In cola.ObtenerElementosComoArreglo()
            lstResultadoCola.Items.Add(elemento.ToString())
        Next
    End Sub

    'ARBOL

    Private Sub bnInsertarArbol_Click(sender As Object, e As EventArgs) Handles bnInsertarArbol.Click
        If Integer.TryParse(txtValorArbol.Text, valor) Then
            arbol.Insertar(valor)
            ActualizarArbol()
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

    Private Sub btnEliminarArbol_Click(sender As Object, e As EventArgs) Handles btnEliminarArbol.Click
        If Integer.TryParse(txtValorArbol.Text, valor) Then
            arbol.Eliminar(valor)
            ActualizarArbol()
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

    Private Sub btnInorden_Click(sender As Object, e As EventArgs) Handles btnInorden.Click
        MessageBox.Show(String.Join(", ", arbol.Inorden()))
    End Sub

    Private Sub btnPreorden_Click(sender As Object, e As EventArgs) Handles btnPreorden.Click
        MessageBox.Show(String.Join(", ", arbol.Preorden()))
    End Sub

    Private Sub btnPostorden_Click(sender As Object, e As EventArgs) Handles btnPostorden.Click
        MessageBox.Show(String.Join(", ", arbol.Postorden()))
    End Sub

    Private Sub ActualizarArbol()
        ' Lógica para representar gráficamente el árbol (puedes usar un control TreeView)
        treeViewArbol.Nodes.Clear()
        DibujarArbol(treeViewArbol.Nodes, arbol.ObtenerNodoRaiz())
    End Sub

    Private Sub DibujarArbol(nodos As TreeNodeCollection, nodo As NodoArbol)
        If nodo IsNot Nothing Then
            Dim nuevoNodo As TreeNode = nodos.Add(nodo.Valor.ToString())

            DibujarArbol(nuevoNodo.Nodes, nodo.Izquierdo)
            DibujarArbol(nuevoNodo.Nodes, nodo.Derecho)
        End If
    End Sub

    Private Sub btnAgregarVertice_Click(sender As Object, e As EventArgs) Handles btnAgregarVertice.Click
        If Integer.TryParse(txtVertice.Text, vertice) Then
            grafo.AgregarVertice(vertice)
            ActualizarGrafo()
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

    Private Sub btnAgregarArista_Click(sender As Object, e As EventArgs) Handles btnAgregarArista.Click
        If Integer.TryParse(txtInicioArista.Text, inicio) AndAlso Integer.TryParse(txtFinArista.Text, fin) Then
            grafo.AgregarArista(inicio, fin)
            ActualizarGrafo()
        Else
            MessageBox.Show("Ingrese valores numéricos válidos para el inicio y el fin de la arista.")
        End If
    End Sub

    Private Sub btnEliminarVertice_Click(sender As Object, e As EventArgs) Handles btnEliminarVertice.Click
        If Integer.TryParse(txtVerticeEliminar.Text, verticeEliminar) Then
            grafo.EliminarVertice(verticeEliminar)
            ActualizarGrafo()
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

    Private Sub btnEliminarArista_Click(sender As Object, e As EventArgs) Handles btnEliminarArista.Click
        If Integer.TryParse(txtInicioEliminarArista.Text, inicioEliminar) AndAlso Integer.TryParse(txtFinEliminarArista.Text, finEliminar) Then
            grafo.EliminarArista(inicioEliminar, finEliminar)
            ActualizarGrafo()
        Else
            MessageBox.Show("Ingrese valores numéricos válidos para el inicio y el fin de la arista.")
        End If
    End Sub

    Private Sub ActualizarGrafo()
        ' Lógica para representar gráficamente el grafo
        DibujarGrafo()
    End Sub

    Private Sub DibujarGrafo()
        ' Lógica para dibujar el grafo en el PictureBox
        Dim bitmap As New Bitmap(pictureBoxGrafo.Width, pictureBoxGrafo.Height)
        Using g As Graphics = Graphics.FromImage(bitmap)
            ' Dibujar vértices
            For Each vertice As Integer In grafo.ObtenerVertices()
                Dim posicion As Point = ObtenerPosicion(vertice)
                Dim rectangulo As New RectangleF(posicion.X - 15, posicion.Y - 15, 30, 30) ' Ajusta el tamaño del vértice según sea necesario
                g.FillEllipse(Brushes.Blue, rectangulo)
                g.DrawString(vertice.ToString(), Font, Brushes.White, posicion)
            Next

            ' Dibujar aristas
            For Each vertice As Integer In grafo.ObtenerVertices()
                For Each vecino As Integer In grafo.ObtenerVecinos(vertice)
                    Dim puntoInicio As Point = ObtenerPosicion(vertice)
                    Dim puntoFin As Point = ObtenerPosicion(vecino)
                    g.DrawLine(Pens.Black, puntoInicio, puntoFin)
                Next
            Next
        End Using

        pictureBoxGrafo.Image = bitmap
    End Sub

    Private Function ObtenerPosicion(vertice As Integer) As Point
        ' Puedes ajustar esto según tus necesidades para distribuir los vértices en el PictureBox
        Return New Point(50 + vertice * 50, pictureBoxGrafo.Height / 2)
    End Function

End Class
