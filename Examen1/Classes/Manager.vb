Imports Microsoft.VisualBasic

Public Class Manager


    Private id As Integer
    Private description As String
    Private user As User

    Public Sub New()

        user = New User()

    End Sub

    Public Property Id_Manager() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Public Property Description_Manager() As String
        Get
            Return description
        End Get
        Set(ByVal value As String)
            description = value
        End Set
    End Property

    Public Property User_Manager() As User
        Get
            Return user
        End Get
        Set(ByVal value As User)
            user = value
        End Set
    End Property

End Class

