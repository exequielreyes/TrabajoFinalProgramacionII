﻿Imports System.Net.Mail
Public Class FormMail
    Private Sub FormMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        enviarCorreo(CBMotivo.Text, "softwaresbe@gmail.com", "Hola1234!", RichTextBox1.Text, TbAsunto.Text, TbPara.Text, Tbrutaarchivo.Text)
    End Sub

    Private Sub btnAdjuntarArchivo_Click(sender As Object, e As EventArgs) Handles btnAdjuntarArchivo.Click

        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                Tbrutaarchivo.Text = Me.OpenFileDialog1.FileName
                PbArchivo.Visible = True
                lblArchivoCargado.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class