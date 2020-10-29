Imports MySql.Data.MySqlClient
'Imports TrabajoFinalProgramacion
'Imports System.Data.OleDb
Public Class FormListadoClientes

    Private vista As New DataView
    Public Property accion As Boolean
    Public Property idFila As String

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dgvListado.RowHeadersVisible = False

        CargaInicial()
    End Sub
    Public Sub CargaInicial()
        'dgvListado.RowHeadersVisible = False

        Conectarse()
        FormInicio.mydbDataSet.Tables("Cliente").Clear()
        FormInicio.clienteDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM cliente", Conexion)
        FormInicio.clienteDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        FormInicio.clienteDataAdapter.Fill(FormInicio.mydbDataSet.Tables("Cliente"))
        vista = FormInicio.mydbDataSet.Tables("Cliente").DefaultView
        dgvListado.DataSource = vista
        dgvListado.Columns(0).Visible = False
        dgvListado.ClearSelection()
        Desconectarse()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        accion = True
        FormCliente.ShowDialog()
        'FormInicio.AbrirFormEnPanel(New FormCliente)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        idFila = dgvListado.CurrentRow.Cells(0).Value
        FormCliente.tbNombre.Text = dgvListado.CurrentRow.Cells(1).Value
        FormCliente.tbApellido.Text = dgvListado.CurrentRow.Cells(2).Value
        FormCliente.tbDni.Text = dgvListado.CurrentRow.Cells(3).Value
        FormCliente.tbEdad.Text = dgvListado.CurrentRow.Cells(4).Value
        FormCliente.tbDireccion.Text = dgvListado.CurrentRow.Cells(5).Value
        FormCliente.tbTelefono.Text = dgvListado.CurrentRow.Cells(6).Value




        accion = False
        FormCliente.ShowDialog()
        'FormInicio.AbrirFormEnPanel(New FormCliente)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        If (MessageBox.Show("Está seguro de borrar este cliente?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            Try
                FormInicio.mydbDataSet.Tables("cliente").Rows.Find(idFila).Delete()
                FormInicio.clienteDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM cliente WHERE id= @id", Conexion)
                FormInicio.clienteDataAdapter.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "id")
                FormInicio.clienteDataAdapter.Update(FormInicio.mydbDataSet.Tables("cliente"))

            Catch ex As Exception
                MsgBox(ex)
                MsgBox("No se puede borrar porque el cliente tiene ventas relacionadas")
            End Try
        End If
        dgvListado.CurrentCell = dgvListado.Rows(0).Cells(1)
        idFila = dgvListado.CurrentRow.Cells(0).Value

    End Sub
    Private Sub dgvListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellClick
        dgvListado.Columns(0).Visible = False

    End Sub
    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
        vista.RowFilter = cbBuscarCampo.Text & " LIKE '" + tbBuscar.Text + "%'"
    End Sub
    Private Sub dgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        FormNyAclientes.ShowDialog()
    End Sub
End Class