Imports System.Data.SqlClient
Public Class CreateUser

    Dim strConexion As String = "Data source = localhost;Initial Catalog=Assets;Integrated Security=true"
    Public connection As New SqlConnection(strConexion)

    Public Sub InsertUser(user As User)

        Dim cmdInsertUser As New SqlCommand
        cmdInsertUser = New SqlCommand("INSERT INTO Users(Name, UserName, IdNumber, Age, Sex, Phone, Email, Password)" & _
                                   "VALUES(@Name, @UserName, @IdNumber, @Age, @Sex, @Phone, @Email, @Password)", connection)

        With cmdInsertUser

            .Parameters.AddWithValue("@Name", user.Name_User)
            .Parameters.AddWithValue("@UserName", user.UserName_User)
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
        user.UserName_User = txbUserName.Text
        user.IdNumber_User = txbIdNumberUser.Text

        If txbAgeUser.Text.Equals("") Then

            user.Age_User = 0
        Else
            user.Age_User = Integer.Parse(txbAgeUser.Text)

        End If
        user.Sex_User = txbSexUser.Text
        user.PhoneNumber_User = txbPhoneNumberUser.Text
        user.Email_User = txbEmailUser.Text
        user.Password_User = txbPasswordUser.Text

        InsertUser(user)

        Me.Hide()
        logIn.Show()

    End Sub

    Private Sub btnCancelCreateUser_Click(sender As Object, e As EventArgs) Handles btnCancelCreateUser.Click

        Me.Hide()
        logIn.Show()

    End Sub
End Class