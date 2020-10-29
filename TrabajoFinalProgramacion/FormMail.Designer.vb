<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMail
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdjuntarArchivo = New System.Windows.Forms.Button()
        Me.lblArchivoCargado = New System.Windows.Forms.Label()
        Me.PbArchivo = New System.Windows.Forms.PictureBox()
        Me.Tbrutaarchivo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.CBMotivo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbPara = New System.Windows.Forms.TextBox()
        Me.TbAsunto = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PbArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(14, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Adjuntar:"
        '
        'btnAdjuntarArchivo
        '
        Me.btnAdjuntarArchivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdjuntarArchivo.Location = New System.Drawing.Point(89, 129)
        Me.btnAdjuntarArchivo.Name = "btnAdjuntarArchivo"
        Me.btnAdjuntarArchivo.Size = New System.Drawing.Size(36, 23)
        Me.btnAdjuntarArchivo.TabIndex = 54
        Me.btnAdjuntarArchivo.Text = ". . ."
        Me.btnAdjuntarArchivo.UseVisualStyleBackColor = True
        '
        'lblArchivoCargado
        '
        Me.lblArchivoCargado.AutoSize = True
        Me.lblArchivoCargado.Location = New System.Drawing.Point(150, 150)
        Me.lblArchivoCargado.Name = "lblArchivoCargado"
        Me.lblArchivoCargado.Size = New System.Drawing.Size(86, 13)
        Me.lblArchivoCargado.TabIndex = 53
        Me.lblArchivoCargado.Text = "Archivo Cargado"
        Me.lblArchivoCargado.Visible = False
        '
        'PbArchivo
        '
        Me.PbArchivo.Location = New System.Drawing.Point(166, 112)
        Me.PbArchivo.Name = "PbArchivo"
        Me.PbArchivo.Size = New System.Drawing.Size(50, 35)
        Me.PbArchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbArchivo.TabIndex = 52
        Me.PbArchivo.TabStop = False
        Me.PbArchivo.Visible = False
        '
        'Tbrutaarchivo
        '
        Me.Tbrutaarchivo.Location = New System.Drawing.Point(550, 140)
        Me.Tbrutaarchivo.Name = "Tbrutaarchivo"
        Me.Tbrutaarchivo.Size = New System.Drawing.Size(100, 20)
        Me.Tbrutaarchivo.TabIndex = 51
        Me.Tbrutaarchivo.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(286, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 43)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox1.BackColor = System.Drawing.Color.LavenderBlush
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 166)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(634, 229)
        Me.RichTextBox1.TabIndex = 49
        Me.RichTextBox1.Text = ""
        '
        'CBMotivo
        '
        Me.CBMotivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CBMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CBMotivo.FormattingEnabled = True
        Me.CBMotivo.Items.AddRange(New Object() {"[Notificacion]", "[Importante]", "[Urgente]"})
        Me.CBMotivo.Location = New System.Drawing.Point(89, 66)
        Me.CBMotivo.Name = "CBMotivo"
        Me.CBMotivo.Size = New System.Drawing.Size(122, 28)
        Me.CBMotivo.TabIndex = 48
        Me.CBMotivo.Text = "[Notificacion]"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(14, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Motivo:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Destinatario:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(244, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Asunto:"
        '
        'TbPara
        '
        Me.TbPara.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbPara.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbPara.Location = New System.Drawing.Point(130, 15)
        Me.TbPara.Name = "TbPara"
        Me.TbPara.Size = New System.Drawing.Size(272, 26)
        Me.TbPara.TabIndex = 44
        '
        'TbAsunto
        '
        Me.TbAsunto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbAsunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TbAsunto.Location = New System.Drawing.Point(341, 66)
        Me.TbAsunto.Name = "TbAsunto"
        Me.TbAsunto.Size = New System.Drawing.Size(178, 26)
        Me.TbAsunto.TabIndex = 43
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdjuntarArchivo)
        Me.Controls.Add(Me.lblArchivoCargado)
        Me.Controls.Add(Me.PbArchivo)
        Me.Controls.Add(Me.Tbrutaarchivo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.CBMotivo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbPara)
        Me.Controls.Add(Me.TbAsunto)
        Me.Name = "FormMail"
        Me.Text = "FormMail"
        CType(Me.PbArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdjuntarArchivo As Button
    Friend WithEvents lblArchivoCargado As Label
    Friend WithEvents PbArchivo As PictureBox
    Friend WithEvents Tbrutaarchivo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents CBMotivo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbPara As TextBox
    Friend WithEvents TbAsunto As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
