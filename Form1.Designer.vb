<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabListas = New System.Windows.Forms.TabPage()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.lstResultado = New System.Windows.Forms.ListBox()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.tabPilas = New System.Windows.Forms.TabPage()
        Me.btnClonarPila = New System.Windows.Forms.Button()
        Me.lstResultadoPila = New System.Windows.Forms.ListView()
        Me.btnLimpiarPila = New System.Windows.Forms.Button()
        Me.btnContarPila = New System.Windows.Forms.Button()
        Me.btnEstaVacia = New System.Windows.Forms.Button()
        Me.btnPeek = New System.Windows.Forms.Button()
        Me.btnDesapilar = New System.Windows.Forms.Button()
        Me.txtDatoPila = New System.Windows.Forms.TextBox()
        Me.btnApilar = New System.Windows.Forms.Button()
        Me.tabColas = New System.Windows.Forms.TabPage()
        Me.txtDatoCola = New System.Windows.Forms.TextBox()
        Me.lstResultadoCola = New System.Windows.Forms.ListView()
        Me.btnOrdenarCola = New System.Windows.Forms.Button()
        Me.btnLimpiarCola = New System.Windows.Forms.Button()
        Me.btnContarCola = New System.Windows.Forms.Button()
        Me.btnEstaVaciaCola = New System.Windows.Forms.Button()
        Me.btnPeekCola = New System.Windows.Forms.Button()
        Me.btnDesencolar = New System.Windows.Forms.Button()
        Me.btnEncolar = New System.Windows.Forms.Button()
        Me.tabArboles = New System.Windows.Forms.TabPage()
        Me.txtValorArbol = New System.Windows.Forms.TextBox()
        Me.btnPostorden = New System.Windows.Forms.Button()
        Me.btnPreorden = New System.Windows.Forms.Button()
        Me.btnInorden = New System.Windows.Forms.Button()
        Me.btnEliminarArbol = New System.Windows.Forms.Button()
        Me.bnInsertarArbol = New System.Windows.Forms.Button()
        Me.treeViewArbol = New System.Windows.Forms.TreeView()
        Me.tabGrafos = New System.Windows.Forms.TabPage()
        Me.txtFinEliminarArista = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtInicioEliminarArista = New System.Windows.Forms.TextBox()
        Me.btnEliminarArista = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnEliminarVertice = New System.Windows.Forms.Button()
        Me.txtVerticeEliminar = New System.Windows.Forms.TextBox()
        Me.pictureBoxGrafo = New System.Windows.Forms.PictureBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtFinArista = New System.Windows.Forms.TextBox()
        Me.txtInicioArista = New System.Windows.Forms.TextBox()
        Me.btnAgregarArista = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnAgregarVertice = New System.Windows.Forms.Button()
        Me.txtVertice = New System.Windows.Forms.TextBox()
        Me.tabControl1.SuspendLayout()
        Me.tabListas.SuspendLayout()
        Me.tabPilas.SuspendLayout()
        Me.tabColas.SuspendLayout()
        Me.tabArboles.SuspendLayout()
        Me.tabGrafos.SuspendLayout()
        CType(Me.pictureBoxGrafo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabListas)
        Me.tabControl1.Controls.Add(Me.tabPilas)
        Me.tabControl1.Controls.Add(Me.tabColas)
        Me.tabControl1.Controls.Add(Me.tabArboles)
        Me.tabControl1.Controls.Add(Me.tabGrafos)
        Me.tabControl1.Location = New System.Drawing.Point(12, 37)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(776, 377)
        Me.tabControl1.TabIndex = 1
        '
        'tabListas
        '
        Me.tabListas.AccessibleName = "tabListas"
        Me.tabListas.Controls.Add(Me.btnLimpiar)
        Me.tabListas.Controls.Add(Me.btnOrdenar)
        Me.tabListas.Controls.Add(Me.btnMostrar)
        Me.tabListas.Controls.Add(Me.btnEliminar)
        Me.tabListas.Controls.Add(Me.btnInsertar)
        Me.tabListas.Controls.Add(Me.lstResultado)
        Me.tabListas.Controls.Add(Me.txtDato)
        Me.tabListas.Location = New System.Drawing.Point(4, 22)
        Me.tabListas.Name = "tabListas"
        Me.tabListas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabListas.Size = New System.Drawing.Size(768, 351)
        Me.tabListas.TabIndex = 0
        Me.tabListas.Text = "Listas"
        Me.tabListas.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(544, 160)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(118, 32)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Location = New System.Drawing.Point(544, 86)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(118, 32)
        Me.btnOrdenar.TabIndex = 5
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(544, 19)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(118, 32)
        Me.btnMostrar.TabIndex = 4
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(354, 86)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(118, 32)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(354, 19)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(118, 32)
        Me.btnInsertar.TabIndex = 2
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'lstResultado
        '
        Me.lstResultado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstResultado.FormattingEnabled = True
        Me.lstResultado.Location = New System.Drawing.Point(193, 143)
        Me.lstResultado.Name = "lstResultado"
        Me.lstResultado.Size = New System.Drawing.Size(279, 160)
        Me.lstResultado.TabIndex = 1
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(109, 47)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(162, 20)
        Me.txtDato.TabIndex = 0
        '
        'tabPilas
        '
        Me.tabPilas.AccessibleName = "tabPilas"
        Me.tabPilas.Controls.Add(Me.btnClonarPila)
        Me.tabPilas.Controls.Add(Me.lstResultadoPila)
        Me.tabPilas.Controls.Add(Me.btnLimpiarPila)
        Me.tabPilas.Controls.Add(Me.btnContarPila)
        Me.tabPilas.Controls.Add(Me.btnEstaVacia)
        Me.tabPilas.Controls.Add(Me.btnPeek)
        Me.tabPilas.Controls.Add(Me.btnDesapilar)
        Me.tabPilas.Controls.Add(Me.txtDatoPila)
        Me.tabPilas.Controls.Add(Me.btnApilar)
        Me.tabPilas.Location = New System.Drawing.Point(4, 22)
        Me.tabPilas.Name = "tabPilas"
        Me.tabPilas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPilas.Size = New System.Drawing.Size(768, 351)
        Me.tabPilas.TabIndex = 1
        Me.tabPilas.Text = "Pilas"
        Me.tabPilas.UseVisualStyleBackColor = True
        '
        'btnClonarPila
        '
        Me.btnClonarPila.Location = New System.Drawing.Point(537, 251)
        Me.btnClonarPila.Name = "btnClonarPila"
        Me.btnClonarPila.Size = New System.Drawing.Size(115, 40)
        Me.btnClonarPila.TabIndex = 8
        Me.btnClonarPila.Text = "Clonar Pila"
        Me.btnClonarPila.UseVisualStyleBackColor = True
        '
        'lstResultadoPila
        '
        Me.lstResultadoPila.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstResultadoPila.HideSelection = False
        Me.lstResultadoPila.Location = New System.Drawing.Point(109, 144)
        Me.lstResultadoPila.Name = "lstResultadoPila"
        Me.lstResultadoPila.Size = New System.Drawing.Size(269, 179)
        Me.lstResultadoPila.TabIndex = 7
        Me.lstResultadoPila.UseCompatibleStateImageBehavior = False
        '
        'btnLimpiarPila
        '
        Me.btnLimpiarPila.Location = New System.Drawing.Point(625, 181)
        Me.btnLimpiarPila.Name = "btnLimpiarPila"
        Me.btnLimpiarPila.Size = New System.Drawing.Size(115, 40)
        Me.btnLimpiarPila.TabIndex = 6
        Me.btnLimpiarPila.Text = "Limpiar Pila"
        Me.btnLimpiarPila.UseVisualStyleBackColor = True
        '
        'btnContarPila
        '
        Me.btnContarPila.Location = New System.Drawing.Point(625, 115)
        Me.btnContarPila.Name = "btnContarPila"
        Me.btnContarPila.Size = New System.Drawing.Size(115, 40)
        Me.btnContarPila.TabIndex = 5
        Me.btnContarPila.Text = "Contar Pila"
        Me.btnContarPila.UseVisualStyleBackColor = True
        '
        'btnEstaVacia
        '
        Me.btnEstaVacia.Location = New System.Drawing.Point(625, 40)
        Me.btnEstaVacia.Name = "btnEstaVacia"
        Me.btnEstaVacia.Size = New System.Drawing.Size(115, 40)
        Me.btnEstaVacia.TabIndex = 4
        Me.btnEstaVacia.Text = "Esta Vacía"
        Me.btnEstaVacia.UseVisualStyleBackColor = True
        '
        'btnPeek
        '
        Me.btnPeek.Location = New System.Drawing.Point(473, 181)
        Me.btnPeek.Name = "btnPeek"
        Me.btnPeek.Size = New System.Drawing.Size(115, 40)
        Me.btnPeek.TabIndex = 3
        Me.btnPeek.Text = "Peek"
        Me.btnPeek.UseVisualStyleBackColor = True
        '
        'btnDesapilar
        '
        Me.btnDesapilar.Location = New System.Drawing.Point(473, 115)
        Me.btnDesapilar.Name = "btnDesapilar"
        Me.btnDesapilar.Size = New System.Drawing.Size(115, 40)
        Me.btnDesapilar.TabIndex = 2
        Me.btnDesapilar.Text = "Desapilar"
        Me.btnDesapilar.UseVisualStyleBackColor = True
        '
        'txtDatoPila
        '
        Me.txtDatoPila.Location = New System.Drawing.Point(170, 76)
        Me.txtDatoPila.Name = "txtDatoPila"
        Me.txtDatoPila.Size = New System.Drawing.Size(151, 20)
        Me.txtDatoPila.TabIndex = 1
        '
        'btnApilar
        '
        Me.btnApilar.Location = New System.Drawing.Point(473, 40)
        Me.btnApilar.Name = "btnApilar"
        Me.btnApilar.Size = New System.Drawing.Size(115, 40)
        Me.btnApilar.TabIndex = 0
        Me.btnApilar.Text = "Apilar"
        Me.btnApilar.UseVisualStyleBackColor = True
        '
        'tabColas
        '
        Me.tabColas.AccessibleName = "tabColas"
        Me.tabColas.Controls.Add(Me.txtDatoCola)
        Me.tabColas.Controls.Add(Me.lstResultadoCola)
        Me.tabColas.Controls.Add(Me.btnOrdenarCola)
        Me.tabColas.Controls.Add(Me.btnLimpiarCola)
        Me.tabColas.Controls.Add(Me.btnContarCola)
        Me.tabColas.Controls.Add(Me.btnEstaVaciaCola)
        Me.tabColas.Controls.Add(Me.btnPeekCola)
        Me.tabColas.Controls.Add(Me.btnDesencolar)
        Me.tabColas.Controls.Add(Me.btnEncolar)
        Me.tabColas.Location = New System.Drawing.Point(4, 22)
        Me.tabColas.Name = "tabColas"
        Me.tabColas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabColas.Size = New System.Drawing.Size(768, 351)
        Me.tabColas.TabIndex = 2
        Me.tabColas.Text = "Colas"
        Me.tabColas.UseVisualStyleBackColor = True
        '
        'txtDatoCola
        '
        Me.txtDatoCola.Location = New System.Drawing.Point(168, 61)
        Me.txtDatoCola.Name = "txtDatoCola"
        Me.txtDatoCola.Size = New System.Drawing.Size(164, 20)
        Me.txtDatoCola.TabIndex = 8
        '
        'lstResultadoCola
        '
        Me.lstResultadoCola.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstResultadoCola.HideSelection = False
        Me.lstResultadoCola.Location = New System.Drawing.Point(60, 127)
        Me.lstResultadoCola.Name = "lstResultadoCola"
        Me.lstResultadoCola.Size = New System.Drawing.Size(339, 211)
        Me.lstResultadoCola.TabIndex = 7
        Me.lstResultadoCola.UseCompatibleStateImageBehavior = False
        '
        'btnOrdenarCola
        '
        Me.btnOrdenarCola.Location = New System.Drawing.Point(507, 206)
        Me.btnOrdenarCola.Name = "btnOrdenarCola"
        Me.btnOrdenarCola.Size = New System.Drawing.Size(108, 42)
        Me.btnOrdenarCola.TabIndex = 6
        Me.btnOrdenarCola.Text = "Ordenar Cola"
        Me.btnOrdenarCola.UseVisualStyleBackColor = True
        '
        'btnLimpiarCola
        '
        Me.btnLimpiarCola.Location = New System.Drawing.Point(586, 158)
        Me.btnLimpiarCola.Name = "btnLimpiarCola"
        Me.btnLimpiarCola.Size = New System.Drawing.Size(108, 42)
        Me.btnLimpiarCola.TabIndex = 5
        Me.btnLimpiarCola.Text = "Limpiar Cola"
        Me.btnLimpiarCola.UseVisualStyleBackColor = True
        '
        'btnContarCola
        '
        Me.btnContarCola.Location = New System.Drawing.Point(586, 99)
        Me.btnContarCola.Name = "btnContarCola"
        Me.btnContarCola.Size = New System.Drawing.Size(108, 42)
        Me.btnContarCola.TabIndex = 4
        Me.btnContarCola.Text = "Contar Cola"
        Me.btnContarCola.UseVisualStyleBackColor = True
        '
        'btnEstaVaciaCola
        '
        Me.btnEstaVaciaCola.Location = New System.Drawing.Point(586, 39)
        Me.btnEstaVaciaCola.Name = "btnEstaVaciaCola"
        Me.btnEstaVaciaCola.Size = New System.Drawing.Size(108, 42)
        Me.btnEstaVaciaCola.TabIndex = 3
        Me.btnEstaVaciaCola.Text = "Esta Vacía"
        Me.btnEstaVaciaCola.UseVisualStyleBackColor = True
        '
        'btnPeekCola
        '
        Me.btnPeekCola.Location = New System.Drawing.Point(436, 158)
        Me.btnPeekCola.Name = "btnPeekCola"
        Me.btnPeekCola.Size = New System.Drawing.Size(108, 42)
        Me.btnPeekCola.TabIndex = 2
        Me.btnPeekCola.Text = "Peek"
        Me.btnPeekCola.UseVisualStyleBackColor = True
        '
        'btnDesencolar
        '
        Me.btnDesencolar.Location = New System.Drawing.Point(436, 99)
        Me.btnDesencolar.Name = "btnDesencolar"
        Me.btnDesencolar.Size = New System.Drawing.Size(108, 42)
        Me.btnDesencolar.TabIndex = 1
        Me.btnDesencolar.Text = "Desencolar"
        Me.btnDesencolar.UseVisualStyleBackColor = True
        '
        'btnEncolar
        '
        Me.btnEncolar.Location = New System.Drawing.Point(436, 39)
        Me.btnEncolar.Name = "btnEncolar"
        Me.btnEncolar.Size = New System.Drawing.Size(108, 42)
        Me.btnEncolar.TabIndex = 0
        Me.btnEncolar.Text = "Encolar"
        Me.btnEncolar.UseVisualStyleBackColor = True
        '
        'tabArboles
        '
        Me.tabArboles.AccessibleName = "tabArboles"
        Me.tabArboles.Controls.Add(Me.txtValorArbol)
        Me.tabArboles.Controls.Add(Me.btnPostorden)
        Me.tabArboles.Controls.Add(Me.btnPreorden)
        Me.tabArboles.Controls.Add(Me.btnInorden)
        Me.tabArboles.Controls.Add(Me.btnEliminarArbol)
        Me.tabArboles.Controls.Add(Me.bnInsertarArbol)
        Me.tabArboles.Controls.Add(Me.treeViewArbol)
        Me.tabArboles.Location = New System.Drawing.Point(4, 22)
        Me.tabArboles.Name = "tabArboles"
        Me.tabArboles.Padding = New System.Windows.Forms.Padding(3)
        Me.tabArboles.Size = New System.Drawing.Size(768, 351)
        Me.tabArboles.TabIndex = 3
        Me.tabArboles.Text = "Arboles"
        Me.tabArboles.UseVisualStyleBackColor = True
        '
        'txtValorArbol
        '
        Me.txtValorArbol.Location = New System.Drawing.Point(156, 46)
        Me.txtValorArbol.Name = "txtValorArbol"
        Me.txtValorArbol.Size = New System.Drawing.Size(185, 20)
        Me.txtValorArbol.TabIndex = 6
        '
        'btnPostorden
        '
        Me.btnPostorden.Location = New System.Drawing.Point(532, 178)
        Me.btnPostorden.Name = "btnPostorden"
        Me.btnPostorden.Size = New System.Drawing.Size(104, 47)
        Me.btnPostorden.TabIndex = 5
        Me.btnPostorden.Text = "Postorden"
        Me.btnPostorden.UseVisualStyleBackColor = True
        '
        'btnPreorden
        '
        Me.btnPreorden.Location = New System.Drawing.Point(610, 104)
        Me.btnPreorden.Name = "btnPreorden"
        Me.btnPreorden.Size = New System.Drawing.Size(104, 47)
        Me.btnPreorden.TabIndex = 4
        Me.btnPreorden.Text = "Preorden"
        Me.btnPreorden.UseVisualStyleBackColor = True
        '
        'btnInorden
        '
        Me.btnInorden.Location = New System.Drawing.Point(610, 32)
        Me.btnInorden.Name = "btnInorden"
        Me.btnInorden.Size = New System.Drawing.Size(104, 47)
        Me.btnInorden.TabIndex = 3
        Me.btnInorden.Text = "Inorden"
        Me.btnInorden.UseVisualStyleBackColor = True
        '
        'btnEliminarArbol
        '
        Me.btnEliminarArbol.Location = New System.Drawing.Point(463, 104)
        Me.btnEliminarArbol.Name = "btnEliminarArbol"
        Me.btnEliminarArbol.Size = New System.Drawing.Size(104, 47)
        Me.btnEliminarArbol.TabIndex = 2
        Me.btnEliminarArbol.Text = "Eliminar"
        Me.btnEliminarArbol.UseVisualStyleBackColor = True
        '
        'bnInsertarArbol
        '
        Me.bnInsertarArbol.Location = New System.Drawing.Point(463, 32)
        Me.bnInsertarArbol.Name = "bnInsertarArbol"
        Me.bnInsertarArbol.Size = New System.Drawing.Size(104, 47)
        Me.bnInsertarArbol.TabIndex = 1
        Me.bnInsertarArbol.Text = "Insetar"
        Me.bnInsertarArbol.UseVisualStyleBackColor = True
        '
        'treeViewArbol
        '
        Me.treeViewArbol.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.treeViewArbol.Location = New System.Drawing.Point(47, 104)
        Me.treeViewArbol.Name = "treeViewArbol"
        Me.treeViewArbol.Size = New System.Drawing.Size(360, 223)
        Me.treeViewArbol.TabIndex = 0
        '
        'tabGrafos
        '
        Me.tabGrafos.AccessibleName = "tabGrafos"
        Me.tabGrafos.Controls.Add(Me.txtFinEliminarArista)
        Me.tabGrafos.Controls.Add(Me.label6)
        Me.tabGrafos.Controls.Add(Me.label5)
        Me.tabGrafos.Controls.Add(Me.txtInicioEliminarArista)
        Me.tabGrafos.Controls.Add(Me.btnEliminarArista)
        Me.tabGrafos.Controls.Add(Me.label4)
        Me.tabGrafos.Controls.Add(Me.btnEliminarVertice)
        Me.tabGrafos.Controls.Add(Me.txtVerticeEliminar)
        Me.tabGrafos.Controls.Add(Me.pictureBoxGrafo)
        Me.tabGrafos.Controls.Add(Me.label3)
        Me.tabGrafos.Controls.Add(Me.label2)
        Me.tabGrafos.Controls.Add(Me.txtFinArista)
        Me.tabGrafos.Controls.Add(Me.txtInicioArista)
        Me.tabGrafos.Controls.Add(Me.btnAgregarArista)
        Me.tabGrafos.Controls.Add(Me.label1)
        Me.tabGrafos.Controls.Add(Me.btnAgregarVertice)
        Me.tabGrafos.Controls.Add(Me.txtVertice)
        Me.tabGrafos.Location = New System.Drawing.Point(4, 22)
        Me.tabGrafos.Name = "tabGrafos"
        Me.tabGrafos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGrafos.Size = New System.Drawing.Size(768, 351)
        Me.tabGrafos.TabIndex = 4
        Me.tabGrafos.Text = "Grafos"
        Me.tabGrafos.UseVisualStyleBackColor = True
        '
        'txtFinEliminarArista
        '
        Me.txtFinEliminarArista.Location = New System.Drawing.Point(493, 103)
        Me.txtFinEliminarArista.Name = "txtFinEliminarArista"
        Me.txtFinEliminarArista.Size = New System.Drawing.Size(147, 20)
        Me.txtFinEliminarArista.TabIndex = 16
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(387, 103)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(89, 13)
        Me.label6.TabIndex = 15
        Me.label6.Text = "Eliminar Fin Arista"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(387, 70)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(100, 13)
        Me.label5.TabIndex = 14
        Me.label5.Text = "Eliminar Inicio Arista"
        '
        'txtInicioEliminarArista
        '
        Me.txtInicioEliminarArista.Location = New System.Drawing.Point(493, 67)
        Me.txtInicioEliminarArista.Name = "txtInicioEliminarArista"
        Me.txtInicioEliminarArista.Size = New System.Drawing.Size(147, 20)
        Me.txtInicioEliminarArista.TabIndex = 13
        '
        'btnEliminarArista
        '
        Me.btnEliminarArista.Location = New System.Drawing.Point(646, 73)
        Me.btnEliminarArista.Name = "btnEliminarArista"
        Me.btnEliminarArista.Size = New System.Drawing.Size(116, 43)
        Me.btnEliminarArista.TabIndex = 12
        Me.btnEliminarArista.Text = "Eliminar Arista"
        Me.btnEliminarArista.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(387, 21)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(79, 13)
        Me.label4.TabIndex = 11
        Me.label4.Text = "Eliminar Vertice"
        '
        'btnEliminarVertice
        '
        Me.btnEliminarVertice.Location = New System.Drawing.Point(636, 5)
        Me.btnEliminarVertice.Name = "btnEliminarVertice"
        Me.btnEliminarVertice.Size = New System.Drawing.Size(116, 43)
        Me.btnEliminarVertice.TabIndex = 10
        Me.btnEliminarVertice.Text = "Eliminar Vertice"
        Me.btnEliminarVertice.UseVisualStyleBackColor = True
        '
        'txtVerticeEliminar
        '
        Me.txtVerticeEliminar.Location = New System.Drawing.Point(472, 17)
        Me.txtVerticeEliminar.Name = "txtVerticeEliminar"
        Me.txtVerticeEliminar.Size = New System.Drawing.Size(147, 20)
        Me.txtVerticeEliminar.TabIndex = 9
        '
        'pictureBoxGrafo
        '
        Me.pictureBoxGrafo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pictureBoxGrafo.Location = New System.Drawing.Point(9, 132)
        Me.pictureBoxGrafo.Name = "pictureBoxGrafo"
        Me.pictureBoxGrafo.Size = New System.Drawing.Size(743, 213)
        Me.pictureBoxGrafo.TabIndex = 8
        Me.pictureBoxGrafo.TabStop = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 80)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(65, 13)
        Me.label3.TabIndex = 7
        Me.label3.Text = "Fin de Arista"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 47)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(76, 13)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Inicio de Arista"
        '
        'txtFinArista
        '
        Me.txtFinArista.Location = New System.Drawing.Point(77, 77)
        Me.txtFinArista.Name = "txtFinArista"
        Me.txtFinArista.Size = New System.Drawing.Size(147, 20)
        Me.txtFinArista.TabIndex = 5
        '
        'txtInicioArista
        '
        Me.txtInicioArista.Location = New System.Drawing.Point(88, 44)
        Me.txtInicioArista.Name = "txtInicioArista"
        Me.txtInicioArista.Size = New System.Drawing.Size(147, 20)
        Me.txtInicioArista.TabIndex = 4
        '
        'btnAgregarArista
        '
        Me.btnAgregarArista.Location = New System.Drawing.Point(271, 55)
        Me.btnAgregarArista.Name = "btnAgregarArista"
        Me.btnAgregarArista.Size = New System.Drawing.Size(116, 43)
        Me.btnAgregarArista.TabIndex = 3
        Me.btnAgregarArista.Text = "Agregar Arista"
        Me.btnAgregarArista.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Vertice"
        '
        'btnAgregarVertice
        '
        Me.btnAgregarVertice.Location = New System.Drawing.Point(271, 6)
        Me.btnAgregarVertice.Name = "btnAgregarVertice"
        Me.btnAgregarVertice.Size = New System.Drawing.Size(116, 43)
        Me.btnAgregarVertice.TabIndex = 1
        Me.btnAgregarVertice.Text = "Agregar Vertice"
        Me.btnAgregarVertice.UseVisualStyleBackColor = True
        '
        'txtVertice
        '
        Me.txtVertice.Location = New System.Drawing.Point(52, 14)
        Me.txtVertice.Name = "txtVertice"
        Me.txtVertice.Size = New System.Drawing.Size(147, 20)
        Me.txtVertice.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tabControl1.ResumeLayout(False)
        Me.tabListas.ResumeLayout(False)
        Me.tabListas.PerformLayout()
        Me.tabPilas.ResumeLayout(False)
        Me.tabPilas.PerformLayout()
        Me.tabColas.ResumeLayout(False)
        Me.tabColas.PerformLayout()
        Me.tabArboles.ResumeLayout(False)
        Me.tabArboles.PerformLayout()
        Me.tabGrafos.ResumeLayout(False)
        Me.tabGrafos.PerformLayout()
        CType(Me.pictureBoxGrafo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabListas As TabPage
    Private WithEvents btnLimpiar As Button
    Private WithEvents btnOrdenar As Button
    Private WithEvents btnMostrar As Button
    Private WithEvents btnEliminar As Button
    Private WithEvents btnInsertar As Button
    Private WithEvents lstResultado As ListBox
    Private WithEvents txtDato As TextBox
    Private WithEvents tabPilas As TabPage
    Private WithEvents btnClonarPila As Button
    Private WithEvents lstResultadoPila As ListView
    Private WithEvents btnLimpiarPila As Button
    Private WithEvents btnContarPila As Button
    Private WithEvents btnEstaVacia As Button
    Private WithEvents btnPeek As Button
    Private WithEvents btnDesapilar As Button
    Private WithEvents txtDatoPila As TextBox
    Private WithEvents btnApilar As Button
    Private WithEvents tabColas As TabPage
    Private WithEvents txtDatoCola As TextBox
    Private WithEvents lstResultadoCola As ListView
    Private WithEvents btnOrdenarCola As Button
    Private WithEvents btnLimpiarCola As Button
    Private WithEvents btnContarCola As Button
    Private WithEvents btnEstaVaciaCola As Button
    Private WithEvents btnPeekCola As Button
    Private WithEvents btnDesencolar As Button
    Private WithEvents btnEncolar As Button
    Private WithEvents tabArboles As TabPage
    Private WithEvents txtValorArbol As TextBox
    Private WithEvents btnPostorden As Button
    Private WithEvents btnPreorden As Button
    Private WithEvents btnInorden As Button
    Private WithEvents btnEliminarArbol As Button
    Private WithEvents bnInsertarArbol As Button
    Private WithEvents treeViewArbol As TreeView
    Private WithEvents tabGrafos As TabPage
    Private WithEvents txtFinEliminarArista As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents txtInicioEliminarArista As TextBox
    Private WithEvents btnEliminarArista As Button
    Private WithEvents label4 As Label
    Private WithEvents btnEliminarVertice As Button
    Private WithEvents txtVerticeEliminar As TextBox
    Private WithEvents pictureBoxGrafo As PictureBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents txtFinArista As TextBox
    Private WithEvents txtInicioArista As TextBox
    Private WithEvents btnAgregarArista As Button
    Private WithEvents label1 As Label
    Private WithEvents btnAgregarVertice As Button
    Private WithEvents txtVertice As TextBox
End Class
