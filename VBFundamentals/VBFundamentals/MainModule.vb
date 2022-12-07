Imports System

Module MainModule
    Sub Main()
        Dim prod As New Product With {
            .ProductID = 700,
            .ProductName = "10 Speed Bike",
            .ProductNumber = "10-SP"
        }
        Console.WriteLine(prod.GetClassData())

        Dim cust As New Customer With {
        .CustomerID = 1,
        .CompanyName = "Beach Computer Consulting",
        .FirstName = "Bruce",
        .LastName = "Jones"
        }

        Console.WriteLine(cust.GetClassData())

        Console.ReadKey()
    End Sub
End Module
