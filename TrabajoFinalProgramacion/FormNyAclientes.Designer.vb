<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNyAclientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNyAclientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMeses = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTurno = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbSemanaCuatro = New System.Windows.Forms.RadioButton()
        Me.rbsemanaTres = New System.Windows.Forms.RadioButton()
        Me.RbsemanaDos = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvListado2 = New System.Windows.Forms.DataGridView()
        Me.tbHora = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.dgvListado3 = New System.Windows.Forms.DataGridView()
        Me.cbPatologia = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbColumna = New System.Windows.Forms.CheckBox()
        Me.cbLesiones = New System.Windows.Forms.CheckBox()
        Me.cbCardiaco = New System.Windows.Forms.CheckBox()
        Me.rbEspecificar = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.dgvListado4 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListado2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvListado3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvListado4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(477, 665)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pbFoto)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.lblTotal)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cbMeses)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.cbTurno)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.rbSemanaCuatro)
        Me.TabPage1.Controls.Add(Me.rbsemanaTres)
        Me.TabPage1.Controls.Add(Me.RbsemanaDos)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.dgvListado2)
        Me.TabPage1.Controls.Add(Me.tbHora)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.dtpFechaInicio)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.lblPrecio)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.tbApellido)
        Me.TabPage1.Controls.Add(Me.tbNombre)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(469, 639)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Turnos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pbFoto
        '
        Me.pbFoto.BackgroundImage = CType(resources.GetObject("pbFoto.BackgroundImage"), System.Drawing.Image)
        Me.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFoto.InitialImage = Nothing
        Me.pbFoto.Location = New System.Drawing.Point(254, 14)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(181, 153)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 47
        Me.pbFoto.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(16, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 25)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Cliente"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTotal.Location = New System.Drawing.Point(313, 343)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(44, 20)
        Me.lblTotal.TabIndex = 45
        Me.lblTotal.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(268, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Precio total a pagar"
        '
        'cbMeses
        '
        Me.cbMeses.FormattingEnabled = True
        Me.cbMeses.Items.AddRange(New Object() {"1 mes", "2 meses", "3 meses"})
        Me.cbMeses.Location = New System.Drawing.Point(10, 278)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Size = New System.Drawing.Size(121, 21)
        Me.cbMeses.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(6, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Turno"
        '
        'cbTurno
        '
        Me.cbTurno.FormattingEnabled = True
        Me.cbTurno.Items.AddRange(New Object() {"Mañana", "Tarde", "Noche"})
        Me.cbTurno.Location = New System.Drawing.Point(10, 219)
        Me.cbTurno.Name = "cbTurno"
        Me.cbTurno.Size = New System.Drawing.Size(121, 21)
        Me.cbTurno.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(6, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Cantidad de clases"
        '
        'rbSemanaCuatro
        '
        Me.rbSemanaCuatro.AutoSize = True
        Me.rbSemanaCuatro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSemanaCuatro.ForeColor = System.Drawing.SystemColors.Highlight
        Me.rbSemanaCuatro.Location = New System.Drawing.Point(10, 385)
        Me.rbSemanaCuatro.Name = "rbSemanaCuatro"
        Me.rbSemanaCuatro.Size = New System.Drawing.Size(150, 20)
        Me.rbSemanaCuatro.TabIndex = 39
        Me.rbSemanaCuatro.TabStop = True
        Me.rbSemanaCuatro.Text = "4 veces a la semana"
        Me.rbSemanaCuatro.UseVisualStyleBackColor = True
        '
        'rbsemanaTres
        '
        Me.rbsemanaTres.AutoSize = True
        Me.rbsemanaTres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbsemanaTres.ForeColor = System.Drawing.SystemColors.Highlight
        Me.rbsemanaTres.Location = New System.Drawing.Point(10, 359)
        Me.rbsemanaTres.Name = "rbsemanaTres"
        Me.rbsemanaTres.Size = New System.Drawing.Size(150, 20)
        Me.rbsemanaTres.TabIndex = 38
        Me.rbsemanaTres.TabStop = True
        Me.rbsemanaTres.Text = "3 veces a la semana"
        Me.rbsemanaTres.UseVisualStyleBackColor = True
        '
        'RbsemanaDos
        '
        Me.RbsemanaDos.AutoSize = True
        Me.RbsemanaDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbsemanaDos.ForeColor = System.Drawing.SystemColors.Highlight
        Me.RbsemanaDos.Location = New System.Drawing.Point(10, 333)
        Me.RbsemanaDos.Name = "RbsemanaDos"
        Me.RbsemanaDos.Size = New System.Drawing.Size(150, 20)
        Me.RbsemanaDos.TabIndex = 37
        Me.RbsemanaDos.TabStop = True
        Me.RbsemanaDos.Text = "2 veces a la semana"
        Me.RbsemanaDos.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(292, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvListado2
        '
        Me.dgvListado2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvListado2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListado2.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.dgvListado2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListado2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListado2.ColumnHeadersHeight = 25
        Me.dgvListado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListado2.EnableHeadersVisualStyles = False
        Me.dgvListado2.GridColor = System.Drawing.Color.DarkCyan
        Me.dgvListado2.Location = New System.Drawing.Point(3, 411)
        Me.dgvListado2.MultiSelect = False
        Me.dgvListado2.Name = "dgvListado2"
        Me.dgvListado2.ReadOnly = True
        Me.dgvListado2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvListado2.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListado2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado2.Size = New System.Drawing.Size(463, 127)
        Me.dgvListado2.TabIndex = 34
        '
        'tbHora
        '
        Me.tbHora.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbHora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHora.Location = New System.Drawing.Point(292, 282)
        Me.tbHora.Multiline = True
        Me.tbHora.Name = "tbHora"
        Me.tbHora.Size = New System.Drawing.Size(109, 23)
        Me.tbHora.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label16.Location = New System.Drawing.Point(288, 259)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 20)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Hora"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(292, 219)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(143, 20)
        Me.dtpFechaInicio.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label15.Location = New System.Drawing.Point(288, 196)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 20)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Fecha de inicio"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Location = New System.Drawing.Point(6, 254)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 20)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Meses"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblPrecio.Location = New System.Drawing.Point(184, 281)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 27
        Me.lblPrecio.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(141, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Precio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(6, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Apellido"
        '
        'tbApellido
        '
        Me.tbApellido.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbApellido.Enabled = False
        Me.tbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido.Location = New System.Drawing.Point(10, 124)
        Me.tbApellido.Multiline = True
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(205, 23)
        Me.tbApellido.TabIndex = 23
        '
        'tbNombre
        '
        Me.tbNombre.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNombre.Enabled = False
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(10, 75)
        Me.tbNombre.Multiline = True
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(205, 23)
        Me.tbNombre.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(6, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(16, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 25)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Turno"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rbEspecificar)
        Me.TabPage2.Controls.Add(Me.cbCardiaco)
        Me.TabPage2.Controls.Add(Me.cbLesiones)
        Me.TabPage2.Controls.Add(Me.cbColumna)
        Me.TabPage2.Controls.Add(Me.bGuardar)
        Me.TabPage2.Controls.Add(Me.dgvListado3)
        Me.TabPage2.Controls.Add(Me.cbPatologia)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(469, 639)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Patologias"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'bGuardar
        '
        Me.bGuardar.Location = New System.Drawing.Point(194, 336)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(75, 23)
        Me.bGuardar.TabIndex = 36
        Me.bGuardar.Text = "Button2"
        Me.bGuardar.UseVisualStyleBackColor = True
        '
        'dgvListado3
        '
        Me.dgvListado3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvListado3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListado3.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.dgvListado3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListado3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListado3.ColumnHeadersHeight = 25
        Me.dgvListado3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListado3.EnableHeadersVisualStyles = False
        Me.dgvListado3.GridColor = System.Drawing.Color.DarkCyan
        Me.dgvListado3.Location = New System.Drawing.Point(3, 365)
        Me.dgvListado3.MultiSelect = False
        Me.dgvListado3.Name = "dgvListado3"
        Me.dgvListado3.ReadOnly = True
        Me.dgvListado3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado3.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgvListado3.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListado3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado3.Size = New System.Drawing.Size(463, 142)
        Me.dgvListado3.TabIndex = 35
        '
        'cbPatologia
        '
        Me.cbPatologia.FormattingEnabled = True
        Me.cbPatologia.Items.AddRange(New Object() {"Si", "No"})
        Me.cbPatologia.Location = New System.Drawing.Point(12, 50)
        Me.cbPatologia.Name = "cbPatologia"
        Me.cbPatologia.Size = New System.Drawing.Size(121, 21)
        Me.cbPatologia.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(8, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Especificar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(8, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Patologia"
        '
        'cbColumna
        '
        Me.cbColumna.AutoSize = True
        Me.cbColumna.Enabled = False
        Me.cbColumna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbColumna.Location = New System.Drawing.Point(12, 77)
        Me.cbColumna.Name = "cbColumna"
        Me.cbColumna.Size = New System.Drawing.Size(87, 20)
        Me.cbColumna.TabIndex = 40
        Me.cbColumna.Text = "Columna"
        Me.cbColumna.UseVisualStyleBackColor = True
        '
        'cbLesiones
        '
        Me.cbLesiones.AutoSize = True
        Me.cbLesiones.Enabled = False
        Me.cbLesiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLesiones.Location = New System.Drawing.Point(12, 129)
        Me.cbLesiones.Name = "cbLesiones"
        Me.cbLesiones.Size = New System.Drawing.Size(158, 20)
        Me.cbLesiones.TabIndex = 41
        Me.cbLesiones.Text = "Lesiones recientes"
        Me.cbLesiones.UseVisualStyleBackColor = True
        '
        'cbCardiaco
        '
        Me.cbCardiaco.AutoSize = True
        Me.cbCardiaco.Enabled = False
        Me.cbCardiaco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCardiaco.Location = New System.Drawing.Point(12, 103)
        Me.cbCardiaco.Name = "cbCardiaco"
        Me.cbCardiaco.Size = New System.Drawing.Size(90, 20)
        Me.cbCardiaco.TabIndex = 42
        Me.cbCardiaco.Text = "Cardiaco"
        Me.cbCardiaco.UseVisualStyleBackColor = True
        '
        'rbEspecificar
        '
        Me.rbEspecificar.Location = New System.Drawing.Point(12, 202)
        Me.rbEspecificar.Name = "rbEspecificar"
        Me.rbEspecificar.Size = New System.Drawing.Size(434, 115)
        Me.rbEspecificar.TabIndex = 43
        Me.rbEspecificar.Text = ""
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvListado4)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.TextBox3)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(469, 639)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Datos clinicos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Altura"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Grupo sanguineo"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(13, 160)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Peso"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(13, 107)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 4
        '
        'dgvListado4
        '
        Me.dgvListado4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvListado4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListado4.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.dgvListado4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListado4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListado4.ColumnHeadersHeight = 25
        Me.dgvListado4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListado4.EnableHeadersVisualStyles = False
        Me.dgvListado4.GridColor = System.Drawing.Color.DarkCyan
        Me.dgvListado4.Location = New System.Drawing.Point(0, 201)
        Me.dgvListado4.MultiSelect = False
        Me.dgvListado4.Name = "dgvListado4"
        Me.dgvListado4.ReadOnly = True
        Me.dgvListado4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado4.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvListado4.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvListado4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado4.Size = New System.Drawing.Size(463, 142)
        Me.dgvListado4.TabIndex = 36
        '
        'FormNyAclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 570)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormNyAclientes"
        Me.Text = "FormNyAclientes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListado2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvListado3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvListado4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbHora As TextBox
    Friend WithEvents Label16 As Label
    Private WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents dgvListado2 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvListado3 As DataGridView
    Friend WithEvents cbPatologia As ComboBox
    Friend WithEvents bGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents rbSemanaCuatro As RadioButton
    Friend WithEvents rbsemanaTres As RadioButton
    Friend WithEvents RbsemanaDos As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents cbTurno As ComboBox
    Friend WithEvents cbMeses As ComboBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Private WithEvents pbFoto As PictureBox
    Friend WithEvents rbEspecificar As RichTextBox
    Friend WithEvents cbCardiaco As CheckBox
    Friend WithEvents cbLesiones As CheckBox
    Friend WithEvents cbColumna As CheckBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvListado4 As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
