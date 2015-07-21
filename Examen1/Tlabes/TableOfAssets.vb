Imports System.Data.SqlClient
Public Class TableOfAssets

    Dim dataTableAssets As New DataTable
    Dim connection As SqlConnection = AddAssets.connection

    Private Sub TableOfAssets_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillDataGridView()

    End Sub

    Public Function CreateDataTable() As DataTable

        dataTableAssets = New DataTable
        dataTableAssets.Columns.Add("Nombre")
        dataTableAssets.Columns.Add("Color")
        dataTableAssets.Columns.Add("Descripción")
        dataTableAssets.Columns.Add("Serie")
        dataTableAssets.Columns.Add("Marca")
        dataTableAssets.Columns.Add("Modelo")
        dataTableAssets.Columns.Add("Condción")
        dataTableAssets.Columns.Add("Departamento")


        CreateDataTable = dataTableAssets

    End Function

    Public Sub FillDataGridView()

        dataTableAssets = CreateDataTable()
        Dim AssetsGridView As List(Of Assets)

        AssetsGridView = ListOfAssets()

        Dim row As DataRow

        For index = 0 To AssetsGridView.Count - 1

            row = dataTableAssets.NewRow
            row("Nombre") = AssetsGridView(index).Name_Assets
            row("Color") = AssetsGridView(index).Color_Assets
            row("Descripción") = AssetsGridView(index).Description_Assets
            row("Serie") = AssetsGridView(index).Serial_Assets
            row("Marca") = AssetsGridView(index).Brand_Assets
            row("Modelo") = AssetsGridView(index).Model_Assets
            row("Condción") = AssetsGridView(index).Condition_Assets
            row("Departamento") = AssetsGridView(index).Departament_Assets




            'añadimos una fila al total de filas del datatable que se muestra en el gridview
            dataTableAssets.Rows.Add(row)

        Next

        Me.dgvAssets.DataSource = dataTableAssets

    End Sub

    Public Function ListOfAssets() As List(Of Assets)

        Dim commandAssets As SqlCommand
        commandAssets = New SqlCommand("SELECT D.Name, D.Description, M.User FROM  Departament D, Manager M WHERE D.IdManager=M.Id", connection)

        connection.Open()
        Dim readerOfAssets As SqlDataReader = commandAssets.ExecuteReader()
        Dim AssetsList As New List(Of Assets)
        Dim Assets As New Assets
        'Itera mientras haya filas
        Do While readerOfAssets.HasRows
            'Itera en cada fila
            Do While readerOfAssets.Read()

                Assets = New Assets
                Assets.Name_Assets = readerOfAssets.GetString(0)
                Assets.Color_Assets = readerOfAssets.GetString(1)
                Assets.Description_Assets = readerOfAssets.GetString(2)
                Assets.Serial_Assets = readerOfAssets.GetInt32(3)
                Assets.Brand_Assets = readerOfAssets.GetString(4)
                Assets.Model_Assets = readerOfAssets.GetString(5)
                Assets.Condition_Assets = readerOfAssets.GetString(6)
                Assets.Departament_Assets = readerOfAssets.GetInt32(7)

                AssetsList.Add(Assets)

            Loop

            readerOfAssets.NextResult()

        Loop

        ListOfAssets = AssetsList
        connection.Close()

    End Function
    Public Sub Modify(ByVal user As User)

        Dim cmdUpdate As New SqlCommand
        Dim name As String, color As String, Description As String, serial As Integer, Brand As Integer, Model As String, Condition As String, Departament As String
        name = InputBox("Ingrese el nombre: ")
        color = InputBox("Ingrese el color")
        Description = InputBox("Ingrese la descripcion ")
        serial = CInt(InputBox("Ingrese la serie "))
        Brand = CInt(InputBox("Ingrese la marca: "))
        Model = InputBox("Ingrese el modelo: ")
        Condition = InputBox("Ingrese la condición ")
        Departament = InputBox("Ingrese el departamento:")


        Dim identifier As Integer = dgvAssets.Item(0, row).Value

        cmdUpdate = New SqlCommand("update Course set " & _
                               "name = @name, " & _
                               "color = @color" & _
                               "Description = @Description, " & _
                               "serial = @Serial, " & _
                               "Brand = @Brand, " & _
                               "Model = @Model " & _
                               "Conditión= @Conditión " & _
                               "Departament= @Departament " & _
                               "where identifier = " & identifier, connection)

        With cmdUpdate

            .Parameters.AddWithValue("@name", name)
            .Parameters.AddWithValue("@color", color)
            .Parameters.AddWithValue("@Description", Description)
            .Parameters.AddWithValue("@Serial", serial)
            .Parameters.AddWithValue("@Brand", Brand)
            .Parameters.AddWithValue("@Model", Model)
            .Parameters.AddWithValue("@phoneNumber", Condition)
            .Parameters.AddWithValue("@Departament", Departament)


        End With

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        Update()
        connection.Close()
        MessageBox.Show("Usuario modificado con éxito!")


    End Sub


    Public Sub Delete()

        Dim cmdUpdate As New SqlCommand
        Dim identifier As Integer = dgvAssets.Item(0, row).Value

        cmdUpdate = New SqlCommand("Delete from Users " & _
                               "where identifier = " & identifier, connection)

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        Update()
        connection.Close()
        MessageBox.Show("Usuario eliminado con éxito!")


    End Sub
End Class