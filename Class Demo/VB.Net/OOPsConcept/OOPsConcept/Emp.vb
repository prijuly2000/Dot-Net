'MustInherit for abstract class
Public MustInherit Class Emp
    Dim name As String
    Dim eid As Integer
    Protected basic As Double
    'new keyword is used to create constructor
    Public Sub New()
        name = ""
        eid = 0
        basic = 0
    End Sub
    Public Sub New(ByVal e As Integer, ByVal nm As String,
                   ByVal bs As Double)
        name = nm
        eid = e
        basic = bs
    End Sub
    'Overridable is used in place of virtual
    Public Overridable Sub Display()
        Console.WriteLine("Name=" + name)
        Console.WriteLine("Eid=" + eid.ToString())
        Console.WriteLine("Basic=" + basic.ToString())
    End Sub


    'Public Overridable Function CalSal() As Double
    '    Return basic
    'End Function

    'Mustoverride in place of Abstract
    Public MustOverride Function CalSal() As Double

End Class
