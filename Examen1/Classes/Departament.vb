Imports Microsoft.VisualBasic

Public Class Departament

    Private name As String
    Private id As Integer
    Private description As String
    Private manager As Manager

    Public Sub New()

        manager = New Manager()

    End Sub

    Public Property Id_Departament() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Public Property Name_Departament() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property


    Public Property Description_Departament() As String
        Get
            Return description
        End Get
        Set(ByVal value As String)
            description = value
        End Set
    End Property


    Public Property Manager_Departament() As Manager
        Get
            Return Manager
        End Get
        Set(ByVal value As Manager)
            manager = value
        End Set
    End Property

End Class
