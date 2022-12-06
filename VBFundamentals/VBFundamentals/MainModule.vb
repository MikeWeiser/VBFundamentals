Imports System

Module MainModule
    Sub Main()

        Dim prod As New Product
        Dim sellDate As DateTime

        prod.SellStartDate = #5/1/2019#
        prod.CalculateSellEndDate(30, sellDate) 'adds 20 days to start date and assigns to SellEndDate

        Console.WriteLine(sellDate)

        Console.ReadKey()
    End Sub
End Module
