Public Class GPACalculator

    Private _bolMale As Boolean
    Private _bolFemale As Boolean
    Private _intMaleClicks As Integer
    Private _intFemaleClicks As Integer
    Private _decSelectedGPA As Decimal
    Private _decMaleGPA As Decimal
    Private _decFemaleGPA As Decimal
    Private _decTotalMaleGPABeforeAverage As Decimal
    Private _decTotalFemaleGPABeforeAverage As Decimal
    Private _decTotalGPA As Decimal
    Private _decTotalStudents As Decimal

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

    Public Property MaleClicks As Integer
        Get
            Return _intMaleClicks
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intMaleClicks = value
            Else
                _intMaleClicks = 0
            End If
        End Set
    End Property

    Public Property FemaleClicks As Integer
        Get
            Return _intFemaleClicks
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intFemaleClicks = value
            Else
                _intFemaleClicks = 0
            End If
        End Set
    End Property

    Public Sub New()

        _bolMale = False
        _bolFemale = False
        _intMaleClicks = 0
        _intFemaleClicks = 0
        _decSelectedGPA = 0
        _decMaleGPA = 0
        _decFemaleGPA = 0
        _decTotalMaleGPABeforeAverage = 0
        _decTotalFemaleGPABeforeAverage = 0
        _decTotalGPA = 0
        _decTotalStudents = 0

    End Sub
    Public Sub Clear()

        _bolMale = False
        _bolFemale = False
        _intMaleClicks = 0
        _intFemaleClicks = 0
        _decSelectedGPA = 0
        _decMaleGPA = 0
        _decFemaleGPA = 0
        _decTotalMaleGPABeforeAverage = 0
        _decTotalFemaleGPABeforeAverage = 0
        _decTotalGPA = 0
        _decTotalStudents = 0

    End Sub

    Public Function GetMaleGPA() As Decimal

        If _bolMale = True Then
            _decTotalMaleGPABeforeAverage = _decTotalMaleGPABeforeAverage + _decSelectedGPA
            _decMaleGPA = _decTotalMaleGPABeforeAverage / _intMaleClicks
        End If

        Return _decMaleGPA

    End Function

    Public Function GetFemaleGPA() As Decimal

        If _bolFemale = True Then
            _decTotalFemaleGPABeforeAverage = _decTotalFemaleGPABeforeAverage + _decSelectedGPA
            _decFemaleGPA = _decTotalFemaleGPABeforeAverage / _intFemaleClicks
        End If

        Return _decFemaleGPA

    End Function

    Public Function GetCombinedGPA() As Decimal

        Dim decClassTotalGPABeforeAverage As Decimal
        Dim decClassGPA As Decimal

        decClassTotalGPABeforeAverage = _decTotalMaleGPABeforeAverage + _decTotalFemaleGPABeforeAverage
        _decTotalStudents = _intMaleClicks + _intFemaleClicks

        decClassGPA = decClassTotalGPABeforeAverage / _decTotalStudents

        Return decClassGPA

    End Function

    Public Function GetNumOfTotalStudents()

        Return _decTotalStudents

    End Function

End Class
