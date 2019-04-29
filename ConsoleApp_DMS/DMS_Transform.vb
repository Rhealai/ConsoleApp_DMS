Public Class DMS_Transform
    Private iDegree As Integer
    Private iMinute As Integer
    Private sglSecond As Single
    Private sglResolution As Single = 10000
    Private sglPosition As Single

    Public Property Resolution() As Single
        Get
            Return sglResolution
        End Get
        Set(ByVal value As Single)
            sglResolution = value
        End Set
    End Property

    Public Property Position() As Single
        Get
            Return sglPosition
        End Get
        Set(ByVal value As Single)
            sglPosition = value
        End Set
    End Property

    Public ReadOnly Property Degree() As Integer
        Get
            iDegree = Math.Floor(sglPosition / sglResolution * 360)
            Return iDegree
        End Get
    End Property

    Public ReadOnly Property Minute() As Integer
        Get
            iMinute = Math.Floor((sglPosition / sglResolution * 360) * 60 - iDegree * 60)
            Return iMinute
        End Get
    End Property

    Public ReadOnly Property Second() As Single
        Get
            sglSecond = (sglPosition / sglResolution * 360) * 60 * 60 - iDegree * 3600 - iMinute * 60
            If (sglSecond < 0.001) Then
                sglSecond = 0
            End If
            Return sglSecond
        End Get
    End Property




End Class
