Imports MySql.Data.MySqlClient
Imports System.IO

'Imports System.Runtime.InteropServices
Public Class FormCliente

    Public sRuta As String
    Dim Conexion As New MySqlConnection("Server = localhost; Database = mydb; user= root; password = exequielmumia;")


    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If FormListadoClientes.accion Then
            tbNombre.Text = ""
            tbApellido.Text = ""
            tbDni.Text = ""
            tbEdad.Text = ""
            tbDireccion.Text = ""
            tbTelefono.Text = ""
            PictureBox1.Refresh()
            pbFoto.Refresh()



            Me.Text = "Nuevo Cliente"
        Else
            Me.Text = "Editar Cliente"
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim fila As DataRow
        Dim consulta As String

        'Try
        If FormListadoClientes.accion = True Then
            '1. Crear una nueva fila'
            fila = FormInicio.pilatesgymDataSet.Tables("Alumno").NewRow

            '2. Rellenar la fila con información
            fila("nombre") = tbNombre.Text
            fila("apellido") = tbApellido.Text
            fila("dni") = tbDni.Text
            fila("edad") = tbEdad.Text
            fila("direccion") = tbDireccion.Text
            fila("telefono") = tbTelefono.Text
            fila("nombreqr") = PictureBox1.Image
            fila("foto") = pbFoto.Image


            '3. Agregar fila a la tabla del DataSet
            FormInicio.pilatesgymDataSet.Tables("alumno").Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva

            consulta = "INSERT INTO alumno (nombre, apellido,dni, edad, direccion ,telefono,nombreqr,foto) VALUES ( @nom, @ape,@dni, @ed,@dir,@tel,@qr,@fot)"
            FormInicio.alumnoDataAdapter.InsertCommand = New MySqlCommand(consulta, Conexion)
            FormInicio.alumnoDataAdapter.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45, "nombre")
            FormInicio.alumnoDataAdapter.InsertCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 45, "apellido")
            FormInicio.alumnoDataAdapter.InsertCommand.Parameters.Add("@dni", MySqlDbType.Int32, 0, "dni")
            FormInicio.alumnoDataAdapter.InsertCommand.Parameters.Add("@ed", MySqlDbType.Int32, 0, "edad")
            FormInicio.alumnoDataAdapter.InsertCommand.Parameters.Add("@dir", MySqlDbType.VarChar, 100, "direccion")
            FormInicio.alumnoDataAdapter.InsertCommand.Parameters.Add("@tel", MySqlDbType.VarChar, 20, "telefono")
            FormInicio.alumnoDataAdapter.InsertCommand.Parameters.Add("@qr", MySqlDbType.Blob, "nombreqr")
            FormInicio.alumnoDataAdapter.InsertCommand.Parameters.Add("@fot", MySqlDbType.Blob, "foto")



            '5. Guardar los cambios en la base de datos
            FormInicio.alumnoDataAdapter.Update(FormInicio.pilatesgymDataSet.Tables("alumno"))


            '6. Actualiza la tabla del formulario listado de clientes
            FormListadoClientes.CargaInicial()

            'Limpiamos los textbox para poder cargar otro cliente            
            tbNombre.Text = ""
            tbApellido.Text = ""
            tbDni.Text = ""
            tbEdad.Text = ""
            tbDireccion.Text = ""
            tbTelefono.Text = ""
            PictureBox1.Refresh()
            pbFoto.Refresh()


        Else
            '1. Seleccionar fila a editar
            fila = FormInicio.pilatesgymDataSet.Tables("alumno").Rows.Find(FormListadoClientes.idFila)



            '2. Rellenar la fila con información   
            fila("Nombre") = tbNombre.Text
            fila("apellido") = tbApellido.Text
            fila("dni") = tbDni.Text
            fila("edad") = tbEdad.Text
            fila("direccion") = tbDireccion.Text
            fila("telefono") = tbTelefono.Text
            fila("nombreqr") = PictureBox1.Image
            fila("foto") = pbFoto.Image


            '3. Crear Comando para modificar la fila en la BD

            consulta = "UPDATE alumno SET nombre=@nom, apellido=@ape, dni=@dni ,edad=@ed, direccion =@dir, telefono=@tel, nombreqr=@qr , foto=@fot   WHERE id_alumno=@id"
            FormInicio.alumnoDataAdapter.UpdateCommand = New MySqlCommand(consulta, Conexion)
            FormInicio.alumnoDataAdapter.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45, "nombre")
            FormInicio.alumnoDataAdapter.UpdateCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 45, "apellido")
            FormInicio.alumnoDataAdapter.UpdateCommand.Parameters.Add("@dni", MySqlDbType.Int32, 0, "dni")
            FormInicio.alumnoDataAdapter.UpdateCommand.Parameters.Add("@ed", MySqlDbType.Int32, 0, "edad")
            FormInicio.alumnoDataAdapter.UpdateCommand.Parameters.Add("@dir", MySqlDbType.VarChar, 100, "direccion")
            FormInicio.alumnoDataAdapter.UpdateCommand.Parameters.Add("@tel", MySqlDbType.Int32, 11, "telefono")
            FormInicio.alumnoDataAdapter.UpdateCommand.Parameters.Add("@qr", MySqlDbType.Blob, "nombreqr")
            FormInicio.alumnoDataAdapter.UpdateCommand.Parameters.Add("@fot", MySqlDbType.Blob, "foto")

            FormInicio.alumnoDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "id_alumno")

            '4. Guardar los cambios en la base de datos
            FormInicio.alumnoDataAdapter.Update(FormInicio.pilatesgymDataSet.Tables("alumno"))


            '5. Actualiza la tabla del formulario listado de clientes
            FormListadoClientes.CargaInicial()
            Me.Close()
        End If
        'Catch ex As Exception
        '    MsgBox("Error espacio en blanco", MsgBoxStyle.Critical)

        'End Try
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            Dim img As New Bitmap(PictureBox1.Image)
            img.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs)
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub tbNombre_TextChanged(sender As Object, e As EventArgs) Handles tbNombre.TextChanged
        Try
            PictureBox1.Image = QR_Generator.Encode(tbNombre.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbApellido_TextChanged(sender As Object, e As EventArgs) Handles tbApellido.TextChanged
        Try
            PictureBox1.Image = QR_Generator.Encode(tbApellido.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbDNI_TextChanged(sender As Object, e As EventArgs)
        Try
            PictureBox1.Image = QR_Generator.Encode(tbDni.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbEdad_TextChanged(sender As Object, e As EventArgs) Handles tbEdad.TextChanged
        Try
            PictureBox1.Image = QR_Generator.Encode("Nombre:" & tbNombre.Text & vbCrLf & "Apellido:" & tbApellido.Text & vbCrLf & "Dni: " & tbDni.Text & vbCrLf & "Edad:" & tbEdad.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub pbFoto_Click(sender As Object, e As EventArgs) Handles pbFoto.Click
        FormFoto.Show()


    End Sub


    Private Sub cmdcamara_Click(sender As Object, e As EventArgs) Handles cmdcamara.Click
        web.OpenPreviewWindowCliente()
        cmdcamara.Enabled = False

    End Sub

    Private Sub cmdCapturar_Click(sender As Object, e As EventArgs) Handles cmdCapturar.Click
        web.CapturarCliente()
        web.ClosePreviewWindow()
        cmdcamara.Enabled = True
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        PicFoto.Image = Nothing
    End Sub

    Private Sub btnGuardarFotoBase_Click(sender As Object, e As EventArgs) Handles btnGuardarFotoBase.Click
        PicFoto.Image.Save("miFoto.jpg")
        Dim o As System.IO.FileStream
        Dim r As StreamReader
        Conexion.Open()

        Dim comando As New MySqlCommand("INSERT INTO foto(nombre,FOTO) values('" & txtNombre.Text & "',@FOTO)", Conexion)
        o = New FileStream("mifoto.jpg", FileMode.Open, FileAccess.Read, FileShare.Read)
        r = New StreamReader(o)
        Dim FileByteArray(o.Length - 1) As Byte
        o.Read(FileByteArray, 0, o.Length)
        comando.Parameters.Add("@FOTO", System.Data.SqlDbType.Binary, o.Length).Value = FileByteArray
        comando.ExecuteNonQuery()
        Conexion.Close()
    End Sub

    Private Sub btnGuardarFotoArchivo_Click(sender As Object, e As EventArgs) Handles btnGuardarFotoArchivo.Click
        Try
            Dim sFD As New SaveFileDialog
            sFD.Title = "Guardar Imagen"
            sFD.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp"
            If sFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.PicFoto.Image.Save(System.IO.Path.GetFullPath(sFD.FileName))
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LlenarGrid()
        Conexion.Open()
        Dim da As New MySqlDataAdapter("Select * from foto where nombre like'%" & txtBuscar.Text & "%'", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If
        Conexion.Close()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.RowCount > 0 Then
            Conexion.Open()
            Dim da As New MySqlDataAdapter("select * from foto where idFoto=" & DataGridView1.CurrentRow.Cells("idFoto").Value, Conexion)
            Dim ds As New DataSet
            da.Fill(ds)

            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim bytBLOBData() As Byte =
                    ds.Tables(0).Rows(c - 1)("FOTO")
                Dim stmBLOBData As New MemoryStream(bytBLOBData)
                PicFoto.Image = Image.FromStream(stmBLOBData)
            End If

            txtNombre.Text = DataGridView1.CurrentRow.Cells("nombre").Value.ToString
        End If
        Conexion.Close()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        LlenarGrid()
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        OpenFileDialog1.InitialDirectory = "C: \Users\exeq\Imagenes"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormMail.ShowDialog()
    End Sub







    'Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
    '    If txtEscalaPixel.Text.Trim = "" Then
    '        MsgBox("Debe indicar la escala de los píxeles del " +
    '               "QR que se generará.",
    '               MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
    '        txtEscalaPixel.Focus()
    '    Else

    '        If Val(txtEscalaPixel.Text) = 0 Then
    '            txtEscalaPixel.Text = 4
    '        End If

    'End Sub

    'Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If cbPatologia.Text = "Si" Then
    '        FormNyAclientes.Show()
    '    End If

    'End Sub
End Class