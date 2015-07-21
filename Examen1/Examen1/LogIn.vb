Imports System.Data.SqlClient
Public Class logIn
    Dim connection As SqlConnection = CreateUser.connection
    Private Sub btnGoCreateUser_Click(sender As Object, e As EventArgs) Handles btnGoCreateUser.Click

        Me.Hide()
        CreateUser.Show()

    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        connection.Open()
        Dim sqlQueryToVerifyName As String
        sqlQueryToVerifyName = "SELECT Name, Password FROM TableUsers"
        Using command As SqlCommand = New SqlCommand(sqlQueryToVerifyName, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader
            Dim dataTable As DataTable = New DataTable
            dataTable.Load(dataReader)

            User.Name_User
            User.Password_User
            connection.Close()

        End Using

    End Sub
End Class
