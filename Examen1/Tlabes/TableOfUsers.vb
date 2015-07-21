Imports System.Data.SqlClient
Public Class TableOfUsers
    Dim dataTableUsers As New DataTable
    Dim connection As SqlConnection = CreateUser.connection
    Private Sub TableOfUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillDataGridView()

    End Sub

    Public Function CreateDataTable() As DataTable

        dataTableUsers = New DataTable
        dataTableUsers.Columns.Add("Name")
        dataTableUsers.Columns.Add("UserName")
        dataTableUsers.Columns.Add("IdNumber")
        dataTableUsers.Columns.Add("Age")
        dataTableUsers.Columns.Add("Sex")
        dataTableUsers.Columns.Add("Phone")
        dataTableUsers.Columns.Add("Email")
        dataTableUsers.Columns.Add("Password")

        CreateDataTable = dataTableUsers

    End Function

    Public Sub FillDataGridView()

        dataTableUsers = CreateDataTable()
        Dim usersGridView As List(Of User)

        usersGridView = ListOfUsers()

        Dim row As DataRow

        For index = 0 To usersGridView.Count - 1

            row = dataTableUsers.NewRow
            row("Name") = usersGridView(index).Name_User
            row("UserName") = usersGridView(index).Name_User
            row("IdNumber") = usersGridView(index).IdNumber_User
            row("Age") = usersGridView(index).Age_User
            row("Sex") = usersGridView(index).Sex_User
            row("Phone") = usersGridView(index).PhoneNumber_User
            row("Email") = usersGridView(index).Email_User
            row("Password") = usersGridView(index).Password_User
            'añadimos una fila al total de filas del datatable que se muestra en el gridview
            dataTableUsers.Rows.Add(row)

        Next

        Me.dgvTableUsers.DataSource = dataTableUsers

    End Sub

    Public Function ListOfUsers() As List(Of User)

        Dim commandUsers As SqlCommand
        commandUsers = New SqlCommand("SELECT Name, UserName, IdNumber, Age, Sex, Phone, Email, Password FROM  Users", connection)

        connection.Open()
        Dim readerOfUsers As SqlDataReader = commandUsers.ExecuteReader()
        Dim usersList As New List(Of User)
        Dim user As New User
        'Itera mientras haya filas
        Do While readerOfUsers.HasRows
            'Itera en cada fila
            Do While readerOfUsers.Read()

                user = New User
                user.Name_User = readerOfUsers.GetString(0)
                user.Name_User = readerOfUsers.GetString(1)
                user.IdNumber_User = readerOfUsers.GetString(2)
                If readerOfUsers.GetSqlInt32(3).IsNull = False Then
                    user.Age_User = readerOfUsers.GetInt32(3)
                End If

                user.Sex_User = readerOfUsers.GetString(4)
                user.PhoneNumber_User = readerOfUsers.GetString(5)
                user.Email_User = readerOfUsers.GetString(6)
                user.Password_User = readerOfUsers.GetString(7)


                usersList.Add(user)

            Loop

            readerOfUsers.NextResult()

        Loop

        ListOfUsers = usersList
        connection.Close()

    End Function

    Public Sub Modify(ByVal user As User)

        Dim cmdUpdate As New SqlCommand
        Dim id As String, name As String, userName As String, idNumber As Integer, age As Integer, sex As String, phoneNumber As String, email As String, password As String
        id = InputBox("Ingrese el id: ")
        name = InputBox("Ingrese el nombre: ")
        userName = InputBox("Ingrese el UserName ")
        idNumber = CInt(InputBox("Ingrese su identificacion "))
        age = CInt(InputBox("Ingrese su edad: "))
        sex = InputBox("Ingrese su sexo ")
        phoneNumber = InputBox("Ingrese su telefono: ")
        email = InputBox("Ingrese su correo ")
        password = InputBox("Ingrese su contraseña ")

        Dim identifier As Integer = dgvTableUsers.Item(0, row).Value

        cmdUpdate = New SqlCommand("update Course set " & _
                               "id = @id, " & _
                               "name = @name, " & _
                               "userName = @userName, " & _
                               "idNumber = @idNumber, " & _
                               "age = @age, " & _
                               "sex = @sex " & _
                               "phoneNumber = @phoneNumber " & _
                               "email = @email " & _
                               "password = @password " & _
                               "where identifier = " & identifier, connection)

        With cmdUpdate

            .Parameters.AddWithValue("@id", id)
            .Parameters.AddWithValue("@name", name)
            .Parameters.AddWithValue("@userName", userName)
            .Parameters.AddWithValue("@idNumber", idNumber)
            .Parameters.AddWithValue("@age", age)
            .Parameters.AddWithValue("@sex", sex)
            .Parameters.AddWithValue("@phoneNumber", phoneNumber)
            .Parameters.AddWithValue("@email", email)
            .Parameters.AddWithValue("@password", password)

        End With

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        Update()
        connection.Close()
        MessageBox.Show("Usuario modificado con éxito!")


    End Sub


    Public Sub Delete()

        Dim cmdUpdate As New SqlCommand
        Dim identifier As Integer = dgvTableUsers.Item(0, row).Value

        cmdUpdate = New SqlCommand("Delete from Users " & _
                               "where identifier = " & identifier, connection)

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        Update()
        connection.Close()
        MessageBox.Show("Usuario eliminado con éxito!")


    End Sub


End Class