Imports System.Data.SqlClient
Public Class logIn
    Dim connection As SqlConnection = CreateUser.connection
    Private Sub btnGoCreateUser_Click(sender As Object, e As EventArgs) Handles btnGoCreateUser.Click

        Me.Hide()
        CreateUser.Show()

    End Sub

    Private Sub btnLogIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogIn.Click

        If comprobarUsuario(Me.txbUser.Text, Me.txbPassword.Text) Then
            Me.DialogResult = DialogResult.OK
            Me.Hide()
            Home.Show()
        End If
   
    End Sub

    Private Function comprobarUsuario(ByVal userName As String, ByVal password As String) As Boolean



        Dim strConexion As String = "Data source = localhost;Initial Catalog=Assets;Integrated Security=true"
        Dim connection As SqlConnection = New SqlConnection(strConexion)
        Dim result As Boolean

        Try
            connection.Open()

            Dim commandUsers As SqlCommand = New SqlCommand("SELECT UserName FROM Users where UserName like '" & userName & "' and Password like '" & password & "'", connection)

            Dim readerOfUsers As SqlDataReader = commandUsers.ExecuteReader()

            If readerOfUsers.HasRows Then

                readerOfUsers.Read()
                MessageBox.Show("Bienvenido " + readerOfUsers.GetString(0))
                result = True


            Else
                MessageBox.Show("Credenciales incorrectas")
                result = False
            End If

            connection.Close()

        Catch ex As Exception
            MessageBox.Show("ERROR al conectar a la base de datos: " & vbCrLf & _
                        ex.Message, "Comprobar usuario", MessageBoxButtons.OK, _
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        Finally
            If Not connection Is Nothing Then
                connection.Dispose()
            End If
        End Try

        Return result
    End Function

    Private Sub logIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
