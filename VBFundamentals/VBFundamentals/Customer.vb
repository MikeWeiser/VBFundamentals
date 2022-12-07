Public Class Customer
    Inherits CommonBase

    Sub New()
        MyBase.New()

        CustomerID = 1
    End Sub

    Public Property CustomerID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property CompanyName As String

    Overrides Function GetClassData() As String
        Dim sb As New Text.StringBuilder(1024)

        sb.AppendLine("CustomerID: " + CustomerID.ToString())
        sb.AppendLine("CompanyNam: " + CompanyName)
        sb.AppendLine("FirstName: " + FirstName)
        sb.AppendLine("LastName: " + LastName)

        sb.AppendLine(MyBase.GetClassData())

        Return sb.ToString()
    End Function

End Class
