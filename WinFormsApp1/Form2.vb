Imports System.ComponentModel.Design
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Form2

    Dim conectar_banco_de_dados As String = "Server=srv1078.hstgr.io;Database=u224972953_teste_php;Uid=u224972953_root;Pwd=Skoi7617@;"
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCadastar.Click
        Using connection As New MySqlConnection(conectar_banco_de_dados)
            connection.Open()

            Dim command As New MySqlCommand("SELECT * FROM users;", connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            For Each readers In reader
                Dim ujugh = readers("nome")
                MsgBox(ujugh)
            Next
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class