Public Class GPACalculator

    Private _bolMale As Boolean
    Private _bolFemale As Boolean
    Private _decSelectedGPA As Decimal
    Private _decMaleGPA As Decimal
    Private _decFemaleGPA As Decimal
    Private _decTotalGPA As Decimal

    Public Property Male As Boolean
        Get
            Return _bolMale = False
        End Get
        Set(value As Boolean)
            If value = True Then
                _bolMale = True
            Else
                _bolMale = False
            End If
        End Set
    End Property

    Public Property Female As Boolean
        Get
            Return _bolFemale = False
        End Get
        Set(value As Boolean)
            If value = True Then
                _bolFemale = True
            Else
                _bolFemale = False
            End If
        End Set
    End Property

    Public Property SelectedGPA As Decimal
        Get
            Return _decSelectedGPA
        End Get
        Set(value As Decimal)
            If value > 0 Then
                _decSelectedGPA = value
            Else
                _decSelectedGPA = 0
            End If
        End Set
    End Property

    Public Sub New()

        _bolMale = False
        _bolFemale = False
        _decSelectedGPA = 0
        _decMaleGPA = 0
        _decFemaleGPA = 0
        _decTotalGPA = 0

    End Sub
    Public Sub Clear()

        _bolMale = False
        _bolFemale = False
        _decSelectedGPA = 0
        _decMaleGPA = 0
        _decFemaleGPA = 0
        _decTotalGPA = 0

    End Sub

    Public Function GetMaleGPA() As Decimal

        If _bolMale = True Then
            _decMaleGPA = 
        End If

    End Function

    Public Function GetFemaleGPA() As Decimal


    End Function

    Public Function GetCombinedGPA() As Decimal


    End Function

End Class
