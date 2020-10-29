Imports MySql.Data.MySqlClient
Public Class FormNyAclientes

    Private vista As New DataView
    Public Property accion As Boolean
    Public Property idFila As String

    Private Sub FormNyAclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
        idFila = FormListadoClientes.dgvListado.CurrentRow.Cells(0).Value
        tbNombre.Text = FormListadoClientes.dgvListado.CurrentRow.Cells(1).Value
        tbApellido.Text = FormListadoClientes.dgvListado.CurrentRow.Cells(2).Value
        'FormCliente.PictureBox1

        If FormListadoClientes.accion Then
            'cbMembresia.Text = ""
            lblPrecio.Text = ""
            'lblMeses.Text = ""
            dtpFechaInicio.ResetText()
            tbHora.Text = ""

            Me.Text = "Nuevo Cliente"
        Else
            Me.Text = "Editar Cliente"
        End If

        If FormListadoClientes.accion Then
            cbPatologia.Text = ""
            rbEspecificar.Text = ""

            Me.Text = "Nuevo Cliente"
        Else
            Me.Text = "Editar Cliente"
        End If




        'tbDNI.Text = FormListadoClientes.dgvListado.CurrentRow.Cells(3).Value
        'tbEdad.Text = FormListadoClientes.dgvListado.CurrentRow.Cells(4).Value
        'tbDireccion.Text = FormListadoClientes.dgvListado.CurrentRow.Cells(5).Value
        'tbTelefono.Text = FormListadoClientes.dgvListado.CurrentRow.Cells(6).Value
        'tbAltura.Text = FormListadoClientes.dgvListado.CurrentRow.Cells(7).Value
        'tbPeso.Text = FormListadoClientes.dgvListado.CurrentRow.Cells(8).Value
        'tbFactor.Text = FormListadoClientes.dgvListado.CurrentRow.Cells(9).Value
        ''FormCliente.cbPatologia.Text = dgvListado.CurrentRow.Cells(10).Value
        'tbPatologia.Text = FormListadoClientes.dgvListado.CurrentRow.Cells(10).Value
        'tbTurno.Text = FormListadoClientes.dgvListado.CurrentRow.Cells(11).Value
        'tbClases.Text = FormListadoClientes.dgvListado.CurrentRow.Cells(12).Value
        'accion = False
    End Sub
    Public Sub CargaInicial()
        'dgvListado.RowHeadersVisible = False

        Conectarse()
        FormInicio.pilatesgymDataSet.Tables("turno").Clear()
        FormInicio.turnoDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM turno", Conexion)
        FormInicio.turnoDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        FormInicio.turnoDataAdapter.Fill(FormInicio.pilatesgymDataSet.Tables("turno"))
        vista = FormInicio.pilatesgymDataSet.Tables("turno").DefaultView
        dgvListado2.DataSource = vista
        dgvListado2.Columns(0).Visible = False
        dgvListado2.ClearSelection()



        FormInicio.pilatesgymDataSet.Tables("historia clinica").Clear()
        FormInicio.historiaclinicaDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM historia_clinica", Conexion)
        FormInicio.historiaclinicaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        FormInicio.historiaclinicaDataAdapter.Fill(FormInicio.pilatesgymDataSet.Tables("historia clinica"))
        vista = FormInicio.pilatesgymDataSet.Tables("historia clinica").DefaultView
        dgvListado3.DataSource = vista
        dgvListado3.Columns(0).Visible = False
        dgvListado3.ClearSelection()


        Desconectarse()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fila As DataRow
        Dim consulta As String

        'Try
        If FormListadoClientes.accion = True Then
            '1. Crear una nueva fila'
            fila = FormInicio.pilatesgymDataSet.Tables("turno").NewRow

            '2. Rellenar la fila con información
            'fila("cantidad") = cbMembresia.Text
            fila("precio") = lblPrecio.Text
            'fila("meses") = lblMeses.Text
            fila("fecha") = dtpFechaInicio.Text
                fila("hora") = tbHora.Text


            '3. Agregar fila a la tabla del DataSet
            FormInicio.pilatesgymDataSet.Tables("turno").Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva

            consulta = "INSERT INTO turno (cantidad,precio,meses,fecha,hora) VALUES ( @cant,@pre,@mes,@fec,@hor)"

                FormInicio.turnoDataAdapter.InsertCommand = New MySqlCommand(consulta, Conexion)
                FormInicio.turnoDataAdapter.InsertCommand.Parameters.Add("@cant", MySqlDbType.Int32, 0, "cantidad")
                FormInicio.turnoDataAdapter.InsertCommand.Parameters.Add("@pre", MySqlDbType.Decimal, 11, "precio")
                FormInicio.turnoDataAdapter.InsertCommand.Parameters.Add("@mes", MySqlDbType.VarChar, 20, "meses")
                FormInicio.turnoDataAdapter.InsertCommand.Parameters.Add("@fec", MySqlDbType.DateTime, 0, "fecha")
                FormInicio.turnoDataAdapter.InsertCommand.Parameters.Add("@hor", MySqlDbType.Int32, 0, "hora")




            '5. Guardar los cambios en la base de datos
            FormInicio.turnoDataAdapter.Update(FormInicio.pilatesgymDataSet.Tables("turno"))


            '6. Actualiza la tabla del formulario listado de clientes
            FormListadoClientes.CargaInicial()

            'Limpiamos los textbox para poder cargar otro cliente            
            'cbMembresia.Text = ""
            lblPrecio.Text = ""
            'lblMeses.Text = ""
            dtpFechaInicio.ResetText()
                tbHora.Text = ""


            Else
            '1. Seleccionar fila a editar
            fila = FormInicio.pilatesgymDataSet.Tables("turno").Rows.Find(FormListadoClientes.idFila)


            '2. Rellenar la fila con información   
            'fila("cantidad") = cbMembresia.Text
            fila("precio") = lblPrecio.Text
            'fila("meses") = lblMeses.Text
            fila("fecha") = dtpFechaInicio.Text
                fila("hora") = tbHora.Text

            '3. Crear Comando para modificar la fila en la BD

            consulta = "UPDATE turno SET cantidad=@cant, precio=@pre, meses=@mes, fecha=@fec, hora =@hor WHERE idTurno=@id"
                FormInicio.turnoDataAdapter.UpdateCommand = New MySqlCommand(consulta, Conexion)
                FormInicio.turnoDataAdapter.UpdateCommand.Parameters.Add("@cant", MySqlDbType.Int32, 0, "cantidad")
                FormInicio.turnoDataAdapter.UpdateCommand.Parameters.Add("@pre", MySqlDbType.Decimal, 11, "precio")
                FormInicio.turnoDataAdapter.UpdateCommand.Parameters.Add("@mes", MySqlDbType.Int32, 0, "meses")
                FormInicio.turnoDataAdapter.UpdateCommand.Parameters.Add("@fec", MySqlDbType.DateTime, 0, "fecha")
                FormInicio.turnoDataAdapter.UpdateCommand.Parameters.Add("@hor", MySqlDbType.Int32, 0, "hora")


                FormInicio.turnoDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "idTurno")

            '4. Guardar los cambios en la base de datos
            FormInicio.turnoDataAdapter.Update(FormInicio.pilatesgymDataSet.Tables("turno"))


            '5. Actualiza la tabla del formulario listado de clientes
            FormListadoClientes.CargaInicial()
                Me.Close()


            End If
        'Catch ex As Exception
        '    MsgBox("Error espacio en blanco", MsgBoxStyle.Critical)

        'End Try
    End Sub

    'Private Sub cbMembresia_SelectedIndexChanged(sender As Object, e As EventArgs)

    '    If cbMembresia.Text = "Mensual" Then

    '        'lblPrecio.Text = "320"
    '        lblMeses.Text = "1"

    '    Else
    '        cbMembresia.Text = "Bimensual"
    '        'lblPrecio.Text = "640"
    '        lblMeses.Text = "2"

    '    End If
    'End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPatologia.SelectedIndexChanged

        If cbPatologia.Text = "Si" Then
            rbEspecificar.Enabled = True
            cbColumna.Enabled = True
            cbCardiaco.Enabled = True
            cbLesiones.Enabled = True
        Else
            cbPatologia.Text = "No"
            rbEspecificar.Enabled = False
            cbColumna.Enabled = False
            cbCardiaco.Enabled = False
            cbLesiones.Enabled = False
        End If
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim fila As DataRow
        Dim consulta As String

        'Try
        If FormListadoClientes.accion = True Then
            '1. Crear una nueva fila'
            fila = FormInicio.pilatesgymDataSet.Tables("historia clinica").NewRow

            '2. Rellenar la fila con información
            fila("patologia") = cbPatologia.Text
            fila("especificaciones") = rbEspecificar.Text



            '3. Agregar fila a la tabla del DataSet
            FormInicio.pilatesgymDataSet.Tables("historia_clinica").Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva

            consulta = "INSERT INTO historia_clinica (patologia, especificaciones) VALUES ( @pat,@esp)"

            FormInicio.historiaclinicaDataAdapter.InsertCommand = New MySqlCommand(consulta, Conexion)
            FormInicio.historiaclinicaDataAdapter.InsertCommand.Parameters.Add("@pat", MySqlDbType.VarChar, 45, "patologia")
            FormInicio.historiaclinicaDataAdapter.InsertCommand.Parameters.Add("@esp", MySqlDbType.VarChar, 100, "especificaciones")




            '5. Guardar los cambios en la base de datos
            FormInicio.historiaclinicaDataAdapter.Update(FormInicio.pilatesgymDataSet.Tables("historia clinica"))


            '6. Actualiza la tabla del formulario listado de clientes
            FormListadoClientes.CargaInicial()

            'Limpiamos los textbox para poder cargar otro cliente            
            cbPatologia.Text = ""
            rbEspecificar.Text = ""


        Else
            '1. Seleccionar fila a editar
            fila = FormInicio.pilatesgymDataSet.Tables("historia clinica").Rows.Find(FormListadoClientes.idFila)


            '2. Rellenar la fila con información   
            fila("patologia") = cbPatologia.Text
            fila("especificaciones") = rbEspecificar.Text


            '3. Crear Comando para modificar la fila en la BD

            consulta = "UPDATE historia_clinica SET patologia=@pat, especificaciones=@esp WHERE id=@id"
            FormInicio.historiaclinicaDataAdapter.UpdateCommand = New MySqlCommand(consulta, Conexion)
            FormInicio.historiaclinicaDataAdapter.UpdateCommand.Parameters.Add("@pat", MySqlDbType.VarChar, 45, "patologia")
            FormInicio.historiaclinicaDataAdapter.UpdateCommand.Parameters.Add("@esp", MySqlDbType.VarChar, 100, "especificaciones")

            FormInicio.historiaclinicaDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "idTurno")

            '4. Guardar los cambios en la base de datos
            FormInicio.historiaclinicaDataAdapter.Update(FormInicio.pilatesgymDataSet.Tables("historia clinica"))


            '5. Actualiza la tabla del formulario listado de clientes
            FormListadoClientes.CargaInicial()
            Me.Close()


        End If
        'Catch ex As Exception
        '    MsgBox("Error espacio en blanco", MsgBoxStyle.Critical)

        'End Try

    End Sub


    Private Sub cbMeses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMeses.SelectedIndexChanged
        If cbMeses.Text = "1 mes" Then
            lblPrecio.Text = "400"
        ElseIf cbMeses.Text = "2 meses" Then
            lblPrecio.Text = "800"

        ElseIf cbMeses.Text = "3 meses" Then
            lblPrecio.Text = "1200"
        End If
    End Sub




    Private Sub RbsemanaDos_CheckedChanged(sender As Object, e As EventArgs) Handles RbsemanaDos.CheckedChanged
        '-----------1 mes---------'
        If cbMeses.Text = "1 mes" Then
            If RbsemanaDos.Text = RbsemanaDos.Text Then
                lblTotal.Text = "400"
            End If
        End If

        '-----------2 meses---------'

        If cbMeses.Text = "2 meses" Then
            If RbsemanaDos.Text = RbsemanaDos.Text Then
                lblTotal.Text = "800"
            End If
        End If

        '-----------------3 meses--------------'
        If cbMeses.Text = "3 meses" Then
            If RbsemanaDos.Text = RbsemanaDos.Text Then
                lblTotal.Text = "1200"
            End If
        End If

    End Sub

    Private Sub rbsemanaTres_CheckedChanged(sender As Object, e As EventArgs) Handles rbsemanaTres.CheckedChanged
        '-----------1 mes---------'
        If cbMeses.Text = "1 mes" Then
            If rbsemanaTres.Text = rbsemanaTres.Text Then
                lblTotal.Text = "450"
            End If
        End If
        '-----------2 meses---------'

        If cbMeses.Text = "2 meses" Then
            If RbsemanaDos.Text = RbsemanaDos.Text Then
                lblTotal.Text = "850"
            End If
        End If

        '-----------------3 meses--------------'
        If cbMeses.Text = "3 meses" Then
            If RbsemanaDos.Text = RbsemanaDos.Text Then
                lblTotal.Text = "1250"
            End If
        End If
    End Sub

    Private Sub rbSemanaCuatro_CheckedChanged(sender As Object, e As EventArgs) Handles rbSemanaCuatro.CheckedChanged
        '-----------1 mes---------'
        If cbMeses.Text = "1 mes" Then
            If rbsemanaTres.Text = rbsemanaTres.Text Then
                lblTotal.Text = "500"
            End If
        End If
        '-----------2 meses---------'

        If cbMeses.Text = "2 meses" Then
            If RbsemanaDos.Text = RbsemanaDos.Text Then
                lblTotal.Text = "900"
            End If
        End If

        '-----------------3 meses--------------'
        If cbMeses.Text = "3 meses" Then
            If RbsemanaDos.Text = RbsemanaDos.Text Then
                lblTotal.Text = "1300"
            End If
        End If

    End Sub

End Class