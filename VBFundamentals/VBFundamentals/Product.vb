Public Class Product

    Sub New()
        StandardCost = 500
        ListPrice = 900
        SellStartDate = DateTime.Now
    End Sub


    Public Property IsActive As Boolean

    Public Property Name As String

    Public Property ProductNumber As String

    Public Property StandardCost As Decimal

    Public Property ListPrice As Decimal

    Public Property Size As String

    Public Property Weight As Decimal

    Public Property SellStartDate As DateTime

    Public Property SellEndDate As DateTime

    Function CalculateSellEndDate(ByVal days As Integer) As DateTime
        SellEndDate = SellStartDate.AddDays(days)

        Return SellEndDate
    End Function

    Overloads Function CalculateProfit() As Decimal
        Return CalculateProfit(StandardCost)
    End Function


    Overloads Function CalculateProfit(ByVal newCost As Decimal)
        If newCost <> 0 Then
            StandardCost = newCost
        End If

        Return ListPrice - StandardCost
    End Function



End Class

