Imports System.Data.SqlClient
Public Class TableOfUsers
    Dim dataTableUsers As New DataTable
    Dim connection As SqlConnection = CreateUser.connection
    Private Sub TableOfUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillDataGridView()

    End Sub

    Public Function CreateDataTable() As DataTable

        dataTableUsers = New DataTable
        dataTableUsers.Columns.Add("Nombre")
        dataTableUsers.Columns.Add("Identificacion")
        dataTableUsers.Columns.Add("Edad")
        dataTableUsers.Columns.Add("Sexo")
        dataTableUsers.Columns.Add("Telefono")
        dataTableUsers.Columns.Add("Email")
        dataTableUsers.Columns.Add("Contraseña")

        CreateDataTable = dataTableUsers

    End Function

    Public Sub FillDataGridView()

        dataTableUsers = CreateDataTable()
        Dim usersGridView As List(Of User)

        usersGridView = ListOfUsers()

        Dim row As DataRow

        For index = 0 To usersGridView.Count - 1

            row = dataTableUsers.NewRow
            row("Nombre") = usersGridView(index).Name_User
            row("Identificacion") = usersGridView(index).IdNumber_User
            row("Edad") = usersGridView(index).Age_User
            row("Sexo") = usersGridView(index).Sex_User
            row("Telefono") = usersGridView(index).PhoneNumber_User
            row("Email") = usersGridView(index).Email_User
            row("Contraseña") = usersGridView(index).Password_User
            'añadimos una fila al total de filas del datatable que se muestra en el gridview
            dataTableUsers.Rows.Add(row)

        Next

        Me.dgvTableUsers.DataSource = dataTableUsers

    End Sub

    Public Function ListOfUsers() As List(Of User)

        Dim commandUsers As SqlCommand
        commandUsers = New SqlCommand("SELECT Name, Identificacion, Edad, Sexo, Telefono, Email, Contraseña FROM  TableUsers", connection)

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
                user.IdNumber_User = readerOfUsers.GetString(1)
                user.Age_User = readerOfUsers.GetString(3)
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


End Class