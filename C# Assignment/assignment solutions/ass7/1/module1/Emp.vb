Public MustInherit Class Emp
    Dim id As Integer
    Dim name As String
    Protected basic As Double

    Public Sub New()
        id = 0
        name = ""
        basic = 0
    End Sub

    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal basic As Double)
        Me.id = id
        Me.name = name
        Me.basic = basic
    End Sub

    Public Overridable Sub display()
        Console.WriteLine("Id:" + id.ToString())
        Console.WriteLine("Name:" + name)
        Console.WriteLine("Basic:" + basic.ToString())
    End Sub

    Public MustOverride Function calsal() As Double

End Class
