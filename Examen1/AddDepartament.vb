Imports System.Data.SqlClient

Public Class AddDepartament

    Dim strConexion As String = "Data source = localhost;Initial Catalog=Assets;Integrated Security=true"
    Public connection As New SqlConnection(strConexion)

    Public Sub InsertDepartament(departament As Departament)

        Dim cmdInsertD As New SqlCommand
        cmdInsertD = New SqlCommand("INSERT INTO Departament(Name, Description, IdManager)" & _
                                   "VALUEs(@Name, @Description, @IdManager)", connection)

        With cmdInsertD

            .Parameters.AddWithValue("@Name", departament.Name_Departament)
            .Parameters.AddWithValue("@Description", departament.Description_Departament)
            .Parameters.AddWithValue("@IdManager", departament.Manager_Departament.Id_Manager)
            '.Parameters.AddWithValue("@IdLeader", 2)


        End With

        'la conexion con base de datos se abre aca

        connection.Open()
        cmdInsertD.ExecuteNonQuery()
        connection.Close()

        MsgBox("Departamento ingresado con éxito")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadLeadersInComboBox()

    End Sub

    Private Sub LoadLeadersInComboBox()

        'la conexion con base de datos se abre aca
        connection.Open()
        Dim sqlQueryToGetLeaders As String
        sqlQueryToGetLeaders = "SELECT Id, Description FROM Manager"
        Using command As SqlCommand = New SqlCommand(sqlQueryToGetLeaders, connection)

            Dim dataReader As SqlDataReader = command.ExecuteReader
            Dim dataTable As DataTable = New DataTable
            dataTable.Load(dataReader)

            cbxManager.ValueMember = "Id"
            cbxManager.DisplayMember = "Description"
            cbxManager.DataSource = dataTable

        End Using

        connection.Close()


    End Sub

    Private Sub btnDepartament_Click(sender As Object, e As EventArgs) Handles btnDepartament.Click

        Dim departament As New Departament()
        departament.Name_Departament = txbName.Text
        departament.Description_Departament = txbDescription.Text

        Dim manager As New Manager
        manager.Id_Manager = cbxManager.SelectedValue

        manager.User_Manager = cbxManager.DisplayMember()

        'Asociamos departamento con el lider seleccionado en el ComboBox 
        departament.Manager_Departament = manager

        InsertDepartament(departament)

        Me.Hide()
        TableOfDepartament.Show()

    End Sub
End Class
