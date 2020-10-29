Imports ThoughtWorks.QRCode
Imports ThoughtWorks.QRCode.Codec
Imports ThoughtWorks.QRCode.Codec.Data
Public Class FormEscritorio
    Private Sub btSelImagenQR_Click(sender As Object, e As EventArgs) Handles btSelImagenQR.Click
        Dim dlAbrirImagenQR As New OpenFileDialog

        dlAbrirImagenQR.InitialDirectory =
            My.Computer.FileSystem.SpecialDirectories.MyPictures
        dlAbrirImagenQR.Filter = "*.bmp;*.gif;*.jpg;*.png|*.bmp;*.gif;*.jpg;*.png"
        dlAbrirImagenQR.RestoreDirectory = True
        dlAbrirImagenQR.CheckFileExists = True
        dlAbrirImagenQR.CheckPathExists = True
        If dlAbrirImagenQR.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtLeerQRImagen.Text = dlAbrirImagenQR.FileName
        End If

    End Sub

    Private Sub btDecodificarImagenQR_Click(sender As Object, e As EventArgs) Handles btDecodificarImagenQR.Click
        If IsNothing(imgQRExistente.Image) Then
            MsgBox("Antes de decodificar una imagen QR a su texto " +
                   "correspondiente QR Code debe seleccionar la imagen.",
                   MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            btSelImagenQR.Focus()
        Else
            Try
                Dim decoder As QRCodeDecoder = New QRCodeDecoder
                If opLeerForzarUTF8.Checked Then
                    txtLeerQRTexto.Text =
                        decoder.decode(New QRCodeBitmapImage(
                                       New Bitmap(imgQRExistente.Image)),
                                   System.Text.Encoding.UTF8)
                Else
                    txtLeerQRTexto.Text =
                        decoder.decode(New QRCodeBitmapImage(
                                       New Bitmap(imgQRExistente.Image)))
                End If
            Catch ex As Exception
                MsgBox(ex.Message,
                       MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try
        End If

    End Sub

    Private Sub txtLeerQRImagen_TextChanged(sender As Object, e As EventArgs) Handles txtLeerQRImagen.TextChanged
        If System.IO.File.Exists(txtLeerQRImagen.Text) Then
            imgQRExistente.Image = New Bitmap(txtLeerQRImagen.Text)
        End If
    End Sub
End Class