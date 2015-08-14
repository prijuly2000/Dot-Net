Public Class SalesMgr

    Inherits Emp
    Dim incentive As Integer


    Public Sub New()
        MyBase.New()
        incentive = 0
    End Sub
    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal basic As Double, ByVal incentive As Integer)
        MyBase.New(id, name, basic)
        Me.incentive = incentive

    End Sub
    Public Overrides Sub display()
        MyBase.display()
        Console.WriteLine("incentive=" + incentive.ToString())

    End Sub

    Public Overrides Function calsal() As Double
        Return (MyBase.basic + incentive)
    End Function
End Class
