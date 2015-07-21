Imports System.Data.SqlClient

Public Class TableOfManagers
    Dim dataTableManager As New DataTable
    Dim connection As SqlConnection = AddManager.connection
    Private Sub dgvListOfManager_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListOfManager.CellContentClick

    End Sub

    Private Sub TableOfManagers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillDataGridView()

    End Sub

    Public Function CreateDataTable() As DataTable

        dataTableManager = New DataTable
       
        dataTableManager.Columns.Add("Descripción")
        dataTableManager.Columns.Add("idManager")
       


        CreateDataTable = dataTableManager

    End Function

    Public Sub FillDataGridView()

        dataTableManager = CreateDataTable()
        Dim ManagerGridView As List(Of Manager)

        ManagerGridView = ListOfManager()

        Dim row As DataRow

        For index = 0 To ManagerGridView.Count - 1

            row = dataTableManager.NewRow
           
            row("Descripción") = ManagerGridView(index).Description_Manager
            row("Encargado") = ManagerGridView(index).User_Manager

            



            'añadimos una fila al total de filas del datatable que se muestra en el gridview
            dataTableManager.Rows.Add(row)

        Next

        Me.dgvListOfManager.DataSource = dataTableManager

    End Sub

    Public Function ListOfManager() As List(Of Manager)

        Dim commandAssets As SqlCommand
        commandAssets = New SqlCommand("SELECT M.Description, M.IdManager", connection)

        connection.Open()
        Dim readerOfManager As SqlDataReader = commandAssets.ExecuteReader()
        Dim ManagerList As New List(Of Manager)
        Dim Manager As New Manager
        'Itera mientras haya filas
        Do While readerOfManager.HasRows
            'Itera en cada fila
            Do While readerOfManager.Read()

                Manager = New Manager
               
                Manager.Description_Manager = readerOfManager.GetString(2)
                Manager.User_Manager = readerOfManager.GetInt32(3)
               

                ManagerList.Add(Manager)

            Loop

            readerOfManager.NextResult()

        Loop

        ListOfManager = ManagerList
        connection.Close()

    End Function
    Public Sub Modify(ByVal user As Manager)

        Dim cmdUpdate As New SqlCommand
        Dim User_Manager As String, Description As String
        User_Manager = InputBox("Ingrese el Encargado: ")
        Description = InputBox("Ingrese la descripción: ")
        

        Dim identifier As Integer = dgvListOfManager.Item(0, row).Value

        cmdUpdate = New SqlCommand("update Course set " & _
                               "id = @id, " & _
                               "User_Manager = @User_Manager, " & _
                               "Descriptión = @Descriptión, " & _
                               "where identifier = " & identifier, connection)

        With cmdUpdate

            .Parameters.AddWithValue("@User_Manager", User_Manager)
            .Parameters.AddWithValue("@Descriptión", Description)
            
        End With

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        Update()
        connection.Close()
        MessageBox.Show("Usuario modificado con éxito!")


    End Sub


    Public Sub Delete()

        Dim cmdUpdate As New SqlCommand
        Dim identifier As Integer = dgvListOfManager.Item(0, row).Value

        cmdUpdate = New SqlCommand("Delete from Users " & _
                               "where identifier = " & identifier, connection)

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        Update()
        connection.Close()
        MessageBox.Show("Usuario eliminado con éxito!")


    End Sub

End Class
 