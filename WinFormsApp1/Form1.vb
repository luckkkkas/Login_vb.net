Imports System.Security.Cryptography.X509Certificates
Imports System.Xml
Imports MySql.Data.MySqlClient


Public Class telaLogin

    Dim connectionString As String = "Server=srv1078.hstgr.io;Database=u224972953_teste_php;Uid=u224972953_root;Pwd=Skoi7617@;"

    Function Validar_Usuario(user_name) As Boolean
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim command As New MySqlCommand("SELECT * FROM users", connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            For Each readers In reader
                Dim sql_table_user = readers("nome").ToString()
                If sql_table_user = user_name Then
                    Return True
                End If
            Next
            Return False
            reader.Close()
        End Using
    End Function

    Function Validar_senha(pass) As Boolean
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim command As New MySqlCommand("SELECT sobrenome FROM users WHERE nome = 'Lucas'", connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            For Each passes In reader
                Dim pass_table_user = reader("sobrenome").ToString()

                If pass_table_user = pass Then
                    Return True
                End If
            Next
            Return False
        End Using
    End Function

    Function Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If TextBox2.Text = Nothing Or TextBox1.Text.Trim() = Nothing Then
            Return MsgBox("Insira usuário e senha")
            Exit Function
        End If

        If Validar_Usuario(TextBox1.Text) And Validar_senha(TextBox2.Text) Then
            Return MsgBox("voce logou")
            Exit Function
        End If
        Return MsgBox("usuário ou senha inválidos")
    End Function

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Form2.ShowDialog()
    End Sub
End Class
