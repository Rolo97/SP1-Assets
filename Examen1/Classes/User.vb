Public Class User

    Private name As String
    Private userName As String
    Private id As Integer
    Private idNumber As Integer
    Private age As Integer
    Private sex As String
    Private phoneNumber As String
    Private email As String
    Private password As String

    Public Property Id_User() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property
    Public Property Name_User() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property

    Public Property UserName_User() As String
        Get
            Return userName
        End Get
        Set(ByVal value As String)
            userName = value
        End Set
    End Property

    Public Property IdNumber_User() As Integer
        Get
            Return idNumber
        End Get
        Set(ByVal value As Integer)
            idNumber = value
        End Set
    End Property

    Public Property Age_User() As Integer
        Get
            Return age
        End Get
        Set(ByVal value As Integer)
            age = value
        End Set
    End Property

    Public Property Sex_User() As String
        Get
            Return sex
        End Get
        Set(ByVal value As String)
            sex = value
        End Set
    End Property

    Public Property PhoneNumber_User() As String
        Get
            Return phoneNumber
        End Get
        Set(ByVal value As String)
            phoneNumber = value
        End Set
    End Property

    Public Property Email_User() As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property

    Public Property Password_User() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property

End Class




