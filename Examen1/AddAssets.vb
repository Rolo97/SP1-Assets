Imports System.Data.SqlClient
Public Class AddAssets

    Dim strConexion As String = "Data source = localhost;Initial Catalog=Assets;Integrated Security=true"
    Public connection As New SqlConnection(strConexion)

    Public Sub InsertAssets(assets As Assets)

        Dim cmdInsertD As New SqlCommand
        cmdInsertD = New SqlCommand("INSERT INTO Assets(Nombre, Color, Descripción, Serie, Marca, Modelo, Condición, Departamento)" & _
                                   "VALUEs(@Nombre, @Color, @Descripción, @Serie, @Marca, @Modelo, @Condición, @Departamento)", connection)

        With cmdInsertD

            .Parameters.AddWithValue("@Nombre", assets.Name_Assets)
            .Parameters.AddWithValue("@Color", assets.Color_Assets)
            .Parameters.AddWithValue("@Descripción", assets.Description_Assets)
            .Parameters.AddWithValue("@Serie", assets.Serial_Assets)
            .Parameters.AddWithValue("@Marca", assets.Brand_Assets)
            .Parameters.AddWithValue("@Modelo", assets.Model_Assets)
            .Parameters.AddWithValue("@Condición", assets.Condition_Assets)
            .Parameters.AddWithValue("@Departamento", assets.Departament_Assets)


            '.Parameters.AddWithValue("@IdLeader", 2)


        End With

        'la conexion con base de datos se abre aca

        connection.Open()
        cmdInsertD.ExecuteNonQuery()
        connection.Close()

        MsgBox("Bien institucional ingresado con éxito")

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

            cbxDepartament.ValueMember = "Id"
            cbxDepartament.DisplayMember = "Description"
            cbxDepartament.DataSource = dataTable

        End Using

        connection.Close()


    End Sub

    Private Sub AddAssets_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadLeadersInComboBox()

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs)

        Dim Assets As New Assets()
        Assets.Name_Assets = txbName.Text
        Assets.Description_Assets = txbDescription.Text

        Dim departament As New Departament
        departament.Id_Departament = cbxDepartament.SelectedValue
        departament.Description_Departament = cbxDepartament.SelectedValue

        'Asociamos departamento con el lider seleccionado en el ComboBox 
        Assets.Departament_Assets = departament

        InsertAssets(Assets)

        Me.Hide()
        TableOfAssets.Show()
    End Sub
End Class