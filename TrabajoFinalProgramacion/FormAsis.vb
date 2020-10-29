Public Class FormAsis
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormEscritorio.ShowDialog()
        'FormInicio.AbrirFormEnPanel(New FormEscritorio)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormAsistencia.ShowDialog()
        'FormInicio.AbrirFormEnPanel(New FormAsistencia)
    End Sub
End Class