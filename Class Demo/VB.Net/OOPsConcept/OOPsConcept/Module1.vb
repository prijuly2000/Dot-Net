Module Module1

    Sub Display()
        Console.WriteLine("Display method is called")
    End Sub

    Sub Main1()

        'Use dim keyword for declaring variables        
        Console.WriteLine("Sum=" + Sum(10, 20).ToString())
    End Sub


    Function Sum(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function



    Sub Main2()
        'Dim e As New Emp()  'Ref and Object 
        'e.Display()

        Dim e As Emp  'Reference of Emp
        e = New Emp() ' Object of Emp
        e.Display()

        Dim p As Programmer
        p = New Programmer(101, "PPP", 10000, 100, 10)
        p.Display()
    End Sub

    Sub Main()
        Dim e As Emp
        e = New Programmer(101, "PPP", 10000, 100, 10)
        e.Display()
        Console.WriteLine("Total Salary=" + e.CalSal().ToString())
    End Sub

End Module
