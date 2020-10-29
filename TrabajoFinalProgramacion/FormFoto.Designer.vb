<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFoto
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
        Me.spContenedor = New System.Windows.Forms.SplitContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTomar = New System.Windows.Forms.Button()
        Me.VideoSourcePlayer1 = New AForge.Controls.VideoSourcePlayer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.spContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spContenedor.Panel1.SuspendLayout()
        Me.spContenedor.Panel2.SuspendLayout()
        Me.spContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'spContenedor
        '
        Me.spContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spContenedor.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.spContenedor.Location = New System.Drawing.Point(0, 0)
        Me.spContenedor.Name = "spContenedor"
        Me.spContenedor.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spContenedor.Panel1
        '
        Me.spContenedor.Panel1.Controls.Add(Me.VideoSourcePlayer1)
        Me.spContenedor.Panel1.Controls.Add(Me.Button2)
        Me.spContenedor.Panel1.Controls.Add(Me.Button1)
        Me.spContenedor.Panel1.Controls.Add(Me.ComboBox1)
        Me.spContenedor.Panel1.Controls.Add(Me.Label1)
        Me.spContenedor.Panel1MinSize = 100
        '
        'spContenedor.Panel2
        '
        Me.spContenedor.Panel2.Controls.Add(Me.btnTomar)
        Me.spContenedor.Panel2MinSize = 50
        Me.spContenedor.Size = New System.Drawing.Size(800, 448)
        Me.spContenedor.SplitterDistance = 393
        Me.spContenedor.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(418, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Detener"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Iniciar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(304, 9)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(228, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(233, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Camara:"
        '
        'btnTomar
        '
        Me.btnTomar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTomar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTomar.Location = New System.Drawing.Point(0, 0)
        Me.btnTomar.Name = "btnTomar"
        Me.btnTomar.Size = New System.Drawing.Size(800, 51)
        Me.btnTomar.TabIndex = 0
        Me.btnTomar.Text = "Tomar Foto"
        Me.btnTomar.UseVisualStyleBackColor = True
        '
        'VideoSourcePlayer1
        '
        Me.VideoSourcePlayer1.Location = New System.Drawing.Point(151, 61)
        Me.VideoSourcePlayer1.Name = "VideoSourcePlayer1"
        Me.VideoSourcePlayer1.Size = New System.Drawing.Size(518, 330)
        Me.VideoSourcePlayer1.TabIndex = 14
        Me.VideoSourcePlayer1.Text = "VideoSourcePlayer1"
        Me.VideoSourcePlayer1.VideoSource = Nothing
        '
        'FormFoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 448)
        Me.Controls.Add(Me.spContenedor)
        Me.Name = "FormFoto"
        Me.Text = "FormFoto"
        Me.spContenedor.Panel1.ResumeLayout(False)
        Me.spContenedor.Panel1.PerformLayout()
        Me.spContenedor.Panel2.ResumeLayout(False)
        CType(Me.spContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents spContenedor As SplitContainer
    Private WithEvents btnTomar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents VideoSourcePlayer1 As AForge.Controls.VideoSourcePlayer
    Friend WithEvents Timer1 As Timer
End Class
