﻿Imports MySql.Data.MySqlClient


Module ConexionBD

    Private miConexion As New MySqlConnection

    Public Sub Conectarse()
        Try
            miConexion.ConnectionString = "server=localhost;database=pilatesgym;user=root;password=exequielmumia;"
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Desconectarse()
        miConexion.Close()
    End Sub

    Public Function Conexion() As MySqlConnection
        Return miConexion
    End Function
End Module
