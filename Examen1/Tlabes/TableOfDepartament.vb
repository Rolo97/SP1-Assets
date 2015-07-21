Imports System.Data.SqlClient

Public Class TableOfDepartament
    Dim dataTableDepartaments As New DataTable
    Dim connection As SqlConnection = AddDepartament.connection

    Private Sub TabladeDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillDataGridView()

    End Sub

    Public Function CreateDataTable() As DataTable

        dataTableDepartaments = New DataTable
        dataTableDepartaments.Columns.Add("Nombre")
        dataTableDepartaments.Columns.Add("Descripcion")
        dataTableDepartaments.Columns.Add("Gerente")

        CreateDataTable = dataTableDepartaments

    End Function

    Public Sub FillDataGridView()

        dataTableDepartaments = CreateDataTable()
        Dim departamentsGridView As List(Of Departament)

        departamentsGridView = ListOfDepartaments()

        Dim row As DataRow

        For index = 0 To departamentsGridView.Count - 1

            row = dataTableDepartaments.NewRow
            row("Nombre") = departamentsGridView(index).Name_Departament
            row("Descripcion") = departamentsGridView(index).Description_Departament
            row("Gerente") = departamentsGridView(index).Manager_Departament.User_Manager

            'añadimos una fila al total de filas del datatable que se muestra en el gridview
            dataTableDepartaments.Rows.Add(row)

        Next

        Me.dgvDepartamentsTable.DataSource = dataTableDepartaments

    End Sub

    Public Function ListOfDepartaments() As List(Of Departament)

        Dim commandDepartaments As SqlCommand
        commandDepartaments = New SqlCommand("SELECT D.Name, D.Description, M.User FROM  Departament D, Manager M WHERE D.IdManager=M.Id", connection)

        connection.Open()
        Dim readerOfDepartament As SqlDataReader = commandDepartaments.ExecuteReader()
        Dim departamentsList As New List(Of Departament)
        Dim departament As New Departament
        'Itera mientras haya filas
        Do While readerOfDepartament.HasRows
            'Itera en cada fila
            Do While readerOfDepartament.Read()

                departament = New Departament
                departament.Name_Departament = readerOfDepartament.GetString(0)
                departament.Description_Departament = readerOfDepartament.GetString(1)
                departament.Manager_Departament.User_Manager = readerOfDepartament.GetString(2)

                departamentsList.Add(departament)

            Loop

            readerOfDepartament.NextResult()

        Loop

        ListOfDepartaments = departamentsList
        connection.Close()

    End Function





    Public Sub Modify(ByVal user As Departament)

        Dim cmdUpdate As New SqlCommand
        Dim name As String, description As String, manager As String
        name = InputBox("Ingrese el nombre: ")
        description = InputBox("Ingrese la Descripción: ")
        manager = InputBox("Ingrese el Encargado ")
        
        Dim identifier As Integer = dgvDepartamentsTable.Item(0, row).Value

        cmdUpdate = New SqlCommand("update Course set " & _
                               "id = @id, " & _
                               "name = @name, " & _
                               "description = @description, " & _
                               "manager = @managerer, " & _
                               "where identifier = " & identifier, connection)

        With cmdUpdate


            .Parameters.AddWithValue("@name", name)
            .Parameters.AddWithValue("@description", description)
            .Parameters.AddWithValue("@manafer", manager)
            

        End With

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        Update()
        connection.Close()
        MessageBox.Show("Usuario modificado con éxito!")


    End Sub


    Public Sub Delete()

        Dim cmdUpdate As New SqlCommand
        Dim identifier As Integer = dgvDepartamentsTable.Item(0, row).Value

        cmdUpdate = New SqlCommand("Delete from Users " & _
                               "where identifier = " & identifier, connection)

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        Update()
        connection.Close()
        MessageBox.Show("Usuario eliminado con éxito!")


    End Sub



End Class