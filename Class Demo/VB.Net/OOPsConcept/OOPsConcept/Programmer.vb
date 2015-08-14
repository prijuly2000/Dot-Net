Public Class Programmer
    Inherits Emp
    Dim extraHrs As Integer
    Dim costPerHrs As Double
    Public Sub New()
        MyBase.New()  'MyBase keyword is used to refer to base class
        extraHrs = 0
        costPerHrs = 0
    End Sub

    Public Sub New(ByVal e As Integer, ByVal nm As String,
                   ByVal bs As Double, ByVal eh As Integer,
                   ByVal costPerHrs As Double)
        MyBase.New(e, nm, bs)
        extraHrs = eh
        Me.costPerHrs = costPerHrs
        'Me is used in place of this keyword
    End Sub
    'Function hiding is known as shadowing 
    Public Overrides Sub Display()
        MyBase.Display()
        Console.WriteLine("Extra Hrs=" + extraHrs.ToString())
        Console.WriteLine("Cost Per Hrs=" + costPerHrs.ToString())
    End Sub

    Public Overrides Function CalSal() As Double
        Return basic + extraHrs * costPerHrs
    End Function


End Class
