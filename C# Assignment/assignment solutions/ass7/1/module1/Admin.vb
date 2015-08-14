Public Class Admin
    Inherits Emp
    Dim comm As Integer

    Public Sub New()
        MyBase.New()
        comm = 0
    End Sub

    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal basic As Double, ByVal comm As Integer)
        MyBase.New(id, name, basic)
        Me.comm = comm
    End Sub

    Public Overrides Sub display()
        MyBase.display()
        Console.WriteLine("Commission:" + comm.ToString())

    End Sub

    Public Overrides Function calsal() As Double
        Return (MyBase.basic + comm)
    End Function
End Class
