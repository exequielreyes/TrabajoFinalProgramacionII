Imports MySql.Data.MySqlClient
'Imports System.Runtime.InteropServices

Public Class FormInicio
    Public Property clienteDataAdapter As New MySqlDataAdapter
    Public Property turnoDataAdapter As New MySqlDataAdapter
    Public Property historiaclinicaDataAdapter As New MySqlDataAdapter
    Public Property mydbDataSet As New DataSet
    '<DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    'Private Shared Sub ReleaseCapture()
    'End Sub

    '<DllImport("user32.DLL", EntryPoint:="SendMessage")>
    'Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    'End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mydbDataSet.Tables.Add("cliente")
        mydbDataSet.Tables.Add("turno")

        mydbDataSet.Tables.Add("historia clinica")
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        FormListadoClientes.Show()
        'AbrirFormEnPanel(New FormListadoClientes)
    End Sub
    Private Sub btnAsistencias_Click(sender As Object, e As EventArgs) Handles btnAsistencias.Click

        FormAsis.ShowDialog()
        'AbrirFormEnPanel(New FormAsis)
    End Sub
    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        End
    End Sub

    'Private Sub Panel3_MouseHover(sender As Object, e As EventArgs)
    '    Panel3.Size = New Size(112, 97)
    'End Sub

    'Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs)
    '    Panel3.Size = New Size(109, 94)
    'End Sub

    'Private Sub Panel4_MouseHover(sender As Object, e As EventArgs)
    '    Panel4.Size = New Size(112, 110)
    'End Sub

    'Private Sub Panel4_MouseLeave(sender As Object, e As EventArgs)
    '    Panel4.Size = New Size(109, 107)
    'End Sub

    'Private Sub Panel5_MouseHover(sender As Object, e As EventArgs)
    '    Panel5.Size = New Size(142, 98)
    'End Sub

    'Private Sub Panel5_MouseLeave(sender As Object, e As EventArgs)
    '    Panel5.Size = New Size(139, 95)

    'End Sub

    'Private Sub Panel5_MouseClick(sender As Object, e As MouseEventArgs)
    '    Me.Close()
    'End Sub

    'Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs)
    '    FormListadoClientes.ShowDialog()
    'End Sub

    'Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs)
    '    FormAsistencia.ShowDialog()
    'End Sub

    Public Sub tmOcultar_Tick(sender As Object, e As EventArgs) Handles tmOcultar.Tick
        If Panel2.Width <= 60 Then
            Me.tmOcultar.Enabled = False
        Else
            Me.Panel2.Width = Panel2.Width - 20
        End If
    End Sub

    Public Sub tmMostrar_Tick(sender As Object, e As EventArgs) Handles tmMostrar.Tick
        If Panel2.Width >= 220 Then
            Me.tmMostrar.Enabled = False
        Else
            Me.Panel2.Width = Panel2.Width + 20
        End If
    End Sub

    Public Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If Panel2.Width = 220 Then
            tmOcultar.Enabled = True
        ElseIf Panel2.Width = 60 Then
            tmMostrar.Enabled = True
        End If
    End Sub
    'Public Sub AbrirFormEnPanel(ByVal Formhijo As Object)
    '    If Me.pnContenedor.Controls.Count > 0 Then
    '        Me.pnContenedor.Controls.RemoveAt(0)
    '    End If
    '    Dim fh As Form = TryCast(Formhijo, Form)
    '    fh.TopLevel = False
    '    fh.FormBorderStyle = FormBorderStyle.None
    '    fh.Dock = DockStyle.Fill
    '    Me.pnContenedor.Controls.Add(fh)
    '    Me.pnContenedor.Tag = fh
    '    fh.Show()
    'End Sub

End Class
