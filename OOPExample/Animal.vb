Public Class Animal
    'properties-----------------
    Private _skinType As String
    Public Property skinType() As String
        Get
            Return _skinType
        End Get
        Set(ByVal value As String)
            _skinType = value
        End Set
    End Property


    Private _movement As String
    Public Property movement() As String
        Get
            Return _movement
        End Get
        Set(ByVal value As String)
            _movement = value
        End Set
    End Property


    Private _vocalization As String
    Public Property vocalization() As String
        Get
            Return _vocalization
        End Get
        Set(ByVal value As String)
            _vocalization = value
        End Set
    End Property

    'fields---------------------

    'Dim movement As String

    Sub New()
        Me.movement = "Animals can move... except sponges..."
        Me.skinType = "IDK if sponges have skin..."
    End Sub
    Sub move()
        Console.WriteLine(Me.movement)
    End Sub

    Sub speak()
        Console.WriteLine(Me.vocalization)
    End Sub

End Class
