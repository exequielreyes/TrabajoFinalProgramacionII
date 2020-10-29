'Public Class FormVentas
'    Private dataReader As MySqlDataReader
'    Private cmd As MySqlCommand
'    Private nuevaFactura As Boolean = True
'    Private tablaDetalle As New DataTable
'    Private duplicado As Boolean
'    Private total As Single

'    Public Property idCliente As Integer
'    Public Property idProducto As Integer
'    Public Property idFactura As Integer

'    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub

'    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
'        FormListadoClientes.ShowDialog()
'    End Sub

'    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
'        'tbTotal.Enabled = False
'        'Crea una nueva factura a donde agregar items (productos) sino hay una'
'        If nuevaFactura Then
'            AgregarFactura()
'        End If
'        'verifica si hay stock de ese producto'
'        If Convert.ToInt32(tbStock.Text) >= Convert.ToInt32(tbCantidad.Text) Then

'            'Añade en la tabla detalle un nuevo item o producto
'            AgregarItemDetalle()

'            tbCantidad.Text = 1
'            tbDescripcion.Text = ""
'            tbStock.Text = ""
'            tbPrecioUnitario.Text = ""

'            dgvDetalle.DataSource = tablaDetalle
'            dgvDetalle.Columns(0).Visible = False
'            dgvDetalle.Columns(1).Visible = False
'            dgvDetalle.ClearSelection()

'            CalcularTotal()
'            btnAgregar.Enabled = False
'        Else
'            MsgBox("No posee el stock suficiente de este producto.",, "Aviso")
'        End If
'    End Sub
'End Class