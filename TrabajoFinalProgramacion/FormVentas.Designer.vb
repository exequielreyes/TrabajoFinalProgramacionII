<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.BtnBuscarProducto = New System.Windows.Forms.Button()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbStock = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbApellidoNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(193, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 34)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Listado de Factura"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.Location = New System.Drawing.Point(492, 414)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(118, 34)
        Me.btnImprimir.TabIndex = 32
        Me.btnImprimir.Text = "Imprimir Factura"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(515, 383)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(95, 20)
        Me.tbTotal.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(467, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "TOTAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(190, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Doble click para quitar el producto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMenos)
        Me.GroupBox2.Controls.Add(Me.btnMas)
        Me.GroupBox2.Controls.Add(Me.BtnBuscarProducto)
        Me.GroupBox2.Controls.Add(Me.tbCantidad)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbPrecioUnitario)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tbStock)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbDescripcion)
        Me.GroupBox2.Location = New System.Drawing.Point(193, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(417, 132)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'btnMenos
        '
        Me.btnMenos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMenos.Location = New System.Drawing.Point(248, 92)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(39, 34)
        Me.btnMenos.TabIndex = 28
        Me.btnMenos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'btnMas
        '
        Me.btnMas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMas.Location = New System.Drawing.Point(206, 92)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(39, 34)
        Me.btnMas.TabIndex = 27
        Me.btnMas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMas.UseVisualStyleBackColor = True
        '
        'BtnBuscarProducto
        '
        Me.BtnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarProducto.Location = New System.Drawing.Point(356, 39)
        Me.BtnBuscarProducto.Name = "BtnBuscarProducto"
        Me.BtnBuscarProducto.Size = New System.Drawing.Size(30, 34)
        Me.BtnBuscarProducto.TabIndex = 26
        Me.BtnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarProducto.UseVisualStyleBackColor = True
        '
        'tbCantidad
        '
        Me.tbCantidad.Location = New System.Drawing.Point(147, 101)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.Size = New System.Drawing.Size(53, 20)
        Me.tbCantidad.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(147, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Cantidad"
        '
        'tbPrecioUnitario
        '
        Me.tbPrecioUnitario.Location = New System.Drawing.Point(68, 101)
        Me.tbPrecioUnitario.Name = "tbPrecioUnitario"
        Me.tbPrecioUnitario.Size = New System.Drawing.Size(73, 20)
        Me.tbPrecioUnitario.TabIndex = 22
        '
        'btnAgregar
        '
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.Location = New System.Drawing.Point(293, 92)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(110, 34)
        Me.btnAgregar.TabIndex = 16
        Me.btnAgregar.Text = "Añadir Producto"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Precio Unitario"
        '
        'tbStock
        '
        Me.tbStock.BackColor = System.Drawing.Color.White
        Me.tbStock.Enabled = False
        Me.tbStock.Location = New System.Drawing.Point(6, 101)
        Me.tbStock.Name = "tbStock"
        Me.tbStock.Size = New System.Drawing.Size(56, 20)
        Me.tbStock.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Descripcion"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescripcion.Location = New System.Drawing.Point(7, 45)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(343, 21)
        Me.tbDescripcion.TabIndex = 1
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(193, 258)
        Me.dgvDetalle.MultiSelect = False
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(417, 115)
        Me.dgvDetalle.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbDNI)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbApellidoNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(193, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 89)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(356, 39)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(30, 34)
        Me.BtnBuscarCliente.TabIndex = 24
        Me.BtnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Apellido y Nombre"
        '
        'tbDNI
        '
        Me.tbDNI.Location = New System.Drawing.Point(7, 45)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.Size = New System.Drawing.Size(100, 20)
        Me.tbDNI.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DNI/CUIT"
        '
        'tbApellidoNombre
        '
        Me.tbApellidoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellidoNombre.Location = New System.Drawing.Point(118, 45)
        Me.tbApellidoNombre.Name = "tbApellidoNombre"
        Me.tbApellidoNombre.Size = New System.Drawing.Size(232, 21)
        Me.tbApellidoNombre.TabIndex = 1
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 464)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormVentas"
        Me.Text = "FormVentas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnMas As Button
    Friend WithEvents BtnBuscarProducto As Button
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbPrecioUnitario As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbStock As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbDNI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbApellidoNombre As TextBox
End Class
