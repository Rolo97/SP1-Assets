Imports System.Data.SqlClient
Public Class CreateUser

    Dim strConexion As String = "Data source = localhost;Initial Catalog=Assests;Integrated Security=true"
    Public connection As New SqlConnection(strConexion)

    Public Sub InsertUser(user As User)

        Dim cmdInsertUser As New SqlCommand
        cmdInsertUser = New SqlCommand("INSERT INTO TableUsers(Name, IdNumber, Age, Sex, Phone, Email, Password)" & _
                                   "VALUES(@Name, @IdNumber, @Age, @Sex, @Phone, @Email, @Password)", connection)

        With cmdInsertUser

            .Parameters.AddWithValue("@Name", user.Name_User)
            .Parameters.AddWithValue("@IdNumber", user.IdNumber_User)
            .Parameters.AddWithValue("@Age", user.Age_User)
            .Parameters.AddWithValue("@Sex", user.Sex_User)
            .Parameters.AddWithValue("@Phone", user.PhoneNumber_User)
            .Parameters.AddWithValue("@Email", user.Email_User)
            .Parameters.AddWithValue("@Password", user.Password_User)
        End With

        'la conexion con base de datos se abre aca

        connection.Open()
        cmdInsertUser.ExecuteNonQuery()
        connection.Close()

        MsgBox("Usuario ingresado con éxito")


    End Sub


    Private Sub CreateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click

        Dim user As New User()
        user.Name_User = txbNameUser.Text
        user.IdNumber_User = txbIdNumberUser.Text
        user.Age_User = txbAgeUser.Text
        user.Sex_User = txbSexUser.Text
        user.PhoneNumber_User = txbPhoneNumberUser.Text
        user.Email_User = txbEmailUser.Text
        user.Password_User = txbPasswordUser.Text

        InsertUser(user)

        Me.Hide()
        TableOfUsers.Show()

    End Sub

    Private Sub btnCancelCreateUser_Click(sender As Object, e As EventArgs) Handles btnCancelCreateUser.Click

        Me.Hide()
        logIn.Show()

    End Sub
End Class