Imports System.Data.SqlClient
Public Class AddManager

    Dim strConexion As String = "Data source = localhost;Initial Catalog=Assets;Integrated Security=true"
    Public connection As New SqlConnection(strConexion)

    Public Sub InsertManager(manager As Manager)

        Dim cmdInsertManager As New SqlCommand
        cmdInsertManager = New SqlCommand("INSERT INTO Manager(Description, IdUser)" & _
                                   "VALUEs(@Description, @IdUser)", connection)

        With cmdInsertManager

            .Parameters.AddWithValue("@Description", manager.Description_Manager)
            .Parameters.AddWithValue("@IdUser", manager.User_Manager.Id_User)
            '.Parameters.AddWithValue("@IdLeader", 2)

        End With

        'la conexion con base de datos se abre aca

        connection.Open()
        cmdInsertManager.ExecuteNonQuery()
        connection.Close()

        MsgBox("Gerente ingresado con éxito")

    End Sub

    Private Sub AddManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadUsersInComboBox()

    End Sub

    Private Sub LoadUsersInComboBox()

        'la conexion con base de datos se abre aca
        connection.Open()
        Dim sqlQueryToGetLeaders As String
        sqlQueryToGetLeaders = "SELECT Id, Name FROM Users"
        Using command As SqlCommand = New SqlCommand(sqlQueryToGetLeaders, connection)

            Dim dataReader As SqlDataReader = command.ExecuteReader
            Dim dataTable As DataTable = New DataTable
            dataTable.Load(dataReader)

            cbxChoseUser.ValueMember = "Id"
            cbxChoseUser.DisplayMember = "Name"
            cbxChoseUser.DataSource = dataTable

        End Using

        connection.Close()


    End Sub

    Private Sub btnCancelManager_Click(sender As Object, e As EventArgs) Handles btnCancelManager.Click

        Me.Hide()
        Home.Show()

    End Sub

    Private Sub btnAddManager_Click(sender As Object, e As EventArgs) Handles btnAddManager.Click

        Dim manager As New Manager()        
        manager.Description_Manager = txbDescriptionManager.Text

        Dim user As New User
        user.Id_User = cbxChoseUser.SelectedValue
        user.Name_User = cbxChoseUser.Text.ToString

        'Asociamos departamento con el usuario seleccionado en el ComboBox 
        manager.User_Manager = user

        InsertManager(manager)

        Me.Hide()
        AddDepartament.Show()

    End Sub
End Class