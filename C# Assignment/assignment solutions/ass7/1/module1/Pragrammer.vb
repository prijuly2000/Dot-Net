Public Class Pragrammer
    Inherits Emp

    Dim extraHrs As Integer
    Dim costPerHr As Integer

    Public Sub New()
        MyBase.New()
        extraHrs = 0
        costPerHr = 0

    End Sub

    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal basic As Double, ByVal e As Integer, ByVal c As Integer)
        MyBase.New(id, name, basic)
        extraHrs = e
        costPerHr = c

    End Sub

    Public Overrides Sub display()
        MyBase.display()
        Console.WriteLine("Exra Hours:" + extraHrs.ToString())
        Console.WriteLine("Cost Per Hour:" + costPerHr.ToString())
    End Sub

    Public Overrides Function calsal() As Double
        Return MyBase.basic + costPerHr * extraHrs
    End Function

End Class
