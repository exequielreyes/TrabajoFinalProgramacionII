<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEscritorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEscritorio))
        Me.txtLeerQRImagen = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.opLeerForzarUTF8 = New System.Windows.Forms.CheckBox()
        Me.txtLeerQRTexto = New System.Windows.Forms.TextBox()
        Me.btDecodificarImagenQR = New System.Windows.Forms.Button()
        Me.imgQRExistente = New System.Windows.Forms.PictureBox()
        Me.btSelImagenQR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.imgQRExistente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLeerQRImagen
        '
        Me.txtLeerQRImagen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLeerQRImagen.Location = New System.Drawing.Point(141, 49)
        Me.txtLeerQRImagen.Name = "txtLeerQRImagen"
        Me.txtLeerQRImagen.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLeerQRImagen.Size = New System.Drawing.Size(174, 20)
        Me.txtLeerQRImagen.TabIndex = 29
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(138, 325)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(398, 13)
        Me.Label29.TabIndex = 28
        Me.Label29.Text = "Texto de la decodificación del código QR de la imagen seleccionada"
        '
        'opLeerForzarUTF8
        '
        Me.opLeerForzarUTF8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opLeerForzarUTF8.AutoSize = True
        Me.opLeerForzarUTF8.Checked = True
        Me.opLeerForzarUTF8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.opLeerForzarUTF8.Location = New System.Drawing.Point(374, 52)
        Me.opLeerForzarUTF8.Name = "opLeerForzarUTF8"
        Me.opLeerForzarUTF8.Size = New System.Drawing.Size(88, 17)
        Me.opLeerForzarUTF8.TabIndex = 14
        Me.opLeerForzarUTF8.Text = "Forzar UTF-8"
        Me.opLeerForzarUTF8.UseVisualStyleBackColor = True
        '
        'txtLeerQRTexto
        '
        Me.txtLeerQRTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLeerQRTexto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtLeerQRTexto.Location = New System.Drawing.Point(141, 342)
        Me.txtLeerQRTexto.Multiline = True
        Me.txtLeerQRTexto.Name = "txtLeerQRTexto"
        Me.txtLeerQRTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLeerQRTexto.Size = New System.Drawing.Size(412, 177)
        Me.txtLeerQRTexto.TabIndex = 5
        '
        'btDecodificarImagenQR
        '
        Me.btDecodificarImagenQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btDecodificarImagenQR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btDecodificarImagenQR.Image = CType(resources.GetObject("btDecodificarImagenQR.Image"), System.Drawing.Image)
        Me.btDecodificarImagenQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDecodificarImagenQR.Location = New System.Drawing.Point(468, 40)
        Me.btDecodificarImagenQR.Name = "btDecodificarImagenQR"
        Me.btDecodificarImagenQR.Size = New System.Drawing.Size(79, 35)
        Me.btDecodificarImagenQR.TabIndex = 4
        Me.btDecodificarImagenQR.Text = "&Leer QR"
        Me.btDecodificarImagenQR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btDecodificarImagenQR.UseVisualStyleBackColor = True
        '
        'imgQRExistente
        '
        Me.imgQRExistente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgQRExistente.BackColor = System.Drawing.Color.White
        Me.imgQRExistente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgQRExistente.Location = New System.Drawing.Point(141, 85)
        Me.imgQRExistente.Name = "imgQRExistente"
        Me.imgQRExistente.Size = New System.Drawing.Size(412, 224)
        Me.imgQRExistente.TabIndex = 3
        Me.imgQRExistente.TabStop = False
        '
        'btSelImagenQR
        '
        Me.btSelImagenQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelImagenQR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSelImagenQR.Image = CType(resources.GetObject("btSelImagenQR.Image"), System.Drawing.Image)
        Me.btSelImagenQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSelImagenQR.Location = New System.Drawing.Point(321, 40)
        Me.btSelImagenQR.Name = "btSelImagenQR"
        Me.btSelImagenQR.Size = New System.Drawing.Size(47, 39)
        Me.btSelImagenQR.TabIndex = 0
        Me.btSelImagenQR.Text = "..."
        Me.btSelImagenQR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSelImagenQR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(293, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Leer codigo QR"
        '
        'FormEscritorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 531)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLeerQRTexto)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtLeerQRImagen)
        Me.Controls.Add(Me.opLeerForzarUTF8)
        Me.Controls.Add(Me.imgQRExistente)
        Me.Controls.Add(Me.btDecodificarImagenQR)
        Me.Controls.Add(Me.btSelImagenQR)
        Me.Name = "FormEscritorio"
        Me.Text = "FormEscritorio"
        CType(Me.imgQRExistente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLeerQRImagen As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents opLeerForzarUTF8 As CheckBox
    Friend WithEvents txtLeerQRTexto As TextBox
    Friend WithEvents btDecodificarImagenQR As Button
    Friend WithEvents imgQRExistente As PictureBox
    Friend WithEvents btSelImagenQR As Button
    Friend WithEvents Label1 As Label
End Class
