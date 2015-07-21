Imports Microsoft.VisualBasic
Public Class Assets


    Private id As Integer
    Private name As String
    Private color As String
    Private description As String
    Private serial As String
    Private brand As String
    Private model As String
    Private condition As String
    Private departament As Departament

    Public Sub New()

        departament = New Departament()

    End Sub

    Public Property Id_Assets() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Public Property Name_Assets() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property
    Public Property Color_Assets() As String
        Get
            Return Color
        End Get
        Set(ByVal value As String)
            Color = value
        End Set
    End Property

    Public Property Description_Assets() As String
        Get
            Return description
        End Get
        Set(ByVal value As String)
            description = value
        End Set
    End Property

    Public Property Serial_Assets() As Int32
        Get
            Return serial
        End Get
        Set(ByVal value As Int32)
            serial = value
        End Set
    End Property
    Public Property Brand_Assets() As String
        Get
            Return Brand
        End Get
        Set(ByVal value As String)
            Brand = value
        End Set
    End Property
    Public Property Model_Assets() As String
        Get
            Return Model
        End Get
        Set(ByVal value As String)
            Model = value
        End Set
    End Property
    Public Property Condition_Assets() As String
        Get
            Return Condition
        End Get
        Set(ByVal value As String)
            Condition = value
        End Set
    End Property

    Public Property Departament_Assets() As Departament
        Get
            Return departament
        End Get
        Set(ByVal value As Departament)
            departament = value
        End Set
    End Property




End Class
