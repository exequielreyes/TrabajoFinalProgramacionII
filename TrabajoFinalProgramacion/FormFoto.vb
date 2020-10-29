Imports AForge.Video.DirectShow
Imports BarcodeLib.BarcodeReader
Public Class FormFoto
    Private dispositivos As FilterInfoCollection
    Private fuenteVideo As VideoCaptureDevice
    Private Sub FormFoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dispositivos = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each x As FilterInfo In dispositivos
            ComboBox1.Items.Add(x.Name)
        Next
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Start()
        fuenteVideo = New VideoCaptureDevice(dispositivos(ComboBox1.SelectedIndex).MonikerString)
        VideoSourcePlayer1.VideoSource = fuenteVideo
        VideoSourcePlayer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        VideoSourcePlayer1.Stop()
    End Sub

    Private Sub btnTomar_Click(sender As Object, e As EventArgs) Handles btnTomar.Click

        'DIALOGO PARA SELECCIONAR LA RUTA PARA GUARDAR
        Dim sf As New SaveFileDialog()
        'FILTO DE IMAGENES JPG
        sf.Filter = "Imagenes JPG | *.jpg"
        'MOSTRAR DIALOGO
        sf.ShowDialog()
        'ASEGURAR QUE TIENE UNA RUTA VALIDA
        If sf.FileName IsNot Nothing Then
            'VARIBALE PARA LA IMAGEN
            Dim img As Bitmap = VideoSourcePlayer1.GetCurrentVideoFrame()
            'GUARDAR IMAGEN EN LA RUTA
            img.Save(sf.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            'BORRAR IMAGEN DE MEMORIA
            img.Dispose()
            'PROBAR!!!
        End If
    End Sub
End Class