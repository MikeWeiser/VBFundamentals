Imports System

Module MainModule
    Sub Main()

        Dim prod As New Product

        prod.StandardCost = 250
        prod.ListPrice = 500

        Console.WriteLine(prod.CalculateProfit())    '250
        Console.WriteLine(prod.CalculateProfit(700))  '-200

        Console.ReadKey()
    End Sub
End Module
