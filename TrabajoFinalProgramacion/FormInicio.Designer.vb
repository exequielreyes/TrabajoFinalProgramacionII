<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicio
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnAsistencias = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.tmOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.pnContenedor = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.TrabajoFinalProgramacion.My.Resources.Resources.Panel
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.bSalir)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.btnAsistencias)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.btnMenu)
        Me.Panel2.Controls.Add(Me.btnClientes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(220, 461)
        Me.Panel2.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel4.Location = New System.Drawing.Point(0, 334)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 44)
        Me.Panel4.TabIndex = 10
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.Color.Transparent
        Me.bSalir.FlatAppearance.BorderSize = 0
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.Font = New System.Drawing.Font("Castellar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.ForeColor = System.Drawing.Color.White
        Me.bSalir.Image = Global.TrabajoFinalProgramacion.My.Resources.Resources.Cancel241
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(16, 334)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(204, 44)
        Me.bSalir.TabIndex = 9
        Me.bSalir.Text = "SALIR"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(419, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GIMNASIO PILATES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.BackgroundImage = Global.TrabajoFinalProgramacion.My.Resources.Resources.asistencia
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel7.ForeColor = System.Drawing.Color.Transparent
        Me.Panel7.Location = New System.Drawing.Point(12, 248)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(40, 44)
        Me.Panel7.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel6.Location = New System.Drawing.Point(0, 248)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 44)
        Me.Panel6.TabIndex = 7
        '
        'btnAsistencias
        '
        Me.btnAsistencias.BackColor = System.Drawing.Color.Transparent
        Me.btnAsistencias.FlatAppearance.BorderSize = 0
        Me.btnAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencias.Font = New System.Drawing.Font("Castellar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsistencias.ForeColor = System.Drawing.Color.White
        Me.btnAsistencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsistencias.Location = New System.Drawing.Point(0, 248)
        Me.btnAsistencias.Name = "btnAsistencias"
        Me.btnAsistencias.Size = New System.Drawing.Size(220, 44)
        Me.btnAsistencias.TabIndex = 6
        Me.btnAsistencias.Text = "       ASISTENCIAS"
        Me.btnAsistencias.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Location = New System.Drawing.Point(0, 167)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 44)
        Me.Panel1.TabIndex = 5
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.Image = Global.TrabajoFinalProgramacion.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnMenu.Location = New System.Drawing.Point(189, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(28, 39)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMenu.TabIndex = 4
        Me.btnMenu.TabStop = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.Transparent
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Castellar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Image = Global.TrabajoFinalProgramacion.My.Resources.Resources.clientes
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 167)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(220, 44)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "   CLIENTES"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'tmOcultar
        '
        '
        'tmMostrar
        '
        '
        'pnContenedor
        '
        Me.pnContenedor.BackColor = System.Drawing.Color.Transparent
        Me.pnContenedor.Location = New System.Drawing.Point(223, 0)
        Me.pnContenedor.Name = "pnContenedor"
        Me.pnContenedor.Size = New System.Drawing.Size(1000, 500)
        Me.pnContenedor.TabIndex = 4
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrabajoFinalProgramacion.My.Resources.Resources.fondo_azul_blue_cuadros_fotorecurso
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.pnContenedor)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FormInicio"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents tmOcultar As Timer
    Friend WithEvents tmMostrar As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAsistencias As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents bSalir As Button
    Friend WithEvents pnContenedor As Panel
End Class
