﻿Public Class Product
    Inherits CommonBase

    Sub New()
        StandardCost = 500
        ListPrice = 900
        SellStartDate = DateTime.Now
    End Sub


    Public Property ProductID As Integer

    Public Property ProductName As String

    Public Property ProductNumber As String

    Public Property Color As String

    Public Property StandardCost As Decimal

    Public Property ListPrice As Decimal

    Public Property Size As String

    Public Property Weight As Decimal

    Public Property SellStartDate As DateTime

    Public Property SellEndDate As DateTime


    Shared Function CalculateTheProfit(ByVal cost As Decimal, ByVal price As Decimal) As Decimal
        Return price - cost
    End Function

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

    Function GetClassData() As String
        Dim sb As New Text.StringBuilder(1024)

        sb.AppendLine("ProductId: " + ProductID.ToString())
        sb.AppendLine("ProductName: " + ProductName)
        sb.AppendLine("ProductNumber: " + ProductNumber)
        ' below vars are from the CommonBase class
        sb.AppendLine("IsActive: " + IsActive.ToString())
        sb.AppendLine("ModifiedDate: " + ModifiedDate.ToString())
        sb.AppendLine("CreatedBy: " + CreatedBy)

        Return sb.ToString()
    End Function


End Class

