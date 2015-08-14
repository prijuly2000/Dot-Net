Module Module1


    Sub Main()
        Dim e1 As New Pragrammer(1, "p", 100, 3, 100)
        e1.display()
        Console.WriteLine("Calsal: " + e1.calsal().ToString())
        Console.WriteLine()

        Dim e2 As New Admin(2, "q", 200, 200)
        e2.display()
        Console.WriteLine("calsal:" + e2.calsal().ToString())
        Console.WriteLine()

        Dim e3 As New SalesMgr(3, "r", 300, 300)
        e3.display()
        Console.WriteLine("calsal:" + e3.calsal().ToString())
        Console.ReadLine()

    End Sub

End Module
