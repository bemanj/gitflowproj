Public Class EmployeeBase
    Private _lastName As String
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property

    Sub AddEmployee()
        MsgBox("New Employee added")
    End Sub

End Class
