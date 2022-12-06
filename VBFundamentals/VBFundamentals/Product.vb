Public Class Product
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

End Class

